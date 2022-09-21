using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HttpRequest;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using xNet;

public class GClass28
{
	public static int int_0;

	public static int int_1;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	private static string[] string_3 = new string[15]
	{
		"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
		"ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"
	};

	public static string smethod_0(string string_4)
	{
		string text = "";
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_4
		});
		string input = requestHTTP.Request("GET", "https://business.facebook.com/business_locations/");
		return Regex.Match(input, "EAAG(.*?)\"").Value.Replace("\"", "");
	}

	public static void smethod_1(ChromeDriver chromeDriver_0)
	{
		try
		{
			chromeDriver_0.Quit();
		}
		catch
		{
		}
	}

	public static ChromeDriver smethod_2(ChromeDriver chromeDriver_0, bool bool_0, bool bool_1, string string_4, string string_5, bool bool_2, Point point_0, Point point_1, string string_6, int int_2 = 0, int int_3 = 0)
	{
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		if (bool_0)
		{
			chromeDriverService.HideCommandPromptWindow = true;
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments("--disable-notifications", "--window-size=" + point_0.X + "," + point_0.Y, "--window-position=" + point_1.X + "," + point_1.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--mute-audio", "--disable-popup-blocking", "--user-agent=" + string_4);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.notifications", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.popups", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.auto_select_certificate", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.mixed_script", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protocol_handlers", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.midi_sysex", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.push_messaging", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.ssl_cert_decisions", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.metro_switch_to_desktop", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protected_media_identifier", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.site_engagement", 1);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.durable_storage", 1);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.images", 1);
		chromeOptions.AddUserProfilePreference("useAutomationExtension", true);
		if (bool_2)
		{
			string_5 = "";
			chromeOptions.AddArgument("--headless");
		}
		if (bool_1)
		{
			chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
		}
		if (!string.IsNullOrEmpty(string_5.Trim()))
		{
			chromeOptions.AddArgument("--user-data-dir=" + string_5);
		}
		if (string_6 == "-1")
		{
			string_6 = "";
		}
		if (!string.IsNullOrEmpty(string_6.Trim()))
		{
			chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + string_6);
		}
		chromeDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		chromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int_2);
		chromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(int_3);
		return chromeDriver_0;
	}

	public static List<string> smethod_3(List<string> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Trim() == "")
			{
				list_0.RemoveAt(i--);
			}
		}
		return list_0;
	}

	public static string smethod_4(string string_4)
	{
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/groups/?seemore&refid=27");
			MatchCollection matchCollection = Regex.Matches(input, "</li>");
			return matchCollection.Count.ToString();
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_5(string string_4)
	{
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/profile.php?v=friends&refid=17");
			string input2 = Regex.Match(input, "allactivity\\?refid=17\"(.*?)</h3>").Value.ToString();
			string text = Regex.Match(input2, "\\((.*?)\\)").Groups[1].Value.ToString().Replace(".", "");
			if (text == "")
			{
				text = "0";
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_6(string string_4)
	{
		try
		{
			string value = Regex.Match(string_4, "c_user=(.*?);").Value;
			string value2 = Regex.Match(string_4, "xs=(.*?);").Value;
			string value3 = Regex.Match(string_4, "fr=(.*?);").Value;
			string value4 = Regex.Match(string_4, "datr=(.*?);").Value;
			return value + value2 + value3 + value4;
		}
		catch
		{
			return string_4;
		}
	}

	public static bool smethod_7(ChromeDriver chromeDriver_0, int int_2, string string_4)
	{
		try
		{
			if (int_2 == 0)
			{
				chromeDriver_0.FindElementById(string_4);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_8(string string_4)
	{
		bool result = false;
		try
		{
			xNet.HttpRequest httpRequest = new xNet.HttpRequest();
			httpRequest.KeepAlive = true;
			httpRequest.Cookies = new CookieDictionary();
			httpRequest.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
			httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string address = "https://graph.facebook.com/" + string_4 + "/picture";
			httpRequest.Get(address).ToString();
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_9(string string_4)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string text = requestHTTP.Request("GET", "https://graph.facebook.com/" + string_4 + "/picture");
		if (text.Contains("error"))
		{
			return false;
		}
		return true;
	}

	public static string smethod_10(string string_4, string string_5)
	{
		string text = "";
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string input = requestHTTP.Request("GET", "https://login.yahoo.com/config/login");
		string value = Regex.Match(input, "acrumb\" value=\"(.*?)\"").Groups[1].Value;
		string value2 = Regex.Match(input, "sessionIndex\" value=\"(.*?)\"").Groups[1].Value;
		string value3 = Regex.Match(input, "persistent\" value=\"(.*?)\"").Groups[1].Value;
		string s = "acrumb=" + value + "&sessionIndex=" + value2 + "&username=" + string_4 + "&passwd=&signin=Ti%E1%BA%BFp%C2%A0theo&persistent=" + value3;
		input = requestHTTP.Request("POST", "https://login.yahoo.com/config/login", null, Encoding.ASCII.GetBytes(s));
		string value4 = Regex.Match(input, "crumb\" value=\"(.*?)\"").Groups[1].Value;
		string value5 = Regex.Match(input, "passwordContext\" value=\"(.*?)\"").Groups[1].Value;
		s = "browser-fp-data=%7B%22language%22%3A%22en-US%22%2C%22colorDepth%22%3A24%2C%22deviceMemory%22%3A8%2C%22pixelRatio%22%3A1%2C%22hardwareConcurrency%22%3A8%2C%22timezoneOffset%22%3A-420%2C%22timezone%22%3A%22Asia%2FBangkok%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22openDatabase%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22Win32%22%2C%22doNotTrack%22%3A%221%22%2C%22plugins%22%3A%7B%22count%22%3A3%2C%22hash%22%3A%22e43a8bc708fc490225cde0663b28278c%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Google+Inc.%7EANGLE+%28Intel%28R%29+UHD+Graphics+630+Direct3D11+vs_5_0+ps_5_0%29%22%2C%22adBlock%22%3A1%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A0%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A0%2C%22event%22%3A0%2C%22start%22%3A0%7D%2C%22fonts%22%3A%7B%22count%22%3A45%2C%22hash%22%3A%2246a30c0488455f08568f3e573502b25e%22%7D%2C%22audio%22%3A%22124.0434474653739%22%2C%22resolution%22%3A%7B%22w%22%3A%221920%22%2C%22h%22%3A%221080%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%221040%22%2C%22h%22%3A%221920%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1559177497471%2C%22render%22%3A1559177497688%7D%7D&crumb=" + value4 + "&acrumb=" + value + "&sessionIndex=" + value2 + "&displayName=phuonglazy&username=" + string_4 + "&passwordContext=" + value5 + "&password=" + string_5 + "&verifyPassword=%C4%90%C4%83ng+nh%E1%BA%ADp";
		input = requestHTTP.Request("POST", "https://login.yahoo.com/account/challenge/password", null, Encoding.ASCII.GetBytes(s));
		requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
		text = ((input.Contains("login-passwd") || !input.Contains(string_4.Replace("@yahoo.com", ""))) ? "0|" : "1|");
		string cookiesString = requestHTTP.GetCookiesString("https://login.yahoo.com");
		return text + cookiesString;
	}

	public static string smethod_11(string string_4, string string_5)
	{
		string text = "";
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_5
		});
		string text2 = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
		text = ((text2.Contains("login-username") || !text2.Contains(string_4.Replace("@yahoo.com", ""))) ? "0|" : "1|");
		string cookiesString = requestHTTP.GetCookiesString("https://login.yahoo.com");
		return text + cookiesString;
	}

	public static string smethod_12(string string_4, int int_2)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_4
		});
		requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
		bool flag = false;
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			if (Environment.TickCount - tickCount <= int_2 * 1000)
			{
				string input = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
				string value = Regex.Match(input, "message-subject(.*?)</span>", RegexOptions.Singleline).Value;
				text = Regex.Match(value, "\\d{6}", RegexOptions.Singleline).Value;
				if (text != "")
				{
					flag = true;
					break;
				}
				continue;
			}
			return "";
		}
		while (!flag);
		return text;
	}

	public static string smethod_13(string string_4, string string_5)
	{
		string text = "";
		try
		{
			using (ImapClient imapClient = new ImapClient())
			{
				imapClient.Connect("outlook.office365.com", 993, useSsl: true);
				imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
				imapClient.Authenticate(string_4, string_5);
				IMailFolder inbox = imapClient.Inbox;
				inbox.Open(FolderAccess.ReadOnly);
				for (int i = 0; i < inbox.Count; i++)
				{
					MimeMessage message = inbox.GetMessage(i);
					inbox.AddFlags(i, MessageFlags.Deleted, silent: true);
					_ = message.Subject;
				}
				imapClient.Disconnect(quit: true);
			}
			return "1";
		}
		catch
		{
			return "0";
		}
	}

	public static void smethod_14(ChromeDriver chromeDriver_0, string string_4)
	{
		try
		{
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1, 1000);
			string text2 = "";
			if (chromeDriver_0 != null)
			{
				text2 = chromeDriver_0.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
				Screenshot screenshot = ((ITakesScreenshot)chromeDriver_0).GetScreenshot();
				screenshot.SaveAsFile("log\\images\\" + text + ".png");
				File.WriteAllText("log\\html\\" + text + ".html", text2);
			}
			File.AppendAllText("log\\log.txt", DateTime.Now.ToString() + "|<" + text + ">|" + string_4 + Environment.NewLine);
		}
		catch
		{
		}
	}

	public static string smethod_15(string string_4, string string_5, int int_2)
	{
		bool flag = false;
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			if (Environment.TickCount - tickCount <= int_2 * 1000)
			{
				using (ImapClient imapClient = new ImapClient())
				{
					imapClient.Connect("outlook.office365.com", 993, useSsl: true);
					imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
					imapClient.Authenticate(string_4, string_5);
					IMailFolder inbox = imapClient.Inbox;
					inbox.Open(FolderAccess.ReadOnly);
					if (inbox.Count <= 0)
					{
						goto IL_00ce;
					}
					MimeMessage message = inbox.GetMessage(0);
					string input = message.Body.ToString();
					text = Regex.Match(input, "\\d{6}", RegexOptions.Singleline).Value;
					if (text.Equals(""))
					{
						goto IL_00ce;
					}
					flag = true;
					goto end_IL_001a;
					IL_00ce:
					imapClient.Disconnect(quit: true);
					continue;
					end_IL_001a:;
				}
				break;
			}
			return "";
		}
		while (!flag);
		return text;
	}

	public static bool smethod_16(string string_4, string string_5)
	{
		bool result = false;
		try
		{
			if (smethod_18(string_4).Equals("Die"))
			{
				return result;
			}
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/" + string_5);
			string text = Regex.Match(input, "/a/mobile/friends/profile_add_friend(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
			if (text.Equals(""))
			{
				return result;
			}
			text = "https://mbasic.facebook.com" + text;
			input = requestHTTP.Request("GET", text);
			Thread.Sleep(300);
			input = requestHTTP.Request("GET", "https://mbasic.facebook.com/" + string_5);
			result = ((!input.Contains("profile_add_friend")) ? true : false);
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_17(string string_4, string string_5, int int_2 = 0)
	{
		int num = 0;
		try
		{
			if (smethod_18(string_4).Equals("Die"))
			{
				return "";
			}
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string url = "https://mbasic.facebook.com/send_page_invite/?pageid=" + string_5;
			bool flag = false;
			do
			{
				flag = false;
				string text = requestHTTP.Request("GET", url);
				MatchCollection matchCollection = Regex.Matches(text, "/pages/friend_invite/send/(.*?)\"");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					string url2 = "https://mbasic.facebook.com" + matchCollection[i].Value.Replace("\"", "").Replace("amp;", "");
					requestHTTP.Request("GET", url2);
					num++;
					if (int_2 != 0)
					{
						Thread.Sleep(int_2);
					}
				}
				if (text.Contains("offset"))
				{
					flag = true;
				}
			}
			while (flag);
		}
		catch
		{
		}
		return num.ToString() ?? "";
	}

	public static string smethod_18(string string_4)
	{
		string_4 = smethod_67(string_4);
		string result = "Die";
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string value = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
			string text = requestHTTP.Request("GET", "https://www.facebook.com/me");
			if (!value.Equals("") && text.Contains(value) && text.Contains("entity_id") && !text.Contains("checkpointSubmitButton"))
			{
				result = "Live";
			}
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_19(string string_4, string string_5 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
	{
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: application/x-www-form-urlencoded",
				"user-agent: " + string_5,
				"cookie: " + string_4
			});
			string text = requestHTTP.Request("GET", "https://m.facebook.com/ajax/dtsg/?__ajax__=true");
			text = text.Replace("for (;;);", "");
			JObject jObject = JObject.Parse(text);
			return jObject["payload"]!["token"]!.ToString();
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_20(string string_4, string string_5, string string_6, string string_7)
	{
		string text = smethod_21(string_6);
		if (text == "")
		{
			return "";
		}
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_4
		});
		string value = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
		string value2 = smethod_19(string_4);
		string input = requestHTTP.Request("GET", "https://m.facebook.com/me");
		string value3 = Regex.Match(input, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
		string value4 = Regex.Match(input, "name=\"privacyx\" value=\"(.*?)\"").Groups[1].Value;
		string value5 = Regex.Match(input, "__spin_r\":(.*?),").Groups[1].Value;
		string text2 = value5;
		string value6 = Regex.Match(input, "__spin_t\":(.*?),").Groups[1].Value;
		string s = "__user=" + value + "&__a=1&__dyn=7AgNe-UOByEogDxyHqzGomzFEbEyGzEy4aheC267Uqzob4q2i5UK3u2C3-u5RyUoxGEbbyEjKewXwgUOdwJyFElwzxCuifz8nxm1Dxa2m4o6e2e79oeGwaWum1NwJxCq7ooxu6U8kU4m3mbx-2K1KUkBzXG6o6CEWu4EhwG-U99m4-3Cfz8-4U-5898Gfxm7omyUnG12AgG4eeKi8wg8jyE5WcyES48y8xK3yeCzEmgK7o88vwEy8iwSwjU4W2WE9EjwtUym2mfxW68lBwcO&__csr=&__req=13&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value5 + "&__s=k2qltm%3Act038n%3Av4okyh&__hsi=6766055500147629515-0&fb_dtsg=" + WebUtility.UrlEncode(value2) + "&jazoest=" + value3 + "&__spin_r=" + text2 + "&__spin_b=trunk&__spin_t=" + value6;
		string text3 = "";
		text3 = ((!(string_7 != "")) ? ("https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=self&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(string_5) + "&owner_id=&post_id=" + text + "&privacy=" + value4 + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + value) : ("https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=group&audience_targets[0]=" + string_7 + "&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(string_5) + "&owner_id=&post_id=" + text + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + value));
		string input2 = requestHTTP.Request("POST", text3, null, Encoding.ASCII.GetBytes(s));
		return Regex.Match(input2, "object_id\":(.*?),").Groups[1].Value;
	}

	public static string smethod_21(string string_4)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: application/x-www-form-urlencoded", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36" });
		string input = requestHTTP.Request("GET", string_4);
		string value = Regex.Match(input, "\\\\\"post_fbid\\\\\":(.*?)}", RegexOptions.Singleline).Groups[1].Value;
		if (value == "")
		{
			value = Regex.Match(input, "share_fbid:\"(.*?)\"", RegexOptions.Singleline).Groups[1].Value;
		}
		if (value == "")
		{
			value = Regex.Match(input, "videos/(.*?)/", RegexOptions.Singleline).Groups[1].Value;
		}
		return value;
	}

	public static void smethod_22(string string_4)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_4
		});
		string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/privacy/touch/composer/selector/?logging_source=composer_options");
		string text = Regex.Match(input, "/privacy/save(.*?)\"").Value.Replace("\"", "").Replace("&amp;", "&");
		requestHTTP.Request("GET", "https://mbasic.facebook.com" + text);
	}

	public static List<string> smethod_23(string string_4)
	{
		List<string> list = new List<string>();
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + string_4
		});
		string text = "https://mbasic.facebook.com/friends/center/friends/?ppk=" + 0;
		bool flag = true;
		try
		{
			while (flag)
			{
				string input = requestHTTP.Request("GET", text);
				MatchCollection matchCollection = Regex.Matches(input, "/friends/hovercard(.*?)<");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					string value = Regex.Match(matchCollection[i].Value, "uid=(.*?)&").Groups[1].Value;
					string value2 = Regex.Match(matchCollection[i].Value, ">(.*?)<").Groups[1].Value;
					list.Add(value + "|" + value2);
				}
				text = Regex.Match(input, "/friends/center/friends/.ppk=(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
				if (text.Equals(""))
				{
					flag = false;
					continue;
				}
				flag = true;
				text = "https://mbasic.facebook.com" + text;
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool smethod_24(string string_4)
	{
		bool flag = false;
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + string_4
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/me/friends");
			string text = Regex.Match(input, "/privacyx/selector/(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
			text = "https://mbasic.facebook.com" + text;
			input = requestHTTP.Request("GET", text);
			string text2 = Regex.Match(input, "/a/privacy/.px=300645083384735(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
			text2 = "https://mbasic.facebook.com" + text2;
			input = requestHTTP.Request("GET", text2);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static List<string> smethod_25(string string_4)
	{
		List<string> list = new List<string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/accounts?access_token=" + string_4 + "&fields=id,likes&limit=50");
			JObject jObject = JObject.Parse(json);
			for (int i = 0; i < jObject["data"].Count(); i++)
			{
				list.Add(jObject["data"]![i]!["id"]!.ToString() + "|" + jObject["data"]![i]!["likes"]!.ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_26(string string_4)
	{
		List<string> list = new List<string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/businesses?access_token=" + string_4 + "&fields=id,name&limit=50");
			JObject jObject = JObject.Parse(json);
			for (int i = 0; i < jObject["data"].Count(); i++)
			{
				list.Add(jObject["data"]![i]!["id"]!.ToString() + "|" + jObject["data"]![i]!["name"]!.ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_27(string string_4)
	{
		List<string> list = new List<string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/adaccounts?access_token=" + string_4 + "&fields=id,min_billing_threshold&limit=100");
			JObject jObject = JObject.Parse(json);
			for (int i = 0; i < jObject["data"].Count(); i++)
			{
				try
				{
					list.Add(jObject["data"]![i]!["id"]!.ToString() + "|" + jObject["data"]![i]!["min_billing_threshold"]!["amount"]!.ToString() + " " + jObject["data"]![i]!["min_billing_threshold"]!["currency"]!.ToString());
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_28(string string_4)
	{
		List<string> list = new List<string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/groups?access_token=" + string_4 + "&fields=id,administrator,member_count&limit=5000");
			JObject jObject = JObject.Parse(json);
			for (int i = 0; i < jObject["data"].Count(); i++)
			{
				try
				{
					if (jObject["data"]![i]!["administrator"]!.ToString().Equals("True"))
					{
						list.Add(jObject["data"]![i]!["id"]!.ToString() + "|" + jObject["data"]![i]!["member_count"]!.ToString());
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static Dictionary<string, string> smethod_29(string string_4, string string_5, string string_6 = "")
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			int num = 0;
			JObject jObject;
			string value;
			string text;
			string text2;
			string value2;
			string value3;
			string value4;
			string value5;
			while (true)
			{
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/v2.11/" + string_5 + "?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + string_4);
				jObject = JObject.Parse(json);
				value = "";
				text = "";
				text2 = "";
				value2 = "";
				value3 = "";
				value4 = "";
				value5 = "Live";
				jObject["name"]!.ToString();
				try
				{
					value4 = jObject["birthday"]!.ToString();
				}
				catch
				{
				}
				try
				{
					value3 = jObject["gender"]!.ToString();
				}
				catch
				{
				}
				try
				{
					value = jObject["email"]!.ToString();
				}
				catch
				{
				}
				try
				{
					value2 = jObject["mobile_phone"]!.ToString();
				}
				catch
				{
				}
				try
				{
					text2 = jObject["friends"]!["summary"]!["total_count"]!.ToString();
				}
				catch
				{
					if (string_6 != "" && smethod_18(string_6) == "Live" && num == 0 && smethod_24(string_6))
					{
						num++;
						continue;
					}
				}
				break;
			}
			if (text2 == "")
			{
				text2 = "0";
			}
			try
			{
				text = jObject["groups"]!["data"].Count().ToString() ?? "";
			}
			catch
			{
			}
			if (text == "")
			{
				text = "0";
			}
			dictionary.Add("uid", jObject["id"]!.ToString());
			dictionary.Add("name", jObject["name"]!.ToString());
			dictionary.Add("birthday", value4);
			dictionary.Add("gender", value3);
			dictionary.Add("token", string_4);
			dictionary.Add("email", value);
			dictionary.Add("phone", value2);
			dictionary.Add("friends", text2);
			dictionary.Add("groups", text);
			dictionary.Add("info", value5);
		}
		catch
		{
			dictionary.Add("info", "Die");
		}
		return dictionary;
	}

	public static List<string> smethod_30(string string_4, int int_2)
	{
		List<string> list = new List<string>();
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string json = requestHTTP.Request("GET", "https://api.facebook.com/method/fql.query?query=select%20uid2%20from%20friend%20where%20uid1%20=%20me()%20order%20by%20rand()%20limit%20" + int_2 + "&access_token=" + string_4 + "&format=json").ToString();
		JArray source = JArray.Parse(json);
		List<JObject> list2 = source.OfType<JObject>().ToList();
		for (int i = 0; i < list2.Count(); i++)
		{
			list.Add(list2[i]["uid2"]!.ToString());
		}
		return list;
	}

	public static Dictionary<string, string> smethod_31(string string_4)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://graph.facebook.com/v2.11/me?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + string_4).ToString();
			JObject jObject = JObject.Parse(json);
			string value = "";
			string text = "";
			string text2 = "";
			string value2 = "";
			string value3 = "";
			string value4 = "Live";
			jObject["name"]!.ToString();
			try
			{
				jObject["birthday"]!.ToString();
			}
			catch
			{
			}
			try
			{
				value3 = jObject["gender"]!.ToString();
			}
			catch
			{
			}
			try
			{
				value = jObject["email"]!.ToString();
			}
			catch
			{
			}
			try
			{
				value2 = jObject["mobile_phone"]!.ToString();
			}
			catch
			{
			}
			text2 = jObject["friends"]!["summary"]!["total_count"]!.ToString();
			try
			{
				text = jObject["groups"]!["data"].Count().ToString() ?? "";
			}
			catch
			{
			}
			if (text == "")
			{
				text = "0";
			}
			dictionary.Add("uid", jObject["id"]!.ToString());
			dictionary.Add("name", jObject["name"]!.ToString());
			dictionary.Add("birthday", jObject["birthday"]!.ToString());
			dictionary.Add("gender", value3);
			dictionary.Add("token", string_4);
			dictionary.Add("email", value);
			dictionary.Add("phone", value2);
			dictionary.Add("friends", text2);
			dictionary.Add("groups", text);
			dictionary.Add("info", value4);
		}
		catch (Exception)
		{
			dictionary.Add("info", "Die");
		}
		return dictionary;
	}

	public static string smethod_32(string string_4, string string_5)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string text = "";
		bool flag = false;
		string text2 = "882a8490361da98702bf97a021ddc14d";
		string text3 = smethod_42("api_key=" + text2 + "email=" + string_4 + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + string_5 + "return_ssl_resources=0v=1.062f8ce9f74b12f84c123cc23437a4a32").ToLower();
		string json = requestHTTP.Request("GET", "https://api.facebook.com/restserver.php?&api_key=" + text2 + "&email=" + string_4 + "&format=JSON&locale=vi_vn&method=auth.login&password=" + string_5 + "&return_ssl_resources=0&v=1.0&sig=" + text3);
		JObject jObject = JObject.Parse(json);
		try
		{
			text = jObject["access_token"]!.ToString();
		}
		catch
		{
			flag = true;
			JToken? jToken = jObject["error_code"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken!.ToString();
				if (obj != null)
				{
					goto IL_0118;
				}
			}
			obj = "";
			goto IL_0118;
			IL_0118:
			text = (string)obj;
		}
		return flag ? ("1|" + text) : ("0|" + text);
	}

	public static string smethod_33(string string_4, string string_5)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string text = "";
		bool flag = false;
		string text2 = "3e7c78e35a76a9299309885393b02d97";
		string text3 = smethod_42("api_key=" + text2 + "email=" + string_4 + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + string_5 + "return_ssl_resources=0v=1.0c1e620fa708a1d5696fb991c1bde5662").ToLower();
		string json = requestHTTP.Request("GET", "https://api.facebook.com/restserver.php?&api_key=" + text2 + "&email=" + string_4 + "&format=JSON&locale=vi_vn&method=auth.login&password=" + string_5 + "&return_ssl_resources=0&v=1.0&sig=" + text3);
		JObject jObject = JObject.Parse(json);
		try
		{
			text = jObject["access_token"]!.ToString();
		}
		catch
		{
			flag = true;
			JToken? jToken = jObject["error_code"];
			object obj;
			if (jToken == null)
			{
				obj = null;
			}
			else
			{
				obj = jToken!.ToString();
				if (obj != null)
				{
					goto IL_0118;
				}
			}
			obj = "";
			goto IL_0118;
			IL_0118:
			text = (string)obj;
		}
		return flag ? ("1|" + text) : ("0|" + text);
	}

	public static string smethod_34(string string_4, string string_5)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string text = "";
		string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
		string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
		string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
		string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
		(new string[1])[0] = "referer: https://mbasic.facebook.com/checkpoint/?_rdr";
		string text2 = requestHTTP.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", null, Encoding.UTF8.GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
		text2 = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
		if (text2.Contains("checkpoint/?next"))
		{
			text = "2|";
			value = Regex.Match(text2, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			value2 = Regex.Match(text2, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value5 = Regex.Match(text2, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
			string value6 = Regex.Match(text2, "client_revision\":(.*?),").Groups[1].Value;
			input = requestHTTP.Request("POST", "https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", null, Encoding.UTF8.GetBytes("jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value5 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=&__req=&__be=0&__pc=PHASED%3ADEFAULT&dpr=&__rev=" + value6));
			input = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
			MatchCollection matchCollection = Regex.Matches(input, "verification_method\" value=\"(.*?)\"");
			if (matchCollection.Count > 0)
			{
				foreach (Match item in matchCollection)
				{
					text = text + item.Groups[1].Value + "-";
				}
				text = text.TrimEnd('-');
			}
			else if (input.Contains("full-name") || input.Contains("captcha"))
			{
				text += "72h";
			}
			else if (input.Contains("mvm uiP fsm"))
			{
				text += "vhh";
			}
			return text + "|" + requestHTTP.GetCookiesString("https://www.facebook.com/");
		}
		if (text2.Contains("id=\"email\"") || text2.Contains("id=\"pass\""))
		{
			return "3|";
		}
		return "1|" + requestHTTP.GetCookiesString("https://www.facebook.com/");
	}

	public static string smethod_35(string string_4, string string_5, string string_6, string string_7, int int_2)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + string_6
		});
		requestHTTP.SetProxy(string_7, int_2);
		requestHTTP.usProxy = true;
		string result = "";
		string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
		string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
		string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
		string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
		requestHTTP.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", null, Encoding.UTF8.GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
		requestHTTP.Request("GET", "https://m.facebook.com/checkpoint/?next=https%3A%2F%2Fm.facebook.com%2F");
		requestHTTP.Request("GET", "https://mbasic.facebook.com/checkpoint/?next=https%3A%2F%2Fmbasic.facebook.com%2F");
		requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%www.facebook.com%2F");
		return result;
	}

	public static string smethod_36(string string_4)
	{
		string result = "";
		switch (Class321.smethod_0(string_4))
		{
		case 401286136u:
			if (string_4 == "14")
			{
				result = "Thiết bị";
			}
			break;
		case 334175660u:
			if (string_4 == "18")
			{
				result = "Bình luận";
			}
			break;
		case 923577301u:
			if (string_4 == "2")
			{
				result = "Ngày sinh";
			}
			break;
		case 906799682u:
			if (string_4 == "3")
			{
				result = "Ảnh";
			}
			break;
		case 822911587u:
			if (string_4 == "4")
			{
				result = "Otp";
			}
			break;
		case 2347784130u:
			if (string_4 == "34")
			{
				result = "Otp";
			}
			break;
		case 1153637868u:
			if (string_4 == "72h")
			{
				result = "72h";
			}
			break;
		case 2517938561u:
			if (string_4 == "vhh")
			{
				result = "Vô hiệu hóa";
			}
			break;
		case 2381486463u:
			if (string_4 == "20")
			{
				result = "Tin nhắn";
			}
			break;
		case 2347931225u:
			if (string_4 == "26")
			{
				result = "Bạn bè";
			}
			break;
		}
		return result;
	}

	public static List<string> smethod_37(string string_4, string string_5)
	{
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		List<string> list = new List<string>();
		string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
		string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
		string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
		string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
		(new string[1])[0] = "referer: https://mbasic.facebook.com/checkpoint/?_rdr";
		string text = requestHTTP.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", null, Encoding.UTF8.GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
		if (text.Contains("checkpoint_title"))
		{
			value = Regex.Match(text, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			value2 = Regex.Match(text, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			_ = Regex.Match(input, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
			input = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
			string value5 = Regex.Match(input, "<select name=\"verification_method(.*?)</select>").Value;
			MatchCollection matchCollection = Regex.Matches(value5, "\\d{2}");
			foreach (Match item in matchCollection)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public static bool smethod_38(string string_4)
	{
		bool result = false;
		string_4 = string_4.Replace("@yahoo.com", "");
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[5] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", "X-Requested-With: XMLHttpRequest", "Cookie: AS=v=1&s=jc8Jz1UA", "Referrer: https://login.yahoo.com/account/module/create?validateField=yid" });
		string text = requestHTTP.Request("POST", "https://login.yahoo.com/account/module/create?validateField=yid", null, Encoding.UTF8.GetBytes("browser-fp-data=&specId=yidReg&crumb=&acrumb=jc8Jz1UA&c=&s=&done=https%3A%2F%2Fwww.yahoo.com&googleIdToken=&authCode=&tos0=yahoo_freereg%7Cvn%7Cvi-VN&tos1=yahoo_comms_atos%7Cvn%7Cvi-VN&firstName=&lastName=&yid=" + string_4 + "&password=&shortCountryCode=VN&phone=&mm=&dd=&yyyy=&freeformGender="));
		if (text.Contains("yid\",\"error"))
		{
			result = true;
		}
		return result;
	}

	public static bool smethod_39(string string_4)
	{
		bool flag = false;
		string_4 = string_4.Replace("@yahoo.com", "");
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		string json = requestHTTP.Request("GET", "https://login.microsoftonline.com/common/userrealm/?user=" + string_4 + "&api-version=2.1&stsRequest=rQIIAbPSySgpKSi20tcvyC8qSczRy81MLsovzk8ryc_LycxL1UvOz9XLL0rPTAGxioS4BC6HNYTFGB7zWy90MI6xcUHgKkZlwkboX2BkfMHIeItJ0L8o3TMlvNgtNSW1KLEkMz_vERNvaHFqkX9eTmVIfnZq3iRmvpz89My8-OKitPi0nPxyoADQhILE5JL4kszk7NSSXcwqiSaWqYZpKWm6xpZplromhiZmupYWiWa6FhYmZqaGFqlpFomJF1gEfrAwLmIFurmyae30LeVybvNE3C_Vi-5_e4pVPy_FOcvSIiIgNUPbJyU1KjE0PTcsMdezzCM5PN2oJN8zyN0g0MjZ3bzSuNzW0srwACcjAA2&checkForMicrosoftAccount=true").ToString();
		JObject jObject = JObject.Parse(json);
		if (jObject["MicrosoftAccount"]!.ToString().Equals("1"))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_40(string string_4)
	{
		bool flag = true;
		try
		{
			string value = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.87 Safari/537.36",
				"cookie: " + string_4
			});
			string text = requestHTTP.Request("GET", "https://www.facebook.com/");
			if (!value.Equals("") && text.Contains(value) && text.Contains("name=\"fb_dtsg\" value="))
			{
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/settings/email/");
				string text2 = Regex.Match(input, "/privacyx/selector(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
				string input2 = requestHTTP.Request("GET", "https://mbasic.facebook.com" + text2 + "&priv_expand=see_all");
				string text3 = Regex.Match(input2, "/a/privacy/.px=286958161406148(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
				if (text3.Equals(""))
				{
					return false;
				}
				requestHTTP.Request("GET", "https://mbasic.facebook.com" + text3);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static string smethod_41(string string_4)
	{
		string result = "";
		if (string_4.Split('|')[0] == "1")
		{
			result = Convert.ToInt32(string_4.Split('|')[1]) switch
			{
				400 => "Tài khoản không tồn tại", 
				104 => "Lỗi phần mềm", 
				613 => "Giới hạn lấy token", 
				405 => GClass29.smethod_0("Checkpoint"), 
				401 => "Changed pass", 
				_ => "Lỗi hệ thống", 
			};
		}
		return result;
	}

	public static string smethod_42(string string_4)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_4);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static void smethod_43(string string_4)
	{
		Process process = new Process();
		process.StartInfo.FileName = "rasdial.exe";
		process.StartInfo.Arguments = "\"" + string_4 + "\" /disconnect";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
		Thread.Sleep(1000);
	}

	public static void smethod_44(double double_0)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
	}

	public static void smethod_45(string string_4)
	{
		Thread.Sleep(1000);
		Process process = new Process();
		process.StartInfo.FileName = "rasdial.exe";
		process.StartInfo.Arguments = "\"" + string_4 + "\"";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
		Thread.Sleep(1500);
	}

	public static bool smethod_46(int int_2, string string_4, int int_3, string string_5)
	{
		return true;
	}

	private static string smethod_47(string string_4)
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c " + string_4;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		if (string.IsNullOrEmpty(text))
		{
			return "";
		}
		return text;
	}

	public static void smethod_48()
	{
		Process[] processesByName = Process.GetProcessesByName("chromedriver");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static Point smethod_49(int int_2, int int_3 = 6)
	{
		Point result = default(Point);
		int num = 2 * int_0 / int_3;
		int num2 = int_3 / 2;
		while (int_2 > 5)
		{
			int_2 -= 6;
		}
		if (int_2 <= num2 - 1)
		{
			result.Y = 0;
		}
		else if (int_2 < int_3)
		{
			result.Y = int_1 / 2;
			int_2 -= num2;
		}
		result.X = int_2 * num;
		return result;
	}

	public static DataTable smethod_50(string string_4, string string_5, int int_2)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			uint num = Class321.smethod_0(string_4);
			if (num <= 2071622424)
			{
				if (num <= 1605967500)
				{
					if (num <= 850372319)
					{
						if (num != 321211332)
						{
							if (num != 850372319 || !(string_4 == "backup"))
							{
								goto IL_031c;
							}
							text = "(backup like '%{0}%')";
							text = string.Format(text, string_5);
						}
						else
						{
							if (!(string_4 == "all"))
							{
								goto IL_031c;
							}
							text = "(uid like '%{0}%' OR token like '%{0}%' OR email like '%{0}%' OR phone like '%{0}%' OR name like '%{0}%' OR friends like '%{0}%' OR groups like '%{0}%' OR gender like '%{0}%' OR backup like '%{0}%' OR info like '%{0}%' OR pass like '%{0}%' OR cookie like '%{0}%' OR mailrecovery like '%{0}%' OR passmail like '%{0}%')";
							text = string.Format(text, string_5);
						}
					}
					else if (num != 1556604621)
					{
						if (num != 1605967500 || !(string_4 == "group"))
						{
							goto IL_031c;
						}
						text = "(groups like '%{0}%')";
						text = string.Format(text, string_5);
					}
					else
					{
						if (!(string_4 == "uid"))
						{
							goto IL_031c;
						}
						text = "(uid like '%{0}%')";
						text = string.Format(text, string_5);
					}
				}
				else if (num <= 2000032175)
				{
					if (num != 1841097094)
					{
						if (num != 2000032175 || !(string_4 == "phone"))
						{
							goto IL_031c;
						}
						text = "(phone like '%{0}%')";
						text = string.Format(text, string_5);
					}
					else
					{
						if (!(string_4 == "tinhtrang"))
						{
							goto IL_031c;
						}
						text = "(info like '%{0}%')";
						text = string.Format(text, string_5);
					}
				}
				else if (num != 2007449791)
				{
					if (num != 2071622424 || !(string_4 == "pass"))
					{
						goto IL_031c;
					}
					text = "(pass like '%{0}%')";
					text = string.Format(text, string_5);
				}
				else
				{
					if (!(string_4 == "cookie"))
					{
						goto IL_031c;
					}
					text = "(cookie like '%{0}%')";
					text = string.Format(text, string_5);
				}
			}
			else if (num <= 3416301453u)
			{
				if (num <= 2369371622u)
				{
					if (num != 2324124615u)
					{
						if (num != 2369371622u || !(string_4 == "name"))
						{
							goto IL_031c;
						}
						text = "(name like '%{0}%')";
						text = string.Format(text, string_5);
					}
					else
					{
						if (!(string_4 == "email"))
						{
							goto IL_031c;
						}
						text = "(email like '%{0}%')";
						text = string.Format(text, string_5);
					}
				}
				else if (num != 2491017778u)
				{
					if (num != 3416301453u || !(string_4 == "friend"))
					{
						goto IL_031c;
					}
					text = "(friends like '%{0}%')";
					text = string.Format(text, string_5);
				}
				else
				{
					if (!(string_4 == "token"))
					{
						goto IL_031c;
					}
					text = "(token like '%{0}%')";
					text = string.Format(text, string_5);
				}
			}
			else if (num <= 3979810479u)
			{
				if (num != 3968918830u)
				{
					if (num != 3979810479u || !(string_4 == "passmail"))
					{
						goto IL_031c;
					}
					text = "(passmail like '%{0}%')";
					text = string.Format(text, string_5);
				}
				else
				{
					if (!(string_4 == "mail"))
					{
						goto IL_031c;
					}
					text = "(mailrecovery like '%{0}%')";
					text = string.Format(text, string_5);
				}
			}
			else if (num != 4025178668u)
			{
				if (num != 4280007968u || !(string_4 == "gioitinh"))
				{
					goto IL_031c;
				}
				text = "(gender like '%{0}%')";
				text = string.Format(text, string_5);
			}
			else
			{
				if (!(string_4 == "birthday"))
				{
					goto IL_031c;
				}
				text = "(birthday like '%{0}%')";
				text = string.Format(text, string_5);
			}
			goto IL_0332;
			IL_031c:
			text = "(0 = 1)";
			goto IL_0332;
			IL_0332:
			string text2 = "SELECT * FROM accounts WHERE idfile = " + int_2 + " AND " + text;
			result = GClass11.GClass11_0.method_1(text2);
		}
		catch
		{
		}
		return result;
	}

	private static string smethod_51(string string_4)
	{
		return string_4 + "minsoftware.tk";
	}

	public static string smethod_52(int int_2 = 15)
	{
		string text = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		Random random = new Random();
		char[] array = new char[int_2];
		for (int i = 0; i < int_2 - 2; i++)
		{
			array[i] = text[random.Next(0, text.Length)];
		}
		array[13] = '1';
		array[14] = 'T';
		return new string(array);
	}

	public static bool smethod_53(object object_0, string string_4)
	{
		Type type = object_0.GetType();
		return type.GetMethod(string_4) != null;
	}

	public static string smethod_54(string string_4)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_4);
		return Encoding.UTF8.GetString(bytes);
	}

	public static double smethod_55(string string_4, string string_5)
	{
		double num = 0.0;
		string[] array = string_5.Split(' ');
		for (int i = 0; i < array.Length; i++)
		{
			if (string_5 != "" && string_4.Contains(" " + array[i] + " "))
			{
				num += 1.0;
			}
		}
		return num / (double)array.Length;
	}

	public static string smethod_56(string string_4)
	{
		int int_ = Class50.smethod_0();
		try
		{
			return Class50.smethod_1(string_4.Split('|')[0], string_4.Split('|')[1], string_4.Split('|')[2], int_) ? ("1|" + int_) : ("0|" + int_);
		}
		catch
		{
			return "0|" + int_;
		}
	}

	private static string smethod_57(string string_4)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_4);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X"));
		}
		return stringBuilder.ToString();
	}

	public static string smethod_58(string string_4 = "")
	{
		return GClass14.smethod_2();
	}

	public static string smethod_59(string string_4 = "")
	{
		if (string_4.Equals(""))
		{
			string_4 = smethod_58();
		}
		return smethod_60(smethod_51(string_4));
	}

	public static string smethod_60(string string_4)
	{
		string text = "";
		byte[] bytes = Encoding.UTF8.GetBytes(string_4);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("X2");
		}
		return text.ToLower();
	}

	public static string smethod_61()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "CMD.exe",
			Arguments = "/C wmic csproduct get UUID"
		};
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		process.WaitForExit();
		string text = process.StandardOutput.ReadToEnd();
		return text.Replace("UUID", "").Replace("\n", "").Replace(" ", "")
			.Replace("-", "")
			.Replace("\r", "");
	}

	public static string smethod_62()
	{
		string result = string.Empty;
		ManagementClass managementClass = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = managementClass.GetInstances();
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				result = managementObject.Properties["processorID"].Value.ToString();
			}
		}
		return result;
	}

	public static void smethod_63()
	{
		ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
		managementClass.Get();
		managementClass.Scope.Options.EnablePrivileges = true;
		ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Win32Shutdown");
		methodParameters["Flags"] = "1";
		methodParameters["Reserved"] = "0";
		foreach (ManagementObject instance in managementClass.GetInstances())
		{
			instance.InvokeMethod("Win32Shutdown", methodParameters, null);
		}
	}

	public static string smethod_64(string string_4, string string_5, string string_6 = "", int int_2 = 11)
	{
		if (string_6.Equals(""))
		{
			string_6 = smethod_58();
		}
		RequestHTTP requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
		GClass4 gClass = new GClass4();
		Random random = new Random();
		int num = random.Next(0, 999999);
		GClass1 gClass2 = new GClass1(string_4, string_5, string_6, int_2.ToString(), num.ToString());
		string text = gClass2.method_0();
		if (text == "error")
		{
			return "error";
		}
		string text2 = smethod_65(text);
		string text3 = gClass.method_9(text2, "MINSOFTWARE_KEY_PRO" + num);
		if (text3 == "" || text3 == "null")
		{
			return "error";
		}
		return text3;
	}

	public static string smethod_65(string string_4)
	{
		byte[] bytes = Convert.FromBase64String(string_4);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool smethod_66(string string_4)
	{
		try
		{
			new MailAddress(string_4);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string smethod_67(string string_4)
	{
		try
		{
			string value = Regex.Match(string_4, "c_user=(.*?);").Value;
			string value2 = Regex.Match(string_4, "xs=(.*?);").Value;
			string value3 = Regex.Match(string_4, "fr=(.*?);").Value;
			string value4 = Regex.Match(string_4, "datr=(.*?);").Value;
			return value + value2 + value3 + value4;
		}
		catch
		{
			return string_4;
		}
	}

	public static void smethod_68(int int_2)
	{
		try
		{
			Class50.smethod_2(int_2);
		}
		catch
		{
		}
	}

	public static List<string> smethod_69(string string_4, string string_5 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
	{
		string_4 = smethod_67(string_4);
		List<string> list = new List<string>();
		try
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: " + string_5,
				"cookie: " + string_4
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/groups/?seemore");
			MatchCollection matchCollection = Regex.Matches(input, "<a href=\"/groups/[0-9]+\\?refid=27");
			for (int i = 0; i < matchCollection.Count; i++)
			{
				try
				{
					string text = Regex.Match(matchCollection[i].Value, "groups/(.*?)\\?refid=27").Groups[1].Value.ToString();
					if (text != "")
					{
						list.Add(text);
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_70(string string_4)
	{
		for (int i = 1; i < string_3.Length; i++)
		{
			for (int j = 0; j < string_3[i].Length; j++)
			{
				string_4 = string_4.Replace(string_3[i][j], string_3[0][i - 1]);
			}
		}
		return string_4;
	}
}
