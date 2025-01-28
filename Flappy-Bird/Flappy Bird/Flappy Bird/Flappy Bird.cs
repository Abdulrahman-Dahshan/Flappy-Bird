namespace Flappy_Bird
{
    public partial class Background : Form
    {
        int gravity = 15;
        int pipespeed = 8;
        int score = 0;
        bool gameStarted = false;
        bool pressed = false;

        public Background()
        {
            InitializeComponent();
        }



        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipespeed;
            PipeTop.Left -= pipespeed;
            Score.Text = score.ToString();

            if (!(gameStarted) && !(pressed))
            {
               GameTimer.Enabled = false;
            }

            if (PipeBottom.Left < 0)
            {
                PipeBottom.Left = 700;
                score++;
            }
            if (PipeTop.Left < 0)
            {
                PipeTop.Left = 730;
            }

            if (score > 4) pipespeed = 12;
            if (score > 10) pipespeed = 15;
            if (score > 19) pipespeed = 18;
            if(score > 29) pipespeed = 22;
            if (score > 44) pipespeed = 25;

            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) ||
                FlappyBird.Top < 0)
            {
                endGame();
            }

        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        public void endGame()
        {
            GameTimer.Stop();
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                pressed = true;
                GameTimer.Start();
            }
        }
    }
}
