using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace EventDriven_18024092
{

    public partial class Form1 : Form
    {
        //Creating new deleggates that will later be used with events
        delegate void ControlsUpdated(ControlUpdate update);
        delegate void TelemetryUpdated(TelemetryUpdate update);
        delegate void WarningUpdated(string warning);
        
        //Events created to be used later
        event ControlsUpdated eventControls;
        event TelemetryUpdated eventTelemetry;
        event WarningUpdated eventWarnings;

        //ControlUpdate is used to store values from Form Throttle and Pitch controls
        class ControlUpdate
        {
            public double Throttle;
            public double ElevatorPitch;
        }

        //Used to store Telemetery data when recieved from Server
        class TelemetryUpdate
        {
            public double Altitude;
            public double Speed;
            public double Pitch;
            public double VerticalSpeed;
            public double Throttle = 0;
            public double ElevatorPitch;
            public double WarningCode;
        }


        //Defines client
        TcpClient m_client;

        //Creates 2 nullptr threads 
        Thread listeningThread = null;
        Thread autoPilot = null;

        //Creates an instance of both Control Update and Telemetry Update
        ControlUpdate CU;
        TelemetryUpdate TU;
        public Form1()
        {
            InitializeComponent();
            //Assign events with their repective delegates and functions 
            eventControls += new ControlsUpdated(SendData);
            eventTelemetry += new TelemetryUpdated(RecievedMessage);
            eventWarnings += new WarningUpdated(UpdateWarnings);

       
            TU = new TelemetryUpdate();
            CU = new ControlUpdate();
        }

        delegate void AddMessageDelegate(string message);

        //This function is used to listen for messages from the server
        //This function operates on a different thread
        private void listen()
        {
            NetworkStream stream = m_client.GetStream(); //Gets the data from the steam
            while (true)
            {
                byte[] buffer = new byte[256]; //Defines the max amount oof bytes expected
                int num_bytes = stream.Read(buffer, 0, 256);

                if (num_bytes>0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, num_bytes); //Converts the recieved data into ASCII for a string variable
                    AddMessage(message); //Passing data unto AddMessage
                }
            }
        }

        private void AddMessage(string message)
        {
            if (this.InvokeRequired) //Invoke the AddMessageDelegate is required
            {
                this.Invoke(new AddMessageDelegate(AddMessage), new object[] { message });
            }
            else
            {
                //Deserialiing the JSON message into a TelemeteryUpdate instance 
                JavaScriptSerializer Deserializer = new JavaScriptSerializer();
                TelemetryUpdate telemetryUpdate = Deserializer.Deserialize<TelemetryUpdate>(message);
                lblJsonRecieved.Text = message; //Updates the label with the recieved JSON message
                eventTelemetry?.Invoke(telemetryUpdate); //Invoke the eventTelemetery event which using a delegate and the message ends up being recieved in the RecievedMessage Function
            }
        }
        private void RecievedMessage(TelemetryUpdate updates)
        {
            if (updates.WarningCode != 0) //Determines if a warning code was recieved
            {
                string warning = "";
                switch (updates.WarningCode)
                {
                    //Assign the approperiate message to each warning
                    case 1:
                        warning = "Too Low (less than 1000ft)";
                        break;
                    case 2:
                        warning = "Stall";
                            break;
                    default:
                        break;
                }
                //Invokes eventWarning using the assigned delegate the message ends up in UpdateWarnings
                eventWarnings?.Invoke(warning);
            }
            else
            {
                lblWarnings.Text = updates.WarningCode.ToString(); //If no warning is recieved the the warnings label is set to 0
            }

            //update lables
           
            lblAltitude.Text = updates.Altitude.ToString();
            lblSpeed.Text = updates.Speed.ToString();
            lblPitch.Text = updates.Pitch.ToString();
            lblVerticalSpeed.Text = updates.VerticalSpeed.ToString();
            lblThrottle.Text = updates.Throttle.ToString();
            lblElevatorPitch.Text = updates.ElevatorPitch.ToString();

            //update data view table
            tabData.Rows.Add(new Object[] { updates.Altitude, updates.Speed, updates.Pitch, updates.VerticalSpeed, updates.Throttle, updates.ElevatorPitch, updates.WarningCode });
        }
        private void UpdateWarnings(string warning)
        {
            //Updates warning labe;
            lblWarnings.Text = "Warning: " + warning;
        }

        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_client = new TcpClient();
            IPAddress ip = IPAddress.Parse(txtIPAddress.Text); //Gets the input IP address from the text box and saves as a IPAddress variable
             int port = int.Parse(txtPort.Text);
            m_client.Connect(ip, port); //This attempts to correct to the defined IP and the port

            MessageBox.Show("Connected to: " + txtIPAddress.Text); //Shows that the client has connected 
            lblConnectionStatus.Text = txtIPAddress.Text;
            listeningThread = new Thread(new ThreadStart(listen)); //Defines the listeningThread
            listeningThread.Start(); //Starts the listening thread

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ControlUpdate update = new ControlUpdate(); //Creates new instance of ControlUpdate
            update.Throttle = Convert.ToDouble(trkThrottle.Value); //Defines the Throttle of Control Update with the track bar value
            update.ElevatorPitch = Convert.ToDouble(trkPitch.Value); //Defines the pitch of control update with the track bar value
            eventControls?.Invoke(update); //Invokes the eventControls events using the assigned delegate sends the update instance to SendData
        }

        private void SendData(ControlUpdate updates)
        {

            //Serialises the contents of updates to JSON format
            JavaScriptSerializer Serializer = new JavaScriptSerializer();
            string jsonString = Serializer.Serialize(updates);
            NetworkStream stream = m_client.GetStream();
            byte[] rawData = Encoding.ASCII.GetBytes(jsonString);
            lblJsonSent.Text = jsonString; //Redefines the text inside lblJsonSent with the new message
            stream.Write(rawData, 0, rawData.Length); //Writes this message to the stream for the server to pick up
        }

        private void trkThrottle_Scroll(object sender, EventArgs e)
        {
            lblThrottleControl.Text = trkThrottle.Value.ToString(); //Uses the trackbar to set the value of the lbl
        }

        private void trkPitch_Scroll(object sender, EventArgs e)
        {
            lblPitchControl.Text = trkPitch.Value.ToString(); //Uses the trackbar to set the value of the lbl
        }

        private void updateFormControls(ControlUpdate CU)
        {
            if (this.InvokeRequired) //Ensure that the delegate has been invoked before use
            {
                this.Invoke(new ControlsUpdated(updateFormControls), new object[] { CU });
            }
            else
            {
                trkThrottle.Value = Convert.ToInt32(CU.Throttle); //Update the status of the throttle track bar
                trkPitch.Value = Convert.ToInt32(CU.ElevatorPitch); //Update the status of the pitch track bar
                lblThrottleControl.Text = CU.Throttle.ToString(); //Update the throrttle label
                lblPitchControl.Text = CU.ElevatorPitch.ToString(); //Update the pitch label
                eventControls.Invoke(CU); //Invoek the eventControls event, this event ends with the new data being sent to the server
            }
        }

        private void btnAutoPilot_Click(object sender, EventArgs e)
        {
            btnAutoPilot.Enabled = false;
            btnCancelAP.Enabled = true;
            autoPilot = new Thread(new ThreadStart(AutomaticControls)); //When pressed defines new thread
            autoPilot.Start(); //Starts new thread
        }
        private void AutomaticControls() //the auto pilot operates in a different thread
        {
            double targetSpeed = 0;
            double targetAltitude = 0;
            if (txtTargetSpeeds.Text == "")
            {
                targetSpeed = Convert.ToDouble(lblSpeed.Text); //if no targer speed is entered the plane will keep at the same speed
            }
            else { targetSpeed = Convert.ToDouble(txtTargetSpeeds.Text); } //Else the speed in the correct text box is set to the new target speed

            if (txtTargetAltitude.Text == "")
            {
                targetAltitude = Convert.ToDouble(lblAltitude.Text);//if no targer altitude is entered the plane will keep at the same altitude
            }
            else { targetAltitude = Convert.ToDouble(txtTargetAltitude.Text); }//Else the altitude in the correct text box is set to the new target altitude


            while (true) //Infinite loop, this loop is killed when the thread is closed
            {

                //Defines each variable with the correct values
                double labelSpeed = Convert.ToDouble(lblSpeed.Text);
                double labelAltidude = Convert.ToDouble(lblAltitude.Text);
                double labelPitch = Convert.ToDouble(lblPitch.Text);
                double labelThrottle = Convert.ToDouble(lblThrottle.Text);
                double labelElevatorPitch = Convert.ToDouble(lblElevatorPitch.Text);
                ControlUpdate CU = new ControlUpdate(); //Defines a new instance of ControlUpdate

                //If the plane is going too slow
                if (targetSpeed > labelSpeed)
                {
                    if ((labelThrottle + 10) <= 100)
                    {
                        CU.Throttle = labelThrottle + 10; //Increase throttle by 10
                    }
                    else
                    {
                        CU.Throttle = 100; //Ensures the thottle cannot go over 100
                    }
                }

                //If the plane is going too fast
                if (targetSpeed < labelSpeed)
                {
                    if ((labelThrottle - 10) >= 0)
                    {
                        CU.Throttle = labelThrottle - 10; //Decrease throttle by 10
                    }
                    else
                    {

                        CU.Throttle = 0; //Ensures the throttle cannot go below 0
                    }
                }
                if (targetSpeed == labelSpeed) //If at desired speed throttle is 0
                {
                    CU.Throttle = 0; 
                }

                //The next checks determine the plane altitude
                //The plane cannot exceed 20 degrees in pitch
                //The plane cannot go below -5 degrees in pitch
                //The elevatorsa cannot exceed setting 2
                //The elevators cannot go lower than -1
                //These protects are placed so the plane remains stable

                //Checks if plane is currently lower altitude that target altitude 

                if (targetAltitude < labelAltidude)
                {
                    if (labelPitch < -5) //If plane pitch degrees is higher than -5 degrees
                    {
                        if (labelElevatorPitch < 2) //If plane elevators are lower than 2
                        {
                            CU.ElevatorPitch = labelElevatorPitch + 1; //Increase elevators

                            CU.Throttle = 50; //Increase speed to pull out of nose dive
                        }
                        else
                        {
                            CU.ElevatorPitch = 2; //Else set elevators to 2
                        }
                    }
                    else
                    {
                        if (labelElevatorPitch > -1) //If elevators are not set below -1
                        {
                            CU.ElevatorPitch = labelElevatorPitch - 1; // Lower elevators
                        }
                        else
                        {
                            CU.ElevatorPitch = -1; //Set elevators to -1
                        }
                    }
                }

                //If plane is above target altitude 
                if (targetAltitude > labelAltidude)
                {
                    if (labelPitch > 20) //if angle of attack is greater than 20
                    {
                        if (labelElevatorPitch > -1) //Ensuring no more than -1 elevator control
                        {
                            CU.ElevatorPitch = labelElevatorPitch - 1; //Decrease elevators
                        }
                        else
                        {
                            CU.ElevatorPitch = -1; 
                        }
                    }
                    else
                    {

                        if (labelElevatorPitch < 2) //If elevators are not above 2
                        {
                            CU.ElevatorPitch = labelElevatorPitch + 1; //Increase elvators
                        }
                        else
                        { 
                             CU.ElevatorPitch = 2; //Set elevators to 2
                        }
                    }
                   
                }
               //Send new ControlUpdate to updateformcontrols to be send the data to the server
                updateFormControls(CU);
                Thread.Sleep(100); //Sleeps the thread 
            }
        }

        //When the auto pilot get ended
        private void btnCancelAP_Click(object sender, EventArgs e)
        {
            btnAutoPilot.Enabled = true;
            btnCancelAP.Enabled = false;
            autoPilot.Abort(); //Abort thread
            autoPilot = null; //Set thread pointer to null
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If either thread is still running this will abort them
            if (listeningThread != null)
            {
                listeningThread.Abort();
            }
            if (autoPilot != null)
            {
                autoPilot.Abort();
            }
        }
    }
}
