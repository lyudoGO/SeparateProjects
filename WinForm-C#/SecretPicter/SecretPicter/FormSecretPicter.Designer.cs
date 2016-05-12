namespace SecretPicter
{
    partial class FormSecretPicter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretPicter));
            this.buttonPicterOne = new System.Windows.Forms.Button();
            this.buttonPicterTwo = new System.Windows.Forms.Button();
            this.buttonPicterThree = new System.Windows.Forms.Button();
            this.buttonPicterFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPicterOne
            // 
            this.buttonPicterOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPicterOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPicterOne.Location = new System.Drawing.Point(12, 12);
            this.buttonPicterOne.Name = "buttonPicterOne";
            this.buttonPicterOne.Size = new System.Drawing.Size(60, 20);
            this.buttonPicterOne.TabIndex = 0;
            this.buttonPicterOne.Text = "Car 1";
            this.buttonPicterOne.UseVisualStyleBackColor = true;
            this.buttonPicterOne.Click += new System.EventHandler(this.buttonPicterOne_Click);
            // 
            // buttonPicterTwo
            // 
            this.buttonPicterTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPicterTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPicterTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPicterTwo.Location = new System.Drawing.Point(212, 12);
            this.buttonPicterTwo.Name = "buttonPicterTwo";
            this.buttonPicterTwo.Size = new System.Drawing.Size(60, 20);
            this.buttonPicterTwo.TabIndex = 1;
            this.buttonPicterTwo.Text = "Car 2";
            this.buttonPicterTwo.UseVisualStyleBackColor = true;
            this.buttonPicterTwo.Click += new System.EventHandler(this.buttonPicterTwo_Click);
            // 
            // buttonPicterThree
            // 
            this.buttonPicterThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPicterThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPicterThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPicterThree.Location = new System.Drawing.Point(12, 227);
            this.buttonPicterThree.Name = "buttonPicterThree";
            this.buttonPicterThree.Size = new System.Drawing.Size(60, 20);
            this.buttonPicterThree.TabIndex = 2;
            this.buttonPicterThree.Text = "Car 3";
            this.buttonPicterThree.UseVisualStyleBackColor = true;
            this.buttonPicterThree.Click += new System.EventHandler(this.buttonPicterThree_Click);
            // 
            // buttonPicterFour
            // 
            this.buttonPicterFour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPicterFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPicterFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPicterFour.Location = new System.Drawing.Point(208, 227);
            this.buttonPicterFour.Name = "buttonPicterFour";
            this.buttonPicterFour.Size = new System.Drawing.Size(60, 20);
            this.buttonPicterFour.TabIndex = 3;
            this.buttonPicterFour.Text = "Car 4";
            this.buttonPicterFour.UseVisualStyleBackColor = true;
            this.buttonPicterFour.Click += new System.EventHandler(this.buttonPicterFour_Click);
            // 
            // FormSecretPicter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonPicterFour);
            this.Controls.Add(this.buttonPicterThree);
            this.Controls.Add(this.buttonPicterTwo);
            this.Controls.Add(this.buttonPicterOne);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormSecretPicter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Picter";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicter_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPicterOne;
        private System.Windows.Forms.Button buttonPicterTwo;
        private System.Windows.Forms.Button buttonPicterThree;
        private System.Windows.Forms.Button buttonPicterFour;
    }
}

