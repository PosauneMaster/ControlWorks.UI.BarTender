namespace ControlWorks.UI.BarTender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveRight = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMachineControl = new System.Windows.Forms.Button();
            this.btnLabelSetup = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMachineControl = new System.Windows.Forms.Panel();
            this.pnlLabelSettings = new System.Windows.Forms.Panel();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLabelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1366, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1366, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Resize += new System.EventHandler(this.toolStrip1_Resize);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Image = global::ControlWorks.UI.BarTender.Properties.Resources.greenlight2;
            this.toolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, -4, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(139, 22);
            this.toolStripLabel2.Text = "MACHINE CONTROL";
            this.toolStripLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrMoveRight
            // 
            this.tmrMoveRight.Interval = 1000;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bartender Files (*.btw)|*.btw|All files (*.*)|*.*";
            // 
            // btnMachineControl
            // 
            this.btnMachineControl.BackColor = System.Drawing.Color.White;
            this.btnMachineControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineControl.Location = new System.Drawing.Point(1160, 66);
            this.btnMachineControl.Name = "btnMachineControl";
            this.btnMachineControl.Size = new System.Drawing.Size(194, 96);
            this.btnMachineControl.TabIndex = 2;
            this.btnMachineControl.Text = "Machine Control";
            this.btnMachineControl.UseVisualStyleBackColor = false;
            this.btnMachineControl.Click += new System.EventHandler(this.btnMachineControl_Click);
            // 
            // btnLabelSetup
            // 
            this.btnLabelSetup.BackColor = System.Drawing.Color.White;
            this.btnLabelSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabelSetup.Location = new System.Drawing.Point(1160, 195);
            this.btnLabelSetup.Name = "btnLabelSetup";
            this.btnLabelSetup.Size = new System.Drawing.Size(194, 96);
            this.btnLabelSetup.TabIndex = 3;
            this.btnLabelSetup.Text = "Label Setup";
            this.btnLabelSetup.UseVisualStyleBackColor = false;
            this.btnLabelSetup.Click += new System.EventHandler(this.btnLabelSetup_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.White;
            this.btnConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.Location = new System.Drawing.Point(1160, 324);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(194, 96);
            this.btnConfiguration.TabIndex = 4;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pnlMachineControl);
            this.panel1.Controls.Add(this.pnlLabelSettings);
            this.panel1.Controls.Add(this.pnlConfiguration);
            this.panel1.Controls.Add(this.btnMachineControl);
            this.panel1.Controls.Add(this.btnConfiguration);
            this.panel1.Controls.Add(this.btnLabelSetup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 658);
            this.panel1.TabIndex = 5;
            // 
            // pnlMachineControl
            // 
            this.pnlMachineControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMachineControl.Location = new System.Drawing.Point(1154, 0);
            this.pnlMachineControl.Name = "pnlMachineControl";
            this.pnlMachineControl.Size = new System.Drawing.Size(1154, 658);
            this.pnlMachineControl.TabIndex = 5;
            // 
            // pnlLabelSettings
            // 
            this.pnlLabelSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLabelSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlLabelSettings.Name = "pnlLabelSettings";
            this.pnlLabelSettings.Size = new System.Drawing.Size(1154, 658);
            this.pnlLabelSettings.TabIndex = 0;
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConfiguration.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(1154, 658);
            this.pnlConfiguration.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1382, 744);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarTender Label Control System ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlLabelSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrMoveRight;
        private System.Windows.Forms.Timer tmrMoveLeft;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMachineControl;
        private System.Windows.Forms.Button btnLabelSetup;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMachineControl;
        private System.Windows.Forms.Panel pnlLabelSettings;
        private System.Windows.Forms.Panel pnlConfiguration;
    }
}