using System;
using System.Windows.Forms;
using System.Media;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player = null;
        string fileName = string.Empty;
        void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        void button1_Click(object sender, EventArgs e)
        {
                player.SoundLocation = fileName;
                player.Play();
        }

        void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Filter = "WAV|*.wav",
                Multiselect = false,
                ValidateNames = true
            };

            if(op.ShowDialog() == DialogResult.OK)
            {
                fileName = op.FileName;
                textBox1.Text = fileName;
            }
        }
    }
}
