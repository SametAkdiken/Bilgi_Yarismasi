namespace Bilgi_Yarismasi
{
    partial class Mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesaj));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cevap = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.pb_cntrl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cntrl)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(415, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Devam Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cevap
            // 
            this.lbl_cevap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cevap.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_cevap.Location = new System.Drawing.Point(56, 163);
            this.lbl_cevap.Name = "lbl_cevap";
            this.lbl_cevap.Size = new System.Drawing.Size(484, 72);
            this.lbl_cevap.TabIndex = 2;
            this.lbl_cevap.Text = "Mesaj";
            this.lbl_cevap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_close.Image = global::Bilgi_Yarismasi.Properties.Resources.icons8_close_45;
            this.lbl_close.Location = new System.Drawing.Point(570, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(34, 34);
            this.lbl_close.TabIndex = 9;
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // pb_cntrl
            // 
            this.pb_cntrl.BackColor = System.Drawing.Color.Transparent;
            this.pb_cntrl.Image = global::Bilgi_Yarismasi.Properties.Resources.download_removebg_preview;
            this.pb_cntrl.Location = new System.Drawing.Point(328, 275);
            this.pb_cntrl.Name = "pb_cntrl";
            this.pb_cntrl.Size = new System.Drawing.Size(70, 60);
            this.pb_cntrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cntrl.TabIndex = 10;
            this.pb_cntrl.TabStop = false;
            this.pb_cntrl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilgi_Yarismasi.Properties.Resources.desktop_wallpaper_backgrounds_kids_group_backgrounds_for_kids;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 347);
            this.Controls.Add(this.pb_cntrl);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_cevap);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.Mesaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cntrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label lbl_cevap;
        private Label lbl_close;
        public PictureBox pb_cntrl;
    }
}