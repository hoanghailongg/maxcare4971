using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fHDTuongTacNewsfeedv2 : Form
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

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudTimeFrom;

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

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private Panel plCountComment;

	private NumericUpDown nudCountCommentFrom;

	private Label label13;

	private Label label14;

	private NumericUpDown nudCountCommentTo;

	private Panel plCountLike;

	private NumericUpDown nudCountLikeFrom;

	private Label label9;

	private Label label10;

	private NumericUpDown nudCountLikeTo;

	private Panel plComment;

	private RichTextBox txtComment;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label8;

	private Label label15;

	private Label lblStatus;

	private Panel panel2;

	private CheckBox ckbAngry;

	private CheckBox ckbSad;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	public fHDTuongTacNewsfeedv2(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDTuongTacNewsfeedv2").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNewsfeedv2', 'Tương tác Newsfeed v2');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDTuongTacNewsfeedv2");
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
		GClass29.smethod_1(label14);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDTuongTacNewsfeedv2_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = gclass17_0.method_2("nudTimeFrom", 10);
			nudTimeTo.Value = gclass17_0.method_2("nudTimeTo", 30);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 1);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 3);
			nudCountLikeFrom.Value = gclass17_0.method_2("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass17_0.method_2("nudCountLikeTo", 3);
			nudCountCommentFrom.Value = gclass17_0.method_2("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass17_0.method_2("nudCountCommentTo", 3);
			ckbInteract.Checked = gclass17_0.method_3("ckbInteract");
			ckbComment.Checked = gclass17_0.method_3("ckbComment");
			txtComment.Text = gclass17_0.method_0("txtComment");
			if (gclass17_0.method_0("typeCamXuc").Contains("0"))
			{
				ckbLike.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("1"))
			{
				ckbLove.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("2"))
			{
				ckbCare.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("3"))
			{
				ckbHaha.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("4"))
			{
				ckbWow.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("5"))
			{
				ckbSad.Checked = true;
			}
			if (gclass17_0.method_0("typeCamXuc").Contains("6"))
			{
				ckbAngry.Checked = true;
			}
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
		gClass.method_5("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_5("nudTimeTo", nudTimeTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbInteract", ckbInteract.Checked);
		gClass.method_5("ckbComment", ckbComment.Checked);
		gClass.method_5("txtComment", txtComment.Text.Trim());
		gClass.method_5("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.method_5("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.method_5("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.method_5("nudCountCommentTo", nudCountCommentTo.Value);
		string text2 = "";
		if (ckbLike.Checked)
		{
			text2 += "0";
		}
		if (ckbLove.Checked)
		{
			text2 += "1";
		}
		if (ckbCare.Checked)
		{
			text2 += "2";
		}
		if (ckbHaha.Checked)
		{
			text2 += "3";
		}
		if (ckbWow.Checked)
		{
			text2 += "4";
		}
		if (ckbSad.Checked)
		{
			text2 += "5";
		}
		if (ckbAngry.Checked)
		{
			text2 += "6";
		}
		gClass.method_5("typeCamXuc", text2);
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
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = ckbInteract.Checked;
		panel2.Enabled = ckbInteract.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCountComment.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plComment.Height = 207;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plComment.Height = 163;
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

	private void method_3(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));
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
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plComment = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label8 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plCountComment = new System.Windows.Forms.Panel();
		this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.plCountLike = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
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
		this.panel2 = new System.Windows.Forms.Panel();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.ckbLove = new System.Windows.Forms.CheckBox();
		this.ckbCare = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbSad = new System.Windows.Forms.CheckBox();
		this.ckbAngry = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.panel2.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed v2";
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
		this.button1.Image = Class306.Bitmap_15;
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.plCountComment);
		this.panel1.Controls.Add(this.plCountLike);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudTimeTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudTimeFrom);
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
		this.panel1.Size = new System.Drawing.Size(362, 468);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.btnDown);
		this.plComment.Controls.Add(this.btnUp);
		this.plComment.Controls.Add(this.rbNganCachKyTu);
		this.plComment.Controls.Add(this.rbNganCachMoiDong);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.label15);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(50, 255);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 163);
		this.plComment.TabIndex = 42;
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
		this.btnDown.Visible = false;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.UseSelectable = true;
		this.btnUp.Visible = false;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(203, 20);
		this.rbNganCachKyTu.TabIndex = 6;
		this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(171, 20);
		this.rbNganCachMoiDong.TabIndex = 5;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 161);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(65, 16);
		this.label8.TabIndex = 4;
		this.label8.Text = "Tùy chọn:";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(4, 141);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(266, 16);
		this.label15.TabIndex = 0;
		this.label15.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(140, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.plCountComment.Controls.Add(this.nudCountCommentFrom);
		this.plCountComment.Controls.Add(this.label13);
		this.plCountComment.Controls.Add(this.label14);
		this.plCountComment.Controls.Add(this.nudCountCommentTo);
		this.plCountComment.Location = new System.Drawing.Point(136, 226);
		this.plCountComment.Name = "plCountComment";
		this.plCountComment.Size = new System.Drawing.Size(195, 25);
		this.plCountComment.TabIndex = 41;
		this.nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentFrom.Name = "nudCountCommentFrom";
		this.nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentFrom.TabIndex = 1;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(157, 3);
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
		this.plCountLike.Controls.Add(this.nudCountLikeFrom);
		this.plCountLike.Controls.Add(this.label9);
		this.plCountLike.Controls.Add(this.label10);
		this.plCountLike.Controls.Add(this.nudCountLikeTo);
		this.plCountLike.Location = new System.Drawing.Point(136, 133);
		this.plCountLike.Name = "plCountLike";
		this.plCountLike.Size = new System.Drawing.Size(195, 25);
		this.plCountLike.TabIndex = 39;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(157, 3);
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
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 228);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(82, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(30, 135);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(105, 20);
		this.ckbInteract.TabIndex = 5;
		this.ckbInteract.Text = "Thả cảm xúc:";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(234, 105);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudTimeTo.Location = new System.Drawing.Point(234, 77);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeTo.TabIndex = 2;
		this.nudDelayFrom.Location = new System.Drawing.Point(137, 105);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.nudTimeFrom.Location = new System.Drawing.Point(137, 77);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTimeFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(199, 107);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(199, 79);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(292, 107);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(292, 79);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(31, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 107);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(111, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 79);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(92, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thơ\u0300i gian lươ\u0301t:";
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
		this.btnCancel.Location = new System.Drawing.Point(189, 428);
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
		this.panel2.Controls.Add(this.ckbAngry);
		this.panel2.Controls.Add(this.ckbSad);
		this.panel2.Controls.Add(this.ckbWow);
		this.panel2.Controls.Add(this.ckbHaha);
		this.panel2.Controls.Add(this.ckbCare);
		this.panel2.Controls.Add(this.ckbLove);
		this.panel2.Controls.Add(this.ckbLike);
		this.panel2.Location = new System.Drawing.Point(50, 161);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(281, 51);
		this.panel2.TabIndex = 43;
		this.ckbLike.AutoSize = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Location = new System.Drawing.Point(3, 3);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(49, 20);
		this.ckbLike.TabIndex = 6;
		this.ckbLike.Text = "Like";
		this.ckbLike.UseVisualStyleBackColor = true;
		this.ckbLove.AutoSize = true;
		this.ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLove.Location = new System.Drawing.Point(73, 3);
		this.ckbLove.Name = "ckbLove";
		this.ckbLove.Size = new System.Drawing.Size(52, 20);
		this.ckbLove.TabIndex = 7;
		this.ckbLove.Text = "Tym";
		this.ckbLove.UseVisualStyleBackColor = true;
		this.ckbCare.AutoSize = true;
		this.ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCare.Location = new System.Drawing.Point(142, 3);
		this.ckbCare.Name = "ckbCare";
		this.ckbCare.Size = new System.Drawing.Size(71, 20);
		this.ckbCare.TabIndex = 8;
		this.ckbCare.Text = "Thương";
		this.ckbCare.UseVisualStyleBackColor = true;
		this.ckbHaha.AutoSize = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Location = new System.Drawing.Point(222, 3);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(56, 20);
		this.ckbHaha.TabIndex = 9;
		this.ckbHaha.Text = "Haha";
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.ckbWow.AutoSize = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Location = new System.Drawing.Point(3, 29);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(56, 20);
		this.ckbWow.TabIndex = 10;
		this.ckbWow.Text = "Wow";
		this.ckbWow.UseVisualStyleBackColor = true;
		this.ckbSad.AutoSize = true;
		this.ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSad.Location = new System.Drawing.Point(73, 29);
		this.ckbSad.Name = "ckbSad";
		this.ckbSad.Size = new System.Drawing.Size(55, 20);
		this.ckbSad.TabIndex = 11;
		this.ckbSad.Text = "Buồn";
		this.ckbSad.UseVisualStyleBackColor = true;
		this.ckbAngry.AutoSize = true;
		this.ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAngry.Location = new System.Drawing.Point(142, 29);
		this.ckbAngry.Name = "ckbAngry";
		this.ckbAngry.Size = new System.Drawing.Size(73, 20);
		this.ckbAngry.TabIndex = 12;
		this.ckbAngry.Text = "Phẫn nộ";
		this.ckbAngry.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(362, 468);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNewsfeedv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacNewsfeedv2_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCountComment.ResumeLayout(false);
		this.plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.plCountLike.ResumeLayout(false);
		this.plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
	}
}
