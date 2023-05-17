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
    public partial class arsa_ekle : Form
    {
        public arsa_ekle()
        {
            InitializeComponent();
        }

        private void btn_fotosec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fotosec = new FolderBrowserDialog();
            fotosec.ShowDialog();
            string a = fotosec.SelectedPath.ToString();
            txt_arsa_fotolar.Text = a;
        }

        public void temizle()
        {
            txt_arsa_il.Text = "";
            txt_arsa_ilce.Text = "";
            txt_arsa_mahalle.Text = "";
            txt_arsa_ada.Text = "";
            txt_arsa_parsel.Text = "";
            txt_arsa_konum.Text = "";
            txt_arsa_statü.Text = "";
            txt_arsa_hisse_durum.Text = "";
            txt_arsa_hisse_sayi.Text = "";
            txt_arsa_arsa_sahibi.Text = "";
            txt_arsa_arsa_sahibi_no.Text = "";
            txt_arsa_fotolar.Text = "";
            

        }

        private void btn_arsa_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into satilik_arsa(il,ilce,mahalle,ada,parsel,donum,konum,statu,hisse_durum,hisse_sayisi,arsa_sahibi,arsa_sahibi_no,foto)Values('" + txt_arsa_il.Text + "','" + txt_arsa_ilce.Text+ "','" + txt_arsa_mahalle.Text + "','" + txt_arsa_ada.Text + "','" + txt_arsa_parsel.Text + "','" + txt_arsa_donum.Text + "','" + txt_arsa_konum.Text + "','" + txt_arsa_statü.Text + "','" + txt_arsa_hisse_durum.Text + "','" + txt_arsa_hisse_sayi.Text + "','" + txt_arsa_arsa_sahibi.Text + "','" + txt_arsa_arsa_sahibi_no.Text + "','" + txt_arsa_fotolar.Text + "')";
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }
    }
}
