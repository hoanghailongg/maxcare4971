using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapPassKhoiPhuc : Form
{
	public static bool bool_0;

	public static bool bool_1;

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

	private CheckBox ckbThemKyTu;

	private Panel panel1;

	private RadioButton rbTuDatKyTu;

	private RadioButton rbRandomKyTu;

	private TextBox txtKyTu;

	public fNhapPassKhoiPhuc(bool bool_2 = false)
	{
		InitializeComponent();
		method_0();
		gclass17_0 = new GClass17("configGeneral");
		bool_0 = false;
		bool_1 = bool_2;
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
		if (ckbThemKyTu.Checked && rbTuDatKyTu.Checked && txtKyTu.Text.Trim() == "")
		{
			GClass38.smethod_0("Vui lòng nhập ký tự cần thêm!", 4);
			return;
		}
		int num = 0;
		if (rbPassNgauNhien.Checked)
		{
			num = 1;
		}
		gclass17_0.method_5("typePass", num);
		gclass17_0.method_5("txtPass", txtPass.Text.Trim());
		gclass17_0.method_5("ckbThemKyTu", ckbThemKyTu.Checked);
		gclass17_0.method_5("rbRandomKyTu", rbRandomKyTu.Checked);
		gclass17_0.method_5("rbTuDatKyTu", rbTuDatKyTu.Checked);
		gclass17_0.method_5("txtKyTu", txtKyTu.Text.Trim());
		gclass17_0.method_8();
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapPassKhoiPhuc_Load(object sender, EventArgs e)
	{
		if (bool_1)
		{
			ckbThemKyTu.Visible = false;
			panel1.Visible = false;
			base.Size = new Size(310, 170);
		}
		if (gclass17_0.method_2("typePass") == 0)
		{
			rbPassTuDat.Checked = true;
		}
		else
		{
			rbPassNgauNhien.Checked = true;
		}
		txtPass.Text = gclass17_0.method_0("txtPass");
		ckbThemKyTu.Checked = gclass17_0.method_3("ckbThemKyTu");
		rbRandomKyTu.Checked = gclass17_0.method_3("rbRandomKyTu");
		rbTuDatKyTu.Checked = gclass17_0.method_3("rbTuDatKyTu");
		txtKyTu.Text = gclass17_0.method_0("txtKyTu");
		rbPassTuDat_CheckedChanged(null, null);
		rbTuDatKyTu_CheckedChanged(null, null);
		ckbThemKyTu_CheckedChanged(null, null);
	}

	private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
	{
		txtPass.Enabled = rbPassTuDat.Checked;
	}

	private void rbTuDatKyTu_CheckedChanged(object sender, EventArgs e)
	{
		txtKyTu.Enabled = rbTuDatKyTu.Checked;
	}

	private void ckbThemKyTu_CheckedChanged(object sender, EventArgs e)
	{
		panel1.Enabled = ckbThemKyTu.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapPassKhoiPhuc));
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
		this.ckbThemKyTu = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.rbTuDatKyTu = new System.Windows.Forms.RadioButton();
		this.rbRandomKyTu = new System.Windows.Forms.RadioButton();
		this.txtKyTu = new System.Windows.Forms.TextBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(310, 34);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(308, 28);
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
		this.btnMinimize.Location = new System.Drawing.Point(276, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(308, 28);
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
		this.btnCancel.Location = new System.Drawing.Point(161, 215);
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
		this.btnAdd.Location = new System.Drawing.Point(57, 215);
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
		this.rbPassNgauNhien.Location = new System.Drawing.Point(12, 73);
		this.rbPassNgauNhien.Name = "rbPassNgauNhien";
		this.rbPassNgauNhien.Size = new System.Drawing.Size(118, 20);
		this.rbPassNgauNhien.TabIndex = 5;
		this.rbPassNgauNhien.TabStop = true;
		this.rbPassNgauNhien.Text = "Pass ngẫu nhiên";
		this.rbPassNgauNhien.UseVisualStyleBackColor = true;
		this.rbPassTuDat.AutoSize = true;
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
		this.txtPass.Size = new System.Drawing.Size(168, 20);
		this.txtPass.TabIndex = 7;
		this.ckbThemKyTu.AutoSize = true;
		this.ckbThemKyTu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbThemKyTu.Location = new System.Drawing.Point(12, 108);
		this.ckbThemKyTu.Name = "ckbThemKyTu";
		this.ckbThemKyTu.Size = new System.Drawing.Size(230, 20);
		this.ckbThemKyTu.TabIndex = 8;
		this.ckbThemKyTu.Text = "Thêm kí tự vào cuối mail khôi phục:";
		this.ckbThemKyTu.UseVisualStyleBackColor = true;
		this.ckbThemKyTu.CheckedChanged += new System.EventHandler(ckbThemKyTu_CheckedChanged);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.rbTuDatKyTu);
		this.panel1.Controls.Add(this.rbRandomKyTu);
		this.panel1.Controls.Add(this.txtKyTu);
		this.panel1.Location = new System.Drawing.Point(34, 135);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(265, 63);
		this.panel1.TabIndex = 9;
		this.rbTuDatKyTu.AutoSize = true;
		this.rbTuDatKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuDatKyTu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbTuDatKyTu.Location = new System.Drawing.Point(7, 33);
		this.rbTuDatKyTu.Name = "rbTuDatKyTu";
		this.rbTuDatKyTu.Size = new System.Drawing.Size(68, 20);
		this.rbTuDatKyTu.TabIndex = 7;
		this.rbTuDatKyTu.TabStop = true;
		this.rbTuDatKyTu.Text = "Tự đặt:";
		this.rbTuDatKyTu.UseVisualStyleBackColor = true;
		this.rbTuDatKyTu.CheckedChanged += new System.EventHandler(rbTuDatKyTu_CheckedChanged);
		this.rbRandomKyTu.AutoSize = true;
		this.rbRandomKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbRandomKyTu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbRandomKyTu.Location = new System.Drawing.Point(7, 7);
		this.rbRandomKyTu.Name = "rbRandomKyTu";
		this.rbRandomKyTu.Size = new System.Drawing.Size(89, 20);
		this.rbRandomKyTu.TabIndex = 7;
		this.rbRandomKyTu.TabStop = true;
		this.rbRandomKyTu.Text = "Ngẫu nhiên";
		this.rbRandomKyTu.UseVisualStyleBackColor = true;
		this.txtKyTu.Location = new System.Drawing.Point(92, 33);
		this.txtKyTu.Name = "txtKyTu";
		this.txtKyTu.Size = new System.Drawing.Size(168, 20);
		this.txtKyTu.TabIndex = 7;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(310, 250);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.ckbThemKyTu);
		base.Controls.Add(this.txtPass);
		base.Controls.Add(this.rbPassTuDat);
		base.Controls.Add(this.rbPassNgauNhien);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapPassKhoiPhuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fNhapPassKhoiPhuc_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
