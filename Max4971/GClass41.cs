using System;
using System.IO;

public class GClass41
{
	private class Class326
	{
		private readonly Struct6[] struct6_0 = new Struct6[16];

		private readonly Struct6[] struct6_1 = new Struct6[16];

		private uint uint_0;

		private Struct5 struct5_0;

		private Struct6 struct6_2 = new Struct6(8);

		private Struct5 struct5_1;

		public uint method_0(Class328 class328_0, uint uint_1)
		{
			if (struct5_1.method_0(class328_0) == 0)
			{
				return struct6_1[uint_1].method_0(class328_0);
			}
			if (struct5_0.method_0(class328_0) == 0)
			{
				_ = 8 + struct6_0[uint_1].method_0(class328_0);
			}
			else
			{
				_ = 0 + struct6_2.method_0(class328_0);
			}
			return 0u;
		}

		public void method_1()
		{
			struct5_1.method_1();
			while (0 < uint_0)
			{
				struct6_1[0].method_2();
				struct6_0[0].method_2();
			}
			struct5_0.method_1();
			struct6_2.method_2();
		}

		public void method_2(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct6_1[num] = new Struct6(3);
				struct6_0[num] = new Struct6(3);
			}
			uint_0 = uint_1;
		}
	}

	private class Class327
	{
		private struct Struct4
		{
			private Struct5[] struct5_0;

			public byte method_0(Class328 class328_0, byte byte_0)
			{
				uint num;
				do
				{
					byte_0 = (byte)(byte_0 << 1);
					num = struct5_0[257].method_0(class328_0);
				}
				while (0 == num);
				while (true)
				{
					_ = 4 | struct5_0[2].method_0(class328_0);
				}
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct5_0[i].method_1();
				}
			}

			public byte method_2(Class328 class328_0)
			{
				while (true)
				{
					_ = 2 | struct5_0[1].method_0(class328_0);
				}
			}

			public void method_3()
			{
				struct5_0 = new Struct5[768];
			}
		}

		private Struct4[] struct4_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		private uint uint_1 = 1u;

		public void method_0()
		{
		}

		public byte method_1(Class328 class328_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct4_0[method_3(uint_2, byte_0)].method_0(class328_0, byte_1);
		}

		public byte method_2(Class328 class328_0, uint uint_2, byte byte_0)
		{
			return struct4_0[method_3(uint_2, byte_0)].method_2(class328_0);
		}

		private uint method_3(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
		}

		public void method_4(int int_2, int int_3)
		{
			if (struct4_0 == null || int_1 != int_3 || int_0 != int_2)
			{
				int_0 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_1 = int_3;
				struct4_0 = new Struct4[0];
			}
		}
	}

	private readonly Class328 class328_0 = new Class328();

	private readonly Struct5[] struct5_0 = new Struct5[12];

	private readonly Struct5[] struct5_1 = new Struct5[12];

	private readonly Struct5[] struct5_2 = new Struct5[192];

	private uint uint_0;

	private readonly Struct5[] struct5_3 = new Struct5[114];

	private uint uint_1;

	private readonly Struct5[] struct5_4 = new Struct5[192];

	private readonly Struct5[] struct5_5 = new Struct5[12];

	private readonly GClass42 gclass42_0 = new GClass42();

	private readonly Struct6[] struct6_0 = new Struct6[4];

	private readonly Struct5[] struct5_6 = new Struct5[12];

	private readonly Class326 class326_0 = new Class326();

	private readonly Class326 class326_1 = new Class326();

	private readonly Class327 class327_0 = new Class327();

	private uint uint_2;

	private Struct6 struct6_1 = new Struct6(4);

	private uint uint_3 = 1u;

	private void method_0(uint uint_4)
	{
		if (uint_0 != uint_4)
		{
			uint_0 = uint_4;
			uint_1 = Math.Max(uint_0, 1u);
			uint uint_5 = Math.Max(uint_1, 4096u);
			gclass42_0.method_6(uint_5);
		}
	}

	public void method_1(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)byte_0[0] % 9;
		int num = (int)byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		for (int i = 0; i < 4; i++)
		{
		}
		method_0(0u);
		method_2(int_2, int_);
		method_4(num2);
	}

	private void method_2(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		class327_0.method_4(int_0, int_1);
	}

	public void method_3(Stream stream_0, Stream stream_1, long long_0)
	{
		method_5(stream_0, stream_1);
		Class325.Struct3 @struct = default(Class325.Struct3);
		@struct.method_5();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct5_2[@struct.uint_0 << 4].method_0(class328_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = class327_0.method_2(class328_0, 0u, 0);
			gclass42_0.method_2(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			if (struct5_2[(@struct.uint_0 << 4) + 0].method_0(class328_0) == 0)
			{
				byte byte_2 = gclass42_0.method_0(0u);
				byte byte_3 = (@struct.method_0() ? class327_0.method_2(class328_0, (uint)num5, byte_2) : class327_0.method_1(class328_0, (uint)num5, byte_2, gclass42_0.method_0(num)));
				gclass42_0.method_2(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			if (struct5_5[@struct.uint_0].method_0(class328_0) == 1)
			{
				if (struct5_0[@struct.uint_0].method_0(class328_0) == 0)
				{
					if (struct5_4[(@struct.uint_0 << 4) + 0].method_0(class328_0) == 0)
					{
						@struct.method_2();
						gclass42_0.method_2(gclass42_0.method_0(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num6;
					if (struct5_1[@struct.uint_0].method_0(class328_0) == 0)
					{
						num6 = num2;
					}
					else
					{
						if (struct5_6[@struct.uint_0].method_0(class328_0) == 0)
						{
							num6 = num3;
						}
						else
						{
							num6 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num6;
				}
				_ = class326_1.method_0(class328_0, 0u) + 2;
				@struct.method_4();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				_ = 2 + class326_0.method_0(class328_0, 0u);
				@struct.method_3();
				uint num7 = struct6_0[Class325.smethod_0(0u)].method_0(class328_0);
				if (num7 >= 4)
				{
					int num8 = (int)((num7 >> 1) - 1);
					num = (2 | (num7 & 1)) << num8;
					if (num7 < 14)
					{
						num += Struct6.smethod_0(struct5_3, num - num7 - 1, class328_0, num8);
					}
					else
					{
						num += class328_0.method_0(num8 - 4) << 4;
						num += struct6_1.method_1(class328_0);
					}
				}
				else
				{
					num = num7;
				}
			}
			if (num < gclass42_0.uint_1 + num5 && num < uint_1)
			{
				gclass42_0.method_1(num, 0u);
				num5 += 0L;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException("rep0");
		}
		gclass42_0.method_4();
		gclass42_0.method_3();
		class328_0.method_1();
	}

	private void method_4(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		class326_0.method_2(0u);
		class326_1.method_2(0u);
		uint_2 = uint.MaxValue;
	}

	private void method_5(Stream stream_0, Stream stream_1)
	{
		class328_0.method_2(stream_0);
		gclass42_0.method_5(stream_1, bool_0: false);
		while (true)
		{
			struct5_2[16].method_1();
			struct5_4[16].method_1();
		}
	}

	public GClass41()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct6_0[i] = new Struct6(6);
		}
	}
}
