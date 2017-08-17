using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPR321Project
{
    public class Controller
    {
        #region Fields

        private List<string> listCommands;
        private string currentCommand;
        private float bodyValue;
        private float shoulderValue;
        private float armValue;
        private float gripperG;
        private float gripperRotate;
        private float gripperU;

        #endregion

        #region Constructors

        public Controller()
        {

        }

        #endregion

        #region Properties

        public List<string> ListCommands
        {
            get { return listCommands; }
            set { listCommands = value; }
        }
        
        public string CurrentCommand
        {
            get { return currentCommand; }
            set { currentCommand = value; }
        }
        
        public float BodyValue
        {
            get { return bodyValue; }
            set { bodyValue = value; }
        }
        
        public float ShoulderValue
        {
            get { return shoulderValue; }
            set { shoulderValue = value; }
        }
        
        public float ArmValue
        {
            get { return armValue; }
            set { armValue = value; }
        }
        
        public float GripperG
        {
            get { return gripperG; }
            set { gripperG = value; }
        }
        
        public float GripperRotate
        {
            get { return gripperRotate; }
            set { gripperRotate = value; }
        }
        
        public float GripperU
        {
            get { return gripperU; }
            set { gripperU = value; }
        }

        #endregion

        #region Methods

        #endregion
    }
}
