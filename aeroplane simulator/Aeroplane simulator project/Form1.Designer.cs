
namespace New_Event_driven_assignment__2
{
    partial class TheSimulator
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
            this.Throttle1 = new System.Windows.Forms.TrackBar();
            this.ThrottleButton = new System.Windows.Forms.Button();
            this.Pitch1 = new System.Windows.Forms.TrackBar();
            this.PitchButton = new System.Windows.Forms.Button();
            this.ControlInformation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseProgram = new System.Windows.Forms.Button();
            this.Controlslist = new System.Windows.Forms.DataGridView();
            this.ThrottleInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PitchInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReceivedGB = new System.Windows.Forms.GroupBox();
            this.WarningR_Button = new System.Windows.Forms.Button();
            this.ElevatorPitchR_Button = new System.Windows.Forms.Button();
            this.ThrottleR_Button = new System.Windows.Forms.Button();
            this.VerticalSpeedR_Button = new System.Windows.Forms.Button();
            this.PitchR_Button = new System.Windows.Forms.Button();
            this.SpeedR_Button = new System.Windows.Forms.Button();
            this.AltitudeR_Button = new System.Windows.Forms.Button();
            this.Warnings = new System.Windows.Forms.TextBox();
            this.ElevatorPitchText = new System.Windows.Forms.TextBox();
            this.ThrottleText = new System.Windows.Forms.TextBox();
            this.VerticalSpeedText = new System.Windows.Forms.TextBox();
            this.PitchText = new System.Windows.Forms.TextBox();
            this.SpeedText = new System.Windows.Forms.TextBox();
            this.AltitudeText = new System.Windows.Forms.TextBox();
            this.ConnectionGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_Button = new System.Windows.Forms.TextBox();
            this.IP_Button = new System.Windows.Forms.TextBox();
            this.Connection_button = new System.Windows.Forms.Button();
            this.SendText_Button = new System.Windows.Forms.Button();
            this.SendText_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Throttle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Controlslist)).BeginInit();
            this.DataReceivedGB.SuspendLayout();
            this.ConnectionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Throttle1
            // 
            this.Throttle1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Throttle1.Location = new System.Drawing.Point(20, 66);
            this.Throttle1.Maximum = 100;
            this.Throttle1.Name = "Throttle1";
            this.Throttle1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Throttle1.Size = new System.Drawing.Size(69, 387);
            this.Throttle1.TabIndex = 0;
            this.Throttle1.Scroll += new System.EventHandler(this.Throttle1_Scroll);
            // 
            // ThrottleButton
            // 
            this.ThrottleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThrottleButton.Location = new System.Drawing.Point(60, 233);
            this.ThrottleButton.Name = "ThrottleButton";
            this.ThrottleButton.Size = new System.Drawing.Size(72, 65);
            this.ThrottleButton.TabIndex = 1;
            this.ThrottleButton.Text = "Throttle NO";
            this.ThrottleButton.UseVisualStyleBackColor = true;
            this.ThrottleButton.Click += new System.EventHandler(this.ThrottleButton_Click);
            // 
            // Pitch1
            // 
            this.Pitch1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pitch1.Location = new System.Drawing.Point(138, 66);
            this.Pitch1.Maximum = 5;
            this.Pitch1.Minimum = -5;
            this.Pitch1.Name = "Pitch1";
            this.Pitch1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Pitch1.Size = new System.Drawing.Size(69, 387);
            this.Pitch1.TabIndex = 2;
            this.Pitch1.Scroll += new System.EventHandler(this.Pitch1_Scroll);
            // 
            // PitchButton
            // 
            this.PitchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PitchButton.Location = new System.Drawing.Point(185, 233);
            this.PitchButton.Name = "PitchButton";
            this.PitchButton.Size = new System.Drawing.Size(72, 65);
            this.PitchButton.TabIndex = 3;
            this.PitchButton.Text = "Pitch NO";
            this.PitchButton.UseVisualStyleBackColor = true;
            this.PitchButton.Click += new System.EventHandler(this.PitchButton_Click);
            // 
            // ControlInformation
            // 
            this.ControlInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ControlInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlInformation.Location = new System.Drawing.Point(724, 366);
            this.ControlInformation.Multiline = true;
            this.ControlInformation.Name = "ControlInformation";
            this.ControlInformation.Size = new System.Drawing.Size(351, 124);
            this.ControlInformation.TabIndex = 4;
            this.ControlInformation.Text = "                     Control Messages";
            this.ControlInformation.TextChanged += new System.EventHandler(this.ControlInformation_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.ThrottleButton);
            this.groupBox1.Controls.Add(this.Throttle1);
            this.groupBox1.Controls.Add(this.PitchButton);
            this.groupBox1.Controls.Add(this.Pitch1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(455, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 486);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                   Controls";
            // 
            // CloseProgram
            // 
            this.CloseProgram.BackColor = System.Drawing.Color.DarkRed;
            this.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseProgram.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseProgram.Location = new System.Drawing.Point(724, 500);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(351, 80);
            this.CloseProgram.TabIndex = 6;
            this.CloseProgram.Text = "EXIT";
            this.CloseProgram.UseVisualStyleBackColor = false;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // Controlslist
            // 
            this.Controlslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Controlslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Controlslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThrottleInformation,
            this.PitchInformation});
            this.Controlslist.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.Controlslist.Location = new System.Drawing.Point(724, 4);
            this.Controlslist.Name = "Controlslist";
            this.Controlslist.RowHeadersWidth = 62;
            this.Controlslist.RowTemplate.Height = 28;
            this.Controlslist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Controlslist.Size = new System.Drawing.Size(351, 362);
            this.Controlslist.TabIndex = 7;
            this.Controlslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Controlslist_CellContentClick);
            // 
            // ThrottleInformation
            // 
            this.ThrottleInformation.HeaderText = "Throttle ";
            this.ThrottleInformation.MinimumWidth = 8;
            this.ThrottleInformation.Name = "ThrottleInformation";
            this.ThrottleInformation.Width = 103;
            // 
            // PitchInformation
            // 
            this.PitchInformation.HeaderText = "Pitch";
            this.PitchInformation.MinimumWidth = 8;
            this.PitchInformation.Name = "PitchInformation";
            this.PitchInformation.Width = 80;
            // 
            // DataReceivedGB
            // 
            this.DataReceivedGB.Controls.Add(this.WarningR_Button);
            this.DataReceivedGB.Controls.Add(this.ElevatorPitchR_Button);
            this.DataReceivedGB.Controls.Add(this.ThrottleR_Button);
            this.DataReceivedGB.Controls.Add(this.VerticalSpeedR_Button);
            this.DataReceivedGB.Controls.Add(this.PitchR_Button);
            this.DataReceivedGB.Controls.Add(this.SpeedR_Button);
            this.DataReceivedGB.Controls.Add(this.AltitudeR_Button);
            this.DataReceivedGB.Controls.Add(this.Warnings);
            this.DataReceivedGB.Controls.Add(this.ElevatorPitchText);
            this.DataReceivedGB.Controls.Add(this.ThrottleText);
            this.DataReceivedGB.Controls.Add(this.VerticalSpeedText);
            this.DataReceivedGB.Controls.Add(this.PitchText);
            this.DataReceivedGB.Controls.Add(this.SpeedText);
            this.DataReceivedGB.Controls.Add(this.AltitudeText);
            this.DataReceivedGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataReceivedGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReceivedGB.Location = new System.Drawing.Point(12, 137);
            this.DataReceivedGB.Name = "DataReceivedGB";
            this.DataReceivedGB.Size = new System.Drawing.Size(437, 555);
            this.DataReceivedGB.TabIndex = 8;
            this.DataReceivedGB.TabStop = false;
            this.DataReceivedGB.Text = "Data Received ";
            // 
            // WarningR_Button
            // 
            this.WarningR_Button.Location = new System.Drawing.Point(15, 472);
            this.WarningR_Button.Name = "WarningR_Button";
            this.WarningR_Button.Size = new System.Drawing.Size(384, 44);
            this.WarningR_Button.TabIndex = 20;
            this.WarningR_Button.Text = "W";
            this.WarningR_Button.UseVisualStyleBackColor = true;
            this.WarningR_Button.Click += new System.EventHandler(this.WarningR_Button_Click);
            // 
            // ElevatorPitchR_Button
            // 
            this.ElevatorPitchR_Button.Location = new System.Drawing.Point(216, 367);
            this.ElevatorPitchR_Button.Name = "ElevatorPitchR_Button";
            this.ElevatorPitchR_Button.Size = new System.Drawing.Size(98, 39);
            this.ElevatorPitchR_Button.TabIndex = 19;
            this.ElevatorPitchR_Button.Text = "E";
            this.ElevatorPitchR_Button.UseVisualStyleBackColor = true;
            this.ElevatorPitchR_Button.Click += new System.EventHandler(this.ElevatorPitchR_Button_Click);
            // 
            // ThrottleR_Button
            // 
            this.ThrottleR_Button.Location = new System.Drawing.Point(216, 311);
            this.ThrottleR_Button.Name = "ThrottleR_Button";
            this.ThrottleR_Button.Size = new System.Drawing.Size(98, 39);
            this.ThrottleR_Button.TabIndex = 18;
            this.ThrottleR_Button.Text = "T";
            this.ThrottleR_Button.UseVisualStyleBackColor = true;
            this.ThrottleR_Button.Click += new System.EventHandler(this.ThrottleR_Button_Click);
            // 
            // VerticalSpeedR_Button
            // 
            this.VerticalSpeedR_Button.Location = new System.Drawing.Point(216, 253);
            this.VerticalSpeedR_Button.Name = "VerticalSpeedR_Button";
            this.VerticalSpeedR_Button.Size = new System.Drawing.Size(98, 39);
            this.VerticalSpeedR_Button.TabIndex = 17;
            this.VerticalSpeedR_Button.Text = "VS";
            this.VerticalSpeedR_Button.UseVisualStyleBackColor = true;
            this.VerticalSpeedR_Button.Click += new System.EventHandler(this.VerticalSpeedR_Button_Click);
            // 
            // PitchR_Button
            // 
            this.PitchR_Button.Location = new System.Drawing.Point(216, 187);
            this.PitchR_Button.Name = "PitchR_Button";
            this.PitchR_Button.Size = new System.Drawing.Size(98, 39);
            this.PitchR_Button.TabIndex = 16;
            this.PitchR_Button.Text = "P";
            this.PitchR_Button.UseVisualStyleBackColor = true;
            this.PitchR_Button.Click += new System.EventHandler(this.PitchR_Button_Click);
            // 
            // SpeedR_Button
            // 
            this.SpeedR_Button.BackColor = System.Drawing.SystemColors.Control;
            this.SpeedR_Button.Location = new System.Drawing.Point(216, 126);
            this.SpeedR_Button.Name = "SpeedR_Button";
            this.SpeedR_Button.Size = new System.Drawing.Size(98, 39);
            this.SpeedR_Button.TabIndex = 15;
            this.SpeedR_Button.Text = "S";
            this.SpeedR_Button.UseVisualStyleBackColor = false;
            this.SpeedR_Button.Click += new System.EventHandler(this.SpeedR_Button_Click);
            // 
            // AltitudeR_Button
            // 
            this.AltitudeR_Button.Location = new System.Drawing.Point(216, 65);
            this.AltitudeR_Button.Name = "AltitudeR_Button";
            this.AltitudeR_Button.Size = new System.Drawing.Size(98, 39);
            this.AltitudeR_Button.TabIndex = 9;
            this.AltitudeR_Button.Text = "A";
            this.AltitudeR_Button.UseVisualStyleBackColor = true;
            this.AltitudeR_Button.Click += new System.EventHandler(this.AltitudeR_Button_Click);
            // 
            // Warnings
            // 
            this.Warnings.BackColor = System.Drawing.SystemColors.Control;
            this.Warnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warnings.Location = new System.Drawing.Point(104, 430);
            this.Warnings.Name = "Warnings";
            this.Warnings.Size = new System.Drawing.Size(179, 26);
            this.Warnings.TabIndex = 14;
            this.Warnings.Text = "Warnings";
            // 
            // ElevatorPitchText
            // 
            this.ElevatorPitchText.BackColor = System.Drawing.SystemColors.Control;
            this.ElevatorPitchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevatorPitchText.Location = new System.Drawing.Point(6, 367);
            this.ElevatorPitchText.Name = "ElevatorPitchText";
            this.ElevatorPitchText.Size = new System.Drawing.Size(179, 26);
            this.ElevatorPitchText.TabIndex = 13;
            this.ElevatorPitchText.Text = "Elevator Pitch";
            // 
            // ThrottleText
            // 
            this.ThrottleText.BackColor = System.Drawing.SystemColors.Control;
            this.ThrottleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThrottleText.Location = new System.Drawing.Point(6, 311);
            this.ThrottleText.Name = "ThrottleText";
            this.ThrottleText.Size = new System.Drawing.Size(179, 26);
            this.ThrottleText.TabIndex = 12;
            this.ThrottleText.Text = "Throttle";
            // 
            // VerticalSpeedText
            // 
            this.VerticalSpeedText.BackColor = System.Drawing.SystemColors.Control;
            this.VerticalSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerticalSpeedText.Location = new System.Drawing.Point(6, 253);
            this.VerticalSpeedText.Name = "VerticalSpeedText";
            this.VerticalSpeedText.Size = new System.Drawing.Size(179, 26);
            this.VerticalSpeedText.TabIndex = 11;
            this.VerticalSpeedText.Text = "Vertical Speed";
            // 
            // PitchText
            // 
            this.PitchText.BackColor = System.Drawing.SystemColors.Control;
            this.PitchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PitchText.Location = new System.Drawing.Point(6, 187);
            this.PitchText.Name = "PitchText";
            this.PitchText.Size = new System.Drawing.Size(179, 26);
            this.PitchText.TabIndex = 10;
            this.PitchText.Text = "Pitch";
            // 
            // SpeedText
            // 
            this.SpeedText.BackColor = System.Drawing.SystemColors.Control;
            this.SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedText.Location = new System.Drawing.Point(6, 126);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(179, 26);
            this.SpeedText.TabIndex = 9;
            this.SpeedText.Text = "Speed";
            // 
            // AltitudeText
            // 
            this.AltitudeText.BackColor = System.Drawing.SystemColors.Control;
            this.AltitudeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeText.Location = new System.Drawing.Point(6, 65);
            this.AltitudeText.Name = "AltitudeText";
            this.AltitudeText.Size = new System.Drawing.Size(179, 26);
            this.AltitudeText.TabIndex = 9;
            this.AltitudeText.Text = "Altitude";
            // 
            // ConnectionGB
            // 
            this.ConnectionGB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ConnectionGB.Controls.Add(this.label2);
            this.ConnectionGB.Controls.Add(this.label1);
            this.ConnectionGB.Controls.Add(this.Port_Button);
            this.ConnectionGB.Controls.Add(this.IP_Button);
            this.ConnectionGB.Controls.Add(this.Connection_button);
            this.ConnectionGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectionGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionGB.Location = new System.Drawing.Point(12, 4);
            this.ConnectionGB.Name = "ConnectionGB";
            this.ConnectionGB.Size = new System.Drawing.Size(437, 127);
            this.ConnectionGB.TabIndex = 9;
            this.ConnectionGB.TabStop = false;
            this.ConnectionGB.Text = "Connection";
            this.ConnectionGB.Enter += new System.EventHandler(this.ConnectionGB_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "IP Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Port_Button
            // 
            this.Port_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_Button.Location = new System.Drawing.Point(138, 84);
            this.Port_Button.Name = "Port_Button";
            this.Port_Button.Size = new System.Drawing.Size(140, 30);
            this.Port_Button.TabIndex = 12;
            this.Port_Button.TextChanged += new System.EventHandler(this.Port_Button_TextChanged);
            // 
            // IP_Button
            // 
            this.IP_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Button.Location = new System.Drawing.Point(138, 37);
            this.IP_Button.Name = "IP_Button";
            this.IP_Button.Size = new System.Drawing.Size(140, 30);
            this.IP_Button.TabIndex = 11;
            this.IP_Button.TextChanged += new System.EventHandler(this.IP_Button_TextChanged);
            // 
            // Connection_button
            // 
            this.Connection_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Connection_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connection_button.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_button.Location = new System.Drawing.Point(284, 18);
            this.Connection_button.Name = "Connection_button";
            this.Connection_button.Size = new System.Drawing.Size(147, 103);
            this.Connection_button.TabIndex = 10;
            this.Connection_button.Text = "Connect";
            this.Connection_button.UseVisualStyleBackColor = false;
            this.Connection_button.Click += new System.EventHandler(this.Connection_button_Click);
            // 
            // SendText_Button
            // 
            this.SendText_Button.BackColor = System.Drawing.Color.YellowGreen;
            this.SendText_Button.Font = new System.Drawing.Font("News706 BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendText_Button.Location = new System.Drawing.Point(455, 500);
            this.SendText_Button.Name = "SendText_Button";
            this.SendText_Button.Size = new System.Drawing.Size(262, 79);
            this.SendText_Button.TabIndex = 10;
            this.SendText_Button.Text = "SEND TEXT";
            this.SendText_Button.UseVisualStyleBackColor = false;
            this.SendText_Button.Click += new System.EventHandler(this.SendText_Button_Click);
            // 
            // SendText_TextBox
            // 
            this.SendText_TextBox.BackColor = System.Drawing.Color.YellowGreen;
            this.SendText_TextBox.Location = new System.Drawing.Point(455, 585);
            this.SendText_TextBox.Multiline = true;
            this.SendText_TextBox.Name = "SendText_TextBox";
            this.SendText_TextBox.Size = new System.Drawing.Size(259, 106);
            this.SendText_TextBox.TabIndex = 11;
            this.SendText_TextBox.TextChanged += new System.EventHandler(this.SendText_TextBox_TextChanged);
            // 
            // TheSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 704);
            this.Controls.Add(this.SendText_TextBox);
            this.Controls.Add(this.SendText_Button);
            this.Controls.Add(this.ConnectionGB);
            this.Controls.Add(this.DataReceivedGB);
            this.Controls.Add(this.Controlslist);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.ControlInformation);
            this.Controls.Add(this.groupBox1);
            this.Name = "TheSimulator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TheSimulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Throttle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Controlslist)).EndInit();
            this.DataReceivedGB.ResumeLayout(false);
            this.DataReceivedGB.PerformLayout();
            this.ConnectionGB.ResumeLayout(false);
            this.ConnectionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Throttle1;
        private System.Windows.Forms.Button ThrottleButton;
        private System.Windows.Forms.TrackBar Pitch1;
        private System.Windows.Forms.Button PitchButton;
        private System.Windows.Forms.TextBox ControlInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CloseProgram;
        private System.Windows.Forms.DataGridView Controlslist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThrottleInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PitchInformation;
        private System.Windows.Forms.GroupBox DataReceivedGB;
        private System.Windows.Forms.Button WarningR_Button;
        private System.Windows.Forms.Button ElevatorPitchR_Button;
        private System.Windows.Forms.Button ThrottleR_Button;
        private System.Windows.Forms.Button VerticalSpeedR_Button;
        private System.Windows.Forms.Button PitchR_Button;
        private System.Windows.Forms.Button SpeedR_Button;
        private System.Windows.Forms.Button AltitudeR_Button;
        private System.Windows.Forms.TextBox Warnings;
        private System.Windows.Forms.TextBox ElevatorPitchText;
        private System.Windows.Forms.TextBox ThrottleText;
        private System.Windows.Forms.TextBox VerticalSpeedText;
        private System.Windows.Forms.TextBox PitchText;
        private System.Windows.Forms.TextBox SpeedText;
        private System.Windows.Forms.TextBox AltitudeText;
        private System.Windows.Forms.GroupBox ConnectionGB;
        private System.Windows.Forms.Button Connection_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_Button;
        private System.Windows.Forms.TextBox IP_Button;
        private System.Windows.Forms.Button SendText_Button;
        private System.Windows.Forms.TextBox SendText_TextBox;
    }
}

