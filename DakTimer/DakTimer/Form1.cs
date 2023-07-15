using System;
using System.Media;
using System.Windows.Forms;

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
            UpdateTimeLabel();

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

            StopSimpleSound();
        }

        private void StartTimer(int duration)
        {
            remainingTime = duration;
            UpdateTimeLabel();
            timer.Start();
        }
        private void StopSimpleSound()
        {
            // Stop the currently playing sound
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Users\adaib\Downloads\Waves-1.wav");
            simpleSound.Stop();
        }
        private void playSimpleSound()
        {

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Users\adaib\Downloads\Waves-1.wav");
            simpleSound.Play();
        }
    }
}