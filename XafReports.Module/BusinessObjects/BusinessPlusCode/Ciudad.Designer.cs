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

    public partial class Ciudad : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        Estado fEstado;
        [Association(@"CiudadReferencesEstado")]
        public Estado Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<Estado>(nameof(Estado), ref fEstado, value); }
        }
        [Association(@"DireccionReferencesCiudad")]
        public XPCollection<Direccion> Direccions { get { return GetCollection<Direccion>(nameof(Direccions)); } }
    }

}