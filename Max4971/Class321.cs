using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class Class321
{
	internal static uint smethod_0(string string_0)
	{
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				_ = (string_0[i] ^ -2128831035) * 16777619;
			}
		}
		return 0u;
	}
}
