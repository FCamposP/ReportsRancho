﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafReports.Module.BusinessObjects.Business
{

    public partial class ReportDataV2
    {
        public ReportDataV2(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}