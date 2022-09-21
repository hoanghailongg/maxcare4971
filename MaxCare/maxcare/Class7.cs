using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class7
{
	[CompilerGenerated]
	private sealed class Class8
	{
		public string string_0;

		internal Task<string> method_0()
		{
			return smethod_2(new Uri(string_0));
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

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	private object object_0 = new object();

	public int int_2 = 0;

	public int int_3 = 0;

	public int int_4 = 3;

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

	public Class7(string string_3, int int_5, int int_6)
	{
		String_0 = string_3;
		String_1 = "";
		String_2 = "";
		Int32_1 = 0;
		Int32_0 = int_5;
		int_4 = int_6;
		int_2 = 0;
		int_3 = 0;
	}

	public void method_0()
	{
		lock (object_0)
		{
			int_2--;
			if (int_2 == 0 && int_3 == int_4)
			{
				int_3 = 0;
			}
		}
	}

	public bool method_1()
	{
		String_1 = "";
		String_2 = "";
		Int32_1 = 0;
		string text = smethod_0("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + String_0);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["status"]!.ToString() == "success")
				{
					if (Int32_0 == 0)
					{
						String_1 = jObject["data"]!["proxy"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_1 = int.Parse(array[1]);
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

	public bool method_2()
	{
		String_1 = "";
		String_2 = "";
		Int32_1 = 0;
		string text = smethod_0("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + String_0);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["status"]!.ToString() == "success")
				{
					String_1 = jObject["data"]!["proxy"]!.ToString();
					string[] array = String_1.Split(':');
					String_2 = array[0];
					Int32_1 = int.Parse(array[1]);
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_3()
	{
		while (!method_2())
		{
		}
		return String_1;
	}

	public static string smethod_0(string string_3)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_2(new Uri(string_3)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Request get");
			return "";
		}
	}

	private static async Task<string> smethod_1(Uri uri_0, HttpContent httpContent_0)
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

	private static async Task<string> smethod_2(Uri uri_0)
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
