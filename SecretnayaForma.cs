using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface___igra
{
    public partial class SecretnayaForma : Form
    {
        public SecretnayaForma()
        {
            InitializeComponent();
            this.Width = 1024;
            this.Height = 768;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower() == "капи")
            {
                pictureBox1.Image = Properties.Resources.Kapi;
                textBox1.Hide();
            }
            else
            {
                pictureBox1.Image = null;
                textBox1.Show();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.Show();
        }

        
    }
}
