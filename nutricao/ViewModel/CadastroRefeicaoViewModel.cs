using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace nutricao
{
	public class CadastroRefeicaoViewModel : INotifyPropertyChanged
	{
		private String descricao;
		private double calorias;
		private ContentPage page;
		public ICommand SalvaRefeicao { get; protected set; }


		public String Descricao
		{
			get { return descricao; }
			set {
				if (value != descricao)
				{
					descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
		{
			this.dao = dao;
			this.page = page;

			SalvaRefeicao = new Command(() =>
			{
				Refeicao refeicao = new Refeicao(descricao, calorias);
				dao.Salvar(refeicao);

				String msg = "A Refeição " + descricao + " de " + calorias + " Calorias, foi salva com sucesso!";

				this.page.DisplayAlert("Salvar Refeição", msg, "Ok");
			});
		}
		public double Calorias
		{
			get { return calorias; }
			set {
				if (calorias != value)
				{
					calorias = value;
					OnPropertyChanged("Calorias");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(String nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}

	}
}
