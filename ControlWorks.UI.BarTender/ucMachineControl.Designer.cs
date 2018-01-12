namespace ControlWorks.UI.BarTender
{
    partial class ucMachineControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMachineControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboLabelsPerBox = new System.Windows.Forms.ComboBox();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.txtJobStartTime = new System.Windows.Forms.TextBox();
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtConveyorSpeed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 644);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.cboLabelsPerBox);
            this.groupBox4.Controls.Add(this.txtTemplateName);
            this.groupBox4.Controls.Add(this.txtJobId);
            this.groupBox4.Controls.Add(this.txtJobStartTime);
            this.groupBox4.Controls.Add(this.txtBoxCount);
            this.groupBox4.Controls.Add(this.txtStatus);
            this.groupBox4.Controls.Add(this.txtConveyorSpeed);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(369, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 409);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JobDetails";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(393, 202);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(163, 70);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(393, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 70);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboLabelsPerBox
            // 
            this.cboLabelsPerBox.FormattingEnabled = true;
            this.cboLabelsPerBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboLabelsPerBox.Location = new System.Drawing.Point(193, 167);
            this.cboLabelsPerBox.Name = "cboLabelsPerBox";
            this.cboLabelsPerBox.Size = new System.Drawing.Size(180, 28);
            this.cboLabelsPerBox.TabIndex = 33;
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.BackColor = System.Drawing.Color.White;
            this.txtTemplateName.Location = new System.Drawing.Point(193, 44);
            this.txtTemplateName.Multiline = true;
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.ReadOnly = true;
            this.txtTemplateName.Size = new System.Drawing.Size(180, 28);
            this.txtTemplateName.TabIndex = 32;
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.White;
            this.txtJobId.Location = new System.Drawing.Point(193, 85);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(180, 28);
            this.txtJobId.TabIndex = 31;
            // 
            // txtJobStartTime
            // 
            this.txtJobStartTime.BackColor = System.Drawing.Color.White;
            this.txtJobStartTime.Location = new System.Drawing.Point(193, 126);
            this.txtJobStartTime.Multiline = true;
            this.txtJobStartTime.Name = "txtJobStartTime";
            this.txtJobStartTime.ReadOnly = true;
            this.txtJobStartTime.Size = new System.Drawing.Size(180, 28);
            this.txtJobStartTime.TabIndex = 30;
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.BackColor = System.Drawing.Color.White;
            this.txtBoxCount.Enabled = false;
            this.txtBoxCount.Location = new System.Drawing.Point(193, 208);
            this.txtBoxCount.Multiline = true;
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.ReadOnly = true;
            this.txtBoxCount.Size = new System.Drawing.Size(180, 28);
            this.txtBoxCount.TabIndex = 29;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(193, 290);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(370, 113);
            this.txtStatus.TabIndex = 28;
            // 
            // txtConveyorSpeed
            // 
            this.txtConveyorSpeed.Location = new System.Drawing.Point(193, 249);
            this.txtConveyorSpeed.Multiline = true;
            this.txtConveyorSpeed.Name = "txtConveyorSpeed";
            this.txtConveyorSpeed.Size = new System.Drawing.Size(180, 28);
            this.txtConveyorSpeed.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Conveyor Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Box Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Labels Per Box:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Job Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Job Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Template Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadTemplate);
            this.groupBox3.Controls.Add(this.txtTemplatePath);
            this.groupBox3.Location = new System.Drawing.Point(369, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Template Details";
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTemplate.Image")));
            this.btnLoadTemplate.Location = new System.Drawing.Point(393, 89);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(163, 70);
            this.btnLoadTemplate.TabIndex = 2;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadTemplate.UseVisualStyleBackColor = false;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(6, 36);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.Size = new System.Drawing.Size(550, 26);
            this.txtTemplatePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLog);
            this.groupBox2.Location = new System.Drawing.Point(3, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(3, 22);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(354, 281);
            this.lbLog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Label Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucMachineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucMachineControl";
            this.Size = new System.Drawing.Size(969, 644);
            this.Load += new System.EventHandler(this.ucMachineControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboLabelsPerBox;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.TextBox txtJobStartTime;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtConveyorSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}
