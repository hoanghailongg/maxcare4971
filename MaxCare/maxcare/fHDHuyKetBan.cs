using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDHuyKetBan : Form
{
	private GClass17 gclass17_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private RadioButton rbHuyTheoUid;

	private RadioButton rbHuyNgauNhien;

	private Label label8;

	private Panel plHuyTheoUid;

	private Label lblStatus;

	private Label label9;

	private RichTextBox txtUid;

	private Panel plHuyNgauNhien;

	private Label label12;

	private RichTextBox txtUidKhongHuyKetBan;

	private Label label10;

	public fHDHuyKetBan(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDHuyKetBan");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(rbHuyNgauNhien);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(rbHuyTheoUid);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDHuyKetBan_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass17_0.method_2("nudSoLuongFrom");
			nudSoLuongTo.Value = gclass17_0.method_2("nudSoLuongTo");
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom");
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo");
			if (gclass17_0.method_2("typeHuyKetBan") == 0)
			{
				rbHuyNgauNhien.Checked = true;
			}
			else
			{
				rbHuyTheoUid.Checked = true;
			}
			txtUid.Text = gclass17_0.method_0("txtUid");
			txtUidKhongHuyKetBan.Text = gclass17_0.method_0("txtUidKhongHuyKetBan");
			rbHuyNgauNhien_CheckedChanged(null, null);
			rbHuyTheoUid_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		if (rbHuyNgauNhien.Checked)
		{
			gClass.method_5("typeHuyKetBan", 0);
		}
		else
		{
			gClass.method_5("typeHuyKetBan", 1);
		}
		gClass.method_5("txtUid", txtUid.Text);
		gClass.method_5("txtUidKhongHuyKetBan", txtUidKhongHuyKetBan.Text);
		string string_ = gClass.method_9();
		if (int_0 == 0)
		{
			if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class307.smethod_18(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass38.smethod_0(GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class307.smethod_20(string_2, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUid.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Uid cần hủy kết bạn ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void rbHuyNgauNhien_CheckedChanged(object sender, EventArgs e)
	{
		plHuyNgauNhien.Enabled = rbHuyNgauNhien.Checked;
	}

	private void rbHuyTheoUid_CheckedChanged(object sender, EventArgs e)
	{
		plHuyTheoUid.Enabled = rbHuyTheoUid.Checked;
	}

	private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUidKhongHuyKetBan.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label10.Text = string.Format(GClass29.smethod_0("Danh sách UID bạn bè cần giữ lại ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void label10_Click(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyKetBan));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label12 = new System.Windows.Forms.Label();
		this.txtUidKhongHuyKetBan = new System.Windows.Forms.RichTextBox();
		this.plHuyTheoUid = new System.Windows.Forms.Panel();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.plHuyNgauNhien = new System.Windows.Forms.Panel();
		this.label2 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.rbHuyTheoUid = new System.Windows.Forms.RadioButton();
		this.rbHuyNgauNhien = new System.Windows.Forms.RadioButton();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plHuyTheoUid.SuspendLayout();
		this.plHuyNgauNhien.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(687, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(656, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.label12);
		this.panel1.Controls.Add(this.txtUidKhongHuyKetBan);
		this.panel1.Controls.Add(this.plHuyTheoUid);
		this.panel1.Controls.Add(this.plHuyNgauNhien);
		this.panel1.Controls.Add(this.rbHuyTheoUid);
		this.panel1.Controls.Add(this.rbHuyNgauNhien);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(690, 411);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(539, 324);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(103, 16);
		this.label12.TabIndex = 115;
		this.label12.Text = "(Mỗi Uid 1 dòng)";
		this.label12.Click += new System.EventHandler(label12_Click);
		this.txtUidKhongHuyKetBan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtUidKhongHuyKetBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUidKhongHuyKetBan.Location = new System.Drawing.Point(385, 102);
		this.txtUidKhongHuyKetBan.Name = "txtUidKhongHuyKetBan";
		this.txtUidKhongHuyKetBan.Size = new System.Drawing.Size(253, 221);
		this.txtUidKhongHuyKetBan.TabIndex = 117;
		this.txtUidKhongHuyKetBan.Text = "";
		this.txtUidKhongHuyKetBan.WordWrap = false;
		this.txtUidKhongHuyKetBan.TextChanged += new System.EventHandler(txtUidKhongHuyKetBan_TextChanged);
		this.plHuyTheoUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plHuyTheoUid.Controls.Add(this.lblStatus);
		this.plHuyTheoUid.Controls.Add(this.label9);
		this.plHuyTheoUid.Controls.Add(this.txtUid);
		this.plHuyTheoUid.Location = new System.Drawing.Point(59, 208);
		this.plHuyTheoUid.Name = "plHuyTheoUid";
		this.plHuyTheoUid.Size = new System.Drawing.Size(267, 134);
		this.plHuyTheoUid.TabIndex = 118;
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 3);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(209, 16);
		this.lblStatus.TabIndex = 116;
		this.lblStatus.Text = "Danh sa\u0301ch Uid cần hủy kết bạn (0):";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(161, 112);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(103, 16);
		this.label9.TabIndex = 115;
		this.label9.Text = "(Mỗi Uid 1 dòng)";
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(7, 23);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(253, 86);
		this.txtUid.TabIndex = 117;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.plHuyNgauNhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plHuyNgauNhien.Controls.Add(this.label2);
		this.plHuyNgauNhien.Controls.Add(this.label4);
		this.plHuyNgauNhien.Controls.Add(this.label3);
		this.plHuyNgauNhien.Controls.Add(this.nudSoLuongFrom);
		this.plHuyNgauNhien.Controls.Add(this.nudSoLuongTo);
		this.plHuyNgauNhien.Location = new System.Drawing.Point(59, 155);
		this.plHuyNgauNhien.Name = "plHuyNgauNhien";
		this.plHuyNgauNhien.Size = new System.Drawing.Size(267, 27);
		this.plHuyNgauNhien.TabIndex = 118;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(3, 3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(64, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng:";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(225, 3);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label3.Location = new System.Drawing.Point(135, 3);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(73, 1);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.nudSoLuongTo.Location = new System.Drawing.Point(167, 1);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.rbHuyTheoUid.AutoSize = true;
		this.rbHuyTheoUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHuyTheoUid.Location = new System.Drawing.Point(46, 185);
		this.rbHuyTheoUid.Name = "rbHuyTheoUid";
		this.rbHuyTheoUid.Size = new System.Drawing.Size(146, 20);
		this.rbHuyTheoUid.TabIndex = 47;
		this.rbHuyTheoUid.Text = "Hủy kết bạn theo UID";
		this.rbHuyTheoUid.UseVisualStyleBackColor = true;
		this.rbHuyTheoUid.CheckedChanged += new System.EventHandler(rbHuyTheoUid_CheckedChanged);
		this.rbHuyNgauNhien.AutoSize = true;
		this.rbHuyNgauNhien.Checked = true;
		this.rbHuyNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHuyNgauNhien.Location = new System.Drawing.Point(46, 132);
		this.rbHuyNgauNhien.Name = "rbHuyNgauNhien";
		this.rbHuyNgauNhien.Size = new System.Drawing.Size(177, 20);
		this.rbHuyNgauNhien.TabIndex = 47;
		this.rbHuyNgauNhien.TabStop = true;
		this.rbHuyNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
		this.rbHuyNgauNhien.UseVisualStyleBackColor = true;
		this.rbHuyNgauNhien.CheckedChanged += new System.EventHandler(rbHuyNgauNhien_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(226, 78);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 78);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(192, 80);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(285, 80);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(382, 83);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(223, 16);
		this.label10.TabIndex = 44;
		this.label10.Text = "Danh sách UID bạn bè cần giữ lại (0):";
		this.label10.Click += new System.EventHandler(label10_Click);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(27, 110);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(135, 16);
		this.label8.TabIndex = 44;
		this.label8.Text = "Tùy chọn hủy kết bạn:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 80);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(352, 364);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(245, 364);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(687, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(690, 411);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDHuyKetBan_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plHuyTheoUid.ResumeLayout(false);
		this.plHuyTheoUid.PerformLayout();
		this.plHuyNgauNhien.ResumeLayout(false);
		this.plHuyNgauNhien.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
