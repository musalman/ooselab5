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
    public partial class Dashboard : Form
    {
        //Temporary list that holds purchased products
        List<Product> purchased;
        //pid is for serial number of Products in bill
        int pid=1;

        //Variables for Calculation
        double subtotal=0, discount=0, total=0;
        public Dashboard()
        {
            InitializeComponent();
            purchased = new List<Product>();
        }

        //Signout
        private void lbSignout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Signout?","Signout",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                this.Hide();
                SignIn form = new SignIn();
                form.Show();
            }
        }
        //Exit
        private void lbExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Add Products upon Form Load
            addProducts();

            //Live Time & Date
            Timer timer = new Timer();
            lbDateTime.Text = DateTime.Now.ToString("ddd, dd MMMM hh:mm tt");
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = (60 - DateTime.Now.Second)*1000;
            timer.Enabled = true;
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, dd MMMM hh:mm tt");
        }

        //When any product's quantity is changed
        private void quantityEntered(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Data of Selected Product
                string selectedProduct = dataProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                int selectedProductPrice = Convert.ToInt32(dataProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
                string enteredQty = dataProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                int qty;
                if (!int.TryParse(enteredQty, out qty))
                {

                    dataProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Convert.ToInt32(enteredQty) <= 0)
                {
                    dataProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    MessageBox.Show("Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //Everything's fine. Add it to the list and do Calcs
                    purchased.Add(new Product(selectedProduct, selectedProductPrice, qty));
                    int currentProductTotal = selectedProductPrice * qty;
                    subtotal += currentProductTotal;
                    total = subtotal - discount;

                    //Update Bill ID
                    pid++;

                    //Update Labels
                    lbTotalItems.Text = purchased.Count.ToString();
                    lbSubtotal.Text = "Rs. " + subtotal;
                    lbTotal.Text = "Rs. "+total;

                    //Disable Cell so it can't be edited again
                    dataProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Apply Fixed Discount
        private void btnDiscFixed_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(tbDiscAmount.Text, out amount))
            {
                MessageBox.Show("Invalid Discount amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amount<0)
            {
                MessageBox.Show("Discount can't be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ApplyDiscount("Fixed", amount);
            }
        }
        //Apply Percentage Discount
        private void btnDiscPercent_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(tbDiscAmount.Text, out amount))
            {
                MessageBox.Show("Invalid Discount Percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amount < 0)
            {
                MessageBox.Show("Discount can't be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amount > 100)
            {
                MessageBox.Show("Discount can't be greater than 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ApplyDiscount("Percentage", amount);
            }
        }

        private void lbViewBills_Click(object sender, EventArgs e)
        {
            Bills form = new Bills();
            form.Show();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            //Work only if there is atleast 1 product purchased
            if (purchased.Count>0)
            {
                MessageBox.Show("Bill ID is " + Cart.ID, "Checkout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cart.bills.Add(new Cart(purchased, subtotal, discount));

                //Empty purchase list
                this.purchased = new List<Product>();

                //Reset Products Table
                dataProducts.Rows.Clear();
                dataProducts.Refresh();

                //Empty Calcs
                subtotal = discount = total = 0;

                //Display Products again
                addProducts();
            }
        }

        //Add some Products to the Table
        private void addProducts()
        {
            Product.products.Add(new Product("Nachos", 450));
            Product.products.Add(new Product("Tacos", 500));
            Product.products.Add(new Product("Chicken Steak", 900));
            Product.products.Add(new Product("Crispy Strip Chicken", 300));
            Product.products.Add(new Product("Spicy Chicken Wings", 400));
            Product.products.Add(new Product("Smoked BBQ Burger", 600));
            Product.products.Add(new Product("Grilled Chicken Burger", 450));
            Product.products.Add(new Product("BBQ Chicken Sliders", 250));
            Product.products.Add(new Product("Chilli Sauce Pasta", 200));
            Product.products.Add(new Product("Cheese Club Sandwich", 200));
            Product.products.Add(new Product("Chicken Biryani", 200));
            Product.products.Add(new Product("Mutton Biryani", 300));
            Product.products.Add(new Product("French Toast", 250));
            Product.products.Add(new Product("Late", 300));
            Product.products.Add(new Product("Cuppuccino", 300));
            Product.products.Add(new Product("Espresso", 500));
            Product.products.Add(new Product("Tea", 100));
            Product.products.Add(new Product("Ice Tea", 150));
            Product.products.Add(new Product("Soft Drink", 80));
            Product.products.Add(new Product("Juice", 200));

            //Add Products from List to Table
            int id = 1;
            foreach (Product p in Product.products)
            {
                dataProducts.Rows.Add(new Object[] { id, p.Name, p.Price, 0 });
                id++;
            }
        }
        //Apply Discount
        private void ApplyDiscount(string type,double amount)
        {
            //Count > 0 cause there should be atleast 1 purchased product
            if (purchased.Count>0)
            {

                if (type == "Percentage")
                {
                    amount /= 100;
                    discount = subtotal * amount;
                    total = subtotal - discount;

                    //Update Labels
                    lbDiscAmount.Text = "Rs. " + discount;
                    lbSubtotal.Text = "Rs. " + subtotal;
                    lbTotal.Text = "Rs. " + total;

                }
                else if (type == "Fixed")
                {
                    discount = amount;
                    total = subtotal - discount;

                    //Update Labels
                    lbDiscAmount.Text = "Rs. " + discount;
                    lbSubtotal.Text = "Rs. " + subtotal;
                    lbTotal.Text = "Rs. " + total;
                }
                tbDiscAmount.Text = null;
            }
        }
    }
}
