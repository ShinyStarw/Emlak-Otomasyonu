using ANKA_OTOMASYON.kiralık;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKA_OTOMASYON
{
    public partial class ANKA : Form
    {
        public ANKA()
        {
            InitializeComponent();
        }

        

        private void satilik_daire_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            satilik_daireler formu_ac = new satilik_daireler();
            formu_ac.Show();
        }

        public void listeler()
        {
            satilik_daireler daire_sayi = new satilik_daireler();
            lbl_satilik_daire.Text = "SATILIK DAİRE SAYISI = " + daire_sayi.datagrid_satilik_daireler.RowCount.ToString();
            satilik_arac arac_sayi = new satilik_arac();
            lbl_satilik_arac.Text = "SATILIK ARAÇ SAYISI = " + arac_sayi.datagrid_satilik_arac.RowCount.ToString();
            satilik_arsa arsa_sayi = new satilik_arsa();
            lbl_satilik_arsa.Text = "SATILIK ARSA SAYISI = " + arsa_sayi.datagrid_arsa.RowCount.ToString();
            kiralik_arac krlk_arac_sayi = new kiralik_arac();
            lbl_kiralik_arac.Text = "KİRALIK ARAÇ SAYISI = " + krlk_arac_sayi.datagrid_kiralik_arac.RowCount.ToString();
            kiralık_daireler krlk_daire_sayi = new kiralık_daireler();
            lbl_kiralik_daire.Text = "KİRALIK DAİRE SAYISI = " + krlk_daire_sayi.datagrid_kiralik_daireler.RowCount.ToString();

        }

        public void gizle()
        {
            datagrid_müsteri.Columns[0].Visible = false;
            //datagrid_randevu.Columns[0].Visible = false;
        }

        public void sütun_baslik()
        {
            datagrid_müsteri.Columns[1].HeaderText = "İSİM";
            datagrid_müsteri.Columns[2].HeaderText = "TÜR";
            datagrid_müsteri.Columns[3].HeaderText = "İSTENEN";
            datagrid_müsteri.Columns[4].HeaderText = "BÜTÇE";
            datagrid_müsteri.Columns[5].HeaderText = "ACIKLAMA";

        }

        public void randevu_durum()
        {
            datagrid_randevu.Columns[0].Visible = false;
            datagrid_randevu.Columns[1].HeaderText = "İSİM";
            datagrid_randevu.Columns[2].HeaderText = "ACIKLAMA";
            datagrid_randevu.Columns[3].HeaderText = "TARİH";
        }

        public void ANKA_Load(object sender, EventArgs e)
        {
            webView1.Url = "www.sahibinden.com";
            listeler();
            müsteriler();
            gizle();
            sütun_baslik();
            randevular();
            randevu_durum();
            
        }

        void müsteriSil(int ID)
        {
            string sql = "DELETE FROM müsteri WHERE ID=@ID";
            SQLiteCommand komut = new SQLiteCommand(sql, Baglan.connection);
            komut.Parameters.AddWithValue("@ID", ID);
            Baglan.connection.Open();
            komut.ExecuteNonQuery();
            Baglan.connection.Close();
        }

        void randevuSil(int ID)
        {
            string sql = "DELETE FROM randevu WHERE ID=@ID";
            SQLiteCommand komut = new SQLiteCommand(sql, Baglan.connection);
            komut.Parameters.AddWithValue("@ID", ID);
            Baglan.connection.Open();
            komut.ExecuteNonQuery();
            Baglan.connection.Close();
        }




        private void satilik_arsa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satilik_arsa ac = new satilik_arsa();
            ac.Show();
        }

        private void satilik_arac_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satilik_arac ac = new satilik_arac();
            ac.Show();
        }

        private void kiralık_daire_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kiralık.kiralık_daireler ac = new kiralık.kiralık_daireler();
            ac.Show();
        }

        private void kiralik_arac_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kiralık.kiralik_arac ac = new kiralık.kiralik_arac();
            ac.Show();
        }

        

        private void KREDİHESAPLAYICIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kredi_hesaplama_aracı ac = new kredi_hesaplama_aracı();
            ac.Show();
        }

        public void müsteriler()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From müsteri", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_müsteri.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }

        public void randevular()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From randevu", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_randevu.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }

        private void btn_müsteri_ekle_Click(object sender, EventArgs e)
        {
            müsteri_ekle ac = new müsteri_ekle();
            ac.Show();
        }

        private void btn_müsteri_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_müsteri.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                müsteriSil(ID);
            }
            müsteriler();
        }

        private void btn_müsteri_yenile_Click(object sender, EventArgs e)
        {
            müsteriler();
        }

        private void btn_randevu_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_randevu.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                randevuSil(ID);
            }
            randevular();
        }

        private void btn_randevu_yenile_Click(object sender, EventArgs e)
        {
            randevular();
        }

        private void btn_randevu_ekle_Click(object sender, EventArgs e)
        {
            randevu_ekle ac = new randevu_ekle();
            ac.Show();
        }

        private void btn_list_yenile_Click(object sender, EventArgs e)
        {
            listeler();
        }
    }
}
