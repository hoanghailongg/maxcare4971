using System;

internal struct Struct2
{
	private int int_0;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal int Int32_0 => int_0 + 1;

	private int Int32_1
	{
		get
		{
			int num = 0;
			for (int num2 = int_0; num2 >= 0; num2--)
			{
				if (uint_1[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal Struct2(A5B97CB8 a5B97CB8_0, ref int int_1)
	{
		bool_0 = false;
		uint_1 = a5B97CB8_0.UInt32_0;
		int int32_ = a5B97CB8_0.Int32_1;
		int num = int32_ >> 31;
		int_1 = (int_1 ^ num) - num;
		if (uint_1 == null)
		{
			int_0 = 0;
			uint_0 = (uint)((int32_ ^ num) - num);
			return;
		}
		int_0 = uint_1.Length - 1;
		uint_0 = uint_1[0];
		while (int_0 > 0 && uint_1[int_0] == 0)
		{
			int_0--;
		}
	}

	internal void method_0(ref Struct2 struct2_0)
	{
		if (struct2_0.int_0 == 0)
		{
			method_10(smethod_0(ref this, struct2_0.uint_0));
		}
		else if (int_0 != 0)
		{
			Struct2 struct2_ = default(Struct2);
			smethod_2(ref this, ref struct2_0, bool_1: false, ref struct2_);
		}
	}

	private static uint smethod_0(ref Struct2 struct2_0, uint uint_2)
	{
		if (uint_2 == 1)
		{
			return 0u;
		}
		if (struct2_0.int_0 == 0)
		{
			return struct2_0.uint_0 % uint_2;
		}
		ulong num = 0uL;
		for (int num2 = struct2_0.int_0; num2 >= 0; num2--)
		{
			num = Class324.smethod_3((uint)num, struct2_0.uint_1[num2]);
			num %= uint_2;
		}
		return (uint)num;
	}

	private static uint smethod_1(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 + (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_1(int int_1, int int_2)
	{
		if (int_1 <= 1)
		{
			if (int_0 > 0)
			{
				uint_0 = uint_1[0];
			}
			int_0 = 0;
			return;
		}
		if (bool_0 && uint_1.Length >= int_1)
		{
			if (int_0 + 1 < int_1)
			{
				Array.Clear(uint_1, int_0 + 1, int_1 - int_0 - 1);
				if (int_0 == 0)
				{
					uint_1[0] = uint_0;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_1 + int_2];
			if (int_0 == 0)
			{
				array[0] = uint_0;
			}
			else
			{
				Array.Copy(uint_1, array, Math.Min(int_1, int_0 + 1));
			}
			uint_1 = array;
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_2(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			uint_0 = 0u;
			return;
		}
		if (bool_0 && uint_1.Length >= int_1)
		{
			Array.Clear(uint_1, 0, int_1);
		}
		else
		{
			uint_1 = new uint[int_1];
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	internal void method_3(ref Struct2 struct2_0, ref Struct2 struct2_1)
	{
		if (struct2_0.int_0 == 0)
		{
			if (struct2_1.int_0 == 0)
			{
				method_11((ulong)struct2_0.uint_0 * (ulong)struct2_1.uint_0);
				return;
			}
			method_4(ref struct2_1, 1);
			method_8(struct2_0.uint_0);
			return;
		}
		if (struct2_1.int_0 == 0)
		{
			method_4(ref struct2_0, 1);
			method_8(struct2_1.uint_0);
			return;
		}
		method_2(struct2_0.int_0 + struct2_1.int_0 + 2);
		uint[] array;
		int num;
		uint[] array2;
		int num2;
		if (struct2_0.Int32_1 <= struct2_1.Int32_1)
		{
			array = struct2_0.uint_1;
			num = struct2_0.int_0 + 1;
			array2 = struct2_1.uint_1;
			num2 = struct2_1.int_0 + 1;
		}
		else
		{
			array = struct2_1.uint_1;
			num = struct2_1.int_0 + 1;
			array2 = struct2_0.uint_1;
			num2 = struct2_0.int_0 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = array[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_3(ref uint_1[num5], num3, array2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = smethod_1(ref uint_1[num5++], 0u, num4);
				}
			}
		}
		method_7();
	}

	private void method_4(ref Struct2 struct2_0, int int_1)
	{
		if (struct2_0.int_0 == 0)
		{
			uint_0 = struct2_0.uint_0;
			int_0 = 0;
			return;
		}
		if (!bool_0 || uint_1.Length <= struct2_0.int_0)
		{
			uint_1 = new uint[struct2_0.int_0 + 1 + int_1];
			bool_0 = true;
		}
		int_0 = struct2_0.int_0;
		Array.Copy(struct2_0.uint_1, uint_1, int_0 + 1);
	}

	private static void smethod_2(ref Struct2 struct2_0, ref Struct2 struct2_1, bool bool_1, ref Struct2 struct2_2)
	{
		struct2_2.method_10(0u);
		if (struct2_0.int_0 < struct2_1.int_0)
		{
			return;
		}
		int num = struct2_1.int_0 + 1;
		int num2 = struct2_0.int_0 - struct2_1.int_0;
		int num3 = num2;
		int num4 = struct2_0.int_0;
		while (true)
		{
			if (num4 >= num2)
			{
				if (struct2_1.uint_1[num4 - num2] == struct2_0.uint_1[num4])
				{
					num4--;
					continue;
				}
				if (struct2_1.uint_1[num4 - num2] < struct2_0.uint_1[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (bool_1)
		{
			struct2_2.method_9(num3);
		}
		uint num5 = struct2_1.uint_1[num - 1];
		uint num6 = struct2_1.uint_1[num - 2];
		int num7 = Class324.smethod_0(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= struct2_1.uint_1[num - 3] >> num8;
			}
		}
		struct2_0.method_12();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= struct2_0.int_0) ? struct2_0.uint_1[num9 + num] : 0u);
			ulong num11 = Class324.smethod_3(num10, struct2_0.uint_1[num9 + num - 1]);
			uint num12 = struct2_0.uint_1[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= struct2_0.uint_1[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > Class324.smethod_3((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += struct2_1.uint_1[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (struct2_0.uint_1[num9 + i] < num16)
					{
						num15++;
					}
					struct2_0.uint_1[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint uint_ = 0u;
					for (int j = 0; j < num; j++)
					{
						uint_ = smethod_1(ref struct2_0.uint_1[num9 + j], struct2_1.uint_1[j], uint_);
					}
					num13--;
				}
				struct2_0.int_0 = num9 + num - 1;
			}
			if (bool_1)
			{
				if (num3 == 1)
				{
					struct2_2.uint_0 = (uint)num13;
				}
				else
				{
					struct2_2.uint_1[num9] = (uint)num13;
				}
			}
		}
		struct2_0.int_0 = num - 1;
		struct2_0.method_7();
	}

	internal A5B97CB8 method_5(int int_1)
	{
		method_6(int_1, out int_1, out var uint_);
		return new A5B97CB8(int_1, uint_);
	}

	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		ulong num = (ulong)((long)uint_3 * (long)uint_4 + uint_2 + uint_5);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	internal Struct2(int int_1)
	{
		int_0 = 0;
		uint_0 = 0u;
		if (int_1 > 1)
		{
			uint_1 = new uint[int_1];
			bool_0 = true;
		}
		else
		{
			uint_1 = null;
			bool_0 = false;
		}
	}

	private void method_6(int int_1, out int int_2, out uint[] uint_2)
	{
		if (int_0 == 0)
		{
			if (uint_0 <= int.MaxValue)
			{
				int_2 = int_1 * (int)uint_0;
				uint_2 = null;
				return;
			}
			if (uint_1 == null)
			{
				uint_1 = new uint[1] { uint_0 };
			}
			else if (bool_0)
			{
				uint_1[0] = uint_0;
			}
			else if (uint_1[0] != uint_0)
			{
				uint_1 = new uint[1] { uint_0 };
			}
		}
		int_2 = int_1;
		int num = uint_1.Length - int_0 - 1;
		if (num <= 1)
		{
			if (num == 0 || uint_1[int_0 + 1] == 0)
			{
				bool_0 = false;
				uint_2 = uint_1;
				return;
			}
			if (bool_0)
			{
				uint_1[int_0 + 1] = 0u;
				bool_0 = false;
				uint_2 = uint_1;
				return;
			}
		}
		uint_2 = uint_1;
		Array.Resize(ref uint_2, int_0 + 1);
		if (!bool_0)
		{
			uint_1 = uint_2;
		}
	}

	private void method_7()
	{
		if (int_0 > 0 && uint_1[int_0] == 0)
		{
			uint_0 = uint_1[0];
			while (--int_0 > 0 && uint_1[int_0] == 0)
			{
			}
		}
	}

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 * (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_8(uint uint_2)
	{
		switch (uint_2)
		{
		case 0u:
			method_10(0u);
			return;
		case 1u:
			return;
		}
		if (int_0 == 0)
		{
			method_11((ulong)uint_0 * (ulong)uint_2);
			return;
		}
		method_12(1);
		uint num = 0u;
		for (int i = 0; i <= int_0; i++)
		{
			num = smethod_4(ref uint_1[i], uint_2, num);
		}
		if (num != 0)
		{
			method_1(int_0 + 2, 0);
			uint_1[int_0] = num;
		}
	}

	private void method_9(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			return;
		}
		if (!bool_0 || uint_1.Length < int_1)
		{
			uint_1 = new uint[int_1];
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_10(uint uint_2)
	{
		uint_0 = uint_2;
		int_0 = 0;
	}

	private void method_11(ulong ulong_0)
	{
		uint num = Class324.smethod_5(ulong_0);
		if (num == 0)
		{
			uint_0 = Class324.smethod_7(ulong_0);
			int_0 = 0;
		}
		else
		{
			method_9(2);
			uint_1[0] = (uint)ulong_0;
			uint_1[1] = num;
		}
	}

	private void method_12(int int_1 = 0)
	{
		if (!bool_0)
		{
			uint[] destinationArray = new uint[int_0 + 1 + int_1];
			Array.Copy(uint_1, destinationArray, int_0 + 1);
			uint_1 = destinationArray;
			bool_0 = true;
		}
	}

	private void method_13(bool bool_1)
	{
	}
}
