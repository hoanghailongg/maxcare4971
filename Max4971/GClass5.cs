using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class GClass5 : GClass3
{
	private GEnum0 genum0_0 = GEnum0.const_2;

	public string method_9(string string_0, string string_1)
	{
		try
		{
			return smethod_0(method_10(string_0, string_1, genum0_0));
		}
		catch
		{
			return "null";
		}
	}

	public static string smethod_0(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	public string method_10(string string_0, string string_1, GEnum0 genum0_1)
	{
		method_0(genum0_1);
		byte[] bytes = base.Encoding_0.GetBytes(string_0);
		GStruct0 gstruct0_ = default(GStruct0);
		gstruct0_.byte_0 = new byte[1] { (byte)genum0_1 };
		gstruct0_.byte_1 = new byte[1] { (byte)genum5_0 };
		gstruct0_.byte_2 = method_12(8);
		gstruct0_.byte_3 = method_12(8);
		gstruct0_.byte_4 = method_12(16);
		byte[] byte_ = method_3(gstruct0_.byte_2, string_1);
		switch (genum1_0)
		{
		case GEnum1.const_1:
			gstruct0_.byte_6 = method_11(bytes, byte_, gstruct0_.byte_4);
			break;
		case GEnum1.const_0:
			gstruct0_.byte_6 = method_4(bytes, byte_, gstruct0_.byte_4);
			break;
		}
		gstruct0_.byte_5 = method_1(gstruct0_, string_1);
		List<byte> list = new List<byte>();
		list.AddRange(method_2(gstruct0_));
		list.AddRange(gstruct0_.byte_6);
		list.AddRange(gstruct0_.byte_5);
		return Convert.ToBase64String(list.ToArray());
	}

	private byte[] method_11(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = aes.CreateEncryptor(byte_1, byte_2);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
		}
		return memoryStream.ToArray();
	}

	private byte[] method_12(int int_1)
	{
		byte[] array = new byte[int_1];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}
}
