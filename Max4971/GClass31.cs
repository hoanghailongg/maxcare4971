using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class GClass31
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public GClass31(string string_1)
	{
		String_0 = string_1;
	}

	public bool method_0(int int_0, string string_1, out string string_2)
	{
		string text = "";
		string text2 = "";
		text2 = ((int_0 != 0) ? "api.captcha.guru" : "2captcha.com");
		using (WebClient webClient = new WebClient())
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["method"] = "base64";
			nameValueCollection["key"] = String_0;
			nameValueCollection["body"] = string_1;
			byte[] bytes = webClient.UploadValues("http://" + text2 + "/in.php", nameValueCollection);
			text = Encoding.Default.GetString(bytes);
		}
		Thread.Sleep(TimeSpan.FromSeconds(5.0));
		if (text.Substring(0, 3) == "OK|")
		{
			string text3 = text.Remove(0, 3);
			for (int i = 0; i < 24; i++)
			{
				WebRequest webRequest = WebRequest.Create("http://" + text2 + "/res.php?key=" + String_0 + "&action=get&id=" + text3);
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
					string text4 = streamReader.ReadToEnd();
					if (text4.Length < 3)
					{
						string_2 = text4;
						return false;
					}
					if (text4.Substring(0, 3) == "OK|")
					{
						string_2 = text4.Remove(0, 3);
						return true;
					}
					if (text4 != "CAPCHA_NOT_READY")
					{
						string_2 = text4;
						return false;
					}
				}
				Thread.Sleep(5000);
			}
			string_2 = "Timeout";
			return false;
		}
		string_2 = text;
		return false;
	}

	public static string smethod_0(int int_0, string string_1, string string_2)
	{
		string string_3 = "";
		GClass31 gClass = new GClass31(string_1);
		bool flag = gClass.method_0(int_0, string_2, out string_3);
		while (!flag)
		{
			flag = gClass.method_0(int_0, string_2, out string_3);
			Thread.Sleep(TimeSpan.FromSeconds(2.0));
		}
		return string_3;
	}

	public static string smethod_1(string string_1, string string_2, int int_0, string string_3 = "", string string_4 = "")
	{
		string string_5 = "";
		GClass31 gClass = new GClass31(string_1);
		gClass.method_1(string_2, int_0, out string_5, string_3, string_4);
		return string_5;
	}

	private bool method_1(string string_1, int int_0, out string string_2, string string_3 = "", string string_4 = "")
	{
		string text = "";
		using (WebClient webClient = new WebClient())
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["method"] = "base64";
			nameValueCollection["key"] = String_0;
			nameValueCollection["body"] = string_1;
			nameValueCollection["type"] = int_0.ToString();
			nameValueCollection["code"] = string_3;
			nameValueCollection["hash"] = string_4;
			byte[] bytes = webClient.UploadValues("http://captchafb.xyz/in.php", nameValueCollection);
			text = Encoding.Default.GetString(bytes);
		}
		Thread.Sleep(TimeSpan.FromSeconds(1.0));
		if (text.Substring(0, 3) == "OK|")
		{
			string text2 = text.Remove(0, 3);
			for (int i = 0; i < 24; i++)
			{
				WebRequest webRequest = WebRequest.Create("http://captchafb.xyz/res.php?id=" + text2);
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
					string text3 = streamReader.ReadToEnd();
					if (text3.Length < 3)
					{
						string_2 = text3;
						return false;
					}
					if (text3.Substring(0, 3) == "OK|")
					{
						string_2 = text3.Remove(0, 3);
						return true;
					}
					if (text3 != "CAPCHA_NOT_READY")
					{
						string_2 = text3;
						return false;
					}
				}
				Thread.Sleep(2000);
			}
			string_2 = "Timeout";
			return false;
		}
		string_2 = text;
		return false;
	}

	public bool method_2(int int_0, string string_1, string string_2, out string string_3, string string_4 = "")
	{
		string text = "";
		switch (int_0)
		{
		case 0:
			text = "2captcha.com";
			break;
		case 1:
			text = "api.captcha.guru";
			break;
		case 3:
			text = string_4.Split('*')[0];
			String_0 = string_4.Split('*')[1];
			break;
		}
		string requestUriString = "http://" + text + "/in.php?key=" + String_0 + "&method=userrecaptcha&googlekey=" + string_1 + "&pageurl=" + string_2;
		try
		{
			WebRequest webRequest = WebRequest.Create(requestUriString);
			using WebResponse webResponse = webRequest.GetResponse();
			using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
			string text2 = streamReader.ReadToEnd();
			if (text2.Length < 3)
			{
				string_3 = text2;
				return false;
			}
			if (text2.Substring(0, 3) == "OK|")
			{
				string text3 = text2.Remove(0, 3);
				for (int i = 0; i < 24; i++)
				{
					WebRequest webRequest2 = WebRequest.Create("http://" + text + "/res.php?key=" + String_0 + "&action=get&id=" + text3);
					using (WebResponse webResponse2 = webRequest2.GetResponse())
					{
						using StreamReader streamReader2 = new StreamReader(webResponse2.GetResponseStream());
						string text4 = streamReader2.ReadToEnd();
						if (text4.Length < 3)
						{
							string_3 = text4;
							return false;
						}
						if (text4.Substring(0, 3) == "OK|")
						{
							string_3 = text4.Remove(0, 3);
							return true;
						}
						if (text4 != "CAPCHA_NOT_READY")
						{
							string_3 = text4;
							return false;
						}
					}
					Thread.Sleep(5000);
				}
				string_3 = "Timeout";
				return false;
			}
			string_3 = text2;
			return false;
		}
		catch
		{
		}
		string_3 = "Unknown error";
		return false;
	}

	public static string smethod_2(int int_0, string string_1, string string_2, string string_3)
	{
		string string_4 = "";
		GClass31 gClass = null;
		gClass = ((!string_1.Contains("*")) ? new GClass31(string_1) : new GClass31(string_1.Split('*')[1]));
		bool flag = gClass.method_2(int_0, string_2, string_3, out string_4, string_1);
		while (!flag)
		{
			flag = gClass.method_2(int_0, string_2, string_3, out string_4, string_1);
			Thread.Sleep(TimeSpan.FromSeconds(2.0));
		}
		return string_4;
	}
}
