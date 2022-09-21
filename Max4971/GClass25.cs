using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class GClass25
{
	public static string smethod_0(string string_0 = "")
	{
		string text = "";
		int num = 0;
		do
		{
			if (text == "")
			{
				num++;
				text = smethod_1();
				continue;
			}
			if (string_0 == "")
			{
				string_0 = GClass22.smethod_17(10);
			}
			return string_0 + text;
		}
		while (num != 10);
		return "";
	}

	public static string smethod_1()
	{
		GClass18 gClass = new GClass18();
		string input = gClass.method_0("https://generator.email/");
		MatchCollection matchCollection = Regex.Matches(input, "change_dropdown_list\\(this.innerHTML\\)\" id=\"(.*?)\"");
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < matchCollection.Count; i++)
		{
			text = matchCollection[i].Groups[1].Value;
			if (GClass22.smethod_7(text) && !GClass22.smethod_10(text) && !text.Contains("-") && (text.EndsWith(".com") || text.EndsWith(".org") || text.EndsWith(".info")))
			{
				list.Add(text);
			}
		}
		if (list.Count <= 0)
		{
			return "";
		}
		Random random = new Random();
		return "@" + list[random.Next(0, list.Count)];
	}

	public static string smethod_2(string string_0, int int_0 = 30)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		_ = "/" + string_0.Split('@')[1] + "/" + string_0.Split('@')[0] + "/(.*?)\"";
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			string input = gClass.method_0("https://generator.email/" + string_0);
			text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\"").Value.TrimEnd('"');
			text = Regex.Match(text, "c=(.*?)&").Groups[1].Value;
			if (text != "")
			{
				break;
			}
		}
		return text;
	}

	public static bool smethod_3(string string_0)
	{
		GClass18 gClass = new GClass18();
		string input = gClass.method_0("https://generator.email/" + string_0);
		string value = Regex.Match(input, "delll: \"(.*?)\"").Groups[1].Value;
		string string_ = "delll=" + value;
		input = gClass.method_1("https://generator.email/del_mail.php", string_);
		if (input.Contains("successfully"))
		{
			return true;
		}
		return false;
	}

	public static string smethod_4(string string_0)
	{
		GClass18 gClass = new GClass18();
		string text = gClass.method_0("https://minsoftware.xyz/minsoftware/api1.php/GetCodeCheckCountry");
		string text2 = text.Replace("\"", "");
		string result = "";
		string json = gClass.method_1("https://www.mapdevelopers.com/data.php?operation=geocode&address=" + string_0 + "&region=US&code=" + text2).ToString();
		JObject jObject = JObject.Parse(json);
		string text3 = jObject["data"]!["country"]!.ToString();
		if (text3 != "")
		{
			result = text3;
		}
		return result;
	}

	public static string smethod_5(string string_0)
	{
		string text = "";
		GClass19 gClass = new GClass19("", "", "", 0);
		string json = gClass.method_0("https://api.rentcode.net/api/ig/balance?apiKey=" + Uri.EscapeDataString(string_0));
		JObject jObject = JObject.Parse(json);
		if (Convert.ToBoolean(jObject["success"]))
		{
			try
			{
				text = jObject["results"]!["balance"]!.ToString();
			}
			catch
			{
			}
		}
		return (text == "") ? "" : Convert.ToInt32(text).ToString();
	}

	public static string smethod_6(string string_0, int int_0 = 3, int int_1 = 2, int int_2 = 60)
	{
		string text = "";
		GClass19 gClass = new GClass19("", "", "", 0);
		string string_ = "{ \"serviceProviderId\": " + int_0 + ", \"networkProvider\": " + int_1 + " }";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 5; i++)
		{
			try
			{
				text2 = gClass.method_2("https://api.rentcode.net/api/ig/create-request?apiKey=" + Uri.EscapeDataString(string_0), string_, "application/json");
				text3 = JObject.Parse(text2)["results"]!["id"]!.ToString();
				if (text3 != "")
				{
					break;
				}
			}
			catch
			{
			}
		}
		if (text3 != "")
		{
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= int_2 * 1000)
			{
				text2 = gClass.method_0("https://api.rentcode.net/api/ig/orders/" + text3 + "/check-status?apiKey=" + Uri.EscapeDataString(string_0));
				JObject jObject = JObject.Parse(text2);
				if (!Convert.ToBoolean(jObject["success"]))
				{
					continue;
				}
				try
				{
					text = jObject["results"]!["phoneNumber"]!.ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return text3 + "|" + text;
	}

	public static string smethod_7(string string_0, string string_1, int int_0 = 60)
	{
		string text = "";
		GClass19 gClass = new GClass19("", "", "", 0);
		string string_2 = "{ \"pageIndex\": 0, \"pageSize\": 0, \"sortColumnName\": \"string\", \"isAsc\": true, \"searchObject\": { \"additionalProp1\": { }, \"additionalProp2\": { }, \"additionalProp3\": { } } }";
		string text2 = "";
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			text2 = gClass.method_2("https://api.rentcode.net/api/ig/orders/" + string_1 + "/results?apiKey=" + Uri.EscapeDataString(string_0), string_2, "application/json");
			JObject jObject = JObject.Parse(text2);
			if (Convert.ToInt32(jObject["total"]) <= 0)
			{
				continue;
			}
			try
			{
				text = jObject["results"]![0]!["message"]!.ToString();
				text = Regex.Match(text, "\\d{6}").Value;
				if (!(text != ""))
				{
					continue;
				}
				return text;
			}
			catch
			{
			}
		}
		return text;
	}
}
