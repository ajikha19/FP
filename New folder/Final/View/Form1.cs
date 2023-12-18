using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.View
{
    public partial class Form1 : Form
    {
        private const string PlaceholderText = "Masukkan teks disini...";

        public Form1()
        {
            InitializeComponent();

            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            // Hapus teks placeholder saat TextBox mendapatkan fokus
            if (textBox1.Text == PlaceholderText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // Atur warna teks kembali ke warna default
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // Atur teks placeholder saat TextBox kehilangan fokus
            //SetPlaceholder();
        }

        private void SetPlaceHolder()
        {
            textBox1.Text = PlaceholderText;
            textBox1.ForeColor = SystemColors.GrayText; // Atur warna teks menjadi abu-abu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBarang barang = new InputBarang();

            barang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditBarang barang = new EditBarang();

            barang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputPelanggan pelanggan = new InputPelanggan();

            pelanggan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPelanggan pelanggan = new EditPelanggan();

            pelanggan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kasir kasir = new Kasir();

            kasir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditKasir kasir = new EditKasir();

            kasir.Show();
        }
    }
}
