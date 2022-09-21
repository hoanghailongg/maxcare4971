using System;
using System.Security.Principal;
using System.Windows.Forms;

internal static class Class305
{
	public static int int_0;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Class49.smethod_0();
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				GClass38.smethod_0("Vui lòng chạy bằng quyền Admin!\r\nPlease Run Aplication As Administrator!", 3);
				Environment.Exit(0);
			}
			Application.Run(new fIntro());
		}
		catch (Exception exception_)
		{
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!"), 2);
			GClass14.smethod_75(null, exception_, "Run Program2");
			Environment.Exit(0);
		}
	}
}
