namespace EventDriven_18024092
{
    partial class Form1
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
            this.Connection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tgPort = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.tgConnection = new System.Windows.Forms.Label();
            this.tgIPAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJsonSent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblJsonRecieved = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPitchControl = new System.Windows.Forms.Label();
            this.lblThrottleControl = new System.Windows.Forms.Label();
            this.tgThrottle = new System.Windows.Forms.Label();
            this.tgPitch = new System.Windows.Forms.Label();
            this.trkPitch = new System.Windows.Forms.TrackBar();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.DataGridView();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Throttle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAutoPilot = new System.Windows.Forms.Button();
            this.txtTargetSpeeds = new System.Windows.Forms.TextBox();
            this.txtTargetAltitude = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelAP = new System.Windows.Forms.Button();
            this.Connection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabData)).BeginInit();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.btnConnect);
            this.Connection.Controls.Add(this.txtPort);
            this.Connection.Controls.Add(this.tgPort);
            this.Connection.Controls.Add(this.txtIPAddress);
            this.Connection.Controls.Add(this.lblConnectionStatus);
            this.Connection.Controls.Add(this.tgConnection);
            this.Connection.Controls.Add(this.tgIPAddress);
            this.Connection.Location = new System.Drawing.Point(13, 13);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(379, 109);
            this.Connection.TabIndex = 0;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(255, 59);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(246, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 5;
            // 
            // tgPort
            // 
            this.tgPort.AutoSize = true;
            this.tgPort.Location = new System.Drawing.Point(208, 23);
            this.tgPort.Name = "tgPort";
            this.tgPort.Size = new System.Drawing.Size(32, 13);
            this.tgPort.TabIndex = 4;
            this.tgPort.Text = "Port: ";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(78, 20);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 3;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(113, 50);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(73, 13);
            this.lblConnectionStatus.TabIndex = 2;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // tgConnection
            // 
            this.tgConnection.AutoSize = true;
            this.tgConnection.Location = new System.Drawing.Point(7, 50);
            this.tgConnection.Name = "tgConnection";
            this.tgConnection.Size = new System.Drawing.Size(100, 13);
            this.tgConnection.TabIndex = 1;
            this.tgConnection.Text = "Connection Status: ";
            // 
            // tgIPAddress
            // 
            this.tgIPAddress.AutoSize = true;
            this.tgIPAddress.Location = new System.Drawing.Point(7, 20);
            this.tgIPAddress.Name = "tgIPAddress";
            this.tgIPAddress.Size = new System.Drawing.Size(64, 13);
            this.tgIPAddress.TabIndex = 0;
            this.tgIPAddress.Text = "IP Address: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJsonSent);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON Sent";
            // 
            // lblJsonSent
            // 
            this.lblJsonSent.AutoSize = true;
            this.lblJsonSent.Location = new System.Drawing.Point(7, 29);
            this.lblJsonSent.Name = "lblJsonSent";
            this.lblJsonSent.Size = new System.Drawing.Size(10, 13);
            this.lblJsonSent.TabIndex = 0;
            this.lblJsonSent.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblJsonRecieved);
            this.groupBox2.Location = new System.Drawing.Point(13, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON Recieved";
            // 
            // lblJsonRecieved
            // 
            this.lblJsonRecieved.AutoSize = true;
            this.lblJsonRecieved.Location = new System.Drawing.Point(7, 29);
            this.lblJsonRecieved.Name = "lblJsonRecieved";
            this.lblJsonRecieved.Size = new System.Drawing.Size(10, 13);
            this.lblJsonRecieved.TabIndex = 0;
            this.lblJsonRecieved.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.lblPitchControl);
            this.groupBox3.Controls.Add(this.lblThrottleControl);
            this.groupBox3.Controls.Add(this.tgThrottle);
            this.groupBox3.Controls.Add(this.tgPitch);
            this.groupBox3.Controls.Add(this.trkPitch);
            this.groupBox3.Controls.Add(this.trkThrottle);
            this.groupBox3.Location = new System.Drawing.Point(13, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 305);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(116, 261);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPitchControl
            // 
            this.lblPitchControl.AutoSize = true;
            this.lblPitchControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchControl.Location = new System.Drawing.Point(297, 82);
            this.lblPitchControl.Name = "lblPitchControl";
            this.lblPitchControl.Size = new System.Drawing.Size(24, 26);
            this.lblPitchControl.TabIndex = 5;
            this.lblPitchControl.Text = "0";
            // 
            // lblThrottleControl
            // 
            this.lblThrottleControl.AutoSize = true;
            this.lblThrottleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottleControl.Location = new System.Drawing.Point(111, 82);
            this.lblThrottleControl.Name = "lblThrottleControl";
            this.lblThrottleControl.Size = new System.Drawing.Size(24, 26);
            this.lblThrottleControl.TabIndex = 4;
            this.lblThrottleControl.Text = "0";
            // 
            // tgThrottle
            // 
            this.tgThrottle.AutoSize = true;
            this.tgThrottle.Location = new System.Drawing.Point(59, 25);
            this.tgThrottle.Name = "tgThrottle";
            this.tgThrottle.Size = new System.Drawing.Size(43, 13);
            this.tgThrottle.TabIndex = 3;
            this.tgThrottle.Text = "Throttle";
            // 
            // tgPitch
            // 
            this.tgPitch.AutoSize = true;
            this.tgPitch.Location = new System.Drawing.Point(218, 25);
            this.tgPitch.Name = "tgPitch";
            this.tgPitch.Size = new System.Drawing.Size(73, 13);
            this.tgPitch.TabIndex = 2;
            this.tgPitch.Text = "Elevator Pitch";
            // 
            // trkPitch
            // 
            this.trkPitch.Location = new System.Drawing.Point(235, 41);
            this.trkPitch.Maximum = 5;
            this.trkPitch.Minimum = -5;
            this.trkPitch.Name = "trkPitch";
            this.trkPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPitch.Size = new System.Drawing.Size(45, 216);
            this.trkPitch.TabIndex = 1;
            this.trkPitch.Tag = "";
            this.trkPitch.Scroll += new System.EventHandler(this.trkPitch_Scroll);
            // 
            // trkThrottle
            // 
            this.trkThrottle.Location = new System.Drawing.Point(62, 41);
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(45, 216);
            this.trkThrottle.TabIndex = 0;
            this.trkThrottle.TickFrequency = 10;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblWarnings);
            this.groupBox4.Location = new System.Drawing.Point(541, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Warnings";
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Location = new System.Drawing.Point(6, 21);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(10, 13);
            this.lblWarnings.TabIndex = 0;
            this.lblWarnings.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblElevatorPitch);
            this.groupBox5.Controls.Add(this.lblThrottle);
            this.groupBox5.Controls.Add(this.lblVerticalSpeed);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.lblPitch);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblSpeed);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblAltitude);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(541, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 124);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Recieved";
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(385, 95);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(13, 13);
            this.lblElevatorPitch.TabIndex = 11;
            this.lblElevatorPitch.Text = "0";
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(385, 66);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(13, 13);
            this.lblThrottle.TabIndex = 10;
            this.lblThrottle.Text = "0";
            // 
            // lblVerticalSpeed
            // 
            this.lblVerticalSpeed.AutoSize = true;
            this.lblVerticalSpeed.Location = new System.Drawing.Point(385, 36);
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            this.lblVerticalSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblVerticalSpeed.TabIndex = 9;
            this.lblVerticalSpeed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Elevator Pitch: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Throttle: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vertical Speed:";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(63, 95);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(13, 13);
            this.lblPitch.TabIndex = 5;
            this.lblPitch.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pitch:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(63, 66);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speed:";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(63, 35);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(13, 13);
            this.lblAltitude.TabIndex = 1;
            this.lblAltitude.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altitude: ";
            // 
            // tabData
            // 
            this.tabData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Altitude,
            this.Speed,
            this.Pitch,
            this.VerticalSpeed,
            this.Throttle,
            this.ElevatorPitch,
            this.WarningCode});
            this.tabData.Location = new System.Drawing.Point(399, 203);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(757, 379);
            this.tabData.TabIndex = 6;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // Pitch
            // 
            this.Pitch.HeaderText = "Pitch";
            this.Pitch.Name = "Pitch";
            this.Pitch.ReadOnly = true;
            // 
            // VerticalSpeed
            // 
            this.VerticalSpeed.HeaderText = "Vertical Speed";
            this.VerticalSpeed.Name = "VerticalSpeed";
            this.VerticalSpeed.ReadOnly = true;
            // 
            // Throttle
            // 
            this.Throttle.HeaderText = "Throttle";
            this.Throttle.Name = "Throttle";
            this.Throttle.ReadOnly = true;
            // 
            // ElevatorPitch
            // 
            this.ElevatorPitch.HeaderText = "ElevatorPitch";
            this.ElevatorPitch.Name = "ElevatorPitch";
            this.ElevatorPitch.ReadOnly = true;
            // 
            // WarningCode
            // 
            this.WarningCode.HeaderText = "Warning Code";
            this.WarningCode.Name = "WarningCode";
            this.WarningCode.ReadOnly = true;
            // 
            // btnAutoPilot
            // 
            this.btnAutoPilot.Location = new System.Drawing.Point(424, 33);
            this.btnAutoPilot.Name = "btnAutoPilot";
            this.btnAutoPilot.Size = new System.Drawing.Size(96, 23);
            this.btnAutoPilot.TabIndex = 8;
            this.btnAutoPilot.Text = "Auto Pilot";
            this.btnAutoPilot.UseVisualStyleBackColor = true;
            this.btnAutoPilot.Click += new System.EventHandler(this.btnAutoPilot_Click);
            // 
            // txtTargetSpeeds
            // 
            this.txtTargetSpeeds.Location = new System.Drawing.Point(424, 84);
            this.txtTargetSpeeds.Name = "txtTargetSpeeds";
            this.txtTargetSpeeds.Size = new System.Drawing.Size(100, 20);
            this.txtTargetSpeeds.TabIndex = 7;
            // 
            // txtTargetAltitude
            // 
            this.txtTargetAltitude.Location = new System.Drawing.Point(424, 129);
            this.txtTargetAltitude.Name = "txtTargetAltitude";
            this.txtTargetAltitude.Size = new System.Drawing.Size(100, 20);
            this.txtTargetAltitude.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Target Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Target Altitude";
            // 
            // btnCancelAP
            // 
            this.btnCancelAP.Enabled = false;
            this.btnCancelAP.Location = new System.Drawing.Point(424, 162);
            this.btnCancelAP.Name = "btnCancelAP";
            this.btnCancelAP.Size = new System.Drawing.Size(96, 23);
            this.btnCancelAP.TabIndex = 10;
            this.btnCancelAP.Text = "Cancel Auto Pilot";
            this.btnCancelAP.UseVisualStyleBackColor = true;
            this.btnCancelAP.Click += new System.EventHandler(this.btnCancelAP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 594);
            this.Controls.Add(this.btnCancelAP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTargetAltitude);
            this.Controls.Add(this.txtTargetSpeeds);
            this.Controls.Add(this.btnAutoPilot);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.Text = "18024092";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Connection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label tgPort;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label tgConnection;
        private System.Windows.Forms.Label tgIPAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJsonSent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJsonRecieved;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tgThrottle;
        private System.Windows.Forms.Label tgPitch;
        private System.Windows.Forms.TrackBar trkPitch;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPitchControl;
        private System.Windows.Forms.Label lblThrottleControl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblWarnings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throttle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarningCode;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnAutoPilot;
        private System.Windows.Forms.TextBox txtTargetSpeeds;
        private System.Windows.Forms.TextBox txtTargetAltitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelAP;
    }
}

