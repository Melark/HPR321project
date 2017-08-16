using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPR321Project
{
    public partial class Arm_Controller : MetroForm
    {
        public Arm_Controller()
        {
            InitializeComponent();
        }

        private void Arm_Controller_Load(object sender, EventArgs e)
        {

        }

        SerialPort sp = new SerialPort();

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("@ARM " + mtbbTeachMoverDetails.Text + "\r");
            }
        }

        private void btnBodyLeft_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "100,0,0,0,0,0,0,\r");
            }
        }

        private void btnBodyRight_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "-100,0,0,0,0,0,0,\r");
            }
        }

        private void btnShoulderUp_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,-100,0,0,0,0,0,\r");
            }
        }

        private void btnShoulderDown_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,100,0,0,0,0,0,\r");
            }
        }

        private void btnArmUp_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,-100,0,0,0,0,\r");
            }
        }

        private void btnArmDown_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,100,0,0,0,0,\r");
            }
        }

        private void btnGripUp_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,100,0,0,0,\r");
            }
        }

        private void btnGrupDown_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,-100,0,0,0,\r");
            }
        }

        private void btnGripClose_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,0,-100,0,\r");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,0,100,0,\r");
            }
        }

        private void btnGripRotateLeft_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,-100,0,0,\r");
            }
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,100,0,0,\r");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
