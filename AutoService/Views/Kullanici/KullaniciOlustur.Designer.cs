
namespace AutoService
{
    partial class KullaniciOlustur
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
            this.gbTemelBilgiler = new System.Windows.Forms.GroupBox();
            this.radioKurumsal = new System.Windows.Forms.RadioButton();
            this.radioBireysel = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupKurumsalBilgiler = new System.Windows.Forms.GroupBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtTicariUnvan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnKullaniciKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.gbTemelBilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupKurumsalBilgiler.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTemelBilgiler
            // 
            this.gbTemelBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.gbTemelBilgiler.Controls.Add(this.radioKurumsal);
            this.gbTemelBilgiler.Controls.Add(this.radioBireysel);
            this.gbTemelBilgiler.Controls.Add(this.txtSoyad);
            this.gbTemelBilgiler.Controls.Add(this.txtAd);
            this.gbTemelBilgiler.Controls.Add(this.label5);
            this.gbTemelBilgiler.Controls.Add(this.label2);
            this.gbTemelBilgiler.Controls.Add(this.label1);
            this.gbTemelBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTemelBilgiler.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTemelBilgiler.ForeColor = System.Drawing.Color.White;
            this.gbTemelBilgiler.Location = new System.Drawing.Point(12, 31);
            this.gbTemelBilgiler.Name = "gbTemelBilgiler";
            this.gbTemelBilgiler.Size = new System.Drawing.Size(329, 153);
            this.gbTemelBilgiler.TabIndex = 0;
            this.gbTemelBilgiler.TabStop = false;
            this.gbTemelBilgiler.Text = "Temel Bilgiler";
            // 
            // radioKurumsal
            // 
            this.radioKurumsal.AutoSize = true;
            this.radioKurumsal.Location = new System.Drawing.Point(197, 114);
            this.radioKurumsal.Name = "radioKurumsal";
            this.radioKurumsal.Size = new System.Drawing.Size(109, 26);
            this.radioKurumsal.TabIndex = 6;
            this.radioKurumsal.Text = "Kurumsal";
            this.radioKurumsal.UseVisualStyleBackColor = true;
            this.radioKurumsal.CheckedChanged += new System.EventHandler(this.radioKurumsal_CheckedChanged);
            // 
            // radioBireysel
            // 
            this.radioBireysel.AutoSize = true;
            this.radioBireysel.Checked = true;
            this.radioBireysel.Location = new System.Drawing.Point(97, 112);
            this.radioBireysel.Name = "radioBireysel";
            this.radioBireysel.Size = new System.Drawing.Size(94, 26);
            this.radioBireysel.TabIndex = 5;
            this.radioBireysel.TabStop = true;
            this.radioBireysel.Text = "Bireysel";
            this.radioBireysel.UseVisualStyleBackColor = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(97, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(205, 27);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 27);
            this.txtAd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.mtxtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(358, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(81, 76);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(184, 60);
            this.txtAdres.TabIndex = 5;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(81, 37);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(184, 27);
            this.mtxtTelefon.TabIndex = 4;
            this.mtxtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "GSM";
            // 
            // groupKurumsalBilgiler
            // 
            this.groupKurumsalBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.groupKurumsalBilgiler.Controls.Add(this.txtVergiNo);
            this.groupKurumsalBilgiler.Controls.Add(this.txtVergiDairesi);
            this.groupKurumsalBilgiler.Controls.Add(this.txtTicariUnvan);
            this.groupKurumsalBilgiler.Controls.Add(this.label8);
            this.groupKurumsalBilgiler.Controls.Add(this.label6);
            this.groupKurumsalBilgiler.Controls.Add(this.label7);
            this.groupKurumsalBilgiler.Enabled = false;
            this.groupKurumsalBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupKurumsalBilgiler.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupKurumsalBilgiler.ForeColor = System.Drawing.Color.White;
            this.groupKurumsalBilgiler.Location = new System.Drawing.Point(358, 190);
            this.groupKurumsalBilgiler.Name = "groupKurumsalBilgiler";
            this.groupKurumsalBilgiler.Size = new System.Drawing.Size(280, 153);
            this.groupKurumsalBilgiler.TabIndex = 4;
            this.groupKurumsalBilgiler.TabStop = false;
            this.groupKurumsalBilgiler.Text = "Kurumsal Bilgiler";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(126, 109);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(139, 27);
            this.txtVergiNo.TabIndex = 11;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(126, 76);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(139, 27);
            this.txtVergiDairesi.TabIndex = 10;
            // 
            // txtTicariUnvan
            // 
            this.txtTicariUnvan.Location = new System.Drawing.Point(126, 40);
            this.txtTicariUnvan.Name = "txtTicariUnvan";
            this.txtTicariUnvan.Size = new System.Drawing.Size(139, 27);
            this.txtTicariUnvan.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vergi No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vergi Dairesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ticari Unvan";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtSifre);
            this.groupBox3.Controls.Add(this.txtEposta);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giriş Bilgileri";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(97, 76);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(205, 27);
            this.txtSifre.TabIndex = 8;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(97, 40);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(205, 27);
            this.txtEposta.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Şifre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "E-Posta";
            // 
            // btnKullaniciKaydet
            // 
            this.btnKullaniciKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKullaniciKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKullaniciKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciKaydet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnKullaniciKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKullaniciKaydet.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciKaydet.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnKullaniciKaydet.Location = new System.Drawing.Point(270, 358);
            this.btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            this.btnKullaniciKaydet.Size = new System.Drawing.Size(127, 42);
            this.btnKullaniciKaydet.TabIndex = 5;
            this.btnKullaniciKaydet.Text = "K A Y D E T";
            this.btnKullaniciKaydet.UseVisualStyleBackColor = false;
            this.btnKullaniciKaydet.Click += new System.EventHandler(this.btnKullaniciKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnIptal.Location = new System.Drawing.Point(408, 358);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(103, 42);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İ P T A L";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Black;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTemizle.Location = new System.Drawing.Point(131, 358);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 42);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "T E M İ Z L E";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // KullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.hexagonbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKullaniciKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupKurumsalBilgiler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTemelBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciOlustur";
            this.gbTemelBilgiler.ResumeLayout(false);
            this.gbTemelBilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupKurumsalBilgiler.ResumeLayout(false);
            this.groupKurumsalBilgiler.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTemelBilgiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupKurumsalBilgiler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKullaniciKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.RadioButton radioKurumsal;
        private System.Windows.Forms.RadioButton radioBireysel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtTicariUnvan;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnTemizle;
    }
}