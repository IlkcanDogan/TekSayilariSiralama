namespace TekSayilariSiralama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.lblSayilar = new System.Windows.Forms.ListBox();
            this.lblTekSayilar = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(140, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 31);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Sayı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(237, 180);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(111, 31);
            this.btnSirala.TabIndex = 1;
            this.btnSirala.Text = "Tek Sayıları Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // lblSayilar
            // 
            this.lblSayilar.FormattingEnabled = true;
            this.lblSayilar.Location = new System.Drawing.Point(12, 12);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(120, 199);
            this.lblSayilar.TabIndex = 2;
            this.lblSayilar.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTekSayilar
            // 
            this.lblTekSayilar.FormattingEnabled = true;
            this.lblTekSayilar.Location = new System.Drawing.Point(354, 12);
            this.lblTekSayilar.Name = "lblTekSayilar";
            this.lblTekSayilar.Size = new System.Drawing.Size(120, 199);
            this.lblTekSayilar.TabIndex = 3;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(140, 12);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(143, 20);
            this.txtSayi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 223);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblTekSayilar);
            this.Controls.Add(this.lblSayilar);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.ListBox lblSayilar;
        private System.Windows.Forms.ListBox lblTekSayilar;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

