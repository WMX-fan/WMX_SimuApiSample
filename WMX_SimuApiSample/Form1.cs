using System;
using System.Windows.Forms;
using WMX3ApiCLR;
using WMX3ApiCLR.SimuApiCLR;

namespace WMX_SimuApiSample
{
    public partial class Form1 : Form
    {
        /// <summary>モーションコントロール</summary>
        private WMX3Api Device;

        /// <summary>モーションコントロールシミュレーター</summary>
        WMX3ApiCLR.SimuApiCLR.Simu SimulatorDevice;

        public Form1()
        {
            InitializeComponent();

            Device = new WMX3Api();
            SimulatorDevice = new Simu(Device);
            Disposed += Form1_Disposed;
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            Device?.CloseDevice();
            Device?.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevicesInfo devInfo = new DevicesInfo();
            Device.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\",
                DeviceType.DeviceTypeNormal,
                0xFFFFFFFF);

            Device.SetDeviceName("WMX_SimuApiSample");
            Device.GetAllDevices(ref devInfo);
        }


        /// <summary>入力アドレス(@byte,bit)</summary>
        //const float IN_SW0 = 1.2f;  

        private void InputONbutton_Click(object sender, EventArgs e)
        {
            SetInputValue((float)InputAddres.Value, true);
        }

        private void InputOFFbutton_Click(object sender, EventArgs e)
        {
            SetInputValue((float)InputAddres.Value, false);
        }

        /// <summary>
        /// 入力値の書き換え
        /// </summary>
        /// <param name="addres">操作する対象</param>
        /// <param name="value">値</param>
        public void SetInputValue(float addres ,bool value)
        {
            string sbit = addres.ToString();
            int dotIndex = sbit.IndexOf('.');
            int bit = 0;
            if (dotIndex != -1)
            {
                string fractionPart = sbit.Substring(dotIndex + 1);
                bit = int.Parse(fractionPart);
            }

            SimulatorDevice.SetInBit((int)addres, bit, value ? (byte)1 : (byte)0);
        }
    }
}
