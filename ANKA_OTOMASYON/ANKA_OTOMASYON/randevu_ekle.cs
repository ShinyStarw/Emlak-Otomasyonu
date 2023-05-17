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
    public partial class randevu_ekle : Form
    {
        public randevu_ekle()
        {
            InitializeComponent();
        }

        private void randevu_ekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_müsteri_kaydet_Click(object sender, EventArgs e)
        {
            Baglan.connection.Open();
            string ekle_sql = "insert into randevu(adsoyad,aciklama,saat)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "')"; 
            SQLiteCommand komutislet = new SQLiteCommand(ekle_sql, Baglan.connection);
            komutislet.ExecuteNonQuery();
            Baglan.connection.Close();
            MessageBox.Show("KAYDEDİLDİ!!");
            temizle();
        }

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }
    }
}
