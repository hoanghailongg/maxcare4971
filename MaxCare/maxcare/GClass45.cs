using System;
using System.Collections.Generic;
using System.Reflection;

public class GClass45
{
	private readonly Dictionary<string, uint> dictionary_0;

	private GClass47 gclass47_0;

	private long long_0;

	private void method_0(ref byte[] byte_0, uint uint_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ (GClass50.smethod_2(uint_0, i) + i));
		}
	}

	private Assembly method_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return (Assembly)new GClass59().method_8(new object[3] { this, object_0, resolveEventArgs_0 }, 25361548);
	}

	public GClass45(long long_1)
	{
		new GClass59().method_8(new object[2] { this, long_1 }, 25344846);
	}
}
