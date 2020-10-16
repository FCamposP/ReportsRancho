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

    public partial class Sucursal : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fCodigo;
        public string Codigo
        {
            get { return fCodigo; }
            set { SetPropertyValue<string>(nameof(Codigo), ref fCodigo, value); }
        }
        string fDireccion;
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        string fTelefono;
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        bool fActivo;
        public bool Activo
        {
            get { return fActivo; }
            set { SetPropertyValue<bool>(nameof(Activo), ref fActivo, value); }
        }
        [Association(@"CobroPendienteReferencesSucursal")]
        public XPCollection<CobroPendiente> CobroPendientes { get { return GetCollection<CobroPendiente>(nameof(CobroPendientes)); } }
        [Association(@"CorteDeCajaReferencesSucursal")]
        public XPCollection<CorteDeCaja> CorteDeCajas { get { return GetCollection<CorteDeCaja>(nameof(CorteDeCajas)); } }
        [Association(@"DetalleCobrosReferencesSucursal")]
        public XPCollection<DetalleCobros> DetalleCobrosCollection { get { return GetCollection<DetalleCobros>(nameof(DetalleCobrosCollection)); } }
        [Association(@"EmpleadoReferencesSucursal")]
        public XPCollection<Empleado> Empleadoes { get { return GetCollection<Empleado>(nameof(Empleadoes)); } }
        [Association(@"EntidadReferencesSucursal")]
        public XPCollection<Entidad> Entidads { get { return GetCollection<Entidad>(nameof(Entidads)); } }
        [Association(@"TipoDocumentoReferencesSucursal")]
        public XPCollection<TipoDocumento> TipoDocumentoes { get { return GetCollection<TipoDocumento>(nameof(TipoDocumentoes)); } }
        [Association(@"TurnoReferencesSucursal")]
        public XPCollection<Turno> Turnoes { get { return GetCollection<Turno>(nameof(Turnoes)); } }
        [Association(@"UsuarioReferencesSucursal")]
        public XPCollection<Usuario> Usuarios { get { return GetCollection<Usuario>(nameof(Usuarios)); } }
    }

}
