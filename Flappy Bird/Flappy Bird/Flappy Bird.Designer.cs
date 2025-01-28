namespace Flappy_Bird
{
    partial class Background
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            Ground = new PictureBox();
            FlappyBird = new PictureBox();
            PipeTop = new PictureBox();
            PipeBottom = new PictureBox();
            Score = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeBottom).BeginInit();
            SuspendLayout();
            // 
            // Ground
            // 
            Ground.BackgroundImage = Properties.Resources.ground;
            Ground.Location = new Point(0, 403);
            Ground.Name = "Ground";
            Ground.Size = new Size(858, 104);
            Ground.TabIndex = 0;
            Ground.TabStop = false;
            // 
            // FlappyBird
            // 
            FlappyBird.BackColor = Color.Transparent;
            FlappyBird.BackgroundImage = Properties.Resources.bird_down2;
            FlappyBird.Location = new Point(187, 183);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(34, 25);
            FlappyBird.TabIndex = 0;
            FlappyBird.TabStop = false;
            // 
            // PipeTop
            // 
            PipeTop.BackgroundImage = Properties.Resources.sky_pipe;
            PipeTop.Location = new Point(619, 1);
            PipeTop.Name = "PipeTop";
            PipeTop.Size = new Size(46, 120);
            PipeTop.TabIndex = 0;
            PipeTop.TabStop = false;
            // 
            // PipeBottom
            // 
            PipeBottom.BackgroundImage = Properties.Resources.ground_pipe;
            PipeBottom.Location = new Point(466, 245);
            PipeBottom.Name = "PipeBottom";
            PipeBottom.Size = new Size(51, 161);
            PipeBottom.TabIndex = 0;
            PipeBottom.TabStop = false;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Score.Location = new Point(29, 449);
            Score.Name = "Score";
            Score.Size = new Size(114, 37);
            Score.TabIndex = 1;
            Score.Text = "Score : 0";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Background
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(734, 504);
            Controls.Add(Score);
            Controls.Add(PipeBottom);
            Controls.Add(PipeTop);
            Controls.Add(FlappyBird);
            Controls.Add(Ground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Background";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird";
            KeyDown += KeyDownEvent;
            KeyUp += KeyUpEvent;
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Ground;
        private PictureBox FlappyBird;
        private PictureBox PipeTop;
        private PictureBox PipeBottom;
        private Label Score;
        private System.Windows.Forms.Timer GameTimer;
    }
}
