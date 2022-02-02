using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WebSocketsWindowsForm
{
    public partial class MainForm : Form
    {

        private readonly WSServer _ws;

        public MainForm()
        {
            InitializeComponent();
            _ws = new WSServer("ws://localhost:3333", this);
            Voicer.Init();
            Voicer.SayByKey("start");
            LoadPortsOnComboBox();
            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.Arguments = "/c node server.js";
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            //p.Start();
        }

        public TextBox getTextBox()
        {
            return tb_on_message;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_StartWS_Click(object sender, EventArgs e)
        {
            _ws.Start();
            SetEnebledButtonsWSControl();
            RefreshForm();
        }

        private void btn_CloseWS_Click(object sender, EventArgs e)
        {
            _ws.Stop();
            SetEnebledButtonsWSControl();
            RefreshForm();
        }

        private void RefreshForm()
        {
            tb_ws_status.Text = _ws.GetStatus();
            ActiveControl = null;
        }
        private void SetEnebledButtonsWSControl()
        {
            btn_CloseWS.Enabled = !btn_CloseWS.Enabled;
            btn_StartWS.Enabled = !btn_StartWS.Enabled;
        }

        private void LoadPortsOnComboBox()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cb_comport.Items.Add(port);
                Console.WriteLine(port);
            }
        }

        private void btn_arduino_connect_Click(object sender, EventArgs e)
        {

        }

        private void tick_render(object sender, EventArgs e)
        {

            tb_cpu_info.Text = ((int)performanceCounterCPU.NextValue()).ToString() + "%";
        }
    }
}
