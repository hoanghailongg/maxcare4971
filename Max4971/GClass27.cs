using System;
using System.Data;
using System.Data.SQLite;

public class GClass27
{
	private string string_0;

	private SQLiteConnection sqliteConnection_0 = null;

	public GClass27(string string_1)
	{
		string_0 = "Data Source=" + string_1 + ";Version=3;";
	}

	public void method_0()
	{
		try
		{
			if (sqliteConnection_0 == null)
			{
				sqliteConnection_0 = new SQLiteConnection(string_0);
			}
			if (sqliteConnection_0.State == ConnectionState.Closed)
			{
				sqliteConnection_0.Open();
			}
		}
		catch (Exception)
		{
		}
	}

	public DataTable method_1(string string_1)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			SQLiteCommand cmd = new SQLiteCommand(string_1, sqliteConnection_0);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch
		{
		}
		return dataTable;
	}

	public int method_2(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception)
		{
		}
		return result;
	}
}
