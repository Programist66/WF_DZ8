using System.Drawing.Drawing2D;

namespace WF_DZ8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawApple(e.Graphics);
        }

        private void DrawApple(Graphics g)
        {
            int h = Math.Min(ClientSize.Height, ClientSize.Width);                
            int w = h;
            int startGrowPoint = (w / 2 - w / 4) / 2 + w / 4;
            g.FillEllipse(Brushes.Red, new Rectangle(0,h/5,w/2,h*4/5));
            g.FillEllipse(Brushes.Red, new Rectangle(w/4, h/5, w/2, h*4/5));
            g.FillPolygon(Brushes.Brown, new Point[] {new Point(startGrowPoint, h/4), new Point(startGrowPoint + w /5, 0), new Point(startGrowPoint + w / 4, h/50)});
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
