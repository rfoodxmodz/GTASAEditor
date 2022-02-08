namespace GTASA_Handling_Editor
{
    partial class main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.setHandling = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.handlinglist = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.carslist = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ip = new System.Windows.Forms.Label();
            this.textIp = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(15, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(542, 282);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.setHandling);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Handling Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // setHandling
            // 
            this.setHandling.Location = new System.Drawing.Point(32, 180);
            this.setHandling.Name = "setHandling";
            this.setHandling.Size = new System.Drawing.Size(75, 26);
            this.setHandling.TabIndex = 3;
            this.setHandling.Text = "set";
            this.setHandling.UseVisualStyleBackColor = true;
            this.setHandling.Click += new System.EventHandler(this.setHandling_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.handlinglist);
            this.groupBox4.Location = new System.Drawing.Point(32, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 68);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "select handling type";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // handlinglist
            // 
            this.handlinglist.FormattingEnabled = true;
            this.handlinglist.Items.AddRange(new object[] {
            "Drift",
            "Need For Speed",
            "Reduce Car Weight",
            "Unlock Steering Wheels",
            "Lowered Suspension"});
            this.handlinglist.Location = new System.Drawing.Point(6, 21);
            this.handlinglist.Name = "handlinglist";
            this.handlinglist.Size = new System.Drawing.Size(185, 24);
            this.handlinglist.TabIndex = 1;
            this.handlinglist.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.carslist);
            this.groupBox3.Location = new System.Drawing.Point(32, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "select a car";
            // 
            // carslist
            // 
            this.carslist.FormattingEnabled = true;
            this.carslist.Items.AddRange(new object[] {
            "All cars",
            "LANDSTAL",
            "BRAVURA",
            "BUFFALO",
            "LINERUN",
            "PEREN",
            "SENTINEL",
            "DUMPER",
            "FIRETRUK",
            "TRASH",
            "STRETCH",
            "MANANA",
            "INFERNUS",
            "VOODOO",
            "PONY",
            "MULE",
            "CHEETAH",
            "AMBULAN",
            "MOONBEAM",
            "ESPERANT",
            "TAXI",
            "WASHING",
            "BOBCAT",
            "MRWHOOP",
            "BFINJECT",
            "PREMIER",
            "ENFORCER",
            "SECURICA",
            "BANSHEE",
            "BUS",
            "RHINO",
            "BARRACKS",
            "HOTKNIFE",
            "ARTICT1",
            "PREVION",
            "COACH",
            "CABBIE",
            "STALLION",
            "RUMPO",
            "RCBANDIT",
            "ROMERO",
            "PACKER",
            "MONSTER",
            "ADMIRAL",
            "TRAM",
            "AIRTRAIN",
            "ARTICT2",
            "TURISMO",
            "FLATBED",
            "YANKEE",
            "GOLFCART",
            "SOLAIR",
            "TOPFUN",
            "GLENDALE",
            "OCEANIC",
            "PATRIOT",
            "HERMES",
            "SABRE",
            "ZR350",
            "WALTON",
            "REGINA",
            "COMET",
            "BURRITO",
            "CAMPER",
            "BAGGAGE",
            "DOZER",
            "RANCHER",
            "FBIRANCH",
            "VIRGO",
            "GREENWOOD",
            "HOTRING",
            "SANDKING",
            "BLISTAC",
            "BOXVILLE",
            "BENSON",
            "MESA",
            "BLOODRA",
            "BLOODRB",
            "SUPERGT",
            "ELEGANT",
            "JOURNEY",
            "PETROL",
            "RDTRAIN",
            "NEBULA",
            "MAJESTIC",
            "BUCCANEE",
            "CEMENT",
            "TOWTRUCK",
            "FORTUNE",
            "CADRONA",
            "FBITRUCK",
            "WILLARD",
            "FORKLIFT",
            "TRACTOR",
            "COMBINE",
            "FELTZER",
            "REMINGTN",
            "SLAMVAN",
            "BLADE\t",
            "FREIGHT",
            "STREAK",
            "VINCENT",
            "BULLET",
            "CLOVER",
            "SADLER",
            "RANGER",
            "HUSTLER",
            "INTRUDER",
            "PRIMO",
            "TAMPA",
            "SUNRISE",
            "MERIT",
            "UTILITY",
            "YOSEMITE",
            "WINDSOR",
            "MTRUCK_A",
            "MTRUCK_B",
            "URANUS",
            "JESTER",
            "SULTAN",
            "STRATUM",
            "ELEGY",
            "RCTIGER",
            "FLASH",
            "TAHOMA",
            "SAVANNA",
            "BANDITO",
            "FREIFLAT",
            "CSTREAK",
            "KART",
            "MOWER",
            "DUNE",
            "SWEEPER",
            "BROADWAY",
            "TORNADO",
            "DFT30",
            "HUNTLEY",
            "STAFFORD",
            "NEWSVAN",
            "TUG\t",
            "PETROTR",
            "EMPEROR",
            "FLOAT",
            "EUROS",
            "HOTDOG\t",
            "CLUB\t",
            "ARTICT3",
            "RCCAM\t",
            "POLICE_LA",
            "POLICE_SF",
            "POLICE_VG",
            "POLRANGER",
            "PICADOR",
            "SWATVAN",
            "ALPHA",
            "PHOENIX",
            "BAGBOXA",
            "BAGBOXB",
            "STAIRS",
            "BOXBURG",
            "FARM_TR1",
            "UTIL_TR1",
            "ROLLER\t",
            "BIKE",
            "MOPED",
            "DIRTBIKE",
            "FCR900",
            "NRG500",
            "HPV1000",
            "BF400",
            "WAYFARER",
            "QUADBIKE",
            "BMX",
            "CHOPPERB",
            "MTB",
            "FREEWAY",
            "PREDATOR",
            "SPEEDER",
            "REEFER",
            "RIO",
            "SQUALO",
            "TROPIC",
            "COASTGRD",
            "DINGHY",
            "MARQUIS",
            "CUPBOAT",
            "LAUNCH",
            "SEAPLANE",
            "VORTEX",
            "RUSTLER",
            "BEAGLE",
            "CROPDUST",
            "STUNT",
            "SHAMAL",
            "HYDRA",
            "NEVADA",
            "AT400",
            "ANDROM",
            "DODO\t",
            "SPARROW",
            "SEASPAR",
            "MAVERICK",
            "COASTMAV",
            "POLMAV",
            "HUNTER",
            "LEVIATHN",
            "CARGOBOB",
            "RAINDANC",
            "RCBARON",
            "RCGOBLIN",
            "RCRAIDER"});
            this.carslist.Location = new System.Drawing.Point(6, 25);
            this.carslist.Name = "carslist";
            this.carslist.Size = new System.Drawing.Size(185, 24);
            this.carslist.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Controls.Add(this.textIp);
            this.groupBox2.Controls.Add(this.connectBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ip.Location = new System.Drawing.Point(28, 28);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(50, 17);
            this.ip.TabIndex = 2;
            this.ip.Text = "PS4 IP";
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(88, 23);
            this.textIp.Multiline = true;
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(186, 27);
            this.textIp.TabIndex = 1;
            this.textIp.Tag = "PS4 IP";
            this.textIp.Text = "192.168.1.";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(15, 54);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(156, 26);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "connect And attach";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "Connection:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel2.Text = "Not connected";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "GTA SA Handling Editor";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button setHandling;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox handlinglist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox carslist;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

