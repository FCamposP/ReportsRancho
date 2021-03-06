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

    public partial class RentaVehiculo : XPObject
    {
        CuentaServicios fCuentaServicio;
        [Association(@"RentaVehiculoReferencesCuentaServicios")]
        public CuentaServicios CuentaServicio
        {
            get { return fCuentaServicio; }
            set { SetPropertyValue<CuentaServicios>(nameof(CuentaServicio), ref fCuentaServicio, value); }
        }
        DateTime fFechaCreacion;
        public DateTime FechaCreacion
        {
            get { return fFechaCreacion; }
            set { SetPropertyValue<DateTime>(nameof(FechaCreacion), ref fFechaCreacion, value); }
        }
        DateTime fFechaSalida;
        public DateTime FechaSalida
        {
            get { return fFechaSalida; }
            set { SetPropertyValue<DateTime>(nameof(FechaSalida), ref fFechaSalida, value); }
        }
        DateTime fFechaEntrada;
        public DateTime FechaEntrada
        {
            get { return fFechaEntrada; }
            set { SetPropertyValue<DateTime>(nameof(FechaEntrada), ref fFechaEntrada, value); }
        }
        DateTime fFechaAnulacion;
        public DateTime FechaAnulacion
        {
            get { return fFechaAnulacion; }
            set { SetPropertyValue<DateTime>(nameof(FechaAnulacion), ref fFechaAnulacion, value); }
        }
        Entidad fCliente;
        [Association(@"RentaVehiculoReferencesEntidad")]
        public Entidad Cliente
        {
            get { return fCliente; }
            set { SetPropertyValue<Entidad>(nameof(Cliente), ref fCliente, value); }
        }
        decimal fTotal;
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        int fEstado;
        public int Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<int>(nameof(Estado), ref fEstado, value); }
        }
        string fNota;
        public string Nota
        {
            get { return fNota; }
            set { SetPropertyValue<string>(nameof(Nota), ref fNota, value); }
        }
        string fCodigoReservacion;
        public string CodigoReservacion
        {
            get { return fCodigoReservacion; }
            set { SetPropertyValue<string>(nameof(CodigoReservacion), ref fCodigoReservacion, value); }
        }
        DateTime fFechaEntregaVehiculos;
        public DateTime FechaEntregaVehiculos
        {
            get { return fFechaEntregaVehiculos; }
            set { SetPropertyValue<DateTime>(nameof(FechaEntregaVehiculos), ref fFechaEntregaVehiculos, value); }
        }
        [Association(@"ReservacionVehiculoReferencesRentaVehiculo")]
        public XPCollection<ReservacionVehiculo> ReservacionVehiculoes { get { return GetCollection<ReservacionVehiculo>(nameof(ReservacionVehiculoes)); } }
        [Association(@"ServicioExtraVehiculoReferencesRentaVehiculo")]
        public XPCollection<ServicioExtraVehiculo> ServicioExtraVehiculoes { get { return GetCollection<ServicioExtraVehiculo>(nameof(ServicioExtraVehiculoes)); } }
    }

}
