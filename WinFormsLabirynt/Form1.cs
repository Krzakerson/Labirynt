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

            if (moveRight== true && pictureBox1.Left < 830)
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

            if (pictureBox1.Left <= pictureBox2.Right && pictureBox2.Left <= pictureBox1.Right
                && pictureBox1.Top <= pictureBox2.Top && pictureBox2.Top <= pictureBox1.Top)
            {
                new Win().ShowDialog();
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