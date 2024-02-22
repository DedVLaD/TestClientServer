using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TestKlient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private async void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(addressServer_txt.Text, 9999);
                Console.WriteLine("Connected to server");


                client.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            //try
            //{
            //    TcpClient client = new TcpClient(addressServer_txt.Text, 9999);
            //    Console.WriteLine("Connected to server");

            //    // Проверка соединения с сервером
            //    using (TcpClient tempClient = new TcpClient(addressServer_txt.Text, 9999))
            //    {
            //        NetworkStream tempStream = tempClient.GetStream();
            //        byte[] testMessage = Encoding.ASCII.GetBytes("Server is shutting down.");
            //        await tempStream.WriteAsync(testMessage, 0, testMessage.Length);

            //        byte[] buffer = new byte[1];
            //        int bytesRead = await tempStream.ReadAsync(buffer, 0, 1);
            //        if (bytesRead == 0)
            //        {
            //            Console.WriteLine("Connection to server lost");
            //        }
            //    }

            //    client.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

        }

        private void CreateFileData_btn_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(addressServer_txt.Text, 9999);
                NetworkStream stream = client.GetStream();

                string fileName = fileName_txt.Text;
                string fileData = fileDate_txt.Text;

                string dataToSend = "CreateFile: " + fileName + ";" + fileData;
                byte[] dataBytes = Encoding.ASCII.GetBytes(dataToSend);
                stream.Write(dataBytes, 0, dataBytes.Length);

                byte[] responseData = new byte[256]; //Чтение ответа с сервера
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                string response = Encoding.ASCII.GetString(responseData, 0, bytesRead);
                Console.WriteLine("Received: " + response); 

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void fileName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void addressServer_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
