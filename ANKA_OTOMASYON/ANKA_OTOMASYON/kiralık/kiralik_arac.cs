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

namespace ANKA_OTOMASYON.kiralık
{
    public partial class kiralik_arac : Form
    {
        public kiralik_arac()
        {
            InitializeComponent();
            arac_listele();
        }

        private void kiralik_arac_Load(object sender, EventArgs e)
        {
            arac_listele();
            sütun_gizle();
            datagrid_baslikadi();
        }

        public void arac_listele()
        {
            Baglan.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From kiralik_arac", Baglan.connection);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            datagrid_kiralik_arac.DataSource = dset.Tables[0];
            Baglan.connection.Close();
        }

        void aracSil(int ID)
        {
            string sql = "DELETE FROM kiralik_arac WHERE ID=@ID";
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
            ara = txt_kiralik_arac_ara.Text;
            sorgu = "Select * from kiralik_arac where marka like '%" + txt_kiralik_arac_ara.Text + "%'";
            SQLiteDataAdapter adptr = new SQLiteDataAdapter(sorgu, Baglan.connection);
            adptr.Fill(tbl);
            Baglan.connection.Close();
            datagrid_kiralik_arac.DataSource = tbl;
        }

        void sütun_gizle()
        {
            datagrid_kiralik_arac.Columns[0].Visible = false;
            datagrid_kiralik_arac.Columns[12].Visible = false;
        }

        void datagrid_baslikadi()
        {
            datagrid_kiralik_arac.Columns[1].HeaderText = "PLAKA";
            datagrid_kiralik_arac.Columns[2].HeaderText = "MODEL";
            datagrid_kiralik_arac.Columns[3].HeaderText = "MARKA";
            datagrid_kiralik_arac.Columns[4].HeaderText = "KM";
            datagrid_kiralik_arac.Columns[5].HeaderText = "MOTOR";
            datagrid_kiralik_arac.Columns[6].HeaderText = "HASAR";
            datagrid_kiralik_arac.Columns[7].HeaderText = "DEĞİŞEN";
            datagrid_kiralik_arac.Columns[8].HeaderText = "BOYA";
            datagrid_kiralik_arac.Columns[9].HeaderText = "AÇIKLAMA";
            datagrid_kiralik_arac.Columns[10].HeaderText = "ARAÇ SAHİBİ";
            datagrid_kiralik_arac.Columns[11].HeaderText = "ARAÇ SAHİBİ NO";


        }

        private void btn_kiralik_arac_ekle_Click(object sender, EventArgs e)
        {
            ekleme_formları.kiralık.kiralik_arac_ekle ac = new ekleme_formları.kiralık.kiralik_arac_ekle();
            ac.Show();
        }

        private void btn_kiralik_arac_yenile_Click(object sender, EventArgs e)
        {
            arac_listele();
        }

        private void btn_kiralik_arac_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagrid_kiralik_arac.SelectedRows)  //Seçili Satırları Silme
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                aracSil(ID);
            }
            arac_listele();
        }

        private void btn_fotogoster_Click(object sender, EventArgs e)
        {
            if (txt_kiralik_arac_yol.Text == null || txt_kiralik_arac_yol.Text == "")
            {
                MessageBox.Show("GİDİLECEK HERHANGİ BİR KLASÖR BULUNAMADI!");
            }
            else
            {
                string yol = datagrid_kiralik_arac.CurrentRow.Cells[12].Value.ToString();
                txt_kiralik_arac_yol.Text = yol;
                Process.Start(yol);
            }
        }

        private void datagrid_kiralik_arac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yol = datagrid_kiralik_arac.CurrentRow.Cells[12].Value.ToString();
            txt_kiralik_arac_yol.Text = yol;
        }

        private void txt_kiralik_arac_ara_TextChanged(object sender, EventArgs e)
        {
            arac_ara();
        }
    }
}
