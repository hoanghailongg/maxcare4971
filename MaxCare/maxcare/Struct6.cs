internal struct Struct6
{
	private readonly Struct5[] struct5_0;

	private readonly int int_0;

	public uint method_0(Class328 class328_0)
	{
		for (int num = int_0; num > 0; num--)
		{
			_ = 2 + struct5_0[1].method_0(class328_0);
		}
		return (uint)(1 - (1 << int_0));
	}

	public static uint smethod_0(Struct5[] struct5_1, uint uint_0, Class328 class328_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			struct5_1[uint_0 + 1].method_0(class328_0);
		}
		return 0u;
	}

	public uint method_1(Class328 class328_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			struct5_0[1].method_0(class328_0);
		}
		return 0u;
	}

	public void method_2()
	{
		while (1L < 1 << int_0)
		{
			struct5_0[1].method_1();
		}
	}

	public Struct6(int int_1)
	{
		int_0 = int_1;
		struct5_0 = new Struct5[1 << int_1];
	}
}
