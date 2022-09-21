using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class Class40
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_3;

	private object object_0 = new object();

	private object object_1 = new object();

	public string string_3 = "";

	private string string_4 = "http://proxy.tinsoftsv.com";

	private int int_4 = 0;

	public bool bool_0 = true;

	public int int_5 = 0;

	public int int_6 = 0;

	public int int_7 = 3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public Class40(string string_5, int int_8, int int_9 = 0)
	{
		String_0 = string_5;
		String_1 = "";
		String_2 = "";
		Int32_0 = 0;
		Int32_1 = 0;
		Int32_2 = 0;
		Int32_3 = int_9;
		int_7 = int_8;
		int_5 = 0;
		int_6 = 0;
		bool_0 = true;
	}

	public string method_0()
	{
		lock (object_0)
		{
			if (int_5 == 0)
			{
				if (int_6 > 0 && int_6 < int_7)
				{
					if (method_4() < 30 && !method_2())
					{
						return "0";
					}
				}
				else if (!method_2())
				{
					return "0";
				}
			}
			else
			{
				if (int_6 >= int_7)
				{
					return "2";
				}
				if (method_4() < 30 && !method_2())
				{
					return "0";
				}
			}
			int_6++;
			int_5++;
			return "1";
		}
	}

	public void method_1()
	{
		lock (object_1)
		{
			int_5--;
			if (int_5 == 0 && int_6 == int_7)
			{
				int_6 = 0;
			}
		}
	}

	public bool method_2()
	{
		lock (object_1)
		{
			if (method_7())
			{
				string_3 = "";
				Int32_2 = 0;
				String_1 = "";
				String_2 = "";
				Int32_0 = 0;
				Int32_1 = 0;
				string text = method_8(string_4 + "/api/changeProxy.php?key=" + String_0 + "&location=" + Int32_3);
				if (text != "")
				{
					try
					{
						JObject jObject = JObject.Parse(text);
						if (bool.Parse(jObject["success"]!.ToString()))
						{
							String_1 = jObject["proxy"]!.ToString();
							string[] array = String_1.Split(':');
							String_2 = array[0];
							Int32_0 = int.Parse(array[1]);
							Int32_1 = int.Parse(jObject["timeout"]!.ToString());
							Int32_2 = int.Parse(jObject["next_change"]!.ToString());
							string_3 = "";
							return true;
						}
						string_3 = jObject["description"]!.ToString();
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
					}
					catch
					{
					}
				}
				else
				{
					string_3 = "request server timeout!";
				}
			}
			else
			{
				string_3 = "Request so fast!";
			}
			return false;
		}
	}

	public string method_3()
	{
		while (!method_6())
		{
		}
		return String_1;
	}

	public int method_4()
	{
		while (!method_6())
		{
		}
		return Int32_1;
	}

	public int method_5()
	{
		while (!method_6())
		{
		}
		return Int32_2;
	}

	public bool method_6()
	{
		lock (object_1)
		{
			string_3 = "";
			Int32_2 = 0;
			String_1 = "";
			String_2 = "";
			Int32_0 = 0;
			Int32_1 = 0;
			string text = method_8(string.Concat(new object[3] { string_4, "/api/getProxy.php?key=", String_0 }));
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (bool.Parse(jObject["success"]!.ToString()))
					{
						String_1 = jObject["proxy"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_0 = int.Parse(array[1]);
						Int32_1 = int.Parse(jObject["timeout"]!.ToString());
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
						string_3 = "";
						return true;
					}
					string_3 = jObject["description"]!.ToString();
					if (jObject["next_change"] != null)
					{
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
					}
				}
				catch (Exception)
				{
				}
			}
			else
			{
				string_3 = "request server timeout!";
			}
			return false;
		}
	}

	private bool method_7()
	{
		try
		{
			DateTime dateTime = new DateTime(2001, 1, 1);
			long ticks = DateTime.Now.Ticks - dateTime.Ticks;
			int num = (int)new TimeSpan(ticks).TotalSeconds;
			if (num - int_4 >= 10)
			{
				int_4 = num;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private string method_8(string string_5)
	{
		Console.WriteLine(string_5);
		string text = "";
		try
		{
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString(string_5);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	private static string smethod_0(string string_5)
	{
		Console.WriteLine(string_5);
		string text = "";
		try
		{
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString(string_5);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	public static bool smethod_1(string string_5)
	{
		string text = smethod_0("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + string_5);
		if (text != "")
		{
			JObject jObject = JObject.Parse(text);
			if (bool.Parse(jObject["success"]!.ToString()))
			{
				return true;
			}
		}
		return false;
	}

	public static List<string> smethod_2(string string_5)
	{
		List<string> list = new List<string>();
		try
		{
			GClass19 gClass = new GClass19("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
			string json = gClass.method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + string_5);
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
			{
				if (Convert.ToBoolean(item["success"]!.ToString()))
				{
					list.Add(item["key"]!.ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}
}
