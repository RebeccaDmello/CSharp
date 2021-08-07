
namespace UnitConversions
{
    partial class FrmConversions
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
            this.lblForValConvert = new System.Windows.Forms.Label();
            this.lblForConversions = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtValConvert = new System.Windows.Forms.TextBox();
            this.lstConversions = new System.Windows.Forms.ListBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblForValConvert
            // 
            this.lblForValConvert.AutoSize = true;
            this.lblForValConvert.Location = new System.Drawing.Point(12, 9);
            this.lblForValConvert.Name = "lblForValConvert";
            this.lblForValConvert.Size = new System.Drawing.Size(93, 13);
            this.lblForValConvert.TabIndex = 0;
            this.lblForValConvert.Text = "Value To Convert:";
            // 
            // lblForConversions
            // 
            this.lblForConversions.AutoSize = true;
            this.lblForConversions.Location = new System.Drawing.Point(12, 48);
            this.lblForConversions.Name = "lblForConversions";
            this.lblForConversions.Size = new System.Drawing.Size(68, 13);
            this.lblForConversions.TabIndex = 1;
            this.lblForConversions.Text = "Conversions:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 309);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(122, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(203, 309);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(121, 23);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "Manage Conversions";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(379, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtValConvert
            // 
            this.txtValConvert.Location = new System.Drawing.Point(12, 25);
            this.txtValConvert.Name = "txtValConvert";
            this.txtValConvert.Size = new System.Drawing.Size(185, 20);
            this.txtValConvert.TabIndex = 6;
            this.txtValConvert.Tag = "Amount for conversion";
            // 
            // lstConversions
            // 
            this.lstConversions.FormattingEnabled = true;
            this.lstConversions.Location = new System.Drawing.Point(12, 64);
            this.lstConversions.Name = "lstConversions";
            this.lstConversions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstConversions.Size = new System.Drawing.Size(185, 238);
            this.lstConversions.TabIndex = 9;
            this.lstConversions.Tag = "Converisons listbox";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(203, 12);
            this.lstResults.Name = "lstResults";
            this.lstResults.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstResults.Size = new System.Drawing.Size(251, 290);
            this.lstResults.TabIndex = 10;
            // 
            // FrmConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 344);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lstConversions);
            this.Controls.Add(this.txtValConvert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblForConversions);
            this.Controls.Add(this.lblForValConvert);
            this.MaximizeBox = false;
            this.Name = "FrmConversions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.FrmConversions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForValConvert;
        private System.Windows.Forms.Label lblForConversions;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtValConvert;
        private System.Windows.Forms.ListBox lstConversions;
        private System.Windows.Forms.ListBox lstResults;
    }
}

