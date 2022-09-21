using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTruyCapWebsite : Form
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

	private RichTextBox txtLinkWeb;

	private NumericUpDown nudCountLinkClickTo;

	private NumericUpDown nudCountLinkTo;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown nudCountLinkFrom;

	private Label label17;

	private Label label13;

	private Label label16;

	private Label label11;

	private Label label15;

	private Label label9;

	private CheckBox ckbLuot;

	private NumericUpDown nudCountTimeScrollTo;

	private Label label2;

	private Label label3;

	private Label label4;

	private NumericUpDown nudCountTimeScrollFrom;

	public fHDTruyCapWebsite(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDTruyCapWebsite").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTruyCapWebsite', 'Truy cập Website');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDTruyCapWebsite");
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
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(ckbLuot);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDTruyCapWebsite_Load(object sender, EventArgs e)
	{
		try
		{
			nudCountLinkFrom.Value = gclass17_0.method_2("nudCountLinkFrom", 1);
			nudCountLinkTo.Value = gclass17_0.method_2("nudCountLinkTo", 1);
			nudCountLinkClickFrom.Value = gclass17_0.method_2("nudCountLinkClickFrom", 3);
			nudCountLinkClickTo.Value = gclass17_0.method_2("nudCountLinkClickTo", 5);
			nudCountTimeScrollFrom.Value = gclass17_0.method_2("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass17_0.method_2("nudCountTimeScrollTo", 30);
			txtLinkWeb.Text = gclass17_0.method_0("txtLinkWeb");
			ckbLuot.Checked = gclass17_0.method_3("ckbLuot", bool_0: true);
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
		gClass.method_5("nudCountLinkFrom", nudCountLinkFrom.Value);
		gClass.method_5("nudCountLinkTo", nudCountLinkTo.Value);
		gClass.method_5("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.method_5("nudCountLinkClickTo", nudCountLinkClickTo.Value);
		gClass.method_5("nudCountTimeScrollFrom", nudCountTimeScrollFrom.Value);
		gClass.method_5("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.method_5("txtLinkWeb", txtLinkWeb.Text.Trim());
		gClass.method_5("ckbLuot", ckbLuot.Checked);
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

	private void txtLinkWeb_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtLinkWeb.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Link Web ({0}):"), list_.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTruyCapWebsite));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbLuot = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.txtLinkWeb = new System.Windows.Forms.RichTextBox();
		this.nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkFrom).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Truy cập Website";
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
		this.panel1.Controls.Add(this.nudCountTimeScrollTo);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.ckbLuot);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.txtLinkWeb);
		this.panel1.Controls.Add(this.nudCountTimeScrollFrom);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.nudCountLinkClickTo);
		this.panel1.Controls.Add(this.nudCountLinkTo);
		this.panel1.Controls.Add(this.nudCountLinkClickFrom);
		this.panel1.Controls.Add(this.nudCountLinkFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label17);
		this.panel1.Controls.Add(this.label13);
		this.panel1.Controls.Add(this.label16);
		this.panel1.Controls.Add(this.label11);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 419);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.nudCountTimeScrollTo.Location = new System.Drawing.Point(263, 316);
		this.nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollTo.TabIndex = 2;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(28, 318);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(121, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thời gian trên web:";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(299, 318);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(31, 16);
		this.label3.TabIndex = 35;
		this.label3.Text = "giây";
		this.ckbLuot.AutoSize = true;
		this.ckbLuot.Checked = true;
		this.ckbLuot.CheckState = System.Windows.Forms.CheckState.Checked;
		this.ckbLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLuot.Location = new System.Drawing.Point(30, 343);
		this.ckbLuot.Name = "ckbLuot";
		this.ckbLuot.Size = new System.Drawing.Size(158, 20);
		this.ckbLuot.TabIndex = 43;
		this.ckbLuot.Text = "Tự động lướt trên Web";
		this.ckbLuot.UseVisualStyleBackColor = true;
		this.label4.Location = new System.Drawing.Point(231, 318);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 37;
		this.label4.Text = "đê\u0301n";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtLinkWeb.Location = new System.Drawing.Point(30, 94);
		this.txtLinkWeb.Name = "txtLinkWeb";
		this.txtLinkWeb.Size = new System.Drawing.Size(298, 142);
		this.txtLinkWeb.TabIndex = 42;
		this.txtLinkWeb.Text = "";
		this.txtLinkWeb.WordWrap = false;
		this.txtLinkWeb.TextChanged += new System.EventHandler(txtLinkWeb_TextChanged);
		this.nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 316);
		this.nudCountTimeScrollFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
		this.nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollFrom.TabIndex = 1;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(28, 239);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(134, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi nội dung 1 do\u0300ng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(27, 75);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(149, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Link Web (0):";
		this.nudCountLinkClickTo.Location = new System.Drawing.Point(263, 288);
		this.nudCountLinkClickTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
		this.nudCountLinkClickTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickTo.TabIndex = 2;
		this.nudCountLinkTo.Location = new System.Drawing.Point(263, 260);
		this.nudCountLinkTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkTo.Name = "nudCountLinkTo";
		this.nudCountLinkTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkTo.TabIndex = 2;
		this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 288);
		this.nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickFrom.TabIndex = 1;
		this.nudCountLinkFrom.Location = new System.Drawing.Point(192, 260);
		this.nudCountLinkFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkFrom.Name = "nudCountLinkFrom";
		this.nudCountLinkFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label17.Location = new System.Drawing.Point(231, 290);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(29, 16);
		this.label17.TabIndex = 37;
		this.label17.Text = "đê\u0301n";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label13.Location = new System.Drawing.Point(231, 262);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 37;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(299, 290);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(27, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "link";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(299, 262);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(27, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "link";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(28, 290);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(165, 16);
		this.label15.TabIndex = 34;
		this.label15.Text = "Click random link trên web:";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(27, 262);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(153, 16);
		this.label9.TabIndex = 32;
		this.label9.Text = "Sô\u0301 link web cần truy cập:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 375);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 375);
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
		base.ClientSize = new System.Drawing.Size(362, 419);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTruyCapWebsite";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTruyCapWebsite_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
