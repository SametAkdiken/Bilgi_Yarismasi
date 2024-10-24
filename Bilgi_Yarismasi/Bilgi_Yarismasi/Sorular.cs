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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        public int soru_no;
        string cevap;

        private void button_disable() 
        {
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;

            lbl_dgru.Text = Form1.dogru.ToString();
            lbl_ynls.Text = Form1.yanlis.ToString();
        }

        public void SetBackgroundImage(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.b1;
                    pb_r1.Image = Properties.Resources.r1;
                    pb_r2.Image = Properties.Resources.r1;
                    pb_r3.Image = Properties.Resources.r1;
                    pb_r4.Image = Properties.Resources.r1;                    
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.b2;
                    pb_r1.Image = Properties.Resources.r2;
                    pb_r2.Image = Properties.Resources.r2;
                    pb_r3.Image = Properties.Resources.r2;
                    pb_r4.Image = Properties.Resources.r2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.b3;
                    pb_r1.Image = Properties.Resources.r3;
                    pb_r2.Image = Properties.Resources.r3;
                    pb_r3.Image = Properties.Resources.r3;
                    pb_r4.Image = Properties.Resources.r3;
                    lbl_soru.ForeColor= System.Drawing.Color.White;
                    lbl_dgru.ForeColor= System.Drawing.Color.White;
                    lbl_dogru.ForeColor= System.Drawing.Color.White;
                    lbl_ynls.ForeColor= System.Drawing.Color.White;
                    lbl_yanlis.ForeColor= System.Drawing.Color.White;
                    lbl_n_soru.ForeColor= System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor= System.Drawing.Color.White;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.b4;
                    pb_r1.Image = Properties.Resources.r4;
                    pb_r2.Image = Properties.Resources.r4;
                    pb_r3.Image = Properties.Resources.r4;
                    pb_r4.Image = Properties.Resources.r4;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.b5;
                    pb_r1.Image = Properties.Resources.r5;
                    pb_r2.Image = Properties.Resources.r5;
                    pb_r3.Image = Properties.Resources.r5;
                    pb_r4.Image = Properties.Resources.r5;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.b6;
                    pb_r1.Image = Properties.Resources.r6;
                    pb_r2.Image = Properties.Resources.r6;
                    pb_r3.Image = Properties.Resources.r6;
                    pb_r4.Image = Properties.Resources.r6;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.b7;
                    pb_r1.Image = Properties.Resources.r7;
                    pb_r2.Image = Properties.Resources.r7;
                    pb_r3.Image = Properties.Resources.r7;
                    pb_r4.Image = Properties.Resources.r7;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 8:
                    this.BackgroundImage = Properties.Resources.b8;
                    pb_r1.Image = Properties.Resources.r8;
                    pb_r2.Image = Properties.Resources.r8;
                    pb_r3.Image = Properties.Resources.r8;
                    pb_r4.Image = Properties.Resources.r8;
                    break;
                case 9:
                    this.BackgroundImage = Properties.Resources.b9;
                    pb_r1.Image = Properties.Resources.r9;
                    pb_r2.Image = Properties.Resources.r9;
                    pb_r3.Image = Properties.Resources.r9;
                    pb_r4.Image = Properties.Resources.r9;
                    break;
                case 10:
                    this.BackgroundImage = Properties.Resources.b10;
                    pb_r1.Image = Properties.Resources.r10;
                    pb_r2.Image = Properties.Resources.r10;
                    pb_r3.Image = Properties.Resources.r10;
                    pb_r4.Image = Properties.Resources.r10;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 11:
                    this.BackgroundImage = Properties.Resources.b11;
                    pb_r1.Image = Properties.Resources.r11;
                    pb_r2.Image = Properties.Resources.r11;
                    pb_r3.Image = Properties.Resources.r11;
                    pb_r4.Image = Properties.Resources.r11;
                    break;
                case 12:
                    this.BackgroundImage = Properties.Resources.b12;
                    pb_r1.Image = Properties.Resources.r12;
                    pb_r2.Image = Properties.Resources.r12;
                    pb_r3.Image = Properties.Resources.r12;
                    pb_r4.Image = Properties.Resources.r12;
                    break;
                case 13:
                    this.BackgroundImage = Properties.Resources.b13;
                    pb_r1.Image = Properties.Resources.r13;
                    pb_r2.Image = Properties.Resources.r13;
                    pb_r3.Image = Properties.Resources.r13;
                    pb_r4.Image = Properties.Resources.r13;
                    break;
                case 14:
                    this.BackgroundImage = Properties.Resources.b14;
                    pb_r1.Image = Properties.Resources.r14;
                    pb_r2.Image = Properties.Resources.r14;
                    pb_r3.Image = Properties.Resources.r14;
                    pb_r4.Image = Properties.Resources.r14;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 15:
                    this.BackgroundImage = Properties.Resources.b15;
                    pb_r1.Image = Properties.Resources.r15;
                    pb_r2.Image = Properties.Resources.r15;
                    pb_r3.Image = Properties.Resources.r15;
                    pb_r4.Image = Properties.Resources.r15;
                    break;
                case 16:
                    this.BackgroundImage = Properties.Resources.b16;
                    pb_r1.Image = Properties.Resources.r16;
                    pb_r2.Image = Properties.Resources.r16;
                    pb_r3.Image = Properties.Resources.r16;
                    pb_r4.Image = Properties.Resources.r16;
                    lbl_soru.ForeColor = System.Drawing.Color.White;
                    lbl_dgru.ForeColor = System.Drawing.Color.White;
                    lbl_dogru.ForeColor = System.Drawing.Color.White;
                    lbl_ynls.ForeColor = System.Drawing.Color.White;
                    lbl_yanlis.ForeColor = System.Drawing.Color.White;
                    lbl_n_soru.ForeColor = System.Drawing.Color.White;
                    lbl_soru_desc.ForeColor = System.Drawing.Color.White;
                    break;
                case 17:
                    this.BackgroundImage = Properties.Resources.b17;
                    pb_r1.Image = Properties.Resources.r17;
                    pb_r2.Image = Properties.Resources.r17;
                    pb_r3.Image = Properties.Resources.r17;
                    pb_r4.Image = Properties.Resources.r17;
                    break;
                case 18:
                    this.BackgroundImage = Properties.Resources.b18;
                    pb_r1.Image = Properties.Resources.r18;
                    pb_r2.Image = Properties.Resources.r18;
                    pb_r3.Image = Properties.Resources.r18;
                    pb_r4.Image = Properties.Resources.r18;
                    break;
                case 19:
                    this.BackgroundImage = Properties.Resources.b19;
                    pb_r1.Image = Properties.Resources.r19;
                    pb_r2.Image = Properties.Resources.r19;
                    pb_r3.Image = Properties.Resources.r19;
                    pb_r4.Image = Properties.Resources.r19;
                    break;
                case 20:
                    this.BackgroundImage = Properties.Resources.b20;
                    pb_r1.Image = Properties.Resources.r20;
                    pb_r2.Image = Properties.Resources.r20;
                    pb_r3.Image = Properties.Resources.r20;
                    pb_r4.Image = Properties.Resources.r20;
                    break;
                default:
                    //MessageBox.Show("Geçersiz soru numarası!");
                    break;
               
             this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

      

            private void Sorular_Load(object sender, EventArgs e)
            {
            this.WindowState = FormWindowState.Maximized;
            pb_r1.BackColor = Color.Transparent;
            pb_r2.BackColor = Color.Transparent;
            pb_r3.BackColor = Color.Transparent;
            pb_r4.BackColor = Color.Transparent;
            SetBackgroundImage(soru_no + 1);    
            
            cevap = frm1.dogrucevaplar[soru_no].ToString();
            lbl_soru.Text = frm1.soru[soru_no].ToString();
            btn_a.Text = frm1.cevaplar[soru_no, 0].ToString();
            btn_b.Text = frm1.cevaplar[soru_no, 1].ToString();
            btn_c.Text = frm1.cevaplar[soru_no, 2].ToString();
            btn_d.Text = frm1.cevaplar[soru_no, 3].ToString();

            lbl_dgru.Text = Form1.dogru.ToString();
            lbl_ynls.Text = Form1.yanlis.ToString();
            lbl_n_soru.Text = (soru_no + 1).ToString();
            msj.FormClosed += Msj_FormClosed;
            }

        private void Msj_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        Mesaj msj = new Mesaj();        
        
        private void btn_a_Click(object sender, EventArgs e)
        {
            if (btn_a.Text == cevap)
            {
                Form1.dogru++;
                msj.acıklama = "Bravo!, Doğru Cevap";
                msj.pb_cntrl.Visible = false;
                msj.Show();
                //MessageBox.Show("Bravo!, Doğru Cevap");
            }
            else
            {
                Form1.yanlis++;
                msj.acıklama = "Üzgünüm!, Yanlış Cevap";
                msj.cevap = cevap;
                msj.Show();
                //MessageBox.Show("Üzgünüm!, Yanlış Cevap");
            }
            button_disable();
            this.Refresh();
            //this.Close();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            if (btn_b.Text == cevap)
            {
                Form1.dogru++;
                msj.acıklama = "Bravo!, Doğru Cevap";
                msj.pb_cntrl.Visible = false;
                msj.Show();
                //MessageBox.Show("Bravo!, Doğru Cevap");
            }
            else
            {
                Form1.yanlis++;
                msj.acıklama = "Üzgünüm!, Yanlış Cevap";
                msj.cevap = cevap;
                msj.Show();
                //MessageBox.Show("Üzgünüm!, Yanlış Cevap");
            }
            button_disable();
            this.Refresh();
            //this.Close();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if (btn_c.Text == cevap)
            {
                Form1.dogru++;
                msj.acıklama = "Bravo!, Doğru Cevap";
                msj.pb_cntrl.Visible = false;
                msj.Show();
                //MessageBox.Show("Bravo!, Doğru Cevap");
            }
            else
            {
                Form1.yanlis++;
                msj.acıklama = "Üzgünüm!, Yanlış Cevap";
                msj.cevap = cevap;
                msj.Show();
                //MessageBox.Show("Üzgünüm!, Yanlış Cevap");
            }
            button_disable();
            this.Refresh();
            //this.Close();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            if (btn_d.Text == cevap)
            {
                Form1.dogru++;
                msj.acıklama = "Bravo!, Doğru Cevap";
                msj.pb_cntrl.Visible = false;
                msj.Show();
                //MessageBox.Show("Bravo!, Doğru Cevap");
            }
            else
            {
                Form1.yanlis++;
                msj.acıklama = "Üzgünüm!, Yanlış Cevap";
                msj.cevap = cevap;
                msj.Show();
                //MessageBox.Show("Üzgünüm!, Yanlış Cevap");
            }
            button_disable();
            this.Refresh();
            //this.Close();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
