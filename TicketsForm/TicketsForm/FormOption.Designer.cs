
namespace TicketsForm
{
    partial class frmOption
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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblFstTck = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBxMinPerWindow = new System.Windows.Forms.TextBox();
            this.txtBxGuestsPerWindow = new System.Windows.Forms.TextBox();
            this.txtBxStart = new System.Windows.Forms.TextBox();
            this.txtBxEnd = new System.Windows.Forms.TextBox();
            this.txtBxFstTckNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(15, 11);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(135, 17);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "Minutes per window:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(15, 41);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(131, 17);
            this.lblGuests.TabIndex = 1;
            this.lblGuests.Text = "Guests per window:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(15, 70);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 17);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start time:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(15, 100);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(67, 17);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End time:";
            // 
            // lblFstTck
            // 
            this.lblFstTck.AutoSize = true;
            this.lblFstTck.Location = new System.Drawing.Point(15, 129);
            this.lblFstTck.Name = "lblFstTck";
            this.lblFstTck.Size = new System.Drawing.Size(128, 17);
            this.lblFstTck.TabIndex = 4;
            this.lblFstTck.Text = "First ticket number:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(159, 155);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(184, 34);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBxMinPerWindow
            // 
            this.txtBxMinPerWindow.Location = new System.Drawing.Point(159, 7);
            this.txtBxMinPerWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxMinPerWindow.Name = "txtBxMinPerWindow";
            this.txtBxMinPerWindow.Size = new System.Drawing.Size(183, 22);
            this.txtBxMinPerWindow.TabIndex = 6;
            this.txtBxMinPerWindow.Tag = "Minutes Per Window";
            // 
            // txtBxGuestsPerWindow
            // 
            this.txtBxGuestsPerWindow.Location = new System.Drawing.Point(159, 37);
            this.txtBxGuestsPerWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxGuestsPerWindow.Name = "txtBxGuestsPerWindow";
            this.txtBxGuestsPerWindow.Size = new System.Drawing.Size(183, 22);
            this.txtBxGuestsPerWindow.TabIndex = 7;
            this.txtBxGuestsPerWindow.Tag = "Guests Per Window";
            // 
            // txtBxStart
            // 
            this.txtBxStart.Location = new System.Drawing.Point(159, 66);
            this.txtBxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxStart.Name = "txtBxStart";
            this.txtBxStart.Size = new System.Drawing.Size(183, 22);
            this.txtBxStart.TabIndex = 8;
            this.txtBxStart.Tag = "Start Time";
            // 
            // txtBxEnd
            // 
            this.txtBxEnd.Location = new System.Drawing.Point(159, 96);
            this.txtBxEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEnd.Name = "txtBxEnd";
            this.txtBxEnd.Size = new System.Drawing.Size(183, 22);
            this.txtBxEnd.TabIndex = 9;
            this.txtBxEnd.Tag = "End Time";
            // 
            // txtBxFstTckNo
            // 
            this.txtBxFstTckNo.Location = new System.Drawing.Point(159, 126);
            this.txtBxFstTckNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxFstTckNo.Name = "txtBxFstTckNo";
            this.txtBxFstTckNo.Size = new System.Drawing.Size(183, 22);
            this.txtBxFstTckNo.TabIndex = 10;
            this.txtBxFstTckNo.Tag = "First Ticket Number";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 197);
            this.Controls.Add(this.txtBxFstTckNo);
            this.Controls.Add(this.txtBxEnd);
            this.Controls.Add(this.txtBxStart);
            this.Controls.Add(this.txtBxGuestsPerWindow);
            this.Controls.Add(this.txtBxMinPerWindow);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblFstTck);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblMinutes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblFstTck;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBxMinPerWindow;
        private System.Windows.Forms.TextBox txtBxGuestsPerWindow;
        private System.Windows.Forms.TextBox txtBxStart;
        private System.Windows.Forms.TextBox txtBxEnd;
        private System.Windows.Forms.TextBox txtBxFstTckNo;
    }
}