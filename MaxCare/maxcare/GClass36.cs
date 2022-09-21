using System.Linq;

public class GClass36
{
	public static string smethod_0()
	{
		Class319 @class = new Class319("configGeneral");
		string text = @class.method_0("txbPathProfile");
		if (!text.Contains('\\'))
		{
			text = GClass37.smethod_0() + "\\" + ((@class.method_0("txbPathProfile") == "") ? "profiles" : @class.method_0("txbPathProfile"));
		}
		return text;
	}

	public static string smethod_1()
	{
		return GClass37.smethod_0() + "\\backup";
	}
}
