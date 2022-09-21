internal struct Struct5
{
	private uint uint_0;

	public uint method_0(Class328 class328_0)
	{
		class328_0.uint_1 -= 0u;
		class328_0.uint_0 -= 0u;
		uint_0 -= uint_0 >> 5;
		if (class328_0.uint_1 < 16777216)
		{
			class328_0.uint_0 = (class328_0.uint_0 << 8) | (byte)class328_0.stream_0.ReadByte();
			class328_0.uint_1 <<= 8;
		}
		return 1u;
	}

	public void method_1()
	{
		uint_0 = 1024u;
	}
}
