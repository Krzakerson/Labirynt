namespace WinFormsLabirynt
{
    public partial class Form1 : Form
    {
        bool moveUp, moveDown, moveLeft, moveRight;

        int speed = 15;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if(moveLeft == true && pictureBox1.Left >  0)
            {
                pictureBox1.Left -= speed;
            }

            if (moveRight== true && pictureBox1.Left < 646)
            {
                pictureBox1.Left += speed;
            }

            if (moveUp == true && pictureBox1.Top > 0 )
            {
                pictureBox1.Top -= speed;
            }


            if (moveDown == true && pictureBox1.Top < 517)
            {
                pictureBox1.Top += speed;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

        }
    }
}