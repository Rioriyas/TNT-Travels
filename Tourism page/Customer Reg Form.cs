using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_page
{
    public partial class Customer_Reg_Form : Form
    {
        public Customer_Reg_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fnametext.Text = "";
            Emailtext.Text = "";
            Lnametext.Text = "";
            Addresstext.Text = "";
            Mobiletext.Text = "";
            Citytext.Text = "";
            Countrytext.Text = "";
       
    }
    }
}
