using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignments
{
    public partial class assi_1_q_2_temperature : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double res = (num1 * 9 / 5) + 32;
            Response.Write("Temperature in Fahrenheit: " + res);
        }
    }
}