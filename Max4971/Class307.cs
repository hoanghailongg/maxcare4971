using System;
using System.Collections.Generic;
using System.Data;

internal class Class307
{
	public static bool smethod_0(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = GClass32.GClass32_0.method_3("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'");
			if (num > 0)
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

	public static bool smethod_1(string string_0, string string_1, int int_0)
	{
		bool result = false;
		try
		{
			if (GClass32.GClass32_0.method_2("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + ((int_0 == 0) ? "INT" : "TEXT") + ";") > 0)
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

	public static DataTable smethod_2(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_3(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = GClass32.GClass32_0.method_1(string_).Rows[0][0].ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static DataTable smethod_4()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban";
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_5()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1";
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_6(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = GClass32.GClass32_0.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_7(string string_0, string string_1)
	{
		try
		{
			string string_2 = "UPDATE Kich_Ban SET CauHinh = '" + string_1 + "' WHERE Id_KichBan = " + string_0;
			return GClass32.GClass32_0.method_2(string_2) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_8(string string_0)
	{
		try
		{
			string string_ = "SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + string_0 + "'";
			if (GClass32.GClass32_0.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_9(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "INSERT INTO Kich_Ban (TenKichBan) VALUES ('" + string_0 + "')";
			if (GClass32.GClass32_0.method_2(string_) > 0)
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

	public static bool smethod_10(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string string_2 = "UPDATE Kich_Ban SET TenKichBan = '" + string_1 + "' WHERE Id_KichBan = " + string_0;
			if (GClass32.GClass32_0.method_2(string_2) > 0)
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

	public static bool smethod_11(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			if (GClass32.GClass32_0.method_2(string_) > 0)
			{
				smethod_23(string_0);
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

	public static bool smethod_12(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			if (smethod_9(string_1))
			{
				string text = smethod_5().Rows[0]["Id_KichBan"].ToString();
				DataTable dataTable = GClass32.GClass32_0.method_1("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + string_0);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string string_2 = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + dataTable.Rows[i]["STT"].ToString() + "," + text + ", '" + dataTable.Rows[i]["TenHanhDong"].ToString() + "', " + dataTable.Rows[i]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[i]["CauHinh"].ToString().Replace("'", "''") + "')";
					GClass32.GClass32_0.method_2(string_2);
				}
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

	public static DataTable smethod_13(string string_0 = "", string string_1 = "")
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			if (string_0 != "")
			{
				text = text + "Id_TuongTac = " + string_0 + " AND ";
			}
			if (string_1 != "")
			{
				text = text + "TenTuongTac = '" + string_1 + "'";
			}
			if (text != "")
			{
				if (text.EndsWith(" AND "))
				{
					text = text.Replace(" AND ", "");
				}
				string string_2 = "SELECT * FROM Tuong_Tac WHERE " + text;
				result = GClass32.GClass32_0.method_1(string_2);
			}
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_14(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " ORDER BY t1.STT";
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_15(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + string_0;
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_16()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1";
			result = GClass32.GClass32_0.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_17(string string_0)
	{
		try
		{
			string string_ = "SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + string_0 + "'";
			if (GClass32.GClass32_0.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_18(string string_0, string string_1, string string_2, string string_3)
	{
		bool result = false;
		try
		{
			string text = "";
			try
			{
				text = GClass32.GClass32_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + string_0 + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string_3 = string_3.Replace("'", "''");
			string string_4 = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + string_0 + ", '" + string_1 + "', " + string_2 + ", '" + string_3 + "')";
			if (GClass32.GClass32_0.method_2(string_4) > 0)
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

	public static bool smethod_19(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			DataTable dataTable = GClass32.GClass32_0.method_1("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + string_0);
			string text = "";
			try
			{
				text = GClass32.GClass32_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string string_2 = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + dataTable.Rows[0]["Id_KichBan"].ToString() + ", '" + string_1 + "', " + dataTable.Rows[0]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[0]["CauHinh"].ToString() + "')";
			if (GClass32.GClass32_0.method_2(string_2) > 0)
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

	public static bool smethod_20(string string_0, string string_1 = "", string string_2 = "")
	{
		bool result = false;
		try
		{
			string text = "";
			string_2 = string_2.Replace("'", "''");
			if (string_1 != "")
			{
				text = text + "TenHanhDong = '" + string_1 + "',";
			}
			if (string_2 != "")
			{
				text = text + "CauHinh = '" + string_2 + "'";
			}
			if (text != "")
			{
				text = text.TrimEnd(',');
				string string_3 = "UPDATE Hanh_Dong SET " + text + " WHERE Id_HanhDong = " + string_0;
				if (GClass32.GClass32_0.method_2(string_3) > 0)
				{
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_21(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = GClass32.GClass32_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["STT"].ToString();
			string text2 = GClass32.GClass32_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_1).Rows[0]["STT"].ToString();
			string string_2 = "UPDATE Hanh_Dong SET STT = " + text2 + " WHERE Id_HanhDong = " + string_0;
			string string_3 = "UPDATE Hanh_Dong SET STT = " + text + " WHERE Id_HanhDong = " + string_1;
			if (GClass32.GClass32_0.method_2(string_2) > 0 && GClass32.GClass32_0.method_2(string_3) > 0)
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

	public static bool smethod_22(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + string_0;
			if (GClass32.GClass32_0.method_2(string_) > 0)
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

	public static bool smethod_23(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_KichBan = " + string_0;
			if (GClass32.GClass32_0.method_2(string_) > 0)
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

	public static List<string> smethod_24(string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			string string_2 = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " AND t2.TenTuongTac = '" + string_1 + "'";
			DataTable dataTable = GClass32.GClass32_0.method_1(string_2);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_25(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + string_0;
			result = GClass32.GClass32_0.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}
}
