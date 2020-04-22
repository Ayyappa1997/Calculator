using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class index : System.Web.UI.Page
    {
        double var_inp1;
        double var_inp2;
        string action;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Calculate calculate = new Calculate();
        protected void Fetchtxtbxvls()
        {
            if (txtInput1.Text!=null && txtInput2.Text != null)
            {
                var_inp1 = Convert.ToDouble(txtInput1.Text);
                var_inp2 = Convert.ToDouble(txtInput2.Text);
                txtInput1.Text = "";
                txtInput2.Text = "";
                txtInput1.Text = calculate.Operations(var_inp1, var_inp2, action).ToString();
            }

            
        }
        
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            
            action = "Div";
            Fetchtxtbxvls();
            
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            action = "Mul";
            Fetchtxtbxvls();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            action = "Add";
            Fetchtxtbxvls();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            action = "Sub";
            Fetchtxtbxvls();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
        }
    }
}