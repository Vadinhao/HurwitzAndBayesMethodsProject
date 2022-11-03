using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HurwitzAndBayesMethodsProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TabControlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMenu.SelectedTab == tabExit)
            {
                Application.Exit();
            }
            else if (TabControlMenu.SelectedTab == tabLogOut) {
                Title formTitle = new Title();
                formTitle.Show();
                this.Close();
            }
        }
    }
}
