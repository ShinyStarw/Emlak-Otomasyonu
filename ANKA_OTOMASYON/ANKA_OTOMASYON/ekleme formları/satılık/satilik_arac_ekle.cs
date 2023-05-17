using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKA_OTOMASYON
{
    public partial class satilik_arac_ekle : Form
    {
        public satilik_arac_ekle()
        {
            InitializeComponent();
        }

        private void btn_fotosec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fotosec = new FolderBrowserDialog();
            fotosec.ShowDialog();
            string a = fotosec.SelectedPath.ToString();
            txt_satilik_arac_fotolar.Text = a;
        }
        public void temizle()
        {
            txt_satilik_arac_plaka.Text = "";
            txt_satilik_arac_model.Text = "";
            txt_satilik_arac_marka.Text = "";
            txt_satilik_arac_km.Text = "";
            txt_satilik_arac_motor.Text = "";
            txt_satilik_arac_hasar.Text = "";
            txt_satilik_arac_degisen.Text = "";
            txt_satilik_arac_boya.Text = "";
            txt_satilik_arac_aciklama.Text = "";
            txt_satilik_arac_aracsahibi.Text = "";
            txt_satilik_arac_no.Text = "";
            txt_satilik_arac_fotolar.Text = "";
        }

        private void btn_arsa_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into satilik_arac(plaka,model,marka,km,motor,hasar,degisen,boya,aciklama,arac_sahibi,arac_sahibi_no,foto_klasor)Values('" + txt_satilik_arac_plaka.Text + "','" + txt_satilik_arac_model.Text + "','" + txt_satilik_arac_marka.Text + "','" + txt_satilik_arac_km.Text + "','" + txt_satilik_arac_motor.Text + "','" + txt_satilik_arac_hasar.Text + "','" + txt_satilik_arac_degisen.Text + "','" + txt_satilik_arac_boya.Text + "','" + txt_satilik_arac_aciklama.Text + "','" + txt_satilik_arac_aracsahibi.Text + "','" + txt_satilik_arac_no.Text + "','" + txt_satilik_arac_fotolar.Text + "')";
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }
    }
}
