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

    public partial class UnidadOrganizativa : XPObject
    {
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fCategoria;
        public string Categoria
        {
            get { return fCategoria; }
            set { SetPropertyValue<string>(nameof(Categoria), ref fCategoria, value); }
        }
        string fDepartamento;
        public string Departamento
        {
            get { return fDepartamento; }
            set { SetPropertyValue<string>(nameof(Departamento), ref fDepartamento, value); }
        }
        [Association(@"EmpleadoReferencesUnidadOrganizativa")]
        public XPCollection<Empleado> Empleadoes { get { return GetCollection<Empleado>(nameof(Empleadoes)); } }
    }

}
