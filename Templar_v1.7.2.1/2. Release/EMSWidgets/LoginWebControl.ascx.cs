using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Templar.Contract;
using RollBasedAccess;

namespace EMSWidgets
{
    public partial class LoginWebControl : System.Web.UI.UserControl,IWidget
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void HideSettings()
        {
            //throw new NotImplementedException();
        }

        public new void Init(IWidgetHost host)
        {
            //throw new NotImplementedException();
        }

        public void ShowSettings()
        {
            pnlSettings.Visible = true;
            //throw new NotImplementedException();
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Credentials credential = new Credentials();
            credential.EmailId = TextBoxUserName.Text;
            credential.Password = TextBoxPassword.Text;
            Session["Email"] = TextBoxUserName.Text;
            var res = Credentials.Authenticate(credential);
            if (res.Status.StatusCode == "200")
            {
                Session["Id"] = res.Employee.Id;
                if (string.Equals(res.Employee.Title, "Hr", StringComparison.CurrentCultureIgnoreCase))
                    Response.Redirect("HRHomePage");
                else
                {
                    Response.Redirect("DisplayRemarks");
                }

            }
         
        }

       
    }
}