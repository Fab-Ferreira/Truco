using System;
using System.Windows.Forms;

namespace truco
{
	public class Background : PictureBox 
	{
		//Tela de fundo
		public Background()
		{
			SizeMode = PictureBoxSizeMode.StretchImage;
			Load("Componentes/fundo.png");
		}
	}
}
