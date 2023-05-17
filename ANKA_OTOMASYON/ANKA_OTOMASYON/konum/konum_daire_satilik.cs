using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKA_OTOMASYON
{
    public partial class konum_daire_satilik : Form
    {
        public konum_daire_satilik()
        {
            InitializeComponent();
        }
        Button btn_satilik_daire = new Button();
        Button btn_kiralik_daire = new Button();
        Button btn_satilik_arsa = new Button();


        private void konum_daire_satilik_Load(object sender, EventArgs e)
        {
                webView1.Url = satilik_daireler.knm_txt.Text.ToString();
            
            
            
        }
    }
}
