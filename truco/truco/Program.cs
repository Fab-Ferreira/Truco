//Código feito por Fabrício Prudente Ferreira
using System;
using System.Windows.Forms;

namespace truco
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
