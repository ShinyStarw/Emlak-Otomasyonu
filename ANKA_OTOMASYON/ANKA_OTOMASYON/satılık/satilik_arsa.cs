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
    public partial class satilik_arsa : Form
    {
        public satilik_arsa()
        {
            InitializeComponent();
            arsa_listele();
        }
        public static string arsa_konum;
        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void arsa_listele()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From satilik_arsa", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_arsa.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }
        void datagrid_baslikadi()
        {
            datagrid_arsa.Columns[1].HeaderText = "İL";
            datagrid_arsa.Columns[2].HeaderText = "İLÇE";
            datagrid_arsa.Columns[3].HeaderText = "KÖY/MAH";
            datagrid_arsa.Columns[4].HeaderText = "ADA";
            datagrid_arsa.Columns[5].HeaderText = "PARSEL";
            datagrid_arsa.Columns[6].HeaderText = "DÖNÜM";
            datagrid_arsa.Columns[7].HeaderText = "KONUM";
            datagrid_arsa.Columns[8].HeaderText = "STATÜ";
            datagrid_arsa.Columns[9].HeaderText = "HİSSE";
            datagrid_arsa.Columns[10].HeaderText = "HİSSE SAYISI";
            datagrid_arsa.Columns[11].HeaderText = "ARSA SAHİBİ";
            datagrid_arsa.Columns[12].HeaderText = "ARSA SAHİBİ NO";
        }
        void sütun_gizle()
        {
            datagrid_arsa.Columns[0].Visible = false;
            datagrid_arsa.Columns[7].Visible = false;
            datagrid_arsa.Columns[13].Visible = false;
        }

        private void satilik_arsa_Load(object sender, EventArgs e)
        {
            arsa_listele();
            datagrid_baslikadi();
            sütun_gizle();
            


        }

        private void btn_stlk_arsa_ekle_Click(object sender, EventArgs e)
        {
            arsa_ekle ac = new arsa_ekle();
            ac.Show();
        }

        private void btn_arsa_yenile_Click(object sender, EventArgs e)
        {
            arsa_listele();
        }
        void arsasil(int ID)
        {
            string sql = "DELETE FROM satilik_arsa WHERE ID=@ID";
            SQLiteCommand komut = new SQLiteCommand(sql, Baglan.connection);
            komut.Parameters.AddWithValue("@ID", ID);
            Baglan.connection.Open();
            komut.ExecuteNonQuery();
            Baglan.connection.Close();
        }

        private void btn_arsa_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_arsa.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                arsasil(ID);
            }
            arsa_listele();
        }

        private void btn_arsa_fotogoster_Click(object sender, EventArgs e)
        {
            if (txt_arsa_yol.Text == null || txt_arsa_yol.Text == "")
            {
                MessageBox.Show("GİDİLECEK HERHANGİ BİR KLASÖR BULUNAMADI!");
            }
            else
            {
                string yol = datagrid_arsa.CurrentRow.Cells[13].Value.ToString();
                txt_arsa_yol.Text = yol;
                Process.Start(yol);
            }
        }

        

        void arsa_ara()
        {
            Baglan.connection.Open();
            DataTable tbl = new DataTable();
            string ara, sorgu;
            ara = txt_arsa_ara.Text;
            sorgu = "Select * from satilik_arsa where il like '%" + txt_arsa_ara.Text + "%'";
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sorgu, Baglan.connection);
            adptr.Fill(tbl);
            Baglan.connection.Close();
            datagrid_arsa.DataSource = tbl;
        }

        private void txt_satilik_ara_TextChanged(object sender, EventArgs e)
        {
            arsa_ara();
        }

        private void txt_arsa_ara_MouseEnter(object sender, EventArgs e)
        {
            txt_arsa_ara.Text = "";
        }

        private void datagrid_arsa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yol = datagrid_arsa.CurrentRow.Cells[13].Value.ToString();
            txt_arsa_yol.Text = yol;

            string konum = datagrid_arsa.CurrentRow.Cells[7].Value.ToString();
            txt_satilik_arsa_konum.Text = konum;


        }

        private void btn_arsa_konum_Click(object sender, EventArgs e)
        {
            arsa_konum = txt_satilik_arsa_konum.Text;
            konum.satilik_arsa_konum ac = new konum.satilik_arsa_konum();
            ac.Show();
        }
    }
}
