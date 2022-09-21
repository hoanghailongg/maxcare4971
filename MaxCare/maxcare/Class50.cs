using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ManagedWinapi.Windows;

internal class Class50
{
	[Serializable]
	[CompilerGenerated]
	private sealed class BAC540F5
	{
		public static readonly BAC540F5 _003C_003E9 = new BAC540F5();

		public static Predicate<SystemWindow> _003C_003E9__9_0;

		public static Predicate<SystemWindow> _003C_003E9__9_2;

		internal bool method_0(SystemWindow systemWindow_0)
		{
			return systemWindow_0.Title == "Host Key Verification";
		}

		internal bool method_1(SystemWindow systemWindow_0)
		{
			return systemWindow_0.Title == "&Accept for This Session";
		}
	}

	[CompilerGenerated]
	private sealed class Class51
	{
		public int int_0;

		public string string_0;

		public Predicate<SystemWindow> predicate_0;

		internal bool method_0(SystemWindow systemWindow_0)
		{
			return systemWindow_0.Title == "Bitvise SSH Client - " + int_0 + ".bscp - " + string_0 + ":22";
		}
	}

	private const int int_0 = 16;

	private const int int_1 = 245;

	private const int int_2 = 513;

	private const int int_3 = 514;

	private static Hashtable hashtable_0 = new Hashtable();

	public static int int_4 = 30;

	private static int int_5 = 1079;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(int int_6, int int_7, int int_8, IntPtr intptr_0);

	public static int smethod_0()
	{
		int_5++;
		if (int_5 >= 1280)
		{
			int_5 = 1079;
		}
		Process value = new Process();
		try
		{
			hashtable_0.Add(int_5, value);
		}
		catch
		{
		}
		return int_5;
	}

	public static bool smethod_1(string string_0, string string_1, string string_2, int int_6)
	{
		bool flag = false;
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\BvSsh.exe";
		processStartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient";
		processStartInfo.Arguments = "-profile=\"" + AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\" + int_6 + ".bscp\" -host=" + string_0 + " -user=" + string_1 + " -password=" + string_2 + " -loginOnStartup -hide=main,trayIcon,banner,auth,popups,trayLog,trayWRC,trayTerm,traySFTP,trayRDP,trayPopups";
		Process process = Process.Start(processStartInfo);
		hashtable_0[int_6] = process;
		Thread.Sleep(2000);
		for (int i = 0; i < int_4; i++)
		{
			SystemWindow[] array = SystemWindow.FilterToplevelWindows((SystemWindow systemWindow_0) => systemWindow_0.Title == "Host Key Verification");
			if (array.Length != 0)
			{
				SystemWindow[] array2 = array[0].FilterDescendantWindows(directOnly: false, (SystemWindow systemWindow_0) => systemWindow_0.Title == "&Accept for This Session");
				if (array2.Length != 0)
				{
					SendMessage((int)array2[0].HWnd, 513, 0, IntPtr.Zero);
					Thread.Sleep(10);
					SendMessage((int)array2[0].HWnd, 514, 0, IntPtr.Zero);
					SendMessage((int)array2[0].HWnd, 513, 0, IntPtr.Zero);
					Thread.Sleep(10);
					SendMessage((int)array2[0].HWnd, 514, 0, IntPtr.Zero);
				}
			}
			SystemWindow[] array3 = SystemWindow.FilterToplevelWindows((SystemWindow systemWindow_0) => systemWindow_0.Title == "Bitvise SSH Client - " + int_6 + ".bscp - " + string_0 + ":22");
			if (array3.Length == 0)
			{
				Thread.Sleep(1000);
				continue;
			}
			flag = true;
			break;
		}
		if (!flag)
		{
			try
			{
				process.Kill();
				process.Dispose();
				return flag;
			}
			catch
			{
				return flag;
			}
		}
		return flag;
	}

	public static void smethod_2(int int_6)
	{
		if (hashtable_0[int_6] != null)
		{
			try
			{
				Process process = hashtable_0[int_6] as Process;
				process.Kill();
				process.Dispose();
			}
			catch
			{
			}
		}
	}

	private static bool smethod_3(string string_0, int int_6)
	{
		return true;
	}

	public static void smethod_4()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName == "BvSsh")
			{
				process.Kill();
			}
		}
	}

	public static Process smethod_5(IntPtr intptr_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.Handle == intptr_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}
}
