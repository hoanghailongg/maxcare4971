using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using OpenQA.Selenium.Interactions;

public class GClass7
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Process process_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IntPtr intptr_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GClass12 gclass12_0;

	public Process Process_0
	{
		[CompilerGenerated]
		get
		{
			return process_0;
		}
		[CompilerGenerated]
		set
		{
			process_0 = value;
		}
	}

	public IntPtr IntPtr_0
	{
		[CompilerGenerated]
		get
		{
			return intptr_0;
		}
		[CompilerGenerated]
		set
		{
			intptr_0 = value;
		}
	}

	public GClass12 GClass12_0
	{
		[CompilerGenerated]
		get
		{
			return gclass12_0;
		}
		[CompilerGenerated]
		set
		{
			gclass12_0 = value;
		}
	}

	public GClass7(GClass12 gclass12_1)
	{
		Process_0 = gclass12_1.Process_0;
		IntPtr_0 = Process_0.MainWindowHandle;
		GClass12_0 = gclass12_1;
	}

	public Image method_0(IntPtr intptr_1)
	{
		IntPtr windowDC = Class4.GetWindowDC(intptr_1);
		Class4.Struct0 struct0_ = default(Class4.Struct0);
		Class4.GetWindowRect(intptr_1, ref struct0_);
		int num = struct0_.int_2 - struct0_.int_0;
		int num2 = struct0_.int_3 - struct0_.int_1;
		IntPtr intPtr = Class3.CreateCompatibleDC(windowDC);
		IntPtr intPtr2 = Class3.CreateCompatibleBitmap(windowDC, num, num2);
		IntPtr intptr_2 = Class3.SelectObject(intPtr, intPtr2);
		Class3.BitBlt(intPtr, 0, 0, num, num2, windowDC, 0, 0, 13369376);
		Class3.SelectObject(intPtr, intptr_2);
		Class3.DeleteDC(intPtr);
		Class4.ReleaseDC(intptr_1, windowDC);
		Image result = Image.FromHbitmap(intPtr2);
		Class3.DeleteObject(intPtr2);
		return result;
	}

	public bool method_1(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			(method_0(IntPtr_0) as Bitmap).Save(string_0 + (string_0.EndsWith("\\") ? "" : "\\") + string_1 + ".png", ImageFormat.Png);
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.ScreenCapture(" + string_0 + "," + string_1 + ")");
			return result;
		}
	}

	public Bitmap method_2(int int_0 = 1)
	{
		Bitmap result = null;
		try
		{
			for (int i = 0; i < int_0; i++)
			{
				try
				{
					result = (Bitmap)method_0(IntPtr_0);
				}
				catch (Exception exception_)
				{
					smethod_0(this, exception_, "CaptureWindow");
					GClass14.smethod_58(1.0);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_2)
		{
			smethod_0(null, exception_2, "AutoChrome.ScreenCapture()");
		}
		return result;
	}

	public void method_3(double double_0)
	{
		try
		{
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, $"chrome.DelayTime({double_0})");
		}
	}

	public bool method_4(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.9)
	{
		if (bitmap_1 == null || bitmap_0 == null)
		{
			return false;
		}
		Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap_0);
		Image<Bgr, byte> template = new Image<Bgr, byte>(bitmap_1);
		Point? point = null;
		using Image<Gray, float> image2 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed);
		image2.MinMax(out var _, out var maxValues, out var _, out var _);
		return maxValues[0] > double_0;
	}

	public bool method_5(int int_0, double double_0, int int_1 = 0, int int_2 = 0)
	{
		Bitmap bitmap_ = method_2();
		if (int_2 == 0)
		{
			method_20(int_0, double_0);
		}
		else
		{
			method_21(int_0, double_0);
		}
		method_3(int_1);
		Bitmap bitmap_2 = method_2();
		return !method_4(bitmap_2, bitmap_);
	}

	public bool method_6(int int_0, int int_1 = 0, int int_2 = 0)
	{
		int_0 *= 100;
		Bitmap bitmap_ = method_2();
		if (int_2 == 0)
		{
			method_17(int_0);
		}
		else
		{
			method_17(-int_0);
		}
		method_3(int_1);
		Bitmap bitmap_2 = method_2();
		return !method_4(bitmap_2, bitmap_);
	}

	public Point? method_7(string string_0, int int_0 = 0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		FileInfo[] files = directoryInfo.GetFiles();
		int tickCount = Environment.TickCount;
		do
		{
			Bitmap bitmap = method_2(3);
			if (bitmap == null)
			{
				break;
			}
			Point? point = null;
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Bitmap bitmap2 = (Bitmap)Image.FromFile(fileInfo.FullName);
				point = Class5.smethod_3(bitmap, bitmap2);
				if (point.HasValue)
				{
					int x = point.Value.X + new Random().Next(0, bitmap2.Width * 3 / 4);
					int y = point.Value.Y + new Random().Next(0, bitmap2.Height * 3 / 4);
					return new Point(x, y);
				}
			}
			GClass14.smethod_58(1.0);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return null;
	}

	public bool method_8(string string_0, int int_0 = 0)
	{
		if (method_7(string_0, int_0).HasValue)
		{
			return true;
		}
		return false;
	}

	public int method_9(double double_0 = 0.0, params string[] string_0)
	{
		int result = 0;
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					if (method_8(string_0[i]))
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
			smethod_0(null, exception_, string.Format("AutoChrome.CheckExistImages({0},{1})", double_0, string.Join("|", string_0)));
		}
		return result;
	}

	public bool method_10(string string_0, int int_0 = 3)
	{
		bool result = false;
		try
		{
			Point? point = method_7(string_0, int_0);
			if (point.HasValue)
			{
				GClass10.smethod_17(IntPtr_0, point.Value.X, point.Value.Y);
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public bool method_11(string string_0)
	{
		bool result = false;
		try
		{
			GClass10.smethod_28(IntPtr_0, string_0);
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + string_0 + ")");
			return result;
		}
	}

	public bool method_12(string string_0, double double_0)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass10.smethod_28(IntPtr_0, string_0[i].ToString());
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + string_0 + ")");
			return result;
		}
	}

	public bool method_13(string string_0)
	{
		bool result = false;
		try
		{
			new Actions(GClass12_0.ChromeDriver_0).SendKeys(string_0).Perform();
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + string_0 + ")");
			return result;
		}
	}

	public bool method_14(string string_0, double double_0)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				new Actions(GClass12_0.ChromeDriver_0).SendKeys(string_0[i].ToString()).Perform();
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, $"AutoChrome.SendKeys({string_0},{double_0})");
			return result;
		}
	}

	public bool method_15()
	{
		bool result = false;
		try
		{
			GClass10.smethod_22(IntPtr_0, GEnum7.const_8);
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendEnter()");
			return result;
		}
	}

	public void method_16()
	{
		try
		{
			Process_0.Kill();
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.Close()");
		}
	}

	public void method_17(int int_0)
	{
		try
		{
			GClass12_0.method_20("window.scrollBy({ top: " + int_0 + ",behavior: 'smooth'});");
		}
		catch
		{
		}
	}

	public bool method_18(int int_0, int int_1)
	{
		bool result = false;
		try
		{
			GClass10.smethod_17(IntPtr_0, int_0, int_1);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public bool method_19(Point? nullable_0)
	{
		bool result = false;
		try
		{
			if (nullable_0.HasValue)
			{
				GClass10.smethod_17(IntPtr_0, nullable_0.Value.X, nullable_0.Value.Y);
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void method_20(int int_0 = 10, double double_0 = 100.0)
	{
		try
		{
			for (int i = 0; i < int_0; i++)
			{
				GClass10.smethod_22(IntPtr_0, GEnum7.const_23);
				method_3(double_0);
			}
		}
		catch
		{
		}
	}

	public void method_21(int int_0 = 10, double double_0 = 100.0)
	{
		try
		{
			for (int i = 0; i < int_0; i++)
			{
				GClass10.smethod_22(IntPtr_0, GEnum7.const_21);
				method_3(double_0);
			}
		}
		catch
		{
		}
	}

	public static void smethod_0(GClass7 gclass7_0, Exception exception_0, string string_0 = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			gclass7_0?.method_1("log\\images\\", text);
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_0 != "")
			{
				streamWriter.WriteLine("Error: " + string_0);
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
