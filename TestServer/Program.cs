using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TestServer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            Console.WriteLine("Server started!");

            bool isRunning = true;
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    string input = Console.ReadLine().Trim();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Received exit command. Shutting down server.");

                        TcpClient tempClient = new TcpClient("127.0.0.1", 9999);
                        NetworkStream tempStream = tempClient.GetStream();
                        byte[] shutdownMessage = Encoding.ASCII.GetBytes("Server is shutting down.");
                        tempStream.Write(shutdownMessage, 0, shutdownMessage.Length);
                        tempClient.Close();

                        isRunning = false;
                        server.Stop();
                        break;
                    }
                }

                if (server.Pending())
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] data = new byte[256];
                    int bytesRead = stream.Read(data, 0, data.Length);
                    string requestData = Encoding.ASCII.GetString(data, 0, bytesRead);

                    Console.WriteLine("Received data: " + requestData);

                    if (requestData.StartsWith("CreateFile: "))
                    {
                        string[] parts = requestData.Substring("CreateFile: ".Length).Split(';');
                        string fileName = parts[0];
                        string fileData = parts[1];

                        string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                        File.WriteAllText(filePath, fileData);

                        byte[] responseData = Encoding.ASCII.GetBytes("The file is created and the data is recorded.");
                        stream.Write(responseData, 0, responseData.Length);
                    }

                    client.Close();
                }
            }
        }
    }
}
