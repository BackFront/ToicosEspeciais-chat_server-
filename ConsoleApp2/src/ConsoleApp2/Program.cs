using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibUDP;
using System.Text;

namespace ConsoleApp2
{
	public class Program
	{
		private UDPSocket socket;
		private List<Usuario> usuarios = new List<Usuario>();
		private int qntUsuarios;

		public void Main(string[] args)
		{
			Console.WriteLine("[] - Servidor Iniciado");
			socket = new UDPSocket(MesagemRecebida, 6200);
			Console.ReadKey();
		}


		private void MesagemRecebida(byte[] buffer, int size, string ip, int port)
		{
			string body = Encoding.UTF8.GetString(buffer, 0, size);
			string[] tipo = body.Split('|');

			if (tipo[0] == "usr")
			{
				usuarios.Add(new Usuario(ip, port, tipo[1]));
				Console.WriteLine("Conectado: <" + ip + "> - " + tipo[1]);
			}

			if (tipo[0] == "msg")
			{
				//msg|destino|mensagem

				foreach (var key in usuarios)
				{
					if (tipo[1] == key.usuario)
					{
						string msg = "Mensagem de - " + key.usuario + ": " + tipo[2];
						socket.Send(msg, key.ip, key.port);
					}
				}

			}
		}
	}
}
