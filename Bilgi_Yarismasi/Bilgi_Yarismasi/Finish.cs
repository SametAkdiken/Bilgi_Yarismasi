using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        public string skor, dogru, yanlis;
    

        private void lbl_mesaj_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Load(object sender, EventArgs e)
        {
            lbl_dgr.Text = dogru.ToString();
            lbl_skr.Text = skor.ToString();
            lbl_ynls.Text = yanlis.ToString();
            pictureBox1.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.durum = 0;
            this.Close();
        }
    }
}
