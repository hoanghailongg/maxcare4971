using System;
using System.Net;

public class GClass20
{
	public static string smethod_0(string string_0 = "test")
	{
		string text = "https://minsoftware.xyz/file/" + string_0 + "/";
		try
		{
			WebClient webClient = new WebClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Uri address = new Uri(text + "update.ini");
			webClient.DownloadFile(address, "./update/update.ini");
			GClass24 gClass = new GClass24("./update/update.ini");
			string text2 = gClass.method_1("Version", "Infor");
			double num = Convert.ToDouble(text2.Replace(".", "").Insert(1, "."));
			GClass24 gClass2 = new GClass24("update.ini");
			string text3 = gClass2.method_1("Version", "Infor");
			double num2 = Convert.ToDouble(text3.Replace(".", "").Insert(1, "."));
			if (num > num2)
			{
				string text4 = "\r\nVersion: " + text2;
				text4 = text4 + "\r\n" + GClass29.smethod_0("Nô\u0323i dung update:");
				text4 = text4 + "\r\n" + GClass22.smethod_16(gClass.method_1("Content", "Infor"));
				return text4 + "\r\n\r\n" + GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t phâ\u0300n mê\u0300m?");
			}
		}
		catch
		{
		}
		return "";
	}
}
