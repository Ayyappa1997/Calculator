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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Fetchtxtbxvls()
        {
            var_inp1 = Convert.ToDouble(txtInput1.Text);
            var_inp2 = Convert.ToDouble(txtInput2.Text);
            txtInput1.Text = "";
            txtInput2.Text = "";
        }
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            Fetchtxtbxvls();
            txtInput1.Text = (var_inp1 / var_inp2).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            Fetchtxtbxvls();
            txtInput1.Text = (var_inp1 * var_inp2).ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Fetchtxtbxvls();
            txtInput1.Text = (var_inp1 + var_inp2).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            Fetchtxtbxvls();
            txtInput1.Text = (var_inp1 - var_inp2).ToString();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
        }
    }
}