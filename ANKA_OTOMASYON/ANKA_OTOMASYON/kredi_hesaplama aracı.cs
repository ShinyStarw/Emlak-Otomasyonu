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
    public partial class kredi_hesaplama_aracı : Form
    {
        public kredi_hesaplama_aracı()
        {
            InitializeComponent();
        }

        private void kredi_hesaplama_aracı_Load(object sender, EventArgs e)
        {
            webView1.Url = "https://kredi.hesaplama.net";
        }
    }
}
