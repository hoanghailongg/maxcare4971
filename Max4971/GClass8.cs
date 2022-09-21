using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class GClass8
{
	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = "";

	private List<GClass9> list_0;

	public GClass8(string string_3)
	{
		string_2 = string_3;
		list_0 = new List<GClass9>();
	}

	public string method_0()
	{
		return string_2;
	}

	public void method_1(GClass9 gclass9_0)
	{
		string_0 = gclass9_0.method_7();
		string_1 = gclass9_0.method_8();
		list_0.Add(gclass9_0);
	}

	public List<GClass9> method_2()
	{
		return list_0;
	}

	public List<GClass9> method_3()
	{
		List<GClass9> list = new List<GClass9>();
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass9 gClass = list_0[i];
			if (gClass.bool_0 && gClass.int_2 < gClass.int_3)
			{
				list.Add(gClass);
			}
		}
		return list;
	}

	public bool method_4()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string text = string_0.TrimEnd('/') + "/reset?proxy=" + string_1 + "&type=deep";
			GClass19 gClass = new GClass19("", "", "", 0);
			string json = gClass.method_0(text);
			JObject jObject = JObject.Parse(json);
			if (jObject.ContainsKey("msg") && (JObject.Parse(json)["msg"]!.ToString() == "command_sent" || JObject.Parse(json)["msg"]!.ToString() == "OK" || JObject.Parse(json)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(json)["error_code"]!.ToString().ToLower() == "0")
			{
				result = true;
			}
		}
		catch
		{
		}
		foreach (GClass9 item in list_0)
		{
			item.int_2 = 0;
		}
		return result;
	}

	public bool method_5()
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				GClass9 gClass = list_0[num];
				if (gClass.bool_0 && (gClass.int_2 != gClass.int_3 || gClass.int_1 != 0))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static Dictionary<string, List<string>> smethod_0(string string_3)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			string_3 = string_3.TrimEnd('/') + "/api/v1/dongles/all";
			string text = new GClass19("", "", "", 0).method_0(string_3);
			text = "{data:" + text + "}";
			JObject jObject = JObject.Parse(text);
			foreach (JToken item2 in (IEnumerable<JToken>)(jObject["data"]!))
			{
				string key = item2["rootId"]!.ToString();
				string item = item2["httpPortV6"]!.ToString();
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<string>());
				}
				dictionary[key].Add(item);
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static GClass8 smethod_1(List<GClass8> list_1, string string_3)
	{
		GClass8 result = null;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (list_1[i].method_0() == string_3)
			{
				result = list_1[i];
				break;
			}
		}
		return result;
	}
}
