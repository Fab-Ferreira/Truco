using System;
using System.Drawing;
using System.Windows.Forms;

namespace truco
{
	public partial class TrucoScreen : Form
	{
		public TrucoScreen()
		{
			InitializeComponent();
			
			//Definir Parent dos componentes
			accept.Parent = pictureBox1;
			runaway.Parent = pictureBox1;
			upTruco.Parent = pictureBox1;
			label1.Parent = pictureBox1;
			
			label1.Font = new Font("Cantata One", 70);
			label1.Location = new Point((Width / 2) - (label1.Width / 2), 45);
		}
		
		//Instâncias e variáveis
		public MainForm form;
		public Cartas cartas;
		public bool fugaBot, fugaPers, apostaAumentada;
		
		//Correr de um truco ou de uma rodada
		public void RunawayClick(object sender, EventArgs e)
		{
			if(cartas.trucoPermissao) //Se correu de um pedido de truco
			{
				MessageBox.Show("A dupla decidiu correr do pedido de truco.", "Aposta negada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				//Definir pontuação
				if(cartas.pontuacao == 3) cartas.pontuacao = 1;
				else if(cartas.pontuacao >= 6) cartas.pontuacao -= 3;
				
				//Definir quem fugiu
				switch (cartas.pontuacao)
				{
					case 1:
					case 6:
						if(!cartas.trucoBot) fugaBot = true; //Se foram os bots que correram
						else fugaPers = true; //Se foram vocês que correram
						break;
						
					case 3:
					case 9:
						if(cartas.trucoBot) fugaBot = true; //Se foram os bots que corretam
						else fugaPers = true; //Se foram vocês que correram
						break;
				}
			}
			
			else //Se correu de uma rodada (mão de onze)
			{
				MessageBox.Show("A dupla decidiu não aceitar as cartas.", "Rodada negada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				if(form.maoOnze) fugaPers = true; //Se foram vocês que correram
				else fugaBot = true; //Se foram os bots que correram
			}
			
			Hide(); //Esconder tela
			cartas.Reset(); //Resetar
		}
		
		//Aceitar um truco
		public void AcceptClick(object sender, EventArgs e)
		{
			if(cartas.trucoPermissao) MessageBox.Show("A dupla decidiu aceitar o truco.", "Truco aceito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			else MessageBox.Show("A dupla decidiu continuar com as cartas.", "Rodada aceita!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			
			Hide(); //Esconder tela
			
			if(cartas.time != 0) { cartas.time--; cartas.delay.Start(); } //Se não é a vez do Player
			else //Se for a vez do Player
			{
				for(int i = 0; i < 3; i++)
				{
					form.card[i].Click += cartas.ChooseCard;
				}
			}
		}
		
		//Aumentar a aposta do truco
		public void UpTrucoClick(object sender, EventArgs e)
		{
			apostaAumentada = true;
			cartas.pontuacao += 3;
			form.valorPontos.Text = "+" + cartas.pontuacao;
			Text = "Truco valendo " + cartas.pontuacao + " pontos";
			MessageBox.Show("A dupla decidiu aumentar o truco para " + cartas.pontuacao + " pontos.", "Aposta aumentada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			//Se a aposta chegar ao seu limite (12)
			if(cartas.pontuacao == 12)
			{
				upTruco.Visible = false;
				upTruco.Enabled = false;
				
				runaway.Left = accept.Left - 50;
				accept.Left += 50;
			}
			
			//Detectar quem pediu mais pontos para o truco
			switch (cartas.pontuacao - 3)
			{
				case 3:
				case 9:
					if(cartas.trucoBot)
					{
						Hide();
						form.delayTruco.Start();
					}
					else ShowDialog();
					break;
					
				case 6:
					if(!cartas.trucoBot)
					{
						Hide();
						form.delayTruco.Start();
					}
					else ShowDialog();
					break;
			}
		}
		
		void TrucoScreenFormClosed(object sender, FormClosedEventArgs e) { delay.Start(); } //Evitar com que a tela do truco seja fechada
		
		int delayTim;
		void DelayTick(object sender, EventArgs e)
		{
			delayTim++;
			if(delayTim == 1)
			{
				delay.Stop();
				delayTim = 0;
				ShowDialog();
			}
		}
	}
}
