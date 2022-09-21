using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class GClass11
{
	private static GClass11 gclass11_0;

	private string string_0 = "Data Source=database/db_maxcare.sqlite;Version=3;";

	private SQLiteConnection sqliteConnection_0 = null;

	public static GClass11 GClass11_0
	{
		get
		{
			if (gclass11_0 == null)
			{
				gclass11_0 = new GClass11();
			}
			return gclass11_0;
		}
		private set
		{
			gclass11_0 = value;
		}
	}

	private GClass11()
	{
	}

	private void method_0()
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
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "CheckConnectServer");
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
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "ExecuteQuery");
		}
		return dataTable;
	}

	public DataTable method_2(List<string> list_0)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			for (int i = 0; i < list_0.Count; i++)
			{
				string commandText = list_0[i];
				SQLiteCommand cmd = new SQLiteCommand(commandText, sqliteConnection_0);
				SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
				sQLiteDataAdapter.Fill(dataTable);
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "ExecuteQuery");
		}
		return dataTable;
	}

	public int method_3(List<string> list_0)
	{
		int result = 0;
		try
		{
			method_0();
			for (int i = 0; i < list_0.Count; i++)
			{
				string commandText = list_0[i];
				SQLiteCommand sQLiteCommand = new SQLiteCommand(commandText, sqliteConnection_0);
				result = sQLiteCommand.ExecuteNonQuery();
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "ExecuteNonQuery");
		}
		return result;
	}

	public int method_4(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "ExecuteNonQuery: " + string_1);
		}
		return result;
	}

	public int method_5(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "ExecuteScalar: " + string_1);
		}
		return result;
	}
}
