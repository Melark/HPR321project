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

        #region Fields

        private string MovementSpeed = "200"; //Default movement speed

        SerialPort sp = new SerialPort();

        string currentDataTempStorage = "";
        volatile bool IsCarrageReturnReceived = false;
        volatile bool RecordProgram = false;
        List<string> ListOfRecordedCommands = new List<string>(); // store commands recorded by the user
        List<string> ListOfCommands = new List<string>(); //stores all commands run by the user

        #endregion

        #region Constructors

        public Arm_Controller()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        #region Form

        private void Arm_Controller_Load(object sender, EventArgs e)
        {
            CheckConnectedDevices(); // checks connected devices on the serial port
        }

        private void Arm_Controller_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu();
        }

        #endregion

        #region Button Clicks

        #region Body

        private void btnBodyLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "100,0,0,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Body Left");
            }
        }

        private void btnBodyRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "-100,0,0,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Body Right");
            }
        }

        #endregion

        #region Shoulder

        private void btnShoulderUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,-100,0,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Shoulder Up");
            }
        }

        private void btnShoulderDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,100,0,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Shoulder Down");
            }
        }

        #endregion

        #region Arm

        private void btnArmUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,-100,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Arm Up");
            }
        }

        private void btnArmDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,100,0,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Arm Down");
            }
        }

        #endregion

        #region Grip

        private void btnGripUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,100,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Grip Up");
            }
        }

        private void btnGrupDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,-100,0,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Grip Down");
            }
        }

        private void btnGripClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,0,0,-100,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Closing Grip");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,0,0,100,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Opening Grip");
            }
        }

        private void btnGripRotateLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,0,-100,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Rotating Grip Left");
            }
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "," + "0,0,0,0,100,0,0,\r");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Rotating Grip Right");
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cmbPorts.SelectedItem.ToString();
                sp.BaudRate = 9600;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.DataReceived += sp_DataReceived;
                sp.ErrorReceived += sp_ErrorReceived;
                if (!sp.IsOpen)
                {
                    sp.Open();
                    sp.Write("@ARM " + mtbbTeachMoverDetails.Text + "\r");
                    MessageBox.Show("Connected to port: " + sp.PortName, "Success");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage("An error occured: " + ex.Message, "Saving");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToMenu();
        }

        #endregion

        private void sp_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error: Something Went Wrong " + e.ToString());
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(PortReader));
        }

        public void PortReader(object s, EventArgs e)
        {
            try
            {
                string currentdata = sp.ReadExisting();
                currentDataTempStorage += currentdata;
                if (currentDataTempStorage.EndsWith("\r"))
                {
                    IsCarrageReturnReceived = true;
                    // done
                    if (currentDataTempStorage.Length > 10)
                    {
                        if (RecordProgram)
                        {
                            ListOfRecordedCommands.Add("" + currentDataTempStorage.ToString());
                            // mybe write the program to file
                        }
                        ListOfCommands.Add(currentDataTempStorage.ToString());
                        txtCurrentCommand.Text = currentDataTempStorage; // display the current read move coordinates
                    }
                    // lstData.Items.Add(currentDataTempStorage.ToString());

                    currentDataTempStorage = ""; // reset to null value
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Port Reader");
            }
        }

        private void SpeedSlider_ValueChanged(object sender, EventArgs e)
        {
            MovementSpeed = SpeedSlider.Value.ToString();
        }

        #endregion

        #region Methods

        public void CheckConnectedDevices()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();

                cmbPorts.Items.Clear();
                foreach (var item in ports)
                {
                    cmbPorts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message, "Checking Connected Devices");
            }
        }

        private void BackToMenu()
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void DisplayErrorMessage(string ErrorMessage, string MethodName)
        {
            Invoke(new Action(() =>
            {
                MessageBox.Show("An Error has occured: " + ErrorMessage, "Error in " + MethodName);
            }));
        }

        #endregion
    }
}
