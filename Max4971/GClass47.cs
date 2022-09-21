using System;
using System.Runtime.InteropServices;

public class GClass47
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct7
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public uint uint_1;
	}

	private readonly uint[] uint_0;

	public void method_0(byte[] byte_0, byte[] byte_1)
	{
		Struct7 struct7_ = default(Struct7);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			struct7_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			method_3(ref struct7_);
			BitConverter.GetBytes(struct7_.ulong_0).CopyTo(byte_1, i);
		}
	}

	public byte[] method_1(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_2(byte_0, array);
		return array;
	}

	public void method_2(byte[] byte_0, byte[] byte_1)
	{
		Struct7 struct7_ = default(Struct7);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			struct7_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			method_5(ref struct7_);
			BitConverter.GetBytes(struct7_.ulong_0).CopyTo(byte_1, i);
		}
	}

	private void method_3(ref Struct7 struct7_0)
	{
		uint num = struct7_0.uint_1;
		uint num2 = struct7_0.uint_0;
		while (true)
		{
			num = GClass50.smethod_1(num - uint_0[31], (int)num2) ^ num2;
			num2 = GClass50.smethod_1(num2 - uint_0[30], (int)num) ^ num;
		}
	}

	public byte[] method_4(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_0(byte_0, array);
		return array;
	}

	private void method_5(ref Struct7 struct7_0)
	{
		uint num = struct7_0.uint_0 + uint_0[0];
		uint num2 = struct7_0.uint_1 + uint_0[1];
		while (true)
		{
			num = GClass50.smethod_2(num ^ num2, (int)num2) + uint_0[2];
			num2 = GClass50.smethod_2(num2 ^ num, (int)num) + uint_0[3];
		}
	}

	public GClass47(byte[] byte_0)
	{
		uint num = 4u;
		uint[] array = new uint[2];
		uint_0 = new uint[32];
		array[1] = 0u;
		while (true)
		{
			array[0u / num] = (array[0u / num] << 8) + byte_0[0];
		}
	}
}
