
namespace UnitConversions
{
    partial class FrmAddConversion
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
            this.lblForFrom = new System.Windows.Forms.Label();
            this.lblForTo = new System.Windows.Forms.Label();
            this.lblForMultiplier = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForFrom
            // 
            this.lblForFrom.AutoSize = true;
            this.lblForFrom.Location = new System.Drawing.Point(6, 6);
            this.lblForFrom.Name = "lblForFrom";
            this.lblForFrom.Size = new System.Drawing.Size(33, 13);
            this.lblForFrom.TabIndex = 0;
            this.lblForFrom.Text = "From:";
            // 
            // lblForTo
            // 
            this.lblForTo.AutoSize = true;
            this.lblForTo.Location = new System.Drawing.Point(6, 32);
            this.lblForTo.Name = "lblForTo";
            this.lblForTo.Size = new System.Drawing.Size(23, 13);
            this.lblForTo.TabIndex = 1;
            this.lblForTo.Text = "To:";
            // 
            // lblForMultiplier
            // 
            this.lblForMultiplier.AutoSize = true;
            this.lblForMultiplier.Location = new System.Drawing.Point(6, 58);
            this.lblForMultiplier.Name = "lblForMultiplier";
            this.lblForMultiplier.Size = new System.Drawing.Size(51, 13);
            this.lblForMultiplier.TabIndex = 2;
            this.lblForMultiplier.Text = "Multiplier:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(72, 3);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(108, 20);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.Tag = "From value";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(72, 29);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(108, 20);
            this.txtTo.TabIndex = 4;
            this.txtTo.Tag = "To value";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(72, 55);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(108, 20);
            this.txtMultiplier.TabIndex = 5;
            this.txtMultiplier.Tag = "Multiplier value";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 81);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(195, 131);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblForMultiplier);
            this.Controls.Add(this.lblForTo);
            this.Controls.Add(this.lblForFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddConversion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForFrom;
        private System.Windows.Forms.Label lblForTo;
        private System.Windows.Forms.Label lblForMultiplier;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}