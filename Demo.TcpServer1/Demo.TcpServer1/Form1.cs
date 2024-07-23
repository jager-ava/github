using STTech.BytesIO.Tcp;

namespace Demo.TcpServer1
{
    public partial class Form1 : Form
    {
        private TcpServer server;
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            server = new TcpServer();
            server.Port = int.Parse(tbPort1.Text);


            server.Started += Server_Started;
            server.Closed += Server_Closed;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;

            server.ClientConnectionAcceptedHandle = (s, e) =>
            {
                if (server.Clients.Count() < 3)
                {
                    return true;
                }
                else
                {
                    print($" 连接满了关闭[{e.ClientSocket.RemoteEndPoint}]");
                    return false;
                }
            };

        }

        private void Server_ClientDisconnected(object? sender, ClientDisconnectedEventArgs e)
        {
            print($"a[{e.Client.Host} {e.Client.Port}]断开连接");
        }

        private void Server_ClientConnected(object? sender, ClientConnectedEventArgs e)
        {
            print($"a[{e.Client.Host} {e.Client.Port}]开始连接");
            e.Client.OnDataReceived += Client_OnDataReceived;
        }

        private void Client_OnDataReceived(object? sender, STTech.BytesIO.Core.DataReceivedEventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            TcpClient client = (TcpClient)sender;
            tbLog.AppendText($"接受到[{client.RemoteEndPoint}]的消息:{e.Data.EncodeToString("GBK")}\r\n");

            foreach (TcpClient tcpClient in server.Clients) {
                if (tcpClient != client)
                {
                    tcpClient.SendAsync(e.Data);
                }
            }

        }

        private void Server_Closed(object? sender, EventArgs e)
        {
            print("停止监听");
        }

        private void Server_Started(object? sender, EventArgs e)
        {
            print("开始监听");
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            server.StartAsync();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            server.CloseAsync();
        }

        private void print(String msg) {
            tbLog.AppendText($"[{DateTime.Now}]:{msg}\r\n");
        }
    }
}
