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
            this.lblMain = new System.Windows.Forms.Label();
            this.grpBxLod = new System.Windows.Forms.GroupBox();
            this.lstBxDays = new System.Windows.Forms.ListBox();
            this.grpBxAmtDay = new System.Windows.Forms.GroupBox();
            this.txtBxAmtDay = new System.Windows.Forms.TextBox();
            this.grpBxAF = new System.Windows.Forms.GroupBox();
            this.txtBxAirFare = new System.Windows.Forms.TextBox();
            this.grpBxCRD = new System.Windows.Forms.GroupBox();
            this.grpBxParking = new System.Windows.Forms.GroupBox();
            this.txtBxRentPark = new System.Windows.Forms.TextBox();
            this.lstBxCRD = new System.Windows.Forms.ListBox();
            this.txtBxCRD = new System.Windows.Forms.TextBox();
            this.grpBxPriMiles = new System.Windows.Forms.GroupBox();
            this.grpBxParkPriv = new System.Windows.Forms.GroupBox();
            this.txtBxPriPark = new System.Windows.Forms.TextBox();
            this.txtBxPriMiles = new System.Windows.Forms.TextBox();
            this.grpBxTaxiFare = new System.Windows.Forms.GroupBox();
            this.txtBxTaxiFare = new System.Windows.Forms.TextBox();
            this.grpBxEvents = new System.Windows.Forms.GroupBox();
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.btnResetEvt = new System.Windows.Forms.Button();
            this.grpBxITSecu = new System.Windows.Forms.GroupBox();
            this.chkBxAttack = new System.Windows.Forms.CheckBox();
            this.chkBxEncry = new System.Windows.Forms.CheckBox();
            this.chkBxOS = new System.Windows.Forms.CheckBox();
            this.lblTotExp = new System.Windows.Forms.Label();
            this.lblReimbursemnt = new System.Windows.Forms.Label();
            this.lblYouPay = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBxTExpn = new System.Windows.Forms.TextBox();
            this.txtBxReimburse = new System.Windows.Forms.TextBox();
            this.txtBxYouPay = new System.Windows.Forms.TextBox();
            this.grpBxLod.SuspendLayout();
            this.grpBxAmtDay.SuspendLayout();
            this.grpBxAF.SuspendLayout();
            this.grpBxCRD.SuspendLayout();
            this.grpBxParking.SuspendLayout();
            this.grpBxPriMiles.SuspendLayout();
            this.grpBxParkPriv.SuspendLayout();
            this.grpBxTaxiFare.SuspendLayout();
            this.grpBxEvents.SuspendLayout();
            this.grpBxITSecu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Khaki;
            this.lblMain.Location = new System.Drawing.Point(55, 27);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(758, 50);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Travel Expenses Calculator";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxLod
            // 
            this.grpBxLod.Controls.Add(this.lstBxDays);
            this.grpBxLod.Controls.Add(this.grpBxAmtDay);
            this.grpBxLod.Location = new System.Drawing.Point(59, 100);
            this.grpBxLod.Name = "grpBxLod";
            this.grpBxLod.Size = new System.Drawing.Size(301, 120);
            this.grpBxLod.TabIndex = 1;
            this.grpBxLod.TabStop = false;
            this.grpBxLod.Text = "Lodging";
            // 
            // lstBxDays
            // 
            this.lstBxDays.FormattingEnabled = true;
            this.lstBxDays.Items.AddRange(new object[] {
            "1 Day(s)",
            "2 Day(s)",
            "3 Day(s)",
            "4 Day(s)",
            "5 Day(s)",
            "6 Day(s)",
            "7 Day(s)",
            "8 Day(s)",
            "9 Day(s)",
            "10 Day(s)",
            "11 Day(s)",
            "12 Day(s)",
            "13 Day(s)",
            "14 Day(s)",
            ""});
            this.lstBxDays.Location = new System.Drawing.Point(195, 42);
            this.lstBxDays.Name = "lstBxDays";
            this.lstBxDays.Size = new System.Drawing.Size(87, 56);
            this.lstBxDays.TabIndex = 1;
            this.lstBxDays.SelectedIndexChanged += new System.EventHandler(this.lstBxDays_SelectedIndexChanged);
            // 
            // grpBxAmtDay
            // 
            this.grpBxAmtDay.Controls.Add(this.txtBxAmtDay);
            this.grpBxAmtDay.Location = new System.Drawing.Point(23, 28);
            this.grpBxAmtDay.Name = "grpBxAmtDay";
            this.grpBxAmtDay.Size = new System.Drawing.Size(129, 67);
            this.grpBxAmtDay.TabIndex = 0;
            this.grpBxAmtDay.TabStop = false;
            this.grpBxAmtDay.Text = "Amount/Day($)";
            // 
            // txtBxAmtDay
            // 
            this.txtBxAmtDay.BackColor = System.Drawing.Color.Yellow;
            this.txtBxAmtDay.Location = new System.Drawing.Point(23, 28);
            this.txtBxAmtDay.Name = "txtBxAmtDay";
            this.txtBxAmtDay.Size = new System.Drawing.Size(100, 20);
            this.txtBxAmtDay.TabIndex = 0;
            // 
            // grpBxAF
            // 
            this.grpBxAF.Controls.Add(this.txtBxAirFare);
            this.grpBxAF.Location = new System.Drawing.Point(390, 100);
            this.grpBxAF.Name = "grpBxAF";
            this.grpBxAF.Size = new System.Drawing.Size(434, 120);
            this.grpBxAF.TabIndex = 2;
            this.grpBxAF.TabStop = false;
            this.grpBxAF.Text = "Airfare ($)";
            // 
            // txtBxAirFare
            // 
            this.txtBxAirFare.BackColor = System.Drawing.Color.Yellow;
            this.txtBxAirFare.Location = new System.Drawing.Point(37, 56);
            this.txtBxAirFare.Name = "txtBxAirFare";
            this.txtBxAirFare.Size = new System.Drawing.Size(137, 20);
            this.txtBxAirFare.TabIndex = 0;
            // 
            // grpBxCRD
            // 
            this.grpBxCRD.Controls.Add(this.grpBxParking);
            this.grpBxCRD.Controls.Add(this.lstBxCRD);
            this.grpBxCRD.Controls.Add(this.txtBxCRD);
            this.grpBxCRD.Location = new System.Drawing.Point(390, 226);
            this.grpBxCRD.Name = "grpBxCRD";
            this.grpBxCRD.Size = new System.Drawing.Size(434, 115);
            this.grpBxCRD.TabIndex = 0;
            this.grpBxCRD.TabStop = false;
            this.grpBxCRD.Text = "Car Rental/Day ($)";
            // 
            // grpBxParking
            // 
            this.grpBxParking.Controls.Add(this.txtBxRentPark);
            this.grpBxParking.Location = new System.Drawing.Point(290, 40);
            this.grpBxParking.Name = "grpBxParking";
            this.grpBxParking.Size = new System.Drawing.Size(133, 44);
            this.grpBxParking.TabIndex = 3;
            this.grpBxParking.TabStop = false;
            this.grpBxParking.Text = "Parking ($)";
            // 
            // txtBxRentPark
            // 
            this.txtBxRentPark.BackColor = System.Drawing.Color.Yellow;
            this.txtBxRentPark.Location = new System.Drawing.Point(16, 18);
            this.txtBxRentPark.Name = "txtBxRentPark";
            this.txtBxRentPark.Size = new System.Drawing.Size(108, 20);
            this.txtBxRentPark.TabIndex = 1;
            // 
            // lstBxCRD
            // 
            this.lstBxCRD.FormattingEnabled = true;
            this.lstBxCRD.Location = new System.Drawing.Point(155, 40);
            this.lstBxCRD.Name = "lstBxCRD";
            this.lstBxCRD.Size = new System.Drawing.Size(120, 56);
            this.lstBxCRD.TabIndex = 2;
            // 
            // txtBxCRD
            // 
            this.txtBxCRD.BackColor = System.Drawing.Color.Yellow;
            this.txtBxCRD.Location = new System.Drawing.Point(37, 40);
            this.txtBxCRD.Name = "txtBxCRD";
            this.txtBxCRD.Size = new System.Drawing.Size(100, 20);
            this.txtBxCRD.TabIndex = 0;
            // 
            // grpBxPriMiles
            // 
            this.grpBxPriMiles.Controls.Add(this.grpBxParkPriv);
            this.grpBxPriMiles.Controls.Add(this.txtBxPriMiles);
            this.grpBxPriMiles.Location = new System.Drawing.Point(390, 360);
            this.grpBxPriMiles.Name = "grpBxPriMiles";
            this.grpBxPriMiles.Size = new System.Drawing.Size(434, 112);
            this.grpBxPriMiles.TabIndex = 3;
            this.grpBxPriMiles.TabStop = false;
            this.grpBxPriMiles.Text = "Private (miles - $0.43)";
            // 
            // grpBxParkPriv
            // 
            this.grpBxParkPriv.Controls.Add(this.txtBxPriPark);
            this.grpBxParkPriv.Location = new System.Drawing.Point(285, 19);
            this.grpBxParkPriv.Name = "grpBxParkPriv";
            this.grpBxParkPriv.Size = new System.Drawing.Size(138, 44);
            this.grpBxParkPriv.TabIndex = 4;
            this.grpBxParkPriv.TabStop = false;
            this.grpBxParkPriv.Text = "Parking ($)";
            // 
            // txtBxPriPark
            // 
            this.txtBxPriPark.BackColor = System.Drawing.Color.Yellow;
            this.txtBxPriPark.Location = new System.Drawing.Point(16, 18);
            this.txtBxPriPark.Name = "txtBxPriPark";
            this.txtBxPriPark.Size = new System.Drawing.Size(108, 20);
            this.txtBxPriPark.TabIndex = 1;
            // 
            // txtBxPriMiles
            // 
            this.txtBxPriMiles.BackColor = System.Drawing.Color.Yellow;
            this.txtBxPriMiles.Location = new System.Drawing.Point(37, 37);
            this.txtBxPriMiles.Name = "txtBxPriMiles";
            this.txtBxPriMiles.Size = new System.Drawing.Size(100, 20);
            this.txtBxPriMiles.TabIndex = 0;
            // 
            // grpBxTaxiFare
            // 
            this.grpBxTaxiFare.Controls.Add(this.txtBxTaxiFare);
            this.grpBxTaxiFare.Location = new System.Drawing.Point(390, 482);
            this.grpBxTaxiFare.Name = "grpBxTaxiFare";
            this.grpBxTaxiFare.Size = new System.Drawing.Size(434, 76);
            this.grpBxTaxiFare.TabIndex = 4;
            this.grpBxTaxiFare.TabStop = false;
            this.grpBxTaxiFare.Text = "Taxi Fare ($)";
            // 
            // txtBxTaxiFare
            // 
            this.txtBxTaxiFare.BackColor = System.Drawing.Color.Yellow;
            this.txtBxTaxiFare.Location = new System.Drawing.Point(37, 30);
            this.txtBxTaxiFare.Name = "txtBxTaxiFare";
            this.txtBxTaxiFare.Size = new System.Drawing.Size(100, 20);
            this.txtBxTaxiFare.TabIndex = 0;
            // 
            // grpBxEvents
            // 
            this.grpBxEvents.Controls.Add(this.lstBxEvents);
            this.grpBxEvents.Location = new System.Drawing.Point(59, 242);
            this.grpBxEvents.Name = "grpBxEvents";
            this.grpBxEvents.Size = new System.Drawing.Size(301, 112);
            this.grpBxEvents.TabIndex = 0;
            this.grpBxEvents.TabStop = false;
            this.grpBxEvents.Text = "Events";
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.Items.AddRange(new object[] {
            "Cloud Computing - $789.37",
            "Advanced Programming - $472.93",
            "Network Security - $241.45",
            "IT Security Seminar "});
            this.lstBxEvents.Location = new System.Drawing.Point(23, 24);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.Size = new System.Drawing.Size(244, 69);
            this.lstBxEvents.TabIndex = 0;
            this.lstBxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBxEvents_SelectedIndexChanged);
            // 
            // btnResetEvt
            // 
            this.btnResetEvt.Location = new System.Drawing.Point(161, 371);
            this.btnResetEvt.Name = "btnResetEvt";
            this.btnResetEvt.Size = new System.Drawing.Size(92, 35);
            this.btnResetEvt.TabIndex = 5;
            this.btnResetEvt.Text = "Reset Events";
            this.btnResetEvt.UseVisualStyleBackColor = true;
            this.btnResetEvt.Click += new System.EventHandler(this.btnResetEvt_Click);
            // 
            // grpBxITSecu
            // 
            this.grpBxITSecu.Controls.Add(this.chkBxAttack);
            this.grpBxITSecu.Controls.Add(this.chkBxEncry);
            this.grpBxITSecu.Controls.Add(this.chkBxOS);
            this.grpBxITSecu.Location = new System.Drawing.Point(59, 412);
            this.grpBxITSecu.Name = "grpBxITSecu";
            this.grpBxITSecu.Size = new System.Drawing.Size(301, 146);
            this.grpBxITSecu.TabIndex = 1;
            this.grpBxITSecu.TabStop = false;
            this.grpBxITSecu.Text = "IT Security Topics";
            this.grpBxITSecu.Visible = false;
            // 
            // chkBxAttack
            // 
            this.chkBxAttack.AutoSize = true;
            this.chkBxAttack.Location = new System.Drawing.Point(46, 113);
            this.chkBxAttack.Name = "chkBxAttack";
            this.chkBxAttack.Size = new System.Drawing.Size(149, 17);
            this.chkBxAttack.TabIndex = 2;
            this.chkBxAttack.Text = "Types of Attack - $152.94";
            this.chkBxAttack.UseVisualStyleBackColor = true;
            // 
            // chkBxEncry
            // 
            this.chkBxEncry.AutoSize = true;
            this.chkBxEncry.Location = new System.Drawing.Point(46, 69);
            this.chkBxEncry.Name = "chkBxEncry";
            this.chkBxEncry.Size = new System.Drawing.Size(124, 17);
            this.chkBxEncry.TabIndex = 1;
            this.chkBxEncry.Text = "Encryption - $250.23";
            this.chkBxEncry.UseVisualStyleBackColor = true;
            // 
            // chkBxOS
            // 
            this.chkBxOS.AutoSize = true;
            this.chkBxOS.Location = new System.Drawing.Point(46, 33);
            this.chkBxOS.Name = "chkBxOS";
            this.chkBxOS.Size = new System.Drawing.Size(130, 17);
            this.chkBxOS.TabIndex = 0;
            this.chkBxOS.Text = "OS Security - $347.52";
            this.chkBxOS.UseVisualStyleBackColor = true;
            // 
            // lblTotExp
            // 
            this.lblTotExp.AutoSize = true;
            this.lblTotExp.Location = new System.Drawing.Point(259, 591);
            this.lblTotExp.Name = "lblTotExp";
            this.lblTotExp.Size = new System.Drawing.Size(122, 13);
            this.lblTotExp.TabIndex = 6;
            this.lblTotExp.Text = "Total Expenses Incurred";
            // 
            // lblReimbursemnt
            // 
            this.lblReimbursemnt.AutoSize = true;
            this.lblReimbursemnt.Location = new System.Drawing.Point(259, 630);
            this.lblReimbursemnt.Name = "lblReimbursemnt";
            this.lblReimbursemnt.Size = new System.Drawing.Size(80, 13);
            this.lblReimbursemnt.TabIndex = 7;
            this.lblReimbursemnt.Text = "Reimbursement";
            // 
            // lblYouPay
            // 
            this.lblYouPay.AutoSize = true;
            this.lblYouPay.Location = new System.Drawing.Point(263, 670);
            this.lblYouPay.Name = "lblYouPay";
            this.lblYouPay.Size = new System.Drawing.Size(47, 13);
            this.lblYouPay.TabIndex = 8;
            this.lblYouPay.Text = "You Pay";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(171, 710);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 36);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(368, 710);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 710);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBxTExpn
            // 
            this.txtBxTExpn.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBxTExpn.Location = new System.Drawing.Point(387, 591);
            this.txtBxTExpn.Name = "txtBxTExpn";
            this.txtBxTExpn.ReadOnly = true;
            this.txtBxTExpn.Size = new System.Drawing.Size(311, 20);
            this.txtBxTExpn.TabIndex = 12;
            // 
            // txtBxReimburse
            // 
            this.txtBxReimburse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxReimburse.ForeColor = System.Drawing.Color.Yellow;
            this.txtBxReimburse.Location = new System.Drawing.Point(387, 630);
            this.txtBxReimburse.Name = "txtBxReimburse";
            this.txtBxReimburse.ReadOnly = true;
            this.txtBxReimburse.Size = new System.Drawing.Size(311, 20);
            this.txtBxReimburse.TabIndex = 13;
            // 
            // txtBxYouPay
            // 
            this.txtBxYouPay.BackColor = System.Drawing.Color.Red;
            this.txtBxYouPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxYouPay.ForeColor = System.Drawing.Color.Yellow;
            this.txtBxYouPay.Location = new System.Drawing.Point(387, 670);
            this.txtBxYouPay.Name = "txtBxYouPay";
            this.txtBxYouPay.ReadOnly = true;
            this.txtBxYouPay.Size = new System.Drawing.Size(308, 26);
            this.txtBxYouPay.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 781);
            this.Controls.Add(this.txtBxYouPay);
            this.Controls.Add(this.txtBxReimburse);
            this.Controls.Add(this.txtBxTExpn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblYouPay);
            this.Controls.Add(this.lblReimbursemnt);
            this.Controls.Add(this.lblTotExp);
            this.Controls.Add(this.grpBxITSecu);
            this.Controls.Add(this.btnResetEvt);
            this.Controls.Add(this.grpBxEvents);
            this.Controls.Add(this.grpBxPriMiles);
            this.Controls.Add(this.grpBxCRD);
            this.Controls.Add(this.grpBxTaxiFare);
            this.Controls.Add(this.grpBxAF);
            this.Controls.Add(this.grpBxLod);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "Travel Expenses";
            this.grpBxLod.ResumeLayout(false);
            this.grpBxAmtDay.ResumeLayout(false);
            this.grpBxAmtDay.PerformLayout();
            this.grpBxAF.ResumeLayout(false);
            this.grpBxAF.PerformLayout();
            this.grpBxCRD.ResumeLayout(false);
            this.grpBxCRD.PerformLayout();
            this.grpBxParking.ResumeLayout(false);
            this.grpBxParking.PerformLayout();
            this.grpBxPriMiles.ResumeLayout(false);
            this.grpBxPriMiles.PerformLayout();
            this.grpBxParkPriv.ResumeLayout(false);
            this.grpBxParkPriv.PerformLayout();
            this.grpBxTaxiFare.ResumeLayout(false);
            this.grpBxTaxiFare.PerformLayout();
            this.grpBxEvents.ResumeLayout(false);
            this.grpBxITSecu.ResumeLayout(false);
            this.grpBxITSecu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grpBxLod;
        private System.Windows.Forms.GroupBox grpBxAmtDay;
        private System.Windows.Forms.TextBox txtBxAmtDay;
        private System.Windows.Forms.GroupBox grpBxAF;
        private System.Windows.Forms.TextBox txtBxAirFare;
        private System.Windows.Forms.GroupBox grpBxCRD;
        private System.Windows.Forms.TextBox txtBxRentPark;
        private System.Windows.Forms.TextBox txtBxCRD;
        private System.Windows.Forms.GroupBox grpBxPriMiles;
        private System.Windows.Forms.TextBox txtBxPriMiles;
        private System.Windows.Forms.GroupBox grpBxTaxiFare;
        private System.Windows.Forms.TextBox txtBxTaxiFare;
        private System.Windows.Forms.GroupBox grpBxEvents;
        private System.Windows.Forms.Button btnResetEvt;
        private System.Windows.Forms.GroupBox grpBxITSecu;
        private System.Windows.Forms.CheckBox chkBxAttack;
        private System.Windows.Forms.CheckBox chkBxEncry;
        private System.Windows.Forms.CheckBox chkBxOS;
        private System.Windows.Forms.Label lblTotExp;
        private System.Windows.Forms.Label lblReimbursemnt;
        private System.Windows.Forms.Label lblYouPay;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBxTExpn;
        private System.Windows.Forms.TextBox txtBxReimburse;
        private System.Windows.Forms.TextBox txtBxYouPay;
        private System.Windows.Forms.ListBox lstBxCRD;
        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.ListBox lstBxDays;
        private System.Windows.Forms.GroupBox grpBxParking;
        private System.Windows.Forms.GroupBox grpBxParkPriv;
        private System.Windows.Forms.TextBox txtBxPriPark;
    }
}

