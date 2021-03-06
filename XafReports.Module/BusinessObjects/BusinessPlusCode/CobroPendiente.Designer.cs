﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafReports.Module.BusinessObjects.Business
{

    public partial class CobroPendiente : XPObject
    {
        string fDescripcion;
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        decimal fMonto;
        public decimal Monto
        {
            get { return fMonto; }
            set { SetPropertyValue<decimal>(nameof(Monto), ref fMonto, value); }
        }
        decimal fTotal;
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        decimal fDescuento;
        public decimal Descuento
        {
            get { return fDescuento; }
            set { SetPropertyValue<decimal>(nameof(Descuento), ref fDescuento, value); }
        }
        DateTime fFecha;
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>(nameof(Fecha), ref fFecha, value); }
        }
        DateTime fFechaAnulado;
        public DateTime FechaAnulado
        {
            get { return fFechaAnulado; }
            set { SetPropertyValue<DateTime>(nameof(FechaAnulado), ref fFechaAnulado, value); }
        }
        DateTime fFechaCobrado;
        public DateTime FechaCobrado
        {
            get { return fFechaCobrado; }
            set { SetPropertyValue<DateTime>(nameof(FechaCobrado), ref fFechaCobrado, value); }
        }
        int fEstado;
        public int Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<int>(nameof(Estado), ref fEstado, value); }
        }
        Entidad fCliente;
        [Association(@"CobroPendienteReferencesEntidad")]
        public Entidad Cliente
        {
            get { return fCliente; }
            set { SetPropertyValue<Entidad>(nameof(Cliente), ref fCliente, value); }
        }
        Articulo fArticulo;
        [Association(@"CobroPendienteReferencesArticulo")]
        public Articulo Articulo
        {
            get { return fArticulo; }
            set { SetPropertyValue<Articulo>(nameof(Articulo), ref fArticulo, value); }
        }
        decimal fGravado;
        public decimal Gravado
        {
            get { return fGravado; }
            set { SetPropertyValue<decimal>(nameof(Gravado), ref fGravado, value); }
        }
        decimal fExento;
        public decimal Exento
        {
            get { return fExento; }
            set { SetPropertyValue<decimal>(nameof(Exento), ref fExento, value); }
        }
        decimal fIva;
        public decimal Iva
        {
            get { return fIva; }
            set { SetPropertyValue<decimal>(nameof(Iva), ref fIva, value); }
        }
        decimal fNoSujeto;
        public decimal NoSujeto
        {
            get { return fNoSujeto; }
            set { SetPropertyValue<decimal>(nameof(NoSujeto), ref fNoSujeto, value); }
        }
        Venta fVenta;
        [Association(@"CobroPendienteReferencesVenta")]
        public Venta Venta
        {
            get { return fVenta; }
            set { SetPropertyValue<Venta>(nameof(Venta), ref fVenta, value); }
        }
        Turno fTurno;
        [Association(@"CobroPendienteReferencesTurno")]
        public Turno Turno
        {
            get { return fTurno; }
            set { SetPropertyValue<Turno>(nameof(Turno), ref fTurno, value); }
        }
        Empleado fEmpleado;
        [Association(@"CobroPendienteReferencesEmpleado")]
        public Empleado Empleado
        {
            get { return fEmpleado; }
            set { SetPropertyValue<Empleado>(nameof(Empleado), ref fEmpleado, value); }
        }
        bool fBoolCliente;
        public bool BoolCliente
        {
            get { return fBoolCliente; }
            set { SetPropertyValue<bool>(nameof(BoolCliente), ref fBoolCliente, value); }
        }
        int fTipoServicio;
        public int TipoServicio
        {
            get { return fTipoServicio; }
            set { SetPropertyValue<int>(nameof(TipoServicio), ref fTipoServicio, value); }
        }
        Sucursal fSucursal;
        [Association(@"CobroPendienteReferencesSucursal")]
        public Sucursal Sucursal
        {
            get { return fSucursal; }
            set { SetPropertyValue<Sucursal>(nameof(Sucursal), ref fSucursal, value); }
        }
        decimal fPrecioUnitario;
        public decimal PrecioUnitario
        {
            get { return fPrecioUnitario; }
            set { SetPropertyValue<decimal>(nameof(PrecioUnitario), ref fPrecioUnitario, value); }
        }
        ReporteCxcEmpleado fReporteEmpleado;
        [Association(@"CobroPendienteReferencesReporteCxcEmpleado")]
        public ReporteCxcEmpleado ReporteEmpleado
        {
            get { return fReporteEmpleado; }
            set { SetPropertyValue<ReporteCxcEmpleado>(nameof(ReporteEmpleado), ref fReporteEmpleado, value); }
        }
        int fEstadocxc;
        public int Estadocxc
        {
            get { return fEstadocxc; }
            set { SetPropertyValue<int>(nameof(Estadocxc), ref fEstadocxc, value); }
        }
        AnulacionCobro fSolicitudAnulado;
        [Association(@"CobroPendienteReferencesAnulacionCobro")]
        public AnulacionCobro SolicitudAnulado
        {
            get { return fSolicitudAnulado; }
            set { SetPropertyValue<AnulacionCobro>(nameof(SolicitudAnulado), ref fSolicitudAnulado, value); }
        }
        ComandasVendidasTurno fReporteCobrosTurno;
        [Association(@"CobroPendienteReferencesComandasVendidasTurno")]
        public ComandasVendidasTurno ReporteCobrosTurno
        {
            get { return fReporteCobrosTurno; }
            set { SetPropertyValue<ComandasVendidasTurno>(nameof(ReporteCobrosTurno), ref fReporteCobrosTurno, value); }
        }
        ComandasTurno fReporteTurno;
        [Association(@"CobroPendienteReferencesComandasTurno")]
        public ComandasTurno ReporteTurno
        {
            get { return fReporteTurno; }
            set { SetPropertyValue<ComandasTurno>(nameof(ReporteTurno), ref fReporteTurno, value); }
        }
        [Association(@"DetalleVentaReferencesCobroPendiente")]
        public XPCollection<DetalleVenta> DetalleVentas { get { return GetCollection<DetalleVenta>(nameof(DetalleVentas)); } }
    }

}
