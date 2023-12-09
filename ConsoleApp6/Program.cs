using System;
using System.Net.Sockets;
using System.Text;

class Client {

    public static void Main()
    {
       TcpClient tcpClient = new TcpClient();
        Console.WriteLine("Клиент запущен");
       tcpClient.Connect("127.0.0.1", 8888);
        
        if (tcpClient.Connected)
        {
            var stream = tcpClient.GetStream();
            Console.WriteLine($"Подключение с {tcpClient.Client.RemoteEndPoint} установлено");
            while (true)
            {
                byte[] buffer = new byte[1024]; 
                int b = stream.Read(buffer,0,1024);
                //for (int i = 0; i < 1024; i++)
                //{
                //    Console.Write((char)buffer[i]);
                //}
                
                Console.WriteLine(Encoding.UTF8.GetString(buffer));

            }
        }
        else
            Console.WriteLine("Не удалось подключиться");
    }

}

