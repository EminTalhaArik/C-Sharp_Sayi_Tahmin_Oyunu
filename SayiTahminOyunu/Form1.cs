using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            Kazandin();
            tbx_tahmin.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemelFonksiyonlar();
        }

        int baslangicSaniyesi = 20;
        int saniye = 0;

        Random random = new Random();

        private void timer_Tick(object sender, EventArgs e)
        {
            SaniyeKontrolVeDegisim();
        }

        private void SaniyeKontrolVeDegisim()
        {
            saniye--;
            lbl_saniye.Text = saniye.ToString();
            progressBar1.Value -= 5;
            if (saniye <= 0)
            {
                if (timer.Enabled) timer.Stop();
                MessageBox.Show("Oyun Bitti");
                yanlisTahminsayisi++;
                TemelFonksiyonlar();
            }
        }

        private void TekrarBasla()
        {
            TemelFonksiyonlar();
        }

        int rastgeleSayi = 0;
        int dogruTahminsayisi = 0;
        int yanlisTahminsayisi = 0;
        private void TemelFonksiyonlar()
        {
            tbx_tahmin.Text = "";
            saniye = baslangicSaniyesi;
            progressBar1.Value = 100;
            lbl_saniye.Text = saniye.ToString();
            if (!timer.Enabled) timer.Start();
            rastgeleSayi = random.Next(0, 20);
            lbl_durum.Text = "";
            lbl_dogruTahmin.Text = "Doğru Tahmin Sayısı: " + dogruTahminsayisi.ToString();
            lbl_yanlistahmin.Text = "Yanlış Tahmin Sayısı: " + yanlisTahminsayisi.ToString();
        }

        private void Kazandin()
        {
            int sayi = 25;
            try
            {
                sayi = Convert.ToInt32(tbx_tahmin.Text);
            }
            catch { MessageBox.Show("Girdiğin Bir Sayı Değil"); return; }

            if (sayi > 20)
            {
                MessageBox.Show("Girdiğiniz Sayı Çok Büyük");
                return;
            }

            if (sayi == rastgeleSayi)
            {
                if (timer.Enabled) timer.Stop();
                MessageBox.Show("Doğru tahmin ettiniz!");
                dogruTahminsayisi++;
                TemelFonksiyonlar();

            }

            if (sayi < rastgeleSayi && sayi != 25)
            {
                lbl_durum.Text = "Yukarı";
            }
            if (sayi > rastgeleSayi && sayi != 25)
            {
                lbl_durum.Text = "Aşağı";
            }

            tbx_tahmin.Focus();
        }
    }
}
