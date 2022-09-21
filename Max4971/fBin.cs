using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

public class fBin : Form
{
	[CompilerGenerated]
	private sealed class Class58
	{
		public fBin fBin_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fBin_0.dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Class59 CS_0024_003C_003E8__locals0 = new Class59
							{
								class58_0 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals0.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = Class309.smethod_3(CS_0024_003C_003E8__locals0.class58_0.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.int_0, "cCookies");
									string text = Class309.smethod_3(CS_0024_003C_003E8__locals0.class58_0.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.int_0, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(.*?);").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										Class309.smethod_5(CS_0024_003C_003E8__locals0.class58_0.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.int_0, "cStatus", GClass29.smethod_0("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class58_0.int_0);
								}
								catch (Exception ex2)
								{
									GClass22.smethod_22(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass22.smethod_21(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					GClass22.smethod_21(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass22.smethod_22(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class59
	{
		public int int_0;

		public Class58 class58_0;

		internal void method_0()
		{
			try
			{
				string input = Class309.smethod_3(class58_0.fBin_0.dtgvAcc, int_0, "cCookies");
				string text = Class309.smethod_3(class58_0.fBin_0.dtgvAcc, int_0, "cUid");
				if (text == "")
				{
					text = Regex.Match(input, "c_user=(.*?);").Groups[1].Value;
				}
				if (File.Exists("backup\\" + text + "\\" + text + ".html"))
				{
					Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
				}
				else
				{
					Class309.smethod_5(class58_0.fBin_0.dtgvAcc, int_0, "cStatus", GClass29.smethod_0("Chưa tạo html!"));
				}
				Interlocked.Decrement(ref class58_0.int_0);
			}
			catch (Exception ex)
			{
				GClass22.smethod_22(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class60
	{
		public fBin fBin_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			fBin_0.method_27("start");
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (fBin_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class61 CS_0024_003C_003E8__locals0 = new Class61
						{
							class60_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class60_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class60_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.class60_0.fBin_0.method_46(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class60_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			fBin_0.method_27("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class61
	{
		public int int_0;

		public Class60 class60_0;

		internal void method_0()
		{
			class60_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class60_0.fBin_0.dtgvAcc);
			class60_0.fBin_0.method_46(int_0);
			Interlocked.Decrement(ref class60_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class62
	{
		public int int_0;

		public int int_1;

		public fBin fBin_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class63 CS_0024_003C_003E8__locals0 = new Class63
						{
							class62_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class62_0.fBin_0.method_19(GClass29.smethod_0("Đang xo\u0301a dữ liệu backup..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class62_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.class62_0.fBin_0.method_50(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class62_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class63
	{
		public int int_0;

		public Class62 class62_0;

		internal void method_0()
		{
			class62_0.fBin_0.method_19(GClass29.smethod_0("Đang xo\u0301a dữ liệu backup..."), "cStatus", int_0, 0, class62_0.fBin_0.dtgvAcc);
			class62_0.fBin_0.method_50(int_0);
			Interlocked.Decrement(ref class62_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class64
	{
		public fBin fBin_0;

		public int int_0;

		public int int_1;

		public string string_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class65 CS_0024_003C_003E8__locals0 = new Class65
						{
							class64_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class64_0.fBin_0.method_8(CS_0024_003C_003E8__locals0.int_0, GClass29.smethod_0("Đang check backup..."));
							CS_0024_003C_003E8__locals0.class64_0.fBin_0.method_51(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class64_0.string_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class64_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class65
	{
		public int int_0;

		public Class64 class64_0;

		internal void method_0()
		{
			class64_0.fBin_0.method_8(int_0, GClass29.smethod_0("Đang check backup..."));
			class64_0.fBin_0.method_51(int_0, class64_0.string_0);
			Interlocked.Decrement(ref class64_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class66
	{
		public int int_0;

		public List<int> list_0;

		public string string_0;

		public fBin fBin_0;

		internal void method_0()
		{
			try
			{
				if (fBin_0.gclass17_0.method_2("ip_iTypeChangeIp") == 8 && fBin_0.gclass17_0.method_2("typeRunXproxy") == 1)
				{
					for (int i = 0; i < fBin_0.list_5.Count; i++)
					{
						fBin_0.list_5[i].method_1();
					}
				}
				int num = 0;
				while (num < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (fBin_0.bool_0 || fBin_0.list_10.Count >= int_0)
						{
							break;
						}
						Class67 CS_0024_003C_003E8__locals0 = new Class67
						{
							class66_0 = this
						};
						if (fBin_0.bool_0)
						{
							break;
						}
						CS_0024_003C_003E8__locals0.int_0 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								int int_ = GClass14.smethod_65(ref CS_0024_003C_003E8__locals0.class66_0.list_0);
								CS_0024_003C_003E8__locals0.class66_0.fBin_0.method_55(CS_0024_003C_003E8__locals0.int_0, int_, CS_0024_003C_003E8__locals0.class66_0.string_0);
							}
							catch (Exception exception_2)
							{
								GClass14.smethod_75(null, exception_2);
							}
						})
						{
							Name = CS_0024_003C_003E8__locals0.int_0.ToString()
						};
						fBin_0.list_10.Add(thread);
						GClass14.smethod_58(1.0);
						thread.Start();
					}
					else
					{
						num++;
					}
					if (fBin_0.bool_0)
					{
						break;
					}
				}
				for (int j = 0; j < fBin_0.list_10.Count; j++)
				{
					fBin_0.list_10[j].Join();
				}
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class67
	{
		public int int_0;

		public Class66 class66_0;

		internal void method_0()
		{
			try
			{
				int int_ = GClass14.smethod_65(ref class66_0.list_0);
				class66_0.fBin_0.method_55(int_0, int_, class66_0.string_0);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class68
	{
		public string string_0;

		public fBin fBin_0;

		internal void method_0()
		{
			try
			{
				if (string_0 == "start")
				{
					fBin_0.grTimKiem.Enabled = false;
					fBin_0.grQuanLyThuMuc.Enabled = false;
				}
				else if (string_0 == "stop")
				{
					fBin_0.grTimKiem.Enabled = true;
					fBin_0.grQuanLyThuMuc.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class69
	{
		public fBin fBin_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public string string_0;

		internal void method_0()
		{
			fBin_0.method_27("start");
			switch (int_0)
			{
			case 0:
			{
				int num4 = 0;
				while (num4 < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class70 CS_0024_003C_003E8__locals5 = new Class70
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals5.int_0 = num4++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals5.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals5.int_0, 0, CS_0024_003C_003E8__locals5.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals5.class69_0.fBin_0.method_37(CS_0024_003C_003E8__locals5.int_0, CS_0024_003C_003E8__locals5.class69_0.string_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals5.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num4++;
					}
				}
				break;
			}
			case 1:
			{
				int num6 = 0;
				while (num6 < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class71 CS_0024_003C_003E8__locals0 = new Class71
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals0.int_0 = num6++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals0.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals0.class69_0.fBin_0.method_38(CS_0024_003C_003E8__locals0.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num6++;
					}
				}
				break;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class72 CS_0024_003C_003E8__locals1 = new Class72
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals1.int_0 = num2++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals1.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals1.int_0, 0, CS_0024_003C_003E8__locals1.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals1.class69_0.fBin_0.method_39(CS_0024_003C_003E8__locals1.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals1.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num2++;
					}
				}
				break;
			}
			case 3:
			{
				int num5 = 0;
				while (num5 < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class73 CS_0024_003C_003E8__locals2 = new Class73
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals2.int_0 = num5++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals2.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals2.int_0, 0, CS_0024_003C_003E8__locals2.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals2.class69_0.fBin_0.method_40(CS_0024_003C_003E8__locals2.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals2.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num5++;
					}
				}
				break;
			}
			case 4:
			{
				int num3 = 0;
				while (num3 < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class74 CS_0024_003C_003E8__locals3 = new Class74
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals3.int_0 = num3++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals3.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals3.int_0, 0, CS_0024_003C_003E8__locals3.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals3.class69_0.fBin_0.method_36(CS_0024_003C_003E8__locals3.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals3.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				break;
			}
			case 5:
			{
				int num = 0;
				while (num < fBin_0.dtgvAcc.Rows.Count && !fBin_0.bool_0)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_1 < int_2)
						{
							Class75 CS_0024_003C_003E8__locals4 = new Class75
							{
								class69_0 = this
							};
							Interlocked.Increment(ref int_1);
							CS_0024_003C_003E8__locals4.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals4.class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals4.int_0, 0, CS_0024_003C_003E8__locals4.class69_0.fBin_0.dtgvAcc);
								CS_0024_003C_003E8__locals4.class69_0.fBin_0.method_35(CS_0024_003C_003E8__locals4.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals4.class69_0.int_1);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				break;
			}
			}
			int tickCount = Environment.TickCount;
			while (int_1 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass14.smethod_58(1.0);
			}
			fBin_0.method_27("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class70
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_37(int_0, class69_0.string_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class71
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_38(int_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class72
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_39(int_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class73
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_40(int_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class74
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_36(int_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class75
	{
		public int int_0;

		public Class69 class69_0;

		internal void method_0()
		{
			class69_0.fBin_0.method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_0, 0, class69_0.fBin_0.dtgvAcc);
			class69_0.fBin_0.method_35(int_0);
			Interlocked.Decrement(ref class69_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class76
	{
		public int int_0;

		public int int_1;

		public fBin fBin_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class77 CS_0024_003C_003E8__locals0 = new Class77
						{
							class76_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class76_0.fBin_0.method_19(GClass29.smethod_0("Đang xo\u0301a profile..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class76_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.class76_0.fBin_0.method_42(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class76_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class77
	{
		public int int_0;

		public Class76 class76_0;

		internal void method_0()
		{
			class76_0.fBin_0.method_19(GClass29.smethod_0("Đang xo\u0301a profile..."), "cStatus", int_0, 0, class76_0.fBin_0.dtgvAcc);
			class76_0.fBin_0.method_42(int_0);
			Interlocked.Decrement(ref class76_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class78
	{
		public fBin fBin_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class79 CS_0024_003C_003E8__locals0 = new Class79
						{
							class78_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class78_0.fBin_0.method_19(GClass29.smethod_0("Đang check profile..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class78_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.class78_0.fBin_0.method_43(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class78_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class79
	{
		public int int_0;

		public Class78 class78_0;

		internal void method_0()
		{
			class78_0.fBin_0.method_19(GClass29.smethod_0("Đang check profile..."), "cStatus", int_0, 0, class78_0.fBin_0.dtgvAcc);
			class78_0.fBin_0.method_43(int_0);
			Interlocked.Decrement(ref class78_0.int_0);
		}
	}

	private Random random_0 = new Random();

	private bool bool_0;

	private GClass17 gclass17_0;

	private GClass17 gclass17_1;

	private object object_0 = new object();

	private object object_1 = new object();

	private int int_0 = 0;

	private object object_2 = new object();

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private object object_3 = new object();

	private List<int> list_3 = new List<int>();

	private bool bool_1 = false;

	private object object_4 = new object();

	private int int_1 = -1;

	private bool bool_2 = true;

	private object object_5 = new object();

	private object object_6 = new object();

	private object object_7 = new object();

	private object object_8 = new object();

	private object object_9 = new object();

	private int int_2 = -1;

	private bool bool_3 = true;

	private GClass17 gclass17_2;

	private List<Class40> list_4 = null;

	private List<Class47> list_5 = null;

	private List<Class41> list_6 = null;

	private List<string> list_7 = null;

	private List<string> list_8 = null;

	private List<string> list_9 = null;

	private List<Thread> list_10 = null;

	private IContainer icontainer_0 = null;

	public DataGridView dtgvAcc;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private MenuStrip menuStrip1;

	private GroupBox grQuanLyThuMuc;

	private Label label1;

	private MetroComboBox cbbThuMuc;

	private MetroContextMenu ctmsAcc;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem liveToolStripMenuItem;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem tokenToolStripMenuItem;

	private ToolStripMenuItem cookieToolStripMenuItem;

	private ToolStripMenuItem uidPassToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem checkCookieToolStripMenuItem;

	private ToolStripMenuItem backupToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem passToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem mailPassMailToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

	private ToolStripMenuItem profileToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private GroupBox grTimKiem;

	private BunifuCustomTextbox txbSearch;

	private ToolStripMenuItem mailToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem fAToolStripMenuItem;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem uidPass2FaToolStripMenuItem;

	private BunifuDragControl bunifuDragControl_1;

	private ToolTip toolTip_0;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem backupToolStripMenuItem1;

	private ToolStripMenuItem htmlToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem donDepProfileToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem useragentToolStripMenuItem1;

	private ToolStripMenuItem proxyToolStripMenuItem1;

	private ComboBox cbbSearch;

	private ToolStripMenuItem toolStripMenuItem_15;

	private MetroButton btnLoadAcc;

	private MetroComboBox cbbTinhTrang;

	private Label label2;

	private ToolStripMenuItem toolStripMenuItem_16;

	private MetroButton BtnSearch;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem checkAvatarToolStripMenuItem;

	private ToolStripMenuItem checkProxyToolStripMenuItem;

	private ToolStripMenuItem checkProfileToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_17;

	private ToolStripMenuItem toolStripMenuItem_18;

	private ToolStripMenuItem toolStripMenuItem_19;

	private ToolStripMenuItem checkBackupToolStripMenuItem;

	private ToolStripMenuItem checkInfoUIDToolStripMenuItem;

	private ToolStripMenuItem checkBackupToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_20;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel5;

	private ToolStripStatusLabel lblCountSelect;

	private ToolStripStatusLabel toolStripStatusLabel7;

	private ToolStripStatusLabel lblCountTotal;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cToken;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cEmail;

	private DataGridViewTextBoxColumn cPhone;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cFollow;

	private DataGridViewTextBoxColumn cFriend;

	private DataGridViewTextBoxColumn cGroup;

	private DataGridViewTextBoxColumn cBirthday;

	private DataGridViewTextBoxColumn cGender;

	private DataGridViewTextBoxColumn cPassword;

	private DataGridViewTextBoxColumn cMailRecovery;

	private DataGridViewTextBoxColumn cPassMail;

	private DataGridViewTextBoxColumn cBackup;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cUseragent;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cDateCreateAcc;

	private DataGridViewTextBoxColumn cAvatar;

	private DataGridViewTextBoxColumn cProfile;

	private DataGridViewTextBoxColumn cThuMuc;

	private DataGridViewTextBoxColumn cInteractEnd;

	private DataGridViewTextBoxColumn cInfo;

	private DataGridViewTextBoxColumn cGhiChu;

	private DataGridViewTextBoxColumn cDateDelete;

	private DataGridViewTextBoxColumn cStatus;

	private Button button9;

	private Button button3;

	private ToolStripMenuItem toolStripMenuItem_21;

	private Label label3;

	private ToolStripMenuItem toolStripMenuItem_22;

	private ToolStripMenuItem toolStripMenuItem_23;

	public fBin()
	{
		InitializeComponent();
		method_45();
		method_2();
		method_1();
		menuStrip1.Cursor = Cursors.Hand;
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_2(toolStripMenuItem_14);
		GClass29.smethod_1(grTimKiem);
		GClass29.smethod_1(grQuanLyThuMuc);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(button9);
		GClass29.smethod_1(button3);
		GClass29.smethod_2(toolStripStatusLabel5);
		GClass29.smethod_2(toolStripStatusLabel7);
		GClass29.smethod_1(label3);
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			GClass29.smethod_3(column);
		}
		GClass29.smethod_2(toolStripMenuItem_0);
		GClass29.smethod_2(toolStripMenuItem_2);
		GClass29.smethod_2(liveToolStripMenuItem);
		GClass29.smethod_2(tinhTrangToolStripMenuItem);
		GClass29.smethod_2(toolStripMenuItem_8);
		GClass29.smethod_2(toolStripMenuItem_3);
		GClass29.smethod_2(toolStripMenuItem_20);
		GClass29.smethod_2(toolStripMenuItem_1);
		GClass29.smethod_2(toolStripMenuItem_21);
		GClass29.smethod_2(toolStripMenuItem_22);
		GClass29.smethod_2(toolStripMenuItem_23);
		GClass29.smethod_2(toolStripMenuItem_13);
		GClass29.smethod_2(toolStripMenuItem_11);
		GClass29.smethod_2(checkCookieToolStripMenuItem);
		GClass29.smethod_2(profileToolStripMenuItem);
		GClass29.smethod_2(toolStripMenuItem_10);
		GClass29.smethod_2(donDepProfileToolStripMenuItem);
		GClass29.smethod_2(backupToolStripMenuItem);
		GClass29.smethod_2(toolStripMenuItem_15);
		GClass29.smethod_2(backupToolStripMenuItem1);
		GClass29.smethod_2(toolStripMenuItem_17);
		GClass29.smethod_2(toolStripMenuItem_6);
	}

	private void method_1()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{
				"cName",
				GClass29.smethod_0("Tên")
			},
			{
				"cBirthday",
				GClass29.smethod_0("Ngày sinh")
			},
			{
				"cGender",
				GClass29.smethod_0("Giới tính")
			},
			{
				"cPassword",
				GClass29.smethod_0("Mật khẩu")
			},
			{
				"cGhiChu",
				GClass29.smethod_0("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				GClass29.smethod_0("Tương ta\u0301c cuô\u0301i")
			}
		};
		cbbSearch.DataSource = new BindingSource(dataSource, null);
		cbbSearch.ValueMember = "Key";
		cbbSearch.DisplayMember = "Value";
	}

	private void method_2()
	{
		gclass17_1 = new GClass17("configDatagridview");
		dtgvAcc.Columns["cToken"].Visible = gclass17_1.method_3("cToken");
		dtgvAcc.Columns["cCookies"].Visible = gclass17_1.method_3("ckbCookie");
		dtgvAcc.Columns["cEmail"].Visible = gclass17_1.method_3("ckbEmail");
		dtgvAcc.Columns["cName"].Visible = gclass17_1.method_3("ckbTen");
		dtgvAcc.Columns["cFriend"].Visible = gclass17_1.method_3("ckbBanBe");
		dtgvAcc.Columns["cGroup"].Visible = gclass17_1.method_3("ckbNhom");
		dtgvAcc.Columns["cBirthday"].Visible = gclass17_1.method_3("ckbNgaySinh");
		dtgvAcc.Columns["cGender"].Visible = gclass17_1.method_3("ckbGioiTinh");
		dtgvAcc.Columns["cPassword"].Visible = gclass17_1.method_3("ckbMatKhau");
		dtgvAcc.Columns["cPassMail"].Visible = gclass17_1.method_3("ckbMatKhauMail");
		dtgvAcc.Columns["cBackup"].Visible = gclass17_1.method_3("ckbBackup");
		dtgvAcc.Columns["cFa2"].Visible = gclass17_1.method_3("ckbMa2FA");
		dtgvAcc.Columns["cUseragent"].Visible = gclass17_1.method_3("ckbUseragent");
		dtgvAcc.Columns["cProxy"].Visible = gclass17_1.method_3("ckbProxy");
		dtgvAcc.Columns["cDateCreateAcc"].Visible = gclass17_1.method_3("ckbNgayTao");
		dtgvAcc.Columns["cAvatar"].Visible = gclass17_1.method_3("ckbAvatar");
		dtgvAcc.Columns["cProfile"].Visible = gclass17_1.method_3("ckbProfile");
		dtgvAcc.Columns["cInfo"].Visible = gclass17_1.method_3("ckbTinhTrang");
		dtgvAcc.Columns["cThuMuc"].Visible = gclass17_1.method_3("ckbThuMuc");
		dtgvAcc.Columns["cGhiChu"].Visible = gclass17_1.method_3("ckbGhiChu");
		dtgvAcc.Columns["cFollow"].Visible = gclass17_1.method_3("ckbFollow");
		dtgvAcc.Columns["cInteractEnd"].Visible = gclass17_1.method_3("ckbInteractEnd");
		dtgvAcc.Columns["cPhone"].Visible = gclass17_1.method_3("ckbPhone");
	}

	protected override void OnLoad(EventArgs e)
	{
		Application.Idle += method_31;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (base.Width == Screen.PrimaryScreen.WorkingArea.Width && base.Height == Screen.PrimaryScreen.WorkingArea.Height)
		{
			base.Width = Class49.int_0;
			base.Height = Class49.int_1;
			base.Top = Class49.int_2;
			base.Left = Class49.int_3;
		}
		else
		{
			Class49.int_2 = base.Top;
			Class49.int_3 = base.Left;
			base.Top = 0;
			base.Left = 0;
			base.Width = Screen.PrimaryScreen.WorkingArea.Width;
			base.Height = Screen.PrimaryScreen.WorkingArea.Height;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void btnLoadAcc_Click(object sender, EventArgs e)
	{
		string text = "";
		if (cbbThuMuc.SelectedValue != null)
		{
			text = cbbThuMuc.SelectedValue.ToString();
		}
		method_32();
		if (text != "999999" && text != "-1")
		{
			int_1 = -1;
			cbbThuMuc.SelectedValue = text;
			return;
		}
		bool_2 = false;
		cbbThuMuc.SelectedValue = text;
		bool_2 = true;
		method_33(fChonThuMuc.list_1);
	}

	private List<string> method_3()
	{
		List<string> result = null;
		try
		{
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				result = ((text2 == "999999") ? GClass35.smethod_2(fChonThuMuc.list_1) : new List<string> { cbbThuMuc.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void method_4(List<string> list_11 = null, string string_0 = "", bool bool_4 = false)
	{
		try
		{
			dtgvAcc.Rows.Clear();
			if (string_0 == "[Tất cả tình trạng]" || string_0 == GClass29.smethod_0("[Tất cả tình trạng]"))
			{
				string_0 = "";
			}
			DataTable dataTable_ = Class36.smethod_19(list_11, string_0, bool_4);
			method_5(dataTable_);
		}
		catch (Exception)
		{
		}
	}

	private void method_5(DataTable dataTable_0)
	{
		Class309.smethod_6(dtgvAcc, dataTable_0, bool_0: true);
		method_17(0);
		method_7();
		method_16();
	}

	private void method_6(int int_3, int int_4)
	{
		switch (int_4)
		{
		case 2:
			dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 1:
			dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		}
	}

	private void method_7(int int_3 = -1)
	{
		method_45();
		if (gclass17_0.method_2("typePhanBietMau") == 0)
		{
			if (int_3 == -1)
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text = method_13(i);
					if (text == "Live")
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains(GClass29.smethod_0("Checkpoint")) || text.Contains("Changed pass"))
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
			}
			else
			{
				string text2 = method_13(int_3);
				if (text2 == "Live")
				{
					dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
				else if (text2.Contains("Die") || text2.Contains(GClass29.smethod_0("Checkpoint")) || text2.Contains("Changed pass"))
				{
					dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
		}
		else if (int_3 == -1)
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string text3 = method_13(j);
				if (text3 == "Live")
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Green;
				}
				else if (text3.Contains("Die") || text3.Contains(GClass29.smethod_0("Checkpoint")) || text3.Contains("Changed pass"))
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
		else
		{
			string text4 = method_13(int_3);
			if (text4 == "Live")
			{
				dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Green;
			}
			else if (text4.Contains("Die") || text4.Contains(GClass29.smethod_0("Checkpoint")) || text4.Contains("Changed pass"))
			{
				dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Red;
			}
		}
	}

	public void method_8(int int_3, string string_0)
	{
		Class309.smethod_5(dtgvAcc, int_3, "cStatus", string_0);
	}

	public void method_9(string string_0, int int_3, string string_1)
	{
		Class309.smethod_5(dtgvAcc, int_3, "cInfo", string_1);
		method_7(int_3);
		Class36.smethod_13(string_0, "info", string_1);
	}

	public void method_10(int int_3, string string_0, object object_10)
	{
		Class309.smethod_5(dtgvAcc, int_3, string_0, object_10);
	}

	public void method_11(int int_3, int int_4, object object_10)
	{
		Class309.smethod_4(dtgvAcc, int_3, int_4, object_10);
	}

	public string method_12(int int_3)
	{
		return Class309.smethod_3(dtgvAcc, int_3, "cStatus");
	}

	public string method_13(int int_3)
	{
		return Class309.smethod_3(dtgvAcc, int_3, "cInfo");
	}

	public string method_14(int int_3, string string_0)
	{
		return Class309.smethod_3(dtgvAcc, int_3, string_0);
	}

	public string method_15(int int_3, int int_4)
	{
		return Class309.smethod_2(dtgvAcc, int_3, int_4);
	}

	private void method_16()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_17(int int_3 = -1)
	{
		if (int_3 == -1)
		{
			int_3 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					int_3++;
				}
			}
		}
		lblCountSelect.Text = int_3.ToString();
	}

	private void method_18(int int_3 = -1)
	{
		method_45();
		if (gclass17_0.method_2("typePhanBietMau") == 0)
		{
			if (int_3 == -1)
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text = Class309.smethod_3(dtgvAcc, i, "cInfo");
					if (text == "Live")
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains(GClass29.smethod_0("Checkpoint")) || text.Contains("Changed pass"))
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
				return;
			}
			string text2 = Class309.smethod_3(dtgvAcc, int_3, "cInfo");
			string text3 = text2;
			if (!(text3 == "Live"))
			{
				if (text3 == "Die")
				{
					dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
			else
			{
				dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			}
		}
		else if (int_3 == -1)
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string text4 = Class309.smethod_3(dtgvAcc, j, "cInfo");
				if (text4.Contains("Die") || text4.Contains(GClass29.smethod_0("Checkpoint")))
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
		else
		{
			string text5 = Class309.smethod_3(dtgvAcc, int_3, "cInfo");
			string text6 = text5;
			if (!(text6 == "Live") && text6 == "Die")
			{
				dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void method_19(string string_0, string string_1, int int_3, int int_4, DataGridView dataGridView_0)
	{
		if (!bool_1)
		{
			Class309.smethod_5(dtgvAcc, int_3, string_1, string_0);
		}
		if (string_1 == "cInfo")
		{
			method_18(int_3);
		}
	}

	private void method_20(string string_0)
	{
		switch (string_0)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < dtgvAcc.SelectedRows.Count; k++)
			{
				int index = dtgvAcc.SelectedRows[k].Index;
				method_10(index, "cChose", !Convert.ToBoolean(method_14(index, "cChose")));
			}
			method_17();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				method_10(selectedRows[j].Index, "cChose", true);
			}
			method_17();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < dtgvAcc.RowCount; l++)
			{
				method_10(l, "cChose", false);
			}
			method_17(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				method_10(i, "cChose", true);
			}
			method_17(dtgvAcc.RowCount);
			break;
		}
		}
	}

	private void method_21(string string_0)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(Class309.smethod_3(dtgvAcc, i, "cChose")))
				{
					list.Add(Class309.smethod_3(dtgvAcc, i, "cId"));
					break;
				}
			}
			if (list.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
				return;
			}
			string text = "";
			switch (Class321.smethod_0(string_0))
			{
			case 457434463u:
			{
				if (!(string_0 == "uid|pass|token|cookie"))
				{
					break;
				}
				for (int k = 0; k < dtgvAcc.RowCount; k++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[k].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, k, "cUid") + "|" + Class309.smethod_3(dtgvAcc, k, "cPassword") + "|" + Class309.smethod_3(dtgvAcc, k, "cToken") + "|" + Class309.smethod_3(dtgvAcc, k, "cCookies") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 159575910u:
			{
				if (!(string_0 == "uid|pass"))
				{
					break;
				}
				for (int l = 0; l < dtgvAcc.RowCount; l++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[l].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, l, "cUid") + "|" + Class309.smethod_3(dtgvAcc, l, "cPassword") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 1329202400u:
			{
				if (!(string_0 == "mail|passmail"))
				{
					break;
				}
				for (int num7 = 0; num7 < dtgvAcc.RowCount; num7++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num7].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num7, "cEmail") + "|" + Class309.smethod_3(dtgvAcc, num7, "cPassMail") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 738560386u:
			{
				if (!(string_0 == "ma2fa"))
				{
					break;
				}
				for (int num3 = 0; num3 < dtgvAcc.RowCount; num3++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						try
						{
							text = text + GClass14.smethod_83(Class309.smethod_3(dtgvAcc, num3, "cFa2")) + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 1718322808u:
			{
				if (!(string_0 == "2fa"))
				{
					break;
				}
				for (int num5 = 0; num5 < dtgvAcc.RowCount; num5++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num5, "cFa2") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 1556604621u:
			{
				if (!(string_0 == "uid"))
				{
					break;
				}
				for (int num10 = 0; num10 < dtgvAcc.RowCount; num10++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num10].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num10, "cUid") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2071622424u:
			{
				if (!(string_0 == "pass"))
				{
					break;
				}
				for (int m = 0; m < dtgvAcc.RowCount; m++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[m].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, m, "cPassword") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2007449791u:
			{
				if (!(string_0 == "cookie"))
				{
					break;
				}
				for (int num9 = 0; num9 < dtgvAcc.RowCount; num9++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num9].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num9, "cCookies") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2337339239u:
			{
				if (!(string_0 == "useragent"))
				{
					break;
				}
				for (int num2 = 0; num2 < dtgvAcc.RowCount; num2++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num2, "cUseragent") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2107770459u:
			{
				if (!(string_0 == "proxy"))
				{
					break;
				}
				for (int num11 = 0; num11 < dtgvAcc.RowCount; num11++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num11].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num11, "cProxy").Split('*')[0] + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2491017778u:
			{
				if (!(string_0 == "token"))
				{
					break;
				}
				for (int num6 = 0; num6 < dtgvAcc.RowCount; num6++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num6, "cToken") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2369371622u:
			{
				if (!(string_0 == "name"))
				{
					break;
				}
				for (int num = 0; num < dtgvAcc.RowCount; num++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num, "cName") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text.TrimEnd('\r', '\n'));
				break;
			}
			case 3144981877u:
			{
				if (!(string_0 == "uid|pass|2fa"))
				{
					break;
				}
				for (int num12 = 0; num12 < dtgvAcc.RowCount; num12++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num12].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num12, "cUid") + "|" + Class309.smethod_3(dtgvAcc, num12, "cPassword") + "|" + Class309.smethod_3(dtgvAcc, num12, "cFa2") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 2703251604u:
			{
				if (!(string_0 == "uid|pass|token|cookie|mail|passmail"))
				{
					break;
				}
				for (int num8 = 0; num8 < dtgvAcc.RowCount; num8++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num8].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num8, "cUid") + "|" + Class309.smethod_3(dtgvAcc, num8, "cPassword") + "|" + Class309.smethod_3(dtgvAcc, num8, "cToken") + "|" + Class309.smethod_3(dtgvAcc, num8, "cCookies") + "|" + Class309.smethod_3(dtgvAcc, num8, "cEmail") + "|" + Class309.smethod_3(dtgvAcc, num8, "cPassMail") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 4025178668u:
			{
				if (!(string_0 == "birthday"))
				{
					break;
				}
				for (int num4 = 0; num4 < dtgvAcc.RowCount; num4++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, num4, "cBirthday") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text.TrimEnd('\r', '\n'));
				break;
			}
			case 3968918830u:
			{
				if (!(string_0 == "mail"))
				{
					break;
				}
				for (int n = 0; n < dtgvAcc.RowCount; n++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[n].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, n, "cEmail") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			case 3728375369u:
			{
				if (!(string_0 == "uid|pass|token|cookie|mail|passmail|fa2"))
				{
					break;
				}
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						try
						{
							text = text + Class309.smethod_3(dtgvAcc, j, "cUid") + "|" + Class309.smethod_3(dtgvAcc, j, "cPassword") + "|" + Class309.smethod_3(dtgvAcc, j, "cToken") + "|" + Class309.smethod_3(dtgvAcc, j, "cCookies") + "|" + Class309.smethod_3(dtgvAcc, j, "cEmail") + "|" + Class309.smethod_3(dtgvAcc, j, "cPassMail") + "|" + Class309.smethod_3(dtgvAcc, j, "cFa2") + "\r\n";
						}
						catch
						{
						}
					}
				}
				Clipboard.SetText(text);
				break;
			}
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_20("All");
	}

	private void liveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_20("SelectHighline");
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_20("UnAll");
	}

	private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("token");
	}

	private void cookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("cookie");
	}

	private void uidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid");
	}

	private void passToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("pass");
	}

	private void uidPassToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid|pass");
	}

	private void uidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid|pass|token|cookie");
	}

	private void fBin_Load(object sender, EventArgs e)
	{
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		toolStripMenuItem_8.DropDownItems.Clear();
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			text = Class309.smethod_3(dtgvAcc, i, "cStatus");
			if (text != "")
			{
				text2 = Regex.Match(text, "\\(IP: (.*?)\\)").Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				if (text != "" && !list.Contains(text))
				{
					list.Add(text);
				}
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			toolStripMenuItem_8.DropDownItems.Add(list[j]);
			toolStripMenuItem_8.DropDownItems[j].Click += method_23;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list = new List<string>();
		for (int k = 0; k < dtgvAcc.RowCount; k++)
		{
			if (dtgvAcc.Rows[k].Cells["cInfo"].Value != null && !Class309.smethod_3(dtgvAcc, k, "cInfo").Equals("") && !list.Contains(Class309.smethod_3(dtgvAcc, k, "cInfo")))
			{
				list.Add(Class309.smethod_3(dtgvAcc, k, "cInfo"));
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(list[l]);
			tinhTrangToolStripMenuItem.DropDownItems[l].Click += method_22;
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string value = toolStripMenuItem.Text;
			if (Class309.smethod_3(dtgvAcc, i, "cInfo").Equals(value))
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = true;
			}
			else
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = false;
			}
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string value = toolStripMenuItem.Text;
			if (Class309.smethod_3(dtgvAcc, i, "cStatus").Contains(value))
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = true;
			}
			else
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = false;
			}
		}
	}

	private void method_24()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn tài khoản cần xóa!"), 3);
			return;
		}
		if (GClass38.smethod_1(string.Format(GClass29.smethod_0("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), method_49()) + "\r\n\r\n" + GClass29.smethod_0("Chu\u0301 y\u0301: Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a thi\u0300 không thê\u0309 khôi phu\u0323c la\u0323i đươ\u0323c nư\u0303a!")) == DialogResult.Yes)
		{
			if (Class36.smethod_26(list, bool_0: true))
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						dtgvAcc.Rows.RemoveAt(j--);
					}
				}
				if (Class36.smethod_7())
				{
					method_25();
				}
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Xóa thất bại, vui lòng thử lại sau!"), 2);
			}
			method_41();
		}
		method_30();
		method_29();
	}

	private void method_25()
	{
		method_18();
		method_41();
		method_30();
		method_29();
	}

	private bool method_26(string string_0)
	{
		return GClass14.smethod_46(string_0) && !string_0.StartsWith("0");
	}

	private void method_27(string string_0)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (string_0 == "start")
				{
					grTimKiem.Enabled = false;
					grQuanLyThuMuc.Enabled = false;
				}
				else if (string_0 == "stop")
				{
					grTimKiem.Enabled = true;
					grQuanLyThuMuc.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				method_17();
			}
			catch
			{
			}
		}
	}

	private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_20("ToggleCheck");
		}
	}

	private void method_28(int int_3, string string_0)
	{
		if (!bool_1)
		{
			Class309.smethod_5(dtgvAcc, int_3, "cStatus", string_0);
		}
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		btnLoadAcc_Click(null, null);
	}

	private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_2 || cbbThuMuc.SelectedValue == null || !GClass39.smethod_0(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && int_1 == cbbThuMuc.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				method_33(method_3());
			}
			else
			{
				GClass14.smethod_33(new fChonThuMuc(bool_2: true));
				if (!fChonThuMuc.bool_1 || fChonThuMuc.list_1 == null || fChonThuMuc.list_1.Count == 0)
				{
					bool_2 = false;
					cbbThuMuc.SelectedIndex = ((int_1 != -1) ? int_1 : 0);
					bool_2 = true;
				}
				else
				{
					method_33(fChonThuMuc.list_1);
				}
			}
		}
		else
		{
			method_33();
		}
		int_1 = cbbThuMuc.SelectedIndex;
	}

	private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("mail|passmail");
	}

	private void uidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid|pass|token|cookie|mail|passmail");
	}

	private void method_29()
	{
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		try
		{
			lblCountSelect.Text = num.ToString();
		}
		catch
		{
		}
	}

	private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void method_30()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_31(object sender, EventArgs e)
	{
		Application.Idle -= method_31;
		method_2();
		method_32();
		method_33();
	}

	private void method_32()
	{
		bool_2 = false;
		DataTable dataSource = Class36.smethod_2(bool_0: true);
		cbbThuMuc.DataSource = dataSource;
		cbbThuMuc.ValueMember = "id";
		cbbThuMuc.DisplayMember = "name";
		bool_2 = true;
	}

	private void method_33(List<string> list_11 = null)
	{
		try
		{
			DataTable dataSource = Class36.smethod_9(list_11, bool_0: false);
			cbbTinhTrang.DataSource = dataSource;
			cbbTinhTrang.ValueMember = "id";
			cbbTinhTrang.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void method_34(int int_3)
	{
		method_45();
		int int_4 = 0;
		int int_5 = gclass17_0.method_2("nudHideThread", 10);
		string string_0 = gclass17_0.method_0("token");
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_27("start");
			switch (int_3)
			{
			case 0:
			{
				int num4 = 0;
				while (num4 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_8 = num4++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_8, 0, dtgvAcc);
								method_37(int_8, string_0);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num4++;
					}
				}
				break;
			}
			case 1:
			{
				int num6 = 0;
				while (num6 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_6 = num6++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_6, 0, dtgvAcc);
								method_38(int_6);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num6++;
					}
				}
				break;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_10 = num2++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_10, 0, dtgvAcc);
								method_39(int_10);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num2++;
					}
				}
				break;
			}
			case 3:
			{
				int num5 = 0;
				while (num5 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_7 = num5++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_7, 0, dtgvAcc);
								method_40(int_7);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num5++;
					}
				}
				break;
			}
			case 4:
			{
				int num3 = 0;
				while (num3 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_9 = num3++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_9, 0, dtgvAcc);
								method_36(int_9);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				break;
			}
			case 5:
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_4 < int_5)
						{
							Interlocked.Increment(ref int_4);
							int int_11 = num++;
							new Thread((ThreadStart)delegate
							{
								method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_11, 0, dtgvAcc);
								method_35(int_11);
								Interlocked.Decrement(ref int_4);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				break;
			}
			}
			int tickCount = Environment.TickCount;
			while (int_4 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass14.smethod_58(1.0);
			}
			method_27("stop");
		}).Start();
	}

	private void method_35(int int_3)
	{
		try
		{
			string string_ = method_14(int_3, "cId");
			string string_2 = method_14(int_3, "cUid");
			if (!method_26(string_2))
			{
				method_8(int_3, GClass29.smethod_0("Uid không hợp lệ!"));
				return;
			}
			string text = "";
			string text2 = Class32.smethod_15(string_2);
			if (text2.StartsWith("0|"))
			{
				if (Class32.smethod_14(string_2).StartsWith("0|"))
				{
					method_8(int_3, GClass29.smethod_0("Tài khoản Die!"));
					method_9(string_, int_3, "Die");
				}
				else
				{
					method_8(int_3, GClass29.smethod_0("Không check đươ\u0323c!"));
				}
			}
			else if (text2.StartsWith("1|"))
			{
				string[] array = text2.Split('|');
				string text3 = array[2];
				string text4 = array[3].ToLower();
				string text5 = array[4];
				string text6 = array[5];
				string text7 = array[6];
				Class36.smethod_14(string_, "name|gender|friends|groups", text3 + "|" + text4 + "|" + text6 + "|" + text7);
				method_10(int_3, "cName", text3);
				method_10(int_3, "cGender", text4);
				method_10(int_3, "cFriend", text6);
				method_10(int_3, "cGroup", text7);
				if (text5 != "")
				{
					method_10(int_3, "cBirthday", text5);
					Class36.smethod_13(string_, "birthday", text5);
				}
				method_9(string_, int_3, "Live");
				text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				method_8(int_3, text);
			}
			else
			{
				method_8(int_3, GClass29.smethod_0("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			method_8(int_3, GClass29.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_36(int int_3)
	{
		try
		{
			string text = "";
			string text2 = "";
			text = dtgvAcc.Rows[int_3].Cells["cEmail"].Value.ToString();
			text2 = dtgvAcc.Rows[int_3].Cells["cPassMail"].Value.ToString();
			if (text == "" || text2 == "")
			{
				method_19(GClass29.smethod_0("Không tìm thấy mail") + "!!!", "cStatus", int_3, 2, dtgvAcc);
			}
			else if (text.Contains("@hotmail.") || text.Contains("@outlook."))
			{
				string text3 = GClass14.smethod_14(text, text2);
				if (text3.Equals("1"))
				{
					method_19(GClass29.smethod_0("Tài khoản mail: live!"), "cStatus", int_3, 0, dtgvAcc);
				}
				else
				{
					method_19(GClass29.smethod_0("Tài khoản mail: die!"), "cStatus", int_3, 1, dtgvAcc);
				}
			}
			else
			{
				method_19(GClass29.smethod_0("Mail chưa hỗ trợ") + "!!!", "cStatus", int_3, 2, dtgvAcc);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Lỗi!!!"), "cStatus", int_3, 2, dtgvAcc);
		}
	}

	private void method_37(int int_3, string string_0)
	{
		try
		{
			string string_ = method_14(int_3, "cId");
			string string_2 = method_14(int_3, "cUid");
			if (!method_26(string_2))
			{
				method_8(int_3, GClass29.smethod_0("Uid không hợp lệ!"));
				return;
			}
			string text = "";
			string text2 = "";
			string text3 = Class32.smethod_14(string_2);
			if (text3.StartsWith("0|"))
			{
				text = "Die";
				text2 = "Wall die";
			}
			else if (text3.StartsWith("1|"))
			{
				text = "Live";
				text2 = "Wall live";
			}
			else
			{
				text2 = GClass29.smethod_0("Không check đươ\u0323c!");
			}
			method_8(int_3, text2);
			if (text != "")
			{
				method_9(string_, int_3, text);
			}
		}
		catch
		{
			method_8(int_3, GClass29.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_38(int int_3)
	{
		try
		{
			string text = "";
			string string_ = Class309.smethod_3(dtgvAcc, int_3, "cId");
			string string_2 = Class309.smethod_3(dtgvAcc, int_3, "cCookies");
			string string_3 = Class309.smethod_3(dtgvAcc, int_3, "cToken");
			string text2 = Class309.smethod_3(dtgvAcc, int_3, "cUseragent");
			string text3 = "";
			int num = 0;
			if (gclass17_0.method_2("ip_iTypeChangeIp") == 9)
			{
				text3 = method_14(int_3, "cProxy");
				num = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			if (text2 == "" || text3.Split(':').Length == 4)
			{
				text2 = Class49.string_7;
			}
			string text4 = "";
			if (!Class32.smethod_17(string_2, string_3, text2, text3, num))
			{
				text4 = "Token die";
			}
			else
			{
				text = "Live";
				text4 = "Token live";
			}
			method_19(text4, "cStatus", int_3, 2, dtgvAcc);
			if (text != "")
			{
				method_9(string_, int_3, text);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Không check đươ\u0323c!"), "cStatus", int_3, 2, dtgvAcc);
		}
	}

	private void method_39(int int_3)
	{
		try
		{
			string text = "";
			string string_ = Class309.smethod_3(dtgvAcc, int_3, "cId");
			string string_2 = Class309.smethod_3(dtgvAcc, int_3, "cCookies");
			string text2 = Class309.smethod_3(dtgvAcc, int_3, "cUseragent");
			string text3 = "";
			int num = 0;
			if (gclass17_0.method_2("ip_iTypeChangeIp") == 9)
			{
				text3 = method_14(int_3, "cProxy");
				num = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			if (text2 == "" || text3.Split(':').Length == 4)
			{
				text2 = Class49.string_7;
			}
			string text4 = "";
			if (!Class32.smethod_2(string_2, text2, text3, num).StartsWith("1|"))
			{
				text4 = "Cookie die";
			}
			else
			{
				text = "Live";
				text4 = "Cookie live";
			}
			method_19(text4, "cStatus", int_3, 2, dtgvAcc);
			if (text != "")
			{
				method_9(string_, int_3, text);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Không check đươ\u0323c!"), "cStatus", int_3, 2, dtgvAcc);
		}
	}

	private void method_40(int int_3)
	{
		string string_ = dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
		string string_2 = dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
		string string_3 = dtgvAcc.Rows[int_3].Cells["cPassword"].Value.ToString();
		string text = Class309.smethod_3(dtgvAcc, int_3, "cUseragent");
		string text2 = "";
		int num = 0;
		if (gclass17_0.method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = method_14(int_3, "cProxy");
			num = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		if (text == "" || text2.Split(':').Length == 4)
		{
			text = Class49.string_7;
		}
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = Class32.smethod_21(string_2, string_3, "", text2, num);
		switch (text6.Split('|')[0])
		{
		case "3":
			text3 = "Changed pass";
			break;
		case "2":
			text3 = ((!(text6.Split('|')[1].Trim() != "")) ? GClass29.smethod_0("Checkpoint") : ("Checkpoint: " + text6.Split('|')[1]));
			break;
		case "1":
			text5 = text6.Split('|')[1];
			text3 = "Live";
			break;
		case "5":
			text4 = GClass29.smethod_0("Không check đươ\u0323c (Co\u0301 2fa)!");
			break;
		case "0":
		case "4":
			text4 = GClass29.smethod_0("Không check đươ\u0323c!");
			break;
		}
		if (text4 == "")
		{
			text4 = GClass29.smethod_0("Đa\u0303 check xong!");
		}
		if (text5 != "")
		{
			Class36.smethod_13(string_, "cookie1", text5);
			method_19(text5, "cCookies", int_3, 1, dtgvAcc);
		}
		if (text3 != "")
		{
			method_9(string_, int_3, text3);
		}
		method_19(text4, "cStatus", int_3, 1, dtgvAcc);
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		method_34(0);
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		if (GClass38.smethod_1(GClass29.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.Yes)
		{
			method_34(1);
		}
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		method_34(2);
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		method_34(3);
	}

	private void mailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("mail");
	}

	private void BtnSearch_Click(object sender, EventArgs e)
	{
		try
		{
			if (cbbSearch.SelectedIndex == -1)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn kiểu tìm kiếm!"));
				return;
			}
			string columnName = cbbSearch.SelectedValue.ToString();
			string text = txbSearch.Text.Trim();
			if (text == "")
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập nội dung tìm kiếm!"));
				return;
			}
			List<int> list = new List<int>();
			text = GClass14.smethod_98(text.ToLower());
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string text2 = dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
				text2 = GClass14.smethod_98(text2.ToLower());
				text = GClass14.smethod_98(text.ToLower());
				if (text2.Contains(text))
				{
					list.Add(i);
				}
			}
			int index = 0;
			if (list.Count <= 0)
			{
				return;
			}
			int index2 = dtgvAcc.CurrentRow.Index;
			if (index2 >= list[list.Count - 1])
			{
				index = 0;
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (index2 < list[j])
					{
						index = j;
						break;
					}
				}
			}
			int index3 = list[index];
			dtgvAcc.CurrentCell = dtgvAcc.Rows[index3].Cells[columnName];
			dtgvAcc.ClearSelection();
			dtgvAcc.Rows[index3].Selected = true;
		}
		catch
		{
		}
	}

	private void uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid|pass|token|cookie|mail|passmail|fa2");
	}

	private void method_41()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			Class309.smethod_5(dtgvAcc, i, "cSTT", i + 1);
		}
	}

	private void fAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("2fa");
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		if (GClass38.smethod_1(string.Format(GClass29.smethod_0("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), method_49())) != DialogResult.Yes)
		{
			return;
		}
		method_45();
		int int_0 = 0;
		int int_1 = gclass17_0.method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_19(GClass29.smethod_0("Đang xo\u0301a profile..."), "cStatus", int_2, 0, dtgvAcc);
							method_42(int_2);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_42(int int_3)
	{
		try
		{
			string string_ = dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_19(GClass29.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, dtgvAcc);
				return;
			}
			string path = gclass17_0.method_0("txbPathProfile") + "\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_19(GClass29.smethod_0("Xóa profile thành công!"), "cStatus", int_3, 0, dtgvAcc);
				method_19("No", "cProfile", int_3, 0, dtgvAcc);
				Class36.smethod_13(string_, "profile", "No");
			}
			else
			{
				method_19(GClass29.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, dtgvAcc);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Xóa profile thất bại!"), "cStatus", int_3, 0, dtgvAcc);
		}
	}

	private void checkProfileToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_19(GClass29.smethod_0("Đang check profile..."), "cStatus", int_2, 0, dtgvAcc);
							method_43(int_2);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_43(int int_3)
	{
		try
		{
			string string_ = dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
			string path = gclass17_0.method_0("txbPathProfile") + "\\" + text;
			if (Directory.Exists(path))
			{
				method_19(GClass29.smethod_0("Đã có profile!"), "cStatus", int_3, 0, dtgvAcc);
				method_19("Yes", "cProfile", int_3, 0, dtgvAcc);
				Class36.smethod_13(string_, "profile", "Yes");
			}
			else
			{
				method_19(GClass29.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, dtgvAcc);
				method_19("No", "cProfile", int_3, 0, dtgvAcc);
				Class36.smethod_13(string_, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void donDepProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			GClass14.smethod_33(new fClearProfile());
		}
		catch (Exception ex)
		{
			GClass38.smethod_0(ex.ToString(), 3);
		}
	}

	public void method_44(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	private void pictureBox1_DoubleClick(object sender, EventArgs e)
	{
		method_44("Chrome");
	}

	private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_21("uid|pass|2fa");
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(method_14(i, "cUid") + "|" + method_14(i, "cPassword") + "|" + method_14(i, "cToken") + "|" + method_14(i, "cCookies") + "|" + method_14(i, "cEmail") + "|" + method_14(i, "cPassMail") + "|" + method_14(i, "cFa2") + "|" + method_14(i, "cUseragent") + "|" + method_14(i, "cProxy").Split('*')[0] + "|" + method_14(i, "cName") + "|" + method_14(i, "cGender") + "|" + method_14(i, "cFollow") + "|" + method_14(i, "cFriend") + "|" + method_14(i, "cGroup") + "|" + method_14(i, "cBirthday") + "|" + method_14(i, "cDateCreateAcc"));
				}
			}
			if (list.Count <= 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
			}
			else
			{
				GClass14.smethod_33(new fCopy_1(list));
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Error Copy");
		}
	}

	private void toolStripMenuItem_13_Click(object sender, EventArgs e)
	{
		method_21("ma2fa");
	}

	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
	}

	private void method_45()
	{
		gclass17_0 = new GClass17("configGeneral");
	}

	private void toolStripMenuItem_19_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Interlocked.Increment(ref int_0);
							int int_2 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = Class309.smethod_3(dtgvAcc, int_2, "cCookies");
									string text = Class309.smethod_3(dtgvAcc, int_2, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(.*?);").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										Class309.smethod_5(dtgvAcc, int_2, "cStatus", GClass29.smethod_0("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref int_0);
								}
								catch (Exception ex2)
								{
									GClass22.smethod_22(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass22.smethod_21(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					GClass22.smethod_21(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass22.smethod_22(null, ex.ToString());
			}
		}).Start();
	}

	private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = "";
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
		{
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				return;
			}
			text = folderBrowserDialog.SelectedPath;
		}
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists("backup\\" + text2 + "\\" + text2 + ".html"))
					{
						File.Copy("backup\\" + text2 + "\\" + text2 + ".html", text + "\\" + text2 + ".html");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		GClass38.smethod_0(string.Format(GClass29.smethod_0("Copy thành công {0} tệp backup html!"), num));
	}

	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		string text = "";
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
		{
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				return;
			}
			text = folderBrowserDialog.SelectedPath;
		}
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (!Directory.Exists(text + "\\" + text2))
					{
						Directory.CreateDirectory(text + "\\" + text2);
					}
					string[] files = Directory.GetFiles("backup\\" + text2);
					for (int j = 0; j < files.Length; j++)
					{
						File.Copy(files[j], text + "\\" + text2 + "\\" + Path.GetFileName(files[j]));
					}
					num++;
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		GClass38.smethod_0(string.Format(GClass29.smethod_0("Copy thành công {0} thư mục backup!"), num));
	}

	private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow" };
		if (list.Contains(e.Column.Name))
		{
			e.SortResult = int.Parse((e.CellValue1.ToString() == "") ? "-1" : e.CellValue1.ToString()).CompareTo(int.Parse((e.CellValue2.ToString() == "") ? "-1" : e.CellValue2.ToString()));
			e.Handled = true;
		}
		else
		{
			e.SortResult = ((e.CellValue1.ToString() == "") ? "" : e.CellValue1.ToString()).CompareTo((e.CellValue2.ToString() == "") ? "" : e.CellValue2.ToString());
			e.Handled = true;
		}
	}

	private void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fCauHinhHienThi());
		method_2();
	}

	private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = gclass17_0.method_2("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_27("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_19(GClass29.smethod_0("Đang kiểm tra..."), "cStatus", int_2, 0, dtgvAcc);
							method_46(int_2);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_27("stop");
		}).Start();
	}

	private void method_46(int int_3)
	{
		try
		{
			string text = dtgvAcc.Rows[int_3].Cells["cProxy"].Value.ToString();
			int num = 0;
			if (text.EndsWith("*1"))
			{
				num = 1;
			}
			text = text.Substring(0, text.Length - 2);
			int num2 = 0;
			int num3 = 0;
			string text2 = "";
			bool flag = false;
			for (int i = 0; i < 10; i++)
			{
				text2 = GClass14.smethod_67(text, num);
				if (text2 != "")
				{
					num2++;
					if (num2 == 3)
					{
						flag = true;
						break;
					}
				}
				else
				{
					num3++;
					if (num3 == 3)
					{
						break;
					}
				}
			}
			if (!flag)
			{
				method_19("Proxy Die!", "cStatus", int_3, 2, dtgvAcc);
			}
			else
			{
				method_19("Proxy Live!", "cStatus", int_3, 2, dtgvAcc);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Lỗi!!!"), "cStatus", int_3, 2, dtgvAcc);
		}
	}

	private void useragentToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_21("useragent");
	}

	private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_21("proxy");
	}

	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (bool_0)
			{
				break;
			}
			if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			string text = "backup\\" + Class309.smethod_3(dtgvAcc, i, "cUid");
			if (Directory.Exists(text))
			{
				try
				{
					Process.Start(text);
					method_28(i, GClass29.smethod_0("Mở thành công!"));
				}
				catch
				{
					method_28(i, GClass29.smethod_0("Mở thất bại!"));
				}
			}
			else
			{
				method_28(i, GClass29.smethod_0("Chưa backup!"));
			}
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			try
			{
				Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
			}
			catch
			{
			}
		}
	}

	private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_3 || cbbTinhTrang.SelectedValue == null || !GClass39.smethod_0(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && int_2 == cbbTinhTrang.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				method_4(method_3(), cbbTinhTrang.Text);
			}
			else
			{
				method_4(fChonThuMuc.list_1, cbbTinhTrang.Text);
			}
		}
		else
		{
			method_4(null, cbbTinhTrang.Text);
		}
		int_2 = cbbTinhTrang.SelectedIndex;
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_24();
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		method_34(4);
	}

	private void method_47(object sender, EventArgs e)
	{
		method_21("name");
	}

	private void method_48(object sender, EventArgs e)
	{
		method_21("birthday");
	}

	public int method_49()
	{
		int num = 0;
		try
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					num++;
				}
			}
		}
		catch
		{
		}
		return num;
	}

	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		if (GClass38.smethod_1(string.Format(GClass29.smethod_0("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), method_49())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = gclass17_0.method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_19(GClass29.smethod_0("Đang xo\u0301a dữ liệu backup..."), "cStatus", int_2, 0, dtgvAcc);
							method_50(int_2);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_50(int int_3)
	{
		try
		{
			string string_ = dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_19(GClass29.smethod_0("Chưa backup!"), "cStatus", int_3, 0, dtgvAcc);
				return;
			}
			string path = "backup\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_19(GClass29.smethod_0("Xóa dữ liệu backup thành công!"), "cStatus", int_3, 0, dtgvAcc);
				method_19("", "cBackup", int_3, 0, dtgvAcc);
				Class36.smethod_13(string_, "backup", "");
			}
			else
			{
				method_19(GClass29.smethod_0("Chưa backup!"), "cStatus", int_3, 0, dtgvAcc);
			}
		}
		catch
		{
			method_19(GClass29.smethod_0("Xóa dữ liệu backup thất bại!"), "cStatus", int_3, 0, dtgvAcc);
		}
	}

	private void checkBackupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string string_0 = GClass36.smethod_1();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_8(int_2, GClass29.smethod_0("Đang check backup..."));
							method_51(int_2, string_0);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_51(int int_3, string string_0)
	{
		try
		{
			string string_ = dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
			string_0 = string_0 + "\\" + text + "\\" + text + ".txt";
			if (File.Exists(string_0))
			{
				method_8(int_3, GClass29.smethod_0("Đã backup!"));
				method_10(int_3, "cBackup", GClass14.smethod_12(string_0));
				Class36.smethod_13(string_, "backup", GClass14.smethod_12(string_0));
			}
			else
			{
				method_8(int_3, GClass29.smethod_0("Chưa backup!"));
				method_10(int_3, "cBackup", "");
				Class36.smethod_13(string_, "backup", "");
			}
		}
		catch
		{
		}
	}

	private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_34(5);
	}

	private void button9_Click(object sender, EventArgs e)
	{
		method_52();
	}

	private void method_52()
	{
		if (method_49() == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n khôi phu\u0323c!"), 3);
			return;
		}
		GClass14.smethod_33(new fCauHinhKhoiPhucTaiKhoan());
		if (fCauHinhKhoiPhucTaiKhoan.bool_0)
		{
			try
			{
				if (fCauHinhKhoiPhucTaiKhoan.int_0 == 0)
				{
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					for (int i = 0; i < dtgvAcc.RowCount; i++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
						{
							string text = Class309.smethod_3(dtgvAcc, i, "cId");
							string item = Class36.smethod_28(text);
							list.Add(text);
							list2.Add(item);
							dtgvAcc.Rows.RemoveAt(i--);
						}
					}
					method_41();
					Class36.smethod_18(list2, "active", "1");
					if (Class36.smethod_17(list, "active", "1"))
					{
						GClass38.smethod_0(string.Format(GClass29.smethod_0("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list.Count));
					}
					else
					{
						GClass38.smethod_0(GClass29.smethod_0("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
					}
				}
				else
				{
					string string_ = fCauHinhKhoiPhucTaiKhoan.string_0;
					List<string> list3 = new List<string>();
					for (int j = 0; j < dtgvAcc.RowCount; j++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
						{
							string item2 = Class309.smethod_3(dtgvAcc, j, "cId");
							list3.Add(item2);
							dtgvAcc.Rows.RemoveAt(j--);
						}
					}
					method_41();
					if (Class36.smethod_17(list3, "idFile", string_) && Class36.smethod_17(list3, "active", "1"))
					{
						GClass38.smethod_0(string.Format(GClass29.smethod_0("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list3.Count));
					}
					else
					{
						GClass38.smethod_0(GClass29.smethod_0("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
					}
				}
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_, "Khoi Phuc Tai Khoan");
			}
		}
		method_30();
		method_29();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_24();
	}

	private void toolStripMenuItem_20_Click(object sender, EventArgs e)
	{
		method_52();
	}

	public List<string> method_53()
	{
		List<string> list = new List<string>();
		try
		{
			if (gclass17_0.method_2("typeApiTinsoft") == 0)
			{
				GClass19 gClass = new GClass19("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = gClass.method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + gclass17_0.method_0("txtApiUser"));
				JObject jObject = JObject.Parse(json);
				foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
				{
					if (Convert.ToBoolean(item["success"]!.ToString()))
					{
						list.Add(item["key"]!.ToString());
					}
				}
			}
			else
			{
				List<string> list2 = gclass17_0.method_1("txtApiProxy");
				foreach (string item2 in list2)
				{
					if (Class40.smethod_1(item2))
					{
						list.Add(item2);
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	private void method_54()
	{
		try
		{
			gclass17_2 = new GClass17("configOpenBrowser");
			string string_0 = "";
			if (gclass17_2.method_3("isUseProfile"))
			{
				string_0 = GClass36.smethod_0();
				if (!Directory.Exists(string_0))
				{
					GClass38.smethod_0(GClass29.smethod_0("Đường dẫn profile không hợp lệ!"), 3);
					return;
				}
			}
			if (Class49.string_7 == "")
			{
				Class49.string_7 = GClass15.smethod_24();
				if (Class49.string_7 == "")
				{
					GClass38.smethod_0(GClass29.smethod_0("Phiên bản Chromedriver hiện tại không khả dụng, vui lòng cập nhật!"), 3);
					return;
				}
			}
			method_45();
			int int_0 = method_49();
			switch (gclass17_0.method_2("ip_iTypeChangeIp"))
			{
			case 7:
			{
				list_7 = method_53();
				if (list_7.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Proxy Tinsoft không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_4 = new List<Class40>();
				for (int j = 0; j < list_7.Count; j++)
				{
					Class40 item2 = new Class40(list_7[j], gclass17_0.method_2("nudLuongPerIPTinsoft"), gclass17_0.method_2("cbbLocationTinsoft"));
					list_4.Add(item2);
				}
				if (list_7.Count * gclass17_0.method_2("nudLuongPerIPTinsoft") < int_0)
				{
					int_0 = list_7.Count * gclass17_0.method_2("nudLuongPerIPTinsoft");
				}
				break;
			}
			case 8:
			{
				list_8 = gclass17_0.method_1("txtListProxy");
				if (list_8.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Proxy không đủ, vui lòng cấu hình lại!"), 2);
					return;
				}
				list_5 = new List<Class47>();
				for (int k = 0; k < list_8.Count; k++)
				{
					Class47 item3 = new Class47(gclass17_0.method_0("txtServiceURLXProxy"), list_8[k], gclass17_0.method_2("typeProxy"), gclass17_0.method_2("nudLuongPerIPXProxy"));
					list_5.Add(item3);
				}
				if (list_8.Count * gclass17_0.method_2("nudLuongPerIPXProxy") < int_0)
				{
					int_0 = list_8.Count * gclass17_0.method_2("nudLuongPerIPXProxy");
				}
				break;
			}
			case 10:
			{
				list_9 = gclass17_0.method_1("txtApiKeyTMProxy");
				if (list_9.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("TMProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_6 = new List<Class41>();
				for (int i = 0; i < list_9.Count; i++)
				{
					Class41 item = new Class41(list_9[i], 0, gclass17_0.method_2("nudLuongPerIPTMProxy"));
					list_6.Add(item);
				}
				if (list_9.Count * gclass17_0.method_2("nudLuongPerIPTMProxy") < int_0)
				{
					int_0 = list_9.Count * gclass17_0.method_2("nudLuongPerIPTMProxy");
				}
				break;
			}
			}
			bool_0 = false;
			List<int> list_0 = new List<int>();
			for (int l = 0; l < method_49(); l++)
			{
				list_0.Add(0);
			}
			this.int_0 = 0;
			list_10 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					if (gclass17_0.method_2("ip_iTypeChangeIp") == 8 && gclass17_0.method_2("typeRunXproxy") == 1)
					{
						for (int m = 0; m < list_5.Count; m++)
						{
							list_5[m].method_1();
						}
					}
					int num = 0;
					while (num < dtgvAcc.Rows.Count && !bool_0)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
						{
							if (bool_0 || list_10.Count >= int_0)
							{
								break;
							}
							if (bool_0)
							{
								break;
							}
							int int_ = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									int int_2 = GClass14.smethod_65(ref list_0);
									method_55(int_, int_2, string_0);
								}
								catch (Exception exception_3)
								{
									GClass14.smethod_75(null, exception_3);
								}
							})
							{
								Name = int_.ToString()
							};
							list_10.Add(thread);
							GClass14.smethod_58(1.0);
							thread.Start();
						}
						else
						{
							num++;
						}
						if (bool_0)
						{
							break;
						}
					}
					for (int n = 0; n < list_10.Count; n++)
					{
						list_10[n].Join();
					}
				}
				catch (Exception exception_2)
				{
					GClass14.smethod_75(null, exception_2);
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
		}
	}

	private void method_55(int int_3, int int_4, string string_0)
	{
		string text = "";
		GClass12 gClass = null;
		int num = 0;
		bool flag = false;
		string text2 = "";
		int int32_ = 0;
		string text3 = "";
		Class40 @class = null;
		Class47 class2 = null;
		Class41 class3 = null;
		bool flag2 = false;
		string text4 = "";
		string text5 = method_14(int_3, "cUid");
		string string_ = method_14(int_3, "cId");
		string text6 = method_14(int_3, "cEmail");
		string string_2 = method_14(int_3, "cFa2");
		string text7 = method_14(int_3, "cPassword");
		string text8 = method_14(int_3, "cCookies");
		method_14(int_3, "cToken");
		string text9 = method_14(int_3, "cUseragent");
		if (text5 == "")
		{
			text5 = Regex.Match(text8, "c_user=(.*?);").Groups[1].Value;
		}
		if (bool_0)
		{
			method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
		}
		else
		{
			while (true)
			{
				switch (gclass17_0.method_2("ip_iTypeChangeIp"))
				{
				case 10:
					method_8(int_3, GClass29.smethod_0("Đang lấy TMProxy..."));
					lock (object_0)
					{
						while (!bool_0)
						{
							class3 = null;
							while (!bool_0)
							{
								foreach (Class41 item in list_6)
								{
									if (class3 == null || item.int_5 < class3.int_5)
									{
										class3 = item;
									}
								}
								if (class3.int_5 != class3.int_6)
								{
									break;
								}
							}
							if (bool_0)
							{
								break;
							}
							if (class3.int_5 > 0 || class3.method_4())
							{
								text = class3.String_1;
								if (text == "")
								{
									text = class3.method_7();
								}
								class3.int_4++;
								class3.int_5++;
								break;
							}
						}
						if (bool_0)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
							break;
						}
						if (gclass17_0.method_2("nudDelayCheckIP") > 0)
						{
							Class309.smethod_0(dtgvAcc, int_3, "cStatus", gclass17_0.method_2("nudDelayCheckIP"), text2 + "Delay after change ip {time}s...");
						}
						bool flag5 = true;
						if (!gclass17_0.method_3("ckbKhongCheckIP"))
						{
							text2 = "(IP: " + text.Split(':')[0] + ") ";
							method_8(int_3, text2 + "Check IP...");
							text3 = GClass14.smethod_67(text, 0);
							if (text3 == "")
							{
								flag5 = false;
							}
						}
						if (!flag5)
						{
							class3.int_4--;
							class3.int_5--;
							continue;
						}
						goto default;
					}
				case 8:
					method_8(int_3, GClass29.smethod_0("Đang lấy Proxy..."));
					lock (object_0)
					{
						if (gclass17_0.method_2("typeRunXproxy") == 0)
						{
							while (!bool_0)
							{
								class2 = null;
								while (!bool_0)
								{
									foreach (Class47 item2 in list_5)
									{
										if (item2.bool_0 && (class2 == null || item2.int_2 < class2.int_2))
										{
											class2 = item2;
										}
									}
									if (class2.int_2 != class2.int_3)
									{
										break;
									}
								}
								if (bool_0)
								{
									break;
								}
								if (class2.bool_0)
								{
									bool flag3 = false;
									if (class2.int_2 > 0)
									{
										flag3 = true;
									}
									else
									{
										switch (class2.method_2())
										{
										case 0:
											class2.bool_0 = false;
											break;
										case 1:
											flag3 = true;
											break;
										}
									}
									if (flag3)
									{
										text = class2.string_1;
										int32_ = class2.int_0;
										class2.int_1++;
										class2.int_2++;
										break;
									}
								}
								else
								{
									class2.bool_0 = false;
								}
							}
						}
						else
						{
							while (!bool_0)
							{
								class2 = null;
								List<Class47> list = new List<Class47>();
								foreach (Class47 item3 in list_5)
								{
									if (item3.bool_0)
									{
										if (item3.int_2 < item3.int_3)
										{
											list.Add(item3);
										}
										else if (item3.int_1 == 0)
										{
											item3.method_1();
											item3.int_2 = 0;
										}
									}
								}
								for (int i = 0; i < list.Count; i++)
								{
									if (list[i].method_4(0))
									{
										class2 = list[i];
										break;
									}
								}
								if (class2 != null)
								{
									text = class2.string_1;
									int32_ = class2.int_0;
									class2.int_1++;
									class2.int_2++;
									break;
								}
							}
						}
						if (bool_0)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
							break;
						}
						if (gclass17_0.method_2("nudDelayCheckIP") > 0)
						{
							Class309.smethod_0(dtgvAcc, int_3, "cStatus", gclass17_0.method_2("nudDelayCheckIP"), text2 + "Delay after change ip {time}s...");
						}
						bool flag4 = true;
						if (!gclass17_0.method_3("ckbKhongCheckIP"))
						{
							text2 = "(IP: " + text + ") ";
							method_8(int_3, text2 + "Check IP...");
							text3 = GClass14.smethod_67(text, int32_, gclass17_0.method_2("nudDelayResetXProxy", 1) * 60);
							if (text3 == "")
							{
								class2.bool_0 = false;
								flag4 = false;
							}
						}
						if (!flag4)
						{
							class2.int_1--;
							class2.int_2--;
							continue;
						}
						goto default;
					}
				case 7:
					method_8(int_3, GClass29.smethod_0("Đang lấy proxy Tinsoft..."));
					lock (object_0)
					{
						while (!bool_0)
						{
							@class = null;
							while (!bool_0)
							{
								foreach (Class40 item4 in list_4)
								{
									if (@class == null || item4.int_6 < @class.int_6)
									{
										@class = item4;
									}
								}
								if (@class.int_6 != @class.int_7)
								{
									break;
								}
							}
							if (bool_0)
							{
								break;
							}
							if (@class.int_6 > 0 || @class.method_2())
							{
								text = @class.String_1;
								if (text == "")
								{
									text = @class.method_3();
								}
								@class.int_5++;
								@class.int_6++;
								break;
							}
						}
						if (bool_0)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
							break;
						}
						if (gclass17_0.method_2("nudDelayCheckIP") > 0)
						{
							Class309.smethod_0(dtgvAcc, int_3, "cStatus", gclass17_0.method_2("nudDelayCheckIP"), text2 + "Delay after change ip {time}s...");
						}
						bool flag6 = true;
						if (!gclass17_0.method_3("ckbKhongCheckIP"))
						{
							text2 = "(IP: " + text.Split(':')[0] + ") ";
							method_8(int_3, text2 + "Check IP...");
							text3 = GClass14.smethod_67(text, 0);
							if (text3 == "")
							{
								flag6 = false;
							}
						}
						if (!flag6)
						{
							@class.int_5--;
							@class.int_6--;
							continue;
						}
						goto default;
					}
				case 9:
					text = method_14(int_3, "cProxy");
					int32_ = (text.EndsWith("*1") ? 1 : 0);
					if (text.EndsWith("*0") || text.EndsWith("*1"))
					{
						text = text.Substring(0, text.Length - 2);
					}
					goto default;
				default:
					{
						if (bool_0)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
							break;
						}
						if (!gclass17_0.method_3("ckbKhongCheckIP"))
						{
							if (gclass17_0.method_2("ip_iTypeChangeIp") != 7 && gclass17_0.method_2("ip_iTypeChangeIp") != 8 && gclass17_0.method_2("ip_iTypeChangeIp") != 10)
							{
								if (text != "")
								{
									text2 = "(IP: " + text.Split(':')[0] + ") ";
								}
								method_8(int_3, text2 + "Check IP...");
								bool flag7 = false;
								int num2 = 0;
								while (num2 < 30)
								{
									GClass14.smethod_58(1.0);
									text3 = GClass14.smethod_67(text, int32_);
									if (!(text3 != ""))
									{
										if (!bool_0)
										{
											num2++;
											continue;
										}
										goto IL_0a85;
									}
									flag7 = true;
									break;
								}
								if (!flag7)
								{
									if (text != "")
									{
										method_8(int_3, text2 + GClass29.smethod_0("Không thể kết nối proxy!"));
									}
									else
									{
										method_8(int_3, text2 + GClass29.smethod_0("Không có kết nối Internet!"));
									}
									break;
								}
							}
							text2 = ((text3 == "") ? "" : ("(IP: " + text3 + ") "));
						}
						if (bool_0)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
							break;
						}
						try
						{
							method_8(int_3, text2 + GClass29.smethod_0("Chờ đến lượt..."));
							lock (object_2)
							{
								if (int_0 > 0)
								{
									int num3 = random_0.Next(gclass17_0.method_2("nudDelayOpenChromeFrom", 1), gclass17_0.method_2("nudDelayOpenChromeTo", 1) + 1);
									if (num3 > 0)
									{
										int tickCount = Environment.TickCount;
										while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
										{
											method_8(int_3, text2 + GClass29.smethod_0("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString()));
											GClass14.smethod_58(0.5);
											if (!bool_0)
											{
												continue;
											}
											method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
											goto end_IL_0ac8;
										}
									}
								}
								else
								{
									int_0++;
								}
							}
							method_8(int_3, text2 + GClass29.smethod_0("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
							if (text9 == "" || text.Split(':').Length == 4)
							{
								text9 = Class49.string_7;
							}
							string text10 = string_0 + "\\" + text5;
							if (!gclass17_2.method_3("isUseProfile"))
							{
								text10 = "";
							}
							Point point_ = GClass14.smethod_64(int_4, 5, 2);
							Point point_2 = GClass14.smethod_63(5, 2);
							gClass = new GClass12
							{
								Boolean_2 = !Convert.ToBoolean((gclass17_0.method_0("ckbShowImageInteract") == "") ? "false" : gclass17_0.method_0("ckbShowImageInteract")),
								String_0 = text9,
								String_1 = text10,
								Point_0 = point_2,
								Point_1 = point_,
								Int32_1 = 3,
								Int32_2 = 120,
								String_2 = text,
								Int32_3 = int32_,
								Boolean_6 = gclass17_0.method_3("ckbUsePortable"),
								String_6 = gclass17_0.method_0("txtPathToPortableZip")
							};
							if (bool_0)
							{
								method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
								break;
							}
							if (gclass17_0.method_2("typeBrowser") != 0)
							{
								gClass.String_4 = gclass17_0.method_0("txtLinkToOtherBrowser");
							}
							if (!gClass.method_0())
							{
								method_8(int_3, text2 + GClass29.smethod_0("Lỗi mở trình duyệt!"));
								break;
							}
							method_8(int_3, text2 + GClass29.smethod_0("Đang đăng nhâ\u0323p..."));
							string text11 = "";
							text11 = ((gclass17_2.method_2("typeBrowserLogin") != 0) ? "https://www.facebook.com/" : "https://m.facebook.com/");
							if (text10.Trim() != "")
							{
								num = GClass15.smethod_34(gClass, text11);
								switch (num)
								{
								case -3:
									gClass.GEnum10_0 = GEnum10.const_6;
									goto end_IL_0ac8;
								case -2:
									gClass.GEnum10_0 = GEnum10.const_1;
									goto end_IL_0ac8;
								case 1:
									flag = true;
									break;
								case 2:
									gClass.GEnum10_0 = GEnum10.const_4;
									method_9(string_, int_3, GClass29.smethod_0("Checkpoint"));
									goto end_IL_0ac8;
								}
							}
							if (!flag)
							{
								string text12 = "";
								switch (gclass17_2.method_2("typeLogin"))
								{
								case 0:
									if (text5.Trim() == "" || text7.Trim() == "")
									{
										if (text5.Trim() == "")
										{
											method_8(int_3, text2 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y UID!"));
										}
										else if (text7.Trim() == "")
										{
											method_8(int_3, text2 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Pass!"));
										}
										goto end_IL_0893;
									}
									method_8(int_3, text2 + GClass29.smethod_0("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
									text12 = GClass15.smethod_30(gClass, text5, text7, string_2, text11, 2);
									try
									{
										num = Convert.ToInt32(text12);
									}
									catch
									{
										num = -1;
									}
									goto default;
								case 1:
									if (text6.Trim() == "" || text7.Trim() == "")
									{
										if (text6.Trim() == "")
										{
											method_8(int_3, text2 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Email!"));
										}
										else if (text7.Trim() == "")
										{
											method_8(int_3, text2 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Pass!"));
										}
										goto end_IL_0893;
									}
									method_8(int_3, text2 + GClass29.smethod_0("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
									text12 = GClass15.smethod_30(gClass, text6, text7, string_2, text11, 2);
									try
									{
										num = Convert.ToInt32(text12);
									}
									catch
									{
										num = -1;
									}
									goto default;
								case 2:
									if (text8.Trim() == "")
									{
										method_8(int_3, text2 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Cookie!"));
										goto end_IL_0893;
									}
									method_8(int_3, text2 + GClass29.smethod_0("Đăng nhâ\u0323p bă\u0300ng cookie..."));
									num = Convert.ToInt32(GClass15.smethod_25(gClass, text8, text11));
									goto default;
								default:
									if (gclass17_2.method_2("typeLogin") != 2)
									{
										switch (num)
										{
										case -2:
											gClass.GEnum10_0 = GEnum10.const_1;
											break;
										case -1:
											method_8(int_3, text2 + text12);
											break;
										case 0:
											method_8(int_3, text2 + GClass29.smethod_0("Đăng nhập thất bại!"));
											GClass15.smethod_46(gClass, bool_0: true);
											if (gClass.GEnum10_0 == GEnum10.const_5)
											{
												flag = true;
											}
											break;
										case 1:
											flag = true;
											break;
										case 2:
											gClass.GEnum10_0 = GEnum10.const_4;
											method_9(string_, int_3, GClass29.smethod_0("Checkpoint"));
											break;
										case 3:
											method_8(int_3, text2 + GClass29.smethod_0("Không có 2fa!"));
											break;
										case 4:
											method_8(int_3, text2 + GClass29.smethod_0("Tài khoản không đúng!"));
											break;
										case 5:
											method_8(int_3, text2 + GClass29.smethod_0("Mật khẩu không đúng!"));
											method_9(string_, int_3, "Changed pass");
											break;
										case 6:
											method_8(int_3, text2 + GClass29.smethod_0("Mã 2fa không đúng!"));
											break;
										case 7:
											gClass.GEnum10_0 = GEnum10.const_6;
											break;
										}
										if (flag)
										{
											break;
										}
										method_6(int_3, 1);
										goto end_IL_0893;
									}
									switch (num)
									{
									case -3:
										gClass.GEnum10_0 = GEnum10.const_6;
										goto end_IL_0ac8;
									case -2:
										gClass.GEnum10_0 = GEnum10.const_1;
										goto end_IL_0ac8;
									case 1:
										flag = true;
										goto default;
									default:
										if (flag)
										{
											break;
										}
										method_6(int_3, 1);
										method_8(int_3, text2 + GClass29.smethod_0("Đăng nhâ\u0323p thâ\u0301t ba\u0323i!"));
										goto end_IL_0ac8;
									case 2:
										gClass.GEnum10_0 = GEnum10.const_4;
										method_9(string_, int_3, GClass29.smethod_0("Checkpoint"));
										goto end_IL_0ac8;
									}
									break;
								}
							}
							if (gclass17_2.method_2("typeBrowserLogin") == 1 && !gClass.method_12().StartsWith(text11))
							{
								gClass.method_13(text11);
							}
							method_8(int_3, text2 + GClass29.smethod_0("Đăng nhâ\u0323p tha\u0300nh công!"));
							method_6(int_3, 2);
							if (gclass17_2.method_3("ckbAutoOpenLink"))
							{
								gClass.method_13(gclass17_2.method_0("txtLink"));
							}
							if (flag2 = !method_26(text5))
							{
								text4 = text5;
								text5 = Regex.Match(gClass.method_62() + ";", "c_user=(.*?);").Groups[1].Value;
								Class36.smethod_13(string_, "uid", text5);
								method_10(int_3, "cUid", text5);
							}
							if (gclass17_2.method_3("isGetCookie"))
							{
								text8 = gClass.method_62();
								Class36.smethod_13(string_, "uid", text5);
								Class36.smethod_13(string_, "cookie1", text8);
								method_10(int_3, "cCookies", text8);
							}
							end_IL_0ac8:;
						}
						catch (Exception exception_)
						{
							method_8(int_3, text2 + GClass29.smethod_0("Lô\u0303i không xa\u0301c đi\u0323nh!"));
							GClass14.smethod_75(gClass, exception_);
						}
						break;
					}
					IL_0a85:
					method_8(int_3, text2 + GClass29.smethod_0("Đã dừng!"));
					break;
					end_IL_0893:
					break;
				}
				break;
			}
		}
		if (gClass != null)
		{
			GEnum10 gEnum10_ = gClass.GEnum10_0;
			GEnum10 gEnum = gEnum10_;
			if (gEnum == GEnum10.const_1 || gEnum == GEnum10.const_4 || gEnum == GEnum10.const_6)
			{
				method_6(int_3, 1);
				method_8(int_3, text2 + GClass40.smethod_0(gClass.GEnum10_0));
			}
		}
		if (!flag && gclass17_2.method_3("isAutoCloseChromeLoginFail"))
		{
			try
			{
				gClass.method_58();
			}
			catch
			{
			}
		}
		if (flag2 && Directory.Exists(gclass17_0.method_0("txbPathProfile") + "\\" + text4))
		{
			string string_3 = gclass17_0.method_0("txbPathProfile") + "\\" + text4;
			string string_4 = gclass17_0.method_0("txbPathProfile") + "\\" + text5;
			if (!GClass14.smethod_94(string_3, string_4) && GClass14.smethod_93(string_3, string_4))
			{
				GClass14.smethod_95(string_3);
			}
		}
		lock (object_1)
		{
			switch (gclass17_0.method_2("ip_iTypeChangeIp"))
			{
			case 7:
				@class?.method_1();
				break;
			case 8:
				class2?.method_3(gclass17_0.method_2("typeRunXproxy"));
				break;
			case 10:
				class3?.method_2();
				break;
			case 9:
				break;
			}
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
			method_17();
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_23_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fMoTrinhDuyet());
	}

	private void toolStripMenuItem_22_Click(object sender, EventArgs e)
	{
		if (method_49() == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn tài khoản cần mở trình duyệt!"), 3);
		}
		else
		{
			method_54();
		}
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBin));
		this.dtgvAcc = new System.Windows.Forms.DataGridView();
		this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cInteractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cDateDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctmsAcc = new MetroFramework.Controls.MetroContextMenu(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_20 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_21 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_22 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_23 = new System.Windows.Forms.ToolStripMenuItem();
		this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieMailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.useragentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkBackupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		this.donDepProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.checkBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		this.toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		this.grQuanLyThuMuc = new System.Windows.Forms.GroupBox();
		this.btnLoadAcc = new MetroFramework.Controls.MetroButton();
		this.cbbTinhTrang = new MetroFramework.Controls.MetroComboBox();
		this.cbbThuMuc = new MetroFramework.Controls.MetroComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.grTimKiem = new System.Windows.Forms.GroupBox();
		this.BtnSearch = new MetroFramework.Controls.MetroButton();
		this.cbbSearch = new System.Windows.Forms.ComboBox();
		this.txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.statusStrip1 = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		this.button9 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
		this.ctmsAcc.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.grQuanLyThuMuc.SuspendLayout();
		this.grTimKiem.SuspendLayout();
		this.statusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.dtgvAcc.AllowUserToAddRows = false;
		this.dtgvAcc.AllowUserToDeleteRows = false;
		this.dtgvAcc.AllowUserToResizeRows = false;
		this.dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvAcc.Columns.AddRange(this.cChose, this.cStt, this.cId, this.cUid, this.cToken, this.cCookies, this.cEmail, this.cPhone, this.cName, this.cFollow, this.cFriend, this.cGroup, this.cBirthday, this.cGender, this.cPassword, this.cMailRecovery, this.cPassMail, this.cBackup, this.cFa2, this.cUseragent, this.cProxy, this.cDateCreateAcc, this.cAvatar, this.cProfile, this.cThuMuc, this.cInteractEnd, this.cInfo, this.cGhiChu, this.cDateDelete, this.cStatus);
		this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvAcc.Location = new System.Drawing.Point(2, 124);
		this.dtgvAcc.Name = "dtgvAcc";
		this.dtgvAcc.ReadOnly = true;
		this.dtgvAcc.RowHeadersVisible = false;
		this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvAcc.Size = new System.Drawing.Size(1199, 461);
		this.dtgvAcc.TabIndex = 0;
		this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		this.dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		this.dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(dtgvAcc_SortCompare);
		this.dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvAcc_KeyDown);
		this.cChose.HeaderText = "Chọn";
		this.cChose.Name = "cChose";
		this.cChose.ReadOnly = true;
		this.cChose.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Width = 35;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.cUid.HeaderText = "UID";
		this.cUid.Name = "cUid";
		this.cUid.ReadOnly = true;
		this.cUid.Width = 80;
		this.cToken.HeaderText = "Token";
		this.cToken.Name = "cToken";
		this.cToken.ReadOnly = true;
		this.cToken.Width = 70;
		this.cCookies.HeaderText = "Cookie";
		this.cCookies.Name = "cCookies";
		this.cCookies.ReadOnly = true;
		this.cCookies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cCookies.Width = 70;
		this.cEmail.HeaderText = "Email";
		this.cEmail.Name = "cEmail";
		this.cEmail.ReadOnly = true;
		this.cEmail.Width = 60;
		this.cPhone.HeaderText = "Phone";
		this.cPhone.Name = "cPhone";
		this.cPhone.ReadOnly = true;
		this.cPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cPhone.Visible = false;
		this.cPhone.Width = 90;
		this.cName.HeaderText = "Tên";
		this.cName.Name = "cName";
		this.cName.ReadOnly = true;
		this.cName.Width = 70;
		this.cFollow.HeaderText = "Theo do\u0303i";
		this.cFollow.Name = "cFollow";
		this.cFollow.ReadOnly = true;
		this.cFollow.Width = 80;
		this.cFriend.HeaderText = "Ba\u0323n be\u0300";
		this.cFriend.Name = "cFriend";
		this.cFriend.ReadOnly = true;
		this.cFriend.Width = 70;
		this.cGroup.HeaderText = "Nho\u0301m";
		this.cGroup.Name = "cGroup";
		this.cGroup.ReadOnly = true;
		this.cGroup.Width = 60;
		this.cBirthday.HeaderText = "Nga\u0300y sinh";
		this.cBirthday.Name = "cBirthday";
		this.cBirthday.ReadOnly = true;
		this.cBirthday.Width = 90;
		this.cGender.HeaderText = "Giới Tính";
		this.cGender.Name = "cGender";
		this.cGender.ReadOnly = true;
		this.cGender.Width = 80;
		this.cPassword.HeaderText = "Mật khẩu";
		this.cPassword.Name = "cPassword";
		this.cPassword.ReadOnly = true;
		this.cPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cPassword.Visible = false;
		this.cPassword.Width = 70;
		this.cMailRecovery.HeaderText = "Email khôi phục";
		this.cMailRecovery.Name = "cMailRecovery";
		this.cMailRecovery.ReadOnly = true;
		this.cMailRecovery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cMailRecovery.Visible = false;
		this.cMailRecovery.Width = 120;
		this.cPassMail.HeaderText = "Mật khẩu mail";
		this.cPassMail.Name = "cPassMail";
		this.cPassMail.ReadOnly = true;
		this.cPassMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cPassMail.Visible = false;
		this.cPassMail.Width = 120;
		this.cBackup.HeaderText = "Backup";
		this.cBackup.Name = "cBackup";
		this.cBackup.ReadOnly = true;
		this.cBackup.Width = 70;
		this.cFa2.HeaderText = "Mã 2FA";
		this.cFa2.Name = "cFa2";
		this.cFa2.ReadOnly = true;
		this.cFa2.Width = 65;
		this.cUseragent.HeaderText = "Useragent";
		this.cUseragent.Name = "cUseragent";
		this.cUseragent.ReadOnly = true;
		this.cUseragent.Width = 70;
		this.cProxy.HeaderText = "Proxy";
		this.cProxy.Name = "cProxy";
		this.cProxy.ReadOnly = true;
		this.cProxy.Width = 55;
		this.cDateCreateAcc.HeaderText = "Nga\u0300y ta\u0323o";
		this.cDateCreateAcc.Name = "cDateCreateAcc";
		this.cDateCreateAcc.ReadOnly = true;
		this.cDateCreateAcc.Width = 85;
		this.cAvatar.HeaderText = "Avatar";
		this.cAvatar.Name = "cAvatar";
		this.cAvatar.ReadOnly = true;
		this.cAvatar.Width = 50;
		this.cProfile.HeaderText = "Profile";
		this.cProfile.Name = "cProfile";
		this.cProfile.ReadOnly = true;
		this.cProfile.Width = 50;
		this.cThuMuc.HeaderText = "Thư mục";
		this.cThuMuc.Name = "cThuMuc";
		this.cThuMuc.ReadOnly = true;
		this.cInteractEnd.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		this.cInteractEnd.Name = "cInteractEnd";
		this.cInteractEnd.ReadOnly = true;
		this.cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.cInfo.HeaderText = "Tình Trạng";
		this.cInfo.Name = "cInfo";
		this.cInfo.ReadOnly = true;
		this.cInfo.Width = 90;
		this.cGhiChu.HeaderText = "Ghi Chú";
		this.cGhiChu.Name = "cGhiChu";
		this.cGhiChu.ReadOnly = true;
		this.cDateDelete.HeaderText = "Thơ\u0300i gian xo\u0301a";
		this.cDateDelete.Name = "cDateDelete";
		this.cDateDelete.ReadOnly = true;
		this.cDateDelete.Width = 111;
		this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cStatus.HeaderText = "Trạng Thái";
		this.cStatus.Name = "cStatus";
		this.cStatus.ReadOnly = true;
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.toolStripMenuItem_0, this.toolStripMenuItem_3, this.toolStripMenuItem_20, this.toolStripMenuItem_1, this.toolStripMenuItem_21, this.copyToolStripMenuItem, this.checkCookieToolStripMenuItem, this.profileToolStripMenuItem, this.backupToolStripMenuItem, this.toolStripMenuItem_6 });
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(198, 224);
		this.ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripMenuItem_2, this.liveToolStripMenuItem, this.tinhTrangToolStripMenuItem, this.toolStripMenuItem_8 });
		this.toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		this.toolStripMenuItem_0.Name = "chọnLiveToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_0.Text = "Chọn";
		this.toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_2.Name = "tấtCảToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_2.Text = "Tất cả";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.liveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
		this.liveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.liveToolStripMenuItem.Text = "Bôi đen";
		this.liveToolStripMenuItem.Click += new System.EventHandler(liveToolStripMenuItem_Click);
		this.tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		this.tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		this.toolStripMenuItem_8.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		this.toolStripMenuItem_8.Name = "trạngTháiToolStripMenuItem";
		this.toolStripMenuItem_8.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_8.Text = "Trạng thái";
		this.toolStripMenuItem_8.Click += new System.EventHandler(toolStripMenuItem_8_Click);
		this.toolStripMenuItem_3.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_3.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_3.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		this.toolStripMenuItem_20.Image = Class306.Bitmap_214;
		this.toolStripMenuItem_20.Name = "khôiPhucTaiKhoanToolStripMenuItem";
		this.toolStripMenuItem_20.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_20.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		this.toolStripMenuItem_20.Click += new System.EventHandler(toolStripMenuItem_20_Click);
		this.toolStripMenuItem_1.Image = Class306.Bitmap_111;
		this.toolStripMenuItem_1.Name = "xóaTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_1.Text = "Xóa ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.toolStripMenuItem_21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_22, this.toolStripMenuItem_23 });
		this.toolStripMenuItem_21.Image = (System.Drawing.Image)resources.GetObject("mởTrìnhDuyệtToolStripMenuItem.Image");
		this.toolStripMenuItem_21.Name = "mởTrìnhDuyệtToolStripMenuItem";
		this.toolStripMenuItem_21.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_21.Text = "Mở trình duyệt";
		this.toolStripMenuItem_22.Name = "tiếnHànhMởToolStripMenuItem";
		this.toolStripMenuItem_22.Size = new System.Drawing.Size(181, 22);
		this.toolStripMenuItem_22.Text = "Tiến hành mở";
		this.toolStripMenuItem_22.Click += new System.EventHandler(toolStripMenuItem_22_Click);
		this.toolStripMenuItem_23.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
		this.toolStripMenuItem_23.Size = new System.Drawing.Size(181, 22);
		this.toolStripMenuItem_23.Text = "Cài đặt cấu hình mở";
		this.toolStripMenuItem_23.Click += new System.EventHandler(toolStripMenuItem_23_Click);
		this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			this.uidToolStripMenuItem, this.passToolStripMenuItem, this.tokenToolStripMenuItem, this.cookieToolStripMenuItem, this.mailToolStripMenuItem, this.fAToolStripMenuItem, this.toolStripMenuItem_13, this.uidPassToolStripMenuItem, this.uidPass2FaToolStripMenuItem, this.mailPassMailToolStripMenuItem,
			this.uidPassTokenCookieToolStripMenuItem, this.uidPassTokenCookieMailPassMailToolStripMenuItem, this.uidPassTokenCookieMailPassMail2faToolStripMenuItem, this.useragentToolStripMenuItem1, this.proxyToolStripMenuItem1, this.toolStripMenuItem_11
		});
		this.copyToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		this.copyToolStripMenuItem.Text = "Copy";
		this.uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		this.uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidToolStripMenuItem.Text = "Uid";
		this.uidToolStripMenuItem.Click += new System.EventHandler(uidToolStripMenuItem_Click);
		this.passToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		this.passToolStripMenuItem.Name = "passToolStripMenuItem";
		this.passToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.passToolStripMenuItem.Text = "Pass";
		this.passToolStripMenuItem.Click += new System.EventHandler(passToolStripMenuItem_Click);
		this.tokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		this.tokenToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.tokenToolStripMenuItem.Text = "Token";
		this.tokenToolStripMenuItem.Click += new System.EventHandler(tokenToolStripMenuItem_Click);
		this.cookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		this.cookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.cookieToolStripMenuItem.Text = "Cookie";
		this.cookieToolStripMenuItem.Click += new System.EventHandler(cookieToolStripMenuItem_Click);
		this.mailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
		this.mailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.mailToolStripMenuItem.Text = "Email";
		this.mailToolStripMenuItem.Click += new System.EventHandler(mailToolStripMenuItem_Click);
		this.fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		this.fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.fAToolStripMenuItem.Text = "2FA";
		this.fAToolStripMenuItem.Click += new System.EventHandler(fAToolStripMenuItem_Click);
		this.toolStripMenuItem_13.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		this.toolStripMenuItem_13.Name = "maBaoMât6SôToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new System.Drawing.Size(289, 22);
		this.toolStripMenuItem_13.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301";
		this.toolStripMenuItem_13.Click += new System.EventHandler(toolStripMenuItem_13_Click);
		this.uidPassToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassToolStripMenuItem.Text = "Uid|Pass";
		this.uidPassToolStripMenuItem.Click += new System.EventHandler(uidPassToolStripMenuItem_Click);
		this.uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		this.uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		this.uidPass2FaToolStripMenuItem.Click += new System.EventHandler(uidPass2FaToolStripMenuItem_Click);
		this.mailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
		this.mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
		this.mailPassMailToolStripMenuItem.Click += new System.EventHandler(mailPassMailToolStripMenuItem_Click);
		this.uidPassTokenCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
		this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
		this.uidPassTokenCookieToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieToolStripMenuItem_Click);
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieMailPassMailToolStripMenuItem_Click);
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click);
		this.useragentToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		this.useragentToolStripMenuItem1.Name = "useragentToolStripMenuItem1";
		this.useragentToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		this.useragentToolStripMenuItem1.Text = "Useragent";
		this.useragentToolStripMenuItem1.Click += new System.EventHandler(useragentToolStripMenuItem1_Click);
		this.proxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
		this.proxyToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		this.proxyToolStripMenuItem1.Text = "Proxy";
		this.proxyToolStripMenuItem1.Click += new System.EventHandler(proxyToolStripMenuItem1_Click);
		this.toolStripMenuItem_11.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		this.toolStripMenuItem_11.Name = "đinhDangKhacToolStripMenuItem";
		this.toolStripMenuItem_11.Size = new System.Drawing.Size(289, 22);
		this.toolStripMenuItem_11.Text = "Đi\u0323nh da\u0323ng kha\u0301c...";
		this.toolStripMenuItem_11.Click += new System.EventHandler(toolStripMenuItem_11_Click);
		this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.toolStripMenuItem_9, this.checkInfoUIDToolStripMenuItem, this.toolStripMenuItem_5, this.toolStripMenuItem_4, this.checkAvatarToolStripMenuItem, this.checkProfileToolStripMenuItem1, this.checkBackupToolStripMenuItem1, this.toolStripMenuItem_7, this.toolStripMenuItem_16, this.checkProxyToolStripMenuItem });
		this.checkCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
		this.checkCookieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
		this.toolStripMenuItem_9.Name = "kiểmTraWallToolStripMenuItem";
		this.toolStripMenuItem_9.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_9.Text = "Check Wall";
		this.toolStripMenuItem_9.ToolTipText = "Không cần dùng token";
		this.toolStripMenuItem_9.Click += new System.EventHandler(toolStripMenuItem_9_Click);
		this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
		this.checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
		this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
		this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		this.checkInfoUIDToolStripMenuItem.Click += new System.EventHandler(checkInfoUIDToolStripMenuItem_Click);
		this.toolStripMenuItem_5.Name = "kiểmTraTokenToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_5.Text = "Check Token";
		this.toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		this.toolStripMenuItem_4.Name = "kiểmTraCookieToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_4.Text = "Check Cookie";
		this.toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		this.checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
		this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
		this.checkAvatarToolStripMenuItem.Click += new System.EventHandler(checkAvatarToolStripMenuItem_Click);
		this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		this.checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
		this.checkProfileToolStripMenuItem1.Text = "Check Profile";
		this.checkProfileToolStripMenuItem1.Click += new System.EventHandler(checkProfileToolStripMenuItem1_Click);
		this.checkBackupToolStripMenuItem1.Name = "checkBackupToolStripMenuItem1";
		this.checkBackupToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
		this.checkBackupToolStripMenuItem1.Text = "Check Backup";
		this.checkBackupToolStripMenuItem1.Click += new System.EventHandler(checkBackupToolStripMenuItem_Click);
		this.toolStripMenuItem_7.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_7.Text = "Dạng checkpoint";
		this.toolStripMenuItem_7.ToolTipText = "Chi\u0309 sư\u0309 du\u0323ng khi ta\u0300i khoa\u0309n đa\u0303 bi\u0323 checkpoint!";
		this.toolStripMenuItem_7.Click += new System.EventHandler(toolStripMenuItem_7_Click);
		this.toolStripMenuItem_16.Name = "kiểmTraMailpassMailToolStripMenuItem";
		this.toolStripMenuItem_16.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_16.Text = "Mail|pass Mail";
		this.toolStripMenuItem_16.Click += new System.EventHandler(toolStripMenuItem_16_Click);
		this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
		this.checkProxyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
		this.checkProxyToolStripMenuItem.Text = "Check Proxy";
		this.checkProxyToolStripMenuItem.Click += new System.EventHandler(checkProxyToolStripMenuItem_Click);
		this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_10, this.donDepProfileToolStripMenuItem });
		this.profileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
		this.profileToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		this.profileToolStripMenuItem.Text = "Profile Chrome";
		this.toolStripMenuItem_10.Image = (System.Drawing.Image)resources.GetObject("xóaProfileToolStripMenuItem.Image");
		this.toolStripMenuItem_10.Name = "xóaProfileToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new System.Drawing.Size(156, 22);
		this.toolStripMenuItem_10.Text = "Xóa profile";
		this.toolStripMenuItem_10.Click += new System.EventHandler(toolStripMenuItem_10_Click);
		this.donDepProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		this.donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
		this.donDepProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
		this.donDepProfileToolStripMenuItem.Text = "Do\u0323n de\u0323p profile";
		this.donDepProfileToolStripMenuItem.Click += new System.EventHandler(donDepProfileToolStripMenuItem_Click);
		this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.checkBackupToolStripMenuItem, this.toolStripMenuItem_15, this.backupToolStripMenuItem1, this.toolStripMenuItem_17 });
		this.backupToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("backupToolStripMenuItem.Image");
		this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
		this.backupToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		this.backupToolStripMenuItem.Text = "Backup dư\u0303 liê\u0323u";
		this.checkBackupToolStripMenuItem.Image = Class306.Bitmap_48;
		this.checkBackupToolStripMenuItem.Name = "checkBackupToolStripMenuItem";
		this.checkBackupToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
		this.checkBackupToolStripMenuItem.Text = "Check Backup";
		this.checkBackupToolStripMenuItem.Click += new System.EventHandler(checkBackupToolStripMenuItem_Click);
		this.toolStripMenuItem_15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_19, this.toolStripMenuItem_18 });
		this.toolStripMenuItem_15.Image = (System.Drawing.Image)resources.GetObject("mởThưMụcBackupToolStripMenuItem.Image");
		this.toolStripMenuItem_15.Name = "mởThưMụcBackupToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new System.Drawing.Size(183, 22);
		this.toolStripMenuItem_15.Text = "Mở dữ liêu Backup";
		this.toolStripMenuItem_19.Name = "mởFileHTMLToolStripMenuItem";
		this.toolStripMenuItem_19.Size = new System.Drawing.Size(149, 22);
		this.toolStripMenuItem_19.Text = "File HTML";
		this.toolStripMenuItem_19.Click += new System.EventHandler(toolStripMenuItem_19_Click);
		this.toolStripMenuItem_18.Name = "mởFolderBackupToolStripMenuItem";
		this.toolStripMenuItem_18.Size = new System.Drawing.Size(149, 22);
		this.toolStripMenuItem_18.Text = "Folder Backup";
		this.toolStripMenuItem_18.Click += new System.EventHandler(toolStripMenuItem_18_Click);
		this.backupToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.htmlToolStripMenuItem, this.toolStripMenuItem_12 });
		this.backupToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("backupToolStripMenuItem1.Image");
		this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
		this.backupToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
		this.backupToolStripMenuItem1.Text = "Copy dư\u0303 liê\u0323u Backup";
		this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
		this.htmlToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
		this.htmlToolStripMenuItem.Text = "File HTML";
		this.htmlToolStripMenuItem.Click += new System.EventHandler(htmlToolStripMenuItem_Click);
		this.toolStripMenuItem_12.Name = "thưMụcToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new System.Drawing.Size(149, 22);
		this.toolStripMenuItem_12.Text = "Folder Backup";
		this.toolStripMenuItem_12.Click += new System.EventHandler(toolStripMenuItem_12_Click);
		this.toolStripMenuItem_17.Image = Class306.Bitmap_28;
		this.toolStripMenuItem_17.Name = "xóaDữLiệuBackupToolStripMenuItem";
		this.toolStripMenuItem_17.Size = new System.Drawing.Size(183, 22);
		this.toolStripMenuItem_17.Text = "Xóa dữ liệu Backup";
		this.toolStripMenuItem_17.Click += new System.EventHandler(toolStripMenuItem_17_Click);
		this.toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		this.toolStripMenuItem_6.Name = "tảiLạiDanhSáchToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_6.Text = "Tải lại danh sách";
		this.toolStripMenuItem_6.Click += new System.EventHandler(toolStripMenuItem_6_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1203, 29);
		this.pnlHeader.TabIndex = 0;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(6, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.pictureBox1.DoubleClick += new System.EventHandler(pictureBox1_DoubleClick);
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		this.button2.Location = new System.Drawing.Point(1107, 0);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(32, 29);
		this.button2.TabIndex = 0;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Dock = System.Windows.Forms.DockStyle.Right;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(1139, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(32, 29);
		this.button1.TabIndex = 1;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(1171, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 29);
		this.btnMinimize.TabIndex = 2;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(186, 16);
		this.bunifuCustomLabel1.TabIndex = 3;
		this.bunifuCustomLabel1.Text = "Danh sa\u0301ch ta\u0300i khoa\u0309n đa\u0303 xo\u0301a";
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkRed;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1204, 38);
		this.bunifuCards1.TabIndex = 0;
		this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.menuStrip1.AutoSize = false;
		this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.toolStripMenuItem_14 });
		this.menuStrip1.Location = new System.Drawing.Point(0, 37);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.menuStrip1.Size = new System.Drawing.Size(1201, 25);
		this.menuStrip1.Stretch = false;
		this.menuStrip1.TabIndex = 1;
		this.menuStrip1.Text = "menuStrip1";
		this.toolStripMenuItem_14.Image = Class306.Bitmap_205;
		this.toolStripMenuItem_14.Name = "thoátToolStripMenuItem";
		this.toolStripMenuItem_14.Size = new System.Drawing.Size(132, 21);
		this.toolStripMenuItem_14.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		this.toolStripMenuItem_14.Click += new System.EventHandler(toolStripMenuItem_14_Click);
		this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
		this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
		this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
		this.grQuanLyThuMuc.Controls.Add(this.label2);
		this.grQuanLyThuMuc.Controls.Add(this.label1);
		this.grQuanLyThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.grQuanLyThuMuc.Location = new System.Drawing.Point(292, 65);
		this.grQuanLyThuMuc.Name = "grQuanLyThuMuc";
		this.grQuanLyThuMuc.Size = new System.Drawing.Size(445, 53);
		this.grQuanLyThuMuc.TabIndex = 5;
		this.grQuanLyThuMuc.TabStop = false;
		this.grQuanLyThuMuc.Text = "Quản lý thư mục";
		this.btnLoadAcc.BackgroundImage = Class306.Bitmap_9;
		this.btnLoadAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		this.btnLoadAcc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnLoadAcc.Location = new System.Drawing.Point(416, 19);
		this.btnLoadAcc.Name = "btnLoadAcc";
		this.btnLoadAcc.Size = new System.Drawing.Size(25, 25);
		this.btnLoadAcc.TabIndex = 6;
		this.toolTip_0.SetToolTip(this.btnLoadAcc, "Load lại danh sách");
		this.btnLoadAcc.UseSelectable = true;
		this.btnLoadAcc.Click += new System.EventHandler(btnLoadAcc_Click);
		this.cbbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTinhTrang.DropDownWidth = 300;
		this.cbbTinhTrang.FontSize = MetroFramework.MetroComboBoxSize.Small;
		this.cbbTinhTrang.FormattingEnabled = true;
		this.cbbTinhTrang.ItemHeight = 19;
		this.cbbTinhTrang.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		this.cbbTinhTrang.Location = new System.Drawing.Point(289, 19);
		this.cbbTinhTrang.Name = "cbbTinhTrang";
		this.cbbTinhTrang.Size = new System.Drawing.Size(121, 25);
		this.cbbTinhTrang.TabIndex = 3;
		this.cbbTinhTrang.UseSelectable = true;
		this.cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(cbbTinhTrang_SelectedIndexChanged);
		this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbThuMuc.DropDownWidth = 350;
		this.cbbThuMuc.FontSize = MetroFramework.MetroComboBoxSize.Small;
		this.cbbThuMuc.FormattingEnabled = true;
		this.cbbThuMuc.ItemHeight = 19;
		this.cbbThuMuc.Items.AddRange(new object[1] { "[Tất cả thư mục]" });
		this.cbbThuMuc.Location = new System.Drawing.Point(72, 19);
		this.cbbThuMuc.Name = "cbbThuMuc";
		this.cbbThuMuc.Size = new System.Drawing.Size(173, 25);
		this.cbbThuMuc.TabIndex = 1;
		this.cbbThuMuc.UseSelectable = true;
		this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(cbbThuMuc_SelectedIndexChanged);
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(249, 22);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(42, 16);
		this.label2.TabIndex = 2;
		this.label2.Text = "Lọc:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(8, 23);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(64, 16);
		this.label1.TabIndex = 0;
		this.label1.Text = "Thư mục:";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.grTimKiem.Controls.Add(this.BtnSearch);
		this.grTimKiem.Controls.Add(this.cbbSearch);
		this.grTimKiem.Controls.Add(this.txbSearch);
		this.grTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.grTimKiem.Location = new System.Drawing.Point(2, 65);
		this.grTimKiem.Name = "grTimKiem";
		this.grTimKiem.Size = new System.Drawing.Size(284, 53);
		this.grTimKiem.TabIndex = 4;
		this.grTimKiem.TabStop = false;
		this.grTimKiem.Text = "Tìm kiếm";
		this.BtnSearch.BackgroundImage = Class306.Bitmap_192;
		this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnSearch.Location = new System.Drawing.Point(253, 18);
		this.BtnSearch.Name = "BtnSearch";
		this.BtnSearch.Size = new System.Drawing.Size(24, 24);
		this.BtnSearch.TabIndex = 2;
		this.BtnSearch.UseSelectable = true;
		this.BtnSearch.Click += new System.EventHandler(BtnSearch_Click);
		this.cbbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbSearch.DropDownWidth = 100;
		this.cbbSearch.FormattingEnabled = true;
		this.cbbSearch.Location = new System.Drawing.Point(12, 18);
		this.cbbSearch.Name = "cbbSearch";
		this.cbbSearch.Size = new System.Drawing.Size(86, 24);
		this.cbbSearch.TabIndex = 0;
		this.txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
		this.txbSearch.Location = new System.Drawing.Point(104, 19);
		this.txbSearch.Name = "txbSearch";
		this.txbSearch.Size = new System.Drawing.Size(143, 23);
		this.txbSearch.TabIndex = 1;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 30000;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 40;
		this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
		this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripStatusLabel5, this.lblCountSelect, this.toolStripStatusLabel7, this.lblCountTotal });
		this.statusStrip1.Location = new System.Drawing.Point(0, 588);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.Size = new System.Drawing.Size(1204, 22);
		this.statusStrip1.TabIndex = 11;
		this.statusStrip1.Text = "statusStrip1";
		this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
		this.toolStripStatusLabel5.Size = new System.Drawing.Size(66, 17);
		this.toolStripStatusLabel5.Text = "Đã chọn:";
		this.lblCountSelect.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		this.lblCountSelect.Name = "lblCountSelect";
		this.lblCountSelect.Size = new System.Drawing.Size(16, 17);
		this.lblCountSelect.Text = "0";
		this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
		this.toolStripStatusLabel7.Size = new System.Drawing.Size(53, 17);
		this.toolStripStatusLabel7.Text = "Tất cả:";
		this.lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		this.lblCountTotal.Name = "lblCountTotal";
		this.lblCountTotal.Size = new System.Drawing.Size(16, 17);
		this.lblCountTotal.Text = "0";
		this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button9.BackColor = System.Drawing.Color.White;
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.Image = Class306.Bitmap_214;
		this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button9.Location = new System.Drawing.Point(836, 78);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(158, 34);
		this.button9.TabIndex = 12;
		this.button9.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click);
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button3.BackColor = System.Drawing.Color.White;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Image = Class306.Bitmap_111;
		this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button3.Location = new System.Drawing.Point(1000, 78);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(201, 34);
		this.button3.TabIndex = 12;
		this.button3.Text = "Xo\u0301a ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.label3.BackColor = System.Drawing.SystemColors.Control;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.Location = new System.Drawing.Point(688, 591);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(515, 16);
		this.label3.TabIndex = 13;
		this.label3.Text = "[Bôi đen nhiều dòng rồi nhấn phím Space] hoặc [Click đúp vào tài khoản] để tích chọn!";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label3.Click += new System.EventHandler(label3_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1204, 610);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button9);
		base.Controls.Add(this.statusStrip1);
		base.Controls.Add(this.grTimKiem);
		base.Controls.Add(this.grQuanLyThuMuc);
		base.Controls.Add(this.dtgvAcc);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.menuStrip1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = this.menuStrip1;
		base.Name = "fBin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE";
		base.Load += new System.EventHandler(fBin_Load);
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
		this.ctmsAcc.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.grQuanLyThuMuc.ResumeLayout(false);
		this.grTimKiem.ResumeLayout(false);
		this.grTimKiem.PerformLayout();
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
