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
namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer(Properties.Resources.BACKSOUNDS);
        }        
        public static int soru_sayisi = 0, dogru = 0, yanlis = 0, durum = 1;
        private int counter = 1;
      

        public string[] soru = new string[20]{
        "Hangi tekniğin en önemli amacı “üretim planının günlük olarak değişmesinden ziyade sabit bir planla hareket edebilmeyi sağlayarak çalışanlar için stresin minimuma indirildiği bir ortam sağlamaktır” ?",
        "Üretim planının daha düzgün olmasını sağlayarak mevcut kaynakların kullanımını etkin duruma getirerek değer akışını verimli duruma getirmeyi hedefleyen yalın üretim tekniği hangisidir ?",
        "Ofis, fabrika, depo gibi ortamlarda çalışanların daha dikkatli, verimli ve iletişim aksaklığına uğramadan işlerini devam ettirmelerine olanak sağlayan yalın üretim yöntemi nedir ?",
        "Görsel panolar, dijital tabelalar, görselleştirmeler ve hatta trafik levhaları da görsel yönetim araçlarına örnek olarak verilebilir. Verilen örnekler hangi yalın üretim yöntemi ile ilgilidir?",
        "Ürünleri, kişileri ve hizmetleri sürekli iyileştirmek için yinelemeli bir yaklaşımdır. Adım adım iplerin tekrar eden hatalardan kaçınmalarını ve süreçleri iyileştirmelerini sağlayan basit bir dört aşamalı yalın üretim yöntemidir. Tanımı verilmiş yalın üretim yöntemi hangisidir ?",
        "Dışardan tedarik edilecek malzeme için kullanılan çekme tipi kanbandır. Tanımı hangi kanban sistemine aittir ?",
        "Sonraki istasyonun önceki istasyondan istediği kadar parça çekmesi için kullanılan kanban türüdür. Tanımı hangi kanban sistemine aittir ?",
        "Çekme kanbanıyla alınan parça için üretimi tetikleyen kanban türüdür. Alınan parça için yeni parçanın üretimini ister. Tanımı hangi kanban sistemine aittir ?",
        "Kanban sistemi kaça ayrılır ?",
        "Üretim ve malzeme akışını kontrol etmek için kullanılan; üretim proseslerine neyi, ne zaman, ne kadar üreteceklerini ve nereye göndereceklerini söyleyen yalın üretim yöntemi hangisidir?",
        "Hangi teknik sayesinde imalat içi süre azalır ve küçük büyüklükteki partilerin üretimi mümkün hale gelir ?",
        "Makine kullanım zamanlarının optimize edilmesi, makinelerin boş durma zamanlarının azaltılması için uygulanan yalın üretim tekniği nedir ?",
        "5S de ilk iş nedir?",
        "Bu yalın üretim aracının amacı temiz, düzenli, her malzemenin yerli yerinde olduğu bir çalışma ortamı oluşturmaktır.",
        "…………… anlayışına göre tüm ürün, hizmet ve süreçler, önemli yatırımlara gerek kalmadan her zaman iyileştirilebilir. Anlayışını benimseyen yalın üretim tekniği hangisidir ?",
        "En alt düzeydeki prosesten, tüm şirketi içine alan hedeflerle yönetim sistemine kadar bütün ileriye dönük planlama ve uygulama çalışmaları hangi yalın üretim yöntemine göre düzenlenmiştir ?",
        "Örneğin montaj hattının bir bölümüne, eklenen parçalarla beraber oluşan toplam ağırlığa duyarlı bir araç yerleştirerek farklı ağırlıkta bir parçanın bir sonraki üretim birimine geçmesini engelleyebilen yalın üretim yöntemi nedir ?",
        "Otonomasyon adıyla da bilinen. Şirketin düşük kalitede ya da hatalı ürünler teslim etmesinin önüne geçmeyi amaçlayan yalın üretim yöntemi nedir ?",
        "Ürün geliştirme süreçlerinde benimsenen yalın üretim yöntemi nedir ?",
        "Poka Yoke Japonca bir kavram olup Poka ve Yoke kelimelerinden oluşur ve hatadan sakınma anlamında bir arada kullanılır. Japonca bir kavram olan Yoke'nin anlamı nedir?"
        };

        public string[,] cevaplar = new string[20,4]{
        {"Heijunka","JIT","Jidoko","Kaizen" },
        {"Jidoko", "Heijunka", "Kaizen", "Kanban"},
        {"TPM", "PUKÖ döngüsü", "Görsel yönetim", "Heijunka"},
        {"Görsel yönetim", "Kanban", "Andon panosu", "Kaizen"},
        {"PUKÖ Döngüsü", "Jidoko", "Kaizen", "5S"},
        {"Üretim kanbanı", "Malzeme kanbanı", "Çekme kanbanı", "Tedarikçi kanbanı"},
        {"Malzeme kanbanı", "Çekme kanbanı", "Üretim kanbanı", "Tedarikçi kanbanı"},
        {"Tedarikçi kanbanı", "Malzeme kanbanı", "Üretim kanbanı", "Çekme kanbanı"},
        {"5", "2", "4", "3"},
        {"Kanban", "Jidoko", "Heijunka", "TPM"},
        {"Kaizen", "SMED", "Heijunka", "TPM"},
        {"SMED", "VSM", "TPM", "JIT"},
        {"Düzenleme", "Temizleme", "Ayıklama", "Disiplin"},
        {"JIT", "5S", "Kaizen", "Heijunka"},
        {"Kaizen", "Jidoko", "Poka Yoke", "SMED"},
        {"Poka Yoke", "Jidoko", "Kaizen", "SMED"},
        {"Görsel Yönetim", "Poka Yoke", "Jidoko", "Milk run"},
        {"Jidoko", "Poka Yoke", "5S", "Kaizen"},
        {"Görsel Yönetim", " Milk run", "Kanban", "Jidoko"},
        {"Tesadüfi hata", "Önleme", "Sakınma, azaltma", "Kontrol"}
        };

        public string[] dogrucevaplar= new string[] {
          "Heijunka",
          "Heijunka",
          "Görsel yönetim",
          "Görsel yönetim",
          "PUKÖ Döngüsü",
          "Tedarikçi kanbanı",
          "Çekme kanbanı",
          "Üretim kanbanı",
          "3",
          "Kanban",
          "SMED",
          "SMED",
          "Ayıklama",
          "5S",
          "Kaizen",
          "Kaizen",
          "Poka Yoke",
          "Jidoko",
          "Jidoko",
          "Sakınma, azaltma"
        };

        private void ResetForm()
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
            this.Close();
        }


        private void btn_soru_Click(object sender, EventArgs e)
        {
            timer1.Stop();            
            Sorular frm_Sorular= new Sorular();
            frm_Sorular.FormClosed += Sorular_FormClosed;
            frm_Sorular.soru_no = Convert.ToUInt16(lbl_soru_no.Text) - 1;
            frm_Sorular.Show();
            soru_sayisi++;            
        }

        
        
        private void Sorular_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Start();
            lbl_dgru.Text = dogru.ToString();
            lbl_ynls.Text = yanlis.ToString();
            lbl_puan.Text = ((dogru * 10) - (yanlis * 4)).ToString();
            if (soru_sayisi == 20)
            {
                Finish final = new Finish();
                final.skor = lbl_puan.Text;
                final.dogru = dogru.ToString();
                final.yanlis = yanlis.ToString();
                final.FormClosed += Final_FormClosed;
                _soundPlayer.Stop();
                final.Show();
                if (durum == 0)
                {
                    this.Close();
                }
            }
        }

        private void Final_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

            private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _soundPlayer.PlayLooping();
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();            
            lbl_dgru.Text = dogru.ToString();
            lbl_ynls.Text = yanlis.ToString();
            lbl_puan.Text = "0";

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (counter <= 20)
            {
                lbl_soru_no.Text = counter.ToString();
                counter++;
            }
            else
            {
                counter = 1;
            }
        }
    }
}