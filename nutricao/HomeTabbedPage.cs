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
			ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();

			SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
			RefeicaoDAO dao = new RefeicaoDAO(con);
			CadastroRefeicao telaCadastro = new CadastroRefeicao(refeicoes,dao);
			ListaRefeicoes telaLista = new ListaRefeicoes(refeicoes);

			this.Children.Add(telaCadastro);

			this.Children.Add(telaLista);	
			}
		}
	}


