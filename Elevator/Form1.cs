using Elevator.Controller;
using Elevator.Model;
using LanguageExt;
using LanguageExt.ClassInstances;
using System;
using System.Collections;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using Windows.UI.Xaml.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Elevator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int x_doorL_close = 120;
        int x_doorL_open = 20;

        int y_liftDown = 540;
        int y_liftUp = 85;

        bool moving_up = false;
        bool moving_down = false;
        bool result;
        DateTime dateTime = DateTime.Now;

        String LiftStatus = "GroundFloor";



        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();

        }
        public void loadcomponent() => InitializeComponent();
        public delegate void MethodCall();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btn_closedoors.BackColor = Color.Red;
            switch (LiftStatus)
            {
                case "GroundFloor":
                    downdoors_close.Enabled = true;
                    break;
                case "FirstFloor":
                    updoors_close.Enabled = true;
                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ground_door_open_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btn_opendoor.BackColor = Color.Red;
            switch (LiftStatus)
            {
                case "GroundFloor":
                    downdoor_open_btn.Enabled = true;
                    break;
                case "FirstFloor":
                    updoor_open_btn.Enabled = true;

                    break;
            }
        }

        private void downDoorClose_Tick(object sender, EventArgs e)
        {

        }

        private void downdoors_closeMethod() // animation method to close down doors
        {
            door_downL.Left += 1;
            door_downR.Left -= 1;
        }

        private void downdoors_openMethod() // animate method to open down doors
        {
            door_downL.Left -= 1;
            door_downR.Left += 1;
        }

        private void updoors_closeMethod() // animate method to close the doors 
        {
            door_upL.Left += 1;
            door_upR.Left -= 1;
        }

        private void updoors_openMethod() // animate method to open the doors
        {
            door_upL.Left -= 1;
            door_upR.Left += 1;
        }

        private void liftUp() // method to animate liftbox moving down
        {
            liftbox.Top -= 1;
            liftbox.Image = Resource1.closed_door_without_frame;
        }

        private void liftDown() // method to animate liftbox moving up
        {
            liftbox.Top += 1;
            liftbox.Image = Resource1.closed_door_without_frame;
        }

        private void downdoors_open_Tick(object sender, EventArgs e)
        {
            if (door_downL.Left >= x_doorL_open && downdoors_close.Enabled != true)
            {
                MethodCall downdoor = new MethodCall(downdoors_openMethod);
                downdoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                downdoors_open.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door open at ground floor"));
                PopulateDataGridView();
                timer_close.Enabled = true;

            }
        }

        private void updoors_open_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left >= x_doorL_open && updoors_close.Enabled != true) // if door is closed
            {
                MethodCall updoor = new MethodCall(updoors_openMethod);
                updoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                updoors_open.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door open at First-Floor"));
                PopulateDataGridView();
                timer_close.Enabled = true;
            }
        }

        private void updoors_close_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left <= x_doorL_close && updoors_open.Enabled != true) // if door is open
            {
                MethodCall updoor = new MethodCall(updoors_closeMethod);
                updoor.Invoke();
            }
            else
            {
                btn_closedoors.BackColor = Color.White;
                updoors_close.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door close at First-Floor"));
                PopulateDataGridView();
                if (moving_down == true) // if also moving down
                {
                    lift_display.Image = global::Elevator.Resource1.down; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                    G_display.Image = global::Elevator.Resource1.down;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                    F_display.Image = global::Elevator.Resource1.down;
                    go_down.Enabled = true;
                }
            }
        }

        private void downdoors_close_Tick(object sender, EventArgs e)
        {
            if (door_downL.Left <= x_doorL_close && downdoors_open.Enabled != true) // if lift doors are open
            {
                MethodCall downdoor = new MethodCall(downdoors_closeMethod);
                downdoor.Invoke();
            }
            else
            {
                btn_closedoors.BackColor = Color.White;
                downdoors_close.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door close at Ground-Floor"));
                PopulateDataGridView();
                if (moving_up == true) // if also moving up
                {
                    lift_display.Image = global::Elevator.Resource1.up; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                    G_display.Image = global::Elevator.Resource1.up;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                    F_display.Image = global::Elevator.Resource1.up;

                    go_up.Enabled = true;
                }
            }
        }

        private void go_up_Tick(object sender, EventArgs e)
        {
            if (liftbox.Top != y_liftUp)
            {
                MethodCall movingUp = new MethodCall(liftUp);
                movingUp.Invoke();
            }
            else
            {
                btn_firstFloor.BackColor = Color.White; // changing button color
                request_G.BackColor = Color.White; // changing button color
                result = new ElevatorController().Insert(new ElevatorModel("Lift arrived at First-Floor"));
                PopulateDataGridView();
                moving_up = false; // updating moving up status as false
                liftbox.Image = Resource1.Inside_of_the_lift; // changing image resource
                lift_display.Image = global::Elevator.Resource1.Red_firstFloorDisplay; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                G_display.Image = global::Elevator.Resource1.Red_firstFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                F_display.Image = global::Elevator.Resource1.Red_firstFloorDisplay;

                LiftStatus = "FirstFloor"; // updating liftStaus
                go_up.Enabled = false;
                updoors_open.Enabled = true;
                btn_opendoor.Enabled = true;
                btn_closedoors.Enabled = true;
            }
        }



        private void go_down_Tick(object sender, EventArgs e)
        {
            if (liftbox.Top != y_liftDown) // moving the lift
            {
                MethodCall movingUp = new MethodCall(liftDown);
                movingUp.Invoke();
            }
            else
            {
                btn_groundFloor.BackColor = Color.White;
                request_F.BackColor = Color.White;
                result = new ElevatorController().Insert(new ElevatorModel("Lift arrived at Ground-Floor"));
                PopulateDataGridView();
                moving_down = false;
                liftbox.Image = Resource1.Inside_of_the_lift;
                lift_display.Image = global::Elevator.Resource1.Red_groundFloorDisplay; // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                G_display.Image = global::Elevator.Resource1.Red_groundFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay
                F_display.Image = global::Elevator.Resource1.Red_groundFloorDisplay;    // resource file name Red_firstFloorDisplay = Red_GroundFloorDisplay

                LiftStatus = "GroundFloor";
                go_down.Enabled = false;
                downdoors_open.Enabled = true;
                btn_opendoor.Enabled = true;
                btn_closedoors.Enabled = true;
            }
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            switch (LiftStatus)
            {
                case "GroundFloor":
                    downdoors_close.Enabled = true;
                    break;
                case "FirstFloor":
                    updoors_close.Enabled = true;
                    break;
            }
            timer_close.Enabled = false;
        }

        private void door_downR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void request_F_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("FirstFloor")) // if lift is at first floor
            {
                request_F.BackColor = Color.Red; // btn color change
                moving_down = true;
                updoors_close.Enabled = true;
                btn_opendoor.Enabled = false;
                btn_closedoors.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Lift requested at Ground-Floor"));
                PopulateDataGridView();
                
            }
            else
            {
                downdoors_open.Enabled = true;
            }
        }

        private void request_G_Click(object sender, EventArgs e)
        {
            if (LiftStatus.Equals("GroundFloor")) // if lift is at ground floor
            {
                request_G.BackColor = Color.Red; // button color
                moving_up = true;
                downdoors_close.Enabled = true;
                btn_opendoor.Enabled = false;
                btn_closedoors.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Lift requested at First-Floor"));
                PopulateDataGridView();

            }
            else
            {
                updoors_open.Enabled = true;
            }
        }

        private void G_display_Click(object sender, EventArgs e)
        {

        }

        private void btn_groundFloor_Click(object sender, EventArgs e)
        {

            if (moving_up == false) // if the lift isnot moving up
            {
                if (LiftStatus == "GroundFloor")
                {
                    btn_groundFloor.BackColor = Color.Orange;
                    downdoor_open_btn.Enabled = true;
                    moving_down = false;
                    btn_groundFloor.BackColor = Color.White;
                }
                else
                {
                    btn_groundFloor.BackColor = Color.Orange;
                    moving_down = true;
                    updoors_close.Enabled = true;
                    btn_opendoor.Enabled = false;
                    btn_closedoors.Enabled = false;
                    result = new ElevatorController().Insert(new ElevatorModel("Lift moving toward Ground-Floor"));
                    PopulateDataGridView();
                }

            }
        }

        private void btn_firstFloor_Click(object sender, EventArgs e)
        {
            if (moving_down == false) // if the lift isnot moving down
            {

                if (LiftStatus == "FirstFloor")
                {
                    btn_firstFloor.BackColor = Color.Orange;
                    updoor_open_btn.Enabled = true;
                    moving_up = false;
                    btn_firstFloor.BackColor = Color.White;

                }
                btn_firstFloor.BackColor = Color.Orange;
                moving_up = true;
                downdoors_close.Enabled = true;
                btn_opendoor.Enabled = false;
                btn_closedoors.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Lift moving toward First-Floor"));
                PopulateDataGridView();

            }
        }



        private void PopulateDataGridView()
        {
            ArrayList elevatorarray = new ElevatorController().getElevatorData();
            dataGridView1.DataSource = elevatorarray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList elevatorarray = new ElevatorController().getElevatorData();
            dataGridView1.DataSource = elevatorarray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            result = new ElevatorController().clearAllData();
            PopulateDataGridView();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void downdoor_open_btn_Tick(object sender, EventArgs e)
        {
            if (door_downL.Left >= x_doorL_open && downdoors_close.Enabled != true)
            {
                MethodCall downdoor = new MethodCall(downdoors_openMethod);
                downdoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                downdoor_open_btn.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door open at ground floor"));
                PopulateDataGridView();


            }
        }

        private void updoor_open_btn_Tick(object sender, EventArgs e)
        {
            if (door_upL.Left >= x_doorL_open && updoors_close.Enabled != true) // if door is closed
            {
                MethodCall updoor = new MethodCall(updoors_openMethod);
                updoor.Invoke();
            }
            else
            {
                btn_opendoor.BackColor = Color.White;
                updoor_open_btn.Enabled = false;
                result = new ElevatorController().Insert(new ElevatorModel("Door open at First-Floor"));
                PopulateDataGridView();
                
            }
        }
    }
}