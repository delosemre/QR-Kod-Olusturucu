
namespace QR_KOD_OLUŞTURUCU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qrkodmetin = new System.Windows.Forms.TextBox();
            this.qrolustur = new System.Windows.Forms.Button();
            this.qrcoderesim = new System.Windows.Forms.PictureBox();
            this.kayitisim = new System.Windows.Forms.TextBox();
            this.qrcodekayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.website = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.qrcoderesim)).BeginInit();
            this.SuspendLayout();
            // 
            // qrkodmetin
            // 
            this.qrkodmetin.Location = new System.Drawing.Point(24, 68);
            this.qrkodmetin.Multiline = true;
            this.qrkodmetin.Name = "qrkodmetin";
            this.qrkodmetin.Size = new System.Drawing.Size(387, 92);
            this.qrkodmetin.TabIndex = 0;
            // 
            // qrolustur
            // 
            this.qrolustur.Location = new System.Drawing.Point(127, 180);
            this.qrolustur.Name = "qrolustur";
            this.qrolustur.Size = new System.Drawing.Size(168, 30);
            this.qrolustur.TabIndex = 1;
            this.qrolustur.Text = "QR Kod Oluştur";
            this.qrolustur.UseVisualStyleBackColor = true;
            this.qrolustur.Click += new System.EventHandler(this.qrolustur_Click);
            // 
            // qrcoderesim
            // 
            this.qrcoderesim.Location = new System.Drawing.Point(440, 68);
            this.qrcoderesim.Name = "qrcoderesim";
            this.qrcoderesim.Size = new System.Drawing.Size(326, 280);
            this.qrcoderesim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrcoderesim.TabIndex = 2;
            this.qrcoderesim.TabStop = false;
            // 
            // kayitisim
            // 
            this.kayitisim.Location = new System.Drawing.Point(82, 303);
            this.kayitisim.Name = "kayitisim";
            this.kayitisim.Size = new System.Drawing.Size(271, 22);
            this.kayitisim.TabIndex = 3;
            // 
            // qrcodekayit
            // 
            this.qrcodekayit.Location = new System.Drawing.Point(174, 361);
            this.qrcodekayit.Name = "qrcodekayit";
            this.qrcodekayit.Size = new System.Drawing.Size(83, 29);
            this.qrcodekayit.TabIndex = 4;
            this.qrcodekayit.Text = "Kaydet";
            this.qrcodekayit.UseVisualStyleBackColor = true;
            this.qrcodekayit.Click += new System.EventHandler(this.qrcodekayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oluşturmak istediğiniz metni veya URL\'yi yazınız.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kayıt ederken kullanacağınız adı yazınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Örnek: qrkodum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(560, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Önizleme";
            // 
            // GitHub
            // 
            this.GitHub.AutoSize = true;
            this.GitHub.Location = new System.Drawing.Point(725, 424);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(52, 17);
            this.GitHub.TabIndex = 9;
            this.GitHub.TabStop = true;
            this.GitHub.Text = "GitHub";
            this.GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(631, 424);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(63, 17);
            this.website.TabIndex = 10;
            this.website.TabStop = true;
            this.website.Text = "Web site";
            this.website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.website_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 453);
            this.Controls.Add(this.website);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrcodekayit);
            this.Controls.Add(this.kayitisim);
            this.Controls.Add(this.qrcoderesim);
            this.Controls.Add(this.qrolustur);
            this.Controls.Add(this.qrkodmetin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Kod Oluşturucu - delosemre";
            ((System.ComponentModel.ISupportInitialize)(this.qrcoderesim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qrkodmetin;
        private System.Windows.Forms.Button qrolustur;
        private System.Windows.Forms.PictureBox qrcoderesim;
        private System.Windows.Forms.TextBox kayitisim;
        private System.Windows.Forms.Button qrcodekayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel GitHub;
        private System.Windows.Forms.LinkLabel website;
    }
}

