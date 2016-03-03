using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Usuario
    {

		public int port;
		public string ip;
		public string usuario;

		public Usuario(string ip, int port, string user)
		{
			this.port = port;
			this.ip = ip;
			this.usuario = user;
		}

	}
}
