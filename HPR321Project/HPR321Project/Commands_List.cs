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
    public partial class Commands_List : MetroForm
    {
        List<string> cmd = new List<string>();
        public Commands_List(List<string> commands)
        {
            cmd = commands;
            InitializeComponent();
        }

        private void Commands_List_Load(object sender, EventArgs e)
        {
            foreach (var command in cmd)
            {
                lstCommands.Items.Add(command);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Arm_Controller ac = new Arm_Controller();
            ac.Show();
            this.Hide();
        }
    }
}
