using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPR321Project
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnUserInterface_Click(object sender, EventArgs e)
        {
            Arm_Controller ui = new Arm_Controller();
            ui.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
