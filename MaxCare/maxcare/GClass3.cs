using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

public abstract class GClass3
{
	protected GEnum1 genum1_0;

	protected GEnum5 genum5_0;

	protected bool bool_0;

	protected bool bool_1;

	protected GEnum3 genum3_0;

	protected const GEnum4 genum4_0 = GEnum4.const_0;

	protected const short short_0 = 8;

	protected const short short_1 = 16;

	protected const GEnum2 genum2_0 = GEnum2.const_0;

	protected const int int_0 = 10000;

	protected const short short_2 = 32;

	protected const short short_3 = 32;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Encoding encoding_0;

	public Encoding Encoding_0
	{
		[CompilerGenerated]
		get
		{
			return encoding_0;
		}
		[CompilerGenerated]
		set
		{
			encoding_0 = value;
		}
	}

	public GClass3()
	{
		Encoding_0 = Encoding.UTF8;
	}

	protected void method_0(GEnum0 genum0_0)
	{
		switch (genum0_0)
		{
		case GEnum0.const_0:
			genum1_0 = GEnum1.const_0;
			genum5_0 = GEnum5.const_0;
			bool_0 = false;
			bool_1 = true;
			genum3_0 = GEnum3.const_0;
			break;
		case GEnum0.const_1:
			genum1_0 = GEnum1.const_1;
			genum5_0 = GEnum5.const_1;
			bool_0 = false;
			bool_1 = false;
			genum3_0 = GEnum3.const_1;
			break;
		case GEnum0.const_2:
		case GEnum0.const_3:
			genum1_0 = GEnum1.const_1;
			genum5_0 = GEnum5.const_1;
			bool_0 = true;
			bool_1 = false;
			genum3_0 = GEnum3.const_1;
			break;
		}
	}

	protected byte[] method_1(GStruct0 gstruct0_0, string string_0)
	{
		List<byte> list = new List<byte>();
		if (bool_0)
		{
			list.AddRange(method_2(gstruct0_0));
		}
		list.AddRange(gstruct0_0.byte_6);
		byte[] key = method_3(gstruct0_0.byte_3, string_0);
		HMAC hMAC = null;
		switch (genum3_0)
		{
		case GEnum3.const_1:
			hMAC = new HMACSHA256(key);
			break;
		case GEnum3.const_0:
			hMAC = new HMACSHA1(key);
			break;
		}
		List<byte> list2 = new List<byte>();
		list2.AddRange(hMAC.ComputeHash(list.ToArray()));
		if (bool_1)
		{
			for (int i = list2.Count; i < 32; i++)
			{
				list2.Add(0);
			}
		}
		return list2.ToArray();
	}

	protected byte[] method_2(GStruct0 gstruct0_0)
	{
		List<byte> list = new List<byte>();
		list.AddRange(gstruct0_0.byte_0);
		list.AddRange(gstruct0_0.byte_1);
		list.AddRange(gstruct0_0.byte_2);
		list.AddRange(gstruct0_0.byte_3);
		list.AddRange(gstruct0_0.byte_4);
		return list.ToArray();
	}

	protected byte[] method_3(byte[] byte_0, string string_0)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, byte_0, 10000);
		return rfc2898DeriveBytes.GetBytes(32);
	}

	protected byte[] method_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] byte_3 = method_5(byte_0.Length, byte_2);
		byte[] byte_4 = method_6(byte_3, byte_1);
		return method_7(byte_0, byte_4);
	}

	private byte[] method_5(int int_1, byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		byte_0.CopyTo(array, 0);
		int num = (int)Math.Ceiling((decimal)int_1 / (decimal)byte_0.Length);
		List<byte> list = new List<byte>();
		for (int i = 0; i < num; i++)
		{
			list.AddRange(array);
			array[0]++;
		}
		return list.ToArray();
	}

	private byte[] method_6(byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.ECB;
		aes.Padding = PaddingMode.None;
		ICryptoTransform transform = aes.CreateEncryptor(byte_1, null);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
		}
		return memoryStream.ToArray();
	}

	private byte[] method_7(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length];
		ulong num = (ulong)byte_1.Length;
		ulong num2 = (ulong)byte_0.Length;
		ulong num3 = 0uL;
		for (ulong num4 = 0uL; num4 < num2; num4++)
		{
			array[num4] = (byte)(byte_0[num4] ^ byte_1[num3]);
			num3 = ((++num3 < num) ? num3 : 0uL);
		}
		return array;
	}

	protected string method_8(byte[] byte_0)
	{
		string text = "";
		foreach (byte b in byte_0)
		{
			text += $"{b:x2}";
		}
		return text;
	}
}
