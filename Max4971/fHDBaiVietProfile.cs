using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBaiVietProfile : Form
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

	private Panel plComment;

	private Label lblStatus;

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

	private RichTextBox txtComment;

	private CheckBox ckbTuDongXoaUid;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private CheckBox ckbRandomGoVanBan;

	private Button btnChooseFileUid;

	private RadioButton rbListUid;

	private RadioButton rbFileUid;

	private Label label10;

	private TextBox txtPathFileUid;

	private TextBox txtAnh;

	private Label label12;

	private Button button3;

	private Button button2;

	private Button button4;

	private LinkLabel linkLabel1;

	private Label label2;

	private Button button5;

	public fHDBaiVietProfile(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDBaiVietProfile").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\",  \"nudSoLuongBaiVietFrom\": \"1\",  \"nudSoLuongBaiVietTo\": \"3\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",\"txtUid\": \"\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết Profile');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDBaiVietProfile");
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
		GClass29.smethod_1(ckbRandomGoVanBan);
		GClass29.smethod_1(ckbInteract);
		GClass29.smethod_1(ckbShareWall);
		GClass29.smethod_1(ckbComment);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(rbNganCachMoiDong);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(rbNganCachKyTu);
		GClass29.smethod_1(button3);
		GClass29.smethod_1(ckbSendAnh);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDBaiVietProfile_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = gclass17_0.method_2("nudSoLuongUidFrom");
			nudSoLuongUidTo.Value = gclass17_0.method_2("nudSoLuongUidTo");
			nudSoLuongBaiVietFrom.Value = gclass17_0.method_2("nudSoLuongBaiVietFrom");
			nudSoLuongBaiVietTo.Value = gclass17_0.method_2("nudSoLuongBaiVietTo");
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom");
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo");
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
			txtComment.Text = gclass17_0.method_0("txtComment");
			ckbSendAnh.Checked = gclass17_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass17_0.method_0("txtAnh");
			ckbTuDongXoaUid.Checked = gclass17_0.method_3("ckbTuDongXoaUid");
			ckbRandomGoVanBan.Checked = gclass17_0.method_3("ckbRandomGoVanBan");
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
		method_3();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
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
			if (ckbComment.Checked)
			{
				List<string> list_2 = txtComment.Lines.ToList();
				list_2 = GClass14.smethod_36(list_2);
				if (list_2.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
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
			gClass.method_5("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass.method_5("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
			gClass.method_5("nudDelayTo", nudDelayTo.Value);
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
			gClass.method_5("txtComment", txtComment.Text.Trim());
			gClass.method_5("ckbSendAnh", ckbSendAnh.Checked);
			gClass.method_5("txtAnh", txtAnh.Text.Trim());
			gClass.method_5("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
			gClass.method_5("ckbRandomGoVanBan", ckbRandomGoVanBan.Checked);
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			gClass.method_5("typeNganCach", num);
			string string_ = gClass.method_9();
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
		else
		{
			if (GClass38.smethod_1(GClass29.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) != DialogResult.Yes)
			{
				return;
			}
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
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
				List<string> list_3 = txtUid.Lines.ToList();
				list_3 = GClass14.smethod_36(list_3);
				if (list_3.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!"), 3);
					return;
				}
			}
			if (ckbComment.Checked)
			{
				List<string> list_4 = txtComment.Lines.ToList();
				list_4 = GClass14.smethod_36(list_4);
				if (list_4.Count == 0)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			if (ckbSendAnh.Checked && txtAnh.Text.Trim().Length == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn folder ảnh!"), 3);
				return;
			}
			GClass17 gClass2 = new GClass17();
			gClass2.method_5("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
			gClass2.method_5("nudSoLuongUidTo", nudSoLuongUidTo.Value);
			gClass2.method_5("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass2.method_5("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass2.method_5("nudDelayFrom", nudDelayFrom.Value);
			gClass2.method_5("nudDelayTo", nudDelayTo.Value);
			if (rbFileUid.Checked)
			{
				gClass2.method_5("typeListUid", 1);
			}
			else
			{
				gClass2.method_5("typeListUid", 0);
			}
			gClass2.method_5("txtPathFileUid", txtPathFileUid.Text.Trim());
			gClass2.method_5("txtUid", txtUid.Text.Trim());
			gClass2.method_5("ckbInteract", ckbInteract.Checked);
			gClass2.method_5("ckbShareWall", ckbShareWall.Checked);
			gClass2.method_5("ckbComment", ckbComment.Checked);
			gClass2.method_5("txtComment", txtComment.Text.Trim());
			gClass2.method_5("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.method_5("txtAnh", txtAnh.Text.Trim());
			gClass2.method_5("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
			gClass2.method_5("ckbRandomGoVanBan", ckbRandomGoVanBan.Checked);
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			gClass2.method_5("typeNganCach", num2);
			gClass2.method_5("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.method_5("txtAnh", txtAnh.Text.Trim());
			string text3 = gClass2.method_9();
			if (Class307.smethod_20(string_2, text2, text3))
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

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
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

	private void method_3()
	{
		method_4(null, null);
		ckbComment_CheckedChanged(null, null);
		rbFileUid_CheckedChanged(null, null);
		rbListUid_CheckedChanged(null, null);
	}

	private void method_4(object sender, EventArgs e)
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

	private void method_5(object sender, EventArgs e)
	{
		txtAnh.Text = GClass14.smethod_40();
	}

	private void txtComment_MouseLeave(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void panel1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbRandomGoVanBan.Visible = true;
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

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + GClass29.smethod_0("Ví dụ") + ": 15465478242/posts");
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
	}

	private void button5_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0("Có thể dùng [u] để thay thế tên của UID!");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietProfile));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.button4 = new System.Windows.Forms.Button();
		this.btnChooseFileUid = new System.Windows.Forms.Button();
		this.rbListUid = new System.Windows.Forms.RadioButton();
		this.rbFileUid = new System.Windows.Forms.RadioButton();
		this.plComment = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblStatus = new System.Windows.Forms.Label();
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
		this.ckbRandomGoVanBan = new System.Windows.Forms.CheckBox();
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
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label2 = new System.Windows.Forms.Label();
		this.button5 = new System.Windows.Forms.Button();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(680, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Profile";
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
		this.pnlHeader.Size = new System.Drawing.Size(680, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(649, 1);
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
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.btnChooseFileUid);
		this.panel1.Controls.Add(this.rbListUid);
		this.panel1.Controls.Add(this.rbFileUid);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.ckbRandomGoVanBan);
		this.panel1.Controls.Add(this.ckbTuDongXoaUid);
		this.panel1.Controls.Add(this.ckbShareWall);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.panel1.Controls.Add(this.txtPathFileUid);
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
		this.panel1.Size = new System.Drawing.Size(683, 432);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(panel1_Click);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(267, 167);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 5;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.btnChooseFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnChooseFileUid.Location = new System.Drawing.Point(267, 189);
		this.btnChooseFileUid.Name = "btnChooseFileUid";
		this.btnChooseFileUid.Size = new System.Drawing.Size(63, 25);
		this.btnChooseFileUid.TabIndex = 156;
		this.btnChooseFileUid.Text = "Chọn";
		this.btnChooseFileUid.UseVisualStyleBackColor = true;
		this.btnChooseFileUid.Click += new System.EventHandler(btnChooseFileUid_Click);
		this.rbListUid.AutoSize = true;
		this.rbListUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbListUid.Location = new System.Drawing.Point(31, 213);
		this.rbListUid.Name = "rbListUid";
		this.rbListUid.Size = new System.Drawing.Size(175, 20);
		this.rbListUid.TabIndex = 163;
		this.rbListUid.Text = "Nhập (Mỗi Uid 1 dòng) (0)";
		this.rbListUid.UseVisualStyleBackColor = true;
		this.rbListUid.CheckedChanged += new System.EventHandler(rbListUid_CheckedChanged);
		this.rbFileUid.AutoSize = true;
		this.rbFileUid.Checked = true;
		this.rbFileUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbFileUid.Location = new System.Drawing.Point(31, 190);
		this.rbFileUid.Name = "rbFileUid";
		this.rbFileUid.Size = new System.Drawing.Size(95, 20);
		this.rbFileUid.TabIndex = 163;
		this.rbFileUid.TabStop = true;
		this.rbFileUid.Text = "Nhập từ File";
		this.rbFileUid.UseVisualStyleBackColor = true;
		this.rbFileUid.CheckedChanged += new System.EventHandler(rbFileUid_CheckedChanged);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.linkLabel1);
		this.plComment.Controls.Add(this.label2);
		this.plComment.Controls.Add(this.button5);
		this.plComment.Controls.Add(this.button3);
		this.plComment.Controls.Add(this.button2);
		this.plComment.Controls.Add(this.rbNganCachKyTu);
		this.plComment.Controls.Add(this.rbNganCachMoiDong);
		this.plComment.Controls.Add(this.label9);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(369, 128);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 193);
		this.plComment.TabIndex = 10;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(229, 168);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 4;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(229, 145);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 23);
		this.button2.TabIndex = 4;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		this.rbNganCachKyTu.TabIndex = 3;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(70, 147);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		this.rbNganCachMoiDong.TabIndex = 3;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(5, 147);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(65, 16);
		this.label9.TabIndex = 2;
		this.label9.Text = "Tùy chọn:";
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 99);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.txtComment.MouseEnter += new System.EventHandler(txtComment_MouseEnter);
		this.txtComment.MouseLeave += new System.EventHandler(txtComment_MouseLeave);
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(140, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label12);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(369, 349);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(281, 31);
		this.plAnh.TabIndex = 162;
		this.txtAnh.Location = new System.Drawing.Point(136, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(140, 23);
		this.txtAnh.TabIndex = 159;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(138, 16);
		this.label12.TabIndex = 158;
		this.label12.Text = "Đường dẫn folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(351, 327);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(104, 20);
		this.ckbSendAnh.TabIndex = 161;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(31, 236);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(299, 115);
		this.txtUid.TabIndex = 117;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 170);
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
		this.label19.Location = new System.Drawing.Point(27, 112);
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
		this.ckbComment.Location = new System.Drawing.Point(351, 103);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(128, 20);
		this.ckbComment.TabIndex = 9;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.ckbRandomGoVanBan.AutoSize = true;
		this.ckbRandomGoVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRandomGoVanBan.Location = new System.Drawing.Point(31, 383);
		this.ckbRandomGoVanBan.Name = "ckbRandomGoVanBan";
		this.ckbRandomGoVanBan.Size = new System.Drawing.Size(141, 20);
		this.ckbRandomGoVanBan.TabIndex = 8;
		this.ckbRandomGoVanBan.Text = "Random go\u0303 văn ba\u0309n";
		this.ckbRandomGoVanBan.UseVisualStyleBackColor = true;
		this.ckbRandomGoVanBan.Visible = false;
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 357);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(304, 20);
		this.ckbTuDongXoaUid.TabIndex = 8;
		this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(351, 77);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(168, 20);
		this.ckbShareWall.TabIndex = 8;
		this.ckbShareWall.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(351, 51);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(94, 20);
		this.ckbInteract.TabIndex = 7;
		this.ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(232, 140);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 110);
		this.nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(135, 140);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 5;
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 110);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 3;
		this.txtPathFileUid.Location = new System.Drawing.Point(135, 190);
		this.txtPathFileUid.Name = "txtPathFileUid";
		this.txtPathFileUid.Size = new System.Drawing.Size(126, 23);
		this.txtPathFileUid.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(197, 142);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(197, 112);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 142);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 112);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(25, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0300i";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 142);
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
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(349, 390);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(242, 390);
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
		this.bunifuCards1.Size = new System.Drawing.Size(680, 37);
		this.bunifuCards1.TabIndex = 28;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(163, 126);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 187;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(5, 126);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(132, 16);
		this.label2.TabIndex = 186;
		this.label2.Text = "Spin content: {a|b|c}";
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(247, 123);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(23, 23);
		this.button5.TabIndex = 185;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(683, 432);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBaiVietProfile_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
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
		base.ResumeLayout(false);
	}
}
