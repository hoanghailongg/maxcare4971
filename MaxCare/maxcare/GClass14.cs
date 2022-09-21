using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using OtpNet;

public class GClass14
{
	[Serializable]
	[CompilerGenerated]
	private sealed class E6D73986
	{
		public static readonly E6D73986 _003C_003E9 = new E6D73986();

		public static RemoteCertificateValidationCallback _003C_003E9__19_0;

		public static RemoteCertificateValidationCallback _003C_003E9__21_0;

		public static Func<bool, bool, bool> _003C_003E9__27_0;

		public static Func<bool, bool> _003C_003E9__27_1;

		public static Func<DataRow, int> _003C_003E9__100_0;

		internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		internal bool method_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		internal bool method_2(bool bool_0, bool bool_1)
		{
			return bool_0 == bool_1;
		}

		internal bool method_3(bool bool_0)
		{
			return bool_0;
		}

		internal int method_4(DataRow dataRow_0)
		{
			return Class49.random_0.Next();
		}
	}

	[CompilerGenerated]
	private sealed class Class22
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public object object_0;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public string string_0;

		public bool bool_0;

		internal void method_0()
		{
			try
			{
				Clipboard.SetText(string_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class24
	{
		public string string_0;

		public int int_0;

		public string string_1;
	}

	[CompilerGenerated]
	private sealed class Class25
	{
		public int int_0;

		public Class24 class24_0;
	}

	[CompilerGenerated]
	private sealed class Class26
	{
		public string string_0;

		public Class25 class25_0;

		internal void method_0()
		{
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < 20000)
			{
				string text = smethod_69(string_0, class25_0.class24_0.string_0, class25_0.class24_0.int_0);
				if (text != "" && !text.Contains("html"))
				{
					class25_0.class24_0.string_1 = text;
					break;
				}
			}
			Interlocked.Increment(ref class25_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class27
	{
		public string string_0;

		public int int_0;

		public string string_1;
	}

	[CompilerGenerated]
	private sealed class Class28
	{
		public int int_0;

		public Class27 class27_0;
	}

	[CompilerGenerated]
	private sealed class Class29
	{
		public string string_0;

		public Class28 class28_0;

		internal void method_0()
		{
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < 20000)
			{
				string text = smethod_69(string_0, class28_0.class27_0.string_0, class28_0.class27_0.int_0);
				if (text != "" && !text.Contains("html"))
				{
					class28_0.class27_0.string_1 = text;
					break;
				}
			}
			Interlocked.Increment(ref class28_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class30
	{
		public StringBuilder stringBuilder_0;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder_0.Append(e.Data + "\n");
			}
		}
	}

	[CompilerGenerated]
	private static class Class31
	{
		public static CallSite<Func<CallSite, object, GInterface3>> callSite_0;
	}

	private static Random random_0 = new Random();

	private static int int_0 = Screen.PrimaryScreen.WorkingArea.Width;

	private static int int_1 = Screen.PrimaryScreen.WorkingArea.Height;

	private static object object_0 = new object();

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetDeviceId();

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckLicense(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTotp(byte[] byte_0);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetApiToken(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public static string smethod_0(string string_0, string string_1, string string_2)
	{
		return smethod_1(GetApiToken(Encoding.UTF8.GetBytes(string_0), Encoding.UTF8.GetBytes(string_1), Encoding.UTF8.GetBytes(string_2)));
	}

	private static string smethod_1(IntPtr intptr_0)
	{
		try
		{
			string s = Marshal.PtrToStringAnsi(intptr_0);
			byte[] bytes = Encoding.Default.GetBytes(s);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_2()
	{
		return smethod_1(GetDeviceId());
	}

	public static string smethod_3(string string_0, string string_1, string string_2)
	{
		return smethod_1(CheckLicense(Encoding.UTF8.GetBytes(string_0), Encoding.UTF8.GetBytes(string_1), Encoding.UTF8.GetBytes(string_2)));
	}

	public static double smethod_4(DateTime dateTime_0)
	{
		return (dateTime_0 - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	public static string smethod_5(object object_1)
	{
		string text = "";
		try
		{
			PropertyInfo[] properties = object_1.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				text = text + propertyInfo.GetValue(object_1)?.ToString() + ",";
			}
			text = text.TrimEnd(',');
		}
		catch
		{
		}
		return text;
	}

	public static string smethod_6(string string_0, string string_1, string string_2, int int_2)
	{
		try
		{
			string input = new GClass19(string_0, string_1, string_2, int_2).method_0("https://m.facebook.com/help/");
			return Regex.Match(input, smethod_53("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}

	public static List<string> smethod_7(List<string> list_0, List<string> list_1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Intersect(list_1).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_8(List<string> list_0, List<string> list_1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Except(list_1).ToList();
		}
		catch
		{
		}
		return result;
	}

	private static void smethod_9(string string_0)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_0 + "\" enable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	private static void smethod_10(string string_0)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_0 + "\" disable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	public static string smethod_11(string string_0)
	{
		try
		{
			return Directory.GetCreationTime(string_0).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_12(string string_0)
	{
		try
		{
			return File.GetCreationTime(string_0).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_13(ref List<string> list_0, Random random_1)
	{
		string text = "";
		try
		{
			text = list_0[random_1.Next(0, list_0.Count)];
			list_0.Remove(text);
		}
		catch (Exception)
		{
			throw;
		}
		return text;
	}

	public static string smethod_14(string string_0, string string_1, string string_2 = "")
	{
		int num = 0;
		while (true)
		{
			try
			{
				if (string_2 == "")
				{
					if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail.") || string_0.Contains("muarefbmail.com") || string_0.Contains("live.com") || string_0.Contains("@gzipmail.com"))
					{
						string_2 = "outlook.office365.com";
					}
					else if (string_0.EndsWith("@yandex.com"))
					{
						string_2 = "imap.yandex.com";
					}
					else if (string_0.EndsWith("@gmail.com"))
					{
						string_2 = "imap.gmail.com";
					}
					else if (string_0.EndsWith("@onet.pl"))
					{
						string_2 = "imap.poczta.onet.pl";
					}
					else if (string_0.EndsWith("@gmail.com"))
					{
						string_2 = "imap.gmail.com";
					}
				}
				if (string_2 == "")
				{
					return "0";
				}
				ImapClient imapClient = new ImapClient();
				imapClient.CheckCertificateRevocation = false;
				imapClient.ServerCertificateValidationCallback = (object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true;
				imapClient.SslProtocols = SslProtocols.Ssl2 | SslProtocols.Ssl3 | SslProtocols.Tls11;
				imapClient.Connect(string_2, 993);
				imapClient.Authenticate(string_0, string_1);
				imapClient.Disconnect(quit: true);
				return "1";
			}
			catch (Exception ex)
			{
				if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
				{
					goto IL_018f;
				}
				num++;
				if (num >= 10)
				{
					goto IL_018f;
				}
				goto end_IL_016d;
				IL_018f:
				return "0";
				end_IL_016d:;
			}
		}
	}

	public static void smethod_15()
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

	public static string smethod_16(string string_0, string string_1, string string_2)
	{
		int num = 0;
		while (true)
		{
			try
			{
				ImapClient imapClient = new ImapClient();
				imapClient.CheckCertificateRevocation = false;
				imapClient.ServerCertificateValidationCallback = (object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true;
				imapClient.SslProtocols = SslProtocols.Ssl2 | SslProtocols.Ssl3 | SslProtocols.Tls11;
				imapClient.Connect(string_2, 993, SecureSocketOptions.SslOnConnect);
				imapClient.Authenticate(string_0, string_1);
				return "1";
			}
			catch (Exception ex)
			{
				if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
				{
					goto IL_0095;
				}
				num++;
				if (num >= 10)
				{
					goto IL_0095;
				}
				goto end_IL_0073;
				IL_0095:
				return "0";
				end_IL_0073:;
			}
		}
	}

	public static string smethod_17(int int_2)
	{
		try
		{
			TimeSpan.FromSeconds(int_2);
			if (int_2 < 60)
			{
				return TimeSpan.FromSeconds(int_2).ToString("ss");
			}
			if (int_2 < 3600)
			{
				return TimeSpan.FromSeconds(int_2).ToString("mm\\:ss");
			}
			return TimeSpan.FromSeconds(int_2).ToString("hh\\:mm\\:ss");
		}
		catch
		{
			return "";
		}
	}

	public static bool smethod_18(string string_0, string string_1, string string_2, string string_3 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string string_4 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
	{
		bool result = false;
		try
		{
			smethod_19(string_0, string_1, string_4, "--user-data-dir=\"" + string_2 + "\"", string_4.Substring(0, string_4.LastIndexOf("\\")), string_3);
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			smethod_75(null, exception_, "chrome.CreateShortcut(" + string_0 + "," + string_1 + "," + string_4 + ")select");
			return result;
		}
	}

	// GClass14
	// Token: 0x060001CC RID: 460 RVA: 0x000136C8 File Offset: 0x000118C8
	public static void smethod_19(string string_0, string string_1, string string_2, string string_3, string string_4 = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string string_5 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
	{
		string string_6 = Path.Combine(string_1, string_0 + ".lnk");
		GInterface4 gInterface = (GInterface4)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
		GInterface3 gInterface2 = (GInterface3)(dynamic)gInterface.imethod_0(string_6);
		gInterface2.String_2 = "Shortcut Chrome MIN Software";
		gInterface2.String_5 = string_4;
		gInterface2.String_3 = string_5;
		gInterface2.String_4 = string_2;
		gInterface2.String_1 = string_3;
		gInterface2.imethod_0();
	}


	public static void smethod_20(object object_1, int int_2)
	{
		switch (int_2)
		{
		case 1:
			MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			break;
		case 2:
			MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			break;
		case 3:
			MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			break;
		}
	}

	public static void smethod_21(DataGridView dataGridView_0, int int_2, string string_0, object object_1)
	{
		try
		{
			Application.DoEvents();
			dataGridView_0.Invoke((MethodInvoker)delegate
			{
				dataGridView_0.Rows[int_2].Cells[string_0].Value = object_1;
			});
		}
		catch
		{
		}
	}

	public static int smethod_22(string string_0, string string_1)
	{
		int result = 0;
		try
		{
			List<bool> first = smethod_24(new Bitmap(string_0));
			List<bool> second = smethod_24(new Bitmap(string_0));
			result = first.Zip(second, (bool bool_0, bool bool_1) => bool_0 == bool_1).Count((bool bool_0) => bool_0);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_23(string string_0)
	{
		bool bool_0 = false;
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					Clipboard.SetText(string_0);
					bool_0 = true;
				}
				catch
				{
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
		catch
		{
		}
		return bool_0;
	}

	public static List<bool> smethod_24(Bitmap bitmap_0)
	{
		List<bool> list = new List<bool>();
		Bitmap bitmap = new Bitmap(bitmap_0, new Size(16, 16));
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
			}
		}
		return list;
	}

	public static List<string> smethod_25(List<string> list_0)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list.Add(list_0[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_26(string string_0, Random random_1)
	{
		string pattern = "{[^{}]*}";
		Match match = Regex.Match(string_0, pattern);
		while (match.Success)
		{
			string text = string_0.Substring(match.Index + 1, match.Length - 2);
			string[] array = text.Split('|');
			string_0 = string_0.Substring(0, match.Index) + array[random_1.Next(array.Length)] + string_0.Substring(match.Index + match.Length);
			match = Regex.Match(string_0, pattern);
		}
		return string_0;
	}

	public static void smethod_27(string string_0, string string_1 = "Nhập danh sách Uid cần clone", string string_2 = "Danh sách Uid", string string_3 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		try
		{
			if (!File.Exists(string_0))
			{
				smethod_30(string_0);
			}
			smethod_33(new fNhapDuLieu1(string_0, string_1, string_2, string_3));
		}
		catch
		{
		}
	}

	public static DateTime smethod_28(double double_0)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
	}

	public static Form smethod_29(string string_0, string string_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Type[] types = executingAssembly.GetTypes();
		int num = 0;
		while (true)
		{
			if (num < types.Length)
			{
				Type type = types[num];
				if (type.BaseType != null && type.BaseType.FullName == "System.Windows.Forms.Form" && type.FullName == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return Activator.CreateInstance(Type.GetType(string_0), "", 1, string_1) as Form;
	}

	public static void smethod_30(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.AppendAllText(string_0, "");
			}
		}
		catch
		{
		}
	}

	public static void smethod_31(DataGridView dataGridView_0)
	{
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			dataGridView_0.Rows[i].Selected = false;
		}
	}

	public static void smethod_32(string string_0)
	{
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
		}
		catch
		{
		}
	}

	public static void smethod_33(Form form_0)
	{
		try
		{
			form_0.ShowInTaskbar = false;
			form_0.ShowDialog();
		}
		catch (Exception)
		{
		}
	}

	public static List<int> smethod_34(List<int> list_0)
	{
		int num = 0;
		int num2 = list_0.Count;
		int num3 = 0;
		while (num2 != 0)
		{
			num3 = Class49.random_0.Next(0, list_0.Count);
			num2--;
			num = list_0[num2];
			list_0[num2] = list_0[num3];
			list_0[num3] = num;
		}
		return list_0;
	}

	public static List<string> smethod_35(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Class49.random_0.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> smethod_36(List<string> list_0)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Trim();
			if (text != "")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string smethod_37(string string_0, string string_1)
	{
		if (!string_0.EndsWith(string_1))
		{
			return string_0;
		}
		return string_0.Remove(string_0.LastIndexOf(string_1));
	}

	public static void smethod_38(DataGridView dataGridView_0, string string_0, char char_0 = '|')
	{
		List<string> list = new List<string>();
		string text = "";
		object obj = null;
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			text = "";
			for (int j = 0; j < dataGridView_0.ColumnCount; j++)
			{
				obj = dataGridView_0.Rows[i].Cells[j].Value;
				text += ((obj == null) ? char_0.ToString() : (obj?.ToString() + char_0));
			}
			text = text.TrimEnd(char_0);
			list.Add(text);
		}
		File.WriteAllLines(string_0, list);
	}

	public static void smethod_39(DataGridView dataGridView_0, string string_0, char char_0 = '|')
	{
		if (!File.Exists(string_0))
		{
			smethod_30(string_0);
		}
		List<string> list = File.ReadAllLines(string_0).ToList();
		string text = "";
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i];
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = text.Split(char_0);
				rows.Add(values);
			}
		}
	}

	public static string smethod_40()
	{
		string result = "";
		try
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				result = folderBrowserDialog.SelectedPath;
			}
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_41(string string_0 = "Chọn File txt", string string_1 = "txt Files (*.txt)|*.txt|")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = string_1 + "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = string_0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
		}
		catch
		{
		}
		return result;
	}

	public static void smethod_42(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	public static bool smethod_43(string string_0)
	{
		bool result = true;
		foreach (char c in string_0)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.')
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string smethod_44(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				text += c;
			}
		}
		return text;
	}

	public static string smethod_45(string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		string_0 = Encoding.UTF8.GetString(bytes);
		return string_0;
	}

	public static bool smethod_46(string string_0)
	{
		if (string_0 == "")
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char c = string_0[num];
				if (!char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool smethod_47(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char c = string_0[num];
				if (char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_48(string string_0)
	{
		string text = "zzz999.html";
		File.WriteAllText(text, string_0);
		Process.Start(text);
	}

	public static string smethod_49(string string_0)
	{
		try
		{
			GClass19 gClass = new GClass19("", "", "", 0);
			gClass.httpRequest_0.AddHeader("Cache-Control", "no-cache");
			return gClass.method_0(string_0);
		}
		catch
		{
			return null;
		}
	}

	public static bool smethod_50(string string_0)
	{
		try
		{
			new MailAddress(string_0);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string smethod_51(string string_0, string string_1 = "X2")
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(string_1));
		}
		return stringBuilder.ToString();
	}

	public static string smethod_52(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_53(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_54(int int_2, Random random_1 = null)
	{
		string text = "";
		if (random_1 == null)
		{
			random_1 = new Random();
		}
		string text2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		for (int i = 0; i < int_2; i++)
		{
			text += text2[random_1.Next(0, text2.Length)];
		}
		return text;
	}

	public static string smethod_55(int int_2, Random random_1 = null)
	{
		string text = "";
		if (random_1 == null)
		{
			random_1 = new Random();
		}
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 0; i < int_2; i++)
		{
			text += text2[random_1.Next(0, text2.Length)];
		}
		return text;
	}

	public static string smethod_56(int int_2, Random random_1 = null)
	{
		string text = "";
		if (random_1 == null)
		{
			random_1 = new Random();
		}
		string text2 = "0123456789";
		for (int i = 0; i < int_2; i++)
		{
			text += text2[random_1.Next(0, text2.Length)];
		}
		return text;
	}

	public static string smethod_57(string string_0)
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c " + string_0;
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

	public static void smethod_58(double double_0)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
	}

	public static string smethod_59(string string_0)
	{
		return WebUtility.HtmlDecode(string_0);
	}

	public static string smethod_60(string string_0)
	{
		return WebUtility.HtmlEncode(string_0);
	}

	public static string smethod_61(string string_0)
	{
		return WebUtility.UrlDecode(string_0);
	}

	public static string smethod_62(string string_0)
	{
		return WebUtility.UrlEncode(string_0);
	}

	public static Point smethod_63(int int_2, int int_3)
	{
		GClass17 gClass = new GClass17("configChrome");
		if (gClass.method_2("width") == 0)
		{
			gClass.method_5("width", int_0);
			gClass.method_5("heigh", int_1);
			gClass.method_8();
		}
		int_0 = gClass.method_2("width");
		int_1 = gClass.method_2("heigh");
		int x = int_0 / int_2 + 15;
		int y = int_1 / int_3 + 10;
		return new Point(x, y);
	}

	public static Point smethod_64(int int_2, int int_3, int int_4)
	{
		GClass17 gClass = new GClass17("configChrome");
		if (gClass.method_2("width") == 0)
		{
			gClass.method_5("width", int_0);
			gClass.method_5("heigh", int_1);
			gClass.method_8();
		}
		int_0 = gClass.method_2("width");
		int_1 = gClass.method_2("heigh");
		Point result = default(Point);
		while (int_2 >= int_3 * int_4)
		{
			int_2 -= int_3 * int_4;
		}
		switch (int_4)
		{
		case 1:
			result.Y = 0;
			break;
		case 2:
			if (int_2 < int_3)
			{
				result.Y = 0;
			}
			else if (int_2 < int_3 * 2)
			{
				result.Y = int_1 / 2;
				int_2 -= int_3;
			}
			break;
		case 3:
			if (int_2 < int_3)
			{
				result.Y = 0;
			}
			else if (int_2 < int_3 * 2)
			{
				result.Y = int_1 / 3;
				int_2 -= int_3;
			}
			else if (int_2 < int_3 * 3)
			{
				result.Y = int_1 / 3 * 2;
				int_2 -= int_3 * 2;
			}
			break;
		case 4:
			if (int_2 < int_3)
			{
				result.Y = 0;
			}
			else if (int_2 < int_3 * 2)
			{
				result.Y = int_1 / 4;
				int_2 -= int_3;
			}
			else if (int_2 < int_3 * 3)
			{
				result.Y = int_1 / 4 * 2;
				int_2 -= int_3 * 2;
			}
			else if (int_2 < int_3 * 4)
			{
				result.Y = int_1 / 4 * 3;
				int_2 -= int_3 * 3;
			}
			break;
		case 5:
			if (int_2 < int_3)
			{
				result.Y = 0;
			}
			else if (int_2 < int_3 * 2)
			{
				result.Y = int_1 / 5;
				int_2 -= int_3;
			}
			else if (int_2 < int_3 * 3)
			{
				result.Y = int_1 / 5 * 2;
				int_2 -= int_3 * 2;
			}
			else if (int_2 < int_3 * 4)
			{
				result.Y = int_1 / 5 * 3;
				int_2 -= int_3 * 3;
			}
			else
			{
				result.Y = int_1 / 5 * 4;
				int_2 -= int_3 * 4;
			}
			break;
		}
		int num = int_0 / int_3;
		result.X = int_2 * num - 10;
		return result;
	}

	public static int smethod_65(ref List<int> list_0)
	{
		int result = 0;
		lock (list_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] == 0)
				{
					result = i;
					list_0[i] = 1;
					break;
				}
			}
		}
		return result;
	}

	public static void smethod_66(ref List<int> list_0, int int_2)
	{
		lock (list_0)
		{
			list_0[int_2] = 0;
		}
	}

	public static string smethod_67(string string_0, int int_2, int int_3 = 0)
	{
		string string_2 = "";
		List<string> list = new List<string> { "https://icanhazip.com", "https://api.myip.com/", "https://api64.ipify.org/", "http://v4v6.ipv6-test.com/api/myip.php/" };
		try
		{
			int int_4 = 0;
			int count = list.Count;
			List<Thread> list2 = new List<Thread>();
			for (int i = 0; i < count; i++)
			{
				string string_ = list[i];
				Thread thread = new Thread((ThreadStart)delegate
				{
					int tickCount = Environment.TickCount;
					while (Environment.TickCount - tickCount < 20000)
					{
						string text = smethod_69(string_, string_0, int_2);
						if (text != "" && !text.Contains("html"))
						{
							string_2 = text;
							break;
						}
					}
					Interlocked.Increment(ref int_4);
				});
				list2.Add(thread);
				thread.Start();
			}
			while (int_4 < count && string_2 == "")
			{
				Thread.Sleep(1000);
			}
			foreach (Thread item in list2)
			{
				try
				{
					item.Abort();
				}
				catch (Exception)
				{
				}
			}
		}
		catch
		{
		}
		return string_2.Trim();
	}

	public static string smethod_68(string string_0, int int_2, int int_3 = 0)
	{
		string string_2 = "";
		List<string> list = new List<string> { "https://icanhazip.com", "https://api.myip.com/", "https://api64.ipify.org/", "http://v4v6.ipv6-test.com/api/myip.php/" };
		try
		{
			int int_4 = 0;
			int count = list.Count;
			List<Thread> list2 = new List<Thread>();
			for (int i = 0; i < count; i++)
			{
				string string_ = list[i];
				Thread thread = new Thread((ThreadStart)delegate
				{
					int tickCount = Environment.TickCount;
					while (Environment.TickCount - tickCount < 20000)
					{
						string text = smethod_69(string_, string_0, int_2);
						if (text != "" && !text.Contains("html"))
						{
							string_2 = text;
							break;
						}
					}
					Interlocked.Increment(ref int_4);
				});
				list2.Add(thread);
				thread.Start();
			}
			while (int_4 < count && string_2 == "")
			{
				Thread.Sleep(1000);
			}
			foreach (Thread item in list2)
			{
				try
				{
					item.Abort();
				}
				catch (Exception)
				{
				}
			}
		}
		catch
		{
		}
		return string_2.Trim();
	}

	private static string smethod_69(string string_0, string string_1, int int_2)
	{
		string text = "";
		try
		{
			GClass19 gClass = new GClass19("", "", string_1, int_2);
			gClass.httpRequest_0.AddHeader("Cache-Control", "no-cache");
			if (string_1 != "")
			{
				gClass.httpRequest_0.Proxy.ConnectTimeout = 5000;
			}
			text = gClass.method_0(string_0);
			if (string_0 == "https://api.myip.com/")
			{
				text = Regex.Match(text, "ip\":\"(.*?)\"").Groups[1].Value;
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	public static void smethod_70(RichTextBox richTextBox_0, Label label_0)
	{
		try
		{
			string text = label_0.Text;
			List<string> list_ = richTextBox_0.Lines.ToList();
			list_ = smethod_36(list_);
			label_0.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + list_.Count + ")");
		}
		catch
		{
		}
	}

	public static string smethod_71(string string_0, int int_2)
	{
		string text = "";
		try
		{
			GClass19 gClass = new GClass19("", Class38.smethod_0(random_0), string_0, int_2);
			return gClass.method_0("https://api64.ipify.org/");
		}
		catch (Exception)
		{
			return smethod_72(string_0, int_2);
		}
	}

	public static string smethod_72(string string_0, int int_2)
	{
		string result = "";
		try
		{
			GClass19 gClass = new GClass19("", Class38.smethod_0(random_0), string_0, int_2);
			string input = gClass.method_0("https://showip.net/");
			result = Regex.Match(input, "value=\"(.*?)\"").Groups[1].Value;
		}
		catch (Exception exception_)
		{
			smethod_75(null, exception_, "Check Proxy2");
		}
		return result;
	}

	public static string smethod_73(string string_0, int int_2)
	{
		string result = "";
		try
		{
			GClass19 gClass = new GClass19("", "", string_0, int_2);
			string json = gClass.method_0("http://lumtest.com/myip.json");
			result = JObject.Parse(json)["ip"]!.ToString();
		}
		catch (Exception exception_)
		{
			smethod_75(null, exception_, "Check Proxy");
		}
		return result;
	}

	public static string smethod_74()
	{
		string result = "";
		try
		{
			GClass19 gClass = new GClass19("", "", "", 0);
			string text = "";
			text = gClass.method_0("http://lumtest.com/myip.json");
			result = JObject.Parse(text)["ip"]!.ToString();
		}
		catch
		{
		}
		return result;
	}

	public static void smethod_75(GClass12 gclass12_0, Exception exception_0, string string_0 = "")
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

	public static void smethod_76(Exception exception_0, string string_0 = "")
	{
		try
		{
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
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

	public static string smethod_77(string string_0, string string_1, int int_2 = 10)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_0;
		process.StartInfo.Arguments = string_1;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
		process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
		StringBuilder stringBuilder_0 = new StringBuilder();
		process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder_0.Append(e.Data + "\n");
			}
		};
		process.Start();
		process.BeginOutputReadLine();
		if (int_2 < 0)
		{
			process.WaitForExit();
		}
		else
		{
			process.WaitForExit(int_2 * 1000);
		}
		process.Close();
		return stringBuilder_0.ToString();
	}

	public static bool smethod_78(string string_0)
	{
		bool flag = false;
		string text = smethod_77("rasdial.exe", "\"" + string_0 + "\"", 3);
		if (text.Contains("Successfully connected to "))
		{
			flag = true;
		}
		else if (text.Contains("You are already connected to "))
		{
			for (int i = 0; i < 3; i++)
			{
				text = smethod_77("rasdial.exe", "\"" + string_0 + "\" /disconnect", 3);
				if (!(text.Trim() == "Command completed successfully."))
				{
					smethod_58(1.0);
					continue;
				}
				flag = true;
				break;
			}
			smethod_58(1.0);
			if (flag)
			{
				for (int j = 0; j < 3; j++)
				{
					text = smethod_77("rasdial.exe", "\"" + string_0 + "\"", 3);
					if (!text.Contains("Successfully connected to "))
					{
						smethod_58(1.0);
						continue;
					}
					flag = true;
					break;
				}
			}
			smethod_58(1.0);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	public static bool smethod_79(int int_2, int int_3, string string_0, string string_1, int int_4, string string_2)
	{
		bool result = false;
		string text = "";
		try
		{
			switch (int_2)
			{
			case 0:
				return true;
			case 1:
			{
				string text2 = smethod_74();
				IntPtr intptr_ = GClass10.smethod_3(null, "HMA VPN");
				GClass10.smethod_1(intptr_);
				GClass10.smethod_17(GClass10.smethod_12(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				Thread.Sleep(5000);
				string text3 = smethod_74();
				GClass10.smethod_17(GClass10.smethod_12(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				int tickCount = Environment.TickCount;
				do
				{
					text = smethod_74();
				}
				while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
				if (text != text2)
				{
					result = true;
				}
				break;
			}
			case 2:
			{
				if (int_3 == 0)
				{
					result = smethod_78(string_0);
					break;
				}
				int num = smethod_81(string_1);
				if (num == 0)
				{
					Thread.Sleep(2000);
					num = smethod_81(string_1);
				}
				result = num == 1;
				break;
			}
			}
		}
		catch (Exception exception_)
		{
			smethod_75(null, exception_, "Error ChangeIP");
		}
		return result;
	}

	public static bool smethod_80(string string_0)
	{
		return string_0.Length != Regex.Replace(string_0, "\\p{Cs}", "").Length;
	}

	public static int smethod_81(string string_0)
	{
		int result = -1;
		try
		{
			string text = "http" + Regex.Match(string_0, "http(.*?)/html").Groups[1].Value;
			GClass18 gClass = new GClass18("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
			string input = gClass.method_0(string_0);
			string text2 = "";
			try
			{
				text2 = Regex.Matches(input, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
			}
			catch
			{
				text2 = Regex.Match(gClass.method_0(text + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
			}
			input = gClass.method_0(text + "/api/dialup/mobile-dataswitch");
			gClass.requestHTTP_0.SetDefaultHeaders(new string[8]
			{
				"__RequestVerificationToken: " + text2,
				"Accept: */*",
				"Accept-Encoding: gzip, deflate",
				"Accept-Language: vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5",
				"Content-Type: application/x-www-form-urlencoded; charset=UTF-8",
				"X-Requested-With: XMLHttpRequest",
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36"
			});
			string text3 = "";
			if (input.Contains("dataswitch>1"))
			{
				text3 = input.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
			}
			else
			{
				if (!input.Contains("dataswitch>0"))
				{
					return -1;
				}
				text3 = input.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
			}
			string text4 = gClass.method_1(text + "/api/dialup/mobile-dataswitch", text3);
			if (text4.Contains("OK"))
			{
				input = gClass.method_0(text + "/api/dialup/mobile-dataswitch");
				if (input.Contains("dataswitch>1<"))
				{
					for (int i = 0; i < 10; i++)
					{
						string text5 = gClass.method_0(text + "/api/monitoring/traffic-statistics");
						if (!text5.Contains("<CurrentUpload>0"))
						{
							break;
						}
						Thread.Sleep(1000);
					}
				}
				return Convert.ToInt32(Regex.Match(input, "dataswitch>(.*?)<").Groups[1].Value);
			}
			result = -1;
		}
		catch
		{
		}
		return result;
	}

	public static DateTime smethod_82(string string_0, string string_1 = "dd/MM/yyyy HH:mm:ss")
	{
		return DateTime.ParseExact(string_0, string_1, CultureInfo.InvariantCulture);
	}

	public static string smethod_83(string string_0, int int_2 = 0)
	{
		return smethod_1(GetTotp(Encoding.UTF8.GetBytes(string_0)));
	}

	public static string smethod_84(string string_0)
	{
		string text = "";
		try
		{
			string text2 = "";
			string_0 = string_0.Replace(" ", "").Trim();
			string string_ = "https://app.minsoftware.vn/api/2fa1?secret=" + string_0;
			string string_2 = "http://2fa.live/tok/" + string_0;
			for (int i = 0; i < 5; i++)
			{
				text = "";
				try
				{
					text2 = smethod_49(string_2);
					if (text2.Contains("token"))
					{
						JObject jObject = JObject.Parse(text2);
						text = jObject["token"]!.ToString().Trim();
					}
				}
				catch (Exception exception_)
				{
					smethod_76(exception_, string_2);
				}
				try
				{
					if (text.Trim() == "")
					{
						text = smethod_49(string_);
					}
				}
				catch (Exception exception_2)
				{
					smethod_76(exception_2, string_);
				}
				if (!(text != "") || !smethod_46(text))
				{
					smethod_58(1.0);
					continue;
				}
				for (int j = text.Length; j < 6; j++)
				{
					text = "0" + text;
				}
				break;
			}
		}
		catch
		{
		}
		return text;
	}

	public static string smethod_85(string string_0)
	{
		try
		{
			byte[] secretKey = Base32Encoding.ToBytes(string_0.Trim().Replace(" ", ""));
			Totp totp = new Totp(secretKey);
			return totp.ComputeTotp(DateTime.UtcNow);
		}
		catch (Exception exception_)
		{
			smethod_76(exception_, "GetTotp(" + string_0 + ")");
		}
		return "";
	}

	private static int smethod_86()
	{
		return 30 - (int)((DateTime.UtcNow.Ticks - 621355968000000000L) / 10000000L % 30L);
	}

	private static byte[] smethod_87(long long_0)
	{
		byte[] bytes = BitConverter.GetBytes(long_0);
		Array.Reverse(bytes);
		return bytes;
	}

	private static long smethod_88(DateTime dateTime_0)
	{
		long num = (dateTime_0.Ticks - 621355968000000000L) / 10000000L;
		return num / 30L;
	}

	private static string smethod_89(long long_0, int int_2)
	{
		return ((int)long_0 % (int)Math.Pow(10.0, int_2)).ToString().PadLeft(int_2, '0');
	}

	private static byte[] smethod_90(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("input");
		}
		string_0 = string_0.TrimEnd('=');
		int num = string_0.Length * 5 / 8;
		byte[] array = new byte[num];
		byte b = 0;
		byte b2 = 8;
		int num2 = 0;
		int num3 = 0;
		string text = string_0;
		foreach (char char_ in text)
		{
			int num4 = smethod_91(char_);
			if (b2 > 5)
			{
				num2 = num4 << b2 - 5;
				b = (byte)(b | num2);
				b2 = (byte)(b2 - 5);
			}
			else
			{
				num2 = num4 >> 5 - b2;
				b = (byte)(b | num2);
				array[num3++] = b;
				b = (byte)(num4 << 3 + b2);
				b2 = (byte)(b2 + 3);
			}
		}
		if (num3 != num)
		{
			array[num3] = b;
		}
		return array;
	}

	private static int smethod_91(char char_0)
	{
		if (char_0 < '[' && char_0 > '@')
		{
			return char_0 - 65;
		}
		if (char_0 < '8' && char_0 > '1')
		{
			return char_0 - 24;
		}
		if (char_0 < '{' && char_0 > '`')
		{
			return char_0 - 97;
		}
		throw new ArgumentException("Character is not a Base32 character.", "c");
	}

	public static DataTable smethod_92(DataTable dataTable_0)
	{
		DataTable result = new DataTable();
		try
		{
			result = (from DataRow dataRow_0 in dataTable_0.Rows
				orderby Class49.random_0.Next()
				select dataRow_0).CopyToDataTable();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_93(string string_0, string string_1)
	{
		try
		{
			smethod_32(string_1);
			string[] directories = Directory.GetDirectories(string_0, "*", SearchOption.AllDirectories);
			foreach (string text in directories)
			{
				Directory.CreateDirectory(text.Replace(string_0, string_1));
			}
			string[] files = Directory.GetFiles(string_0, "*.*", SearchOption.AllDirectories);
			foreach (string text2 in files)
			{
				File.Copy(text2, text2.Replace(string_0, string_1), overwrite: true);
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_94(string string_0, string string_1)
	{
		try
		{
			Directory.Move(string_0, string_1);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_95(string string_0)
	{
		try
		{
			Directory.Delete(string_0, recursive: true);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_96(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0 == "")
		{
			return false;
		}
		return string_0 != smethod_98(string_0) && smethod_97(string_0);
	}

	public static bool smethod_97(string string_0)
	{
		bool result = true;
		string text = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZaAeEoOuUiIdDyYáàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ";
		foreach (char value in string_0)
		{
			if (!text.ToCharArray().Contains(value))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string smethod_98(string string_0)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string input = string_0.Normalize(NormalizationForm.FormD);
		return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
	}

	public static bool smethod_99(string string_0)
	{
		try
		{
			File.Delete(string_0);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_100()
	{
		string result = "";
		string newValue = "chrome.exe";
		object value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
		if (value == null)
		{
			value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
			if (value != null)
			{
				result = value.ToString();
			}
		}
		else
		{
			result = value.ToString();
		}
		return result;
	}

	public static string smethod_101()
	{
		return FileVersionInfo.GetVersionInfo(smethod_100().ToString()).FileVersion;
	}
}
