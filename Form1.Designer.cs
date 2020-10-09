namespace App_TOR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms1 = new VisioForge.Types.VideoRendererSettingsWinForms();
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.firebase = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.data_sales_save = new System.Windows.Forms.Label();
            this.quantity_save = new System.Windows.Forms.Label();
            this.user_name_save = new System.Windows.Forms.Label();
            this.partia_save = new System.Windows.Forms.Label();
            this.name_save = new System.Windows.Forms.Label();
            this.textBox_data_sales_save = new System.Windows.Forms.TextBox();
            this.textBox_quantity_save = new System.Windows.Forms.TextBox();
            this.textBox_user_name_save = new System.Windows.Forms.TextBox();
            this.textBox_partia_save = new System.Windows.Forms.TextBox();
            this.textBox_name_save = new System.Windows.Forms.TextBox();
            this.open_file_mp4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture1.Audio_CaptureDevice_Path = null;
            this.videoCapture1.Audio_CaptureSourceFilter = null;
            this.videoCapture1.Audio_Channel_Mapper = null;
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PCM_Converter = null;
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.BDA_Source = null;
            this.videoCapture1.ChromaKey = null;
            this.videoCapture1.Custom_Source = null;
            this.videoCapture1.CustomRedist_Auto = true;
            this.videoCapture1.CustomRedist_Enabled = false;
            this.videoCapture1.CustomRedist_Path = null;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_DisableMessageDialogs = false;
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Debug_Telemetry = false;
            this.videoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.Decklink_Output = null;
            this.videoCapture1.Decklink_Source = null;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Face_Tracking = null;
            this.videoCapture1.IP_Camera_Source = null;
            this.videoCapture1.Location = new System.Drawing.Point(12, 26);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture1.Motion_Detection = null;
            this.videoCapture1.Motion_DetectionEx = null;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Demuxer = null;
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_Output = null;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.OSD_Enabled = false;
            this.videoCapture1.Output_Filename = "C:\\Users\\hubert.gosciniak\\OneDrive - W.Legutko Przedsiębiorstwo Hodowlano-Nasienn" +
    "e Sp. z o.o\\Dokumenty\\VisioForge\\output.avi";
            this.videoCapture1.Output_Format = null;
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_ChromaKeySettings = null;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture1.Push_Source = null;
            this.videoCapture1.Screen_Capture_Source = null;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_GMFMode = true;
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture1.Size = new System.Drawing.Size(906, 635);
            this.videoCapture1.Start_DelayEnabled = false;
            this.videoCapture1.TabIndex = 0;
            this.videoCapture1.Tags = null;
            this.videoCapture1.Timeshift_Settings = null;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture1.Video_Crop = null;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_Effects_GPU_Enabled = false;
            this.videoCapture1.Video_Effects_MergeImageLogos = false;
            this.videoCapture1.Video_Effects_MergeTextLogos = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_X = 16;
            videoRendererSettingsWinForms1.Aspect_Ratio_Y = 9;
            videoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black;
            videoRendererSettingsWinForms1.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.Auto;
            videoRendererSettingsWinForms1.Deinterlace_VMR9_Mode = null;
            videoRendererSettingsWinForms1.Deinterlace_VMR9_UseDefault = true;
            videoRendererSettingsWinForms1.Flip_Horizontal = false;
            videoRendererSettingsWinForms1.Flip_Vertical = false;
            videoRendererSettingsWinForms1.RotationAngle = 0;
            videoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox;
            videoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.EVR;
            videoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.EVR;
            videoRendererSettingsWinForms1.Zoom_Ratio = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftX = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftY = 0;
            this.videoCapture1.Video_Renderer = videoRendererSettingsWinForms1;
            this.videoCapture1.Video_Resize = null;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = true;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.VLC_Path = null;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(58, 741);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 120);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(574, 741);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(278, 120);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1131, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1133, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1133, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1133, 332);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 31);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1133, 393);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 31);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1133, 444);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 31);
            this.textBox6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "partia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1000, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "control_date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1000, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "user_name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1000, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1002, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "data_sales";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1133, 510);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(877, 31);
            this.textBox7.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1000, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "file_location";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firebase
            // 
            this.firebase.Location = new System.Drawing.Point(1644, 160);
            this.firebase.Name = "firebase";
            this.firebase.Size = new System.Drawing.Size(114, 84);
            this.firebase.TabIndex = 17;
            this.firebase.Text = "Firebase";
            this.firebase.UseVisualStyleBackColor = true;
            this.firebase.Click += new System.EventHandler(this.firebase_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1644, 289);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 91);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete Files";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1158, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dane z Bazy danych Firebase";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1158, 625);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Zapisz do bazy danych";
            // 
            // data_sales_save
            // 
            this.data_sales_save.AutoSize = true;
            this.data_sales_save.Location = new System.Drawing.Point(1087, 910);
            this.data_sales_save.Name = "data_sales_save";
            this.data_sales_save.Size = new System.Drawing.Size(117, 25);
            this.data_sales_save.TabIndex = 32;
            this.data_sales_save.Text = "data_sales";
            // 
            // quantity_save
            // 
            this.quantity_save.AutoSize = true;
            this.quantity_save.Location = new System.Drawing.Point(1085, 859);
            this.quantity_save.Name = "quantity_save";
            this.quantity_save.Size = new System.Drawing.Size(88, 25);
            this.quantity_save.TabIndex = 31;
            this.quantity_save.Text = "quantity";
            // 
            // user_name_save
            // 
            this.user_name_save.AutoSize = true;
            this.user_name_save.Location = new System.Drawing.Point(1085, 798);
            this.user_name_save.Name = "user_name_save";
            this.user_name_save.Size = new System.Drawing.Size(119, 25);
            this.user_name_save.TabIndex = 30;
            this.user_name_save.Text = "user_name";
            // 
            // partia_save
            // 
            this.partia_save.AutoSize = true;
            this.partia_save.Location = new System.Drawing.Point(1085, 735);
            this.partia_save.Name = "partia_save";
            this.partia_save.Size = new System.Drawing.Size(66, 25);
            this.partia_save.TabIndex = 28;
            this.partia_save.Text = "partia";
            // 
            // name_save
            // 
            this.name_save.AutoSize = true;
            this.name_save.Location = new System.Drawing.Point(1085, 681);
            this.name_save.Name = "name_save";
            this.name_save.Size = new System.Drawing.Size(65, 25);
            this.name_save.TabIndex = 27;
            this.name_save.Text = "name";
            // 
            // textBox_data_sales_save
            // 
            this.textBox_data_sales_save.Location = new System.Drawing.Point(1218, 910);
            this.textBox_data_sales_save.Name = "textBox_data_sales_save";
            this.textBox_data_sales_save.Size = new System.Drawing.Size(188, 31);
            this.textBox_data_sales_save.TabIndex = 26;
            // 
            // textBox_quantity_save
            // 
            this.textBox_quantity_save.Location = new System.Drawing.Point(1218, 859);
            this.textBox_quantity_save.Name = "textBox_quantity_save";
            this.textBox_quantity_save.Size = new System.Drawing.Size(188, 31);
            this.textBox_quantity_save.TabIndex = 25;
            // 
            // textBox_user_name_save
            // 
            this.textBox_user_name_save.Location = new System.Drawing.Point(1218, 798);
            this.textBox_user_name_save.Name = "textBox_user_name_save";
            this.textBox_user_name_save.Size = new System.Drawing.Size(188, 31);
            this.textBox_user_name_save.TabIndex = 24;
            // 
            // textBox_partia_save
            // 
            this.textBox_partia_save.Location = new System.Drawing.Point(1216, 735);
            this.textBox_partia_save.Name = "textBox_partia_save";
            this.textBox_partia_save.Size = new System.Drawing.Size(188, 31);
            this.textBox_partia_save.TabIndex = 22;
            // 
            // textBox_name_save
            // 
            this.textBox_name_save.Location = new System.Drawing.Point(1216, 681);
            this.textBox_name_save.Name = "textBox_name_save";
            this.textBox_name_save.Size = new System.Drawing.Size(188, 31);
            this.textBox_name_save.TabIndex = 21;
            // 
            // open_file_mp4
            // 
            this.open_file_mp4.Location = new System.Drawing.Point(1795, 682);
            this.open_file_mp4.Name = "open_file_mp4";
            this.open_file_mp4.Size = new System.Drawing.Size(225, 107);
            this.open_file_mp4.TabIndex = 33;
            this.open_file_mp4.Text = "Open file mp4";
            this.open_file_mp4.UseVisualStyleBackColor = true;
            this.open_file_mp4.Click += new System.EventHandler(this.open_file_mp4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2085, 1070);
            this.Controls.Add(this.open_file_mp4);
            this.Controls.Add(this.data_sales_save);
            this.Controls.Add(this.quantity_save);
            this.Controls.Add(this.user_name_save);
            this.Controls.Add(this.partia_save);
            this.Controls.Add(this.name_save);
            this.Controls.Add(this.textBox_data_sales_save);
            this.Controls.Add(this.textBox_quantity_save);
            this.Controls.Add(this.textBox_user_name_save);
            this.Controls.Add(this.textBox_partia_save);
            this.Controls.Add(this.textBox_name_save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.firebase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.videoCapture1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button firebase;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label data_sales_save;
        private System.Windows.Forms.Label quantity_save;
        private System.Windows.Forms.Label user_name_save;
        private System.Windows.Forms.Label partia_save;
        private System.Windows.Forms.Label name_save;
        private System.Windows.Forms.TextBox textBox_data_sales_save;
        private System.Windows.Forms.TextBox textBox_quantity_save;
        private System.Windows.Forms.TextBox textBox_user_name_save;
        private System.Windows.Forms.TextBox textBox_partia_save;
        private System.Windows.Forms.TextBox textBox_name_save;
        private System.Windows.Forms.Button open_file_mp4;
    }
}

