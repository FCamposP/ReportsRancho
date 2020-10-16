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

    public partial class TarifaHabitacion : XPObject
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
        decimal fPrecioTarifa;
        public decimal PrecioTarifa
        {
            get { return fPrecioTarifa; }
            set { SetPropertyValue<decimal>(nameof(PrecioTarifa), ref fPrecioTarifa, value); }
        }
        [Association(@"HabitacionReferencesTarifaHabitacion")]
        public XPCollection<Habitacion> Habitacions { get { return GetCollection<Habitacion>(nameof(Habitacions)); } }
        [Association(@"PreciosTarifasReferencesTarifaHabitacion")]
        public XPCollection<PreciosTarifas> PreciosTarifasCollection { get { return GetCollection<PreciosTarifas>(nameof(PreciosTarifasCollection)); } }
        [Association(@"ReservacionTarifasReferencesTarifaHabitacion")]
        public XPCollection<ReservacionTarifas> ReservacionTarifasCollection { get { return GetCollection<ReservacionTarifas>(nameof(ReservacionTarifasCollection)); } }
        [Association(@"TarifaPromocionReferencesTarifaHabitacion")]
        public XPCollection<TarifaPromocion> TarifaPromocions { get { return GetCollection<TarifaPromocion>(nameof(TarifaPromocions)); } }
    }

}