using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class11
{
	[CompilerGenerated]
	private sealed class Class12
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
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_4;

	private object object_0 = new object();

	private object object_1 = new object();

	private int int_5 = 0;

	public int int_6 = 0;

	public int int_7 = 0;

	public int int_8 = 3;

	public bool bool_0 = true;

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

	public int Int32_4
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string String_4
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public Class11(int int_9, string string_5, int int_10, int int_11)
	{
		Int32_0 = int_9;
		String_0 = string_5;
		String_1 = "";
		String_2 = "";
		Int32_3 = 0;
		Int32_4 = 0;
		Int32_1 = int_10;
		int_8 = int_11;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		String_3 = "";
		String_4 = "";
	}

	public static bool smethod_0(int int_9, string string_5)
	{
		string text = "";
		text = ((int_9 != 0) ? smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-status?api_key=" + string_5) : smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + string_5));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
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
			if (int_6 == 0)
			{
				if (int_7 > 0 && int_7 < int_8)
				{
					if (method_1() < 30 && method_3() != 1)
					{
						return "0";
					}
				}
				else if (method_3() != 1)
				{
					return "0";
				}
			}
			else
			{
				if (int_7 >= int_8)
				{
					return "2";
				}
				if (method_1() < 30 && method_3() != 1)
				{
					return "0";
				}
			}
			int_7++;
			int_6++;
			return "1";
		}
	}

	public int method_1()
	{
		method_4();
		return Int32_2;
	}

	public void method_2()
	{
		lock (object_1)
		{
			int_6--;
			if (int_6 == 0 && int_7 == int_8)
			{
				bool_0 = true;
				int_7 = 0;
			}
		}
	}

	public int method_3()
	{
		String_1 = "";
		String_2 = "";
		Int32_3 = 0;
		string text = "";
		text = ((Int32_0 != 0) ? smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-new-proxy?api_key=" + String_0) : smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + String_0));
		if (text != "")
		{
			if (text.Contains("api expired"))
			{
				return -1;
			}
			if (text.Contains("api wrong") || text.Contains("error"))
			{
				return -2;
			}
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(jObject["data"]!["next_request"]!.ToString(), "\\d+").Value;
				Int32_4 = ((!(value == "")) ? int.Parse(value) : 0);
				if (jObject["code"]!.ToString() == "2")
				{
					String_3 = jObject["data"]!["ip_allow"]!.ToString();
					String_4 = jObject["data"]!["your_ip"]!.ToString();
					if (Int32_0 == 0)
					{
						String_1 = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_3 = int.Parse(array[1]);
						return 1;
					}
					if (Int32_0 == 1)
					{
						if (Int32_1 == 0)
						{
							String_1 = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = String_1.Split(':');
							String_2 = array2[0];
							Int32_3 = int.Parse(array2[1]);
						}
						else if (Int32_1 == 1)
						{
							String_1 = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = String_1.Split(':');
							String_2 = array3[0];
							Int32_3 = int.Parse(array3[1]);
						}
						else if (Int32_1 == 2)
						{
							String_1 = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = String_1.Split(':');
							String_2 = array4[0];
							Int32_3 = int.Parse(array4[1]);
						}
						else
						{
							String_1 = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = String_1.Split(':');
							String_2 = array5[0];
							Int32_3 = int.Parse(array5[1]);
						}
						return 1;
					}
				}
				return 0;
			}
			catch
			{
			}
		}
		Int32_4 = 0;
		return 0;
	}

	public bool method_4()
	{
		Int32_4 = 0;
		String_1 = "";
		String_2 = "";
		Int32_3 = 0;
		Int32_2 = 0;
		string text = "";
		text = ((Int32_0 != 0) ? smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-current-proxy?api_key=" + String_0) : smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + String_0));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
				{
					Int32_4 = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
					Int32_2 = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
					String_3 = jObject["data"]!["ip_allow"]!.ToString();
					String_4 = jObject["data"]!["your_ip"]!.ToString();
					if (Int32_0 == 0)
					{
						String_1 = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = String_1.Split(':');
						String_2 = array[0];
						Int32_3 = int.Parse(array[1]);
						return true;
					}
					if (Int32_0 == 1)
					{
						if (Int32_1 == 0)
						{
							String_1 = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = String_1.Split(':');
							String_2 = array2[0];
							Int32_3 = int.Parse(array2[1]);
						}
						else if (Int32_1 == 1)
						{
							String_1 = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = String_1.Split(':');
							String_2 = array3[0];
							Int32_3 = int.Parse(array3[1]);
						}
						else if (Int32_1 == 2)
						{
							String_1 = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = String_1.Split(':');
							String_2 = array4[0];
							Int32_3 = int.Parse(array4[1]);
						}
						else
						{
							String_1 = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = String_1.Split(':');
							String_2 = array5[0];
							Int32_3 = int.Parse(array5[1]);
						}
						return true;
					}
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_5()
	{
		while (!method_4())
		{
		}
		return String_1;
	}

	public static string smethod_1(string string_5)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_2(new Uri(string_5)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Request get");
			return "";
		}
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
