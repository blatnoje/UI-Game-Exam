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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            this.Width = 800;
            this.Height = 600;
        }

        private void CloseAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }
        
        private void playButton1_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.Show();
        }
        private void helpButton2_Click(object sender, EventArgs e)
        {
            HelpForm helpForm= new HelpForm();
            this.Hide();
            helpForm.Show();
        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            CloseAllForms();
        }

        private void SecretCodeButton_Click(object sender, EventArgs e)
        {
            SecretnayaForma secrForm = new SecretnayaForma();
            this.Hide();
            secrForm.Show();
        }

        private void SecretCodeButton_MouseEnter(object sender, EventArgs e)
        {
            SecretCodeButton.BackColor = Color.Red;
            SecretCodeButton.ForeColor = Color.White;
            SecretCodeButton.Font = new Font(SecretCodeButton.Font, FontStyle.Bold);
        }

        private void SecretCodeButton_MouseLeave(object sender, EventArgs e)
        {
            SecretCodeButton.BackColor = Color.FromArgb(35, 187, 115);
            SecretCodeButton.Font = new Font(SecretCodeButton.Font, FontStyle.Regular);
            SecretCodeButton.ForeColor = Color.Black;
        }
    }
}
