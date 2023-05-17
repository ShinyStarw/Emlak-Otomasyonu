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
    public partial class satilik_arsa_konum : Form
    {
        public satilik_arsa_konum()
        {
            InitializeComponent();
        }

        private void satilik_arsa_konum_Load(object sender, EventArgs e)
        {
            webView1.Url = satilik_arsa.arsa_konum;
        }
    }
}
