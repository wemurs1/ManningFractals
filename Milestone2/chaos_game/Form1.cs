namespace chaos_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Drawing = false;
        private Random Rand = new();
        private int NumDotsDrawn = 0;
        private Bitmap? ChaosBitmap = null;
        private PointF[]? Points = null;
        private PointF CurrentPoint;

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Drawing) Stop();
            else Start();
        }

        private void Start()
        {
            Drawing = true;
            startButton.Text = "Stop";
            var bitmapWidth = chaosPictureBox.Size.Width;
            var bitmapHeight = chaosPictureBox.Size.Height;
            ChaosBitmap = new Bitmap(bitmapWidth, bitmapHeight);
            var margin = 20;
            using (Graphics graphics = Graphics.FromImage(ChaosBitmap))
            {
                graphics.Clear(Color.Black);
            }
            chaosPictureBox.Image = ChaosBitmap;
            Points = new PointF[3];
            var lowerLeft = new PointF(margin, bitmapHeight - margin);
            var lowerRight = new PointF(bitmapWidth - margin, bitmapHeight - margin);
            var upperMiddle = new PointF(bitmapWidth / 2, margin);
            Points[0] = lowerLeft;
            Points[1] = lowerRight;
            Points[2] = upperMiddle;
            CurrentPoint = new PointF(bitmapWidth / 2, bitmapHeight / 2);
            NumDotsDrawn = 0;
            dotsTimer.Start();
        }

        private void Stop()
        {
            Drawing = false;
            startButton.Text = "Start";
            // dotsTimer.Stop();
        }

        private void dotsTimer_Tick(object sender, EventArgs e)
        {
            if (!Drawing)
            {
                dotsTimer.Stop();
                Console.WriteLine($"NumDotsDrawn: {NumDotsDrawn}");
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                DrawDot();
            }
            NumDotsDrawn += 100;
            chaosPictureBox.Refresh();
        }

        private void DrawDot()
        {
            var index = Rand.Next(0, Points!.Length);
            var referencePoint = Points[index];
            CurrentPoint = new PointF(Math.Abs(referencePoint.X - CurrentPoint.X), Math.Abs(referencePoint.Y - CurrentPoint.Y));
            ChaosBitmap!.SetPixel((int)Math.Round(CurrentPoint.X, 0), (int)Math.Round(CurrentPoint.Y, 0), Color.Red);
        }
    }
}