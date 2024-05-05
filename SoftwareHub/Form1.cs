using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
//If you are seeing this edit the code below.
namespace SoftwareHub
{
    public partial class Form1 : Form
    {
        string CAMNAME = "";
        string VIDEO_URL = "";
        LibVLC _libvlc;
        MediaPlayer _mediaPlayer;
        VideoView _videoView;
        private Timer _timer;

        public Form1()
        {
            InitializeComponent();

            Core.Initialize();
            _libvlc = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libvlc);
            _videoView = new VideoView();
            _videoView.Dock = DockStyle.Fill;
            Controls.Add(_videoView);
            _videoView.MediaPlayer = _mediaPlayer;
            _timer = new Timer();
            _timer.Interval = 1000; // Update every second
            _timer.Tick += Timer_Tick;
            _timer.Start();
            camname.Text = CAMNAME;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            VIDEO_URL = "rtsp://" + textBox1.Text;
            var rtsp1 = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            _mediaPlayer.Play(rtsp1);
            label2.Visible = false;
            
            
            try
            {
                

            }
            catch
            {
                
                label2.Visible = true;
                

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time label with the current timestamp
            time.Text = DateTime.Now.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
