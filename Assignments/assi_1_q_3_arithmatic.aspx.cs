using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignments
{
    public partial class assi_1_q_3_arithmatic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double res = 0;
            if (RadioButton1.Checked)
            {
                res = num1 + num2;
                Label3.Text = "Addition: " + res;
                Label3.Visible = true;
            }
            else if (RadioButton2.Checked)
            {
                res = num1 - num2;
                Label3.Text = "Subtraction: " + res;
                Label3.Visible = true;
            }
            else if (RadioButton3.Checked)
            {
                res = num1 * num2;
                Label3.Text = "Multiplication: " + res;
                Label3.Visible = true;
            }
            else if (RadioButton4.Checked)
            {
                res = num1 / num2;
                Label3.Text = "Division: " + res;
                Label3.Visible = true;
            }
        }
    }
}