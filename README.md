# Truco
## Introdução
  Olá! Este é um programa que fiz com a ajuda da minha amiga @Alicia-Marcolino, onde é simulado um jogo de Truco Paulista. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
  
  **Observação:** Para que algumas fontes funcione, é preciso instalar o arquivo "CantataOne-Regular.tff" no seu aparelho. O arquivo está no caminho Truco/Truco/Bin/Debug
&nbsp;

## Como jogar?
#### Objetivo:
  Cada jogador possuirá 3 cartas e esses jogadores estarão divididos em duas duplas. A cada partida, a dupla que conseguir fazer duas rodadas ganhará um ponto. A primeira dupla que conseguir **12 pontos** será a vencedora.

#### Ordem das Cartas e dos Naipes:
  Segue abaixo a ordem das cartas e dos naipes (do mais forte ao mais fraco):
  
  <img src="http://www.jogosdorei.com.br/images/baralho-online/cartas/sequencia-truco-fr.png" width=525 height=150>
  <img src="https://www.fazfacil.com.br/wp-content/uploads/2014/01/20140130-truco-ordem-naipes.png" width=500 height=250>
 
#### Manilha
  Quando a partida é iniciada, uma carta é gerada no topo superior direito da tela na qual irá determinar a carta mais forte desta partida.
  
  Por exemplo: suponha-se que esta carta seja um 5. Segundo a ordem das cartas do jogo de Truco, logo após o 5 vem o número 6, então as cartas mais fortes desta partida seriam as quatro cartas de número 6. Entretanto, ainda há a ordem dos naipes em que o naipe mais forte é sempre o **Zap** (ou Paus, símbolo do trevo preto). Logo, nesta partida, a carta mais poderosa seria o 6 de paus, em seguida vem o 6 de copas, 6 de espadas e 6 de ouros.
  **Atenção:** A ordem dos naipes é válido apenas para a manilha. As cartas comuns do jogo, caso haja duas iguais e elas sejam as mais fortes das 4 descartadas, houverá um empate.

#### Truco
  Durante a partida, o jogador (na sua vez) poderá pedir truco. Isso significa que a partida (que está valendo 1 ponto) passa a valer 3 pontos. Quando um jogador pedir truco, a dupla adversária terá 3 escolhas:
- **Aceitar o truco**, dando continuidade à partida valendo esses pontos adicionais;
- **Aumentar a aposta do truco**, adicionando mais 3 pontos à aposta (ou seja, se estiver valendo 3, vai à 6; se estiver 6 vai à 9, e assim vai). Quando a aposta é aumentada pela dupla, a outra dupla poderá correr, aceitar ou aumentar mais ainda essa aposta. Se a aposta chegar a 12 pontos, será proibido o acréscimo de mais pontos;
- **Correr do truco**, fazendo com que a dupla adversária ganhe pontos (se a partida estiver valendo 3, o adversário ganha 1 ponto; se estiver 6 ganha 3 pontos; se estiver 9 ganha 6 pontos e assim por diante).

#### Empates
  Em caso de empate, será de acordo com a situação da partida:
- Se empatar na primeira rodada, o vencedor da partida será quem fizer a segunda rodada;
- Se empatar na segunda rodada, o vencedor da partida será quem fez a primeira rodada;
- Se empatar nas duas primeiras rodadas, o vencedor da partida será quem fizer a terceira rodada;
- Se empatar na terceira rodada, o vencedor da partida será quem fez a primeira rodada;
- Se empatar nas três rodadas, não houverá vencedores e a partida será reiniciada.

#### Mão de Onze e Mão de Ferro
  Quando uma dupla consegue alcançar 11 pontos, é denominado então **Mão de Onze**, ou seja, a dupla poderá ver as cartas do parceiro e podem decidir se desejam continuar com essas cartas ou se querem fugir.
- Se continuarem, será *proibido* com que qualquer jogador pessa truco;
- Se fugirem, a partida será reiniciada e a dupla adversária ganhará 1 ponto.

  Porém, caso ambas as duplas atinjam 11 pontos, é chamado **Mão de Ferro**, ou seja, o jogador não conseguirá ver suas próprias cartas. Pelo fato das duas duplas possuírem 11 pontos, essa partida seria a decisiva para determinar o vencedor do jogo.
  
## Funcionalidade do Programa
  Em resumo, o nome das 13 cartas (3 para cada jogador e 1 que determina a manilha) são guardadas em um vetor *string cartasEscondidas* (exemplo do nome de uma carta: **Cartas/Copas/K.png**). Para saber qual foi a carta virada, o programa pega a letra ou o número do nome dela utilizando ***Split*** e a guarda numa variável tipo *char*;
~~~c#
string[] split = form.cartasEscolhidas[12].Split('/');
char manilha = Convert.ToChar((split[2].Split('.'))[0]);
~~~

  Através de uma outra váriavel string contendo a ordem das cartas, o programa identifica qual é a carta mais forte da partida e salva o número ou letra dentro de uma váriavel tipo *char*:
~~~c#
char maiorCarta;
string ordem = "4567QJKA23";

for(int i = 0; i < 10; i++)
{
		if(manilha == ordem[i] && manilha != '3') maiorCarta = ordem[i + 1];
		else if(manilha == '3') maiorCarta = '4';
}
~~~~

  Com isso, 4 cartas serão descartadas em uma rodada. O programa fará uma análise em cada uma delas e ver se a letra ou número guardada na variável *maiorCarta* coincide com a letra ou número de alguma das cartas descartadas. Se houver manilha, então serão analisadas todas as cartas que forem manilhas (pois pode haver mais de uma manilha descartada) e será determinado qual é a manilha mais forte.
  Para determinar a manilha mais forte, é pego o nome do naipe que está no nome da carta (por exemplo: Cartas/**Copas**/K.png) e, caso seja:
  - **Paus,** será recebido dentro de uma List tipo *int* o número 4;
  - **Copas,** será recebido dentro de uma List tipo *int* o número 3;
  - **Espadas,** será recebido dentro de uma List tipo *int* o número 2;
  - **Ouros,** será recebido dentro de uma List tipo *int* o número 1;
  Após isso, será analisado qual foi o maior número inserido e, então, determinar a maior manilha dessas cartas descartadas.
  
  Entretanto, caso não haja manilhas, as quatro cartas descartadas serão analisadas e, a partir do número ou letra em seu nome, será determinado qual é a mais forte.
  
  Se a carta mais forte descartada for do usuário ou do parceiro (o computador), essa dupla terá feito a rodada, senão se forem os outros dois computadores, a dupla adversária terá feito a rodada.
  
  O usuário pode pedir truco quando for na sua vez apertando no botão "Truco". Porém, no caso dos computadores, eles pedem através de ***Random***. Se nesse Random pegar um número específico, o computador pedirá truco. Essa mecânica funciona também para caso ele tenha que decidir entre correr, aceitar ou aumentar um pedido de truco. Siga abaixo a chance do computador fazer essas ações:
  
  Pedir Truco | Correr | Aceitar | Aumentar Aposta | Continuar com as Cartas ou fugir (Mão de Onze)
  ----- | ------ | ----- | ----- | -----
  6% | 40% | 44% | 16% | 50%
  
Este é o meu programa, meus agradecimentos especiais a minha amiga que é minha colega de classe pelo design do jogo, esperamos que tenha gostado e que a explicação do jogo tenha sido eficaz. No próprio código, há alguns comentários explicando as linhas para caso queira compreender melhor a lógica do programa.
