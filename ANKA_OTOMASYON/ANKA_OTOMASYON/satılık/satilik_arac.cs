using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKA_OTOMASYON
{
    public partial class satilik_arac : Form
    {
        public satilik_arac()
        {
            InitializeComponent();
            arac_listele();
        }
        public void arac_listele()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From satilik_arac", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_satilik_arac.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }

        void aracSil(int ID)
        {
            string sql = "DELETE FROM satilik_arac WHERE ID=@ID";
            SQLiteCommand komut = new SQLiteCommand(sql, Baglan.connection);
            komut.Parameters.AddWithValue("@ID", ID);
            Baglan.connection.Open();
            komut.ExecuteNonQuery();
            Baglan.connection.Close();
        }

        void arac_ara()
        {
            Baglan.connection.Open();
            DataTable tbl = new DataTable();
            string ara, sorgu;
            ara = txt_satilik_arac_ara.Text;
            sorgu = "Select * from satilik_arac where marka like '%" + txt_satilik_arac_ara.Text + "%'";
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sorgu, Baglan.connection);
            adptr.Fill(tbl);
            Baglan.connection.Close();
            datagrid_satilik_arac.DataSource = tbl;
        }

        void sütun_gizle()
        {
            datagrid_satilik_arac.Columns[0].Visible = false;
            datagrid_satilik_arac.Columns[12].Visible = false;
        }

        void datagrid_baslikadi()
        {
            datagrid_satilik_arac.Columns[1].HeaderText = "PLAKA";
            datagrid_satilik_arac.Columns[2].HeaderText = "MODEL";
            datagrid_satilik_arac.Columns[3].HeaderText = "MARKA";
            datagrid_satilik_arac.Columns[4].HeaderText = "KM";
            datagrid_satilik_arac.Columns[5].HeaderText = "MOTOR";
            datagrid_satilik_arac.Columns[6].HeaderText = "HASAR";
            datagrid_satilik_arac.Columns[7].HeaderText = "DEĞİŞEN";
            datagrid_satilik_arac.Columns[8].HeaderText = "BOYA";
            datagrid_satilik_arac.Columns[9].HeaderText = "AÇIKLAMA";
            datagrid_satilik_arac.Columns[10].HeaderText = "ARAÇ SAHİBİ";
            datagrid_satilik_arac.Columns[11].HeaderText = "ARAÇ SAHİBİ NO";
            

        }




        private void satilik_arac_Load(object sender, EventArgs e)
        {
            arac_listele();
            sütun_gizle();
            datagrid_baslikadi();
        }

        private void btn_satilik_arac_yenile_Click(object sender, EventArgs e)
        {
            arac_listele();
        }

        private void btn_satilik_arac_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_satilik_arac.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                aracSil(ID);
            }
            arac_listele();
        }

        private void txt_satilik_arac_ara_TextChanged(object sender, EventArgs e)
        {
            arac_ara();
        }

        private void btn_stlk_arac_ekle_Click(object sender, EventArgs e)
        {
            satilik_arac_ekle ac = new satilik_arac_ekle();
            ac.Show();
        }

        private void btn_fotogoster_Click(object sender, EventArgs e)
        {
            if (txt_satilik_arac_yol.Text == null || txt_satilik_arac_yol.Text == "")
            {
                MessageBox.Show("GİDİLECEK HERHANGİ BİR KLASÖR BULUNAMADI!");
            }
            else
            {
                string yol = datagrid_satilik_arac.CurrentRow.Cells[12].Value.ToString();
                txt_satilik_arac_yol.Text = yol;
                Process.Start(yol);
            }
        }

        

        private void datagrid_satilik_arac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yol = datagrid_satilik_arac.CurrentRow.Cells[12].Value.ToString();
            txt_satilik_arac_yol.Text = yol;
        }
    }
}
