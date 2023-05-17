using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ANKA_OTOMASYON
{
    public partial class satilik_daire_ekle : Form
    {
      
        public satilik_daire_ekle()
        {
            InitializeComponent();
            
        }

        
        
        public void temizle()
        {
            txt_satilik_mahalle.Text = "";
            txt_satilik_oda.Text = "";
            txt_satilik_m2.Text = "";
            txt_satilik_mutfak.Text = "";
            txt_satilik_kat.Text = "";
            txt_satilik_durum.Text = "";
            txt_satilik_evsahibi.Text = "";
            txt_satilik_telno.Text = "";
            txt_satilik_fotolar.Text = "";
        }

        private void btn_satilik_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into satilik_daire(mahalle,oda_sayisi,m2,mutfak,kat,durum,evsahibi,evsahibi_no,foto_klasor,konum)Values('" + txt_satilik_mahalle.Text + "','" + txt_satilik_oda.Text + "','" + txt_satilik_m2.Text + "','" + txt_satilik_mutfak.Text + "','" + txt_satilik_kat.Text + "','" + txt_satilik_durum.Text + "','" + txt_satilik_evsahibi.Text + "','" + txt_satilik_telno.Text + "','"+txt_satilik_fotolar.Text+ "','" + txt_satilik_daire_konum.Text + "')";
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }

       

        private void txt_satilik_mahalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fotosec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fotosec = new FolderBrowserDialog();
            fotosec.ShowDialog();
            string a = fotosec.SelectedPath.ToString();
            txt_satilik_fotolar.Text = a;
        }

        private void satilik_daire_ekle_Load(object sender, EventArgs e)
        {
            
        }
    }
    }

