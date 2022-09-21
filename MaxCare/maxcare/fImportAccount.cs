using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportAccount : Form
{
	[CompilerGenerated]
	private sealed class Class209
	{
		public bool bool_0;

		public int int_0;

		public string[] string_0;

		public List<string> list_0;

		public string string_1;

		public fImportAccount fImportAccount_0;

		internal void method_0()
		{
			try
			{
				fImportAccount_0.btnAdd.Invoke((MethodInvoker)delegate
				{
					fImportAccount_0.btnAdd.Enabled = false;
				});
				fImportAccount_0.method_2(GClass29.smethod_0("Chuẩn bị thêm tài khoản..."), fImportAccount_0.lblStatus);
				if (bool_0)
				{
					int num = 0;
					while (num < fImportAccount_0.list_1.Count)
					{
						if (fImportAccount_0.list_2.Count < int_0)
						{
							Class210 CS_0024_003C_003E8__locals0 = new Class210
							{
								class209_0 = this,
								int_0 = num++
							};
							fImportAccount_0.method_2(string.Format(GClass29.smethod_0("Đang check thông tin {0}/{1}..."), num, fImportAccount_0.list_1.Count), fImportAccount_0.lblStatus);
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									string text15 = CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.list_1[CS_0024_003C_003E8__locals0.int_0];
									if (!(text15.Trim() == ""))
									{
										string[] array2 = text15.Split('|');
										string text16 = "";
										string text17 = "";
										string text18 = "";
										string text19 = "";
										string text20 = "";
										string text21 = "";
										string text22 = "";
										string text23 = "";
										string text24 = "";
										string text25 = "";
										string text26 = "";
										string text27 = "";
										string text28 = "";
										text16 = array2[0];
										text17 = array2[1];
										text18 = array2[2];
										text19 = array2[3];
										text20 = array2[4];
										text21 = array2[5];
										text22 = array2[6];
										text23 = array2[7];
										text24 = array2[8];
										text25 = array2[9];
										text26 = array2[10];
										text27 = array2[11];
										text28 = array2[12];
										string string_5 = "";
										string string_6 = "";
										string string_7 = "";
										string text29 = "unknow";
										if (text16 == "")
										{
											text16 = Regex.Match(text19, "c_user=(.*?);").Groups[1].Value;
										}
										if (text16 == "")
										{
											text29 = "Die";
										}
										else
										{
											string text30 = Class32.smethod_15(text16);
											if (text30.StartsWith("0|"))
											{
												if (Class32.smethod_14(text16).StartsWith("0|"))
												{
													text29 = "Die";
												}
											}
											else if (text30.StartsWith("1|"))
											{
												CS_0024_003C_003E8__locals0.class209_0.string_0 = text30.Split('|');
												string_5 = CS_0024_003C_003E8__locals0.class209_0.string_0[1];
												text26 = CS_0024_003C_003E8__locals0.class209_0.string_0[2];
												text27 = CS_0024_003C_003E8__locals0.class209_0.string_0[3];
												text29 = "Live";
											}
										}
										string text31 = text29;
										string text32 = text31;
										if (!(text32 == "Live"))
										{
											if (!(text32 == "Die"))
											{
												CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.method_3(CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.lblKhongCheckDuoc);
											}
											else
											{
												CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.method_3(CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.lblWallDie);
											}
										}
										else
										{
											CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.method_3(CS_0024_003C_003E8__locals0.class209_0.fImportAccount_0.lblWallLive);
										}
										CS_0024_003C_003E8__locals0.class209_0.list_0.Add(Class36.smethod_12(text16, text17, text18, text19, text20, string_5, text26, string_6, text25, string_7, text29, text22, CS_0024_003C_003E8__locals0.class209_0.string_1, text21, text23, text24, text27, text28));
									}
								}
								catch
								{
								}
							});
							fImportAccount_0.list_2.Add(thread);
							thread.Start();
							continue;
						}
						for (int i = 0; i < fImportAccount_0.list_2.Count; i++)
						{
							if (!fImportAccount_0.list_2[i].IsAlive)
							{
								fImportAccount_0.list_2.RemoveAt(i--);
							}
						}
					}
					for (int j = 0; j < fImportAccount_0.list_2.Count; j++)
					{
						fImportAccount_0.list_2[j].Join();
					}
				}
				else
				{
					for (int k = 0; k < fImportAccount_0.list_1.Count; k++)
					{
						try
						{
							string text = fImportAccount_0.list_1[k];
							if (text.Trim() == "")
							{
								return;
							}
							string[] array = text.Split('|');
							string text2 = "";
							string text3 = "";
							string text4 = "";
							string text5 = "";
							string text6 = "";
							string text7 = "";
							string text8 = "";
							string text9 = "";
							string text10 = "";
							string text11 = "";
							string text12 = "";
							string text13 = "";
							string text14 = "";
							text2 = array[0];
							text3 = array[1];
							text4 = array[2];
							text5 = array[3];
							text6 = array[4];
							text7 = array[5];
							text8 = array[6];
							text9 = array[7];
							text10 = array[8];
							text11 = array[9];
							text12 = array[10];
							text13 = array[11];
							text14 = array[12];
							string string_ = "";
							string string_2 = "";
							string string_3 = "";
							string string_4 = "unknow";
							if (text2 == "")
							{
								text2 = Regex.Match(text5, "c_user=(.*?);").Groups[1].Value;
							}
							list_0.Add(Class36.smethod_12(text2, text3, text4, text5, text6, string_, text12, string_2, text11, string_3, string_4, text8, string_1, text7, text9, text10, text13, text14));
						}
						catch
						{
						}
					}
				}
				fImportAccount_0.method_2(GClass29.smethod_0("Đang thêm tài khoản..."), fImportAccount_0.lblStatus);
				if (list_0.Count >= 0)
				{
					list_0 = Class36.smethod_11(list_0);
					for (int l = 0; l < list_0.Count; l++)
					{
						fImportAccount_0.method_3(fImportAccount_0.lblSuccess, GClass11.GClass11_0.method_4(list_0[l]));
					}
				}
				fImportAccount_0.method_2((Convert.ToInt32(fImportAccount_0.lblTotal.Text) - Convert.ToInt32(fImportAccount_0.lblSuccess.Text)).ToString() ?? "", fImportAccount_0.lblError);
				fImportAccount_0.btnAdd.Invoke((MethodInvoker)delegate
				{
					fImportAccount_0.btnAdd.Enabled = true;
				});
				GClass38.smethod_0(GClass29.smethod_0("Thêm tài khoản thành công!"));
				fImportAccount_0.method_2(GClass29.smethod_0("Thêm tài khoản thành công!"), fImportAccount_0.lblStatus);
				fImportAccount.bool_0 = true;
				fImportAccount.int_0 = Convert.ToInt32(string_1);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_, "AddAccount");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class210
	{
		public int int_0;

		public Class209 class209_0;

		internal void method_0()
		{
			try
			{
				string text = class209_0.fImportAccount_0.list_1[int_0];
				if (text.Trim() == "")
				{
					return;
				}
				string[] array = text.Split('|');
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				string text6 = "";
				string text7 = "";
				string text8 = "";
				string text9 = "";
				string text10 = "";
				string text11 = "";
				string text12 = "";
				string text13 = "";
				string text14 = "";
				text2 = array[0];
				text3 = array[1];
				text4 = array[2];
				text5 = array[3];
				text6 = array[4];
				text7 = array[5];
				text8 = array[6];
				text9 = array[7];
				text10 = array[8];
				text11 = array[9];
				text12 = array[10];
				text13 = array[11];
				text14 = array[12];
				string string_ = "";
				string string_2 = "";
				string string_3 = "";
				string text15 = "unknow";
				if (text2 == "")
				{
					text2 = Regex.Match(text5, "c_user=(.*?);").Groups[1].Value;
				}
				if (text2 == "")
				{
					text15 = "Die";
				}
				else
				{
					string text16 = Class32.smethod_15(text2);
					if (text16.StartsWith("0|"))
					{
						if (Class32.smethod_14(text2).StartsWith("0|"))
						{
							text15 = "Die";
						}
					}
					else if (text16.StartsWith("1|"))
					{
						class209_0.string_0 = text16.Split('|');
						string_ = class209_0.string_0[1];
						text12 = class209_0.string_0[2];
						text13 = class209_0.string_0[3];
						text15 = "Live";
					}
				}
				string text17 = text15;
				string text18 = text17;
				if (!(text18 == "Live"))
				{
					if (!(text18 == "Die"))
					{
						class209_0.fImportAccount_0.method_3(class209_0.fImportAccount_0.lblKhongCheckDuoc);
					}
					else
					{
						class209_0.fImportAccount_0.method_3(class209_0.fImportAccount_0.lblWallDie);
					}
				}
				else
				{
					class209_0.fImportAccount_0.method_3(class209_0.fImportAccount_0.lblWallLive);
				}
				class209_0.list_0.Add(Class36.smethod_12(text2, text3, text4, text5, text6, string_, text12, string_2, text11, string_3, text15, text8, class209_0.string_1, text7, text9, text10, text13, text14));
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class211
	{
		public Label label_0;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			label_0.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class212
	{
		public Label label_0;

		public int int_0;

		internal void method_0()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + ((int_0 == -1) ? 1 : int_0)).ToString();
		}

		internal void method_1()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + int_0).ToString();
		}
	}

	public static bool bool_0 = false;

	public static int int_0 = -1;

	public static bool bool_1 = false;

	private List<ComboBox> list_0;

	private int int_1 = 0;

	private List<string> list_1 = new List<string>();

	private List<Thread> list_2 = null;

	private object object_0 = new object();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnAdd;

	private Button btnCancel;

	private Label lblSuccess;

	private Label lblError;

	private Label lblWallDie;

	private Label lblTotal;

	private Label lblWallLive;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label lblStatus;

	private Label label8;

	private ComboBox cbbDinhDangNhap;

	private ComboBox cbbDinhDang1;

	private Label label9;

	private ComboBox cbbDinhDang2;

	private Label label10;

	private ComboBox cbbDinhDang3;

	private Label label11;

	private ComboBox cbbDinhDang4;

	private Label label12;

	private ComboBox cbbDinhDang5;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label14;

	private ComboBox cbbDinhDang7;

	private Label label15;

	private CheckBox ckbCheckThongTin;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel plDinhDangNhap;

	private PictureBox pictureBox1;

	private Label label16;

	private ComboBox cbbThuMuc;

	private Button button1;

	private RichTextBox txbAccount;

	private Label label18;

	private Label label17;

	private ComboBox cbbDinhDang8;

	private ComboBox cbbDinhDang9;

	private Button btnMinimize;

	private Label lblKhongCheckDuoc;

	private Label label2;

	private Button button2;

	private Button button3;

	private Label label19;

	private Label label1;

	private ComboBox cbbDinhDang10;

	private ComboBox cbbDinhDang11;

	public fImportAccount(string string_0)
	{
		InitializeComponent();
		method_1();
		method_0();
		if (string_0 != "" && string_0 != "-1" && string_0 != "999999")
		{
			cbbThuMuc.SelectedValue = string_0;
		}
		cbbDinhDangNhap.SelectedIndex = 0;
		list_0 = new List<ComboBox>
		{
			cbbDinhDang1, cbbDinhDang2, cbbDinhDang3, cbbDinhDang4, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, cbbDinhDang9, cbbDinhDang10,
			cbbDinhDang11
		};
		bool_1 = false;
		bool_0 = false;
		int_0 = -1;
	}

	private void method_0()
	{
		int_1 = cbbThuMuc.SelectedIndex;
		DataTable dataTable = Class36.smethod_1();
		if (dataTable.Rows.Count > 0)
		{
			cbbThuMuc.DataSource = dataTable;
			cbbThuMuc.ValueMember = "id";
			cbbThuMuc.DisplayMember = "name";
			if (int_1 == -1)
			{
				int_1 = 0;
			}
			cbbThuMuc.SelectedIndex = int_1;
		}
	}

	private void method_1()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(button1);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(ckbCheckThongTin);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = txbAccount.Lines.ToList();
			list = GClass14.smethod_36(list);
			if (list.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!"), 3);
				txbAccount.Focus();
				return;
			}
			if (cbbThuMuc.SelectedValue == null)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng cho\u0323n thư mu\u0323c!"), 3);
				return;
			}
			string string_1 = cbbThuMuc.SelectedValue.ToString();
			bool bool_0 = ckbCheckThongTin.Checked;
			int selectedIndex = cbbDinhDangNhap.SelectedIndex;
			if (selectedIndex == 6)
			{
				bool flag = false;
				for (int i = 0; i < this.list_0.Count; i++)
				{
					if (this.list_0[i].SelectedIndex > -1)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!"), 3);
					return;
				}
			}
			int int_0 = 100;
			if (list.Count < 100)
			{
				int_0 = list.Count;
			}
			lblSuccess.Text = "0";
			lblError.Text = "0";
			lblWallDie.Text = "0";
			lblKhongCheckDuoc.Text = "0";
			lblWallLive.Text = "0";
			list_1 = new List<string>();
			int num = 0;
			string[] string_0;
			switch (selectedIndex)
			{
			case 0:
			{
				num = 3;
				for (int num3 = 0; num3 < list.Count; num3++)
				{
					string_0 = list[num3].Split('|');
					if (string_0.Count() >= num)
					{
						list_1.Add(string_0[0] + "|" + string_0[1] + "|||||" + string_0[2] + "||||||");
					}
					else
					{
						method_3(lblError);
					}
				}
				break;
			}
			case 1:
			{
				for (int l = 0; l < list.Count; l++)
				{
					list_1.Add("|||" + list[l] + "|||||||||");
				}
				break;
			}
			case 2:
			{
				num = 2;
				for (int n = 0; n < list.Count; n++)
				{
					string_0 = list[n].Split('|');
					if (string_0.Count() >= num)
					{
						list_1.Add(string_0[0] + "|" + string_0[1] + "|||||||||||");
					}
					else
					{
						method_3(lblError);
					}
				}
				break;
			}
			case 3:
			{
				num = 4;
				for (int num4 = 0; num4 < list.Count; num4++)
				{
					string_0 = list[num4].Split('|');
					if (string_0.Count() >= num)
					{
						list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|||||||||");
					}
					else
					{
						method_3(lblError);
					}
				}
				break;
			}
			case 4:
			{
				num = 6;
				for (int num2 = 0; num2 < list.Count; num2++)
				{
					string_0 = list[num2].Split('|');
					if (string_0.Count() >= num)
					{
						list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|" + string_0[4] + "|" + string_0[5] + "|||||||");
					}
					else
					{
						method_3(lblError);
					}
				}
				break;
			}
			case 5:
			{
				num = 7;
				for (int m = 0; m < list.Count; m++)
				{
					string_0 = list[m].Split('|');
					if (string_0.Count() >= num)
					{
						list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|" + string_0[4] + "|" + string_0[5] + "|" + string_0[6] + "||||||");
					}
					else
					{
						method_3(lblError);
					}
				}
				break;
			}
			case 6:
			{
				string text = "";
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				string text6 = "";
				string text7 = "";
				string text8 = "";
				string text9 = "";
				string text10 = "";
				string text11 = "";
				string text12 = "";
				string text13 = "";
				for (int j = 0; j < list.Count; j++)
				{
					string_0 = list[j].Split('|');
					text = "";
					text2 = "";
					text3 = "";
					text4 = "";
					text5 = "";
					text6 = "";
					text7 = "";
					text8 = "";
					text9 = "";
					text10 = "";
					text11 = "";
					text12 = "";
					text13 = "";
					try
					{
						for (int k = 0; k < this.list_0.Count; k++)
						{
							switch (this.list_0[k].SelectedIndex)
							{
							case 0:
								text = string_0[k];
								break;
							case 1:
								text2 = string_0[k];
								break;
							case 2:
								text3 = string_0[k];
								break;
							case 3:
								text4 = string_0[k];
								break;
							case 4:
								text5 = string_0[k];
								break;
							case 5:
								text6 = string_0[k];
								break;
							case 6:
								text7 = string_0[k];
								break;
							case 7:
								text8 = string_0[k];
								break;
							case 8:
								text9 = ((!(string_0[k].Trim() == "")) ? (string_0[k] + "*0") : "");
								break;
							case 9:
								text10 = string_0[k];
								break;
							case 10:
								text11 = string_0[k];
								break;
							case 11:
								text12 = string_0[k];
								break;
							case 12:
								text13 = string_0[k];
								break;
							}
						}
						list_1.Add(text + "|" + text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13);
					}
					catch
					{
						method_3(lblError);
					}
				}
				break;
			}
			}
			List<string> list_0 = new List<string>();
			list_2 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnAdd.Invoke((MethodInvoker)delegate
					{
						btnAdd.Enabled = false;
					});
					method_2(GClass29.smethod_0("Chuẩn bị thêm tài khoản..."), lblStatus);
					if (bool_0)
					{
						int num5 = 0;
						while (num5 < list_1.Count)
						{
							if (list_2.Count < int_0)
							{
								int int_ = num5++;
								method_2(string.Format(GClass29.smethod_0("Đang check thông tin {0}/{1}..."), num5, list_1.Count), lblStatus);
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										string text28 = list_1[int_];
										if (!(text28.Trim() == ""))
										{
											string[] array2 = text28.Split('|');
											string text29 = "";
											string text30 = "";
											string text31 = "";
											string text32 = "";
											string text33 = "";
											string text34 = "";
											string text35 = "";
											string text36 = "";
											string text37 = "";
											string text38 = "";
											string text39 = "";
											string text40 = "";
											string text41 = "";
											text29 = array2[0];
											text30 = array2[1];
											text31 = array2[2];
											text32 = array2[3];
											text33 = array2[4];
											text34 = array2[5];
											text35 = array2[6];
											text36 = array2[7];
											text37 = array2[8];
											text38 = array2[9];
											text39 = array2[10];
											text40 = array2[11];
											text41 = array2[12];
											string string_6 = "";
											string string_7 = "";
											string string_8 = "";
											string text42 = "unknow";
											if (text29 == "")
											{
												text29 = Regex.Match(text32, "c_user=(.*?);").Groups[1].Value;
											}
											if (text29 == "")
											{
												text42 = "Die";
											}
											else
											{
												string text43 = Class32.smethod_15(text29);
												if (text43.StartsWith("0|"))
												{
													if (Class32.smethod_14(text29).StartsWith("0|"))
													{
														text42 = "Die";
													}
												}
												else if (text43.StartsWith("1|"))
												{
													string_0 = text43.Split('|');
													string_6 = string_0[1];
													text39 = string_0[2];
													text40 = string_0[3];
													text42 = "Live";
												}
											}
											string text44 = text42;
											string text45 = text44;
											if (!(text45 == "Live"))
											{
												if (!(text45 == "Die"))
												{
													method_3(lblKhongCheckDuoc);
												}
												else
												{
													method_3(lblWallDie);
												}
											}
											else
											{
												method_3(lblWallLive);
											}
											list_0.Add(Class36.smethod_12(text29, text30, text31, text32, text33, string_6, text39, string_7, text38, string_8, text42, text35, string_1, text34, text36, text37, text40, text41));
										}
									}
									catch
									{
									}
								});
								list_2.Add(thread);
								thread.Start();
							}
							else
							{
								for (int num6 = 0; num6 < list_2.Count; num6++)
								{
									if (!list_2[num6].IsAlive)
									{
										list_2.RemoveAt(num6--);
									}
								}
							}
						}
						for (int num7 = 0; num7 < list_2.Count; num7++)
						{
							list_2[num7].Join();
						}
					}
					else
					{
						for (int num8 = 0; num8 < list_1.Count; num8++)
						{
							try
							{
								string text14 = list_1[num8];
								if (text14.Trim() == "")
								{
									return;
								}
								string[] array = text14.Split('|');
								string text15 = "";
								string text16 = "";
								string text17 = "";
								string text18 = "";
								string text19 = "";
								string text20 = "";
								string text21 = "";
								string text22 = "";
								string text23 = "";
								string text24 = "";
								string text25 = "";
								string text26 = "";
								string text27 = "";
								text15 = array[0];
								text16 = array[1];
								text17 = array[2];
								text18 = array[3];
								text19 = array[4];
								text20 = array[5];
								text21 = array[6];
								text22 = array[7];
								text23 = array[8];
								text24 = array[9];
								text25 = array[10];
								text26 = array[11];
								text27 = array[12];
								string string_2 = "";
								string string_3 = "";
								string string_4 = "";
								string string_5 = "unknow";
								if (text15 == "")
								{
									text15 = Regex.Match(text18, "c_user=(.*?);").Groups[1].Value;
								}
								list_0.Add(Class36.smethod_12(text15, text16, text17, text18, text19, string_2, text25, string_3, text24, string_4, string_5, text21, string_1, text20, text22, text23, text26, text27));
							}
							catch
							{
							}
						}
					}
					method_2(GClass29.smethod_0("Đang thêm tài khoản..."), lblStatus);
					if (list_0.Count >= 0)
					{
						list_0 = Class36.smethod_11(list_0);
						for (int num9 = 0; num9 < list_0.Count; num9++)
						{
							method_3(lblSuccess, GClass11.GClass11_0.method_4(list_0[num9]));
						}
					}
					method_2((Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(lblSuccess.Text)).ToString() ?? "", lblError);
					btnAdd.Invoke((MethodInvoker)delegate
					{
						btnAdd.Enabled = true;
					});
					GClass38.smethod_0(GClass29.smethod_0("Thêm tài khoản thành công!"));
					method_2(GClass29.smethod_0("Thêm tài khoản thành công!"), lblStatus);
					fImportAccount.bool_0 = true;
					fImportAccount.int_0 = Convert.ToInt32(string_1);
				}
				catch (Exception exception_2)
				{
					GClass14.smethod_75(null, exception_2, "AddAccount");
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			GClass38.smethod_0(GClass29.smethod_0("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			GClass14.smethod_75(null, exception_, "AddAccount");
		}
	}

	private void method_2(string string_0, Label label_0)
	{
		label_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			label_0.Text = string_0;
		});
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = txbAccount.Lines.ToList();
			list = GClass14.smethod_36(list);
			lblTotal.Text = list.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_3(Label label_0, int int_2 = -1)
	{
		if (int_2 == -1)
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				label_0.Text = (Convert.ToInt32(label_0.Text) + ((int_2 == -1) ? 1 : int_2)).ToString();
			});
		}
		else
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				label_0.Text = (Convert.ToInt32(label_0.Text) + int_2).ToString();
			});
		}
	}

	private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = cbbDinhDangNhap.SelectedIndex == cbbDinhDangNhap.Items.Count - 1;
		if (plDinhDangNhap.Visible)
		{
			method_8();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		GClass14.smethod_33(form_);
		if (fAddFile.bool_0)
		{
			method_0();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 1;
			bool_1 = true;
		}
	}

	private bool method_4()
	{
		bool result = false;
		List<int> list = new List<int>();
		int num = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			num = list_0[i].SelectedIndex;
			if (num != -1)
			{
				if (list.Contains(num))
				{
					result = true;
					break;
				}
				list.Add(num);
			}
		}
		return result;
	}

	private void cbbDinhDang9_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (method_4())
		{
			GClass38.smethod_0(GClass29.smethod_0("Tu\u0300y cho\u0323n na\u0300y đa\u0303 tô\u0300n ta\u0323i, vui lo\u0300ng cho\u0323n tu\u0300y cho\u0323n kha\u0301c!"), 3);
			(sender as ComboBox).SelectedIndex = -1;
		}
	}

	private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private void method_6()
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void method_7()
	{
		try
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			File.WriteAllText("settings\\format_paste.txt", text);
		}
		catch
		{
		}
	}

	private void method_8()
	{
		try
		{
			if (File.Exists("settings\\format_paste.txt"))
			{
				string text = File.ReadAllText("settings\\format_paste.txt");
				for (int i = 0; i < list_0.Count; i++)
				{
					list_0[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportAccount));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnAdd = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.lblSuccess = new System.Windows.Forms.Label();
		this.lblError = new System.Windows.Forms.Label();
		this.lblWallDie = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.lblWallLive = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.cbbDinhDangNhap = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		this.label9 = new System.Windows.Forms.Label();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.label10 = new System.Windows.Forms.Label();
		this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.label15 = new System.Windows.Forms.Label();
		this.ckbCheckThongTin = new System.Windows.Forms.CheckBox();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.plDinhDangNhap = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.label19 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		this.label17 = new System.Windows.Forms.Label();
		this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang9 = new System.Windows.Forms.ComboBox();
		this.label16 = new System.Windows.Forms.Label();
		this.cbbThuMuc = new System.Windows.Forms.ComboBox();
		this.button1 = new System.Windows.Forms.Button();
		this.txbAccount = new System.Windows.Forms.RichTextBox();
		this.lblKhongCheckDuoc = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.plDinhDangNhap.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1143, 37);
		this.bunifuCards1.TabIndex = 11;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1143, 31);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(1110, 2);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1143, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Nhập Tài Khoản";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(459, 532);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(107, 31);
		this.btnAdd.TabIndex = 13;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(573, 532);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(107, 31);
		this.btnCancel.TabIndex = 14;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.lblSuccess.AutoSize = true;
		this.lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		this.lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.lblSuccess.Location = new System.Drawing.Point(106, 51);
		this.lblSuccess.Name = "lblSuccess";
		this.lblSuccess.Size = new System.Drawing.Size(19, 19);
		this.lblSuccess.TabIndex = 23;
		this.lblSuccess.Text = "0";
		this.lblError.AutoSize = true;
		this.lblError.BackColor = System.Drawing.SystemColors.Control;
		this.lblError.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblError.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.lblError.Location = new System.Drawing.Point(218, 51);
		this.lblError.Name = "lblError";
		this.lblError.Size = new System.Drawing.Size(19, 19);
		this.lblError.TabIndex = 24;
		this.lblError.Text = "0";
		this.lblWallDie.AutoSize = true;
		this.lblWallDie.BackColor = System.Drawing.SystemColors.Control;
		this.lblWallDie.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblWallDie.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.lblWallDie.Location = new System.Drawing.Point(498, 51);
		this.lblWallDie.Name = "lblWallDie";
		this.lblWallDie.Size = new System.Drawing.Size(19, 19);
		this.lblWallDie.TabIndex = 25;
		this.lblWallDie.Text = "0";
		this.lblTotal.AutoSize = true;
		this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
		this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotal.ForeColor = System.Drawing.Color.Teal;
		this.lblTotal.Location = new System.Drawing.Point(842, 51);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(19, 19);
		this.lblTotal.TabIndex = 26;
		this.lblTotal.Text = "0";
		this.lblWallLive.AutoSize = true;
		this.lblWallLive.BackColor = System.Drawing.SystemColors.Control;
		this.lblWallLive.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblWallLive.ForeColor = System.Drawing.Color.Green;
		this.lblWallLive.Location = new System.Drawing.Point(361, 51);
		this.lblWallLive.Name = "lblWallLive";
		this.lblWallLive.Size = new System.Drawing.Size(19, 19);
		this.lblWallLive.TabIndex = 29;
		this.lblWallLive.Text = "0";
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label3.Location = new System.Drawing.Point(22, 53);
		this.label3.Name = "label3";
		this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label3.Size = new System.Drawing.Size(87, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Tha\u0300nh công:";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label4.Location = new System.Drawing.Point(170, 53);
		this.label4.Name = "label4";
		this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label4.Size = new System.Drawing.Size(52, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "Lỗi:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label5.Location = new System.Drawing.Point(295, 53);
		this.label5.Name = "label5";
		this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label5.Size = new System.Drawing.Size(70, 16);
		this.label5.TabIndex = 36;
		this.label5.Text = "Wall Live:";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label6.Location = new System.Drawing.Point(438, 53);
		this.label6.Name = "label6";
		this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label6.Size = new System.Drawing.Size(64, 16);
		this.label6.TabIndex = 37;
		this.label6.Text = "Wall Die:";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(783, 53);
		this.label7.Name = "label7";
		this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label7.Size = new System.Drawing.Size(63, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "Tô\u0309ng sô\u0301:";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.Location = new System.Drawing.Point(15, 75);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(924, 28);
		this.lblStatus.TabIndex = 27;
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(14, 397);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(97, 14);
		this.label8.TabIndex = 39;
		this.label8.Text = "Định dạng nhập:";
		this.cbbDinhDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDangNhap.FormattingEnabled = true;
		this.cbbDinhDangNhap.Items.AddRange(new object[7] { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		this.cbbDinhDangNhap.Location = new System.Drawing.Point(117, 394);
		this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
		this.cbbDinhDangNhap.Size = new System.Drawing.Size(269, 22);
		this.cbbDinhDangNhap.TabIndex = 40;
		this.cbbDinhDangNhap.SelectedIndexChanged += new System.EventHandler(cbbDinhDangNhap_SelectedIndexChanged);
		this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang1.FormattingEnabled = true;
		this.cbbDinhDang1.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang1.Location = new System.Drawing.Point(3, 3);
		this.cbbDinhDang1.Name = "cbbDinhDang1";
		this.cbbDinhDang1.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang1.TabIndex = 40;
		this.cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label9.Location = new System.Drawing.Point(81, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(15, 19);
		this.label9.TabIndex = 41;
		this.label9.Text = "|";
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang2.Location = new System.Drawing.Point(96, 3);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang2.TabIndex = 40;
		this.cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label10.Location = new System.Drawing.Point(174, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(15, 19);
		this.label10.TabIndex = 41;
		this.label10.Text = "|";
		this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang3.FormattingEnabled = true;
		this.cbbDinhDang3.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang3.Location = new System.Drawing.Point(189, 3);
		this.cbbDinhDang3.Name = "cbbDinhDang3";
		this.cbbDinhDang3.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang3.TabIndex = 40;
		this.cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label11.Location = new System.Drawing.Point(267, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(15, 19);
		this.label11.TabIndex = 41;
		this.label11.Text = "|";
		this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang4.FormattingEnabled = true;
		this.cbbDinhDang4.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang4.Location = new System.Drawing.Point(282, 3);
		this.cbbDinhDang4.Name = "cbbDinhDang4";
		this.cbbDinhDang4.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang4.TabIndex = 40;
		this.cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label12.Location = new System.Drawing.Point(360, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(15, 19);
		this.label12.TabIndex = 41;
		this.label12.Text = "|";
		this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang5.FormattingEnabled = true;
		this.cbbDinhDang5.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang5.Location = new System.Drawing.Point(375, 3);
		this.cbbDinhDang5.Name = "cbbDinhDang5";
		this.cbbDinhDang5.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang5.TabIndex = 40;
		this.cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label13.Location = new System.Drawing.Point(453, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(15, 19);
		this.label13.TabIndex = 41;
		this.label13.Text = "|";
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang6.Location = new System.Drawing.Point(468, 3);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang6.TabIndex = 40;
		this.cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label14.Location = new System.Drawing.Point(546, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(15, 19);
		this.label14.TabIndex = 41;
		this.label14.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang7.Location = new System.Drawing.Point(561, 3);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang7.TabIndex = 40;
		this.cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(14, 502);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(63, 14);
		this.label15.TabIndex = 39;
		this.label15.Text = "Tùy chọn:";
		this.ckbCheckThongTin.AutoSize = true;
		this.ckbCheckThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckThongTin.Location = new System.Drawing.Point(117, 501);
		this.ckbCheckThongTin.Name = "ckbCheckThongTin";
		this.ckbCheckThongTin.Size = new System.Drawing.Size(355, 18);
		this.ckbCheckThongTin.TabIndex = 43;
		this.ckbCheckThongTin.Text = "Check thông tin (Check Wall, Tên, Giới tính, Bạn bè, Nhóm)";
		this.ckbCheckThongTin.UseVisualStyleBackColor = true;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.plDinhDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDinhDangNhap.Controls.Add(this.button2);
		this.plDinhDangNhap.Controls.Add(this.button3);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang1);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang2);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang3);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang4);
		this.plDinhDangNhap.Controls.Add(this.label19);
		this.plDinhDangNhap.Controls.Add(this.label18);
		this.plDinhDangNhap.Controls.Add(this.label14);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang5);
		this.plDinhDangNhap.Controls.Add(this.label1);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang10);
		this.plDinhDangNhap.Controls.Add(this.label17);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang8);
		this.plDinhDangNhap.Controls.Add(this.label13);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang11);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang6);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang9);
		this.plDinhDangNhap.Controls.Add(this.label12);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang7);
		this.plDinhDangNhap.Controls.Add(this.label11);
		this.plDinhDangNhap.Controls.Add(this.label9);
		this.plDinhDangNhap.Controls.Add(this.label10);
		this.plDinhDangNhap.Location = new System.Drawing.Point(114, 420);
		this.plDinhDangNhap.Name = "plDinhDangNhap";
		this.plDinhDangNhap.Size = new System.Drawing.Size(1019, 75);
		this.plDinhDangNhap.TabIndex = 46;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.button2.BackColor = System.Drawing.Color.DarkOrange;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Location = new System.Drawing.Point(380, 40);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(121, 29);
		this.button2.TabIndex = 43;
		this.button2.Text = "Reset định dạng";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.button3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.FlatAppearance.BorderSize = 0;
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.Color.White;
		this.button3.Location = new System.Drawing.Point(517, 40);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(120, 29);
		this.button3.TabIndex = 42;
		this.button3.Text = "Lưu định dạng";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label19.Location = new System.Drawing.Point(919, 3);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(15, 19);
		this.label19.TabIndex = 41;
		this.label19.Text = "|";
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label18.Location = new System.Drawing.Point(732, 3);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(15, 19);
		this.label18.TabIndex = 41;
		this.label18.Text = "|";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label1.Location = new System.Drawing.Point(826, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(15, 19);
		this.label1.TabIndex = 41;
		this.label1.Text = "|";
		this.cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang10.FormattingEnabled = true;
		this.cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang10.Location = new System.Drawing.Point(841, 3);
		this.cbbDinhDang10.Name = "cbbDinhDang10";
		this.cbbDinhDang10.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang10.TabIndex = 40;
		this.cbbDinhDang10.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label17.Location = new System.Drawing.Point(639, 3);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(15, 19);
		this.label17.TabIndex = 41;
		this.label17.Text = "|";
		this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang8.FormattingEnabled = true;
		this.cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang8.Location = new System.Drawing.Point(654, 3);
		this.cbbDinhDang8.Name = "cbbDinhDang8";
		this.cbbDinhDang8.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang8.TabIndex = 40;
		this.cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang11.FormattingEnabled = true;
		this.cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang11.Location = new System.Drawing.Point(934, 3);
		this.cbbDinhDang11.Name = "cbbDinhDang11";
		this.cbbDinhDang11.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang11.TabIndex = 40;
		this.cbbDinhDang11.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang9.FormattingEnabled = true;
		this.cbbDinhDang9.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang9.Location = new System.Drawing.Point(747, 3);
		this.cbbDinhDang9.Name = "cbbDinhDang9";
		this.cbbDinhDang9.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang9.TabIndex = 40;
		this.cbbDinhDang9.SelectedIndexChanged += new System.EventHandler(cbbDinhDang9_SelectedIndexChanged);
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(14, 368);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(90, 14);
		this.label16.TabIndex = 39;
		this.label16.Text = "Cho\u0323n thư mu\u0323c:";
		this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbThuMuc.DropDownWidth = 269;
		this.cbbThuMuc.FormattingEnabled = true;
		this.cbbThuMuc.Location = new System.Drawing.Point(117, 365);
		this.cbbThuMuc.Name = "cbbThuMuc";
		this.cbbThuMuc.Size = new System.Drawing.Size(201, 22);
		this.cbbThuMuc.TabIndex = 40;
		this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(cbbThuMuc_SelectedIndexChanged);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(324, 364);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(62, 25);
		this.button1.TabIndex = 45;
		this.button1.Text = "Thêm";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txbAccount.Location = new System.Drawing.Point(15, 120);
		this.txbAccount.Name = "txbAccount";
		this.txbAccount.Size = new System.Drawing.Size(1118, 238);
		this.txbAccount.TabIndex = 48;
		this.txbAccount.Text = "";
		this.txbAccount.WordWrap = false;
		this.txbAccount.TextChanged += new System.EventHandler(txbAccount_TextChanged);
		this.lblKhongCheckDuoc.AutoSize = true;
		this.lblKhongCheckDuoc.BackColor = System.Drawing.SystemColors.Control;
		this.lblKhongCheckDuoc.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblKhongCheckDuoc.ForeColor = System.Drawing.Color.Maroon;
		this.lblKhongCheckDuoc.Location = new System.Drawing.Point(705, 51);
		this.lblKhongCheckDuoc.Name = "lblKhongCheckDuoc";
		this.lblKhongCheckDuoc.Size = new System.Drawing.Size(19, 19);
		this.lblKhongCheckDuoc.TabIndex = 25;
		this.lblKhongCheckDuoc.Text = "0";
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(578, 53);
		this.label2.Name = "label2";
		this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label2.Size = new System.Drawing.Size(131, 16);
		this.label2.TabIndex = 37;
		this.label2.Text = "Không Check được:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1143, 576);
		base.Controls.Add(this.txbAccount);
		base.Controls.Add(this.plDinhDangNhap);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.ckbCheckThongTin);
		base.Controls.Add(this.cbbThuMuc);
		base.Controls.Add(this.cbbDinhDangNhap);
		base.Controls.Add(this.label15);
		base.Controls.Add(this.label16);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.lblWallLive);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.lblKhongCheckDuoc);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.lblWallDie);
		base.Controls.Add(this.lblError);
		base.Controls.Add(this.lblSuccess);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportAccount";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Nhập tài khoản";
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.plDinhDangNhap.ResumeLayout(false);
		this.plDinhDangNhap.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_9()
	{
		btnAdd.Enabled = false;
	}

	[CompilerGenerated]
	private void method_10()
	{
		btnAdd.Enabled = true;
	}
}
