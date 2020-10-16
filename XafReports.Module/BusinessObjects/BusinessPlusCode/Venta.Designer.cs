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

    public partial class Venta : XPObject
    {
        decimal fGravado;
        public decimal Gravado
        {
            get { return fGravado; }
            set { SetPropertyValue<decimal>(nameof(Gravado), ref fGravado, value); }
        }
        decimal fDescuento;
        public decimal Descuento
        {
            get { return fDescuento; }
            set { SetPropertyValue<decimal>(nameof(Descuento), ref fDescuento, value); }
        }
        decimal fIva;
        public decimal Iva
        {
            get { return fIva; }
            set { SetPropertyValue<decimal>(nameof(Iva), ref fIva, value); }
        }
        decimal fSubTotal;
        public decimal SubTotal
        {
            get { return fSubTotal; }
            set { SetPropertyValue<decimal>(nameof(SubTotal), ref fSubTotal, value); }
        }
        decimal fNoSujeto;
        public decimal NoSujeto
        {
            get { return fNoSujeto; }
            set { SetPropertyValue<decimal>(nameof(NoSujeto), ref fNoSujeto, value); }
        }
        decimal fExento;
        public decimal Exento
        {
            get { return fExento; }
            set { SetPropertyValue<decimal>(nameof(Exento), ref fExento, value); }
        }
        decimal fTotal;
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        double fPorcentajeDescuento;
        public double PorcentajeDescuento
        {
            get { return fPorcentajeDescuento; }
            set { SetPropertyValue<double>(nameof(PorcentajeDescuento), ref fPorcentajeDescuento, value); }
        }
        decimal fDescuentoTotal;
        public decimal DescuentoTotal
        {
            get { return fDescuentoTotal; }
            set { SetPropertyValue<decimal>(nameof(DescuentoTotal), ref fDescuentoTotal, value); }
        }
        decimal fPercibido;
        public decimal Percibido
        {
            get { return fPercibido; }
            set { SetPropertyValue<decimal>(nameof(Percibido), ref fPercibido, value); }
        }
        decimal fRetenido;
        public decimal Retenido
        {
            get { return fRetenido; }
            set { SetPropertyValue<decimal>(nameof(Retenido), ref fRetenido, value); }
        }
        Entidad fCliente;
        [Association(@"VentaReferencesEntidad")]
        public Entidad Cliente
        {
            get { return fCliente; }
            set { SetPropertyValue<Entidad>(nameof(Cliente), ref fCliente, value); }
        }
        string fANombreDe;
        public string ANombreDe
        {
            get { return fANombreDe; }
            set { SetPropertyValue<string>(nameof(ANombreDe), ref fANombreDe, value); }
        }
        TipoDocumento fTipoDocumento;
        [Association(@"VentaReferencesTipoDocumento")]
        public TipoDocumento TipoDocumento
        {
            get { return fTipoDocumento; }
            set { SetPropertyValue<TipoDocumento>(nameof(TipoDocumento), ref fTipoDocumento, value); }
        }
        DateTime fFechaVenta;
        public DateTime FechaVenta
        {
            get { return fFechaVenta; }
            set { SetPropertyValue<DateTime>(nameof(FechaVenta), ref fFechaVenta, value); }
        }
        DateTime fFechaImpresion;
        public DateTime FechaImpresion
        {
            get { return fFechaImpresion; }
            set { SetPropertyValue<DateTime>(nameof(FechaImpresion), ref fFechaImpresion, value); }
        }
        DateTime fFechaAnulado;
        public DateTime FechaAnulado
        {
            get { return fFechaAnulado; }
            set { SetPropertyValue<DateTime>(nameof(FechaAnulado), ref fFechaAnulado, value); }
        }
        Turno fTurno;
        [Association(@"VentaReferencesTurno")]
        public Turno Turno
        {
            get { return fTurno; }
            set { SetPropertyValue<Turno>(nameof(Turno), ref fTurno, value); }
        }
        int fEstado;
        public int Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<int>(nameof(Estado), ref fEstado, value); }
        }
        CorteDeCaja fCorteDeCaja;
        [Association(@"VentaReferencesCorteDeCaja")]
        public CorteDeCaja CorteDeCaja
        {
            get { return fCorteDeCaja; }
            set { SetPropertyValue<CorteDeCaja>(nameof(CorteDeCaja), ref fCorteDeCaja, value); }
        }
        bool fImpreso;
        [ColumnDbDefaultValue("((0))")]
        public bool Impreso
        {
            get { return fImpreso; }
            set { SetPropertyValue<bool>(nameof(Impreso), ref fImpreso, value); }
        }
        string fNumeroDocumento;
        public string NumeroDocumento
        {
            get { return fNumeroDocumento; }
            set { SetPropertyValue<string>(nameof(NumeroDocumento), ref fNumeroDocumento, value); }
        }
        decimal fEfectivoIngresaado;
        public decimal EfectivoIngresaado
        {
            get { return fEfectivoIngresaado; }
            set { SetPropertyValue<decimal>(nameof(EfectivoIngresaado), ref fEfectivoIngresaado, value); }
        }
        Transaccion fTransaccion;
        [Association(@"VentaReferencesTransaccion")]
        public Transaccion Transaccion
        {
            get { return fTransaccion; }
            set { SetPropertyValue<Transaccion>(nameof(Transaccion), ref fTransaccion, value); }
        }
        Turno fTurnoAnulado;
        [Association(@"VentaReferencesTurno1")]
        public Turno TurnoAnulado
        {
            get { return fTurnoAnulado; }
            set { SetPropertyValue<Turno>(nameof(TurnoAnulado), ref fTurnoAnulado, value); }
        }
        CuentaServicios fCuentaServicio;
        [Association(@"VentaReferencesCuentaServicios")]
        public CuentaServicios CuentaServicio
        {
            get { return fCuentaServicio; }
            set { SetPropertyValue<CuentaServicios>(nameof(CuentaServicio), ref fCuentaServicio, value); }
        }
        [Association(@"CobroPendienteReferencesVenta")]
        public XPCollection<CobroPendiente> CobroPendientes { get { return GetCollection<CobroPendiente>(nameof(CobroPendientes)); } }
        [Association(@"DetallePagoReferencesVenta")]
        public XPCollection<DetallePago> DetallePagoes { get { return GetCollection<DetallePago>(nameof(DetallePagoes)); } }
        [Association(@"DetalleVentaReferencesVenta")]
        public XPCollection<DetalleVenta> DetalleVentas { get { return GetCollection<DetalleVenta>(nameof(DetalleVentas)); } }
        [Association(@"TipoImpuestoReferencesVenta")]
        public XPCollection<TipoImpuesto> TipoImpuestoes { get { return GetCollection<TipoImpuesto>(nameof(TipoImpuestoes)); } }
    }

}