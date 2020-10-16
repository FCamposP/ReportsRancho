using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XafReports.Module.BusinessObjects.BusinessPlus;

namespace PrintSalesBPlus
{
    static class Program
    {

        private static IObjectSpace directObjectSpace;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistrarObjectSpace();
            Application.Run(new Form1());
        }

        private static void RegistrarObjectSpace()
        {
            string connectionString = "";
            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null)
            {
                connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }

            IDataStore store = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.SchemaAlreadyExists);
            XPDictionary dict = new ReflectionDictionary();
            dict.GetDataStoreSchema(System.Reflection.Assembly.GetExecutingAssembly());
            XpoDefault.DataLayer = new ThreadSafeDataLayer(dict, store);

            XpoTypesInfoHelper.ForceInitialize();
            XpoTypesInfoHelper.GetXpoTypeInfoSource();

            XafTypesInfo.Instance.RegisterEntity(typeof(Venta));
            XafTypesInfo.Instance.RegisterEntity(typeof(TipoDocumento));
            XafTypesInfo.Instance.RegisterEntity(typeof(CobroPendiente));
            XafTypesInfo.Instance.RegisterEntity(typeof(ReporteCxcEmpleado));
            XafTypesInfo.Instance.RegisterEntity(typeof(CorteDeCaja));
            XafTypesInfo.Instance.RegisterEntity(typeof(Empleado));

            XafTypesInfo.Instance.RegisterEntity(typeof(Sucursal));


            XafTypesInfo.Instance.RegisterEntity(typeof(ReportDataV2));

            XPObjectSpaceProvider directProvider = new XPObjectSpaceProvider(connectionString, null, true);
ObjectsPaceConnection.PropObjectSpace = directProvider.CreateObjectSpace();
            ObjectsPaceConnection.Session = ((XPObjectSpace)ObjectsPaceConnection.PropObjectSpace).Session;


        }
    }
}
