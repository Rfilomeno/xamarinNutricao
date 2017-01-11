using System;
using SQLite;

namespace nutricao
{
	public class RefeicaoDAO
	{
		private SQLiteConnection conexao;
		public RefeicaoDAO(SQLiteConnection con)
		{
			conexao = con;
		}

		public void Salvar(Refeicao refeicao)
		{ 
			conexao.Insert(refeicao);

		}

		}
}

