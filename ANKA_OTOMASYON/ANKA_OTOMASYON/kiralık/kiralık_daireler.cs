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

namespace ANKA_OTOMASYON.kiralık
{
    public partial class kiralık_daireler : Form
    {
        public kiralık_daireler()
        {
            InitializeComponent();
            listele();

        }

        public static TextBox kiralik_knm_txt;
        

        private void kiralık_daireler_Load(object sender, EventArgs e)
        {
            listele();
            sütun_gizle();
            datagrid_baslikadi();
        }

        public void listele()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From kiralik_daire", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_kiralik_daireler.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }

        void KayıtSil(int ID)
        {
            string sql = "DELETE FROM kiralik_daire WHERE ID=@ID";
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
            ara = txt_krlk_ara.Text;
            sorgu = "Select * from kiralik_daire where mahalle like '%" + txt_krlk_ara.Text + "%'";
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sorgu, Baglan.connection);
            adptr.Fill(tbl);
            Baglan.connection.Close();
            datagrid_kiralik_daireler.DataSource = tbl;
        }

        void sütun_gizle()
        {
            datagrid_kiralik_daireler.Columns[0].Visible = false;
            datagrid_kiralik_daireler.Columns[9].Visible = false;
            datagrid_kiralik_daireler.Columns[10].Visible = false;
        }

        void datagrid_baslikadi()
        {
            datagrid_kiralik_daireler.Columns[1].HeaderText = "MAHALLE";
            datagrid_kiralik_daireler.Columns[2].HeaderText = "ODA SAYISI";
            datagrid_kiralik_daireler.Columns[3].HeaderText = "M2";
            datagrid_kiralik_daireler.Columns[4].HeaderText = "MUTFAK";
            datagrid_kiralik_daireler.Columns[5].HeaderText = "KAT";
            datagrid_kiralik_daireler.Columns[6].HeaderText = "DURUM";
            datagrid_kiralik_daireler.Columns[7].HeaderText = "EV SAHİBİ";
            datagrid_kiralik_daireler.Columns[8].HeaderText = "EV SAHİBİ NO";
        }

        private void btn_krlk_daire_ekle_Click(object sender, EventArgs e)
        {
            ekleme_formları.kiralık.kiralik_daire_ekle ac = new ekleme_formları.kiralık.kiralik_daire_ekle();
            ac.Show();
        }

        private void btn_krlk_yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_krlk_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_kiralik_daireler.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(ID);
            }
            listele();
        }

        private void txt_krlk_ara_TextChanged(object sender, EventArgs e)
        {
            kayıt_ara();
        }

        private void btn_konum_Click(object sender, EventArgs e)
        {
            
            kiralik_knm_txt = txt_kiralik_konum;
            kiralik_knm_txt.Text = txt_kiralik_konum.Text.ToString();
            konum.kiralik_daire_konum ac = new konum.kiralik_daire_konum();
            ac.Show();
        }

        private void datagrid_kiralik_daireler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yol = datagrid_kiralik_daireler.CurrentRow.Cells[9].Value.ToString();
            txt_kiralik_yol.Text = yol;

            string konum = datagrid_kiralik_daireler.CurrentRow.Cells[10].Value.ToString();
            txt_kiralik_konum.Text = konum;
        }
    }
    
}
