using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace nutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		
		public HomeTabbedPage()
		{
			
			SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();

			RefeicaoDAO dao = new RefeicaoDAO(con);


			CadastroRefeicao telaCadastro = new CadastroRefeicao(dao);

			ListaRefeicoes telaLista = new ListaRefeicoes(dao);

			this.Children.Add(telaCadastro);

			this.Children.Add(telaLista);	
			}
		}
	}


