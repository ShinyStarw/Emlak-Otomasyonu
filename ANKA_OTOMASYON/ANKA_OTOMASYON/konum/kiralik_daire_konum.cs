using ANKA_OTOMASYON.kiralık;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANKA_OTOMASYON.konum
{
    public partial class kiralik_daire_konum : Form
    {
        public kiralik_daire_konum()
        {
            InitializeComponent();
        }

        private void kiralik_daire_konum_Load(object sender, EventArgs e)
        {
            webView1.Url = kiralık_daireler.kiralik_knm_txt.Text;
        }
    }
}
