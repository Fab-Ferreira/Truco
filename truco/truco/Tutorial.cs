using System;
using System.Drawing;
using System.Windows.Forms;

namespace truco
{
	public partial class Tutorial : Form
	{
		public Tutorial() //Customizar a tela
		{
			InitializeComponent();
			quit.Font = new Font("Cantata One", 20);
		}
		
		void QuitClick(object sender, EventArgs e) { Close(); }
	}
}
