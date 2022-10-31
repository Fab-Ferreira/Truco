using System;
using System.Collections.Generic;
using System.Linq;

namespace truco
{
	public class Manilha
	{
		public Manilha()
		{
		}
		
		public MainForm form;
		public Cartas card;
		
		public string[] cartas;
		public string ordem = "4567QJKA23", cartaMaisForte;
		public char[] valorCartasDescartadas = new char[4];
		public char manilha, maiorCarta;
		public bool coringa, empate, derrota, vitoria;
		
		public void DefinirManilha()
		{
			coringa = false;
			cartaMaisForte = "";
			string[] split = form.cartasEscolhidas[12].Split('/');
			manilha = Convert.ToChar((split[2].Split('.'))[0]);
			empate = false;
			derrota = false;
			vitoria = false;
			
			//Verificar a manilha do jogo
			for(int i = 0; i < 10; i++)
			{
				if(manilha == ordem[i] && manilha != '3') maiorCarta = ordem[i + 1];
				else if(manilha == '3') maiorCarta = '4';
			}
			
			//Pegar o número ou a letra das cartas descartadas do jogo (no tipo Char)
			for(int i = 0; i < 4; i++)
			{
				valorCartasDescartadas[i] = Convert.ToChar(((card.cartasDescartadas[i].Split('/'))[2].Split('.'))[0]);
			}
			
			//Guardar o número da posição (da string ordem) numa lista e verificar se há manilha no jogo
			List<int> positions = new List<int>();
			foreach (char numCarta in valorCartasDescartadas)
			{
				int posicao = ordem.IndexOf(numCarta);
				positions.Add(posicao);
				
				if(numCarta == maiorCarta) //Se houver manilha
				{
					coringa = true;
				}
			}
			
			//Se tem manilha no jogo
			List<int> naipes = new List<int>();
			List<string> droppedManilhas = new List<string>();
			naipes.Clear();
			droppedManilhas.Clear();
			
			if(coringa)
			{
				for(int i = 0; i < 4; i++) //Fará análise das 4 cartas descartadas
				{
					string drop = ((card.cartasDescartadas[i].Split('/'))[2].Split('.'))[0];
					if(drop == maiorCarta.ToString()) droppedManilhas.Add(card.cartasDescartadas[i]); //Guardas as manilhas descartadas numa lista
				}
				
				for(int i = 0; i < droppedManilhas.Count(); i++) //Verificar todas as manilhas da lista
				{
					string[] carta = droppedManilhas[i].Split('/');
					
					switch (carta[1]) //Verificar o naipe
					{
						case "Paus": naipes.Add(4); break;
						case "Copas": naipes.Add(3); break;
						case "Espadas": naipes.Add(2); break;
						case "Ouros": naipes.Add(1); break;
					}
					
					if(naipes.Last() >= naipes.Max()) cartaMaisForte = droppedManilhas[i]; //Definir a mais forte
				}
			}
			
			else if(!coringa) //Se não houver manilhas
			{
				List<int> repeatCard = new List<int>();
				repeatCard.Clear();
				
				for(int i = 0; i < 4; i++)
				{
					for(int a = 0; a < i; a++)
					{
						if(positions[a] == positions[i] && positions.Max() == positions[a])
						{
							for(int carta = 0; carta < 4; carta++)
							{
								string letraCard = ((card.cartasDescartadas[carta].Split('/'))[2].Split('.'))[0];
								
								if(ordem[positions[a]].ToString() == letraCard) repeatCard.Add(carta);
							}
						
							if(repeatCard.Max() == 3 && repeatCard.Min() == 2) empate = true;
							else if(repeatCard.Max() == 2 && repeatCard.Min() == 1) empate = true;
							else if(repeatCard.Max() == 3 && repeatCard.Min() == 0) empate = true;
							else if(repeatCard.Max() == 1 && repeatCard.Min() == 0) empate = true;
						}
					}
					if(ordem[positions.Max()] == valorCartasDescartadas[i]) cartaMaisForte = card.cartasDescartadas[i];
				}
			}
			
			//Declarar vitória
			if(!empate)
			{
				for(int i = 0; i < 12; i++)
				{
					if(cartaMaisForte == form.card[i].Name)
					{
						switch(i)
						{
							case 0:
							case 1:
							case 2:
							case 6:
							case 7:
							case 8:
								vitoria = true;
								break;
								
							case 3:
							case 4:
							case 5:
							case 9:
							case 10:
							case 11:
								derrota = true;
								break;
						}
					}
				}
			}
		}
	}
}
