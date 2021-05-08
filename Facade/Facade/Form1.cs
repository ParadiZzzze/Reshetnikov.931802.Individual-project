using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void order_button_Click(object sender, EventArgs e)
        {
            string clienttype = (string)edType.Text;
            string clientsize = (string)edSize.Text;
            string clientcountry = (string)edCountry.Text;
            //TaxInspection tax = new TaxInspection();
            //Storage aaa = new Storage();
            //double r = aaa.isAvailable("jeans", "S");
            //label4.Text = "Stuff price: " + Convert.ToString(r);
            //r = tax.payTax(r);
            
            Facade facade = new Facade();
            label5.Text = "Stuff price with VAT: " + Convert.ToString(facade.orderStuff(clienttype, clientsize, clientcountry));
        }
    }
}
