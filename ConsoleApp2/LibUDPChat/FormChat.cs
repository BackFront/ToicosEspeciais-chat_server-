using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// **********************************************
// Não se esqueça de importar nossa bilbioteca
// tanto aqui, como nas "References" do projeto!
// **********************************************
using LibUDP;

namespace LibUDPChat
{
	public partial class FormChat : Form
	{
		private UDPSocket socket;

		public FormChat()
		{
			InitializeComponent();

			// Inicia o servidor local na porta 6200
			socket = new UDPSocket(MesagemRecebida, 6200);
		}

		private void MesagemRecebida(byte[] buffer, int size, string ip, int port)
		{
			string mensagemRecebida = Encoding.UTF8.GetString(buffer, 0, size);

			txtHistorico.Text = txtHistorico.Text +
				"Mensagem de " + ip + ": " +
				mensagemRecebida +
				Environment.NewLine +
				Environment.NewLine;
		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			if (txtMensagem.Text != "")
			{
				socket.Send("msg|" + txtDestino.Text + "|" + txtMensagem.Text, txtIP.Text, 6200);
				txtMensagem.Text = "";
			}
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
			socket.Close();
			socket.Dispose();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtOrigem.Text != "")
			{
				socket.Send("usr|" + txtOrigem.Text, txtIP.Text, 6200);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
