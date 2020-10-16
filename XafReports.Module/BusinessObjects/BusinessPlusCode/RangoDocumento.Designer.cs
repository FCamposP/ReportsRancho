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

    public partial class RangoDocumento : XPObject
    {
        int fActual;
        public int Actual
        {
            get { return fActual; }
            set { SetPropertyValue<int>(nameof(Actual), ref fActual, value); }
        }
        string fSerie;
        public string Serie
        {
            get { return fSerie; }
            set { SetPropertyValue<string>(nameof(Serie), ref fSerie, value); }
        }
        bool fEstado;
        [ColumnDbDefaultValue("((0))")]
        public bool Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<bool>(nameof(Estado), ref fEstado, value); }
        }
        TipoDocumento fTipoDocumento;
        [Association(@"RangoDocumentoReferencesTipoDocumento")]
        public TipoDocumento TipoDocumento
        {
            get { return fTipoDocumento; }
            set { SetPropertyValue<TipoDocumento>(nameof(TipoDocumento), ref fTipoDocumento, value); }
        }
        int fInicial;
        public int Inicial
        {
            get { return fInicial; }
            set { SetPropertyValue<int>(nameof(Inicial), ref fInicial, value); }
        }
        int fFinal;
        public int Final
        {
            get { return fFinal; }
            set { SetPropertyValue<int>(nameof(Final), ref fFinal, value); }
        }
        string fDireccion;
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        DateTime fFechaAutorizacion;
        public DateTime FechaAutorizacion
        {
            get { return fFechaAutorizacion; }
            set { SetPropertyValue<DateTime>(nameof(FechaAutorizacion), ref fFechaAutorizacion, value); }
        }
        string fNoAutorizacion;
        public string NoAutorizacion
        {
            get { return fNoAutorizacion; }
            set { SetPropertyValue<string>(nameof(NoAutorizacion), ref fNoAutorizacion, value); }
        }
        [Association(@"TipoDocumentoReferencesRangoDocumento")]
        public XPCollection<TipoDocumento> TipoDocumentoes { get { return GetCollection<TipoDocumento>(nameof(TipoDocumentoes)); } }
    }

}