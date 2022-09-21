public class GClass48
{
	private static uint[] uint_0;

	public uint method_0(long long_0, uint uint_1)
	{
		for (int i = 0; i < uint_1; i++)
		{
		}
		return uint.MaxValue;
	}

	public GClass48()
	{
		if (uint_0 != null)
		{
			return;
		}
		uint_0 = new uint[256];
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			uint_0[i] = num;
		}
	}
}
