using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace Strife
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //remember to set safe word in Register form
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

    }

        private void Response_Click(object sender, EventArgs e)
        {
    
            
            /*Geolocation part
          
            namespace LongLat
            {
                 public partial class Form1 : Form
        {
             public Form1()
            {
                InitializeComponent();
            }
            // The coordinate watcher.
            private GeoCoordinateWatcher Watcher = null;

            // Create and start the watcher.
            private void Form1_Load(object sender, EventArgs e)
            {
                // Create the watcher.

                Watcher = new GeoCoordinateWatcher();
                // Catch the StatusChanged event.

                Watcher.StatusChanged += Watcher_StatusChanged;
                // Start the watcher.

                Watcher.Start();
            }
            // The watcher’s status has change. See if it is ready.
            private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    // Display the latitude and longitude.
                    if (Watcher.Position.Location.IsUnknown)
                    {
                        txtLat.Text = "Cannot find location data";
                    }
                    else
                    {
                        txtLat.Text = Watcher.Position.Location.Latitude.ToString();
                        txtLong.Text = Watcher.Position.Location.Longitude.ToString();
                    }
                }
         }
        }
    }
*/

            string safeSentence = txtsafeSentence.Text;

            if (safeSentence != null)
            {
                MessageBox.Show("Help is on the way");
            }
            else
            {
                MessageBox.Show("Error: Invalid safe sentence. Please reenter safe sentence");
            }
        }

        private void txtsafeSentence_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string userInput = txtCancel.Text;

            if (userInput != null)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error: Invalid password. Please reenter password");
            }
        }

        private void txtsafeSentence_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
