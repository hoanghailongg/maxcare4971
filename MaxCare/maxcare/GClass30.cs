using System.Data;
using System.Data.SQLite;

public class GClass30
{
	private static GClass30 gclass30_0;

	private string string_0 = "Data Source=database/db_post.db;Version=3;";

	public static GClass30 GClass30_0
	{
		get
		{
			if (gclass30_0 == null)
			{
				gclass30_0 = new GClass30();
			}
			return gclass30_0;
		}
		private set
		{
			gclass30_0 = value;
		}
	}

	private GClass30()
	{
	}

	public DataTable method_0(string string_1)
	{
		DataTable dataTable = new DataTable();
		using (SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0))
		{
			sQLiteConnection.Open();
			SQLiteCommand cmd = new SQLiteCommand(string_1, sQLiteConnection);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
			sQLiteConnection.Close();
		}
		return dataTable;
	}

	public int method_1(string string_1)
	{
		int result = 0;
		try
		{
			using SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0);
			sQLiteConnection.Open();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sQLiteConnection);
			result = sQLiteCommand.ExecuteNonQuery();
			sQLiteConnection.Close();
		}
		catch
		{
		}
		return result;
	}

	public object method_2(string string_1)
	{
		object result = 0;
		using (SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0))
		{
			sQLiteConnection.Open();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sQLiteConnection);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
			sQLiteConnection.Close();
		}
		return result;
	}
}
