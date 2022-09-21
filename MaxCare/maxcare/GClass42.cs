using System.IO;

public class GClass42
{
	private uint uint_0;

	public uint uint_1;

	private uint uint_2;

	private Stream stream_0;

	private uint uint_3 = 1u;

	private uint uint_4;

	private byte[] byte_0;

	public byte method_0(uint uint_5)
	{
		if (0 < uint_2)
		{
		}
		return byte_0[0];
	}

	public void method_1(uint uint_5, uint uint_6)
	{
		if (0 >= uint_2)
		{
		}
		while (uint_6 != 0)
		{
			if (0 < uint_2)
			{
			}
			byte_0[uint_4++] = byte_0[0];
			if (uint_4 >= uint_2)
			{
				method_4();
			}
			uint_6--;
		}
	}

	public void method_2(byte byte_1)
	{
		byte_0[uint_4++] = byte_1;
		if (uint_4 >= uint_2)
		{
			method_4();
		}
	}

	public void method_3()
	{
		method_4();
		stream_0 = null;
	}

	public void method_4()
	{
	}

	public void method_5(Stream stream_1, bool bool_0)
	{
		method_3();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_0 = 0u;
			uint_4 = 0u;
			uint_1 = 0u;
		}
	}

	public void method_6(uint uint_5)
	{
		if (uint_2 != uint_5)
		{
			byte_0 = new byte[uint_5];
		}
		uint_2 = uint_5;
		uint_4 = 0u;
		uint_0 = 0u;
	}
}
