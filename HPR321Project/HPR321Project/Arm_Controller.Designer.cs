namespace HPR321Project
{
    partial class Arm_Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arm_Controller));
            this.mtbArmControllerTabs = new MetroFramework.Controls.MetroTabControl();
            this.mtbppUserInterface = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SpeedSlider = new MetroFramework.Controls.MetroTrackBar();
            this.pnArm = new System.Windows.Forms.Panel();
            this.mtbArmCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.btnArmDown = new System.Windows.Forms.Button();
            this.lblArm = new System.Windows.Forms.Label();
            this.btnArmUp = new System.Windows.Forms.Button();
            this.pnShoulder = new System.Windows.Forms.Panel();
            this.mtbxtShoulderCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.btnShoulderDown = new System.Windows.Forms.Button();
            this.lblShoulder = new System.Windows.Forms.Label();
            this.btnShoulderUp = new System.Windows.Forms.Button();
            this.pnGripRotate = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.lblGriprotate = new System.Windows.Forms.Label();
            this.btnGripRotateLeft = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.mtbBodyCo_ordinates = new MetroFramework.Controls.MetroTextBox();
            this.btnBodyRight = new System.Windows.Forms.Button();
            this.btnBody = new System.Windows.Forms.Label();
            this.btnBodyLeft = new System.Windows.Forms.Button();
            this.pnGripOpenClose = new System.Windows.Forms.Panel();
            this.mtbGripCoordinatesOpenClose = new MetroFramework.Controls.MetroTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblGripOpenClose = new System.Windows.Forms.Label();
            this.btnGripClose = new System.Windows.Forms.Button();
            this.pnGrip = new System.Windows.Forms.Panel();
            this.mtbGripCoordinates = new MetroFramework.Controls.MetroTextBox();
            this.btnGrupDown = new System.Windows.Forms.Button();
            this.lblGrip = new System.Windows.Forms.Label();
            this.btnGripUp = new System.Windows.Forms.Button();
            this.mtbTeachMoverDetails = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentCommand = new MetroFramework.Controls.MetroTextBox();
            this.cmbPorts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtbbTeachMoverDetails = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.mtbArmControllerTabs.SuspendLayout();
            this.mtbppUserInterface.SuspendLayout();
            this.pnArm.SuspendLayout();
            this.pnShoulder.SuspendLayout();
            this.pnGripRotate.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnGripOpenClose.SuspendLayout();
            this.pnGrip.SuspendLayout();
            this.mtbTeachMoverDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbArmControllerTabs
            // 
            this.mtbArmControllerTabs.Controls.Add(this.mtbppUserInterface);
            this.mtbArmControllerTabs.Controls.Add(this.mtbTeachMoverDetails);
            this.mtbArmControllerTabs.Location = new System.Drawing.Point(17, 84);
            this.mtbArmControllerTabs.Margin = new System.Windows.Forms.Padding(2);
            this.mtbArmControllerTabs.Name = "mtbArmControllerTabs";
            this.mtbArmControllerTabs.SelectedIndex = 0;
            this.mtbArmControllerTabs.Size = new System.Drawing.Size(888, 413);
            this.mtbArmControllerTabs.TabIndex = 7;
            // 
            // mtbppUserInterface
            // 
            this.mtbppUserInterface.Controls.Add(this.label1);
            this.mtbppUserInterface.Controls.Add(this.metroLabel4);
            this.mtbppUserInterface.Controls.Add(this.metroLabel3);
            this.mtbppUserInterface.Controls.Add(this.SpeedSlider);
            this.mtbppUserInterface.Controls.Add(this.pnArm);
            this.mtbppUserInterface.Controls.Add(this.pnShoulder);
            this.mtbppUserInterface.Controls.Add(this.pnGripRotate);
            this.mtbppUserInterface.Controls.Add(this.pnBody);
            this.mtbppUserInterface.Controls.Add(this.pnGripOpenClose);
            this.mtbppUserInterface.Controls.Add(this.pnGrip);
            this.mtbppUserInterface.HorizontalScrollbarBarColor = true;
            this.mtbppUserInterface.HorizontalScrollbarSize = 8;
            this.mtbppUserInterface.Location = new System.Drawing.Point(4, 35);
            this.mtbppUserInterface.Margin = new System.Windows.Forms.Padding(2);
            this.mtbppUserInterface.Name = "mtbppUserInterface";
            this.mtbppUserInterface.Size = new System.Drawing.Size(880, 374);
            this.mtbppUserInterface.TabIndex = 0;
            this.mtbppUserInterface.Text = "User Interface";
            this.mtbppUserInterface.VerticalScrollbarBarColor = true;
            this.mtbppUserInterface.VerticalScrollbarSize = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Movement Speed";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(161, 51);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Slower";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(658, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Faster";
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.BackColor = System.Drawing.Color.Transparent;
            this.SpeedSlider.Location = new System.Drawing.Point(214, 47);
            this.SpeedSlider.Maximum = 500;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpeedSlider.Size = new System.Drawing.Size(438, 23);
            this.SpeedSlider.TabIndex = 15;
            this.SpeedSlider.Text = "SpeedSlider";
            this.SpeedSlider.ValueChanged += new System.EventHandler(this.SpeedSlider_ValueChanged);
            // 
            // pnArm
            // 
            this.pnArm.BackColor = System.Drawing.Color.DimGray;
            this.pnArm.Controls.Add(this.mtbArmCoordinates);
            this.pnArm.Controls.Add(this.btnArmDown);
            this.pnArm.Controls.Add(this.lblArm);
            this.pnArm.Controls.Add(this.btnArmUp);
            this.pnArm.Location = new System.Drawing.Point(2, 279);
            this.pnArm.Margin = new System.Windows.Forms.Padding(2);
            this.pnArm.Name = "pnArm";
            this.pnArm.Size = new System.Drawing.Size(401, 79);
            this.pnArm.TabIndex = 12;
            // 
            // mtbArmCoordinates
            // 
            this.mtbArmCoordinates.Location = new System.Drawing.Point(154, 43);
            this.mtbArmCoordinates.Margin = new System.Windows.Forms.Padding(2);
            this.mtbArmCoordinates.Name = "mtbArmCoordinates";
            this.mtbArmCoordinates.Size = new System.Drawing.Size(87, 19);
            this.mtbArmCoordinates.TabIndex = 3;
            // 
            // btnArmDown
            // 
            this.btnArmDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArmDown.BackgroundImage")));
            this.btnArmDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArmDown.Location = new System.Drawing.Point(314, 11);
            this.btnArmDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnArmDown.Name = "btnArmDown";
            this.btnArmDown.Size = new System.Drawing.Size(68, 51);
            this.btnArmDown.TabIndex = 2;
            this.btnArmDown.UseVisualStyleBackColor = true;
            this.btnArmDown.Click += new System.EventHandler(this.btnArmDown_Click);
            // 
            // lblArm
            // 
            this.lblArm.AutoSize = true;
            this.lblArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArm.Location = new System.Drawing.Point(169, 0);
            this.lblArm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArm.Name = "lblArm";
            this.lblArm.Size = new System.Drawing.Size(72, 36);
            this.lblArm.TabIndex = 1;
            this.lblArm.Text = "Arm";
            // 
            // btnArmUp
            // 
            this.btnArmUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArmUp.BackgroundImage")));
            this.btnArmUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArmUp.Location = new System.Drawing.Point(17, 11);
            this.btnArmUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnArmUp.Name = "btnArmUp";
            this.btnArmUp.Size = new System.Drawing.Size(68, 51);
            this.btnArmUp.TabIndex = 0;
            this.btnArmUp.UseVisualStyleBackColor = true;
            this.btnArmUp.Click += new System.EventHandler(this.btnArmUp_Click);
            // 
            // pnShoulder
            // 
            this.pnShoulder.BackColor = System.Drawing.Color.DimGray;
            this.pnShoulder.Controls.Add(this.mtbxtShoulderCoordinates);
            this.pnShoulder.Controls.Add(this.btnShoulderDown);
            this.pnShoulder.Controls.Add(this.lblShoulder);
            this.pnShoulder.Controls.Add(this.btnShoulderUp);
            this.pnShoulder.Location = new System.Drawing.Point(2, 180);
            this.pnShoulder.Margin = new System.Windows.Forms.Padding(2);
            this.pnShoulder.Name = "pnShoulder";
            this.pnShoulder.Size = new System.Drawing.Size(401, 79);
            this.pnShoulder.TabIndex = 14;
            // 
            // mtbxtShoulderCoordinates
            // 
            this.mtbxtShoulderCoordinates.Location = new System.Drawing.Point(154, 49);
            this.mtbxtShoulderCoordinates.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxtShoulderCoordinates.Name = "mtbxtShoulderCoordinates";
            this.mtbxtShoulderCoordinates.Size = new System.Drawing.Size(87, 19);
            this.mtbxtShoulderCoordinates.TabIndex = 3;
            // 
            // btnShoulderDown
            // 
            this.btnShoulderDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShoulderDown.BackgroundImage")));
            this.btnShoulderDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoulderDown.Location = new System.Drawing.Point(314, 11);
            this.btnShoulderDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnShoulderDown.Name = "btnShoulderDown";
            this.btnShoulderDown.Size = new System.Drawing.Size(68, 51);
            this.btnShoulderDown.TabIndex = 2;
            this.btnShoulderDown.UseVisualStyleBackColor = true;
            this.btnShoulderDown.Click += new System.EventHandler(this.btnShoulderDown_Click);
            // 
            // lblShoulder
            // 
            this.lblShoulder.AutoSize = true;
            this.lblShoulder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoulder.Location = new System.Drawing.Point(131, 11);
            this.lblShoulder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShoulder.Name = "lblShoulder";
            this.lblShoulder.Size = new System.Drawing.Size(144, 36);
            this.lblShoulder.TabIndex = 1;
            this.lblShoulder.Text = "Shoulder";
            // 
            // btnShoulderUp
            // 
            this.btnShoulderUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShoulderUp.BackgroundImage")));
            this.btnShoulderUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoulderUp.Location = new System.Drawing.Point(17, 11);
            this.btnShoulderUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnShoulderUp.Name = "btnShoulderUp";
            this.btnShoulderUp.Size = new System.Drawing.Size(68, 51);
            this.btnShoulderUp.TabIndex = 0;
            this.btnShoulderUp.UseVisualStyleBackColor = true;
            this.btnShoulderUp.Click += new System.EventHandler(this.btnShoulderUp_Click);
            // 
            // pnGripRotate
            // 
            this.pnGripRotate.BackColor = System.Drawing.Color.DimGray;
            this.pnGripRotate.Controls.Add(this.metroTextBox1);
            this.pnGripRotate.Controls.Add(this.btnRotateRight);
            this.pnGripRotate.Controls.Add(this.lblGriprotate);
            this.pnGripRotate.Controls.Add(this.btnGripRotateLeft);
            this.pnGripRotate.Location = new System.Drawing.Point(452, 279);
            this.pnGripRotate.Margin = new System.Windows.Forms.Padding(2);
            this.pnGripRotate.Name = "pnGripRotate";
            this.pnGripRotate.Size = new System.Drawing.Size(401, 79);
            this.pnGripRotate.TabIndex = 12;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(154, 43);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(87, 19);
            this.metroTextBox1.TabIndex = 3;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateRight.BackgroundImage")));
            this.btnRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateRight.Location = new System.Drawing.Point(310, 11);
            this.btnRotateRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(68, 51);
            this.btnRotateRight.TabIndex = 2;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // lblGriprotate
            // 
            this.lblGriprotate.AutoSize = true;
            this.lblGriprotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGriprotate.Location = new System.Drawing.Point(165, 0);
            this.lblGriprotate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGriprotate.Name = "lblGriprotate";
            this.lblGriprotate.Size = new System.Drawing.Size(76, 36);
            this.lblGriprotate.TabIndex = 1;
            this.lblGriprotate.Text = "Grip";
            // 
            // btnGripRotateLeft
            // 
            this.btnGripRotateLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGripRotateLeft.BackgroundImage")));
            this.btnGripRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGripRotateLeft.Location = new System.Drawing.Point(17, 11);
            this.btnGripRotateLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnGripRotateLeft.Name = "btnGripRotateLeft";
            this.btnGripRotateLeft.Size = new System.Drawing.Size(68, 51);
            this.btnGripRotateLeft.TabIndex = 0;
            this.btnGripRotateLeft.UseVisualStyleBackColor = true;
            this.btnGripRotateLeft.Click += new System.EventHandler(this.btnGripRotateLeft_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.DimGray;
            this.pnBody.Controls.Add(this.mtbBodyCo_ordinates);
            this.pnBody.Controls.Add(this.btnBodyRight);
            this.pnBody.Controls.Add(this.btnBody);
            this.pnBody.Controls.Add(this.btnBodyLeft);
            this.pnBody.Location = new System.Drawing.Point(2, 79);
            this.pnBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(401, 79);
            this.pnBody.TabIndex = 13;
            // 
            // mtbBodyCo_ordinates
            // 
            this.mtbBodyCo_ordinates.Location = new System.Drawing.Point(154, 36);
            this.mtbBodyCo_ordinates.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBodyCo_ordinates.Name = "mtbBodyCo_ordinates";
            this.mtbBodyCo_ordinates.Size = new System.Drawing.Size(87, 19);
            this.mtbBodyCo_ordinates.TabIndex = 3;
            // 
            // btnBodyRight
            // 
            this.btnBodyRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBodyRight.BackgroundImage")));
            this.btnBodyRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBodyRight.Location = new System.Drawing.Point(314, 11);
            this.btnBodyRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnBodyRight.Name = "btnBodyRight";
            this.btnBodyRight.Size = new System.Drawing.Size(68, 51);
            this.btnBodyRight.TabIndex = 2;
            this.btnBodyRight.UseVisualStyleBackColor = true;
            this.btnBodyRight.Click += new System.EventHandler(this.btnBodyRight_Click);
            // 
            // btnBody
            // 
            this.btnBody.AutoSize = true;
            this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBody.Location = new System.Drawing.Point(153, -2);
            this.btnBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnBody.Name = "btnBody";
            this.btnBody.Size = new System.Drawing.Size(88, 36);
            this.btnBody.TabIndex = 1;
            this.btnBody.Text = "Body";
            // 
            // btnBodyLeft
            // 
            this.btnBodyLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBodyLeft.BackgroundImage")));
            this.btnBodyLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBodyLeft.Location = new System.Drawing.Point(17, 11);
            this.btnBodyLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnBodyLeft.Name = "btnBodyLeft";
            this.btnBodyLeft.Size = new System.Drawing.Size(68, 51);
            this.btnBodyLeft.TabIndex = 0;
            this.btnBodyLeft.UseVisualStyleBackColor = true;
            this.btnBodyLeft.Click += new System.EventHandler(this.btnBodyLeft_Click);
            // 
            // pnGripOpenClose
            // 
            this.pnGripOpenClose.BackColor = System.Drawing.Color.DimGray;
            this.pnGripOpenClose.Controls.Add(this.mtbGripCoordinatesOpenClose);
            this.pnGripOpenClose.Controls.Add(this.btnOpen);
            this.pnGripOpenClose.Controls.Add(this.lblGripOpenClose);
            this.pnGripOpenClose.Controls.Add(this.btnGripClose);
            this.pnGripOpenClose.Location = new System.Drawing.Point(452, 180);
            this.pnGripOpenClose.Margin = new System.Windows.Forms.Padding(2);
            this.pnGripOpenClose.Name = "pnGripOpenClose";
            this.pnGripOpenClose.Size = new System.Drawing.Size(401, 79);
            this.pnGripOpenClose.TabIndex = 10;
            // 
            // mtbGripCoordinatesOpenClose
            // 
            this.mtbGripCoordinatesOpenClose.Location = new System.Drawing.Point(154, 58);
            this.mtbGripCoordinatesOpenClose.Margin = new System.Windows.Forms.Padding(2);
            this.mtbGripCoordinatesOpenClose.Name = "mtbGripCoordinatesOpenClose";
            this.mtbGripCoordinatesOpenClose.Size = new System.Drawing.Size(87, 19);
            this.mtbGripCoordinatesOpenClose.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(310, 11);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 51);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblGripOpenClose
            // 
            this.lblGripOpenClose.AutoSize = true;
            this.lblGripOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGripOpenClose.Location = new System.Drawing.Point(176, 11);
            this.lblGripOpenClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGripOpenClose.Name = "lblGripOpenClose";
            this.lblGripOpenClose.Size = new System.Drawing.Size(76, 36);
            this.lblGripOpenClose.TabIndex = 1;
            this.lblGripOpenClose.Text = "Grip";
            // 
            // btnGripClose
            // 
            this.btnGripClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGripClose.BackgroundImage")));
            this.btnGripClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGripClose.Location = new System.Drawing.Point(17, 11);
            this.btnGripClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnGripClose.Name = "btnGripClose";
            this.btnGripClose.Size = new System.Drawing.Size(68, 51);
            this.btnGripClose.TabIndex = 0;
            this.btnGripClose.UseVisualStyleBackColor = true;
            this.btnGripClose.Click += new System.EventHandler(this.btnGripClose_Click);
            // 
            // pnGrip
            // 
            this.pnGrip.BackColor = System.Drawing.Color.DimGray;
            this.pnGrip.Controls.Add(this.mtbGripCoordinates);
            this.pnGrip.Controls.Add(this.btnGrupDown);
            this.pnGrip.Controls.Add(this.lblGrip);
            this.pnGrip.Controls.Add(this.btnGripUp);
            this.pnGrip.Location = new System.Drawing.Point(452, 79);
            this.pnGrip.Margin = new System.Windows.Forms.Padding(2);
            this.pnGrip.Name = "pnGrip";
            this.pnGrip.Size = new System.Drawing.Size(401, 79);
            this.pnGrip.TabIndex = 8;
            // 
            // mtbGripCoordinates
            // 
            this.mtbGripCoordinates.Location = new System.Drawing.Point(154, 58);
            this.mtbGripCoordinates.Margin = new System.Windows.Forms.Padding(2);
            this.mtbGripCoordinates.Name = "mtbGripCoordinates";
            this.mtbGripCoordinates.Size = new System.Drawing.Size(87, 19);
            this.mtbGripCoordinates.TabIndex = 3;
            // 
            // btnGrupDown
            // 
            this.btnGrupDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrupDown.BackgroundImage")));
            this.btnGrupDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrupDown.Location = new System.Drawing.Point(310, 11);
            this.btnGrupDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrupDown.Name = "btnGrupDown";
            this.btnGrupDown.Size = new System.Drawing.Size(68, 51);
            this.btnGrupDown.TabIndex = 2;
            this.btnGrupDown.UseVisualStyleBackColor = true;
            this.btnGrupDown.Click += new System.EventHandler(this.btnGrupDown_Click);
            // 
            // lblGrip
            // 
            this.lblGrip.AutoSize = true;
            this.lblGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrip.Location = new System.Drawing.Point(176, 11);
            this.lblGrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrip.Name = "lblGrip";
            this.lblGrip.Size = new System.Drawing.Size(76, 36);
            this.lblGrip.TabIndex = 1;
            this.lblGrip.Text = "Grip";
            // 
            // btnGripUp
            // 
            this.btnGripUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGripUp.BackgroundImage")));
            this.btnGripUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGripUp.Location = new System.Drawing.Point(17, 11);
            this.btnGripUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnGripUp.Name = "btnGripUp";
            this.btnGripUp.Size = new System.Drawing.Size(68, 51);
            this.btnGripUp.TabIndex = 0;
            this.btnGripUp.UseVisualStyleBackColor = true;
            this.btnGripUp.Click += new System.EventHandler(this.btnGripUp_Click);
            // 
            // mtbTeachMoverDetails
            // 
            this.mtbTeachMoverDetails.Controls.Add(this.metroLabel5);
            this.mtbTeachMoverDetails.Controls.Add(this.txtCurrentCommand);
            this.mtbTeachMoverDetails.Controls.Add(this.cmbPorts);
            this.mtbTeachMoverDetails.Controls.Add(this.metroLabel2);
            this.mtbTeachMoverDetails.Controls.Add(this.metroLabel1);
            this.mtbTeachMoverDetails.Controls.Add(this.btnSave);
            this.mtbTeachMoverDetails.Controls.Add(this.mtbbTeachMoverDetails);
            this.mtbTeachMoverDetails.HorizontalScrollbarBarColor = true;
            this.mtbTeachMoverDetails.HorizontalScrollbarSize = 8;
            this.mtbTeachMoverDetails.Location = new System.Drawing.Point(4, 35);
            this.mtbTeachMoverDetails.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTeachMoverDetails.Name = "mtbTeachMoverDetails";
            this.mtbTeachMoverDetails.Size = new System.Drawing.Size(880, 374);
            this.mtbTeachMoverDetails.TabIndex = 1;
            this.mtbTeachMoverDetails.Text = "Teach Mover Details";
            this.mtbTeachMoverDetails.VerticalScrollbarBarColor = true;
            this.mtbTeachMoverDetails.VerticalScrollbarSize = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(445, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Current Coordinates";
            // 
            // txtCurrentCommand
            // 
            this.txtCurrentCommand.Location = new System.Drawing.Point(578, 21);
            this.txtCurrentCommand.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentCommand.Name = "txtCurrentCommand";
            this.txtCurrentCommand.Size = new System.Drawing.Size(198, 19);
            this.txtCurrentCommand.TabIndex = 12;
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.ItemHeight = 23;
            this.cmbPorts.Location = new System.Drawing.Point(142, 44);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(198, 29);
            this.cmbPorts.TabIndex = 11;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Availible Ports";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(133, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Command Character";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(221, 91);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Connect";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtbbTeachMoverDetails
            // 
            this.mtbbTeachMoverDetails.Location = new System.Drawing.Point(142, 21);
            this.mtbbTeachMoverDetails.Margin = new System.Windows.Forms.Padding(2);
            this.mtbbTeachMoverDetails.Name = "mtbbTeachMoverDetails";
            this.mtbbTeachMoverDetails.Size = new System.Drawing.Size(198, 19);
            this.mtbbTeachMoverDetails.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(783, 22);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 47);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Arm_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 515);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mtbArmControllerTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Arm_Controller";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Arm Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arm_Controller_FormClosed);
            this.Load += new System.EventHandler(this.Arm_Controller_Load);
            this.mtbArmControllerTabs.ResumeLayout(false);
            this.mtbppUserInterface.ResumeLayout(false);
            this.mtbppUserInterface.PerformLayout();
            this.pnArm.ResumeLayout(false);
            this.pnArm.PerformLayout();
            this.pnShoulder.ResumeLayout(false);
            this.pnShoulder.PerformLayout();
            this.pnGripRotate.ResumeLayout(false);
            this.pnGripRotate.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.pnGripOpenClose.ResumeLayout(false);
            this.pnGripOpenClose.PerformLayout();
            this.pnGrip.ResumeLayout(false);
            this.pnGrip.PerformLayout();
            this.mtbTeachMoverDetails.ResumeLayout(false);
            this.mtbTeachMoverDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl mtbArmControllerTabs;
        private MetroFramework.Controls.MetroTabPage mtbppUserInterface;
        private System.Windows.Forms.Panel pnArm;
        private MetroFramework.Controls.MetroTextBox mtbArmCoordinates;
        private System.Windows.Forms.Button btnArmDown;
        private System.Windows.Forms.Label lblArm;
        private System.Windows.Forms.Button btnArmUp;
        private System.Windows.Forms.Panel pnShoulder;
        private MetroFramework.Controls.MetroTextBox mtbxtShoulderCoordinates;
        private System.Windows.Forms.Button btnShoulderDown;
        private System.Windows.Forms.Label lblShoulder;
        private System.Windows.Forms.Button btnShoulderUp;
        private System.Windows.Forms.Panel pnGripRotate;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Label lblGriprotate;
        private System.Windows.Forms.Button btnGripRotateLeft;
        private System.Windows.Forms.Panel pnBody;
        private MetroFramework.Controls.MetroTextBox mtbBodyCo_ordinates;
        private System.Windows.Forms.Button btnBodyRight;
        private System.Windows.Forms.Label btnBody;
        private System.Windows.Forms.Button btnBodyLeft;
        private System.Windows.Forms.Panel pnGripOpenClose;
        private MetroFramework.Controls.MetroTextBox mtbGripCoordinatesOpenClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblGripOpenClose;
        private System.Windows.Forms.Button btnGripClose;
        private System.Windows.Forms.Panel pnGrip;
        private MetroFramework.Controls.MetroTextBox mtbGripCoordinates;
        private System.Windows.Forms.Button btnGrupDown;
        private System.Windows.Forms.Label lblGrip;
        private System.Windows.Forms.Button btnGripUp;
        private MetroFramework.Controls.MetroTabPage mtbTeachMoverDetails;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox mtbbTeachMoverDetails;
        private System.Windows.Forms.Button btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbPorts;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar SpeedSlider;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCurrentCommand;
    }
}