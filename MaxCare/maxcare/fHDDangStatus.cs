using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fHDDangStatus : Form
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

	private CheckBox ckbAnh;

	private CheckBox ckbVanBan;

	private Panel plVanBan;

	private Label label8;

	private Label lblStatus;

	private Panel plAnh;

	private TextBox txtPathAnh;

	private Label label3;

	private Panel plVideo;

	private TextBox txtPathVideo;

	private Label label7;

	private CheckBox ckbVideo;

	private RichTextBox txtNoiDung;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private CheckBox ckbUseBackground;

	private Panel plTag;

	private RichTextBox txtUidTag;

	private Label label11;

	private Label label10;

	private Label lbUid;

	private CheckBox ckbTag;

	private NumericUpDown nudUidTo;

	private NumericUpDown nudUidFrom;

	private Label label13;

	private Label label14;

	private RadioButton rbUidTuNhap;

	private RadioButton rbUidBanBe;

	private Label label12;

	private Panel plUidTuNhap;

	private Label label19;

	private Label label20;

	private NumericUpDown nudKhoangCachTo;

	private NumericUpDown nudKhoangCachFrom;

	private Label label18;

	private Label label17;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label16;

	private Label label15;

	private NumericUpDown nudSoLuongVideoTo;

	private NumericUpDown nudSoLuongVideoFrom;

	private Label label5;

	private Label label6;

	private Label label22;

	private NumericUpDown nudSoLuongAnhTo;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label label2;

	private Label label4;

	private Label label21;

	private Button button2;

	private Button button3;

	private Button button4;

	private LinkLabel linkLabel1;

	public fHDDangStatus(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDDangStatus").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDDangStatus', '{  \"ckbVanBan\": \"False\",\"txtNoiDung\": \"\",   \"ckbAnh\": \"False\",\"txtPathAnh\":\"\",\"nudSoLuongAnh\": \"1\",  \"ckbVideo\": \"False\",\"txtPathVideo\":\"\",\"nudSoLuongVideo\": \"1\"}', 'Đăng status');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDDangStatus");
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
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(label18);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(ckbVanBan);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(ckbAnh);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(ckbUseBackground);
		GClass29.smethod_1(ckbVideo);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label22);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(ckbTag);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(rbUidBanBe);
		GClass29.smethod_1(rbUidTuNhap);
		GClass29.smethod_1(lbUid);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDDangStatus_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass17_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass17_0.method_2("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = gclass17_0.method_2("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = gclass17_0.method_2("nudKhoangCachTo", 10);
			ckbVanBan.Checked = gclass17_0.method_3("ckbVanBan");
			ckbUseBackground.Checked = gclass17_0.method_3("ckbUseBackground");
			txtNoiDung.Text = gclass17_0.method_0("txtNoiDung");
			ckbAnh.Checked = gclass17_0.method_3("ckbAnh");
			ckbVideo.Checked = gclass17_0.method_3("ckbVideo");
			nudSoLuongAnhFrom.Value = gclass17_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass17_0.method_2("nudSoLuongAnhTo", 1);
			nudSoLuongVideoFrom.Value = gclass17_0.method_2("nudSoLuongVideoFrom", 1);
			nudSoLuongVideoTo.Value = gclass17_0.method_2("nudSoLuongVideoTo", 1);
			txtPathAnh.Text = gclass17_0.method_0("txtPathAnh");
			txtPathVideo.Text = gclass17_0.method_0("txtPathVideo");
			if (gclass17_0.method_2("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			if (gclass17_0.method_2("typeUidTag") == 0)
			{
				rbUidBanBe.Checked = true;
			}
			else
			{
				rbUidTuNhap.Checked = true;
			}
			ckbTag.Checked = gclass17_0.method_3("ckbTag");
			txtUidTag.Text = gclass17_0.method_0("txtUidTag");
			nudUidFrom.Value = gclass17_0.method_2("nudUidFrom", 1);
			nudUidTo.Value = gclass17_0.method_2("nudUidTo", 1);
		}
		catch (Exception)
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
		if (ckbAnh.Checked && !Directory.Exists(txtPathAnh.Text.Trim()))
		{
			GClass38.smethod_0(GClass29.smethod_0("Đường dẫn ảnh không tồn tại!"), 3);
			return;
		}
		if (ckbVideo.Checked && !Directory.Exists(txtPathVideo.Text.Trim()))
		{
			GClass38.smethod_0(GClass29.smethod_0("Đường dẫn video không tồn tại!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_5("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_5("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		gClass.method_5("nudKhoangCachTo", nudKhoangCachTo.Value);
		gClass.method_5("ckbVanBan", ckbVanBan.Checked);
		gClass.method_5("ckbUseBackground", ckbUseBackground.Checked);
		gClass.method_5("ckbAnh", ckbAnh.Checked);
		gClass.method_5("ckbVideo", ckbVideo.Checked);
		gClass.method_5("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.method_5("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.method_5("nudSoLuongVideoFrom", nudSoLuongVideoFrom.Value);
		gClass.method_5("nudSoLuongVideoTo", nudSoLuongVideoTo.Value);
		gClass.method_5("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.method_5("txtPathAnh", txtPathAnh.Text.Trim());
		gClass.method_5("txtPathVideo", txtPathVideo.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.method_5("typeNganCach", num);
		if (rbUidBanBe.Checked)
		{
			gClass.method_5("typeUidTag", 0);
		}
		else if (rbUidTuNhap.Checked)
		{
			gClass.method_5("typeUidTag", 1);
		}
		gClass.method_5("ckbTag", ckbTag.Checked);
		gClass.method_5("txtUidTag", txtUidTag.Text.Trim());
		gClass.method_5("nudUidFrom", nudUidFrom.Value);
		gClass.method_5("nudUidTo", nudUidTo.Value);
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

	private void method_1()
	{
		ckbVanBan_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		ckbVideo_CheckedChanged(null, null);
		ckbTag_CheckedChanged(null, null);
		rbUidTuNhap_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
		if (!ckbVanBan.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void ckbVideo_CheckedChanged(object sender, EventArgs e)
	{
		plVideo.Enabled = ckbVideo.Checked;
		if (ckbVideo.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = GClass14.smethod_36(list);
			lblStatus.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtUidTag.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtUidTag.Lines.ToList());
			list = GClass14.smethod_36(list);
			lbUid.Text = string.Format(GClass29.smethod_0("Danh sách Uid ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		txtPathAnh.Text = GClass14.smethod_40();
	}

	private void method_5(object sender, EventArgs e)
	{
		txtPathVideo.Text = GClass14.smethod_40();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 325;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 276;
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void ckbTag_CheckedChanged(object sender, EventArgs e)
	{
		plTag.Enabled = ckbTag.Checked;
	}

	private void txtUidTag_TextChanged(object sender, EventArgs e)
	{
		method_3();
	}

	private void lbUid_Click(object sender, EventArgs e)
	{
	}

	private void label11_Click(object sender, EventArgs e)
	{
	}

	private void rbUidTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		plUidTuNhap.Enabled = rbUidTuNhap.Checked;
	}

	private void txtPathAnh_TextChanged(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string object_ = GClass29.smethod_0("Có thể dùng:") + Environment.NewLine + GClass29.smethod_0("- [full_name] để thay thế họ tên của tài khoản!") + Environment.NewLine + GClass29.smethod_0("- [name] để thay thế tên của tài khoản!");
		GClass38.smethod_0(object_);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtNoiDung.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtNoiDung.Focus();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangStatus));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label19 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		this.nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.plTag = new System.Windows.Forms.Panel();
		this.plUidTuNhap = new System.Windows.Forms.Panel();
		this.lbUid = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.txtUidTag = new System.Windows.Forms.RichTextBox();
		this.rbUidTuNhap = new System.Windows.Forms.RadioButton();
		this.rbUidBanBe = new System.Windows.Forms.RadioButton();
		this.nudUidTo = new System.Windows.Forms.NumericUpDown();
		this.nudUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.plVanBan = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.button4 = new System.Windows.Forms.Button();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		this.plVideo = new System.Windows.Forms.Panel();
		this.nudSoLuongVideoTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongVideoFrom = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.txtPathVideo = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.txtPathAnh = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbVideo = new System.Windows.Forms.CheckBox();
		this.ckbTag = new System.Windows.Forms.CheckBox();
		this.ckbUseBackground = new System.Windows.Forms.CheckBox();
		this.ckbAnh = new System.Windows.Forms.CheckBox();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.plTag.SuspendLayout();
		this.plUidTuNhap.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudUidFrom).BeginInit();
		this.plVanBan.SuspendLayout();
		this.plVideo.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoFrom).BeginInit();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Đăng status";
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
		this.button1.TabIndex = 0;
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
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.nudKhoangCachTo);
		this.panel1.Controls.Add(this.nudKhoangCachFrom);
		this.panel1.Controls.Add(this.label18);
		this.panel1.Controls.Add(this.label17);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.label16);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.plTag);
		this.panel1.Controls.Add(this.plVanBan);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.plVideo);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbVideo);
		this.panel1.Controls.Add(this.ckbTag);
		this.panel1.Controls.Add(this.ckbUseBackground);
		this.panel1.Controls.Add(this.ckbAnh);
		this.panel1.Controls.Add(this.ckbVanBan);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(683, 591);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(291, 108);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(31, 16);
		this.label19.TabIndex = 43;
		this.label19.Text = "giây";
		this.label20.Location = new System.Drawing.Point(205, 108);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(29, 16);
		this.label20.TabIndex = 42;
		this.label20.Text = "đến";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudKhoangCachTo.Location = new System.Drawing.Point(236, 106);
		this.nudKhoangCachTo.Name = "nudKhoangCachTo";
		this.nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		this.nudKhoangCachTo.TabIndex = 41;
		this.nudKhoangCachFrom.Location = new System.Drawing.Point(151, 106);
		this.nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		this.nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		this.nudKhoangCachFrom.TabIndex = 40;
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(291, 83);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(25, 16);
		this.label18.TabIndex = 39;
		this.label18.Text = "bài";
		this.label17.Location = new System.Drawing.Point(205, 83);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(29, 16);
		this.label17.TabIndex = 38;
		this.label17.Text = "đến";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudSoLuongTo.Location = new System.Drawing.Point(236, 78);
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTo.TabIndex = 37;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(151, 78);
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongFrom.TabIndex = 36;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(30, 108);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(117, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "Khoảng cách đăng:";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(30, 83);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(109, 16);
		this.label15.TabIndex = 34;
		this.label15.Text = "Số lượng bài viết:";
		this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTag.Controls.Add(this.plUidTuNhap);
		this.plTag.Controls.Add(this.rbUidTuNhap);
		this.plTag.Controls.Add(this.rbUidBanBe);
		this.plTag.Controls.Add(this.nudUidTo);
		this.plTag.Controls.Add(this.nudUidFrom);
		this.plTag.Controls.Add(this.label12);
		this.plTag.Controls.Add(this.label10);
		this.plTag.Controls.Add(this.label13);
		this.plTag.Controls.Add(this.label14);
		this.plTag.Enabled = false;
		this.plTag.Location = new System.Drawing.Point(369, 266);
		this.plTag.Name = "plTag";
		this.plTag.Size = new System.Drawing.Size(278, 255);
		this.plTag.TabIndex = 33;
		this.plUidTuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plUidTuNhap.Controls.Add(this.lbUid);
		this.plUidTuNhap.Controls.Add(this.label11);
		this.plUidTuNhap.Controls.Add(this.txtUidTag);
		this.plUidTuNhap.Location = new System.Drawing.Point(17, 97);
		this.plUidTuNhap.Name = "plUidTuNhap";
		this.plUidTuNhap.Size = new System.Drawing.Size(248, 151);
		this.plUidTuNhap.TabIndex = 34;
		this.lbUid.AutoSize = true;
		this.lbUid.Location = new System.Drawing.Point(3, 3);
		this.lbUid.Name = "lbUid";
		this.lbUid.Size = new System.Drawing.Size(115, 16);
		this.lbUid.TabIndex = 0;
		this.lbUid.Text = "Danh sa\u0301ch Uid (0):";
		this.lbUid.Click += new System.EventHandler(lbUid_Click);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(4, 127);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(134, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "(Mỗi nội dung 1 dòng)";
		this.label11.Click += new System.EventHandler(label11_Click);
		this.txtUidTag.Location = new System.Drawing.Point(7, 22);
		this.txtUidTag.Name = "txtUidTag";
		this.txtUidTag.Size = new System.Drawing.Size(236, 102);
		this.txtUidTag.TabIndex = 34;
		this.txtUidTag.Text = "";
		this.txtUidTag.WordWrap = false;
		this.txtUidTag.TextChanged += new System.EventHandler(txtUidTag_TextChanged);
		this.rbUidTuNhap.AutoSize = true;
		this.rbUidTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbUidTuNhap.Location = new System.Drawing.Point(17, 73);
		this.rbUidTuNhap.Name = "rbUidTuNhap";
		this.rbUidTuNhap.Size = new System.Drawing.Size(187, 20);
		this.rbUidTuNhap.TabIndex = 42;
		this.rbUidTuNhap.Text = "Theo danh sách Uid tự nhập";
		this.rbUidTuNhap.UseVisualStyleBackColor = true;
		this.rbUidTuNhap.CheckedChanged += new System.EventHandler(rbUidTuNhap_CheckedChanged);
		this.rbUidBanBe.AutoSize = true;
		this.rbUidBanBe.Checked = true;
		this.rbUidBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbUidBanBe.Location = new System.Drawing.Point(17, 50);
		this.rbUidBanBe.Name = "rbUidBanBe";
		this.rbUidBanBe.Size = new System.Drawing.Size(195, 20);
		this.rbUidBanBe.TabIndex = 42;
		this.rbUidBanBe.TabStop = true;
		this.rbUidBanBe.Text = "Ngẫu nhiên danh sách bạn bè";
		this.rbUidBanBe.UseVisualStyleBackColor = true;
		this.nudUidTo.Location = new System.Drawing.Point(208, 4);
		this.nudUidTo.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		this.nudUidTo.Name = "nudUidTo";
		this.nudUidTo.Size = new System.Drawing.Size(36, 23);
		this.nudUidTo.TabIndex = 39;
		this.nudUidTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudUidFrom.Location = new System.Drawing.Point(137, 4);
		this.nudUidFrom.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		this.nudUidFrom.Name = "nudUidFrom";
		this.nudUidFrom.Size = new System.Drawing.Size(36, 23);
		this.nudUidFrom.TabIndex = 38;
		this.nudUidFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 31);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(127, 16);
		this.label12.TabIndex = 0;
		this.label12.Text = "Tùy chọn Uid để tag:";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(3, 6);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(118, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = "Số Uid cần tag/bài:";
		this.label13.Location = new System.Drawing.Point(176, 6);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 41;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(244, 6);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(26, 16);
		this.label14.TabIndex = 40;
		this.label14.Text = "Uid";
		this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVanBan.Controls.Add(this.linkLabel1);
		this.plVanBan.Controls.Add(this.button3);
		this.plVanBan.Controls.Add(this.button2);
		this.plVanBan.Controls.Add(this.btnDown);
		this.plVanBan.Controls.Add(this.button4);
		this.plVanBan.Controls.Add(this.btnUp);
		this.plVanBan.Controls.Add(this.rbNganCachKyTu);
		this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
		this.plVanBan.Controls.Add(this.label9);
		this.plVanBan.Controls.Add(this.txtNoiDung);
		this.plVanBan.Controls.Add(this.label8);
		this.plVanBan.Controls.Add(this.lblStatus);
		this.plVanBan.Location = new System.Drawing.Point(47, 159);
		this.plVanBan.Name = "plVanBan";
		this.plVanBan.Size = new System.Drawing.Size(278, 276);
		this.plVanBan.TabIndex = 33;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(225, 298);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 96;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(247, 249);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 95;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(221, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 38;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(225, 275);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 97;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(252, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 39;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 298);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		this.rbNganCachKyTu.TabIndex = 37;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 277);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		this.rbNganCachMoiDong.TabIndex = 36;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(4, 277);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(65, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "Tùy chọn:";
		this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(263, 225);
		this.txtNoiDung.TabIndex = 34;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 252);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(144, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(146, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(245, 544);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.plVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVideo.Controls.Add(this.nudSoLuongVideoTo);
		this.plVideo.Controls.Add(this.nudSoLuongVideoFrom);
		this.plVideo.Controls.Add(this.label5);
		this.plVideo.Controls.Add(this.label6);
		this.plVideo.Controls.Add(this.label22);
		this.plVideo.Controls.Add(this.txtPathVideo);
		this.plVideo.Controls.Add(this.label7);
		this.plVideo.Location = new System.Drawing.Point(369, 181);
		this.plVideo.Name = "plVideo";
		this.plVideo.Size = new System.Drawing.Size(278, 58);
		this.plVideo.TabIndex = 33;
		this.nudSoLuongVideoTo.Location = new System.Drawing.Point(196, 30);
		this.nudSoLuongVideoTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongVideoTo.Name = "nudSoLuongVideoTo";
		this.nudSoLuongVideoTo.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongVideoTo.TabIndex = 12;
		this.nudSoLuongVideoFrom.Location = new System.Drawing.Point(119, 30);
		this.nudSoLuongVideoFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongVideoFrom.Name = "nudSoLuongVideoFrom";
		this.nudSoLuongVideoFrom.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongVideoFrom.TabIndex = 13;
		this.label5.Location = new System.Drawing.Point(165, 32);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(29, 16);
		this.label5.TabIndex = 9;
		this.label5.Text = "đến";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(241, 33);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(38, 16);
		this.label6.TabIndex = 10;
		this.label6.Text = "video";
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(3, 32);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(120, 16);
		this.label22.TabIndex = 11;
		this.label22.Text = "Sô\u0301 lươ\u0323ng video/bài:";
		this.txtPathVideo.Location = new System.Drawing.Point(148, 2);
		this.txtPathVideo.Name = "txtPathVideo";
		this.txtPathVideo.Size = new System.Drawing.Size(126, 23);
		this.txtPathVideo.TabIndex = 1;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(3, 5);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(147, 16);
		this.label7.TabIndex = 0;
		this.label7.Text = "Đường dẫn folder video:";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.nudSoLuongAnhTo);
		this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
		this.plAnh.Controls.Add(this.label2);
		this.plAnh.Controls.Add(this.label4);
		this.plAnh.Controls.Add(this.label21);
		this.plAnh.Controls.Add(this.txtPathAnh);
		this.plAnh.Controls.Add(this.label3);
		this.plAnh.Location = new System.Drawing.Point(47, 463);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(278, 58);
		this.plAnh.TabIndex = 33;
		this.nudSoLuongAnhTo.Location = new System.Drawing.Point(196, 29);
		this.nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		this.nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhTo.TabIndex = 7;
		this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(119, 29);
		this.nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhFrom.TabIndex = 8;
		this.label2.Location = new System.Drawing.Point(167, 31);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(29, 16);
		this.label2.TabIndex = 4;
		this.label2.Text = "đến";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(239, 31);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 5;
		this.label4.Text = "a\u0309nh";
		this.label21.AutoSize = true;
		this.label21.Location = new System.Drawing.Point(3, 31);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(111, 16);
		this.label21.TabIndex = 6;
		this.label21.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		this.txtPathAnh.Location = new System.Drawing.Point(136, 2);
		this.txtPathAnh.Name = "txtPathAnh";
		this.txtPathAnh.Size = new System.Drawing.Size(138, 23);
		this.txtPathAnh.TabIndex = 1;
		this.txtPathAnh.TextChanged += new System.EventHandler(txtPathAnh_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 5);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(138, 16);
		this.label3.TabIndex = 0;
		this.label3.Text = "Đường dẫn folder ảnh:";
		this.ckbVideo.AutoSize = true;
		this.ckbVideo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVideo.Location = new System.Drawing.Point(355, 159);
		this.ckbVideo.Name = "ckbVideo";
		this.ckbVideo.Size = new System.Drawing.Size(59, 20);
		this.ckbVideo.TabIndex = 32;
		this.ckbVideo.Text = "Video";
		this.ckbVideo.UseVisualStyleBackColor = true;
		this.ckbVideo.CheckedChanged += new System.EventHandler(ckbVideo_CheckedChanged);
		this.ckbTag.AutoSize = true;
		this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTag.Location = new System.Drawing.Point(355, 242);
		this.ckbTag.Name = "ckbTag";
		this.ckbTag.Size = new System.Drawing.Size(140, 20);
		this.ckbTag.TabIndex = 32;
		this.ckbTag.Text = "Tag Uid vào bài viết";
		this.ckbTag.UseVisualStyleBackColor = true;
		this.ckbTag.CheckedChanged += new System.EventHandler(ckbTag_CheckedChanged);
		this.ckbUseBackground.AutoSize = true;
		this.ckbUseBackground.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseBackground.Location = new System.Drawing.Point(355, 135);
		this.ckbUseBackground.Name = "ckbUseBackground";
		this.ckbUseBackground.Size = new System.Drawing.Size(145, 20);
		this.ckbUseBackground.TabIndex = 32;
		this.ckbUseBackground.Text = "Sử dụng Background";
		this.ckbUseBackground.UseVisualStyleBackColor = true;
		this.ckbUseBackground.CheckedChanged += new System.EventHandler(ckbUseBackground_CheckedChanged);
		this.ckbAnh.AutoSize = true;
		this.ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAnh.Location = new System.Drawing.Point(33, 441);
		this.ckbAnh.Name = "ckbAnh";
		this.ckbAnh.Size = new System.Drawing.Size(49, 20);
		this.ckbAnh.TabIndex = 32;
		this.ckbAnh.Text = "A\u0309nh";
		this.ckbAnh.UseVisualStyleBackColor = true;
		this.ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(33, 135);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(74, 20);
		this.ckbVanBan.TabIndex = 32;
		this.ckbVanBan.Text = "Văn ba\u0309n";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		this.txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(174, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(30, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(344, 544);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
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
		this.linkLabel1.Location = new System.Drawing.Point(165, 252);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(82, 16);
		this.linkLabel1.TabIndex = 111;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(683, 591);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangStatus";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangStatus_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.plTag.ResumeLayout(false);
		this.plTag.PerformLayout();
		this.plUidTuNhap.ResumeLayout(false);
		this.plUidTuNhap.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudUidFrom).EndInit();
		this.plVanBan.ResumeLayout(false);
		this.plVanBan.PerformLayout();
		this.plVideo.ResumeLayout(false);
		this.plVideo.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoFrom).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
