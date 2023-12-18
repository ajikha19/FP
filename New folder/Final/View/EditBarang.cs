using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final.View
{
    public partial class EditBarang : Form
    {
        private const string PlaceholderText = "Masukkan teks disini...";

        public EditBarang()
        {
            InitializeComponent();
            // Atur placeholder pada awalnya
            SetPlaceholder();

            // Tambahkan event handler untuk Enter dan Leave
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;

            textBox2.Enter += TextBox1_Enter;
            textBox2.Leave += TextBox1_Leave;

            textBox3.Enter += TextBox3_Enter;
            textBox3.Leave += TextBox3_Leave;

            textBox4.Enter += TextBox4_Enter;
            textBox4.Leave += TextBox4_Leave;

            textBox5.Enter += TextBox5_Enter;
            textBox5.Leave += TextBox5_Leave;
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

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == PlaceholderText)
            {
                textBox2.Text = " ";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == PlaceholderText)
            {
                textBox3.Text = " ";
                textBox3.ForeColor = SystemColors.WindowText;
            }
            
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == PlaceholderText)
            {
                textBox4.Text = " ";
                textBox4.ForeColor = SystemColors.WindowText;
            }

        }

        private void TextBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == PlaceholderText)
            {
                textBox5.Text = " ";
                textBox5.ForeColor = SystemColors.WindowText;
            }

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // Atur teks placeholder saat TextBox kehilangan fokus
            SetPlaceholder();
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            textBox1.Text = PlaceholderText;
            textBox1.ForeColor = SystemColors.GrayText; // Atur warna teks menjadi abu-abu

            textBox2.Text = PlaceholderText;
            textBox2.ForeColor = SystemColors.GrayText;

            textBox3.Text = PlaceholderText;
            textBox3.ForeColor = SystemColors.GrayText;

            textBox3.Text = PlaceholderText;
            textBox3.ForeColor = SystemColors.GrayText;

            textBox4.Text = PlaceholderText;
            textBox4.ForeColor = SystemColors.GrayText;

            textBox5.Text = PlaceholderText;
            textBox5.ForeColor = SystemColors.GrayText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang Anda perlukan saat teks berubah
            UpdateStatusLabel(textBox1.Text.Length);
        }
        private void UpdateStatusLabel(int textLength)
        {
            // Contoh: Memperbarui label untuk menampilkan panjang teks
           // statusLabel.Text = $"Panjang Teks: {textLength}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // logika saat teks berubah
            UpdateStatusLabel(textBox2.Text.Length);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel(textBox3.Text.Length);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel(textBox4.Text.Length);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel(textBox5.Text.Length);
        }

        private void EditBarang_Load(object sender, EventArgs e)
        {

        }
    }
}