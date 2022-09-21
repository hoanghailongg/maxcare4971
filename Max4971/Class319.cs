using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class Class319
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A52078E5
	{
		public static readonly A52078E5 _003C_003E9 = new A52078E5();

		public static Func<KeyValuePair<string, object>, Class0<KeyValuePair<string, object>, string>> _003C_003E9__3_0;

		public static Func<Class0<KeyValuePair<string, object>, string>, Class1<Class0<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_1;

		public static Func<Class1<Class0<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_2;

		public static Func<Class1<Class0<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_3;

		public static Func<KeyValuePair<string, object>, Class0<KeyValuePair<string, object>, string>> _003C_003E9__3_4;

		public static Func<Class0<KeyValuePair<string, object>, string>, Class1<Class0<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_5;

		public static Func<Class1<Class0<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_6;

		public static Func<Class1<Class0<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_7;

		public static Func<JToken, object> _003C_003E9__3_10;

		internal Class0<KeyValuePair<string, object>, string> method_0(KeyValuePair<string, object> keyValuePair_0)
		{
			KeyValuePair<string, object> keyValuePair = keyValuePair_0;
			return new Class0<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
		}

		internal Class1<Class0<KeyValuePair<string, object>, string>, object> method_1(Class0<KeyValuePair<string, object>, string> class0_0)
		{
			return new Class1<Class0<KeyValuePair<string, object>, string>, object>(class0_0, class0_0.Prop_0.Value);
		}

		internal bool method_2(Class1<Class0<KeyValuePair<string, object>, string>, object> class1_0)
		{
			return class1_0.Prop_1.GetType() == typeof(JObject);
		}

		internal string method_3(Class1<Class0<KeyValuePair<string, object>, string>, object> class1_0)
		{
			return class1_0.Prop_0.Prop_1;
		}

		internal Class0<KeyValuePair<string, object>, string> method_4(KeyValuePair<string, object> keyValuePair_0)
		{
			KeyValuePair<string, object> keyValuePair = keyValuePair_0;
			return new Class0<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
		}

		internal Class1<Class0<KeyValuePair<string, object>, string>, object> method_5(Class0<KeyValuePair<string, object>, string> class0_0)
		{
			return new Class1<Class0<KeyValuePair<string, object>, string>, object>(class0_0, class0_0.Prop_0.Value);
		}

		internal bool method_6(Class1<Class0<KeyValuePair<string, object>, string>, object> class1_0)
		{
			return class1_0.Prop_1.GetType() == typeof(JArray);
		}

		internal string method_7(Class1<Class0<KeyValuePair<string, object>, string>, object> class1_0)
		{
			return class1_0.Prop_0.Prop_1;
		}

		internal object method_8(JToken jtoken_0)
		{
			return ((JValue)jtoken_0).Value;
		}
	}

	[CompilerGenerated]
	private sealed class Class320
	{
		public Dictionary<string, object> dictionary_0;

		internal void method_0(string string_0)
		{
			dictionary_0[string_0] = (from jtoken_0 in ((JArray)dictionary_0[string_0]).Values()
				select ((JValue)jtoken_0).Value).ToArray();
		}

		internal void method_1(string string_0)
		{
			dictionary_0[string_0] = smethod_0(dictionary_0[string_0] as JObject);
		}
	}

	private string string_0;

	private JObject jobject_0;

	public Class319(string string_1, bool bool_0 = false)
	{
		if (bool_0)
		{
			if (string_1.Trim() == "")
			{
				string_1 = "{}";
			}
			jobject_0 = JObject.Parse(string_1);
			return;
		}
		try
		{
			string_0 = "settings\\" + string_1 + ".json";
			if (!File.Exists(string_0))
			{
				using (File.AppendText(string_0))
				{
				}
			}
			jobject_0 = JObject.Parse(File.ReadAllText(string_0));
		}
		catch
		{
			jobject_0 = new JObject();
		}
	}

	public static Dictionary<string, object> smethod_0(JObject jobject_1)
	{
		Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();
		try
		{
			dictionary_0 = jobject_1.ToObject<Dictionary<string, object>>();
			List<string> list = (from class0_0 in dictionary_0.Select(delegate(KeyValuePair<string, object> keyValuePair_0)
				{
					KeyValuePair<string, object> keyValuePair2 = keyValuePair_0;
					return new Class0<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair2.Key);
				})
				select new Class1<Class0<KeyValuePair<string, object>, string>, object>(class0_0, class0_0.Prop_0.Value) into class1_0
				where class1_0.Prop_1.GetType() == typeof(JObject)
				select class1_0.Prop_0.Prop_1).ToList();
			List<string> list2 = (from class0_0 in dictionary_0.Select(delegate(KeyValuePair<string, object> keyValuePair_0)
				{
					KeyValuePair<string, object> keyValuePair = keyValuePair_0;
					return new Class0<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
				})
				select new Class1<Class0<KeyValuePair<string, object>, string>, object>(class0_0, class0_0.Prop_0.Value) into class1_0
				where class1_0.Prop_1.GetType() == typeof(JArray)
				select class1_0.Prop_0.Prop_1).ToList();
			list2.ForEach(delegate(string string_0)
			{
				dictionary_0[string_0] = (from jtoken_0 in ((JArray)dictionary_0[string_0]).Values()
					select ((JValue)jtoken_0).Value).ToArray();
			});
			list.ForEach(delegate(string string_0)
			{
				dictionary_0[string_0] = smethod_0(dictionary_0[string_0] as JObject);
			});
		}
		catch
		{
		}
		return dictionary_0;
	}

	public Class319()
	{
		jobject_0 = new JObject();
	}

	public string method_0(string string_1, string string_2 = "")
	{
		string result = string_2;
		try
		{
			result = ((jobject_0[string_1] == null) ? string_2 : jobject_0[string_1]!.ToString());
		}
		catch
		{
		}
		return result;
	}

	public List<string> method_1(string string_1, int int_0 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			list = ((int_0 != 0) ? method_0(string_1).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : method_0(string_1).Split('\n').ToList());
			list = GClass14.smethod_36(list);
		}
		catch
		{
		}
		return list;
	}

	public int method_2(string string_1, int int_0 = 0)
	{
		int result = int_0;
		try
		{
			result = ((jobject_0[string_1] == null) ? int_0 : Convert.ToInt32(jobject_0[string_1]!.ToString()));
		}
		catch
		{
		}
		return result;
	}

	public bool method_3(string string_1, bool bool_0 = false)
	{
		bool result = bool_0;
		try
		{
			result = ((jobject_0[string_1] == null) ? bool_0 : Convert.ToBoolean(jobject_0[string_1]!.ToString()));
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void method_4(string string_1, string string_2)
	{
		try
		{
			if (!jobject_0.ContainsKey(string_1))
			{
				jobject_0.Add(string_1, string_2);
			}
			else
			{
				jobject_0[string_1] = string_2;
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_5(string string_1, object object_0)
	{
		try
		{
			jobject_0[string_1] = object_0.ToString();
		}
		catch
		{
		}
	}

	public void method_6(string string_1, List<string> list_0)
	{
		try
		{
			jobject_0[string_1] = string.Join("\n", list_0).ToString();
		}
		catch
		{
		}
	}

	public void method_7(string string_1)
	{
		try
		{
			jobject_0.Remove(string_1);
		}
		catch
		{
		}
	}

	public void method_8(string string_1 = "")
	{
		try
		{
			if (string_1 == "")
			{
				string_1 = string_0;
			}
			File.WriteAllText(string_1, jobject_0.ToString());
		}
		catch
		{
		}
	}

	public string method_9()
	{
		string result = "";
		try
		{
			result = jobject_0.ToString().Replace("\r\n", "");
		}
		catch (Exception)
		{
		}
		return result;
	}
}
