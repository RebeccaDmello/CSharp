namespace WindowsFormsApplicationRebecca
{
    partial class GUICalculator
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
            this.lblTop = new System.Windows.Forms.Label();
            this.lblFxdOrdCst = new System.Windows.Forms.Label();
            this.lblUntCst = new System.Windows.Forms.Label();
            this.lblDmdRate = new System.Windows.Forms.Label();
            this.lblCryCstRate = new System.Windows.Forms.Label();
            this.grpBxFOC = new System.Windows.Forms.GroupBox();
            this.txtBxFOC = new System.Windows.Forms.TextBox();
            this.grpBxUntCst = new System.Windows.Forms.GroupBox();
            this.txtBxUC = new System.Windows.Forms.TextBox();
            this.grpBxDR = new System.Windows.Forms.GroupBox();
            this.txtBxDR = new System.Windows.Forms.TextBox();
            this.grpBxCCR = new System.Windows.Forms.GroupBox();
            this.txtBxCCR = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpBxFOC.SuspendLayout();
            this.grpBxUntCst.SuspendLayout();
            this.grpBxDR.SuspendLayout();
            this.grpBxCCR.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(62, 29);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(612, 54);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Economic Order Quantity";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFxdOrdCst
            // 
            this.lblFxdOrdCst.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFxdOrdCst.Location = new System.Drawing.Point(71, 161);
            this.lblFxdOrdCst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFxdOrdCst.Name = "lblFxdOrdCst";
            this.lblFxdOrdCst.Size = new System.Drawing.Size(98, 50);
            this.lblFxdOrdCst.TabIndex = 1;
            this.lblFxdOrdCst.Text = "Fixed Order Cost";
            // 
            // lblUntCst
            // 
            this.lblUntCst.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUntCst.Location = new System.Drawing.Point(421, 284);
            this.lblUntCst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUntCst.Name = "lblUntCst";
            this.lblUntCst.Size = new System.Drawing.Size(98, 50);
            this.lblUntCst.TabIndex = 2;
            this.lblUntCst.Text = "Unit Cost";
            this.lblUntCst.Click += new System.EventHandler(this.lblUntCst_Click);
            // 
            // lblDmdRate
            // 
            this.lblDmdRate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmdRate.Location = new System.Drawing.Point(421, 161);
            this.lblDmdRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDmdRate.Name = "lblDmdRate";
            this.lblDmdRate.Size = new System.Drawing.Size(98, 50);
            this.lblDmdRate.TabIndex = 3;
            this.lblDmdRate.Text = "Demand Rate";
            // 
            // lblCryCstRate
            // 
            this.lblCryCstRate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCryCstRate.Location = new System.Drawing.Point(71, 284);
            this.lblCryCstRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCryCstRate.Name = "lblCryCstRate";
            this.lblCryCstRate.Size = new System.Drawing.Size(98, 50);
            this.lblCryCstRate.TabIndex = 4;
            this.lblCryCstRate.Text = "Carry Cost Rate";
            // 
            // grpBxFOC
            // 
            this.grpBxFOC.Controls.Add(this.txtBxFOC);
            this.grpBxFOC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFOC.Location = new System.Drawing.Point(174, 161);
            this.grpBxFOC.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxFOC.Name = "grpBxFOC";
            this.grpBxFOC.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxFOC.Size = new System.Drawing.Size(150, 65);
            this.grpBxFOC.TabIndex = 5;
            this.grpBxFOC.TabStop = false;
            this.grpBxFOC.Text = "(0.00, $/unit)";
            // 
            // txtBxFOC
            // 
            this.txtBxFOC.Location = new System.Drawing.Point(22, 26);
            this.txtBxFOC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxFOC.Name = "txtBxFOC";
            this.txtBxFOC.Size = new System.Drawing.Size(111, 25);
            this.txtBxFOC.TabIndex = 5;
            this.txtBxFOC.TextChanged += new System.EventHandler(this.txtBxFOC_TextChanged);
            // 
            // grpBxUntCst
            // 
            this.grpBxUntCst.Controls.Add(this.txtBxUC);
            this.grpBxUntCst.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxUntCst.Location = new System.Drawing.Point(524, 284);
            this.grpBxUntCst.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxUntCst.Name = "grpBxUntCst";
            this.grpBxUntCst.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxUntCst.Size = new System.Drawing.Size(150, 58);
            this.grpBxUntCst.TabIndex = 8;
            this.grpBxUntCst.TabStop = false;
            this.grpBxUntCst.Text = "(0.00, $/unit)";
            // 
            // txtBxUC
            // 
            this.txtBxUC.Location = new System.Drawing.Point(28, 24);
            this.txtBxUC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxUC.Name = "txtBxUC";
            this.txtBxUC.Size = new System.Drawing.Size(111, 25);
            this.txtBxUC.TabIndex = 8;
            // 
            // grpBxDR
            // 
            this.grpBxDR.Controls.Add(this.txtBxDR);
            this.grpBxDR.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxDR.Location = new System.Drawing.Point(524, 161);
            this.grpBxDR.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxDR.Name = "grpBxDR";
            this.grpBxDR.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxDR.Size = new System.Drawing.Size(150, 58);
            this.grpBxDR.TabIndex = 6;
            this.grpBxDR.TabStop = false;
            this.grpBxDR.Text = "(0, unit/yr)";
            // 
            // txtBxDR
            // 
            this.txtBxDR.Location = new System.Drawing.Point(20, 26);
            this.txtBxDR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxDR.Name = "txtBxDR";
            this.txtBxDR.Size = new System.Drawing.Size(111, 25);
            this.txtBxDR.TabIndex = 6;
            // 
            // grpBxCCR
            // 
            this.grpBxCCR.Controls.Add(this.txtBxCCR);
            this.grpBxCCR.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCCR.Location = new System.Drawing.Point(174, 284);
            this.grpBxCCR.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxCCR.Name = "grpBxCCR";
            this.grpBxCCR.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxCCR.Size = new System.Drawing.Size(150, 58);
            this.grpBxCCR.TabIndex = 7;
            this.grpBxCCR.TabStop = false;
            this.grpBxCCR.Text = "(0.00, %)";
            // 
            // txtBxCCR
            // 
            this.txtBxCCR.Location = new System.Drawing.Point(20, 24);
            this.txtBxCCR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxCCR.Name = "txtBxCCR";
            this.txtBxCCR.Size = new System.Drawing.Size(111, 25);
            this.txtBxCCR.TabIndex = 7;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(304, 401);
            this.btnCal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(154, 48);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(75, 401);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 132);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 401);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 132);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Gold;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(116, 485);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(519, 48);
            this.lblResult.TabIndex = 11;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 568);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.grpBxUntCst);
            this.Controls.Add(this.grpBxDR);
            this.Controls.Add(this.grpBxCCR);
            this.Controls.Add(this.grpBxFOC);
            this.Controls.Add(this.lblCryCstRate);
            this.Controls.Add(this.lblDmdRate);
            this.Controls.Add(this.lblUntCst);
            this.Controls.Add(this.lblFxdOrdCst);
            this.Controls.Add(this.lblTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUICalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxFOC.ResumeLayout(false);
            this.grpBxFOC.PerformLayout();
            this.grpBxUntCst.ResumeLayout(false);
            this.grpBxUntCst.PerformLayout();
            this.grpBxDR.ResumeLayout(false);
            this.grpBxDR.PerformLayout();
            this.grpBxCCR.ResumeLayout(false);
            this.grpBxCCR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblFxdOrdCst;
        private System.Windows.Forms.Label lblUntCst;
        private System.Windows.Forms.Label lblDmdRate;
        private System.Windows.Forms.Label lblCryCstRate;
        private System.Windows.Forms.GroupBox grpBxFOC;
        private System.Windows.Forms.GroupBox grpBxUntCst;
        private System.Windows.Forms.GroupBox grpBxDR;
        private System.Windows.Forms.GroupBox grpBxCCR;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBxFOC;
        private System.Windows.Forms.TextBox txtBxUC;
        private System.Windows.Forms.TextBox txtBxDR;
        private System.Windows.Forms.TextBox txtBxCCR;
    }
}

