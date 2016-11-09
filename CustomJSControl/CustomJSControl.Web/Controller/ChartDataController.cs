using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using CustomJSControl.Module.BusinessObjects;
using DevExpress.Xpo;

namespace CustomJSControl.Web.Controller
{
    public class ChartDataController : ApiController
    {
        public IHttpActionResult GetChartData(Guid parentOid)
        {
            using (var uow = new UnitOfWork())
            {
                uow.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                var resultList = new XPQuery<ChildObject>(uow).Where(w => w.ParentObject.Oid == parentOid);
                var transformedResult = resultList.ToList().Select(sl => new Model.ChartData() { Argument = sl.DateTime, Value = sl.Value });
                return this.Ok(transformedResult);
            }
        }
    }
}