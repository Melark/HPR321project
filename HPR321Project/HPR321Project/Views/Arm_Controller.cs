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
using DataAccess.FileHandler;
using MetroFramework;

namespace HPR321Project.Views
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
        //Commands_List cl;

        string currentDataTempStorage = "";
        volatile bool IsCarrageReturnReceived = false;
        volatile bool RecordProgram = false;
        List<string> ListOfRecordedCommands = new List<string>(); // store commands recorded by the user
        List<string> ListOfCommands = new List<string>(); //stores all commands run by the user
        List<string> FinalProgramCommands = new List<string>();// stores formatted final program to be executed.
        List<string> FinalProgramTempF = new List<string>(); // Foward Move Temporary Store
        List<string> FInalProgramTempR = new List<string>(); // reverse move Temporay Store
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
                    MetroMessageBox.Show(this,"Connected to port: " + sp.PortName, "Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    lstCommands.Items.Add("Connected : " + sp.PortName);
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
                    lstCommands.Items.Add(currentDataTempStorage.ToString());

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

        /// <summary>
        /// Sets all available com ports that the user can use
        /// </summary>
        public void CheckConnectedDevices()
        {
            try
            {
                // Get all found ports from system
                string[] ports = SerialPort.GetPortNames();

                // Clear the combo box list
                cmbPorts.Items.Clear();
                // For all com ports found
                foreach (var item in ports)
                {
                    // Add com port to list
                    cmbPorts.Items.Add(item);
                }

                #region Auto select port

                // If there is only one com port available, automatically use it
                if (ports.Length == 1)
                {
                    cmbPorts.SelectedIndex = 0;
                }

                #endregion
            }
            catch (Exception ex)
            {
                // Display an error messaage
                DisplayErrorMessage(ex.Message, "Checking Connected Devices");
            }
        }

        private void BackToMenu()
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        /// <summary>
        /// Display an error message
        /// </summary>
        /// <param name="ErrorMessage">Error message for the error</param>
        /// <param name="MethodName">Method where the error occured</param>
        private void DisplayErrorMessage(string ErrorMessage, string MethodName)
        {
            // Allows for the method to be executed from different threads
            Invoke(new Action(() =>
            {
                // Show a MessageBoxDialog
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckConnectedDevices();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (FinalProgramCommands.Count < 1)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                string filepath = openFile.FileName.ToString();
                if (string.IsNullOrEmpty(filepath))
                {
                    MetroMessageBox.Show(this, "No File Chosen.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<string> data = FileHandler.ReadProgramFromFile(filepath);
                    if (data.Count < 1)
                    {
                        MessageBox.Show("Selected File is Empty.");
                    }
                    else
                    {
                        FinalProgramCommands = null;
                        FinalProgramCommands = data; // new program stored on the textfile
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "This action will completely clear the program already saved", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // read data from the textfile
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (FinalProgramCommands.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Create A File To Save Data Into";
                string filepath = "";
                saveFile.ShowDialog();
                filepath = saveFile.FileName;
                if (string.IsNullOrEmpty(filepath))
                {
                    MetroMessageBox.Show(this, "Oops! , Please Creat a file first?","Error Occured", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
                else
                {
                    FileHandler.WriteProgramToFile(filepath, FinalProgramCommands);
                }

            }
            else
            {
                MetroMessageBox.Show(this,"Oops! , Nothing was Recorded.","Error Occured",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            lstCommands.Items.Clear();
           
        }

        //private void btnCommands_Click(object sender, EventArgs e)
        //{
        //    // open Full Command View
        //    List<string> lscmd = new List<string>();
        //    foreach (var item in lstCommands.Items)
        //    {
        //        lscmd.Add(item.ToString());
        //    }
        //    cl = new Commands_List(lscmd);
        //    cl.Show();
        //    this.Hide();

        //}

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            RecordProgram = true;// allow recording of the program
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("@RESET \r");
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            txtCurrentCommand.Text = " ";
            if (sp.IsOpen)
            {
                sp.Write("@READ \r");
            }
        }
        public void ResetNumericUpDowns()
        {
            numArm.Value = 0;
            numBody.Value = 0;
            numGripperCloseOpen.Value = 0;
            numGripperRotate.Value = 0;
            numGripperUpDown.Value = 0;
            numShoulder.Value = 0;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            mtxbSend.Text = "@STEP " + MovementSpeed + "," + numBody.Value + "," + numShoulder.Value + "," + numArm.Value + "," + numGripperUpDown.Value + "," + numGripperRotate.Value + "," + numGripperCloseOpen.Value + ",\r";
            if (sp.IsOpen)
            {
                sp.Write(mtxbSend.Text);
            }
            ResetNumericUpDowns();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            txtCurrentCommand.Text = " ";
            if (sp.IsOpen)
            {
                sp.Write("@READ \r");
            }
        }

        private void btnStopData_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("@STOP \r");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //pBar.Value = 0;
            // add Steps to the Commmand
            string line = "";
            if (sp.IsOpen)
            {
                for (int i = 0; i < ListOfRecordedCommands.Count - 1; i++)
                {
                    line = mtbbTeachMoverDetails.Text + "STEP " + MovementSpeed + "" + CoordsCalculator(ListOfRecordedCommands[i + 1], ListOfRecordedCommands[i]).Replace("/r", "").Replace("\r", "") + "\r";
                    FinalProgramCommands.Add(line);// add final code to the machine
                }
                backRunCode.RunWorkerAsync();
            }
        }

        private void btnInitialPosition_Click(object sender, EventArgs e)
        {
            if (!backRunCode.IsBusy)
            {
                if (sp.IsOpen)
                {                                                                                                                                                                                                                                                                                                                                               
                    FinalProgramTempF = FinalProgramCommands;
                    CalclateReverseProgram();
                    backRunCode.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("System is Still Executing the Steps..");
            }
        }

        public void CalclateReverseProgram()
        {
            foreach (string cmd in FinalProgramCommands)
            {
                string[] commandSub = cmd.Split(',');
                string finalcommandX = "";

                for (int i = 0; i < 8; i++)
                {
                    if (i > 1 && i < 8)
                    {
                        double current = double.Parse(commandSub[i]);
                        if (current > 0)
                        {
                            current *= -1;
                            finalcommandX = "," + current.ToString();

                        }
                        if (current > 0)
                        {
                            current *= -1;
                            finalcommandX = "," + current.ToString();
                        }

                    }
                    else
                    {
                        finalcommandX = commandSub[i];
                    }

                }
                FInalProgramTempR.Add(cmd);
            }
            FInalProgramTempR.Reverse();
            FinalProgramCommands = FInalProgramTempR;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("@RESET \r");
            }
        }

        public string CoordsCalculator(string current, string previous)
        {
            if (current.Split(',')[0].Contains("\r"))
            {
                current = current.Remove(0, 1);
            }

            if (previous.Split(',')[0].Contains("\r"))
            {
                previous = previous.Remove(0, 1);
            }

            string currentBackSPlit = current.Replace("\r", "").Replace("/r", "");
            string previousBackSplit = previous.Replace("\r", "").Replace("/r", "");
            string line = "";
            string[] currentArr = currentBackSPlit.Split(',');
            string[] previousArr = previousBackSplit.Split(',');

            double[] data = new double[currentArr.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = double.Parse(currentArr[i]) - double.Parse(previousArr[i]);
                line += "," + data[i];
            }
            return line;
        }

        private void btnThickorThin_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(mtbbTeachMoverDetails.Text + "STEP" + MovementSpeed + "," + "240,1,-100,1,1,1,500,\r");
                sp.Write(mtbbTeachMoverDetails.Text + "CLOSE" + MovementSpeed + "," + "0,0,0,0,0,-100,0,\r");
                sp.Write(mtbbTeachMoverDetails.Text + "RESET \r");
                sp.Write(mtbbTeachMoverDetails.Text + "STEP" + MovementSpeed + "," + "240,0,0,0,0,0,1113-500,\r");
                sp.Write(mtbbTeachMoverDetails.Text + "CLOSE" + MovementSpeed + "," + "240,0,0,0,0,0,0,\r");
                sp.Write(mtbbTeachMoverDetails + "READ \r");
                double th;
                double jaw = 613;
                sp.Write(mtbbTeachMoverDetails + "READ" + MovementSpeed + "," + "0,0,0,0,0,0,613,0,\r");
                th = jaw / 371;
                if(th<0.015)
                {
                    MetroMessageBox.Show(this, "Thickness is: " ,th.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MetroMessageBox.Show(this, "Thinness is: ", th.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
