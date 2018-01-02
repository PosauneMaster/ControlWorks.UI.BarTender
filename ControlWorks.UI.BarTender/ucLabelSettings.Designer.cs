namespace ControlWorks.UI.BarTender
{
    partial class ucLabelSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLabelSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChooseLabel = new System.Windows.Forms.Button();
            this.cboLabelsPerBox = new System.Windows.Forms.ComboBox();
            this.txtConveyorSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboLabelPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLabelSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.lblRightDistance = new System.Windows.Forms.Label();
            this.lblLeftDistance = new System.Windows.Forms.Label();
            this.pb4x6 = new System.Windows.Forms.PictureBox();
            this.pb4x4 = new System.Windows.Forms.PictureBox();
            this.pb6x4 = new System.Windows.Forms.PictureBox();
            this.tmrMoveRight = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6x4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnChooseLabel);
            this.groupBox1.Controls.Add(this.cboLabelsPerBox);
            this.groupBox1.Controls.Add(this.txtConveyorSpeed);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTemplateName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboLabelPosition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboLabelSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 519);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(167, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnChooseLabel
            // 
            this.btnChooseLabel.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseLabel.Location = new System.Drawing.Point(22, 319);
            this.btnChooseLabel.Name = "btnChooseLabel";
            this.btnChooseLabel.Size = new System.Drawing.Size(120, 50);
            this.btnChooseLabel.TabIndex = 31;
            this.btnChooseLabel.Text = "Choose Label";
            this.btnChooseLabel.UseVisualStyleBackColor = false;
            this.btnChooseLabel.Click += new System.EventHandler(this.btnChooseLabel_Click);
            // 
            // cboLabelsPerBox
            // 
            this.cboLabelsPerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelsPerBox.FormattingEnabled = true;
            this.cboLabelsPerBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboLabelsPerBox.Location = new System.Drawing.Point(167, 56);
            this.cboLabelsPerBox.Name = "cboLabelsPerBox";
            this.cboLabelsPerBox.Size = new System.Drawing.Size(224, 28);
            this.cboLabelsPerBox.TabIndex = 30;
            this.cboLabelsPerBox.Click += new System.EventHandler(this.OnComboboxClicked);
            // 
            // txtConveyorSpeed
            // 
            this.txtConveyorSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConveyorSpeed.Location = new System.Drawing.Point(167, 92);
            this.txtConveyorSpeed.Multiline = true;
            this.txtConveyorSpeed.Name = "txtConveyorSpeed";
            this.txtConveyorSpeed.Size = new System.Drawing.Size(224, 28);
            this.txtConveyorSpeed.TabIndex = 29;
            this.txtConveyorSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(23, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Conveyor Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(23, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Labels Per Box:";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplateName.Location = new System.Drawing.Point(167, 21);
            this.txtTemplateName.Multiline = true;
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(224, 27);
            this.txtTemplateName.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Template Name:";
            // 
            // cboLabelPosition
            // 
            this.cboLabelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelPosition.FormattingEnabled = true;
            this.cboLabelPosition.Location = new System.Drawing.Point(167, 274);
            this.cboLabelPosition.Name = "cboLabelPosition";
            this.cboLabelPosition.Size = new System.Drawing.Size(224, 28);
            this.cboLabelPosition.TabIndex = 8;
            this.cboLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cboLabelPosition_SelectedIndexChanged);
            this.cboLabelPosition.Click += new System.EventHandler(this.OnComboboxClicked);
            this.cboLabelPosition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCboMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Label Position";
            // 
            // cboLabelSize
            // 
            this.cboLabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelSize.FormattingEnabled = true;
            this.cboLabelSize.Location = new System.Drawing.Point(167, 231);
            this.cboLabelSize.Name = "cboLabelSize";
            this.cboLabelSize.Size = new System.Drawing.Size(224, 28);
            this.cboLabelSize.TabIndex = 6;
            this.cboLabelSize.SelectedIndexChanged += new System.EventHandler(this.cboLabelSize_SelectedIndexChanged);
            this.cboLabelSize.Click += new System.EventHandler(this.OnComboboxClicked);
            this.cboLabelSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCboMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Label Size";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(135, 190);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "12";
            this.txtWidth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width (inches):";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(135, 151);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "12";
            this.txtHeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (inches):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box Dimensions";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(567, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 70);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.SystemColors.Control;
            this.btnRotate.Image = global::ControlWorks.UI.BarTender.Properties.Resources.Rotate_Right;
            this.btnRotate.Location = new System.Drawing.Point(12, 433);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(140, 80);
            this.btnRotate.TabIndex = 9;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.BackColor = System.Drawing.Color.Peru;
            this.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBox.Controls.Add(this.lblRightDistance);
            this.pnlBox.Controls.Add(this.lblLeftDistance);
            this.pnlBox.Controls.Add(this.pb4x6);
            this.pnlBox.Controls.Add(this.pb4x4);
            this.pnlBox.Controls.Add(this.pb6x4);
            this.pnlBox.Location = new System.Drawing.Point(12, 22);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(400, 400);
            this.pnlBox.TabIndex = 3;
            // 
            // lblRightDistance
            // 
            this.lblRightDistance.AutoSize = true;
            this.lblRightDistance.Location = new System.Drawing.Point(280, 57);
            this.lblRightDistance.Name = "lblRightDistance";
            this.lblRightDistance.Size = new System.Drawing.Size(35, 13);
            this.lblRightDistance.TabIndex = 3;
            this.lblRightDistance.Text = "label7";
            // 
            // lblLeftDistance
            // 
            this.lblLeftDistance.AutoSize = true;
            this.lblLeftDistance.Location = new System.Drawing.Point(21, 57);
            this.lblLeftDistance.Name = "lblLeftDistance";
            this.lblLeftDistance.Size = new System.Drawing.Size(35, 13);
            this.lblLeftDistance.TabIndex = 2;
            this.lblLeftDistance.Text = "label6";
            // 
            // pb4x6
            // 
            this.pb4x6.BackColor = System.Drawing.Color.White;
            this.pb4x6.Image = global::ControlWorks.UI.BarTender.Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb4x6.Location = new System.Drawing.Point(138, 108);
            this.pb4x6.MaximumSize = new System.Drawing.Size(120, 180);
            this.pb4x6.MinimumSize = new System.Drawing.Size(120, 180);
            this.pb4x6.Name = "pb4x6";
            this.pb4x6.Size = new System.Drawing.Size(120, 180);
            this.pb4x6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb4x6.TabIndex = 1;
            this.pb4x6.TabStop = false;
            this.pb4x6.Tag = "4";
            this.pb4x6.Visible = false;
            // 
            // pb4x4
            // 
            this.pb4x4.BackColor = System.Drawing.Color.White;
            this.pb4x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb4x4.Image = global::ControlWorks.UI.BarTender.Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb4x4.Location = new System.Drawing.Point(138, 138);
            this.pb4x4.Name = "pb4x4";
            this.pb4x4.Size = new System.Drawing.Size(120, 120);
            this.pb4x4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb4x4.TabIndex = 0;
            this.pb4x4.TabStop = false;
            this.pb4x4.Tag = "4";
            // 
            // pb6x4
            // 
            this.pb6x4.BackColor = System.Drawing.Color.White;
            this.pb6x4.Image = global::ControlWorks.UI.BarTender.Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb6x4.Location = new System.Drawing.Point(108, 138);
            this.pb6x4.Name = "pb6x4";
            this.pb6x4.Size = new System.Drawing.Size(180, 120);
            this.pb6x4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb6x4.TabIndex = 4;
            this.pb6x4.TabStop = false;
            this.pb6x4.Tag = "6";
            this.pb6x4.Visible = false;
            // 
            // tmrMoveRight
            // 
            this.tmrMoveRight.Interval = 250;
            this.tmrMoveRight.Tick += new System.EventHandler(this.tmrMoveRight_Tick);
            // 
            // tmrMoveLeft
            // 
            this.tmrMoveLeft.Interval = 250;
            this.tmrMoveLeft.Tick += new System.EventHandler(this.tmrMoveLeft_Tick);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Control;
            this.btnRight.Image = global::ControlWorks.UI.BarTender.Properties.Resources.arrow_Next_16xLG_color;
            this.btnRight.Location = new System.Drawing.Point(292, 440);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(120, 50);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeft.Image = global::ControlWorks.UI.BarTender.Properties.Resources.arrow_Previous_16xLG_color;
            this.btnLeft.Location = new System.Drawing.Point(166, 440);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(120, 50);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(197, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "New Template";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 70);
            this.button2.TabIndex = 10;
            this.button2.Text = "Load Template";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTemplate.Image")));
            this.btnSaveTemplate.Location = new System.Drawing.Point(382, 34);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(163, 70);
            this.btnSaveTemplate.TabIndex = 12;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTemplate.UseVisualStyleBackColor = false;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlBox);
            this.groupBox2.Controls.Add(this.btnRotate);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Location = new System.Drawing.Point(429, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 519);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Label Settings";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bartender Files (*.btw)|*.btw|All files (*.*)|*.*";
            // 
            // ucLabelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucLabelSettings";
            this.Size = new System.Drawing.Size(933, 644);
            this.Load += new System.EventHandler(this.ucLabelSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6x4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.ComboBox cboLabelPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLabelSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Label lblRightDistance;
        private System.Windows.Forms.Label lblLeftDistance;
        private System.Windows.Forms.PictureBox pb4x6;
        private System.Windows.Forms.PictureBox pb4x4;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Timer tmrMoveRight;
        private System.Windows.Forms.Timer tmrMoveLeft;
        private System.Windows.Forms.PictureBox pb6x4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtConveyorSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboLabelsPerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChooseLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
