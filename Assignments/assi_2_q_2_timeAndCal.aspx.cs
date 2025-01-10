using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignments
{
    public partial class assi_2_q_2_timeAndCal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label4.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}