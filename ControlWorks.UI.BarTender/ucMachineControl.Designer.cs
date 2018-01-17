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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMachineControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRunTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalLabels = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSideLabels = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrontLabels = new System.Windows.Forms.TextBox();
            this.btnTestPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChooseLabel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLabelsPerBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboLabelPlacement = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboLabelPosition = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboLabelSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLeftOffset = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrinterSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfeedSpeed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtJobStartTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrJobRun = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRunTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotalLabels);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSideLabels);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFrontLabels);
            this.panel1.Controls.Add(this.btnTestPrint);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnChooseLabel);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtJobStartTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 644);
            this.panel1.TabIndex = 0;
            // 
            // txtRunTime
            // 
            this.txtRunTime.BackColor = System.Drawing.Color.White;
            this.txtRunTime.Enabled = false;
            this.txtRunTime.Location = new System.Drawing.Point(208, 435);
            this.txtRunTime.Multiline = true;
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.ReadOnly = true;
            this.txtRunTime.Size = new System.Drawing.Size(143, 28);
            this.txtRunTime.TabIndex = 45;
            this.txtRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Job Run Time:";
            // 
            // txtTotalLabels
            // 
            this.txtTotalLabels.BackColor = System.Drawing.Color.White;
            this.txtTotalLabels.Enabled = false;
            this.txtTotalLabels.Location = new System.Drawing.Point(208, 551);
            this.txtTotalLabels.Multiline = true;
            this.txtTotalLabels.Name = "txtTotalLabels";
            this.txtTotalLabels.ReadOnly = true;
            this.txtTotalLabels.Size = new System.Drawing.Size(143, 28);
            this.txtTotalLabels.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total Labels:";
            // 
            // txtSideLabels
            // 
            this.txtSideLabels.BackColor = System.Drawing.Color.White;
            this.txtSideLabels.Enabled = false;
            this.txtSideLabels.Location = new System.Drawing.Point(208, 488);
            this.txtSideLabels.Multiline = true;
            this.txtSideLabels.Name = "txtSideLabels";
            this.txtSideLabels.ReadOnly = true;
            this.txtSideLabels.Size = new System.Drawing.Size(143, 28);
            this.txtSideLabels.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Side Labels:";
            // 
            // txtFrontLabels
            // 
            this.txtFrontLabels.BackColor = System.Drawing.Color.White;
            this.txtFrontLabels.Enabled = false;
            this.txtFrontLabels.Location = new System.Drawing.Point(31, 551);
            this.txtFrontLabels.Multiline = true;
            this.txtFrontLabels.Name = "txtFrontLabels";
            this.txtFrontLabels.ReadOnly = true;
            this.txtFrontLabels.Size = new System.Drawing.Size(143, 28);
            this.txtFrontLabels.TabIndex = 43;
            // 
            // btnTestPrint
            // 
            this.btnTestPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestPrint.Location = new System.Drawing.Point(208, 324);
            this.btnTestPrint.Name = "btnTestPrint";
            this.btnTestPrint.Size = new System.Drawing.Size(120, 50);
            this.btnTestPrint.TabIndex = 35;
            this.btnTestPrint.Text = "Print Test";
            this.btnTestPrint.UseVisualStyleBackColor = false;
            this.btnTestPrint.Click += new System.EventHandler(this.btnTestPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Front Labels:";
            // 
            // btnChooseLabel
            // 
            this.btnChooseLabel.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseLabel.Location = new System.Drawing.Point(28, 324);
            this.btnChooseLabel.Name = "btnChooseLabel";
            this.btnChooseLabel.Size = new System.Drawing.Size(120, 50);
            this.btnChooseLabel.TabIndex = 34;
            this.btnChooseLabel.Text = "Choose Label";
            this.btnChooseLabel.UseVisualStyleBackColor = false;
            this.btnChooseLabel.Click += new System.EventHandler(this.btnChooseLabel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtLabelsPerBox);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cboLabelPlacement);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cboLabelPosition);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cboLabelSize);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtLeftOffset);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cboOrientation);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPrinterSpeed);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.txtInfeedSpeed);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(369, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 452);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JobDetails";
            this.groupBox4.VisibleChanged += new System.EventHandler(this.groupBox4_VisibleChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(437, 277);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(43, 26);
            this.txtWidth.TabIndex = 54;
            this.txtWidth.Text = "12";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(410, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "W:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(321, 277);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(43, 26);
            this.txtHeight.TabIndex = 52;
            this.txtHeight.Text = "12";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(297, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "H:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(297, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 16);
            this.label18.TabIndex = 50;
            this.label18.Text = "Box Dimensions";
            // 
            // txtLabelsPerBox
            // 
            this.txtLabelsPerBox.Enabled = false;
            this.txtLabelsPerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelsPerBox.Location = new System.Drawing.Point(299, 221);
            this.txtLabelsPerBox.Multiline = true;
            this.txtLabelsPerBox.Name = "txtLabelsPerBox";
            this.txtLabelsPerBox.Size = new System.Drawing.Size(180, 28);
            this.txtLabelsPerBox.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(297, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 16);
            this.label15.TabIndex = 48;
            this.label15.Text = "Labels Per Box:";
            // 
            // cboLabelPlacement
            // 
            this.cboLabelPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelPlacement.FormattingEnabled = true;
            this.cboLabelPlacement.Items.AddRange(new object[] {
            "Front",
            "Side",
            "Front and Side"});
            this.cboLabelPlacement.Location = new System.Drawing.Point(39, 220);
            this.cboLabelPlacement.Name = "cboLabelPlacement";
            this.cboLabelPlacement.Size = new System.Drawing.Size(180, 28);
            this.cboLabelPlacement.TabIndex = 47;
            this.cboLabelPlacement.SelectedIndexChanged += new System.EventHandler(this.cboLabelPlacement_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Label Placement:";
            // 
            // cboLabelPosition
            // 
            this.cboLabelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelPosition.FormattingEnabled = true;
            this.cboLabelPosition.Location = new System.Drawing.Point(300, 165);
            this.cboLabelPosition.Name = "cboLabelPosition";
            this.cboLabelPosition.Size = new System.Drawing.Size(180, 28);
            this.cboLabelPosition.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(297, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Label Position";
            // 
            // cboLabelSize
            // 
            this.cboLabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelSize.FormattingEnabled = true;
            this.cboLabelSize.Location = new System.Drawing.Point(300, 110);
            this.cboLabelSize.Name = "cboLabelSize";
            this.cboLabelSize.Size = new System.Drawing.Size(180, 28);
            this.cboLabelSize.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(297, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Label Size";
            // 
            // txtLeftOffset
            // 
            this.txtLeftOffset.Location = new System.Drawing.Point(300, 55);
            this.txtLeftOffset.Multiline = true;
            this.txtLeftOffset.Name = "txtLeftOffset";
            this.txtLeftOffset.Size = new System.Drawing.Size(180, 28);
            this.txtLeftOffset.TabIndex = 41;
            this.txtLeftOffset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Left Offset:";
            // 
            // cboOrientation
            // 
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Items.AddRange(new object[] {
            "Portrait",
            "Landscape",
            "Portrait 180",
            "Landscape 180"});
            this.cboOrientation.Location = new System.Drawing.Point(39, 55);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(180, 28);
            this.cboOrientation.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Label Orientation:";
            // 
            // txtPrinterSpeed
            // 
            this.txtPrinterSpeed.Location = new System.Drawing.Point(39, 165);
            this.txtPrinterSpeed.Multiline = true;
            this.txtPrinterSpeed.Name = "txtPrinterSpeed";
            this.txtPrinterSpeed.Size = new System.Drawing.Size(180, 28);
            this.txtPrinterSpeed.TabIndex = 37;
            this.txtPrinterSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Printer Speed:";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(333, 362);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(163, 70);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(56, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 70);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfeedSpeed
            // 
            this.txtInfeedSpeed.Location = new System.Drawing.Point(39, 110);
            this.txtInfeedSpeed.Multiline = true;
            this.txtInfeedSpeed.Name = "txtInfeedSpeed";
            this.txtInfeedSpeed.Size = new System.Drawing.Size(180, 28);
            this.txtInfeedSpeed.TabIndex = 27;
            this.txtInfeedSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Infeed Speed:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadTemplate);
            this.groupBox3.Controls.Add(this.txtTemplatePath);
            this.groupBox3.Location = new System.Drawing.Point(369, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 180);
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
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtJobStartTime
            // 
            this.txtJobStartTime.BackColor = System.Drawing.Color.White;
            this.txtJobStartTime.Enabled = false;
            this.txtJobStartTime.Location = new System.Drawing.Point(31, 435);
            this.txtJobStartTime.Multiline = true;
            this.txtJobStartTime.Name = "txtJobStartTime";
            this.txtJobStartTime.ReadOnly = true;
            this.txtJobStartTime.Size = new System.Drawing.Size(143, 28);
            this.txtJobStartTime.TabIndex = 30;
            this.txtJobStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Job Start Time:";
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.BackColor = System.Drawing.Color.White;
            this.txtBoxCount.Enabled = false;
            this.txtBoxCount.Location = new System.Drawing.Point(31, 493);
            this.txtBoxCount.Multiline = true;
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.ReadOnly = true;
            this.txtBoxCount.Size = new System.Drawing.Size(143, 28);
            this.txtBoxCount.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Box Count:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrJobRun
            // 
            this.tmrJobRun.Interval = 1000;
            this.tmrJobRun.Tick += new System.EventHandler(this.tmrJobRun_Tick);
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
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtJobStartTime;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.TextBox txtInfeedSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPrinterSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrontLabels;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSideLabels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalLabels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTestPrint;
        private System.Windows.Forms.Button btnChooseLabel;
        private System.Windows.Forms.TextBox txtRunTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrJobRun;
        private System.Windows.Forms.TextBox txtLeftOffset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboOrientation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLabelSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboLabelPosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboLabelPlacement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLabelsPerBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}
