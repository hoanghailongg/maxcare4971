using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class GClass53
{
	public class GClass54
	{
		[Serializable]
		private sealed class F3D4585C
		{
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public static readonly F3D4585C f3D4585C_0 = new F3D4585C();

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		private string string_0;

		private string string_1;

		public string String_0
		{
			get
			{
				return string_1;
			}
			private set
			{
				string_1 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_0;
			}
			private set
			{
				string_0 = value;
			}
		}

		private void method_0(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(String_0);
				foreach (char c in string_2)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				String_0 = stringBuilder.ToString();
			}
			else
			{
				String_0 += string_2;
			}
		}

		protected void method_1()
		{
			String_0 = Convert.ToBase64String(Encoding.UTF8.GetBytes(String_0));
		}

		protected void method_2(string string_2, string string_3)
		{
			method_0(string_2, bool_0: false);
			method_0(string_3, bool_0: true);
		}

		protected bool method_3(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			String_0 = Encoding.UTF8.GetString(byte_0, index, num);
			if (String_0[String_0.Length - 1] != '/')
			{
				String_0 += "/";
			}
			return true;
		}
	}

	public class GClass55 : GClass54
	{
		private string string_2;
	}

	public class GClass56 : GClass54
	{
	}

	private uint uint_0;

	private int int_0;

	private GEnum11 genum11_0;

	private long long_0;

	private byte[] byte_0;

	private readonly int int_1;

	private readonly object object_0;

	private readonly byte[] byte_1;

	public GClass53(byte[] byte_2)
	{
		new GClass59().method_8(new object[2] { this, byte_2 }, 25338503);
	}

	public GClass53(long long_1)
	{
		new GClass59().method_8(new object[2] { this, long_1 }, 25346231);
	}
}
