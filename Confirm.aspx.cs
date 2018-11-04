using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblSalesPrice.Text = Session["value1"].ToString();
            lblDiscountAmount.Text = Session["value2"].ToString();
            lblTotalPrice.Text = Session["value3"].ToString();
        }

        protected void btnQuatation_Click(object sender, EventArgs e)
        {

            if(txtEmail== null || txtName == null )
            {
                Label1.Text = "Please Provide the email and name";
            }
            else

            Label1.Text = "Thank You for sending the quotation !   Click on Return to go back to Home Page";            
        }
    }
}