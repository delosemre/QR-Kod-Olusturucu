using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_KOD_OLUŞTURUCU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        public void qrolustur_Click(object sender, EventArgs e)
        {
            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrkodmetin.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrcoderesim.Image = qrCode.GetGraphic(5);

            



        }

        public void qrcodekayit_Click(object sender, EventArgs e)
        {
            string kayityolu = Application.StartupPath;
            qrcoderesim.Image.Save(kayitisim.Text+".png", ImageFormat.Png);
            MessageBox.Show("Kayıt İşlemi Tamamlandı! Kayıt Dizini:"+ kayityolu, "Bilgilendirme Penceresi");

        }

        private void GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/delosemre/");
        }

        private void website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://emreylmz.com/");
        }
    }
}
