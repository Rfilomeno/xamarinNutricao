using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace nutricao
{
	public partial class CadastroRefeicao : ContentPage
	{
		
		private RefeicaoDAO dao;
		
		
		public CadastroRefeicao(RefeicaoDAO dao)
		{
			
			this.dao = dao;
			InitializeComponent();
		}
		public void AtualizaContador(Object sender, EventArgs e)
		{
			double valor = stpCalorias.Value;
			lblCalorias.Text = valor.ToString();
		}
		public void SalvaRefeicao(Object sender, EventArgs e)
		{
			String descricao = entDescricao.Text;
			double valor = stpCalorias.Value;
			Refeicao refeicao = new Refeicao(descricao, valor);
			dao.Salvar(refeicao);


			String msg = "A Refeição " + descricao + " de " + valor + " Calorias, foi salva com sucesso!";



			DisplayAlert("Salvar Refeição", msg, "Ok");
			clear();
		}
		public void clear() 
		{ 
			entDescricao.Text = "";
			stpCalorias.Value = 10;
		}
		public void MostraLista(object sender, EventArgs e)
		{
			//ListaRefeicoes tela = new ListaRefeicoes();
			//Navigation.PushAsync(tela);
		}
	}
}
