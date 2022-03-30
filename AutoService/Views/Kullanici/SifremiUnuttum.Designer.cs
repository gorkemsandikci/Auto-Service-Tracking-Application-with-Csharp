
namespace AutoService
{
    partial class SifremiUnuttum
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSifremiUnuttum = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblSifremiUnuttum);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 24);
            this.panel1.TabIndex = 4;
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifremiUnuttum.ForeColor = System.Drawing.Color.Black;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(148, 3);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(123, 18);
            this.lblSifremiUnuttum.TabIndex = 6;
            this.lblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblSifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Black;
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGonder.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGonder.Location = new System.Drawing.Point(99, 108);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(110, 31);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "G Ö N D E R";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtEPosta
            // 
            this.txtEPosta.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtEPosta.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtEPosta.ForeColor = System.Drawing.Color.White;
            this.txtEPosta.Location = new System.Drawing.Point(69, 62);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(287, 27);
            this.txtEPosta.TabIndex = 8;
            // 
            // lblEPosta
            // 
            this.lblEPosta.AutoSize = true;
            this.lblEPosta.BackColor = System.Drawing.Color.Transparent;
            this.lblEPosta.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEPosta.ForeColor = System.Drawing.Color.Snow;
            this.lblEPosta.Location = new System.Drawing.Point(170, 32);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(78, 22);
            this.lblEPosta.TabIndex = 9;
            this.lblEPosta.Text = "E-Posta :";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnIptal.Location = new System.Drawing.Point(215, 108);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(110, 31);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İ P T A L";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(424, 168);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblEPosta);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifremiUnuttum";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.Label lblSifremiUnuttum;
        private System.Windows.Forms.Button btnIptal;
    }
}