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

namespace ANKA_OTOMASYON.ekleme_formları.kiralık
{
    public partial class kiralik_daire_ekle : Form
    {
        public kiralik_daire_ekle()
        {
            InitializeComponent();
        }

        private void btn_kiralik_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into kiralik_daire(mahalle,oda_sayisi,m2,mutfak,kat,durum,evsahibi,evsahibi_no,foto,konum)Values('" + txt_kiralik_mahalle.Text + "','" + txt_kiralik_oda.Text + "','" + txt_kiralik_m2.Text + "','" + txt_kiralik_mutfak.Text + "','" + txt_kiralik_kat.Text + "','" + txt_kiralik_durum.Text + "','" + txt_kiralik_evsahibi.Text + "','" + txt_kiralik_telno.Text + "','" + txt_kiralik_fotolar.Text + "','" + txt_kiralik_daire_konum.Text + "')";
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }

        public void temizle()
        {
            txt_kiralik_mahalle.Text = "";
            txt_kiralik_oda.Text = "";
            txt_kiralik_m2.Text = "";
            txt_kiralik_mutfak.Text = "";
            txt_kiralik_kat.Text = "";
            txt_kiralik_durum.Text = "";
            txt_kiralik_evsahibi.Text = "";
            txt_kiralik_telno.Text = "";
            txt_kiralik_fotolar.Text = "";
        }

        private void btn_fotosec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fotosec = new FolderBrowserDialog();
            fotosec.ShowDialog();
            string a = fotosec.SelectedPath.ToString();
            txt_kiralik_fotolar.Text = a;
        }

        private void kiralik_daire_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
