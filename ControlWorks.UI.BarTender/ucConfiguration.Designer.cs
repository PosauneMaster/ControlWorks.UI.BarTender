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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBTFilesLocation = new System.Windows.Forms.Button();
            this.txtBtFilesLocation = new System.Windows.Forms.TextBox();
            this.btnTemplateFiles = new System.Windows.Forms.Button();
            this.txtTemplateFilesLocation = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefaultBoxHeight = new System.Windows.Forms.TextBox();
            this.txtDefaultBoxWidth = new System.Windows.Forms.TextBox();
            this.btnManualFront = new System.Windows.Forms.Button();
            this.btnManualSide = new System.Windows.Forms.Button();
            this.lblManualFront = new System.Windows.Forms.Label();
            this.lblManualSide = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearQueue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLabelPlacement = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrinterSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfeedSpeed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Default Box Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default Box Width:";
            // 
            // txtDefaultBoxHeight
            // 
            this.txtDefaultBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultBoxHeight.Location = new System.Drawing.Point(47, 260);
            this.txtDefaultBoxHeight.Multiline = true;
            this.txtDefaultBoxHeight.Name = "txtDefaultBoxHeight";
            this.txtDefaultBoxHeight.Size = new System.Drawing.Size(180, 28);
            this.txtDefaultBoxHeight.TabIndex = 7;
            this.txtDefaultBoxHeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // txtDefaultBoxWidth
            // 
            this.txtDefaultBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultBoxWidth.Location = new System.Drawing.Point(47, 314);
            this.txtDefaultBoxWidth.Multiline = true;
            this.txtDefaultBoxWidth.Name = "txtDefaultBoxWidth";
            this.txtDefaultBoxWidth.Size = new System.Drawing.Size(180, 28);
            this.txtDefaultBoxWidth.TabIndex = 8;
            this.txtDefaultBoxWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnManualFront
            // 
            this.btnManualFront.Location = new System.Drawing.Point(35, 293);
            this.btnManualFront.Name = "btnManualFront";
            this.btnManualFront.Size = new System.Drawing.Size(144, 51);
            this.btnManualFront.TabIndex = 9;
            this.btnManualFront.Text = "Manual Front";
            this.btnManualFront.UseVisualStyleBackColor = false;
            this.btnManualFront.Click += new System.EventHandler(this.btnManualFront_Click);
            // 
            // btnManualSide
            // 
            this.btnManualSide.Location = new System.Drawing.Point(35, 365);
            this.btnManualSide.Name = "btnManualSide";
            this.btnManualSide.Size = new System.Drawing.Size(144, 51);
            this.btnManualSide.TabIndex = 10;
            this.btnManualSide.Text = "Manual Side";
            this.btnManualSide.UseVisualStyleBackColor = false;
            this.btnManualSide.Click += new System.EventHandler(this.btnManualSide_Click);
            // 
            // lblManualFront
            // 
            this.lblManualFront.AutoSize = true;
            this.lblManualFront.Location = new System.Drawing.Point(186, 312);
            this.lblManualFront.Name = "lblManualFront";
            this.lblManualFront.Size = new System.Drawing.Size(35, 13);
            this.lblManualFront.TabIndex = 11;
            this.lblManualFront.Text = "label3";
            // 
            // lblManualSide
            // 
            this.lblManualSide.AutoSize = true;
            this.lblManualSide.Location = new System.Drawing.Point(186, 384);
            this.lblManualSide.Name = "lblManualSide";
            this.lblManualSide.Size = new System.Drawing.Size(35, 13);
            this.lblManualSide.TabIndex = 12;
            this.lblManualSide.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearQueue
            // 
            this.btnClearQueue.Location = new System.Drawing.Point(35, 431);
            this.btnClearQueue.Name = "btnClearQueue";
            this.btnClearQueue.Size = new System.Drawing.Size(144, 51);
            this.btnClearQueue.TabIndex = 13;
            this.btnClearQueue.Text = "Clear Printer";
            this.btnClearQueue.UseVisualStyleBackColor = false;
            this.btnClearQueue.Click += new System.EventHandler(this.btnClearQueue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLabelPlacement);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboOrientation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrinterSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDefaultBoxWidth);
            this.groupBox1.Controls.Add(this.txtInfeedSpeed);
            this.groupBox1.Controls.Add(this.txtDefaultBoxHeight);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(544, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 374);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Settings";
            this.groupBox1.Visible = false;
            // 
            // cboLabelPlacement
            // 
            this.cboLabelPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelPlacement.FormattingEnabled = true;
            this.cboLabelPlacement.Items.AddRange(new object[] {
            "Front",
            "Side",
            "Front and Side",
            "None"});
            this.cboLabelPlacement.Location = new System.Drawing.Point(47, 206);
            this.cboLabelPlacement.Name = "cboLabelPlacement";
            this.cboLabelPlacement.Size = new System.Drawing.Size(180, 28);
            this.cboLabelPlacement.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Label Placement:";
            // 
            // cboOrientation
            // 
            this.cboOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Items.AddRange(new object[] {
            "Portrait",
            "Landscape",
            "Portrait 180",
            "Landscape 180"});
            this.cboOrientation.Location = new System.Drawing.Point(47, 44);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(180, 28);
            this.cboOrientation.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Label Orientation:";
            // 
            // txtPrinterSpeed
            // 
            this.txtPrinterSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinterSpeed.Location = new System.Drawing.Point(47, 152);
            this.txtPrinterSpeed.Multiline = true;
            this.txtPrinterSpeed.Name = "txtPrinterSpeed";
            this.txtPrinterSpeed.Size = new System.Drawing.Size(180, 28);
            this.txtPrinterSpeed.TabIndex = 51;
            this.txtPrinterSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Printer Speed:";
            // 
            // txtInfeedSpeed
            // 
            this.txtInfeedSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfeedSpeed.Location = new System.Drawing.Point(47, 98);
            this.txtInfeedSpeed.Multiline = true;
            this.txtInfeedSpeed.Name = "txtInfeedSpeed";
            this.txtInfeedSpeed.Size = new System.Drawing.Size(180, 28);
            this.txtInfeedSpeed.TabIndex = 49;
            this.txtInfeedSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(47, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "Infeed Speed:";
            // 
            // ucConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearQueue);
            this.Controls.Add(this.lblManualSide);
            this.Controls.Add(this.lblManualFront);
            this.Controls.Add(this.btnManualSide);
            this.Controls.Add(this.btnManualFront);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTemplateFilesLocation);
            this.Controls.Add(this.btnTemplateFiles);
            this.Controls.Add(this.txtBtFilesLocation);
            this.Controls.Add(this.btnBTFilesLocation);
            this.Name = "ucConfiguration";
            this.Size = new System.Drawing.Size(933, 644);
            this.Load += new System.EventHandler(this.ucConfiguration_Load);
            this.VisibleChanged += new System.EventHandler(this.ucConfiguration_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefaultBoxHeight;
        private System.Windows.Forms.TextBox txtDefaultBoxWidth;
        private System.Windows.Forms.Button btnManualFront;
        private System.Windows.Forms.Button btnManualSide;
        private System.Windows.Forms.Label lblManualFront;
        private System.Windows.Forms.Label lblManualSide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLabelPlacement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboOrientation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrinterSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfeedSpeed;
        private System.Windows.Forms.Label label14;
    }
}
