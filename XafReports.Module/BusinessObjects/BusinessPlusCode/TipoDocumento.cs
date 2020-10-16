using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafReports.Module.BusinessObjects.Business
{

    public partial class TipoDocumento
    {
        public TipoDocumento(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
