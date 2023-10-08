using System.Windows.Forms;

namespace MüsteriÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal void VerileriGönder(List<Kisi> eklenenler)
        {

            listBox1.Items.Clear();
            foreach (Kisi ekle in eklenenler)
            {
                listBox1.Items.Add($"{ekle.AdSoyad}");

            }
        }
        
        private void btnYeniMüsteriEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {

            //Liste kisi2 = new Liste();

            //MessageBox.Show($"{kisi2.AdSoyad} - {kisi2.Telefon} - {kisi2.Yas} - {kisi2.Adres}");
        }

        
    }
}