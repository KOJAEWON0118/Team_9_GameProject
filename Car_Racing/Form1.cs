using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        enum KeyRole
        {
            Forward,
            Backward,
            RotateLeft,
            RotateRight
        }
        
        // 기본 이미지 및 맵
        Image car;
        Image map;
        string map_name = "map.png";
        Random random = new Random();

        // 키 상태
        HashSet<Keys> pressedKeys = new HashSet<Keys>();
        Dictionary<KeyRole, Keys> roleToKey = new Dictionary<KeyRole, Keys>();
        Dictionary<Keys, KeyRole> keyToRole = new Dictionary<Keys, KeyRole>();
        Dictionary<Keys, Image> keyToArrowImage = new Dictionary<Keys, Image>();

        // 자동차 상태
        PointF car_position = new PointF(400f, 400f);
        float imageOffsetAngle = -90f;
        float angleDeg = 0f;
        float speed = 0f;
        float carScale = 0.5f;
        const float maxSpeed = 5f;
        const float accel = 0.2f;
        const float friction = 0.05f;
        const float carRadius = 15f;

        // 게임 필드
        int width = 800;
        int height = 600;
        int gridRows = 4, gridCols = 4;
        int cellWidth, cellHeight;
        int selectPoint = 10;
        float samplingNum = 100;
        float brushRadius = 30f;
        List<PointF> gridCenters = new List<PointF>();
        List<PointF> selectedPoints = new List<PointF>();
        List<PointF> splinePoints = new List<PointF>();
        HashSet<PointF> visitedPoints = new HashSet<PointF>();

        // 키 아이콘 표시 위치
        readonly Point upPos = new Point(80, 40);
        readonly Point downPos = new Point(80, 160);
        readonly Point leftPos = new Point(20, 100);
        readonly Point rightPos = new Point(140, 100);
        const int arrowSize = 50;

        // 점수
        int score = 0;
        bool[,] passed;
        const int gridX = 40;
        const int gridY = 30;
        const int gridSize = 20;
        int playTime = 60;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = width;
            this.Height = height;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(width / 2 - label2.Text.Length*5, label2.Location.Y);

            InitGame();
            ShuffleKeyRoles();

            GenerateGridPoints();
            SelectRandomPoints(selectPoint);
            GenerateSplinePoints();

            GameLoop.Interval = 20;
            GameLoop.Tick += Render;
            GameLoop.Start();

            EndTimer.Interval = 1000;
            EndTimer.Tick += Quit;
            EndTimer.Start();

            ShuffleKey.Interval = 10000;
            ShuffleKey.Tick += shuffleKey;
            ShuffleKey.Start();

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        void InitGame()
        {
            try
            {
                car = Image.FromFile("car_yellow.png");
                car = ResizeImage(car, new Size((int)(car.Width * carScale), (int)(car.Height * carScale)));

                map = Image.FromFile(map_name);
                keyToArrowImage[Keys.Up] = Image.FromFile("up_arrow.png");
                keyToArrowImage[Keys.Down] = Image.FromFile("down_arrow.png");
                keyToArrowImage[Keys.Left] = Image.FromFile("left_arrow.png");
                keyToArrowImage[Keys.Right] = Image.FromFile("right_arrow.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드 실패: " + ex.Message);
            }

            passed = new bool[gridX, gridY];
            score = 0;
        }

        void Quit(object sender, EventArgs e)
        {
            playTime--;
            label2.Text = $"남은 시간: {playTime}";
            if(playTime == 0)
            {
                EndTimer.Stop();
                GameLoop.Stop();
                MessageBox.Show(score.ToString());
                this.Close();
            }
            
        }

        void GenerateGridPoints()
        {
            gridCenters.Clear();
            cellWidth = this.ClientSize.Width / gridCols;
            cellHeight = this.ClientSize.Height / gridRows;

            for (int col = 0; col < gridCols; col++)   
            {
                for (int row = 0; row < gridRows; row++)
                {
                    float x = col * cellWidth + cellWidth / 2f;
                    float y = row * cellHeight + cellHeight / 2f;
                    gridCenters.Add(new PointF(x, y));
                }
            }
        }

        private void SelectRandomPoints(int count)
        {
            selectedPoints = gridCenters
                .Skip(2)
                .OrderBy(p => random.Next())
                .Take(count)
                .ToList();

            PointF center = new PointF(
                selectedPoints.Average(p => p.X),
                selectedPoints.Average(p => p.Y));

            selectedPoints = selectedPoints
                .OrderBy(p => Math.Atan2(p.Y - center.Y, p.X - center.X))
                .ToList();
        }

        private void GenerateSplinePoints()
        {
            splinePoints.Clear();

            if (selectedPoints.Count < 2) return;

            List<PointF> paddedPoints = new List<PointF>();
            paddedPoints.Add(selectedPoints[0]);
            paddedPoints.AddRange(selectedPoints);
            paddedPoints.Add(selectedPoints[selectedPoints.Count - 1]);

            for (int i = 0; i < paddedPoints.Count - 3; i++)
            {
                PointF p0 = paddedPoints[i];
                PointF p1 = paddedPoints[i + 1];
                PointF p2 = paddedPoints[i + 2];
                PointF p3 = paddedPoints[i + 3];

                for (int j = 0; j <= samplingNum; j++) // <= 로 마지막 점 포함
                {
                    float t = j / (float)samplingNum;
                    float t2 = t * t;
                    float t3 = t2 * t;

                    float x = 0.5f * ((2 * p1.X) +
                                      (-p0.X + p2.X) * t +
                                      (2 * p0.X - 5 * p1.X + 4 * p2.X - p3.X) * t2 +
                                      (-p0.X + 3 * p1.X - 3 * p2.X + p3.X) * t3);

                    float y = 0.5f * ((2 * p1.Y) +
                                      (-p0.Y + p2.Y) * t +
                                      (2 * p0.Y - 5 * p1.Y + 4 * p2.Y - p3.Y) * t2 +
                                      (-p0.Y + 3 * p1.Y - 3 * p2.Y + p3.Y) * t3);

                    splinePoints.Add(new PointF(x, y));
                }
            }
        }

        Image ResizeImage(Image imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            }
            return b;
        }

        void shuffleKey(object sender, EventArgs e)
        {
            ShuffleKeyRoles();
        }

        void ShuffleKeyRoles()
        {
            var roles = Enum.GetValues(typeof(KeyRole)).Cast<KeyRole>().OrderBy(x => random.Next()).ToList();
            var keys = new[] { Keys.Up, Keys.Down, Keys.Left, Keys.Right };

            roleToKey.Clear();
            keyToRole.Clear();

            for (int i = 0; i < 4; i++)
            {
                roleToKey[roles[i]] = keys[i];
                keyToRole[keys[i]] = roles[i];
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
        }

        void Render(object sender, EventArgs e)
        {
            if (IsRolePressed(KeyRole.RotateLeft)) angleDeg -= 5f;
            if (IsRolePressed(KeyRole.RotateRight)) angleDeg += 5f;

            if (IsRolePressed(KeyRole.Forward))
            {
                speed = Math.Min(speed + accel, maxSpeed);
                float rad = angleDeg * (float)Math.PI / 180f;
                car_position.X += (float)Math.Cos(rad) * speed;
                car_position.Y += (float)Math.Sin(rad) * speed;
            }
            else if (IsRolePressed(KeyRole.Backward))
            {
                speed = Math.Min(speed - accel, maxSpeed);
                float rad = angleDeg * (float)Math.PI / 180f;
                car_position.X += (float)Math.Cos(rad) * speed;
                car_position.Y += (float)Math.Sin(rad) * speed;
            }
            else
            {
                speed = Math.Max(speed - friction, 0f);
            }

            ClampCarPosition();
            CheckPointHit(car_position);

            label1.Text = $"Score: {score}";
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(map, 0, 0, width, height);

            foreach (var pt in splinePoints)
            {
                g.FillEllipse(Brushes.Gray, pt.X - brushRadius / 2, pt.Y - brushRadius / 2, brushRadius, brushRadius);
            }

            using (Pen pen = new Pen(Color.Yellow, 3))
            {
                g.DrawLines(pen, splinePoints.ToArray());
            }

            foreach (var pt in selectedPoints)
            {
                if(!visitedPoints.Contains(pt))
                g.FillEllipse(Brushes.IndianRed, pt.X - 5, pt.Y - 5, 10, 10);
            }

            g.TranslateTransform(car_position.X, car_position.Y);
            g.RotateTransform(angleDeg - imageOffsetAngle);

            g.DrawImage(car, -car.Width /2, -car.Height /2);
            g.ResetTransform();

            DrawDirectionKeys(g);
        }

        void ClampCarPosition()
        {
            car_position.X = Math.Max(carRadius, Math.Min(width - carRadius, car_position.X));
            car_position.Y = Math.Max(carRadius, Math.Min(height - carRadius, car_position.Y));
        }

        void CheckPointHit(PointF brushPos)
        {
            float threshold = 10f;

            foreach (var target in selectedPoints)
            {
                if (!visitedPoints.Contains(target))
                {
                    float dist = Distance(brushPos, target);
                    if (dist <= threshold)
                    {
                        score++;
                        visitedPoints.Add(target);
                    }
                }
            }
        }

        float Distance(PointF a, PointF b)
        {
            float dx = a.X - b.X;
            float dy = a.Y - b.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        bool IsRolePressed(KeyRole role)
        {
            return roleToKey.TryGetValue(role, out Keys key) && pressedKeys.Contains(key);
        }

        void DrawDirectionKeys(Graphics g)
        {

            Dictionary<KeyRole, Point> roleToPosition = new Dictionary<KeyRole, Point>
            {
                { KeyRole.Forward, upPos },
                { KeyRole.Backward, downPos },
                { KeyRole.RotateLeft, leftPos },
                { KeyRole.RotateRight, rightPos }
            };

            foreach (var kvp in roleToPosition)
            {
                if (roleToKey.TryGetValue(kvp.Key, out Keys key) &&
                    keyToArrowImage.TryGetValue(key, out Image img))
                {
                    g.DrawImage(img, new Rectangle(kvp.Value, new Size(arrowSize, arrowSize)));
                }
            }
        }
    }
}
