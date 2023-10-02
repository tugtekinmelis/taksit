using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_taksit_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int taksit, tutar;
            double taksitliTutar; 
            taksit = tbTaksit.Value;
            tutar = Convert.ToInt32(txtTutar.Text);

            taksitliTutar = (double)tutar / taksit;

            lblSonuc.Text = taksitliTutar.ToString();

        }

        private void tbTaksit_Scroll(object sender, EventArgs e)
        {
            lblSonuc.Text = tbTaksit.Value.ToString();
        }
    }
}
