using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDReviewPage : Form
{
	private JObject jobject_0;

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

	private Label label8;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private RichTextBox txtUid;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip toolTip_0;

	private Panel plTuongTacComment;

	private TextBox txtComment;

	private Label lblStatusComment;

	private Label label17;

	private RadioButton rbNo;

	private RadioButton rbYes;

	private Label label9;

	public fHDReviewPage(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDKetBanTepUid");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(ckbTuDongXoaUid);
		GClass29.smethod_1(lblStatusComment);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDReviewPage_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			if (Convert.ToInt32(jobject_0["typeReview"]) == 0)
			{
				rbNo.Checked = true;
			}
			else
			{
				rbYes.Checked = true;
			}
			txtUid.Text = jobject_0["txtUid"]!.ToString();
			ckbTuDongXoaUid.Checked = Convert.ToBoolean(jobject_0["ckbTuDongXoaUid"]);
			txtComment.Text = jobject_0["txtComment"]!.ToString();
		}
		catch
		{
		}
		method_1();
	}

	private void method_1()
	{
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
		List<string> list_ = txtUid.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		if (list_.Count == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách Id page cần đánh giá!"), 3);
			return;
		}
		list_ = txtComment.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		if (list_.Count == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nội dung đánh giá!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		int num = 0;
		if (rbYes.Checked)
		{
			num = 1;
		}
		gClass.method_5("type", num);
		gClass.method_5("txtUid", txtUid.Text.Trim());
		gClass.method_5("txtComment", txtComment.Text.Trim());
		gClass.method_5("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
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

	private void method_2(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUid.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Id cần đánh giá ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtComment.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatusComment.Text = string.Format(GClass29.smethod_0("Nội dung đánh giá ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDReviewPage));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plTuongTacComment = new System.Windows.Forms.Panel();
		this.label17 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.lblStatusComment = new System.Windows.Forms.Label();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.label9 = new System.Windows.Forms.Label();
		this.rbYes = new System.Windows.Forms.RadioButton();
		this.rbNo = new System.Windows.Forms.RadioButton();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plTuongTacComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Đánh giá page";
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
		this.panel1.Controls.Add(this.rbNo);
		this.panel1.Controls.Add(this.rbYes);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.plTuongTacComment);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.ckbTuDongXoaUid);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(690, 435);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plTuongTacComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacComment.Controls.Add(this.label17);
		this.plTuongTacComment.Controls.Add(this.txtComment);
		this.plTuongTacComment.Controls.Add(this.lblStatusComment);
		this.plTuongTacComment.Location = new System.Drawing.Point(345, 49);
		this.plTuongTacComment.Name = "plTuongTacComment";
		this.plTuongTacComment.Size = new System.Drawing.Size(332, 297);
		this.plTuongTacComment.TabIndex = 93;
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(196, 277);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(131, 16);
		this.label17.TabIndex = 188;
		this.label17.Text = "Spin content: {a|b|c}";
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Multiline = true;
		this.txtComment.Name = "txtComment";
		this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtComment.Size = new System.Drawing.Size(320, 246);
		this.txtComment.TabIndex = 1;
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblStatusComment.AutoSize = true;
		this.lblStatusComment.Location = new System.Drawing.Point(3, 5);
		this.lblStatusComment.Name = "lblStatusComment";
		this.lblStatusComment.Size = new System.Drawing.Size(136, 16);
		this.lblStatusComment.TabIndex = 0;
		this.lblStatusComment.Text = "Nội dung đánh giá (0):";
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(24, 194);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(295, 141);
		this.txtUid.TabIndex = 114;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(24, 358);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(184, 20);
		this.ckbTuDongXoaUid.TabIndex = 113;
		this.ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Id đa\u0303 đánh giá";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(222, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(220, 338);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(95, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi Id 1 dòng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(20, 172);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(184, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Id cần đánh giá (0):";
		this.nudDelayFrom.Location = new System.Drawing.Point(125, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(187, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(280, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(20, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(222, 80);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(125, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(187, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(280, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(35, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "page";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(20, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(95, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng page:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(20, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(349, 393);
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
		this.btnAdd.Location = new System.Drawing.Point(242, 393);
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
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 0;
		this.toolTip_0.ShowAlways = true;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(24, 142);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(56, 16);
		this.label9.TabIndex = 115;
		this.label9.Text = "Đề xuất:";
		this.rbYes.AutoSize = true;
		this.rbYes.Location = new System.Drawing.Point(125, 140);
		this.rbYes.Name = "rbYes";
		this.rbYes.Size = new System.Drawing.Size(40, 20);
		this.rbYes.TabIndex = 116;
		this.rbYes.TabStop = true;
		this.rbYes.Text = "Có";
		this.rbYes.UseVisualStyleBackColor = true;
		this.rbNo.AutoSize = true;
		this.rbNo.Location = new System.Drawing.Point(222, 140);
		this.rbNo.Name = "rbNo";
		this.rbNo.Size = new System.Drawing.Size(60, 20);
		this.rbNo.TabIndex = 116;
		this.rbNo.TabStop = true;
		this.rbNo.Text = "Không";
		this.rbNo.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(690, 435);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDReviewPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDReviewPage_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plTuongTacComment.ResumeLayout(false);
		this.plTuongTacComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
