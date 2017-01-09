using System;

using Xamarin.Forms;

namespace nutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			this.Children.Add(new CadastroRefeicao());
			this.Children.Add(new ListaRefeicoes());	
			}
		}
	}


