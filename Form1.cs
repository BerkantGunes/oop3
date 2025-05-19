using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Butona tıkladığımda listbox ın altındaki textbox a yazdığım karakterler listbox a eklensin, listbox dan seçtiğim item  sağ taraftaki textbox da görüntülensin
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
        }
    }
}
