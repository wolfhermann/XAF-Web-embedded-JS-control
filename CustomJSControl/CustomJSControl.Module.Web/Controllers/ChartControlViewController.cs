using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomJSControl.Module.BusinessObjects;
using CustomJSControl.Module.Web.Interfaces;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace CustomJSControl.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ChartControlViewController : ViewController
    {
        public ChartControlViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            TargetObjectType = typeof(ParentObject);
            TargetViewType = ViewType.DetailView;
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();

            // Access and customize the target View control.
            var view = (DetailView)View;

            ViewItem customControl = view.FindItem("ChartControl");
            if (customControl != null)
            {
                customControl.ControlCreated += CustomControl_ControlCreated;
            }
        }

        private void CustomControl_ControlCreated(object sender, EventArgs e)
        {
            ViewItem customControl = sender as ViewItem;

            var currentObject = View.CurrentObject as ParentObject;
            if (currentObject != null)
            {
                var control = (IBoundCustomControl)customControl.Control;
                control.SetOid(currentObject.Oid);
            }
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
