
namespace VPL_Lab_Manual_Solution
{
    partial class ExTwoDetails
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
            this.lblNameShow = new System.Windows.Forms.Label();
            this.lblIDShow = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameShow
            // 
            this.lblNameShow.AutoSize = true;
            this.lblNameShow.Location = new System.Drawing.Point(196, 95);
            this.lblNameShow.Name = "lblNameShow";
            this.lblNameShow.Size = new System.Drawing.Size(35, 13);
            this.lblNameShow.TabIndex = 0;
            this.lblNameShow.Text = "label1";
            // 
            // lblIDShow
            // 
            this.lblIDShow.AutoSize = true;
            this.lblIDShow.Location = new System.Drawing.Point(196, 59);
            this.lblIDShow.Name = "lblIDShow";
            this.lblIDShow.Size = new System.Drawing.Size(35, 13);
            this.lblIDShow.TabIndex = 1;
            this.lblIDShow.Text = "label1";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(196, 129);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(35, 13);
            this.lblGen.TabIndex = 2;
            this.lblGen.Text = "label1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(196, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "label2";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Location = new System.Drawing.Point(196, 202);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(35, 13);
            this.lblNat.TabIndex = 4;
            this.lblNat.Text = "label3";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Location = new System.Drawing.Point(196, 237);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(35, 13);
            this.lblSem.TabIndex = 5;
            this.lblSem.Text = "label4";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(199, 273);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(35, 13);
            this.lblDept.TabIndex = 6;
            this.lblDept.Text = "label5";
            // 
            // ExTwoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblNat);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblIDShow);
            this.Controls.Add(this.lblNameShow);
            this.Name = "ExTwoDetails";
            this.Text = "ExTwoDetails";
            this.Load += new System.EventHandler(this.ExTwoDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameShow;
        private System.Windows.Forms.Label lblIDShow;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblDept;
    }
}