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

    public partial class ServicioExtraVehiculo : XPObject
    {
        RentaVehiculo fRentaVehiculo;
        [Association(@"ServicioExtraVehiculoReferencesRentaVehiculo")]
        public RentaVehiculo RentaVehiculo
        {
            get { return fRentaVehiculo; }
            set { SetPropertyValue<RentaVehiculo>(nameof(RentaVehiculo), ref fRentaVehiculo, value); }
        }
        string fDescripcion;
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        string fPrecio;
        public string Precio
        {
            get { return fPrecio; }
            set { SetPropertyValue<string>(nameof(Precio), ref fPrecio, value); }
        }
        string fCantidad;
        public string Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<string>(nameof(Cantidad), ref fCantidad, value); }
        }
        string fFechaCreacion;
        public string FechaCreacion
        {
            get { return fFechaCreacion; }
            set { SetPropertyValue<string>(nameof(FechaCreacion), ref fFechaCreacion, value); }
        }
        DetalleCobros fDetalleCobro;
        [Association(@"ServicioExtraVehiculoReferencesDetalleCobros")]
        public DetalleCobros DetalleCobro
        {
            get { return fDetalleCobro; }
            set { SetPropertyValue<DetalleCobros>(nameof(DetalleCobro), ref fDetalleCobro, value); }
        }
    }

}
