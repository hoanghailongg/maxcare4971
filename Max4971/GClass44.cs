using System.Runtime.InteropServices;

public class GClass44
{
	private GClass52 gclass52_0;

	private GClass53 gclass53_0;

	private GClass58 gclass58_0;

	private GClass45 gclass45_0;

	public static readonly GClass44 gclass44_0;

	public GClass52 GClass52_0
	{
		get
		{
			return (GClass52)new GClass59().method_8(new object[1] { this }, 25343409);
		}
		private set
		{
			new GClass59().method_8(new object[2] { this, value }, 25342739);
		}
	}

	public GClass58 GClass58_0
	{
		get
		{
			return (GClass58)new GClass59().method_8(new object[1] { this }, 25355149);
		}
		private set
		{
			new GClass59().method_8(new object[2] { this, value }, 25335386);
		}
	}

	public GClass53 GClass53_0
	{
		get
		{
			return (GClass53)new GClass59().method_8(new object[1] { this }, 25347130);
		}
		private set
		{
			new GClass59().method_8(new object[2] { this, value }, 25345478);
		}
	}

	public GClass45 GClass45_0
	{
		get
		{
			return (GClass45)new GClass59().method_8(new object[1] { this }, 25361199);
		}
		private set
		{
			new GClass59().method_8(new object[2] { this, value }, 25341141);
		}
	}

	static GClass44()
	{
		new GClass59().method_8(null, 25339736);
	}

	public static void smethod_0(string string_0)
	{
		new GClass59().method_8(new object[1] { string_0 }, 25332892);
	}

	public static bool smethod_1(ref string string_0)
	{
		object[] array = new object[1] { string_0 };
		try
		{
			return (bool)new GClass59().method_8(array, 25339074);
		}
		finally
		{
			string_0 = (string)array[0];
		}
	}

	public static bool smethod_2()
	{
		return (bool)new GClass59().method_8(null, 25337860);
	}

	public unsafe static bool smethod_3()
	{
		if (!GClass51.smethod_9())
		{
			long num = Marshal.GetHINSTANCE(typeof(GClass44).Module).ToInt64();
			uint num2 = *(uint*)(num + 25360389L);
			uint num3 = 25335983u;
			bool result = true;
			GClass48 gClass = new GClass48();
			if (*(uint*)(num + 25359283L) != gClass.method_0(num + 25335983L, num2))
			{
				result = false;
			}
			GClass49 gClass2 = new GClass49();
			for (int i = 0; i < num2; i += 12)
			{
				uint* ptr = (uint*)(num + num3 + i);
				uint num4 = gClass2.method_0(*ptr);
				uint uint_ = gClass2.method_0(ptr[1]);
				uint num5 = gClass2.method_0(ptr[2]);
				if (gClass.method_0(num + num4, uint_) != num5)
				{
					result = false;
				}
			}
			num2 = GClass51.smethod_0();
			uint num6 = *(uint*)(num + num2 + 4L);
			uint num7 = *(uint*)(num + num2 + 8L);
			if (num6 != 0)
			{
				Class371.Struct16* ptr2 = (Class371.Struct16*)num;
				if (ptr2->ushort_0 == 23117)
				{
					uint uint_2 = ptr2->uint_0;
					Class371.Struct18* ptr3 = (Class371.Struct18*)(num + uint_2);
					if (ptr3->uint_0 == 17744)
					{
						uint_2 += (uint)Marshal.SizeOf(typeof(Class371.Struct18));
						ushort num8 = *(ushort*)(num + uint_2);
						if (num8 != 267 && num8 == 523)
						{
							goto IL_016e;
						}
					}
				}
			}
			num2 = *(uint*)(num + num2);
			num3 = GClass51.smethod_7();
			if (*(uint*)(num + GClass51.smethod_3()) != gClass.method_0(num + num3, num2))
			{
				result = false;
			}
			GClass49 gClass3 = new GClass49();
			for (int j = 0; j < num2; j += 12)
			{
				uint* ptr4 = (uint*)(num + num3 + j);
				uint num9 = gClass3.method_0(*ptr4);
				uint uint_3 = gClass3.method_0(ptr4[1]);
				uint num10 = gClass3.method_0(ptr4[2]);
				if ((num9 < num6 || num9 >= num7) && gClass.method_0(num + num9, uint_3) != num10)
				{
					result = false;
				}
			}
			return result;
		}
		goto IL_016e;
		IL_016e:
		return false;
	}

	public GClass44()
	{
		new GClass59().method_8(new object[1] { this }, 25352500);
	}

	private static void smethod_4()
	{
		new GClass59().method_8(null, 25349523);
	}

	internal static bool smethod_5(byte[] byte_0)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (num + 3 >= byte_0.Length || byte_0[num] != 81 || byte_0[num + 1] != 69 || byte_0[num + 2] != 77 || byte_0[num + 3] != 85)
				{
					if (num + 8 >= byte_0.Length || byte_0[num] != 77 || byte_0[num + 1] != 105 || byte_0[num + 2] != 99 || byte_0[num + 3] != 114 || byte_0[num + 4] != 111 || byte_0[num + 5] != 115 || byte_0[num + 6] != 111 || byte_0[num + 7] != 102 || byte_0[num + 8] != 116)
					{
						if (num + 5 >= byte_0.Length || byte_0[num] != 104 || byte_0[num + 1] != 110 || byte_0[num + 2] != 110 || byte_0[num + 3] != 111 || byte_0[num + 4] != 116 || byte_0[num + 5] != 101 || byte_0[num + 6] != 107)
						{
							if (num + -447643275 >= byte_0.Length)
							{
							}
							if (num + 5 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 77 || byte_0[num + 2] != 119 || byte_0[num + 3] != 97 || byte_0[num + 4] != 114 || byte_0[num + 5] != 101)
							{
								if (num + 8 < byte_0.Length && byte_0[num] == 80 && byte_0[num + 1] == 97 && byte_0[num + 2] == 114 && byte_0[num + 3] == 97 && byte_0[num + 4] == 108 && byte_0[num + 5] == 108 && byte_0[num + 6] == 101 && byte_0[num + 7] == 108 && byte_0[num + 8] == 115)
								{
									break;
								}
								num++;
								continue;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static string smethod_6(uint uint_0)
	{
		return (string)new GClass59().method_8(new object[1] { uint_0 }, 25360629);
	}

	public static bool smethod_7(bool bool_0)
	{
		return (bool)new GClass59().method_8(new object[1] { bool_0 }, 25352849);
	}
}
