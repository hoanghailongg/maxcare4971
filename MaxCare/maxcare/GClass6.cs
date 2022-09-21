using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass6
{
	[CompilerGenerated]
	private sealed class Class2
	{
		public GClass6 gclass6_0;

		public int int_0;

		internal void method_0()
		{
			try
			{
				while (Environment.TickCount - gclass6_0.Int32_0 < int_0 * 1000 && gclass6_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
				gclass6_0.Thread_0.Abort();
				while (gclass6_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Thread thread_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	private Thread Thread_0
	{
		[CompilerGenerated]
		get
		{
			return thread_0;
		}
		[CompilerGenerated]
		set
		{
			thread_0 = value;
		}
	}

	private int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public GClass6(Thread thread_1, int int_1 = -1)
	{
		GClass6 gclass6_0 = this;
		Thread_0 = thread_1;
		Int32_0 = Environment.TickCount;
		if (int_1 <= 0)
		{
			return;
		}
		new Thread((ThreadStart)delegate
		{
			try
			{
				while (Environment.TickCount - gclass6_0.Int32_0 < int_1 * 1000 && gclass6_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
				gclass6_0.Thread_0.Abort();
				while (gclass6_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	public string method_0()
	{
		return GClass14.smethod_17((Environment.TickCount - Int32_0) / 1000);
	}
}
