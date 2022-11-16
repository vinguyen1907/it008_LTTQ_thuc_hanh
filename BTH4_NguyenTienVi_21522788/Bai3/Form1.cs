using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = $"Hôm nay là ngày: {DateTime.Now.ToShortDateString()} - Bây giờ là: {DateTime.Now.ToLongTimeString()}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AVI|*.avi|MP4|*.mp4|MPEG|*.mpeg|WAV|*.wav|MIDI|*.midi|MP3|*.mp3|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }
    }
}
