using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace truco
{
	//Classe das Cartas
	public class Cartas : PictureBox
	{
		public Cartas() //Características
		{
			Load("Cartas/BackCardV.png");
			BackColor = Color.Transparent;
			SizeMode = PictureBoxSizeMode.StretchImage;
			Size = new Size(90, 131);
			delay.Tick += DelayTick;
			delay.Interval = 1000;
		}
		
		//Variáveis e instâncias
		public bool trucoBot, trucoPedido, firstVic, undefined, trucoPermissao = true, maoFechada;
		public int time, vitorias, derrotas, chanceTruco, pontuacao = 1, carta, contador, contadorD, contadorV;
		public string[] cartasDescartadas = new string[4];
		public List<PictureBox> droppedCards = new List<PictureBox>(), ownCards = new List<PictureBox>();
		public Random rnd = new Random();
		public Timer delay = new Timer();
		public MainForm form;
		public Manilha manilha;
		public TrucoScreen trucoScreen;
		public PictureBox droppedCard = new PictureBox();
		
		//Método de quando selecionar uma carta
		public void ChooseCard(object sender, EventArgs e)
		{
			form.truco.Visible = false;
			(sender as PictureBox).Location = new Point(form.Width / 2 - (droppedCard.Width / 2), form.Height / 2 + 60);
			droppedCards.Add(sender as PictureBox);
			
			if(maoFechada) (sender as PictureBox).Load((sender as PictureBox).Name);
			
			for(int i = 0; i < 3; i++)
			{
				form.card[i].Click -= ChooseCard; //Tirar a possibilidade de clicar
			}
			
			form.truco.Enabled = false;
			cartasDescartadas[0] = (sender as PictureBox).Name;
			delay.Start();
		}
		
		//Andamento da rodada
		public void DelayTick(object sender, EventArgs e)
		{
			time++;
			if(time == 1) //Bot 1
			{
				carta = rnd.Next(3, 6);
				chanceTruco = rnd.Next(0, 15); //Chance de pedir truco
				
				if(chanceTruco == 10 && !trucoPedido && trucoPermissao) //Quando pedir truco
				{
					trucoBot = true;
					delay.Stop();
					form.TrucoClick(form.sender, form.e);
				}
				else //Quando jogar normalmente
				{
					while(form.card[carta].IsDisposed) { carta = rnd.Next(3, 6); } //Selecionar uma das suas cartas disponíveis
				
					form.card[carta].Size = new Size(90, 131);
					form.card[carta].Location = new Point(form.Width / 2 + 60, form.Height / 2 - (form.card[carta].Height / 2));
					form.card[carta].Load(form.cartasEscolhidas[carta]);
					cartasDescartadas[1] = form.cartasEscolhidas[carta];
					droppedCards.Add(form.card[carta]); //Adicionar carta descartada à lista
				}
			}
			
			else if(time == 2) //Bot 2
			{
				carta = rnd.Next(6, 9);
				chanceTruco = rnd.Next(0, 15); //Chance de pedir truco
				
				if(chanceTruco == 10 && !trucoPedido && trucoPermissao) //Quando pedir truco
				{
					delay.Stop();
					form.TrucoClick(form.sender, form.e);
				}
				else //Quando jogar normalmente
				{
					while(form.card[carta].IsDisposed) { carta = rnd.Next(6, 9); } //Selecionar uma das suas cartas disponíveis
				
					form.card[carta].Location = new Point(form.Width / 2 - (droppedCard.Width / 2), form.Height / 2 - 190);
					form.card[carta].Load(form.cartasEscolhidas[carta]);
					cartasDescartadas[2] = form.cartasEscolhidas[carta];
					droppedCards.Add(form.card[carta]); //Adicionar carta descartada à lista
				}	
			}
			
			else if(time == 3) //Bot 3
			{
				carta = rnd.Next(9, 12);
				chanceTruco = rnd.Next(0, 15); //Chance de pedir truco
				
				if(chanceTruco == 10 && !trucoPedido && trucoPermissao) //Quando pedir truco
				{
					trucoBot = true;
					delay.Stop();
					form.TrucoClick(form.sender, form.e);
				}
				else //Quando jogar normalmente
				{
					while(form.card[carta].IsDisposed) { carta = rnd.Next(9, 12); } //Selecionar uma das suas cartas disponíveis
					
					form.card[carta].Size = new Size(90, 131);
					form.card[carta].Location = new Point(form.Width / 2 - 165, form.Height / 2 - (form.card[carta].Height / 2));
					form.card[carta].Load(form.cartasEscolhidas[carta]);
					cartasDescartadas[3] = form.cartasEscolhidas[carta];
					droppedCards.Add(form.card[carta]); //Adicionar carta descartada à lista
				}
			}
			
			else if(time == 4) Points(); //Verificação do vencedor
			
			else if(time == 6) //Resetar rodada
			{
				for(int i = 0; i < droppedCards.Count(); i++)
				{
					droppedCards[i].Dispose(); //Remover cartas descartadas
				}
				
				for(int i = 0; i < ownCards.Count(); i++)
				{
					ownCards[i].Click += ChooseCard; //Possibilitar o descarte das cartas do usuário
				}
				
				if(!trucoPedido && trucoPermissao) { form.truco.Enabled = true; form.truco.Visible = true;}
				delay.Stop();
				time = 0;
				Reset(); //Reiniciar tudo
			}
		}
		
		public void Points() //Acrescentar ponto da rodada
		{
			manilha.DefinirManilha(); //Buscar maior carta do jogo
			
			if(manilha.vitoria) //Ponto do Player & Bot 2
			{
				if(contador == 0) firstVic = true;
				form.pointsV[contador].Load("Componentes/check.png");
				form.pointsD[contador].Load("Componentes/fail.png");
				contadorV++;
			}
			
			else if(manilha.derrota) //Ponto do Bot 1 && Bot 3
			{
				form.pointsD[contador].Load("Componentes/check.png");
				form.pointsV[contador].Load("Componentes/fail.png");
				contadorD++;
			}
			
			else if(manilha.empate) //Empate (em fase de teste)
			{
				form.pointsD[contador].Load("Componentes/equal.png");
				form.pointsV[contador].Load("Componentes/equal.png");
				form.pointsD[contador].Name = "empate";
				form.pointsV[contador].Name = "empate";
				
				switch (contador)
				{
					case 0: //Se empatar na primeira rodada
						contadorV = 1;
						contadorD = 1;
						break;
						
					case 1: //Se empatar na segunda rodada
						if(form.pointsD[0].Name != "empate") //Caso não tenha empatado na primeira rodada
						{
							if(contadorV == 1) contadorV++;
							else if(contadorD == 1) contadorD++;
						}
						break;
						
					case 2:
						if(form.pointsV[1].Name != "empate") //Caso não tenha empatado nas outras duas rodadas
						{
							if(firstVic) contadorV = 2;
							else contadorD = 2;
						}
						else undefined = true;
						break;
				}
			}
			
			contador++;
		}
		
		public void Reset() //Resetar rodada
		{
			if(contadorD == 2 || contadorV == 2 || trucoScreen.fugaBot || trucoScreen.fugaPers || undefined) //Verificar se a rodada acabou
			{
				//Resetar variáveis boolean
				if(derrotas != 11 || vitorias != 11) form.truco.Enabled = true;
				
				trucoScreen.upTruco.Enabled = true;
				trucoScreen.upTruco.Visible = true;
				
				trucoScreen.apostaAumentada = false;
				trucoPedido = false;
				trucoBot = false;
				form.cartas.Visible = false;
				undefined = false;
				firstVic = false;
				time = 0;
				
				//Deletar todas as cartas do jogo
				for (int i = 0; i < form.card.Length; i++)
				{
					if(!form.card[i].IsDisposed) form.card[i].Dispose();
				}
				
				//Se o Player e o Bot 2 ganharem a partida ou se os Bots 1 e 3 fugirem do truco
				if(contadorV == 2 || trucoScreen.fugaBot)
				{
					trucoScreen.fugaBot = false;
					
					vitorias += pontuacao;
					form.labelV.Text = vitorias.ToString();
					
					//Declarar vitória se chegar a 12 pontos
					if(vitorias >= 12)
					{
						form.panel1.Visible = false;
						form.tutorialBtn.Visible = false;
						form.tutorialBtn.Enabled = false;
						form.pbTitle.Visible = false;
						
						if(MessageBox.Show(" Você venceu! \n Deseja continuar?", "Parabéns!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							Application.Restart();
						}
						else Application.Exit();
					} 
				}
				
				//Se os Bots 1 e 3 ganharem a partida ou se o Player e o Bot 2 fugirem do truco
				else if(contadorD == 2 || trucoScreen.fugaPers)
				{
					trucoScreen.fugaPers = false;
					
					derrotas += pontuacao;
					form.labelD.Text = derrotas.ToString();
					
					if(derrotas >= 12)
					{
						form.panel1.Visible = false;
						form.tutorialBtn.Visible = false;
						form.tutorialBtn.Enabled = false;
						form.pbTitle.Visible = false;
						
						if(MessageBox.Show(" Você perdeu! \n Deseja continuar?", "Derrota!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							Application.Restart();
						}
						else Application.Exit();
					}
				}
				
				if(vitorias == 11 && derrotas == 11) maoFechada = true;
				
				pontuacao = 1;
				contadorV = 0;
				contadorD = 0;
				contador = 0;
				form.valorPontos.Text = "+1";
				
				//Recriar novamente as cartas
				form.StartClick(form.sender, form.e);
			}
		}
	}
}