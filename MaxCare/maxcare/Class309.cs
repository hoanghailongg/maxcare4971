using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Class309
{
	[CompilerGenerated]
	private sealed class Class310
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public string string_1;

		public int int_1;
	}

	[CompilerGenerated]
	private sealed class Class311
	{
		public int int_0;

		public Class310 class310_0;

		internal void method_0()
		{
			class310_0.dataGridView_0.Rows[class310_0.int_0].Cells[class310_0.string_0].Value = class310_0.string_1.Replace("{time}", (class310_0.int_1 - (Environment.TickCount - int_0) / 1000).ToString());
		}
	}

	[CompilerGenerated]
	private sealed class Class312
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public string string_1;

		public int int_1;
	}

	[CompilerGenerated]
	private sealed class Class313
	{
		public int int_0;

		public Class312 class312_0;

		internal void method_0()
		{
			class312_0.dataGridView_0.Rows[class312_0.int_0].Cells[class312_0.string_0].Value = class312_0.string_1.Replace("{time}", (class312_0.int_1 - (Environment.TickCount - int_0) / 1000).ToString());
		}
	}

	[CompilerGenerated]
	private sealed class Class314
	{
		public string string_0;

		public DataGridView dataGridView_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class315
	{
		public string string_0;

		public DataGridView dataGridView_0;

		public int int_0;

		public string string_1;

		internal void method_0()
		{
			string_0 = dataGridView_0.Rows[int_0].Cells[string_1].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class316
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public int int_1;

		public object object_0;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class317
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public object object_0;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
		}
	}

	public static void smethod_0(DataGridView dataGridView_0, int int_0, string string_0, int int_1 = 0, string string_1 = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int int_2 = Environment.TickCount;
			while ((Environment.TickCount - int_2) / 1000 - int_1 < 0)
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[string_0].Value = string_1.Replace("{time}", (int_1 - (Environment.TickCount - int_2) / 1000).ToString());
				});
				GClass14.smethod_58(0.5);
			}
		}
		catch
		{
		}
	}

	public static void smethod_1(DataGridView dataGridView_0, int int_0, string string_0, int int_1 = 0, int int_2 = 0, string string_1 = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int int_3 = Environment.TickCount;
			while ((Environment.TickCount - int_3) / 1000 - int_1 < 0)
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[string_0].Value = string_1.Replace("{time}", (int_2 - (Environment.TickCount - int_3) / 1000).ToString());
				});
				GClass14.smethod_58(0.5);
			}
		}
		catch
		{
		}
	}

	public static string smethod_2(DataGridView dataGridView_0, int int_0, int int_1)
	{
		string string_0 = "";
		try
		{
			if (dataGridView_0.Rows[int_0].Cells[int_1].Value != null)
			{
				try
				{
					string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
				}
				catch
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
					});
				}
			}
		}
		catch
		{
		}
		return string_0;
	}

	public static string smethod_3(DataGridView dataGridView_0, int int_0, string string_0)
	{
		string string_ = "";
		try
		{
			if (dataGridView_0.Rows[int_0].Cells[string_0].Value != null)
			{
				try
				{
					string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
				}
				catch
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
					});
				}
			}
		}
		catch
		{
		}
		return string_;
	}

	public static void smethod_4(DataGridView dataGridView_0, int int_0, int int_1, object object_0)
	{
		try
		{
			try
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
				});
			}
			catch
			{
				dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void smethod_5(DataGridView dataGridView_0, int int_0, string string_0, object object_0)
	{
		try
		{
			if (Class187.bool_0 && string_0 == "cStatus")
			{
				string string_ = smethod_3(dataGridView_0, int_0, "cId");
				Class187.smethod_1(string_, object_0.ToString());
			}
			try
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
				});
			}
			catch
			{
				dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void smethod_6(DataGridView dataGridView_0, DataTable dataTable_0, bool bool_0 = false)
	{
		if (!bool_0)
		{
			for (int i = 0; i < dataTable_0.Rows.Count; i++)
			{
				DataRow dataRow = dataTable_0.Rows[i];
				dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow["id"], dataRow["uid"], dataRow["token"], dataRow["cookie1"], dataRow["email"], dataRow["phone"], dataRow["name"], dataRow["follow"], dataRow["friends"], dataRow["groups"], dataRow["birthday"], dataRow["gender"], dataRow["pass"], dataRow["mailrecovery"], dataRow["passmail"], dataRow["backup"], dataRow["fa2"], dataRow["useragent"], dataRow["proxy"], dataRow["dateCreateAcc"], dataRow["avatar"], dataRow["profile"], dataRow["nameFile"], dataRow["interactEnd"], dataRow["info"], dataRow["ghiChu"], Class187.smethod_0(dataRow["id"].ToString()));
			}
			return;
		}
		for (int j = 0; j < dataTable_0.Rows.Count; j++)
		{
			DataRow dataRow2 = dataTable_0.Rows[j];
			dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow2["id"], dataRow2["uid"], dataRow2["token"], dataRow2["cookie1"], dataRow2["email"], dataRow2["phone"], dataRow2["name"], dataRow2["follow"], dataRow2["friends"], dataRow2["groups"], dataRow2["birthday"], dataRow2["gender"], dataRow2["pass"], dataRow2["mailrecovery"], dataRow2["passmail"], dataRow2["backup"], dataRow2["fa2"], dataRow2["useragent"], dataRow2["proxy"], dataRow2["dateCreateAcc"], dataRow2["avatar"], dataRow2["profile"], dataRow2["nameFile"], dataRow2["interactEnd"], dataRow2["info"], dataRow2["ghiChu"], dataRow2["dateDelete"], Class187.smethod_0(dataRow2["id"].ToString()));
		}
	}
}
