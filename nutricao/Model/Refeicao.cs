using System;
using SQLite;

namespace nutricao
{
	public class Refeicao
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set;}
		public String Descricao { get; set;}
		public double Calorias { get; set; }

		public Refeicao() { }
		public Refeicao(String descricao, double calorias)
		{
			
			this.Descricao = descricao;
			this.Calorias = calorias;
		}
	}
}
