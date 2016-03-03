namespace LibUDPChat
{
	partial class FormChat
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHistorico = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtOrigem = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mensagem";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtMensagem
			// 
			this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMensagem.Location = new System.Drawing.Point(88, 90);
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(250, 20);
			this.txtMensagem.TabIndex = 3;
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(88, 12);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(159, 20);
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "10.1.1.250";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "IP Servidor";
			// 
			// txtHistorico
			// 
			this.txtHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHistorico.Location = new System.Drawing.Point(88, 171);
			this.txtHistorico.Multiline = true;
			this.txtHistorico.Name = "txtHistorico";
			this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHistorico.Size = new System.Drawing.Size(536, 276);
			this.txtHistorico.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Histórico";
			// 
			// btnEnviar
			// 
			this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnviar.Location = new System.Drawing.Point(344, 87);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(117, 23);
			this.btnEnviar.TabIndex = 4;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// txtDestino
			// 
			this.txtDestino.Location = new System.Drawing.Point(88, 64);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(250, 20);
			this.txtDestino.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "User Destino";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(344, 34);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(117, 23);
			this.btnLogin.TabIndex = 9;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtOrigem
			// 
			this.txtOrigem.Location = new System.Drawing.Point(88, 38);
			this.txtOrigem.Name = "txtOrigem";
			this.txtOrigem.Size = new System.Drawing.Size(250, 20);
			this.txtOrigem.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "User Origem";
			// 
			// FormChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 459);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtOrigem);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtHistorico);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMensagem);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(356, 324);
			this.Name = "FormChat";
			this.Text = "LibUDP Chat";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHistorico;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtOrigem;
		private System.Windows.Forms.Label label5;
	}
}

