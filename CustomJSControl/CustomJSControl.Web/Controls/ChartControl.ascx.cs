using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomJSControl.Module.Web.Interfaces;
using DevExpress.ExpressApp.Web;

namespace CustomJSControl.Web.Controls
{
    public partial class ChartControl : System.Web.UI.UserControl, IBoundCustomControl
    {
        public void SetOid(Guid oid)
        {
            if (this.ASPxPanel1.JSProperties.ContainsKey("cpOid"))
            {
                this.ASPxPanel1.JSProperties["cpOid"] = oid;
            }
            else
            {
                this.ASPxPanel1.JSProperties.Add("cpOid", oid);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string url = this.ResolveClientUrl("~/js/chartControl.js");
            WebWindow.CurrentRequestWindow.RegisterClientScriptInclude("chartControl", url);
        }
    }
}