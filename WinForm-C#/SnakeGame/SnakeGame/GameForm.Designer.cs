namespace SnakeGame
{
    partial class GameForm
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
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreValue = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelApples = new System.Windows.Forms.Label();
            this.labelAppleCount = new System.Windows.Forms.Label();
            this.labelOranges = new System.Windows.Forms.Label();
            this.labelOrangeCount = new System.Windows.Forms.Label();
            this.labelTomatos = new System.Windows.Forms.Label();
            this.labelTomatoCount = new System.Windows.Forms.Label();
            this.labelLemons = new System.Windows.Forms.Label();
            this.labelLemonCount = new System.Windows.Forms.Label();
            this.labelGameStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxGame.Location = new System.Drawing.Point(1, 41);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(480, 320);
            this.pictureBoxGame.TabIndex = 0;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGame_Paint);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(89, 29);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score:";
            // 
            // labelScoreValue
            // 
            this.labelScoreValue.AutoSize = true;
            this.labelScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreValue.Location = new System.Drawing.Point(107, 9);
            this.labelScoreValue.Name = "labelScoreValue";
            this.labelScoreValue.Size = new System.Drawing.Size(27, 29);
            this.labelScoreValue.TabIndex = 2;
            this.labelScoreValue.Text = "0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.BackColor = System.Drawing.SystemColors.Info;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.Location = new System.Drawing.Point(134, 165);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(200, 38);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApples
            // 
            this.labelApples.AutoSize = true;
            this.labelApples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApples.Location = new System.Drawing.Point(145, 18);
            this.labelApples.Name = "labelApples";
            this.labelApples.Size = new System.Drawing.Size(54, 16);
            this.labelApples.TabIndex = 4;
            this.labelApples.Text = "Apples:";
            // 
            // labelAppleCount
            // 
            this.labelAppleCount.AutoSize = true;
            this.labelAppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAppleCount.Location = new System.Drawing.Point(196, 18);
            this.labelAppleCount.Name = "labelAppleCount";
            this.labelAppleCount.Size = new System.Drawing.Size(15, 16);
            this.labelAppleCount.TabIndex = 5;
            this.labelAppleCount.Text = "0";
            // 
            // labelOranges
            // 
            this.labelOranges.AutoSize = true;
            this.labelOranges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOranges.Location = new System.Drawing.Point(217, 19);
            this.labelOranges.Name = "labelOranges";
            this.labelOranges.Size = new System.Drawing.Size(63, 16);
            this.labelOranges.TabIndex = 6;
            this.labelOranges.Text = "Oranges:";
            // 
            // labelOrangeCount
            // 
            this.labelOrangeCount.AutoSize = true;
            this.labelOrangeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrangeCount.Location = new System.Drawing.Point(277, 18);
            this.labelOrangeCount.Name = "labelOrangeCount";
            this.labelOrangeCount.Size = new System.Drawing.Size(15, 16);
            this.labelOrangeCount.TabIndex = 7;
            this.labelOrangeCount.Text = "0";
            // 
            // labelTomatos
            // 
            this.labelTomatos.AutoSize = true;
            this.labelTomatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTomatos.Location = new System.Drawing.Point(299, 19);
            this.labelTomatos.Name = "labelTomatos";
            this.labelTomatos.Size = new System.Drawing.Size(65, 16);
            this.labelTomatos.TabIndex = 8;
            this.labelTomatos.Text = "Tomatos:";
            // 
            // labelTomatoCount
            // 
            this.labelTomatoCount.AutoSize = true;
            this.labelTomatoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTomatoCount.Location = new System.Drawing.Point(362, 19);
            this.labelTomatoCount.Name = "labelTomatoCount";
            this.labelTomatoCount.Size = new System.Drawing.Size(15, 16);
            this.labelTomatoCount.TabIndex = 9;
            this.labelTomatoCount.Text = "0";
            // 
            // labelLemons
            // 
            this.labelLemons.AutoSize = true;
            this.labelLemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLemons.Location = new System.Drawing.Point(383, 18);
            this.labelLemons.Name = "labelLemons";
            this.labelLemons.Size = new System.Drawing.Size(59, 16);
            this.labelLemons.TabIndex = 10;
            this.labelLemons.Text = "Lemons:";
            // 
            // labelLemonCount
            // 
            this.labelLemonCount.AutoSize = true;
            this.labelLemonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLemonCount.Location = new System.Drawing.Point(439, 19);
            this.labelLemonCount.Name = "labelLemonCount";
            this.labelLemonCount.Size = new System.Drawing.Size(15, 16);
            this.labelLemonCount.TabIndex = 11;
            this.labelLemonCount.Text = "0";
            // 
            // labelGameStart
            // 
            this.labelGameStart.BackColor = System.Drawing.Color.MintCream;
            this.labelGameStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGameStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameStart.Location = new System.Drawing.Point(0, 0);
            this.labelGameStart.Name = "labelGameStart";
            this.labelGameStart.Size = new System.Drawing.Size(484, 362);
            this.labelGameStart.TabIndex = 12;
            this.labelGameStart.Text = "Snake Game\r\nCreated by lyudoGo\r\n\r\nUse arrow keys to play\r\nUse space to Pause the " +
    "Game\r\n\r\nTo start press Enter";
            this.labelGameStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameStart.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.labelGameStart);
            this.Controls.Add(this.labelLemonCount);
            this.Controls.Add(this.labelLemons);
            this.Controls.Add(this.labelTomatoCount);
            this.Controls.Add(this.labelTomatos);
            this.Controls.Add(this.labelOrangeCount);
            this.Controls.Add(this.labelOranges);
            this.Controls.Add(this.labelAppleCount);
            this.Controls.Add(this.labelApples);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScoreValue);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreValue;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelApples;
        private System.Windows.Forms.Label labelAppleCount;
        private System.Windows.Forms.Label labelOranges;
        private System.Windows.Forms.Label labelOrangeCount;
        private System.Windows.Forms.Label labelTomatos;
        private System.Windows.Forms.Label labelTomatoCount;
        private System.Windows.Forms.Label labelLemons;
        private System.Windows.Forms.Label labelLemonCount;
        private System.Windows.Forms.Label labelGameStart;
    }
}

