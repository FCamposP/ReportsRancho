using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Windows.Forms;
using XafReports.Module.BusinessObjects.Business;


namespace PrintSalesBPlus
{
    public partial class Form1 : Form
    {
        private int TiempoConsulta;
        private static Sucursal sucursal;
        Session session;
        List<TipoDocReporte> listaReportesDoc;
        public Form1()
        {
            session = new Session();

            InitializeComponent();
            timerVentas.Interval = 7000;
            timerReports.Interval = 7000;
            sucursal = session.Query<Sucursal>().Where(x => x.Oid == 1).FirstOrDefault();
            listaReportesDoc = new List<TipoDocReporte>();
            ConsultarReportes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerVentas.Start();

            timerReports.Start();
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            btnConfig.Enabled = false;
        }

        private void ConsultarReportes()
        {
            List<TipoDocumento> listaTipoDoc =
                            session.Query<TipoDocumento>().ToList();

            foreach (TipoDocumento tipoDoc in listaTipoDoc)
            {
                if (tipoDoc.NombreReporte.Length > 0)
                {
                    //Ir a traer el reporte y convertirlo en XtraReport para guardarlo
                    ReportDataV2 reportData = ObjectsPaceConnection.Session.FindObject<ReportDataV2>(
                        new BinaryOperator("DisplayName", tipoDoc.NombreReporte));
                    if (reportData == null)
                    {
                        XtraMessageBox.Show("No se encontro el reporte: " + tipoDoc.NombreReporte + " \n\r Del Tipo de Documento: " + tipoDoc.NombreReporte);
                        return;
                    }


                    if (reportData == null)
                    {
                        XtraMessageBox.Show("No se encontro el reporte: " + tipoDoc.NombreReporte + " \n\r Del Tipo de Documento: " + tipoDoc.NombreReporte);
                        return;
                    }

                    listaReportesDoc.Add(new TipoDocReporte()
                    {
                        TipoDoc = tipoDoc,
                        Reporte = reportData
                    });

                }
            }
        }

        public class TipoDocReporte
        {
            public TipoDocumento TipoDoc { get; set; }
            public ReportDataV2 Reporte { get; set; }
        }

        private void timerVentas_Tick(object sender, EventArgs e)
        {
            ConsultarVentasPendientes();
        }
        private void ConsultarVentasPendientes()
        {

            List<Venta> ventas = session.Query<Venta>().Where(v => null == v.Impreso || v.Impreso == false).Where(v => v.Turno.Usuario.Sucursal == sucursal)
                             .ToList();
            List<Venta> listaVacia = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                venta.Impreso = true;
                session.Save(venta);
                venta.FechaImpresion = DateTime.Now;
                List<Venta> dsVentas = new List<Venta>();
                dsVentas.Add(venta);
                //obtiene formato de reporte guardado y crea un xtrareport
                ReportDataV2 reportData = listaReportesDoc.Where(r => r.TipoDoc == venta.TipoDocumento).FirstOrDefault().Reporte;

                var varRepor = ReportDataProvider.ReportsStorage.LoadReport(reportData);
                XtraReport report = varRepor;
                report.DataSource = dsVentas;

                //PrintToolBase tool = new PrintToolBase(report.PrintingSystem);
                //tool.Print(venta.TipoDocumento.NombreImpresora);
                report.CreateDocument();
                using (ReportPrintTool pt = new ReportPrintTool(report))
                {

                    string NombreImpresor = "";

                    string nombre = venta.TipoDocumento.NombreImpresora;
                    NombreImpresor = nombre == null ? "" : nombre;
                       pt.ShowPreviewDialog();


                    //if (NombreImpresor != "")
                    //    pt.Print(NombreImpresor);
                    //else
                    //    pt.PrintDialog();
                }

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timerVentas.Start();
            timerReports.Start();
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            btnConfig.Enabled = false;
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {
            timerVentas.Stop();
            timerReports.Stop();
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            btnConfig.Enabled = true;
        }
        private void timerReports_Tick(object sender, EventArgs e)
        {
            ObtenerCorteCaja();
        }
        private void ObtenerCorteCaja()
        {

            int oidCorte =session.Query<CorteDeCaja>().Where(x => x.Sucursal ==sucursal && x.Finalizado==false ).Max(fcd => fcd.Oid);
            CorteDeCaja corte = session.Query<CorteDeCaja>().Where(x => x.Oid == oidCorte).FirstOrDefault();

            if (corte != null)
            {
                if (corte.Solicitado)
                {
               
                    List<CorteDeCaja> listaCorte = new List<CorteDeCaja>();
                    ReportDataV2 reportData = ObjectsPaceConnection.Session.Query<ReportDataV2>().Where(x => x.DisplayName == "CorteDeCaja").FirstOrDefault();
                    XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
                    listaCorte.Add(corte);
                    report.DataSource = listaCorte;
                   using (ReportPrintTool pt = new ReportPrintTool(report))
                        {
                            corte.Solicitado = false;
                        session.Save(corte);
                            pt.ShowPreviewDialog();
                            //         pt.ShowPreviewDialog(UserLookAndFeel.Default);
                        }
                }

                if (corte.ReporteCobros)
                {
                  
                    List<CobroPendiente> listaCobrado = session.Query<CobroPendiente>().
        Where(cobro => cobro.Venta.Turno == corte.Turno).ToList();
                    ReportDataV2 reportData = ObjectsPaceConnection.Session.FindObject<ReportDataV2>(
                        new BinaryOperator("DisplayName", "Comandas Cobradas por Turno"));
                    XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
                    report.DataSource = listaCobrado;
                        using (ReportPrintTool pt = new ReportPrintTool(report))
                        {
                            corte.ReporteCobros = false;
                        session.Save(corte);
                            pt.ShowPreviewDialog();
                            //       pt.ShowPreviewDialog(UserLookAndFeel.Default);
                        }
                }
            }

            BuscarReporteEmpleado();
        }

        private void BuscarReporteEmpleado()
        {
            ReporteCxcEmpleado reporteEmpleado = session.Query<ReporteCxcEmpleado>().Where(x=>x.Imprimir==true).FirstOrDefault();
            if (reporteEmpleado!=null)
            {
                List<CobroPendiente> cobrosReporte = session.Query<CobroPendiente>().Where(x => x.ReporteEmpleado != null).ToList();
                List<CobroPendiente> cobrosQuitar = reporteEmpleado.CobroPendientes.ToList();

                foreach (CobroPendiente item in cobrosReporte)
                {
                    reporteEmpleado.CobroPendientes.Add(item);
                }

                reporteEmpleado.Imprimir = false;
                reporteEmpleado.Save();
                List<ReporteCxcEmpleado> listaReporte = new List<ReporteCxcEmpleado>();
                    ReportDataV2 reportData = ObjectsPaceConnection.Session.Query<ReportDataV2>().Where(x => x.DisplayName == "CobrosEmpleados").FirstOrDefault();
                    var varRepor = ReportDataProvider.ReportsStorage.LoadReport(reportData);
                XtraReport report = varRepor;
                    listaReporte.Add(reporteEmpleado);
                    report.DataSource = listaReporte;
                    using (ReportPrintTool pt = new ReportPrintTool(report))
                    {

                        pt.ShowPreviewDialog();
                        //         pt.ShowPreviewDialog(UserLookAndFeel.Default);
                    }
                foreach (CobroPendiente item in cobrosQuitar)
                {
                    reporteEmpleado.CobroPendientes.Remove(item);
                }
                reporteEmpleado.Save();
            }
        }
    }
}
