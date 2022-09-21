using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

public class GClass26
{
	public static void smethod_0(string string_0 = "database\\db_maxcare.sqlite")
	{
		string fileName = Path.GetFileName(string_0);
		GClass14.smethod_32(Environment.GetEnvironmentVariable("LocalAppData") + "\\database");
		string string_ = Environment.GetEnvironmentVariable("LocalAppData") + "\\database\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName;
		GClass27 gClass = new GClass27(string_0);
		gClass.method_0();
		GClass27 gClass2 = new GClass27(string_);
		gClass2.method_0();
		List<string> list = new List<string>();
		DataTable dataTable = gClass.method_1("select name,sql from sqlite_master;");
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			list.Add(dataTable.Rows[i]["name"].ToString());
			gClass2.method_2(dataTable.Rows[i]["sql"].ToString());
		}
		for (int j = 0; j < list.Count; j++)
		{
			string text = list[j];
			if (text == "interacts")
			{
				continue;
			}
			DataTable dataTable2 = gClass.method_1("pragma table_info(" + text + ")");
			List<string> list2 = new List<string>();
			for (int k = 0; k < dataTable2.Rows.Count; k++)
			{
				list2.Add(dataTable2.Rows[k]["name"].ToString());
			}
			string text2 = "INSERT INTO " + text + "(" + string.Join(",", list2) + ") VALUES ";
			List<string> list3 = new List<string>();
			DataTable dataTable3 = gClass.method_1("select * from " + text);
			int num = 0;
			for (int l = 0; l < dataTable3.Rows.Count; l++)
			{
				List<string> list4 = new List<string>();
				for (int m = 0; m < dataTable3.Rows[l].ItemArray.Length; m++)
				{
					list4.Add(dataTable3.Rows[l][m].ToString().Replace("'", "''"));
				}
				list3.Add("('" + string.Join("','", list4) + "')");
				num++;
				if (num % 1000 == 0)
				{
					gClass2.method_2(text2 + string.Join(",", list3));
					list3 = new List<string>();
				}
			}
			gClass2.method_2(text2 + string.Join(",", list3));
		}
	}
}
