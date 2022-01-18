using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test"); // Form Yüklenme esnasında çalışacak kodlar
            textBox1.MaxLength = 250;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // Mause üzerine gelince Çalışacak
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // Mause üzerinden ayrılınca çalışacak
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = (250 - textBox1.TextLength).ToString();// TextBox a değer girdikçe çalışacak 
        }
    }
}
