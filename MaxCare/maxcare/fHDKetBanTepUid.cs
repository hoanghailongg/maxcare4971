using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDKetBanTepUid : Form
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

	private Panel plTuongTac;

	private Label label54;

	private Label label19;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private CheckBox ckbTuongTacLike;

	private Label label46;

	private NumericUpDown nudTuongTacDelayFrom;

	private Label label47;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudTuongTacDelayTo;

	private Label label67;

	private Label label48;

	private CheckBox ckbTuongTac;

	private Panel plTuongTacComment;

	private TextBox txtComment;

	private Label lblStatusComment;

	private CheckBox ckbTuongTacComment;

	private LinkLabel linkLabel1;

	private Label label17;

	public fHDKetBanTepUid(string string_3, int int_1 = 0, string string_4 = "")
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
		GClass29.smethod_1(ckbTuongTac);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(label67);
		GClass29.smethod_1(label54);
		GClass29.smethod_1(label46);
		GClass29.smethod_1(label48);
		GClass29.smethod_1(label47);
		GClass29.smethod_1(ckbTuongTacComment);
		GClass29.smethod_1(lblStatusComment);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDKetBanTepUid_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			ckbTuDongXoaUid.Checked = Convert.ToBoolean(jobject_0["ckbKetBanTrungNhau"]);
			txtUid.Text = jobject_0["txtUid"]!.ToString();
			ckbTuongTac.Checked = Convert.ToBoolean(jobject_0["ckbTuongTac"]);
			nudSoLuongBaiVietFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietFrom"]);
			nudSoLuongBaiVietTo.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietTo"]);
			nudTuongTacDelayFrom.Value = Convert.ToInt32(jobject_0["nudTuongTacDelayFrom"]);
			nudTuongTacDelayTo.Value = Convert.ToInt32(jobject_0["nudTuongTacDelayTo"]);
			ckbTuongTacLike.Checked = Convert.ToBoolean(jobject_0["ckbTuongTacLike"]);
			ckbTuongTacComment.Checked = Convert.ToBoolean(jobject_0["ckbTuongTacComment"]);
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
		ckbTuongTac_CheckedChanged(null, null);
		ckbTuongTacComment_CheckedChanged(null, null);
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
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid cần kết bạn!"), 3);
			return;
		}
		if (ckbTuongTac.Checked && ckbTuongTacComment.Checked)
		{
			list_ = txtComment.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			if (list_.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nội dung bình luận!"), 3);
				return;
			}
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbKetBanTrungNhau", ckbTuDongXoaUid.Checked);
		gClass.method_5("txtUid", txtUid.Text.Trim());
		gClass.method_5("ckbTuongTac", ckbTuongTac.Checked);
		gClass.method_5("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.method_5("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.method_5("nudTuongTacDelayFrom", nudTuongTacDelayFrom.Value);
		gClass.method_5("nudTuongTacDelayTo", nudTuongTacDelayTo.Value);
		gClass.method_5("ckbTuongTacLike", ckbTuongTacLike.Checked);
		gClass.method_5("ckbTuongTacComment", ckbTuongTacComment.Checked);
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
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Uid cần kết bạn ({0}):"), list_.Count.ToString());
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
			lblStatusComment.Text = string.Format(GClass29.smethod_0("Nội dung bình luận ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuongTac.Checked;
	}

	private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacComment.Enabled = ckbTuongTacComment.Checked;
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUid));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.plTuongTacComment = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.lblStatusComment = new System.Windows.Forms.Label();
		this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
		this.label54 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
		this.label46 = new System.Windows.Forms.Label();
		this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label47 = new System.Windows.Forms.Label();
		this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label67 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.ckbTuongTac = new System.Windows.Forms.CheckBox();
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
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label17 = new System.Windows.Forms.Label();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plTuongTac.SuspendLayout();
		this.plTuongTacComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp UID";
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
		this.panel1.Controls.Add(this.plTuongTac);
		this.panel1.Controls.Add(this.ckbTuongTac);
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
		this.panel1.Size = new System.Drawing.Size(690, 406);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.plTuongTacComment);
		this.plTuongTac.Controls.Add(this.ckbTuongTacComment);
		this.plTuongTac.Controls.Add(this.label54);
		this.plTuongTac.Controls.Add(this.label19);
		this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.plTuongTac.Controls.Add(this.ckbTuongTacLike);
		this.plTuongTac.Controls.Add(this.label46);
		this.plTuongTac.Controls.Add(this.nudTuongTacDelayFrom);
		this.plTuongTac.Controls.Add(this.label47);
		this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietTo);
		this.plTuongTac.Controls.Add(this.nudTuongTacDelayTo);
		this.plTuongTac.Controls.Add(this.label67);
		this.plTuongTac.Controls.Add(this.label48);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(360, 74);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(310, 272);
		this.plTuongTac.TabIndex = 116;
		this.plTuongTacComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacComment.Controls.Add(this.linkLabel1);
		this.plTuongTacComment.Controls.Add(this.label17);
		this.plTuongTacComment.Controls.Add(this.txtComment);
		this.plTuongTacComment.Controls.Add(this.lblStatusComment);
		this.plTuongTacComment.Location = new System.Drawing.Point(25, 113);
		this.plTuongTacComment.Name = "plTuongTacComment";
		this.plTuongTacComment.Size = new System.Drawing.Size(278, 151);
		this.plTuongTacComment.TabIndex = 93;
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Multiline = true;
		this.txtComment.Name = "txtComment";
		this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtComment.Size = new System.Drawing.Size(261, 100);
		this.txtComment.TabIndex = 1;
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblStatusComment.AutoSize = true;
		this.lblStatusComment.Location = new System.Drawing.Point(3, 5);
		this.lblStatusComment.Name = "lblStatusComment";
		this.lblStatusComment.Size = new System.Drawing.Size(140, 16);
		this.lblStatusComment.TabIndex = 0;
		this.lblStatusComment.Text = "Nội dung bình luận (0):";
		this.ckbTuongTacComment.AutoSize = true;
		this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacComment.Location = new System.Drawing.Point(7, 88);
		this.ckbTuongTacComment.Name = "ckbTuongTacComment";
		this.ckbTuongTacComment.Size = new System.Drawing.Size(131, 20);
		this.ckbTuongTacComment.TabIndex = 92;
		this.ckbTuongTacComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.ckbTuongTacComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(ckbTuongTacComment_CheckedChanged);
		this.label54.AutoSize = true;
		this.label54.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label54.Location = new System.Drawing.Point(240, 7);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(25, 16);
		this.label54.TabIndex = 89;
		this.label54.Text = "ba\u0300i";
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(4, 7);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(73, 16);
		this.label19.TabIndex = 89;
		this.label19.Text = "Sô\u0301 ba\u0300i viê\u0301t:";
		this.nudSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(114, 4);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 2;
		this.nudSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacLike.AutoSize = true;
		this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacLike.Location = new System.Drawing.Point(7, 62);
		this.ckbTuongTacLike.Name = "ckbTuongTacLike";
		this.ckbTuongTacLike.Size = new System.Drawing.Size(49, 20);
		this.ckbTuongTacLike.TabIndex = 5;
		this.ckbTuongTacLike.Text = "Like";
		this.ckbTuongTacLike.UseVisualStyleBackColor = true;
		this.label46.AutoSize = true;
		this.label46.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label46.Location = new System.Drawing.Point(4, 34);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(100, 16);
		this.label46.TabIndex = 89;
		this.label46.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(114, 31);
		this.nudTuongTacDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
		this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacDelayFrom.TabIndex = 3;
		this.nudTuongTacDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label47.AutoSize = true;
		this.label47.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label47.Location = new System.Drawing.Point(240, 36);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(31, 16);
		this.label47.TabIndex = 91;
		this.label47.Text = "giây";
		this.nudSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(191, 5);
		this.nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
		this.nudSoLuongBaiVietTo.TabIndex = 4;
		this.nudSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayTo.Location = new System.Drawing.Point(191, 32);
		this.nudTuongTacDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
		this.nudTuongTacDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacDelayTo.TabIndex = 4;
		this.nudTuongTacDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label67.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label67.Location = new System.Drawing.Point(159, 7);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(29, 16);
		this.label67.TabIndex = 91;
		this.label67.Text = "đê\u0301n";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label48.Location = new System.Drawing.Point(159, 36);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(29, 16);
		this.label48.TabIndex = 91;
		this.label48.Text = "đê\u0301n";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbTuongTac.AutoSize = true;
		this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTac.Location = new System.Drawing.Point(342, 51);
		this.ckbTuongTac.Name = "ckbTuongTac";
		this.ckbTuongTac.Size = new System.Drawing.Size(185, 20);
		this.ckbTuongTac.TabIndex = 115;
		this.ckbTuongTac.Text = "Tương tác trước khi kết bạn";
		this.ckbTuongTac.UseVisualStyleBackColor = true;
		this.ckbTuongTac.CheckedChanged += new System.EventHandler(ckbTuongTac_CheckedChanged);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(24, 163);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(295, 141);
		this.txtUid.TabIndex = 114;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(23, 326);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(249, 20);
		this.ckbTuDongXoaUid.TabIndex = 113;
		this.ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 gư\u0309i lơ\u0300i mơ\u0300i kê\u0301t ba\u0323n";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(222, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(220, 307);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(103, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi Uid 1 dòng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(20, 141);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(185, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Uid cần kết bạn (0):";
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
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(20, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
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
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(20, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(89, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(20, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(355, 362);
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
		this.btnAdd.Location = new System.Drawing.Point(248, 362);
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
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(166, 130);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 189;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(4, 130);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(132, 16);
		this.label17.TabIndex = 188;
		this.label17.Text = "Spin content: {a|b|c}";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(690, 406);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTepUid_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		this.plTuongTacComment.ResumeLayout(false);
		this.plTuongTacComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
