using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTimKiemGoogle : Form
{
	private GClass17 gclass17_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label8;

	private Label lblStatus;

	private RichTextBox txtTuKhoa;

	private NumericUpDown nudCountTimeScrollTo;

	private NumericUpDown nudCountLinkClickTo;

	private NumericUpDown nudCountPageTo;

	private NumericUpDown nudCountTuKhoaTo;

	private NumericUpDown nudCountTimeScrollFrom;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown nudCountPageFrom;

	private NumericUpDown nudCountTuKhoaFrom;

	private Label label4;

	private Label label17;

	private Label label14;

	private Label label3;

	private Label label13;

	private Label label16;

	private Label label12;

	private Label label11;

	private Label label15;

	private Label label10;

	private Label label9;

	public fHDTimKiemGoogle(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDTimKiemGoogle").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Ti\u0300m kiê\u0301m Google');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDTimKiemGoogle");
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
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label14);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDTimKiemGoogle_Load(object sender, EventArgs e)
	{
		try
		{
			nudCountTuKhoaFrom.Value = gclass17_0.method_2("nudCountTuKhoaFrom", 1);
			nudCountTuKhoaTo.Value = gclass17_0.method_2("nudCountTuKhoaTo", 1);
			nudCountPageFrom.Value = gclass17_0.method_2("nudCountPageFrom", 3);
			nudCountPageTo.Value = gclass17_0.method_2("nudCountPageTo", 3);
			nudCountLinkClickFrom.Value = gclass17_0.method_2("nudCountLinkClickFrom", 3);
			nudCountLinkClickTo.Value = gclass17_0.method_2("nudCountLinkClickTo", 5);
			nudCountTimeScrollFrom.Value = gclass17_0.method_2("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass17_0.method_2("nudCountTimeScrollTo", 30);
			txtTuKhoa.Text = gclass17_0.method_0("txtTuKhoa");
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
		gClass.method_5("nudCountTuKhoaFrom", nudCountTuKhoaFrom.Value);
		gClass.method_5("nudCountTuKhoaTo", nudCountTuKhoaTo.Value);
		gClass.method_5("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.method_5("nudCountPageTo", nudCountPageTo.Value);
		gClass.method_5("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.method_5("nudCountLinkClickTo", nudCountLinkClickTo.Value);
		gClass.method_5("nudCountTimeScrollFrom", nudCountTimeScrollFrom.Value);
		gClass.method_5("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.method_5("txtTuKhoa", txtTuKhoa.Text.Trim());
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

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtTuKhoa.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web ({0}):"), list_.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTimKiemGoogle));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtTuKhoa = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountTuKhoaTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountTuKhoaFrom = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Ti\u0300m kiê\u0301m Google";
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
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
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
		this.panel1.Controls.Add(this.txtTuKhoa);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.nudCountTimeScrollTo);
		this.panel1.Controls.Add(this.nudCountLinkClickTo);
		this.panel1.Controls.Add(this.nudCountPageTo);
		this.panel1.Controls.Add(this.nudCountTuKhoaTo);
		this.panel1.Controls.Add(this.nudCountTimeScrollFrom);
		this.panel1.Controls.Add(this.nudCountLinkClickFrom);
		this.panel1.Controls.Add(this.nudCountPageFrom);
		this.panel1.Controls.Add(this.nudCountTuKhoaFrom);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label17);
		this.panel1.Controls.Add(this.label14);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label13);
		this.panel1.Controls.Add(this.label16);
		this.panel1.Controls.Add(this.label12);
		this.panel1.Controls.Add(this.label11);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 428);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtTuKhoa.Location = new System.Drawing.Point(30, 94);
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.Size = new System.Drawing.Size(298, 142);
		this.txtTuKhoa.TabIndex = 42;
		this.txtTuKhoa.Text = "";
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(28, 239);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(134, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi nội dung 1 do\u0300ng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(27, 75);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(202, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web (0):";
		this.nudCountTimeScrollTo.Location = new System.Drawing.Point(263, 344);
		this.nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollTo.TabIndex = 2;
		this.nudCountLinkClickTo.Location = new System.Drawing.Point(263, 316);
		this.nudCountLinkClickTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
		this.nudCountLinkClickTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickTo.TabIndex = 2;
		this.nudCountPageTo.Location = new System.Drawing.Point(263, 288);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountPageTo.TabIndex = 2;
		this.nudCountTuKhoaTo.Location = new System.Drawing.Point(263, 260);
		this.nudCountTuKhoaTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
		this.nudCountTuKhoaTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTuKhoaTo.TabIndex = 2;
		this.nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 344);
		this.nudCountTimeScrollFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
		this.nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollFrom.TabIndex = 1;
		this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 316);
		this.nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickFrom.TabIndex = 1;
		this.nudCountPageFrom.Location = new System.Drawing.Point(192, 288);
		this.nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageFrom.Name = "nudCountPageFrom";
		this.nudCountPageFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountPageFrom.TabIndex = 1;
		this.nudCountTuKhoaFrom.Location = new System.Drawing.Point(192, 260);
		this.nudCountTuKhoaFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTuKhoaFrom.Name = "nudCountTuKhoaFrom";
		this.nudCountTuKhoaFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountTuKhoaFrom.TabIndex = 1;
		this.label4.Location = new System.Drawing.Point(231, 346);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 37;
		this.label4.Text = "đê\u0301n";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label17.Location = new System.Drawing.Point(231, 318);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(29, 16);
		this.label17.TabIndex = 37;
		this.label17.Text = "đê\u0301n";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.Location = new System.Drawing.Point(231, 290);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(299, 346);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(31, 16);
		this.label3.TabIndex = 35;
		this.label3.Text = "giây";
		this.label13.Location = new System.Drawing.Point(231, 262);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 37;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(299, 318);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(27, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "link";
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(299, 290);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(38, 16);
		this.label12.TabIndex = 35;
		this.label12.Text = "trang";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(299, 262);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(51, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "tư\u0300 khóa";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(28, 318);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(165, 16);
		this.label15.TabIndex = 34;
		this.label15.Text = "Click random link trên web:";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 290);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(151, 16);
		this.label10.TabIndex = 34;
		this.label10.Text = "Sô\u0301 trang ti\u0300m kiê\u0301m tô\u0301i đa:";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(27, 262);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(121, 16);
		this.label9.TabIndex = 32;
		this.label9.Text = "Sô\u0301 tư\u0300 kho\u0301a câ\u0300n ti\u0300m:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 346);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(147, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thơ\u0300i gian lươ\u0301t trên web:";
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
		this.btnCancel.Location = new System.Drawing.Point(189, 384);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 384);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
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
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(362, 428);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTimKiemGoogle";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTimKiemGoogle_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
