namespace ControlWorks.UI.BarTender
{
    partial class ucConfiguration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBTFilesLocation = new System.Windows.Forms.Button();
            this.txtBtFilesLocation = new System.Windows.Forms.TextBox();
            this.btnTemplateFiles = new System.Windows.Forms.Button();
            this.txtTemplateFilesLocation = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBTFilesLocation
            // 
            this.btnBTFilesLocation.BackColor = System.Drawing.Color.Silver;
            this.btnBTFilesLocation.Location = new System.Drawing.Point(35, 81);
            this.btnBTFilesLocation.Name = "btnBTFilesLocation";
            this.btnBTFilesLocation.Size = new System.Drawing.Size(167, 23);
            this.btnBTFilesLocation.TabIndex = 0;
            this.btnBTFilesLocation.Text = "BT Files Location";
            this.btnBTFilesLocation.UseVisualStyleBackColor = false;
            this.btnBTFilesLocation.Click += new System.EventHandler(this.btnBTFilesLocation_Click);
            // 
            // txtBtFilesLocation
            // 
            this.txtBtFilesLocation.Location = new System.Drawing.Point(208, 81);
            this.txtBtFilesLocation.Name = "txtBtFilesLocation";
            this.txtBtFilesLocation.Size = new System.Drawing.Size(606, 20);
            this.txtBtFilesLocation.TabIndex = 1;
            // 
            // btnTemplateFiles
            // 
            this.btnTemplateFiles.BackColor = System.Drawing.Color.Silver;
            this.btnTemplateFiles.Location = new System.Drawing.Point(35, 139);
            this.btnTemplateFiles.Name = "btnTemplateFiles";
            this.btnTemplateFiles.Size = new System.Drawing.Size(167, 23);
            this.btnTemplateFiles.TabIndex = 2;
            this.btnTemplateFiles.Text = "Template Files Location";
            this.btnTemplateFiles.UseVisualStyleBackColor = false;
            this.btnTemplateFiles.Click += new System.EventHandler(this.btnTemplateFiles_Click);
            // 
            // txtTemplateFilesLocation
            // 
            this.txtTemplateFilesLocation.Location = new System.Drawing.Point(208, 141);
            this.txtTemplateFilesLocation.Name = "txtTemplateFilesLocation";
            this.txtTemplateFilesLocation.Size = new System.Drawing.Size(606, 20);
            this.txtTemplateFilesLocation.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(774, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ucConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTemplateFilesLocation);
            this.Controls.Add(this.btnTemplateFiles);
            this.Controls.Add(this.txtBtFilesLocation);
            this.Controls.Add(this.btnBTFilesLocation);
            this.Name = "ucConfiguration";
            this.Size = new System.Drawing.Size(933, 644);
            this.Load += new System.EventHandler(this.ucConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBTFilesLocation;
        private System.Windows.Forms.TextBox txtBtFilesLocation;
        private System.Windows.Forms.Button btnTemplateFiles;
        private System.Windows.Forms.TextBox txtTemplateFilesLocation;
        private System.Windows.Forms.Button btnExit;
    }
}
