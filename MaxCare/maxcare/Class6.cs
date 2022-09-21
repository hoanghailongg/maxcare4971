using System;
using System.Threading;
using Newtonsoft.Json.Linq;

internal class Class6
{
	private object object_0 = new object();

	private object object_1 = new object();

	public int int_0;

	private string string_0;

	public string string_1;

	public string string_2 = "";

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3 = 3;

	public Class6(string string_3, string string_4, int int_4, int int_5)
	{
		string_0 = string_3;
		string_1 = string_4;
		int_3 = int_5;
		string_2 = "";
		int_0 = int_4;
	}

	public bool method_0()
	{
		bool result = false;
		try
		{
			string text = "https://api.proxyv6.net/api/reset-ip-manual?api_key=" + string_0;
			string text2 = "{\"host\": \"" + string_1.Split(':')[0] + "\", \"port\": " + string_1.Split(':')[1] + "}";
			GClass19 gClass = new GClass19("", "", "", 0);
			string json = gClass.method_2(text, text2, "application/json");
			if (JObject.Parse(json)["message"]!.ToString() == "SUCCESS")
			{
				for (int i = 0; i < 120; i++)
				{
					if (!method_2())
					{
						Thread.Sleep(1000);
						continue;
					}
					Thread.Sleep(1000);
					return true;
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void method_1()
	{
		lock (object_0)
		{
			int_1--;
			if (int_1 == 0 && int_2 == int_3)
			{
				int_2 = 0;
			}
		}
	}

	public bool method_2()
	{
		bool result = false;
		try
		{
			string text = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + string_0;
			string text2 = string_1.Split(':')[2] + ":" + string_1.Split(':')[3] + "@" + string_1.Split(':')[0] + ":" + string_1.Split(':')[1];
			string text3 = "{\"proxies\": [\"" + text2 + "\"]}";
			GClass19 gClass = new GClass19("", "", "", 0);
			string json = gClass.method_2(text, text3, "application/json");
			result = Convert.ToBoolean(JObject.Parse(json)["message"]!.ToString() == "SUCCESS" && JObject.Parse(json)["data"]!["ip"]!.ToString() != "");
			return result;
		}
		catch
		{
			return result;
		}
	}
}
