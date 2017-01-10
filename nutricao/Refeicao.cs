using System;
namespace nutricao
{
	public class Refeicao
	{
		public String Descricao { get; set;}
		public double Calorias { get; set; }

		public Refeicao(String descricao, double calorias)
		{
			
			this.Descricao = descricao;
			this.Calorias = calorias;
		}
	}
}
