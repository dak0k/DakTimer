using System;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DakTimer
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer timer;
        private int remainingTime;
        private bool isPaused;

        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                UpdateTimeLabel();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Timer finished!");
                playSimpleSound();
            }
        }
        private void UpdateTimeLabel()
        {
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            _time.Text = $"00:{minutes:D2}:{seconds:D2}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BgPicture_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {
        
        }

        private void _Min5Btn_Click(object sender, EventArgs e)
        {
            StartTimer(5 * 60); 

        }

        private void _Min15Btn_Click(object sender, EventArgs e)
        {
            StartTimer(15 * 60); 
        }

        private void _Min20Btn_Click(object sender, EventArgs e)
        {
            StartTimer(20 * 60); 
        }

        private void _Min30Btn_Click(object sender, EventArgs e)
        {
            StartTimer(30 * 60); 
        }

        private void _Min45Btn_Click(object sender, EventArgs e)
        {
            StartTimer(45 * 60);
        }

        private void _Min60Btn_Click(object sender, EventArgs e)
        {
            StartTimer(60 * 60);
        }

        private void _playBtn_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                timer.Start();
                isPaused = false;
            }
            else
            {
                StartTimer(remainingTime);
            }
        }

        private void _pauseBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isPaused = true;
        }

        private void StartTimer(int duration)
        {
            remainingTime = duration;
            UpdateTimeLabel();
            timer.Start();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\adaib\Downloads\Waves-1.mp3");
            simpleSound.Play();
        }
    }
}