using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;


namespace SunManage.communication
{
    public partial class RS232 : Form
    {
        public static string mSerialPortState;
        public RS232()
        {
            try
            {
            InitializeComponent();
           
            CommPort com = CommPort.Instance;


            int found = 0;
            string[] portList = com.GetAvailablePorts();
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                comboBoxPortName.Items.Add(name);
                if (name == Settings.Port.PortName)
                    found = i;
            }
            if (portList.Length > 0)
                comboBoxPortName.SelectedIndex = found;

            Int32[] baudRates = {
                100,300,600,1200,2400,4800,9600,14400,19200,
                38400,56000,57600,115200,128000,256000,0
            };
            found = 0;
            for (int i = 0; baudRates[i] != 0; ++i)
            {
                comboBoxBaudRate.Items.Add(baudRates[i].ToString());
                if (baudRates[i] == Settings.Port.BaudRate)
                    found = i;
            }
            comboBoxBaudRate.SelectedIndex = found;

            comboBoxDataBits.Items.Add("5");
            comboBoxDataBits.Items.Add("6");
            comboBoxDataBits.Items.Add("7");
            comboBoxDataBits.Items.Add("8");
            comboBoxDataBits.SelectedIndex = Settings.Port.DataBits - 5;

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboBoxParity.Items.Add(s);
            }
            comboBoxParity.SelectedIndex = (int)Settings.Port.Parity;

            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                comboBoxStopBits.Items.Add(s);
            }
            comboBoxStopBits.SelectedIndex = (int)Settings.Port.StopBits;

            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                comboBoxHandshake.Items.Add(s);
            }
            comboBoxHandshake.SelectedIndex = (int)Settings.Port.Handshake;

            com.StatusChanged += OnStatusChanged;

            //com.DataReceived += OnDataReceived;

            com.Open();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Port.PortName = comboBoxPortName.Text;
                Settings.Port.BaudRate = Int32.Parse(comboBoxBaudRate.Text);
                Settings.Port.DataBits = comboBoxDataBits.SelectedIndex + 5;
                Settings.Port.Parity = (Parity)comboBoxParity.SelectedIndex;
                Settings.Port.StopBits = (StopBits)comboBoxStopBits.SelectedIndex;
                Settings.Port.Handshake = (Handshake)comboBoxHandshake.SelectedIndex;
                CommPort com = CommPort.Instance;
                com.Open();


                if (com.IsOpen)
                {


                    MessageBox.Show("串口COM打开成功", "提示");
                }
                Settings.Write();
               
                buttonOpen.Enabled = false;
                comboBoxPortName.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                comboBoxDataBits.Enabled = false;
                comboBoxParity.Enabled = false;
                comboBoxStopBits.Enabled = false;
                comboBoxHandshake.Enabled = false;
               

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
                return;
            }
            //Close();
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
             try
            {
          
            buttonOpen.Enabled = true;
            comboBoxPortName.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            comboBoxDataBits.Enabled = true;
            comboBoxParity.Enabled = true;
            comboBoxStopBits.Enabled = true;
            comboBoxHandshake.Enabled = true;
            CommPort com = CommPort.Instance;


           
            if (com.IsOpen == false)
            {
                MessageBox.Show("串口没被打开", "提示");
            }
            if (com.IsOpen == true)
            {
                com.Close();
            }
            }
             catch (Exception ex)
             {
                 LogClass.WriteLogFile ("Exception:" + ex.ToString());
             }
        }

        // delegate used for Invoke
        internal delegate void StringDelegate(string data);
        /// <summary>
        /// Update the connection status
        /// </summary>
        
        public void OnStatusChanged(string status)
        {
            try
            {
            //Handle multi-threading
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(OnStatusChanged), new object[] { status });
                return;
            }
            mSerialPortState = status;
            USB.mUSBState = "";
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
           
        }

        private void RS232_Load(object sender, EventArgs e)
        {
            try
            {
              CommPort com = CommPort.Instance;



              if (com.IsOpen == true)
              {
                  buttonOpen.Enabled = false;
                  comboBoxPortName.Enabled = false;
                  comboBoxBaudRate.Enabled = false;
                  comboBoxDataBits.Enabled = false;
                  comboBoxParity.Enabled = false;
                  comboBoxStopBits.Enabled = false;
                  comboBoxHandshake.Enabled = false;
              }
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
    }
}
