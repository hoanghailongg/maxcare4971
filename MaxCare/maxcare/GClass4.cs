using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class GClass4 : GClass3
{
	public string method_9(string string_0, string string_1)
	{
		try
		{
			GStruct0 gstruct0_ = method_11(string_0);
			if (!method_12(gstruct0_, string_1))
			{
				return "";
			}
			byte[] byte_ = method_3(gstruct0_.byte_2, string_1);
			byte[] bytes = new byte[0];
			switch (genum1_0)
			{
			case GEnum1.const_1:
				bytes = method_10(gstruct0_.byte_6, byte_, gstruct0_.byte_4);
				break;
			case GEnum1.const_0:
				bytes = method_4(gstruct0_.byte_6, byte_, gstruct0_.byte_4);
				break;
			}
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return "null";
		}
	}

	private byte[] method_10(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = aes.CreateDecryptor(byte_1, byte_2);
		string s;
		using (MemoryStream stream = new MemoryStream(byte_0))
		{
			using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream2);
			s = streamReader.ReadToEnd();
		}
		return base.Encoding_0.GetBytes(s);
	}

	private GStruct0 method_11(string string_0)
	{
		List<byte> list = new List<byte>();
		list.AddRange(Convert.FromBase64String(string_0));
		int num = 0;
		GStruct0 result = default(GStruct0);
		result.byte_0 = list.GetRange(0, 1).ToArray();
		num = 1;
		method_0((GEnum0)list[0]);
		result.byte_1 = list.GetRange(1, 1).ToArray();
		num = 2;
		result.byte_2 = list.GetRange(2, 8).ToArray();
		num = 2 + result.byte_2.Length;
		result.byte_3 = list.GetRange(num, 8).ToArray();
		num += result.byte_3.Length;
		result.byte_4 = list.GetRange(num, 16).ToArray();
		num = (result.int_0 = num + result.byte_4.Length);
		result.byte_6 = list.GetRange(num, list.Count - 32 - result.int_0).ToArray();
		num += result.byte_6.Length;
		result.byte_5 = list.GetRange(num, 32).ToArray();
		return result;
	}

	private bool method_12(GStruct0 gstruct0_0, string string_0)
	{
		byte[] array = method_1(gstruct0_0, string_0);
		if (array.Length != gstruct0_0.byte_5.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < gstruct0_0.byte_5.Length)
			{
				if (array[num] != gstruct0_0.byte_5[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
