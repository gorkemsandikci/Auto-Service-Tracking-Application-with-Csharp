namespace AutoService
{
    partial class KullaniciListele
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
            this.components = new System.ComponentModel.Container();
            this.gbKullaniciListele = new System.Windows.Forms.GroupBox();
            this.dgwKullaniciListele = new System.Windows.Forms.DataGridView();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoSerciceDataSet = new AutoService.AutoSerciceDataSet();
            this.kullanicilarTableAdapter = new AutoService.AutoSerciceDataSetTableAdapters.KullanicilarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticariUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiDairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.olusturmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProfilGoruntule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbKullaniciListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullaniciListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoSerciceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKullaniciListele
            // 
            this.gbKullaniciListele.BackColor = System.Drawing.Color.Transparent;
            this.gbKullaniciListele.Controls.Add(this.dgwKullaniciListele);
            this.gbKullaniciListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbKullaniciListele.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.gbKullaniciListele.ForeColor = System.Drawing.Color.Black;
            this.gbKullaniciListele.Location = new System.Drawing.Point(12, 12);
            this.gbKullaniciListele.Name = "gbKullaniciListele";
            this.gbKullaniciListele.Size = new System.Drawing.Size(776, 426);
            this.gbKullaniciListele.TabIndex = 1;
            this.gbKullaniciListele.TabStop = false;
            this.gbKullaniciListele.Text = "Kullanıcı Listesi";
            // 
            // dgwKullaniciListele
            // 
            this.dgwKullaniciListele.AutoGenerateColumns = false;
            this.dgwKullaniciListele.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwKullaniciListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwKullaniciListele.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwKullaniciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullaniciListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.gsmDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.ticariUnvanDataGridViewTextBoxColumn,
            this.vergiDairesiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.musteriTipiDataGridViewTextBoxColumn,
            this.kullaniciTipiDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn,
            this.olusturmaTarihiDataGridViewTextBoxColumn,
            this.btnProfilGoruntule});
            this.dgwKullaniciListele.DataSource = this.kullanicilarBindingSource;
            this.dgwKullaniciListele.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwKullaniciListele.Location = new System.Drawing.Point(6, 26);
            this.dgwKullaniciListele.Name = "dgwKullaniciListele";
            this.dgwKullaniciListele.Size = new System.Drawing.Size(764, 394);
            this.dgwKullaniciListele.TabIndex = 0;
            this.dgwKullaniciListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullaniciListele_CellContentClick);
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.autoSerciceDataSet;
            // 
            // autoSerciceDataSet
            // 
            this.autoSerciceDataSet.DataSetName = "AutoSerciceDataSet";
            this.autoSerciceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // gsmDataGridViewTextBoxColumn
            // 
            this.gsmDataGridViewTextBoxColumn.DataPropertyName = "Gsm";
            this.gsmDataGridViewTextBoxColumn.HeaderText = "Gsm";
            this.gsmDataGridViewTextBoxColumn.Name = "gsmDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // ticariUnvanDataGridViewTextBoxColumn
            // 
            this.ticariUnvanDataGridViewTextBoxColumn.DataPropertyName = "TicariUnvan";
            this.ticariUnvanDataGridViewTextBoxColumn.HeaderText = "TicariUnvan";
            this.ticariUnvanDataGridViewTextBoxColumn.Name = "ticariUnvanDataGridViewTextBoxColumn";
            // 
            // vergiDairesiDataGridViewTextBoxColumn
            // 
            this.vergiDairesiDataGridViewTextBoxColumn.DataPropertyName = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.HeaderText = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.Name = "vergiDairesiDataGridViewTextBoxColumn";
            // 
            // vergiNoDataGridViewTextBoxColumn
            // 
            this.vergiNoDataGridViewTextBoxColumn.DataPropertyName = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.HeaderText = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.Name = "vergiNoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // musteriTipiDataGridViewTextBoxColumn
            // 
            this.musteriTipiDataGridViewTextBoxColumn.DataPropertyName = "MusteriTipi";
            this.musteriTipiDataGridViewTextBoxColumn.HeaderText = "MusteriTipi";
            this.musteriTipiDataGridViewTextBoxColumn.Name = "musteriTipiDataGridViewTextBoxColumn";
            // 
            // kullaniciTipiDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.HeaderText = "KullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.Name = "kullaniciTipiDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // olusturmaTarihiDataGridViewTextBoxColumn
            // 
            this.olusturmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "OlusturmaTarihi";
            this.olusturmaTarihiDataGridViewTextBoxColumn.HeaderText = "OlusturmaTarihi";
            this.olusturmaTarihiDataGridViewTextBoxColumn.Name = "olusturmaTarihiDataGridViewTextBoxColumn";
            // 
            // btnProfilGoruntule
            // 
            this.btnProfilGoruntule.HeaderText = "Görüntüle";
            this.btnProfilGoruntule.Name = "btnProfilGoruntule";
            this.btnProfilGoruntule.ReadOnly = true;
            this.btnProfilGoruntule.Text = "Görüntüle";
            this.btnProfilGoruntule.UseColumnTextForButtonValue = true;
            // 
            // KullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.hexagonbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbKullaniciListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciListele";
            this.Load += new System.EventHandler(this.KullaniciListele_Load);
            this.gbKullaniciListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullaniciListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoSerciceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKullaniciListele;
        private System.Windows.Forms.DataGridView dgwKullaniciListele;
        private AutoSerciceDataSet autoSerciceDataSet;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private AutoSerciceDataSetTableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticariUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiDairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnProfilGoruntule;
    }
}