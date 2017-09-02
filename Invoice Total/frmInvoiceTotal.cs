using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Total
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            /*this metho calculates the total for an invoice depending on a
             * discount that's based on the subtotal */
           
            //get the subtotal amount from the Subtotal text box decimal subtotal
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);

            //set the discountPercent variable based
            //on the value of the subtotal variable
            decimal discountPercent = 0m;    //the m indicates a decimal value
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            //calculate and assign the values for the
            //discountAmount and invoiceTotal variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            //format the values and display them in their text boxes
            txtDiscountPercent.Text = discountPercent.ToString("p1"); //percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c"); //currency format
            txtTotal.Text = invoiceTotal.ToString("c");

            //move the focus to the Subtotal text box
            txtSubTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
