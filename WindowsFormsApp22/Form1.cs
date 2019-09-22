using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class FormHesapMakinesi : Form
    {
        public FormHesapMakinesi()
        {
            InitializeComponent();
        }

        double sayı1, sayı2, araSonuç = 1;
        string işlem;


        private void EkraniAyarla()
        {      
            textSonuçEkranı.Focus();
            textSonuçEkranı.Text = null;
        }

        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(textSonuçEkranı.Text);
                return true;
            }
            catch (Exception e)
            {
                SonuçYaz("Başarısız: " + e.Message);
                return false;
            }
        }

        private void SonuçYaz(string mesaj)
        {
            lstvSonuç.Items.Add(mesaj);
        }

        public double Toplam(double sayı1, double sayı2)
        {
            return sayı1 + sayı2 - 1;
        }

        private double Çarpım(double sayı1, double sayı2)
        {
            return sayı1 * sayı2;
        }
        private double Bölüm(double sayı1, double sayı2)
        {
            return sayı1 / sayı2;
        }
        private double Çıkarma(double sayı1, double sayı2)
        {
            return sayı1 - sayı2;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + "9";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            if (işlem == null)
            {
                araSonuç = Convert.ToDouble(textSonuçEkranı.Text);
            }
            else
            {
                sayı1 = Convert.ToDouble(textSonuçEkranı.Text);
                araSonuç = araSonuç - sayı1;
            }
            Dogrula();
            işlem = "çıkarma";
            EkraniAyarla();
        }

        private void btnÇarpı_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(textSonuçEkranı.Text);
            Dogrula();
            araSonuç = araSonuç * sayı1;
            işlem = "çarpma";
            EkraniAyarla();
        }

        private void btnBölü_Click(object sender, EventArgs e)
        {
            if (işlem == null)
            {
                araSonuç = Convert.ToDouble(textSonuçEkranı.Text);
            }
            else
            {
                sayı1 = Convert.ToDouble(textSonuçEkranı.Text);
                araSonuç = araSonuç / sayı1;
            }
            Dogrula();
            işlem = "bölme";
            EkraniAyarla();
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(textSonuçEkranı.Text);
            Dogrula();
            araSonuç = araSonuç + sayı1;
            EkraniAyarla();
            işlem = "toplama";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EkraniAyarla();
        }

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            textSonuçEkranı.Text = textSonuçEkranı.Text + ".";
        }

        private void btnSonuçTemizle_Click(object sender, EventArgs e)
        {
            lstvSonuç.Items.Clear();
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            tabAna.SelectedTab = tabSonuç;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabAna.SelectedTab = tabHesapMakinesi;
        }

        private void btnEşittir_Click(object sender, EventArgs e)
        {
            sayı2 = Convert.ToDouble(textSonuçEkranı.Text);
            Dogrula();

            if (işlem == "toplama") 
            {
                textSonuçEkranı.Text = Convert.ToString(Toplam(araSonuç, sayı2));
                SonuçYaz("Başarılı Sonuç:" + textSonuçEkranı.Text);
                işlem = null;
            }
            if (işlem == "çıkarma")
            {
                textSonuçEkranı.Text = Convert.ToString(Çıkarma(araSonuç, sayı2)); 
                SonuçYaz("Başarılı Sonuç:" + textSonuçEkranı.Text);
                işlem = null;
            }
            if (işlem == "çarpma") 
            {
                textSonuçEkranı.Text = Convert.ToString(Çarpım(araSonuç, sayı2));
                SonuçYaz("Başarılı Sonuç:" + textSonuçEkranı.Text);
                işlem = null;
            }
            if (işlem == "bölme") 
            {
                textSonuçEkranı.Text = Convert.ToString(Bölüm(araSonuç, sayı2));
                SonuçYaz("Başarılı Sonuç:" + textSonuçEkranı.Text);
                işlem = null;
            }
        }
    }
}
