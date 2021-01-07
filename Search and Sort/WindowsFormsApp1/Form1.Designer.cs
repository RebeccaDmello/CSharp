namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.grpBxNameOnly = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.rbExact = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.grpBxNameOnly.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(12, 12);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 45);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Sort by Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 63);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 45);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sort by Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lstRes
            // 
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Location = new System.Drawing.Point(96, 13);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(500, 95);
            this.lstRes.TabIndex = 2;
            // 
            // grpBxNameOnly
            // 
            this.grpBxNameOnly.Controls.Add(this.btnSearch);
            this.grpBxNameOnly.Controls.Add(this.txtBxSearch);
            this.grpBxNameOnly.Controls.Add(this.rbExact);
            this.grpBxNameOnly.Controls.Add(this.rbEnd);
            this.grpBxNameOnly.Controls.Add(this.rbStart);
            this.grpBxNameOnly.Location = new System.Drawing.Point(96, 114);
            this.grpBxNameOnly.Name = "grpBxNameOnly";
            this.grpBxNameOnly.Size = new System.Drawing.Size(500, 86);
            this.grpBxNameOnly.TabIndex = 3;
            this.grpBxNameOnly.TabStop = false;
            this.grpBxNameOnly.Text = "Search by Name only";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSearch.Location = new System.Drawing.Point(15, 53);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(205, 25);
            this.txtBxSearch.TabIndex = 3;
            this.txtBxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbExact
            // 
            this.rbExact.AutoSize = true;
            this.rbExact.Checked = true;
            this.rbExact.Location = new System.Drawing.Point(250, 12);
            this.rbExact.Name = "rbExact";
            this.rbExact.Size = new System.Drawing.Size(171, 30);
            this.rbExact.TabIndex = 2;
            this.rbExact.TabStop = true;
            this.rbExact.Text = "Exact or Within Name\r\n(inc. Exact or Start/End/within)";
            this.rbExact.UseVisualStyleBackColor = true;
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(135, 19);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(74, 17);
            this.rbEnd.TabIndex = 1;
            this.rbEnd.Text = "Ends With";
            this.rbEnd.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Location = new System.Drawing.Point(15, 19);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(72, 17);
            this.rbStart.TabIndex = 0;
            this.rbStart.Text = "Start With";
            this.rbStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 212);
            this.Controls.Add(this.grpBxNameOnly);
            this.Controls.Add(this.lstRes);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnName);
            this.Name = "Form1";
            this.Text = "Search and Sort";
            this.grpBxNameOnly.ResumeLayout(false);
            this.grpBxNameOnly.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.GroupBox grpBxNameOnly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.RadioButton rbExact;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.RadioButton rbStart;
    }
}

