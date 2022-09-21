using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhHienThi : Form
{
	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel lblStatus;

	private PictureBox pictureBox1;

	private CheckBox ckbToken;

	private CheckBox ckbCookie;

	private CheckBox ckbEmail;

	private CheckBox ckbTen;

	private CheckBox ckbBanBe;

	private CheckBox ckbNhom;

	private CheckBox ckbNgaySinh;

	private CheckBox ckbGioiTinh;

	private CheckBox ckbMatKhau;

	private CheckBox ckbMatKhauMail;

	private CheckBox ckbBackup;

	private CheckBox ckbMa2FA;

	private CheckBox ckbUseragent;

	private CheckBox ckbProxy;

	private CheckBox ckbNgayTao;

	private CheckBox ckbAvatar;

	private CheckBox ckbProfile;

	private CheckBox ckbTinhTrang;

	private CheckBox ckbGhiChu;

	private CheckBox ckbThuMuc;

	private CheckBox ckbFollow;

	private CheckBox ckbInteractEnd;

	private CheckBox ckbMailRecovery;

	private CheckBox ckbPhone;

	public fCauHinhHienThi()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configDatagridview");
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(ckbTen);
		GClass29.smethod_1(ckbFollow);
		GClass29.smethod_1(ckbBanBe);
		GClass29.smethod_1(ckbNhom);
		GClass29.smethod_1(ckbNgaySinh);
		GClass29.smethod_1(ckbGioiTinh);
		GClass29.smethod_1(ckbMatKhau);
		GClass29.smethod_1(ckbMatKhauMail);
		GClass29.smethod_1(ckbMa2FA);
		GClass29.smethod_1(ckbNgayTao);
		GClass29.smethod_1(ckbInteractEnd);
		GClass29.smethod_1(ckbTinhTrang);
		GClass29.smethod_1(ckbThuMuc);
		GClass29.smethod_1(ckbGhiChu);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		gclass17_0.method_5("cToken", ckbToken.Checked);
		gclass17_0.method_5("ckbCookie", ckbCookie.Checked);
		gclass17_0.method_5("ckbEmail", ckbEmail.Checked);
		gclass17_0.method_5("ckbTen", ckbTen.Checked);
		gclass17_0.method_5("ckbBanBe", ckbBanBe.Checked);
		gclass17_0.method_5("ckbNhom", ckbNhom.Checked);
		gclass17_0.method_5("ckbNgaySinh", ckbNgaySinh.Checked);
		gclass17_0.method_5("ckbGioiTinh", ckbGioiTinh.Checked);
		gclass17_0.method_5("ckbMatKhau", ckbMatKhau.Checked);
		gclass17_0.method_5("ckbMatKhauMail", ckbMatKhauMail.Checked);
		gclass17_0.method_5("ckbBackup", ckbBackup.Checked);
		gclass17_0.method_5("ckbMa2FA", ckbMa2FA.Checked);
		gclass17_0.method_5("ckbUseragent", ckbUseragent.Checked);
		gclass17_0.method_5("ckbProxy", ckbProxy.Checked);
		gclass17_0.method_5("ckbNgayTao", ckbNgayTao.Checked);
		gclass17_0.method_5("ckbAvatar", ckbAvatar.Checked);
		gclass17_0.method_5("ckbProfile", ckbProfile.Checked);
		gclass17_0.method_5("ckbTinhTrang", ckbTinhTrang.Checked);
		gclass17_0.method_5("ckbThuMuc", ckbThuMuc.Checked);
		gclass17_0.method_5("ckbGhiChu", ckbGhiChu.Checked);
		gclass17_0.method_5("ckbFollow", ckbFollow.Checked);
		gclass17_0.method_5("ckbInteractEnd", ckbInteractEnd.Checked);
		gclass17_0.method_5("ckbMailRecovery", ckbMailRecovery.Checked);
		gclass17_0.method_5("ckbPhone", ckbPhone.Checked);
		gclass17_0.method_8();
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	private void fCauHinhHienThi_Load(object sender, EventArgs e)
	{
		ckbToken.Checked = gclass17_0.method_3("cToken");
		ckbCookie.Checked = gclass17_0.method_3("ckbCookie");
		ckbEmail.Checked = gclass17_0.method_3("ckbEmail");
		ckbTen.Checked = gclass17_0.method_3("ckbTen");
		ckbBanBe.Checked = gclass17_0.method_3("ckbBanBe");
		ckbNhom.Checked = gclass17_0.method_3("ckbNhom");
		ckbNgaySinh.Checked = gclass17_0.method_3("ckbNgaySinh");
		ckbGioiTinh.Checked = gclass17_0.method_3("ckbGioiTinh");
		ckbMatKhau.Checked = gclass17_0.method_3("ckbMatKhau");
		ckbMatKhauMail.Checked = gclass17_0.method_3("ckbMatKhauMail");
		ckbBackup.Checked = gclass17_0.method_3("ckbBackup");
		ckbMa2FA.Checked = gclass17_0.method_3("ckbMa2FA");
		ckbUseragent.Checked = gclass17_0.method_3("ckbUseragent");
		ckbProxy.Checked = gclass17_0.method_3("ckbProxy");
		ckbNgayTao.Checked = gclass17_0.method_3("ckbNgayTao");
		ckbAvatar.Checked = gclass17_0.method_3("ckbAvatar");
		ckbProfile.Checked = gclass17_0.method_3("ckbProfile");
		ckbTinhTrang.Checked = gclass17_0.method_3("ckbTinhTrang");
		ckbThuMuc.Checked = gclass17_0.method_3("ckbThuMuc");
		ckbGhiChu.Checked = gclass17_0.method_3("ckbGhiChu");
		ckbFollow.Checked = gclass17_0.method_3("ckbFollow");
		ckbInteractEnd.Checked = gclass17_0.method_3("ckbInteractEnd");
		ckbMailRecovery.Checked = gclass17_0.method_3("ckbMailRecovery");
		ckbPhone.Checked = gclass17_0.method_3("ckbPhone");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhHienThi));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.ckbToken = new System.Windows.Forms.CheckBox();
		this.ckbCookie = new System.Windows.Forms.CheckBox();
		this.ckbEmail = new System.Windows.Forms.CheckBox();
		this.ckbTen = new System.Windows.Forms.CheckBox();
		this.ckbBanBe = new System.Windows.Forms.CheckBox();
		this.ckbNhom = new System.Windows.Forms.CheckBox();
		this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
		this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
		this.ckbMatKhau = new System.Windows.Forms.CheckBox();
		this.ckbMatKhauMail = new System.Windows.Forms.CheckBox();
		this.ckbBackup = new System.Windows.Forms.CheckBox();
		this.ckbMa2FA = new System.Windows.Forms.CheckBox();
		this.ckbUseragent = new System.Windows.Forms.CheckBox();
		this.ckbProxy = new System.Windows.Forms.CheckBox();
		this.ckbNgayTao = new System.Windows.Forms.CheckBox();
		this.ckbAvatar = new System.Windows.Forms.CheckBox();
		this.ckbProfile = new System.Windows.Forms.CheckBox();
		this.ckbTinhTrang = new System.Windows.Forms.CheckBox();
		this.ckbGhiChu = new System.Windows.Forms.CheckBox();
		this.ckbThuMuc = new System.Windows.Forms.CheckBox();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.ckbInteractEnd = new System.Windows.Forms.CheckBox();
		this.ckbMailRecovery = new System.Windows.Forms.CheckBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(479, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(479, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(447, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(479, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(247, 253);
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
		this.btnAdd.Location = new System.Drawing.Point(143, 253);
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
		this.lblStatus.BackColor = System.Drawing.Color.Transparent;
		this.lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ForeColor = System.Drawing.Color.Black;
		this.lblStatus.Location = new System.Drawing.Point(51, 41);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(384, 32);
		this.lblStatus.TabIndex = 21;
		this.lblStatus.Text = "Vui lo\u0300ng cho\u0323n như\u0303ng cô\u0323t câ\u0300n hiê\u0309n thi\u0323!";
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblStatus.Click += new System.EventHandler(lblStatus_Click);
		this.ckbToken.AutoSize = true;
		this.ckbToken.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbToken.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbToken.Location = new System.Drawing.Point(31, 85);
		this.ckbToken.Name = "ckbToken";
		this.ckbToken.Size = new System.Drawing.Size(61, 20);
		this.ckbToken.TabIndex = 22;
		this.ckbToken.Text = "Token";
		this.ckbToken.UseVisualStyleBackColor = true;
		this.ckbCookie.AutoSize = true;
		this.ckbCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCookie.Location = new System.Drawing.Point(31, 111);
		this.ckbCookie.Name = "ckbCookie";
		this.ckbCookie.Size = new System.Drawing.Size(64, 20);
		this.ckbCookie.TabIndex = 22;
		this.ckbCookie.Text = "Cookie";
		this.ckbCookie.UseVisualStyleBackColor = true;
		this.ckbEmail.AutoSize = true;
		this.ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbEmail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbEmail.Location = new System.Drawing.Point(31, 137);
		this.ckbEmail.Name = "ckbEmail";
		this.ckbEmail.Size = new System.Drawing.Size(57, 20);
		this.ckbEmail.TabIndex = 22;
		this.ckbEmail.Text = "Email";
		this.ckbEmail.UseVisualStyleBackColor = true;
		this.ckbTen.AutoSize = true;
		this.ckbTen.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTen.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbTen.Location = new System.Drawing.Point(31, 163);
		this.ckbTen.Name = "ckbTen";
		this.ckbTen.Size = new System.Drawing.Size(48, 20);
		this.ckbTen.TabIndex = 22;
		this.ckbTen.Text = "Tên";
		this.ckbTen.UseVisualStyleBackColor = true;
		this.ckbBanBe.AutoSize = true;
		this.ckbBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBanBe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbBanBe.Location = new System.Drawing.Point(31, 215);
		this.ckbBanBe.Name = "ckbBanBe";
		this.ckbBanBe.Size = new System.Drawing.Size(65, 20);
		this.ckbBanBe.TabIndex = 22;
		this.ckbBanBe.Text = "Ba\u0323n be\u0300";
		this.ckbBanBe.UseVisualStyleBackColor = true;
		this.ckbNhom.AutoSize = true;
		this.ckbNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNhom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbNhom.Location = new System.Drawing.Point(128, 85);
		this.ckbNhom.Name = "ckbNhom";
		this.ckbNhom.Size = new System.Drawing.Size(59, 20);
		this.ckbNhom.TabIndex = 22;
		this.ckbNhom.Text = "Nho\u0301m";
		this.ckbNhom.UseVisualStyleBackColor = true;
		this.ckbNgaySinh.AutoSize = true;
		this.ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbNgaySinh.Location = new System.Drawing.Point(128, 111);
		this.ckbNgaySinh.Name = "ckbNgaySinh";
		this.ckbNgaySinh.Size = new System.Drawing.Size(81, 20);
		this.ckbNgaySinh.TabIndex = 22;
		this.ckbNgaySinh.Text = "Nga\u0300y sinh";
		this.ckbNgaySinh.UseVisualStyleBackColor = true;
		this.ckbGioiTinh.AutoSize = true;
		this.ckbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbGioiTinh.Location = new System.Drawing.Point(128, 137);
		this.ckbGioiTinh.Name = "ckbGioiTinh";
		this.ckbGioiTinh.Size = new System.Drawing.Size(72, 20);
		this.ckbGioiTinh.TabIndex = 22;
		this.ckbGioiTinh.Text = "Giơ\u0301i ti\u0301nh";
		this.ckbGioiTinh.UseVisualStyleBackColor = true;
		this.ckbMatKhau.AutoSize = true;
		this.ckbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMatKhau.Location = new System.Drawing.Point(128, 163);
		this.ckbMatKhau.Name = "ckbMatKhau";
		this.ckbMatKhau.Size = new System.Drawing.Size(78, 20);
		this.ckbMatKhau.TabIndex = 22;
		this.ckbMatKhau.Text = "Mâ\u0323t khâ\u0309u";
		this.ckbMatKhau.UseVisualStyleBackColor = true;
		this.ckbMatKhauMail.AutoSize = true;
		this.ckbMatKhauMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMatKhauMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMatKhauMail.Location = new System.Drawing.Point(128, 189);
		this.ckbMatKhauMail.Name = "ckbMatKhauMail";
		this.ckbMatKhauMail.Size = new System.Drawing.Size(106, 20);
		this.ckbMatKhauMail.TabIndex = 22;
		this.ckbMatKhauMail.Text = "Mâ\u0323t khâ\u0309u mail";
		this.ckbMatKhauMail.UseVisualStyleBackColor = true;
		this.ckbBackup.AutoSize = true;
		this.ckbBackup.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBackup.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbBackup.Location = new System.Drawing.Point(128, 215);
		this.ckbBackup.Name = "ckbBackup";
		this.ckbBackup.Size = new System.Drawing.Size(66, 20);
		this.ckbBackup.TabIndex = 22;
		this.ckbBackup.Text = "Backup";
		this.ckbBackup.UseVisualStyleBackColor = true;
		this.ckbMa2FA.AutoSize = true;
		this.ckbMa2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMa2FA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMa2FA.Location = new System.Drawing.Point(253, 85);
		this.ckbMa2FA.Name = "ckbMa2FA";
		this.ckbMa2FA.Size = new System.Drawing.Size(69, 20);
		this.ckbMa2FA.TabIndex = 22;
		this.ckbMa2FA.Text = "Ma\u0303 2FA";
		this.ckbMa2FA.UseVisualStyleBackColor = true;
		this.ckbUseragent.AutoSize = true;
		this.ckbUseragent.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbUseragent.Location = new System.Drawing.Point(253, 111);
		this.ckbUseragent.Name = "ckbUseragent";
		this.ckbUseragent.Size = new System.Drawing.Size(84, 20);
		this.ckbUseragent.TabIndex = 22;
		this.ckbUseragent.Text = "Useragent";
		this.ckbUseragent.UseVisualStyleBackColor = true;
		this.ckbProxy.AutoSize = true;
		this.ckbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbProxy.Location = new System.Drawing.Point(253, 137);
		this.ckbProxy.Name = "ckbProxy";
		this.ckbProxy.Size = new System.Drawing.Size(57, 20);
		this.ckbProxy.TabIndex = 22;
		this.ckbProxy.Text = "Proxy";
		this.ckbProxy.UseVisualStyleBackColor = true;
		this.ckbNgayTao.AutoSize = true;
		this.ckbNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNgayTao.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbNgayTao.Location = new System.Drawing.Point(253, 163);
		this.ckbNgayTao.Name = "ckbNgayTao";
		this.ckbNgayTao.Size = new System.Drawing.Size(76, 20);
		this.ckbNgayTao.TabIndex = 22;
		this.ckbNgayTao.Text = "Nga\u0300y ta\u0323o";
		this.ckbNgayTao.UseVisualStyleBackColor = true;
		this.ckbAvatar.AutoSize = true;
		this.ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAvatar.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAvatar.Location = new System.Drawing.Point(253, 189);
		this.ckbAvatar.Name = "ckbAvatar";
		this.ckbAvatar.Size = new System.Drawing.Size(63, 20);
		this.ckbAvatar.TabIndex = 22;
		this.ckbAvatar.Text = "Avatar";
		this.ckbAvatar.UseVisualStyleBackColor = true;
		this.ckbProfile.AutoSize = true;
		this.ckbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbProfile.Location = new System.Drawing.Point(253, 215);
		this.ckbProfile.Name = "ckbProfile";
		this.ckbProfile.Size = new System.Drawing.Size(62, 20);
		this.ckbProfile.TabIndex = 22;
		this.ckbProfile.Text = "Profile";
		this.ckbProfile.UseVisualStyleBackColor = true;
		this.ckbTinhTrang.AutoSize = true;
		this.ckbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbTinhTrang.Location = new System.Drawing.Point(355, 111);
		this.ckbTinhTrang.Name = "ckbTinhTrang";
		this.ckbTinhTrang.Size = new System.Drawing.Size(85, 20);
		this.ckbTinhTrang.TabIndex = 22;
		this.ckbTinhTrang.Text = "Ti\u0300nh tra\u0323ng";
		this.ckbTinhTrang.UseVisualStyleBackColor = true;
		this.ckbGhiChu.AutoSize = true;
		this.ckbGhiChu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbGhiChu.Location = new System.Drawing.Point(355, 163);
		this.ckbGhiChu.Name = "ckbGhiChu";
		this.ckbGhiChu.Size = new System.Drawing.Size(68, 20);
		this.ckbGhiChu.TabIndex = 22;
		this.ckbGhiChu.Text = "Ghi chú";
		this.ckbGhiChu.UseVisualStyleBackColor = true;
		this.ckbThuMuc.AutoSize = true;
		this.ckbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbThuMuc.Location = new System.Drawing.Point(355, 137);
		this.ckbThuMuc.Name = "ckbThuMuc";
		this.ckbThuMuc.Size = new System.Drawing.Size(77, 20);
		this.ckbThuMuc.TabIndex = 22;
		this.ckbThuMuc.Text = "Thư mục";
		this.ckbThuMuc.UseVisualStyleBackColor = true;
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFollow.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbFollow.Location = new System.Drawing.Point(31, 189);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(76, 20);
		this.ckbFollow.TabIndex = 22;
		this.ckbFollow.Text = "Theo do\u0303i";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.ckbInteractEnd.AutoSize = true;
		this.ckbInteractEnd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteractEnd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbInteractEnd.Location = new System.Drawing.Point(355, 85);
		this.ckbInteractEnd.Name = "ckbInteractEnd";
		this.ckbInteractEnd.Size = new System.Drawing.Size(111, 20);
		this.ckbInteractEnd.TabIndex = 22;
		this.ckbInteractEnd.Text = "Tương ta\u0301c cuô\u0301i";
		this.ckbInteractEnd.UseVisualStyleBackColor = true;
		this.ckbMailRecovery.AutoSize = true;
		this.ckbMailRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMailRecovery.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMailRecovery.Location = new System.Drawing.Point(355, 189);
		this.ckbMailRecovery.Name = "ckbMailRecovery";
		this.ckbMailRecovery.Size = new System.Drawing.Size(107, 20);
		this.ckbMailRecovery.TabIndex = 22;
		this.ckbMailRecovery.Text = "Mail khôi phục";
		this.ckbMailRecovery.UseVisualStyleBackColor = true;
		this.ckbPhone.AutoSize = true;
		this.ckbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbPhone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbPhone.Location = new System.Drawing.Point(355, 215);
		this.ckbPhone.Name = "ckbPhone";
		this.ckbPhone.Size = new System.Drawing.Size(61, 20);
		this.ckbPhone.TabIndex = 22;
		this.ckbPhone.Text = "Phone";
		this.ckbPhone.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(479, 295);
		base.Controls.Add(this.ckbThuMuc);
		base.Controls.Add(this.ckbPhone);
		base.Controls.Add(this.ckbMailRecovery);
		base.Controls.Add(this.ckbGhiChu);
		base.Controls.Add(this.ckbInteractEnd);
		base.Controls.Add(this.ckbTinhTrang);
		base.Controls.Add(this.ckbProfile);
		base.Controls.Add(this.ckbAvatar);
		base.Controls.Add(this.ckbNgayTao);
		base.Controls.Add(this.ckbProxy);
		base.Controls.Add(this.ckbUseragent);
		base.Controls.Add(this.ckbMa2FA);
		base.Controls.Add(this.ckbBackup);
		base.Controls.Add(this.ckbMatKhauMail);
		base.Controls.Add(this.ckbMatKhau);
		base.Controls.Add(this.ckbGioiTinh);
		base.Controls.Add(this.ckbNgaySinh);
		base.Controls.Add(this.ckbNhom);
		base.Controls.Add(this.ckbFollow);
		base.Controls.Add(this.ckbBanBe);
		base.Controls.Add(this.ckbTen);
		base.Controls.Add(this.ckbEmail);
		base.Controls.Add(this.ckbCookie);
		base.Controls.Add(this.ckbToken);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhHienThi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhHienThi_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
