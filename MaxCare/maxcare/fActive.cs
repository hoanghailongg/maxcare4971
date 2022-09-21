using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fActive : Form
{
	[CompilerGenerated]
	private sealed class Class208
	{
		public fActive fActive_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public MethodInvoker methodInvoker_0;

		public MethodInvoker methodInvoker_1;

		public MethodInvoker methodInvoker_2;

		public MethodInvoker methodInvoker_3;

		public MethodInvoker methodInvoker_4;

		public MethodInvoker methodInvoker_5;

		public MethodInvoker methodInvoker_6;

		public MethodInvoker methodInvoker_7;

		public MethodInvoker methodInvoker_8;

		public MethodInvoker methodInvoker_9;

		public MethodInvoker methodInvoker_10;

		public MethodInvoker methodInvoker_11;

		public MethodInvoker methodInvoker_12;

		public MethodInvoker methodInvoker_13;

		internal void method_0()
		{
			fActive_0.lblStatus.Text = GClass29.smethod_0("Email bạn nhập không đúng đi\u0323nh da\u0323ng!");
		}

		internal void method_1()
		{
			fActive_0.btnLogin.Invoke((MethodInvoker)delegate
			{
				fActive_0.btnLogin.Enabled = false;
			});
			fActive_0.lblStatus.Invoke((MethodInvoker)delegate
			{
				fActive_0.lblStatus.Text = GClass29.smethod_0("Đang kiểm tra đăng nhập...");
			});
			try
			{
				new GClass5();
				GClass14.smethod_2();
				new GClass18();
				new GClass4();
				new Random();
				string text = GClass14.smethod_0(string_0, string_1, string_2);
				if (text.Trim() == "")
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = fActive_0.method_2(4);
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				string text2 = GClass14.smethod_3(string_0, text, 11.ToString());
				if (text2.Contains("chuakichhoat"))
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = fActive_0.method_2(2);
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Contains("error"))
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = fActive_0.method_2(5);
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Contains("hethan"))
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = fActive_0.method_2(3);
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Split('|').Length < 3)
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = GClass29.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				fActive_0.lblStatus.Invoke((MethodInvoker)delegate
				{
					fActive_0.lblStatus.Text = GClass29.smethod_0("Đăng nhập thành công!");
				});
				GClass38.smethod_0(GClass29.smethod_0("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + GClass29.smethod_0("Vui lòng mở lại phần mềm để sử dụng!"));
				fActive_0.gclass17_0.method_5("UserName", string_1);
				fActive_0.gclass17_0.method_5("PassWord", string_2);
				fActive_0.gclass17_0.method_5("Domain", string_0);
				fActive_0.gclass17_0.method_8();
				Environment.Exit(0);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_, "Active error");
				GClass38.smethod_0("Lỗi không xác định!!!", 2);
			}
			fActive_0.btnLogin.Invoke((MethodInvoker)delegate
			{
				fActive_0.btnLogin.Enabled = true;
			});
		}

		internal void method_2()
		{
			fActive_0.btnLogin.Enabled = false;
		}

		internal void method_3()
		{
			fActive_0.lblStatus.Text = GClass29.smethod_0("Đang kiểm tra đăng nhập...");
		}

		internal void method_4()
		{
			fActive_0.lblStatus.Text = fActive_0.method_2(4);
		}

		internal void method_5()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_6()
		{
			fActive_0.lblStatus.Text = fActive_0.method_2(2);
		}

		internal void method_7()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_8()
		{
			fActive_0.lblStatus.Text = fActive_0.method_2(5);
		}

		internal void method_9()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_10()
		{
			fActive_0.lblStatus.Text = fActive_0.method_2(3);
		}

		internal void method_11()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_12()
		{
			fActive_0.lblStatus.Text = GClass29.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
		}

		internal void method_13()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_14()
		{
			fActive_0.lblStatus.Text = GClass29.smethod_0("Đăng nhập thành công!");
		}

		internal void method_15()
		{
			fActive_0.btnLogin.Enabled = true;
		}
	}

	private int int_0 = 0;

	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private BunifuMetroTextbox txbUserName;

	private BunifuCustomLabel bunifuCustomLabel2;

	private BunifuCustomLabel bunifuCustomLabel3;

	private BunifuMetroTextbox txbPassword;

	private Button btnLogin;

	private Label lblStatus;

	private LinkLabel linkLabel1;

	private Label label1;

	private Button btnMinimize;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox2;

	private BunifuCustomLabel bunifuCustomLabel8;

	private BunifuCustomLabel bunifuCustomLabel6;

	private BunifuCustomLabel bunifuCustomLabel4;

	private BunifuCustomLabel lblKey;

	private BunifuCustomLabel bunifuCustomLabel7;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCustomLabel bunifuCustomLabel5;

	private BunifuCustomLabel lblServer;

	private ComboBox cbbServer;

	public fActive(int int_1, string string_0)
	{
		InitializeComponent();
		gclass17_0 = new GClass17("settingLogin");
		int_0 = int_1;
		lblStatus.Text = method_2(int_1);
		if (string_0 == "")
		{
			string_0 = GClass14.smethod_2();
		}
		lblKey.Text = string_0;
		method_1();
		method_0();
		if (gclass17_0.method_0("Domain") == "https://hocvienkinhdoanh.minsoftware.vn/")
		{
			cbbServer.SelectedIndex = 1;
			string value = ((KeyValuePair<string, string>)cbbServer.SelectedItem).Value;
			bunifuCustomLabel1.Text = "MAX CARE - " + value;
		}
		else
		{
			cbbServer.SelectedIndex = 0;
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "http://app.minsoftware.xyz/", "Minsoftware" },
			{ "https://hocvienkinhdoanh.minsoftware.vn/", "Hocvienkinhdoanh" }
		};
		cbbServer.DataSource = new BindingSource(dataSource, null);
		cbbServer.ValueMember = "Key";
		cbbServer.DisplayMember = "Value";
	}

	private void method_1()
	{
		GClass29.smethod_1(this);
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(bunifuCustomLabel3);
		GClass29.smethod_1(btnLogin);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(linkLabel1);
		GClass29.smethod_1(bunifuCustomLabel7);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private string method_2(int int_1 = 0)
	{
		return int_1 switch
		{
			0 => "", 
			1 => GClass29.smethod_0("Vui lòng đăng nhập để sử dụng phần mềm!!!"), 
			2 => GClass29.smethod_0("Thiết bị của bạn chưa được kích hoạt!!!"), 
			3 => GClass29.smethod_0("Thiết bị của bạn đã hết hạn sử dụng!!!"), 
			4 => GClass29.smethod_0("Tài khoản hoặc mật khẩu bạn nhập không đúng!!!"), 
			_ => GClass29.smethod_0("Lỗi không xác định!!!"), 
		};
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		string string_1 = txbUserName.Text.Trim();
		string string_2 = txbPassword.Text.Trim();
		string string_0 = cbbServer.SelectedValue.ToString();
		if (string_1 == "" || string_2 == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng điền đầy đủ thông tin!"), 3);
			return;
		}
		if (!GClass22.smethod_13(txbUserName.Text))
		{
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Text = GClass29.smethod_0("Email bạn nhập không đúng đi\u0323nh da\u0323ng!");
			});
			return;
		}
		new Thread((ThreadStart)delegate
		{
			btnLogin.Invoke((MethodInvoker)delegate
			{
				btnLogin.Enabled = false;
			});
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Text = GClass29.smethod_0("Đang kiểm tra đăng nhập...");
			});
			try
			{
				new GClass5();
				GClass14.smethod_2();
				new GClass18();
				new GClass4();
				new Random();
				string text = GClass14.smethod_0(string_0, string_1, string_2);
				if (text.Trim() == "")
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = method_2(4);
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				string text2 = GClass14.smethod_3(string_0, text, 11.ToString());
				if (text2.Contains("chuakichhoat"))
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = method_2(2);
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Contains("error"))
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = method_2(5);
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Contains("hethan"))
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = method_2(3);
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				if (text2.Split('|').Length < 3)
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = GClass29.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				lblStatus.Invoke((MethodInvoker)delegate
				{
					lblStatus.Text = GClass29.smethod_0("Đăng nhập thành công!");
				});
				GClass38.smethod_0(GClass29.smethod_0("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + GClass29.smethod_0("Vui lòng mở lại phần mềm để sử dụng!"));
				gclass17_0.method_5("UserName", string_1);
				gclass17_0.method_5("PassWord", string_2);
				gclass17_0.method_5("Domain", string_0);
				gclass17_0.method_8();
				Environment.Exit(0);
			}
			catch (Exception exception_)
			{
				GClass14.smethod_75(null, exception_, "Active error");
				GClass38.smethod_0("Lỗi không xác định!!!", 2);
			}
			btnLogin.Invoke((MethodInvoker)delegate
			{
				btnLogin.Enabled = true;
			});
		}).Start();
	}

	private void fActive_FormClosing(object sender, FormClosingEventArgs e)
	{
		Environment.Exit(0);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://app.minsoftware.vn/signup");
		}
		catch
		{
			Process.Start("https://app.minsoftware.vn/signup");
		}
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(lblKey.Text);
		GClass38.smethod_0(GClass29.smethod_0("Đã copy mã thiết bị!"));
	}

	private void txbPassword_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnLogin_Click(null, null);
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if (!lblServer.Visible)
		{
			lblServer.Visible = true;
			cbbServer.Visible = true;
			base.Height = 320;
		}
		else
		{
			lblServer.Visible = false;
			cbbServer.Visible = false;
			base.Height = 275;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fActive));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.txbUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
		this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.txbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
		this.btnLogin = new System.Windows.Forms.Button();
		this.lblStatus = new System.Windows.Forms.Label();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.lblKey = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.lblServer = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.cbbServer = new System.Windows.Forms.ComboBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(395, 38);
		this.bunifuCards1.TabIndex = 11;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(393, 32);
		this.pnlHeader.TabIndex = 9;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(361, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 13;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(6, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 7);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(221, 16);
		this.bunifuCustomLabel1.TabIndex = 7;
		this.bunifuCustomLabel1.Text = "MAX CARE - Kích hoạt bản quyền";
		this.txbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.txbUserName.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbUserName.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbUserName.BorderThickness = 3;
		this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txbUserName.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbUserName.isPassword = false;
		this.txbUserName.Location = new System.Drawing.Point(117, 46);
		this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
		this.txbUserName.Name = "txbUserName";
		this.txbUserName.Size = new System.Drawing.Size(228, 29);
		this.txbUserName.TabIndex = 0;
		this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(txbPassword_KeyDown);
		this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.bunifuCustomLabel2.AutoSize = true;
		this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 52);
		this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		this.bunifuCustomLabel2.Size = new System.Drawing.Size(44, 16);
		this.bunifuCustomLabel2.TabIndex = 13;
		this.bunifuCustomLabel2.Text = "Email:";
		this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.bunifuCustomLabel3.AutoSize = true;
		this.bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 91);
		this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 16);
		this.bunifuCustomLabel3.TabIndex = 15;
		this.bunifuCustomLabel3.Text = "Mật khẩu:";
		this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.txbPassword.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbPassword.BorderThickness = 3;
		this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txbPassword.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbPassword.isPassword = true;
		this.txbPassword.Location = new System.Drawing.Point(117, 83);
		this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
		this.txbPassword.Name = "txbPassword";
		this.txbPassword.Size = new System.Drawing.Size(228, 29);
		this.txbPassword.TabIndex = 1;
		this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(txbPassword_KeyDown);
		this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnLogin.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnLogin.FlatAppearance.BorderSize = 0;
		this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnLogin.ForeColor = System.Drawing.Color.White;
		this.btnLogin.Location = new System.Drawing.Point(149, 136);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new System.Drawing.Size(115, 29);
		this.btnLogin.TabIndex = 2;
		this.btnLogin.Text = "Đăng nhập";
		this.btnLogin.UseVisualStyleBackColor = false;
		this.btnLogin.Click += new System.EventHandler(btnLogin_Click);
		this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ForeColor = System.Drawing.Color.Red;
		this.lblStatus.Location = new System.Drawing.Point(10, 115);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(371, 18);
		this.lblStatus.TabIndex = 28;
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.linkLabel1.Location = new System.Drawing.Point(274, 172);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(25, 13);
		this.linkLabel1.TabIndex = 3;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "đây";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(118, 172);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(157, 13);
		this.label1.TabIndex = 30;
		this.label1.Text = "Đăng ký tài khoản mới bấm vào";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		this.pictureBox2.Location = new System.Drawing.Point(357, 247);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(20, 20);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 42;
		this.pictureBox2.TabStop = false;
		this.pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
		this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel8.AutoSize = true;
		this.bunifuCustomLabel8.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
		this.bunifuCustomLabel8.Location = new System.Drawing.Point(78, 229);
		this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
		this.bunifuCustomLabel8.Size = new System.Drawing.Size(140, 13);
		this.bunifuCustomLabel8.TabIndex = 40;
		this.bunifuCustomLabel8.Text = "https://minsoftware.vn";
		this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel6.AutoSize = true;
		this.bunifuCustomLabel6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel6.Location = new System.Drawing.Point(22, 229);
		this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
		this.bunifuCustomLabel6.Size = new System.Drawing.Size(56, 13);
		this.bunifuCustomLabel6.TabIndex = 38;
		this.bunifuCustomLabel6.Text = "Website:";
		this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel4.AutoSize = true;
		this.bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 205);
		this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		this.bunifuCustomLabel4.Size = new System.Drawing.Size(53, 13);
		this.bunifuCustomLabel4.TabIndex = 39;
		this.bunifuCustomLabel4.Text = "Hotline: ";
		this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.lblKey.AutoSize = true;
		this.lblKey.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblKey.ForeColor = System.Drawing.Color.Gray;
		this.lblKey.Location = new System.Drawing.Point(94, 252);
		this.lblKey.Name = "lblKey";
		this.lblKey.Size = new System.Drawing.Size(231, 13);
		this.lblKey.TabIndex = 37;
		this.lblKey.Text = "********************************";
		this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel7.AutoSize = true;
		this.bunifuCustomLabel7.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel7.Location = new System.Drawing.Point(22, 252);
		this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
		this.bunifuCustomLabel7.Size = new System.Drawing.Size(70, 13);
		this.bunifuCustomLabel7.TabIndex = 36;
		this.bunifuCustomLabel7.Text = "Mã thiết bị:";
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel5.AutoSize = true;
		this.bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
		this.bunifuCustomLabel5.Location = new System.Drawing.Point(73, 205);
		this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
		this.bunifuCustomLabel5.Size = new System.Drawing.Size(257, 13);
		this.bunifuCustomLabel5.TabIndex = 41;
		this.bunifuCustomLabel5.Text = "0969.078.803 - 0966.260.829 - 0973.363.129";
		this.lblServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.lblServer.AutoSize = true;
		this.lblServer.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblServer.Location = new System.Drawing.Point(37, 125);
		this.lblServer.Name = "lblServer";
		this.lblServer.Size = new System.Drawing.Size(56, 16);
		this.lblServer.TabIndex = 43;
		this.lblServer.Text = "Server:";
		this.lblServer.Visible = false;
		this.cbbServer.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbServer.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbServer.FormattingEnabled = true;
		this.cbbServer.Location = new System.Drawing.Point(120, 122);
		this.cbbServer.Name = "cbbServer";
		this.cbbServer.Size = new System.Drawing.Size(224, 24);
		this.cbbServer.TabIndex = 44;
		this.cbbServer.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(393, 277);
		base.Controls.Add(this.cbbServer);
		base.Controls.Add(this.lblServer);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.bunifuCustomLabel8);
		base.Controls.Add(this.bunifuCustomLabel5);
		base.Controls.Add(this.bunifuCustomLabel6);
		base.Controls.Add(this.bunifuCustomLabel4);
		base.Controls.Add(this.lblKey);
		base.Controls.Add(this.bunifuCustomLabel7);
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.btnLogin);
		base.Controls.Add(this.bunifuCustomLabel3);
		base.Controls.Add(this.txbPassword);
		base.Controls.Add(this.bunifuCustomLabel2);
		base.Controls.Add(this.txbUserName);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fActive";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE - Kích hoạt bản quyền";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fActive_FormClosing);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
