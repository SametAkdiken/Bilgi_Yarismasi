namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_soru = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.lbl_soru_no = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_ynls = new System.Windows.Forms.Label();
            this.lbl_dgru = new System.Windows.Forms.Label();
            this.lbl_yanlis = new System.Windows.Forms.Label();
            this.lbl_dogru = new System.Windows.Forms.Label();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_soru
            // 
            this.btn_soru.BackColor = System.Drawing.Color.PaleGoldenrod;
            resources.ApplyResources(this.btn_soru, "btn_soru");
            this.btn_soru.Name = "btn_soru";
            this.btn_soru.UseVisualStyleBackColor = false;
            this.btn_soru.Click += new System.EventHandler(this.btn_soru_Click);
            // 
            // lbl_baslik
            // 
            resources.ApplyResources(this.lbl_baslik, "lbl_baslik");
            this.lbl_baslik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_baslik.Name = "lbl_baslik";
            // 
            // lbl_soru_no
            // 
            resources.ApplyResources(this.lbl_soru_no, "lbl_soru_no");
            this.lbl_soru_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soru_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_soru_no.Name = "lbl_soru_no";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_ynls
            // 
            resources.ApplyResources(this.lbl_ynls, "lbl_ynls");
            this.lbl_ynls.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ynls.Name = "lbl_ynls";
            // 
            // lbl_dgru
            // 
            resources.ApplyResources(this.lbl_dgru, "lbl_dgru");
            this.lbl_dgru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dgru.Name = "lbl_dgru";
            // 
            // lbl_yanlis
            // 
            resources.ApplyResources(this.lbl_yanlis, "lbl_yanlis");
            this.lbl_yanlis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yanlis.Name = "lbl_yanlis";
            // 
            // lbl_dogru
            // 
            resources.ApplyResources(this.lbl_dogru, "lbl_dogru");
            this.lbl_dogru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dogru.Name = "lbl_dogru";
            // 
            // lbl_skor
            // 
            resources.ApplyResources(this.lbl_skor, "lbl_skor");
            this.lbl_skor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_skor.Name = "lbl_skor";
            // 
            // lbl_puan
            // 
            resources.ApplyResources(this.lbl_puan, "lbl_puan");
            this.lbl_puan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puan.Name = "lbl_puan";
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_close, "lbl_close");
            this.lbl_close.Image = global::Bilgi_Yarismasi.Properties.Resources.icons8_close_45;
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Bilgi_Yarismasi.Properties.Resources.desktop_wallpaper_2d_video_game_backgrounds_loading_screens;
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_ynls);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.lbl_dgru);
            this.Controls.Add(this.lbl_yanlis);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.lbl_dogru);
            this.Controls.Add(this.lbl_soru_no);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.btn_soru);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_soru;
        private Label lbl_baslik;
        public Label lbl_soru_no;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_ynls;
        private Label lbl_dgru;
        private Label lbl_yanlis;
        private Label lbl_dogru;
        private Label lbl_skor;
        private Label lbl_puan;
        private Label lbl_close;
    }
}