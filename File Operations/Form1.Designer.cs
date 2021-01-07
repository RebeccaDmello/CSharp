using System;

namespace FileOperation
{
    partial class DataFile
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
            this.lblMain = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdBtnSumry = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.grpBxStockNm = new System.Windows.Forms.GroupBox();
            this.grpBxShares = new System.Windows.Forms.GroupBox();
            this.grpBxPurPrice = new System.Windows.Forms.GroupBox();
            this.txtPurPrice = new System.Windows.Forms.TextBox();
            this.grpBxPriceFile = new System.Windows.Forms.GroupBox();
            this.txtCurPriceF = new System.Windows.Forms.TextBox();
            this.grpBxPriceNew = new System.Windows.Forms.GroupBox();
            this.txtCurPriceN = new System.Windows.Forms.TextBox();
            this.grpBxStockNm.SuspendLayout();
            this.grpBxShares.SuspendLayout();
            this.grpBxPurPrice.SuspendLayout();
            this.grpBxPriceFile.SuspendLayout();
            this.grpBxPriceNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Tomato;
            this.lblMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(217, 43);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(355, 45);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Stock Portfolio";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(21, 19);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(131, 25);
            this.txtStockName.TabIndex = 1;
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(19, 19);
            this.txtShares.Name = "txtShares";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(104, 25);
            this.txtShares.TabIndex = 5;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(83, 273);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(374, 147);
            this.lstResult.TabIndex = 6;
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Checked = true;
            this.rdoDetails.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDetails.Location = new System.Drawing.Point(517, 273);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(106, 23);
            this.rdoDetails.TabIndex = 7;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Show Detail";
            this.rdoDetails.UseVisualStyleBackColor = true;
            // 
            // rdBtnSumry
            // 
            this.rdBtnSumry.AutoSize = true;
            this.rdBtnSumry.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnSumry.Location = new System.Drawing.Point(517, 330);
            this.rdBtnSumry.Name = "rdBtnSumry";
            this.rdBtnSumry.Size = new System.Drawing.Size(130, 23);
            this.rdBtnSumry.TabIndex = 8;
            this.rdBtnSumry.TabStop = true;
            this.rdBtnSumry.Text = "Show Summary";
            this.rdBtnSumry.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(517, 389);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(173, 31);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click_1);
            // 
            // grpBxStockNm
            // 
            this.grpBxStockNm.Controls.Add(this.txtStockName);
            this.grpBxStockNm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxStockNm.Location = new System.Drawing.Point(93, 147);
            this.grpBxStockNm.Name = "grpBxStockNm";
            this.grpBxStockNm.Size = new System.Drawing.Size(165, 54);
            this.grpBxStockNm.TabIndex = 10;
            this.grpBxStockNm.TabStop = false;
            this.grpBxStockNm.Text = "Enter Stock Name";
            // 
            // grpBxShares
            // 
            this.grpBxShares.Controls.Add(this.txtShares);
            this.grpBxShares.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxShares.Location = new System.Drawing.Point(297, 118);
            this.grpBxShares.Name = "grpBxShares";
            this.grpBxShares.Size = new System.Drawing.Size(144, 54);
            this.grpBxShares.TabIndex = 11;
            this.grpBxShares.TabStop = false;
            this.grpBxShares.Text = "Shares";
            // 
            // grpBxPurPrice
            // 
            this.grpBxPurPrice.Controls.Add(this.txtPurPrice);
            this.grpBxPurPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPurPrice.Location = new System.Drawing.Point(297, 178);
            this.grpBxPurPrice.Name = "grpBxPurPrice";
            this.grpBxPurPrice.Size = new System.Drawing.Size(144, 54);
            this.grpBxPurPrice.TabIndex = 12;
            this.grpBxPurPrice.TabStop = false;
            this.grpBxPurPrice.Text = "Purchase Price";
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.Location = new System.Drawing.Point(19, 19);
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.ReadOnly = true;
            this.txtPurPrice.Size = new System.Drawing.Size(104, 25);
            this.txtPurPrice.TabIndex = 5;
            // 
            // grpBxPriceFile
            // 
            this.grpBxPriceFile.Controls.Add(this.txtCurPriceF);
            this.grpBxPriceFile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPriceFile.Location = new System.Drawing.Point(498, 108);
            this.grpBxPriceFile.Name = "grpBxPriceFile";
            this.grpBxPriceFile.Size = new System.Drawing.Size(192, 54);
            this.grpBxPriceFile.TabIndex = 13;
            this.grpBxPriceFile.TabStop = false;
            this.grpBxPriceFile.Text = "Current Price from File";
            // 
            // txtCurPriceF
            // 
            this.txtCurPriceF.Location = new System.Drawing.Point(19, 23);
            this.txtCurPriceF.Name = "txtCurPriceF";
            this.txtCurPriceF.ReadOnly = true;
            this.txtCurPriceF.Size = new System.Drawing.Size(143, 25);
            this.txtCurPriceF.TabIndex = 5;
            // 
            // grpBxPriceNew
            // 
            this.grpBxPriceNew.Controls.Add(this.txtCurPriceN);
            this.grpBxPriceNew.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPriceNew.Location = new System.Drawing.Point(498, 178);
            this.grpBxPriceNew.Name = "grpBxPriceNew";
            this.grpBxPriceNew.Size = new System.Drawing.Size(192, 54);
            this.grpBxPriceNew.TabIndex = 13;
            this.grpBxPriceNew.TabStop = false;
            this.grpBxPriceNew.Text = "Current Price (New)";
            // 
            // txtCurPriceN
            // 
            this.txtCurPriceN.Location = new System.Drawing.Point(19, 24);
            this.txtCurPriceN.Name = "txtCurPriceN";
            this.txtCurPriceN.Size = new System.Drawing.Size(143, 25);
            this.txtCurPriceN.TabIndex = 5;
            // 
            // csis1175W2020Assign2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBxPriceFile);
            this.Controls.Add(this.grpBxPriceNew);
            this.Controls.Add(this.grpBxPurPrice);
            this.Controls.Add(this.grpBxShares);
            this.Controls.Add(this.grpBxStockNm);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rdBtnSumry);
            this.Controls.Add(this.rdoDetails);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.lblMain);
            this.Name = "csis1175W2020Assign2";
            this.Text = "Data from File";
            this.Load += new System.EventHandler(this.csis1175W2020Assign2_Load);
            this.grpBxStockNm.ResumeLayout(false);
            this.grpBxStockNm.PerformLayout();
            this.grpBxShares.ResumeLayout(false);
            this.grpBxShares.PerformLayout();
            this.grpBxPurPrice.ResumeLayout(false);
            this.grpBxPurPrice.PerformLayout();
            this.grpBxPriceFile.ResumeLayout(false);
            this.grpBxPriceFile.PerformLayout();
            this.grpBxPriceNew.ResumeLayout(false);
            this.grpBxPriceNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void csis1175W2020Assign2_Load(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdBtnSumry;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox grpBxStockNm;
        private System.Windows.Forms.GroupBox grpBxShares;
        private System.Windows.Forms.GroupBox grpBxPurPrice;
        private System.Windows.Forms.TextBox txtPurPrice;
        private System.Windows.Forms.GroupBox grpBxPriceFile;
        private System.Windows.Forms.TextBox txtCurPriceF;
        private System.Windows.Forms.GroupBox grpBxPriceNew;
        private System.Windows.Forms.TextBox txtCurPriceN;
    }
}

