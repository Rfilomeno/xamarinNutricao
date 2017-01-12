using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace nutricao
{
	public partial class ListaRefeicoes : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set;}
		private RefeicaoDAO dao;
		public ListaRefeicoes(RefeicaoDAO dao)
		{

			this.dao = dao;
			BindingContext = this;
			Refeicoes = dao.Lista;
			InitializeComponent();
		}
		public async void AcaoItem(object sender, ItemTappedEventArgs e)
		{
			Refeicao refeicao = e.Item as Refeicao;
			var resposta = await DisplayAlert("Remover Item", "Você tem certeza que deseja remover a refeição " + refeicao.Descricao, "Sim", "Não");
			if (resposta)
			{
				dao.Remove(refeicao);
				await DisplayAlert("Remover item", "Refeição removida com sucesso!", "ok");
			}
		}
	}
}
