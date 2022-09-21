using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatch : Form
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

	private NumericUpDown nudTimeWatchTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudTimeWatchFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label label5;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private Label label8;

	private Label lblStatus;

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private Panel plCountComment;

	private NumericUpDown nudCountCommentFrom;

	private Label label13;

	private Label label14;

	private NumericUpDown nudCountCommentTo;

	private Panel plCountShareWall;

	private NumericUpDown nudCountShareFrom;

	private Label label11;

	private Label label12;

	private NumericUpDown nudCountShareTo;

	private Panel plCountLike;

	private NumericUpDown nudCountLikeFrom;

	private Label label9;

	private Label label10;

	private NumericUpDown nudCountLikeTo;

	private RichTextBox txtComment;

	private Button button2;

	private LinkLabel linkLabel1;

	private Panel plFollow;

	private NumericUpDown nudFollowFrom;

	private Label label15;

	private Label label16;

	private NumericUpDown nudFollowTo;

	private CheckBox ckbFollow;

	public fHDXemWatch(string string_3, int int_1 = 0, string string_4 = "")
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
			DataTable dataTable2 = Class307.smethod_13("", "HDXemWatch");
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
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label14);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDXemWatch_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass17_0.method_2("nudSoLuongFrom");
			nudSoLuongTo.Value = gclass17_0.method_2("nudSoLuongTo");
			nudTimeWatchFrom.Value = gclass17_0.method_2("nudTimeWatchFrom");
			nudTimeWatchTo.Value = gclass17_0.method_2("nudTimeWatchTo");
			ckbInteract.Checked = gclass17_0.method_3("ckbInteract");
			ckbComment.Checked = gclass17_0.method_3("ckbComment");
			ckbShareWall.Checked = gclass17_0.method_3("ckbShareWall");
			txtComment.Text = gclass17_0.method_0("txtComment");
			nudCountLikeFrom.Value = gclass17_0.method_2("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass17_0.method_2("nudCountLikeTo", 3);
			nudCountShareFrom.Value = gclass17_0.method_2("nudCountShareFrom", 1);
			nudCountShareTo.Value = gclass17_0.method_2("nudCountShareTo", 3);
			nudCountCommentFrom.Value = gclass17_0.method_2("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass17_0.method_2("nudCountCommentTo", 3);
			ckbFollow.Checked = gclass17_0.method_3("ckbFollow");
			nudFollowFrom.Value = gclass17_0.method_2("nudFollowFrom", 1);
			nudFollowTo.Value = gclass17_0.method_2("nudFollowTo", 2);
		}
		catch
		{
		}
		method_1();
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
		if (ckbComment.Checked)
		{
			List<string> list_ = txtComment.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			if (list_.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudTimeWatchFrom", nudTimeWatchFrom.Value);
		gClass.method_5("nudTimeWatchTo", nudTimeWatchTo.Value);
		gClass.method_5("ckbInteract", ckbInteract.Checked);
		gClass.method_5("ckbShareWall", ckbShareWall.Checked);
		gClass.method_5("ckbComment", ckbComment.Checked);
		gClass.method_5("txtComment", txtComment.Text.Trim());
		gClass.method_5("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.method_5("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.method_5("nudCountShareFrom", nudCountShareFrom.Value);
		gClass.method_5("nudCountShareTo", nudCountShareTo.Value);
		gClass.method_5("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.method_5("nudCountCommentTo", nudCountCommentTo.Value);
		gClass.method_5("ckbFollow", ckbFollow.Checked);
		gClass.method_5("nudFollowFrom", nudFollowFrom.Value);
		gClass.method_5("nudFollowTo", nudFollowTo.Value);
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

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtComment.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatus.Text = string.Format(GClass29.smethod_0("Nội dung bình luận ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbShareWall_CheckedChanged(null, null);
		ckbFollow_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
		plCountComment.Enabled = ckbComment.Checked;
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = ckbInteract.Checked;
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = ckbShareWall.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
	}

	private void ckbFollow_CheckedChanged(object sender, EventArgs e)
	{
		plFollow.Enabled = ckbFollow.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemWatch));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plCountComment = new System.Windows.Forms.Panel();
		this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.plCountShareWall = new System.Windows.Forms.Panel();
		this.nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		this.plCountLike = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		this.plComment = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.button2 = new System.Windows.Forms.Button();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudTimeWatchTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeWatchFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.plFollow = new System.Windows.Forms.Panel();
		this.nudFollowFrom = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.nudFollowTo = new System.Windows.Forms.NumericUpDown();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
		this.plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
		this.plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.plFollow.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudFollowFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudFollowTo).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Xem Watch";
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
		this.panel1.Controls.Add(this.plFollow);
		this.panel1.Controls.Add(this.ckbFollow);
		this.panel1.Controls.Add(this.plCountComment);
		this.panel1.Controls.Add(this.plCountShareWall);
		this.panel1.Controls.Add(this.plCountLike);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.ckbShareWall);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudTimeWatchTo);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudTimeWatchFrom);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 470);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plCountComment.Controls.Add(this.nudCountCommentFrom);
		this.plCountComment.Controls.Add(this.label13);
		this.plCountComment.Controls.Add(this.label14);
		this.plCountComment.Controls.Add(this.nudCountCommentTo);
		this.plCountComment.Location = new System.Drawing.Point(132, 186);
		this.plCountComment.Name = "plCountComment";
		this.plCountComment.Size = new System.Drawing.Size(200, 25);
		this.plCountComment.TabIndex = 44;
		this.nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentFrom.Name = "nudCountCommentFrom";
		this.nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentFrom.TabIndex = 1;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(159, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(25, 16);
		this.label13.TabIndex = 35;
		this.label13.Text = "lần";
		this.label14.Location = new System.Drawing.Point(63, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentTo.Name = "nudCountCommentTo";
		this.nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentTo.TabIndex = 2;
		this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
		this.plCountShareWall.Controls.Add(this.label11);
		this.plCountShareWall.Controls.Add(this.label12);
		this.plCountShareWall.Controls.Add(this.nudCountShareTo);
		this.plCountShareWall.Location = new System.Drawing.Point(132, 158);
		this.plCountShareWall.Name = "plCountShareWall";
		this.plCountShareWall.Size = new System.Drawing.Size(200, 25);
		this.plCountShareWall.TabIndex = 43;
		this.nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareFrom.Name = "nudCountShareFrom";
		this.nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareFrom.TabIndex = 1;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(159, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(25, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "lần";
		this.label12.Location = new System.Drawing.Point(63, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(29, 16);
		this.label12.TabIndex = 37;
		this.label12.Text = "đê\u0301n";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountShareTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareTo.Name = "nudCountShareTo";
		this.nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareTo.TabIndex = 2;
		this.plCountLike.Controls.Add(this.nudCountLikeFrom);
		this.plCountLike.Controls.Add(this.label9);
		this.plCountLike.Controls.Add(this.label10);
		this.plCountLike.Controls.Add(this.nudCountLikeTo);
		this.plCountLike.Location = new System.Drawing.Point(132, 130);
		this.plCountLike.Name = "plCountLike";
		this.plCountLike.Size = new System.Drawing.Size(200, 25);
		this.plCountLike.TabIndex = 42;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(159, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(25, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "lần";
		this.label10.Location = new System.Drawing.Point(63, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 37;
		this.label10.Text = "đê\u0301n";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeTo.Name = "nudCountLikeTo";
		this.nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeTo.TabIndex = 2;
		this.plComment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.linkLabel1);
		this.plComment.Controls.Add(this.button2);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(48, 249);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(278, 164);
		this.plComment.TabIndex = 8;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(165, 4);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 48;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(247, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 46;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.txtComment.Location = new System.Drawing.Point(6, 24);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(264, 114);
		this.txtComment.TabIndex = 45;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 141);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(266, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(140, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 188);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(82, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(30, 160);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(90, 20);
		this.ckbShareWall.TabIndex = 6;
		this.ckbShareWall.Text = "Share Wall";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(30, 132);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(49, 20);
		this.ckbInteract.TabIndex = 5;
		this.ckbInteract.Text = "Like";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.nudTimeWatchTo.Location = new System.Drawing.Point(229, 103);
		this.nudTimeWatchTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWatchTo.Name = "nudTimeWatchTo";
		this.nudTimeWatchTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWatchTo.TabIndex = 4;
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 76);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudTimeWatchFrom.Location = new System.Drawing.Point(132, 103);
		this.nudTimeWatchFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWatchFrom.Name = "nudTimeWatchFrom";
		this.nudTimeWatchFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWatchFrom.TabIndex = 3;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 76);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(194, 105);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(194, 78);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 105);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 78);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(38, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "video";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 105);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(94, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian xem:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 78);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(98, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng video:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 428);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 428);
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
		this.plFollow.Controls.Add(this.nudFollowFrom);
		this.plFollow.Controls.Add(this.label15);
		this.plFollow.Controls.Add(this.label16);
		this.plFollow.Controls.Add(this.nudFollowTo);
		this.plFollow.Location = new System.Drawing.Point(132, 212);
		this.plFollow.Name = "plFollow";
		this.plFollow.Size = new System.Drawing.Size(200, 25);
		this.plFollow.TabIndex = 46;
		this.nudFollowFrom.Location = new System.Drawing.Point(1, 1);
		this.nudFollowFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudFollowFrom.Name = "nudFollowFrom";
		this.nudFollowFrom.Size = new System.Drawing.Size(56, 23);
		this.nudFollowFrom.TabIndex = 1;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(159, 3);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(36, 16);
		this.label15.TabIndex = 35;
		this.label15.Text = "page";
		this.label16.Location = new System.Drawing.Point(63, 3);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(29, 16);
		this.label16.TabIndex = 37;
		this.label16.Text = "đê\u0301n";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudFollowTo.Location = new System.Drawing.Point(98, 1);
		this.nudFollowTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudFollowTo.Name = "nudFollowTo";
		this.nudFollowTo.Size = new System.Drawing.Size(56, 23);
		this.nudFollowTo.TabIndex = 2;
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFollow.Location = new System.Drawing.Point(30, 214);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(64, 20);
		this.ckbFollow.TabIndex = 45;
		this.ckbFollow.Text = "Follow";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.ckbFollow.CheckedChanged += new System.EventHandler(ckbFollow_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(362, 470);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemWatch_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plCountComment.ResumeLayout(false);
		this.plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.plCountShareWall.ResumeLayout(false);
		this.plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
		this.plCountLike.ResumeLayout(false);
		this.plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.plFollow.ResumeLayout(false);
		this.plFollow.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudFollowFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudFollowTo).EndInit();
		base.ResumeLayout(false);
	}
}
