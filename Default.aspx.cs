﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
           
        }

        


        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                decimal salesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;

                decimal discountAmount = salesPrice * discountPercent;
                decimal totalPrice = salesPrice - discountAmount;

                lblDiscountAmount.Text = discountAmount.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");

                Session["value1"] = "$" + txtSalesPrice.Text;
                Session["value2"] = lblDiscountAmount.Text;
                Session["value3"] = lblTotalPrice.Text;
            }   
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Session["value3"] != null)
               {
                
                Response.Redirect("Confirm.aspx");
               }
            
             
            {
                lblconfirm.Text = "Calculate the Item price first!";
            }
        }


            
        }
    }
