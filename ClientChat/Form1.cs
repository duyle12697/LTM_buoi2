using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientChat
{
    public partial class Form1 : Form
    {
        byte[] data;
        string input;
        IPEndPoint ipe;
        Socket server;
        int recv;
        string datas;
        string mes = "client: ";



        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), 123);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipe);
                lbClient.Items.Add("Success connected");
            }
            catch (SocketException sex)
            {
                lbClient.Items.Add("fail connected");
                lbClient.Items.Add(sex.ToString());
                return;
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            input = txtClient.Text;
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(mes + input);
            lbClient.Items.Add(data);
            server.Send(data);
            data = new byte[1024];
            server.Receive(data);
            txtClient.Text = "";
            lbClient.Items.Add(Encoding.ASCII.GetString(data));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            this.Close();
        }
    }
}
