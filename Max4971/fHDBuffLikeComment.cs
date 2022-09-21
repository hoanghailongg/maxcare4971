using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fHDBuffLikeComment : Form
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

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private Label label10;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudTimeFrom;

	private Label label9;

	private Label label4;

	private Label label3;

	private Panel plCommentText;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label8;

	private RichTextBox txtComment;

	private Label label11;

	private Label lblStatus;

	private Panel plAnh;

	private TextBox txtAnh;

	private RichTextBox txtIdPost;

	private CheckBox ckbSendAnh;

	private CheckBox ckbComment;

	private Label label12;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private RadioButton rbCommentNgauNhien;

	private RadioButton rbCommentTheoThuTu;

	private Label label13;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private Panel panel2;

	private Panel panel3;

	private Button button3;

	private Button button2;

	private Button button4;

	private LinkLabel linkLabel1;

	private CheckBox ckbAutoDeleteComment;

	private Panel plComment;

	private CheckBox ckbCommentText;

	private Panel plTag;

	private NumericUpDown nudSoLuongTagTo;

	private Label label16;

	private NumericUpDown nudSoLuongTagFrom;

	private Label label15;

	private Label label14;

	private CheckBox ckbTag;

	private CheckBox ckbChiTagTenViet;

	public fHDBuffLikeComment(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDBuffLikeComment").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffLikeComment', 'Buff Like, Comment');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDBuffLikeComment");
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
		GClass29.smethod_1(label49);
		GClass29.smethod_1(label66);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(ckbInteract);
		GClass29.smethod_1(ckbShareWall);
		GClass29.smethod_1(ckbComment);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(rbNganCachMoiDong);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(rbNganCachKyTu);
		GClass29.smethod_1(button3);
		GClass29.smethod_1(ckbSendAnh);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(rbCommentTheoThuTu);
		GClass29.smethod_1(rbCommentNgauNhien);
	}

	private void fHDBuffLikeComment_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = gclass17_0.method_2("nudTimeFrom", 3);
			nudTimeTo.Value = gclass17_0.method_2("nudTimeTo", 5);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			nudSoLuongUidFrom.Value = gclass17_0.method_2("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass17_0.method_2("nudSoLuongUidTo", 3);
			ckbInteract.Checked = gclass17_0.method_3("ckbInteract");
			ckbShareWall.Checked = gclass17_0.method_3("ckbShareWall");
			ckbComment.Checked = gclass17_0.method_3("ckbComment");
			ckbCommentText.Checked = gclass17_0.method_3("ckbCommentText");
			txtComment.Text = gclass17_0.method_0("txtComment");
			txtIdPost.Text = gclass17_0.method_0("txtIdPost");
			ckbTag.Checked = gclass17_0.method_3("ckbTag");
			nudSoLuongTagFrom.Value = gclass17_0.method_2("nudSoLuongTagFrom", 3);
			nudSoLuongTagTo.Value = gclass17_0.method_2("nudSoLuongTagTo", 5);
			ckbChiTagTenViet.Checked = gclass17_0.method_3("ckbChiTagTenViet");
			ckbSendAnh.Checked = gclass17_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass17_0.method_0("txtAnh");
			if (gclass17_0.method_2("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			if (gclass17_0.method_2("typeComment") == 1)
			{
				rbCommentNgauNhien.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
			ckbAutoDeleteComment.Checked = gclass17_0.method_3("ckbAutoDeleteComment");
		}
		catch
		{
		}
		method_2();
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
		List<string> list_ = txtIdPost.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		if (list_.Count == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id ba\u0300i viê\u0301t câ\u0300n buff like, comment!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> list_2 = txtComment.Lines.ToList();
			list_2 = GClass14.smethod_36(list_2);
			if (list_2.Count == 0 && !ckbTag.Checked)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_5("nudTimeTo", nudTimeTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.method_5("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.method_5("ckbInteract", ckbInteract.Checked);
		gClass.method_5("ckbShareWall", ckbShareWall.Checked);
		gClass.method_5("ckbComment", ckbComment.Checked);
		gClass.method_5("ckbCommentText", ckbCommentText.Checked);
		gClass.method_5("txtComment", txtComment.Text.Trim());
		gClass.method_5("txtIdPost", txtIdPost.Text.Trim());
		gClass.method_5("ckbTag", ckbTag.Checked);
		gClass.method_5("nudSoLuongTagFrom", nudSoLuongTagFrom.Value);
		gClass.method_5("nudSoLuongTagTo", nudSoLuongTagTo.Value);
		gClass.method_5("ckbChiTagTenViet", ckbChiTagTenViet.Checked);
		gClass.method_5("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_5("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.method_5("typeNganCach", num);
		int num2 = 0;
		if (rbCommentNgauNhien.Checked)
		{
			num2 = 1;
		}
		gClass.method_5("typeComment", num2);
		gClass.method_5("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
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

	private void method_1(object sender, EventArgs e)
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

	private void method_2()
	{
		method_3(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbCommentText_CheckedChanged(null, null);
		ckbTag_CheckedChanged(null, null);
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtIdPost.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label2.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch ID bài viết ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void rbCommentTheoThuTu_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void label13_Click(object sender, EventArgs e)
	{
	}

	private void rbCommentNgauNhien_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 195;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 267;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
	}

	private void ckbTag_CheckedChanged(object sender, EventArgs e)
	{
		plTag.Enabled = ckbTag.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffLikeComment));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plComment = new System.Windows.Forms.Panel();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		this.rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.button4 = new System.Windows.Forms.Button();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.label13 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.plTag = new System.Windows.Forms.Panel();
		this.ckbChiTagTenViet = new System.Windows.Forms.CheckBox();
		this.nudSoLuongTagTo = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.nudSoLuongTagFrom = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.ckbTag = new System.Windows.Forms.CheckBox();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.label10 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.panel2.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plTag.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(711, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Buff Like, Comment ba\u0300i viê\u0301t";
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
		this.pnlHeader.Size = new System.Drawing.Size(711, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(680, 1);
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
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.txtIdPost);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.ckbShareWall);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudTimeTo);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudTimeFrom);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(714, 568);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(panel1_Click);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.plCommentText);
		this.plComment.Controls.Add(this.ckbCommentText);
		this.plComment.Controls.Add(this.plTag);
		this.plComment.Controls.Add(this.ckbTag);
		this.plComment.Location = new System.Drawing.Point(371, 129);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(312, 317);
		this.plComment.TabIndex = 172;
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.ckbAutoDeleteComment);
		this.plCommentText.Controls.Add(this.panel2);
		this.plCommentText.Controls.Add(this.linkLabel1);
		this.plCommentText.Controls.Add(this.panel3);
		this.plCommentText.Controls.Add(this.btnDown);
		this.plCommentText.Controls.Add(this.button4);
		this.plCommentText.Controls.Add(this.btnUp);
		this.plCommentText.Controls.Add(this.label13);
		this.plCommentText.Controls.Add(this.label8);
		this.plCommentText.Controls.Add(this.txtComment);
		this.plCommentText.Controls.Add(this.label11);
		this.plCommentText.Controls.Add(this.lblStatus);
		this.plCommentText.Location = new System.Drawing.Point(22, 26);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(281, 195);
		this.plCommentText.TabIndex = 164;
		this.ckbAutoDeleteComment.AutoSize = true;
		this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteComment.Location = new System.Drawing.Point(7, 236);
		this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		this.ckbAutoDeleteComment.Size = new System.Drawing.Size(226, 20);
		this.ckbAutoDeleteComment.TabIndex = 176;
		this.ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		this.panel2.Controls.Add(this.rbNganCachMoiDong);
		this.panel2.Controls.Add(this.button3);
		this.panel2.Controls.Add(this.button2);
		this.panel2.Controls.Add(this.rbNganCachKyTu);
		this.panel2.Location = new System.Drawing.Point(67, 147);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(200, 43);
		this.panel2.TabIndex = 42;
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(3, 3);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		this.rbNganCachMoiDong.TabIndex = 3;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(165, 22);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 21);
		this.button3.TabIndex = 172;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(165, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 21);
		this.button2.TabIndex = 173;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(3, 24);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		this.rbNganCachKyTu.TabIndex = 3;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(167, 128);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 175;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.panel3.Controls.Add(this.rbCommentTheoThuTu);
		this.panel3.Controls.Add(this.rbCommentNgauNhien);
		this.panel3.Location = new System.Drawing.Point(67, 191);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(200, 43);
		this.panel3.TabIndex = 43;
		this.rbCommentTheoThuTu.AutoSize = true;
		this.rbCommentTheoThuTu.Checked = true;
		this.rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
		this.rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		this.rbCommentTheoThuTu.Size = new System.Drawing.Size(202, 20);
		this.rbCommentTheoThuTu.TabIndex = 3;
		this.rbCommentTheoThuTu.TabStop = true;
		this.rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		this.rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		this.rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(rbCommentTheoThuTu_CheckedChanged);
		this.rbCommentNgauNhien.AutoSize = true;
		this.rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
		this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		this.rbCommentNgauNhien.Size = new System.Drawing.Size(201, 20);
		this.rbCommentNgauNhien.TabIndex = 3;
		this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
		this.rbCommentNgauNhien.CheckedChanged += new System.EventHandler(rbCommentNgauNhien_CheckedChanged);
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 40;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(249, 127);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 21);
		this.button4.TabIndex = 173;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 41;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(4, 193);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(65, 16);
		this.label13.TabIndex = 2;
		this.label13.Text = "Tùy chọn:";
		this.label13.Click += new System.EventHandler(label13_Click);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 150);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(65, 16);
		this.label8.TabIndex = 2;
		this.label8.Text = "Tùy chọn:";
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 102);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(5, 128);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(134, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "Spin nội dung {a|b|c}";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(119, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận:";
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(3, 3);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(128, 20);
		this.ckbCommentText.TabIndex = 165;
		this.ckbCommentText.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTag.Controls.Add(this.ckbChiTagTenViet);
		this.plTag.Controls.Add(this.nudSoLuongTagTo);
		this.plTag.Controls.Add(this.label16);
		this.plTag.Controls.Add(this.nudSoLuongTagFrom);
		this.plTag.Controls.Add(this.label15);
		this.plTag.Controls.Add(this.label14);
		this.plTag.Location = new System.Drawing.Point(22, 249);
		this.plTag.Name = "plTag";
		this.plTag.Size = new System.Drawing.Size(258, 60);
		this.plTag.TabIndex = 167;
		this.ckbChiTagTenViet.AutoSize = true;
		this.ckbChiTagTenViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChiTagTenViet.Location = new System.Drawing.Point(6, 32);
		this.ckbChiTagTenViet.Name = "ckbChiTagTenViet";
		this.ckbChiTagTenViet.Size = new System.Drawing.Size(113, 20);
		this.ckbChiTagTenViet.TabIndex = 168;
		this.ckbChiTagTenViet.Text = "Chỉ tag tên việt";
		this.ckbChiTagTenViet.UseVisualStyleBackColor = true;
		this.nudSoLuongTagTo.Location = new System.Drawing.Point(156, 3);
		this.nudSoLuongTagTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTagTo.Name = "nudSoLuongTagTo";
		this.nudSoLuongTagTo.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTagTo.TabIndex = 174;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 5);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(64, 16);
		this.label16.TabIndex = 175;
		this.label16.Text = "Số lượng:";
		this.nudSoLuongTagFrom.Location = new System.Drawing.Point(70, 3);
		this.nudSoLuongTagFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTagFrom.Name = "nudSoLuongTagFrom";
		this.nudSoLuongTagFrom.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTagFrom.TabIndex = 173;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(213, 5);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(40, 16);
		this.label15.TabIndex = 176;
		this.label15.Text = "người";
		this.label14.Location = new System.Drawing.Point(125, 5);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 177;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbTag.AutoSize = true;
		this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTag.Location = new System.Drawing.Point(3, 227);
		this.ckbTag.Name = "ckbTag";
		this.ckbTag.Size = new System.Drawing.Size(92, 20);
		this.ckbTag.TabIndex = 166;
		this.ckbTag.Text = "Tag bạn bè";
		this.ckbTag.UseVisualStyleBackColor = true;
		this.ckbTag.CheckedChanged += new System.EventHandler(ckbTag_CheckedChanged);
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(26, 108);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(108, 16);
		this.label49.TabIndex = 169;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ID/Nick:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 106);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 167;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(289, 108);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(20, 16);
		this.label68.TabIndex = 170;
		this.label68.Text = "ID";
		this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidTo.Location = new System.Drawing.Point(231, 106);
		this.nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidTo.TabIndex = 168;
		this.nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(196, 108);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 171;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label12);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(371, 476);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(312, 31);
		this.plAnh.TabIndex = 166;
		this.txtAnh.Location = new System.Drawing.Point(136, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(171, 23);
		this.txtAnh.TabIndex = 155;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(138, 16);
		this.label12.TabIndex = 39;
		this.label12.Text = "Đường dẫn folder ảnh:";
		this.label12.Click += new System.EventHandler(label12_Click);
		this.txtIdPost.Location = new System.Drawing.Point(30, 152);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(297, 336);
		this.txtIdPost.TabIndex = 1;
		this.txtIdPost.Text = "";
		this.txtIdPost.WordWrap = false;
		this.txtIdPost.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(353, 452);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(104, 20);
		this.ckbSendAnh.TabIndex = 165;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(353, 103);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(79, 20);
		this.ckbComment.TabIndex = 163;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(26, 491);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(97, 16);
		this.label10.TabIndex = 39;
		this.label10.Text = "(Mỗi ID 1 dòng)";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 132);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(154, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Danh sa\u0301ch ID bài viết (0):";
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(508, 79);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(144, 20);
		this.ckbShareWall.TabIndex = 6;
		this.ckbShareWall.Text = "Chia sẻ bài về tường";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(353, 79);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(94, 20);
		this.ckbInteract.TabIndex = 5;
		this.ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.nudTimeTo.Location = new System.Drawing.Point(568, 50);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(51, 23);
		this.nudTimeTo.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(231, 78);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudTimeFrom.Location = new System.Drawing.Point(490, 50);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		this.nudTimeFrom.TabIndex = 3;
		this.nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label9.Location = new System.Drawing.Point(541, 52);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = "đê\u0301n";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.Location = new System.Drawing.Point(196, 80);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(621, 52);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(31, 16);
		this.label4.TabIndex = 36;
		this.label4.Text = "giây";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(289, 80);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(350, 52);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(139, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Thơ\u0300i gian xem bài viết:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 80);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chờ:";
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
		this.btnCancel.Location = new System.Drawing.Point(349, 526);
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
		this.btnAdd.Location = new System.Drawing.Point(242, 526);
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
		this.bunifuCards1.Size = new System.Drawing.Size(711, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(714, 568);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffLikeComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffLikeComment_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.plTag.ResumeLayout(false);
		this.plTag.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
