using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

public class fChange : Form
{
	[CompilerGenerated]
	private sealed class Class197
	{
		public string[] string_0;

		public fChange fChange_0;

		internal void method_0()
		{
			fChange_0.dtgvAcc.Rows.Add(string_0[0], string_0[1], string_0[2], string_0[3], string_0[4], string_0[5], string_0[6], string_0[7], string_0[8], string_0[9], string_0[10], string_0[11], string_0[12], string_0[13], string_0[14], string_0[15]);
		}
	}

	[CompilerGenerated]
	private sealed class Class198
	{
		public fChange fChange_0;

		public int int_0;

		internal void method_0()
		{
			fChange_0.lblChoosed.Text = int_0.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class199
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public bool bool_0;

		public fChange fChange_0;

		internal void method_0()
		{
			try
			{
				if (fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") == 8 && fChange_0.gclass17_1.method_2("typeRunXproxy") == 1)
				{
					for (int i = 0; i < fChange_0.list_28.Count; i++)
					{
						fChange_0.list_28[i].method_1();
					}
				}
				if (fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") == 14)
				{
					for (int j = 0; j < fChange_0.list_34.Count; j++)
					{
						fChange_0.list_34[j].method_4();
					}
				}
				int num = 0;
				while (true)
				{
					if (num < fChange_0.dtgvAcc.Rows.Count && !fChange_0.bool_0)
					{
						if (Convert.ToBoolean(fChange_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
						{
							if (fChange_0.list_1.Count < int_0)
							{
								Class201 CS_0024_003C_003E8__locals0 = new Class201
								{
									class199_0 = this
								};
								if (fChange_0.bool_0)
								{
									goto IL_04f4;
								}
								CS_0024_003C_003E8__locals0.int_0 = num++;
								if (int_1 > 0)
								{
									GClass14.smethod_58(fChange_0.gclass17_1.method_2("nudDelayOpenChrome", 1));
								}
								int_1++;
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										int num2 = GClass14.smethod_65(ref CS_0024_003C_003E8__locals0.class199_0.fChange_0.list_0);
										CS_0024_003C_003E8__locals0.class199_0.fChange_0.method_14(CS_0024_003C_003E8__locals0.int_0, num2);
										GClass14.smethod_66(ref CS_0024_003C_003E8__locals0.class199_0.fChange_0.list_0, num2);
										Class309.smethod_5(CS_0024_003C_003E8__locals0.class199_0.fChange_0.dtgvAcc, CS_0024_003C_003E8__locals0.int_0, "cChose", false);
									}
									catch (Exception exception_2)
									{
										GClass14.smethod_75(null, exception_2);
									}
								});
								fChange_0.list_1.Add(thread);
								thread.Start();
							}
							else if (fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 0 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 7 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 8 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 9 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 10 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 11 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 12 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 13 && fChange_0.gclass17_1.method_2("ip_iTypeChangeIp") != 14)
							{
								for (int k = 0; k < fChange_0.list_1.Count; k++)
								{
									fChange_0.list_1[k].Join();
									fChange_0.list_1.RemoveAt(k--);
								}
								if (fChange_0.bool_0)
								{
									goto IL_04f4;
								}
								Interlocked.Increment(ref int_2);
								if (int_2 >= Convert.ToInt32((fChange_0.gclass17_1.method_0("ip_nudChangeIpCount") == "") ? "1" : fChange_0.gclass17_1.method_0("ip_nudChangeIpCount")))
								{
									for (int l = 0; l < 3; l++)
									{
										bool_0 = GClass14.smethod_79(fChange_0.gclass17_1.method_2("ip_iTypeChangeIp"), fChange_0.gclass17_1.method_2("typeDcom"), fChange_0.gclass17_1.method_0("ip_txtProfileNameDcom"), fChange_0.gclass17_1.method_0("txtUrlHilink"), fChange_0.gclass17_1.method_2("ip_cbbHostpot"), fChange_0.gclass17_1.method_0("ip_txtNordVPN"));
										if (bool_0)
										{
											break;
										}
									}
									if (!bool_0)
									{
										GClass38.smethod_0(GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!"));
										break;
									}
									int_2 = 0;
								}
							}
							else
							{
								for (int m = 0; m < fChange_0.list_1.Count; m++)
								{
									if (!fChange_0.list_1[m].IsAlive)
									{
										fChange_0.list_1.RemoveAt(m--);
									}
								}
							}
						}
						else
						{
							num++;
						}
						if (!fChange_0.bool_0)
						{
							continue;
						}
					}
					goto IL_04f4;
					IL_04f4:
					for (int n = 0; n < fChange_0.list_1.Count; n++)
					{
						fChange_0.list_1[n].Join();
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
			fChange_0.method_2("stop");
			if (fChange_0.gclass17_0.method_3("ckbAddMail"))
			{
				if (fChange_0.gclass17_0.method_2("themMail") == 1 && !fChange_0.gclass17_0.method_3("ckbMailVip"))
				{
					File.WriteAllLines("configschange\\addmail\\hotmail.txt", fChange_0.list_17);
				}
				GClass14.smethod_32("configschange\\addmail");
				File.WriteAllLines("configschange\\addmail\\MailLoi.txt", fChange_0.list_19);
			}
			if (fChange_0.gclass17_0.method_3("change_ckbVerify"))
			{
				GClass14.smethod_32("configschange\\verify");
				File.WriteAllLines("configschange\\verify\\hotmail.txt", fChange_0.list_18);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class200
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Contains(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class201
	{
		public int int_0;

		public Class199 class199_0;

		internal void method_0()
		{
			try
			{
				int num = GClass14.smethod_65(ref class199_0.fChange_0.list_0);
				class199_0.fChange_0.method_14(int_0, num);
				GClass14.smethod_66(ref class199_0.fChange_0.list_0, num);
				Class309.smethod_5(class199_0.fChange_0.dtgvAcc, int_0, "cChose", false);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
		}
	}

	private Random random_0 = new Random();

	private bool bool_0 = false;

	public static bool bool_1;

	public static fChange fChange_0;

	private GClass17 gclass17_0;

	private GClass17 gclass17_1;

	private GClass17 gclass17_2;

	private object object_0 = new object();

	private List<int> list_0 = new List<int>();

	private List<Thread> list_1 = null;

	private Queue<string> queue_0 = new Queue<string>();

	private Queue<string> queue_1 = new Queue<string>();

	private Queue<string> queue_2 = new Queue<string>();

	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\tieusu";

	private string string_3 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\thongtincanhan";

	private string string_4 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\ho.txt";

	private string string_5 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\tendem.txt";

	private string string_6 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\ten.txt";

	private string string_7 = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doimk.txt";

	private List<string> list_2 = new List<string>();

	private List<string> list_3 = new List<string>();

	private List<string> list_4 = new List<string>();

	private List<string> list_5 = new List<string>();

	private List<string> list_6 = new List<string>();

	private List<string> list_7 = new List<string>();

	private List<string> list_8 = new List<string>();

	private List<string> list_9 = new List<string>();

	private List<string> list_10 = new List<string>();

	private List<string> list_11 = new List<string>();

	private List<string> list_12 = new List<string>();

	private List<string> list_13 = new List<string>();

	private List<string> list_14 = new List<string>();

	private List<string> list_15 = new List<string>();

	private List<string> list_16 = new List<string>();

	private List<string> list_17 = new List<string>();

	private List<string> list_18 = new List<string>();

	private List<string> list_19 = new List<string>();

	private List<string> list_20 = new List<string>();

	private List<string> list_21 = new List<string>();

	private List<string> list_22 = new List<string>();

	private List<string> list_23 = new List<string>();

	private List<string> list_24 = new List<string>();

	private List<string> list_25 = new List<string>();

	private List<string> list_26 = new List<string>();

	private List<Class40> list_27 = null;

	private List<Class47> list_28 = null;

	private List<Class41> list_29 = null;

	private List<Class6> list_30 = null;

	private List<Class7> list_31 = null;

	private List<Class11> list_32 = null;

	private List<GClass9> list_33 = null;

	private List<GClass8> list_34 = null;

	private List<string> list_35 = null;

	private List<string> list_36 = null;

	private List<string> list_37 = null;

	private List<string> list_38 = null;

	private List<string> list_39 = null;

	private List<string> list_40 = null;

	private List<string> list_41 = null;

	private int int_0 = 0;

	private object object_1 = new object();

	private object object_2 = new object();

	private object object_3 = new object();

	private object object_4 = new object();

	private bool bool_2 = false;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel3;

	private ToolStripMenuItem liveToolStripMenuItem;

	private ToolStripMenuItem dieToolStripMenuItem;

	private ToolStripMenuItem checkpointToolStripMenuItem;

	private ToolStripMenuItem changePasswordToolStripMenuItem;

	private ToolStripMenuItem tokenToolStripMenuItem;

	private ToolStripMenuItem cookieToolStripMenuItem;

	private ToolStripMenuItem uidPassToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem passToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem mnsCutAccount;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem cookieToolStripMenuItem1;

	private ToolStripMenuItem uidPassToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem cookieToolStripMenuItem2;

	private ToolStripMenuItem uidPassToolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem tokenToolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem tokenBussinessToolStripMenuItem;

	private ToolStripMenuItem tokenInstagramToolStripMenuItem1;

	private ToolStripMenuItem tokenIosToolStripMenuItem;

	private ToolStripMenuItem tokenAndroidToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem cookieToolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem backupTokenToolStripMenuItem;

	private ToolStripMenuItem backupCookieToolStripMenuItem;

	private ToolStripMenuItem backupCookieTrungGianToolStripMenuItem;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private Button btnMinimize;

	private BunifuCustomLabel lblChoosed;

	private BunifuCustomLabel bunifuCustomLabel2;

	private Label lblCountAcc;

	private Label label7;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripMenuItem ctmsChonTrangThai;

	private ToolStripMenuItem toolStripMenuItem_17;

	private Button btnConfig;

	private Button btnPause;

	private Button btnStart;

	public DataGridView dtgvAcc;

	private Button button3;

	private ToolStripMenuItem loadCookieToolStripMenuItem;

	private Button button7;

	private ToolStripMenuItem copyToolStripMenuItem;

	private Button button4;

	private ToolStripMenuItem toolStripMenuItem_18;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cToken;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cBirthday;

	private DataGridViewTextBoxColumn cGender;

	private DataGridViewTextBoxColumn cPassword;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cEmail;

	private DataGridViewTextBoxColumn cPassMail;

	private DataGridViewTextBoxColumn cUseragent;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cInfo;

	private DataGridViewTextBoxColumn cStatus;

	public fChange(List<string> list_42)
	{
		InitializeComponent();
		if (list_42 != null && list_42.Count > 0)
		{
			for (int i = 0; i < list_42.Count; i++)
			{
				dtgvAcc.Rows.Add(true, list_42[i].Split('|')[0], list_42[i].Split('|')[1], list_42[i].Split('|')[2], list_42[i].Split('|')[3], list_42[i].Split('|')[4], list_42[i].Split('|')[5], list_42[i].Split('|')[6], list_42[i].Split('|')[7], list_42[i].Split('|')[8], list_42[i].Split('|')[9], list_42[i].Split('|')[10], list_42[i].Split('|')[11], list_42[i].Split('|')[12], list_42[i].Split('|')[13], list_42[i].Split('|')[14], list_42[i].Split('|')[15]);
			}
		}
		method_3();
		method_0();
		method_1();
		fChange_0 = this;
		bool_1 = false;
	}

	private void method_0()
	{
		gclass17_0 = new GClass17("configChange");
		gclass17_1 = new GClass17("configGeneral");
		gclass17_2 = new GClass17("configCheckpoint");
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		method_6();
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Maximized)
		{
			base.WindowState = FormWindowState.Normal;
		}
		else
		{
			base.WindowState = FormWindowState.Maximized;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void method_1()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(btnStart);
		GClass29.smethod_1(btnPause);
		GClass29.smethod_1(btnConfig);
		GClass29.smethod_1(button3);
		GClass29.smethod_1(bunifuCustomLabel2);
		GClass29.smethod_1(label7);
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			GClass29.smethod_3(column);
		}
		GClass29.smethod_2(toolStripMenuItem_15);
		GClass29.smethod_2(toolStripMenuItem_16);
		GClass29.smethod_2(ctmsChonTrangThai);
		GClass29.smethod_2(toolStripMenuItem_17);
	}

	private void method_2(string string_8)
	{
		try
		{
			if (string_8 == "start")
			{
				Invoke((MethodInvoker)delegate
				{
					btnPause.Enabled = true;
					btnStart.Enabled = false;
				});
			}
			else if (string_8 == "stop")
			{
				Invoke((MethodInvoker)delegate
				{
					btnPause.Text = GClass29.smethod_0("Ta\u0323m dư\u0300ng");
					btnPause.Enabled = false;
					btnStart.Enabled = true;
				});
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			lblCountAcc.Text = dtgvAcc.RowCount.ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.ColumnIndex == 0)
			{
				try
				{
					if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
					{
						dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
					}
					else
					{
						dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		method_4();
	}

	private void method_4()
	{
		int int_0 = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				int_0++;
			}
		}
		try
		{
			lblChoosed.Invoke((MethodInvoker)delegate
			{
				lblChoosed.Text = int_0.ToString();
			});
		}
		catch
		{
		}
	}

	private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.KeyValue == 32)
			{
				for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
				{
					int index = dtgvAcc.SelectedRows[i].Index;
					if (Convert.ToBoolean(dtgvAcc.Rows[index].Cells["cChose"].Value))
					{
						dtgvAcc.Rows[index].Cells["cChose"].Value = false;
					}
					else
					{
						dtgvAcc.Rows[index].Cells["cChose"].Value = true;
					}
				}
			}
		}
		catch
		{
		}
		method_4();
	}

	private void toolStripMenuItem_15_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
		method_4();
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = false;
			}
		}
		catch
		{
		}
		method_4();
	}

	private void ctmsChonTrangThai_Click(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					string text2 = "";
					try
					{
						text2 = dtgvAcc.Rows[i].Cells["cCookieName"].Value.ToString();
					}
					catch
					{
					}
					dtgvAcc.Rows.RemoveAt(i);
					i--;
					try
					{
						File.Delete(Application.StartupPath + "\\configschange\\cookieJson\\" + text2 + ".txt");
					}
					catch (Exception)
					{
					}
				}
			}
			text = dtgvAcc.SelectedRows[0].Cells["cCookies"].Value.ToString();
			_ = Regex.Match(text, "c_user=(.*?);").Groups[1].Value;
		}
		catch (Exception)
		{
		}
		method_4();
		method_3();
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		ctmsChonTrangThai.DropDownItems.Clear();
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (dtgvAcc.Rows[i].Cells["cStatus"].Value != null && !dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString().Equals("") && !list.Contains(dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString()))
			{
				string text = dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString();
				string value = Regex.Match(text, "\\(IP: (.*?)\\)").Value;
				if (value != "")
				{
					text = text.Replace(value, "").Trim();
				}
				value = Regex.Match(text, "\\[(.*?)\\]").Value;
				if (value != "")
				{
					text = text.Replace(value, "").Trim();
				}
				if (text != "" && !list.Contains(text))
				{
					list.Add(text);
				}
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			ctmsChonTrangThai.DropDownItems.Add(list[j]);
			ctmsChonTrangThai.DropDownItems[j].Click += method_5;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			try
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string value = toolStripMenuItem.Text;
				dtgvAcc.Rows[i].Cells["cChose"].Value = dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString().Contains(value);
			}
			catch (Exception)
			{
			}
		}
		method_4();
	}

	private void method_6()
	{
		List<string> list = new List<string>();
		try
		{
			try
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					DataGridViewRow dataGridViewRow = dtgvAcc.Rows[i];
					string item = ((dataGridViewRow.Cells[0].Value == null) ? "False" : dataGridViewRow.Cells[0].Value.ToString()) + "|" + ((dataGridViewRow.Cells[1].Value == null) ? "" : dataGridViewRow.Cells[1].Value.ToString()) + "|" + ((dataGridViewRow.Cells[2].Value == null) ? "" : dataGridViewRow.Cells[2].Value.ToString()) + "|" + ((dataGridViewRow.Cells[3].Value == null) ? "" : dataGridViewRow.Cells[3].Value.ToString()) + "|" + ((dataGridViewRow.Cells[4].Value == null) ? "" : dataGridViewRow.Cells[4].Value.ToString()) + "|" + ((dataGridViewRow.Cells[5].Value == null) ? "" : dataGridViewRow.Cells[5].Value.ToString()) + "|" + ((dataGridViewRow.Cells[6].Value == null) ? "" : dataGridViewRow.Cells[6].Value.ToString()) + "|" + ((dataGridViewRow.Cells[7].Value == null) ? "" : dataGridViewRow.Cells[7].Value.ToString()) + "|" + ((dataGridViewRow.Cells[8].Value == null) ? "" : dataGridViewRow.Cells[8].Value.ToString()) + "|" + ((dataGridViewRow.Cells[9].Value == null) ? "" : dataGridViewRow.Cells[9].Value.ToString()) + "|" + ((dataGridViewRow.Cells[10].Value == null) ? "" : dataGridViewRow.Cells[10].Value.ToString()) + "|" + ((dataGridViewRow.Cells[11].Value == null) ? "" : dataGridViewRow.Cells[11].Value.ToString()) + "|" + ((dataGridViewRow.Cells[12].Value == null) ? "" : dataGridViewRow.Cells[12].Value.ToString()) + "|" + ((dataGridViewRow.Cells[13].Value == null) ? "" : dataGridViewRow.Cells[13].Value.ToString()) + "|" + ((dataGridViewRow.Cells[14].Value == null) ? "" : dataGridViewRow.Cells[14].Value.ToString()) + "|" + ((dataGridViewRow.Cells[15].Value == null) ? "" : dataGridViewRow.Cells[15].Value.ToString());
					list.Add(item);
				}
			}
			catch
			{
			}
			File.WriteAllLines("account.txt", list);
		}
		catch
		{
		}
	}

	private void btnConfig_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fChangeConfig());
	}

	public List<string> method_7(List<string> list_42)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < list_42.Count; i++)
			{
				list.Add(list_42[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public List<string> method_8()
	{
		List<string> list = new List<string>();
		try
		{
			if (gclass17_1.method_2("typeApiTinsoft") == 0)
			{
				GClass19 gClass = new GClass19("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = gClass.method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + gclass17_1.method_0("txtApiUser"));
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
				List<string> list2 = gclass17_1.method_1("txtApiProxy");
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

	private void btnStart_Click(object sender, EventArgs e)
	{
		try
		{
			method_0();
			int int_0 = gclass17_0.method_2("change_nudThread", 3);
			if (gclass17_0.method_3("change_ckbGiaiCheckPoint") && gclass17_2.method_3("ckbImage"))
			{
				string text = gclass17_2.method_0("txtImage");
				if (text == "")
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn đường dẫn folder chứa ảnh"), 2);
					return;
				}
				if (Directory.GetFiles(text).Length == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng thêm a\u0309nh!"), 2);
					return;
				}
				list_26 = Directory.GetFiles(text).ToList();
			}
			if (gclass17_0.method_3("change_ckbDoiAvatar"))
			{
				this.string_0 = gclass17_0.method_0("change_txtPathAvatar");
				if (this.string_0 == "")
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn đường dẫn folder chứa avatar!"), 2);
					return;
				}
				if (Directory.GetFiles(this.string_0).Length == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng thêm a\u0309nh avatar!"), 2);
					return;
				}
				list_22 = Directory.GetFiles(this.string_0).ToList();
				list_23 = method_7(list_22);
			}
			if (gclass17_0.method_3("change_ckbDoiAnhBia") && gclass17_0.method_2("change_typeUpCover") == 0)
			{
				string_1 = gclass17_0.method_0("change_txtPathCover");
				if (string_1 == "")
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn đường dẫn folder chứa ảnh bìa!"), 2);
					return;
				}
				if (Directory.GetFiles(string_1).Length == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng thêm a\u0309nh bi\u0300a!"), 2);
					return;
				}
				list_24 = Directory.GetFiles(string_1).ToList();
				list_25 = method_7(list_24);
			}
			if (gclass17_0.method_3("change_ckbThemMoTa"))
			{
				if (Directory.GetFiles(string_2).Length == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng thêm tiê\u0309u sư\u0309!"), 2);
					return;
				}
				list_20 = Directory.GetFiles(string_2).ToList();
				list_21 = method_7(list_20);
			}
			if (gclass17_0.method_3("change_ckbCapNhatThongTin"))
			{
				list_7 = File.ReadAllLines("configschange\\thongtincanhan\\NoiLamViec.txt").ToList();
				list_9 = File.ReadAllLines("configschange\\thongtincanhan\\QueQuan.txt").ToList();
				list_11 = File.ReadAllLines("configschange\\thongtincanhan\\ThanhPho.txt").ToList();
				list_13 = File.ReadAllLines("configschange\\thongtincanhan\\TruongDH.txt").ToList();
				list_15 = File.ReadAllLines("configschange\\thongtincanhan\\TruongTHPT.txt").ToList();
				list_7 = GClass14.smethod_36(list_7);
				list_8 = GClass14.smethod_25(list_7);
				list_9 = GClass14.smethod_36(list_9);
				list_10 = GClass14.smethod_25(list_9);
				list_11 = GClass14.smethod_36(list_11);
				list_12 = GClass14.smethod_25(list_11);
				list_13 = GClass14.smethod_36(list_13);
				list_14 = GClass14.smethod_25(list_13);
				list_15 = GClass14.smethod_36(list_15);
				list_16 = GClass14.smethod_25(list_15);
			}
			if (gclass17_0.method_3("change_ckbDoiTen"))
			{
				if (gclass17_0.method_2("change_typeDatTen") == 0)
				{
					list_2 = File.ReadAllLines(string_4).ToList();
					list_2 = GClass14.smethod_36(list_2);
					if (list_2.Count == 0)
					{
						GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm Ho\u0323!"), 2);
						return;
					}
					list_4 = File.ReadAllLines(string_6).ToList();
					list_4 = GClass14.smethod_36(list_4);
					if (list_4.Count == 0)
					{
						GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm Tên!"), 2);
						return;
					}
					list_3 = File.ReadAllLines(string_5).ToList();
					list_3 = GClass14.smethod_36(list_3);
				}
				else if (gclass17_0.method_2("change_typeTenRandom") == 0)
				{
					list_2 = Class38.smethod_4();
					list_3 = Class38.smethod_5();
					list_4 = Class38.smethod_6();
				}
				else
				{
					list_2 = Class38.smethod_7();
					list_3 = new List<string>();
					list_4 = Class38.smethod_8();
				}
			}
			if (gclass17_0.method_3("change_ckbDoiPass") && gclass17_0.method_2("change_typeDoiPass") == 0)
			{
				list_6 = GClass14.smethod_36(File.ReadAllLines(string_7).ToList());
				if (list_6.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm Mâ\u0323t khâ\u0309u!"), 2);
					return;
				}
			}
			int num = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					num++;
				}
			}
			if (gclass17_0.method_3("ckbAddMail") && gclass17_0.method_2("themMail") == 1)
			{
				list_17 = File.ReadAllLines("configschange\\addmail\\hotmail.txt").ToList();
				list_17 = GClass14.smethod_36(list_17);
				if (list_17.Count < num && !gclass17_0.method_3("ckbMailVip"))
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập thêm mail cần add!"), 3);
					return;
				}
			}
			if (gclass17_0.method_3("change_ckbVerify") && gclass17_0.method_2("change_typeMail") == 0)
			{
				list_18 = File.ReadAllLines("configschange\\verify\\hotmail.txt").ToList();
				list_18 = GClass14.smethod_36(list_18);
				if (list_18.Count < num)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập thêm mail cần add!"), 3);
					return;
				}
			}
			for (int j = 0; j < int_0; j++)
			{
				list_0.Add(0);
			}
			switch (gclass17_1.method_2("ip_iTypeChangeIp"))
			{
			case 7:
			{
				list_35 = method_8();
				if (list_35.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Proxy Tinsoft không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_27 = new List<Class40>();
				for (int num2 = 0; num2 < list_35.Count; num2++)
				{
					Class40 item4 = new Class40(list_35[num2], gclass17_1.method_2("nudLuongPerIPTinsoft"), gclass17_1.method_2("cbbLocationTinsoft"));
					list_27.Add(item4);
				}
				if (list_35.Count * gclass17_1.method_2("nudLuongPerIPTinsoft") < int_0)
				{
					int_0 = list_35.Count * gclass17_1.method_2("nudLuongPerIPTinsoft");
				}
				break;
			}
			case 8:
			{
				list_36 = gclass17_1.method_1("txtListProxy");
				if (list_36.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("XProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_28 = new List<Class47>();
				for (int num3 = 0; num3 < list_36.Count; num3++)
				{
					Class47 item5 = new Class47(gclass17_1.method_0("txtServiceURLXProxy"), list_36[num3], gclass17_1.method_2("typeProxy"), gclass17_1.method_2("nudLuongPerIPXProxy"));
					list_28.Add(item5);
				}
				if (list_36.Count * gclass17_1.method_2("nudLuongPerIPXProxy") < int_0)
				{
					int_0 = list_36.Count * gclass17_1.method_2("nudLuongPerIPXProxy");
				}
				break;
			}
			case 10:
			{
				list_37 = gclass17_1.method_1("txtApiKeyTMProxy");
				if (list_37.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("TMProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_29 = new List<Class41>();
				for (int m = 0; m < list_37.Count; m++)
				{
					Class41 item2 = new Class41(list_37[m], 0, gclass17_1.method_2("nudLuongPerIPTMProxy"));
					list_29.Add(item2);
				}
				if (list_37.Count * gclass17_1.method_2("nudLuongPerIPTMProxy") < int_0)
				{
					int_0 = list_37.Count * gclass17_1.method_2("nudLuongPerIPTMProxy");
				}
				break;
			}
			case 11:
			{
				list_38 = gclass17_1.method_1("txtListProxyv6");
				if (list_38.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Proxy không đủ, vui lòng cấu hình lại!"), 2);
					return;
				}
				list_30 = new List<Class6>();
				for (int n = 0; n < list_38.Count; n++)
				{
					Class6 item3 = new Class6(gclass17_1.method_0("txtApiProxyv6"), list_38[n], 0, gclass17_1.method_2("nudLuongPerIPProxyv6"));
					list_30.Add(item3);
				}
				if (list_38.Count * gclass17_1.method_2("nudLuongPerIPProxyv6") < int_0)
				{
					int_0 = list_38.Count * gclass17_1.method_2("nudLuongPerIPProxyv6");
				}
				break;
			}
			case 12:
			{
				list_39 = gclass17_1.method_1("txtApiShopLike");
				if (list_39.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("TMProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_31 = new List<Class7>();
				for (int l = 0; l < list_39.Count; l++)
				{
					Class7 item = new Class7(list_39[l], 0, gclass17_1.method_2("nudLuongPerIPShopLike"));
					list_31.Add(item);
				}
				if (list_39.Count * gclass17_1.method_2("nudLuongPerIPShopLike") < int_0)
				{
					int_0 = list_39.Count * gclass17_1.method_2("nudLuongPerIPShopLike");
				}
				break;
			}
			case 13:
			{
				list_40 = gclass17_1.method_1("txtApiKeyMinProxy");
				if (list_40.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("MinProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_32 = new List<Class11>();
				for (int num4 = 0; num4 < list_40.Count; num4++)
				{
					Class11 item6 = new Class11(gclass17_1.method_2("typeMin"), list_40[num4], gclass17_1.method_2("typeProxyMin"), gclass17_1.method_2("nudLuongPerIPMinProxy"));
					list_32.Add(item6);
				}
				if (list_40.Count * gclass17_1.method_2("nudLuongPerIPMinProxy") < int_0)
				{
					int_0 = list_40.Count * gclass17_1.method_2("nudLuongPerIPMinProxy");
				}
				break;
			}
			case 14:
			{
				list_41 = gclass17_1.method_1("txtListObcProxy");
				if (list_41.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Proxy không đủ, vui lòng cấu hình lại!"), 2);
					return;
				}
				list_33 = new List<GClass9>();
				list_34 = new List<GClass8>();
				Dictionary<string, List<string>> source = GClass8.smethod_0(gclass17_1.method_0("txtLinkWebObcProxy"));
				for (int k = 0; k < list_41.Count; k++)
				{
					string string_0 = list_41[k].Split(':')[1];
					string key = source.FirstOrDefault((KeyValuePair<string, List<string>> keyValuePair_0) => keyValuePair_0.Value.Contains(string_0)).Key;
					if (!string.IsNullOrEmpty(key))
					{
						GClass8 gClass = GClass8.smethod_1(list_34, key);
						if (gClass == null)
						{
							gClass = new GClass8(key);
							list_34.Add(gClass);
						}
						GClass9 gClass2 = new GClass9(gclass17_1.method_0("txtLinkWebObcProxy"), list_41[k], 0, gclass17_1.method_2("nudLuongPerIPObcProxy"), key);
						list_33.Add(gClass2);
						gClass.method_1(gClass2);
					}
				}
				if (list_33.Count * gclass17_1.method_2("nudLuongPerIPObcProxy") < int_0)
				{
					int_0 = list_33.Count * gclass17_1.method_2("nudLuongPerIPObcProxy");
				}
				break;
			}
			}
			method_2("start");
			bool_1 = true;
			this.bool_0 = false;
			int int_2 = 0;
			bool bool_0 = false;
			int int_1 = 0;
			list_1 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					if (gclass17_1.method_2("ip_iTypeChangeIp") == 8 && gclass17_1.method_2("typeRunXproxy") == 1)
					{
						for (int num5 = 0; num5 < list_28.Count; num5++)
						{
							list_28[num5].method_1();
						}
					}
					if (gclass17_1.method_2("ip_iTypeChangeIp") == 14)
					{
						for (int num6 = 0; num6 < list_34.Count; num6++)
						{
							list_34[num6].method_4();
						}
					}
					int num7 = 0;
					while (true)
					{
						if (num7 < dtgvAcc.Rows.Count && !this.bool_0)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[num7].Cells["cChose"].Value))
							{
								if (list_1.Count < int_0)
								{
									if (this.bool_0)
									{
										goto IL_04f4;
									}
									int int_3 = num7++;
									if (int_1 > 0)
									{
										GClass14.smethod_58(gclass17_1.method_2("nudDelayOpenChrome", 1));
									}
									int_1++;
									Thread thread = new Thread((ThreadStart)delegate
									{
										try
										{
											int num12 = GClass14.smethod_65(ref list_0);
											method_14(int_3, num12);
											GClass14.smethod_66(ref list_0, num12);
											Class309.smethod_5(dtgvAcc, int_3, "cChose", false);
										}
										catch (Exception exception_3)
										{
											GClass14.smethod_75(null, exception_3);
										}
									});
									list_1.Add(thread);
									thread.Start();
								}
								else if (gclass17_1.method_2("ip_iTypeChangeIp") != 0 && gclass17_1.method_2("ip_iTypeChangeIp") != 7 && gclass17_1.method_2("ip_iTypeChangeIp") != 8 && gclass17_1.method_2("ip_iTypeChangeIp") != 9 && gclass17_1.method_2("ip_iTypeChangeIp") != 10 && gclass17_1.method_2("ip_iTypeChangeIp") != 11 && gclass17_1.method_2("ip_iTypeChangeIp") != 12 && gclass17_1.method_2("ip_iTypeChangeIp") != 13 && gclass17_1.method_2("ip_iTypeChangeIp") != 14)
								{
									for (int num8 = 0; num8 < list_1.Count; num8++)
									{
										list_1[num8].Join();
										list_1.RemoveAt(num8--);
									}
									if (this.bool_0)
									{
										goto IL_04f4;
									}
									Interlocked.Increment(ref int_2);
									if (int_2 >= Convert.ToInt32((gclass17_1.method_0("ip_nudChangeIpCount") == "") ? "1" : gclass17_1.method_0("ip_nudChangeIpCount")))
									{
										for (int num9 = 0; num9 < 3; num9++)
										{
											bool_0 = GClass14.smethod_79(gclass17_1.method_2("ip_iTypeChangeIp"), gclass17_1.method_2("typeDcom"), gclass17_1.method_0("ip_txtProfileNameDcom"), gclass17_1.method_0("txtUrlHilink"), gclass17_1.method_2("ip_cbbHostpot"), gclass17_1.method_0("ip_txtNordVPN"));
											if (bool_0)
											{
												break;
											}
										}
										if (!bool_0)
										{
											GClass38.smethod_0(GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!"));
											break;
										}
										int_2 = 0;
									}
								}
								else
								{
									for (int num10 = 0; num10 < list_1.Count; num10++)
									{
										if (!list_1[num10].IsAlive)
										{
											list_1.RemoveAt(num10--);
										}
									}
								}
							}
							else
							{
								num7++;
							}
							if (!this.bool_0)
							{
								continue;
							}
						}
						goto IL_04f4;
						IL_04f4:
						for (int num11 = 0; num11 < list_1.Count; num11++)
						{
							list_1[num11].Join();
						}
						break;
					}
				}
				catch (Exception exception_2)
				{
					GClass14.smethod_75(null, exception_2);
				}
				method_2("stop");
				if (gclass17_0.method_3("ckbAddMail"))
				{
					if (gclass17_0.method_2("themMail") == 1 && !gclass17_0.method_3("ckbMailVip"))
					{
						File.WriteAllLines("configschange\\addmail\\hotmail.txt", list_17);
					}
					GClass14.smethod_32("configschange\\addmail");
					File.WriteAllLines("configschange\\addmail\\MailLoi.txt", list_19);
				}
				if (gclass17_0.method_3("change_ckbVerify"))
				{
					GClass14.smethod_32("configschange\\verify");
					File.WriteAllLines("configschange\\verify\\hotmail.txt", list_18);
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
		}
	}

	private void method_9(List<string> list_42)
	{
		try
		{
			for (int i = 0; i < list_42.Count; i++)
			{
				List<Class52> list = new List<Class52>();
				string input = File.ReadAllText(list_42[i]);
				string[] array = Regex.Split(input, "\r\n");
				string[] array2 = array;
				foreach (string input2 in array2)
				{
					string[] array3 = Regex.Split(input2, "\t");
					if (array3.Length == 7)
					{
						list.Add(new Class52(array3[0], Convert.ToInt64(array3[4]), Convert.ToBoolean(array3[1]), array3[5], array3[2], Convert.ToBoolean(array3[3]), array3[6]));
					}
				}
				string contents = JsonConvert.SerializeObject(list);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(list_42[i]);
				if (!Directory.Exists(Application.StartupPath + "\\configschange\\cookieJson"))
				{
					Directory.CreateDirectory(Application.StartupPath + "\\configschange\\cookieJson");
				}
				File.WriteAllText(Application.StartupPath + "\\configschange\\cookieJson\\" + fileNameWithoutExtension + ".txt", contents);
			}
		}
		catch (Exception)
		{
		}
	}

	private int method_10(GClass12 gclass12_0)
	{
		int result = 0;
		try
		{
			if (gclass12_0.method_3())
			{
				result = 2;
			}
			else if (GClass15.smethod_36(gclass12_0))
			{
				result = 3;
			}
		}
		catch
		{
		}
		return result;
	}

	public static int smethod_0(GClass12 gclass12_0, int int_1, int int_2, int int_3)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/editprofile.php?type=basic&edit=birthday");
			gclass12_0.method_67(3.0);
			if (gclass12_0.method_46("#root > div > form > table > tbody > tr:nth-child(2) > td > div", 5.0) != 1)
			{
				gclass12_0.method_68(1, "day", int_1.ToString());
				gclass12_0.method_67(1.0);
				gclass12_0.method_68(1, "month", int_2.ToString());
				gclass12_0.method_67(0.5);
				gclass12_0.method_68(1, "year", int_3.ToString());
				gclass12_0.method_67(0.5);
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(2.0);
				if (gclass12_0.method_46("[name=\"birthday_confirmation\"]", 5.0) == 1)
				{
					gclass12_0.method_26(4, "[name=\"birthday_confirmation\"]");
					gclass12_0.method_67(1.0);
				}
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("[data-sigil=\"profile-card-header\"]", 10.0) == 1)
				{
					flag = true;
				}
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	private void method_11(int int_1, string string_8)
	{
		Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_8);
	}

	public void method_12(int int_1, string string_8)
	{
		Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_8);
	}

	public void method_13(string string_8, int int_1, string string_9)
	{
		Class309.smethod_5(dtgvAcc, int_1, "cInfo", string_9);
		Class36.smethod_13(string_8, "info", string_9);
	}

	private void method_14(object object_5, int int_1)
	{
		int num = 0;
		int num2 = 0;
		string text = "";
		int num3 = (int)object_5;
		GClass12 gClass = null;
		string text2 = Class309.smethod_3(dtgvAcc, num3, "cId");
		string text3 = Class309.smethod_3(dtgvAcc, num3, "cUid");
		string text4 = Class309.smethod_3(dtgvAcc, num3, "cPassword");
		string text5 = Class309.smethod_3(dtgvAcc, num3, "cCookies");
		string text6 = Class309.smethod_3(dtgvAcc, num3, "cFa2");
		string text7 = Class309.smethod_3(dtgvAcc, num3, "cUseragent");
		string text8 = Class309.smethod_3(dtgvAcc, num3, "cCookieName");
		string text9 = "";
		string text10 = "";
		if (text3 == "")
		{
			text3 = Regex.Match(text5, "c_user=(.*?);").Groups[1].Value;
		}
		Class40 @class = null;
		Class47 class2 = null;
		Class41 class3 = null;
		Class6 class4 = null;
		Class7 class5 = null;
		Class11 class6 = null;
		GClass9 gClass2 = null;
		string text11 = "";
		int num4 = 0;
		string text12 = "";
		while (true)
		{
			if (!bool_0)
			{
				bool flag;
				int num17;
				int num18;
				switch (gclass17_1.method_2("ip_iTypeChangeIp"))
				{
				case 7:
					method_11(num3, GClass29.smethod_0("Đang lấy proxy Tinsoft..."));
					lock (object_2)
					{
						while (!bool_0)
						{
							@class = null;
							while (!bool_0)
							{
								foreach (Class40 item in list_27)
								{
									if (@class == null || item.int_6 < @class.int_6)
									{
										@class = item;
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
								Class40 class12 = @class;
								class12.int_5++;
								class12 = @class;
								class12.int_6++;
								break;
							}
						}
						if (!bool_0)
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							bool flag11 = true;
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text.Split(':')[0] + ") ";
								method_11(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_67(text, 0);
								if (text12 == "")
								{
									flag11 = false;
								}
							}
							if (!flag11)
							{
								Class40 class12 = @class;
								class12.int_5--;
								class12 = @class;
								class12.int_6--;
								break;
							}
							goto default;
						}
						method_11(num3, text11 + GClass29.smethod_0("Đã dừng!"));
						num = 1;
					}
					goto IL_46fd;
				case 8:
					method_11(num3, GClass29.smethod_0("Đang lấy Proxy..."));
					lock (object_2)
					{
						if (gclass17_1.method_2("typeRunXproxy") == 0)
						{
							while (!bool_0)
							{
								class2 = null;
								while (!bool_0)
								{
									foreach (Class47 item2 in list_28)
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
									bool flag2 = false;
									if (class2.int_2 > 0)
									{
										flag2 = true;
									}
									else
									{
										switch (class2.method_2())
										{
										case 0:
											class2.bool_0 = false;
											break;
										case 1:
											flag2 = true;
											break;
										}
									}
									if (flag2)
									{
										text = class2.string_1;
										num4 = class2.int_0;
										Class47 class8 = class2;
										class8.int_1++;
										class8 = class2;
										class8.int_2++;
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
								foreach (Class47 item3 in list_28)
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
									num4 = class2.int_0;
									Class47 class8 = class2;
									class8.int_1++;
									class8 = class2;
									class8.int_2++;
									break;
								}
							}
						}
						if (!bool_0)
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							bool flag3 = true;
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text + ") ";
								method_12(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_67(text, num4, gclass17_1.method_2("nudDelayResetXProxy", 1) * 60);
								if (text12 == "")
								{
									class2.bool_0 = false;
									flag3 = false;
								}
							}
							if (!flag3)
							{
								Class47 class8 = class2;
								class8.int_1--;
								class8 = class2;
								class8.int_2--;
								break;
							}
							goto default;
						}
						method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
					}
					goto IL_46fd;
				case 10:
					method_11(num3, GClass29.smethod_0("Đang lấy TMProxy ..."));
					lock (object_2)
					{
						while (!bool_0)
						{
							class3 = null;
							while (!bool_0)
							{
								foreach (Class41 item4 in list_29)
								{
									if (class3 == null || item4.int_5 < class3.int_5)
									{
										class3 = item4;
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
								Class41 class11 = class3;
								class11.int_4++;
								class11 = class3;
								class11.int_5++;
								break;
							}
						}
						if (!bool_0)
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							bool flag10 = true;
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text.Split(':')[0] + ") ";
								method_11(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_67(text, 0);
								if (text12 == "")
								{
									flag10 = false;
								}
							}
							if (!flag10)
							{
								Class41 class11 = class3;
								class11.int_4--;
								class11 = class3;
								class11.int_5--;
								break;
							}
							goto default;
						}
						method_11(num3, text11 + GClass29.smethod_0("Đã dừng!"));
						num = 1;
					}
					goto IL_46fd;
				case 11:
					method_12(num3, GClass29.smethod_0("Đang lấy Proxyv6..."));
					lock (object_2)
					{
						while (!bool_0)
						{
							class4 = null;
							while (!bool_0)
							{
								foreach (Class6 item5 in list_30)
								{
									if (class4 == null || item5.int_2 < class4.int_2)
									{
										class4 = item5;
									}
								}
								if (class4.int_2 != class4.int_3)
								{
									break;
								}
							}
							if (bool_0)
							{
								break;
							}
							if (class4.int_2 > 0 || class4.method_0())
							{
								text = class4.string_1;
								num4 = class4.int_0;
								Class6 class10 = class4;
								class10.int_1++;
								class10 = class4;
								class10.int_2++;
								break;
							}
						}
						bool flag8;
						if (bool_0)
						{
							method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
							num = 1;
						}
						else
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							flag8 = true;
							if (gclass17_1.method_3("ckbKhongCheckIP"))
							{
								goto IL_0b8b;
							}
							text11 = "(IP: " + text.Split(':')[0] + ") ";
							method_12(num3, text11 + "Check IP...");
							int num15 = 0;
							while (true)
							{
								if (num15 < 30)
								{
									GClass14.smethod_58(1.0);
									text12 = GClass14.smethod_67(text, num4);
									if (!(text12 != ""))
									{
										if (!bool_0)
										{
											num15++;
											continue;
										}
										method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
										num = 1;
										break;
									}
								}
								if (text12 == "")
								{
									flag8 = false;
								}
								goto IL_0b8b;
							}
						}
						goto end_IL_096d;
						IL_0b8b:
						if (!flag8)
						{
							Class6 class10 = class4;
							class10.int_1--;
							class10 = class4;
							class10.int_2--;
							break;
						}
						goto default;
						end_IL_096d:;
					}
					goto IL_46fd;
				case 12:
					method_11(num3, GClass29.smethod_0("Đang lấy Proxy ShopLike ..."));
					lock (object_2)
					{
						while (!bool_0)
						{
							class5 = null;
							while (!bool_0)
							{
								foreach (Class7 item6 in list_31)
								{
									if (class5 == null || item6.int_3 < class5.int_3)
									{
										class5 = item6;
									}
								}
								if (class5.int_3 != class5.int_4)
								{
									break;
								}
							}
							if (bool_0)
							{
								break;
							}
							if (class5.int_3 > 0 || class5.method_1())
							{
								text = class5.String_1;
								if (text == "")
								{
									text = class5.method_3();
								}
								Class7 class9 = class5;
								class9.int_2++;
								class9 = class5;
								class9.int_3++;
								break;
							}
						}
						if (!bool_0)
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							bool flag7 = true;
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text.Split(':')[0] + ") ";
								method_11(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_67(text, 0);
								if (text12 == "")
								{
									flag7 = false;
								}
							}
							if (!flag7)
							{
								Class7 class9 = class5;
								class9.int_2--;
								class9 = class5;
								class9.int_3--;
								break;
							}
							goto default;
						}
						method_11(num3, text11 + GClass29.smethod_0("Đã dừng!"));
						num = 1;
					}
					goto IL_46fd;
				case 13:
					method_12(num3, GClass29.smethod_0("Đang lấy Api MinProxy..."));
					class6 = null;
					flag = false;
					num17 = 0;
					if (list_32.Count != 0)
					{
						lock (object_2)
						{
							while (!bool_0)
							{
								foreach (Class11 item7 in list_32)
								{
									if (item7.int_6 != 0)
									{
										if (class6 == null || item7.int_7 < class6.int_7)
										{
											class6 = item7;
										}
										continue;
									}
									class6 = item7;
									break;
								}
								if (class6.int_7 < class6.int_8)
								{
									break;
								}
							}
							if (class6 != null)
							{
								Class11 class7 = class6;
								class7.int_6++;
								class7 = class6;
								class7.int_7++;
								num17 = class6.int_7;
								goto IL_0f1f;
							}
						}
						goto IL_11a1;
					}
					method_12(num3, GClass29.smethod_0("Hết proxy."));
					goto IL_46fd;
				case 14:
					method_12(num3, GClass29.smethod_0("Đang lấy Proxy..."));
					lock (object_2)
					{
						if (gclass17_1.method_2("typeRunObcProxy") == 0)
						{
							while (!bool_0)
							{
								gClass2 = null;
								List<GClass9> list2 = new List<GClass9>();
								foreach (GClass9 item8 in list_33)
								{
									if (item8.bool_0)
									{
										if (item8.int_2 < item8.int_3)
										{
											list2.Add(item8);
										}
										else if (item8.int_1 == 0)
										{
											item8.method_1();
											item8.int_2 = 0;
										}
									}
								}
								for (int n = 0; n < list2.Count; n++)
								{
									if (list2[n].method_4(0))
									{
										gClass2 = list2[n];
										break;
									}
								}
								if (gClass2 != null)
								{
									text = gClass2.string_1;
									num4 = gClass2.int_0;
									GClass9 gClass4 = gClass2;
									gClass4.int_1++;
									gClass4 = gClass2;
									gClass4.int_2++;
									break;
								}
							}
						}
						else
						{
							while (!bool_0)
							{
								gClass2 = null;
								List<GClass9> list3 = new List<GClass9>();
								foreach (GClass8 item9 in list_34)
								{
									if (item9.method_5())
									{
										item9.method_4();
										list3.AddRange(item9.method_2());
									}
									else
									{
										list3.AddRange(item9.method_3());
									}
								}
								for (int num16 = 0; num16 < list3.Count; num16++)
								{
									if (list3[num16].method_4(0))
									{
										gClass2 = list3[num16];
										break;
									}
								}
								if (gClass2 != null)
								{
									text = gClass2.string_1;
									num4 = gClass2.int_0;
									GClass9 gClass4 = gClass2;
									gClass4.int_1++;
									gClass4 = gClass2;
									gClass4.int_2++;
									break;
								}
							}
						}
						if (!bool_0)
						{
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								Class309.smethod_0(dtgvAcc, num3, "cStatus", gclass17_1.method_2("nudDelayCheckIP"), text11 + "Delay after change ip {time}s...");
							}
							bool flag9 = true;
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text + ") ";
								method_12(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_68(text, num4, gclass17_1.method_2("nudDelayCheckIPObcProxy", 1) * 60);
								if (text12 == "")
								{
									gClass2.bool_0 = false;
									flag9 = false;
								}
							}
							if (!flag9)
							{
								GClass9 gClass4 = gClass2;
								gClass4.int_1--;
								gClass4 = gClass2;
								gClass4.int_2--;
								break;
							}
							goto default;
						}
						method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
					}
					goto IL_46fd;
				case 9:
					text = Class309.smethod_3(dtgvAcc, num3, "cProxy");
					num4 = (text.EndsWith("*1") ? 1 : 0);
					if (text.EndsWith("*0") || text.EndsWith("*1"))
					{
						text = text.Substring(0, text.Length - 2);
					}
					goto default;
				default:
					{
						if (!gclass17_1.method_3("ckbKhongCheckIP"))
						{
							if (gclass17_1.method_2("ip_iTypeChangeIp") != 7 && gclass17_1.method_2("ip_iTypeChangeIp") != 8 && gclass17_1.method_2("ip_iTypeChangeIp") != 10 && gclass17_1.method_2("ip_iTypeChangeIp") != 11 && gclass17_1.method_2("ip_iTypeChangeIp") != 12 && gclass17_1.method_2("ip_iTypeChangeIp") != 13 && gclass17_1.method_2("ip_iTypeChangeIp") != 14)
							{
								if (text != "")
								{
									text11 = "(IP: " + text.Split(':')[0] + ") ";
								}
								method_11(num3, text11 + "Check IP...");
								bool flag4 = false;
								for (int j = 0; j < 30; j++)
								{
									GClass14.smethod_58(1.0);
									text12 = GClass14.smethod_67(text, num4);
									if (text12 != "")
									{
										flag4 = true;
										break;
									}
								}
								if (!flag4)
								{
									goto IL_1760;
								}
							}
							text11 = ((text12 == "") ? "" : ("(IP: " + text12 + ") "));
						}
						try
						{
							method_12(num3, text11 + GClass29.smethod_0("Chờ đến lượt..."));
							lock (object_1)
							{
								if (int_0 > 0)
								{
									int num5 = random_0.Next(gclass17_1.method_2("nudDelayOpenChromeFrom", 1), gclass17_1.method_2("nudDelayOpenChromeTo", 1) + 1);
									if (num5 > 0)
									{
										int tickCount = Environment.TickCount;
										while ((Environment.TickCount - tickCount) / 1000 - num5 < 0)
										{
											method_12(num3, text11 + GClass29.smethod_0("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num5 - (Environment.TickCount - tickCount) / 1000).ToString()));
											GClass14.smethod_58(0.5);
											if (!bool_0)
											{
												continue;
											}
											method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
											num = 1;
											goto end_IL_17b2;
										}
									}
								}
								else
								{
									int_0++;
								}
							}
							method_12(num3, text11 + GClass29.smethod_0("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
							string text13 = "data:,";
							Point point_ = GClass14.smethod_64(int_1, gclass17_1.method_2("cbbColumnChrome", 3), gclass17_1.method_2("cbbRowChrome", 2));
							Point point_2 = GClass14.smethod_63(gclass17_1.method_2("cbbColumnChrome", 3), gclass17_1.method_2("cbbRowChrome", 2));
							if (text7 == "")
							{
								text7 = Class49.string_7;
							}
							if (text7 == "")
							{
								text7 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.82 Safari/537.36";
							}
							string text14 = "";
							if (text3 != "")
							{
								text14 = GClass36.smethod_0() + "\\" + text3;
								if (!gclass17_0.method_3("ckbCreateProfile") && !Directory.Exists(text14))
								{
									text14 = "";
								}
							}
							if (gclass17_1.method_2("ip_iTypeChangeIp") == 13)
							{
								num4 = ((gclass17_1.method_2("typeProxyMin") >= 2) ? 1 : 0);
							}
							GClass12 gClass3 = new GClass12();
							gClass3.int_0 = num3;
							gClass3.Boolean_2 = !Convert.ToBoolean((gclass17_1.method_0("ckbShowImageInteract") == "") ? "false" : gclass17_1.method_0("ckbShowImageInteract"));
							gClass3.String_0 = text7;
							gClass3.String_1 = text14;
							gClass3.Point_0 = point_2;
							gClass3.Point_1 = point_;
							gClass3.Int32_1 = 3;
							gClass3.Int32_2 = 120;
							gClass3.String_2 = text;
							gClass3.Int32_3 = num4;
							gClass3.Boolean_3 = true;
							gClass3.String_3 = text13;
							gClass3.Boolean_6 = gclass17_1.method_3("ckbUsePortable");
							gClass3.String_6 = gclass17_1.method_0("txtPathToPortableZip");
							gClass = gClass3;
							if (gclass17_1.method_0("sizeChrome").Contains("x"))
							{
								gClass.Boolean_5 = true;
								string text15 = gclass17_1.method_0("sizeChrome").Substring(0, gclass17_1.method_0("sizeChrome").LastIndexOf('x'));
								int int32_ = Convert.ToInt32(gclass17_1.method_0("sizeChrome").Split('x')[2]);
								gClass.Point_2 = new Point(Convert.ToInt32(text15.Split('x')[0]), Convert.ToInt32(text15.Split('x')[1]));
								if (text7 == "")
								{
									gClass.String_0 = Class49.string_7;
								}
								gClass.Int32_0 = int32_;
							}
							if (bool_0)
							{
								method_12(num3, text11 + GClass29.smethod_0("Đã dừng!"));
								num = 1;
							}
							else
							{
								if (gclass17_1.method_2("typeBrowser") != 0)
								{
									gClass.String_4 = gclass17_1.method_0("txtLinkToOtherBrowser");
								}
								int num6 = 0;
								while (true)
								{
									if (gClass.method_0())
									{
										gClass.method_20("document.title=\"proxyauth=" + text + "\"");
										gClass.method_67(2.0);
										if (!gclass17_1.method_3("ckbKhongCheckIP") && text.Split(':').Length > 1)
										{
											gClass.method_13("https://api.myip.com/");
											gClass.method_67(1.0);
											string text16 = gClass.method_1();
											if (!text16.Contains("ip"))
											{
												gClass.method_58();
												num6++;
												if (num6 >= 3)
												{
													method_12(num3, text11 + GClass29.smethod_0("Lỗi kết nối proxy!"));
													num = 1;
													break;
												}
												continue;
											}
										}
										if (!gClass.method_69())
										{
											method_12(num3, text11 + GClass29.smethod_0("Không check đươ\u0323c chrome!"));
											num = 1;
											break;
										}
										method_12(num3, text11 + GClass29.smethod_0("Đang đăng nhâ\u0323p..."));
										if (bool_2)
										{
											gClass.method_13("chrome-extension://lpmockibcakojclnfmhchibmdpmollgn/editor.html?store=0");
											gClass.method_67(1.0);
											if (gClass.method_46("#cookieupload", 10.0) == 1)
											{
												gClass.method_29(1, "cookieupload", Application.StartupPath + "\\configschange\\cookieJson\\" + text8 + ".txt");
												gClass.method_67(5.0);
												text14 = "x";
											}
										}
										bool flag5 = false;
										bool flag6 = false;
										string text17 = "https://www.facebook.com/";
										if (gclass17_0.method_2("typeBrowserLogin") == 0)
										{
											text17 = "https://m.facebook.com/";
										}
										else if (gclass17_0.method_2("typeBrowserLogin") == 2)
										{
											text17 = "https://mbasic.facebook.com/";
										}
										if (gclass17_0.method_2("typeBrowserLogin") == 3)
										{
											flag6 = true;
										}
										if (text14.Trim() != "")
										{
											num2 = GClass15.smethod_34(gClass, text17);
											if (gClass.method_12().Contains("facebook.com/confirm"))
											{
												goto IL_233b;
											}
											switch (num2)
											{
											case -3:
												gClass.GEnum10_0 = GEnum10.const_6;
												goto end_IL_1ceb;
											case -2:
												gClass.GEnum10_0 = GEnum10.const_1;
												goto end_IL_1ceb;
											case 1:
												flag5 = true;
												break;
											case 2:
												gClass.GEnum10_0 = GEnum10.const_4;
												goto end_IL_1ceb;
											}
										}
										if (!flag5)
										{
											string text18 = "";
											switch (gclass17_0.method_2("typeLogin"))
											{
											case 1:
												if (text5.Trim() == "")
												{
													method_12(num3, text11 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Cookie!"));
													num = 1;
													goto end_IL_1ceb;
												}
												method_12(num3, text11 + GClass29.smethod_0("Đăng nhâ\u0323p bă\u0300ng cookie..."));
												num2 = Convert.ToInt32(GClass15.smethod_25(gClass, text5, text17));
												goto default;
											case 0:
												if (text3.Trim() == "" || text4.Trim() == "")
												{
													if (text3.Trim() == "")
													{
														method_12(num3, text11 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y UID!"));
													}
													else if (text4.Trim() == "")
													{
														method_12(num3, text11 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y Pass!"));
													}
													num = 1;
													goto end_IL_1ceb;
												}
												method_12(num3, text11 + GClass29.smethod_0("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
												text18 = ((!gclass17_0.method_3("change_ckbGiaiCheckPoint")) ? GClass15.smethod_30(gClass, text3, text4, text6, text17, gclass17_1.method_2("tocDoGoVanBan"), gclass17_1.method_3("ckbDontSaveBrowser"), gclass17_1.method_2("type2Fa"), 120, flag6) : GClass15.smethod_30(gClass, text3, text4, text6, "https://www.facebook.com", gclass17_1.method_2("tocDoGoVanBan"), gclass17_1.method_3("ckbDontSaveBrowser"), gclass17_1.method_2("type2Fa"), 120, flag6));
												try
												{
													num2 = Convert.ToInt32(text18);
												}
												catch
												{
													num2 = -1;
												}
												goto default;
											default:
												if (gClass.method_12().Contains("facebook.com/confirm"))
												{
													break;
												}
												if (gclass17_0.method_2("typeLogin") != 1)
												{
													switch (num2)
													{
													case -2:
														gClass.GEnum10_0 = GEnum10.const_1;
														goto default;
													case -1:
														method_12(num3, text11 + text18);
														goto default;
													case 0:
														method_12(num3, text11 + GClass29.smethod_0("Đăng nhập thất bại!"));
														goto default;
													case 1:
														flag5 = true;
														goto default;
													case 2:
														gClass.GEnum10_0 = GEnum10.const_4;
														method_13(text2, num3, GClass29.smethod_0("Checkpoint"));
														goto end_IL_1ceb;
													case 3:
														method_12(num3, text11 + GClass29.smethod_0("Không có 2fa!"));
														goto default;
													case 4:
														method_12(num3, text11 + GClass29.smethod_0("Tài khoản không đúng!"));
														goto default;
													case 5:
														method_12(num3, text11 + GClass29.smethod_0("Mật khẩu không đúng!"));
														method_13(text2, num3, "Changed pass");
														goto default;
													case 6:
														method_12(num3, text11 + GClass29.smethod_0("Mã 2fa không đúng!"));
														goto default;
													case 7:
														gClass.GEnum10_0 = GEnum10.const_6;
														goto default;
													case 8:
														gClass.GEnum10_0 = GEnum10.const_8;
														goto default;
													default:
														if (flag5)
														{
															break;
														}
														method_25(gClass, text3, 1);
														num = 1;
														goto end_IL_1ceb;
													}
													break;
												}
												switch (num2)
												{
												case -3:
													gClass.GEnum10_0 = GEnum10.const_6;
													goto end_IL_1ceb;
												case -2:
													gClass.GEnum10_0 = GEnum10.const_1;
													goto end_IL_1ceb;
												case 1:
													flag5 = true;
													goto default;
												case 2:
													gClass.GEnum10_0 = GEnum10.const_4;
													method_13(text2, num3, GClass29.smethod_0("Checkpoint"));
													goto end_IL_1ceb;
												case 3:
													if (gclass17_0.method_3("change_ckbVerify"))
													{
														flag5 = true;
													}
													goto default;
												default:
													if (flag5)
													{
														break;
													}
													method_12(num3, text11 + GClass29.smethod_0("Đăng nhâ\u0323p thâ\u0301t ba\u0323i!"));
													method_25(gClass, text3, 1);
													num = 1;
													goto end_IL_1ceb;
												}
												break;
											}
										}
										goto IL_233b;
									}
									method_12(num3, text11 + GClass29.smethod_0("Lỗi mở trình duyệt!"));
									num = 1;
									break;
									IL_233b:
									method_12(num3, text11 + GClass29.smethod_0("Đăng nhâ\u0323p tha\u0300nh công!"));
									if (gClass.method_12().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway/nt/"))
									{
										gClass.method_28(4, "span");
										gClass.method_67(2.0);
									}
									if (gClass.method_12().Contains("gettingstarted"))
									{
										for (int k = 0; k < 5; k++)
										{
											if (gClass.method_46("#nux-nav-button", 3.0) != 1)
											{
												break;
											}
											gClass.method_26(1, "nux-nav-button");
											gClass.method_67(2.0);
										}
									}
									if (gClass.method_46("a[href*=\"basic_site_devices\"]") == 1)
									{
										string input = gClass.method_1();
										string value = Regex.Match(input, "gfid=(.*?)&").Groups[1].Value;
										string value2 = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
										string text19 = "fb_dtsg=" + value2 + "&jazoest=22600&basic_site_devices=m_touch";
										GClass15.smethod_40(gClass, "https://m.facebook.com/a/preferences.php?gfid=" + value, text19, "https://m.facebook.com");
									}
									if (text3 == "")
									{
										text3 = Regex.Match(gClass.method_62() + ";", "c_user=(.*?);").Groups[1].Value;
										if (text3 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cUid", text3);
										}
									}
									if (bool_2)
									{
										string input2 = GClass15.smethod_39(gClass, "https://m.facebook.com/help", "https://m.facebook.com");
										string value3 = Regex.Match(input2, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
										input2 = GClass15.smethod_40(gClass, "https://www.facebook.com/api/graphql/", "av=" + text3 + "&__user=" + text3 + "&__a=1&__dyn=&__csr=&__req=1f&__hs=19049.HYP:comet_pkg.2.1.0.2.&dpr=1&__ccg=EXCELLENT&__rev=&__s=hn7rus:ues7k3:uv8mdx&__hsi=7069051347170830170-0&__comet_req=1&fb_dtsg=" + value3 + "&jazoest=&lsd=&__spin_r=&__spin_b=trunk&__spin_t=&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=MWChatChangeTurnOffTabsSettingMutation&variables={\"input\":{\"turn_off_chat_tabs\":true,\"actor_id\":\"" + text3 + "\",\"client_mutation_id\":\"3\"}}&server_timestamps=true&doc_id=2558711324213856&fb_api_analytics_tags=[\"qpl_active_flow_ids = 30605361\"]", "https://www.facebook.com");
										input2 = GClass15.smethod_40(gClass, "https://www.facebook.com/api/graphql/", "av=" + text3 + "&__user=" + text3 + "&__a=1&__dyn=&__csr=&__hs=19060.HYP:comet_pkg.2.1.0.2.&dpr=1&__ccg=EXCELLENT&__rev=&__s=uwu6o6:4chi3z:w60kzp&__hsi=7072910840164422181-0&__comet_req=1&fb_dtsg=" + value3 + "&jazoest=22063&lsd=&__spin_r=&__spin_b=trunk&__spin_t=&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=MWChatChangeTurnOffTabsSettingMutation&variables={\"input\":{\"turn_off_chat_tabs\":true,\"actor_id\":" + text3 + ",\"client_mutation_id\":\"9\"}}&server_timestamps=true&doc_id=2558711324213856&fb_api_analytics_tags=[\"qpl_active_flow_ids=30605361\"]", "https://www.facebook.com");
									}
									if (gclass17_0.method_3("change_ckbDoiNgonNgu"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đô\u0309i ngôn ngư\u0303..."));
										num2 = method_43(gClass, gclass17_0.method_0("change_cbbNgonNgu"));
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("change_ckbVerify"))
									{
										gClass.method_13("https://m.facebook.com");
										gClass.method_67(1.0);
										if (gClass.method_12().Contains("facebook.com/confirm"))
										{
											int int_2 = gclass17_0.method_2("change_typeMail");
											num2 = method_21(gClass, text4, num3, text11, text2, int_2);
											switch (num2)
											{
											case 0:
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Verify fail!"));
												method_50(num3, 2);
												num = 1;
												goto end_IL_1ceb;
											case 1:
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Verify Success..."));
												goto default;
											case 2:
												num = 4;
												goto end_IL_1ceb;
											case 3:
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Hết mail!"));
												bool_0 = true;
												num = 1;
												goto end_IL_1ceb;
											default:
												switch (GClass15.smethod_23(gClass))
												{
												default:
													gClass.method_13("https://m.facebook.com");
													gClass.method_39(2, 3);
													if (gClass.method_46("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
													{
														gClass.method_20("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
														gClass.method_67(3.0);
														if (gClass.method_46("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
														{
															gClass.method_20("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
															gClass.method_67(3.0);
														}
													}
													break;
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													goto end_IL_1ceb;
												case -2:
													num = 2;
													goto end_IL_1ceb;
												case -1:
													num = 3;
													goto end_IL_1ceb;
												}
												break;
											case 5:
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Fb không gư\u0309i otp vê\u0300 mail!"));
												num = 1;
												goto end_IL_1ceb;
											}
										}
									}
									if (gclass17_0.method_3("change_ckbAddPhone"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Thêm sô\u0301 điê\u0323n thoa\u0323i..."));
										num2 = method_44(gClass, gclass17_0.method_0("change_txtPhone"), random_0);
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("change_ckbDoiAvatar"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đô\u0309i avatar..."));
										string text20 = "";
										lock (list_23)
										{
											if (list_23.Count == 0)
											{
												list_23 = method_7(list_22);
											}
											if (!gclass17_0.method_3("change_ckbAvatarThuTu"))
											{
												text20 = list_23[random_0.Next(random_0.Next(0, list_23.Count))];
												list_23.Remove(text20);
											}
											else
											{
												text20 = list_23[num3];
											}
										}
										num2 = method_45(gClass, text20, random_0);
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										case 1:
											Class36.smethod_13(text2, "avatar", "Co\u0301");
											if (gclass17_0.method_3("ckbAutoDeleteFile") && File.Exists(text20))
											{
												File.Delete(text20);
											}
											break;
										}
									}
									if (gclass17_0.method_3("change_ckbDoiAnhBia"))
									{
										num2 = 0;
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đô\u0309i a\u0309nh bi\u0300a..."));
										string text21 = "";
										if (gclass17_0.method_2("change_typeUpCover") == 0)
										{
											lock (list_25)
											{
												if (list_25.Count == 0)
												{
													list_25 = method_7(list_24);
												}
												if (!gclass17_0.method_3("change_ckbCoverThuTu"))
												{
													text21 = list_25[random_0.Next(0, list_25.Count)];
													list_25.Remove(text21);
												}
												else
												{
													text21 = list_25[num3];
												}
											}
											num2 = method_46(gClass, text21, random_0);
										}
										else
										{
											num2 = method_47(gClass, random_0);
										}
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										case 1:
											if (gclass17_0.method_3("ckbAutoDeleteFile") && text21 != "" && File.Exists(text21))
											{
												File.Delete(text21);
											}
											break;
										}
									}
									if (gclass17_0.method_3("change_ckbThemMoTa"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Câ\u0323p nhâ\u0323t tiê\u0309u sư\u0309..."));
										string string_ = "";
										lock (list_21)
										{
											lock (list_21)
											{
												if (list_21.Count == 0)
												{
													list_21 = method_7(list_20);
												}
												string text22 = list_21[random_0.Next(0, list_21.Count)];
												list_21.Remove(text22);
												string_ = File.ReadAllText(text22);
											}
										}
										num2 = method_48(gClass, string_);
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("change_ckbCapNhatThongTin"))
									{
										num2 = 0;
										string text23 = "";
										lock (list_8)
										{
											if (list_8.Count == 0)
											{
												list_8 = GClass14.smethod_25(list_7);
											}
											if (list_8.Count > 0)
											{
												text23 = list_8[random_0.Next(0, list_8.Count)];
												list_8.Remove(text23);
											}
										}
										if (text23 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật nơi làm việc..."));
											num2 = method_39(gClass, text23);
											switch (num2)
											{
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_1ceb;
											}
										}
										string text24 = "";
										lock (list_10)
										{
											if (list_10.Count == 0)
											{
												list_10 = GClass14.smethod_25(list_9);
											}
											if (list_10.Count > 0)
											{
												text24 = list_10[random_0.Next(0, list_10.Count)];
												list_10.Remove(text24);
											}
										}
										if (text24 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật quê qua\u0301n..."));
											num2 = method_37(gClass, text24);
											switch (num2)
											{
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_1ceb;
											}
										}
										string text25 = "";
										lock (list_12)
										{
											if (list_12.Count == 0)
											{
												list_12 = GClass14.smethod_25(list_11);
											}
											if (list_12.Count > 0)
											{
												text25 = list_12[random_0.Next(0, list_12.Count)];
												list_12.Remove(text25);
											}
										}
										if (text25 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật thành phố..."));
											num2 = method_38(gClass, text25);
											switch (num2)
											{
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_1ceb;
											}
										}
										string text26 = "";
										lock (list_14)
										{
											if (list_14.Count == 0)
											{
												list_14 = GClass14.smethod_25(list_13);
											}
											if (list_14.Count > 0)
											{
												text26 = list_14[random_0.Next(0, list_14.Count)];
												list_14.Remove(text26);
											}
										}
										if (text26 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật trường ĐH..."));
											num2 = method_41(gClass, text26);
											switch (num2)
											{
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_1ceb;
											}
										}
										string text27 = "";
										lock (list_16)
										{
											if (list_16.Count == 0)
											{
												list_16 = GClass14.smethod_25(list_15);
											}
											if (list_16.Count > 0)
											{
												text27 = list_16[random_0.Next(0, list_16.Count)];
												list_16.Remove(text27);
											}
										}
										if (text27 != "")
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật trường THPT..."));
											num2 = method_40(gClass, text27);
											switch (num2)
											{
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_1ceb;
											}
										}
									}
									if (gclass17_0.method_3("change_ckbGioiTinh"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đổi giới tính") + "...");
										int int_3 = gclass17_0.method_2("change_typeGioiTinh");
										num2 = method_19(gClass, int_3, text2);
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("change_ckbDoiNgaySinh"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đổi ngày sinh..."));
										int num7 = gclass17_0.method_2("change_nudNgayFrom");
										int num8 = gclass17_0.method_2("change_nudNgayTo");
										int minValue = gclass17_0.method_2("change_nudThangFrom");
										int num9 = gclass17_0.method_2("change_nudThangTo");
										int minValue2 = gclass17_0.method_2("change_nudNamFrom");
										int num10 = gclass17_0.method_2("change_nudNamTo");
										if (num7 == 31)
										{
											num7 = 30;
										}
										if (num8 == 31)
										{
											num8 = 30;
										}
										int num11 = random_0.Next(num7, num8 + 1);
										int num12 = random_0.Next(minValue, num9 + 1);
										int num13 = random_0.Next(minValue2, num10 + 1);
										if (num12 == 2 && num11 > 28)
										{
											num11 = 28;
										}
										num2 = smethod_0(gClass, num11, num12, num13);
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												break;
											case -2:
												num = 2;
												break;
											case -1:
												num = 3;
												break;
											}
											goto end_IL_1ceb;
										case 1:
										{
											string arg = ((num12 < 10) ? ("0" + num12) : (num12.ToString() ?? ""));
											string arg2 = ((num11 < 10) ? ("0" + num11) : (num11.ToString() ?? ""));
											Class36.smethod_13(text2, "birthday", $"{arg}/{arg2}/{num13}");
											Class309.smethod_5(dtgvAcc, num3, "cBirthday", $"{arg}/{arg2}/{num13}");
											break;
										}
										}
									}
									if (gclass17_0.method_3("change_ckbDoiTen"))
									{
										while (true)
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đổi tên..."));
											string text28 = "";
											string text29 = "";
											string text30 = "";
											text28 = list_2[random_0.Next(0, list_2.Count)];
											if (list_3.Count > 0)
											{
												text29 = list_3[random_0.Next(0, list_3.Count)];
											}
											text30 = list_4[random_0.Next(0, list_4.Count)];
											string string_2 = (text28 + " " + text29 + " " + text30).Replace("  ", " ");
											num2 = method_49(gClass, string_2, text4);
											switch (num2)
											{
											case 2:
												continue;
											case -2:
												num = 2;
												goto end_IL_3b08;
											case 0:
												switch (GClass15.smethod_23(gClass))
												{
												case -3:
													num = 1;
													method_11(num3, text11 + "Disconnect Internet!");
													break;
												case -2:
													num = 2;
													break;
												case -1:
													num = 3;
													break;
												}
												goto end_IL_3b08;
											}
											goto IL_3be1;
											continue;
											end_IL_3b08:
											break;
										}
										break;
									}
									goto IL_3be1;
									IL_3be1:
									if (gclass17_0.method_3("change_ckbDoiPass"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đổi mật khẩu..."));
										string text31 = "";
										text31 = ((gclass17_0.method_2("change_typeDoiPass") != 0) ? GClass14.smethod_55(15, random_0) : list_6[random_0.Next(0, list_6.Count)]);
										if (text31.Contains("*"))
										{
											string[] array = text31.Split('*');
											text31 = array[0];
											for (int l = 1; l < array.Length; l++)
											{
												text31 += GClass14.smethod_55(1, random_0);
												text31 += array[l];
											}
										}
										num2 = ((!gclass17_0.method_3("change_ckbDoiPassUseLinkHacked")) ? method_42(gClass, text4, text31) : method_20(gClass, text4, text31));
										switch (num2)
										{
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case 0:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đô\u0309i pass thâ\u0301t ba\u0323i..."));
											method_50(num3, 1);
											num = 1;
											goto end_IL_1ceb;
										case 1:
											Class36.smethod_13(text2, "pass", text31);
											Class309.smethod_5(dtgvAcc, num3, "cPassword", text31);
											text4 = text31;
											break;
										case 2:
											num = 4;
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("ckbAddMail"))
									{
										num2 = (gclass17_0.method_3("ckbAddMailLinkHacked") ? method_17(gClass, text4, num3, text11, text2) : method_28(gClass, text4, num3, text11, text2));
										switch (num2)
										{
										case 0:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Lỗi Add mail!"));
											method_50(num3, 2);
											goto default;
										case 1:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Thêm mail tha\u0300nh công..."));
											goto default;
										case 2:
											num = 4;
											goto end_IL_1ceb;
										case 3:
											if (gclass17_0.method_2("themMail") == 1)
											{
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Hết mail!"));
											}
											else
											{
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Không lấy được Temp-mail!"));
											}
											bool_0 = true;
											goto default;
										case 4:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Fb bắt nhập pass!"));
											goto default;
										case 5:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Fb không gư\u0309i otp vê\u0300 mail!"));
											goto default;
										case 6:
											if (bool_2)
											{
												Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Có lỗi xảy ra!"));
											}
											goto default;
										default:
											if ((num2 != 1 && gclass17_0.method_3("ckbCloseChrome")) || (num2 != 1 && bool_2))
											{
												num = 1;
												goto end_IL_1ceb;
											}
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												goto end_IL_1ceb;
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case -1:
												num = 3;
												goto end_IL_1ceb;
											}
											break;
										}
									}
									if (gclass17_0.method_3("change_ckb2fa"))
									{
										if (gclass17_0.method_2("change_type2fa") == 0)
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Bâ\u0323t 2fa..."));
											text6 = method_35(gClass, text4);
											if (text6.StartsWith("1|"))
											{
												text6 = text6.Split('|')[1];
												Class36.smethod_13(text2, "fa2", text6);
												Class309.smethod_5(dtgvAcc, num3, "cFa2", text6);
											}
										}
										else if (gclass17_0.method_2("change_type2fa") == 1)
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Tă\u0301t 2fa..."));
											if (method_36(gClass, text4))
											{
												Class36.smethod_13(text2, "fa2", "");
												Class309.smethod_5(dtgvAcc, num3, "cFa2", "");
											}
										}
										else
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Lấy 2fa..."));
											text6 = method_16(gClass, text4);
											if (text6.StartsWith("1|"))
											{
												text6 = text6.Split('|')[1];
												Class36.smethod_13(text2, "fa2", text6);
												Class309.smethod_5(dtgvAcc, num3, "cFa2", text6);
											}
										}
										switch (GClass15.smethod_23(gClass))
										{
										case -3:
											num = 1;
											method_11(num3, text11 + "Disconnect Internet!");
											goto end_IL_1ceb;
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case -1:
											num = 3;
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("ckbAnMailAll"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đang â\u0309n mail..."));
										gClass.method_13("https://m.facebook.com/settings/email/");
										gClass.method_67(3.0);
										int num14 = Convert.ToInt32(gClass.method_20("return document.querySelectorAll('[data-sigil=\"dialog-link\"]').length").ToString());
										for (int m = 0; m < num14; m++)
										{
											if (!Convert.ToBoolean(gClass.method_20("return document.querySelectorAll('[data-sigil=\"dialog-link\"]')[" + m + "].getAttribute('data-store').includes('sel=286958161406148')").ToString()))
											{
												gClass.method_26(4, "[data-sigil=\"dialog-link\"]", m);
												gClass.method_67(1.0);
												if (gClass.method_46("[data-sigil=\"audience-options-list\"]", 15.0) == 1)
												{
													gClass.method_26(4, "[data-sigil=\"audience-options-list\"]>label:nth-child(3)");
													gClass.method_67(1.0);
												}
											}
										}
										gClass.method_67(1.0);
									}
									if (gclass17_0.method_3("ckbXoaMailCu2"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đang xo\u0301a mail cu\u0303..."));
										switch (smethod_9(gClass, text4, Class309.smethod_3(dtgvAcc, num3, "cEmail"), gclass17_0.method_2("typeXoaMail")))
										{
										case 0:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Xóa mail thất bại!"));
											break;
										case 1:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Xóa mail thành công!"));
											break;
										case 2:
											num = 4;
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("ckbXoaSdt"))
									{
										num2 = method_33(gClass, text4, gclass17_0.method_2("typeXoaSdt"));
										switch (num2)
										{
										case 0:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Lỗi xóa SĐT!"));
											method_50(num3, 2);
											Class36.smethod_13(text2, "ghiChu", "Lỗi xóa sđt!");
											num = 1;
											goto end_IL_1ceb;
										case 1:
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Xóa SĐT tha\u0300nh công..."));
											goto default;
										default:
											switch (GClass15.smethod_23(gClass))
											{
											case -3:
												num = 1;
												method_11(num3, text11 + "Disconnect Internet!");
												goto end_IL_1ceb;
											case -2:
												num = 2;
												goto end_IL_1ceb;
											case -1:
												num = 3;
												goto end_IL_1ceb;
											}
											break;
										case 2:
											num = 4;
											goto end_IL_1ceb;
										}
									}
									if (gclass17_0.method_3("change_ckbXoaThietBiTinCay"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đang xóa thiết bị tin cậy..."));
										gClass.method_13("https://m.facebook.com/settings/security/two_factor/devices/");
										gClass.method_38();
										if (gClass.method_46("[data-sigil=\"removable-area marea\"] button", 10.0) == 1)
										{
											gClass.method_20("var x=document.querySelectorAll('[data-sigil=\"touchable removable-area-button\"]').length;for(var i=1;i<=x;i++){document.querySelectorAll('[data-sigil=\"touchable removable-area-button\"]')[x-i].click()}");
											gClass.method_67(1.0);
										}
									}
									if (gclass17_0.method_3("ckbLogOut"))
									{
										Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đang đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323..."));
										if (method_34(gClass))
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Đa\u0303 đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323!"));
										}
										else
										{
											Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Lô\u0303i đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323!"));
										}
										switch (GClass15.smethod_23(gClass))
										{
										case -3:
											num = 1;
											method_11(num3, text11 + "Disconnect Internet!");
											goto end_IL_1ceb;
										case -2:
											num = 2;
											goto end_IL_1ceb;
										case -1:
											num = 3;
											goto end_IL_1ceb;
										}
									}
									try
									{
										text5 = gClass.method_62();
										Class309.smethod_5(dtgvAcc, num3, "cCookies", text5);
										Class36.smethod_13(text2, "cookie1", text5);
									}
									catch
									{
									}
									break;
									continue;
									end_IL_1ceb:
									break;
								}
							}
							end_IL_17b2:;
						}
						catch (Exception exception_)
						{
							Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Lô\u0303i không xa\u0301c đi\u0323nh!"));
							GClass14.smethod_75(gClass, exception_);
						}
						goto IL_46fd;
					}
					IL_11a1:
					if (!flag)
					{
						lock (object_2)
						{
							Class11 class7 = class6;
							class7.int_6--;
							class7 = class6;
							class7.int_7--;
						}
						break;
					}
					goto default;
					IL_0f1f:
					method_12(num3, GClass29.smethod_0("Đang lấy Proxy từ API..."));
					num18 = 0;
					if (num17 > 1)
					{
						while (class6.bool_0)
						{
							GClass14.smethod_58(1.0);
							num18++;
							if (num18 > 60)
							{
								break;
							}
						}
						text = class6.method_5();
					}
					else
					{
						while (!bool_0)
						{
							switch (class6.method_3())
							{
							case 0:
								method_12(num3, GClass29.smethod_0("Đang lấy Proxy từ API: Chờ " + class6.Int32_4 + " s"));
								if (class6.Int32_4 > 10)
								{
									GClass14.smethod_58(10.0);
								}
								else if (class6.Int32_4 > 0)
								{
									GClass14.smethod_58(class6.Int32_4);
								}
								goto IL_1015;
							case 1:
								text = class6.String_1;
								class6.bool_0 = false;
								goto IL_1015;
							default:
								goto IL_1015;
							case -2:
								method_12(num3, GClass29.smethod_0("Api không đúng"));
								lock (object_2)
								{
									list_32.Remove(class6);
								}
								break;
							case -1:
								method_12(num3, GClass29.smethod_0("Api hết hạn"));
								lock (object_2)
								{
									list_32.Remove(class6);
								}
								break;
							}
							goto end_IL_0119;
							IL_1015:
							if (text != "")
							{
								break;
							}
						}
					}
					if (!(text == ""))
					{
						method_12(num3, GClass29.smethod_0("Đang kiểm tra proxy..."));
						if (!(GClass14.smethod_67(text, 0, 30) == ""))
						{
							flag = true;
							if (gclass17_1.method_2("nudDelayCheckIP") > 0)
							{
								method_12(num3, text11 + "Delay check IP...");
								GClass14.smethod_58(gclass17_1.method_2("nudDelayCheckIP"));
							}
							if (!gclass17_1.method_3("ckbKhongCheckIP"))
							{
								text11 = "(IP: " + text.Split(':')[0] + ") ";
								method_12(num3, text11 + "Check IP...");
								text12 = GClass14.smethod_67(text, 0);
								if (text12 == "")
								{
									flag = false;
								}
							}
						}
					}
					goto IL_11a1;
					end_IL_0119:
					break;
				}
				continue;
			}
			method_11(num3, text11 + GClass29.smethod_0("Đã dừng!"));
			num = 1;
			int num19 = 1;
			int num20 = 1;
			goto IL_48ad;
			IL_4903:
			Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Không ti\u0300m thâ\u0301y chrome!"));
			break;
			IL_48ad:
			GEnum10 gEnum10_ = gClass.GEnum10_0;
			GEnum10 gEnum = gEnum10_;
			if (gEnum == GEnum10.const_1 || gEnum == GEnum10.const_4 || gEnum == GEnum10.const_6)
			{
				Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass40.smethod_0(gClass.GEnum10_0));
			}
			break;
			IL_1760:
			method_11(num3, text11 + GClass29.smethod_0("Không thể kết nối proxy!"));
			num = 1;
			num19 = 1;
			num20 = 1;
			goto IL_48ad;
			IL_46fd:
			switch (num)
			{
			case 1:
				goto IL_48ad;
			case 2:
				goto IL_4903;
			case 3:
				goto IL_492a;
			case 4:
				goto IL_4979;
			}
			if (GClass15.smethod_36(gClass))
			{
				Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + "Checkpoint!");
				Class309.smethod_5(dtgvAcc, num3, "cInfo", "Die");
				Class36.smethod_13(text2, "info", "Die");
				method_50(num3, 4);
			}
			else if (!gclass17_0.method_3("ckbAddMail") || num2 == 1)
			{
				Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Cập nhật thông tin xong!"));
				if (bool_2)
				{
					text3 = Class309.smethod_3(dtgvAcc, num3, "cUid");
					text4 = Class309.smethod_3(dtgvAcc, num3, "cPassword");
					text9 = Class309.smethod_3(dtgvAcc, num3, "cEmail");
					text10 = Class309.smethod_3(dtgvAcc, num3, "cPassMail");
					text5 = Class309.smethod_3(dtgvAcc, num3, "cCookies");
					text6 = Class309.smethod_3(dtgvAcc, num3, "cFa2");
					File.AppendAllText("change_success.txt", text3 + "|" + text4 + "|" + text6 + "|" + text9 + "|" + text10 + "|" + text5 + Environment.NewLine);
				}
			}
			break;
			IL_4979:
			Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + GClass29.smethod_0("Sai pass!"));
			Class309.smethod_5(dtgvAcc, num3, "cInfo", "Changed pass");
			Class36.smethod_13(text2, "info", "Changed pass");
			method_50(num3, 3);
			break;
			IL_492a:
			Class309.smethod_5(dtgvAcc, num3, "cStatus", text11 + "Checkpoint!");
			Class309.smethod_5(dtgvAcc, num3, "cInfo", "Die");
			Class36.smethod_13(text2, "info", "Die");
			method_50(num3, 4);
			break;
		}
		try
		{
			gClass.method_58();
		}
		catch
		{
		}
		lock (object_3)
		{
			switch (gclass17_1.method_2("ip_iTypeChangeIp"))
			{
			case 7:
				@class?.method_1();
				break;
			case 8:
				class2?.method_3(gclass17_1.method_2("typeRunXproxy"));
				break;
			case 10:
				class3?.method_2();
				break;
			case 11:
				class4?.method_1();
				break;
			case 12:
				class5?.method_0();
				break;
			case 13:
				class6?.method_2();
				break;
			case 14:
				gClass2?.method_3();
				break;
			case 9:
				break;
			}
		}
	}

	public string method_15(string string_8, string string_9, string string_10)
	{
		string result = "";
		try
		{
			string text = "[FBAN/FB4A;FBAV/322.0.0.35.121;FBBV/297186297;FBDM/{density=2.75,width=1080,height=2130};FBLC/en_US;FBRV/298570471;FBCR/Viettel;FBMF/Xiaomi;FBBD/xiaomi;FBPN/com.facebook.katana;FBDV/Redmi Note 8;FBSV/10;FBOP/1;FBCA/arm64-v8a:;]";
			GClass19 gClass = new GClass19("", text, string_10, 0);
			gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_9);
			string text2 = "method=POST&challenge_type=PASSWORD&challenge_params={\"password\":\"" + string_8 + "\"}&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=validate_challenge&fb_api_caller_class=SecuredActionServiceHandler";
			string text3 = gClass.method_2("https://graph.facebook.com/secured_action/validate_challenge", text2);
			gClass.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
			gClass.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
			gClass.httpRequest_0.AddHeader("Authorization", " OAuth " + string_9);
			gClass.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
			gClass.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
			gClass.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
			gClass.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			gClass.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
			gClass.httpRequest_0.AddHeader("X-FB-Friendly-Name", " PageCreationNewPage");
			gClass.httpRequest_0.AddHeader("X-FB-Request-Analytics-Tags", " graphservice");
			gClass.httpRequest_0.AddHeader("X-FB-HTTP-Engine", " Liger");
			gClass.httpRequest_0.AddHeader("X-FB-Client-IP", " True");
			gClass.httpRequest_0.AddHeader("X-FB-Server-Cluster", " True");
			gClass.httpRequest_0.AddHeader("x-fb-connection-token", " f36ca4f6f658dd2e6a1f0ff6e43e6051");
			text2 = "doc_id=4330798123599254&method=post&locale=en_US&pretty=false&format=json&purpose=fetch&variables={\"params\":{\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"},\"path\":\"security/2fac/nt/setup/qr_code\",\"params\":\"{\\\"start_screen_id\\\":\\\"[\\\\\\\"__ntid:uu97dx:0__\\\\\\\",null]\\\"}\",\"extra_client_data\":{}},\"scale\":\"3\",\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"}}&fb_api_req_friendly_name=NativeTemplateScreenQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=[\"GraphServices\"]&server_timestamps=true";
			text3 = gClass.method_2("https://graph.facebook.com/graphql/", text2);
			result = Regex.Match(text3, "secret=(.*?)&").Groups[1].Value;
			string text4 = GClass14.smethod_83(result);
			gClass.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
			gClass.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
			gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_9);
			gClass.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
			gClass.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
			gClass.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
			gClass.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			gClass.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
			text2 = "doc_id=6091464777534071&method=post&locale=en_US&pretty=false&format=json&variables=%7B%22scale%22%3A%223%22%2C%22params%22%3A%7B%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22payload%22%3A%22security%2F2fac%2Fnt%2Fsetup%2Fcode_entry%2Fsubmit%3Fcontent_id%3D%255B%2522__ntid%253Av10gun%253A1__%2522%252Cnull%255D%26error_element_id%3D%255B%2522__ntid%253Av10gun%253A6__%2522%252Cnull%255D%26submit_button_id%3D%255B%2522__ntid%253Av10gun%253A4__%2522%252Cnull%255D%26progress_id%3D%255B%2522__ntid%253Av10gun%253A5__%2522%252Cnull%255D%26form_id%3D%255B%2522__ntid%253Av10gun%253A2__%2522%252Cnull%255D%26start_screen_id%3D%255B%2522__ntid%253Auu97dx%253A0__%2522%252Cnull%255D%22%2C%22client_data%22%3A%7B%22sensitive_string_value%22%3A%22%5B%5B%5C%22code%5B%5D%5C%22%2C%5C%22" + text4 + "%5C%22%5D%2C%5B%5C%22code_handler_type%5C%22%2C%5C%22third_party_qr_auth%5C%22%5D%5D%22%7D%7D%2C%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22profile_image_size%22%3A258%2C%22include_image_ranges%22%3Atrue%7D&fb_api_req_friendly_name=NativeTemplateAsyncQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=%5B%22GraphServices%22%5D&server_timestamps=true";
			text3 = gClass.method_2("https://graph.facebook.com/graphql/", text2);
			if (text3.Contains("error"))
			{
				result = "";
			}
		}
		catch
		{
		}
		return result;
	}

	private string method_16(GClass12 gclass12_0, string string_8)
	{
		string text = "";
		string result = "";
		try
		{
			gclass12_0.method_13("https://m.facebook.com/security/2fac/settings");
			while (true)
			{
				switch (gclass12_0.method_49(20.0, "[href=\"/security/2fac/setup/method/remove/?auth_method=phone\"]", "[data-sigil=\"context-layer-root content-pane\"] [data-sigil=\" flyout-causal\"]", "[name=\"pass\"]", "[href*=\"setup/qrcode/generate\"]"))
				{
				case 3:
					gclass12_0.method_29(2, "pass", string_8);
					gclass12_0.method_67(1.0);
					gclass12_0.method_26(2, "save");
					gclass12_0.method_67(1.0);
					continue;
				case 1:
					gclass12_0.method_13("https://m.facebook.com/security/2fac/setup/method/remove/?auth_method=phone");
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("[method=\"post\"] [type=\"submit\"]", 10.0) == 1)
					{
						gclass12_0.method_26(4, "[method=\"post\"] [type=\"submit\"]");
						gclass12_0.method_67(1.0);
						continue;
					}
					break;
				case 2:
				{
					gclass12_0.method_26(4, "[data-sigil=\"context-layer-root content-pane\"] [data-sigil=\" flyout-causal\"]");
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("[data-sigil=\" m-layer-root\"] a", 10.0) != 1)
					{
						break;
					}
					gclass12_0.method_26(4, "[data-sigil=\" m-layer-root\"] a");
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("[data-testid=\"key\"]", 20.0) != 1)
					{
						break;
					}
					text = gclass12_0.method_20("return document.querySelector('[data-testid=\"key\"]').innerText").ToString().Replace(" ", "");
					gclass12_0.method_26(2, "confirmButton");
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("[name=\"code\"]", 10.0) != 1)
					{
						break;
					}
					int num = 0;
					string text2;
					do
					{
						text2 = GClass14.smethod_83(text, gclass17_1.method_2("type2Fa"));
						if (!(text2 == ""))
						{
							break;
						}
						num++;
					}
					while (num == 1);
					if (text2 != "")
					{
						gclass12_0.method_29(4, "[name=\"code\"]", text2);
						gclass12_0.method_67(1.0);
						gclass12_0.method_26(1, "submit_code_button");
						gclass12_0.method_67(2.0);
					}
					else
					{
						result = "0|Không ta\u0323o đươ\u0323c ma\u0303 6 sô\u0301!";
					}
					break;
				}
				case 4:
					result = method_35(gclass12_0, string_8);
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (text != "")
		{
			result = "1|" + text;
		}
		return result;
	}

	private int method_17(GClass12 gclass12_0, string string_8, int int_1, string string_9, string string_10)
	{
		int result = 0;
		try
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			if (gclass17_0.method_2("themMail") == 1)
			{
				if (gclass17_0.method_3("ckbMailVip"))
				{
					if (list_17.Count == 0)
					{
						return 3;
					}
					text6 = list_17[random_0.Next(0, list_17.Count)];
					text5 = text6.Split('|')[0];
					text2 = text6.Split('|')[1];
					text6 = text6.Split('|', '@')[1];
					text = method_32(text6);
				}
				else
				{
					lock (list_17)
					{
						if (list_17.Count == 0)
						{
							return 3;
						}
						text4 = list_17[0];
						list_17.RemoveAt(0);
					}
					string[] array = text4.Split('|');
					text = array[0];
					text2 = array[1];
					if (array.Length > 2)
					{
						text3 = array[2];
					}
					Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + "Check mail...");
					Class318.smethod_0(text, text2, text3);
				}
			}
			else
			{
				text = method_22(gclass12_0, "https://temp-mail.org/");
				if (!(text != ""))
				{
					return 3;
				}
				text2 = "";
			}
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang thêm mail..."));
			for (int i = 0; i < 10; i++)
			{
				gclass12_0.method_13("https://m.facebook.com/hacked");
				if (GClass15.smethod_26(gclass12_0.method_12()) == 2)
				{
					break;
				}
			}
			if (gclass12_0.method_46("[value=\"someone_accessed\"]", 10.0) == 1)
			{
				gclass12_0.method_20("document.querySelector('[value=\"someone_accessed\"]').click()");
				gclass12_0.method_67(1.0);
				gclass12_0.method_55("document.querySelector('[type=\"submit\"]')");
				gclass12_0.method_26(4, "[type=\"submit\"]");
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("#checkpointButtonGetStarted-actual-button", 15.0) == 1)
				{
					gclass12_0.method_26(1, "checkpointButtonGetStarted-actual-button");
					gclass12_0.method_67(3.0);
					if (gclass12_0.method_46("#checkpointSubmitButton-actual-button", 30.0) == 1)
					{
						gclass12_0.method_26(2, "submit[Continue]");
						gclass12_0.method_67(1.0);
						while (true)
						{
							switch (gclass12_0.method_49(10.0, "[name=\"password_old\"]", "[name=\"password_new\"]", "[name=\"selected[]\"]"))
							{
							case 2:
								text7 = ((!gclass17_0.method_3("ckbRandomPassMailHacked")) ? gclass17_0.method_0("txtPassMailHacked") : (GClass14.smethod_55(8) + GClass14.smethod_56(4)));
								gclass12_0.method_29(2, "password_new", text7);
								gclass12_0.method_67(1.0);
								gclass12_0.method_26(2, "submit[Continue]");
								Class36.smethod_13(string_10, "pass", text7);
								Class309.smethod_5(dtgvAcc, int_1, "cPassword", text7);
								continue;
							case 1:
								text7 = ((!gclass17_0.method_3("ckbRandomPassMailHacked")) ? gclass17_0.method_0("txtPassMailHacked") : (GClass14.smethod_55(8) + GClass14.smethod_56(4)));
								gclass12_0.method_29(2, "password_old", string_8);
								gclass12_0.method_67(1.0);
								gclass12_0.method_29(2, "password_new", text7);
								gclass12_0.method_67(1.0);
								gclass12_0.method_29(2, "password_confirm", text7);
								gclass12_0.method_67(1.0);
								gclass12_0.method_26(2, "submit[Continue]");
								Class36.smethod_13(string_10, "pass", text7);
								Class309.smethod_5(dtgvAcc, int_1, "cPassword", text7);
								continue;
							case 3:
								gclass12_0.method_20("var x=document.querySelectorAll('[name=\"selected[]\"]');for(i=0;i<x.length;i++){{x[i].click();}}");
								gclass12_0.method_67(1.0);
								gclass12_0.method_26(2, "submit[Continue]");
								gclass12_0.method_67(1.0);
								while (true)
								{
									switch (gclass12_0.method_49(10.0, "[name=\"new_cp\"]", "[name=\"submit[Add New Email]\"]"))
									{
									case 2:
										break;
									case 1:
									{
										gclass12_0.method_29(2, "new_cp", text);
										gclass12_0.method_67(1.0);
										gclass12_0.method_26(2, "submit[Add]");
										gclass12_0.method_67(3.0);
										Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang lâ\u0301y otp..."));
										string text8 = "";
										text8 = (gclass17_0.method_3("ckbMailVip") ? Class318.smethod_4(3, text5, text2, text, 30, "imap.yandex.com") : ((!GClass14.smethod_14(text, text2).Equals("1")) ? method_30(text, text2, 1) : Class318.smethod_1(3, text, text2, 30, text3)));
										if (text8.Trim() == "")
										{
											Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Fb không gư\u0309i otp vê\u0300 mail!"));
											lock (object_0)
											{
												list_19.Add(text4);
											}
											return 5;
										}
										gclass12_0.method_29(2, "code", text8);
										gclass12_0.method_67(1.0);
										gclass12_0.method_26(2, "submit[Confirm]");
										gclass12_0.method_67(3.0);
										for (int j = 0; j < 5; j++)
										{
											if (gclass12_0.method_46("[name*=\"submit\"]", 5.0) != 1)
											{
												break;
											}
											gclass12_0.method_26(4, "[name*=\"submit\"]");
										}
										result = 1;
										Class36.smethod_13(string_10, "email", text);
										Class36.smethod_13(string_10, "passmail", text2);
										if (gclass17_0.method_3("ckbAnMailMoi"))
										{
											Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang â\u0309n mail..."));
											gclass12_0.method_13("https://m.facebook.com/settings/email/");
											gclass12_0.method_67(3.0);
											gclass12_0.method_20("document.querySelector('#root>div:nth-child(1)>div>div>div.acw.apl>div>div:nth-child(1)>div>div>div:nth-child(2)> a').click()");
											gclass12_0.method_67(2.0);
											gclass12_0.method_20("document.getElementsByName('px')[2].click()");
											gclass12_0.method_67(1.0);
										}
										goto end_IL_0553;
									}
									default:
										goto end_IL_0553;
									}
									gclass12_0.method_26(2, "submit[Add New Email]");
									gclass12_0.method_67(1.0);
									continue;
									end_IL_0553:
									break;
								}
								break;
							}
							break;
						}
					}
				}
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "Add Mail");
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Add mail thất bại!"));
		}
		return result;
	}

	public static string smethod_1(string string_8, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("https://otpmmo.xyz/textnow/api.php?apikey=" + string_8 + "&type=getphone&qty=1");
				if (text != "")
				{
					return text;
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_2(string string_8, string string_9, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("https://otpmmo.xyz/textnow/api.php?apikey=" + string_8 + "&type=getotp&sdt=" + string_9);
				if (text != "")
				{
					text = text.Remove(0, 1);
					text = text.Remove(text.Length - 1, 1);
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_3(string string_8, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://primeotp.me/api.php?apikey=" + string_8 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_4(string string_8, string string_9, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://primeotp.me/api.php?apikey=" + string_8 + "&action=data-request&requestId=" + string_9);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"]![0]!["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_5(string string_8, string string_9 = "servertextnow.xyz", int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://" + string_9 + "/api/get-phone/?access_token=" + string_8);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["phone"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_6(string string_8, string string_9, string string_10 = "servertextnow.xyz", int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://" + string_10 + "/api/get-otp/?access_token=" + string_8 + "&phone=" + string_9);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_7(string string_8, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://otpfb.com/api.php?apikey=" + string_8 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_8(string string_8, string string_9, int int_1 = 60)
	{
		GClass18 gClass = new GClass18();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				text = gClass.method_0("http://otpfb.com/api.php?apikey=" + string_8 + "&action=data-request&requestId=" + string_9);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"]![0]!["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	private int method_18(GClass12 gclass12_0, string string_8, string string_9, string string_10, bool bool_3 = false)
	{
		int result = 0;
		GClass15.smethod_46(gclass12_0, bool_3);
		switch (gclass12_0.GEnum10_0)
		{
		case GEnum10.const_1:
			result = -2;
			break;
		case GEnum10.const_2:
		case GEnum10.const_3:
		{
			string text = GClass15.smethod_30(gclass12_0, string_8, string_9, string_10, "https://m.facebook.com/", 2);
			result = ((text == "1") ? 1 : 2);
			break;
		}
		case GEnum10.const_4:
			result = -1;
			break;
		case GEnum10.const_6:
			result = -3;
			break;
		}
		return result;
	}

	public int method_19(GClass12 gclass12_0, int int_1, string string_8)
	{
		bool flag = false;
		try
		{
			int num = gclass12_0.method_14("https://m.facebook.com/profile/edit/infotab/section/forms/?section=basic-info");
			if (num == -2)
			{
				return -2;
			}
			if (gclass12_0.method_46("[data-sigil=\"gender-selector\"]", 30.0) == 1)
			{
				gclass12_0.method_54("document.querySelector('[data-sigil=\"gender-selector\"]')");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[data-sigil=\"option touchable\"]", int_1);
				gclass12_0.method_67(1.0);
				gclass12_0.method_54("document.querySelector('[name=\"save\"]')");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(2, "save");
				gclass12_0.method_67(1.0);
				for (int i = 0; i < 30; i++)
				{
					if (gclass12_0.method_46("#basic-info") == 1)
					{
						break;
					}
					Thread.Sleep(1000);
				}
				string text = "";
				switch (int_1)
				{
				case 0:
					text = "female";
					break;
				case 1:
					text = "male";
					break;
				}
				Class36.smethod_13(string_8, "gender", text);
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_20(GClass12 gclass12_0, string string_8, string string_9)
	{
		int num = 0;
		try
		{
			if (!gclass12_0.method_2())
			{
				return -2;
			}
			gclass12_0.method_14("https://m.facebook.com/hacked");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("[value=\"someone_accessed\"]", 10.0) == 1)
			{
				gclass12_0.method_67(1.0);
				gclass12_0.method_20("document.querySelector('[value=\"someone_accessed\"]').checked=true");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[type=\"submit\"]");
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("#checkpointButtonGetStarted-actual-button", 10.0) == 1)
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_26(4, "#checkpointButtonGetStarted-actual-button");
					gclass12_0.method_67(3.0);
					if (gclass12_0.method_46("#checkpointSubmitButton-actual-button", 60.0) == 1)
					{
						gclass12_0.method_67(1.0);
						int num2 = 0;
						for (int i = 0; i < 10; i++)
						{
							if (gclass12_0.method_46("[name=\"password_new\"]") == 1)
							{
								if (num2 > 0)
								{
									num = 0;
									return num;
								}
								gclass12_0.method_67(1.0);
								if (gclass12_0.method_46("[name=\"password_old\"]") == 1)
								{
									gclass12_0.method_29(2, "password_old", string_8);
									gclass12_0.method_67(2.0);
								}
								gclass12_0.method_29(2, "password_new", string_9);
								gclass12_0.method_67(2.0);
								if (gclass12_0.method_46("[name=\"password_confirm\"]") == 1)
								{
									gclass12_0.method_29(2, "password_confirm", string_9);
									gclass12_0.method_67(2.0);
								}
								num2++;
								num = 1;
							}
							string text = gclass12_0.method_70(0.0, "#checkpointSubmitButton-actual-button", "#checkpointButtonContinue-actual-button");
							if (text == "")
							{
								if (gclass12_0.method_12().StartsWith(GClass15.smethod_59(gclass12_0, 2) + "/home.php"))
								{
									return num;
								}
								if (gclass12_0.method_46("[href*=\"/friends/\"]") == 1)
								{
									return num;
								}
							}
							else
							{
								if (text == "-2")
								{
									num = -2;
									return num;
								}
								gclass12_0.method_26(4, text);
								gclass12_0.method_67(1.0);
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		if (num == 0)
		{
			GClass14.smethod_75(gclass12_0, null, "Doi Pass Fail");
		}
		return num;
	}

	private int method_21(GClass12 gclass12_0, string string_8, int int_1, string string_9, string string_10, int int_2)
	{
		int result = 0;
		gclass17_0.method_0("change_apiTempMail");
		try
		{
			string text = "";
			string object_ = "";
			string text2 = "";
			if (int_2 == 0)
			{
				lock (list_18)
				{
					if (list_18.Count == 0)
					{
						return 3;
					}
					text2 = list_18[0];
					list_18.RemoveAt(0);
				}
				text = text2.Split('|')[0];
				object_ = text2.Split('|')[1];
			}
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + "Check mail...");
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Veriry account..."));
			for (int i = 0; i < 10; i++)
			{
				gclass12_0.method_13("https://www.facebook.com/settings?tab=account");
				if (gclass12_0.method_46("#reload-button") != 1 && GClass15.smethod_26(gclass12_0.method_12()) == 1)
				{
					break;
				}
			}
			if (gclass12_0.method_46("#reload-button") == 1)
			{
				return 0;
			}
			string value = Regex.Match(gclass12_0.method_12(), "https://(.*?).facebook.com").Value;
			gclass12_0.method_20("function AddMail(email){var spinR = require([\"SiteData\"]).__spin_r; var spinB = require([\"SiteData\"]).__spin_b; var spinT = require([\"SiteData\"]).__spin_t; var jazoest = require([\"SprinkleConfig\"]).jazoest; var fbdtsg = require([\"DTSGInitData\"]).token; var userId = require([\"CurrentUserInitialData\"]).USER_ID; var hsi = require([\"SiteData\"]).hsi; var pass = \"\"; var url = \"" + value + "/add_contactpoint/dialog/submit/\"; var data = \"jazoest=22134&fb_dtsg=\" + fbdtsg + \"&next=&contactpoint=\" + email + \"&__user=\" + userId + \"&__a=1&__dyn=&__req=1&__be=1&__pc=PHASED%3ADEFAULT&dpr=1&__rev=&__s=&__hsi=\" + hsi + \"&__spin_r=\" + spinR + \"&__spin_b=\" + spinB + \"&__spin_t=\" + spinT; fetch(url, { method: 'POST', body: data, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).then(e => e.text()).then(e => {});};AddMail(\"" + text + "\");");
			gclass12_0.method_67(2.0);
			gclass12_0.method_13(value + "/settings?tab=account");
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang lâ\u0301y otp..."));
			string text3 = "";
			if (int_2 == 0)
			{
				text3 = Class318.smethod_3(text, object_, 10, 1);
			}
			if (text3 == "")
			{
				gclass12_0.method_15();
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("[rel=\"dialog-post\"]", 10.0) == 1)
				{
					gclass12_0.method_26(4, "[rel=\"dialog-post\"]");
					gclass12_0.method_67(2.0);
					text3 = Class318.smethod_1(2, text, object_);
				}
			}
			if (text3 == "block")
			{
				return 0;
			}
			if (text3.Trim() == "")
			{
				Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Fb không gư\u0309i otp vê\u0300 mail!"));
				lock (object_0)
				{
					list_19.Add(text2);
				}
				return 5;
			}
			for (int j = 0; j < 3; j++)
			{
				gclass12_0.method_13(text3);
				gclass12_0.method_67(2.0);
				if (gclass12_0.method_46("[href=\"/help/?ref=404\"]") != 1)
				{
					break;
				}
			}
			result = 1;
			method_27(int_1, "cEmail", text);
			method_27(int_1, "cPassMail", object_);
			Class36.smethod_13(string_10, "email", text);
			Class36.smethod_13(string_10, "passmail", object_);
		}
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "Verify");
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Verify fail!"));
		}
		return result;
	}

	private string method_22(GClass12 gclass12_0, string string_8, int int_1 = 30)
	{
		string text = "";
		try
		{
			for (int i = 0; i < int_1; i++)
			{
				if (!gclass12_0.method_12().Contains(string_8))
				{
					gclass12_0.method_13(string_8);
				}
				string[] array = gclass12_0.method_62(Regex.Match(string_8, "https://(.*?)\\.").Groups[1].Value).Split(';');
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Split('=')[0] == "email")
					{
						text = WebUtility.UrlDecode(array[j].Split('=')[1]);
						break;
					}
				}
				if (!(text != ""))
				{
					GClass14.smethod_58(1.0);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return text;
	}

	private string method_23(string string_8, int int_1 = 60)
	{
		string text = "";
		try
		{
			string text2 = method_24(string_8);
			GClass19 gClass = new GClass19("", "", "", 0);
			string text3 = "";
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < int_1 * 1000)
			{
				text3 = gClass.method_0("https://api4.temp-mail.org/request/mail/id/" + text2 + "/format/json");
				text = Regex.Match(text3, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value;
				text = text.Replace("amp;", "").Replace("\"", "").Replace("\\", "");
				if (!(text != ""))
				{
					Thread.Sleep(2000);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return text;
	}

	public string method_24(string string_8)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_8);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private void method_25(GClass12 gclass12_0, string string_8, int int_1)
	{
		try
		{
			if (gclass12_0 != null)
			{
				string text = Application.StartupPath + "\\log_capture";
				switch (int_1)
				{
				case 0:
					text += "\\checkpoint";
					break;
				case 1:
					text += "\\loginfail";
					break;
				case 2:
					text += "\\disconnect";
					break;
				}
				GClass14.smethod_32(text);
				gclass12_0.method_60(text, string_8);
				string contents = gclass12_0.method_20("var markup = document.documentElement.innerHTML;return markup;").ToString();
				File.WriteAllText(text + "\\" + string_8 + ".html", contents);
			}
		}
		catch
		{
		}
	}

	public string method_26(int int_1, string string_8)
	{
		return Class309.smethod_3(dtgvAcc, int_1, string_8);
	}

	public void method_27(int int_1, string string_8, object object_5, bool bool_3 = true)
	{
		if (bool_3 || !(object_5.ToString().Trim() == ""))
		{
			Class309.smethod_5(dtgvAcc, int_1, string_8, object_5);
		}
	}

	private int method_28(GClass12 gclass12_0, string string_8, int int_1, string string_9, string string_10)
	{
		int num = 0;
		try
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			if (gclass17_0.method_2("themMail") == 1)
			{
				if (gclass17_0.method_3("ckbMailVip"))
				{
					if (list_17.Count == 0)
					{
						return 3;
					}
					text6 = list_17[random_0.Next(0, list_17.Count)];
					text5 = text6.Split('|')[0];
					text2 = text6.Split('|')[1];
					text6 = text6.Split('|', '@')[1];
					text = method_32(text6);
				}
				else
				{
					lock (list_17)
					{
						if (list_17.Count == 0)
						{
							return 3;
						}
						text4 = list_17[0];
						list_17.RemoveAt(0);
					}
					string[] array = text4.Split('|');
					text = array[0];
					text2 = array[1];
					if (array.Length > 2)
					{
						text3 = array[2];
					}
				}
			}
			else
			{
				text = method_22(gclass12_0, "https://temp-mail.org/");
				if (!(text != ""))
				{
					return 3;
				}
				text2 = "";
			}
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang thêm mail..."));
			for (int i = 0; i < 10; i++)
			{
				gclass12_0.method_13("https://www.facebook.com/settings?tab=account");
				if (GClass15.smethod_26(gclass12_0.method_12()) == 1)
				{
					break;
				}
			}
			gclass12_0.method_20("function AddMail(email){var spinR = require([\"SiteData\"]).__spin_r; var spinB = require([\"SiteData\"]).__spin_b; var spinT = require([\"SiteData\"]).__spin_t; var jazoest = require([\"SprinkleConfig\"]).jazoest; var fbdtsg = require([\"DTSGInitData\"]).token; var userId = require([\"CurrentUserInitialData\"]).USER_ID; var hsi = require([\"SiteData\"]).hsi; var pass = \"\"; var url = \"https://www.facebook.com/add_contactpoint/dialog/submit/\"; var data = \"jazoest=22134&fb_dtsg=\" + fbdtsg + \"&next=&contactpoint=\" + email + \"&__user=\" + userId + \"&__a=1&__dyn=&__req=1&__be=1&__pc=PHASED%3ADEFAULT&dpr=1&__rev=&__s=&__hsi=\" + hsi + \"&__spin_r=\" + spinR + \"&__spin_b=\" + spinB + \"&__spin_t=\" + spinT; fetch(url, { method: 'POST', body: data, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).then(e => e.text()).then(e => {});};AddMail(\"" + text + "\");");
			gclass12_0.method_67(2.0);
			string text7 = GClass15.smethod_39(gclass12_0, "https://m.facebook.com/ntdelegatescreen/?params=%7B%22entry-point%22%3A%22settings%22%7D&path=%2Fcontacts%2Fmanagement%2F", "https://m.facebook.com/");
			if (!text7.Contains(GClass14.smethod_62(text.ToLower())))
			{
				return 0;
			}
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Đang lâ\u0301y otp..."));
			Thread.Sleep(3000);
			string text8 = "";
			text8 = (gclass17_0.method_3("ckbMailVip") ? Class318.smethod_4(0, text5, text2, text, 30, "imap.yandex.com") : ((!GClass14.smethod_14(text, text2).Equals("1")) ? method_30(text, text2) : Class318.smethod_1(0, text, text2, 30, text3)));
			if (text8.Trim() == "")
			{
				Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Fb không gư\u0309i otp vê\u0300 mail!"));
				lock (object_0)
				{
					list_19.Add(text4);
				}
				return 5;
			}
			GClass15.smethod_39(gclass12_0, text8.Replace("https://www.facebook.com/", "https://m.facebook.com/"), "https://m.facebook.com");
			num = 1;
			Class309.smethod_5(dtgvAcc, int_1, "cEmail", text);
			Class309.smethod_5(dtgvAcc, int_1, "cPassMail", text2);
			Class309.smethod_5(dtgvAcc, int_1, "cMailRecovery", "");
			Class36.smethod_13(string_10, "email", text);
			Class36.smethod_13(string_10, "passmail", text2);
			Class36.smethod_13(string_10, "mailrecovery", "");
			if (bool_2)
			{
				for (int j = 0; j < 3; j++)
				{
					num = method_29(gclass12_0, int_1, string_9);
					if (num == 1)
					{
						break;
					}
				}
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "Add Mail");
			Class309.smethod_5(dtgvAcc, int_1, "cStatus", string_9 + GClass29.smethod_0("Add mail thất bại!"));
		}
		return num;
	}

	private int method_29(GClass12 gclass12_0, int int_1, string string_8)
	{
		string text = "";
		int result = 6;
		try
		{
			method_12(int_1, string_8 + "Đang khôi phục mật khẩu...");
			string text2 = Class309.smethod_3(dtgvAcc, int_1, "cEmail");
			string text3 = Class309.smethod_3(dtgvAcc, int_1, "cPassMail");
			text = "";
			gclass12_0.method_13("https://m.facebook.com/recover/initiate/");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("[value=\"send_email\"]", 30.0) == 1)
			{
				string[] array = text2.Split('@');
				string text4 = "";
				for (int i = 0; i < array[0].Length - 2; i++)
				{
					text4 += "*";
				}
				array[0] = array[0].Replace(array[0].Substring(1, array[0].Length - 2), text4);
				if (gclass12_0.method_20("var check=0;for(var i=0;i<document.querySelectorAll('[method=\"post\"] label>div').length;i++){if(document.querySelectorAll('[method=\"post\"] label>div')[i].innerText.includes('" + array[0] + "')) check = 1} return check").ToString() == "1")
				{
					if (gclass12_0.method_20("return document.querySelector('[value=\"send_email\"]').getAttribute('checked')").ToString() != "1")
					{
						gclass12_0.method_26(4, "[value=\"send_email\"]");
						gclass12_0.method_67(1.0);
					}
					gclass12_0.method_26(2, "reset_action");
					gclass12_0.method_67(5.0);
					if (gclass12_0.method_46("[data-sigil=\"code-input\"]", 30.0) == 1)
					{
						method_12(int_1, string_8 + "Đang lấy mã otp...");
						while (true)
						{
							text = Class318.smethod_2(text2, text3);
							if (text != "")
							{
								string text5 = gclass12_0.method_12();
								gclass12_0.method_29(4, "[data-sigil=\"code-input\"]", text);
								gclass12_0.method_67(1.0);
								gclass12_0.method_26(2, "reset_action");
								gclass12_0.method_67(5.0);
								switch (gclass12_0.method_49(15.0, "[name=\"password_new\"]", "[data-sigil=\"code-input\"]"))
								{
								case 2:
									if (gclass12_0.method_12() == text5)
									{
										continue;
									}
									break;
								case 1:
								{
									method_12(int_1, string_8 + "Đang đổi mật khẩu...");
									string text6 = "";
									text6 = GClass14.smethod_55(6, random_0) + GClass14.smethod_56(4, random_0) + GClass14.smethod_55(5, random_0);
									for (int j = 0; j < 5; j++)
									{
										gclass12_0.method_29(2, "password_new", text6);
										if (gclass12_0.method_20("return document.querySelector('[name=\"password_new\"]').value+''").ToString() != "")
										{
											break;
										}
										gclass12_0.method_67(3.0);
									}
									gclass12_0.method_67(3.0);
									gclass12_0.method_26(4, "[data-sigil=\"touchable\"]");
									gclass12_0.method_67(1.0);
									GClass14.smethod_21(dtgvAcc, int_1, "cPassword", text6);
									if (gclass12_0.method_46("[method=\"post\"]", 10.0) == 1)
									{
										gclass12_0.method_26(2, "submit_action");
										gclass12_0.method_67(1.0);
									}
									if (GClass15.smethod_34(gclass12_0) == 1)
									{
										GClass14.smethod_21(dtgvAcc, int_1, "cStatus", string_8 + "Đổi pass xong!");
										result = 1;
									}
									break;
								}
								}
							}
							else
							{
								GClass14.smethod_21(dtgvAcc, int_1, "cStatus", string_8 + "Khôi phục mật khẩu thất bại!");
							}
							break;
						}
					}
				}
				else
				{
					GClass14.smethod_21(dtgvAcc, int_1, "cStatus", string_8 + "Không tìm thấy email để khôi phục mật khẩu!");
					Class309.smethod_5(dtgvAcc, int_1, "cGhiChu", "Không tìm thấy email!");
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private string method_30(string string_8, string string_9, int int_1 = 0)
	{
		try
		{
			string text = "";
			GClass18 gClass = new GClass18();
			for (int i = 0; i < 10; i++)
			{
				string text2 = gClass.method_0("https://tools.dongvanfb.com/api/get_messages?mail=" + string_8 + "&pass=" + string_9);
				if (!(text2 != ""))
				{
					continue;
				}
				JObject jObject = JObject.Parse(text2);
				foreach (JToken item in (IEnumerable<JToken>)(jObject["messages"]!))
				{
					if (!(item["from"]![0]!["address"]!.ToString() == "security@facebookmail.com"))
					{
						continue;
					}
					string input = item["message"]!.ToString();
					switch (int_1)
					{
					case 0:
						text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("\"", "");
						break;
					case 1:
						text = Regex.Match(input, "\\d{8}").Value.Trim();
						break;
					case 2:
						text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\"").Value.Trim().Replace("\"", "");
						if (text == "")
						{
							text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("\"", "");
						}
						break;
					case 3:
						text = Regex.Match(input, "confirmcontact.php\\?c=(.*?)&").Groups[1].Value;
						break;
					case 4:
						text = Regex.Match(input, "c=(.*?)&").Groups[1].Value;
						break;
					}
					if (text != "")
					{
						return text;
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	private string method_31(string string_8, int int_1)
	{
		string text = "";
		string text2 = "";
		try
		{
			GClass19 gClass = new GClass19("", "", "", 0);
			for (int i = 0; i < 33; i++)
			{
				string json = gClass.method_0("https://getnada.com/api/v1/inboxes/" + string_8);
				JObject jObject = JObject.Parse(json);
				try
				{
					text2 = jObject["msgs"]![0]!["uid"]!.ToString();
					if (text2 != "")
					{
						json = gClass.method_0("https://getnada.com/api/v1/messages/html/" + text2);
						text = Regex.Match(json, ">(\\d{" + int_1 + "})<").Groups[1].Value;
						if (text != "")
						{
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(3000);
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	private string method_32(string string_8)
	{
		string result = "";
		try
		{
			result = GClass22.smethod_17(10) + GClass22.smethod_18(4) + "@" + string_8;
		}
		catch
		{
		}
		return result;
	}

	private int method_33(GClass12 gclass12_0, string string_8, int int_1)
	{
		int result = 0;
		int num = gclass12_0.ChromeDriver_0.Manage().Window.Size.Width;
		int num2 = gclass12_0.ChromeDriver_0.Manage().Window.Size.Height;
		if (int_1 == 1)
		{
			gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(500, 700);
		}
		try
		{
			if (int_1 == 0)
			{
				gclass12_0.method_13("https://m.facebook.com/settings/sms/");
				gclass12_0.method_67(3.0);
				for (int i = 0; i < 5; i++)
				{
					string text = gclass12_0.method_5("a", "href", "/settings/sms/?remove");
					if (text != "")
					{
						gclass12_0.method_26(4, text);
						switch (gclass12_0.method_49(10.0, "[name=\"remove_phone_warning_acknwoledged\"]", "[name=\"contact_point\"]", "[name=\"save_password\"]"))
						{
						case 1:
							gclass12_0.method_26(2, "remove_phone_warning_acknwoledged");
							gclass12_0.method_67(1.0);
							gclass12_0.method_26(4, "button");
							gclass12_0.method_67(3.0);
							if (gclass12_0.method_46("[name=\"save_password\"]") != 1)
							{
								continue;
							}
							gclass12_0.method_29(2, "save_password", string_8);
							gclass12_0.method_67(1.0);
							if (gclass12_0.method_26(2, "save") == 0)
							{
								gclass12_0.method_20("document.querySelector('[name=\"save\"]').click()");
							}
							gclass12_0.method_67(3.0);
							try
							{
								if (Convert.ToBoolean(gclass12_0.method_20("var x='1'; if(document.querySelector('[name=\"save_password\"]')!=null) x=document.querySelector('[name=\"save_password\"]').value; return (x=='')+''")))
								{
									return 2;
								}
							}
							catch
							{
							}
							continue;
						default:
							gclass12_0.method_29(2, "save_password", string_8);
							gclass12_0.method_67(1.0);
							gclass12_0.method_26(2, "save");
							gclass12_0.method_67(3.0);
							try
							{
								if (Convert.ToBoolean(gclass12_0.method_20("var x='1'; if(document.querySelector('[name=\"save_password\"]')!=null) x=document.querySelector('[name=\"save_password\"]').value; return (x=='')+''")))
								{
									return 2;
								}
							}
							catch
							{
							}
							continue;
						case 2:
							result = 1;
							break;
						}
					}
					else
					{
						result = 1;
					}
					break;
				}
			}
			else
			{
				gclass12_0.method_13("https://www.facebook.com/update_security_info.php");
				gclass12_0.method_67(1.0);
				while (true)
				{
					switch (gclass12_0.method_49(10.0, "[name=\"pass\"]", "[name=\"mirror_submit\"]"))
					{
					case 1:
						break;
					case 2:
					{
						int num3 = Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('#mirror_section_phone .uiCloseButton.uiCloseButtonSmall').length").ToString());
						for (int j = 0; j < num3; j++)
						{
							gclass12_0.method_54("document.querySelectorAll('#mirror_section_phone .uiCloseButton.uiCloseButtonSmall')[0]");
							gclass12_0.method_67(1.0);
							gclass12_0.method_26(4, "#mirror_section_phone .uiCloseButton.uiCloseButtonSmall");
							gclass12_0.method_67(1.0);
							if (gclass12_0.method_46("#pop_content [name=\"confirm\"]", 10.0) != 1)
							{
								continue;
							}
							if (gclass12_0.method_26(4, "#pop_content [name=\"confirm\"]") != 1)
							{
								gclass12_0.method_20("document.querySelector('#pop_content [name=\"confirm\"]').click()");
							}
							for (int k = 0; k < 10; k++)
							{
								if (Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('#mirror_section_phone .uiCloseButton.uiCloseButtonSmall').length").ToString()) == num3 - j - 1)
								{
									break;
								}
								gclass12_0.method_67(1.0);
							}
							gclass12_0.method_67(1.0);
						}
						gclass12_0.method_13("https://www.facebook.com/settings?tab=mobile");
						gclass12_0.method_67(1.0);
						fMain.smethod_2(gclass12_0);
						for (int l = 0; l < 10; l++)
						{
							if (l != 0)
							{
								gclass12_0.method_15();
							}
							try
							{
								gclass12_0.ChromeDriver_0.SwitchTo().Frame(0);
							}
							catch
							{
							}
							string text2 = "[style=\"padding-bottom: 1%;\"] span a";
							string text3 = "[class*=\"fbSettingsListItemContent\"] a";
							switch (gclass12_0.method_49(5.0, text2, text3))
							{
							case 1:
								if (gclass12_0.method_26(4, text2) == 0)
								{
									gclass12_0.method_20("document.querySelector('" + text2 + "').click()");
								}
								gclass12_0.method_67(1.0);
								if (gclass12_0.method_46(".uiInputLabel.clearfix label", 10.0) != 1)
								{
									continue;
								}
								gclass12_0.method_20("document.querySelector('.uiInputLabel.clearfix label').click()");
								gclass12_0.method_67(1.0);
								gclass12_0.method_26(4, "[class*=\"layerConfirm uiOverlayButton\"]");
								gclass12_0.method_67(3.0);
								switch (gclass12_0.method_49(10.0, "[name=\"ajax_password\"]", "[id*=\"fetchstream\"] a", "[class*=\"selected uiButton uiButtonSpecial\"]", text2))
								{
								case 1:
									gclass12_0.method_29(2, "ajax_password", string_8);
									gclass12_0.method_67(1.0);
									gclass12_0.method_26(4, "[class*=\"layerConfirm uiOverlayButton\"]");
									gclass12_0.method_67(1.0);
									if (GClass15.smethod_48(gclass12_0))
									{
										return 0;
									}
									break;
								case 2:
									gclass12_0.method_26(4, "[id*=\"fetchstream\"] a");
									gclass12_0.method_67(1.0);
									if (gclass12_0.method_46("[class*=\"uiOverlayFooter\"] [type=\"submit\"]", 10.0) == 1)
									{
										gclass12_0.method_26(4, "[class*=\"uiOverlayFooter\"] [type=\"submit\"]");
										gclass12_0.method_67(1.0);
									}
									break;
								case 3:
									result = 1;
									break;
								}
								continue;
							default:
								if (gclass12_0.method_26(4, text3) == 0)
								{
									gclass12_0.method_20("document.querySelector('" + text3 + "').click()");
								}
								gclass12_0.method_67(1.0);
								if (gclass12_0.method_46("[role=\"dialog\"] [class*=\"layerConfirm uiOverlayButton\"]", 10.0) != 1)
								{
									continue;
								}
								gclass12_0.method_26(4, "[role=\"dialog\"] [class*=\"layerConfirm uiOverlayButton\"]");
								gclass12_0.method_67(1.0);
								switch (gclass12_0.method_49(10.0, "[name=\"ajax_password\"]", "[id*=\"fetchstream\"] a", "[class*=\"selected uiButton uiButtonSpecial\"]", text2))
								{
								case 1:
									gclass12_0.method_29(2, "ajax_password", string_8);
									gclass12_0.method_67(1.0);
									gclass12_0.method_26(4, "[class*=\"layerConfirm uiOverlayButton\"]");
									gclass12_0.method_67(1.0);
									if (GClass15.smethod_48(gclass12_0))
									{
										return 0;
									}
									break;
								case 2:
									gclass12_0.method_26(4, "[id*=\"fetchstream\"] a");
									gclass12_0.method_67(1.0);
									if (gclass12_0.method_46("[class*=\"uiOverlayFooter\"] [type=\"submit\"]", 10.0) == 1)
									{
										gclass12_0.method_26(4, "[class*=\"uiOverlayFooter\"] [type=\"submit\"]");
										gclass12_0.method_67(1.0);
									}
									break;
								case 3:
									result = 1;
									break;
								}
								continue;
							case 0:
								result = 1;
								break;
							}
							break;
						}
						goto end_IL_02da;
					}
					default:
						goto end_IL_02da;
					}
					gclass12_0.method_29(2, "pass", string_8);
					gclass12_0.method_67(1.0);
					gclass12_0.method_52(2, "pass");
					gclass12_0.method_67(1.0);
					continue;
					end_IL_02da:
					break;
				}
			}
		}
		catch
		{
		}
		gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(num, num2);
		return result;
	}

	public static int smethod_9(GClass12 gclass12_0, string string_8, string string_9 = "", int int_1 = 0)
	{
		int result = 0;
		int num = gclass12_0.ChromeDriver_0.Manage().Window.Size.Width;
		int num2 = gclass12_0.ChromeDriver_0.Manage().Window.Size.Height;
		if (int_1 == 1)
		{
			gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(500, 700);
		}
		try
		{
			if (int_1 == 0)
			{
				int num3 = 0;
				while (num3 < 2)
				{
					if (!gclass12_0.method_12().StartsWith("https://m.facebook.com/settings/email/"))
					{
						gclass12_0.method_13("https://m.facebook.com/settings/email/");
						gclass12_0.method_67(3.0);
					}
					string input = gclass12_0.method_20("return document.documentElement.innerHTML").ToString();
					MatchCollection matchCollection = Regex.Matches(input, "/settings/email/\\?remove_email&(.*?)\"");
					int num4 = 0;
					while (true)
					{
						if (num4 < matchCollection.Count)
						{
							string text = matchCollection[num4].Value.Replace("amp;", "").Replace("\"", "");
							string value = Regex.Match(text, "email=(.*?)&").Groups[1].Value;
							value = GClass14.smethod_61(value);
							if (value != string_9 && gclass12_0.method_20("return (document.documentElement.innerText.match(new RegExp('" + value + "', 'g')) || []).length+''").ToString() != "2")
							{
								gclass12_0.method_13("https://m.facebook.com" + text);
								if (gclass12_0.method_46("[name=\"save\"]", 10.0) == 1)
								{
									gclass12_0.method_67(3.0);
									while (true)
									{
										int num5 = gclass12_0.method_49(0.0, "[name=\"pass\"]", "[name=\"save_password\"]", "[href=\"https://www.facebook.com/help/177066345680802\"]");
										if (num5 == 0)
										{
											if (gclass12_0.method_46("[name=\"save\"]") != 1)
											{
												break;
											}
											gclass12_0.method_26(2, "save");
											gclass12_0.method_67(3.0);
											continue;
										}
										switch (num5)
										{
										case 1:
											gclass12_0.method_29(2, "pass", string_8);
											gclass12_0.method_67(1.0);
											gclass12_0.method_26(2, "save");
											gclass12_0.method_67(3.0);
											try
											{
												if (Convert.ToBoolean(gclass12_0.method_20("(document.querySelector('[name=\"pass\"]').value=='')+''")))
												{
													result = 2;
													goto end_IL_00d2;
												}
											}
											catch
											{
											}
											if (gclass12_0.method_46("[href=\"https://www.facebook.com/help/177066345680802\"]") != 1)
											{
												break;
											}
											result = 3;
											goto end_IL_00d2;
										case 2:
											gclass12_0.method_29(2, "save_password", string_8);
											gclass12_0.method_67(1.0);
											gclass12_0.method_26(2, "save");
											gclass12_0.method_67(3.0);
											try
											{
												if (Convert.ToBoolean(gclass12_0.method_20("(document.querySelector('[name=\"save_password\"]').value=='')+''")))
												{
													result = 2;
													goto end_IL_00d2;
												}
											}
											catch
											{
											}
											if (gclass12_0.method_46("[href=\"https://www.facebook.com/help/177066345680802\"]") != 1)
											{
												break;
											}
											result = 3;
											goto end_IL_00d2;
										case 3:
											result = 3;
											goto end_IL_00d2;
										}
										break;
									}
								}
							}
							num4++;
							continue;
						}
						num3++;
						goto IL_0075;
						continue;
						end_IL_00d2:
						break;
					}
					break;
					IL_0075:;
				}
			}
			else
			{
				while (true)
				{
					IL_037d:
					gclass12_0.method_13("https://www.facebook.com/settings?tab=account&section=email");
					gclass12_0.method_67(1.0);
					fMain.smethod_2(gclass12_0);
					gclass12_0.ChromeDriver_0.SwitchTo().Frame(0);
					if (string_9 != "")
					{
						int num6 = Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('[ajaxify*=\"/settings/account/email/primary\"]').length").ToString());
						for (int i = 0; i < num6; i++)
						{
							string value2 = string_9.Replace("@", "%40");
							string text2 = gclass12_0.method_20("return document.querySelectorAll('[ajaxify*=\"/settings/account/email/primary\"]')[" + i + "].getAttribute('ajaxify')").ToString();
							if (!text2.Contains(value2))
							{
								continue;
							}
							gclass12_0.method_26(4, "[ajaxify*=\"/settings/account/email/primary\"]", i);
							gclass12_0.method_67(1.0);
							if (gclass12_0.method_46("[type=\"password\"]", 5.0) == 1)
							{
								gclass12_0.method_29(4, "[type=\"password\"]", string_8);
								gclass12_0.method_67(1.0);
								gclass12_0.method_52(4, "[type=\"password\"]");
								gclass12_0.method_67(3.0);
								try
								{
									gclass12_0.ChromeDriver_0.SwitchTo().Frame(0);
								}
								catch
								{
								}
							}
						}
					}
					int num7 = 0;
					while (true)
					{
						if (num7 < 10)
						{
							switch (gclass12_0.method_49(5.0, ".SettingsEmailPendingCancel", "[ajaxify*=\"/email/remove\"]", " .fsm.fwn.fcg"))
							{
							case 2:
							{
								gclass12_0.method_54("document.querySelector('[ajaxify*=\"/email/remove\"]')");
								gclass12_0.method_67(1.0);
								if (gclass12_0.method_26(4, "[ajaxify*=\"/email/remove\"]") != 1)
								{
									gclass12_0.method_20("document.querySelector('[ajaxify*=\"/email/remove\"]').click()");
								}
								gclass12_0.method_67(1.0);
								int num8 = gclass12_0.method_49(5.0, "#ajax_password");
								if (num8 == 1)
								{
									gclass12_0.method_29(1, "ajax_password", string_8);
									gclass12_0.method_67(1.0);
									gclass12_0.method_52(1, "ajax_password");
								}
								gclass12_0.method_67(1.0);
								goto IL_057b;
							}
							case 3:
								if (Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('.fsm.fwn.fcg').length").ToString()) > 2)
								{
									gclass12_0.method_20("document.querySelectorAll('.fsm.fwn.fcg')[1].parentNode.querySelectorAll('a')[1].click()");
									gclass12_0.method_67(1.0);
									int num8 = gclass12_0.method_49(5.0, "#ajax_password");
									if (num8 == 1)
									{
										gclass12_0.method_29(1, "ajax_password", string_8);
										gclass12_0.method_67(1.0);
										gclass12_0.method_52(1, "ajax_password");
									}
									gclass12_0.method_67(1.0);
								}
								goto IL_057b;
							case 1:
								gclass12_0.method_54("document.querySelector('.SettingsEmailPendingCancel')");
								gclass12_0.method_67(1.0);
								if (gclass12_0.method_26(4, ".SettingsEmailPendingCancel") != 1)
								{
									gclass12_0.method_20("document.querySelector('.SettingsEmailPendingCancel').click()");
								}
								goto IL_05d5;
							}
						}
						result = 1;
						break;
						IL_057b:
						num7++;
						continue;
						IL_05d5:
						gclass12_0.method_67(1.0);
						goto IL_037d;
					}
					break;
				}
			}
		}
		catch
		{
		}
		gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(num, num2);
		return result;
	}

	private bool method_34(GClass12 gclass12_0)
	{
		bool result = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/settings/security_login/sessions/log_out_all/confirm/");
			gclass12_0.method_67(1.0);
			string text = "";
			for (int i = 0; i < 10; i++)
			{
				text = gclass12_0.method_20("return document.documentElement.innerHTML.match(new RegExp('/security/settings/sessions/log_out_all/(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
				if (!(text != ""))
				{
					gclass12_0.method_67(1.0);
					continue;
				}
				gclass12_0.method_13("https://m.facebook.com" + text);
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public string method_35(GClass12 gclass12_0, string string_8)
	{
		string text = "";
		string text2 = "";
		try
		{
			string text3 = "https://m.facebook.com/nt/screen/?params={\"module\":\"two_factor\",\"initial_screen_id\":\"[\\\"security_checkup_start_screen\\\",null]\",\"walkthrough_modules\":[\"password_change\",\"two_factor\",\"login_alerts\"],\"source\":\"unknown\",\"entry_point\":\"topic_selection\"}&path=security-checkup/modules/&state";
			int num = 0;
			while (true)
			{
				gclass12_0.method_13(text3);
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("[type=\"submit\"]", 15.0) == 1)
				{
					if (gclass12_0.method_26(4, "[type=\"submit\"]") != 1)
					{
						gclass12_0.method_20("document.querySelector('[type=\"submit\"]').click()");
					}
					gclass12_0.method_67(1.0);
				}
				switch (gclass12_0.method_49(20.0, "a[data-sigil=\"touchable\"]", "[name=\"pass\"]", "[data-testid=\"tfs_header_button\"]"))
				{
				default:
				{
					string text4 = gclass12_0.method_20("return document.documentElement.innerHTML.match(new RegExp('https://m.facebook.com/security/2fac/setup/qrcode/generate(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
					if (text4 == "")
					{
						text4 = gclass12_0.method_20("return document.documentElement.innerHTML.match(new RegExp('https://mobile.facebook.com/security/2fac/setup/qrcode/generate(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
					}
					if (!(text4 != ""))
					{
						break;
					}
					gclass12_0.method_13(text4);
					gclass12_0.method_67(1.0);
					int num2 = gclass12_0.method_49(20.0, "[name=\"pass\"]", "[data-testid=\"key\"]", "#checkpointSubmitButton", "#captcha_response", "#checkpointBottomBar");
					if (num2 != 1 && num2 != 2)
					{
						break;
					}
					if (num2 == 1)
					{
						gclass12_0.method_67(1.0);
						gclass12_0.method_29(4, "[name=\"pass\"]", string_8);
						gclass12_0.method_67(1.0);
						gclass12_0.method_26(4, "[name=\"save\"]");
					}
					if (gclass12_0.method_46("[data-testid=\"key\"]", 20.0) != 1)
					{
						break;
					}
					text2 = gclass12_0.method_20("return document.querySelector('[data-testid=\"key\"]').innerText").ToString().Replace(" ", "");
					gclass12_0.method_26(4, "[name=\"confirmButton\"]");
					if (gclass12_0.method_46("[name=\"code\"]", 20.0) != 1)
					{
						break;
					}
					gclass12_0.method_67(1.0);
					string text5 = GClass14.smethod_83(text2, gclass17_1.method_2("type2Fa"));
					if (text5 == "")
					{
						num++;
						if (num == 1)
						{
							continue;
						}
					}
					if (text5 != "")
					{
						gclass12_0.method_29(4, "[name=\"code\"]", text5);
						gclass12_0.method_67(1.0);
						gclass12_0.method_26(1, "submit_code_button");
						gclass12_0.method_67(2.0);
					}
					else
					{
						text = "0|Không ta\u0323o đươ\u0323c ma\u0303 6 sô\u0301!";
					}
					break;
				}
				case 0:
					break;
				case 3:
					text = "0|Đa\u0303 ta\u0323o 2fa trươ\u0301c đo\u0301!";
					break;
				case 2:
					gclass12_0.method_67(1.0);
					gclass12_0.method_29(4, "[name=\"pass\"]", string_8);
					gclass12_0.method_67(1.0);
					gclass12_0.method_26(4, "[name=\"save\"]");
					if (gclass12_0.method_46("[data-testid=\"tfs_header_button\"]", 10.0) == 1)
					{
						text = "0|Đa\u0303 ta\u0323o 2fa trươ\u0301c đo\u0301!";
					}
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (text == "")
		{
			text = "1|" + text2;
		}
		return text;
	}

	public bool method_36(GClass12 gclass12_0, string string_8)
	{
		bool result = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/security/2fac/setup/turn_off/");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("[data-testid=\"tfa_setup_dialog_primary_button\"]", 20.0) == 1)
			{
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[data-testid=\"tfa_setup_dialog_primary_button\"]");
				gclass12_0.method_67(2.0);
				switch (gclass12_0.method_49(10.0, "[name=\"pass\"]", "a[data-sigil=\"touchable\"]", "#checkpointSubmitButton", "#captcha_response", "#checkpointBottomBar"))
				{
				case 1:
					gclass12_0.method_67(1.0);
					gclass12_0.method_33(Class49.random_0, 4, "[name=\"pass\"]", string_8, 0.1);
					gclass12_0.method_38();
					gclass12_0.method_26(4, "[name=\"save\"]");
					if (gclass12_0.method_46("a[data-sigil=\"touchable\"]", 10.0) == 1)
					{
						result = true;
						return result;
					}
					return result;
				case 2:
					result = true;
					return result;
				default:
					return result;
				case 3:
				case 4:
				case 5:
					return result;
				}
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public int method_37(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_14("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=living");
			gclass12_0.method_67(2.0);
			if (gclass12_0.method_46("[data-sigil=\"edit-hometown-text textinput\"]", 10.0) == 1)
			{
				gclass12_0.method_44(4, "[data-sigil=\"edit-hometown-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_33(Class49.random_0, 4, "[data-sigil=\"edit-hometown-text textinput\"]", string_8, 0.1);
				gclass12_0.method_38();
				gclass12_0.method_10(4, "[data-sigil=\"edit-hometown-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_52(4, "[data-sigil=\"edit-hometown-text textinput\"]");
				gclass12_0.method_38(1);
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(2.0);
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_38(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=living");
			gclass12_0.method_67(2.0);
			if (gclass12_0.method_46("[data-sigil=\"edit-current_city-text textinput\"]", 10.0) == 1)
			{
				gclass12_0.method_44(4, "[data-sigil=\"edit-current_city-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_33(Class49.random_0, 4, "[data-sigil=\"edit-current_city-text textinput\"]", string_8, 0.1);
				gclass12_0.method_67(1.0);
				gclass12_0.method_10(4, "[data-sigil=\"edit-current_city-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_52(4, "[data-sigil=\"edit-current_city-text textinput\"]");
				gclass12_0.method_38(1);
				gclass12_0.method_26(4, "[name=\"save\"]");
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_39(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_14("https://m.facebook.com/me/about");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("#timelineBody", 10.0) == 1)
			{
				Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('.darkTouch.l').length").ToString());
			}
			int num = gclass12_0.method_14("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=work&experience_type=2002");
			if (num == -2)
			{
				return -2;
			}
			gclass12_0.method_67(3.0);
			if (gclass12_0.method_46("[data-sigil=\"edit-employer-text textinput\"]", 10.0) == 1)
			{
				gclass12_0.method_33(Class49.random_0, 4, "[data-sigil=\"edit-employer-text textinput\"]", string_8, 0.1);
				gclass12_0.method_38();
				gclass12_0.method_10(4, "[data-sigil=\"edit-employer-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_52(4, "[data-sigil=\"edit-employer-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[data-sigil=\"junk-text\"]");
				gclass12_0.method_67(0.5);
				gclass12_0.method_26(4, "[data-sigil=\"edit-current touchable\"]");
				gclass12_0.method_38();
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(2.0);
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_40(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/me/about");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("#timelineBody", 10.0) == 1)
			{
				Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('.darkTouch.l').length").ToString());
			}
			int num = gclass12_0.method_14("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=education&experience_type=2003");
			if (num == -2)
			{
				return -2;
			}
			gclass12_0.method_67(3.0);
			if (gclass12_0.method_46("[data-sigil=\"edit-hs_school-text textinput\"]", 10.0) == 1)
			{
				gclass12_0.method_33(Class49.random_0, 4, "[data-sigil=\"edit-hs_school-text textinput\"]", string_8, 0.1);
				gclass12_0.method_38();
				gclass12_0.method_10(4, "[data-sigil=\"edit-hs_school-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_52(4, "[data-sigil=\"edit-hs_school-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[name=\"graduated\"]");
				gclass12_0.method_38();
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(2.0);
				gclass12_0.method_13("https://m.facebook.com/me/about");
				gclass12_0.method_67(2.0);
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_41(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_14("https://m.facebook.com/me/about");
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("#timelineBody", 10.0) == 1)
			{
				Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('.darkTouch.l').length").ToString());
			}
			int num = gclass12_0.method_14("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=education&experience_type=2004");
			if (num == -2)
			{
				return -2;
			}
			gclass12_0.method_67(3.0);
			if (gclass12_0.method_46("[data-sigil=\"edit-college_school-text textinput\"]", 10.0) == 1)
			{
				gclass12_0.method_33(Class49.random_0, 4, "[data-sigil=\"edit-college_school-text textinput\"]", string_8, 0.1);
				gclass12_0.method_38();
				gclass12_0.method_10(4, "[data-sigil=\"edit-college_school-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_52(4, "[data-sigil=\"edit-college_school-text textinput\"]");
				gclass12_0.method_67(1.0);
				gclass12_0.method_26(4, "[name=\"graduated\"]");
				gclass12_0.method_38();
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(2.0);
				flag = true;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_42(GClass12 gclass12_0, string string_8, string string_9)
	{
		int result = 0;
		int num = gclass12_0.ChromeDriver_0.Manage().Window.Size.Width;
		int num2 = gclass12_0.ChromeDriver_0.Manage().Window.Size.Height;
		gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(500, 700);
		try
		{
			string text = "https://m.facebook.com/nt/screen/?params={\"module\":\"password_change\",\"initial_screen_id\":\"[\\\"security_checkup_start_screen\\\",null]\",\"walkthrough_modules\":[\"password_change\",\"two_factor\",\"login_alerts\"],\"source\":\"unknown\",\"entry_point\":\"topic_selection\"}&path=security-checkup/modules/&state";
			gclass12_0.method_13(text);
			gclass12_0.method_67(1.0);
			if (gclass12_0.method_46("[type=\"submit\"]", 15.0) == 1)
			{
				gclass12_0.method_54("document.querySelector('[type=\"submit\"]')");
				gclass12_0.method_26(4, "[type=\"submit\"]");
				gclass12_0.method_67(1.0);
				if (gclass12_0.method_46("[name=\"password_old\"]", 10.0) == 1)
				{
					gclass12_0.method_31(4, "[name=\"password_old\"]", string_8, 0.1);
					gclass12_0.method_67(1.0);
					gclass12_0.method_31(4, "[name=\"password_new\"]", string_9, 0.1);
					gclass12_0.method_67(1.0);
					gclass12_0.method_31(4, "[name=\"password_confirm\"]", string_9, 0.1);
					gclass12_0.method_67(1.0);
					gclass12_0.method_54("document.querySelector('[type=\"submit\"]')");
					if (gclass12_0.method_26(4, "[type=\"submit\"]") != 1)
					{
						gclass12_0.method_20("document.querySelector('[type=\"submit\"]').click()");
					}
					gclass12_0.method_67(5.0);
					int tickCount = Environment.TickCount;
					while (Environment.TickCount - tickCount <= 20000)
					{
						if (gclass12_0.method_46("[name=\"password_new\"]") == 1)
						{
							continue;
						}
						for (int i = 0; i < 3; i++)
						{
							if (gclass12_0.method_46("[data-nt=\"FB:FDS_TETRA_BUTTON\"]", 5.0) == 1)
							{
								gclass12_0.method_26(4, "[data-nt=\"FB:FDS_TETRA_BUTTON\"]");
								gclass12_0.method_67(1.0);
							}
						}
						if (gclass12_0.method_46("[style=\"flex-grow:0;flex-shrink:1;width:100%\"]", 10.0) == 1)
						{
							gclass12_0.method_26(4, "[style=\"flex-grow:0;flex-shrink:1;width:100%\"]");
						}
						result = 1;
						break;
					}
				}
			}
		}
		catch
		{
		}
		gclass12_0.ChromeDriver_0.Manage().Window.Size = new Size(num, num2);
		return result;
	}

	public int method_43(GClass12 gclass12_0, string string_8)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/language.php");
			int tickCount = Environment.TickCount;
			string text = "";
			while (Environment.TickCount - tickCount < 10000)
			{
				text = gclass12_0.method_20("var x='';if(document.documentElement.innerHTML.includes('/a/language.php?l=" + string_8 + "')) x=('https://m.facebook.com'+document.documentElement.innerHTML.match(new RegExp('/a/language.php\\\\?l=" + string_8 + "(.*?)\"'))[0]).replace('\"','').split('amp;').join(''); else x=''; return x;").ToString();
				if (!(text != ""))
				{
					if (gclass12_0.method_46("[value=\"" + string_8 + "\"]") == 1 && gclass12_0.method_26(4, "[value=\"" + string_8 + "\"]") == 1)
					{
						gclass12_0.method_46("[href=\"/language.php\"]", 5.0);
						flag = true;
						break;
					}
					continue;
				}
				gclass12_0.method_13(text);
				flag = true;
				break;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_44(GClass12 gclass12_0, string string_8, Random random_1)
	{
		bool flag = false;
		try
		{
			while (true)
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < string_8.Length; i++)
				{
					text2 = string_8[i].ToString();
					if (text2 == "x")
					{
						text2 = random_1.Next(0, 10).ToString();
					}
					text += text2;
				}
				if (text.StartsWith("0"))
				{
					text = "+84" + text.Substring(1);
				}
				gclass12_0.method_13("https://m.facebook.com/phoneacquire/?source=contactpoint_settings&entry_point=settings");
				if (gclass12_0.method_46("[name=\"contact_point\"]", 10.0) == 1)
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_33(Class49.random_0, 4, "[name=\"contact_point\"]", text, 0.1);
					gclass12_0.method_38();
					gclass12_0.method_26(4, ".buttonArea>button");
					gclass12_0.method_67(2.0);
					switch (gclass12_0.method_49(10.0, "#root > div > div > div > div:nth-child(1) > div > div", "[name=\"pin\"]"))
					{
					case 1:
						break;
					default:
						goto end_IL_012f;
					case 2:
						flag = true;
						goto end_IL_012f;
					}
					continue;
				}
				break;
				continue;
				end_IL_012f:
				break;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_45(GClass12 gclass12_0, string string_8, Random random_1)
	{
		bool flag = false;
		try
		{
			while (true)
			{
				IL_0130:
				gclass12_0.method_13("https://m.facebook.com/me");
				gclass12_0.method_67(1.0);
				int num = gclass12_0.method_49(20.0, "#m-timeline-cover-section>div>div>div:nth-child(2)>a", "#m-timeline-cover-section>div>div>div:nth-child(2)>div>a");
				switch (num)
				{
				default:
				{
					switch (num)
					{
					case 2:
						gclass12_0.method_20("document.querySelector('#m-timeline-cover-section>div>div>div:nth-child(2)>div>a').click()");
						gclass12_0.method_67(3.0);
						break;
					case 1:
						gclass12_0.method_20("document.querySelector('#m-timeline-cover-section>div>div>div:nth-child(2)>a').click()");
						gclass12_0.method_67(3.0);
						break;
					}
					if (gclass12_0.method_46("#nuxPicFileInput", 20.0) != 1)
					{
						break;
					}
					gclass12_0.method_67(3.0);
					gclass12_0.method_29(1, "nuxPicFileInput", string_8, bool_7: false);
					gclass12_0.method_67(2.0);
					int num2 = 0;
					for (int i = 0; i < 30; i++)
					{
						if (!Convert.ToBoolean(gclass12_0.method_20("return document.querySelector('#nuxPicFileInput_preview').getAttribute('style').includes('background-image')+''")))
						{
							if (gclass12_0.method_20("return document.querySelector('#nuxPicFileInput').value+''").ToString() == "")
							{
								gclass12_0.method_29(1, "nuxPicFileInput", string_8, bool_7: false);
								gclass12_0.method_67(2.0);
								continue;
							}
							num2++;
							if (num2 == 3)
							{
								goto IL_0130;
							}
							continue;
						}
						gclass12_0.method_67(1.0);
						switch (gclass12_0.method_49(10.0, "#nuxUploadPhotoButton>button", "#nuxUploadPhotoButton>div>button"))
						{
						default:
							GClass14.smethod_75(gclass12_0, null, "Ko up duoc avatar");
							break;
						case 2:
							gclass12_0.method_26(4, "#nuxUploadPhotoButton>div>button");
							break;
						case 1:
							gclass12_0.method_26(4, "#nuxUploadPhotoButton>button");
							break;
						}
						if (gclass12_0.method_48("#nuxUploadPhotoButton>div>button", 1, 20.0) == 1)
						{
							gclass12_0.method_67(1.0);
							flag = true;
						}
						break;
					}
					break;
				}
				case -2:
					return -2;
				case 0:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_46(GClass12 gclass12_0, string string_8, Random random_1)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_14("https://m.facebook.com/me");
			gclass12_0.method_67(2.0);
			IWebElement webElement = (IWebElement)gclass12_0.ChromeDriver_0.ExecuteScript("return document.querySelector('[data-sigil=\"cover-photo\"]').parentNode.querySelector('[data-sigil=\"dialog-link\"]')");
			if (webElement != null)
			{
				webElement.Click();
				gclass12_0.method_67(1.0);
				int num = gclass12_0.method_49(20.0, "#modalDialogView > div > div:nth-child(1) > div > div > a", "#nuxPicFileInput");
				if (num == 1)
				{
					gclass12_0.method_26(4, "#modalDialogView > div > div:nth-child(1) > div > div > a");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_46("#nuxPicFileInput", 10.0) == 1)
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_29(1, "nuxPicFileInput", string_8);
					gclass12_0.method_67(5.0);
					if (gclass12_0.method_26(4, "#nuxUploadPhotoButton button") != 1)
					{
						gclass12_0.method_20("document.querySelector('#nuxUploadPhotoButton button').click()");
					}
					if (gclass12_0.method_48("#nuxUploadPhotoButton button", 1, 20.0) == 1)
					{
						gclass12_0.method_67(1.0);
						flag = true;
					}
				}
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_47(GClass12 gclass12_0, Random random_1)
	{
		bool flag = false;
		try
		{
			gclass12_0.method_14("https://mbasic.facebook.com/photos/change/cover_photo/?photo_type=artwork_photos");
			if (gclass12_0.method_46("#root > table > tbody > tr > td > div > div > div > span > a", 10.0) == 1)
			{
				int num = Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('#root > table > tbody > tr > td > div > div > div > span > a').length+''").ToString());
				if (num > 0)
				{
					gclass12_0.method_20("document.querySelectorAll('#root > table > tbody > tr > td > div > div > div > span > a')[" + random_1.Next(0, num) + "].click()");
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("#root > table > tbody > tr > td > div > div > div > div > form > div > input", 10.0) == 1)
					{
						gclass12_0.method_26(4, "#root > table > tbody > tr > td > div > div > div > div > form > div > input");
					}
					gclass12_0.method_67(2.0);
					flag = true;
				}
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_48(GClass12 gclass12_0, string string_8, bool bool_3 = true)
	{
		bool flag = false;
		try
		{
			try
			{
				gclass12_0.method_14("https://m.facebook.com/profile/intro/edit/public/?refid=17");
				if (gclass12_0.method_46("#root>div>div>div>div>div>div:nth-child(5)>div> div:nth-child(2)", 10.0) == 1)
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_26(4, "#root>div>div>div>div>div>div:nth-child(5)>div> div:nth-child(2)");
					if (gclass12_0.method_46("[name=\"bio\"]", 10.0) == 1)
					{
						string_8 = string_8.Replace("\r\n", "\\r\\n");
						gclass12_0.method_20("document.querySelector('[name=\"bio\"]').value=\"" + string_8 + "\"");
						if (bool_3)
						{
							gclass12_0.method_26(4, "[name=\"publish_to_feed\"]");
							gclass12_0.method_67(1.0);
						}
						if (gclass12_0.method_26(4, "[data-sigil=\"touchable profile-intro-card-confirm-button\"]") != 1)
						{
							gclass12_0.method_20("document.querySelector('[data-sigil=\"touchable profile-intro-card-confirm-button\"]').click()");
						}
						gclass12_0.method_67(2.0);
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int method_49(GClass12 gclass12_0, string string_8, string string_9)
	{
		int result = 0;
		try
		{
			gclass12_0.method_13("https://m.facebook.com/settings/account/?name");
			switch (gclass12_0.method_49(20.0, "[href=\"/help/112146705538576\"]", "[href=\"/help/448505685205813\"]"))
			{
			case 1:
			{
				string[] array = string_8.Split(' ');
				int num = array.Length;
				string string_10 = array[0];
				string text = "";
				string string_11 = array[num - 1];
				if (num > 2)
				{
					for (int i = 1; i < num - 1; i++)
					{
						text = text + array[i] + " ";
					}
				}
				text = text.Trim();
				if (gclass12_0.method_46("[name=\"primary_last_name\"]", 10.0) != 1)
				{
					break;
				}
				gclass12_0.method_67(1.0);
				string text2 = gclass12_0.method_20("return document.querySelector('[name=\"primary_last_name\"]').value").ToString();
				gclass12_0.method_44(4, "[name=\"primary_last_name\"]");
				gclass12_0.method_33(Class49.random_0, 4, "[name=\"primary_last_name\"]", string_10, 0.1);
				gclass12_0.method_67(1.0);
				gclass12_0.method_44(4, "[name=\"primary_middle_name\"]");
				if (text != "")
				{
					gclass12_0.method_33(Class49.random_0, 4, "[name=\"primary_middle_name\"]", text, 0.1);
				}
				gclass12_0.method_67(1.0);
				gclass12_0.method_44(4, "[name=\"primary_first_name\"]");
				gclass12_0.method_33(Class49.random_0, 4, "[name=\"primary_first_name\"]", string_11, 0.1);
				gclass12_0.method_67(2.0);
				gclass12_0.method_26(4, "[name=\"save\"]");
				gclass12_0.method_67(5.0);
				if (gclass12_0.method_20("return document.querySelector('[name=\"primary_last_name\"]').value").ToString() == text2)
				{
					return 2;
				}
				int num2 = Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('#m-settings-form > div:nth-child(4)>fieldset>label').length").ToString());
				for (int j = 0; j < num2; j++)
				{
					string text3 = gclass12_0.method_20("return document.querySelector('#m-settings-form > div:nth-child(4)>fieldset>label:nth-child(" + (j + 1) + ")>div>div>span').innerText").ToString();
					if (string_8 == text3)
					{
						gclass12_0.method_26(4, "#m-settings-form > div:nth-child(4)>fieldset>label:nth-child(" + (j + 1) + ")>div>div:nth-child(2)>input");
						break;
					}
				}
				if (gclass12_0.method_46("[name=\"save_password\"]", 10.0) == 1)
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_33(Class49.random_0, 4, "[name=\"save_password\"]", string_9, 0.1);
					gclass12_0.method_26(4, "[name=\"save\"]");
					gclass12_0.method_67(2.0);
				}
				result = 1;
				break;
			}
			case 2:
				return 0;
			}
		}
		catch
		{
		}
		return result;
	}

	private void btnPause_Click(object sender, EventArgs e)
	{
		try
		{
			bool_0 = true;
			btnPause.Enabled = false;
			btnPause.Text = GClass29.smethod_0("Đang dư\u0300ng...");
		}
		catch
		{
		}
	}

	private void panel3_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		try
		{
			GClass14.smethod_32("configschange\\fail");
			Process.Start("configschange\\fail");
		}
		catch
		{
		}
	}

	public static byte[] smethod_10(Bitmap bitmap_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		bitmap_0.Save(memoryStream, ImageFormat.Png);
		return memoryStream.ToArray();
	}

	private void method_50(int int_1, int int_2)
	{
		string text = "";
		string text2 = "";
		try
		{
			text = text + Class309.smethod_3(dtgvAcc, int_1, "cUid") + "|" + Class309.smethod_3(dtgvAcc, int_1, "cPassword") + "|" + Class309.smethod_3(dtgvAcc, int_1, "cFa2") + "|" + Class309.smethod_3(dtgvAcc, int_1, "cCookies") + "\r\n";
			switch (int_2)
			{
			case 1:
				text2 = "DoiPassThatBai.txt";
				break;
			case 2:
				text2 = "ThemMailThatBai.txt";
				break;
			case 3:
				text2 = "SaiPass.txt";
				break;
			case 4:
				text2 = "Checkpoint.txt";
				break;
			case 5:
				text2 = "Loi.txt";
				break;
			}
			lock (object_4)
			{
				File.AppendAllText("configschange\\fail\\" + text2, text);
			}
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
			method_4();
		}
		catch
		{
		}
	}

	public static string smethod_11(string string_8, int int_1 = 60)
	{
		string text = "";
		int num = 1;
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 10; i++)
		{
			try
			{
				text2 = gClass.method_0("http://codetextnow.com/api.php?apikey=" + string_8 + "&action=create-request&serviceId=" + num + "&count=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["results"]!["data"]![0]!["requestId"]!.ToString();
				if (text3 != "")
				{
					text = jObject["results"]!["data"]![0]!["sdt"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_12(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://codetextnow.com/api.php?apikey=" + string_8 + "&action=data-request&requestId=" + string_9);
				JObject jObject = JObject.Parse(json);
				if (jObject["status"]!.ToString() == "200")
				{
					try
					{
						text = jObject["data"]![0]!["otp"]!.ToString();
						if (text != "")
						{
							return text;
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_13(string string_8, int int_1 = 7, int int_2 = 60)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_2 * 1000)
		{
			text2 = gClass.method_0("http://otpsim.com/api/phones/request?token=" + string_8 + "&service=" + int_1);
			try
			{
				JObject jObject = JObject.Parse(text2);
				if (Convert.ToBoolean(jObject["success"]!.ToString()))
				{
					text = JObject.Parse(text2)["data"]!["phone_number"]!.ToString();
					text3 = JObject.Parse(text2)["data"]!["session"]!.ToString();
					if (!(text != "") || !(text3 != ""))
					{
						Thread.Sleep(5000);
						continue;
					}
					break;
				}
				Thread.Sleep(5000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text3 + "|" + text;
	}

	public static string smethod_14(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otpsim.com/api/sessions/" + string_9 + "?token=" + string_8);
				JObject jObject = JObject.Parse(json);
				if (Convert.ToBoolean(jObject["success"]!.ToString()))
				{
					try
					{
						text = JObject.Parse(json)["data"]!["messages"]![0]!["otp"]!.ToString();
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_15(string string_8, int int_1 = 1001, int int_2 = 60)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 33; i++)
		{
			try
			{
				text2 = gClass.method_0("http://chothuesimcode.com/api?act=number&apik=" + string_8 + "&appId=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]!["Id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Result"]!["Number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_16(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://chothuesimcode.com/api?act=code&apik=" + string_8 + "&id=" + string_9);
				JObject jObject = JObject.Parse(json);
				if (jObject["ResponseCode"]!.ToString() == "0")
				{
					try
					{
						text = jObject["Result"]!["Code"]!.ToString();
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	private void loadCookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		bool_2 = true;
		List<string> list = Directory.GetFiles(Application.StartupPath + "\\configschange\\cookie").ToList();
		for (int i = 0; i < list.Count(); i++)
		{
			int num = dtgvAcc.Rows.Add();
			GClass14.smethod_21(dtgvAcc, num, "cChoseAcc", false);
			GClass14.smethod_21(dtgvAcc, num, "cStt", num + 1);
			GClass14.smethod_21(dtgvAcc, num, "cCookieName", Path.GetFileNameWithoutExtension(list[i]));
		}
		method_9(list);
		button7.Visible = true;
		button4.Visible = true;
	}

	private void button7_Click(object sender, EventArgs e)
	{
		if (Convert.ToInt32(lblChoosed.Text) == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n như\u0303ng ta\u0300i khoa\u0309n muô\u0301n nhâ\u0323p Proxy!"), 3);
		}
		else
		{
			GClass14.smethod_33(new fImportProxy());
		}
	}

	private void copyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(method_26(i, "cUid") + "|" + method_26(i, "cPassword") + "|" + method_26(i, "cToken") + "|" + method_26(i, "cCookies") + "|" + method_26(i, "cEmail") + "|" + method_26(i, "cPassMail") + "|" + method_26(i, "cFa2") + "|" + method_26(i, "cUseragent") + "|" + method_26(i, "cProxy").Split('*')[0] + "|" + method_26(i, "cName") + "|" + method_26(i, "cGender") + "|" + method_26(i, "cFollow") + "|" + method_26(i, "cFriend") + "|" + method_26(i, "cGroup") + "|" + method_26(i, "cBirthday") + "|" + method_26(i, "cDateCreateAcc") + "|" + method_26(i, "cGhiChu"));
				}
			}
			if (list.Count <= 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
			}
			else
			{
				GClass14.smethod_33(new fCopy(list));
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Error Copy");
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		if (Convert.ToInt32(lblChoosed.Text) == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n như\u0303ng ta\u0300i khoa\u0309n muô\u0301n nhâ\u0323p Useragent!"), 3);
		}
		else
		{
			GClass14.smethod_33(new fImportUseragent());
		}
	}

	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
		try
		{
			bool_2 = true;
			string[] array = File.ReadAllLines("account.txt");
			if (array.Length != 0)
			{
				try
				{
					foreach (string text in array)
					{
						string[] string_0 = text.Split('|');
						dtgvAcc.Invoke((Action)delegate
						{
							dtgvAcc.Rows.Add(string_0[0], string_0[1], string_0[2], string_0[3], string_0[4], string_0[5], string_0[6], string_0[7], string_0[8], string_0[9], string_0[10], string_0[11], string_0[12], string_0[13], string_0[14], string_0[15]);
						});
					}
				}
				catch
				{
				}
			}
			method_4();
			button7.Visible = true;
			button4.Visible = true;
		}
		catch
		{
		}
	}

	public static string smethod_17(string string_8, int int_1 = 7, int int_2 = 60)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 33; i++)
		{
			try
			{
				text2 = gClass.method_0("https://api.viotp.com/request/get?token=" + string_8 + "&serviceId=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["request_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_18(string string_8, int int_1 = 1, int int_2 = 60)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 33; i++)
		{
			try
			{
				text2 = gClass.method_0("http://otptextnow.com/api/?key=" + string_8 + "&action=get_number&id=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["request_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_19(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://api.viotp.com/session/get?requestId=" + string_9 + "&token=" + string_8);
				JObject jObject = JObject.Parse(json);
				if (jObject["status_code"]!.ToString() == "200")
				{
					try
					{
						text = jObject["data"]!["Code"]!.ToString();
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_20(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otptextnow.com/api/?key=" + string_8 + "&action=get_code&id=" + string_9);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["otp_code"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_21(string string_8, string string_9)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 33; i++)
		{
			try
			{
				text2 = gClass.method_1("https://tempcode.co/api/orders.php", "api_key=" + string_8 + "&act=buy_number&service_id=" + string_9);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["order_id"]!.ToString();
				if (text3 != "")
				{
					text = (jObject["data"]!["phonenumber"]!.ToString().Contains("+") ? jObject["data"]!["phonenumber"]!.ToString().Remove(0, 2) : jObject["data"]!["phonenumber"]!.ToString().Remove(0, 1));
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_22(string string_8, string string_9, int int_1 = 120)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_1("https://tempcode.co/api/orders.php", "api_key=" + string_8 + "&act=read_message&order_id=" + string_9);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"]!["otp"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_23(string string_8)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < 33; i++)
		{
			try
			{
				text2 = gClass.method_0("http://supersim247.com/api/phone/new-session?token=" + string_8 + "&service=4");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["session"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text3 + "|" + text;
	}

	public static string smethod_24(string string_8, string string_9, int int_1 = 90)
	{
		string text = "";
		GClass18 gClass = new GClass18();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_1 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://supersim247.com/api/session/" + string_9 + "/get-otp?token=" + string_8);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = jObject["data"]!["messages"]![0]!["otp"]!.ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChange));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.dieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.checkpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.mnsCutAccount = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.backupTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupCookieTrungGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenBussinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenInstagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenIosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenAndroidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel3 = new System.Windows.Forms.Panel();
		this.lblChoosed = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.lblCountAcc = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.ctmsAcc = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		this.ctmsChonTrangThai = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.loadCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		this.dtgvAcc = new System.Windows.Forms.DataGridView();
		this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.btnConfig = new System.Windows.Forms.Button();
		this.btnPause = new System.Windows.Forms.Button();
		this.btnStart = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.button7 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.ctmsAcc.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
		base.SuspendLayout();
		this.toolStripMenuItem_2.Name = "tấtCảToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(32, 19);
		this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
		this.liveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.dieToolStripMenuItem.Name = "dieToolStripMenuItem";
		this.dieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.checkpointToolStripMenuItem.Name = "checkpointToolStripMenuItem";
		this.checkpointToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
		this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_4.Name = "đăngNhậpProfileToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem1.Name = "cookieToolStripMenuItem1";
		this.cookieToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem1.Name = "uidPassToolStripMenuItem1";
		this.uidPassToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_5.Name = "đăngNhậpTrìnhDuyệtMớiToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem2.Name = "cookieToolStripMenuItem2";
		this.cookieToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem2.Name = "uidPassToolStripMenuItem2";
		this.uidPassToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		this.tokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		this.cookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		this.uidToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.passToolStripMenuItem.Name = "passToolStripMenuItem";
		this.passToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
		this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_0.Name = "danhSáchChọnToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_1.Name = "danhSáchKhôngChọnToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_3.Name = "giữNguyênỞThưMụcCũToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(32, 19);
		this.mnsCutAccount.Name = "mnsCutAccount";
		this.mnsCutAccount.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_8.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_8.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_6.Name = "kiểmTraCookieToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_7.Name = "kiểmTraTokenToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(32, 19);
		this.backupTokenToolStripMenuItem.Name = "backupTokenToolStripMenuItem";
		this.backupTokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.backupCookieToolStripMenuItem.Name = "backupCookieToolStripMenuItem";
		this.backupCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.backupCookieTrungGianToolStripMenuItem.Name = "backupCookieTrungGianToolStripMenuItem";
		this.backupCookieTrungGianToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_9.Name = "mậtKhẩuToolStripMenuItem1";
		this.toolStripMenuItem_9.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_10.Name = "nhậpDữLiệuToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new System.Drawing.Size(32, 19);
		this.tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
		this.tokenToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_11.Name = "tựĐộngLấyToolStripMenuItem1";
		this.toolStripMenuItem_11.Size = new System.Drawing.Size(32, 19);
		this.tokenBussinessToolStripMenuItem.Name = "tokenBussinessToolStripMenuItem";
		this.tokenBussinessToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.tokenInstagramToolStripMenuItem1.Name = "tokenInstagramToolStripMenuItem1";
		this.tokenInstagramToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.tokenIosToolStripMenuItem.Name = "tokenIosToolStripMenuItem";
		this.tokenIosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.tokenAndroidToolStripMenuItem1.Name = "tokenAndroidToolStripMenuItem1";
		this.tokenAndroidToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_12.Name = "nhậpDữLiệuToolStripMenuItem2";
		this.toolStripMenuItem_12.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
		this.cookieToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_13.Name = "tựĐộngLấyToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_14.Name = "nhậpDữLiệuToolStripMenuItem1";
		this.toolStripMenuItem_14.Size = new System.Drawing.Size(32, 19);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(986, 32);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Enabled = false;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		this.button2.Location = new System.Drawing.Point(890, -1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 15;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Enabled = false;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(922, -1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 14;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(954, -1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 13;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(7, 3);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 16;
		this.pictureBox1.TabStop = false;
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 9);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(258, 16);
		this.bunifuCustomLabel1.TabIndex = 7;
		this.bunifuCustomLabel1.Text = "MAX CARE - CHỨC NĂNG ĐỔI THÔNG TIN";
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = null;
		this.bunifuDragControl_1.Vertical = true;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(986, 38);
		this.bunifuCards1.TabIndex = 10;
		this.panel3.BackColor = System.Drawing.SystemColors.Control;
		this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panel3.Location = new System.Drawing.Point(0, 558);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(986, 26);
		this.panel3.TabIndex = 11;
		this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(panel3_Paint);
		this.lblChoosed.AutoSize = true;
		this.lblChoosed.BackColor = System.Drawing.Color.White;
		this.lblChoosed.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblChoosed.ForeColor = System.Drawing.Color.Maroon;
		this.lblChoosed.Location = new System.Drawing.Point(830, 514);
		this.lblChoosed.Name = "lblChoosed";
		this.lblChoosed.Size = new System.Drawing.Size(15, 16);
		this.lblChoosed.TabIndex = 120;
		this.lblChoosed.Text = "0";
		this.bunifuCustomLabel2.AutoSize = true;
		this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
		this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.bunifuCustomLabel2.Location = new System.Drawing.Point(766, 514);
		this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		this.bunifuCustomLabel2.Size = new System.Drawing.Size(69, 16);
		this.bunifuCustomLabel2.TabIndex = 121;
		this.bunifuCustomLabel2.Text = "Đã chọn: ";
		this.lblCountAcc.AutoSize = true;
		this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		this.lblCountAcc.Location = new System.Drawing.Point(929, 514);
		this.lblCountAcc.Name = "lblCountAcc";
		this.lblCountAcc.Size = new System.Drawing.Size(15, 16);
		this.lblCountAcc.TabIndex = 76;
		this.lblCountAcc.Text = "0";
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(887, 514);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(43, 16);
		this.label7.TabIndex = 77;
		this.label7.Text = "Tổng:";
		this.ctmsAcc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.toolStripMenuItem_15, this.toolStripMenuItem_16, this.ctmsChonTrangThai, this.toolStripMenuItem_17, this.copyToolStripMenuItem, this.loadCookieToolStripMenuItem, this.toolStripMenuItem_18 });
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(160, 158);
		this.ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		this.toolStripMenuItem_15.Name = "chọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new System.Drawing.Size(159, 22);
		this.toolStripMenuItem_15.Text = "Chọn tất cả";
		this.toolStripMenuItem_15.Click += new System.EventHandler(toolStripMenuItem_15_Click);
		this.toolStripMenuItem_16.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_16.Size = new System.Drawing.Size(159, 22);
		this.toolStripMenuItem_16.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_16.Click += new System.EventHandler(toolStripMenuItem_16_Click);
		this.ctmsChonTrangThai.Name = "ctmsChonTrangThai";
		this.ctmsChonTrangThai.Size = new System.Drawing.Size(159, 22);
		this.ctmsChonTrangThai.Text = "Chọn tra\u0323ng tha\u0301i";
		this.ctmsChonTrangThai.Click += new System.EventHandler(ctmsChonTrangThai_Click);
		this.toolStripMenuItem_17.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_17.Size = new System.Drawing.Size(159, 22);
		this.toolStripMenuItem_17.Text = "Xóa đã chọn";
		this.toolStripMenuItem_17.Click += new System.EventHandler(toolStripMenuItem_17_Click);
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
		this.copyToolStripMenuItem.Text = "Copy";
		this.copyToolStripMenuItem.Click += new System.EventHandler(copyToolStripMenuItem_Click);
		this.loadCookieToolStripMenuItem.Name = "loadCookieToolStripMenuItem";
		this.loadCookieToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
		this.loadCookieToolStripMenuItem.Text = "Load Cookie";
		this.loadCookieToolStripMenuItem.Visible = false;
		this.loadCookieToolStripMenuItem.Click += new System.EventHandler(loadCookieToolStripMenuItem_Click);
		this.toolStripMenuItem_18.Name = "loadTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_18.Size = new System.Drawing.Size(159, 22);
		this.toolStripMenuItem_18.Text = "Load tài khoản";
		this.toolStripMenuItem_18.Visible = false;
		this.toolStripMenuItem_18.Click += new System.EventHandler(toolStripMenuItem_18_Click);
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
		this.dtgvAcc.Columns.AddRange(this.cChose, this.cStt, this.cId, this.cUid, this.cCookies, this.cToken, this.cName, this.cBirthday, this.cGender, this.cPassword, this.cFa2, this.cEmail, this.cPassMail, this.cUseragent, this.cProxy, this.cInfo, this.cStatus);
		this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvAcc.Location = new System.Drawing.Point(12, 41);
		this.dtgvAcc.Name = "dtgvAcc";
		this.dtgvAcc.ReadOnly = true;
		this.dtgvAcc.RowHeadersVisible = false;
		this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvAcc.Size = new System.Drawing.Size(962, 465);
		this.dtgvAcc.TabIndex = 125;
		this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		this.dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		this.dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvAcc_KeyDown);
		this.cChose.HeaderText = "Chọn";
		this.cChose.Name = "cChose";
		this.cChose.ReadOnly = true;
		this.cChose.Width = 40;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Width = 50;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.cUid.HeaderText = "UID";
		this.cUid.Name = "cUid";
		this.cUid.ReadOnly = true;
		this.cUid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cUid.Width = 70;
		this.cCookies.HeaderText = "Cookie";
		this.cCookies.Name = "cCookies";
		this.cCookies.ReadOnly = true;
		this.cCookies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cCookies.Width = 60;
		this.cToken.HeaderText = "Token";
		this.cToken.Name = "cToken";
		this.cToken.ReadOnly = true;
		this.cName.HeaderText = "Name";
		this.cName.Name = "cName";
		this.cName.ReadOnly = true;
		this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cName.Width = 75;
		this.cBirthday.HeaderText = "Birthday";
		this.cBirthday.Name = "cBirthday";
		this.cBirthday.ReadOnly = true;
		this.cBirthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cBirthday.Width = 70;
		this.cGender.HeaderText = "Giới Tính";
		this.cGender.Name = "cGender";
		this.cGender.ReadOnly = true;
		this.cGender.Width = 80;
		this.cPassword.HeaderText = "Mật khẩu";
		this.cPassword.Name = "cPassword";
		this.cPassword.ReadOnly = true;
		this.cPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cPassword.Width = 70;
		this.cFa2.HeaderText = "2FA";
		this.cFa2.Name = "cFa2";
		this.cFa2.ReadOnly = true;
		this.cFa2.Width = 40;
		this.cEmail.HeaderText = "Email";
		this.cEmail.Name = "cEmail";
		this.cEmail.ReadOnly = true;
		this.cPassMail.HeaderText = "Pass mail";
		this.cPassMail.Name = "cPassMail";
		this.cPassMail.ReadOnly = true;
		this.cUseragent.HeaderText = "Useragent";
		this.cUseragent.Name = "cUseragent";
		this.cUseragent.ReadOnly = true;
		this.cUseragent.Width = 70;
		this.cProxy.HeaderText = "Proxy";
		this.cProxy.Name = "cProxy";
		this.cProxy.ReadOnly = true;
		this.cProxy.Width = 50;
		this.cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.cInfo.HeaderText = "Tình Trạng";
		this.cInfo.Name = "cInfo";
		this.cInfo.ReadOnly = true;
		this.cInfo.Width = 90;
		this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cStatus.HeaderText = "Trạng Thái";
		this.cStatus.MinimumWidth = 200;
		this.cStatus.Name = "cStatus";
		this.cStatus.ReadOnly = true;
		this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnConfig.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnConfig.Image = (System.Drawing.Image)resources.GetObject("btnConfig.Image");
		this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnConfig.Location = new System.Drawing.Point(235, 514);
		this.btnConfig.Name = "btnConfig";
		this.btnConfig.Size = new System.Drawing.Size(109, 40);
		this.btnConfig.TabIndex = 71;
		this.btnConfig.Text = "Cấu hình";
		this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnConfig.UseVisualStyleBackColor = false;
		this.btnConfig.Click += new System.EventHandler(btnConfig_Click);
		this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnPause.Enabled = false;
		this.btnPause.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnPause.Image = (System.Drawing.Image)resources.GetObject("btnPause.Image");
		this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnPause.Location = new System.Drawing.Point(120, 514);
		this.btnPause.Name = "btnPause";
		this.btnPause.Size = new System.Drawing.Size(109, 40);
		this.btnPause.TabIndex = 70;
		this.btnPause.Text = "Tạm dừng";
		this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnPause.UseVisualStyleBackColor = false;
		this.btnPause.Click += new System.EventHandler(btnPause_Click);
		this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnStart.Image = (System.Drawing.Image)resources.GetObject("btnStart.Image");
		this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnStart.Location = new System.Drawing.Point(5, 514);
		this.btnStart.Name = "btnStart";
		this.btnStart.Size = new System.Drawing.Size(109, 40);
		this.btnStart.TabIndex = 69;
		this.btnStart.Text = "Bắt đầu";
		this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnStart.UseVisualStyleBackColor = false;
		this.btnStart.Click += new System.EventHandler(btnStart_Click);
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button3.Image = Class306.Bitmap_159;
		this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button3.Location = new System.Drawing.Point(350, 514);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(126, 40);
		this.button3.TabIndex = 71;
		this.button3.Text = "Ta\u0300i khoa\u0309n Lô\u0303i";
		this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button7.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button7.Image = (System.Drawing.Image)resources.GetObject("button7.Image");
		this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button7.Location = new System.Drawing.Point(482, 514);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(110, 40);
		this.button7.TabIndex = 126;
		this.button7.Text = "Nhập Proxy";
		this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button7.UseVisualStyleBackColor = false;
		this.button7.Visible = false;
		this.button7.Click += new System.EventHandler(button7_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button4.Image = Class306.Bitmap_195;
		this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button4.Location = new System.Drawing.Point(598, 514);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(126, 40);
		this.button4.TabIndex = 126;
		this.button4.Text = "Nhập Useragent";
		this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Visible = false;
		this.button4.Click += new System.EventHandler(button4_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(986, 584);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button7);
		base.Controls.Add(this.lblChoosed);
		base.Controls.Add(this.dtgvAcc);
		base.Controls.Add(this.bunifuCustomLabel2);
		base.Controls.Add(this.lblCountAcc);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.btnConfig);
		base.Controls.Add(this.btnPause);
		base.Controls.Add(this.btnStart);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChange";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE - CHỨC NĂNG POST";
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.ctmsAcc.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_51()
	{
		btnPause.Enabled = true;
		btnStart.Enabled = false;
	}

	[CompilerGenerated]
	private void method_52()
	{
		btnPause.Text = GClass29.smethod_0("Ta\u0323m dư\u0300ng");
		btnPause.Enabled = false;
		btnStart.Enabled = true;
	}
}
