using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Homework
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000; // 1000 миллисекунд = 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            DateTime currentTime = DateTime.Now;
            UpdateAnalogClock(currentTime);
            UpdateDigitalClock(currentTime);
        }

        private void UpdateAnalogClock(DateTime currentTime)
        {
            int hoursAngle = (currentTime.Hour % 12) * 30 + currentTime.Minute / 2;
            int minutesAngle = currentTime.Minute * 6 + currentTime.Second / 10;
            int secondsAngle = currentTime.Second * 6;

            hourHandPictureBox.Image = RotateImage(Properties.Resources.hour_hand, hoursAngle);
            minuteHandPictureBox.Image = RotateImage(Properties.Resources.minute_hand, minutesAngle);
            secondHandPictureBox.Image = RotateImage(Properties.Resources.second_hand, secondsAngle);
        }

        private void UpdateDigitalClock(DateTime currentTime)
        {
            digitalClockLabel.Text = currentTime.ToString("HH:mm:ss");
        }

        private Bitmap RotateImage(Image image, float angle)
        { 
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }
            return rotatedImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
