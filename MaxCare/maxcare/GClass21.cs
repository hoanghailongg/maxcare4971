using System;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Chrome;

public class GClass21
{
	public static ChromeDriver smethod_0(ChromeDriver chromeDriver_0, bool bool_0, bool bool_1, bool bool_2, string string_0, string string_1, Point point_0, Point point_1, string string_2, int int_0 = 0, int int_1 = 60)
	{
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments("--disable-notifications", "--window-size=" + point_0.X + "," + point_0.Y, "--window-position=" + point_1.X + "," + point_1.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-popup-blocking");
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
		chromeOptions.AddUserProfilePreference("useAutomationExtension", true);
		if (bool_2)
		{
			chromeOptions.AddArgument("--mute-audio");
		}
		if (!bool_0)
		{
			if (bool_1)
			{
				chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
			}
			if (!string.IsNullOrEmpty(string_1.Trim()))
			{
				chromeOptions.AddArgument("--user-data-dir=" + string_1);
			}
		}
		else
		{
			chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
			chromeOptions.AddArgument("--headless");
		}
		if (!string.IsNullOrEmpty(string_2.Trim()))
		{
			chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + string_2);
		}
		if (!string.IsNullOrEmpty(string_0.Trim()))
		{
			chromeOptions.AddArgument("--user-agent=" + string_0);
		}
		chromeDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		chromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int_0);
		chromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(int_1);
		return chromeDriver_0;
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

	public static bool smethod_2(ChromeDriver chromeDriver_0)
	{
		bool result = true;
		try
		{
			_ = chromeDriver_0.Title;
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_3(ChromeDriver chromeDriver_0, int int_0, string string_0, int int_1 = 0)
	{
		bool flag = false;
		TimeSpan implicitWait = chromeDriver_0.Manage().Timeouts().ImplicitWait;
		chromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0.0);
		int tickCount = Environment.TickCount;
		do
		{
			switch (int_0)
			{
			case 3:
				flag = chromeDriver_0.FindElementsByXPath(string_0).Count > 0;
				break;
			case 2:
				flag = chromeDriver_0.FindElementsByName(string_0).Count > 0;
				break;
			case 1:
				flag = chromeDriver_0.FindElementsById(string_0).Count > 0;
				break;
			}
		}
		while (!flag && Environment.TickCount - tickCount <= int_1 * 1000);
		chromeDriver_0.Manage().Timeouts().ImplicitWait = implicitWait;
		return flag;
	}

	public static bool smethod_4(ChromeDriver chromeDriver_0, string string_0)
	{
		bool result = false;
		try
		{
			chromeDriver_0.Navigate().GoToUrl(string_0);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_5(ChromeDriver chromeDriver_0, int int_0, int int_1)
	{
		bool result = false;
		try
		{
			string script = $"window.scrollTo({int_0}, {int_1})";
			chromeDriver_0.ExecuteScript(script);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_6(ChromeDriver chromeDriver_0, int int_0, string string_0, string string_1, double double_0)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < string_1.Length; i++)
			{
				switch (int_0)
				{
				case 1:
					chromeDriver_0.FindElementById(string_0).SendKeys(string_1[i].ToString());
					break;
				case 2:
					chromeDriver_0.FindElementByName(string_0).SendKeys(string_1[i].ToString());
					break;
				case 3:
					chromeDriver_0.FindElementByXPath(string_0).SendKeys(string_1[i].ToString());
					break;
				}
				if (i < string_1.Length - 1)
				{
					Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				}
			}
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_7(ChromeDriver chromeDriver_0, int int_0, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			switch (int_0)
			{
			case 1:
				chromeDriver_0.FindElementById(string_0).SendKeys(string_1);
				break;
			case 2:
				chromeDriver_0.FindElementByName(string_0).SendKeys(string_1);
				break;
			case 3:
				chromeDriver_0.FindElementByXPath(string_0).SendKeys(string_1);
				break;
			}
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_8(ChromeDriver chromeDriver_0, int int_0, string string_0)
	{
		bool result = false;
		try
		{
			switch (int_0)
			{
			case 1:
				chromeDriver_0.FindElementById(string_0).Click();
				break;
			case 2:
				chromeDriver_0.FindElementByName(string_0).Click();
				break;
			case 3:
				chromeDriver_0.FindElementByXPath(string_0).Click();
				break;
			}
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_9(ChromeDriver chromeDriver_0, string string_0)
	{
		bool result = false;
		try
		{
			chromeDriver_0.ExecuteScript(string_0);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}
}
