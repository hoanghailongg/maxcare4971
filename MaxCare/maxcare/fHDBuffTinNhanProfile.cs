using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fHDBuffTinNhanProfile : Form
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

	private Panel plComment;

	private Label label8;

	private Label lblStatus;

	private CheckBox ckbNhanTinVanBan;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private Label label2;

	private Label lblStatusUid;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox ckbSendAnh;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip toolTip_0;

	private Label label3;

	private Label label4;

	private Label label9;

	private NumericUpDown nudSoLuongAnhFrom;

	private NumericUpDown nudSoLuongAnhTo;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label11;

	private Panel plTuongTacTruocKhiNhanTin;

	private CheckBox ckbTuongTacKhiNhanTinComment;

	private CheckBox ckbTuongTacKhiNhanTinLike;

	private CheckBox ckbTuongTacKhiNhanTin;

	private Panel plTuongTacTruocKhiNhanTinComment;

	private RadioButton ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong;

	private RadioButton ckbTuongTacKhiNhanTinCommentNoiDung1Dong;

	private Label label12;

	private RichTextBox txtTuongTacKhiNhanTinComment;

	private Label label14;

	private RadioButton rbTuongTacSauKhiNhanTin;

	private RadioButton rbTuongTacTruocKhiNhanTin;

	private Label label15;

	private Label label16;

	private Label label10;

	private TextBox txtAnh;

	private Button button3;

	private Button button2;

	private Button button4;

	private LinkLabel linkLabel1;

	private Label label17;

	private Button button5;

	private Button button6;

	private CheckBox ckbAddFriend;

	private RichTextBox txtNoiDung;

	public fHDBuffTinNhanProfile(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDBuffTinNhanProfile").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffTinNhanProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\", \"nudSoLuongAnhFrom\": \"1\", \"nudSoLuongAnhTo\": \"1\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",  \"txtUid\": \"\",  \"ckbNhanTinVanBan\": \"True\",  \"txtNoiDung\": \"hello\",  \"ckbSendAnh\": \"False\",  \"txtAnh\": \"\",  \"ckbTuDongXoaUid\": \"False\"}', 'Buff Tin nhắn Profile');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDBuffTinNhanProfile");
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
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(lblStatusUid);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(ckbTuDongXoaUid);
		GClass29.smethod_1(ckbNhanTinVanBan);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(ckbSendAnh);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(ckbTuongTacKhiNhanTin);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(rbTuongTacTruocKhiNhanTin);
		GClass29.smethod_1(rbTuongTacSauKhiNhanTin);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label14);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
		GClass29.smethod_1(ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDBuffTinNhanProfile_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = gclass17_0.method_2("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass17_0.method_2("nudSoLuongUidTo", 3);
			nudSoLuongAnhFrom.Value = gclass17_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass17_0.method_2("nudSoLuongAnhTo", 1);
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			txtUid.Text = gclass17_0.method_0("txtUid");
			ckbAddFriend.Checked = gclass17_0.method_3("ckbAddFriend");
			ckbNhanTinVanBan.Checked = gclass17_0.method_3("ckbNhanTinVanBan");
			txtNoiDung.Text = gclass17_0.method_0("txtNoiDung");
			ckbSendAnh.Checked = gclass17_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass17_0.method_0("txtAnh");
			ckbTuongTacKhiNhanTin.Checked = gclass17_0.method_3("ckbTuongTacKhiNhanTin");
			if (gclass17_0.method_2("typeTuongTacKhiNhanTin") == 0)
			{
				rbTuongTacTruocKhiNhanTin.Checked = true;
			}
			else
			{
				rbTuongTacSauKhiNhanTin.Checked = true;
			}
			ckbTuongTacKhiNhanTinLike.Checked = gclass17_0.method_3("ckbTuongTacKhiNhanTinLike");
			ckbTuongTacKhiNhanTinComment.Checked = gclass17_0.method_3("ckbTuongTacKhiNhanTinComment");
			txtTuongTacKhiNhanTinComment.Text = gclass17_0.method_0("txtTuongTacKhiNhanTinComment");
			if (gclass17_0.method_2("typeNganCachComment") == 1)
			{
				ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
			}
			else
			{
				ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
			}
			ckbTuDongXoaUid.Checked = gclass17_0.method_3("ckbTuDongXoaUid");
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
		method_4();
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
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!"), 3);
			return;
		}
		if (ckbNhanTinVanBan.Checked)
		{
			list_ = txtNoiDung.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			if (list_.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhắn!"), 3);
				return;
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
		gClass.method_5("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.method_5("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("txtUid", txtUid.Text.Trim());
		gClass.method_5("ckbAddFriend", ckbAddFriend.Checked);
		gClass.method_5("ckbNhanTinVanBan", ckbNhanTinVanBan.Checked);
		gClass.method_5("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.method_5("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_5("txtAnh", txtAnh.Text.Trim());
		gClass.method_5("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.method_5("ckbTuongTacKhiNhanTin", ckbTuongTacKhiNhanTin.Checked);
		if (rbTuongTacTruocKhiNhanTin.Checked)
		{
			gClass.method_5("typeTuongTacKhiNhanTin", 0);
		}
		else
		{
			gClass.method_5("typeTuongTacKhiNhanTin", 1);
		}
		gClass.method_5("ckbTuongTacKhiNhanTinLike", ckbTuongTacKhiNhanTinLike.Checked);
		gClass.method_5("ckbTuongTacKhiNhanTinComment", ckbTuongTacKhiNhanTinComment.Checked);
		gClass.method_5("txtTuongTacKhiNhanTinComment", txtTuongTacKhiNhanTinComment.Text.Trim());
		int num = 0;
		if (ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked)
		{
			num = 1;
		}
		gClass.method_5("typeNganCachComment", num);
		int num2 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num2 = 1;
		}
		gClass.method_5("typeNganCach", num2);
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

	private void method_2(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_3()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = GClass14.smethod_36(list);
			lblStatus.Text = string.Format(GClass29.smethod_0("Nội dung tin nhắn ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_4()
	{
		method_5(null, null);
		ckbNhanTinVanBan_CheckedChanged(null, null);
		ckbTuongTacKhiNhanTin_CheckedChanged(null, null);
		ckbTuongTacKhiNhanTinComment_CheckedChanged(null, null);
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void ckbNhanTinVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbNhanTinVanBan.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtUid.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblStatusUid.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void method_6(object sender, EventArgs e)
	{
		txtAnh.Text = GClass14.smethod_40();
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plComment.Height = 235;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plComment.Height = 185;
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_3();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_3();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void ckbTuongTacKhiNhanTin_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacTruocKhiNhanTin.Enabled = ckbTuongTacKhiNhanTin.Checked;
	}

	private void ckbTuongTacKhiNhanTinComment_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacTruocKhiNhanTinComment.Enabled = ckbTuongTacKhiNhanTinComment.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtTuongTacKhiNhanTinComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtTuongTacKhiNhanTinComment.Focus();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0("Có thể dùng [u] để thay thế tên của UID!");
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
	}

	private void button6_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void button5_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffTinNhanProfile));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbAddFriend = new System.Windows.Forms.CheckBox();
		this.plTuongTacTruocKhiNhanTin = new System.Windows.Forms.Panel();
		this.rbTuongTacSauKhiNhanTin = new System.Windows.Forms.RadioButton();
		this.ckbTuongTacKhiNhanTinComment = new System.Windows.Forms.CheckBox();
		this.rbTuongTacTruocKhiNhanTin = new System.Windows.Forms.RadioButton();
		this.label15 = new System.Windows.Forms.Label();
		this.ckbTuongTacKhiNhanTinLike = new System.Windows.Forms.CheckBox();
		this.label16 = new System.Windows.Forms.Label();
		this.plTuongTacTruocKhiNhanTinComment = new System.Windows.Forms.Panel();
		this.button4 = new System.Windows.Forms.Button();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label17 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong = new System.Windows.Forms.RadioButton();
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong = new System.Windows.Forms.RadioButton();
		this.label12 = new System.Windows.Forms.Label();
		this.txtTuongTacKhiNhanTinComment = new System.Windows.Forms.RichTextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.plComment = new System.Windows.Forms.Panel();
		this.button5 = new System.Windows.Forms.Button();
		this.button6 = new System.Windows.Forms.Button();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label11 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.label10 = new System.Windows.Forms.Label();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.lblStatusUid = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.ckbTuongTacKhiNhanTin = new System.Windows.Forms.CheckBox();
		this.ckbNhanTinVanBan = new System.Windows.Forms.CheckBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plTuongTacTruocKhiNhanTin.SuspendLayout();
		this.plTuongTacTruocKhiNhanTinComment.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1009, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Buff Tin nhắn Profile";
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
		this.pnlHeader.Size = new System.Drawing.Size(1009, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(978, 1);
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
		this.panel1.Controls.Add(this.ckbAddFriend);
		this.panel1.Controls.Add(this.plTuongTacTruocKhiNhanTin);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.lblStatusUid);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.ckbTuongTacKhiNhanTin);
		this.panel1.Controls.Add(this.ckbNhanTinVanBan);
		this.panel1.Controls.Add(this.ckbTuDongXoaUid);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1012, 447);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.ckbAddFriend.AutoSize = true;
		this.ckbAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddFriend.Location = new System.Drawing.Point(677, 59);
		this.ckbAddFriend.Name = "ckbAddFriend";
		this.ckbAddFriend.Size = new System.Drawing.Size(173, 20);
		this.ckbAddFriend.TabIndex = 164;
		this.ckbAddFriend.Text = "Kết bạn trước khi nhắn tin";
		this.ckbAddFriend.UseVisualStyleBackColor = true;
		this.plTuongTacTruocKhiNhanTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.rbTuongTacSauKhiNhanTin);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.ckbTuongTacKhiNhanTinComment);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.rbTuongTacTruocKhiNhanTin);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.label15);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.ckbTuongTacKhiNhanTinLike);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.label16);
		this.plTuongTacTruocKhiNhanTin.Controls.Add(this.plTuongTacTruocKhiNhanTinComment);
		this.plTuongTacTruocKhiNhanTin.Enabled = false;
		this.plTuongTacTruocKhiNhanTin.Location = new System.Drawing.Point(695, 105);
		this.plTuongTacTruocKhiNhanTin.Name = "plTuongTacTruocKhiNhanTin";
		this.plTuongTacTruocKhiNhanTin.Size = new System.Drawing.Size(297, 272);
		this.plTuongTacTruocKhiNhanTin.TabIndex = 163;
		this.rbTuongTacSauKhiNhanTin.AutoSize = true;
		this.rbTuongTacSauKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacSauKhiNhanTin.Location = new System.Drawing.Point(77, 28);
		this.rbTuongTacSauKhiNhanTin.Name = "rbTuongTacSauKhiNhanTin";
		this.rbTuongTacSauKhiNhanTin.Size = new System.Drawing.Size(177, 20);
		this.rbTuongTacSauKhiNhanTin.TabIndex = 105;
		this.rbTuongTacSauKhiNhanTin.Text = "Tương tác sau khi nhắn tin";
		this.rbTuongTacSauKhiNhanTin.UseVisualStyleBackColor = true;
		this.ckbTuongTacKhiNhanTinComment.AutoSize = true;
		this.ckbTuongTacKhiNhanTinComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacKhiNhanTinComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacKhiNhanTinComment.Location = new System.Drawing.Point(161, 52);
		this.ckbTuongTacKhiNhanTinComment.Name = "ckbTuongTacKhiNhanTinComment";
		this.ckbTuongTacKhiNhanTinComment.Size = new System.Drawing.Size(81, 20);
		this.ckbTuongTacKhiNhanTinComment.TabIndex = 96;
		this.ckbTuongTacKhiNhanTinComment.Text = "Comment";
		this.ckbTuongTacKhiNhanTinComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacKhiNhanTinComment.CheckedChanged += new System.EventHandler(ckbTuongTacKhiNhanTinComment_CheckedChanged);
		this.rbTuongTacTruocKhiNhanTin.AutoSize = true;
		this.rbTuongTacTruocKhiNhanTin.Checked = true;
		this.rbTuongTacTruocKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacTruocKhiNhanTin.Location = new System.Drawing.Point(77, 6);
		this.rbTuongTacTruocKhiNhanTin.Name = "rbTuongTacTruocKhiNhanTin";
		this.rbTuongTacTruocKhiNhanTin.Size = new System.Drawing.Size(187, 20);
		this.rbTuongTacTruocKhiNhanTin.TabIndex = 106;
		this.rbTuongTacTruocKhiNhanTin.TabStop = true;
		this.rbTuongTacTruocKhiNhanTin.Text = "Tương tác trước khi nhắn tin";
		this.rbTuongTacTruocKhiNhanTin.UseVisualStyleBackColor = true;
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label15.Location = new System.Drawing.Point(6, 8);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(64, 16);
		this.label15.TabIndex = 103;
		this.label15.Text = "Tùy chọn:";
		this.ckbTuongTacKhiNhanTinLike.AutoSize = true;
		this.ckbTuongTacKhiNhanTinLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacKhiNhanTinLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacKhiNhanTinLike.Location = new System.Drawing.Point(106, 52);
		this.ckbTuongTacKhiNhanTinLike.Name = "ckbTuongTacKhiNhanTinLike";
		this.ckbTuongTacKhiNhanTinLike.Size = new System.Drawing.Size(48, 20);
		this.ckbTuongTacKhiNhanTinLike.TabIndex = 95;
		this.ckbTuongTacKhiNhanTinLike.Text = "Like";
		this.ckbTuongTacKhiNhanTinLike.UseVisualStyleBackColor = true;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label16.Location = new System.Drawing.Point(6, 53);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(93, 16);
		this.label16.TabIndex = 104;
		this.label16.Text = "Loa\u0323i tương ta\u0301c:";
		this.plTuongTacTruocKhiNhanTinComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.button4);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.linkLabel1);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.label17);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.button3);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.button2);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.label12);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.txtTuongTacKhiNhanTinComment);
		this.plTuongTacTruocKhiNhanTinComment.Controls.Add(this.label14);
		this.plTuongTacTruocKhiNhanTinComment.Location = new System.Drawing.Point(9, 75);
		this.plTuongTacTruocKhiNhanTinComment.Name = "plTuongTacTruocKhiNhanTinComment";
		this.plTuongTacTruocKhiNhanTinComment.Size = new System.Drawing.Size(281, 191);
		this.plTuongTacTruocKhiNhanTinComment.TabIndex = 101;
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(247, 120);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(23, 23);
		this.button4.TabIndex = 189;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(167, 123);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 188;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(5, 123);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(131, 16);
		this.label17.TabIndex = 187;
		this.label17.Text = "Spin content: {a|b|c}";
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(226, 165);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 5;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(226, 142);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 23);
		this.button2.TabIndex = 6;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.AutoSize = true;
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Location = new System.Drawing.Point(70, 164);
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Name = "ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong";
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Size = new System.Drawing.Size(159, 20);
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.TabIndex = 3;
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Text = "Nội dung có nhiều dòng";
		this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.UseVisualStyleBackColor = true;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.AutoSize = true;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Location = new System.Drawing.Point(70, 143);
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Name = "ckbTuongTacKhiNhanTinCommentNoiDung1Dong";
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Size = new System.Drawing.Size(155, 20);
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabIndex = 3;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabStop = true;
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Text = "Nội dung chỉ có 1 dòng";
		this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.UseVisualStyleBackColor = true;
		this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(5, 143);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(64, 16);
		this.label12.TabIndex = 2;
		this.label12.Text = "Tùy chọn:";
		this.txtTuongTacKhiNhanTinComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtTuongTacKhiNhanTinComment.Location = new System.Drawing.Point(7, 23);
		this.txtTuongTacKhiNhanTinComment.Name = "txtTuongTacKhiNhanTinComment";
		this.txtTuongTacKhiNhanTinComment.Size = new System.Drawing.Size(263, 97);
		this.txtTuongTacKhiNhanTinComment.TabIndex = 1;
		this.txtTuongTacKhiNhanTinComment.Text = "";
		this.txtTuongTacKhiNhanTinComment.WordWrap = false;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(3, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(118, 16);
		this.label14.TabIndex = 0;
		this.label14.Text = "Nội dung bình luận:";
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtNoiDung);
		this.plComment.Controls.Add(this.button5);
		this.plComment.Controls.Add(this.button6);
		this.plComment.Controls.Add(this.btnDown);
		this.plComment.Controls.Add(this.btnUp);
		this.plComment.Controls.Add(this.rbNganCachKyTu);
		this.plComment.Controls.Add(this.rbNganCachMoiDong);
		this.plComment.Controls.Add(this.label11);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(376, 105);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 185);
		this.plComment.TabIndex = 10;
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(224, 210);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(21, 23);
		this.button5.TabIndex = 13;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.button6.Cursor = System.Windows.Forms.Cursors.Help;
		this.button6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button6.Location = new System.Drawing.Point(224, 187);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(21, 23);
		this.button6.TabIndex = 14;
		this.button6.Text = "?";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(button6_Click);
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 11;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 12;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(68, 209);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 10;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(68, 188);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 9;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(3, 188);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(64, 16);
		this.label11.TabIndex = 8;
		this.label11.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 163);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(265, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Spin nội dung {a|b|c} - [u]: Họ tên của Uid)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 3);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(133, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung tin nhắn (0):";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.label10);
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label3);
		this.plAnh.Controls.Add(this.label4);
		this.plAnh.Controls.Add(this.label9);
		this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
		this.plAnh.Controls.Add(this.nudSoLuongAnhTo);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(376, 319);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(281, 58);
		this.plAnh.TabIndex = 162;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(3, 6);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(137, 16);
		this.label10.TabIndex = 159;
		this.label10.Text = "Đường dẫn folder ảnh:";
		this.txtAnh.Location = new System.Drawing.Point(143, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(133, 23);
		this.txtAnh.TabIndex = 158;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 31);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(103, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Số ảnh/tin nhắn:";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(251, 31);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 36;
		this.label4.Text = "ảnh";
		this.label9.Location = new System.Drawing.Point(175, 31);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = "đê\u0301n";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(129, 29);
		this.nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(43, 23);
		this.nudSoLuongAnhFrom.TabIndex = 5;
		this.nudSoLuongAnhTo.Location = new System.Drawing.Point(206, 29);
		this.nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		this.nudSoLuongAnhTo.Size = new System.Drawing.Size(43, 23);
		this.nudSoLuongAnhTo.TabIndex = 6;
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(358, 296);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(70, 20);
		this.ckbSendAnh.TabIndex = 161;
		this.ckbSendAnh.Text = "Gửi ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(31, 154);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(299, 181);
		this.txtUid.TabIndex = 117;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(229, 338);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(102, 16);
		this.label2.TabIndex = 115;
		this.label2.Text = "(Mỗi Uid 1 dòng)";
		this.lblStatusUid.AutoSize = true;
		this.lblStatusUid.Location = new System.Drawing.Point(28, 135);
		this.lblStatusUid.Name = "lblStatusUid";
		this.lblStatusUid.Size = new System.Drawing.Size(237, 16);
		this.lblStatusUid.TabIndex = 116;
		this.lblStatusUid.Text = "Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin (0):";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 81);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(101, 16);
		this.label49.TabIndex = 92;
		this.label49.Text = "Sô\u0301 lươ\u0323ng Uid(?):";
		this.toolTip_0.SetToolTip(this.label49, "Mỗi tài khoản chỉ nhắn tin được tối đa 50 người tại 1 thời điểm!");
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
		this.label68.Size = new System.Drawing.Size(25, 16);
		this.label68.TabIndex = 99;
		this.label68.Text = "Uid";
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
		this.ckbTuongTacKhiNhanTin.AutoSize = true;
		this.ckbTuongTacKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacKhiNhanTin.Location = new System.Drawing.Point(677, 81);
		this.ckbTuongTacKhiNhanTin.Name = "ckbTuongTacKhiNhanTin";
		this.ckbTuongTacKhiNhanTin.Size = new System.Drawing.Size(154, 20);
		this.ckbTuongTacKhiNhanTin.TabIndex = 9;
		this.ckbTuongTacKhiNhanTin.Text = "Tương tác khi nhắn tin";
		this.ckbTuongTacKhiNhanTin.UseVisualStyleBackColor = true;
		this.ckbTuongTacKhiNhanTin.CheckedChanged += new System.EventHandler(ckbTuongTacKhiNhanTin_CheckedChanged);
		this.ckbNhanTinVanBan.AutoSize = true;
		this.ckbNhanTinVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNhanTinVanBan.Location = new System.Drawing.Point(358, 81);
		this.ckbNhanTinVanBan.Name = "ckbNhanTinVanBan";
		this.ckbNhanTinVanBan.Size = new System.Drawing.Size(122, 20);
		this.ckbNhanTinVanBan.TabIndex = 9;
		this.ckbNhanTinVanBan.Text = "Nhắn tin văn bản";
		this.ckbNhanTinVanBan.UseVisualStyleBackColor = true;
		this.ckbNhanTinVanBan.CheckedChanged += new System.EventHandler(ckbNhanTinVanBan_CheckedChanged);
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(30, 357);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(295, 20);
		this.ckbTuDongXoaUid.TabIndex = 8;
		this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã nhắn tin (Không trùng UID)";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(232, 108);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.nudDelayFrom.Location = new System.Drawing.Point(135, 108);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 5;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(197, 110);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 110);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 110);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(513, 398);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
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
		this.btnAdd.Location = new System.Drawing.Point(406, 398);
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
		this.bunifuCards1.Size = new System.Drawing.Size(1009, 37);
		this.bunifuCards1.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 20000;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 0;
		this.toolTip_0.ToolTipTitle = "Chú ý";
		this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(263, 137);
		this.txtNoiDung.TabIndex = 165;
		this.txtNoiDung.Text = "";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1012, 447);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffTinNhanProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffTinNhanProfile_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plTuongTacTruocKhiNhanTin.ResumeLayout(false);
		this.plTuongTacTruocKhiNhanTin.PerformLayout();
		this.plTuongTacTruocKhiNhanTinComment.ResumeLayout(false);
		this.plTuongTacTruocKhiNhanTinComment.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
