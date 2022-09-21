using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCopy : Form
{
	private List<ComboBox> list_0;

	private List<string> list_1 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private Label label1;

	private BunifuDragControl bunifuDragControl_0;

	private ComboBox cbbDinhDang1;

	private ComboBox cbbDinhDang2;

	private ComboBox cbbDinhDang3;

	private ComboBox cbbDinhDang4;

	private Label label14;

	private ComboBox cbbDinhDang5;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label12;

	private ComboBox cbbDinhDang7;

	private Label label11;

	private Label label9;

	private Label label10;

	private ComboBox cbbDinhDang9;

	private ComboBox cbbDinhDang8;

	private Label label2;

	private Label label3;

	private Button button1;

	public fCopy(List<string> list_2)
	{
		InitializeComponent();
		list_1 = list_2;
		method_0();
		list_0 = new List<ComboBox> { cbbDinhDang1, cbbDinhDang2, cbbDinhDang3, cbbDinhDang4, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, cbbDinhDang9 };
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(button1);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void method_1()
	{
		try
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			File.WriteAllText("settings\\format_copy.txt", text);
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			if (File.Exists("settings\\format_copy.txt"))
			{
				string text = File.ReadAllText("settings\\format_copy.txt");
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

	private void method_3()
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

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			string text = "";
			int num = 0;
			int num2 = list_0.Count - 1;
			while (num2 >= 0)
			{
				if (list_0[num2].SelectedIndex == -1)
				{
					num2--;
					continue;
				}
				num = num2 + 1;
				break;
			}
			if (num == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng câ\u0300n copy!"), 3);
				return;
			}
			method_1();
			int num3 = 0;
			for (int i = 0; i < list_1.Count; i++)
			{
				text = "";
				string[] array = list_1[i].Split('|');
				for (int j = 0; j < list_0.Count; j++)
				{
					if (list_0[j].SelectedIndex != -1)
					{
						text += array[list_0[j].SelectedIndex];
					}
					text += "|";
				}
				text = text.TrimEnd('|');
				for (num3 = text.Split('|').Count(); num3 < num; num3++)
				{
					text += "|";
				}
				list.Add(text);
			}
			string text2 = string.Join("\r\n", list);
			Clipboard.SetText(text2);
			GClass38.smethod_0(GClass29.smethod_0("Copy tha\u0300nh công!"));
			Close();
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_3();
	}

	private void fCopy_Load(object sender, EventArgs e)
	{
		method_2();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCopy_1));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.cbbDinhDang9 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1037, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1037, 32);
		this.pnlHeader.TabIndex = 9;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(1005, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1037, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Tu\u0300y cho\u0323n đi\u0323nh da\u0323ng sao che\u0301p";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(575, 120);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(467, 120);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(20, 66);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(132, 16);
		this.label1.TabIndex = 20;
		this.label1.Text = "Cho\u0323n đi\u0323nh da\u0323ng copy:";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang1.FormattingEnabled = true;
		this.cbbDinhDang1.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang1.Location = new System.Drawing.Point(158, 65);
		this.cbbDinhDang1.Name = "cbbDinhDang1";
		this.cbbDinhDang1.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang1.TabIndex = 42;
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang2.Location = new System.Drawing.Point(255, 65);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang2.TabIndex = 43;
		this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang3.FormattingEnabled = true;
		this.cbbDinhDang3.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang3.Location = new System.Drawing.Point(352, 65);
		this.cbbDinhDang3.Name = "cbbDinhDang3";
		this.cbbDinhDang3.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang3.TabIndex = 44;
		this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang4.FormattingEnabled = true;
		this.cbbDinhDang4.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang4.Location = new System.Drawing.Point(449, 65);
		this.cbbDinhDang4.Name = "cbbDinhDang4";
		this.cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang4.TabIndex = 45;
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(721, 67);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(19, 19);
		this.label14.TabIndex = 49;
		this.label14.Text = "|";
		this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang5.FormattingEnabled = true;
		this.cbbDinhDang5.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang5.Location = new System.Drawing.Point(546, 65);
		this.cbbDinhDang5.Name = "cbbDinhDang5";
		this.cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang5.TabIndex = 46;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.Location = new System.Drawing.Point(624, 67);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(19, 19);
		this.label13.TabIndex = 50;
		this.label13.Text = "|";
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang6.Location = new System.Drawing.Point(643, 65);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang6.TabIndex = 47;
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.Location = new System.Drawing.Point(527, 67);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(19, 19);
		this.label12.TabIndex = 51;
		this.label12.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang7.Location = new System.Drawing.Point(740, 65);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang7.TabIndex = 48;
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.Location = new System.Drawing.Point(430, 67);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(19, 19);
		this.label11.TabIndex = 52;
		this.label11.Text = "|";
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(236, 67);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(19, 19);
		this.label9.TabIndex = 53;
		this.label9.Text = "|";
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(333, 67);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(19, 19);
		this.label10.TabIndex = 54;
		this.label10.Text = "|";
		this.cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang9.FormattingEnabled = true;
		this.cbbDinhDang9.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang9.Location = new System.Drawing.Point(934, 65);
		this.cbbDinhDang9.Name = "cbbDinhDang9";
		this.cbbDinhDang9.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang9.TabIndex = 48;
		this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang8.FormattingEnabled = true;
		this.cbbDinhDang8.Items.AddRange(new object[17]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
			"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú"
		});
		this.cbbDinhDang8.Location = new System.Drawing.Point(837, 65);
		this.cbbDinhDang8.Name = "cbbDinhDang8";
		this.cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang8.TabIndex = 47;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(818, 67);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(19, 19);
		this.label2.TabIndex = 50;
		this.label2.Text = "|";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(915, 67);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(19, 19);
		this.label3.TabIndex = 49;
		this.label3.Text = "|";
		this.button1.BackColor = System.Drawing.Color.DarkOrange;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Location = new System.Drawing.Point(330, 120);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(121, 29);
		this.button1.TabIndex = 4;
		this.button1.Text = "Reset định dạng";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1037, 165);
		base.Controls.Add(this.cbbDinhDang1);
		base.Controls.Add(this.cbbDinhDang2);
		base.Controls.Add(this.cbbDinhDang3);
		base.Controls.Add(this.cbbDinhDang4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.cbbDinhDang5);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.cbbDinhDang8);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.cbbDinhDang6);
		base.Controls.Add(this.cbbDinhDang9);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.cbbDinhDang7);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCopy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCopy_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
