using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Class36
{
	[Serializable]
	[CompilerGenerated]
	private sealed class EA2D3EAA
	{
		public static readonly EA2D3EAA _003C_003E9 = new EA2D3EAA();

		public static Func<DataRow, Class48> _003C_003E9__33_0;

		public static Func<DataRow, Class48> _003C_003E9__35_0;

		public static Func<DataRow, Class48> _003C_003E9__40_0;

		internal Class48 method_0(DataRow dataRow_0)
		{
			return new Class48
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
				String_5 = Convert.ToString(dataRow_0["ngaytao"]),
				String_2 = Convert.ToString(dataRow_0["anh"]),
				String_3 = Convert.ToString(dataRow_0["video"]),
				String_1 = Convert.ToString(dataRow_0["tieude"]),
				String_4 = Convert.ToString(dataRow_0["noidung"])
			};
		}

		internal Class48 method_1(DataRow dataRow_0)
		{
			return new Class48
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
				String_5 = Convert.ToString(dataRow_0["ngaytao"]),
				String_2 = Convert.ToString(dataRow_0["anh"]),
				String_3 = Convert.ToString(dataRow_0["video"]),
				String_1 = Convert.ToString(dataRow_0["tieude"]),
				String_4 = Convert.ToString(dataRow_0["noidung"])
			};
		}

		internal Class48 method_2(DataRow dataRow_0)
		{
			return new Class48
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
				String_5 = Convert.ToString(dataRow_0["ngaytao"]),
				String_2 = Convert.ToString(dataRow_0["anh"]),
				String_3 = Convert.ToString(dataRow_0["video"]),
				String_1 = Convert.ToString(dataRow_0["tieude"]),
				String_4 = Convert.ToString(dataRow_0["noidung"])
			};
		}
	}

	public static bool smethod_0(string string_0)
	{
		return GClass11.GClass11_0.method_5("SELECT COUNT(*) FROM files WHERE name='" + string_0 + "' AND active=1;") > 0;
	}

	public static DataTable smethod_1(bool bool_0 = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (bool_0 ? ("select id, name from files where active=1 UNION SELECT -1 AS id, '" + GClass29.smethod_0("[Tất cả thư mục]") + "' AS name UNION SELECT 999999 AS id, '" + GClass29.smethod_0("[Chọn nhiều thư mục]") + "' AS name ORDER BY id ASC") : "select id, name from files where active=1");
			result = GClass11.GClass11_0.method_1(text);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_2(bool bool_0 = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (bool_0 ? ("select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -1 AS id, '" + GClass29.smethod_0("[Tất cả thư mục]") + "' AS name UNION SELECT 999999 AS id, '" + GClass29.smethod_0("[Chọn nhiều thư mục]") + "' AS name ORDER BY id ASC") : "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0)");
			result = GClass11.GClass11_0.method_1(text);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_3(string string_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into files values(null,'" + string_0 + "','" + DateTime.Now.ToString() + "',1)";
			GClass11.GClass11_0.method_1(string_);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_4(string string_0, string string_1)
	{
		try
		{
			string string_2 = "UPDATE files SET name='" + string_1 + "' where id=" + string_0;
			return GClass11.GClass11_0.method_4(string_2) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_5(string string_0)
	{
		bool result = false;
		try
		{
			if (GClass11.GClass11_0.method_5("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + string_0) == 0)
			{
				result = GClass11.GClass11_0.method_4("delete from files where id=" + string_0) > 0;
				return result;
			}
			if (GClass11.GClass11_0.method_4("UPDATE files SET active=0 where id=" + string_0) > 0)
			{
				result = smethod_23(string_0);
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_6(string string_0, List<string> list_0, string string_1 = "accounts")
	{
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Split('|')[0];
			text2 = list_0[i].Split('|')[1];
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
				text3 = text3 + "WHEN '" + text + "' THEN '" + text2 + "' ";
			}
		}
		string string_2 = "UPDATE " + string_1 + " SET " + string_0 + " = CASE id " + text3 + "END WHERE id IN('" + string.Join("','", list) + "'); ";
		return GClass11.GClass11_0.method_4(string_2) > 0;
	}

	public static bool smethod_7()
	{
		bool result = false;
		try
		{
			result = GClass11.GClass11_0.method_4("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts)") > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_8()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT id, status FROM accounts";
			result = GClass11.GClass11_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_9(List<string> list_0, bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = ((list_0 != null && list_0.Count != 0) ? ("where idfile IN (" + string.Join(",", list_0) + ") AND active=" + (bool_0 ? 1 : 0)) : ("where active=" + (bool_0 ? 1 : 0)));
			string string_ = "SELECT '-1' as id, '" + GClass29.smethod_0("[Tất cả tình trạng]") + "' AS name UNION select DISTINCT '0' as id,info from accounts " + text + " ORDER BY id ASC";
			result = GClass11.GClass11_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_10(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15 = "", string string_16 = "", string string_17 = "", string string_18 = "")
	{
		bool result = true;
		try
		{
			string format = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,backup,idfile,passmail,useragent,proxy,dateImport,active) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',1)";
			format = string.Format(format, string_0, string_1.Replace("'", "''"), string_2, string_3, string_4, string_6, string_7, string_8, string_9, string_10, string_11, string_13, string_12, string_14, string_16, string_17, string_18, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			GClass11.GClass11_0.method_1(format);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static List<string> smethod_11(List<string> list_0)
	{
		List<string> list = new List<string>();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateCreateAcc,dateImport,mailrecovery,active) VALUES " + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num)));
				list.Add(text);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string smethod_12(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string string_17)
	{
		string text = "";
		try
		{
			text = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',1)";
			text = string.Format(text, string_0.Replace("'", "''"), string_1.Replace("'", "''"), string_2, string_3, string_4, string_5.Replace("'", "''"), string_6, string_7, string_8, string_9, string_10, string_11, string_12, string_13, string_14, string_15, string_16, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), string_17);
		}
		catch
		{
		}
		return text;
	}

	public static bool smethod_13(string string_0, string string_1, string string_2)
	{
		bool result = false;
		try
		{
			string text = "";
			if (string_1 == "pass")
			{
				text = ", pass_old=pass";
			}
			if (string_1 == "uid" && string_2.ToString().Trim() == "")
			{
				return false;
			}
			if (string_1 == "cookie1" && string_2.ToString().Trim() == "")
			{
				return false;
			}
			string string_3 = "update accounts set " + string_1 + " = '" + string_2.Replace("'", "''") + "'" + text + " where id=" + string_0;
			result = GClass11.GClass11_0.method_4(string_3) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_14(string string_0, string string_1, string string_2, bool bool_0 = true)
	{
		bool result = false;
		try
		{
			if (string_1.Split('|').Length == string_2.Split('|').Length)
			{
				int num = string_1.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					if (bool_0 || !(string_2.Split('|')[i].Trim() == ""))
					{
						text = text + string_1.Split('|')[i] + "='" + string_2.Split('|')[i].Replace("'", "''") + "',";
					}
				}
				text = text.TrimEnd(',');
				string string_3 = "update accounts set " + text + " where id=" + string_0;
				result = GClass11.GClass11_0.method_4(string_3) > 0;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_15(List<string> list_0, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			if (string_0.Split('|').Length == string_1.Split('|').Length)
			{
				int num = string_0.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					text = text + string_0.Split('|')[i] + "='" + string_1.Split('|')[i].Replace("'", "''") + "',";
				}
				text = text.TrimEnd(',');
				int num2 = 100;
				int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list = new List<string>();
				string text2 = "";
				for (int j = 0; j < num3; j++)
				{
					text2 = "update accounts set " + text + " where id IN (" + string.Join(",", list_0.GetRange(num2 * j, (num2 * j + num2 <= list_0.Count) ? num2 : (list_0.Count % num2))) + ")";
					list.Add(text2);
				}
				if (GClass11.GClass11_0.method_3(list) > 0)
				{
					result = true;
					return result;
				}
				result = false;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_16(string string_0, string string_1, string string_2)
	{
		bool result = false;
		try
		{
			string string_3 = "update files set " + string_1 + " = '" + string_2.Replace("'", "''") + "' where id=" + string_0;
			if (GClass11.GClass11_0.method_4(string_3) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_17(List<string> list_0, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			string text2 = "";
			if (string_0 == "pass")
			{
				text2 = ", pass_old=pass";
			}
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set " + string_0 + " = '" + string_1.Replace("'", "''") + "'" + text2 + " where id IN (" + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + ")";
				list.Add(text);
			}
			if (GClass11.GClass11_0.method_3(list) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex)
		{
			GClass14.smethod_76(null, ex.ToString());
			return result;
		}
	}

	public static bool smethod_18(List<string> list_0, string string_0, string string_1)
	{
		bool result = true;
		try
		{
			string string_2 = "update files set " + string_0 + " = '" + string_1 + "' where id IN (" + string.Join(",", list_0) + ")";
			if (GClass11.GClass11_0.method_4(string_2) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_19(List<string> list_0 = null, string string_0 = "", bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "WHERE ";
			string text2 = ((list_0 == null || list_0.Count <= 0) ? "" : ("t1.idFile IN (" + string.Join(",", list_0) + ")"));
			if (text2 != "")
			{
				text = text + text2 + " AND ";
			}
			string text3 = ((string_0 != "") ? ("t1.info = '" + string_0 + "'") : "");
			if (text3 != "")
			{
				text = text + text3 + " AND ";
			}
			string text4 = $"t1.active = '{(bool_0 ? 1 : 0)}'";
			text += text4;
			string string_ = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + text + " ORDER BY t1.idfile";
			result = GClass11.GClass11_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_20(List<string> list_0)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=1";
					list.Add(text);
				}
				result = GClass11.GClass11_0.method_2(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=1 ORDER BY t1.email";
					list2.Add(text2);
				}
				result = GClass11.GClass11_0.method_2(list2);
			}
			else
			{
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=1 ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = GClass11.GClass11_0.method_2(list3);
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_21(List<string> list_0)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=1 ORDER BY t1.email";
				list.Add(text);
			}
			result = GClass11.GClass11_0.method_2(list);
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_22(bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = $"select uid from accounts where active={(bool_0 ? 1 : 0)};";
			result = GClass11.GClass11_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_23(string string_0)
	{
		bool result = true;
		try
		{
			if (GClass11.GClass11_0.method_4("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + string_0) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_24(string string_0)
	{
		try
		{
			return GClass11.GClass11_0.method_4("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id=" + string_0) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static DataTable smethod_25(List<string> list_0)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + "')";
				list.Add(text);
			}
			result = GClass11.GClass11_0.method_2(list);
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static bool smethod_26(List<string> list_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			List<string> list = new List<string>();
			DataTable dataTable = smethod_25(list_0);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string text = "";
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					text = text + dataTable.Rows[i][j].ToString() + "|";
				}
				text = text.Substring(0, text.Length - 1);
				list.Add(text);
			}
			File.AppendAllText("bin.txt", "======" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
			File.AppendAllLines("bin.txt", list);
		}
		bool result = true;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list2 = new List<string>();
			string text2 = "";
			for (int k = 0; k < num2; k++)
			{
				text2 = ((!bool_0) ? ("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")") : ("delete from accounts where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")"));
				list2.Add(text2);
			}
			for (int l = 0; l < list2.Count; l++)
			{
				result = GClass11.GClass11_0.method_4(list2[l]) > 0;
			}
			return result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "DeleteAccountToDatabase");
			return result;
		}
	}

	public static bool smethod_27(string string_0)
	{
		string[] array = string_0.Split('|');
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		string text11 = "";
		string text12 = "";
		string text13 = "";
		text = array[0];
		if (text.Trim() == "")
		{
			return false;
		}
		text2 = array[1];
		text3 = array[2];
		text4 = array[3];
		text5 = array[4];
		text6 = array[5];
		text7 = array[6];
		text8 = array[7];
		text9 = array[8];
		text10 = array[9];
		text11 = array[10];
		text12 = array[11];
		text13 = array[12];
		List<string> list = new List<string>();
		list.Add((text2 != "") ? ("pass|" + text2) : "");
		list.Add((text3 != "") ? ("token|" + text3) : "");
		list.Add((text4 != "") ? ("cookie1|" + text4) : "");
		list.Add((text5 != "") ? ("email|" + text5) : "");
		list.Add((text6 != "") ? ("passmail|" + text6) : "");
		list.Add((text7 != "") ? ("fa2|" + text7) : "");
		list.Add((text8 != "") ? ("useragent|" + text8) : "");
		list.Add((text9 != "") ? ("proxy|" + text9) : "");
		list.Add((text10 != "") ? ("birthday|" + text10) : "");
		list.Add((text11 != "") ? ("friends|" + text11) : "");
		list.Add((text12 != "") ? ("dateCreateAcc|" + text12) : "");
		list.Add((text13 != "") ? ("mailrecovery|" + text13) : "");
		string text14 = "update accounts set";
		foreach (string item in list)
		{
			if (item != "")
			{
				text14 = text14 + " " + item.Split('|')[0] + "='" + item.Split('|')[1] + "',";
				if (item.Split('|')[0] == "pass")
				{
					text14 += "pass_old=pass,";
				}
			}
		}
		text14 = text14.TrimEnd(',');
		text14 = text14 + " where uid='" + text + "'";
		return GClass11.GClass11_0.method_4(text14) > 0;
	}

	public static string smethod_28(string string_0)
	{
		try
		{
			return GClass11.GClass11_0.method_5("SELECT idFile FROM accounts WHERE id='" + string_0 + "'").ToString();
		}
		catch
		{
		}
		return "";
	}

	public static bool smethod_29(string string_0, string string_1)
	{
		return GClass11.GClass11_0.method_5("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'") > 0;
	}

	public static bool smethod_30(string string_0)
	{
		return GClass11.GClass11_0.method_5("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + string_0 + "';") > 0;
	}

	public static bool smethod_31(string string_0, string string_1, int int_0)
	{
		bool result = false;
		try
		{
			if (GClass11.GClass11_0.method_4("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + ((int_0 == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_32(string string_0, string string_1, string string_2)
	{
		bool result = true;
		try
		{
			string string_3 = "INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + string_1 + "','" + string_2 + "')";
			GClass11.GClass11_0.method_1(string_3);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static List<Class48> smethod_33(string string_0)
	{
		List<Class48> result = new List<Class48>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet WHERE id = " + string_0;
			DataTable source = GClass30.GClass30_0.method_0(string_);
			result = (from dataRow_0 in source.AsEnumerable()
				select new Class48
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
					String_5 = Convert.ToString(dataRow_0["ngaytao"]),
					String_2 = Convert.ToString(dataRow_0["anh"]),
					String_3 = Convert.ToString(dataRow_0["video"]),
					String_1 = Convert.ToString(dataRow_0["tieude"]),
					String_4 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_34()
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "select ten from ChuDe;";
			DataTable dataTable = GClass30.GClass30_0.method_0(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i][0].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<Class48> smethod_35(string string_0 = "")
	{
		List<Class48> result = new List<Class48>();
		try
		{
			string text = "";
			text = ((!(string_0 != "")) ? "select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet" : ("select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet WHERE tenchude='" + string_0 + "'"));
			DataTable source = GClass30.GClass30_0.method_0(text);
			result = (from dataRow_0 in source.AsEnumerable()
				select new Class48
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
					String_5 = Convert.ToString(dataRow_0["ngaytao"]),
					String_2 = Convert.ToString(dataRow_0["anh"]),
					String_3 = Convert.ToString(dataRow_0["video"]),
					String_1 = Convert.ToString(dataRow_0["tieude"]),
					String_4 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_36(int int_0)
	{
		bool result = false;
		if (GClass30.GClass30_0.method_1("delete from BaiViet where id=" + int_0) > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool smethod_37(string string_0)
	{
		bool flag = false;
		try
		{
			string string_ = "delete from ChuDe where ten='" + string_0 + "'";
			if (GClass30.GClass30_0.method_1(string_) > 0)
			{
				smethod_38(string_0);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_38(string string_0)
	{
		bool result = false;
		if (GClass30.GClass30_0.method_1("delete from BaiViet where tenchude='" + string_0 + "'") > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool smethod_39(string string_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into ChuDe values('" + string_0 + "')";
			GClass30.GClass30_0.method_1(string_);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static List<Class48> smethod_40()
	{
		List<Class48> result = new List<Class48>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet ORDER BY id DESC LIMIT 1";
			DataTable source = GClass30.GClass30_0.method_0(string_);
			result = (from dataRow_0 in source.AsEnumerable()
				select new Class48
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
					String_5 = Convert.ToString(dataRow_0["ngaytao"]),
					String_2 = Convert.ToString(dataRow_0["anh"]),
					String_3 = Convert.ToString(dataRow_0["video"]),
					String_1 = Convert.ToString(dataRow_0["tieude"]),
					String_4 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_41(int int_0, Class48 class48_0)
	{
		bool result = true;
		try
		{
			string text = "";
			if (class48_0.String_1 != null)
			{
				text = text + "tieude = '" + class48_0.String_1.Replace("'", "''") + "',";
			}
			if (class48_0.String_2 != null)
			{
				text = text + "anh = '" + class48_0.String_2 + "',";
			}
			if (class48_0.String_4 != null)
			{
				text = text + "noidung = '" + class48_0.String_4.Replace("'", "''") + "',";
			}
			if (class48_0.String_5 != null)
			{
				text = text + "ngaytao = '" + class48_0.String_5 + "',";
			}
			if (class48_0.String_0 != null)
			{
				text = text + "tenchude = '" + class48_0.String_0 + "',";
			}
			if (class48_0.String_3 != null)
			{
				text = text + "video = '" + class48_0.String_3 + "',";
			}
			text = text.TrimEnd(',');
			if (text != "")
			{
				string string_ = "UPDATE BaiViet SET " + text + " WHERE id=" + int_0;
				GClass30.GClass30_0.method_1(string_);
				return true;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_42(string string_0, string string_1)
	{
		bool result = true;
		try
		{
			string string_2 = "UPDATE ChuDe SET ten = '" + string_1 + "' WHERE ten='" + string_0 + "'";
			if (GClass30.GClass30_0.method_1(string_2) > 0)
			{
				List<Class48> list = smethod_35(string_0);
				for (int i = 0; i < list.Count; i++)
				{
					smethod_41(list[i].Int32_0, new Class48
					{
						String_0 = string_1
					});
				}
				return result;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_43(string string_0, Class48 class48_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into BaiViet(tenChuDe, tieude, noidung, ngaytao, anh,video) values('" + string_0 + "','" + class48_0.String_1.Replace("'", "''") + "','" + class48_0.String_4.Replace("'", "''") + "','" + class48_0.String_5 + "','" + class48_0.String_2 + "','" + class48_0.String_3 + "')";
			GClass30.GClass30_0.method_1(string_);
			return result;
		}
		catch
		{
			return false;
		}
	}

	internal static DataTable smethod_44(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT pass, cookie1, email, fa2, proxy FROM accounts WHERE uid='" + string_0 + "'AND active=1";
			result = GClass11.GClass11_0.method_1(string_);
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "GetPassByUid");
		}
		return result;
	}
}
