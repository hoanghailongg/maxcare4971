using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class41
{
	[CompilerGenerated]
	private sealed class Class42
	{
		public string string_0;
	}

	[CompilerGenerated]
	private sealed class Class43
	{
		public HttpContent httpContent_0;

		public Class42 class42_0;

		internal Task<string> method_0()
		{
			return smethod_3(new Uri(class42_0.string_0), httpContent_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class44
	{
		public string string_0;

		internal Task<string> method_0()
		{
			return smethod_4(new Uri(string_0));
		}
	}

	private Random random_0 = new Random();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_3;

	private object object_0 = new object();

	private object object_1 = new object();

	public int int_4 = 0;

	public int int_5 = 0;

	public int int_6 = 3;

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

	public Class41(string string_3, int int_7, int int_8)
	{
		String_0 = string_3;
		String_1 = "";
		String_2 = "";
		Int32_2 = 0;
		Int32_3 = 0;
		Int32_0 = int_7;
		int_6 = int_8;
		int_4 = 0;
		int_5 = 0;
	}

	public static bool smethod_0(string string_3)
	{
		string string_4 = "{\"api_key\": \"" + string_3 + "\"}";
		string text = smethod_1("https://tmproxy.com/api/proxy/stats", string_4);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				string text2 = jObject["data"]!["expired_at"]!.ToString();
				DateTime t = GClass14.smethod_82(text2, "HH:mm:ss dd/MM/yyyy");
				if (DateTime.Compare(t, DateTime.Now) > 0)
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_0()
	{
		lock (object_0)
		{
			if (int_4 == 0)
			{
				if (int_5 > 0 && int_5 < int_6)
				{
					if (method_1() < 30 && !method_4())
					{
						return "0";
					}
				}
				else if (!method_4())
				{
					return "0";
				}
			}
			else
			{
				if (int_5 >= int_6)
				{
					return "2";
				}
				if (method_1() < 30 && !method_4())
				{
					return "0";
				}
			}
			int_5++;
			int_4++;
			return "1";
		}
	}

	public int method_1()
	{
		method_6();
		return Int32_1;
	}

	public void method_2()
	{
		lock (object_1)
		{
			int_4--;
			if (int_4 == 0 && int_5 == int_6)
			{
				int_5 = 0;
			}
		}
	}

	public string method_3(string string_3)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_3));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public bool method_4()
	{
		Int32_3 = 0;
		String_1 = "";
		String_2 = "";
		Int32_2 = 0;
		string string_ = "{\"api_key\": \"" + String_0 + "\"}";
		string text = smethod_1("https://tmproxy.com/api/proxy/get-new-proxy", string_);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(JObject.Parse(text)["message"]!.ToString(), "\\d+").Value;
				Int32_3 = ((!(value == "")) ? int.Parse(value) : 0);
				if (Int32_3 == 0)
				{
					if (Int32_0 == 0)
					{
						String_1 = jObject["data"]!["https"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_2 = int.Parse(array[1]);
					}
					else
					{
						String_1 = jObject["data"]!["socks5"]!.ToString();
						string[] array2 = String_1.Split(':');
						String_2 = array2[0];
						Int32_2 = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	private string method_5(string string_3)
	{
		string text = "";
		try
		{
			text = new GClass18().method_0(string_3);
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
		}
		return text;
	}

	public bool method_6()
	{
		Int32_3 = 0;
		String_1 = "";
		String_2 = "";
		Int32_2 = 0;
		Int32_1 = 0;
		string string_ = "{\"api_key\": \"" + String_0 + "\"}";
		string text = smethod_1("https://tmproxy.com/api/proxy/get-current-proxy", string_);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "0")
				{
					Int32_3 = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
					Int32_1 = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
					if (Int32_0 == 0)
					{
						String_1 = jObject["data"]!["https"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_2 = int.Parse(array[1]);
					}
					else
					{
						String_1 = jObject["data"]!["socks5"]!.ToString();
						string[] array2 = String_1.Split(':');
						String_2 = array2[0];
						Int32_2 = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_7()
	{
		while (!method_6())
		{
		}
		return String_1;
	}

	private static string smethod_1(string string_3, string string_4)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpContent httpContent_0 = new StringContent(string_4, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => smethod_3(new Uri(string_3), httpContent_0));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Request Post");
			return "";
		}
	}

	public static string smethod_2(string string_3)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_4(new Uri(string_3)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Request get");
			return "";
		}
	}

	private static async Task<string> smethod_3(Uri uri_0, HttpContent httpContent_0)
	{
		string result = string.Empty;
		using (HttpClient httpClient = new HttpClient())
		{
			HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(uri_0, httpContent_0);
			if (httpResponseMessage.IsSuccessStatusCode)
			{
				result = await httpResponseMessage.Content.ReadAsStringAsync();
			}
		}
		return result;
	}

	private static async Task<string> smethod_4(Uri uri_0)
	{
		string result = string.Empty;
		using (HttpClient httpClient = new HttpClient())
		{
			HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri_0);
			if (httpResponseMessage.IsSuccessStatusCode)
			{
				result = await httpResponseMessage.Content.ReadAsStringAsync();
			}
		}
		return result;
	}
}
