namespace Bilgi_Yarismasi
{
    partial class Finish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finish));
            this.lbl_close = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.lbl_dogru = new System.Windows.Forms.Label();
            this.lbl_yanlis = new System.Windows.Forms.Label();
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.lbl_skr = new System.Windows.Forms.Label();
            this.lbl_dgr = new System.Windows.Forms.Label();
            this.lbl_ynls = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_close.Image = global::Bilgi_Yarismasi.Properties.Resources.icons8_close_45;
            this.lbl_close.Location = new System.Drawing.Point(810, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(34, 34);
            this.lbl_close.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(535, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Bitir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_skor.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_skor.ForeColor = System.Drawing.Color.Black;
            this.lbl_skor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_skor.Location = new System.Drawing.Point(249, 322);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(230, 60);
            this.lbl_skor.TabIndex = 12;
            this.lbl_skor.Text = "Puanınız :";
            // 
            // lbl_dogru
            // 
            this.lbl_dogru.AutoSize = true;
            this.lbl_dogru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dogru.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_dogru.ForeColor = System.Drawing.Color.Black;
            this.lbl_dogru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dogru.Location = new System.Drawing.Point(159, 408);
            this.lbl_dogru.Name = "lbl_dogru";
            this.lbl_dogru.Size = new System.Drawing.Size(150, 50);
            this.lbl_dogru.TabIndex = 12;
            this.lbl_dogru.Text = "Doğru :";
            // 
            // lbl_yanlis
            // 
            this.lbl_yanlis.AutoSize = true;
            this.lbl_yanlis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yanlis.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_yanlis.ForeColor = System.Drawing.Color.Black;
            this.lbl_yanlis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_yanlis.Location = new System.Drawing.Point(388, 408);
            this.lbl_yanlis.Name = "lbl_yanlis";
            this.lbl_yanlis.Size = new System.Drawing.Size(149, 50);
            this.lbl_yanlis.TabIndex = 12;
            this.lbl_yanlis.Text = "Yanlış :";
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mesaj.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_mesaj.Location = new System.Drawing.Point(69, 70);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(578, 72);
            this.lbl_mesaj.TabIndex = 13;
            this.lbl_mesaj.Text = "Tebrikler 20 Soru Cevapladınız...";
            this.lbl_mesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mesaj.Click += new System.EventHandler(this.lbl_mesaj_Click);
            // 
            // lbl_skr
            // 
            this.lbl_skr.AutoSize = true;
            this.lbl_skr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_skr.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_skr.ForeColor = System.Drawing.Color.Black;
            this.lbl_skr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_skr.Location = new System.Drawing.Point(485, 322);
            this.lbl_skr.Name = "lbl_skr";
            this.lbl_skr.Size = new System.Drawing.Size(46, 62);
            this.lbl_skr.TabIndex = 12;
            this.lbl_skr.Text = "-";
            // 
            // lbl_dgr
            // 
            this.lbl_dgr.AutoSize = true;
            this.lbl_dgr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dgr.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_dgr.ForeColor = System.Drawing.Color.Black;
            this.lbl_dgr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dgr.Location = new System.Drawing.Point(315, 408);
            this.lbl_dgr.Name = "lbl_dgr";
            this.lbl_dgr.Size = new System.Drawing.Size(37, 50);
            this.lbl_dgr.TabIndex = 12;
            this.lbl_dgr.Text = "-";
            // 
            // lbl_ynls
            // 
            this.lbl_ynls.AutoSize = true;
            this.lbl_ynls.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ynls.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ynls.ForeColor = System.Drawing.Color.Black;
            this.lbl_ynls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ynls.Location = new System.Drawing.Point(543, 408);
            this.lbl_ynls.Name = "lbl_ynls";
            this.lbl_ynls.Size = new System.Drawing.Size(37, 50);
            this.lbl_ynls.TabIndex = 12;
            this.lbl_ynls.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bilgi_Yarismasi.Properties.Resources.r3;
            this.pictureBox1.Location = new System.Drawing.Point(140, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 72);
            this.label1.TabIndex = 13;
            this.label1.Text = "Oyun Bitti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lbl_mesaj_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::Bilgi_Yarismasi.Properties.Resources.icons8_close_45;
            this.label2.Location = new System.Drawing.Point(763, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 34);
            this.label2.TabIndex = 15;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilgi_Yarismasi.Properties.Resources.msj2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.lbl_yanlis);
            this.Controls.Add(this.lbl_dogru);
            this.Controls.Add(this.lbl_ynls);
            this.Controls.Add(this.lbl_dgr);
            this.Controls.Add(this.lbl_skr);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Finish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Bitti";
            this.Load += new System.EventHandler(this.Finish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_close;
        private Button button1;
        private Label lbl_skor;
        private Label lbl_dogru;
        private Label lbl_yanlis;
        private Label lbl_mesaj;
        private Label lbl_skr;
        private Label lbl_dgr;
        private Label lbl_ynls;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}