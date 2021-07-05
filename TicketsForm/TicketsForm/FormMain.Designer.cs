
namespace TicketsForm
{
    partial class frmMain
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
            this.grpBxGuests = new System.Windows.Forms.GroupBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.grpBxTicket = new System.Windows.Forms.GroupBox();
            this.lblNextSlot = new System.Windows.Forms.Label();
            this.lblTckRes = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBxGuests.SuspendLayout();
            this.grpBxTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxGuests
            // 
            this.grpBxGuests.Controls.Add(this.lblGuests);
            this.grpBxGuests.Location = new System.Drawing.Point(14, 11);
            this.grpBxGuests.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxGuests.Name = "grpBxGuests";
            this.grpBxGuests.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxGuests.Size = new System.Drawing.Size(256, 56);
            this.grpBxGuests.TabIndex = 0;
            this.grpBxGuests.TabStop = false;
            this.grpBxGuests.Text = "Guests with the following tickets may now enter:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(16, 26);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(0, 13);
            this.lblGuests.TabIndex = 0;
            // 
            // grpBxTicket
            // 
            this.grpBxTicket.Controls.Add(this.lblNextSlot);
            this.grpBxTicket.Controls.Add(this.lblTckRes);
            this.grpBxTicket.Controls.Add(this.btnIssue);
            this.grpBxTicket.Controls.Add(this.lblNext);
            this.grpBxTicket.Controls.Add(this.lblTotal);
            this.grpBxTicket.Location = new System.Drawing.Point(14, 71);
            this.grpBxTicket.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxTicket.Name = "grpBxTicket";
            this.grpBxTicket.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxTicket.Size = new System.Drawing.Size(258, 131);
            this.grpBxTicket.TabIndex = 1;
            this.grpBxTicket.TabStop = false;
            this.grpBxTicket.Text = "Ticket Availability";
            // 
            // lblNextSlot
            // 
            this.lblNextSlot.AutoSize = true;
            this.lblNextSlot.Location = new System.Drawing.Point(171, 54);
            this.lblNextSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextSlot.Name = "lblNextSlot";
            this.lblNextSlot.Size = new System.Drawing.Size(0, 13);
            this.lblNextSlot.TabIndex = 4;
            // 
            // lblTckRes
            // 
            this.lblTckRes.AutoSize = true;
            this.lblTckRes.Location = new System.Drawing.Point(171, 24);
            this.lblTckRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTckRes.Name = "lblTckRes";
            this.lblTckRes.Size = new System.Drawing.Size(0, 13);
            this.lblTckRes.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(19, 86);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(2);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(123, 26);
            this.btnIssue.TabIndex = 1;
            this.btnIssue.Text = "Issue Ticket";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(16, 54);
            this.lblNext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(103, 13);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Next available entry:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 24);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total tickets outstanding:";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(14, 206);
            this.lstResult.Margin = new System.Windows.Forms.Padding(2);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(258, 173);
            this.lstResult.TabIndex = 10;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(14, 383);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(84, 28);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 383);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.grpBxTicket);
            this.Controls.Add(this.grpBxGuests);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBxGuests.ResumeLayout(false);
            this.grpBxGuests.PerformLayout();
            this.grpBxTicket.ResumeLayout(false);
            this.grpBxTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxGuests;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.GroupBox grpBxTicket;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNextSlot;
        private System.Windows.Forms.Label lblTckRes;
        private System.Windows.Forms.Button btnIssue;
        public System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
    }
}