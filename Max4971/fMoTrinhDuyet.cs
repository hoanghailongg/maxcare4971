using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fMoTrinhDuyet : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Panel panel1;

	private Panel panel3;

	private RadioButton rbSuDungProfile;

	private RadioButton rbKhongDungProfile;

	private MetroButton btnCauHinh;

	private Panel panel2;

	private RadioButton rbLoginEmailPass;

	private RadioButton rbLoginUidPass;

	private RadioButton rbLoginCookie;

	private Label label3;

	private Label label1;

	private Label label2;

	private Button btnSave;

	private CheckBox ckbGetCookie;

	private Panel panel5;

	private RadioButton rbLoginWWW;

	private RadioButton rbLoginMFB;

	private Label label4;

	private CheckBox ckbAutoCloseChromeLoginFail;

	private TextBox txtLink;

	private CheckBox ckbAutoOpenLink;

	private CheckBox ckbKhongLuuTrinhDuyet;

	private CheckBox ckbLoginHotmail;

	private Panel plAddChromeVaoFormView;

	private NumericUpDown nudWidthChrome;

	private Label label35;

	private Label label33;

	private NumericUpDown nudHeighChrome;

	private CheckBox ckbAddChromeIntoForm;

	private Panel plSapXepCuaSoChrome;

	private Label label10;

	private Label label11;

	private ComboBox cbbColumnChrome;

	private ComboBox cbbRowChrome;

	private RadioButton rbLoginVia;

	private RadioButton rbLoginMbasic;

	private CheckBox ckbGetToken;

	public fMoTrinhDuyet()
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(btnCauHinh);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(rbSuDungProfile);
		GClass29.smethod_1(rbKhongDungProfile);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(ckbKhongLuuTrinhDuyet);
		GClass29.smethod_1(ckbGetCookie);
		GClass29.smethod_1(ckbAutoCloseChromeLoginFail);
		GClass29.smethod_1(ckbAutoOpenLink);
		GClass29.smethod_1(btnSave);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCauHinh_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fCauHinhChung());
	}

	private void fMoTrinhDuyet_Load(object sender, EventArgs e)
	{
		GClass17 gClass = new GClass17("configOpenBrowser");
		if (gClass.method_3("isUseProfile", bool_0: true))
		{
			rbSuDungProfile.Checked = true;
		}
		else
		{
			rbKhongDungProfile.Checked = true;
		}
		switch (gClass.method_2("typeBrowserLogin"))
		{
		case 0:
			rbLoginMFB.Checked = true;
			break;
		case 1:
			rbLoginWWW.Checked = true;
			break;
		case 2:
			rbLoginMbasic.Checked = true;
			break;
		case 3:
			rbLoginVia.Checked = true;
			break;
		}
		switch (gClass.method_2("typeLogin"))
		{
		case 0:
			rbLoginUidPass.Checked = true;
			break;
		case 1:
			rbLoginEmailPass.Checked = true;
			break;
		case 2:
			rbLoginCookie.Checked = true;
			break;
		}
		ckbAddChromeIntoForm.Checked = gClass.method_3("ckbAddChromeIntoForm");
		nudWidthChrome.Value = gClass.method_2("nudWidthChrome", 520);
		nudHeighChrome.Value = gClass.method_2("nudHeighChrome", 480);
		cbbColumnChrome.Text = ((gClass.method_0("cbbColumnChrome") == "") ? "5" : gClass.method_0("cbbColumnChrome"));
		cbbRowChrome.Text = ((gClass.method_0("cbbRowChrome") == "") ? "2" : gClass.method_0("cbbRowChrome"));
		ckbKhongLuuTrinhDuyet.Checked = gClass.method_3("ckbKhongLuuTrinhDuyet");
		ckbGetCookie.Checked = gClass.method_3("isGetCookie");
		ckbGetToken.Checked = gClass.method_3("ckbGetToken");
		ckbAutoCloseChromeLoginFail.Checked = gClass.method_3("isAutoCloseChromeLoginFail");
		ckbAutoOpenLink.Checked = gClass.method_3("ckbAutoOpenLink");
		txtLink.Text = gClass.method_0("txtLink");
		ckbLoginHotmail.Checked = gClass.method_3("ckbLoginHotmail");
		ckbAutoOpenLink_CheckedChanged(null, null);
		method_1(null, null);
		ckbAddChromeIntoForm_CheckedChanged(null, null);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		GClass17 gClass = new GClass17("configOpenBrowser");
		if (rbSuDungProfile.Checked)
		{
			gClass.method_5("isUseProfile", true);
		}
		else
		{
			gClass.method_5("isUseProfile", false);
		}
		if (rbLoginUidPass.Checked)
		{
			gClass.method_5("typeLogin", 0);
		}
		else if (rbLoginEmailPass.Checked)
		{
			gClass.method_5("typeLogin", 1);
		}
		else
		{
			gClass.method_5("typeLogin", 2);
		}
		if (rbLoginMFB.Checked)
		{
			gClass.method_5("typeBrowserLogin", 0);
		}
		else if (rbLoginWWW.Checked)
		{
			gClass.method_5("typeBrowserLogin", 1);
		}
		else if (rbLoginMbasic.Checked)
		{
			gClass.method_5("typeBrowserLogin", 2);
		}
		else
		{
			gClass.method_5("typeBrowserLogin", 3);
		}
		gClass.method_5("ckbAddChromeIntoForm", ckbAddChromeIntoForm.Checked);
		gClass.method_5("nudWidthChrome", nudWidthChrome.Value);
		gClass.method_5("nudHeighChrome", nudHeighChrome.Value);
		gClass.method_5("cbbColumnChrome", cbbColumnChrome.Text);
		gClass.method_5("cbbRowChrome", cbbRowChrome.Text);
		gClass.method_5("isGetCookie", ckbGetCookie.Checked);
		gClass.method_5("ckbGetToken", ckbGetToken.Checked);
		gClass.method_5("ckbKhongLuuTrinhDuyet", ckbKhongLuuTrinhDuyet.Checked);
		gClass.method_5("isAutoCloseChromeLoginFail", ckbAutoCloseChromeLoginFail.Checked);
		gClass.method_5("ckbAutoOpenLink", ckbAutoOpenLink.Checked);
		gClass.method_5("txtLink", txtLink.Text);
		gClass.method_5("ckbLoginHotmail", ckbLoginHotmail.Checked);
		gClass.method_8();
		bool_0 = true;
		Close();
	}

	private void txtLink_TextChanged(object sender, EventArgs e)
	{
	}

	private void ckbAutoOpenLink_CheckedChanged(object sender, EventArgs e)
	{
		txtLink.Enabled = ckbAutoOpenLink.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
	{
		plAddChromeVaoFormView.Enabled = ckbAddChromeIntoForm.Checked;
		plSapXepCuaSoChrome.Enabled = !ckbAddChromeIntoForm.Checked;
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMoTrinhDuyet));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.panel1 = new System.Windows.Forms.Panel();
		this.plSapXepCuaSoChrome = new System.Windows.Forms.Panel();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.cbbColumnChrome = new System.Windows.Forms.ComboBox();
		this.cbbRowChrome = new System.Windows.Forms.ComboBox();
		this.plAddChromeVaoFormView = new System.Windows.Forms.Panel();
		this.nudWidthChrome = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.nudHeighChrome = new System.Windows.Forms.NumericUpDown();
		this.ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
		this.ckbLoginHotmail = new System.Windows.Forms.CheckBox();
		this.txtLink = new System.Windows.Forms.TextBox();
		this.btnCauHinh = new MetroFramework.Controls.MetroButton();
		this.panel5 = new System.Windows.Forms.Panel();
		this.rbLoginVia = new System.Windows.Forms.RadioButton();
		this.rbLoginMbasic = new System.Windows.Forms.RadioButton();
		this.rbLoginWWW = new System.Windows.Forms.RadioButton();
		this.rbLoginMFB = new System.Windows.Forms.RadioButton();
		this.label4 = new System.Windows.Forms.Label();
		this.ckbAutoOpenLink = new System.Windows.Forms.CheckBox();
		this.ckbAutoCloseChromeLoginFail = new System.Windows.Forms.CheckBox();
		this.ckbKhongLuuTrinhDuyet = new System.Windows.Forms.CheckBox();
		this.ckbGetCookie = new System.Windows.Forms.CheckBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbSuDungProfile = new System.Windows.Forms.RadioButton();
		this.rbKhongDungProfile = new System.Windows.Forms.RadioButton();
		this.panel2 = new System.Windows.Forms.Panel();
		this.rbLoginEmailPass = new System.Windows.Forms.RadioButton();
		this.rbLoginUidPass = new System.Windows.Forms.RadioButton();
		this.rbLoginCookie = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.ckbGetToken = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plSapXepCuaSoChrome.SuspendLayout();
		this.plAddChromeVaoFormView.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).BeginInit();
		this.panel5.SuspendLayout();
		this.panel3.SuspendLayout();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(452, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(452, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(419, -1);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(452, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Mở trình duyệt";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(233, 413);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plSapXepCuaSoChrome);
		this.panel1.Controls.Add(this.plAddChromeVaoFormView);
		this.panel1.Controls.Add(this.ckbAddChromeIntoForm);
		this.panel1.Controls.Add(this.ckbLoginHotmail);
		this.panel1.Controls.Add(this.txtLink);
		this.panel1.Controls.Add(this.btnCauHinh);
		this.panel1.Controls.Add(this.panel5);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.ckbAutoOpenLink);
		this.panel1.Controls.Add(this.ckbAutoCloseChromeLoginFail);
		this.panel1.Controls.Add(this.ckbKhongLuuTrinhDuyet);
		this.panel1.Controls.Add(this.ckbGetToken);
		this.panel1.Controls.Add(this.ckbGetCookie);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.panel3);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(453, 455);
		this.panel1.TabIndex = 5;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plSapXepCuaSoChrome.Controls.Add(this.label10);
		this.plSapXepCuaSoChrome.Controls.Add(this.label11);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
		this.plSapXepCuaSoChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.plSapXepCuaSoChrome.Location = new System.Drawing.Point(32, 212);
		this.plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
		this.plSapXepCuaSoChrome.Size = new System.Drawing.Size(358, 28);
		this.plSapXepCuaSoChrome.TabIndex = 159;
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(3, 4);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(147, 16);
		this.label10.TabIndex = 33;
		this.label10.Text = "Sắp xếp cửa sổ chrome:";
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.Location = new System.Drawing.Point(245, 2);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(23, 23);
		this.label11.TabIndex = 33;
		this.label11.Text = "X";
		this.cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbColumnChrome.FormattingEnabled = true;
		this.cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		this.cbbColumnChrome.Location = new System.Drawing.Point(200, 2);
		this.cbbColumnChrome.Name = "cbbColumnChrome";
		this.cbbColumnChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbColumnChrome.TabIndex = 145;
		this.cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbRowChrome.FormattingEnabled = true;
		this.cbbRowChrome.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		this.cbbRowChrome.Location = new System.Drawing.Point(272, 2);
		this.cbbRowChrome.Name = "cbbRowChrome";
		this.cbbRowChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbRowChrome.TabIndex = 145;
		this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
		this.plAddChromeVaoFormView.Controls.Add(this.label35);
		this.plAddChromeVaoFormView.Controls.Add(this.label33);
		this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
		this.plAddChromeVaoFormView.Location = new System.Drawing.Point(224, 185);
		this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
		this.plAddChromeVaoFormView.Size = new System.Drawing.Size(175, 27);
		this.plAddChromeVaoFormView.TabIndex = 158;
		this.nudWidthChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudWidthChrome.Location = new System.Drawing.Point(41, 2);
		this.nudWidthChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudWidthChrome.Minimum = new decimal(new int[4] { 516, 0, 0, 0 });
		this.nudWidthChrome.Name = "nudWidthChrome";
		this.nudWidthChrome.Size = new System.Drawing.Size(53, 23);
		this.nudWidthChrome.TabIndex = 151;
		this.nudWidthChrome.Value = new decimal(new int[4] { 516, 0, 0, 0 });
		this.label35.AutoSize = true;
		this.label35.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.Location = new System.Drawing.Point(95, 2);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(23, 23);
		this.label35.TabIndex = 33;
		this.label35.Text = "X";
		this.label33.AutoSize = true;
		this.label33.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label33.Location = new System.Drawing.Point(3, 4);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(36, 16);
		this.label33.TabIndex = 33;
		this.label33.Text = "Size:";
		this.nudHeighChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudHeighChrome.Location = new System.Drawing.Point(118, 2);
		this.nudHeighChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudHeighChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudHeighChrome.Name = "nudHeighChrome";
		this.nudHeighChrome.Size = new System.Drawing.Size(53, 23);
		this.nudHeighChrome.TabIndex = 151;
		this.nudHeighChrome.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ckbAddChromeIntoForm.AutoSize = true;
		this.ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddChromeIntoForm.Location = new System.Drawing.Point(37, 187);
		this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		this.ckbAddChromeIntoForm.Size = new System.Drawing.Size(187, 20);
		this.ckbAddChromeIntoForm.TabIndex = 157;
		this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
		this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(ckbAddChromeIntoForm_CheckedChanged);
		this.ckbLoginHotmail.AutoSize = true;
		this.ckbLoginHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLoginHotmail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLoginHotmail.Location = new System.Drawing.Point(37, 372);
		this.ckbLoginHotmail.Name = "ckbLoginHotmail";
		this.ckbLoginHotmail.Size = new System.Drawing.Size(184, 20);
		this.ckbLoginHotmail.TabIndex = 25;
		this.ckbLoginHotmail.Text = "Tự động đăng nhập hotmail";
		this.ckbLoginHotmail.UseVisualStyleBackColor = true;
		this.txtLink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLink.Location = new System.Drawing.Point(183, 344);
		this.txtLink.Name = "txtLink";
		this.txtLink.Size = new System.Drawing.Size(233, 23);
		this.txtLink.TabIndex = 24;
		this.txtLink.TextChanged += new System.EventHandler(txtLink_TextChanged);
		this.btnCauHinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCauHinh.Location = new System.Drawing.Point(160, 62);
		this.btnCauHinh.Name = "btnCauHinh";
		this.btnCauHinh.Size = new System.Drawing.Size(75, 23);
		this.btnCauHinh.TabIndex = 5;
		this.btnCauHinh.Text = "Cấu hình";
		this.btnCauHinh.UseSelectable = true;
		this.btnCauHinh.Click += new System.EventHandler(btnCauHinh_Click);
		this.panel5.Controls.Add(this.rbLoginVia);
		this.panel5.Controls.Add(this.rbLoginMbasic);
		this.panel5.Controls.Add(this.rbLoginWWW);
		this.panel5.Controls.Add(this.rbLoginMFB);
		this.panel5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel5.Location = new System.Drawing.Point(157, 155);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(273, 26);
		this.panel5.TabIndex = 23;
		this.rbLoginVia.AutoSize = true;
		this.rbLoginVia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginVia.Location = new System.Drawing.Point(190, 3);
		this.rbLoginVia.Name = "rbLoginVia";
		this.rbLoginVia.Size = new System.Drawing.Size(80, 20);
		this.rbLoginVia.TabIndex = 4;
		this.rbLoginVia.Text = "www->m";
		this.rbLoginVia.UseVisualStyleBackColor = true;
		this.rbLoginMbasic.AutoSize = true;
		this.rbLoginMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginMbasic.Location = new System.Drawing.Point(120, 3);
		this.rbLoginMbasic.Name = "rbLoginMbasic";
		this.rbLoginMbasic.Size = new System.Drawing.Size(65, 20);
		this.rbLoginMbasic.TabIndex = 4;
		this.rbLoginMbasic.Text = "mbasic";
		this.rbLoginMbasic.UseVisualStyleBackColor = true;
		this.rbLoginWWW.AutoSize = true;
		this.rbLoginWWW.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginWWW.Location = new System.Drawing.Point(58, 3);
		this.rbLoginWWW.Name = "rbLoginWWW";
		this.rbLoginWWW.Size = new System.Drawing.Size(55, 20);
		this.rbLoginWWW.TabIndex = 4;
		this.rbLoginWWW.Text = "www";
		this.rbLoginWWW.UseVisualStyleBackColor = true;
		this.rbLoginMFB.AutoSize = true;
		this.rbLoginMFB.Checked = true;
		this.rbLoginMFB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginMFB.Location = new System.Drawing.Point(3, 3);
		this.rbLoginMFB.Name = "rbLoginMFB";
		this.rbLoginMFB.Size = new System.Drawing.Size(51, 20);
		this.rbLoginMFB.TabIndex = 4;
		this.rbLoginMFB.TabStop = true;
		this.rbLoginMFB.Text = "m.fb";
		this.rbLoginMFB.UseVisualStyleBackColor = true;
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(34, 160);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(110, 16);
		this.label4.TabIndex = 22;
		this.label4.Text = "Trang đăng nhâ\u0323p:";
		this.ckbAutoOpenLink.AutoSize = true;
		this.ckbAutoOpenLink.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoOpenLink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAutoOpenLink.Location = new System.Drawing.Point(37, 346);
		this.ckbAutoOpenLink.Name = "ckbAutoOpenLink";
		this.ckbAutoOpenLink.Size = new System.Drawing.Size(149, 20);
		this.ckbAutoOpenLink.TabIndex = 21;
		this.ckbAutoOpenLink.Text = "Tự động mở website:";
		this.ckbAutoOpenLink.UseVisualStyleBackColor = true;
		this.ckbAutoOpenLink.CheckedChanged += new System.EventHandler(ckbAutoOpenLink_CheckedChanged);
		this.ckbAutoCloseChromeLoginFail.AutoSize = true;
		this.ckbAutoCloseChromeLoginFail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoCloseChromeLoginFail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAutoCloseChromeLoginFail.Location = new System.Drawing.Point(37, 320);
		this.ckbAutoCloseChromeLoginFail.Name = "ckbAutoCloseChromeLoginFail";
		this.ckbAutoCloseChromeLoginFail.Size = new System.Drawing.Size(326, 20);
		this.ckbAutoCloseChromeLoginFail.TabIndex = 21;
		this.ckbAutoCloseChromeLoginFail.Text = "Tự động đóng những tab chrome đăng nhập thất bại";
		this.ckbAutoCloseChromeLoginFail.UseVisualStyleBackColor = true;
		this.ckbKhongLuuTrinhDuyet.AutoSize = true;
		this.ckbKhongLuuTrinhDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongLuuTrinhDuyet.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbKhongLuuTrinhDuyet.Location = new System.Drawing.Point(37, 242);
		this.ckbKhongLuuTrinhDuyet.Name = "ckbKhongLuuTrinhDuyet";
		this.ckbKhongLuuTrinhDuyet.Size = new System.Drawing.Size(232, 20);
		this.ckbKhongLuuTrinhDuyet.TabIndex = 21;
		this.ckbKhongLuuTrinhDuyet.Text = "Không lưu trình duyệt khi đăng nhập";
		this.ckbKhongLuuTrinhDuyet.UseVisualStyleBackColor = true;
		this.ckbGetCookie.AutoSize = true;
		this.ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGetCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbGetCookie.Location = new System.Drawing.Point(37, 268);
		this.ckbGetCookie.Name = "ckbGetCookie";
		this.ckbGetCookie.Size = new System.Drawing.Size(344, 20);
		this.ckbGetCookie.TabIndex = 21;
		this.ckbGetCookie.Text = "Tự động cập nhật Cookie sau khi đăng nhập thành công";
		this.ckbGetCookie.UseVisualStyleBackColor = true;
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(125, 413);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 20;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.panel3.Controls.Add(this.rbSuDungProfile);
		this.panel3.Controls.Add(this.rbKhongDungProfile);
		this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel3.Location = new System.Drawing.Point(157, 91);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(273, 26);
		this.panel3.TabIndex = 8;
		this.rbSuDungProfile.AutoSize = true;
		this.rbSuDungProfile.Checked = true;
		this.rbSuDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSuDungProfile.Location = new System.Drawing.Point(3, 3);
		this.rbSuDungProfile.Name = "rbSuDungProfile";
		this.rbSuDungProfile.Size = new System.Drawing.Size(113, 20);
		this.rbSuDungProfile.TabIndex = 4;
		this.rbSuDungProfile.TabStop = true;
		this.rbSuDungProfile.Text = "Sử dụng Profile";
		this.rbSuDungProfile.UseVisualStyleBackColor = true;
		this.rbKhongDungProfile.AutoSize = true;
		this.rbKhongDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbKhongDungProfile.Location = new System.Drawing.Point(127, 3);
		this.rbKhongDungProfile.Name = "rbKhongDungProfile";
		this.rbKhongDungProfile.Size = new System.Drawing.Size(132, 20);
		this.rbKhongDungProfile.TabIndex = 4;
		this.rbKhongDungProfile.Text = "Không dùng Profile";
		this.rbKhongDungProfile.UseVisualStyleBackColor = true;
		this.panel2.Controls.Add(this.rbLoginEmailPass);
		this.panel2.Controls.Add(this.rbLoginUidPass);
		this.panel2.Controls.Add(this.rbLoginCookie);
		this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel2.Location = new System.Drawing.Point(157, 123);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(273, 26);
		this.panel2.TabIndex = 8;
		this.rbLoginEmailPass.AutoSize = true;
		this.rbLoginEmailPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginEmailPass.Location = new System.Drawing.Point(93, 3);
		this.rbLoginEmailPass.Name = "rbLoginEmailPass";
		this.rbLoginEmailPass.Size = new System.Drawing.Size(88, 20);
		this.rbLoginEmailPass.TabIndex = 4;
		this.rbLoginEmailPass.Text = "Email|Pass";
		this.rbLoginEmailPass.UseVisualStyleBackColor = true;
		this.rbLoginUidPass.AutoSize = true;
		this.rbLoginUidPass.Checked = true;
		this.rbLoginUidPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginUidPass.Location = new System.Drawing.Point(3, 3);
		this.rbLoginUidPass.Name = "rbLoginUidPass";
		this.rbLoginUidPass.Size = new System.Drawing.Size(75, 20);
		this.rbLoginUidPass.TabIndex = 4;
		this.rbLoginUidPass.TabStop = true;
		this.rbLoginUidPass.Text = "Uid|Pass";
		this.rbLoginUidPass.UseVisualStyleBackColor = true;
		this.rbLoginCookie.AutoSize = true;
		this.rbLoginCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginCookie.Location = new System.Drawing.Point(196, 3);
		this.rbLoginCookie.Name = "rbLoginCookie";
		this.rbLoginCookie.Size = new System.Drawing.Size(63, 20);
		this.rbLoginCookie.TabIndex = 4;
		this.rbLoginCookie.Text = "Cookie";
		this.rbLoginCookie.UseVisualStyleBackColor = true;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(34, 64);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(98, 16);
		this.label3.TabIndex = 7;
		this.label3.Text = "Cấu hình đổi IP:";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(34, 96);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(104, 16);
		this.label1.TabIndex = 7;
		this.label1.Text = "Tùy chọn Profile:";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(34, 128);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 7;
		this.label2.Text = "Kiểu đăng nhâ\u0323p:";
		this.ckbGetToken.AutoSize = true;
		this.ckbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGetToken.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbGetToken.Location = new System.Drawing.Point(38, 294);
		this.ckbGetToken.Name = "ckbGetToken";
		this.ckbGetToken.Size = new System.Drawing.Size(313, 20);
		this.ckbGetToken.TabIndex = 21;
		this.ckbGetToken.Text = "Tự động cập nhật token khi đăng nhập thành công";
		this.ckbGetToken.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(453, 455);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fMoTrinhDuyet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fMoTrinhDuyet_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plSapXepCuaSoChrome.ResumeLayout(false);
		this.plSapXepCuaSoChrome.PerformLayout();
		this.plAddChromeVaoFormView.ResumeLayout(false);
		this.plAddChromeVaoFormView.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).EndInit();
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
	}
}
