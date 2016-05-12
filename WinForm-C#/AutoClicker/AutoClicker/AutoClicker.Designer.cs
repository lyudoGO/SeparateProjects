namespace AutoClicker
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.trackBar_counter = new System.Windows.Forms.TrackBar();
            this.trackBar_time = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_show_delay = new System.Windows.Forms.Label();
            this.label_show_count = new System.Windows.Forms.Label();
            this.label_info_count = new System.Windows.Forms.Label();
            this.label_info_delay = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_time)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_counter
            // 
            this.trackBar_counter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_counter.LargeChange = 10;
            this.trackBar_counter.Location = new System.Drawing.Point(153, 3);
            this.trackBar_counter.Maximum = 100;
            this.trackBar_counter.Minimum = 1;
            this.trackBar_counter.Name = "trackBar_counter";
            this.trackBar_counter.Size = new System.Drawing.Size(144, 32);
            this.trackBar_counter.TabIndex = 0;
            this.trackBar_counter.TickFrequency = 10;
            this.trackBar_counter.Value = 1;
            this.trackBar_counter.Scroll += new System.EventHandler(this.trackBar_counter_Scroll);
            // 
            // trackBar_time
            // 
            this.trackBar_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_time.LargeChange = 100;
            this.trackBar_time.Location = new System.Drawing.Point(153, 41);
            this.trackBar_time.Maximum = 1000;
            this.trackBar_time.Minimum = 1;
            this.trackBar_time.Name = "trackBar_time";
            this.trackBar_time.Size = new System.Drawing.Size(144, 32);
            this.trackBar_time.SmallChange = 10;
            this.trackBar_time.TabIndex = 1;
            this.trackBar_time.TickFrequency = 100;
            this.trackBar_time.Value = 1;
            this.trackBar_time.Scroll += new System.EventHandler(this.trackBar_time_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label_show_delay, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_show_count, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_info_count, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_info_delay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_counter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_start, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label_show_delay
            // 
            this.label_show_delay.Location = new System.Drawing.Point(303, 38);
            this.label_show_delay.Name = "label_show_delay";
            this.label_show_delay.Size = new System.Drawing.Size(146, 23);
            this.label_show_delay.TabIndex = 5;
            this.label_show_delay.Text = "-";
            this.label_show_delay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_count
            // 
            this.label_show_count.Location = new System.Drawing.Point(303, 0);
            this.label_show_count.Name = "label_show_count";
            this.label_show_count.Size = new System.Drawing.Size(146, 23);
            this.label_show_count.TabIndex = 4;
            this.label_show_count.Text = "-";
            this.label_show_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_info_count
            // 
            this.label_info_count.Location = new System.Drawing.Point(3, 0);
            this.label_info_count.Name = "label_info_count";
            this.label_info_count.Size = new System.Drawing.Size(144, 23);
            this.label_info_count.TabIndex = 2;
            this.label_info_count.Text = "Click count";
            this.label_info_count.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_info_delay
            // 
            this.label_info_delay.Location = new System.Drawing.Point(3, 38);
            this.label_info_delay.Name = "label_info_delay";
            this.label_info_delay.Size = new System.Drawing.Size(144, 23);
            this.label_info_delay.TabIndex = 3;
            this.label_info_delay.Text = "Delay between clicks";
            this.label_info_delay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Location = new System.Drawing.Point(153, 79);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(144, 32);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start Click";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 114);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_time)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_counter;
        private System.Windows.Forms.TrackBar trackBar_time;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_info_count;
        private System.Windows.Forms.Label label_show_delay;
        private System.Windows.Forms.Label label_show_count;
        private System.Windows.Forms.Label label_info_delay;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer;
    }
}

