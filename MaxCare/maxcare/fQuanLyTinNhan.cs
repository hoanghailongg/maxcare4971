using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fQuanLyTinNhan : Form
{
	[CompilerGenerated]
	private sealed class Class90
	{
		public GClass12 gclass12_0;

		public Control control_0;

		internal void method_0()
		{
			SetParent(gclass12_0.Process_0.MainWindowHandle, control_0.Handle);
			MoveWindow(gclass12_0.Process_0.MainWindowHandle, -10, 0, control_0.Size.Width + 20, control_0.Size.Height + 20, bool_0: false);
		}
	}

	[CompilerGenerated]
	private sealed class Class91
	{
		public string string_0;

		public fQuanLyTinNhan fQuanLyTinNhan_0;

		internal void method_0()
		{
			fQuanLyTinNhan_0.tabMain.TabPages.Remove(fQuanLyTinNhan_0.tabMain.TabPages[string_0]);
		}
	}

	[CompilerGenerated]
	private sealed class Class92
	{
		public int int_0;

		public List<int> list_0;

		public fQuanLyTinNhan fQuanLyTinNhan_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < list_0.Count && fQuanLyTinNhan_0.list_1.Count < int_0)
				{
					Class93 CS_0024_003C_003E8__locals0 = new Class93
					{
						class92_0 = this,
						int_0 = list_0[num++]
					};
					if (CS_0024_003C_003E8__locals0.int_0 != 0)
					{
						Thread.Sleep(fQuanLyTinNhan_0.random_0.Next(fQuanLyTinNhan_0.gclass17_0.method_2("nudDelayOpenChromeFrom"), fQuanLyTinNhan_0.gclass17_0.method_2("nudDelayOpenChromeTo") + 1) * 1000);
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							CS_0024_003C_003E8__locals0.class92_0.fQuanLyTinNhan_0.method_8(CS_0024_003C_003E8__locals0.int_0);
						}
						catch (Exception exception_2)
						{
							GClass14.smethod_75(null, exception_2);
						}
					})
					{
						Name = CS_0024_003C_003E8__locals0.int_0.ToString()
					};
					fQuanLyTinNhan_0.list_1.Add(thread);
					GClass14.smethod_58(1.0);
					thread.Start();
				}
				for (int i = 0; i < fQuanLyTinNhan_0.list_1.Count; i++)
				{
					fQuanLyTinNhan_0.list_1[i].Join();
				}
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class93
	{
		public int int_0;

		public Class92 class92_0;

		internal void method_0()
		{
			try
			{
				class92_0.fQuanLyTinNhan_0.method_8(int_0);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class94
	{
		public fQuanLyTinNhan fQuanLyTinNhan_0;

		public TabPage tabPage_0;

		internal void method_0()
		{
			fQuanLyTinNhan_0.tabMain.ItemSize = new Size(0, 1);
			fQuanLyTinNhan_0.tabMain.TabPages.Add(tabPage_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class95
	{
		public string string_0;

		public fQuanLyTinNhan fQuanLyTinNhan_0;

		public MethodInvoker methodInvoker_0;

		internal void method_0()
		{
			fQuanLyTinNhan_0.tabMain.TabPages.Remove(fQuanLyTinNhan_0.tabMain.TabPages[string_0]);
		}
	}

	private Random random_0 = new Random();

	private GClass17 gclass17_0 = new GClass17("configGeneral");

	private List<string> list_0 = new List<string>();

	private List<Thread> list_1 = null;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private ToolTip toolTip_0;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private TabControl tabMain;

	public DataGridView dgvTaiKhoan;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Panel panel2;

	private ToolStripMenuItem toolStripMenuItem_2;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewImageColumn cAvatar;

	private DataGridViewTextBoxColumn cTaiKhoan;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cPassword;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cGhiChu;

	private DataGridViewTextBoxColumn cId;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0);

	public fQuanLyTinNhan(List<string> list_2)
	{
		InitializeComponent();
		GClass14.smethod_32("avatar");
		list_0 = list_2;
		base.Width = Screen.PrimaryScreen.WorkingArea.Width;
		base.Height = Screen.PrimaryScreen.WorkingArea.Height;
	}

	public int method_0()
	{
		int result = 0;
		try
		{
			result = dgvTaiKhoan.SelectedRows.Count;
		}
		catch
		{
		}
		return result;
	}

	public void btnMinimize_Click(object sender, EventArgs e)
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

	public void method_1(int int_0, string string_0, object object_0, bool bool_0 = true)
	{
		if (bool_0 || !(object_0.ToString().Trim() == ""))
		{
			Class309.smethod_5(dgvTaiKhoan, int_0, string_0, object_0);
		}
	}

	public string method_2(int int_0, string string_0)
	{
		return Class309.smethod_3(dgvTaiKhoan, int_0, string_0);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void method_3()
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string[] array = list_0[i].Split('|');
			dgvTaiKhoan.Rows.Add(dgvTaiKhoan.RowCount + 1, Image.FromFile("images\\no_avatar.png"), array[0] + "\r\n" + array[5], array[0], array[1], array[2], array[3], array[4], array[6], array[7]);
		}
	}

	private void fQuanLyTinNhan_Load(object sender, EventArgs e)
	{
		method_3();
	}

	private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void method_4(GClass12 gclass12_0, Control control_0)
	{
		Invoke((MethodInvoker)delegate
		{
			SetParent(gclass12_0.Process_0.MainWindowHandle, control_0.Handle);
			MoveWindow(gclass12_0.Process_0.MainWindowHandle, -10, 0, control_0.Size.Width + 20, control_0.Size.Height + 20, bool_0: false);
		});
	}

	public int method_5(int int_0, string string_0, string string_1, string string_2, TabPage tabPage_0, string string_3 = "", string string_4 = "")
	{
		int result = 0;
		int num = 0;
		try
		{
			string text = string_0;
			if (string_0 == "")
			{
				string_0 = Regex.Match(string_3 + ";", "c_user=(.*?);").Groups[1].Value;
			}
			GClass12 gClass = null;
			bool flag = false;
			string text2 = "";
			if (string_0 != "")
			{
				text2 = gclass17_0.method_0("txbPathProfile") + "\\" + string_0;
				if (!Directory.Exists(text2))
				{
					text2 = "";
				}
			}
			gClass = new GClass12
			{
				Boolean_2 = false,
				Point_0 = new Point(300, 500),
				Point_1 = new Point(0, -1000),
				Int32_1 = 3,
				Int32_2 = 60,
				String_1 = text2,
				String_0 = Class49.string_7
			};
			if (string_4 != "")
			{
				int int32_ = 0;
				if (string_4.EndsWith("*1"))
				{
					int32_ = 1;
				}
				if (string_4.EndsWith("*0") || string_4.EndsWith("*1"))
				{
					string_4 = string_4.Substring(0, string_4.Length - 2);
				}
				gClass.String_2 = string_4;
				gClass.Int32_3 = int32_;
			}
			while (gClass.method_0())
			{
				gClass.method_20("document.title=\"proxyauth=" + string_4 + "\"");
				gClass.method_67(2.0);
				if (!gclass17_0.method_3("ckbKhongCheckIP") && string_4.Split(':').Length > 1)
				{
					gClass.method_13("https://api.myip.com/");
					gClass.method_67(1.0);
					string text3 = gClass.method_1();
					if (!text3.Contains("ip"))
					{
						gClass.method_58();
						num++;
						if (num >= 3)
						{
							break;
						}
						continue;
					}
				}
				gClass.method_69();
				method_4(gClass, tabPage_0);
				if (!(flag = GClass15.smethod_34(gClass, "https://m.facebook.com/") == 1))
				{
					if (text != "" && string_1 != "")
					{
						flag = GClass15.smethod_30(gClass, text, string_1, string_2, "https://m.facebook.com/", 2) == "1";
					}
					else if (string_3 != "")
					{
						flag = GClass15.smethod_25(gClass, string_3, "https://m.facebook.com/") == "1";
					}
				}
				if (!flag)
				{
					method_6(int_0, 1);
					string string_5 = dgvTaiKhoan.Rows[int_0].Cells[3].Value.ToString();
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[string_5]);
					});
					break;
				}
				method_6(int_0, 2);
				gClass.method_13("https://m.facebook.com/");
				Class32.smethod_11(string_0, "avatar");
				if (File.Exists("avatar\\" + string_0 + ".png"))
				{
					dgvTaiKhoan.Rows[int_0].Cells[1].Value = Image.FromFile("avatar\\" + string_0 + ".png");
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	private void method_6(int int_0, int int_1)
	{
		switch (int_1)
		{
		case 1:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		case 2:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 3:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
			break;
		}
	}

	private void method_7(string string_0, string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] buffer = webClient.DownloadData(string_0);
			using MemoryStream stream = new MemoryStream(buffer);
			using Image image = Image.FromStream(stream);
			try
			{
				image.Save(string_1 + ".png", ImageFormat.Png);
			}
			catch
			{
				image.Save(string_1 + ".jpg", ImageFormat.Jpeg);
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		try
		{
			list_1 = new List<Thread>();
			List<int> list_0 = new List<int>();
			foreach (DataGridViewRow selectedRow in dgvTaiKhoan.SelectedRows)
			{
				list_0.Add(selectedRow.Index);
			}
			int int_0 = list_0.Count;
			new Thread((ThreadStart)delegate
			{
				try
				{
					int num = 0;
					while (num < list_0.Count && list_1.Count < int_0)
					{
						int int_ = list_0[num++];
						if (int_ != 0)
						{
							Thread.Sleep(random_0.Next(gclass17_0.method_2("nudDelayOpenChromeFrom"), gclass17_0.method_2("nudDelayOpenChromeTo") + 1) * 1000);
						}
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								method_8(int_);
							}
							catch (Exception exception_3)
							{
								GClass14.smethod_75(null, exception_3);
							}
						})
						{
							Name = int_.ToString()
						};
						list_1.Add(thread);
						GClass14.smethod_58(1.0);
						thread.Start();
					}
					for (int i = 0; i < list_1.Count; i++)
					{
						list_1[i].Join();
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

	private void method_8(int int_0)
	{
		int num = 0;
		string string_ = dgvTaiKhoan.Rows[int_0].Cells[6].Value.ToString();
		string text = dgvTaiKhoan.Rows[int_0].Cells[3].Value.ToString();
		string string_2 = dgvTaiKhoan.Rows[int_0].Cells[4].Value.ToString();
		string string_3 = dgvTaiKhoan.Rows[int_0].Cells[5].Value.ToString();
		string string_4 = dgvTaiKhoan.Rows[int_0].Cells[7].Value.ToString();
		TabPage tabPage_0 = new TabPage();
		tabPage_0.Name = text;
		tabPage_0.Text = text;
		tabPage_0.BackColor = Color.White;
		tabPage_0.ForeColor = Color.White;
		for (int i = 0; i < tabMain.TabPages.Count; i++)
		{
			if (tabMain.TabPages[i].Name.ToString() == tabPage_0.Name)
			{
				num++;
				break;
			}
		}
		if (num == 0)
		{
			tabMain.Invoke((MethodInvoker)delegate
			{
				tabMain.ItemSize = new Size(0, 1);
				tabMain.TabPages.Add(tabPage_0);
			});
			method_5(int_0, text, string_2, string_3, tabPage_0, string_, string_4);
		}
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		try
		{
			string string_0 = "";
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				string_0 = dgvTaiKhoan.SelectedRows[i].Cells[3].Value.ToString();
				if (tabMain.TabPages.Contains(tabMain.TabPages[string_0]))
				{
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[string_0]);
					});
					method_6(dgvTaiKhoan.SelectedRows[i].Index, 3);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		string text = dgvTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
		int num = 0;
		while (true)
		{
			if (num < tabMain.TabPages.Count)
			{
				if (tabMain.TabPages[num].Name.ToString() == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		tabMain.SelectedTab = tabMain.TabPages[text];
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_9("Notes");
	}

	private void method_9(string string_0)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				list.Add(method_2(dgvTaiKhoan.SelectedRows[i].Index, "cId"));
			}
			if (list.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n câ\u0323p nhâ\u0323t!"), 3);
			}
			else
			{
				GClass14.smethod_33(new fUpdateData(this, string_0));
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.tabMain = new System.Windows.Forms.TabControl();
		this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAvatar = new System.Windows.Forms.DataGridViewImageColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.panel1.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
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
		this.pnlHeader.Size = new System.Drawing.Size(1080, 29);
		this.pnlHeader.TabIndex = 0;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(6, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_14;
		this.button2.Location = new System.Drawing.Point(984, 0);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(32, 29);
		this.button2.TabIndex = 0;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Dock = System.Windows.Forms.DockStyle.Right;
		this.button1.Enabled = false;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Class306.Bitmap_13;
		this.button1.Location = new System.Drawing.Point(1016, 0);
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
		this.btnMinimize.Image = Class306.Bitmap_12;
		this.btnMinimize.Location = new System.Drawing.Point(1048, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(178, 16);
		this.bunifuCustomLabel1.TabIndex = 3;
		this.bunifuCustomLabel1.Text = "Quản lý tin nhắn hàng loạt";
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 30000;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 40;
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, -1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1081, 38);
		this.bunifuCards1.TabIndex = 0;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.dgvTaiKhoan);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1082, 565);
		this.panel1.TabIndex = 8;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.tabMain);
		this.panel2.Location = new System.Drawing.Point(7, 39);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(693, 519);
		this.panel2.TabIndex = 8;
		this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		this.tabMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tabMain.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tabMain.Location = new System.Drawing.Point(0, 0);
		this.tabMain.Multiline = true;
		this.tabMain.Name = "tabMain";
		this.tabMain.SelectedIndex = 0;
		this.tabMain.Size = new System.Drawing.Size(693, 518);
		this.tabMain.TabIndex = 7;
		this.dgvTaiKhoan.AllowUserToAddRows = false;
		this.dgvTaiKhoan.AllowUserToDeleteRows = false;
		this.dgvTaiKhoan.AllowUserToResizeColumns = false;
		this.dgvTaiKhoan.AllowUserToResizeRows = false;
		this.dgvTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvTaiKhoan.Columns.AddRange(this.cStt, this.cAvatar, this.cTaiKhoan, this.cUid, this.cPassword, this.cFa2, this.cCookies, this.cProxy, this.cGhiChu, this.cId);
		this.dgvTaiKhoan.ContextMenuStrip = this.contextMenuStrip1;
		this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
		this.dgvTaiKhoan.Location = new System.Drawing.Point(706, 39);
		this.dgvTaiKhoan.Name = "dgvTaiKhoan";
		this.dgvTaiKhoan.ReadOnly = true;
		this.dgvTaiKhoan.RowHeadersVisible = false;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.dgvTaiKhoan.RowTemplate.Height = 50;
		this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvTaiKhoan.Size = new System.Drawing.Size(369, 519);
		this.dgvTaiKhoan.TabIndex = 6;
		this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTaiKhoan_CellClick);
		this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTaiKhoan_CellContentClick);
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(165, 70);
		this.toolStripMenuItem_0.Image = Class306.Bitmap_165;
		this.toolStripMenuItem_0.Name = "hiểnThịToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_0.Text = "Mở trình duyệt";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.toolStripMenuItem_1.Image = Class306.Bitmap_209;
		this.toolStripMenuItem_1.Name = "đóngToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_1.Text = "Đóng trình duyệt";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.toolStripMenuItem_2.Image = Class306.Bitmap_108;
		this.toolStripMenuItem_2.Name = "sửaGhiChúToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_2.Text = "Sửa ghi chú";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.cGhiChu.HeaderText = "Ghi chú";
		this.cGhiChu.Name = "cGhiChu";
		this.cGhiChu.ReadOnly = true;
		this.cProxy.HeaderText = "Proxy";
		this.cProxy.Name = "cProxy";
		this.cProxy.ReadOnly = true;
		this.cProxy.Visible = false;
		this.cCookies.HeaderText = "Cookie";
		this.cCookies.Name = "cCookies";
		this.cCookies.ReadOnly = true;
		this.cCookies.Visible = false;
		this.cFa2.HeaderText = "2fa";
		this.cFa2.Name = "cFa2";
		this.cFa2.ReadOnly = true;
		this.cFa2.Visible = false;
		this.cPassword.HeaderText = "Password";
		this.cPassword.Name = "cPassword";
		this.cPassword.ReadOnly = true;
		this.cPassword.Visible = false;
		this.cUid.HeaderText = "Uid";
		this.cUid.Name = "cUid";
		this.cUid.ReadOnly = true;
		this.cUid.Visible = false;
		this.cTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.cTaiKhoan.DefaultCellStyle = dataGridViewCellStyle4;
		this.cTaiKhoan.HeaderText = "Tài khoản";
		this.cTaiKhoan.Name = "cTaiKhoan";
		this.cTaiKhoan.ReadOnly = true;
		this.cTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cAvatar.FillWeight = 50f;
		this.cAvatar.HeaderText = "Avatar";
		this.cAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
		this.cAvatar.Name = "cAvatar";
		this.cAvatar.ReadOnly = true;
		this.cAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cAvatar.Width = 70;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cStt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cStt.Width = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1082, 565);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fQuanLyTinNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Quản lý tin nhắn";
		base.Load += new System.EventHandler(fQuanLyTinNhan_Load);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
