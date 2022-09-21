using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class GClass16
{
	private FirefoxDriver firefoxDriver_0;

	public bool bool_0 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point point_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point point_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_5;

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool Boolean_3
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
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

	public Point Point_0
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
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

	public Point Point_1
	{
		[CompilerGenerated]
		get
		{
			return point_1;
		}
		[CompilerGenerated]
		set
		{
			point_1 = value;
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

	public int Int32_5
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
		[CompilerGenerated]
		set
		{
			int_5 = value;
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

	public int Int32_6
	{
		[CompilerGenerated]
		get
		{
			return int_6;
		}
		[CompilerGenerated]
		set
		{
			int_6 = value;
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

	public string String_5
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	public GClass16()
	{
		Boolean_1 = true;
		Boolean_2 = false;
		String_0 = "";
		String_1 = "";
		Int32_0 = 300;
		Int32_1 = 300;
		Point_0 = new Point(Int32_1, Int32_0);
		Int32_2 = 300;
		Int32_3 = 0;
		String_2 = "";
		Int32_6 = 0;
		Point_1 = new Point(Int32_2, Int32_3);
		Int32_4 = 0;
		Int32_5 = 5;
		String_3 = "";
		Boolean_3 = false;
		String_4 = "";
		String_5 = "data\\extension";
	}

	public bool method_0()
	{
		bool result = false;
		bool_0 = true;
		try
		{
			FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
			firefoxDriverService.HideCommandPromptWindow = true;
			FirefoxOptions firefoxOptions = new FirefoxOptions();
			firefoxOptions.SetPreference("security.notification_enable_delay", 0);
			firefoxOptions.SetPreference("dom.webnotifications.enabled", preferenceValue: false);
			firefoxOptions.SetPreference("permissions.default.image", Boolean_1 ? 1 : 0);
			firefoxOptions.SetPreference("browser.download.folderList", 2);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
			firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.focusWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.useDownloadDir", preferenceValue: true);
			firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.closeWhenDone", preferenceValue: true);
			firefoxOptions.SetPreference("browser.download.manager.showAlertOnComplete", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.useWindow", preferenceValue: false);
			firefoxOptions.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("pdfjs.disabled", preferenceValue: true);
			firefoxOptions.AddArguments("-width=" + Point_0.X, "-height=" + Point_0.Y);
			if (String_0 != "")
			{
				firefoxOptions.SetPreference("general.useragent.override", String_0);
			}
			else
			{
				firefoxOptions.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0");
			}
			new FirefoxProfileManager();
			firefoxDriver_0 = new FirefoxDriver(firefoxDriverService, firefoxOptions);
			firefoxDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(Int32_5);
			firefoxDriver_0.Manage().Window.Position = Point_1;
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.Open()");
			return result;
		}
	}

	public static string smethod_0(FirefoxOptions firefoxOptions_0, int int_7)
	{
		int num = 0;
		int num2 = 0;
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		int num3 = width / 3;
		int num4 = height / 2;
		if (int_7 < 3)
		{
			num = num3 * int_7;
			num2 = 0;
		}
		else
		{
			num = num3 * (int_7 % 3);
			int num5 = int_7 / 2;
			num2 = ((num5 % 2 != 0) ? num4 : 0);
		}
		firefoxOptions_0.AddArgument($"--width={num3}");
		firefoxOptions_0.AddArgument($"--height={num4}");
		return num + "|" + num2;
	}

	public string method_1(string string_6, string string_7, string string_8)
	{
		string result = "";
		if (bool_0)
		{
			try
			{
				result = firefoxDriver_0.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_6 + "','" + string_7 + "','" + string_8 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetCssSelector(" + string_6 + "," + string_7 + "," + string_8 + ")");
			}
		}
		return result;
	}

	public string method_2(string string_6, string string_7)
	{
		string result = "";
		if (bool_0)
		{
			try
			{
				result = firefoxDriver_0.ExecuteScript("return document.querySelector('" + string_6 + "').getAttribute('" + string_7 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetAttributeValue(" + string_6 + "," + string_7 + ")");
			}
		}
		return result;
	}

	public void method_3(int int_7)
	{
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.ExecuteScript("window.scrollBy({ top: " + int_7 + ",behavior: 'smooth'});");
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"chrome.ScrollSmooth({int_7})");
			}
		}
	}

	public string method_4()
	{
		string result = "";
		try
		{
			result = firefoxDriver_0.ExecuteScript("return navigator.userAgent").ToString();
		}
		catch
		{
		}
		return result;
	}

	public bool method_5(int int_7, string string_6)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeyDown({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public string method_6()
	{
		if (bool_0)
		{
			try
			{
				return firefoxDriver_0.Url;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetURL()");
			}
		}
		return "";
	}

	public bool method_7(string string_6)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.Navigate().GoToUrl(string_6);
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GotoURL(" + string_6 + ")");
				return result;
			}
		}
		return result;
	}

	public bool method_8()
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.Navigate().Refresh();
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.Refresh()");
				return result;
			}
		}
		return result;
	}

	public bool method_9()
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.Navigate().Back();
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GotoBackPage()");
				return result;
			}
		}
		return result;
	}

	public bool method_10(int int_7, string string_6, double double_0)
	{
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.Id(string_6))).Perform();
					break;
				case 2:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.Name(string_6))).Perform();
					break;
				case 3:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.XPath(string_6))).Perform();
					break;
				case 4:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.CssSelector(string_6))).Perform();
					break;
				}
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				return true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.HoverElement({int_7}, {string_6}, {double_0})");
			}
		}
		return false;
	}

	public bool method_11(int int_7, string string_6, int int_8 = 0, int int_9 = 0, string string_7 = "", int int_10 = 0)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				if (int_9 == 0)
				{
					switch (int_7)
					{
					case 1:
						firefoxDriver_0.FindElementsById(string_6)[int_8].Click();
						break;
					case 2:
						firefoxDriver_0.FindElementsByName(string_6)[int_8].Click();
						break;
					case 3:
						firefoxDriver_0.FindElementsByXPath(string_6)[int_8].Click();
						break;
					case 4:
						firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].Click();
						break;
					}
				}
				else
				{
					switch (int_7)
					{
					case 1:
						firefoxDriver_0.FindElementsById(string_6)[int_8].FindElements(By.Id(string_7))[int_10].Click();
						break;
					case 2:
						firefoxDriver_0.FindElementsByName(string_6)[int_8].FindElements(By.Name(string_7))[int_10].Click();
						break;
					case 3:
						firefoxDriver_0.FindElementsByXPath(string_6)[int_8].FindElements(By.XPath(string_7))[int_10].Click();
						break;
					case 4:
						firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].FindElements(By.CssSelector(string_7))[int_10].Click();
						break;
					}
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Click({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public bool method_12(int int_7, string string_6, int int_8 = 0, int int_9 = 0, string string_7 = "", int int_10 = 0)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				if (int_9 != 0)
				{
					switch (int_7)
					{
					case 1:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsById(string_6)[int_8].FindElements(By.Id(string_7))[int_10]).Perform();
						break;
					case 2:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByName(string_6)[int_8].FindElements(By.Name(string_7))[int_10]).Perform();
						break;
					case 3:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByXPath(string_6)[int_8].FindElements(By.XPath(string_7))[int_10]).Perform();
						break;
					case 4:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].FindElements(By.CssSelector(string_7))[int_10]).Perform();
						break;
					}
				}
				else
				{
					switch (int_7)
					{
					case 1:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsById(string_6)[int_8]).Perform();
						break;
					case 2:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByName(string_6)[int_8]).Perform();
						break;
					case 3:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByXPath(string_6)[int_8]).Perform();
						break;
					case 4:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8]).Perform();
						break;
					}
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.ClickWithAction({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public bool method_13(int int_7, string string_6, string string_7, bool bool_5 = true)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				if (bool_5)
				{
					method_11(int_7, string_6);
				}
				switch (int_7)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_6).SendKeys(string_7);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_6).SendKeys(string_7);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_6).SendKeys(string_7);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(string_7);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeys({int_7},{string_6},{string_7},{bool_5})");
				return result;
			}
		}
		return result;
	}

	public bool method_14(int int_7, string string_6, string string_7, double double_0, bool bool_5 = true)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				if (bool_5)
				{
					method_11(int_7, string_6);
				}
				for (int i = 0; i < string_7.Length; i++)
				{
					switch (int_7)
					{
					case 1:
						firefoxDriver_0.FindElementById(string_6).SendKeys(string_7[i].ToString());
						break;
					case 2:
						firefoxDriver_0.FindElementByName(string_6).SendKeys(string_7[i].ToString());
						break;
					case 3:
						firefoxDriver_0.FindElementByXPath(string_6).SendKeys(string_7[i].ToString());
						break;
					case 4:
						firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(string_7[i].ToString());
						break;
					}
					Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeys({int_7},{string_6},{string_7},{double_0},{bool_5})");
				return result;
			}
		}
		return result;
	}

	public bool method_15(int int_7, string string_6)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SelectText({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public bool method_16(int int_7, string string_6)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_6).Clear();
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_6).Clear();
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_6).Clear();
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_6).Clear();
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.ClearText({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public bool method_17(string string_6, double double_0 = 0.0)
	{
		bool result = true;
		if (bool_0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.CheckExistElement({string_6},{double_0})");
				return result;
			}
		}
		return result;
	}

	public bool method_18(string string_6, double double_0 = 0.0)
	{
		bool result = true;
		if (bool_0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)firefoxDriver_0.ExecuteScript("return " + string_6 + ".length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.CheckExistElement({string_6},{double_0})");
				return result;
			}
		}
		return result;
	}

	public bool method_19()
	{
		bool result = true;
		if (bool_0)
		{
			try
			{
				_ = firefoxDriver_0.Title;
				result = false;
				return result;
			}
			catch (Exception exception_)
			{
				bool_0 = false;
				smethod_1(null, exception_, "firefox.CheckChromeClosed()");
				return result;
			}
		}
		return result;
	}

	public bool method_20(string string_6, int int_7 = 0, double double_0 = 0.0)
	{
		bool result = true;
		if (bool_0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				if (int_7 != 0)
				{
					while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") != "0")
					{
						if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
						{
							return false;
						}
						Thread.Sleep(1000);
					}
					return result;
				}
				while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.WaitForSearchElement({string_6},{int_7},{double_0})");
				return result;
			}
		}
		return result;
	}

	public int method_21(double double_0 = 0.0, params string[] string_6)
	{
		int result = 0;
		if (bool_0)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					for (int i = 0; i < string_6.Length; i++)
					{
						if (method_17(string_6[i]))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, string.Format("firefox.CheckExistElements({0},{1})", double_0, string.Join("|", string_6)));
			}
		}
		return result;
	}

	public bool method_22(int int_7, string string_6)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendEnter({int_7},{string_6})");
				return result;
			}
		}
		return result;
	}

	public bool method_23(int int_7, int int_8)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				string script = $"window.scrollTo({int_7}, {int_8})";
				firefoxDriver_0.ExecuteScript(script);
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Scroll({int_7},{int_8})");
				return result;
			}
		}
		return result;
	}

	public void method_24(string string_6)
	{
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.ExecuteScript(string_6 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.ScrollSmooth(" + string_6 + ")");
			}
		}
	}

	public int method_25(string string_6)
	{
		int result = -2;
		if (bool_0)
		{
			try
			{
				result = Convert.ToInt32(firefoxDriver_0.ExecuteScript("var check='';x=" + string_6 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.CheckExistElementOnScreen(" + string_6 + ")");
			}
		}
		return result;
	}

	public Point method_26()
	{
		Point result = new Point(0, 0);
		if (bool_0)
		{
			try
			{
				string text = firefoxDriver_0.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
				result.X = Convert.ToInt32(text.Split('|')[1]);
				result.Y = Convert.ToInt32(text.Split('|')[0]);
			}
			catch
			{
			}
		}
		return result;
	}

	public void method_27()
	{
		try
		{
			if (firefoxDriver_0 != null)
			{
				firefoxDriver_0.Quit();
			}
			bool_0 = false;
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.Close()");
		}
	}

	public void method_28(string string_6, string string_7 = ".facebook.com")
	{
		if (!bool_0)
		{
			return;
		}
		try
		{
			string[] array = string_6.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Trim() != "")
				{
					string[] array3 = text.Split('=');
					if (array3.Count() > 1 && array3[0].Trim() != "")
					{
						Cookie cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_7, "/", DateTime.Now.AddDays(10.0));
						firefoxDriver_0.Manage().Cookies.AddCookie(cookie);
					}
				}
			}
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.AddCookieIntoChrome(" + string_6 + "," + string_7 + ")");
		}
	}

	public string method_29(string string_6 = "facebook")
	{
		string text = "";
		if (bool_0)
		{
			try
			{
				Cookie[] array = firefoxDriver_0.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				foreach (Cookie cookie in array2)
				{
					if (cookie.Domain.Contains(string_6))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetCookieFromChrome(" + string_6 + ")");
			}
		}
		return text;
	}

	public void method_30(string string_6, bool bool_5 = true)
	{
		if (!bool_0)
		{
			return;
		}
		try
		{
			firefoxDriver_0.ExecuteScript("window.open('" + string_6 + "', '_blank').focus();");
			if (bool_5)
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.Last());
			}
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, $"firefox.OpenNewTab({string_6},{bool_5})");
		}
	}

	public void method_31()
	{
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.Close();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.CloseCurrentTab()");
			}
		}
	}

	public void method_32()
	{
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.First());
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.SwitchToFirstTab()");
			}
		}
	}

	public void method_33()
	{
		if (bool_0)
		{
			try
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.Last());
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.SwitchToLastTab()");
			}
		}
	}

	public void method_34(double double_0)
	{
		if (bool_0)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.DelayTime({double_0})");
			}
		}
	}

	public bool method_35(int int_7, string string_6, string string_7)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				switch (int_7)
				{
				case 1:
					new SelectElement(firefoxDriver_0.FindElementById(string_6)).SelectByValue(string_7);
					break;
				case 2:
					new SelectElement(firefoxDriver_0.FindElementByName(string_6)).SelectByValue(string_7);
					break;
				case 3:
					new SelectElement(firefoxDriver_0.FindElementByXPath(string_6)).SelectByValue(string_7);
					break;
				case 4:
					new SelectElement(firefoxDriver_0.FindElementByCssSelector(string_6)).SelectByValue(string_7);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Select({int_7},{string_6},{string_7})");
				return result;
			}
		}
		return result;
	}

	public bool method_36(string string_6, string string_7)
	{
		bool result = false;
		if (bool_0)
		{
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)firefoxDriver_0).GetScreenshot();
				screenshot.SaveAsFile(string_6 + (string_6.EndsWith("\\") ? "" : "\\") + string_7 + ".png");
				result = true;
				return result;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "chrome.ScreenCapture(" + string_6 + "," + string_7 + ")");
				return result;
			}
		}
		return result;
	}

	public object method_37(string string_6)
	{
		if (bool_0)
		{
			try
			{
				return firefoxDriver_0.ExecuteScript(string_6);
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.ExecuteScript(" + string_6 + ")");
			}
		}
		return "";
	}

	public static void smethod_1(GClass12 gclass12_0, Exception exception_0, string string_6 = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\html"))
			{
				Directory.CreateDirectory("log\\html");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			if (gclass12_0 != null)
			{
				string contents = gclass12_0.method_20("var markup = document.documentElement.innerHTML;return markup;").ToString();
				gclass12_0.method_60("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_6 != "")
			{
				streamWriter.WriteLine("Error: " + string_6);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}
}
