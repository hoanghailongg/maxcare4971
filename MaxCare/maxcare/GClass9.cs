using System;
using System.Threading;
using Newtonsoft.Json.Linq;

public class GClass9
{
	public int int_0;

	private string string_0;

	public string string_1;

	public string string_2 = "";

	public bool bool_0 = true;

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3 = 3;

	private string string_3 = "";

	public GClass9(string string_4, string string_5, int int_4, int int_5, string string_6)
	{
		string_0 = string_4;
		string_1 = string_5;
		int_3 = int_5;
		string_2 = "";
		int_0 = int_4;
		method_6(string_6);
	}

	private void method_0(string string_4)
	{
	}

	public bool method_1()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1;
			GClass19 gClass = new GClass19("", "", "", 0);
			string text2 = gClass.method_0(text);
			method_0(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
				return result;
			}
			if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
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

	public bool method_2()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1;
			GClass19 gClass = new GClass19("", "", "", 0);
			string text2 = gClass.method_0(text);
			method_0(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			bool flag = false;
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			if (flag)
			{
				return method_4();
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void method_3(int int_4 = 1)
	{
		int_1--;
		if (int_4 == 0 && int_1 == 0 && int_2 == int_3)
		{
			int_2 = 0;
		}
	}

	public bool method_4(int int_4 = -1)
	{
		if (int_4 == -1)
		{
			int_4 = new GClass17("configGeneral").method_2("nudDelayCheckIPObcProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + string_1;
			GClass19 gClass = new GClass19("", "", "", 0);
			string text2 = "";
			do
			{
				text2 = gClass.method_0(text);
				method_0(text + ": " + text2);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString());
					}
					else
					{
						string text3 = string_1.Split(':')[1];
						if (text3.StartsWith("4") || text3.StartsWith("5"))
						{
							flag = JObject.Parse(text2)["public_ip"]!.ToString() != "" && JObject.Parse(text2)["public_ip"]!.ToString() != "CONNECT_INTERNET_ERROR";
						}
						else if (text3.StartsWith("6") || text3.StartsWith("7"))
						{
							flag = JObject.Parse(text2)["public_ip_v6"]!.ToString() != "" && JObject.Parse(text2)["public_ip_v6"]!.ToString() != "CONNECT_INTERNET_ERROR";
						}
					}
				}
				catch
				{
					flag = JObject.Parse(text2)["error_code"]!.ToString() == "0";
				}
				Thread.Sleep(1000);
				if (flag)
				{
					return flag;
				}
			}
			while (Environment.TickCount - tickCount < int_4 * 1000);
			return flag;
		}
		catch
		{
			return flag;
		}
	}

	public string method_5()
	{
		return string_3;
	}

	public void method_6(string string_4)
	{
		string_3 = string_4;
	}

	public string method_7()
	{
		return string_0;
	}

	public string method_8()
	{
		return string_1.Split(':')[1];
	}
}
