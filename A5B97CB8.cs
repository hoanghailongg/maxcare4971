using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct A5B97CB8
{
	private readonly int int_0;

	private readonly uint[] uint_0;

	private static readonly A5B97CB8 a5B97CB8_0 = new A5B97CB8(-1, new uint[1] { 2147483648u });

	private static readonly A5B97CB8 a5B97CB8_1 = new A5B97CB8(1);

	private static readonly A5B97CB8 a5B97CB8_2 = new A5B97CB8(0);

	private static readonly A5B97CB8 a5B97CB8_3 = new A5B97CB8(-1);

	private static A5B97CB8 A5B97CB8_0 => a5B97CB8_1;

	private bool Boolean_0
	{
		get
		{
			if (uint_0 != null)
			{
				return (uint_0[0] & 1) == 0;
			}
			return (int_0 & 1) == 0;
		}
	}

	private int Int32_0 => (int_0 >> 31) - (-int_0 >> 31);

	internal int Int32_1 => int_0;

	internal uint[] UInt32_0 => uint_0;

	private static void smethod_0(uint uint_1, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_1 & 1) == 1)
			{
				smethod_10(ref struct2_0, ref struct2_1, ref struct2_2, ref struct2_3);
			}
			smethod_8(ref struct2_1, ref struct2_2, ref struct2_3);
			uint_1 >>= 1;
		}
	}

	internal A5B97CB8(int int_1, uint[] uint_1)
	{
		int_0 = int_1;
		uint_0 = uint_1;
	}

	[SpecialName]
	public static bool smethod_1(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return a5B97CB8_4.method_0(a5B97CB8_5) >= 0;
	}

	internal static A5B97CB8 smethod_2(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5, A5B97CB8 a5B97CB8_6)
	{
		if (a5B97CB8_5.Int32_0 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = a5B97CB8_5.Boolean_0;
		Struct2 struct2_ = new Struct2(A5B97CB8_0, ref int_);
		Struct2 struct2_2 = new Struct2(a5B97CB8_4, ref int_2);
		Struct2 struct2_3 = new Struct2(a5B97CB8_6, ref int_3);
		Struct2 struct2_4 = new Struct2(struct2_2.Int32_0);
		struct2_.method_0(ref struct2_3);
		if (a5B97CB8_5.uint_0 == null)
		{
			smethod_12((uint)a5B97CB8_5.int_0, ref struct2_, ref struct2_2, ref struct2_3, ref struct2_4);
		}
		else
		{
			int num = smethod_11(a5B97CB8_5.uint_0);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_0(a5B97CB8_5.uint_0[i], ref struct2_, ref struct2_2, ref struct2_3, ref struct2_4);
			}
			smethod_12(a5B97CB8_5.uint_0[num - 1], ref struct2_, ref struct2_2, ref struct2_3, ref struct2_4);
		}
		return struct2_.method_5((a5B97CB8_4.int_0 > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	private static int smethod_3(uint[] uint_1, uint[] uint_2, int int_1)
	{
		int num = int_1;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_1[num] == uint_2[num]);
		return num + 1;
	}

	[SpecialName]
	public static bool smethod_4(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return !a5B97CB8_4.Equals(a5B97CB8_5);
	}

	[SpecialName]
	public static bool smethod_5(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return a5B97CB8_4.method_0(a5B97CB8_5) <= 0;
	}

	[SpecialName]
	public static bool smethod_6(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return a5B97CB8_4.method_0(a5B97CB8_5) > 0;
	}

	[SpecialName]
	public static bool smethod_7(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return a5B97CB8_4.method_0(a5B97CB8_5) < 0;
	}

	private int method_0(A5B97CB8 a5B97CB8_4)
	{
		if ((int_0 ^ a5B97CB8_4.int_0) < 0)
		{
			if (int_0 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_0 == null)
		{
			if (a5B97CB8_4.uint_0 == null)
			{
				if (int_0 >= a5B97CB8_4.int_0)
				{
					if (int_0 <= a5B97CB8_4.int_0)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -a5B97CB8_4.int_0;
		}
		int num;
		int num2;
		if (a5B97CB8_4.uint_0 != null && (num = smethod_11(uint_0)) <= (num2 = smethod_11(a5B97CB8_4.uint_0)))
		{
			if (num < num2)
			{
				return -int_0;
			}
			int num3 = smethod_3(uint_0, a5B97CB8_4.uint_0, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_0[num3 - 1] >= a5B97CB8_4.uint_0[num3 - 1])
			{
				return int_0;
			}
			return -int_0;
		}
		return int_0;
	}

	private static void smethod_8(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2)
	{
		Class324.smethod_1(ref struct2_0, ref struct2_2);
		struct2_0.method_3(ref struct2_2, ref struct2_2);
		struct2_0.method_0(ref struct2_1);
	}

	[SpecialName]
	public static bool smethod_9(A5B97CB8 a5B97CB8_4, A5B97CB8 a5B97CB8_5)
	{
		return a5B97CB8_4.Equals(a5B97CB8_5);
	}

	internal A5B97CB8(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 0x80) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			int_0 = 0;
			uint_0 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				int_0 = -1;
			}
			else
			{
				int_0 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				int_0 <<= 8;
				int_0 |= byte_0[num2];
			}
			uint_0 = null;
			if (int_0 < 0 && !flag)
			{
				uint_0 = new uint[1];
				uint_0[0] = (uint)int_0;
				int_0 = 1;
			}
			if (int_0 == int.MinValue)
			{
				this = a5B97CB8_0;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
			}
		}
		if (flag2)
		{
			this = a5B97CB8_2;
		}
		else if (flag)
		{
			Class324.smethod_8(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = a5B97CB8_3;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = a5B97CB8_0;
					return;
				}
				int_0 = -1 * (int)array[0];
				uint_0 = null;
			}
			else if (num6 != array.Length)
			{
				int_0 = -1;
				uint_0 = new uint[num6];
				Array.Copy(array, uint_0, num6);
			}
			else
			{
				int_0 = -1;
				uint_0 = array;
			}
		}
		else
		{
			int_0 = 1;
			uint_0 = array;
		}
	}

	private A5B97CB8(int int_1)
	{
		if (int_1 == int.MinValue)
		{
			this = a5B97CB8_0;
			return;
		}
		int_0 = int_1;
		uint_0 = null;
	}

	private static void smethod_10(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3)
	{
		Class324.smethod_1(ref struct2_0, ref struct2_3);
		struct2_0.method_3(ref struct2_3, ref struct2_1);
		struct2_0.method_0(ref struct2_2);
	}

	private static int smethod_11(uint[] uint_1)
	{
		int num = uint_1.Length;
		if (uint_1[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is A5B97CB8))
		{
			return false;
		}
		return Equals((A5B97CB8)obj);
	}

	internal byte[] method_1()
	{
		if (uint_0 == null && int_0 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (uint_0 == null)
		{
			array = new uint[1] { (uint)int_0 };
			b = (byte)((int_0 < 0) ? 255u : 0u);
		}
		else if (int_0 == -1)
		{
			array = (uint[])uint_0.Clone();
			Class324.smethod_8(array);
			b = byte.MaxValue;
		}
		else
		{
			array = uint_0;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	public override int GetHashCode()
	{
		if (uint_0 == null)
		{
			return int_0;
		}
		int result = int_0;
		int num = smethod_11(uint_0);
		while (--num >= 0)
		{
			result = Class324.smethod_6(result, (int)uint_0[num]);
		}
		return result;
	}

	private static void smethod_12(uint uint_1, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3)
	{
		while (uint_1 != 0)
		{
			if ((uint_1 & 1) == 1)
			{
				smethod_10(ref struct2_0, ref struct2_1, ref struct2_2, ref struct2_3);
			}
			if (uint_1 != 1)
			{
				smethod_8(ref struct2_1, ref struct2_2, ref struct2_3);
				uint_1 >>= 1;
				continue;
			}
			break;
		}
	}

	private void method_2()
	{
		if (uint_0 != null)
		{
			smethod_11(uint_0);
		}
	}
}
