using System;
using System.Threading;
using Newtonsoft.Json.Linq;

internal class Class47
{
	public int int_0;

	private string string_0;

	public string string_1;

	public string string_2 = "";

	public bool bool_0 = true;

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3 = 3;

	public Class47(string string_3, string string_4, int int_4, int int_5)
	{
		string_0 = string_3;
		string_1 = string_4;
		int_3 = int_5;
		string_2 = "";
		int_0 = int_4;
	}

	private void method_0(string string_3)
	{
	}

	public int method_1()
	{
		bool flag = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1.Split(':')[0] + ":" + string_1.Split(':')[1];
			GClass19 gClass = new GClass19("", "", "", 0);
			string text2 = gClass.method_0(text);
			if (text2.Contains("reset_too_much"))
			{
				Thread.Sleep(5000);
				return 2;
			}
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			else
			{
				method_0(text + ": " + text2);
			}
		}
		catch (Exception)
		{
		}
		return flag ? 1 : 0;
	}

	public int method_2()
	{
		try
		{
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				num = method_1();
				if (num == 1)
				{
					num = (method_4() ? 1 : 0);
				}
				if (num == 1)
				{
					break;
				}
			}
			return num;
		}
		catch
		{
		}
		return 0;
	}

	public void method_3(int int_4)
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
			int_4 = new GClass17("configGeneral").method_2("nudDelayResetXProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + string_1.Split(':')[0] + ":" + string_1.Split(':')[1];
			GClass19 gClass = new GClass19("", "", "", 0);
			string text2 = "";
			do
			{
				text2 = gClass.method_0(text);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString());
					}
					else
					{
						string text3 = string_1.Split(':')[1];
						flag = ((!text3.StartsWith("4") && !text3.StartsWith("5")) ? ((!text3.StartsWith("6") && !text3.StartsWith("7")) ? Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString()) : (JObject.Parse(text2)["public_ip_v6"]!.ToString() != "" && JObject.Parse(text2)["public_ip_v6"]!.ToString() != "CONNECT_INTERNET_ERROR")) : (JObject.Parse(text2)["public_ip"]!.ToString() != "" && JObject.Parse(text2)["public_ip"]!.ToString() != "CONNECT_INTERNET_ERROR"));
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
		catch (Exception)
		{
			return flag;
		}
	}
}
