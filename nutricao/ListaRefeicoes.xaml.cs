using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace nutricao
{
	public partial class ListaRefeicoes : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set;}

		public ListaRefeicoes(ObservableCollection<Refeicao> refeicoes)
		{
			

			BindingContext = this;
			Refeicoes = refeicoes;
			InitializeComponent();
		}
		public async void AcaoItem(object sender, ItemTappedEventArgs e)
		{
			Refeicao refeicao = e.Item as Refeicao;
			var resposta = await DisplayAlert("Remover Item", "Você tem certeza que deseja remover a refeição " + refeicao.Descricao, "Sim", "Não");
			if (resposta)
			{
				Refeicoes.Remove(refeicao);
				await DisplayAlert("Remover item", "Refeição removida com sucesso!", "ok");
			}
		}
	}
}
