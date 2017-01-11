using System;
using SQLite;

namespace nutricao
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}
