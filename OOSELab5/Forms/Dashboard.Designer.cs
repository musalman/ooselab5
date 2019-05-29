namespace OOSELab5.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.lbSignout = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalItems = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.tbDiscAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiscFixed = new System.Windows.Forms.Button();
            this.btnDiscPercent = new System.Windows.Forms.Button();
            this.lbDiscAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbViewBills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 23.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point of Sale System";
            // 
            // lbSignout
            // 
            this.lbSignout.AutoSize = true;
            this.lbSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignout.ForeColor = System.Drawing.Color.White;
            this.lbSignout.Location = new System.Drawing.Point(470, 9);
            this.lbSignout.Name = "lbSignout";
            this.lbSignout.Size = new System.Drawing.Size(55, 17);
            this.lbSignout.TabIndex = 1;
            this.lbSignout.Text = "Signout";
            this.lbSignout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSignout.Click += new System.EventHandler(this.lbSignout_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 2);
            this.label3.TabIndex = 2;
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbID,
            this.tbProductTitle,
            this.tbProductPrice,
            this.tbQuantity});
            this.dataProducts.Location = new System.Drawing.Point(21, 73);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.Size = new System.Drawing.Size(559, 418);
            this.dataProducts.TabIndex = 3;
            this.dataProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.quantityEntered);
            // 
            // tbID
            // 
            this.tbID.HeaderText = "ID";
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Width = 35;
            // 
            // tbProductTitle
            // 
            this.tbProductTitle.HeaderText = "Product Title";
            this.tbProductTitle.Name = "tbProductTitle";
            this.tbProductTitle.ReadOnly = true;
            this.tbProductTitle.Width = 275;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.HeaderText = "Price";
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.ReadOnly = true;
            // 
            // tbQuantity
            // 
            this.tbQuantity.HeaderText = "Quantity";
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Width = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Items: ";
            // 
            // lbTotalItems
            // 
            this.lbTotalItems.AutoSize = true;
            this.lbTotalItems.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lbTotalItems.ForeColor = System.Drawing.Color.White;
            this.lbTotalItems.Location = new System.Drawing.Point(124, 556);
            this.lbTotalItems.MinimumSize = new System.Drawing.Size(80, 30);
            this.lbTotalItems.Name = "lbTotalItems";
            this.lbTotalItems.Size = new System.Drawing.Size(80, 30);
            this.lbTotalItems.TabIndex = 5;
            this.lbTotalItems.Text = "Rs. 0";
            this.lbTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lbSubtotal.ForeColor = System.Drawing.Color.White;
            this.lbSubtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSubtotal.Location = new System.Drawing.Point(500, 503);
            this.lbSubtotal.MinimumSize = new System.Drawing.Size(80, 30);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(80, 30);
            this.lbSubtotal.TabIndex = 7;
            this.lbSubtotal.Text = "Rs. 0";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(418, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtotal:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(490, 556);
            this.lbTotal.MinimumSize = new System.Drawing.Size(90, 30);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(90, 30);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Rs. 0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(442, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(26, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(561, 2);
            this.label8.TabIndex = 10;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(436, 611);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(151, 43);
            this.btnGenerateBill.TabIndex = 11;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // tbDiscAmount
            // 
            this.tbDiscAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbDiscAmount.Location = new System.Drawing.Point(162, 505);
            this.tbDiscAmount.Name = "tbDiscAmount";
            this.tbDiscAmount.Size = new System.Drawing.Size(135, 27);
            this.tbDiscAmount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apply Discount";
            // 
            // btnDiscFixed
            // 
            this.btnDiscFixed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscFixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscFixed.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnDiscFixed.ForeColor = System.Drawing.Color.White;
            this.btnDiscFixed.Location = new System.Drawing.Point(303, 505);
            this.btnDiscFixed.Name = "btnDiscFixed";
            this.btnDiscFixed.Size = new System.Drawing.Size(43, 27);
            this.btnDiscFixed.TabIndex = 14;
            this.btnDiscFixed.Text = "Rs.";
            this.btnDiscFixed.UseVisualStyleBackColor = true;
            this.btnDiscFixed.Click += new System.EventHandler(this.btnDiscFixed_Click);
            // 
            // btnDiscPercent
            // 
            this.btnDiscPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscPercent.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnDiscPercent.ForeColor = System.Drawing.Color.White;
            this.btnDiscPercent.Location = new System.Drawing.Point(356, 505);
            this.btnDiscPercent.Name = "btnDiscPercent";
            this.btnDiscPercent.Size = new System.Drawing.Size(43, 27);
            this.btnDiscPercent.TabIndex = 15;
            this.btnDiscPercent.Text = "%";
            this.btnDiscPercent.UseVisualStyleBackColor = true;
            this.btnDiscPercent.Click += new System.EventHandler(this.btnDiscPercent_Click);
            // 
            // lbDiscAmount
            // 
            this.lbDiscAmount.AutoSize = true;
            this.lbDiscAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lbDiscAmount.ForeColor = System.Drawing.Color.White;
            this.lbDiscAmount.Location = new System.Drawing.Point(319, 555);
            this.lbDiscAmount.MinimumSize = new System.Drawing.Size(80, 30);
            this.lbDiscAmount.Name = "lbDiscAmount";
            this.lbDiscAmount.Size = new System.Drawing.Size(80, 30);
            this.lbDiscAmount.TabIndex = 17;
            this.lbDiscAmount.Text = "Rs. 0";
            this.lbDiscAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(227, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Discount:";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(550, 9);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(30, 17);
            this.lbExit.TabIndex = 18;
            this.lbExit.Text = "Exit";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.White;
            this.lbDateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDateTime.Location = new System.Drawing.Point(430, 37);
            this.lbDateTime.MinimumSize = new System.Drawing.Size(150, 17);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(150, 17);
            this.lbDateTime.TabIndex = 19;
            this.lbDateTime.Text = "Date Time";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbViewBills
            // 
            this.lbViewBills.AutoSize = true;
            this.lbViewBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbViewBills.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewBills.ForeColor = System.Drawing.Color.White;
            this.lbViewBills.Location = new System.Drawing.Point(26, 637);
            this.lbViewBills.Name = "lbViewBills";
            this.lbViewBills.Size = new System.Drawing.Size(63, 17);
            this.lbViewBills.TabIndex = 20;
            this.lbViewBills.Text = "View Bills";
            this.lbViewBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbViewBills.Click += new System.EventHandler(this.lbViewBills_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(600, 668);
            this.Controls.Add(this.lbViewBills);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbDiscAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDiscPercent);
            this.Controls.Add(this.btnDiscFixed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiscAmount);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSignout);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSignout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalItems;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.TextBox tbDiscAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiscFixed;
        private System.Windows.Forms.Button btnDiscPercent;
        private System.Windows.Forms.Label lbDiscAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbQuantity;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbViewBills;
    }
}