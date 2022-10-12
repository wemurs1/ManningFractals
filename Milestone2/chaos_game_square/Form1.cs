namespace chaos_game_square
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
        private int LastIndex = -1;
        private bool JustRepeated = false;
        private float Cx;
        private float Cy;

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
            Cx = bitmapWidth / 2;
            Cy = bitmapHeight / 2;
            ChaosBitmap = new Bitmap(bitmapWidth, bitmapHeight);
            var margin = 20;
            using (Graphics graphics = Graphics.FromImage(ChaosBitmap))
            {
                graphics.Clear(Color.Black);
            }
            chaosPictureBox.Image = ChaosBitmap;
            Points = new PointF[4];
            var lowerLeft = new PointF(margin, bitmapHeight - margin);
            var lowerRight = new PointF(bitmapWidth - margin, bitmapHeight - margin);
            var upperLeft = new PointF(margin, margin);
            var upperRight = new PointF(bitmapWidth - margin, margin);
            Points[0] = upperLeft;
            Points[1] = upperRight;
            Points[2] = lowerRight;
            Points[3] = lowerLeft;
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
            chaosPictureBox.Refresh();
        }

        private void DrawDot()
        {
            // Pick a random point.
            int index = Rand.Next(0, Points!.Length);

            // Check the first two restrictions.
            switch (restrictionComboBox.SelectedIndex)
            {
                case 1:
                    if (index == LastIndex) return;
                    break;
                case 2:
                    if (index == (LastIndex + 1) % 4) return;
                    break;
            }

            // Go halfway to the new point.
            float x = (CurrentPoint.X + Points[index].X) / 2f;
            float y = (CurrentPoint.Y + Points[index].Y) / 2f;

            // Check the remaining restrctions.
            switch (restrictionComboBox.SelectedIndex)
            {
                case 3:
                    if (Distance(Cx, Cy, x, y) < 30.0) return;
                    break;
                case 4:
                    if (index == (LastIndex + 2) % 4) return;
                    break;
                case 5:
                    if (JustRepeated)
                    {
                        if (index == (LastIndex + 1) % 4) return;
                        if (index == (LastIndex + 3) % 4) return;
                    }
                    break;
            }

            // Move to this point.
            JustRepeated = (index == LastIndex);
            LastIndex = index;
            CurrentPoint = new PointF(x, y);
            ChaosBitmap!.SetPixel((int)CurrentPoint.X, (int)CurrentPoint.Y, Color.LightBlue);

            // We drew a dot, so increment NumDotsDrawn.
            NumDotsDrawn++;
        }

        private double Distance(float cx, float cy, float x, float y)
        {
            var lengthX = Math.Abs(cx - x);
            var lengthY = Math.Abs(cy - y);
            return Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
        }
    }
}