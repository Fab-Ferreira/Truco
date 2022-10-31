//Código feito por Fabrício Prudente Ferreira﻿
using System;
using System.Drawing;
using System.Windows.Forms;

namespace truco
{
	public partial class MainForm : Form
	{
		public MainForm() //Ao iniciar o MainForm
		{
			InitializeComponent();
			Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); //Tamanho da tela
			WindowState = FormWindowState.Maximized; //Maximizar tela
			
			trucoScreen.form = this;
			trucoScreen.cartas = cartas;
			cartas.trucoScreen = trucoScreen;
			
			//Fundo
			bg.Parent = this;
			bg.Size = new Size(Width, Height);
			
			//Título e labels
			pbTitle.Parent = bg;
			pbTitle.Load("Componentes/title.png");
			pbTitle.Size = new Size(600, 150);
			pbTitle.Location = new Point(Width / 2 - pbTitle.Width / 2, Height / 2 - pbTitle.Height / 2);
			
			//Painel da pontuação
			panel1.Parent = bg;
			panel1.Location = new Point(50, 50);
			
			//Labels
			label1.Font = new Font("Cantata One", 16);
			label2.Font = new Font("Cantata One", 16);
			labelV.Font = new Font("Cantata One", 16);
			labelD.Font = new Font("Cantata One", 16);
			
			//Customizar o botão de Iniciar
			start.Location = new Point(Width / 2 - start.Width / 2, Height / 2 - start.Height / 2);
			start.Font = new Font("Cantata One", 30);
			
			//Customizar o botão de Créditos
			credits.Location = new Point(start.Left, start.Top + 100);
			credits.Font = new Font("Cantata One", 30);
			
			//Customizar o botão de Voltar
			back.Location = new Point(credits.Left, credits.Top + 70);
			back.Font = new Font("Cantata One", 30);
			
			//Customizar o botão do Tutorial
			tutorialBtn.Font = new Font("Cantata One", 27);
			tutorialBtn.Location = new Point(70, Height - tutorialBtn.Height - 150);
			
			//Customizar o botão do Truco
			truco.Font = new Font("Cantata One", 27);
			truco.Location = new Point(Width / 2 - truco.Width / 2, start.Top + 150);
			
			//Customizar Labels dos créditos
			program.Parent = bg;
			design.Parent = bg;
			program.Font = new Font("Cantata One", 30);
			design.Font = new Font("Cantata One", 30);
			program.Location = new Point(Width / 2 - program.Width / 2, pbTitle.Top + 40);
			design.Location = new Point(Width / 2 - design.Width / 2, program.Top + 70);
			
			//Iniciar contagem para a animação
			iniciar.Start();
		}
		
		//Variáveis, vetores e instâncias
		public PictureBox[] pointsV = new PictureBox[3], pointsD = new PictureBox[3];
		public Cartas[] card = new Cartas[12];
		public Cartas cartas = new Cartas();
		public TrucoScreen trucoScreen = new TrucoScreen();
		public Tutorial tutorialScreen = new Tutorial();
		
		Background bg = new Background(); //Background Image
		Manilha manilha = new Manilha();
		Random rnd = new Random();
		
		//Vetores de todas as cartas
		string[] cartasP = {"Cartas/Paus/2.png", "Cartas/Paus/3.png", "Cartas/Paus/4.png", "Cartas/Paus/5.png", "Cartas/Paus/6.png",
							"Cartas/Paus/7.png", "Cartas/Paus/A.png", "Cartas/Paus/J.png", "Cartas/Paus/Q.png", "Cartas/Paus/K.png"};
		string[] cartasC = {"Cartas/Copas/2.png", "Cartas/Copas/3.png", "Cartas/Copas/4.png", "Cartas/Copas/5.png", "Cartas/Copas/6.png",
							"Cartas/Copas/7.png", "Cartas/Copas/A.png", "Cartas/Copas/J.png", "Cartas/Copas/Q.png", "Cartas/Copas/K.png"};
		string[] cartasE = {"Cartas/Espadas/2.png", "Cartas/Espadas/3.png", "Cartas/Espadas/4.png", "Cartas/Espadas/5.png", "Cartas/Espadas/6.png",
							"Cartas/Espadas/7.png", "Cartas/Espadas/A.png", "Cartas/Espadas/J.png", "Cartas/Espadas/Q.png", "Cartas/Espadas/K.png"};
		string[] cartasO = {"Cartas/Ouros/2.png", "Cartas/Ouros/3.png", "Cartas/Ouros/4.png", "Cartas/Ouros/5.png", "Cartas/Ouros/6.png",
							"Cartas/Ouros/7.png", "Cartas/Ouros/A.png", "Cartas/Ouros/J.png", "Cartas/Ouros/Q.png", "Cartas/Ouros/K.png"};
		
		public string[] cartasEscolhidas = new string[13]; //Vetor das cartas no jogo
		public bool maoOnze;
		
		public object sender;
		public EventArgs e;
		
		//Ao clicar em iniciar
		public void StartClick(object sender, EventArgs e)
		{
			//Apagar botões
			start.Dispose();
			back.Dispose();
			credits.Dispose();
			
			//Título
			pbTitle.Size = new Size(400, 100);
			pbTitle.Location = new Point(Width - pbTitle.Width - 70, Height - pbTitle.Height - 75);
			
			//Botões e painel
			truco.Enabled = true;
			truco.Visible = true;
			tutorialBtn.Enabled = true;
			tutorialBtn.Visible = true;
			panel1.Visible = true;
			trucoScreen.accept.Left = (trucoScreen.Width / 2) - (trucoScreen.accept.Width / 2);
			trucoScreen.runaway.Left = trucoScreen.accept.Left - 130;
			trucoScreen.upTruco.Left = trucoScreen.accept.Left + 130;
			
			//Pontuação
			pointsV[0] = pointsV1;
			pointsV[1] = pointsV2;
			pointsV[2] = pointsV3;
			pointsD[0] = pointsD1;
			pointsD[1] = pointsD2;
			pointsD[2] = pointsD3;
			
			for(int i = 0; i < 3; i++)
			{
				pointsV[i].Load("Componentes/gray.png");
				pointsD[i].Load("Componentes/gray.png");
				pointsV[i].Name = "pointsV" + (i + 1);
				pointsD[i].Name = "pointsD" + (i + 1);
			}
			
			if(cartas.Visible == false) cartas.Visible = true;
				
			cartas.form = this;
			cartas.manilha = manilha;
			
			manilha.form = this;
			manilha.card = cartas;
			
			cartas.Parent = bg;
			cartas.Location = new Point(Width - cartas.Width - 100, 45);
			
			
			int positionL, positionT, cardPosition = 0; //Criar cartas e estabelecer local
			for(int i = 0; i < 12; i++)
			{
				card[i] = new Cartas();
				card[i].Parent = bg;
				
				if(i < 3) //Player
				{
					positionT = Height - card[i].Height - 50;
					positionL = Width / 2 - card[i].Width / 2 - card[i].Width + cardPosition;
					card[i].Location = new Point(positionL, positionT);
					card[i].Click += cartas.ChooseCard;
					cartas.ownCards.Add(card[i]);
					
					cardPosition += card[i].Width;
					
					if(i == 2) cardPosition = 0;
				}
				
				else if(i >= 3 && i < 6) //Bot 1
				{
					card[i].Load("Cartas/BackCardH.png");
					card[i].Size = new Size(131, 90);
					
					positionL = Width - card[i].Width - 50;
					positionT = Height / 2 - card[i].Height / 2 - card[i].Height + cardPosition;
					card[i].Location = new Point(positionL, positionT);
					
					cardPosition += card[i].Height;
					
					if(i == 5) cardPosition = 0;
				}
				
				else if(i >= 6 && i < 9) //Bot 2
				{
					positionT = 25;
					positionL = Width / 2 - card[i].Width / 2 - card[i].Width + cardPosition;
					card[i].Location = new Point(positionL, positionT);
					
					cardPosition += card[i].Width;
					
					if(i == 8) cardPosition = 0;
				}
				
				else if(i >= 9 && i < 12) //Bot 3
				{
					card[i].Load("Cartas/BackCardH.png");
					card[i].Size = new Size(131, 90);
					
					positionL = 25;
					positionT = Height / 2 - card[i].Height / 2 - card[i].Height + cardPosition;
					card[i].Location = new Point(positionL, positionT);
					
					cardPosition += card[i].Height;
				}
			}
			
			Cartas(); //Chamar método Cartas
			
			if(cartas.maoFechada) //Se for mão fechada (ambas as duplas com 11 pontos)
			{
				cartas.trucoPermissao = false;
				truco.Visible = false;
				truco.Enabled = false;
				
				for(int i = 0; i < 3; i++) { card[i].Load("Cartas/BackCardV.png"); }
			}
			
			else if(cartas.vitorias == 11) //Mão de 11 para o Player
			{
				maoOnze = true;
				cartas.trucoPermissao = false;
				cartas.trucoBot = true;
				
				truco.Visible = false;
				truco.Enabled = false;
				
				for(int i = 6; i < 9; i++) { card[i].Load(cartasEscolhidas[i]); }
				for(int i = 0; i < 3; i++) { card[i].Click -= cartas.ChooseCard; }
				
				//Decisão
				if(MessageBox.Show("Deseja continuar com essas cartas?", "Mão de Onze",
				                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) trucoScreen.AcceptClick(sender, e);
				else trucoScreen.RunawayClick(sender, e);
			}
			
			else if(cartas.derrotas == 11) //Mão de 11 para os Bots
			{
				for(int i = 0; i < 3; i++) { card[i].Click -= cartas.ChooseCard; }
				
				cartas.trucoPermissao = false;
				truco.Visible = false;
				truco.Enabled = false;
				delayTruco.Start();
			}
		}
		
		//Definir as cartas do jogo
		public void Cartas()
		{
			int a = 0;
			
			while (a < 13)
			{
				bool repeat = false;
				int naipe = rnd.Next(0, 4); //Definir naipe
				int num = rnd.Next(0, 10); //Definir número ou letra
				
				switch (naipe) //Inserir dado da carta
				{
					case 0: cartasEscolhidas[a] = cartasP[num]; break;
					case 1: cartasEscolhidas[a] = cartasC[num]; break;
					case 2: cartasEscolhidas[a] = cartasE[num]; break;
					case 3: cartasEscolhidas[a] = cartasO[num]; break;
				}
				
				for(int i = 0; i < a; i++) //Se houver alguma repetida
				{
					if(cartasEscolhidas[i] == cartasEscolhidas[a]) repeat = true;
				}
				
				if(!repeat) //Se não houver repetida
				{
					if(a < 3 && !cartas.maoFechada) //Definir imagens para as cartas do Player
					{
						switch (naipe)
						{
							case 0: card[a].Load(cartasP[num]); break;
							case 1: card[a].Load(cartasC[num]); break;
							case 2: card[a].Load(cartasE[num]); break;
							case 3: card[a].Load(cartasO[num]); break;
						}						
					}
					a++;
				}
			}
			
			for(int i = 0; i < 12; i++) { card[i].Name = cartasEscolhidas[i]; } //Definir nome
			
			//Estabelecer a manilha
			cartas.Name = cartasEscolhidas[12];
			cartas.Load(cartasEscolhidas[12]);
		}
		
		int delay;
		
		//Ao pedirem truco
		public void TrucoClick(object sender, EventArgs e)
		{
			for(int i = 0; i < 3; i++)
			{
				card[i].Click -= cartas.ChooseCard; //Remover a possibilidade de escolher uma carta
			}
			
			MessageBox.Show("A dupla pediu Truco.", "Truco!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			trucoScreen.Text = "Truco valendo 3 pontos";
			cartas.pontuacao = 3;
			cartas.trucoPedido = true;
			truco.Visible = false;
			truco.Enabled = false;
			valorPontos.Text = "+3";
			
			//Se foram os bots que pediram o truco
			if(cartas.trucoBot) trucoScreen.ShowDialog();
			else delayTruco.Start(); //Se foi o Player ou o Bot 2
		}
		
		//Tick do Delay para os Bots 1 e 3 "pensarem" sobre o truco solicitado  
		void DelayTrucoTick(object sender, EventArgs e)
		{
			delay++;
			
			//Resposta dos Bots após pedirem truco
			if(delay == 1 && cartas.derrotas != 11)
			{
				delayTruco.Stop();
				delay = 0;
				int luck = rnd.Next(0, 50); //Definir, na sorte, a ação a ser tomada pelos bots
				if(luck < 20) trucoScreen.RunawayClick(sender, e);
				else if(luck >= 20 && luck < 42) trucoScreen.AcceptClick(sender, e);
				else if(luck >= 42) trucoScreen.UpTrucoClick(sender, e);
			}
			
			//Resposta dos Bots na mão de 11
			else if(delay == 1 && cartas.derrotas == 11)
			{
				delayTruco.Stop();
				delay = 0;
				
				int luck = rnd.Next(0, 2);
				if(luck == 0) trucoScreen.AcceptClick(sender, e);
				else trucoScreen.RunawayClick(sender, e);
			}
		}
		
		int animacao, inicializacao;
		
		//Animação do Título na abertura
		void AnimationTick(object sender, EventArgs e)
		{
			animacao++;
			if(animacao < 75) pbTitle.Top -= 2;
			else
			{
				start.Enabled = true;
				start.Visible = true;
				credits.Enabled = true;
				credits.Visible = true;
				animation.Stop();
			}
		}
		
		//Iniciar a animação
		void IniciarTick(object sender, EventArgs e)
		{
			inicializacao++;
			if(inicializacao == 1) animation.Start();
		}
		
		//Abrir o tutorial
		void TutorialBtnClick(object sender, EventArgs e)
		{
			tutorialScreen.ShowDialog();
			tutorialScreen.tabControl.SelectTab(0);
		}
		
		void CreditsClick(object sender, EventArgs e)
		{
			bg.Load("Componentes/trucoBackground.png");
			back.Enabled = true;
			back.Visible = true;
			program.Visible = true;
			design.Visible = true;
			start.Enabled = false;
			start.Visible = false;
			credits.Enabled = false;
			credits.Visible = false;
			
		}
		
		void BackClick(object sender, EventArgs e)
		{
			bg.Load("Componentes/fundo.png");
			back.Enabled = false;
			back.Visible = false;
			start.Enabled = true;
			start.Visible = true;
			program.Visible = false;
			design.Visible = false;
			credits.Enabled = true;
			credits.Visible = true;
		}
	}
}
