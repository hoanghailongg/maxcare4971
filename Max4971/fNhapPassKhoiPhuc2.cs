using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fNhapPassKhoiPhuc2 : Form
{
	public static bool bool_0;

	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private RadioButton rbPassNgauNhien;

	private RadioButton rbPassTuDat;

	private TextBox txtPass;

	private CheckBox ckbCaptcha;

	private TextBox txtAnyCaptcha;

	private Panel plCaptcha;

	private RadioButton rb2Captcha;

	private RadioButton rbAnyCaptcha;

	private TextBox txt2Captcha;

	private RadioButton rbCaptchafb;

	private TextBox txtCaptchafb;

	private CheckBox ckbLayToken;

	private Panel panel1;

	private RadioButton rbEAAG;

	private RadioButton rbEAAB;

	private MetroButton btnDown;

	private MetroButton btnUp;

	public fNhapPassKhoiPhuc2()
	{
		InitializeComponent();
		method_0();
		gclass17_0 = new GClass17("configGeneral");
		bool_0 = false;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (rbPassTuDat.Checked && txtPass.Text.Trim() == "")
		{
			GClass38.smethod_0("Vui lòng nhập mật khẩu!", 4);
			return;
		}
		int num = 0;
		if (rbPassNgauNhien.Checked)
		{
			num = 1;
		}
		gclass17_0.method_5("typePass", num);
		gclass17_0.method_5("txtPass", txtPass.Text);
		gclass17_0.method_5("ckbCaptcha", ckbCaptcha.Checked);
		int num2 = 0;
		if (rb2Captcha.Checked)
		{
			num2 = 1;
		}
		else if (rbCaptchafb.Checked)
		{
			num2 = 2;
		}
		gclass17_0.method_5("typeCaptcha", num2);
		gclass17_0.method_5("txtAnyCaptcha", txtAnyCaptcha.Text);
		gclass17_0.method_5("txt2Captcha", txt2Captcha.Text);
		gclass17_0.method_5("txtCaptchafb", txtCaptchafb.Text);
		gclass17_0.method_5("ckbLayToken", ckbLayToken.Checked);
		int num3 = 0;
		if (rbEAAG.Checked)
		{
			num3 = 1;
		}
		gclass17_0.method_5("typeToken", num3);
		gclass17_0.method_8();
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapPassKhoiPhuc2_Load(object sender, EventArgs e)
	{
		if (gclass17_0.method_2("typePass") == 0)
		{
			rbPassTuDat.Checked = true;
		}
		else
		{
			rbPassNgauNhien.Checked = true;
		}
		txtPass.Text = gclass17_0.method_0("txtPass");
		ckbCaptcha.Checked = gclass17_0.method_3("ckbCaptcha");
		switch (gclass17_0.method_2("typeCaptcha"))
		{
		case 0:
			rbAnyCaptcha.Checked = true;
			break;
		case 1:
			rb2Captcha.Checked = true;
			break;
		default:
			rbCaptchafb.Checked = true;
			break;
		}
		txtAnyCaptcha.Text = gclass17_0.method_0("txtAnyCaptcha");
		txt2Captcha.Text = gclass17_0.method_0("txt2Captcha");
		txtCaptchafb.Text = gclass17_0.method_0("txtCaptchafb");
		ckbLayToken.Checked = gclass17_0.method_3("ckbLayToken");
		if (gclass17_0.method_2("typeToken") == 0)
		{
			rbEAAB.Checked = true;
		}
		else
		{
			rbEAAG.Checked = true;
		}
		rbPassTuDat_CheckedChanged(null, null);
		ckbCaptcha_CheckedChanged(null, null);
		rb2Captcha_CheckedChanged(null, null);
		rbAnyCaptcha_CheckedChanged(null, null);
		rbCaptchafb_CheckedChanged(null, null);
		ckbLayToken_CheckedChanged(null, null);
	}

	private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
	{
		txtPass.Enabled = rbPassTuDat.Checked;
	}

	private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		plCaptcha.Enabled = ckbCaptcha.Checked;
	}

	private void rbAnyCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		txtAnyCaptcha.Enabled = rbAnyCaptcha.Checked;
	}

	private void rb2Captcha_CheckedChanged(object sender, EventArgs e)
	{
		txt2Captcha.Enabled = rb2Captcha.Checked;
	}

	private void rbCaptchafb_CheckedChanged(object sender, EventArgs e)
	{
		txtCaptchafb.Enabled = rbCaptchafb.Checked;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right)
		{
			btnDown.Visible = true;
			btnUp.Visible = true;
		}
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		base.Size = new Size(368, 260);
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		base.Size = new Size(368, 342);
		ckbLayToken.Visible = true;
		panel1.Visible = true;
	}

	private void ckbLayToken_CheckedChanged(object sender, EventArgs e)
	{
		panel1.Enabled = ckbLayToken.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapPassKhoiPhuc2));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.rbPassNgauNhien = new System.Windows.Forms.RadioButton();
		this.rbPassTuDat = new System.Windows.Forms.RadioButton();
		this.txtPass = new System.Windows.Forms.TextBox();
		this.ckbCaptcha = new System.Windows.Forms.CheckBox();
		this.txtAnyCaptcha = new System.Windows.Forms.TextBox();
		this.plCaptcha = new System.Windows.Forms.Panel();
		this.rb2Captcha = new System.Windows.Forms.RadioButton();
		this.rbCaptchafb = new System.Windows.Forms.RadioButton();
		this.rbAnyCaptcha = new System.Windows.Forms.RadioButton();
		this.txtCaptchafb = new System.Windows.Forms.TextBox();
		this.txt2Captcha = new System.Windows.Forms.TextBox();
		this.ckbLayToken = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.rbEAAB = new System.Windows.Forms.RadioButton();
		this.rbEAAG = new System.Windows.Forms.RadioButton();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.plCaptcha.SuspendLayout();
		this.panel1.SuspendLayout();
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
		this.bunifuCards1.Size = new System.Drawing.Size(368, 34);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(366, 28);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(334, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(366, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Tùy chọn mật khẩu";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(191, 225);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(87, 225);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.rbPassNgauNhien.AutoSize = true;
		this.rbPassNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPassNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbPassNgauNhien.Location = new System.Drawing.Point(12, 71);
		this.rbPassNgauNhien.Name = "rbPassNgauNhien";
		this.rbPassNgauNhien.Size = new System.Drawing.Size(118, 20);
		this.rbPassNgauNhien.TabIndex = 5;
		this.rbPassNgauNhien.Text = "Pass ngẫu nhiên";
		this.rbPassNgauNhien.UseVisualStyleBackColor = true;
		this.rbPassTuDat.AutoSize = true;
		this.rbPassTuDat.Checked = true;
		this.rbPassTuDat.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPassTuDat.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbPassTuDat.Location = new System.Drawing.Point(12, 43);
		this.rbPassTuDat.Name = "rbPassTuDat";
		this.rbPassTuDat.Size = new System.Drawing.Size(94, 20);
		this.rbPassTuDat.TabIndex = 6;
		this.rbPassTuDat.TabStop = true;
		this.rbPassTuDat.Text = "Pass tự đặt:";
		this.rbPassTuDat.UseVisualStyleBackColor = true;
		this.rbPassTuDat.CheckedChanged += new System.EventHandler(rbPassTuDat_CheckedChanged);
		this.txtPass.Location = new System.Drawing.Point(131, 44);
		this.txtPass.Name = "txtPass";
		this.txtPass.Size = new System.Drawing.Size(168, 21);
		this.txtPass.TabIndex = 7;
		this.ckbCaptcha.AutoSize = true;
		this.ckbCaptcha.Font = new System.Drawing.Font("Tahoma", 8.75f);
		this.ckbCaptcha.Location = new System.Drawing.Point(12, 99);
		this.ckbCaptcha.Name = "ckbCaptcha";
		this.ckbCaptcha.Size = new System.Drawing.Size(95, 18);
		this.ckbCaptcha.TabIndex = 8;
		this.ckbCaptcha.Text = "Giải captcha:";
		this.ckbCaptcha.UseVisualStyleBackColor = true;
		this.ckbCaptcha.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		this.txtAnyCaptcha.Location = new System.Drawing.Point(124, 32);
		this.txtAnyCaptcha.Name = "txtAnyCaptcha";
		this.txtAnyCaptcha.Size = new System.Drawing.Size(193, 21);
		this.txtAnyCaptcha.TabIndex = 10;
		this.plCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCaptcha.Controls.Add(this.rb2Captcha);
		this.plCaptcha.Controls.Add(this.rbCaptchafb);
		this.plCaptcha.Controls.Add(this.rbAnyCaptcha);
		this.plCaptcha.Controls.Add(this.txtCaptchafb);
		this.plCaptcha.Controls.Add(this.txt2Captcha);
		this.plCaptcha.Controls.Add(this.txtAnyCaptcha);
		this.plCaptcha.Location = new System.Drawing.Point(34, 123);
		this.plCaptcha.Name = "plCaptcha";
		this.plCaptcha.Size = new System.Drawing.Size(322, 89);
		this.plCaptcha.TabIndex = 10;
		this.rb2Captcha.AutoSize = true;
		this.rb2Captcha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rb2Captcha.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rb2Captcha.Location = new System.Drawing.Point(3, 58);
		this.rb2Captcha.Name = "rb2Captcha";
		this.rb2Captcha.Size = new System.Drawing.Size(83, 20);
		this.rb2Captcha.TabIndex = 12;
		this.rb2Captcha.Text = "2Captcha:";
		this.rb2Captcha.UseVisualStyleBackColor = true;
		this.rb2Captcha.CheckedChanged += new System.EventHandler(rb2Captcha_CheckedChanged);
		this.rbCaptchafb.AutoSize = true;
		this.rbCaptchafb.Checked = true;
		this.rbCaptchafb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCaptchafb.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbCaptchafb.Location = new System.Drawing.Point(3, 6);
		this.rbCaptchafb.Name = "rbCaptchafb";
		this.rbCaptchafb.Size = new System.Drawing.Size(115, 20);
		this.rbCaptchafb.TabIndex = 11;
		this.rbCaptchafb.TabStop = true;
		this.rbCaptchafb.Text = "Captchafb.com:";
		this.rbCaptchafb.UseVisualStyleBackColor = true;
		this.rbCaptchafb.CheckedChanged += new System.EventHandler(rbCaptchafb_CheckedChanged);
		this.rbAnyCaptcha.AutoSize = true;
		this.rbAnyCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbAnyCaptcha.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbAnyCaptcha.Location = new System.Drawing.Point(3, 32);
		this.rbAnyCaptcha.Name = "rbAnyCaptcha";
		this.rbAnyCaptcha.Size = new System.Drawing.Size(97, 20);
		this.rbAnyCaptcha.TabIndex = 11;
		this.rbAnyCaptcha.Text = "AnyCaptcha:";
		this.rbAnyCaptcha.UseVisualStyleBackColor = true;
		this.rbAnyCaptcha.CheckedChanged += new System.EventHandler(rbAnyCaptcha_CheckedChanged);
		this.txtCaptchafb.Location = new System.Drawing.Point(124, 6);
		this.txtCaptchafb.Name = "txtCaptchafb";
		this.txtCaptchafb.Size = new System.Drawing.Size(193, 21);
		this.txtCaptchafb.TabIndex = 10;
		this.txt2Captcha.Location = new System.Drawing.Point(124, 59);
		this.txt2Captcha.Name = "txt2Captcha";
		this.txt2Captcha.Size = new System.Drawing.Size(193, 21);
		this.txt2Captcha.TabIndex = 10;
		this.ckbLayToken.AutoSize = true;
		this.ckbLayToken.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLayToken.Location = new System.Drawing.Point(12, 223);
		this.ckbLayToken.Name = "ckbLayToken";
		this.ckbLayToken.Size = new System.Drawing.Size(255, 20);
		this.ckbLayToken.TabIndex = 11;
		this.ckbLayToken.Text = "Lấy token khi giải checkpoint thành công";
		this.ckbLayToken.UseVisualStyleBackColor = true;
		this.ckbLayToken.Visible = false;
		this.ckbLayToken.CheckedChanged += new System.EventHandler(ckbLayToken_CheckedChanged);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.rbEAAG);
		this.panel1.Controls.Add(this.rbEAAB);
		this.panel1.Location = new System.Drawing.Point(34, 249);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(186, 34);
		this.panel1.TabIndex = 12;
		this.panel1.Visible = false;
		this.rbEAAB.AutoSize = true;
		this.rbEAAB.Checked = true;
		this.rbEAAB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbEAAB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbEAAB.Location = new System.Drawing.Point(6, 6);
		this.rbEAAB.Name = "rbEAAB";
		this.rbEAAB.Size = new System.Drawing.Size(55, 20);
		this.rbEAAB.TabIndex = 5;
		this.rbEAAB.TabStop = true;
		this.rbEAAB.Text = "EAAB";
		this.rbEAAB.UseVisualStyleBackColor = true;
		this.rbEAAG.AutoSize = true;
		this.rbEAAG.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbEAAG.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbEAAG.Location = new System.Drawing.Point(114, 6);
		this.rbEAAG.Name = "rbEAAG";
		this.rbEAAG.Size = new System.Drawing.Size(56, 20);
		this.rbEAAG.TabIndex = 5;
		this.rbEAAG.Text = "EAAG";
		this.rbEAAG.UseVisualStyleBackColor = true;
		this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(305, 34);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 154;
		this.btnDown.UseSelectable = true;
		this.btnDown.Visible = false;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(336, 34);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 155;
		this.btnUp.UseSelectable = true;
		this.btnUp.Visible = false;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(368, 260);
		base.Controls.Add(this.btnDown);
		base.Controls.Add(this.btnUp);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.ckbLayToken);
		base.Controls.Add(this.plCaptcha);
		base.Controls.Add(this.ckbCaptcha);
		base.Controls.Add(this.txtPass);
		base.Controls.Add(this.rbPassTuDat);
		base.Controls.Add(this.rbPassNgauNhien);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapPassKhoiPhuc2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "z";
		base.Load += new System.EventHandler(fNhapPassKhoiPhuc2_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.plCaptcha.ResumeLayout(false);
		this.plCaptcha.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
