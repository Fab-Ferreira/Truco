# Truco
## Introdução
  Olá! Este é um programa que fiz com a ajuda da minha amiga @Fab-Ferreira, onde é simulado um jogo de Truco Paulista. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

## Como jogar?
#### Objetivo:
  Cada jogador possuirá 3 cartas e esses jogadores estarão divididos em duas duplas. A cada partida, a dupla que conseguir fazer duas rodadas ganhará um ponto. A primeira dupla que conseguir 12 pontos será a vencedora.

#### Ordem das Cartas e dos Naipes:
  Segue abaixo a ordem das cartas e dos naipes (do mais forte ao mais fraco):
  
  <img src="http://www.jogosdorei.com.br/images/baralho-online/cartas/sequencia-truco-fr.png" width=525 height=150>
  <img src="https://www.fazfacil.com.br/wp-content/uploads/2014/01/20140130-truco-ordem-naipes.png" width=500 height=250>
 
#### Manilha
  Quando a partida é iniciada, uma carta é gerada no topo superior direito da tela na qual irá determinar a carta mais forte desta partida.
  
  Por exemplo: suponha-se que esta carta seja um 5. Segundo a ordem das cartas do jogo de Truco, logo após o 5 vem o número 6, então as cartas mais fortes desta partida seriam as quatro cartas de número 6. Entretanto, ainda há a ordem dos naipes em que o naipe mais forte é sempre o *Zap* (ou Paus, símbolo do trevo preto). Logo, nesta partida, a carta mais poderosa seria o 6 de paus, em seguida vem o 6 de copas, 6 de espadas e 6 de ouros.
  *Atenção:* A ordem dos naipes é válido apenas para a manilha. As cartas comuns do jogo, caso haja duas iguais e elas sejam as mais fortes das 4 descartadas, houverá um empate.

#### Truco
  Durante a partida, o jogador (na sua vez) poderá pedir truco. Isso significa que a partida (que está valendo 1 ponto) passa a valer 3 pontos. Quando um jogador pedir truco, a dupla adversária terá 3 escolhas:
- Aceitar o truco, dando continuidade à partida valendo esses pontos adicionais;
- Aumentar a aposta do truco, adicionando mais 3 pontos à aposta (ou seja, se estiver valendo 3, vai à 6; se estiver 6 vai à 9, e assim vai). Quando a aposta é aumentada pela dupla, a outra dupla poderá correr, aceitar ou aumentar mais ainda essa aposta. Se a aposta chegar a 12 pontos, será proibido o acréscimo de mais pontos;
- Correr do truco, fazendo com que a dupla adversária ganhe pontos (se a partida estiver valendo 3, o adversário ganha 1 ponto; se estiver 6 ganha 3 pontos; se estiver 9 ganha 6 pontos e assim por diante).

#### Empates
  Em caso de empate, será de acordo com a situação da partida:
- Se empatar na primeira rodada, o vencedor da partida será quem fizer a segunda rodada;
- Se empatar na segunda rodada, o vencedor da partida será quem fez a primeira rodada;
- Se empatar nas duas primeiras rodadas, o vencedor da partida será quem fizer a terceira rodada;
- Se empatar na terceira rodada, o vencedor da partida será quem fez a primeira rodada;
- Se empatar nas três rodadas, não houverá vencedores e a partida será reiniciada.

#### Mão de Onze e Mão de Ferro
  Quando uma dupla consegue alcançar 11 pontos, é denominado então *Mão de Onze*, ou seja, a dupla poderá ver as cartas do parceiro e podem decidir se desejam continuar com essas cartas ou se querem fugir.
- Se continuarem, será *proibido* com que qualquer jogador pessa truco;
- Se fugirem, a partida será reiniciada e a dupla adversária ganhará 1 ponto.

  Porém, caso ambas as duplas atinjam 11 pontos, é chamado *Mão de Ferro*, ou seja, o jogador não conseguirá ver suas próprias cartas. Pelo fato das duas duplas possuírem 11 pontos, essa partida seria a decisiva para determinar o vencedor do jogo.
  
## Funcionalidade do Programa
O programa, primeiramente, identifica a quantidade de algarismos do número que você digitou, isto é, quantos caracteres (char) existem dentro do número (string). Se o número digitado pelo usuário possuir:
1. 4 algarismos (ou seja, um número entre 1000 e 3999), a variável *tamanho* receberá 3;
2. 3 algarismos (ou seja, um número entre 100 e 999), a variável *tamanho* receberá 2;
3. 2 algarismos (ou seja, um número entre 10 e 99), a variável *tamanho* receberá 1;
4. 1 algarismo (ou seja, um número entre 1 e 9), a variável *tamanho* receberá 0;

Após obter o valor de *tamanho*, o programa irá analisar cada algarismo do número que foi digitado. Dependendo do algarismo (2, 3, 7 e 8), haverão repetições de determinadas letras. Segue a tabela abaixo para compreender a formação de cada número:

Algarismo | Romano (na unidade de milhar) | Romano (na centena) | Romano (na dezena) | Romano (na unidade)
----- | ------ | ------ | ------ | ------ 
1 | M | C | X | I
2 | MM | CC | XX | II
3 | MMM | CCC | XXX | III
4 | inválido | CD | XL | IV
5 | inválido | D | L | V
6 | inválido | DC | LX | VI
7 | inválido | DCC | LXX | VII
8 | inválido | DCCC | LXXX | VIII
9 | inválido | CM | XC | IX

**Por exemplo:** O número 2659 em algarismos romanos.
- O número 2 está na 1ª posição (unidade de milhar), logo seu algarismo romano será o M repetido duas vezes (**MM**);
- O número 6 está na 2ª posição (centena), logo seu algarismo romano será o D unido com o C repetido uma única vez (**DC**);
- O número 5 está na 3ª posição (dezena), logo seu algarismo romano será o L (**L**);
- O número 9 está na 4ª posição (unidade), logo seu algarismo romano será o IX (**IX**);

Resultado: **MMDCLIX**
&nbsp;

### Como que o programa sabe qual letra aplicar para cada algarismo?
Através de vetores string. O programa possui 4 vetores string que armazenam as letras:
~~~c#
string[] romanos1 = {"I", "X", "C", "M"}, romanos5 = {"V", "L", "D"}, romanos4 = {"IV", "XL", "CD"}, romanos9 = {"IX", "XC", "CM"}
~~~
Seguindo o exemplo mostrado, em um número de 4 algarismos, o número 6 está na 2ª posição (centena). Como já explicado, um número com 4 algarismos fará com que *tamanho* receba 3. A partir disso, o programa fará a seguinte análise:
~~~c#
string numRomano += (romanos5[tamanho - (posicao - 1)] + romanos1[tamanho - (posicao - 1)]);
~~~
Ou seja:
~~~c#
string numRomano += (romanos5[4 - 2] + romanos1[4 - 2]);
~~~
Explicando o código acima, a variável *numRomano* (que seria o texto onde será guardado o número romano do número inserido) receberá a união da string **"D"** (já que romanos5[2] equivale à "D") com a string **"C"** (já que romanos1[2] equivale à **"C"**), resultando em **DC**.

#### Observação:
Lembre-se: em um vetor, a primeira posição é 0, ou seja, romanos5[0] equivale à "V", romanos5[1] equivale à "L", e assim por diante.

## Atenção!
- Evite de clicar no botão com a TextBox sem texto, com letras ou com caracteres especiais;
- O programa só permite o uso de números **naturais** entre 1 e 3999;

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
