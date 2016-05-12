namespace RockPaperCut
{
    partial class RockPaperCut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperCut));
            this.panelPicterTwo = new System.Windows.Forms.Panel();
            this.pictureBoxPaper = new System.Windows.Forms.PictureBox();
            this.panelPicterThree = new System.Windows.Forms.Panel();
            this.pictureBoxCut = new System.Windows.Forms.PictureBox();
            this.panelPicterCPU = new System.Windows.Forms.Panel();
            this.pictureBoxCutCPU = new System.Windows.Forms.PictureBox();
            this.pictureBoxRockCPU = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaperCPU = new System.Windows.Forms.PictureBox();
            this.panelPicterOne = new System.Windows.Forms.Panel();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPicterTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).BeginInit();
            this.panelPicterThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCut)).BeginInit();
            this.panelPicterCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCutCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperCPU)).BeginInit();
            this.panelPicterOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPicterTwo
            // 
            this.panelPicterTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicterTwo.Controls.Add(this.pictureBoxPaper);
            this.panelPicterTwo.Location = new System.Drawing.Point(169, 78);
            this.panelPicterTwo.Name = "panelPicterTwo";
            this.panelPicterTwo.Size = new System.Drawing.Size(120, 120);
            this.panelPicterTwo.TabIndex = 1;
            this.panelPicterTwo.Tag = "paper";
            this.panelPicterTwo.MouseEnter += new System.EventHandler(this.panelPicterOne_MouseEnter);
            // 
            // pictureBoxPaper
            // 
            this.pictureBoxPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaper.ErrorImage = null;
            this.pictureBoxPaper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaper.Image")));
            this.pictureBoxPaper.InitialImage = null;
            this.pictureBoxPaper.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaper.Name = "pictureBoxPaper";
            this.pictureBoxPaper.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxPaper.TabIndex = 3;
            this.pictureBoxPaper.TabStop = false;
            this.pictureBoxPaper.Visible = false;
            this.pictureBoxPaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRock_MouseClick);
            // 
            // panelPicterThree
            // 
            this.panelPicterThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicterThree.Controls.Add(this.pictureBoxCut);
            this.panelPicterThree.Location = new System.Drawing.Point(321, 78);
            this.panelPicterThree.Name = "panelPicterThree";
            this.panelPicterThree.Size = new System.Drawing.Size(120, 120);
            this.panelPicterThree.TabIndex = 1;
            this.panelPicterThree.Tag = "cut";
            this.panelPicterThree.MouseEnter += new System.EventHandler(this.panelPicterOne_MouseEnter);
            // 
            // pictureBoxCut
            // 
            this.pictureBoxCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCut.ErrorImage = null;
            this.pictureBoxCut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCut.Image")));
            this.pictureBoxCut.InitialImage = null;
            this.pictureBoxCut.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCut.Name = "pictureBoxCut";
            this.pictureBoxCut.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxCut.TabIndex = 4;
            this.pictureBoxCut.TabStop = false;
            this.pictureBoxCut.Visible = false;
            this.pictureBoxCut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRock_MouseClick);
            // 
            // panelPicterCPU
            // 
            this.panelPicterCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicterCPU.Controls.Add(this.pictureBoxCutCPU);
            this.panelPicterCPU.Controls.Add(this.pictureBoxRockCPU);
            this.panelPicterCPU.Controls.Add(this.pictureBoxPaperCPU);
            this.panelPicterCPU.Location = new System.Drawing.Point(513, 78);
            this.panelPicterCPU.Name = "panelPicterCPU";
            this.panelPicterCPU.Size = new System.Drawing.Size(120, 120);
            this.panelPicterCPU.TabIndex = 1;
            // 
            // pictureBoxCutCPU
            // 
            this.pictureBoxCutCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCutCPU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCutCPU.Image")));
            this.pictureBoxCutCPU.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCutCPU.Name = "pictureBoxCutCPU";
            this.pictureBoxCutCPU.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxCutCPU.TabIndex = 5;
            this.pictureBoxCutCPU.TabStop = false;
            this.pictureBoxCutCPU.Visible = false;
            // 
            // pictureBoxRockCPU
            // 
            this.pictureBoxRockCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRockCPU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRockCPU.Image")));
            this.pictureBoxRockCPU.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRockCPU.Name = "pictureBoxRockCPU";
            this.pictureBoxRockCPU.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxRockCPU.TabIndex = 3;
            this.pictureBoxRockCPU.TabStop = false;
            this.pictureBoxRockCPU.Visible = false;
            // 
            // pictureBoxPaperCPU
            // 
            this.pictureBoxPaperCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaperCPU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaperCPU.Image")));
            this.pictureBoxPaperCPU.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaperCPU.Name = "pictureBoxPaperCPU";
            this.pictureBoxPaperCPU.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxPaperCPU.TabIndex = 4;
            this.pictureBoxPaperCPU.TabStop = false;
            this.pictureBoxPaperCPU.Visible = false;
            // 
            // panelPicterOne
            // 
            this.panelPicterOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicterOne.Controls.Add(this.pictureBoxRock);
            this.panelPicterOne.Location = new System.Drawing.Point(19, 79);
            this.panelPicterOne.Name = "panelPicterOne";
            this.panelPicterOne.Size = new System.Drawing.Size(120, 120);
            this.panelPicterOne.TabIndex = 2;
            this.panelPicterOne.Tag = "rock";
            this.panelPicterOne.MouseEnter += new System.EventHandler(this.panelPicterOne_MouseEnter);
            // 
            // pictureBoxRock
            // 
            this.pictureBoxRock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRock.Image")));
            this.pictureBoxRock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRock.Name = "pictureBoxRock";
            this.pictureBoxRock.Size = new System.Drawing.Size(118, 118);
            this.pictureBoxRock.TabIndex = 3;
            this.pictureBoxRock.TabStop = false;
            this.pictureBoxRock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRock_MouseClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(17, 22);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(423, 31);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Choose your figure...";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(18, 230);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(423, 31);
            this.labelScore.TabIndex = 4;
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPU
            // 
            this.labelCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCPU.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(513, 22);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(120, 31);
            this.labelCPU.TabIndex = 5;
            this.labelCPU.Text = "CPU";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(673, 79);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(45, 117);
            this.trackBarSpeed.TabIndex = 6;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSpeed.Value = 3;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(673, 60);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 14);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Low";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "High";
            // 
            // RockPaperCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelPicterOne);
            this.Controls.Add(this.panelPicterCPU);
            this.Controls.Add(this.panelPicterThree);
            this.Controls.Add(this.panelPicterTwo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RockPaperCut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Cut";
            this.panelPicterTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).EndInit();
            this.panelPicterThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCut)).EndInit();
            this.panelPicterCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCutCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRockCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaperCPU)).EndInit();
            this.panelPicterOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPicterTwo;
        private System.Windows.Forms.Panel panelPicterThree;
        private System.Windows.Forms.Panel panelPicterCPU;
        private System.Windows.Forms.PictureBox pictureBoxPaper;
        private System.Windows.Forms.PictureBox pictureBoxCut;
        private System.Windows.Forms.PictureBox pictureBoxRockCPU;
        private System.Windows.Forms.PictureBox pictureBoxCutCPU;
        private System.Windows.Forms.PictureBox pictureBoxPaperCPU;
        private System.Windows.Forms.Panel panelPicterOne;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

