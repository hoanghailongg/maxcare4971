using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCapNhatDuLieu : Form
{
	[CompilerGenerated]
	private sealed class Class53
	{
		public Label label_0;

		internal void method_0()
		{
			int num = Convert.ToInt32(label_0.Text);
			label_0.Text = (num + 1).ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class54
	{
		public fCapNhatDuLieu fCapNhatDuLieu_0;

		public string string_0;

		internal void method_0()
		{
			fCapNhatDuLieu_0.lblStatus.Text = string_0;
		}
	}

	public static bool bool_0;

	private List<ComboBox> list_0;

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> list_3 = new List<string>();

	private IContainer icontainer_0 = null;

	private Button btnAdd;

	private Button btnCancel;

	private Label label8;

	private ComboBox cbbDinhDangNhap;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private RichTextBox txbAccount;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel pnlHeader;

	private BunifuCards bunifuCards1;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private Label label3;

	private Label lblSuccess;

	private Label lblError;

	private Label lblTotal;

	private Label label4;

	private Label label7;

	private Label lblStatus;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private PictureBox pictureBox2;

	private Panel plDinhDangNhap;

	private Label label1;

	private ComboBox cbbDinhDang1;

	private ComboBox cbbDinhDang2;

	private ComboBox cbbDinhDang3;

	private ComboBox cbbDinhDang4;

	private Label label14;

	private ComboBox cbbDinhDang5;

	private Label label17;

	private ComboBox cbbDinhDang8;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label12;

	private ComboBox cbbDinhDang7;

	private Label label11;

	private Label label9;

	private Label label10;

	private ComboBox cbbTypeProxy;

	private Label label2;

	private Label label5;

	private ComboBox cbbDinhDang9;

	private Label label15;

	private ComboBox cbbDinhDang11;

	private Label label6;

	private ComboBox cbbDinhDang10;

	private Label label16;

	private ComboBox cbbDinhDang12;

	public fCapNhatDuLieu()
	{
		InitializeComponent();
		cbbDinhDangNhap.SelectedIndex = 0;
		list_0 = new List<ComboBox>
		{
			cbbDinhDang1, cbbDinhDang2, cbbDinhDang3, cbbDinhDang4, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, cbbDinhDang9, cbbDinhDang10,
			cbbDinhDang11
		};
		bool_0 = false;
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		list_2 = new List<string>();
		list_3 = new List<string>();
		try
		{
			List<string> list = txbAccount.Lines.ToList();
			list = GClass14.smethod_36(list);
			if (list.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!"));
				txbAccount.Focus();
				return;
			}
			int selectedIndex = cbbDinhDangNhap.SelectedIndex;
			if (selectedIndex == 5)
			{
				bool flag = false;
				for (int i = 0; i < list_0.Count; i++)
				{
					if (list_0[i].SelectedIndex > -1)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!"));
					return;
				}
			}
			lblSuccess.Text = "0";
			lblError.Text = "0";
			list_1 = new List<string>();
			int num = 0;
			switch (selectedIndex)
			{
			case 0:
			{
				num = 2;
				for (int n = 0; n < list.Count; n++)
				{
					string[] array = list[n].Split('|');
					if (array.Count() >= num)
					{
						list_1.Add(array[0] + "|" + array[1] + "|||||||||||");
						list_2.Add(list[n]);
					}
					else
					{
						method_2(lblError);
						list_3.Add(list[n]);
					}
				}
				break;
			}
			case 1:
			{
				num = 3;
				for (int num3 = 0; num3 < list.Count; num3++)
				{
					string[] array = list[num3].Split('|');
					if (array.Count() >= num)
					{
						list_1.Add(array[0] + "|" + array[1] + "|||||" + array[2] + "||||||");
						list_2.Add(list[num3]);
					}
					else
					{
						method_2(lblError);
						list_3.Add(list[num3]);
					}
				}
				break;
			}
			case 2:
			{
				num = 4;
				for (int l = 0; l < list.Count; l++)
				{
					string[] array = list[l].Split('|');
					if (array.Count() >= num)
					{
						list_1.Add(array[0] + "|" + array[1] + "|" + array[2] + "|" + array[3] + "|||||||||");
						list_2.Add(list[l]);
					}
					else
					{
						method_2(lblError);
						list_3.Add(list[l]);
					}
				}
				break;
			}
			case 3:
			{
				num = 6;
				for (int num2 = 0; num2 < list.Count; num2++)
				{
					string[] array = list[num2].Split('|');
					if (array.Count() >= num)
					{
						list_1.Add(array[0] + "|" + array[1] + "|" + array[2] + "|" + array[3] + "|" + array[4] + "|" + array[5] + "|||||||");
						list_2.Add(list[num2]);
					}
					else
					{
						method_2(lblError);
						list_3.Add(list[num2]);
					}
				}
				break;
			}
			case 4:
			{
				num = 7;
				for (int m = 0; m < list.Count; m++)
				{
					string[] array = list[m].Split('|');
					if (array.Count() >= num)
					{
						list_1.Add(array[0] + "|" + array[1] + "|" + array[2] + "|" + array[3] + "|" + array[4] + "|" + array[5] + "|" + array[6] + "||||||");
						list_2.Add(list[m]);
					}
					else
					{
						method_2(lblError);
						list_3.Add(list[m]);
					}
				}
				break;
			}
			case 5:
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
					string[] array = list[j].Split('|');
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
						text = array[0];
						for (int k = 1; k < list_0.Count; k++)
						{
							switch (list_0[k - 1].SelectedIndex)
							{
							case 0:
								text = array[k];
								break;
							case 1:
								text2 = array[k];
								break;
							case 2:
								text3 = array[k];
								break;
							case 3:
								text4 = array[k];
								break;
							case 4:
								text5 = array[k];
								break;
							case 5:
								text6 = array[k];
								break;
							case 6:
								text7 = array[k];
								break;
							case 7:
								text8 = array[k];
								break;
							case 8:
								text9 = ((array[k] == "") ? "" : (array[k] + "*" + cbbTypeProxy.SelectedIndex));
								break;
							case 9:
								text10 = array[k];
								break;
							case 10:
								text11 = array[k];
								break;
							case 11:
								text12 = array[k];
								break;
							case 12:
								text13 = array[k];
								break;
							}
						}
						list_1.Add(text + "|" + text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13);
						list_2.Add(list[j]);
					}
					catch
					{
						method_2(lblError);
						list_3.Add(list[j]);
					}
				}
				break;
			}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = false;
			});
			method_1(GClass29.smethod_0("Đang cập nhật dữ liệu..."));
			for (int num4 = 0; num4 < list_1.Count; num4++)
			{
				if (Class36.smethod_27(list_1[num4]))
				{
					method_2(lblSuccess);
				}
				else
				{
					method_2(lblError);
				}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = true;
			});
			list_2.AddRange(list_3);
			txbAccount.Lines = list_2.ToArray();
			method_1(GClass29.smethod_0("Cập nhật dữ liệu xong!"));
			GClass38.smethod_0(GClass29.smethod_0("Cập nhật dữ liệu xong!"));
			bool_0 = true;
		}
		catch (Exception exception_)
		{
			GClass38.smethod_0(GClass29.smethod_0("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"));
			GClass14.smethod_76(exception_, "UpdateAccount");
		}
	}

	private void method_1(string string_0)
	{
		Application.DoEvents();
		lblStatus.Invoke((MethodInvoker)delegate
		{
			lblStatus.Text = string_0;
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

	private void method_2(Label label_0)
	{
		Application.DoEvents();
		lock (label_0)
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				int num = Convert.ToInt32(label_0.Text);
				label_0.Text = (num + 1).ToString();
			});
		}
	}

	private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = cbbDinhDangNhap.SelectedIndex == cbbDinhDangNhap.Items.Count - 1;
	}

	private bool method_3()
	{
		bool result = false;
		List<int> list = new List<int>();
		int num = 0;
		for (int i = 0; i <= 6; i++)
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

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void cbbDinhDang7_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool visible = false;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Text == "Proxy")
			{
				visible = true;
				break;
			}
		}
		label2.Visible = visible;
		cbbTypeProxy.Visible = visible;
	}

	private void fCapNhatDuLieu_Load(object sender, EventArgs e)
	{
		cbbTypeProxy.SelectedIndex = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCapNhatDuLieu));
		this.btnAdd = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.cbbDinhDangNhap = new System.Windows.Forms.ComboBox();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.txbAccount = new System.Windows.Forms.RichTextBox();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ctmsAcc = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.label3 = new System.Windows.Forms.Label();
		this.lblSuccess = new System.Windows.Forms.Label();
		this.lblError = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plDinhDangNhap = new System.Windows.Forms.Panel();
		this.label15 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang9 = new System.Windows.Forms.ComboBox();
		this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		this.label6 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.cbbDinhDang12 = new System.Windows.Forms.ComboBox();
		this.label16 = new System.Windows.Forms.Label();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.ctmsAcc.SuspendLayout();
		this.plDinhDangNhap.SuspendLayout();
		base.SuspendLayout();
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(482, 460);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(97, 31);
		this.btnAdd.TabIndex = 13;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(599, 460);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(97, 31);
		this.btnCancel.TabIndex = 14;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.label8.Location = new System.Drawing.Point(9, 367);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(97, 14);
		this.label8.TabIndex = 39;
		this.label8.Text = "Chọn định dạng:";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.cbbDinhDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDangNhap.FormattingEnabled = true;
		this.cbbDinhDangNhap.Items.AddRange(new object[6] { "Uid|Pass", "Uid|Pass|2FA", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		this.cbbDinhDangNhap.Location = new System.Drawing.Point(112, 364);
		this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
		this.cbbDinhDangNhap.Size = new System.Drawing.Size(269, 22);
		this.cbbDinhDangNhap.TabIndex = 40;
		this.cbbDinhDangNhap.SelectedIndexChanged += new System.EventHandler(cbbDinhDangNhap_SelectedIndexChanged);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1179, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1179, 31);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		this.pictureBox2.Location = new System.Drawing.Point(2, 3);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(34, 27);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 79;
		this.pictureBox2.TabStop = false;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(-156, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 78;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(1147, 1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 77;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txbAccount.Location = new System.Drawing.Point(12, 77);
		this.txbAccount.Name = "txbAccount";
		this.txbAccount.Size = new System.Drawing.Size(1147, 277);
		this.txbAccount.TabIndex = 48;
		this.txbAccount.Text = "";
		this.txbAccount.WordWrap = false;
		this.txbAccount.TextChanged += new System.EventHandler(txbAccount_TextChanged);
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
		this.bunifuCards1.Size = new System.Drawing.Size(1179, 37);
		this.bunifuCards1.TabIndex = 49;
		this.ctmsAcc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.toolStripMenuItem_0, this.toolStripMenuItem2, this.toolStripMenuItem_5, this.toolStripMenuItem_6, this.toolStripMenuItem_7 });
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(179, 114);
		this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3, this.toolStripMenuItem_4 });
		this.toolStripMenuItem_0.Name = "chọnToolStripMenuItem1";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(178, 22);
		this.toolStripMenuItem_0.Text = "Chọn";
		this.toolStripMenuItem_1.Name = "tấtCảToolStripMenuItem1";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(143, 22);
		this.toolStripMenuItem_1.Text = "Tất cả";
		this.toolStripMenuItem_2.Name = "bôiĐenToolStripMenuItem1";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(143, 22);
		this.toolStripMenuItem_2.Text = "Bôi đen";
		this.toolStripMenuItem_3.Name = "tàiKhoản0ToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(143, 22);
		this.toolStripMenuItem_3.Text = "Tài khoản=0";
		this.toolStripMenuItem_4.Name = "tàiKhoản1ToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(143, 22);
		this.toolStripMenuItem_4.Text = "Tài khoản=1";
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
		this.toolStripMenuItem2.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_5.Name = "tạoThiếtBịToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(178, 22);
		this.toolStripMenuItem_5.Text = "Tạo thiết bị";
		this.toolStripMenuItem_6.Name = "xóaThiếtBịToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(178, 22);
		this.toolStripMenuItem_6.Text = "Xóa thiết bị";
		this.toolStripMenuItem_7.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(178, 22);
		this.toolStripMenuItem_7.Text = "Làm mới danh sa\u0301ch";
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label3.Location = new System.Drawing.Point(758, 58);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(87, 16);
		this.label3.TabIndex = 55;
		this.label3.Text = "Tha\u0300nh công:";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblSuccess.AutoSize = true;
		this.lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		this.lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.lblSuccess.Location = new System.Drawing.Point(841, 55);
		this.lblSuccess.Name = "lblSuccess";
		this.lblSuccess.Size = new System.Drawing.Size(19, 19);
		this.lblSuccess.TabIndex = 50;
		this.lblSuccess.Text = "0";
		this.lblError.AutoSize = true;
		this.lblError.BackColor = System.Drawing.SystemColors.Control;
		this.lblError.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblError.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.lblError.Location = new System.Drawing.Point(964, 55);
		this.lblError.Name = "lblError";
		this.lblError.Size = new System.Drawing.Size(19, 19);
		this.lblError.TabIndex = 51;
		this.lblError.Text = "0";
		this.lblTotal.AutoSize = true;
		this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
		this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotal.ForeColor = System.Drawing.Color.Teal;
		this.lblTotal.Location = new System.Drawing.Point(1124, 56);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(19, 19);
		this.lblTotal.TabIndex = 53;
		this.lblTotal.Text = "0";
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label4.Location = new System.Drawing.Point(915, 58);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(52, 16);
		this.label4.TabIndex = 56;
		this.label4.Text = "Lỗi:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(1064, 58);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(63, 16);
		this.label7.TabIndex = 59;
		this.label7.Text = "Tô\u0309ng sô\u0301:";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatus.Location = new System.Drawing.Point(12, 44);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(227, 28);
		this.lblStatus.TabIndex = 60;
		this.lblStatus.Text = "Nhập thông tin tài khoản:";
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plDinhDangNhap.Controls.Add(this.label16);
		this.plDinhDangNhap.Controls.Add(this.label15);
		this.plDinhDangNhap.Controls.Add(this.label5);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang12);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang11);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang9);
		this.plDinhDangNhap.Controls.Add(this.cbbTypeProxy);
		this.plDinhDangNhap.Controls.Add(this.label2);
		this.plDinhDangNhap.Controls.Add(this.label1);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang1);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang2);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang3);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang4);
		this.plDinhDangNhap.Controls.Add(this.label14);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang5);
		this.plDinhDangNhap.Controls.Add(this.label6);
		this.plDinhDangNhap.Controls.Add(this.label17);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang10);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang8);
		this.plDinhDangNhap.Controls.Add(this.label13);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang6);
		this.plDinhDangNhap.Controls.Add(this.label12);
		this.plDinhDangNhap.Controls.Add(this.cbbDinhDang7);
		this.plDinhDangNhap.Controls.Add(this.label11);
		this.plDinhDangNhap.Controls.Add(this.label9);
		this.plDinhDangNhap.Controls.Add(this.label10);
		this.plDinhDangNhap.Location = new System.Drawing.Point(12, 392);
		this.plDinhDangNhap.Name = "plDinhDangNhap";
		this.plDinhDangNhap.Size = new System.Drawing.Size(1157, 62);
		this.plDinhDangNhap.TabIndex = 61;
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label15.Location = new System.Drawing.Point(961, 6);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(15, 19);
		this.label15.TabIndex = 128;
		this.label15.Text = "|";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label5.Location = new System.Drawing.Point(774, 4);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(15, 19);
		this.label5.TabIndex = 128;
		this.label5.Text = "|";
		this.cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang11.FormattingEnabled = true;
		this.cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang11.Location = new System.Drawing.Point(976, 6);
		this.cbbDinhDang11.Name = "cbbDinhDang11";
		this.cbbDinhDang11.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang11.TabIndex = 127;
		this.cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang9.FormattingEnabled = true;
		this.cbbDinhDang9.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang9.Location = new System.Drawing.Point(789, 4);
		this.cbbDinhDang9.Name = "cbbDinhDang9";
		this.cbbDinhDang9.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang9.TabIndex = 127;
		this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbTypeProxy.FormattingEnabled = true;
		this.cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		this.cbbTypeProxy.Location = new System.Drawing.Point(85, 33);
		this.cbbTypeProxy.Name = "cbbTypeProxy";
		this.cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
		this.cbbTypeProxy.TabIndex = 126;
		this.cbbTypeProxy.Visible = false;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(7, 36);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(70, 16);
		this.label2.TabIndex = 125;
		this.label2.Text = "Loại proxy:";
		this.label2.Visible = false;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label1.Location = new System.Drawing.Point(5, 3);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(39, 19);
		this.label1.TabIndex = 42;
		this.label1.Text = "Uid|";
		this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang1.FormattingEnabled = true;
		this.cbbDinhDang1.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang1.Location = new System.Drawing.Point(44, 3);
		this.cbbDinhDang1.Name = "cbbDinhDang1";
		this.cbbDinhDang1.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang1.TabIndex = 40;
		this.cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang2.Location = new System.Drawing.Point(137, 3);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang2.TabIndex = 40;
		this.cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang3.FormattingEnabled = true;
		this.cbbDinhDang3.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang3.Location = new System.Drawing.Point(230, 3);
		this.cbbDinhDang3.Name = "cbbDinhDang3";
		this.cbbDinhDang3.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang3.TabIndex = 40;
		this.cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang4.FormattingEnabled = true;
		this.cbbDinhDang4.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang4.Location = new System.Drawing.Point(323, 3);
		this.cbbDinhDang4.Name = "cbbDinhDang4";
		this.cbbDinhDang4.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang4.TabIndex = 40;
		this.cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label14.Location = new System.Drawing.Point(587, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(15, 19);
		this.label14.TabIndex = 41;
		this.label14.Text = "|";
		this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang5.FormattingEnabled = true;
		this.cbbDinhDang5.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang5.Location = new System.Drawing.Point(416, 3);
		this.cbbDinhDang5.Name = "cbbDinhDang5";
		this.cbbDinhDang5.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang5.TabIndex = 40;
		this.cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label6.Location = new System.Drawing.Point(867, 5);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(15, 19);
		this.label6.TabIndex = 41;
		this.label6.Text = "|";
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label17.Location = new System.Drawing.Point(680, 3);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(15, 19);
		this.label17.TabIndex = 41;
		this.label17.Text = "|";
		this.cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang10.FormattingEnabled = true;
		this.cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang10.Location = new System.Drawing.Point(882, 5);
		this.cbbDinhDang10.Name = "cbbDinhDang10";
		this.cbbDinhDang10.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang10.TabIndex = 40;
		this.cbbDinhDang10.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang8.FormattingEnabled = true;
		this.cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang8.Location = new System.Drawing.Point(695, 3);
		this.cbbDinhDang8.Name = "cbbDinhDang8";
		this.cbbDinhDang8.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang8.TabIndex = 40;
		this.cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label13.Location = new System.Drawing.Point(494, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(15, 19);
		this.label13.TabIndex = 41;
		this.label13.Text = "|";
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang6.Location = new System.Drawing.Point(509, 3);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang6.TabIndex = 40;
		this.cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label12.Location = new System.Drawing.Point(401, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(15, 19);
		this.label12.TabIndex = 41;
		this.label12.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang7.Location = new System.Drawing.Point(602, 3);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang7.TabIndex = 40;
		this.cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label11.Location = new System.Drawing.Point(308, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(15, 19);
		this.label11.TabIndex = 41;
		this.label11.Text = "|";
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label9.Location = new System.Drawing.Point(122, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(15, 19);
		this.label9.TabIndex = 41;
		this.label9.Text = "|";
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label10.Location = new System.Drawing.Point(215, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(15, 19);
		this.label10.TabIndex = 41;
		this.label10.Text = "|";
		this.cbbDinhDang12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang12.FormattingEnabled = true;
		this.cbbDinhDang12.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang12.Location = new System.Drawing.Point(1072, 7);
		this.cbbDinhDang12.Name = "cbbDinhDang12";
		this.cbbDinhDang12.Size = new System.Drawing.Size(78, 22);
		this.cbbDinhDang12.TabIndex = 127;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label16.Location = new System.Drawing.Point(1057, 7);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(15, 19);
		this.label16.TabIndex = 128;
		this.label16.Text = "|";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1179, 502);
		base.Controls.Add(this.plDinhDangNhap);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.lblSuccess);
		base.Controls.Add(this.lblError);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.txbAccount);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.cbbDinhDangNhap);
		base.Controls.Add(this.label8);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCapNhatDuLieu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Nhập tài khoản";
		base.Load += new System.EventHandler(fCapNhatDuLieu_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.ctmsAcc.ResumeLayout(false);
		this.plDinhDangNhap.ResumeLayout(false);
		this.plDinhDangNhap.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_4()
	{
		btnAdd.Enabled = false;
	}

	[CompilerGenerated]
	private void method_5()
	{
		btnAdd.Enabled = true;
	}
}
