using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav3_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(0, 101);

            lblSonuc.Text = sayi.ToString();

            if ( sayi < 50)
            {
                lblSonuc.ForeColor = Color.Red;
            }
            else if ( sayi >= 50 && sayi <= 70)
            {
                lblSonuc.ForeColor = Color.Orange;
            }
            else
            {
                lblSonuc.ForeColor= Color.Blue;
            }

        }
    }
}
