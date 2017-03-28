using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AsyncClient
{
	class AsyncClient
	{
		public static void Main(string[] args)
		{
			const int port = 115400;
			string response = String.Empty;
			TcpListener incoming = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
			incoming.Start();

			TcpClient client = incoming.AcceptTcpClient();
			Console.WriteLine("Accepted");

			NetworkStream stream = client.GetStream();
			string InMSG = stream.ToString();
			Console.WriteLine(InMSG);

			Console.Write("Outgoing: ");
			string input = Console.ReadLine();


			while (!input.Equals("exit"))
			{
				Console.Write("Outgoing: ");
				input = Console.ReadLine();


			}

		}//Client
	}//Class
}//NS
