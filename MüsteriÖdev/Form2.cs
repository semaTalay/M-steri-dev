using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MüsteriÖdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<Kisi> eklenenler = new List<Kisi>();



        public void btnKaydet_Click(object sender, EventArgs e)
        {

            Kisi kisi = new Kisi();
            kisi.AdSoyad = txtAdSoyad.Text;

            kisi.Telefon = int.Parse(txtTelefon.Text);
            kisi.Yas = (int)nudYas.Value;
            kisi.Adres = txtAdres.Text;

            eklenenler.Add(kisi);

            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            nudYas.Value = 0;



        }

        private void btnListeyeGeriDön_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.VerileriGönder(eklenenler);

            form1.Show();

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
