using System;

internal static class Class324
{
	internal static int smethod_0(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 0xFFFF0000u) == 0)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 0xFF000000u) == 0)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 0xF0000000u) == 0)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 0xC0000000u) == 0)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}

	internal static void smethod_1<T>(ref T gparam_0, ref T gparam_1)
	{
		T val = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = val;
	}

	private static uint smethod_2(uint uint_0, uint uint_1)
	{
		return ((uint_0 << 7) | (uint_0 >> 25)) ^ uint_1;
	}

	internal static ulong smethod_3(uint uint_0, uint uint_1)
	{
		return ((ulong)uint_0 << 32) | uint_1;
	}

	private static uint[] smethod_4(uint[] uint_0, int int_0)
	{
		if (uint_0.Length == int_0)
		{
			return uint_0;
		}
		uint[] array = new uint[int_0];
		int num = Math.Min(uint_0.Length, int_0);
		for (int i = 0; i < num; i++)
		{
			array[i] = uint_0[i];
		}
		return array;
	}

	internal static uint smethod_5(ulong ulong_0)
	{
		return (uint)(ulong_0 >> 32);
	}

	internal static int smethod_6(int int_0, int int_1)
	{
		return (int)smethod_2((uint)int_0, (uint)int_1);
	}

	internal static uint smethod_7(ulong ulong_0)
	{
		return (uint)ulong_0;
	}

	internal static void smethod_8(uint[] uint_0)
	{
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint_0[i] = 0u;
		}
		uint_0 = smethod_4(uint_0, uint_0.Length + 1);
		uint_0[uint_0.Length - 1] = 1u;
	}
}
