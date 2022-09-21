using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSpamBaiVietv2 : Form
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

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label label5;

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

	private CheckBox ckbShareWall;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private Label label19;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox ckbSendAnh;

	private CheckBox ckbTuDongXoaUid;

	private RadioButton rbListUid;

	private Label label10;

	private TextBox txtAnh;

	private Label label12;

	private Button button4;

	private CheckBox ckbAutoDeleteComment;

	private Button btnChooseFileUid;

	private RadioButton rbFileUid;

	private TextBox txtPathFileUid;

	private Panel panel2;

	private NumericUpDown nudBoQuaTo;

	private NumericUpDown nudBoQuaFrom;

	private Label label8;

	private Label label11;

	private CheckBox ckbBoQua;

	private CheckBox ckbTuDongThamGiaNhom;

	private CheckBox ckbKhongCommentTrungBaiCu;

	private Panel panel3;

	private NumericUpDown nudSoLuongNhomTo;

	private NumericUpDown nudSoLuongNhomFrom;

	private Label label13;

	private Label label14;

	private Label label15;

	private Panel plComment;

	private TextBox txtPathFolderComment;

	private Label label16;

	private RadioButton rbRandomNhomThamGia;

	private Panel plSpamIDNguoiDungNhap;

	private Label label2;

	private RadioButton rbSpamIDNguoiDungNhap;

	public fHDSpamBaiVietv2(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = "HDSpamBaiVietv2";
		string text2 = "Spam bài viết v2";
		if (Class307.smethod_13("", text).Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text3, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label49);
		GClass29.smethod_1(label66);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(button4);
		GClass29.smethod_1(rbFileUid);
		GClass29.smethod_1(btnChooseFileUid);
		GClass29.smethod_1(rbListUid);
		GClass29.smethod_1(ckbTuDongXoaUid);
		GClass29.smethod_1(ckbInteract);
		GClass29.smethod_1(ckbShareWall);
		GClass29.smethod_1(ckbComment);
		GClass29.smethod_1(ckbSendAnh);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDSpamBaiVietv2_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = gclass17_0.method_2("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass17_0.method_2("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = gclass17_0.method_2("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = gclass17_0.method_2("nudSoLuongBaiVietTo", 3);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 2);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			if (gclass17_0.method_2("typeSpam") == 0)
			{
				rbRandomNhomThamGia.Checked = true;
			}
			else
			{
				rbSpamIDNguoiDungNhap.Checked = true;
			}
			int num = gclass17_0.method_2("typeListUid");
			if (num == 1)
			{
				rbFileUid.Checked = true;
			}
			else
			{
				rbListUid.Checked = true;
			}
			txtPathFileUid.Text = gclass17_0.method_0("txtPathFileUid");
			txtUid.Text = gclass17_0.method_0("txtUid");
			ckbInteract.Checked = gclass17_0.method_3("ckbInteract");
			ckbShareWall.Checked = gclass17_0.method_3("ckbShareWall");
			ckbComment.Checked = gclass17_0.method_3("ckbComment");
			ckbAutoDeleteComment.Checked = gclass17_0.method_3("ckbAutoDeleteComment");
			txtPathFolderComment.Text = gclass17_0.method_0("txtPathFolderComment");
			ckbSendAnh.Checked = gclass17_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass17_0.method_0("txtAnh");
			ckbTuDongXoaUid.Checked = gclass17_0.method_3("ckbTuDongXoaUid");
			ckbKhongCommentTrungBaiCu.Checked = gclass17_0.method_3("ckbKhongCommentTrungBaiCu");
			ckbBoQua.Checked = gclass17_0.method_3("ckbBoQua");
			nudBoQuaFrom.Value = gclass17_0.method_2("nudBoQuaFrom", 1);
			nudBoQuaTo.Value = gclass17_0.method_2("nudBoQuaTo", 1);
			ckbTuDongThamGiaNhom.Checked = gclass17_0.method_3("ckbTuDongThamGiaNhom");
			nudSoLuongNhomFrom.Value = gclass17_0.method_2("nudSoLuongNhomFrom", 1);
			nudSoLuongNhomTo.Value = gclass17_0.method_2("nudSoLuongNhomTo", 1);
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
		if (rbSpamIDNguoiDungNhap.Checked)
		{
			if (rbFileUid.Checked)
			{
				if (txtPathFileUid.Text.Trim() == "")
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn File Uid!"), 3);
					return;
				}
			}
			else
			{
				List<string> list_ = txtUid.Lines.ToList();
				list_ = GClass14.smethod_36(list_);
				if (list_.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!"), 3);
					return;
				}
			}
		}
		if (ckbSendAnh.Checked && txtAnh.Text.Trim().Length == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn folder ảnh!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.method_5("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.method_5("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.method_5("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		if (rbRandomNhomThamGia.Checked)
		{
			gClass.method_5("typeSpam", 0);
		}
		else
		{
			gClass.method_5("typeSpam", 1);
		}
		if (rbFileUid.Checked)
		{
			gClass.method_5("typeListUid", 1);
		}
		else
		{
			gClass.method_5("typeListUid", 0);
		}
		gClass.method_5("txtPathFileUid", txtPathFileUid.Text.Trim());
		gClass.method_5("txtUid", txtUid.Text.Trim());
		gClass.method_5("ckbInteract", ckbInteract.Checked);
		gClass.method_5("ckbShareWall", ckbShareWall.Checked);
		gClass.method_5("ckbComment", ckbComment.Checked);
		gClass.method_5("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		gClass.method_5("txtPathFolderComment", txtPathFolderComment.Text.Trim());
		gClass.method_5("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_5("txtAnh", txtAnh.Text.Trim());
		gClass.method_5("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.method_5("ckbKhongCommentTrungBaiCu", ckbKhongCommentTrungBaiCu.Checked);
		gClass.method_5("ckbBoQua", ckbBoQua.Checked);
		gClass.method_5("nudBoQuaFrom", nudBoQuaFrom.Value);
		gClass.method_5("nudBoQuaTo", nudBoQuaTo.Value);
		gClass.method_5("ckbTuDongThamGiaNhom", ckbTuDongThamGiaNhom.Checked);
		gClass.method_5("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
		gClass.method_5("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
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
	}

	private void method_2()
	{
		method_3(null, null);
		ckbComment_CheckedChanged(null, null);
		rbFileUid_CheckedChanged(null, null);
		rbListUid_CheckedChanged(null, null);
		ckbBoQua_CheckedChanged(null, null);
		ckbTuDongXoaUid_CheckedChanged(null, null);
		ckbTuDongThamGiaNhom_CheckedChanged(null, null);
		rbSpamIDNguoiDungNhap_CheckedChanged(null, null);
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUid.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			rbListUid.Text = string.Format(GClass29.smethod_0("Nhập (Mỗi Uid 1 dòng) ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void method_4(object sender, EventArgs e)
	{
		txtAnh.Text = GClass14.smethod_40();
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void panel1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void btnChooseFileUid_Click(object sender, EventArgs e)
	{
		txtPathFileUid.Text = GClass14.smethod_41();
	}

	private void rbFileUid_CheckedChanged(object sender, EventArgs e)
	{
		txtPathFileUid.Enabled = rbFileUid.Checked;
		btnChooseFileUid.Enabled = rbFileUid.Checked;
	}

	private void rbListUid_CheckedChanged(object sender, EventArgs e)
	{
		txtUid.Enabled = rbListUid.Checked;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + GClass29.smethod_0("Ví dụ") + ": 15465478242/posts");
	}

	private void ckbBoQua_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbBoQua.Checked;
	}

	private void ckbTuDongXoaUid_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void ckbTuDongThamGiaNhom_CheckedChanged(object sender, EventArgs e)
	{
		panel3.Enabled = ckbTuDongThamGiaNhom.Checked;
	}

	private void rbSpamIDNguoiDungNhap_CheckedChanged(object sender, EventArgs e)
	{
		plSpamIDNguoiDungNhap.Enabled = rbSpamIDNguoiDungNhap.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamBaiVietv2));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.nudSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.ckbTuDongThamGiaNhom = new System.Windows.Forms.CheckBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.nudBoQuaTo = new System.Windows.Forms.NumericUpDown();
		this.nudBoQuaFrom = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.ckbBoQua = new System.Windows.Forms.CheckBox();
		this.button4 = new System.Windows.Forms.Button();
		this.btnChooseFileUid = new System.Windows.Forms.Button();
		this.rbListUid = new System.Windows.Forms.RadioButton();
		this.rbFileUid = new System.Windows.Forms.RadioButton();
		this.plComment = new System.Windows.Forms.Panel();
		this.txtPathFolderComment = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.ckbKhongCommentTrungBaiCu = new System.Windows.Forms.CheckBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.txtPathFileUid = new System.Windows.Forms.TextBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.label2 = new System.Windows.Forms.Label();
		this.plSpamIDNguoiDungNhap = new System.Windows.Forms.Panel();
		this.rbRandomNhomThamGia = new System.Windows.Forms.RadioButton();
		this.rbSpamIDNguoiDungNhap = new System.Windows.Forms.RadioButton();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomFrom).BeginInit();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaFrom).BeginInit();
		this.plComment.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.plSpamIDNguoiDungNhap.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(704, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Spam bài viết v2";
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
		this.pnlHeader.Size = new System.Drawing.Size(704, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(673, 1);
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
		this.panel1.Controls.Add(this.rbSpamIDNguoiDungNhap);
		this.panel1.Controls.Add(this.rbRandomNhomThamGia);
		this.panel1.Controls.Add(this.plSpamIDNguoiDungNhap);
		this.panel1.Controls.Add(this.panel3);
		this.panel1.Controls.Add(this.ckbTuDongThamGiaNhom);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.ckbBoQua);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.ckbKhongCommentTrungBaiCu);
		this.panel1.Controls.Add(this.ckbShareWall);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(707, 534);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(panel1_Click);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.nudSoLuongNhomTo);
		this.panel3.Controls.Add(this.nudSoLuongNhomFrom);
		this.panel3.Controls.Add(this.label13);
		this.panel3.Controls.Add(this.label14);
		this.panel3.Controls.Add(this.label15);
		this.panel3.Location = new System.Drawing.Point(392, 442);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(282, 30);
		this.panel3.TabIndex = 168;
		this.nudSoLuongNhomTo.Location = new System.Drawing.Point(175, 3);
		this.nudSoLuongNhomTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongNhomTo.Name = "nudSoLuongNhomTo";
		this.nudSoLuongNhomTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongNhomTo.TabIndex = 40;
		this.nudSoLuongNhomFrom.Location = new System.Drawing.Point(78, 3);
		this.nudSoLuongNhomFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
		this.nudSoLuongNhomFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongNhomFrom.TabIndex = 39;
		this.label13.Location = new System.Drawing.Point(140, 5);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 43;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(233, 5);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(40, 16);
		this.label14.TabIndex = 42;
		this.label14.Text = "nhóm";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(3, 5);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(64, 16);
		this.label15.TabIndex = 41;
		this.label15.Text = "Số lượng:";
		this.ckbTuDongThamGiaNhom.AutoSize = true;
		this.ckbTuDongThamGiaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongThamGiaNhom.Location = new System.Drawing.Point(373, 419);
		this.ckbTuDongThamGiaNhom.Name = "ckbTuDongThamGiaNhom";
		this.ckbTuDongThamGiaNhom.Size = new System.Drawing.Size(287, 20);
		this.ckbTuDongThamGiaNhom.TabIndex = 167;
		this.ckbTuDongThamGiaNhom.Text = "Tự động tham gia nhóm (Nếu chưa tham gia)";
		this.ckbTuDongThamGiaNhom.UseVisualStyleBackColor = true;
		this.ckbTuDongThamGiaNhom.CheckedChanged += new System.EventHandler(ckbTuDongThamGiaNhom_CheckedChanged);
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.nudBoQuaTo);
		this.panel2.Controls.Add(this.nudBoQuaFrom);
		this.panel2.Controls.Add(this.label8);
		this.panel2.Controls.Add(this.label11);
		this.panel2.Location = new System.Drawing.Point(96, 439);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(247, 31);
		this.panel2.TabIndex = 166;
		this.nudBoQuaTo.Location = new System.Drawing.Point(91, 3);
		this.nudBoQuaTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudBoQuaTo.Name = "nudBoQuaTo";
		this.nudBoQuaTo.Size = new System.Drawing.Size(56, 23);
		this.nudBoQuaTo.TabIndex = 40;
		this.nudBoQuaFrom.Location = new System.Drawing.Point(3, 3);
		this.nudBoQuaFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudBoQuaFrom.Name = "nudBoQuaFrom";
		this.nudBoQuaFrom.Size = new System.Drawing.Size(56, 23);
		this.nudBoQuaFrom.TabIndex = 39;
		this.label8.Location = new System.Drawing.Point(60, 5);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(29, 16);
		this.label8.TabIndex = 42;
		this.label8.Text = "đê\u0301n";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(150, 5);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(74, 16);
		this.label11.TabIndex = 41;
		this.label11.Text = "bài viết đầu";
		this.ckbBoQua.AutoSize = true;
		this.ckbBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBoQua.Location = new System.Drawing.Point(30, 444);
		this.ckbBoQua.Name = "ckbBoQua";
		this.ckbBoQua.Size = new System.Drawing.Size(71, 20);
		this.ckbBoQua.TabIndex = 164;
		this.ckbBoQua.Text = "Bỏ qua:";
		this.ckbBoQua.UseVisualStyleBackColor = true;
		this.ckbBoQua.CheckedChanged += new System.EventHandler(ckbBoQua_CheckedChanged);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(244, 1);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 5;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.btnChooseFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnChooseFileUid.Location = new System.Drawing.Point(244, 24);
		this.btnChooseFileUid.Name = "btnChooseFileUid";
		this.btnChooseFileUid.Size = new System.Drawing.Size(63, 25);
		this.btnChooseFileUid.TabIndex = 156;
		this.btnChooseFileUid.Text = "Chọn";
		this.btnChooseFileUid.UseVisualStyleBackColor = true;
		this.btnChooseFileUid.Click += new System.EventHandler(btnChooseFileUid_Click);
		this.rbListUid.AutoSize = true;
		this.rbListUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbListUid.Location = new System.Drawing.Point(7, 48);
		this.rbListUid.Name = "rbListUid";
		this.rbListUid.Size = new System.Drawing.Size(175, 20);
		this.rbListUid.TabIndex = 163;
		this.rbListUid.Text = "Nhập (Mỗi Uid 1 dòng) (0)";
		this.rbListUid.UseVisualStyleBackColor = true;
		this.rbListUid.CheckedChanged += new System.EventHandler(rbListUid_CheckedChanged);
		this.rbFileUid.AutoSize = true;
		this.rbFileUid.Checked = true;
		this.rbFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbFileUid.Location = new System.Drawing.Point(7, 25);
		this.rbFileUid.Name = "rbFileUid";
		this.rbFileUid.Size = new System.Drawing.Size(95, 20);
		this.rbFileUid.TabIndex = 163;
		this.rbFileUid.TabStop = true;
		this.rbFileUid.Text = "Nhập từ File";
		this.rbFileUid.UseVisualStyleBackColor = true;
		this.rbFileUid.CheckedChanged += new System.EventHandler(rbFileUid_CheckedChanged);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtPathFolderComment);
		this.plComment.Controls.Add(this.label16);
		this.plComment.Controls.Add(this.ckbAutoDeleteComment);
		this.plComment.Location = new System.Drawing.Point(391, 271);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(283, 53);
		this.plComment.TabIndex = 162;
		this.txtPathFolderComment.Location = new System.Drawing.Point(158, 3);
		this.txtPathFolderComment.Name = "txtPathFolderComment";
		this.txtPathFolderComment.Size = new System.Drawing.Size(120, 23);
		this.txtPathFolderComment.TabIndex = 159;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 6);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(159, 16);
		this.label16.TabIndex = 158;
		this.label16.Text = "Đường dẫn folder content:";
		this.ckbAutoDeleteComment.AutoSize = true;
		this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteComment.Location = new System.Drawing.Point(6, 29);
		this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		this.ckbAutoDeleteComment.Size = new System.Drawing.Size(226, 20);
		this.ckbAutoDeleteComment.TabIndex = 8;
		this.ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label12);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(391, 350);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(283, 31);
		this.plAnh.TabIndex = 162;
		this.txtAnh.Location = new System.Drawing.Point(160, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(118, 23);
		this.txtAnh.TabIndex = 159;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(138, 16);
		this.label12.TabIndex = 158;
		this.label12.Text = "Đường dẫn folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(373, 328);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(104, 20);
		this.ckbSendAnh.TabIndex = 161;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(7, 71);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(299, 115);
		this.txtUid.TabIndex = 117;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(3, 4);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(242, 16);
		this.label10.TabIndex = 116;
		this.label10.Text = "Nhập danh sách ID Cá nhân/Nhóm/Page:";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 81);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(86, 16);
		this.label49.TabIndex = 92;
		this.label49.Text = "Sô\u0301 lươ\u0323ng Uid:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 1;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(290, 81);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(26, 16);
		this.label68.TabIndex = 99;
		this.label68.Text = "Uid";
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(27, 110);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(95, 16);
		this.label19.TabIndex = 101;
		this.label19.Text = "Sô\u0301 ba\u0300i viết/uid:";
		this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidTo.Location = new System.Drawing.Point(232, 79);
		this.nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidTo.TabIndex = 2;
		this.nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(197, 81);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 105;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(373, 252);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(128, 20);
		this.ckbComment.TabIndex = 9;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.ckbKhongCommentTrungBaiCu.AutoSize = true;
		this.ckbKhongCommentTrungBaiCu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongCommentTrungBaiCu.Location = new System.Drawing.Point(373, 393);
		this.ckbKhongCommentTrungBaiCu.Name = "ckbKhongCommentTrungBaiCu";
		this.ckbKhongCommentTrungBaiCu.Size = new System.Drawing.Size(191, 20);
		this.ckbKhongCommentTrungBaiCu.TabIndex = 8;
		this.ckbKhongCommentTrungBaiCu.Text = "Không comment trùng bài cũ";
		this.ckbKhongCommentTrungBaiCu.UseVisualStyleBackColor = true;
		this.ckbKhongCommentTrungBaiCu.CheckedChanged += new System.EventHandler(ckbTuDongXoaUid_CheckedChanged);
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(7, 187);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(304, 20);
		this.ckbTuDongXoaUid.TabIndex = 8;
		this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.ckbTuDongXoaUid.CheckedChanged += new System.EventHandler(ckbTuDongXoaUid_CheckedChanged);
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(510, 226);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(168, 20);
		this.ckbShareWall.TabIndex = 8;
		this.ckbShareWall.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(373, 226);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(94, 20);
		this.ckbInteract.TabIndex = 7;
		this.ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(232, 137);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 108);
		this.nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(135, 137);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 5;
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 108);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 3;
		this.txtPathFileUid.Location = new System.Drawing.Point(104, 25);
		this.txtPathFileUid.Name = "txtPathFileUid";
		this.txtPathFileUid.Size = new System.Drawing.Size(134, 23);
		this.txtPathFileUid.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(197, 139);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(197, 110);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 139);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 110);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(25, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0300i";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 139);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
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
		this.btnCancel.Location = new System.Drawing.Point(361, 491);
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
		this.btnAdd.Location = new System.Drawing.Point(254, 491);
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
		this.bunifuCards1.Size = new System.Drawing.Size(704, 37);
		this.bunifuCards1.TabIndex = 28;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 163);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(176, 16);
		this.label2.TabIndex = 116;
		this.label2.Text = "Tùy chọn đối tượng để spam:";
		this.plSpamIDNguoiDungNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plSpamIDNguoiDungNhap.Controls.Add(this.label10);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.txtPathFileUid);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.ckbTuDongXoaUid);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.txtUid);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.rbFileUid);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.button4);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.rbListUid);
		this.plSpamIDNguoiDungNhap.Controls.Add(this.btnChooseFileUid);
		this.plSpamIDNguoiDungNhap.Location = new System.Drawing.Point(31, 226);
		this.plSpamIDNguoiDungNhap.Name = "plSpamIDNguoiDungNhap";
		this.plSpamIDNguoiDungNhap.Size = new System.Drawing.Size(312, 210);
		this.plSpamIDNguoiDungNhap.TabIndex = 169;
		this.rbRandomNhomThamGia.AutoSize = true;
		this.rbRandomNhomThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbRandomNhomThamGia.Location = new System.Drawing.Point(31, 182);
		this.rbRandomNhomThamGia.Name = "rbRandomNhomThamGia";
		this.rbRandomNhomThamGia.Size = new System.Drawing.Size(195, 20);
		this.rbRandomNhomThamGia.TabIndex = 170;
		this.rbRandomNhomThamGia.TabStop = true;
		this.rbRandomNhomThamGia.Text = "Random nhóm đang tham gia";
		this.rbRandomNhomThamGia.UseVisualStyleBackColor = true;
		this.rbSpamIDNguoiDungNhap.AutoSize = true;
		this.rbSpamIDNguoiDungNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSpamIDNguoiDungNhap.Location = new System.Drawing.Point(31, 204);
		this.rbSpamIDNguoiDungNhap.Name = "rbSpamIDNguoiDungNhap";
		this.rbSpamIDNguoiDungNhap.Size = new System.Drawing.Size(175, 20);
		this.rbSpamIDNguoiDungNhap.TabIndex = 170;
		this.rbSpamIDNguoiDungNhap.TabStop = true;
		this.rbSpamIDNguoiDungNhap.Text = "Spam ID người dùng nhập";
		this.rbSpamIDNguoiDungNhap.UseVisualStyleBackColor = true;
		this.rbSpamIDNguoiDungNhap.CheckedChanged += new System.EventHandler(rbSpamIDNguoiDungNhap_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(707, 534);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBaiVietv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDSpamBaiVietv2_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomFrom).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaFrom).EndInit();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.plSpamIDNguoiDungNhap.ResumeLayout(false);
		this.plSpamIDNguoiDungNhap.PerformLayout();
		base.ResumeLayout(false);
	}
}
