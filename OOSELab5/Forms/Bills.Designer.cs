namespace OOSELab5.Forms
{
    partial class Bills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBillID = new System.Windows.Forms.TextBox();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBillID = new System.Windows.Forms.Label();
            this.lbGenDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbIDs = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCalc = new System.Windows.Forms.Panel();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbPrices = new System.Windows.Forms.Label();
            this.lbQtys = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCalc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBillID
            // 
            this.tbBillID.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.tbBillID.Location = new System.Drawing.Point(53, 11);
            this.tbBillID.Name = "tbBillID";
            this.tbBillID.Size = new System.Drawing.Size(138, 23);
            this.tbBillID.TabIndex = 0;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Location = new System.Drawing.Point(200, 11);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(97, 23);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "View Bill";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 2);
            this.label3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bill ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 1);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 1);
            this.label8.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bill ID:";
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.Location = new System.Drawing.Point(48, 10);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(25, 13);
            this.lbBillID.TabIndex = 12;
            this.lbBillID.Text = "123";
            // 
            // lbGenDate
            // 
            this.lbGenDate.AutoSize = true;
            this.lbGenDate.Location = new System.Drawing.Point(166, 10);
            this.lbGenDate.MinimumSize = new System.Drawing.Size(130, 13);
            this.lbGenDate.Name = "lbGenDate";
            this.lbGenDate.Size = new System.Drawing.Size(130, 13);
            this.lbGenDate.TabIndex = 14;
            this.lbGenDate.Text = "Date Time";
            this.lbGenDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Generated on:";
            // 
            // lbIDs
            // 
            this.lbIDs.AutoSize = true;
            this.lbIDs.Location = new System.Drawing.Point(10, 62);
            this.lbIDs.MaximumSize = new System.Drawing.Size(22, 500);
            this.lbIDs.Name = "lbIDs";
            this.lbIDs.Size = new System.Drawing.Size(22, 117);
            this.lbIDs.TabIndex = 15;
            this.lbIDs.Text = "1.\r\n\r\n20.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(243, 52);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 13);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.Text = "Rs. 1234";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(211, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Total:";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(7, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 1);
            this.label10.TabIndex = 24;
            // 
            // panelCalc
            // 
            this.panelCalc.BackColor = System.Drawing.Color.Transparent;
            this.panelCalc.Controls.Add(this.lbDiscount);
            this.panelCalc.Controls.Add(this.label12);
            this.panelCalc.Controls.Add(this.lbItems);
            this.panelCalc.Controls.Add(this.label14);
            this.panelCalc.Controls.Add(this.lbSubTotal);
            this.panelCalc.Controls.Add(this.label16);
            this.panelCalc.Controls.Add(this.label10);
            this.panelCalc.Controls.Add(this.lbTotal);
            this.panelCalc.Controls.Add(this.label18);
            this.panelCalc.Location = new System.Drawing.Point(1, 243);
            this.panelCalc.Name = "panelCalc";
            this.panelCalc.Size = new System.Drawing.Size(296, 70);
            this.panelCalc.TabIndex = 25;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(244, 33);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(49, 13);
            this.lbDiscount.TabIndex = 30;
            this.lbDiscount.Text = "Rs. 1234";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Items:";
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.Location = new System.Drawing.Point(48, 13);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(25, 13);
            this.lbItems.TabIndex = 26;
            this.lbItems.Text = "123";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(193, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Subtotal:";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(244, 13);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lbSubTotal.TabIndex = 28;
            this.lbSubTotal.Text = "Rs. 1234";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(192, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Discount:";
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Location = new System.Drawing.Point(38, 62);
            this.lbProducts.MinimumSize = new System.Drawing.Size(145, 130);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(145, 130);
            this.lbProducts.TabIndex = 26;
            this.lbProducts.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.";
            // 
            // lbPrices
            // 
            this.lbPrices.AutoSize = true;
            this.lbPrices.Location = new System.Drawing.Point(198, 62);
            this.lbPrices.MinimumSize = new System.Drawing.Size(40, 130);
            this.lbPrices.Name = "lbPrices";
            this.lbPrices.Size = new System.Drawing.Size(40, 130);
            this.lbPrices.TabIndex = 27;
            this.lbPrices.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.";
            // 
            // lbQtys
            // 
            this.lbQtys.AutoSize = true;
            this.lbQtys.Location = new System.Drawing.Point(258, 62);
            this.lbQtys.MinimumSize = new System.Drawing.Size(35, 130);
            this.lbQtys.Name = "lbQtys";
            this.lbQtys.Size = new System.Drawing.Size(35, 130);
            this.lbQtys.TabIndex = 28;
            this.lbQtys.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbBillID);
            this.panel1.Controls.Add(this.lbQtys);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbPrices);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbProducts);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbIDs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbGenDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 196);
            this.panel1.TabIndex = 29;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(305, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.tbBillID);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Bills";
            this.panelCalc.ResumeLayout(false);
            this.panelCalc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBillID;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBillID;
        private System.Windows.Forms.Label lbGenDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbIDs;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelCalc;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.Label lbPrices;
        private System.Windows.Forms.Label lbQtys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label16;
    }
}