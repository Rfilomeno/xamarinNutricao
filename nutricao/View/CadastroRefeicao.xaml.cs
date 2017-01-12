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

			CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
			BindingContext = vm;
			InitializeComponent();
		}

	}
}
