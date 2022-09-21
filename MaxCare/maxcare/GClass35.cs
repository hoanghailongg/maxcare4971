using System;
using System.Collections.Generic;
using System.Linq;

public class GClass35
{
	public static bool smethod_0(List<string> list_0, List<string> list_1)
	{
		List<string> source = list_0.Except(list_1).ToList();
		List<string> source2 = list_1.Except(list_0).ToList();
		return !source.Any() && !source2.Any();
	}

	public static List<string> smethod_1(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Class49.random_0.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> smethod_2(List<string> list_0)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list.Add(list_0[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<List<string>> smethod_3(List<string> list_0, int int_0)
	{
		List<List<string>> list = new List<List<string>>();
		try
		{
			int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / (double)int_0)));
			for (int i = 0; i < num; i++)
			{
				list.Add(list_0.GetRange(int_0 * i, (int_0 * i + int_0 <= list_0.Count) ? int_0 : (list_0.Count % int_0)));
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_4(List<string> list_0, string string_0 = "\r\n")
	{
		return string.Join(string_0, list_0);
	}

	public static string smethod_5(List<string> list_0)
	{
		string result = "";
		if (list_0.Count > 0)
		{
			result = list_0.Last();
			list_0.RemoveAt(list_0.Count - 1);
		}
		return result;
	}

	public static List<string> smethod_6(List<string> list_0, List<string> list_1)
	{
		foreach (string item in list_1)
		{
			list_0.Remove(item);
		}
		return list_0;
	}
}
