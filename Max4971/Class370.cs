using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class370
{
	public enum Enum3 : uint
	{
		const_0 = 0x1000u,
		const_1 = 0x2000u
	}

	public enum Enum4 : uint
	{
		const_0 = 0x8000u
	}

	public enum Enum5 : uint
	{
		const_0 = 32u,
		const_1 = 64u,
		const_2 = 8u,
		const_3 = 16u,
		const_4 = 1u,
		const_5 = 4u,
		const_6 = 256u,
		const_7 = 2u
	}

	public enum Enum6 : uint
	{
		const_0 = 2u,
		const_1 = 1u,
		const_2 = 8u,
		const_3 = 4u
	}

	public struct Struct8
	{
		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		private readonly IntPtr intptr_0;

		public unsafe void method_0()
		{
			//IL_0013: Expected O, but got Ref
			new GClass59().method_8(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 49665686);
		}

		public unsafe Struct8(string string_0)
		{
			//IL_0013: Expected O, but got Ref
			new GClass59().method_8(new object[2]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				string_0
			}, 49665402);
		}
	}

	public struct Struct9
	{
		public readonly uint uint_0;

		public readonly IntPtr intptr_0;

		public readonly IntPtr intptr_1;

		public readonly uint uint_1;

		public readonly IntPtr intptr_2;

		public readonly IntPtr intptr_3;

		public unsafe void method_0()
		{
			//IL_0013: Expected O, but got Ref
			new GClass59().method_8(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 49666127);
		}

		public unsafe Struct9(Struct8 struct8_0, uint uint_2)
		{
			//IL_0013: Expected O, but got Ref
			new GClass59().method_8(new object[3]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				struct8_0,
				uint_2
			}, 49665835);
		}
	}

	public struct Struct10
	{
		public uint uint_0;

		public IntPtr intptr_0;
	}

	public struct Struct11
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct12
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct13
	{
		public byte byte_0;

		public byte byte_1;
	}

	public struct Struct14
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public byte byte_0;
	}

	public enum Enum7
	{
		const_0 = 1,
		const_1 = 7,
		const_2 = 3,
		const_3 = 6,
		const_4 = 2,
		const_5 = 0,
		const_6 = 5,
		const_7 = 4,
		const_8 = 8
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate4(IntPtr intptr_0, Enum8 enum8_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate5(Enum9 enum9_0, IntPtr intptr_0, uint uint_0, out uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate6(IntPtr intptr_0, Enum10 enum10_0, IntPtr intptr_1, uint uint_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate7(IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate8(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum5 enum5_0, out Enum5 enum5_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate9(IntPtr intptr_0, ref IntPtr intptr_1, IntPtr intptr_2, ref UIntPtr uintptr_0, Enum3 enum3_0, Enum5 enum5_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate10(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum4 enum4_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate11(IntPtr intptr_0, IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate12(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr uintptr_1, Struct11 struct11_0, ref UIntPtr uintptr_2, uint uint_0, uint uint_1, Enum5 enum5_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate13(uint uint_0, uint uint_1, uint uint_2, IntPtr[] intptr_0, uint uint_3, out Enum7 enum7_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate14(out IntPtr intptr_0, uint uint_0, ref Struct9 struct9_0, out Struct10 struct10_0, uint uint_1, uint uint_2);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate15(out IntPtr intptr_0, uint uint_0, ref Struct9 struct9_0, ref Struct11 struct11_0, Enum5 enum5_0, uint uint_1, IntPtr intptr_1);

	public struct Struct15
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	public enum Enum8
	{
		const_0 = 0,
		const_1 = 7,
		const_2 = 30
	}

	public enum Enum9
	{
		const_0 = 76,
		const_1 = 35,
		const_2 = 0
	}

	public enum Enum10
	{
		const_0 = 17
	}

	public static readonly IntPtr intptr_0;

	private static Delegate13 delegate13_0;

	private static Delegate14 delegate14_0;

	private static Delegate7 delegate7_0;

	public static readonly IntPtr intptr_1;

	private static Delegate5 delegate5_0;

	private static IntPtr intptr_2;

	private static Delegate4 delegate4_0;

	private static Delegate8 delegate8_0;

	private static Delegate11 delegate11_0;

	private static Delegate6 delegate6_0;

	private static Delegate10 delegate10_0;

	private static Delegate9 delegate9_0;

	private static Delegate15 delegate15_0;

	private static Delegate12 delegate12_0;

	public static readonly IntPtr intptr_3;

	internal static IntPtr smethod_0(IntPtr intptr_4, object object_0)
	{
		return (IntPtr)new GClass59().method_8(new object[2] { intptr_4, object_0 }, 68101902);
	}

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	public static IntPtr smethod_1(IntPtr intptr_4, Enum6 enum6_0, uint uint_0, uint uint_1, ref UIntPtr uintptr_0)
	{
		object[] array = new object[5] { intptr_4, enum6_0, uint_0, uint_1, uintptr_0 };
		try
		{
			return (IntPtr)new GClass59().method_8(array, 68096583);
		}
		finally
		{
			uintptr_0 = (UIntPtr)array[4];
		}
	}

	public static IntPtr smethod_2(IntPtr intptr_4, IntPtr intptr_5, Enum5 enum5_0, uint uint_0, uint uint_1, string string_0)
	{
		return (IntPtr)new GClass59().method_8(new object[6] { intptr_4, intptr_5, enum5_0, uint_0, uint_1, string_0 }, 49664629);
	}

	public static bool smethod_3(IntPtr intptr_4, UIntPtr uintptr_0, Enum5 enum5_0, out Enum5 enum5_1)
	{
		object[] array = new object[4] { intptr_4, uintptr_0, enum5_0, enum5_1 };
		try
		{
			return (bool)new GClass59().method_8(array, 49664097);
		}
		finally
		{
			enum5_1 = (Enum5)array[3];
		}
	}

	public static byte[] smethod_4(uint uint_0, uint uint_1)
	{
		return (byte[])(Array)new GClass59().method_8(new object[2] { uint_0, uint_1 }, 68107052);
	}

	public static IntPtr smethod_5(string string_0, uint uint_0, uint uint_1)
	{
		return (IntPtr)new GClass59().method_8(new object[3] { string_0, uint_0, uint_1 }, 68107826);
	}

	public static bool smethod_6()
	{
		return (bool)new GClass59().method_8(null, 68098020);
	}

	internal static IntPtr smethod_7(uint uint_0)
	{
		return (IntPtr)new GClass59().method_8(new object[1] { uint_0 }, 68101361);
	}

	private static uint smethod_8(Enum9 enum9_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[4] { enum9_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass59().method_8(array, 68105770);
		}
		finally
		{
			object_0 = array[1];
			uint_1 = (uint)array[3];
		}
	}

	public static uint smethod_9(IntPtr intptr_4, Enum8 enum8_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[5] { intptr_4, enum8_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass59().method_8(array, 68105221);
		}
		finally
		{
			object_0 = array[2];
			uint_1 = (uint)array[4];
		}
	}

	public static uint smethod_10(IntPtr intptr_4, Enum10 enum10_0, IntPtr intptr_5, uint uint_0)
	{
		return (uint)new GClass59().method_8(new object[4] { intptr_4, enum10_0, intptr_5, uint_0 }, 68106244);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_0);

	public static void smethod_11(string string_0, string string_1, GEnum13 genum13_0, GEnum14 genum14_0)
	{
		new GClass59().method_8(new object[4] { string_0, string_1, genum13_0, genum14_0 }, 68098341);
	}

	public static bool smethod_12()
	{
		return (bool)new GClass59().method_8(null, 68097396);
	}

	public static byte[] smethod_13(uint uint_0)
	{
		return (byte[])(Array)new GClass59().method_8(new object[1] { uint_0 }, 68106394);
	}

	public static bool smethod_14(IntPtr intptr_4)
	{
		return (bool)new GClass59().method_8(new object[1] { intptr_4 }, 68097299);
	}

	public static IntPtr smethod_15(IntPtr intptr_4, UIntPtr uintptr_0, Enum3 enum3_0, Enum5 enum5_0)
	{
		return (IntPtr)new GClass59().method_8(new object[4] { intptr_4, uintptr_0, enum3_0, enum5_0 }, 49664253);
	}

	public static bool smethod_16()
	{
		return (bool)new GClass59().method_8(null, 68097681);
	}

	public static bool smethod_17(IntPtr intptr_4, UIntPtr uintptr_0, Enum4 enum4_0)
	{
		return (bool)new GClass59().method_8(new object[3] { intptr_4, uintptr_0, enum4_0 }, 49664468);
	}

	public static bool smethod_18(IntPtr intptr_4)
	{
		return (bool)new GClass59().method_8(new object[1] { intptr_4 }, 68107724);
	}

	static Class370()
	{
		new GClass59().method_8(null, 68100347);
	}
}
