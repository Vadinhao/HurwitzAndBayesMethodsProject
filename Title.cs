using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurwitzAndBayesMethodsProject
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void TitleExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleNextButton_Click(object sender, EventArgs e)
        {

        }

        private void TitleStartButton_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Hide();
        }
    }
}
