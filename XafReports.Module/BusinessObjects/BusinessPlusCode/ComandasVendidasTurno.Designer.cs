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

    public partial class ComandasVendidasTurno : XPObject
    {
        DateTime fInicioTurno;
        public DateTime InicioTurno
        {
            get { return fInicioTurno; }
            set { SetPropertyValue<DateTime>(nameof(InicioTurno), ref fInicioTurno, value); }
        }
        DateTime fFinTurno;
        public DateTime FinTurno
        {
            get { return fFinTurno; }
            set { SetPropertyValue<DateTime>(nameof(FinTurno), ref fFinTurno, value); }
        }
        string fSucursal;
        public string Sucursal
        {
            get { return fSucursal; }
            set { SetPropertyValue<string>(nameof(Sucursal), ref fSucursal, value); }
        }
        [Association(@"CobroPendienteReferencesComandasVendidasTurno")]
        public XPCollection<CobroPendiente> CobroPendientes { get { return GetCollection<CobroPendiente>(nameof(CobroPendientes)); } }
    }

}
