using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace New_Event_driven_assignment__2
{
    public partial class TheSimulator : Form
    {  TcpClient Plane;
        Thread SendData_Thread = null;


        private void Connection_button_Click(object sender, EventArgs e)
        {
            Plane = new TcpClient();
            int Port = Convert.ToInt32(Port_Button.Text);
            IPAddress IP = IPAddress.Parse(IP_Button.Text);

            DialogResult Keypressed;
            Keypressed = MessageBox.Show("Are you sure you would like to connct to the simulator ", "WARNING ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Keypressed == DialogResult.Yes)
            { 
                
                Plane.Connect(IP, Port);
                MessageBox.Show("Connected to " + IP_Button.Text);

                SendData_Thread = new Thread(new ThreadStart(Listen));
                SendData_Thread.Start();

            }
            if (Keypressed == DialogResult.No)
            {
                return;
            }
        
        }


               private void Listen()
                    {
                        NetworkStream stream = Plane.GetStream();
                        while (true)
                        {
                            byte[] buffer = new byte[255];
                            int byteNum = stream.Read(buffer, 0, 255);
                            if (byteNum > 0)
                            {
                   
                            }
                        }


                    }




        public TheSimulator()
        {
            InitializeComponent(); 
            TrackbarEvent += new TrackbarDelegate(UpdateControls);
            telemetryDetails = new TelemetryUpdate();
            TelemetryUpdateEvent += new DataReceivedDelegate(UpdateTelemetry);
           

        }






        private void TheSimulator_Load(object sender, EventArgs e)
        {
                  MessageBox.Show("WELCOME TO THE SIMULATOR, MAKE SURE YOU OPEN THE PORT BEFORE CONNECTING TO THE SERVER ! ", " WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }



        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        //The struc for me to locate the know the value of the controls when changed 
        public struct ControlsUpdate
        {
            public double Throttle;// one hold one value that will be a double 

            public double ElevatorPitch;// one hold one value that will be a double 
        }

        
        //the EVent and delegate 
        public delegate void TrackbarDelegate(ControlsUpdate controlsUpdate);
        public event TrackbarDelegate TrackbarEvent;
        TrackbarDelegate TD;
        ControlsUpdate T;
        ControlsUpdate P;

        public void UpdateControls(ControlsUpdate SendValue)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new TrackbarDelegate(UpdateControls), new object[] { SendValue });
            }
            else
            {
                JavaScriptSerializer SerializerTrack = new JavaScriptSerializer();
                string jsonsendString = SerializerTrack.Serialize(SendValue);
                ControlInformation.AppendText(jsonsendString);
                
            }


            NetworkStream stream = Plane.GetStream();

            SendValue.Throttle = Throttle1.Value;
            SendValue.ElevatorPitch= Pitch1.Value;

            JavaScriptSerializer SerializerTrackgo = new JavaScriptSerializer();
            string jsonsendStringgo = SerializerTrackgo.Serialize(SendValue);

            stream = Plane.GetStream();
            byte[] rawData = Encoding.ASCII.GetBytes(jsonsendStringgo);
            stream.Write(rawData, 0, rawData.Length);
            stream.Flush();

        }


        private void Throttle1_Scroll(object sender, EventArgs e)
        {

            Double throttleValue = this.Throttle1.Value;
            ThrottleButton.Text = throttleValue.ToString();
            T.Throttle = throttleValue;
            //this  will fire the event 
           TrackbarEvent?.Invoke(T);

           //This allows me send information to the DataVeiwGrid to the right cells
            Controlslist.Rows.Insert(0, throttleValue.ToString(), P.ElevatorPitch);
            Controlslist.Refresh();

        }
        private void ThrottleButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// ///////////////////////////////////////////////////
        /// </summary


       

        private void Pitch1_Scroll(object sender, EventArgs e)
        {
            //Tthe messagebox uderv the dataveiwgrid
            Double pitchValue = this.Pitch1.Value;
            PitchButton.Text = pitchValue.ToString();
            P.ElevatorPitch = pitchValue;
            //this  will fire the event 
            TrackbarEvent?.Invoke(P);


    //This allows me send information to the DataVeiwGrid to the right cells
            Controlslist.Rows.Insert(0, T.Throttle, pitchValue.ToString());
            Controlslist.Refresh();

          
        

            //This will allow the information to be imported onto the message box

        }




        private void PitchButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 


      // The message box that allows us to know the current level of the drag bars
        private void ControlInformation_TextChanged(object sender, EventArgs e)

        {
           

        }

        // The dataview list box which shows the individual levels of the drag bar
        private void Controlslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>






        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////// HHlllllpppppppppppp
        /// </summary>
        /// 



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public struct TelemetryUpdate
        {
            public double Altitude;
            public double Speed;
            public double Pitch;
            public double VerticalSpeed;
            public double Throttle;
            public double ElevatorPitch;
            public int WarningCode;

        }
       TelemetryUpdate telemetryDetails;


        // Event delegate
        public delegate void DataReceivedDelegate (double Altitude, double Speed, double Pitch, double VerticalSpeed, double Throttle, double ElevatorPitch, int WarningCode);
        // The event itself
         public event DataReceivedDelegate TelemetryUpdateEvent;

  
        

        public void UpdateTelemetry(double Altitude, double Speed, double Pitch, double VerticalSpeed, double Throttle, double ElevatorPitch, int WarningCode)
        {
            if (this.InvokeRequired)
            {
                //this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] { Altitude, Speed, Pitch, VerticalSpeed, Throttle, ElevatorPitch, WarningCode });
                this.Invoke(new DataReceivedDelegate (UpdateTelemetry), new object[] { Altitude });
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] {  Speed });
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] {  Pitch });
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] { VerticalSpeed });
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] { Throttle});
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] {ElevatorPitch});
                this.Invoke(new DataReceivedDelegate(UpdateTelemetry), new object[] { WarningCode });
            }
            else
            {
              


                JavaScriptSerializer SerializerData = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails1 = SerializerData.Deserialize< TelemetryUpdate> (Altitude.ToString());

                JavaScriptSerializer SerializerData2 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails2 = SerializerData2.Deserialize<TelemetryUpdate>(Speed.ToString());

                JavaScriptSerializer SerializerData3 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails3 = SerializerData3.Deserialize<TelemetryUpdate>(Pitch.ToString());

                JavaScriptSerializer SerializerData4 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails4 = SerializerData4.Deserialize<TelemetryUpdate>(VerticalSpeed.ToString());

                JavaScriptSerializer SerializerData5 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails5 = SerializerData5.Deserialize<TelemetryUpdate>(Throttle.ToString());

                JavaScriptSerializer SerializerData6 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails6 = SerializerData6.Deserialize<TelemetryUpdate>(ElevatorPitch.ToString());

                JavaScriptSerializer SerializerData7 = new JavaScriptSerializer();
                TelemetryUpdate telemetryDetails7 = SerializerData7.Deserialize<TelemetryUpdate>(WarningCode.ToString());

                AltitudeR_Button.Text = telemetryDetails1.Altitude.ToString() + "ft";

                SpeedR_Button.Text = telemetryDetails2.Speed.ToString() + "Knts";

                PitchR_Button.Text = telemetryDetails3.Pitch.ToString();

                VerticalSpeedR_Button.Text = telemetryDetails4.VerticalSpeed.ToString() + "FPM";

                ThrottleR_Button.Text = telemetryDetails5.Throttle.ToString();

                ElevatorPitchR_Button.Text = telemetryDetails6.ElevatorPitch.ToString();

                WarningR_Button.Text = telemetryDetails7.WarningCode.ToString();

                

            telemetryDetails.Altitude = Altitude;
            telemetryDetails.Speed = Speed;
            telemetryDetails.Pitch = Pitch;
            telemetryDetails.Throttle = Throttle;
            telemetryDetails.VerticalSpeed = VerticalSpeed;
            telemetryDetails.WarningCode = WarningCode;
            telemetryDetails.ElevatorPitch = ElevatorPitch;


          
            }
            


        }



        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////Help
        /// </summary>


        // This will allow me to receive all the data coming in from the simulator 

        private void AltitudeR_Button_Click(object sender, EventArgs e)
        {
           
            ////This is to import the receiving dataing from the simulator
      
        }

  
        private void SpeedR_Button_Click(object sender, EventArgs e)
        {

            
   
          
            ////This is to import the receiving dataing from the simulator 
        

        }

        private void PitchR_Button_Click(object sender, EventArgs e)
        {
            
            ////This is to import the receiving dataing from the simulator 
          
        }

        private void VerticalSpeedR_Button_Click(object sender, EventArgs e)
        {
           
            ////This is to import the receiving dataing from the simulator 
          
        }

        private void ThrottleR_Button_Click(object sender, EventArgs e)
        {
            ////This is to import the receiving dataing from the simulator 
            
        }

        private void ElevatorPitchR_Button_Click(object sender, EventArgs e)
        {
            
 
            ////This is to import the receiving dataing from the simulator 
        }  


        private void WarningR_Button_Click(object sender, EventArgs e)
        {

            if (telemetryDetails.WarningCode <= 0)
            {
                Console.WriteLine("NO WARNING ");
            }
            if (telemetryDetails.WarningCode <= 1)
            {
                Console.WriteLine(" Too Low (less than 1000ft)");
            }
            if (telemetryDetails.WarningCode <= 2)
            {
                Console.WriteLine(" STALL");
            }



        }




        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        ///////////////////////////////////////////////The connection
      



        private void ConnectionGB_Enter(object sender, EventArgs e)
        {

        }



      

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

       



        ///The other basic information in the connection GroupoBox

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IP_Button_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Port_Button_TextChanged(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //Thiss allows me to send text to the simulator 
         private void SendText_Button_Click(object sender, EventArgs e)
         {

            NetworkStream stream = Plane.GetStream();

            //This allows me to send The message to the server. 
            string message = "  INCOMING MESSAGE...  " + SendText_TextBox.Text ;
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);


           
        }


        private void SendText_TextBox_TextChanged(object sender, EventArgs e)
          {

          }





        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
       
          // This allows me to exit the program

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult Keypressed;

            Keypressed = MessageBox.Show("Are you sure you would like to exit the panel", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Keypressed == DialogResult.Yes)
            {

               Close();
               
               
            }
            if (Keypressed == DialogResult.No)
            {
                return;
            }
        }

      
    }
}
