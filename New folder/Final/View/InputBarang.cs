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
    public partial class InputBarang : Form
    {
        private const string PlaceHolderText = "Masukkan teks disini...";

        public InputBarang()
        {
            InitializeComponent();

            SetPlaceholder();

            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == PlaceholderText)
            {
                textBox3.Text = " ";
                textBox3.ForeColor = SystemColors.WindowText;
            }

        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void SetPlaceHolder()
        {
            textBox3.Text = PlaceholderText;
            textBox3.ForeColor = SystemColors.GrayText;
        }

        private void InputBarang_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBarang barang = new EditBarang();

            barang.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel(textBox3.Text.Length);
        }
    }
}
