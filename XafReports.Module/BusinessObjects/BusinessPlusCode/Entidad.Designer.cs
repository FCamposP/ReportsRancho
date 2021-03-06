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

    public partial class Entidad : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        Direccion fDireccion;
        [Association(@"EntidadReferencesDireccion")]
        public Direccion Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<Direccion>(nameof(Direccion), ref fDireccion, value); }
        }
        string fRegistroFiscal;
        public string RegistroFiscal
        {
            get { return fRegistroFiscal; }
            set { SetPropertyValue<string>(nameof(RegistroFiscal), ref fRegistroFiscal, value); }
        }
        string fTelefonoCasa;
        public string TelefonoCasa
        {
            get { return fTelefonoCasa; }
            set { SetPropertyValue<string>(nameof(TelefonoCasa), ref fTelefonoCasa, value); }
        }
        string fTipoContribuyente;
        public string TipoContribuyente
        {
            get { return fTipoContribuyente; }
            set { SetPropertyValue<string>(nameof(TipoContribuyente), ref fTipoContribuyente, value); }
        }
        string fNoTributario;
        public string NoTributario
        {
            get { return fNoTributario; }
            set { SetPropertyValue<string>(nameof(NoTributario), ref fNoTributario, value); }
        }
        int fTipoEntidad;
        public int TipoEntidad
        {
            get { return fTipoEntidad; }
            set { SetPropertyValue<int>(nameof(TipoEntidad), ref fTipoEntidad, value); }
        }
        string fRazonSocial;
        public string RazonSocial
        {
            get { return fRazonSocial; }
            set { SetPropertyValue<string>(nameof(RazonSocial), ref fRazonSocial, value); }
        }
        int fTipoPersona;
        public int TipoPersona
        {
            get { return fTipoPersona; }
            set { SetPropertyValue<int>(nameof(TipoPersona), ref fTipoPersona, value); }
        }
        string fNoDocPersonal;
        public string NoDocPersonal
        {
            get { return fNoDocPersonal; }
            set { SetPropertyValue<string>(nameof(NoDocPersonal), ref fNoDocPersonal, value); }
        }
        string fGiro;
        public string Giro
        {
            get { return fGiro; }
            set { SetPropertyValue<string>(nameof(Giro), ref fGiro, value); }
        }
        string fLugarPasaporte;
        public string LugarPasaporte
        {
            get { return fLugarPasaporte; }
            set { SetPropertyValue<string>(nameof(LugarPasaporte), ref fLugarPasaporte, value); }
        }
        int fCategoria;
        public int Categoria
        {
            get { return fCategoria; }
            set { SetPropertyValue<int>(nameof(Categoria), ref fCategoria, value); }
        }
        DateTime fFechaEmisionPasaporte;
        public DateTime FechaEmisionPasaporte
        {
            get { return fFechaEmisionPasaporte; }
            set { SetPropertyValue<DateTime>(nameof(FechaEmisionPasaporte), ref fFechaEmisionPasaporte, value); }
        }
        DateTime fFechaVencimientoPasaporte;
        public DateTime FechaVencimientoPasaporte
        {
            get { return fFechaVencimientoPasaporte; }
            set { SetPropertyValue<DateTime>(nameof(FechaVencimientoPasaporte), ref fFechaVencimientoPasaporte, value); }
        }
        string fPublicidad;
        public string Publicidad
        {
            get { return fPublicidad; }
            set { SetPropertyValue<string>(nameof(Publicidad), ref fPublicidad, value); }
        }
        string fNacionalidad;
        public string Nacionalidad
        {
            get { return fNacionalidad; }
            set { SetPropertyValue<string>(nameof(Nacionalidad), ref fNacionalidad, value); }
        }
        string fTelefonoExtranjero;
        public string TelefonoExtranjero
        {
            get { return fTelefonoExtranjero; }
            set { SetPropertyValue<string>(nameof(TelefonoExtranjero), ref fTelefonoExtranjero, value); }
        }
        string fTelefonoCelular;
        public string TelefonoCelular
        {
            get { return fTelefonoCelular; }
            set { SetPropertyValue<string>(nameof(TelefonoCelular), ref fTelefonoCelular, value); }
        }
        string fOcupacion;
        public string Ocupacion
        {
            get { return fOcupacion; }
            set { SetPropertyValue<string>(nameof(Ocupacion), ref fOcupacion, value); }
        }
        DateTime fFechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fFechaNacimiento; }
            set { SetPropertyValue<DateTime>(nameof(FechaNacimiento), ref fFechaNacimiento, value); }
        }
        int fEstadoCivil;
        public int EstadoCivil
        {
            get { return fEstadoCivil; }
            set { SetPropertyValue<int>(nameof(EstadoCivil), ref fEstadoCivil, value); }
        }
        Pais fPais;
        [Association(@"EntidadReferencesPais")]
        public Pais Pais
        {
            get { return fPais; }
            set { SetPropertyValue<Pais>(nameof(Pais), ref fPais, value); }
        }
        string fFirma;
        public string Firma
        {
            get { return fFirma; }
            set { SetPropertyValue<string>(nameof(Firma), ref fFirma, value); }
        }
        string fCorreo;
        public string Correo
        {
            get { return fCorreo; }
            set { SetPropertyValue<string>(nameof(Correo), ref fCorreo, value); }
        }
        string fNoLicencia;
        public string NoLicencia
        {
            get { return fNoLicencia; }
            set { SetPropertyValue<string>(nameof(NoLicencia), ref fNoLicencia, value); }
        }
        string fLugarLicencia;
        public string LugarLicencia
        {
            get { return fLugarLicencia; }
            set { SetPropertyValue<string>(nameof(LugarLicencia), ref fLugarLicencia, value); }
        }
        Entidad fRecomendado;
        [Association(@"EntidadReferencesEntidad")]
        public Entidad Recomendado
        {
            get { return fRecomendado; }
            set { SetPropertyValue<Entidad>(nameof(Recomendado), ref fRecomendado, value); }
        }
        string fComentarios;
        [Size(SizeAttribute.Unlimited)]
        public string Comentarios
        {
            get { return fComentarios; }
            set { SetPropertyValue<string>(nameof(Comentarios), ref fComentarios, value); }
        }
        Sucursal fSucursal;
        [Association(@"EntidadReferencesSucursal")]
        public Sucursal Sucursal
        {
            get { return fSucursal; }
            set { SetPropertyValue<Sucursal>(nameof(Sucursal), ref fSucursal, value); }
        }
        ClaseCliente fClase;
        [Association(@"EntidadReferencesClaseCliente")]
        public ClaseCliente Clase
        {
            get { return fClase; }
            set { SetPropertyValue<ClaseCliente>(nameof(Clase), ref fClase, value); }
        }
        string fPrimerNombre;
        public string PrimerNombre
        {
            get { return fPrimerNombre; }
            set { SetPropertyValue<string>(nameof(PrimerNombre), ref fPrimerNombre, value); }
        }
        string fSegundoNombre;
        public string SegundoNombre
        {
            get { return fSegundoNombre; }
            set { SetPropertyValue<string>(nameof(SegundoNombre), ref fSegundoNombre, value); }
        }
        string fApellidos;
        public string Apellidos
        {
            get { return fApellidos; }
            set { SetPropertyValue<string>(nameof(Apellidos), ref fApellidos, value); }
        }
        string fTitulo;
        public string Titulo
        {
            get { return fTitulo; }
            set { SetPropertyValue<string>(nameof(Titulo), ref fTitulo, value); }
        }
        [Association(@"CobroPendienteReferencesEntidad")]
        public XPCollection<CobroPendiente> CobroPendientes { get { return GetCollection<CobroPendiente>(nameof(CobroPendientes)); } }
        [Association(@"CuentaServiciosReferencesEntidad")]
        public XPCollection<CuentaServicios> CuentaServiciosCollection { get { return GetCollection<CuentaServicios>(nameof(CuentaServiciosCollection)); } }
        [Association(@"DetalleCobrosReferencesEntidad")]
        public XPCollection<DetalleCobros> DetalleCobrosCollection { get { return GetCollection<DetalleCobros>(nameof(DetalleCobrosCollection)); } }
        [Association(@"EntidadReferencesEntidad")]
        public XPCollection<Entidad> EntidadCollection { get { return GetCollection<Entidad>(nameof(EntidadCollection)); } }
        [Association(@"RentaVehiculoReferencesEntidad")]
        public XPCollection<RentaVehiculo> RentaVehiculoes { get { return GetCollection<RentaVehiculo>(nameof(RentaVehiculoes)); } }
        [Association(@"ReservacionHotelReferencesEntidad")]
        public XPCollection<ReservacionHotel> ReservacionHotels { get { return GetCollection<ReservacionHotel>(nameof(ReservacionHotels)); } }
        [Association(@"VentaReferencesEntidad")]
        public XPCollection<Venta> Ventas { get { return GetCollection<Venta>(nameof(Ventas)); } }
    }

}
