using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOSELab5.Classes;

namespace OOSELab5.Forms
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
            HideContent();
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayBill(Convert.ToInt32(tbBillID.Text));
                tbBillID.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Bill doesnot exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void HideContent()
        {
            panelCalc.Visible = false;
            panel1.Visible = false;
        }
        private void ShowContent()
        {
            panelCalc.Visible = true;
            panel1.Visible = true;
            lbSubTotal.Visible = true;
        }

        //Display bill
        private void DisplayBill(int id)
        {
            lbIDs.Text = lbProducts.Text= lbPrices.Text= lbQtys.Text=null;
            int pid = 1;
            Cart obj = Cart.bills.Where(x => x.bill_id == id).ToList().FirstOrDefault();
            foreach (Product p in obj.products_purchased)
            {
                lbIDs.Text +=pid +"."+ Environment.NewLine + Environment.NewLine;
                pid++;
                lbProducts.Text += p.Name + Environment.NewLine + Environment.NewLine;
                lbPrices.Text += p.Price + Environment.NewLine + Environment.NewLine;
                lbQtys.Text += p.Quantity + Environment.NewLine + Environment.NewLine;
            }
            lbBillID.Text = obj.bill_id.ToString();
            lbGenDate.Text = obj.GeneratedOn.ToString("ddd, dd MMMM hh:mm tt");
            lbItems.Text = obj.TotalItems.ToString();
            lbDiscount.Text = "Rs. "+obj.Discount;
            lbSubTotal.Text = "Rs. " + obj.SubTotal;
            lbTotal.Text = "Rs. " + obj.Total;

            this.panel1.Height = this.lbIDs.Size.Height + 50;
            this.panelCalc.Location = new Point(1, lbIDs.Location.Y + lbIDs.Size.Height + 40);
            ShowContent();
        }

    }
}
