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

    public partial class VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollection : XPObject
    {
        AccesorioVehiculo fAccesorioVehiculoCollection;
        [Indexed(@"Vehiculos", Name = @"iAccesorioVehiculoCollectionVehiculos_VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollection", Unique = true)]
        [Association(@"VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollectionReferencesAccesorioVehiculo")]
        public AccesorioVehiculo AccesorioVehiculoCollection
        {
            get { return fAccesorioVehiculoCollection; }
            set { SetPropertyValue<AccesorioVehiculo>(nameof(AccesorioVehiculoCollection), ref fAccesorioVehiculoCollection, value); }
        }
        Vehiculo fVehiculos;
        [Association(@"VehiculoVehiculos_AccesorioVehiculoAccesorioVehiculoCollectionReferencesVehiculo")]
        public Vehiculo Vehiculos
        {
            get { return fVehiculos; }
            set { SetPropertyValue<Vehiculo>(nameof(Vehiculos), ref fVehiculos, value); }
        }
    }

}