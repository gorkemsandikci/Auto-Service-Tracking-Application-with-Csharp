
namespace AutoService
{
    partial class DashboardForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miKullaniciOlustur = new AutoService.Views.Shared.MenuItem();
            this.miKullanicilariListele = new AutoService.Views.Shared.MenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AutoService.Properties.Resources.on_off_sign_orange_icon_black_vector_13391631;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AutoService.Properties.Resources.a4140429df6844298f03f6a7bd509b49;
            this.pictureBox1.Location = new System.Drawing.Point(871, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblHosgeldiniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHosgeldiniz.Location = new System.Drawing.Point(20, 649);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(270, 15);
            this.lblHosgeldiniz.TabIndex = 12;
            this.lblHosgeldiniz.Text = "Hoşgeldiniz, yapmak istediğiniz işlemi seçiniz..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(22, 697);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 5);
            this.panel1.TabIndex = 14;
            // 
            // miKullaniciOlustur
            // 
            this.miKullaniciOlustur.BackColor = System.Drawing.Color.Transparent;
            this.miKullaniciOlustur.Location = new System.Drawing.Point(17, 669);
            this.miKullaniciOlustur.Name = "miKullaniciOlustur";
            this.miKullaniciOlustur.Size = new System.Drawing.Size(178, 33);
            this.miKullaniciOlustur.TabIndex = 13;
            this.miKullaniciOlustur.Yazi = "Kullanıcı Oluştur";
            this.miKullaniciOlustur.Click += new System.EventHandler(this.miKullaniciOlustur_Click);
            this.miKullaniciOlustur.DoubleClick += new System.EventHandler(this.miKullaniciOlustur_Click);
            // 
            // miKullanicilariListele
            // 
            this.miKullanicilariListele.BackColor = System.Drawing.Color.Transparent;
            this.miKullanicilariListele.Location = new System.Drawing.Point(201, 669);
            this.miKullanicilariListele.Name = "miKullanicilariListele";
            this.miKullanicilariListele.Size = new System.Drawing.Size(188, 33);
            this.miKullanicilariListele.TabIndex = 15;
            this.miKullanicilariListele.Yazi = "Kullanıcıları Listele";
            this.miKullanicilariListele.Click += new System.EventHandler(this.miKullanicilariListele_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(205, 697);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 5);
            this.panel2.TabIndex = 15;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AutoService.Properties.Resources.hexagonbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.miKullanicilariListele);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.miKullaniciOlustur);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private Views.Shared.MenuItem miKullaniciOlustur;
        private System.Windows.Forms.Panel panel1;
        private Views.Shared.MenuItem miKullanicilariListele;
        private System.Windows.Forms.Panel panel2;
    }
}