﻿

namespace ERP.Web.DomainService.Erp
{
    using System;
    using System.Linq;
    using ERP.Web.Entity;

    public partial class DSErp
    {

        public IQueryable<V_Sale_Base_Note> GetV_Sale_Base_NoteList(string dbCode, string sWhere)
        {
            this.ObjectContext.ChangeDataBase(dbCode);
            return this.ObjectContext.V_Sale_Base_Note;
        }

    }
}