namespace Elevator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            button1 = new Button();
            clear_btn = new Button();
            groupBox2 = new GroupBox();
            btn_opendoor = new PictureBox();
            btn_closedoors = new PictureBox();
            btn_firstFloor = new PictureBox();
            btn_groundFloor = new PictureBox();
            lift_display = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            liftbox = new PictureBox();
            door_downL = new PictureBox();
            door_downR = new PictureBox();
            exit_btn = new Button();
            door_upL = new PictureBox();
            door_upR = new PictureBox();
            downdoors_open = new System.Windows.Forms.Timer(components);
            updoors_open = new System.Windows.Forms.Timer(components);
            updoors_close = new System.Windows.Forms.Timer(components);
            downdoors_close = new System.Windows.Forms.Timer(components);
            go_up = new System.Windows.Forms.Timer(components);
            go_down = new System.Windows.Forms.Timer(components);
            timer_close = new System.Windows.Forms.Timer(components);
            request_F = new PictureBox();
            request_G = new PictureBox();
            pictureBox1 = new PictureBox();
            G_display = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            F_display = new PictureBox();
            downdoor_open_btn = new System.Windows.Forms.Timer(components);
            updoor_open_btn = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_opendoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_closedoors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_firstFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_groundFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lift_display).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liftbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_downL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_downR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_upL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_upR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)request_F).BeginInit();
            ((System.ComponentModel.ISupportInitialize)request_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)G_display).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)F_display).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(listBox1);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.Name = "listBox1";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clear_btn
            // 
            resources.ApplyResources(clear_btn, "clear_btn");
            clear_btn.Name = "clear_btn";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_opendoor);
            groupBox2.Controls.Add(btn_closedoors);
            groupBox2.Controls.Add(btn_firstFloor);
            groupBox2.Controls.Add(btn_groundFloor);
            groupBox2.Controls.Add(lift_display);
            groupBox2.Controls.Add(pictureBox2);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btn_opendoor
            // 
            btn_opendoor.BackgroundImage = Resource1.opendoorbutton;
            resources.ApplyResources(btn_opendoor, "btn_opendoor");
            btn_opendoor.Name = "btn_opendoor";
            btn_opendoor.TabStop = false;
            btn_opendoor.Click += pictureBox7_Click;
            // 
            // btn_closedoors
            // 
            resources.ApplyResources(btn_closedoors, "btn_closedoors");
            btn_closedoors.Image = Resource1.closedoorsbutton;
            btn_closedoors.Name = "btn_closedoors";
            btn_closedoors.TabStop = false;
            btn_closedoors.Click += pictureBox6_Click;
            // 
            // btn_firstFloor
            // 
            btn_firstFloor.BackgroundImage = Resource1.firstfloorbutton1;
            resources.ApplyResources(btn_firstFloor, "btn_firstFloor");
            btn_firstFloor.Name = "btn_firstFloor";
            btn_firstFloor.TabStop = false;
            btn_firstFloor.Click += btn_firstFloor_Click;
            // 
            // btn_groundFloor
            // 
            btn_groundFloor.BackgroundImage = Resource1.Groundfloorbutton3;
            resources.ApplyResources(btn_groundFloor, "btn_groundFloor");
            btn_groundFloor.Name = "btn_groundFloor";
            btn_groundFloor.TabStop = false;
            btn_groundFloor.Click += btn_groundFloor_Click;
            // 
            // lift_display
            // 
            lift_display.BackColor = Color.Black;
            resources.ApplyResources(lift_display, "lift_display");
            lift_display.Name = "lift_display";
            lift_display.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Resource1.panel;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = Resource1.door_frame;
            resources.ApplyResources(pictureBox8, "pictureBox8");
            pictureBox8.Name = "pictureBox8";
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Resource1.door_frame;
            resources.ApplyResources(pictureBox9, "pictureBox9");
            pictureBox9.Name = "pictureBox9";
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Resource1.concrete;
            resources.ApplyResources(pictureBox10, "pictureBox10");
            pictureBox10.Name = "pictureBox10";
            pictureBox10.TabStop = false;
            // 
            // liftbox
            // 
            liftbox.BackColor = Color.Transparent;
            liftbox.Image = Resource1.Inside_of_the_lift;
            resources.ApplyResources(liftbox, "liftbox");
            liftbox.Name = "liftbox";
            liftbox.TabStop = false;
            // 
            // door_downL
            // 
            door_downL.BackColor = Color.Transparent;
            door_downL.Image = Resource1.lift_door_left;
            resources.ApplyResources(door_downL, "door_downL");
            door_downL.Name = "door_downL";
            door_downL.TabStop = false;
            // 
            // door_downR
            // 
            door_downR.BackColor = Color.Transparent;
            door_downR.Image = Resource1.lift_door_right;
            resources.ApplyResources(door_downR, "door_downR");
            door_downR.Name = "door_downR";
            door_downR.TabStop = false;
            door_downR.Click += door_downR_Click;
            // 
            // exit_btn
            // 
            resources.ApplyResources(exit_btn, "exit_btn");
            exit_btn.Name = "exit_btn";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // door_upL
            // 
            door_upL.BackColor = Color.Transparent;
            door_upL.Image = Resource1.lift_door_left;
            resources.ApplyResources(door_upL, "door_upL");
            door_upL.Name = "door_upL";
            door_upL.TabStop = false;
            // 
            // door_upR
            // 
            door_upR.Image = Resource1.lift_door_right;
            resources.ApplyResources(door_upR, "door_upR");
            door_upR.Name = "door_upR";
            door_upR.TabStop = false;
            // 
            // downdoors_open
            // 
            downdoors_open.Interval = 30;
            downdoors_open.Tick += downdoors_open_Tick;
            // 
            // updoors_open
            // 
            updoors_open.Interval = 30;
            updoors_open.Tick += updoors_open_Tick;
            // 
            // updoors_close
            // 
            updoors_close.Interval = 30;
            updoors_close.Tick += updoors_close_Tick;
            // 
            // downdoors_close
            // 
            downdoors_close.Interval = 30;
            downdoors_close.Tick += downdoors_close_Tick;
            // 
            // go_up
            // 
            go_up.Interval = 15;
            go_up.Tick += go_up_Tick;
            // 
            // go_down
            // 
            go_down.Interval = 15;
            go_down.Tick += go_down_Tick;
            // 
            // timer_close
            // 
            timer_close.Tick += timer_close_Tick;
            // 
            // request_F
            // 
            request_F.Image = Resource1.direction_north;
            resources.ApplyResources(request_F, "request_F");
            request_F.Name = "request_F";
            request_F.TabStop = false;
            request_F.Click += request_F_Click;
            // 
            // request_G
            // 
            request_G.Image = Resource1.direction_south;
            resources.ApplyResources(request_G, "request_G");
            request_G.Name = "request_G";
            request_G.TabStop = false;
            request_G.Click += request_G_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.display;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // G_display
            // 
            G_display.BackColor = Color.Black;
            resources.ApplyResources(G_display, "G_display");
            G_display.Name = "G_display";
            G_display.TabStop = false;
            G_display.Click += G_display_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Resource1.concrete;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resource1.display;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // F_display
            // 
            F_display.BackColor = Color.Black;
            resources.ApplyResources(F_display, "F_display");
            F_display.Name = "F_display";
            F_display.TabStop = false;
            // 
            // downdoor_open_btn
            // 
            downdoor_open_btn.Interval = 30;
            downdoor_open_btn.Tick += downdoor_open_btn_Tick;
            // 
            // updoor_open_btn
            // 
            updoor_open_btn.Interval = 30;
            updoor_open_btn.Tick += updoor_open_btn_Tick;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(F_display);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(G_display);
            Controls.Add(pictureBox1);
            Controls.Add(request_G);
            Controls.Add(request_F);
            Controls.Add(door_upR);
            Controls.Add(door_upL);
            Controls.Add(exit_btn);
            Controls.Add(door_downR);
            Controls.Add(door_downL);
            Controls.Add(liftbox);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(groupBox2);
            Controls.Add(clear_btn);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_opendoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_closedoors).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_firstFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_groundFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)lift_display).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)liftbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_downL).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_downR).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_upL).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_upR).EndInit();
            ((System.ComponentModel.ISupportInitialize)request_F).EndInit();
            ((System.ComponentModel.ISupportInitialize)request_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)G_display).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)F_display).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Button clear_btn;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private PictureBox lift_display;
        private PictureBox btn_groundFloor;
        private PictureBox btn_firstFloor;
        private PictureBox btn_closedoors;
        private PictureBox btn_opendoor;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox liftbox;
        private PictureBox door_downL;
        private PictureBox door_downR;
        private Button exit_btn;
        private DataGridView dataGridView1;
        private PictureBox door_upL;
        private PictureBox door_upR;
        private System.Windows.Forms.Timer downdoors_open;
        private System.Windows.Forms.Timer updoors_open;
        private System.Windows.Forms.Timer updoors_close;
        private System.Windows.Forms.Timer downdoors_close;
        private System.Windows.Forms.Timer go_up;
        private System.Windows.Forms.Timer go_down;
        private System.Windows.Forms.Timer timer_close;
        private PictureBox request_F;
        private PictureBox request_G;
        private PictureBox pictureBox1;
        private PictureBox G_display;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox F_display;
        private System.Windows.Forms.Timer downdoor_open_btn;
        private System.Windows.Forms.Timer updoor_open_btn;
    }
}