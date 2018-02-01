namespace ControlWorks.UI.BarTender
{
    partial class frmPassword
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
            this.ucNumberPad1 = new ControlWorks.UI.BarTender.ucNumberPad();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ucNumberPad1
            // 
            this.ucNumberPad1.Location = new System.Drawing.Point(3, 85);
            this.ucNumberPad1.Name = "ucNumberPad1";
            this.ucNumberPad1.Size = new System.Drawing.Size(266, 266);
            this.ucNumberPad1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(26, 31);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 349);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ucNumberPad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPassword";
            this.Text = "Enter Password";
            this.Load += new System.EventHandler(this.frmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucNumberPad ucNumberPad1;
        private System.Windows.Forms.TextBox txtPassword;
    }
}