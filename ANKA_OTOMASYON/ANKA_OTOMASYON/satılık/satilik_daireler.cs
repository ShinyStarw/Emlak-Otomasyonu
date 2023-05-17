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
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ANKA_OTOMASYON
{
    public partial class satilik_daireler : Form
    {
        public satilik_daireler()
        {
            InitializeComponent();
            listele();
        }

        public static TextBox knm_txt;
        public static Button button_konum;
        
        
        public void listele()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From satilik_daire",Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_satilik_daireler.DataSource = dset.Tables[0];
            Baglan.connection.Close();
            
            




        }
        void KayıtSil(int ID)
        {
            string sql = "DELETE FROM satilik_daire WHERE ID=@ID";
            SQLiteCommand komut = new SQLiteCommand(sql, Baglan.connection);
            komut.Parameters.AddWithValue("@ID", ID);
            Baglan.connection.Open();
            komut.ExecuteNonQuery();
            Baglan.connection.Close();
        }

        void kayıt_ara()
        {
            Baglan.connection.Open();
            DataTable tbl = new DataTable();
            string ara, sorgu;
            ara = txt_satilik_ara.Text;
            sorgu = "Select * from satilik_daire where mahalle like '%" + txt_satilik_ara.Text + "%'";
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sorgu, Baglan.connection);
            adptr.Fill(tbl);
            Baglan.connection.Close();
            datagrid_satilik_daireler.DataSource = tbl;
        }

        void sütun_gizle()
        {
            datagrid_satilik_daireler.Columns[0].Visible = false;
            datagrid_satilik_daireler.Columns[9].Visible = false;
            datagrid_satilik_daireler.Columns[10].Visible = false;

        }

        void datagrid_baslikadi()
        {
            datagrid_satilik_daireler.Columns[1].HeaderText = "MAHALLE";
            datagrid_satilik_daireler.Columns[2].HeaderText = "ODA SAYISI";
            datagrid_satilik_daireler.Columns[3].HeaderText = "M2";
            datagrid_satilik_daireler.Columns[4].HeaderText = "MUTFAK";
            datagrid_satilik_daireler.Columns[5].HeaderText = "KAT";
            datagrid_satilik_daireler.Columns[6].HeaderText = "DURUM";
            datagrid_satilik_daireler.Columns[7].HeaderText = "EV SAHİBİ";
            datagrid_satilik_daireler.Columns[8].HeaderText = "EV SAHİBİ NO";



        }



        private void btn_stlk_daire_ekle_Click(object sender, EventArgs e)
        {
            satilik_daire_ekle formu_ac = new satilik_daire_ekle();
            formu_ac.Show();
        }

        


        private void satilik_daireler_Load(object sender, EventArgs e)
        {
            listele();
            sütun_gizle();
            datagrid_baslikadi();

        }

        private void btn_satilik_yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_fotogoster_Click(object sender, EventArgs e)
        {
            if (txt_satilik_yol.Text == null || txt_satilik_yol.Text=="")
            {
                MessageBox.Show("GİDİLECEK HERHANGİ BİR KLASÖR BULUNAMADI!");
            }
            else
            {
                string yol = datagrid_satilik_daireler.CurrentRow.Cells[9].Value.ToString();
                txt_satilik_yol.Text = yol;
                Process.Start(yol);
            }
        }

        

        private void txt_satilik_ara_MouseEnter(object sender, EventArgs e)
        {
            txt_satilik_ara.Text = "";
        }

        private void datagrid_satilik_daireler_DoubleClick(object sender, EventArgs e)
        {

            if (txt_satilik_yol.Text == null || txt_satilik_yol.Text == "")
            {
                MessageBox.Show("GİDİLECEK HERHANGİ BİR KLASÖR BULUNAMADI!");
            }
            else
            {
                string yol = datagrid_satilik_daireler.CurrentRow.Cells[9].Value.ToString();
                txt_satilik_yol.Text = yol;
                Process.Start(yol);
            }
        }

        private void btn_satilik_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_satilik_daireler.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(ID);
            }
            listele();
        }

        private void txt_satilik_ara_TextChanged(object sender, EventArgs e)
        {
            kayıt_ara();
        }

        

        private void btn_konum_Click(object sender, EventArgs e)
        {
            
            knm_txt = txt_konum;
            knm_txt.Text = txt_konum.Text.ToString();
            konum_daire_satilik ac = new konum_daire_satilik();
            ac.Show();
        }

        private void datagrid_satilik_daireler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yol = datagrid_satilik_daireler.CurrentRow.Cells[9].Value.ToString();
            txt_satilik_yol.Text = yol;

            string konum = datagrid_satilik_daireler.CurrentRow.Cells[10].Value.ToString();
            txt_konum.Text = konum;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    

   
}
