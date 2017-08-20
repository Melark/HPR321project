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
using Timer = System.Timers.Timer;
using System.Timers;

namespace HPR321Project
{
    public partial class Arm_Controller : MetroForm
    {
        #region TimerFields
        private static Timer loopBodyRightTimer;
        private static Timer loopBodyLeftTimer;

        private static Timer loopShoulderUpTimer;
        private static Timer loopShoulderDownTimer;

        private static Timer loopArmDownTimer;
        private static Timer loopArmUpTimer;

        private static Timer loopGripMovementDownTimer;
        private static Timer loopGripMovementUpTimer;

        private static Timer loopGripCloseTimer;
        private static Timer loopGripOpenTimer;

        private static Timer loopGripPivotRightTimer;
        private static Timer loopGripPivotLeftTimer;
        #endregion

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
            SetTimers();
        }

        private void Arm_Controller_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu();
        }

        #endregion

        #region TimerEventMethods

        #region BodyTimerEvent

        private void LoopBodyRightEvent(Object source, ElapsedEventArgs e)
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

        private void LoopLeftRightEvent(Object source, ElapsedEventArgs e)
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

        #endregion

        #region ShoulderTimerEvent
        private void LoopShoulderDownEvent(Object source, ElapsedEventArgs e)
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

        private void LoopShoulderUpEvent(Object source, ElapsedEventArgs e)
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
        #endregion

        #region ArmTimerEvent
        private void LoopArmDownEvent(Object source, ElapsedEventArgs e)
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

        private void LoopArmUpEvent(Object source, ElapsedEventArgs e)
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
        #endregion

        #region GripMovementEventMethod
        private void LoopGripMovementDownEvent(Object source, ElapsedEventArgs e)
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

        private void LoopGripMovementUpEvent(Object source, ElapsedEventArgs e)
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
        #endregion

        #region GripClawEventMethod
        private void LoopGripCloseEvent(Object source, ElapsedEventArgs e)
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

        private void LoopGripOpenEvent(Object source, ElapsedEventArgs e)
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
        #endregion

        #region GripPivotEventMethod
        private void LoopGripPivotRightEvent(Object source, ElapsedEventArgs e)
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

        private void LoopGripPivotLeftEvent(Object source, ElapsedEventArgs e)
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
        #endregion

        #endregion

        #region Button Clicks

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

        private void SetTimers()
        {
            SetBodyTimer();
            SetShoulderTimer();
            SetArmTimer();
            SetGripMovementTimer();
            SetGripClawTimer();
            SetGripPivotTimer();
        }

        #region SetupTimerEvents

        private void SetBodyTimer()
        {
            loopBodyRightTimer = new Timer();
            loopBodyLeftTimer = new Timer();

            loopBodyRightTimer.Interval = 500;
            loopBodyLeftTimer.Interval = 500;

            loopBodyRightTimer.Enabled = false;
            loopBodyLeftTimer.Enabled = false;

            loopBodyRightTimer.Elapsed += LoopBodyRightEvent;
            loopBodyLeftTimer.Elapsed += LoopLeftRightEvent;

            loopBodyRightTimer.AutoReset = true;
            loopBodyLeftTimer.AutoReset = true;
        }

        private void SetShoulderTimer()
        {
            loopShoulderUpTimer = new Timer();
            loopShoulderDownTimer = new Timer();

            loopShoulderUpTimer.Interval = 500;
            loopShoulderDownTimer.Interval = 500;

            loopShoulderUpTimer.Enabled = false;
            loopShoulderDownTimer.Enabled = false;

            loopShoulderUpTimer.Elapsed += LoopShoulderUpEvent;
            loopShoulderDownTimer.Elapsed += LoopShoulderDownEvent;

            loopShoulderUpTimer.AutoReset = true;
            loopShoulderDownTimer.AutoReset = true;
        }

        private void SetArmTimer()
        {
            loopArmDownTimer = new Timer();
            loopArmUpTimer = new Timer();

            loopArmDownTimer.Interval = 500;
            loopArmUpTimer.Interval = 500;

            loopArmDownTimer.Enabled = false;
            loopArmUpTimer.Enabled = false;

            loopArmDownTimer.Elapsed += LoopArmDownEvent;
            loopArmUpTimer.Elapsed += LoopArmUpEvent;

            loopArmDownTimer.AutoReset = true;
            loopArmUpTimer.AutoReset = true;
        }

        private void SetGripMovementTimer()
        {
            loopGripMovementDownTimer = new Timer();
            loopGripMovementUpTimer = new Timer();

            loopGripMovementDownTimer.Interval = 500;
            loopGripMovementUpTimer.Interval = 500;

            loopGripMovementDownTimer.Enabled = false;
            loopGripMovementUpTimer.Enabled = false;

            loopGripMovementDownTimer.Elapsed += LoopGripMovementDownEvent;
            loopGripMovementUpTimer.Elapsed += LoopGripMovementUpEvent;

            loopGripMovementDownTimer.AutoReset = true;
            loopGripMovementUpTimer.AutoReset = true;
        }

        private void SetGripClawTimer()
        {
            loopGripCloseTimer = new Timer();
            loopGripOpenTimer = new Timer();

            loopGripCloseTimer.Interval = 500;
            loopGripOpenTimer.Interval = 500;

            loopGripCloseTimer.Enabled = false;
            loopGripOpenTimer.Enabled = false;

            loopGripCloseTimer.Elapsed += LoopGripCloseEvent;
            loopGripOpenTimer.Elapsed += LoopGripOpenEvent;

            loopGripCloseTimer.AutoReset = true;
            loopGripOpenTimer.AutoReset = true;
        }

        private void SetGripPivotTimer()
        {
            loopGripPivotRightTimer = new Timer();
            loopGripPivotLeftTimer = new Timer();

            loopGripPivotRightTimer.Interval = 500;
            loopGripPivotLeftTimer.Interval = 500;

            loopGripPivotRightTimer.Enabled = false;
            loopGripPivotLeftTimer.Enabled = false;

            loopGripPivotRightTimer.Elapsed += LoopGripPivotRightEvent;
            loopGripPivotLeftTimer.Elapsed += LoopGripPivotLeftEvent;

            loopGripPivotRightTimer.AutoReset = true;
            loopGripPivotLeftTimer.AutoReset = true;
        }

        #endregion

        #endregion

        #region ButtonDownEvents

        #region Body
        private void btnBodyRight_MouseDown(object sender, MouseEventArgs e)
        {
            loopBodyRightTimer.Enabled = true;
        }

        private void btnBodyRight_MouseUp(object sender, MouseEventArgs e)
        {
            loopBodyRightTimer.Enabled = false;
        }

        private void btnBodyLeft_MouseDown(object sender, MouseEventArgs e)
        {
            loopBodyLeftTimer.Enabled = true;
        }

        private void btnBodyLeft_MouseUp(object sender, MouseEventArgs e)
        {
            loopBodyLeftTimer.Enabled = false;
        }
        #endregion

        #region Shoulder
        private void btnShoulderDown_MouseDown(object sender, MouseEventArgs e)
        {
            loopShoulderDownTimer.Enabled = true;
        }

        private void btnShoulderDown_MouseUp(object sender, MouseEventArgs e)
        {
            loopShoulderDownTimer.Enabled = false;
        }

        private void btnShoulderUp_MouseDown(object sender, MouseEventArgs e)
        {
            loopShoulderUpTimer.Enabled = true;
        }

        private void btnShoulderUp_MouseUp(object sender, MouseEventArgs e)
        {
            loopShoulderUpTimer.Enabled = false;
        }

        #endregion

        #region Arm
        private void btnArmDown_MouseDown(object sender, MouseEventArgs e)
        {
            loopArmDownTimer.Enabled = true;
        }

        private void btnArmDown_MouseUp(object sender, MouseEventArgs e)
        {
            loopArmDownTimer.Enabled = false;
        }

        private void btnArmUp_MouseDown(object sender, MouseEventArgs e)
        {
            loopArmUpTimer.Enabled = true;
        }

        private void btnArmUp_MouseUp(object sender, MouseEventArgs e)
        {
            loopArmUpTimer.Enabled = false;
        }

        #endregion

        #region Grip
        private void btnGrupDown_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripMovementDownTimer.Enabled = true;
        }

        private void btnGrupDown_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripMovementDownTimer.Enabled = false;
        }

        private void btnGripUp_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripMovementUpTimer.Enabled = true;
        }

        private void btnGripUp_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripMovementUpTimer.Enabled = false;
        }

        private void btnOpen_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripOpenTimer.Enabled = true;
        }

        private void btnOpen_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripOpenTimer.Enabled = false;
        }

        private void btnGripClose_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripCloseTimer.Enabled = true;
        }

        private void btnGripClose_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripCloseTimer.Enabled = false;
        }

        private void btnRotateRight_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripPivotRightTimer.Enabled = true;
        }

        private void btnRotateRight_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripPivotRightTimer.Enabled = false;
        }

        private void btnGripRotateLeft_MouseDown(object sender, MouseEventArgs e)
        {
            loopGripPivotLeftTimer.Enabled = true;
        }

        private void btnGripRotateLeft_MouseUp(object sender, MouseEventArgs e)
        {
            loopGripPivotLeftTimer.Enabled = false;
        }

        #endregion

        #endregion
    }
}
