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

public class fHDDangBai : Form
{
	private GClass17 gclass17_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private List<string> list_0 = new List<string>();

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

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label20;

	private Label label19;

	private Label label15;

	private GroupBox groupBox2;

	private Panel plDangBaiLenPage;

	private Label label21;

	private Label label22;

	private NumericUpDown nudCountPageTo;

	private Label label23;

	private NumericUpDown nudCountPageFrom;

	private CheckBox ckbDangBaiLenPage;

	private CheckBox ckbDangBaiLenNhom;

	private CheckBox ckbDangBaiLenTuong;

	private Panel plDangBaiLenNhom;

	private Panel panel4;

	private CheckBox ckbKhongDangTrung;

	private CheckBox ckbUuTienNhomNhieuThanhVien;

	private CheckBox ckbOnlyDangNhomKhongKiemDuyet;

	private CheckBox ckbCauHinhNangCao;

	private Panel panel3;

	private Button button8;

	private RadioButton rbTuNhap;

	private RadioButton rbRandom;

	private Label label12;

	private Panel plInteractGroup;

	private Panel panel5;

	private Button button7;

	private LinkLabel linkLabel2;

	private Button button4;

	private Button button5;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private Label label13;

	private Label label14;

	private RichTextBox txtComment;

	private Label lblComment;

	private Label label16;

	private Label label17;

	private Label label53;

	private NumericUpDown nudTuongTacTo;

	private NumericUpDown nudTuongTacDelayTo;

	private Label label18;

	private NumericUpDown nudTuongTacFrom;

	private Label label52;

	private CheckBox ckbTuongTacComment;

	private NumericUpDown nudTuongTacDelayFrom;

	private Label label51;

	private CheckBox ckbTuongTacLike;

	private Label label50;

	private CheckBox ckbTuongTac;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label label25;

	private Label label26;

	private Panel plVanBan;

	private Button button3;

	private Button button2;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Label label8;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private RichTextBox txtNoiDung;

	private Label lblStatus;

	private Panel plVideo;

	private NumericUpDown nudSoLuongVideoTo;

	private TextBox txtPathVideo;

	private NumericUpDown nudSoLuongVideoFrom;

	private Label label5;

	private Label label11;

	private Label label6;

	private Label label7;

	private Panel plAnh;

	private Panel panel2;

	private Label label3;

	private NumericUpDown nudSoLuongAnhTo;

	private Label label2;

	private Label label4;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label label10;

	private TextBox txtPathAnh;

	private CheckBox ckbUseAvatar;

	private CheckBox ckbVideo;

	private CheckBox ckbUseBackground;

	private CheckBox ckbAnh;

	private CheckBox ckbVanBan;

	public fHDDangBai(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		if (Class307.smethod_13("", text).Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', 'Đăng bài');");
		}
		string text2 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", text);
			text2 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text2 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text2, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(ckbDangBaiLenTuong);
		GClass29.smethod_1(ckbDangBaiLenNhom);
		GClass29.smethod_1(label26);
		GClass29.smethod_1(label24);
		GClass29.smethod_1(label25);
		GClass29.smethod_1(ckbDangBaiLenPage);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label23);
		GClass29.smethod_1(label22);
		GClass29.smethod_1(ckbVanBan);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(ckbUseBackground);
		GClass29.smethod_1(ckbAnh);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(ckbVideo);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
		GClass29.smethod_1(rbNganCachMoiDong);
		GClass29.smethod_1(rbNganCachKyTu);
	}

	private void fHDDangBai_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			ckbDangBaiLenTuong.Checked = gclass17_0.method_3("ckbDangBaiLenTuong");
			ckbDangBaiLenNhom.Checked = gclass17_0.method_3("ckbDangBaiLenNhom");
			nudCountGroupFrom.Value = gclass17_0.method_2("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = gclass17_0.method_2("nudCountGroupTo", 1);
			if (gclass17_0.method_2("typePost") == 0)
			{
				rbRandom.Checked = true;
			}
			else
			{
				rbTuNhap.Checked = true;
			}
			list_0 = gclass17_0.method_1("lstNhomTuNhap");
			ckbCauHinhNangCao.Checked = gclass17_0.method_3("ckbCauHinhNangCao");
			ckbOnlyDangNhomKhongKiemDuyet.Checked = gclass17_0.method_3("ckbOnlyDangNhomKhongKiemDuyet");
			ckbUuTienNhomNhieuThanhVien.Checked = gclass17_0.method_3("ckbUuTienNhomNhieuThanhVien");
			ckbKhongDangTrung.Checked = gclass17_0.method_3("ckbKhongDangTrung");
			ckbTuongTac.Checked = gclass17_0.method_3("ckbTuongTac");
			nudTuongTacFrom.Value = gclass17_0.method_2("nudTuongTacFrom", 3);
			nudTuongTacTo.Value = gclass17_0.method_2("nudTuongTacTo", 5);
			nudTuongTacDelayFrom.Value = gclass17_0.method_2("nudTuongTacDelayFrom", 5);
			nudTuongTacDelayTo.Value = gclass17_0.method_2("nudTuongTacDelayTo", 7);
			ckbTuongTacLike.Checked = gclass17_0.method_3("ckbTuongTacLike");
			ckbTuongTacComment.Checked = gclass17_0.method_3("ckbTuongTacComment");
			txtComment.Text = gclass17_0.method_0("txtComment");
			ckbDangBaiLenPage.Checked = gclass17_0.method_3("ckbDangBaiLenPage");
			nudCountPageFrom.Value = gclass17_0.method_2("nudCountPageFrom", 1);
			nudCountPageTo.Value = gclass17_0.method_2("nudCountPageTo", 1);
			ckbVanBan.Checked = gclass17_0.method_3("ckbVanBan");
			ckbUseBackground.Checked = gclass17_0.method_3("ckbUseBackground");
			txtNoiDung.Text = gclass17_0.method_0("txtNoiDung");
			ckbAnh.Checked = gclass17_0.method_3("ckbAnh");
			ckbVideo.Checked = gclass17_0.method_3("ckbVideo");
			nudSoLuongAnhFrom.Value = gclass17_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass17_0.method_2("nudSoLuongAnhTo", 1);
			ckbUseAvatar.Checked = gclass17_0.method_3("ckbUseAvatar");
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
		GClass17 gClass = new GClass17();
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbDangBaiLenTuong", ckbDangBaiLenTuong.Checked);
		gClass.method_5("ckbDangBaiLenNhom", ckbDangBaiLenNhom.Checked);
		gClass.method_5("nudCountGroupFrom", nudCountGroupFrom.Value);
		gClass.method_5("nudCountGroupTo", nudCountGroupTo.Value);
		int num = 0;
		if (rbTuNhap.Checked)
		{
			num = 1;
		}
		gClass.method_5("typePost", num);
		gClass.method_6("lstNhomTuNhap", list_0);
		gClass.method_5("ckbCauHinhNangCao", ckbCauHinhNangCao.Checked);
		gClass.method_5("ckbOnlyDangNhomKhongKiemDuyet", ckbOnlyDangNhomKhongKiemDuyet.Checked);
		gClass.method_5("ckbUuTienNhomNhieuThanhVien", ckbUuTienNhomNhieuThanhVien.Checked);
		gClass.method_5("ckbKhongDangTrung", ckbKhongDangTrung.Checked);
		gClass.method_5("ckbTuongTac", ckbTuongTac.Checked);
		gClass.method_5("nudTuongTacFrom", nudTuongTacFrom.Value);
		gClass.method_5("nudTuongTacTo", nudTuongTacFrom.Value);
		gClass.method_5("nudTuongTacDelayFrom", nudTuongTacDelayFrom.Value);
		gClass.method_5("nudTuongTacDelayTo", nudTuongTacDelayTo.Value);
		gClass.method_5("ckbTuongTacLike", ckbTuongTacLike.Checked);
		gClass.method_5("ckbTuongTacComment", ckbTuongTacComment.Checked);
		gClass.method_5("txtComment", txtComment.Text);
		gClass.method_5("ckbDangBaiLenPage", ckbDangBaiLenPage.Checked);
		gClass.method_5("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.method_5("nudCountPageTo", nudCountPageTo.Value);
		gClass.method_5("ckbVanBan", ckbVanBan.Checked);
		gClass.method_5("ckbUseBackground", ckbUseBackground.Checked);
		gClass.method_5("ckbAnh", ckbAnh.Checked);
		gClass.method_5("ckbVideo", ckbVideo.Checked);
		gClass.method_5("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.method_5("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.method_5("ckbUseAvatar", ckbUseAvatar.Checked);
		gClass.method_5("nudSoLuongVideoFrom", nudSoLuongVideoFrom.Value);
		gClass.method_5("nudSoLuongVideoTo", nudSoLuongVideoTo.Value);
		gClass.method_5("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.method_5("txtPathAnh", txtPathAnh.Text.Trim());
		gClass.method_5("txtPathVideo", txtPathVideo.Text.Trim());
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

	private void method_1()
	{
		ckbDangBaiLenNhom_CheckedChanged(null, null);
		ckbDangBaiLenPage_CheckedChanged(null, null);
		ckbVanBan_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		ckbVideo_CheckedChanged(null, null);
		method_10(null, null);
		rbTuNhap_CheckedChanged(null, null);
		ckbCauHinhNangCao_CheckedChanged(null, null);
		ckbTuongTac_CheckedChanged(null, null);
		ckbTuongTacComment_CheckedChanged(null, null);
		method_2();
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

	private void method_3(object sender, EventArgs e)
	{
		txtPathAnh.Text = GClass14.smethod_40();
	}

	private void method_4(object sender, EventArgs e)
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
		plVanBan.Height = 279;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 196;
	}

	private void rbNganCachMoiDong_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void rbNganCachKyTu_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = ckbDangBaiLenNhom.Checked;
	}

	private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbDangBaiLenPage.Checked;
	}

	private void method_6(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtNoiDung.Focus();
	}

	private void method_7(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtNoiDung.Focus();
	}

	private void method_8(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_9(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_10(object sender, EventArgs e)
	{
		panel2.Enabled = !ckbUseAvatar.Checked;
	}

	private void button8_Click(object sender, EventArgs e)
	{
		string path = Guid.NewGuid().ToString() + ".txt";
		GClass14.smethod_33(new fNhapDuLieu1(path, "Nhâ\u0323p danh sa\u0301ch ID nho\u0301m", "Danh sa\u0301ch ID nho\u0301m", "(Mô\u0303i nô\u0323i dung 1 do\u0300ng)", list_0));
		list_0 = File.ReadAllLines(path).ToList();
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		button8.Enabled = rbTuNhap.Checked;
	}

	private void ckbCauHinhNangCao_CheckedChanged(object sender, EventArgs e)
	{
		panel4.Enabled = ckbCauHinhNangCao.Checked;
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		plInteractGroup.Enabled = ckbTuongTac.Checked;
	}

	private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
	{
		panel5.Enabled = ckbTuongTacComment.Checked;
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		list = txtComment.Lines.ToList();
		list = GClass14.smethod_36(list);
		lblComment.Text = string.Format(GClass29.smethod_0("Danh sa\u0301ch comment ({0}):"), list.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBai));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plVanBan = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plVideo = new System.Windows.Forms.Panel();
		this.nudSoLuongVideoTo = new System.Windows.Forms.NumericUpDown();
		this.txtPathVideo = new System.Windows.Forms.TextBox();
		this.nudSoLuongVideoFrom = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.label3 = new System.Windows.Forms.Label();
		this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.txtPathAnh = new System.Windows.Forms.TextBox();
		this.ckbUseAvatar = new System.Windows.Forms.CheckBox();
		this.ckbVideo = new System.Windows.Forms.CheckBox();
		this.ckbUseBackground = new System.Windows.Forms.CheckBox();
		this.ckbAnh = new System.Windows.Forms.CheckBox();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.ckbKhongDangTrung = new System.Windows.Forms.CheckBox();
		this.ckbUuTienNhomNhieuThanhVien = new System.Windows.Forms.CheckBox();
		this.ckbOnlyDangNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
		this.ckbCauHinhNangCao = new System.Windows.Forms.CheckBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.button8 = new System.Windows.Forms.Button();
		this.rbTuNhap = new System.Windows.Forms.RadioButton();
		this.rbRandom = new System.Windows.Forms.RadioButton();
		this.label12 = new System.Windows.Forms.Label();
		this.plInteractGroup = new System.Windows.Forms.Panel();
		this.panel5 = new System.Windows.Forms.Panel();
		this.button7 = new System.Windows.Forms.Button();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.button4 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.radioButton1 = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label53 = new System.Windows.Forms.Label();
		this.nudTuongTacTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.nudTuongTacFrom = new System.Windows.Forms.NumericUpDown();
		this.label52 = new System.Windows.Forms.Label();
		this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
		this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label51 = new System.Windows.Forms.Label();
		this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
		this.label50 = new System.Windows.Forms.Label();
		this.ckbTuongTac = new System.Windows.Forms.CheckBox();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.plDangBaiLenPage = new System.Windows.Forms.Panel();
		this.label21 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbDangBaiLenPage = new System.Windows.Forms.CheckBox();
		this.ckbDangBaiLenNhom = new System.Windows.Forms.CheckBox();
		this.ckbDangBaiLenTuong = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plVanBan.SuspendLayout();
		this.plVideo.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoFrom).BeginInit();
		this.plAnh.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).BeginInit();
		this.groupBox2.SuspendLayout();
		this.plDangBaiLenNhom.SuspendLayout();
		this.panel4.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plInteractGroup.SuspendLayout();
		this.panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).BeginInit();
		this.plDangBaiLenPage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1055, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Đăng bài";
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
		this.pnlHeader.Size = new System.Drawing.Size(1055, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(1024, 1);
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
		this.panel1.Controls.Add(this.plVanBan);
		this.panel1.Controls.Add(this.plVideo);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbVideo);
		this.panel1.Controls.Add(this.ckbUseBackground);
		this.panel1.Controls.Add(this.ckbAnh);
		this.panel1.Controls.Add(this.ckbVanBan);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1058, 626);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVanBan.Controls.Add(this.button3);
		this.plVanBan.Controls.Add(this.button2);
		this.plVanBan.Controls.Add(this.rbNganCachKyTu);
		this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
		this.plVanBan.Controls.Add(this.label9);
		this.plVanBan.Controls.Add(this.label8);
		this.plVanBan.Controls.Add(this.btnDown);
		this.plVanBan.Controls.Add(this.btnUp);
		this.plVanBan.Controls.Add(this.txtNoiDung);
		this.plVanBan.Controls.Add(this.lblStatus);
		this.plVanBan.Location = new System.Drawing.Point(49, 131);
		this.plVanBan.MaximumSize = new System.Drawing.Size(285, 252);
		this.plVanBan.MinimumSize = new System.Drawing.Size(285, 199);
		this.plVanBan.Name = "plVanBan";
		this.plVanBan.Size = new System.Drawing.Size(285, 199);
		this.plVanBan.TabIndex = 67;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(232, 221);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 44;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(232, 198);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 23);
		this.button2.TabIndex = 45;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(73, 221);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 42;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.Click += new System.EventHandler(rbNganCachKyTu_Click);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(73, 200);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 43;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.Click += new System.EventHandler(rbNganCachMoiDong_Click);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(8, 200);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 41;
		this.label9.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(6, 174);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 40;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(221, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 38;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(252, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 39;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(269, 147);
		this.txtNoiDung.TabIndex = 34;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(145, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		this.plVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVideo.Controls.Add(this.nudSoLuongVideoTo);
		this.plVideo.Controls.Add(this.txtPathVideo);
		this.plVideo.Controls.Add(this.nudSoLuongVideoFrom);
		this.plVideo.Controls.Add(this.label5);
		this.plVideo.Controls.Add(this.label11);
		this.plVideo.Controls.Add(this.label6);
		this.plVideo.Controls.Add(this.label7);
		this.plVideo.Location = new System.Drawing.Point(46, 502);
		this.plVideo.Name = "plVideo";
		this.plVideo.Size = new System.Drawing.Size(288, 58);
		this.plVideo.TabIndex = 68;
		this.nudSoLuongVideoTo.Location = new System.Drawing.Point(196, 29);
		this.nudSoLuongVideoTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongVideoTo.Name = "nudSoLuongVideoTo";
		this.nudSoLuongVideoTo.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongVideoTo.TabIndex = 3;
		this.txtPathVideo.Location = new System.Drawing.Point(97, 2);
		this.txtPathVideo.Name = "txtPathVideo";
		this.txtPathVideo.Size = new System.Drawing.Size(177, 23);
		this.txtPathVideo.TabIndex = 1;
		this.nudSoLuongVideoFrom.Location = new System.Drawing.Point(118, 29);
		this.nudSoLuongVideoFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongVideoFrom.Name = "nudSoLuongVideoFrom";
		this.nudSoLuongVideoFrom.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongVideoFrom.TabIndex = 3;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(241, 31);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(37, 16);
		this.label5.TabIndex = 0;
		this.label5.Text = "video";
		this.label11.Location = new System.Drawing.Point(165, 31);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(29, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "đến";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 31);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(119, 16);
		this.label6.TabIndex = 0;
		this.label6.Text = "Sô\u0301 lươ\u0323ng video/bài:";
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(3, 5);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(97, 16);
		this.label7.TabIndex = 0;
		this.label7.Text = "Thư mu\u0323c video:";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.panel2);
		this.plAnh.Controls.Add(this.ckbUseAvatar);
		this.plAnh.Location = new System.Drawing.Point(49, 389);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(285, 85);
		this.plAnh.TabIndex = 69;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.label3);
		this.panel2.Controls.Add(this.nudSoLuongAnhTo);
		this.panel2.Controls.Add(this.label2);
		this.panel2.Controls.Add(this.label4);
		this.panel2.Controls.Add(this.nudSoLuongAnhFrom);
		this.panel2.Controls.Add(this.label10);
		this.panel2.Controls.Add(this.txtPathAnh);
		this.panel2.Location = new System.Drawing.Point(3, 3);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(277, 53);
		this.panel2.TabIndex = 34;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(4, 6);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(88, 16);
		this.label3.TabIndex = 0;
		this.label3.Text = "Thư mu\u0323c ảnh:";
		this.nudSoLuongAnhTo.Location = new System.Drawing.Point(198, 27);
		this.nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		this.nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhTo.TabIndex = 3;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(4, 32);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(110, 16);
		this.label2.TabIndex = 0;
		this.label2.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(243, 29);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 0;
		this.label4.Text = "a\u0309nh";
		this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(120, 27);
		this.nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhFrom.TabIndex = 3;
		this.label10.Location = new System.Drawing.Point(167, 29);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = "đến";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtPathAnh.Location = new System.Drawing.Point(95, 3);
		this.txtPathAnh.Name = "txtPathAnh";
		this.txtPathAnh.Size = new System.Drawing.Size(177, 23);
		this.txtPathAnh.TabIndex = 1;
		this.ckbUseAvatar.AutoSize = true;
		this.ckbUseAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseAvatar.Location = new System.Drawing.Point(6, 60);
		this.ckbUseAvatar.Name = "ckbUseAvatar";
		this.ckbUseAvatar.Size = new System.Drawing.Size(196, 20);
		this.ckbUseAvatar.TabIndex = 33;
		this.ckbUseAvatar.Text = "Sử dụng avatar làm ảnh đăng";
		this.ckbUseAvatar.UseVisualStyleBackColor = true;
		this.ckbVideo.AutoSize = true;
		this.ckbVideo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVideo.Location = new System.Drawing.Point(32, 480);
		this.ckbVideo.Name = "ckbVideo";
		this.ckbVideo.Size = new System.Drawing.Size(58, 20);
		this.ckbVideo.TabIndex = 63;
		this.ckbVideo.Text = "Video";
		this.ckbVideo.UseVisualStyleBackColor = true;
		this.ckbVideo.CheckedChanged += new System.EventHandler(ckbVideo_CheckedChanged);
		this.ckbUseBackground.AutoSize = true;
		this.ckbUseBackground.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseBackground.Location = new System.Drawing.Point(32, 340);
		this.ckbUseBackground.Name = "ckbUseBackground";
		this.ckbUseBackground.Size = new System.Drawing.Size(144, 20);
		this.ckbUseBackground.TabIndex = 64;
		this.ckbUseBackground.Text = "Sử dụng Background";
		this.ckbUseBackground.UseVisualStyleBackColor = true;
		this.ckbAnh.AutoSize = true;
		this.ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAnh.Location = new System.Drawing.Point(32, 364);
		this.ckbAnh.Name = "ckbAnh";
		this.ckbAnh.Size = new System.Drawing.Size(48, 20);
		this.ckbAnh.TabIndex = 65;
		this.ckbAnh.Text = "A\u0309nh";
		this.ckbAnh.UseVisualStyleBackColor = true;
		this.ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(32, 107);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(73, 20);
		this.ckbVanBan.TabIndex = 66;
		this.ckbVanBan.Text = "Văn ba\u0309n";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.plDangBaiLenPage);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenPage);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenTuong);
		this.groupBox2.Location = new System.Drawing.Point(360, 123);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(685, 444);
		this.groupBox2.TabIndex = 62;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn đăng";
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.panel4);
		this.plDangBaiLenNhom.Controls.Add(this.ckbCauHinhNangCao);
		this.plDangBaiLenNhom.Controls.Add(this.panel3);
		this.plDangBaiLenNhom.Controls.Add(this.label12);
		this.plDangBaiLenNhom.Controls.Add(this.plInteractGroup);
		this.plDangBaiLenNhom.Controls.Add(this.ckbTuongTac);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.label25);
		this.plDangBaiLenNhom.Controls.Add(this.label26);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(33, 80);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(637, 323);
		this.plDangBaiLenNhom.TabIndex = 2;
		this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel4.Controls.Add(this.ckbKhongDangTrung);
		this.panel4.Controls.Add(this.ckbUuTienNhomNhieuThanhVien);
		this.panel4.Controls.Add(this.ckbOnlyDangNhomKhongKiemDuyet);
		this.panel4.Location = new System.Drawing.Point(19, 138);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(287, 78);
		this.panel4.TabIndex = 69;
		this.ckbKhongDangTrung.AutoSize = true;
		this.ckbKhongDangTrung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongDangTrung.Location = new System.Drawing.Point(3, 55);
		this.ckbKhongDangTrung.Name = "ckbKhongDangTrung";
		this.ckbKhongDangTrung.Size = new System.Drawing.Size(163, 20);
		this.ckbKhongDangTrung.TabIndex = 2;
		this.ckbKhongDangTrung.Text = "Không đăng trùng nhóm";
		this.ckbKhongDangTrung.UseVisualStyleBackColor = true;
		this.ckbUuTienNhomNhieuThanhVien.AutoSize = true;
		this.ckbUuTienNhomNhieuThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUuTienNhomNhieuThanhVien.Location = new System.Drawing.Point(3, 29);
		this.ckbUuTienNhomNhieuThanhVien.Name = "ckbUuTienNhomNhieuThanhVien";
		this.ckbUuTienNhomNhieuThanhVien.Size = new System.Drawing.Size(250, 20);
		this.ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
		this.ckbUuTienNhomNhieuThanhVien.Text = "Ưu tiên đăng nhóm có nhiều thành viên";
		this.ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
		this.ckbOnlyDangNhomKhongKiemDuyet.AutoSize = true;
		this.ckbOnlyDangNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyDangNhomKhongKiemDuyet.Location = new System.Drawing.Point(3, 3);
		this.ckbOnlyDangNhomKhongKiemDuyet.Name = "ckbOnlyDangNhomKhongKiemDuyet";
		this.ckbOnlyDangNhomKhongKiemDuyet.Size = new System.Drawing.Size(216, 20);
		this.ckbOnlyDangNhomKhongKiemDuyet.TabIndex = 0;
		this.ckbOnlyDangNhomKhongKiemDuyet.Text = "Chỉ đăng nhóm không kiểm duyệt";
		this.ckbOnlyDangNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.ckbCauHinhNangCao.AutoSize = true;
		this.ckbCauHinhNangCao.Location = new System.Drawing.Point(6, 115);
		this.ckbCauHinhNangCao.Name = "ckbCauHinhNangCao";
		this.ckbCauHinhNangCao.Size = new System.Drawing.Size(132, 20);
		this.ckbCauHinhNangCao.TabIndex = 68;
		this.ckbCauHinhNangCao.Text = "Cấu hình nâng cao";
		this.ckbCauHinhNangCao.UseVisualStyleBackColor = true;
		this.ckbCauHinhNangCao.CheckedChanged += new System.EventHandler(ckbCauHinhNangCao_CheckedChanged);
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.button8);
		this.panel3.Controls.Add(this.rbTuNhap);
		this.panel3.Controls.Add(this.rbRandom);
		this.panel3.Location = new System.Drawing.Point(19, 54);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(287, 54);
		this.panel3.TabIndex = 67;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Location = new System.Drawing.Point(207, 27);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(75, 23);
		this.button8.TabIndex = 2;
		this.button8.Text = "Nhập";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.rbTuNhap.AutoSize = true;
		this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuNhap.Location = new System.Drawing.Point(3, 29);
		this.rbTuNhap.Name = "rbTuNhap";
		this.rbTuNhap.Size = new System.Drawing.Size(176, 20);
		this.rbTuNhap.TabIndex = 1;
		this.rbTuNhap.Text = "Nhóm do người dùng nhập";
		this.rbTuNhap.UseVisualStyleBackColor = true;
		this.rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		this.rbRandom.AutoSize = true;
		this.rbRandom.Checked = true;
		this.rbRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbRandom.Location = new System.Drawing.Point(3, 3);
		this.rbRandom.Name = "rbRandom";
		this.rbRandom.Size = new System.Drawing.Size(197, 20);
		this.rbRandom.TabIndex = 0;
		this.rbRandom.TabStop = true;
		this.rbRandom.Text = "Ngẫu nhiên nhóm đã tham gia";
		this.rbRandom.UseVisualStyleBackColor = true;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 35);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(154, 16);
		this.label12.TabIndex = 66;
		this.label12.Text = "Tùy chọn nhóm để share:";
		this.plInteractGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plInteractGroup.Controls.Add(this.panel5);
		this.plInteractGroup.Controls.Add(this.label16);
		this.plInteractGroup.Controls.Add(this.label17);
		this.plInteractGroup.Controls.Add(this.label53);
		this.plInteractGroup.Controls.Add(this.nudTuongTacTo);
		this.plInteractGroup.Controls.Add(this.nudTuongTacDelayTo);
		this.plInteractGroup.Controls.Add(this.label18);
		this.plInteractGroup.Controls.Add(this.nudTuongTacFrom);
		this.plInteractGroup.Controls.Add(this.label52);
		this.plInteractGroup.Controls.Add(this.ckbTuongTacComment);
		this.plInteractGroup.Controls.Add(this.nudTuongTacDelayFrom);
		this.plInteractGroup.Controls.Add(this.label51);
		this.plInteractGroup.Controls.Add(this.ckbTuongTacLike);
		this.plInteractGroup.Controls.Add(this.label50);
		this.plInteractGroup.Location = new System.Drawing.Point(338, 26);
		this.plInteractGroup.Name = "plInteractGroup";
		this.plInteractGroup.Size = new System.Drawing.Size(290, 280);
		this.plInteractGroup.TabIndex = 65;
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.button7);
		this.panel5.Controls.Add(this.linkLabel2);
		this.panel5.Controls.Add(this.button4);
		this.panel5.Controls.Add(this.button5);
		this.panel5.Controls.Add(this.radioButton1);
		this.panel5.Controls.Add(this.radioButton2);
		this.panel5.Controls.Add(this.label13);
		this.panel5.Controls.Add(this.label14);
		this.panel5.Controls.Add(this.txtComment);
		this.panel5.Controls.Add(this.lblComment);
		this.panel5.Location = new System.Drawing.Point(8, 101);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(275, 168);
		this.panel5.TabIndex = 104;
		this.button7.Cursor = System.Windows.Forms.Cursors.Help;
		this.button7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button7.Location = new System.Drawing.Point(244, 144);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(23, 23);
		this.button7.TabIndex = 192;
		this.button7.Text = "?";
		this.button7.UseVisualStyleBackColor = true;
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel2.Location = new System.Drawing.Point(164, 147);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(81, 16);
		this.linkLabel2.TabIndex = 191;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Random icon";
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(230, 189);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 44;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(230, 166);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(21, 23);
		this.button5.TabIndex = 45;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.radioButton1.AutoSize = true;
		this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton1.Location = new System.Drawing.Point(71, 189);
		this.radioButton1.Name = "radioButton1";
		this.radioButton1.Size = new System.Drawing.Size(159, 20);
		this.radioButton1.TabIndex = 42;
		this.radioButton1.Text = "Nội dung có nhiều dòng";
		this.radioButton1.UseVisualStyleBackColor = true;
		this.radioButton2.AutoSize = true;
		this.radioButton2.Checked = true;
		this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton2.Location = new System.Drawing.Point(71, 168);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new System.Drawing.Size(155, 20);
		this.radioButton2.TabIndex = 43;
		this.radioButton2.TabStop = true;
		this.radioButton2.Text = "Nội dung chỉ có 1 dòng";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(6, 168);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 41;
		this.label13.Text = "Tùy chọn:";
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(5, 147);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(143, 16);
		this.label14.TabIndex = 40;
		this.label14.Text = "(Spin nội dung {a|b|c})";
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 26);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(260, 119);
		this.txtComment.TabIndex = 34;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(149, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Danh sa\u0301ch comment (0):";
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label16.Location = new System.Drawing.Point(3, 6);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(109, 16);
		this.label16.TabIndex = 99;
		this.label16.Text = "Sô\u0301 ba\u0300i viết/nhóm:";
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label17.Location = new System.Drawing.Point(160, 7);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(28, 16);
		this.label17.TabIndex = 103;
		this.label17.Text = "đê\u0301n";
		this.label53.AutoSize = true;
		this.label53.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label53.Location = new System.Drawing.Point(160, 33);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(28, 16);
		this.label53.TabIndex = 103;
		this.label53.Text = "đê\u0301n";
		this.nudTuongTacTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacTo.Location = new System.Drawing.Point(190, 4);
		this.nudTuongTacTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacTo.Name = "nudTuongTacTo";
		this.nudTuongTacTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacTo.TabIndex = 94;
		this.nudTuongTacTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayTo.Location = new System.Drawing.Point(190, 30);
		this.nudTuongTacDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
		this.nudTuongTacDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacDelayTo.TabIndex = 94;
		this.nudTuongTacDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label18.Location = new System.Drawing.Point(240, 7);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(24, 16);
		this.label18.TabIndex = 102;
		this.label18.Text = "bài";
		this.nudTuongTacFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFrom.Location = new System.Drawing.Point(113, 3);
		this.nudTuongTacFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFrom.Name = "nudTuongTacFrom";
		this.nudTuongTacFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFrom.TabIndex = 92;
		this.nudTuongTacFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label52.AutoSize = true;
		this.label52.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label52.Location = new System.Drawing.Point(240, 32);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(30, 16);
		this.label52.TabIndex = 102;
		this.label52.Text = "giây";
		this.ckbTuongTacComment.AutoSize = true;
		this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacComment.Location = new System.Drawing.Point(113, 79);
		this.ckbTuongTacComment.Name = "ckbTuongTacComment";
		this.ckbTuongTacComment.Size = new System.Drawing.Size(81, 20);
		this.ckbTuongTacComment.TabIndex = 96;
		this.ckbTuongTacComment.Text = "Comment";
		this.ckbTuongTacComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(ckbTuongTacComment_CheckedChanged);
		this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(113, 30);
		this.nudTuongTacDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
		this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacDelayFrom.TabIndex = 93;
		this.nudTuongTacDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label51.AutoSize = true;
		this.label51.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label51.Location = new System.Drawing.Point(3, 33);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(99, 16);
		this.label51.TabIndex = 101;
		this.label51.Text = "Thơ\u0300i gian delay:";
		this.ckbTuongTacLike.AutoSize = true;
		this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacLike.Location = new System.Drawing.Point(113, 58);
		this.ckbTuongTacLike.Name = "ckbTuongTacLike";
		this.ckbTuongTacLike.Size = new System.Drawing.Size(48, 20);
		this.ckbTuongTacLike.TabIndex = 95;
		this.ckbTuongTacLike.Text = "Like";
		this.ckbTuongTacLike.UseVisualStyleBackColor = true;
		this.label50.AutoSize = true;
		this.label50.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label50.Location = new System.Drawing.Point(3, 59);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(93, 16);
		this.label50.TabIndex = 100;
		this.label50.Text = "Loa\u0323i tương ta\u0301c:";
		this.ckbTuongTac.AutoSize = true;
		this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTac.Location = new System.Drawing.Point(316, 3);
		this.ckbTuongTac.Name = "ckbTuongTac";
		this.ckbTuongTac.Size = new System.Drawing.Size(210, 20);
		this.ckbTuongTac.TabIndex = 57;
		this.ckbTuongTac.Text = "Tương tác nhóm trước khi share";
		this.ckbTuongTac.UseVisualStyleBackColor = true;
		this.ckbTuongTac.CheckedChanged += new System.EventHandler(ckbTuongTac_CheckedChanged);
		this.nudCountGroupTo.Location = new System.Drawing.Point(205, 3);
		this.nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupTo.Name = "nudCountGroupTo";
		this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupTo.TabIndex = 53;
		this.nudCountGroupFrom.Location = new System.Drawing.Point(108, 3);
		this.nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupFrom.Name = "nudCountGroupFrom";
		this.nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupFrom.TabIndex = 52;
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(170, 5);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(28, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = "đê\u0301n";
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(264, 5);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(39, 16);
		this.label25.TabIndex = 55;
		this.label25.Text = "nhóm";
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(3, 5);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(99, 16);
		this.label26.TabIndex = 54;
		this.label26.Text = "Số lượng nhóm:";
		this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenPage.Controls.Add(this.label21);
		this.plDangBaiLenPage.Controls.Add(this.label22);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
		this.plDangBaiLenPage.Controls.Add(this.label23);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
		this.plDangBaiLenPage.Location = new System.Drawing.Point(157, 411);
		this.plDangBaiLenPage.Name = "plDangBaiLenPage";
		this.plDangBaiLenPage.Size = new System.Drawing.Size(310, 27);
		this.plDangBaiLenPage.TabIndex = 1;
		this.label21.AutoSize = true;
		this.label21.Location = new System.Drawing.Point(3, 3);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(95, 16);
		this.label21.TabIndex = 49;
		this.label21.Text = "Số lượng page:";
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(261, 3);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(35, 16);
		this.label22.TabIndex = 50;
		this.label22.Text = "page";
		this.nudCountPageTo.Location = new System.Drawing.Point(205, 1);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageTo.TabIndex = 48;
		this.label23.Location = new System.Drawing.Point(170, 3);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(29, 16);
		this.label23.TabIndex = 51;
		this.label23.Text = "đê\u0301n";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountPageFrom.Location = new System.Drawing.Point(108, 1);
		this.nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageFrom.Name = "nudCountPageFrom";
		this.nudCountPageFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageFrom.TabIndex = 47;
		this.ckbDangBaiLenPage.AutoSize = true;
		this.ckbDangBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDangBaiLenPage.Location = new System.Drawing.Point(11, 413);
		this.ckbDangBaiLenPage.Name = "ckbDangBaiLenPage";
		this.ckbDangBaiLenPage.Size = new System.Drawing.Size(130, 20);
		this.ckbDangBaiLenPage.TabIndex = 0;
		this.ckbDangBaiLenPage.Text = "Đăng bài lên page";
		this.ckbDangBaiLenPage.UseVisualStyleBackColor = true;
		this.ckbDangBaiLenPage.CheckedChanged += new System.EventHandler(ckbDangBaiLenPage_CheckedChanged);
		this.ckbDangBaiLenNhom.AutoSize = true;
		this.ckbDangBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDangBaiLenNhom.Location = new System.Drawing.Point(11, 54);
		this.ckbDangBaiLenNhom.Name = "ckbDangBaiLenNhom";
		this.ckbDangBaiLenNhom.Size = new System.Drawing.Size(134, 20);
		this.ckbDangBaiLenNhom.TabIndex = 0;
		this.ckbDangBaiLenNhom.Text = "Đăng bài lên nhóm";
		this.ckbDangBaiLenNhom.UseVisualStyleBackColor = true;
		this.ckbDangBaiLenNhom.CheckedChanged += new System.EventHandler(ckbDangBaiLenNhom_CheckedChanged);
		this.ckbDangBaiLenTuong.AutoSize = true;
		this.ckbDangBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDangBaiLenTuong.Location = new System.Drawing.Point(11, 23);
		this.ckbDangBaiLenTuong.Name = "ckbDangBaiLenTuong";
		this.ckbDangBaiLenTuong.Size = new System.Drawing.Size(135, 20);
		this.ckbDangBaiLenTuong.TabIndex = 0;
		this.ckbDangBaiLenTuong.Text = "Đăng bài lên tường";
		this.ckbDangBaiLenTuong.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(238, 79);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 58;
		this.nudDelayFrom.Location = new System.Drawing.Point(141, 79);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 57;
		this.label20.Location = new System.Drawing.Point(203, 81);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(29, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = "đê\u0301n";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(295, 81);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(30, 16);
		this.label19.TabIndex = 60;
		this.label19.Text = "giây";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(27, 81);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(116, 16);
		this.label15.TabIndex = 59;
		this.label15.Text = "Khoảng cách đăng:";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(433, 584);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.txtTenHanhDong.Location = new System.Drawing.Point(141, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
		this.txtTenHanhDong.TabIndex = 0;
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
		this.btnCancel.Location = new System.Drawing.Point(532, 584);
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
		this.bunifuCards1.Size = new System.Drawing.Size(1055, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1058, 626);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBai";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangBai_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plVanBan.ResumeLayout(false);
		this.plVanBan.PerformLayout();
		this.plVideo.ResumeLayout(false);
		this.plVideo.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongVideoFrom).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.plInteractGroup.ResumeLayout(false);
		this.plInteractGroup.PerformLayout();
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).EndInit();
		this.plDangBaiLenPage.ResumeLayout(false);
		this.plDangBaiLenPage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
