using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;

namespace maxcare
{

	internal static class Program
	{
		public static int intro;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
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
				GClass38.smethod_0(GClass29.smethod_0("Có lỗi xảy ra, vui lòng liên hệ Admin để được hỗ trợ!"), 2);
				GClass14.smethod_75(null, exception_, "Run Program2");
				Environment.Exit(0);
			}
		}
	}
}
