using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;
using VisioForge.Types.VideoEffects;

namespace App_TOR
{
    public partial class Form1 : Form
    {
        DateTime data = DateTime.UtcNow.ToLocalTime();



        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VqK8q4zVP1cQa1xd7KmQYyFTCbcleFhUBalBkTKg",
            BasePath = "https://kontrola-jakosci-1d42b.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnStart_Click(object sender, EventArgs e)
        {

            string name = textBox_name_save.Text;
            string partia = textBox_partia_save.Text;
            string control_date = data.ToString("dd-MM-yyyy hh:mm:ss");
            string user_name = textBox_user_name_save.Text;
            string quantity = textBox_quantity_save.Text;
            string data_sales = textBox_data_sales_save.Text;      //numer kartonu
            string file_location = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + name + "_" + partia + ".mp4";

            videoCapture1.Video_CaptureDevice = videoCapture1.Video_CaptureDevicesInfo[0].Name;
            videoCapture1.Audio_CaptureDevice = videoCapture1.Audio_CaptureDevicesInfo[0].Name;
            videoCapture1.IP_Camera_Source = new VisioForge.Types.Sources.IPCameraSourceSettings() { URL = "http://192.168.43.1:8080/video" };
            videoCapture1.Audio_PlayAudio = videoCapture1.Audio_RecordAudio = false;
            videoCapture1.Output_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + name + "_" + partia + ".mp4";
            videoCapture1.Output_Format = new VFMP4v8v10Output(); //using MP4 output with default settings



            // we using existing simple code for MP4 capture

            // add text overlay
            videoCapture1.Video_Effects_Enabled = true;
            videoCapture1.Video_Effects_Clear();
            var text_name = new VFVideoEffectTextLogo(true) { Text = name, Top = 50, Left = 50, FontColor = Color.Red };
            var text_partia = new VFVideoEffectTextLogo(true) { Text = partia, Top = 100, Left = 50, FontColor = Color.Red };
            var text_control_date = new VFVideoEffectTextLogo(true) { Text = control_date, Top = 150, Left = 50, FontColor = Color.Red };
            var text_user_name = new VFVideoEffectTextLogo(true) { Text = user_name, Top = 200, Left = 50, FontColor = Color.Red };
            var text_quantity = new VFVideoEffectTextLogo(true) { Text = quantity, Top = 250, Left = 50, FontColor = Color.Red };
            var text_data_sales = new VFVideoEffectTextLogo(true) { Text = data_sales, Top = 300, Left = 50, FontColor = Color.Red };
            videoCapture1.Video_Effects_Add(text_name);
            videoCapture1.Video_Effects_Add(text_partia);
            videoCapture1.Video_Effects_Add(text_control_date);
            videoCapture1.Video_Effects_Add(text_user_name);
            videoCapture1.Video_Effects_Add(text_quantity);
            videoCapture1.Video_Effects_Add(text_data_sales);
            videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.IPCapture;
            //save_database(name, partia, control_date, user_name, quantity, partia, file_location, data_sales);
            videoCapture1.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           
            if (client != null)
            {
                MessageBox.Show("Connection is established");
            }
        }
     
        public async void save_database(string name, string partia, string control_date, string user_name,string quantity, string id_partia, string file_location, string data_sales)
        {
            var data = new Data
            {
                Name = name,
                Partia = partia,
                Control_date = control_date,
                User_name = user_name,
                Qantity = quantity,
                File_location = file_location,
                Data_sales = data_sales
            };
            SetResponse response = await client.SetTaskAsync("kontrola_jakości/" + id_partia, data);
            MessageBox.Show("Data Inserted");
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void fi_Click(object sender, EventArgs e)
        {
        

        }

        private async void firebase_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("kontrola_jakości/" + textBox2.Text);
            Data obj = response.ResultAs<Data>();
            textBox1.Text = obj.Name;
            textBox2.Text = obj.Partia;
            textBox3.Text = obj.Control_date;
            textBox4.Text = obj.User_name;
            textBox5.Text = obj.Qantity;
            textBox6.Text = obj.Data_sales;
            textBox7.Text = obj.File_location;
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            string filepath = textBox7.Text;
            FirebaseResponse response = await client.DeleteTaskAsync("kontrola_jakości/" + textBox2.Text);

            if (File.Exists(filepath))
            {

                File.Delete(filepath);
                MessageBox.Show("File Deleted");
               
            }
            else
            {

                MessageBox.Show("File Not Deleted");

            }
        }

        private void open_file_mp4_Click(object sender, EventArgs e)
        {

            //string paht = start_control();
            //System.Diagnostics.Process.Start(paht);

        }
    }
}