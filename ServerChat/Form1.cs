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

namespace ServerChat
{
    public partial class Form1 : Form
    {
        byte[] data = new byte[1024];
        string input;
        IPEndPoint ipe;
        IPEndPoint clientipe;
        Socket server;
        Socket client;
        string mess = "server: ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ipe = new IPEndPoint(IPAddress.Any, 123);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(ipe);
                server.Listen(5);
                lbServer.Items.Add("waiting...");
                client = server.Accept();
                clientipe = (IPEndPoint)client.RemoteEndPoint;
                string conn = "Connected" + clientipe.Address + "  in port: " + clientipe.Port;
                lbServer.Items.Add(conn);
                client.Receive(data);
                lbServer.Items.Add(mess + Encoding.ASCII.GetString(data));
            }
            catch(SocketException sex)
            {
                lbServer.Items.Add(sex);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            input = txtServer.Text;
            lbServer.Items.Add(mess + input);
            txtServer.Text = "";
            data = Encoding.ASCII.GetBytes(mess + input);
            client.Send(data, data.Length, SocketFlags.None);
            client.Receive(data);
            lbServer.Items.Add(Encoding.ASCII.GetString(data));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
