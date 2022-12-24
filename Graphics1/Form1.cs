namespace Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red, 3);
            g.DrawRectangle(myPen,10, 10, 400, 75);
            g.DrawRectangle(myPen, 10, 100, 400, 60);
            g.DrawRectangle(myPen, 10, 175, 400, 45);
            g.DrawRectangle(myPen, 10, 250, 400, 30);
            g.DrawRectangle(myPen, 10, 325, 400, 15);
            g.DrawRectangle(myPen, 10, 400, 400, 5);

        }
    }
}