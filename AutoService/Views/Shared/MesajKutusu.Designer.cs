
namespace AutoService
{
    partial class MesajKutusu
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.pbMesaj = new System.Windows.Forms.PictureBox();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesaj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.Black;
            this.btnTamam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamam.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnTamam.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTamam.Location = new System.Drawing.Point(175, 125);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(92, 31);
            this.btnTamam.TabIndex = 2;
            this.btnTamam.Text = "T A M A M";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Visible = false;
            this.btnTamam.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 24);
            this.panel1.TabIndex = 3;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(150, 3);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(46, 18);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "label1";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMesaj.Location = new System.Drawing.Point(99, 27);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(245, 95);
            this.lblMesaj.TabIndex = 4;
            this.lblMesaj.Text = "label1";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMesaj
            // 
            this.pbMesaj.Location = new System.Drawing.Point(8, 57);
            this.pbMesaj.Name = "pbMesaj";
            this.pbMesaj.Size = new System.Drawing.Size(85, 77);
            this.pbMesaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMesaj.TabIndex = 5;
            this.pbMesaj.TabStop = false;
            // 
            // btnEvet
            // 
            this.btnEvet.BackColor = System.Drawing.Color.Black;
            this.btnEvet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvet.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEvet.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEvet.Location = new System.Drawing.Point(129, 125);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(92, 31);
            this.btnEvet.TabIndex = 7;
            this.btnEvet.Text = "E V E T";
            this.btnEvet.UseVisualStyleBackColor = false;
            this.btnEvet.Visible = false;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayir
            // 
            this.btnHayir.BackColor = System.Drawing.Color.Black;
            this.btnHayir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHayir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHayir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayir.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHayir.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnHayir.Location = new System.Drawing.Point(227, 125);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(92, 31);
            this.btnHayir.TabIndex = 8;
            this.btnHayir.Text = "H A Y I R";
            this.btnHayir.UseVisualStyleBackColor = false;
            this.btnHayir.Visible = false;
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // MesajKutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(344, 168);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.pbMesaj);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesajKutusu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesajKutusu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.PictureBox pbMesaj;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button btnHayir;
    }
}