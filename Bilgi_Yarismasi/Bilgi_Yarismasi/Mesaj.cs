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
    public partial class Mesaj : Form
    {
        public string cevap;
        public Mesaj()
        {
            InitializeComponent();
        }
        public string acıklama;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {
            lbl_cevap.Text = acıklama;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_cevap.Text = cevap;
        }
    }
}
