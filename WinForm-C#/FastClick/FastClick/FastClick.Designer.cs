namespace FastClick
{
    partial class FastClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastClick));
            this.label_counter = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_counter
            // 
            this.label_counter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_counter.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counter.Location = new System.Drawing.Point(33, 85);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(209, 85);
            this.label_counter.TabIndex = 0;
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_counter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_counter_MouseDown);
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(33, 22);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(209, 29);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start Game";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_message
            // 
            this.label_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_message.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.Location = new System.Drawing.Point(33, 188);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(209, 30);
            this.label_message.TabIndex = 2;
            this.label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_about
            // 
            this.button_about.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.Location = new System.Drawing.Point(33, 227);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(209, 23);
            this.button_about.TabIndex = 3;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // FastClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_counter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FastClick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastClick Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_about;
    }
}

