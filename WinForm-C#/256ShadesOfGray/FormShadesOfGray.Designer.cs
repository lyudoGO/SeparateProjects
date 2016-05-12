namespace _256ShadesOfGray
{
    partial class FormShadesOfGray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShadesOfGray));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPicture = new System.Windows.Forms.Button();
            this.textBoxPicter = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxGrayScale = new System.Windows.Forms.CheckBox();
            this.buttonChangePicter = new System.Windows.Forms.Button();
            this.trackBarBrigthness = new System.Windows.Forms.TrackBar();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelContrast = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSavePicter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrigthness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(1, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(470, 441);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonOpenPicture
            // 
            this.buttonOpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenPicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPicture.Location = new System.Drawing.Point(506, 12);
            this.buttonOpenPicture.Name = "buttonOpenPicture";
            this.buttonOpenPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPicture.TabIndex = 1;
            this.buttonOpenPicture.Text = "Open";
            this.buttonOpenPicture.UseVisualStyleBackColor = false;
            this.buttonOpenPicture.Click += new System.EventHandler(this.buttonOpenPicter_Click);
            // 
            // textBoxPicter
            // 
            this.textBoxPicter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPicter.Location = new System.Drawing.Point(477, 77);
            this.textBoxPicter.Name = "textBoxPicter";
            this.textBoxPicter.ReadOnly = true;
            this.textBoxPicter.Size = new System.Drawing.Size(145, 20);
            this.textBoxPicter.TabIndex = 2;
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGrayScale.AutoSize = true;
            this.checkBoxGrayScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGrayScale.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGrayScale.Location = new System.Drawing.Point(487, 103);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(95, 20);
            this.checkBoxGrayScale.TabIndex = 3;
            this.checkBoxGrayScale.Text = "Make gray";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            // 
            // buttonChangePicter
            // 
            this.buttonChangePicter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePicter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangePicter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePicter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePicter.Location = new System.Drawing.Point(495, 390);
            this.buttonChangePicter.Name = "buttonChangePicter";
            this.buttonChangePicter.Size = new System.Drawing.Size(106, 23);
            this.buttonChangePicter.TabIndex = 4;
            this.buttonChangePicter.Text = "Change Picter";
            this.buttonChangePicter.UseVisualStyleBackColor = false;
            this.buttonChangePicter.Click += new System.EventHandler(this.buttonChangePicter_Click);
            // 
            // trackBarBrigthness
            // 
            this.trackBarBrigthness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBrigthness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBrigthness.LargeChange = 10;
            this.trackBarBrigthness.Location = new System.Drawing.Point(477, 168);
            this.trackBarBrigthness.Maximum = 50;
            this.trackBarBrigthness.Minimum = -50;
            this.trackBarBrigthness.Name = "trackBarBrigthness";
            this.trackBarBrigthness.Size = new System.Drawing.Size(144, 45);
            this.trackBarBrigthness.TabIndex = 5;
            this.trackBarBrigthness.TickFrequency = 10;
            this.trackBarBrigthness.ValueChanged += new System.EventHandler(this.trackBarBrigthness_ValueChanged);
            // 
            // labelBrightness
            // 
            this.labelBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrightness.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrightness.Location = new System.Drawing.Point(477, 142);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(144, 23);
            this.labelBrightness.TabIndex = 6;
            this.labelBrightness.Text = "Brightness";
            // 
            // labelContrast
            // 
            this.labelContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrast.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContrast.Location = new System.Drawing.Point(477, 219);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(144, 23);
            this.labelContrast.TabIndex = 8;
            this.labelContrast.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarContrast.LargeChange = 10;
            this.trackBarContrast.Location = new System.Drawing.Point(477, 245);
            this.trackBarContrast.Maximum = 50;
            this.trackBarContrast.Minimum = -50;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(144, 45);
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.TickFrequency = 10;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CheckFileExists = true;
            this.saveFileDialog.FileName = "newImage";
            // 
            // buttonSavePicter
            // 
            this.buttonSavePicter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePicter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSavePicter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavePicter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSavePicter.Location = new System.Drawing.Point(507, 41);
            this.buttonSavePicter.Name = "buttonSavePicter";
            this.buttonSavePicter.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePicter.TabIndex = 9;
            this.buttonSavePicter.Text = "Save";
            this.buttonSavePicter.UseVisualStyleBackColor = false;
            this.buttonSavePicter.Click += new System.EventHandler(this.buttonSavePicter_Click);
            // 
            // FormShadesOfGray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.buttonSavePicter);
            this.Controls.Add(this.labelContrast);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBarBrigthness);
            this.Controls.Add(this.buttonChangePicter);
            this.Controls.Add(this.checkBoxGrayScale);
            this.Controls.Add(this.textBoxPicter);
            this.Controls.Add(this.buttonOpenPicture);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "FormShadesOfGray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "256 Shades Of Gray";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrigthness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonOpenPicture;
        private System.Windows.Forms.TextBox textBoxPicter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxGrayScale;
        private System.Windows.Forms.Button buttonChangePicter;
        private System.Windows.Forms.TrackBar trackBarBrigthness;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSavePicter;
    }
}

