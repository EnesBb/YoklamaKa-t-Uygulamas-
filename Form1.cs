using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YoklamaKagidiAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString(); // label a saati yazdırma kodu
        }
        SoundPlayer ses = new SoundPlayer();
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text==label1.Text)
            {
                SoundPlayer ses = new SoundPlayer();

                ses.SoundLocation = "SesKaydı.wav";

                ses.Play();
                MessageBox.Show("YOKLAMA KAGIDI!!!");
            }
        }

        private void BtnDur_Click(object sender, EventArgs e)
        {
            ses.Stop();
        }

       
    }
}
