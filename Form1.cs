using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacuumCleanerWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        
        private string startRoom;
        private Dictionary<string, int> roomState = new Dictionary<string, int>(2);

        private void Setup()
        {
            //goalstate a=0,b=0
            //Dictionary<string, int> roomState = new Dictionary<string, int>(2);
            // start clean status with value 0, add 1 for dirty status
            roomState.Add("a", 0);
            roomState.Add("b", 0);
        }

        private async Task RunMain()
        {
            string actionRight = "\nMoving right.";
            string actionLeft = "\nMoving left.";
            string actionSuck = "\nRoom is dirty so sucking up stuff.";
            string clean = "\nThe room is clean.";
            string roomA = "\n\nIn room a";
            string roomB = "\n\nIn room b";
            
            //keep track of loops till both rooms are clean include check run
            int countCleanRooms = 0;
            //clears text from rich text box from previous run
            Rtbx_ActionTextDisplay.Clear();
            TextBox = "Starting cleaning process..";
            //clean and dirty split repeat for extra lop to check all clean. 
            while (countCleanRooms < 2)
            {
                foreach (KeyValuePair<string, int> rstate in roomState.ToList())
                {
                    //TextBox = "\nstartRoom is now "+ startRoom; //check print
                    //if foreach iteration is start room and is dirty
                    if (rstate.Key.Contains(startRoom.ToString()) && rstate.Value == 1)
                    {
                        //TextBox = "\nEntering dirty loop";
                        if (startRoom.Equals("a"))
                        {
                            TextBox = roomA + actionSuck + clean + actionRight; //action
                            roomState[startRoom.ToString()] = 0; //change value to 0 (clean)
                            Pbx_ADirty.Visible = false;
                            startRoom = "b"; //moving to next room
                            await Task.Delay(100);
                            Pbx_AVacuum.Visible = false;
                            Pbx_BVacuum.Visible = true;
                        }
                        else
                        {
                            TextBox = roomB + actionSuck + clean + actionLeft; //action
                            roomState[startRoom.ToString()] = 0; //change value to 0 (clean)
                            Pbx_BDirty.Visible = false;
                            startRoom = "a"; //moving to next room
                            await Task.Delay(100);
                            Pbx_AVacuum.Visible = true;
                            Pbx_BVacuum.Visible = false;
                        }
                    }
                    //if foreach iteration is start room and is clean
                    if (rstate.Key.Contains(startRoom.ToString()) && rstate.Value == 0)
                    {
                        //TextBox = "\nEntering clean loop";
                        if (startRoom.Equals("b"))
                        {
                            TextBox = roomB + clean + actionLeft; //action
                            startRoom = "a"; //moving to next room
                            await Task.Delay(100);
                            Pbx_AVacuum.Visible = true;
                            Pbx_BVacuum.Visible = false;
                        }
                        else
                        {
                            TextBox = roomA + clean + actionRight; //action
                            startRoom = "b"; //moving to next room
                            await Task.Delay(100);
                            Pbx_AVacuum.Visible = false;
                            Pbx_BVacuum.Visible = true;
                        }
                        countCleanRooms++;
                    }
                    //wait
                    await Task.Delay(1700);
                }
            }
            TextBox = "\nRooms are now cleaned.";
       }

        private void ResetVacPosition()
        {
            Pbx_AVacuum.Visible = false;
            Pbx_BVacuum.Visible = false;
        }
        private void Cmbx_VacuumPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetVacPosition();
            // Getting room to put vacuum in
            startRoom = VacPosition;
            if (startRoom == "a")
                Pbx_AVacuum.Visible = true;
            else
                Pbx_BVacuum.Visible = true;
        }

        private void ResetDirtyRoom()
        {
            Pbx_ADirty.Visible = false;
            Pbx_BDirty.Visible = false;
        }

        private void Cmbx_DirtyRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDirtyRoom();
            // Getting the rooms to be cleaned to assign visibility status and dictionary value
            var roomDirty = DirtyRoom;
            if (roomDirty == "a")
            {
                roomState["a"] = 1;
                Pbx_ADirty.Visible = true;
            }
            if (roomDirty == "b")
            {
                roomState["b"] = 1;
                Pbx_BDirty.Visible = true;
            }
            if (roomDirty == "ab")
            {
                roomState["a"] = 1;
                roomState["b"] = 1;
                Pbx_ADirty.Visible = true;
                Pbx_BDirty.Visible = true;
            }
        }

        private void Btn_RunWF_Click(object sender, EventArgs e)
        {
            RunMain();
        }

        private void Btn_RunConsole_Click(object sender, EventArgs e)
        {
            //VCConsole program = new VCConsole();
            //program.MainConsole(new string[] { "One", "Two" });
            MessageBox.Show("Nope, not happening yet :( ");
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string TextBox
        {
            get { return Rtbx_ActionTextDisplay.Text; }
            set { Rtbx_ActionTextDisplay.AppendText(value); }
        }
        public string VacPosition
        {
            get { return Cmbx_VacuumPosition.SelectedItem.ToString(); }
            set { Cmbx_VacuumPosition.SelectedItem = value.ToString(); }
        }
        public string DirtyRoom
        {
            get { return Cmbx_DirtyRoom.SelectedItem.ToString(); }
            set { Cmbx_DirtyRoom.SelectedItem = value.ToString(); }        
        }
        public Image AVacuum
        {
            get { return Pbx_AVacuum.Image; }
            set { Pbx_AVacuum.Image = value; }
        }
        public Image BVacuum
        {
            get { return Pbx_BVacuum.Image; }
            set { Pbx_BVacuum.Image = value; }
        }
        public Image ADirty
        {
            get { return Pbx_ADirty.Image; }
            set { Pbx_ADirty.Image = value; }
        }
        public Image BDirty
        {
            get { return Pbx_BDirty.Image; }
            set { Pbx_BDirty.Image = value; }
        }

        
    }
}
