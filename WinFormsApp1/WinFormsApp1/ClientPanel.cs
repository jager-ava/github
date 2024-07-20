using STTech.BytesIO.Core;
using STTech.BytesIO.Serial;
using STTech.BytesIO.Tcp;
using System;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class ClientPanel : UserControl
    {
        private BytesClient tcpClient;
        private ClientPanel()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;


        }

        public ClientPanel(BytesClient tcpClient) : this()
        {
            this.tcpClient = tcpClient;

            propertyGrid1.SelectedObject = tcpClient;

            tcpClient.OnConnectedSuccessfully += TcpClient_OnConnectedSuccessfully;

            tcpClient.OnDataReceived += TcpClient_OnDataReceived;

            tcpClient.OnDisconnected += TcpClient_OnDisconnected;

            tcpClient.OnDataSent += TcpClient_OnDataSent;
        }

        private void TcpClient_OnDataSent(object? sender, DataSentEventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            print($"数据：{e.Data.EncodeToString("GBK")}");
        }

        private void TcpClient_OnDisconnected(object? sender, STTech.BytesIO.Core.DisconnectedEventArgs e)
        {
            print($"断开原因({e.ReasonCode})");
        }

        private void TcpClient_OnConnectedSuccessfully(object? sender, STTech.BytesIO.Core.ConnectedSuccessfullyEventArgs e)
        {
            print("连接成功");
        }

        private void TcpClient_OnDataReceived(object? sender, STTech.BytesIO.Core.DataReceivedEventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            print($"收到数据 ：{e.Data.EncodeToString("GBK")}");
        }

        private void print(string a)
        {
            tbrecv.AppendText($"[{DateTime.Now}]: {a}\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void propertyGrid1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            tcpClient.Disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            tcpClient.Send(tbSend.Text.GetBytes("GBk"));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbrecv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
