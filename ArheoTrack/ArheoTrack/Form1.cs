using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArheoTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            FormAutentificare formAutentificare = new FormAutentificare();
            formAutentificare.ShowDialog();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            FormÎnregistrare formÎnregistrare = new FormÎnregistrare();
            formÎnregistrare.ShowDialog();
        }

        private void txtArheoTrack_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCautareFosile_Click(object sender, EventArgs e)
        {
            FormCautareFosile formCautare = new FormCautareFosile();
            formCautare.ShowDialog();
        }
    }
}
