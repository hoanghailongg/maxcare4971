using System;
using System.Net;
using System.Text;

public class GClass1
{
	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "http://minmaxsoft.com/chapall/api.php/";

	public GClass1(string string_6, string string_7, string string_8, string string_9, string string_10)
	{
		string_0 = string_6;
		string_1 = string_7;
		string_2 = string_8;
		string_3 = string_9;
		string_4 = string_10;
	}

	public string method_0()
	{
		string result = "";
		try
		{
			string text = "MINSOFTWARE_KEY_PRO" + string_4;
			GClass5 gClass = new GClass5();
			new GClass4();
			string text2 = string_3 + "|" + string_2 + "|" + string_0 + "|" + string_1 + "|" + text;
			string text3 = gClass.method_9(text2, "KEY_8f558b28346e6cf3c_HASH_989ae0d760020f2");
			string text4 = method_2(string_5 + "CheckAllToken/?api=" + text3).Replace("\"", "");
			if (text4 != null)
			{
				result = text4;
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	public string method_1()
	{
		string result = "";
		try
		{
			_ = "MINSOFTWARE_KEY_PRO" + string_4;
			GClass5 gClass = new GClass5();
			new GClass4();
			string text = string_0 + "|" + string_1;
			string text2 = gClass.method_9(text, "KEY_8f558b28346e6cf3c_HASH_989ae0d760020f2");
			string text3 = method_2(string_5 + "CheckLoginMin/?api=" + text2).Replace("\"", "");
			if (text3 != null)
			{
				result = text3;
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	public static string smethod_0(string string_6)
	{
		byte[] bytes = Convert.FromBase64String(string_6);
		return Encoding.UTF8.GetString(bytes);
	}

	private string method_2(string string_6)
	{
		try
		{
			WebClient webClient = new WebClient();
			byte[] bytes = webClient.DownloadData(string_6);
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			return uTF8Encoding.GetString(bytes);
		}
		catch
		{
			return null;
		}
	}
}
