using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fCauHinhTuongTac : Form
{
	private GClass17 gclass17_0;

	private bool bool_0 = false;

	private bool bool_1 = true;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private GroupBox groupBox2;

	private RadioButton rbTuongTacNhanh;

	private RadioButton rbTuongTacKichBan;

	private MetroButton btnCauHinhTuongTacNhanh;

	private Panel plTuongTacKichBan;

	private CheckBox ckbRandomHanhDong;

	private ComboBox cbbKichBan;

	private MetroButton btnQuanLyKichBan;

	private Label label1;

	private CheckBox ckbCreateProfile;

	private CheckBox ckbGetCookie;

	private CheckBox ckbCapNhatThongTin;

	private CheckBox ckbGetToken;

	private Panel panel1;

	private CheckBox ckbRepeatAll;

	private CheckBox ckbLogOut;

	private CheckBox ckbLogOutOldDevice;

	private CheckBox ckbCongKhaiBanBe;

	private Label label3;

	private Label label2;

	private Panel panel3;

	private RadioButton rbLoginWWW;

	private RadioButton rbLoginMFB;

	private CheckBox ckbCreateShortcut;

	private CheckBox ckbAllowFollow;

	private Panel plShowCoBan;

	private Button btnShowCoBan;

	private Timer timer_0;

	private Panel plShowNangCao;

	private Button btnShowNangCao;

	private Timer timer_1;

	private Panel panel2;

	private RadioButton rbLoginEmailPass;

	private RadioButton rbLoginUidPass;

	private RadioButton rbLoginCookie;

	private Panel plRepeatAll;

	private Label label6;

	private Label label4;

	private NumericUpDown nudDelayTurnFrom;

	private Label label5;

	private NumericUpDown nudDelayTurnTo;

	private Label label11;

	private NumericUpDown nudSoLuotChay;

	private Label label10;

	private CheckBox ckbReviewTag;

	private CheckBox ckbCheckLiveUid;

	private CheckBox ckbDontSaveBrowser;

	private CheckBox ckbBatThongBaoDangNhap;

	private RadioButton rbLoginMbasic;

	private CheckBox ckbCauHinhTaiKhoan;

	private CheckBox ckbXoaCache;

	private Panel plCapNhatThongTin;

	private CheckBox ckbEmail;

	private CheckBox ckbFollow;

	private CheckBox ckbGroup;

	private CheckBox ckbFriend;

	private CheckBox ckbNgayTao;

	private CheckBox ckbBirthday;

	private CheckBox ckbGender;

	private CheckBox ckbName;

	private Panel plGioiHanThoiGianChayKichBan;

	private Label label7;

	private NumericUpDown nudThoiGianChayKichBanTo;

	private NumericUpDown nudThoiGianChayKichBanFrom;

	private Panel plGioiHanThoiGianChayTaiKhoan;

	private Label label13;

	private NumericUpDown nudThoiGianChayTaiKhoanTo;

	private NumericUpDown nudThoiGianChayTaiKhoanFrom;

	private CheckBox ckbGioiHanThoiGianChayKichBan;

	private CheckBox ckbGioiHanThoiGianChayTaiKhoan;

	private CheckBox ckbCheckBanBeGoiY;

	private Panel plToken;

	private RadioButton rbTokenEAAG;

	private RadioButton rbTokenEAAB;

	private RadioButton rbWwwToMfb;

	private CheckBox ckbBackupDB;

	private CheckBox ckbCheckSpam;

	private CheckBox ckbPhone;

	public fCauHinhTuongTac()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configInteractGeneral");
		method_0();
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(btnShowCoBan);
		GClass29.smethod_1(ckbCreateProfile);
		GClass29.smethod_1(ckbCheckLiveUid);
		GClass29.smethod_1(ckbGetCookie);
		GClass29.smethod_1(ckbLogOut);
		GClass29.smethod_1(ckbDontSaveBrowser);
		GClass29.smethod_1(ckbRepeatAll);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(btnShowNangCao);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(rbTuongTacNhanh);
		GClass29.smethod_1(rbTuongTacKichBan);
		GClass29.smethod_1(btnCauHinhTuongTacNhanh);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(btnQuanLyKichBan);
		GClass29.smethod_1(ckbRandomHanhDong);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
		GClass29.smethod_1(ckbCapNhatThongTin);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(ckbGetToken);
		GClass29.smethod_1(ckbLogOutOldDevice);
		GClass29.smethod_1(ckbCreateShortcut);
		GClass29.smethod_1(ckbAllowFollow);
		GClass29.smethod_1(ckbReviewTag);
		GClass29.smethod_1(ckbCongKhaiBanBe);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (rbLoginEmailPass.Checked)
		{
			num = 1;
		}
		else if (rbLoginCookie.Checked)
		{
			num = 2;
		}
		gclass17_0.method_5("typeLogin", num);
		int num2 = 0;
		if (rbLoginWWW.Checked)
		{
			num2 = 1;
		}
		else if (rbLoginMbasic.Checked)
		{
			num2 = 2;
		}
		else if (rbWwwToMfb.Checked)
		{
			num2 = 3;
		}
		gclass17_0.method_5("typeBrowserLogin", num2);
		gclass17_0.method_5("ckbCreateProfile", ckbCreateProfile.Checked);
		gclass17_0.method_5("ckbGetToken", ckbGetToken.Checked);
		int num3 = 0;
		if (rbTokenEAAB.Checked)
		{
			num3 = 1;
		}
		gclass17_0.method_5("typeToken", num3);
		gclass17_0.method_5("ckbGetCookie", ckbGetCookie.Checked);
		gclass17_0.method_5("ckbCapNhatThongTin", ckbCapNhatThongTin.Checked);
		gclass17_0.method_5("ckbName", ckbName.Checked);
		gclass17_0.method_5("ckbGender", ckbGender.Checked);
		gclass17_0.method_5("ckbBirthday", ckbBirthday.Checked);
		gclass17_0.method_5("ckbNgayTao", ckbNgayTao.Checked);
		gclass17_0.method_5("ckbEmail", ckbEmail.Checked);
		gclass17_0.method_5("ckbFriend", ckbFriend.Checked);
		gclass17_0.method_5("ckbGroup", ckbGroup.Checked);
		gclass17_0.method_5("ckbFollow", ckbFollow.Checked);
		gclass17_0.method_5("ckbPhone", ckbPhone.Checked);
		gclass17_0.method_5("ckbCheckLiveUid", ckbCheckLiveUid.Checked);
		gclass17_0.method_5("ckbDontSaveBrowser", ckbDontSaveBrowser.Checked);
		gclass17_0.method_5("ckbRepeatAll", ckbRepeatAll.Checked);
		gclass17_0.method_5("nudDelayTurnFrom", nudDelayTurnFrom.Value);
		gclass17_0.method_5("nudDelayTurnTo", nudDelayTurnTo.Value);
		gclass17_0.method_5("nudSoLuotChay", nudSoLuotChay.Value);
		gclass17_0.method_5("RepeatAllVIP", "false");
		gclass17_0.method_5("ckbLogOut", ckbLogOut.Checked);
		gclass17_0.method_5("ckbLogOutOldDevice", ckbLogOutOldDevice.Checked);
		gclass17_0.method_5("ckbCreateShortcut", ckbCreateShortcut.Checked);
		gclass17_0.method_5("ckbAllowFollow", ckbAllowFollow.Checked);
		gclass17_0.method_5("ckbReviewTag", ckbReviewTag.Checked);
		gclass17_0.method_5("ckbBatThongBaoDangNhap", ckbBatThongBaoDangNhap.Checked);
		gclass17_0.method_5("ckbCauHinhTaiKhoan", ckbCauHinhTaiKhoan.Checked);
		gclass17_0.method_5("ckbCheckSpam", ckbCheckSpam.Checked);
		gclass17_0.method_5("ckbCongKhaiBanBe", ckbCongKhaiBanBe.Checked);
		gclass17_0.method_5("ckbBackupDB", ckbBackupDB.Checked);
		if (rbTuongTacNhanh.Checked)
		{
			gclass17_0.method_5("typeInteract", 0);
		}
		else
		{
			gclass17_0.method_5("typeInteract", 1);
		}
		gclass17_0.method_5("cbbKichBan", cbbKichBan.SelectedValue);
		gclass17_0.method_5("ckbRandomHanhDong", ckbRandomHanhDong.Checked);
		gclass17_0.method_5("ckbXoaCache", ckbXoaCache.Checked);
		gclass17_0.method_5("ckbCheckBanBeGoiY", ckbCheckBanBeGoiY.Checked);
		gclass17_0.method_5("ckbGioiHanThoiGianChayTaiKhoan", ckbGioiHanThoiGianChayTaiKhoan.Checked);
		gclass17_0.method_5("nudThoiGianChayTaiKhoanFrom", nudThoiGianChayTaiKhoanFrom.Value);
		gclass17_0.method_5("nudThoiGianChayTaiKhoanTo", nudThoiGianChayTaiKhoanTo.Value);
		gclass17_0.method_5("ckbGioiHanThoiGianChayKichBan", ckbGioiHanThoiGianChayKichBan.Checked);
		gclass17_0.method_5("nudThoiGianChayKichBanFrom", nudThoiGianChayKichBanFrom.Value);
		gclass17_0.method_5("nudThoiGianChayKichBanTo", nudThoiGianChayKichBanTo.Value);
		gclass17_0.method_8();
		if (GClass38.smethod_1(GClass29.smethod_0("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
		{
			Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCauHinhTuongTacNhanh_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fConfigInteract());
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		string string_ = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				string_ = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		new Random();
		GClass14.smethod_33(new fDanhSachKichBan_Old(string_));
		method_3();
	}

	private void rbTuongTacNhanh_CheckedChanged(object sender, EventArgs e)
	{
		btnCauHinhTuongTacNhanh.Enabled = rbTuongTacNhanh.Checked;
	}

	private void rbTuongTacKichBan_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacKichBan.Enabled = rbTuongTacKichBan.Checked;
	}

	private void method_1()
	{
		rbTuongTacNhanh_CheckedChanged(null, null);
		rbTuongTacKichBan_CheckedChanged(null, null);
		ckbRepeatAll_CheckedChanged(null, null);
		ckbCapNhatThongTin_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayKichBan_CheckedChanged(null, null);
		ckbGetToken_CheckedChanged(null, null);
	}

	private void fCauHinhTuongTac_Load(object sender, EventArgs e)
	{
		method_3();
		method_2();
		method_1();
	}

	private void method_2()
	{
		try
		{
			switch (gclass17_0.method_2("typeLogin"))
			{
			case 0:
				rbLoginUidPass.Checked = true;
				break;
			case 1:
				rbLoginEmailPass.Checked = true;
				break;
			case 2:
				rbLoginCookie.Checked = true;
				break;
			}
			switch (gclass17_0.method_2("typeBrowserLogin"))
			{
			case 0:
				rbLoginMFB.Checked = true;
				break;
			case 1:
				rbLoginWWW.Checked = true;
				break;
			case 2:
				rbLoginMbasic.Checked = true;
				break;
			case 3:
				rbWwwToMfb.Checked = true;
				break;
			}
			ckbCreateProfile.Checked = gclass17_0.method_3("ckbCreateProfile");
			ckbGetToken.Checked = gclass17_0.method_3("ckbGetToken");
			if (gclass17_0.method_2("typeToken") == 0)
			{
				rbTokenEAAG.Checked = true;
			}
			else
			{
				rbTokenEAAB.Checked = true;
			}
			ckbGetCookie.Checked = gclass17_0.method_3("ckbGetCookie");
			ckbCapNhatThongTin.Checked = gclass17_0.method_3("ckbCapNhatThongTin");
			ckbName.Checked = gclass17_0.method_3("ckbName", bool_0: true);
			ckbGender.Checked = gclass17_0.method_3("ckbGender", bool_0: true);
			ckbBirthday.Checked = gclass17_0.method_3("ckbBirthday", bool_0: true);
			ckbNgayTao.Checked = gclass17_0.method_3("ckbNgayTao", bool_0: true);
			ckbEmail.Checked = gclass17_0.method_3("ckbEmail");
			ckbFriend.Checked = gclass17_0.method_3("ckbFriend", bool_0: true);
			ckbGroup.Checked = gclass17_0.method_3("ckbGroup", bool_0: true);
			ckbFollow.Checked = gclass17_0.method_3("ckbFollow", bool_0: true);
			ckbPhone.Checked = gclass17_0.method_3("ckbPhone", bool_0: true);
			ckbCheckLiveUid.Checked = gclass17_0.method_3("ckbCheckLiveUid");
			ckbDontSaveBrowser.Checked = gclass17_0.method_3("ckbDontSaveBrowser");
			ckbRepeatAll.Checked = gclass17_0.method_3("ckbRepeatAll");
			nudDelayTurnFrom.Value = gclass17_0.method_2("nudDelayTurnFrom");
			nudDelayTurnTo.Value = gclass17_0.method_2("nudDelayTurnTo");
			nudSoLuotChay.Value = gclass17_0.method_2("nudSoLuotChay");
			ckbLogOut.Checked = gclass17_0.method_3("ckbLogOut");
			ckbLogOutOldDevice.Checked = gclass17_0.method_3("ckbLogOutOldDevice");
			ckbCreateShortcut.Checked = gclass17_0.method_3("ckbCreateShortcut");
			ckbAllowFollow.Checked = gclass17_0.method_3("ckbAllowFollow");
			ckbReviewTag.Checked = gclass17_0.method_3("ckbReviewTag");
			ckbBatThongBaoDangNhap.Checked = gclass17_0.method_3("ckbBatThongBaoDangNhap");
			ckbCauHinhTaiKhoan.Checked = gclass17_0.method_3("ckbCauHinhTaiKhoan");
			ckbCheckSpam.Checked = gclass17_0.method_3("ckbCheckSpam");
			ckbCongKhaiBanBe.Checked = gclass17_0.method_3("ckbCongKhaiBanBe");
			ckbBackupDB.Checked = gclass17_0.method_3("ckbBackupDB", bool_0: true);
			if (gclass17_0.method_2("typeInteract") == 0)
			{
				rbTuongTacNhanh.Checked = true;
			}
			else
			{
				rbTuongTacKichBan.Checked = true;
			}
			cbbKichBan.SelectedValue = gclass17_0.method_0("cbbKichBan");
			ckbRandomHanhDong.Checked = gclass17_0.method_3("ckbRandomHanhDong");
			ckbXoaCache.Checked = gclass17_0.method_3("ckbXoaCache");
			ckbCheckBanBeGoiY.Checked = gclass17_0.method_3("ckbCheckBanBeGoiY");
			ckbGioiHanThoiGianChayTaiKhoan.Checked = gclass17_0.method_3("ckbGioiHanThoiGianChayTaiKhoan");
			nudThoiGianChayTaiKhoanFrom.Value = gclass17_0.method_2("nudThoiGianChayTaiKhoanFrom", 1);
			nudThoiGianChayTaiKhoanTo.Value = gclass17_0.method_2("nudThoiGianChayTaiKhoanTo", 1);
			ckbGioiHanThoiGianChayKichBan.Checked = gclass17_0.method_3("ckbGioiHanThoiGianChayKichBan");
			nudThoiGianChayKichBanFrom.Value = gclass17_0.method_2("nudThoiGianChayKichBanFrom", 1);
			nudThoiGianChayKichBanTo.Value = gclass17_0.method_2("nudThoiGianChayKichBanTo", 1);
		}
		catch
		{
		}
	}

	private void method_3()
	{
		int num = -1;
		if (cbbKichBan.SelectedIndex != -1)
		{
			num = cbbKichBan.SelectedIndex;
		}
		DataTable dataSource = Class307.smethod_4();
		cbbKichBan.DataSource = dataSource;
		cbbKichBan.ValueMember = "Id_KichBan";
		cbbKichBan.DisplayMember = "TenKichBan";
		if (num != -1 && num != 0 && cbbKichBan.Items.Count >= num + 1)
		{
			cbbKichBan.SelectedIndex = num;
		}
		else if (cbbKichBan.Items.Count > 0)
		{
			cbbKichBan.SelectedIndex = 0;
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void ckbCreateShortcut_Click(object sender, EventArgs e)
	{
		if (ckbCreateShortcut.Checked)
		{
			GClass14.smethod_33(new fCauHinhTaoShortcut());
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (plShowCoBan.Size == plShowCoBan.MaximumSize)
			{
				timer_0.Stop();
				bool_0 = false;
				return;
			}
			btnShowCoBan.Image = Class306.Bitmap_103;
			plShowNangCao.Top += 10;
			plShowCoBan.Height += 10;
			base.Height += 10;
		}
		else if (plShowCoBan.Size == plShowCoBan.MinimumSize)
		{
			timer_0.Stop();
			bool_0 = true;
		}
		else
		{
			btnShowCoBan.Image = Class306.Bitmap_123;
			plShowNangCao.Top -= 10;
			plShowCoBan.Height -= 10;
			base.Height -= 10;
		}
	}

	private void btnShowCoBan_Click(object sender, EventArgs e)
	{
		timer_0.Start();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (bool_1)
		{
			if (plShowNangCao.Size == plShowNangCao.MaximumSize)
			{
				timer_1.Stop();
				bool_1 = false;
			}
			else
			{
				btnShowNangCao.Image = Class306.Bitmap_103;
				plShowNangCao.Height += 10;
				base.Height += 10;
			}
		}
		else if (plShowNangCao.Size == plShowNangCao.MinimumSize)
		{
			timer_1.Stop();
			bool_1 = true;
		}
		else
		{
			btnShowNangCao.Image = Class306.Bitmap_123;
			plShowNangCao.Height -= 10;
			base.Height -= 10;
		}
	}

	private void btnShowNangCao_Click(object sender, EventArgs e)
	{
		timer_1.Start();
	}

	private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
	{
		plCapNhatThongTin.Enabled = ckbCapNhatThongTin.Checked;
	}

	private void ckbGetToken_Click(object sender, EventArgs e)
	{
		if (ckbGetToken.Checked && GClass38.smethod_1(GClass29.smethod_0("Sư\u0309 du\u0323ng ti\u0301nh năng na\u0300y co\u0301 thê\u0309 dâ\u0303n đê\u0301n ta\u0300i khoa\u0309n Facebook bi\u0323 kho\u0301a!") + "\r\n" + GClass29.smethod_0("Ba\u0323n co\u0301 chă\u0301c vâ\u0303n muô\u0301n sư\u0309 du\u0323ng?")) == DialogResult.No)
		{
			ckbGetToken.Checked = false;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e)
	{
		plRepeatAll.Enabled = ckbRepeatAll.Checked;
	}

	private void ckbCheckSpam_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayTaiKhoan.Enabled = ckbGioiHanThoiGianChayTaiKhoan.Checked;
	}

	private void ckbGioiHanThoiGianChayKichBan_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayKichBan.Enabled = ckbGioiHanThoiGianChayKichBan.Checked;
	}

	private void ckbGetToken_CheckedChanged(object sender, EventArgs e)
	{
		plToken.Enabled = ckbGetToken.Checked;
	}

	private void ckbGroup_Click(object sender, EventArgs e)
	{
		if (ckbGroup.Checked && GClass38.smethod_1(GClass29.smethod_0("Sư\u0309 du\u0323ng ti\u0301nh năng na\u0300y co\u0301 thê\u0309 dâ\u0303n đê\u0301n ta\u0300i khoa\u0309n Facebook bi\u0323 kho\u0301a!") + "\r\n" + GClass29.smethod_0("Ba\u0323n co\u0301 chă\u0301c vâ\u0303n muô\u0301n sư\u0309 du\u0323ng?")) == DialogResult.No)
		{
			ckbGroup.Checked = false;
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTuongTac));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.rbTuongTacNhanh = new System.Windows.Forms.RadioButton();
		this.rbTuongTacKichBan = new System.Windows.Forms.RadioButton();
		this.btnCauHinhTuongTacNhanh = new MetroFramework.Controls.MetroButton();
		this.plTuongTacKichBan = new System.Windows.Forms.Panel();
		this.plGioiHanThoiGianChayKichBan = new System.Windows.Forms.Panel();
		this.label7 = new System.Windows.Forms.Label();
		this.nudThoiGianChayKichBanTo = new System.Windows.Forms.NumericUpDown();
		this.nudThoiGianChayKichBanFrom = new System.Windows.Forms.NumericUpDown();
		this.plGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.Panel();
		this.label13 = new System.Windows.Forms.Label();
		this.nudThoiGianChayTaiKhoanTo = new System.Windows.Forms.NumericUpDown();
		this.nudThoiGianChayTaiKhoanFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbGioiHanThoiGianChayKichBan = new System.Windows.Forms.CheckBox();
		this.ckbGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.CheckBox();
		this.ckbRandomHanhDong = new System.Windows.Forms.CheckBox();
		this.cbbKichBan = new System.Windows.Forms.ComboBox();
		this.btnQuanLyKichBan = new MetroFramework.Controls.MetroButton();
		this.label1 = new System.Windows.Forms.Label();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbWwwToMfb = new System.Windows.Forms.RadioButton();
		this.rbLoginMbasic = new System.Windows.Forms.RadioButton();
		this.rbLoginWWW = new System.Windows.Forms.RadioButton();
		this.rbLoginMFB = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.ckbCreateProfile = new System.Windows.Forms.CheckBox();
		this.ckbGetCookie = new System.Windows.Forms.CheckBox();
		this.ckbCreateShortcut = new System.Windows.Forms.CheckBox();
		this.ckbRepeatAll = new System.Windows.Forms.CheckBox();
		this.ckbAllowFollow = new System.Windows.Forms.CheckBox();
		this.ckbCongKhaiBanBe = new System.Windows.Forms.CheckBox();
		this.ckbLogOutOldDevice = new System.Windows.Forms.CheckBox();
		this.ckbLogOut = new System.Windows.Forms.CheckBox();
		this.ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
		this.ckbGetToken = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plShowNangCao = new System.Windows.Forms.Panel();
		this.plToken = new System.Windows.Forms.Panel();
		this.rbTokenEAAG = new System.Windows.Forms.RadioButton();
		this.rbTokenEAAB = new System.Windows.Forms.RadioButton();
		this.ckbBackupDB = new System.Windows.Forms.CheckBox();
		this.ckbXoaCache = new System.Windows.Forms.CheckBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.rbLoginEmailPass = new System.Windows.Forms.RadioButton();
		this.rbLoginUidPass = new System.Windows.Forms.RadioButton();
		this.rbLoginCookie = new System.Windows.Forms.RadioButton();
		this.ckbCheckSpam = new System.Windows.Forms.CheckBox();
		this.btnShowNangCao = new System.Windows.Forms.Button();
		this.ckbReviewTag = new System.Windows.Forms.CheckBox();
		this.ckbCheckBanBeGoiY = new System.Windows.Forms.CheckBox();
		this.ckbBatThongBaoDangNhap = new System.Windows.Forms.CheckBox();
		this.ckbCauHinhTaiKhoan = new System.Windows.Forms.CheckBox();
		this.plShowCoBan = new System.Windows.Forms.Panel();
		this.plCapNhatThongTin = new System.Windows.Forms.Panel();
		this.ckbEmail = new System.Windows.Forms.CheckBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.ckbGroup = new System.Windows.Forms.CheckBox();
		this.ckbFriend = new System.Windows.Forms.CheckBox();
		this.ckbNgayTao = new System.Windows.Forms.CheckBox();
		this.ckbBirthday = new System.Windows.Forms.CheckBox();
		this.ckbGender = new System.Windows.Forms.CheckBox();
		this.ckbName = new System.Windows.Forms.CheckBox();
		this.plRepeatAll = new System.Windows.Forms.Panel();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.nudDelayTurnTo = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.btnShowCoBan = new System.Windows.Forms.Button();
		this.ckbDontSaveBrowser = new System.Windows.Forms.CheckBox();
		this.ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox2.SuspendLayout();
		this.plTuongTacKichBan.SuspendLayout();
		this.plGioiHanThoiGianChayKichBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanFrom).BeginInit();
		this.plGioiHanThoiGianChayTaiKhoan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).BeginInit();
		this.panel3.SuspendLayout();
		this.panel1.SuspendLayout();
		this.plShowNangCao.SuspendLayout();
		this.plToken.SuspendLayout();
		this.panel2.SuspendLayout();
		this.plShowCoBan.SuspendLayout();
		this.plCapNhatThongTin.SuspendLayout();
		this.plRepeatAll.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.FromArgb(24, 119, 242);
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(440, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(440, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 78;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(406, -2);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(440, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(226, 556);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
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
		this.btnAdd.Location = new System.Drawing.Point(122, 556);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox2.Controls.Add(this.rbTuongTacNhanh);
		this.groupBox2.Controls.Add(this.rbTuongTacKichBan);
		this.groupBox2.Controls.Add(this.btnCauHinhTuongTacNhanh);
		this.groupBox2.Controls.Add(this.plTuongTacKichBan);
		this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.Location = new System.Drawing.Point(10, 353);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(421, 191);
		this.groupBox2.TabIndex = 7;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn kiểu tương tác";
		this.rbTuongTacNhanh.AutoSize = true;
		this.rbTuongTacNhanh.Checked = true;
		this.rbTuongTacNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacNhanh.Location = new System.Drawing.Point(17, 23);
		this.rbTuongTacNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbTuongTacNhanh.Name = "rbTuongTacNhanh";
		this.rbTuongTacNhanh.Size = new System.Drawing.Size(122, 20);
		this.rbTuongTacNhanh.TabIndex = 0;
		this.rbTuongTacNhanh.TabStop = true;
		this.rbTuongTacNhanh.Text = "Tương tác nhanh";
		this.rbTuongTacNhanh.UseVisualStyleBackColor = true;
		this.rbTuongTacNhanh.CheckedChanged += new System.EventHandler(rbTuongTacNhanh_CheckedChanged);
		this.rbTuongTacKichBan.AutoSize = true;
		this.rbTuongTacKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacKichBan.Location = new System.Drawing.Point(17, 46);
		this.rbTuongTacKichBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbTuongTacKichBan.Name = "rbTuongTacKichBan";
		this.rbTuongTacKichBan.Size = new System.Drawing.Size(301, 20);
		this.rbTuongTacKichBan.TabIndex = 0;
		this.rbTuongTacKichBan.TabStop = true;
		this.rbTuongTacKichBan.Text = "Tương tác theo kịch bản (Khuyến khích sử dụng)";
		this.rbTuongTacKichBan.UseVisualStyleBackColor = true;
		this.rbTuongTacKichBan.CheckedChanged += new System.EventHandler(rbTuongTacKichBan_CheckedChanged);
		this.btnCauHinhTuongTacNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCauHinhTuongTacNhanh.Location = new System.Drawing.Point(141, 22);
		this.btnCauHinhTuongTacNhanh.Name = "btnCauHinhTuongTacNhanh";
		this.btnCauHinhTuongTacNhanh.Size = new System.Drawing.Size(75, 23);
		this.btnCauHinhTuongTacNhanh.TabIndex = 1;
		this.btnCauHinhTuongTacNhanh.Text = "Cấu hình";
		this.btnCauHinhTuongTacNhanh.UseSelectable = true;
		this.btnCauHinhTuongTacNhanh.Click += new System.EventHandler(btnCauHinhTuongTacNhanh_Click);
		this.plTuongTacKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacKichBan.Controls.Add(this.plGioiHanThoiGianChayKichBan);
		this.plTuongTacKichBan.Controls.Add(this.plGioiHanThoiGianChayTaiKhoan);
		this.plTuongTacKichBan.Controls.Add(this.ckbGioiHanThoiGianChayKichBan);
		this.plTuongTacKichBan.Controls.Add(this.ckbGioiHanThoiGianChayTaiKhoan);
		this.plTuongTacKichBan.Controls.Add(this.ckbRandomHanhDong);
		this.plTuongTacKichBan.Controls.Add(this.cbbKichBan);
		this.plTuongTacKichBan.Controls.Add(this.btnQuanLyKichBan);
		this.plTuongTacKichBan.Controls.Add(this.label1);
		this.plTuongTacKichBan.Location = new System.Drawing.Point(37, 70);
		this.plTuongTacKichBan.Name = "plTuongTacKichBan";
		this.plTuongTacKichBan.Size = new System.Drawing.Size(376, 115);
		this.plTuongTacKichBan.TabIndex = 2;
		this.plGioiHanThoiGianChayKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.label7);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.nudThoiGianChayKichBanTo);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.nudThoiGianChayKichBanFrom);
		this.plGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(251, 83);
		this.plGioiHanThoiGianChayKichBan.Name = "plGioiHanThoiGianChayKichBan";
		this.plGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayKichBan.TabIndex = 17;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new System.Drawing.Point(50, 4);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(18, 16);
		this.label7.TabIndex = 4;
		this.label7.Text = ">";
		this.nudThoiGianChayKichBanTo.Location = new System.Drawing.Point(69, 1);
		this.nudThoiGianChayKichBanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayKichBanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
		this.nudThoiGianChayKichBanTo.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayKichBanTo.TabIndex = 3;
		this.nudThoiGianChayKichBanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Location = new System.Drawing.Point(1, 1);
		this.nudThoiGianChayKichBanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Name = "nudThoiGianChayKichBanFrom";
		this.nudThoiGianChayKichBanFrom.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayKichBanFrom.TabIndex = 3;
		this.nudThoiGianChayKichBanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.plGioiHanThoiGianChayTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.label13);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanTo);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanFrom);
		this.plGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(251, 53);
		this.plGioiHanThoiGianChayTaiKhoan.Name = "plGioiHanThoiGianChayTaiKhoan";
		this.plGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayTaiKhoan.TabIndex = 18;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.Location = new System.Drawing.Point(50, 4);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(18, 16);
		this.label13.TabIndex = 4;
		this.label13.Text = ">";
		this.nudThoiGianChayTaiKhoanTo.Location = new System.Drawing.Point(69, 1);
		this.nudThoiGianChayTaiKhoanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayTaiKhoanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanTo.Name = "nudThoiGianChayTaiKhoanTo";
		this.nudThoiGianChayTaiKhoanTo.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayTaiKhoanTo.TabIndex = 3;
		this.nudThoiGianChayTaiKhoanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Location = new System.Drawing.Point(1, 1);
		this.nudThoiGianChayTaiKhoanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Name = "nudThoiGianChayTaiKhoanFrom";
		this.nudThoiGianChayTaiKhoanFrom.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayTaiKhoanFrom.TabIndex = 3;
		this.nudThoiGianChayTaiKhoanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ckbGioiHanThoiGianChayKichBan.AutoSize = true;
		this.ckbGioiHanThoiGianChayKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(7, 87);
		this.ckbGioiHanThoiGianChayKichBan.Name = "ckbGioiHanThoiGianChayKichBan";
		this.ckbGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(246, 20);
		this.ckbGioiHanThoiGianChayKichBan.TabIndex = 15;
		this.ckbGioiHanThoiGianChayKichBan.Text = "Giới hạn thời gian chạy/kịch bản (phút)";
		this.ckbGioiHanThoiGianChayKichBan.UseVisualStyleBackColor = true;
		this.ckbGioiHanThoiGianChayKichBan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayKichBan_CheckedChanged);
		this.ckbGioiHanThoiGianChayTaiKhoan.AutoSize = true;
		this.ckbGioiHanThoiGianChayTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(7, 56);
		this.ckbGioiHanThoiGianChayTaiKhoan.Name = "ckbGioiHanThoiGianChayTaiKhoan";
		this.ckbGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(249, 20);
		this.ckbGioiHanThoiGianChayTaiKhoan.TabIndex = 16;
		this.ckbGioiHanThoiGianChayTaiKhoan.Text = "Giới hạn thời gian chạy/tài khoản (giây)";
		this.ckbGioiHanThoiGianChayTaiKhoan.UseVisualStyleBackColor = true;
		this.ckbGioiHanThoiGianChayTaiKhoan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged);
		this.ckbRandomHanhDong.AutoSize = true;
		this.ckbRandomHanhDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRandomHanhDong.Location = new System.Drawing.Point(7, 35);
		this.ckbRandomHanhDong.Name = "ckbRandomHanhDong";
		this.ckbRandomHanhDong.Size = new System.Drawing.Size(199, 20);
		this.ckbRandomHanhDong.TabIndex = 2;
		this.ckbRandomHanhDong.Text = "Random thứ tự các hành động";
		this.ckbRandomHanhDong.UseVisualStyleBackColor = true;
		this.cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbKichBan.DropDownWidth = 200;
		this.cbbKichBan.FormattingEnabled = true;
		this.cbbKichBan.Location = new System.Drawing.Point(103, 5);
		this.cbbKichBan.Name = "cbbKichBan";
		this.cbbKichBan.Size = new System.Drawing.Size(161, 24);
		this.cbbKichBan.TabIndex = 1;
		this.btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnQuanLyKichBan.Location = new System.Drawing.Point(270, 5);
		this.btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		this.btnQuanLyKichBan.Size = new System.Drawing.Size(100, 25);
		this.btnQuanLyKichBan.TabIndex = 1;
		this.btnQuanLyKichBan.Text = "Quản lý kịch bản";
		this.btnQuanLyKichBan.UseSelectable = true;
		this.btnQuanLyKichBan.Click += new System.EventHandler(btnQuanLyKichBan_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(4, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(92, 16);
		this.label1.TabIndex = 0;
		this.label1.Text = "Chọn kịch bản:";
		this.panel3.Controls.Add(this.rbWwwToMfb);
		this.panel3.Controls.Add(this.rbLoginMbasic);
		this.panel3.Controls.Add(this.rbLoginWWW);
		this.panel3.Controls.Add(this.rbLoginMFB);
		this.panel3.Location = new System.Drawing.Point(134, 55);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(273, 26);
		this.panel3.TabIndex = 5;
		this.rbWwwToMfb.AutoSize = true;
		this.rbWwwToMfb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbWwwToMfb.Location = new System.Drawing.Point(191, 3);
		this.rbWwwToMfb.Name = "rbWwwToMfb";
		this.rbWwwToMfb.Size = new System.Drawing.Size(80, 20);
		this.rbWwwToMfb.TabIndex = 5;
		this.rbWwwToMfb.Text = "www->m";
		this.rbWwwToMfb.UseVisualStyleBackColor = true;
		this.rbLoginMbasic.AutoSize = true;
		this.rbLoginMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginMbasic.Location = new System.Drawing.Point(122, 3);
		this.rbLoginMbasic.Name = "rbLoginMbasic";
		this.rbLoginMbasic.Size = new System.Drawing.Size(65, 20);
		this.rbLoginMbasic.TabIndex = 5;
		this.rbLoginMbasic.Text = "mbasic";
		this.rbLoginMbasic.UseVisualStyleBackColor = true;
		this.rbLoginWWW.AutoSize = true;
		this.rbLoginWWW.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginWWW.Location = new System.Drawing.Point(60, 3);
		this.rbLoginWWW.Name = "rbLoginWWW";
		this.rbLoginWWW.Size = new System.Drawing.Size(55, 20);
		this.rbLoginWWW.TabIndex = 4;
		this.rbLoginWWW.Text = "www";
		this.rbLoginWWW.UseVisualStyleBackColor = true;
		this.rbLoginMFB.AutoSize = true;
		this.rbLoginMFB.Checked = true;
		this.rbLoginMFB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginMFB.Location = new System.Drawing.Point(3, 3);
		this.rbLoginMFB.Name = "rbLoginMFB";
		this.rbLoginMFB.Size = new System.Drawing.Size(51, 20);
		this.rbLoginMFB.TabIndex = 4;
		this.rbLoginMFB.TabStop = true;
		this.rbLoginMFB.Text = "m.fb";
		this.rbLoginMFB.UseVisualStyleBackColor = true;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(13, 58);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(110, 16);
		this.label3.TabIndex = 3;
		this.label3.Text = "Trang đăng nhâ\u0323p:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(13, 34);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 3;
		this.label2.Text = "Kiểu đăng nhâ\u0323p:";
		this.ckbCreateProfile.AutoSize = true;
		this.ckbCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCreateProfile.Location = new System.Drawing.Point(10, 31);
		this.ckbCreateProfile.Name = "ckbCreateProfile";
		this.ckbCreateProfile.Size = new System.Drawing.Size(186, 20);
		this.ckbCreateProfile.TabIndex = 2;
		this.ckbCreateProfile.Text = "Tự động tạo Profile khi chạy";
		this.ckbCreateProfile.UseVisualStyleBackColor = true;
		this.ckbGetCookie.AutoSize = true;
		this.ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGetCookie.Location = new System.Drawing.Point(222, 31);
		this.ckbGetCookie.Name = "ckbGetCookie";
		this.ckbGetCookie.Size = new System.Drawing.Size(186, 20);
		this.ckbGetCookie.TabIndex = 2;
		this.ckbGetCookie.Text = "Tự động lấy Cookie khi chạy";
		this.ckbGetCookie.UseVisualStyleBackColor = true;
		this.ckbCreateShortcut.AutoSize = true;
		this.ckbCreateShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCreateShortcut.Location = new System.Drawing.Point(15, 134);
		this.ckbCreateShortcut.Name = "ckbCreateShortcut";
		this.ckbCreateShortcut.Size = new System.Drawing.Size(197, 20);
		this.ckbCreateShortcut.TabIndex = 2;
		this.ckbCreateShortcut.Text = "Tư\u0323 đô\u0323ng tạo Shortcut Chrome";
		this.ckbCreateShortcut.UseVisualStyleBackColor = true;
		this.ckbCreateShortcut.Click += new System.EventHandler(ckbCreateShortcut_Click);
		this.ckbRepeatAll.AutoSize = true;
		this.ckbRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRepeatAll.Location = new System.Drawing.Point(10, 173);
		this.ckbRepeatAll.Name = "ckbRepeatAll";
		this.ckbRepeatAll.Size = new System.Drawing.Size(344, 20);
		this.ckbRepeatAll.TabIndex = 2;
		this.ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
		this.ckbRepeatAll.UseVisualStyleBackColor = true;
		this.ckbRepeatAll.CheckedChanged += new System.EventHandler(ckbRepeatAll_CheckedChanged);
		this.ckbAllowFollow.AutoSize = true;
		this.ckbAllowFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAllowFollow.Location = new System.Drawing.Point(227, 108);
		this.ckbAllowFollow.Name = "ckbAllowFollow";
		this.ckbAllowFollow.Size = new System.Drawing.Size(187, 20);
		this.ckbAllowFollow.TabIndex = 2;
		this.ckbAllowFollow.Text = "Cho phe\u0301p ngươ\u0300i kha\u0301c Follow";
		this.ckbAllowFollow.UseVisualStyleBackColor = true;
		this.ckbCongKhaiBanBe.AutoSize = true;
		this.ckbCongKhaiBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCongKhaiBanBe.Location = new System.Drawing.Point(227, 185);
		this.ckbCongKhaiBanBe.Name = "ckbCongKhaiBanBe";
		this.ckbCongKhaiBanBe.Size = new System.Drawing.Size(187, 20);
		this.ckbCongKhaiBanBe.TabIndex = 2;
		this.ckbCongKhaiBanBe.Text = "Công khai danh sách bạn bè";
		this.ckbCongKhaiBanBe.UseVisualStyleBackColor = true;
		this.ckbCongKhaiBanBe.CheckedChanged += new System.EventHandler(ckbCheckSpam_CheckedChanged);
		this.ckbLogOutOldDevice.AutoSize = true;
		this.ckbLogOutOldDevice.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOutOldDevice.Location = new System.Drawing.Point(227, 84);
		this.ckbLogOutOldDevice.Name = "ckbLogOutOldDevice";
		this.ckbLogOutOldDevice.Size = new System.Drawing.Size(166, 20);
		this.ckbLogOutOldDevice.TabIndex = 2;
		this.ckbLogOutOldDevice.Text = "Đăng xuất hê\u0301t thiê\u0301t bi\u0323 cu\u0303";
		this.ckbLogOutOldDevice.UseVisualStyleBackColor = true;
		this.ckbLogOut.AutoSize = true;
		this.ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOut.Location = new System.Drawing.Point(222, 57);
		this.ckbLogOut.Name = "ckbLogOut";
		this.ckbLogOut.Size = new System.Drawing.Size(186, 20);
		this.ckbLogOut.TabIndex = 2;
		this.ckbLogOut.Text = "Đăng xuất sau khi tương tác";
		this.ckbLogOut.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.AutoSize = true;
		this.ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCapNhatThongTin.Location = new System.Drawing.Point(10, 57);
		this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
		this.ckbCapNhatThongTin.Size = new System.Drawing.Size(181, 20);
		this.ckbCapNhatThongTin.TabIndex = 2;
		this.ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
		this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.CheckedChanged += new System.EventHandler(ckbCapNhatThongTin_CheckedChanged);
		this.ckbGetToken.AutoSize = true;
		this.ckbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGetToken.Location = new System.Drawing.Point(16, 84);
		this.ckbGetToken.Name = "ckbGetToken";
		this.ckbGetToken.Size = new System.Drawing.Size(183, 20);
		this.ckbGetToken.TabIndex = 2;
		this.ckbGetToken.Text = "Tự động lấy Token khi chạy";
		this.ckbGetToken.UseVisualStyleBackColor = true;
		this.ckbGetToken.CheckedChanged += new System.EventHandler(ckbGetToken_CheckedChanged);
		this.ckbGetToken.Click += new System.EventHandler(ckbGetToken_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plShowNangCao);
		this.panel1.Controls.Add(this.ckbCheckBanBeGoiY);
		this.panel1.Controls.Add(this.ckbBatThongBaoDangNhap);
		this.panel1.Controls.Add(this.plShowCoBan);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(442, 598);
		this.panel1.TabIndex = 8;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plShowNangCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plShowNangCao.Controls.Add(this.plToken);
		this.plShowNangCao.Controls.Add(this.ckbBackupDB);
		this.plShowNangCao.Controls.Add(this.ckbXoaCache);
		this.plShowNangCao.Controls.Add(this.ckbCauHinhTaiKhoan);
		this.plShowNangCao.Controls.Add(this.panel2);
		this.plShowNangCao.Controls.Add(this.ckbCheckSpam);
		this.plShowNangCao.Controls.Add(this.ckbCongKhaiBanBe);
		this.plShowNangCao.Controls.Add(this.panel3);
		this.plShowNangCao.Controls.Add(this.btnShowNangCao);
		this.plShowNangCao.Controls.Add(this.ckbReviewTag);
		this.plShowNangCao.Controls.Add(this.ckbAllowFollow);
		this.plShowNangCao.Controls.Add(this.ckbGetToken);
		this.plShowNangCao.Controls.Add(this.label2);
		this.plShowNangCao.Controls.Add(this.ckbLogOutOldDevice);
		this.plShowNangCao.Controls.Add(this.ckbCreateShortcut);
		this.plShowNangCao.Controls.Add(this.label3);
		this.plShowNangCao.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.plShowNangCao.Location = new System.Drawing.Point(11, 319);
		this.plShowNangCao.MaximumSize = new System.Drawing.Size(420, 230);
		this.plShowNangCao.MinimumSize = new System.Drawing.Size(420, 27);
		this.plShowNangCao.Name = "plShowNangCao";
		this.plShowNangCao.Size = new System.Drawing.Size(420, 28);
		this.plShowNangCao.TabIndex = 3;
		this.plToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plToken.Controls.Add(this.rbTokenEAAG);
		this.plToken.Controls.Add(this.rbTokenEAAB);
		this.plToken.Location = new System.Drawing.Point(35, 106);
		this.plToken.Name = "plToken";
		this.plToken.Size = new System.Drawing.Size(166, 27);
		this.plToken.TabIndex = 10;
		this.rbTokenEAAG.AutoSize = true;
		this.rbTokenEAAG.Checked = true;
		this.rbTokenEAAG.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTokenEAAG.Location = new System.Drawing.Point(5, 2);
		this.rbTokenEAAG.Name = "rbTokenEAAG";
		this.rbTokenEAAG.Size = new System.Drawing.Size(56, 20);
		this.rbTokenEAAG.TabIndex = 4;
		this.rbTokenEAAG.TabStop = true;
		this.rbTokenEAAG.Text = "EAAG";
		this.rbTokenEAAG.UseVisualStyleBackColor = true;
		this.rbTokenEAAB.AutoSize = true;
		this.rbTokenEAAB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTokenEAAB.Location = new System.Drawing.Point(81, 2);
		this.rbTokenEAAB.Name = "rbTokenEAAB";
		this.rbTokenEAAB.Size = new System.Drawing.Size(55, 20);
		this.rbTokenEAAB.TabIndex = 4;
		this.rbTokenEAAB.Text = "EAAB";
		this.rbTokenEAAB.UseVisualStyleBackColor = true;
		this.ckbBackupDB.AutoSize = true;
		this.ckbBackupDB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBackupDB.Location = new System.Drawing.Point(227, 159);
		this.ckbBackupDB.Name = "ckbBackupDB";
		this.ckbBackupDB.Size = new System.Drawing.Size(127, 20);
		this.ckbBackupDB.TabIndex = 9;
		this.ckbBackupDB.Text = "Backup Database ";
		this.ckbBackupDB.UseVisualStyleBackColor = true;
		this.ckbXoaCache.AutoSize = true;
		this.ckbXoaCache.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaCache.Location = new System.Drawing.Point(227, 134);
		this.ckbXoaCache.Name = "ckbXoaCache";
		this.ckbXoaCache.Size = new System.Drawing.Size(169, 20);
		this.ckbXoaCache.TabIndex = 9;
		this.ckbXoaCache.Text = "Xoá cache trước khi chạy";
		this.ckbXoaCache.UseVisualStyleBackColor = true;
		this.panel2.Controls.Add(this.rbLoginEmailPass);
		this.panel2.Controls.Add(this.rbLoginUidPass);
		this.panel2.Controls.Add(this.rbLoginCookie);
		this.panel2.Location = new System.Drawing.Point(134, 31);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(273, 26);
		this.panel2.TabIndex = 6;
		this.rbLoginEmailPass.AutoSize = true;
		this.rbLoginEmailPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginEmailPass.Location = new System.Drawing.Point(93, 3);
		this.rbLoginEmailPass.Name = "rbLoginEmailPass";
		this.rbLoginEmailPass.Size = new System.Drawing.Size(88, 20);
		this.rbLoginEmailPass.TabIndex = 4;
		this.rbLoginEmailPass.Text = "Email|Pass";
		this.rbLoginEmailPass.UseVisualStyleBackColor = true;
		this.rbLoginUidPass.AutoSize = true;
		this.rbLoginUidPass.Checked = true;
		this.rbLoginUidPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginUidPass.Location = new System.Drawing.Point(3, 3);
		this.rbLoginUidPass.Name = "rbLoginUidPass";
		this.rbLoginUidPass.Size = new System.Drawing.Size(75, 20);
		this.rbLoginUidPass.TabIndex = 4;
		this.rbLoginUidPass.TabStop = true;
		this.rbLoginUidPass.Text = "Uid|Pass";
		this.rbLoginUidPass.UseVisualStyleBackColor = true;
		this.rbLoginCookie.AutoSize = true;
		this.rbLoginCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginCookie.Location = new System.Drawing.Point(196, 3);
		this.rbLoginCookie.Name = "rbLoginCookie";
		this.rbLoginCookie.Size = new System.Drawing.Size(63, 20);
		this.rbLoginCookie.TabIndex = 4;
		this.rbLoginCookie.Text = "Cookie";
		this.rbLoginCookie.UseVisualStyleBackColor = true;
		this.ckbCheckSpam.AutoSize = true;
		this.ckbCheckSpam.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckSpam.Location = new System.Drawing.Point(15, 185);
		this.ckbCheckSpam.Name = "ckbCheckSpam";
		this.ckbCheckSpam.Size = new System.Drawing.Size(151, 20);
		this.ckbCheckSpam.TabIndex = 2;
		this.ckbCheckSpam.Text = "Check bình luận spam";
		this.ckbCheckSpam.UseVisualStyleBackColor = true;
		this.ckbCheckSpam.CheckedChanged += new System.EventHandler(ckbCheckSpam_CheckedChanged);
		this.btnShowNangCao.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.btnShowNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnShowNangCao.FlatAppearance.BorderSize = 0;
		this.btnShowNangCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnShowNangCao.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnShowNangCao.ForeColor = System.Drawing.Color.Black;
		this.btnShowNangCao.Image = Class306.Bitmap_123;
		this.btnShowNangCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnShowNangCao.Location = new System.Drawing.Point(0, 0);
		this.btnShowNangCao.Name = "btnShowNangCao";
		this.btnShowNangCao.Size = new System.Drawing.Size(418, 26);
		this.btnShowNangCao.TabIndex = 2;
		this.btnShowNangCao.Text = "Cấu hình nâng cao";
		this.btnShowNangCao.UseVisualStyleBackColor = false;
		this.btnShowNangCao.Click += new System.EventHandler(btnShowNangCao_Click);
		this.ckbReviewTag.AutoSize = true;
		this.ckbReviewTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbReviewTag.Location = new System.Drawing.Point(15, 160);
		this.ckbReviewTag.Name = "ckbReviewTag";
		this.ckbReviewTag.Size = new System.Drawing.Size(188, 20);
		this.ckbReviewTag.TabIndex = 2;
		this.ckbReviewTag.Text = "Bật duyệt bài viết trên tường";
		this.ckbReviewTag.UseVisualStyleBackColor = true;
		this.ckbCheckBanBeGoiY.AutoSize = true;
		this.ckbCheckBanBeGoiY.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckBanBeGoiY.Location = new System.Drawing.Point(426, 550);
		this.ckbCheckBanBeGoiY.Name = "ckbCheckBanBeGoiY";
		this.ckbCheckBanBeGoiY.Size = new System.Drawing.Size(118, 17);
		this.ckbCheckBanBeGoiY.TabIndex = 9;
		this.ckbCheckBanBeGoiY.Text = "Check bạn bè gợi ý";
		this.ckbCheckBanBeGoiY.UseVisualStyleBackColor = true;
		this.ckbCheckBanBeGoiY.Visible = false;
		this.ckbBatThongBaoDangNhap.AutoSize = true;
		this.ckbBatThongBaoDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBatThongBaoDangNhap.Location = new System.Drawing.Point(444, 528);
		this.ckbBatThongBaoDangNhap.Name = "ckbBatThongBaoDangNhap";
		this.ckbBatThongBaoDangNhap.Size = new System.Drawing.Size(148, 17);
		this.ckbBatThongBaoDangNhap.TabIndex = 7;
		this.ckbBatThongBaoDangNhap.Text = "Bật thông báo đăng nhập";
		this.ckbBatThongBaoDangNhap.UseVisualStyleBackColor = true;
		this.ckbBatThongBaoDangNhap.Visible = false;
		this.ckbCauHinhTaiKhoan.AutoSize = true;
		this.ckbCauHinhTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCauHinhTaiKhoan.Location = new System.Drawing.Point(15, 208);
		this.ckbCauHinhTaiKhoan.Name = "ckbCauHinhTaiKhoan";
		this.ckbCauHinhTaiKhoan.Size = new System.Drawing.Size(132, 20);
		this.ckbCauHinhTaiKhoan.TabIndex = 8;
		this.ckbCauHinhTaiKhoan.Text = "Cấu hình tài khoản";
		this.ckbCauHinhTaiKhoan.UseVisualStyleBackColor = true;
		this.plShowCoBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plShowCoBan.Controls.Add(this.plCapNhatThongTin);
		this.plShowCoBan.Controls.Add(this.plRepeatAll);
		this.plShowCoBan.Controls.Add(this.ckbGetCookie);
		this.plShowCoBan.Controls.Add(this.ckbCreateProfile);
		this.plShowCoBan.Controls.Add(this.btnShowCoBan);
		this.plShowCoBan.Controls.Add(this.ckbDontSaveBrowser);
		this.plShowCoBan.Controls.Add(this.ckbCheckLiveUid);
		this.plShowCoBan.Controls.Add(this.ckbCapNhatThongTin);
		this.plShowCoBan.Controls.Add(this.ckbRepeatAll);
		this.plShowCoBan.Controls.Add(this.ckbLogOut);
		this.plShowCoBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.plShowCoBan.Location = new System.Drawing.Point(11, 44);
		this.plShowCoBan.MaximumSize = new System.Drawing.Size(420, 269);
		this.plShowCoBan.MinimumSize = new System.Drawing.Size(420, 27);
		this.plShowCoBan.Name = "plShowCoBan";
		this.plShowCoBan.Size = new System.Drawing.Size(420, 269);
		this.plShowCoBan.TabIndex = 3;
		this.plCapNhatThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCapNhatThongTin.Controls.Add(this.ckbEmail);
		this.plCapNhatThongTin.Controls.Add(this.ckbPhone);
		this.plCapNhatThongTin.Controls.Add(this.ckbFollow);
		this.plCapNhatThongTin.Controls.Add(this.ckbGroup);
		this.plCapNhatThongTin.Controls.Add(this.ckbFriend);
		this.plCapNhatThongTin.Controls.Add(this.ckbNgayTao);
		this.plCapNhatThongTin.Controls.Add(this.ckbBirthday);
		this.plCapNhatThongTin.Controls.Add(this.ckbGender);
		this.plCapNhatThongTin.Controls.Add(this.ckbName);
		this.plCapNhatThongTin.Location = new System.Drawing.Point(10, 84);
		this.plCapNhatThongTin.Name = "plCapNhatThongTin";
		this.plCapNhatThongTin.Size = new System.Drawing.Size(397, 55);
		this.plCapNhatThongTin.TabIndex = 14;
		this.ckbEmail.AutoSize = true;
		this.ckbEmail.Location = new System.Drawing.Point(322, 4);
		this.ckbEmail.Name = "ckbEmail";
		this.ckbEmail.Size = new System.Drawing.Size(57, 20);
		this.ckbEmail.TabIndex = 1;
		this.ckbEmail.Text = "Email";
		this.ckbEmail.UseVisualStyleBackColor = true;
		this.ckbPhone.AutoSize = true;
		this.ckbPhone.Location = new System.Drawing.Point(239, 29);
		this.ckbPhone.Name = "ckbPhone";
		this.ckbPhone.Size = new System.Drawing.Size(61, 20);
		this.ckbPhone.TabIndex = 0;
		this.ckbPhone.Text = "Phone";
		this.ckbPhone.UseVisualStyleBackColor = true;
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Location = new System.Drawing.Point(151, 29);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(63, 20);
		this.ckbFollow.TabIndex = 0;
		this.ckbFollow.Text = "Follow";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.ckbGroup.AutoSize = true;
		this.ckbGroup.Location = new System.Drawing.Point(72, 29);
		this.ckbGroup.Name = "ckbGroup";
		this.ckbGroup.Size = new System.Drawing.Size(60, 20);
		this.ckbGroup.TabIndex = 0;
		this.ckbGroup.Text = "Group";
		this.ckbGroup.UseVisualStyleBackColor = true;
		this.ckbGroup.Click += new System.EventHandler(ckbGroup_Click);
		this.ckbFriend.AutoSize = true;
		this.ckbFriend.Location = new System.Drawing.Point(6, 30);
		this.ckbFriend.Name = "ckbFriend";
		this.ckbFriend.Size = new System.Drawing.Size(62, 20);
		this.ckbFriend.TabIndex = 0;
		this.ckbFriend.Text = "Friend";
		this.ckbFriend.UseVisualStyleBackColor = true;
		this.ckbNgayTao.AutoSize = true;
		this.ckbNgayTao.Location = new System.Drawing.Point(239, 3);
		this.ckbNgayTao.Name = "ckbNgayTao";
		this.ckbNgayTao.Size = new System.Drawing.Size(76, 20);
		this.ckbNgayTao.TabIndex = 0;
		this.ckbNgayTao.Text = "Ngày tạo";
		this.ckbNgayTao.UseVisualStyleBackColor = true;
		this.ckbBirthday.AutoSize = true;
		this.ckbBirthday.Location = new System.Drawing.Point(151, 3);
		this.ckbBirthday.Name = "ckbBirthday";
		this.ckbBirthday.Size = new System.Drawing.Size(81, 20);
		this.ckbBirthday.TabIndex = 0;
		this.ckbBirthday.Text = "Ngày sinh";
		this.ckbBirthday.UseVisualStyleBackColor = true;
		this.ckbGender.AutoSize = true;
		this.ckbGender.Location = new System.Drawing.Point(72, 3);
		this.ckbGender.Name = "ckbGender";
		this.ckbGender.Size = new System.Drawing.Size(72, 20);
		this.ckbGender.TabIndex = 0;
		this.ckbGender.Text = "Giới tính";
		this.ckbGender.UseVisualStyleBackColor = true;
		this.ckbName.AutoSize = true;
		this.ckbName.Location = new System.Drawing.Point(6, 4);
		this.ckbName.Name = "ckbName";
		this.ckbName.Size = new System.Drawing.Size(59, 20);
		this.ckbName.TabIndex = 0;
		this.ckbName.Text = "Name";
		this.ckbName.UseVisualStyleBackColor = true;
		this.plRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plRepeatAll.Controls.Add(this.label6);
		this.plRepeatAll.Controls.Add(this.label4);
		this.plRepeatAll.Controls.Add(this.nudDelayTurnFrom);
		this.plRepeatAll.Controls.Add(this.label5);
		this.plRepeatAll.Controls.Add(this.nudDelayTurnTo);
		this.plRepeatAll.Controls.Add(this.label11);
		this.plRepeatAll.Controls.Add(this.nudSoLuotChay);
		this.plRepeatAll.Controls.Add(this.label10);
		this.plRepeatAll.Location = new System.Drawing.Point(30, 195);
		this.plRepeatAll.Name = "plRepeatAll";
		this.plRepeatAll.Size = new System.Drawing.Size(376, 64);
		this.plRepeatAll.TabIndex = 13;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 6);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(83, 16);
		this.label6.TabIndex = 5;
		this.label6.Text = "Sô\u0301 lươ\u0323t cha\u0323y:";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(3, 34);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(144, 16);
		this.label4.TabIndex = 6;
		this.label4.Text = "Chờ cha\u0323y lươ\u0323t tiê\u0301p theo:";
		this.nudDelayTurnFrom.Location = new System.Drawing.Point(154, 32);
		this.nudDelayTurnFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudDelayTurnFrom.Name = "nudDelayTurnFrom";
		this.nudDelayTurnFrom.Size = new System.Drawing.Size(65, 23);
		this.nudDelayTurnFrom.TabIndex = 9;
		this.label5.Location = new System.Drawing.Point(222, 7);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(30, 16);
		this.label5.TabIndex = 10;
		this.label5.Text = "lươ\u0323t";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label5.Click += new System.EventHandler(label5_Click);
		this.nudDelayTurnTo.Location = new System.Drawing.Point(252, 32);
		this.nudDelayTurnTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudDelayTurnTo.Name = "nudDelayTurnTo";
		this.nudDelayTurnTo.Size = new System.Drawing.Size(65, 23);
		this.nudDelayTurnTo.TabIndex = 8;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(320, 35);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(32, 16);
		this.label11.TabIndex = 11;
		this.label11.Text = "phút";
		this.nudSoLuotChay.Location = new System.Drawing.Point(154, 4);
		this.nudSoLuotChay.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudSoLuotChay.Name = "nudSoLuotChay";
		this.nudSoLuotChay.Size = new System.Drawing.Size(65, 23);
		this.nudSoLuotChay.TabIndex = 7;
		this.label10.Location = new System.Drawing.Point(222, 35);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 12;
		this.label10.Text = "đến";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnShowCoBan.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.btnShowCoBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnShowCoBan.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnShowCoBan.FlatAppearance.BorderSize = 0;
		this.btnShowCoBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnShowCoBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnShowCoBan.ForeColor = System.Drawing.Color.Black;
		this.btnShowCoBan.Image = Class306.Bitmap_103;
		this.btnShowCoBan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnShowCoBan.Location = new System.Drawing.Point(0, 0);
		this.btnShowCoBan.Name = "btnShowCoBan";
		this.btnShowCoBan.Size = new System.Drawing.Size(418, 25);
		this.btnShowCoBan.TabIndex = 2;
		this.btnShowCoBan.Text = "Cấu hình cơ bản";
		this.btnShowCoBan.UseVisualStyleBackColor = false;
		this.btnShowCoBan.Click += new System.EventHandler(btnShowCoBan_Click);
		this.ckbDontSaveBrowser.AutoSize = true;
		this.ckbDontSaveBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDontSaveBrowser.Location = new System.Drawing.Point(216, 147);
		this.ckbDontSaveBrowser.Name = "ckbDontSaveBrowser";
		this.ckbDontSaveBrowser.Size = new System.Drawing.Size(199, 20);
		this.ckbDontSaveBrowser.TabIndex = 2;
		this.ckbDontSaveBrowser.Text = "Không lưu trình duyệt khi login";
		this.ckbDontSaveBrowser.UseVisualStyleBackColor = true;
		this.ckbCheckLiveUid.AutoSize = true;
		this.ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckLiveUid.Location = new System.Drawing.Point(10, 147);
		this.ckbCheckLiveUid.Name = "ckbCheckLiveUid";
		this.ckbCheckLiveUid.Size = new System.Drawing.Size(192, 20);
		this.ckbCheckLiveUid.TabIndex = 2;
		this.ckbCheckLiveUid.Text = "Check Live Uid trước khi chạy";
		this.ckbCheckLiveUid.UseVisualStyleBackColor = true;
		this.timer_0.Interval = 15;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.timer_1.Interval = 15;
		this.timer_1.Tick += new System.EventHandler(timer_1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(442, 598);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTuongTac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTuongTac_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plTuongTacKichBan.ResumeLayout(false);
		this.plTuongTacKichBan.PerformLayout();
		this.plGioiHanThoiGianChayKichBan.ResumeLayout(false);
		this.plGioiHanThoiGianChayKichBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanFrom).EndInit();
		this.plGioiHanThoiGianChayTaiKhoan.ResumeLayout(false);
		this.plGioiHanThoiGianChayTaiKhoan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).EndInit();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plShowNangCao.ResumeLayout(false);
		this.plShowNangCao.PerformLayout();
		this.plToken.ResumeLayout(false);
		this.plToken.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.plShowCoBan.ResumeLayout(false);
		this.plShowCoBan.PerformLayout();
		this.plCapNhatThongTin.ResumeLayout(false);
		this.plCapNhatThongTin.PerformLayout();
		this.plRepeatAll.ResumeLayout(false);
		this.plRepeatAll.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).EndInit();
		base.ResumeLayout(false);
	}
}
