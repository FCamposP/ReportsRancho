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

    public partial class AccesorioVehiculo : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fDescripcion;
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        decimal fPrecio;
        public decimal Precio
        {
            get { return fPrecio; }
            set { SetPropertyValue<decimal>(nameof(Precio), ref fPrecio, value); }
        }
        [Association(@"VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollectionReferencesAccesorioVehiculo")]
        public XPCollection<VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollection> VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollections { get { return GetCollection<VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollection>(nameof(VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollections)); } }
    }

}