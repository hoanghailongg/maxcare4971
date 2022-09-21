using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

internal class Class14
{
	[CompilerGenerated]
	private sealed class Class15
	{
		public string string_0;
	}

	[CompilerGenerated]
	private sealed class Class16
	{
		public HttpContent httpContent_0;

		public Class15 class15_0;

		internal Task<string> method_0()
		{
			return smethod_1(new Uri(class15_0.string_0), httpContent_0);
		}
	}

	private object object_0 = new object();

	private object object_1 = new object();

	public int int_0;

	private string string_0;

	public string string_1;

	public string string_2 = "";

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3 = 3;

	public Class14(string string_3, string string_4, int int_4, int int_5)
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
			string string_ = "https://apiv2-public.vitechcheap.com/v1/public/rotate";
			string string_2 = "{\"proxy\": \"" + string_1 + "\"}";
			smethod_0(string_, string_0, string_2);
			return result;
		}
		catch
		{
			return false;
		}
	}

	private static string smethod_0(string string_3, string string_4, string string_5)
	{
		string text = "";
		try
		{
			HttpClient httpClient = new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string_4);
			HttpContent httpContent_0 = new StringContent(string_5, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => smethod_1(new Uri(string_3), httpContent_0));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Request Post");
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
			return result;
		}
		catch
		{
			return result;
		}
	}
}
