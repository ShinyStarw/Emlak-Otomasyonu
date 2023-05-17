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
    public partial class müsteri_ekle : Form
    {
        public müsteri_ekle()
        {
            InitializeComponent();
        }

        private void müsteri_ekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_müsteri_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into müsteri(adsoyad,tür,istenen,bütce,aciklama)Values('" +txt_müsteri_adsoyad.Text +"','" +cmb_tür.Text +"','" +cmb_istenen.Text +"','" +txt_müsteri_bütce.Text +"','" +txt_müsteri_aciklama.Text +"')";
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }

        void temizle()
        {
            txt_müsteri_adsoyad.Text = "";
            cmb_tür.Text = "";
            cmb_istenen.Text = "";
            txt_müsteri_bütce.Text = "";
            txt_müsteri_aciklama.Text = "";

        }
    }
}
