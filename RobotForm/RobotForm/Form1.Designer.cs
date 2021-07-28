
namespace RobotForm
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
            this.lblRes = new System.Windows.Forms.Label();
            this.panelArrow = new System.Windows.Forms.Panel();
            this.lblArrow = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelArrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(54, 29);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(76, 17);
            this.lblRes.TabIndex = 0;
            this.lblRes.Text = "{X=0, Y=0}";
            // 
            // panelArrow
            // 
            this.panelArrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArrow.Controls.Add(this.lblArrow);
            this.panelArrow.Location = new System.Drawing.Point(57, 80);
            this.panelArrow.Name = "panelArrow";
            this.panelArrow.Size = new System.Drawing.Size(251, 177);
            this.panelArrow.TabIndex = 1;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblArrow.Location = new System.Drawing.Point(120, 81);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(23, 15);
            this.lblArrow.TabIndex = 0;
            this.lblArrow.Text = "è";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(57, 344);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(55, 23);
            this.btnGo1.TabIndex = 2;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(143, 344);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(34, 23);
            this.btnW.TabIndex = 3;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(181, 315);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(32, 23);
            this.btnN.TabIndex = 4;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(181, 373);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(32, 25);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(217, 344);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(35, 23);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnGo10
            // 
            this.btnGo10.Location = new System.Drawing.Point(268, 344);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(60, 23);
            this.btnGo10.TabIndex = 7;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.UseVisualStyleBackColor = true;
            this.btnGo10.Click += new System.EventHandler(this.btnGo10_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 539);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.panelArrow);
            this.Controls.Add(this.lblRes);
            this.Name = "Form1";
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelArrow.ResumeLayout(false);
            this.panelArrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Panel panelArrow;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Button btnExit;
    }
}

