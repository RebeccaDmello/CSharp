namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSal = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxAddon = new System.Windows.Forms.GroupBox();
            this.chkbxFrench = new System.Windows.Forms.CheckBox();
            this.chkbxKetchup = new System.Windows.Forms.CheckBox();
            this.chkbxLettuce = new System.Windows.Forms.CheckBox();
            this.gbxMainCourse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxAddon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoSal);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Controls.Add(this.rdoHam);
            this.gbxMainCourse.Location = new System.Drawing.Point(39, 21);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxMainCourse.Size = new System.Drawing.Size(191, 131);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course";
            // 
            // rdoSal
            // 
            this.rdoSal.AutoSize = true;
            this.rdoSal.Location = new System.Drawing.Point(20, 88);
            this.rdoSal.Name = "rdoSal";
            this.rdoSal.Size = new System.Drawing.Size(116, 24);
            this.rdoSal.TabIndex = 2;
            this.rdoSal.Text = "Salad - $4.95";
            this.rdoSal.UseVisualStyleBackColor = true;
            this.rdoSal.CheckedChanged += new System.EventHandler(this.rdoSal_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(20, 58);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(113, 24);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHam
            // 
            this.rdoHam.AutoSize = true;
            this.rdoHam.Checked = true;
            this.rdoHam.Location = new System.Drawing.Point(20, 27);
            this.rdoHam.Name = "rdoHam";
            this.rdoHam.Size = new System.Drawing.Size(155, 24);
            this.rdoHam.TabIndex = 0;
            this.rdoHam.TabStop = true;
            this.rdoHam.Text = "Hamburger - $6.95";
            this.rdoHam.UseVisualStyleBackColor = true;
            this.rdoHam.CheckedChanged += new System.EventHandler(this.rdoHam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSalesTax);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(39, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(297, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(128, 101);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(121, 27);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(128, 67);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(121, 27);
            this.txtSalesTax.TabIndex = 3;
            this.txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(128, 31);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 27);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(366, 189);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(118, 33);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 296);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxAddon
            // 
            this.gbxAddon.Controls.Add(this.chkbxFrench);
            this.gbxAddon.Controls.Add(this.chkbxKetchup);
            this.gbxAddon.Controls.Add(this.chkbxLettuce);
            this.gbxAddon.Location = new System.Drawing.Point(270, 21);
            this.gbxAddon.Name = "gbxAddon";
            this.gbxAddon.Size = new System.Drawing.Size(266, 131);
            this.gbxAddon.TabIndex = 4;
            this.gbxAddon.TabStop = false;
            this.gbxAddon.Text = "Add-on items ($.75/each)";
            // 
            // chkbxFrench
            // 
            this.chkbxFrench.AutoSize = true;
            this.chkbxFrench.Location = new System.Drawing.Point(24, 89);
            this.chkbxFrench.Name = "chkbxFrench";
            this.chkbxFrench.Size = new System.Drawing.Size(106, 24);
            this.chkbxFrench.TabIndex = 2;
            this.chkbxFrench.Text = "French fries";
            this.chkbxFrench.UseVisualStyleBackColor = true;
            // 
            // chkbxKetchup
            // 
            this.chkbxKetchup.AutoSize = true;
            this.chkbxKetchup.Location = new System.Drawing.Point(24, 59);
            this.chkbxKetchup.Name = "chkbxKetchup";
            this.chkbxKetchup.Size = new System.Drawing.Size(219, 24);
            this.chkbxKetchup.TabIndex = 1;
            this.chkbxKetchup.Text = "Ketchup, mustard, and mayo";
            this.chkbxKetchup.UseVisualStyleBackColor = true;
            // 
            // chkbxLettuce
            // 
            this.chkbxLettuce.AutoSize = true;
            this.chkbxLettuce.Location = new System.Drawing.Point(24, 28);
            this.chkbxLettuce.Name = "chkbxLettuce";
            this.chkbxLettuce.Size = new System.Drawing.Size(229, 24);
            this.chkbxLettuce.TabIndex = 0;
            this.chkbxLettuce.Text = "Lettuce, tomatoes, and onions";
            this.chkbxLettuce.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.gbxAddon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxMainCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxAddon.ResumeLayout(false);
            this.gbxAddon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoSal;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHam;
        private System.Windows.Forms.GroupBox gbxAddon;
        private System.Windows.Forms.CheckBox chkbxFrench;
        private System.Windows.Forms.CheckBox chkbxKetchup;
        private System.Windows.Forms.CheckBox chkbxLettuce;
    }
}

