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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.cboLabelPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLabelSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6x4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRotate);
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
            this.groupBox1.Location = new System.Drawing.Point(479, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 505);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnRotate
            // 
            this.btnRotate.Image = global::ControlWorks.UI.BarTender.Properties.Resources.Rotate_Right;
            this.btnRotate.Location = new System.Drawing.Point(89, 390);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(140, 80);
            this.btnRotate.TabIndex = 9;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // cboLabelPosition
            // 
            this.cboLabelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelPosition.FormattingEnabled = true;
            this.cboLabelPosition.Location = new System.Drawing.Point(136, 245);
            this.cboLabelPosition.Name = "cboLabelPosition";
            this.cboLabelPosition.Size = new System.Drawing.Size(150, 28);
            this.cboLabelPosition.TabIndex = 8;
            this.cboLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cboLabelPosition_SelectedIndexChanged);
            this.cboLabelPosition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCboMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Label Position";
            // 
            // cboLabelSize
            // 
            this.cboLabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelSize.FormattingEnabled = true;
            this.cboLabelSize.Location = new System.Drawing.Point(136, 190);
            this.cboLabelSize.Name = "cboLabelSize";
            this.cboLabelSize.Size = new System.Drawing.Size(150, 28);
            this.cboLabelSize.TabIndex = 6;
            this.cboLabelSize.SelectedIndexChanged += new System.EventHandler(this.cboLabelSize_SelectedIndexChanged);
            this.cboLabelSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCboMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Label Size";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(136, 125);
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
            this.label3.Location = new System.Drawing.Point(54, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width (inches):";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(136, 86);
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
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (inches):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box Dimensions";
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
            this.pnlBox.Location = new System.Drawing.Point(19, 87);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(454, 505);
            this.pnlBox.TabIndex = 3;
            // 
            // lblRightDistance
            // 
            this.lblRightDistance.AutoSize = true;
            this.lblRightDistance.Location = new System.Drawing.Point(357, 97);
            this.lblRightDistance.Name = "lblRightDistance";
            this.lblRightDistance.Size = new System.Drawing.Size(35, 13);
            this.lblRightDistance.TabIndex = 3;
            this.lblRightDistance.Text = "label7";
            // 
            // lblLeftDistance
            // 
            this.lblLeftDistance.AutoSize = true;
            this.lblLeftDistance.Location = new System.Drawing.Point(59, 97);
            this.lblLeftDistance.Name = "lblLeftDistance";
            this.lblLeftDistance.Size = new System.Drawing.Size(35, 13);
            this.lblLeftDistance.TabIndex = 2;
            this.lblLeftDistance.Text = "label6";
            // 
            // pb4x6
            // 
            this.pb4x6.BackColor = System.Drawing.Color.White;
            this.pb4x6.Image = global::ControlWorks.UI.BarTender.Properties.Resources._112_UpArrowLong_Blue_24x24_72;
            this.pb4x6.Location = new System.Drawing.Point(165, 160);
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
            this.pb4x4.Location = new System.Drawing.Point(165, 190);
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
            this.pb6x4.Location = new System.Drawing.Point(135, 190);
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
            this.btnRight.Location = new System.Drawing.Point(271, 618);
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
            this.btnLeft.Location = new System.Drawing.Point(92, 618);
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(676, 618);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ucLabelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucLabelSettings";
            this.Size = new System.Drawing.Size(841, 715);
            this.Load += new System.EventHandler(this.ucLabelSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4x4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6x4)).EndInit();
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
    }
}
