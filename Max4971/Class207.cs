using System.Runtime.InteropServices;

internal class Class207
{
	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int int_0, int int_1);

	public static bool smethod_0()
	{
		int int_;
		return InternetGetConnectedState(out int_, 0);
	}
}
