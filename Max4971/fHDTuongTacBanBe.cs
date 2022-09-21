using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fHDTuongTacBanBe : Form
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

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plCommentText;

	private Label label8;

	private Label lblStatus;

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private RichTextBox txtComment;

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

	private Label label2;

	private Label label10;

	private NumericUpDown nudCountLikeTo;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudTimeFrom;

	private Label label15;

	private Label label16;

	private Label label17;

	private Label label18;

	private Label label20;

	private Label label21;

	private GroupBox groupBox1;

	private Label label49;

	private NumericUpDown nudSoLuongBanBeFrom;

	private Label label68;

	private NumericUpDown nudSoLuongBanBeTo;

	private Label label66;

	private Button button2;

	private Button button3;

	private Button button4;

	private LinkLabel linkLabel1;

	private Panel plAnh;

	private TextBox txtAnh;

	private Label label3;

	private CheckBox ckbSendAnh;

	private Label label4;

	private Panel plComment;

	private CheckBox ckbCommentText;

	private CheckBox ckbNangCao;

	public fHDTuongTacBanBe(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDTuongTacBanBe").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBanBe', 'Tương tác Bạn bè');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDTuongTacBanBe");
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
		GClass29.smethod_1(label49);
		GClass29.smethod_1(label66);
		GClass29.smethod_1(label68);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label18);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label2);
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

	private void fHDTuongTacBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBanBeFrom.Value = gclass17_0.method_2("nudSoLuongBanBeFrom", 1);
			nudSoLuongBanBeTo.Value = gclass17_0.method_2("nudSoLuongBanBeTo", 3);
			nudTimeFrom.Value = gclass17_0.method_2("nudTimeFrom", 10);
			nudTimeTo.Value = gclass17_0.method_2("nudTimeTo", 30);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 1);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 3);
			nudCountLikeFrom.Value = gclass17_0.method_2("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass17_0.method_2("nudCountLikeTo", 3);
			nudCountShareFrom.Value = gclass17_0.method_2("nudCountShareFrom", 1);
			nudCountShareTo.Value = gclass17_0.method_2("nudCountShareTo", 3);
			nudCountCommentFrom.Value = gclass17_0.method_2("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass17_0.method_2("nudCountCommentTo", 3);
			ckbInteract.Checked = gclass17_0.method_3("ckbInteract");
			ckbShareWall.Checked = gclass17_0.method_3("ckbShareWall");
			ckbNangCao.Checked = gclass17_0.method_3("ckbNangCao");
			ckbComment.Checked = gclass17_0.method_3("ckbComment");
			ckbCommentText.Checked = gclass17_0.method_3("ckbCommentText");
			txtComment.Text = gclass17_0.method_0("txtComment");
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
		gClass.method_5("nudSoLuongBanBeFrom", nudSoLuongBanBeFrom.Value);
		gClass.method_5("nudSoLuongBanBeTo", nudSoLuongBanBeTo.Value);
		gClass.method_5("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_5("nudTimeTo", nudTimeTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbInteract", ckbInteract.Checked);
		gClass.method_5("ckbShareWall", ckbShareWall.Checked);
		gClass.method_5("ckbNangCao", ckbNangCao.Checked);
		gClass.method_5("ckbComment", ckbComment.Checked);
		gClass.method_5("ckbCommentText", ckbCommentText.Checked);
		gClass.method_5("txtComment", txtComment.Text.Trim());
		gClass.method_5("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.method_5("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.method_5("nudCountShareFrom", nudCountShareFrom.Value);
		gClass.method_5("nudCountShareTo", nudCountShareTo.Value);
		gClass.method_5("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.method_5("nudCountCommentTo", nudCountCommentTo.Value);
		gClass.method_5("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_5("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.method_5("typeNganCach", num);
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
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = GClass14.smethod_36(list);
			lblStatus.Text = string.Format(GClass29.smethod_0("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbShareWall_CheckedChanged(null, null);
		ckbCommentText_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 162;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 210;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
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

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBanBe));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.ckbNangCao = new System.Windows.Forms.CheckBox();
		this.plComment = new System.Windows.Forms.Panel();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.plCountComment = new System.Windows.Forms.Panel();
		this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.label21 = new System.Windows.Forms.Label();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.label20 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.plCountShareWall = new System.Windows.Forms.Panel();
		this.nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		this.label17 = new System.Windows.Forms.Label();
		this.plCountLike = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.nudSoLuongBanBeTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.plAnh.SuspendLayout();
		this.plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
		this.plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeTo).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(384, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Bạn bè";
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
		this.pnlHeader.Size = new System.Drawing.Size(384, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(353, 1);
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
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongBanBeFrom);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.nudSoLuongBanBeTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(387, 628);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox1.Controls.Add(this.ckbNangCao);
		this.groupBox1.Controls.Add(this.plComment);
		this.groupBox1.Controls.Add(this.label21);
		this.groupBox1.Controls.Add(this.ckbInteract);
		this.groupBox1.Controls.Add(this.ckbShareWall);
		this.groupBox1.Controls.Add(this.ckbComment);
		this.groupBox1.Controls.Add(this.label20);
		this.groupBox1.Controls.Add(this.label18);
		this.groupBox1.Controls.Add(this.plCountShareWall);
		this.groupBox1.Controls.Add(this.label17);
		this.groupBox1.Controls.Add(this.plCountLike);
		this.groupBox1.Controls.Add(this.label16);
		this.groupBox1.Controls.Add(this.nudDelayTo);
		this.groupBox1.Controls.Add(this.label15);
		this.groupBox1.Controls.Add(this.nudTimeTo);
		this.groupBox1.Controls.Add(this.nudTimeFrom);
		this.groupBox1.Controls.Add(this.nudDelayFrom);
		this.groupBox1.Location = new System.Drawing.Point(21, 111);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(343, 455);
		this.groupBox1.TabIndex = 124;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình tương tác/Bạn bè";
		this.ckbNangCao.AutoSize = true;
		this.ckbNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNangCao.Location = new System.Drawing.Point(119, 140);
		this.ckbNangCao.Name = "ckbNangCao";
		this.ckbNangCao.Size = new System.Drawing.Size(130, 20);
		this.ckbNangCao.TabIndex = 173;
		this.ckbNangCao.Text = "Random nâng cao";
		this.ckbNangCao.UseVisualStyleBackColor = true;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.plCommentText);
		this.plComment.Controls.Add(this.label4);
		this.plComment.Controls.Add(this.ckbCommentText);
		this.plComment.Controls.Add(this.plCountComment);
		this.plComment.Controls.Add(this.plAnh);
		this.plComment.Controls.Add(this.ckbSendAnh);
		this.plComment.Location = new System.Drawing.Point(21, 164);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(317, 282);
		this.plComment.TabIndex = 172;
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.linkLabel1);
		this.plCommentText.Controls.Add(this.button3);
		this.plCommentText.Controls.Add(this.button4);
		this.plCommentText.Controls.Add(this.button2);
		this.plCommentText.Controls.Add(this.txtComment);
		this.plCommentText.Controls.Add(this.btnDown);
		this.plCommentText.Controls.Add(this.btnUp);
		this.plCommentText.Controls.Add(this.rbNganCachKyTu);
		this.plCommentText.Controls.Add(this.rbNganCachMoiDong);
		this.plCommentText.Controls.Add(this.label9);
		this.plCommentText.Controls.Add(this.label8);
		this.plCommentText.Controls.Add(this.lblStatus);
		this.plCommentText.Location = new System.Drawing.Point(27, 52);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(281, 162);
		this.plCommentText.TabIndex = 10;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(167, 141);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 180;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(224, 182);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 126;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(224, 159);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 127;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(250, 138);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 125;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(266, 111);
		this.txtComment.TabIndex = 106;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 7;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		this.rbNganCachKyTu.TabIndex = 6;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		this.rbNganCachMoiDong.TabIndex = 5;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(4, 161);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(65, 16);
		this.label9.TabIndex = 4;
		this.label9.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 141);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(144, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(140, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(3, 7);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(64, 16);
		this.label4.TabIndex = 110;
		this.label4.Text = "Số lượng:";
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(6, 31);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(128, 20);
		this.ckbCommentText.TabIndex = 171;
		this.ckbCommentText.Text = "Bình luận văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.plCountComment.Controls.Add(this.nudCountCommentFrom);
		this.plCountComment.Controls.Add(this.label13);
		this.plCountComment.Controls.Add(this.label14);
		this.plCountComment.Controls.Add(this.nudCountCommentTo);
		this.plCountComment.Location = new System.Drawing.Point(95, 3);
		this.plCountComment.Name = "plCountComment";
		this.plCountComment.Size = new System.Drawing.Size(196, 25);
		this.plCountComment.TabIndex = 118;
		this.nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentFrom.Name = "nudCountCommentFrom";
		this.nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentFrom.TabIndex = 1;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(156, 3);
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
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label3);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(24, 241);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(284, 31);
		this.plAnh.TabIndex = 170;
		this.txtAnh.Location = new System.Drawing.Point(137, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(140, 23);
		this.txtAnh.TabIndex = 155;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 6);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(138, 16);
		this.label3.TabIndex = 39;
		this.label3.Text = "Đường dẫn folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(6, 218);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(104, 20);
		this.ckbSendAnh.TabIndex = 169;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.label21.AutoSize = true;
		this.label21.Location = new System.Drawing.Point(6, 25);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(92, 16);
		this.label21.TabIndex = 110;
		this.label21.Text = "Thơ\u0300i gian lươ\u0301t:";
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(9, 82);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(49, 20);
		this.ckbInteract.TabIndex = 7;
		this.ckbInteract.Text = "Like";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(9, 111);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(90, 20);
		this.ckbShareWall.TabIndex = 8;
		this.ckbShareWall.Text = "Share Wall";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(9, 140);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(82, 20);
		this.ckbComment.TabIndex = 9;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(6, 53);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(111, 16);
		this.label20.TabIndex = 111;
		this.label20.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(273, 25);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(31, 16);
		this.label18.TabIndex = 112;
		this.label18.Text = "giây";
		this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
		this.plCountShareWall.Controls.Add(this.label11);
		this.plCountShareWall.Controls.Add(this.label12);
		this.plCountShareWall.Controls.Add(this.nudCountShareTo);
		this.plCountShareWall.Location = new System.Drawing.Point(116, 109);
		this.plCountShareWall.Name = "plCountShareWall";
		this.plCountShareWall.Size = new System.Drawing.Size(196, 25);
		this.plCountShareWall.TabIndex = 117;
		this.nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareFrom.Name = "nudCountShareFrom";
		this.nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareFrom.TabIndex = 1;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(156, 3);
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
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(273, 53);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(31, 16);
		this.label17.TabIndex = 113;
		this.label17.Text = "giây";
		this.plCountLike.Controls.Add(this.nudCountLikeFrom);
		this.plCountLike.Controls.Add(this.label2);
		this.plCountLike.Controls.Add(this.label10);
		this.plCountLike.Controls.Add(this.nudCountLikeTo);
		this.plCountLike.Location = new System.Drawing.Point(116, 80);
		this.plCountLike.Name = "plCountLike";
		this.plCountLike.Size = new System.Drawing.Size(196, 25);
		this.plCountLike.TabIndex = 116;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(156, 3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(25, 16);
		this.label2.TabIndex = 35;
		this.label2.Text = "lần";
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
		this.label16.Location = new System.Drawing.Point(179, 25);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(29, 16);
		this.label16.TabIndex = 114;
		this.label16.Text = "đê\u0301n";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudDelayTo.Location = new System.Drawing.Point(214, 51);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 109;
		this.label15.Location = new System.Drawing.Point(179, 53);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(29, 16);
		this.label15.TabIndex = 115;
		this.label15.Text = "đê\u0301n";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudTimeTo.Location = new System.Drawing.Point(214, 23);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeTo.TabIndex = 107;
		this.nudTimeFrom.Location = new System.Drawing.Point(117, 23);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTimeFrom.TabIndex = 106;
		this.nudDelayFrom.Location = new System.Drawing.Point(117, 51);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 108;
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(18, 82);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(107, 16);
		this.label49.TabIndex = 121;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		this.nudSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBanBeFrom.Location = new System.Drawing.Point(129, 80);
		this.nudSoLuongBanBeFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBanBeFrom.Name = "nudSoLuongBanBeFrom";
		this.nudSoLuongBanBeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBanBeFrom.TabIndex = 119;
		this.nudSoLuongBanBeFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(287, 82);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(29, 16);
		this.label68.TabIndex = 122;
		this.label68.Text = "ba\u0323n";
		this.nudSoLuongBanBeTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBanBeTo.Location = new System.Drawing.Point(226, 80);
		this.nudSoLuongBanBeTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBanBeTo.Name = "nudSoLuongBanBeTo";
		this.nudSoLuongBanBeTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBanBeTo.TabIndex = 120;
		this.nudSoLuongBanBeTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.AutoSize = true;
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(191, 82);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 123;
		this.label66.Text = "đê\u0301n";
		this.txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(235, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(18, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(201, 583);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
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
		this.btnAdd.Location = new System.Drawing.Point(94, 583);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 11;
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
		this.bunifuCards1.Size = new System.Drawing.Size(384, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(387, 628);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacBanBe_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.plCountComment.ResumeLayout(false);
		this.plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		this.plCountShareWall.ResumeLayout(false);
		this.plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
		this.plCountLike.ResumeLayout(false);
		this.plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeTo).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
