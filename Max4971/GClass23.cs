using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class GClass23
{
	public static string smethod_0(string string_0, string string_1, string string_2, int int_0)
	{
		string result = "0|";
		string value = Regex.Match(string_0, "c_user=(.*?);").Groups[1].Value;
		GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
		if (value != "")
		{
			try
			{
				string text = gClass.method_0("https://www.facebook.com/me").ToString();
				if (text.Contains("id=\"code_in_cliff\""))
				{
					result = "1|0";
				}
				else if (Regex.Match(text, "\"USER_ID\":\"(.*?)\"").Groups[1].Value.Trim() == value.Trim() && !text.Contains("checkpointSubmitButton"))
				{
					result = "1|1";
				}
			}
			catch
			{
				result = "2|";
			}
		}
		return result;
	}

	public static string smethod_1(string string_0, string string_1, string string_2, int int_0)
	{
		try
		{
			string input = new GClass19(string_0, string_1, string_2, int_0).method_0("https://m.facebook.com/ajax/dtsg/?__ajax__=true").ToString();
			return Regex.Match(input, "\"token\":\"(.*?)\"").Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}

	public static string smethod_2(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		string string_4 = "email=" + WebUtility.UrlEncode(string_0) + "&pass=" + WebUtility.UrlEncode(string_1);
		GClass19 gClass = new GClass19("", string_2, string_3, int_0);
		gClass.method_2("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", string_4).ToString();
		return gClass.method_4();
	}

	public static string smethod_3(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		try
		{
			GClass19 gClass = new GClass19("", string_2, string_3, int_0);
			string json = gClass.method_0("https://graph.facebook.com/" + string_0 + "?fields=name&access_token=" + string_1);
			JObject jObject = JObject.Parse(json);
			return jObject["name"]!.ToString();
		}
		catch
		{
			return "";
		}
	}
}
