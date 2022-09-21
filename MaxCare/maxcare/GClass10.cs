using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class GClass10
{
	public delegate bool GDelegate0(IntPtr intptr_0, IntPtr intptr_1);

	private delegate bool Delegate0(IntPtr intptr_0, IntPtr intptr_1);

	[Flags]
	public enum GEnum9 : uint
	{
		flag_0 = 2u,
		flag_1 = 4u,
		flag_2 = 0x20u,
		flag_3 = 0x40u,
		flag_4 = 1u,
		flag_5 = 0x8000u,
		flag_6 = 8u,
		flag_7 = 0x10u,
		flag_8 = 0x800u,
		flag_9 = 0x80u,
		flag_10 = 0x100u,
		flag_11 = 1u,
		flag_12 = 2u
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class A29B5E56
	{
		public static readonly A29B5E56 _003C_003E9 = new A29B5E56();

		public static Func<Process, bool> _003C_003E9__26_0;

		public static Func<Process, bool> _003C_003E9__27_0;

		public static Delegate0 _003C_003E9__31_0;

		internal bool method_0(Process process_0)
		{
			return process_0.MainWindowHandle != IntPtr.Zero;
		}

		internal bool method_1(Process process_0)
		{
			return process_0.MainWindowHandle != IntPtr.Zero;
		}

		internal bool method_2(IntPtr intptr_0, IntPtr intptr_1)
		{
			GCHandle gCHandle = GCHandle.FromIntPtr(intptr_1);
			if (gCHandle.Target == null)
			{
				return false;
			}
			List<IntPtr> list = gCHandle.Target as List<IntPtr>;
			list.Add(intptr_0);
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class Class19
	{
		public string string_0;

		public string string_1;

		internal bool method_0(IntPtr intptr_0)
		{
			string text = smethod_46(intptr_0);
			string text2 = smethod_45(intptr_0);
			return text == string_0 || text2 == string_1;
		}
	}

	[CompilerGenerated]
	private sealed class Class20
	{
		public string string_0;

		public string string_1;

		internal bool method_0(IntPtr intptr_0)
		{
			string text = smethod_46(intptr_0);
			string text2 = smethod_45(intptr_0);
			return text == string_0 || text2 == string_1;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	public static extern bool EnumChildWindows(IntPtr intptr_0, GDelegate0 gdelegate0_0, IntPtr intptr_1);

	[DllImport("User32.dll")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_1(IntPtr intptr_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_2(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_3(IntPtr intptr_0, int int_0, IntPtr intptr_1, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	public static extern int SendMessage_4(IntPtr intptr_0, int int_0, int int_1, string string_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDlgItem(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	private static extern bool SetDlgItemTextA(IntPtr intptr_0, int int_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "PostMessage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage_1(IntPtr intptr_0, int int_0, IntPtr intptr_1, string string_0);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_0, ref GStruct1 gstruct1_0);

	[DllImport("user32", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows_1(IntPtr intptr_0, Delegate0 delegate0_0, IntPtr intptr_1);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(uint uint_0, int int_0, int int_1, int int_2, UIntPtr uintptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint uint_0, GStruct2[] gstruct2_0, int int_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	public static IntPtr smethod_0(string string_0, string string_1 = null)
	{
		IntPtr intPtr = FindWindow(string_0, string_1);
		SetForegroundWindow(intPtr);
		return intPtr;
	}

	public static IntPtr smethod_1(IntPtr intptr_0)
	{
		SetForegroundWindow(intptr_0);
		return intptr_0;
	}

	public static bool smethod_2(IntPtr intptr_0)
	{
		return IsWindowVisible(intptr_0);
	}

	public static IntPtr smethod_3(string string_0, string string_1)
	{
		return FindWindow(string_0, string_1);
	}

	public static List<IntPtr> smethod_4(string string_0, string string_1, int int_0 = 1)
	{
		Process[] processes = Process.GetProcesses();
		List<IntPtr> list = new List<IntPtr>();
		int num = 0;
		foreach (Process item in processes.Where((Process process_0) => process_0.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_46(mainWindowHandle);
			string text2 = smethod_45(mainWindowHandle);
			if (text == string_0 || text2 == string_1)
			{
				list.Add(mainWindowHandle);
				if (num >= int_0)
				{
					break;
				}
				num++;
			}
		}
		return list;
	}

	public static IntPtr smethod_5(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		IntPtr result = IntPtr.Zero;
		foreach (Process item in processes.Where((Process process_0) => process_0.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_46(mainWindowHandle);
			string text2 = smethod_45(mainWindowHandle);
			if (text == string_0 || text2 == string_1)
			{
				result = mainWindowHandle;
				break;
			}
		}
		return result;
	}

	public static IntPtr smethod_6(IntPtr intptr_0, string string_0, string string_1)
	{
		return FindWindowEx(intptr_0, IntPtr.Zero, string_1, string_0);
	}

	private static IntPtr smethod_7(IntPtr intptr_0, int int_0)
	{
		if (int_0 == 0)
		{
			return intptr_0;
		}
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		do
		{
			intPtr = FindWindowEx(intptr_0, intPtr, "Button", null);
			if (intPtr != IntPtr.Zero)
			{
				num++;
			}
		}
		while (num < int_0 && intPtr != IntPtr.Zero);
		return intPtr;
	}

	public static IntPtr smethod_8(IntPtr intptr_0, int int_0)
	{
		return GetDlgItem(intptr_0, int_0);
	}

	public static List<IntPtr> smethod_9(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr intptr_2 = GCHandle.ToIntPtr(value);
		try
		{
			Delegate0 delegate0_ = delegate(IntPtr intptr_0, IntPtr intptr_1)
			{
				GCHandle gCHandle = GCHandle.FromIntPtr(intptr_1);
				if (gCHandle.Target == null)
				{
					return false;
				}
				List<IntPtr> list2 = gCHandle.Target as List<IntPtr>;
				list2.Add(intptr_0);
				return true;
			};
			EnumChildWindows_1(intptr_0, delegate0_, intptr_2);
		}
		finally
		{
			value.Free();
		}
		return list;
	}

	public static IntPtr smethod_10(List<IntPtr> list_0, string string_0, string string_1)
	{
		return list_0.Find(delegate(IntPtr intptr_0)
		{
			string text = smethod_46(intptr_0);
			string text2 = smethod_45(intptr_0);
			return text == string_0 || text2 == string_1;
		});
	}

	public static List<IntPtr> smethod_11(List<IntPtr> list_0, string string_0, string string_1)
	{
		new List<IntPtr>();
		IEnumerable<IntPtr> source = list_0.Where(delegate(IntPtr intptr_0)
		{
			string text = smethod_46(intptr_0);
			string text2 = smethod_45(intptr_0);
			return text == string_0 || text2 == string_1;
		});
		return source.ToList();
	}

	public static IntPtr smethod_12(IntPtr intptr_0, string string_0, string string_1)
	{
		return smethod_10(smethod_9(intptr_0), string_0, string_1);
	}

	public static List<IntPtr> smethod_13(IntPtr intptr_0, string string_0, string string_1)
	{
		return smethod_11(smethod_9(intptr_0), string_0, string_1);
	}

	public static bool smethod_14(IntPtr intptr_0, IntPtr intptr_1)
	{
		string text = smethod_45(intptr_0);
		string text2 = smethod_46(intptr_0);
		if (text == "&Options >>" && text2.StartsWith("ToolbarWindow32"))
		{
			SendMessage_2(intptr_0, 0, IntPtr.Zero, IntPtr.Zero);
			return false;
		}
		return true;
	}

	public static void smethod_15(IntPtr intptr_0, int int_0)
	{
		IntPtr dlgItem = GetDlgItem(intptr_0, int_0);
		int int_ = 0 | (int_0 & 0xFFFF);
		SendMessage_1(intptr_0, 273, int_, dlgItem);
	}

	public static void smethod_16(IntPtr intptr_0)
	{
		SendMessage_2(intptr_0, 513, IntPtr.Zero, IntPtr.Zero);
		SendMessage_2(intptr_0, 514, IntPtr.Zero, IntPtr.Zero);
	}

	public static void smethod_17(IntPtr intptr_0, int int_0, int int_1, GEnum8 genum8_0 = GEnum8.const_0, int int_2 = 1)
	{
		int int_3 = 0;
		int int_4 = 0;
		if (genum8_0 == GEnum8.const_0)
		{
			int_3 = 513;
			int_4 = 514;
		}
		if (genum8_0 == GEnum8.const_1)
		{
			int_3 = 516;
			int_4 = 517;
		}
		IntPtr intptr_ = smethod_48(int_0, int_1);
		if (genum8_0 == GEnum8.const_0 || genum8_0 == GEnum8.const_1)
		{
			for (int i = 0; i < int_2; i++)
			{
				PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
				PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
				PostMessage(intptr_0, int_4, new IntPtr(0), intptr_);
			}
			return;
		}
		if (genum8_0 == GEnum8.const_2)
		{
			int_3 = 515;
			int_4 = 514;
		}
		if (genum8_0 == GEnum8.const_3)
		{
			int_3 = 518;
			int_4 = 517;
		}
		PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
		PostMessage(intptr_0, int_4, new IntPtr(0), intptr_);
	}

	public static void smethod_18(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, int int_4 = 10, int int_5 = 10, double double_0 = 0.05)
	{
		int int_6 = 513;
		int int_7 = 514;
		IntPtr intptr_ = smethod_48(int_0, int_1);
		IntPtr intptr_2 = smethod_48(int_2, int_3);
		if (int_2 < int_0)
		{
			int_4 *= -1;
		}
		if (int_3 < int_1)
		{
			int_5 *= -1;
		}
		PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
		PostMessage(intptr_0, int_6, new IntPtr(1), intptr_);
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(intptr_0, 512, new IntPtr(1), smethod_48(int_0, int_1));
			if (int_4 <= 0)
			{
				if (int_0 > int_2)
				{
					int_0 += int_4;
				}
				else
				{
					flag = true;
				}
			}
			else if (int_0 < int_2)
			{
				int_0 += int_4;
			}
			else
			{
				flag = true;
			}
			if (int_5 > 0)
			{
				if (int_1 < int_3)
				{
					int_1 += int_5;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (int_1 > int_3)
			{
				int_1 += int_5;
			}
			else
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
		PostMessage(intptr_0, int_7, new IntPtr(0), intptr_2);
	}

	public static void smethod_19(IntPtr intptr_0, int int_0, int int_1, GEnum8 genum8_0 = GEnum8.const_0, int int_2 = 1)
	{
		int int_3 = 0;
		if (genum8_0 == GEnum8.const_0)
		{
			int_3 = 513;
		}
		if (genum8_0 == GEnum8.const_1)
		{
			int_3 = 516;
		}
		IntPtr intptr_ = smethod_48(int_0, int_1);
		for (int i = 0; i < int_2; i++)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
			PostMessage(intptr_0, int_3, new IntPtr(1), intptr_);
		}
	}

	public static void smethod_20(IntPtr intptr_0, int int_0, int int_1, GEnum8 genum8_0 = GEnum8.const_0, int int_2 = 1)
	{
		int int_3 = 0;
		if (genum8_0 == GEnum8.const_0)
		{
			int_3 = 514;
		}
		if (genum8_0 == GEnum8.const_1)
		{
			int_3 = 517;
		}
		IntPtr intptr_ = smethod_48(int_0, int_1);
		for (int i = 0; i < int_2; i++)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
			SendMessage_2(intptr_0, int_3, new IntPtr(0), intptr_);
		}
	}

	public static void smethod_21(IntPtr intptr_0, string string_0)
	{
		SendMessage_4(intptr_0, 12, 0, string_0);
	}

	public static void smethod_22(IntPtr intptr_0, GEnum7 genum7_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)genum7_0), new IntPtr(1));
		PostMessage(intptr_0, 257, new IntPtr((int)genum7_0), new IntPtr(0));
	}

	public static void smethod_23(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
	{
		string text = string_0.ToLower();
		foreach (char c in text)
		{
			GEnum7 genum7_ = GEnum7.const_31;
			char c2 = c;
			switch (c2)
			{
			default:
				switch (c2)
				{
				case 'a':
					genum7_ = GEnum7.const_41;
					break;
				case 'b':
					genum7_ = GEnum7.const_42;
					break;
				case 'c':
					genum7_ = GEnum7.const_62;
					break;
				case 'd':
					genum7_ = GEnum7.const_44;
					break;
				case 'e':
					genum7_ = GEnum7.const_45;
					break;
				case 'f':
					genum7_ = GEnum7.const_46;
					break;
				case 'g':
					genum7_ = GEnum7.const_47;
					break;
				case 'h':
					genum7_ = GEnum7.const_48;
					break;
				case 'i':
					genum7_ = GEnum7.const_49;
					break;
				case 'j':
					genum7_ = GEnum7.const_50;
					break;
				case 'k':
					genum7_ = GEnum7.const_51;
					break;
				case 'l':
					genum7_ = GEnum7.const_52;
					break;
				case 'm':
					genum7_ = GEnum7.const_53;
					break;
				case 'n':
					genum7_ = GEnum7.const_54;
					break;
				case 'o':
					genum7_ = GEnum7.const_55;
					break;
				case 'p':
					genum7_ = GEnum7.const_56;
					break;
				case 'q':
					genum7_ = GEnum7.const_57;
					break;
				case 'r':
					genum7_ = GEnum7.const_58;
					break;
				case 's':
					genum7_ = GEnum7.const_59;
					break;
				case 't':
					genum7_ = GEnum7.const_60;
					break;
				case 'u':
					genum7_ = GEnum7.const_61;
					break;
				case 'v':
					genum7_ = GEnum7.const_62;
					break;
				case 'w':
					genum7_ = GEnum7.const_63;
					break;
				case 'x':
					genum7_ = GEnum7.const_64;
					break;
				case 'y':
					genum7_ = GEnum7.const_65;
					break;
				case 'z':
					genum7_ = GEnum7.const_66;
					break;
				}
				break;
			case '0':
				genum7_ = GEnum7.const_31;
				break;
			case '1':
				genum7_ = GEnum7.const_32;
				break;
			case '2':
				genum7_ = GEnum7.const_33;
				break;
			case '3':
				genum7_ = GEnum7.const_34;
				break;
			case '4':
				genum7_ = GEnum7.const_35;
				break;
			case '5':
				genum7_ = GEnum7.const_36;
				break;
			case '6':
				genum7_ = GEnum7.const_37;
				break;
			case '7':
				genum7_ = GEnum7.const_38;
				break;
			case '8':
				genum7_ = GEnum7.const_39;
				break;
			case '9':
				genum7_ = GEnum7.const_40;
				break;
			}
			smethod_22(intptr_0, genum7_);
			Thread.Sleep(TimeSpan.FromSeconds(float_0));
		}
	}

	public static void smethod_24(IntPtr intptr_0, GEnum7 genum7_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 257, new IntPtr((int)genum7_0), new IntPtr(0));
	}

	public static void smethod_25(IntPtr intptr_0, GEnum7 genum7_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 258, new IntPtr((int)genum7_0), new IntPtr(0));
	}

	public static void smethod_26(IntPtr intptr_0, int int_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 258, new IntPtr(int_0), new IntPtr(0));
	}

	public static void smethod_27(IntPtr intptr_0, GEnum7 genum7_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)genum7_0), new IntPtr(0));
	}

	public static void smethod_28(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
	{
		string text = string_0.ToLower();
		foreach (char int_ in text)
		{
			smethod_26(intptr_0, int_);
		}
	}

	public static void smethod_29(GEnum6 genum6_0)
	{
		smethod_32(genum6_0);
	}

	public static void smethod_30(GEnum6[] genum6_0)
	{
		foreach (GEnum6 genum6_ in genum6_0)
		{
			smethod_34(genum6_);
		}
		foreach (GEnum6 genum6_2 in genum6_0)
		{
			smethod_35(genum6_2);
		}
	}

	public static void smethod_31(string string_0)
	{
		Clipboard.SetText(string_0);
		smethod_30(new GEnum6[2]
		{
			GEnum6.const_107,
			GEnum6.const_94
		});
	}

	public static void smethod_32(GEnum6 genum6_0)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.uint_0 = 1u;
		GStruct2 gStruct2 = gStruct;
		gStruct2.gstruct3_0.gstruct6_0 = new GStruct6
		{
			ushort_0 = (ushort)genum6_0,
			ushort_1 = 0,
			uint_0 = 0u,
			uint_1 = 0u,
			intptr_0 = IntPtr.Zero
		};
		gStruct = default(GStruct2);
		gStruct.uint_0 = 1u;
		GStruct2 gStruct3 = gStruct;
		gStruct3.gstruct3_0.gstruct6_0 = new GStruct6
		{
			ushort_0 = (ushort)genum6_0,
			ushort_1 = 0,
			uint_0 = 2u,
			uint_1 = 0u,
			intptr_0 = IntPtr.Zero
		};
		GStruct2[] gstruct2_ = new GStruct2[2] { gStruct2, gStruct3 };
		if (SendInput(2u, gstruct2_, Marshal.SizeOf(typeof(GStruct2))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_33(string string_0, double double_0 = 0.5)
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case '0':
				smethod_32(GEnum6.const_63);
				break;
			case '1':
				smethod_32(GEnum6.const_64);
				break;
			case '2':
				smethod_32(GEnum6.const_65);
				break;
			case '3':
				smethod_32(GEnum6.const_66);
				break;
			case '4':
				smethod_32(GEnum6.const_67);
				break;
			case '5':
				smethod_32(GEnum6.const_68);
				break;
			case '6':
				smethod_32(GEnum6.const_69);
				break;
			case '7':
				smethod_32(GEnum6.const_70);
				break;
			case '8':
				smethod_32(GEnum6.const_71);
				break;
			case '9':
				smethod_32(GEnum6.const_72);
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
	}

	public static void smethod_34(GEnum6 genum6_0)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.uint_0 = 1u;
		GStruct2 gStruct2 = gStruct;
		gStruct2.gstruct3_0.gstruct6_0 = default(GStruct6);
		gStruct2.gstruct3_0.gstruct6_0.ushort_0 = (ushort)genum6_0;
		gStruct2.gstruct3_0.gstruct6_0.ushort_1 = 0;
		gStruct2.gstruct3_0.gstruct6_0.uint_0 = 0u;
		gStruct2.gstruct3_0.gstruct6_0.uint_1 = 0u;
		gStruct2.gstruct3_0.gstruct6_0.intptr_0 = IntPtr.Zero;
		GStruct2[] gstruct2_ = new GStruct2[1] { gStruct2 };
		if (SendInput(1u, gstruct2_, Marshal.SizeOf(typeof(GStruct2))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_35(GEnum6 genum6_0)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.uint_0 = 1u;
		GStruct2 gStruct2 = gStruct;
		gStruct2.gstruct3_0.gstruct6_0 = default(GStruct6);
		gStruct2.gstruct3_0.gstruct6_0.ushort_0 = (ushort)genum6_0;
		gStruct2.gstruct3_0.gstruct6_0.ushort_1 = 0;
		gStruct2.gstruct3_0.gstruct6_0.uint_0 = 2u;
		gStruct2.gstruct3_0.gstruct6_0.uint_1 = 0u;
		gStruct2.gstruct3_0.gstruct6_0.intptr_0 = IntPtr.Zero;
		GStruct2[] gstruct2_ = new GStruct2[1] { gStruct2 };
		if (SendInput(1u, gstruct2_, Marshal.SizeOf(typeof(GStruct2))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_36(int int_0, int int_1, GEnum8 genum8_0 = GEnum8.const_0)
	{
		Cursor.Position = new Point(int_0, int_1);
		smethod_41(genum8_0);
	}

	public static void smethod_37(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < int_0; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_38(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < int_0; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_39(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2048u, 0, 0, int_0, UIntPtr.Zero);
	}

	public static void smethod_40(Point point_0, GEnum8 genum8_0 = GEnum8.const_0)
	{
		Cursor.Position = point_0;
		smethod_41(genum8_0);
	}

	public static void smethod_41(GEnum8 genum8_0 = GEnum8.const_0)
	{
		switch (genum8_0)
		{
		case GEnum8.const_0:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum8.const_1:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum8.const_2:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum8.const_3:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		}
	}

	public static GStruct1 smethod_42(IntPtr intptr_0)
	{
		GStruct1 gstruct1_ = default(GStruct1);
		GetWindowRect(intptr_0, ref gstruct1_);
		return gstruct1_;
	}

	public static Point smethod_43(IntPtr intptr_0, Point? nullable_0 = null)
	{
		Point result = default(Point);
		GStruct1 gStruct = smethod_42(intptr_0);
		if (!nullable_0.HasValue)
		{
			nullable_0 = default(Point);
		}
		result.X = nullable_0.Value.X + gStruct.int_0;
		result.Y = nullable_0.Value.Y + gStruct.int_1;
		return result;
	}

	public static Point smethod_44(IntPtr intptr_0, int int_0 = 0, int int_1 = 0)
	{
		Point result = default(Point);
		GStruct1 gStruct = smethod_42(intptr_0);
		result.X = int_0 + gStruct.int_0;
		result.Y = int_1 + gStruct.int_1;
		return result;
	}

	public static string smethod_45(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(intptr_0, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static string smethod_46(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetClassName(intptr_0, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static IntPtr smethod_47(int int_0, int int_1)
	{
		return (IntPtr)((int_1 << 16) | (int_0 & 0xFFFF));
	}

	public static IntPtr smethod_48(int int_0, int int_1)
	{
		return (IntPtr)((int_1 << 16) | int_0);
	}
}
