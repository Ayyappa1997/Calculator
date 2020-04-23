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
        string var_result;
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
                switch (action)
                {
                    case "Add":
                        var_result = calculate.Add(var_inp1, var_inp2).ToString();
                         break;
                    case "Sub":
                        var_result = calculate.Sub(var_inp1, var_inp2).ToString();
                        break;
                    case "Mul":
                        var_result = calculate.Mul(var_inp1, var_inp2).ToString();
                        break;
                    case "Div":
                        var_result = calculate.Div(var_inp1, var_inp2).ToString();
                        break;                        
                }
                txtInput1.Text = var_result;
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
