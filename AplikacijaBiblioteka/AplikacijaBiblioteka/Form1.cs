using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaBiblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpisKorisnika frm = new UpisKorisnika();
            frm.ShowDialog();

        }

        private void btnUpisKnjiga_Click(object sender, EventArgs e)
        {
            UpisKnjiga frm = new UpisKnjiga();
                frm.ShowDialog();
        }

        private void btnPosudbaKnjige_Click(object sender, EventArgs e)
        {
             PosudbaKnjige frm = new PosudbaKnjige();
                frm.ShowDialog();
        }

        private void btnStanjeKnjiga_Click(object sender, EventArgs e)
        {
            StanjeKnjiga frm = new StanjeKnjiga(); 
            frm.ShowDialog();
        }

        private void btnStanjeKnjSkladistu_Click(object sender, EventArgs e)
        {
            StanjeKnjigaSkladiste frm = new StanjeKnjigaSkladiste();
            frm.ShowDialog();
        }
    }
}
