using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Templar.Contract;

namespace EMSWidgets
{
    public partial class Logout : System.Web.UI.UserControl,IWidget
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session.IsNewSession==false)
             Session.Abandon();
           Response.Redirect("Login");
        }

        public void HideSettings()
        {
           // throw new NotImplementedException();
        }

        public new void Init(IWidgetHost host)
        {
         //   throw new NotImplementedException();
        }

        public void ShowSettings()
        {
           // throw new NotImplementedException();
        }
    }
}