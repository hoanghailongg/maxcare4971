using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;

public class fChangeConfig : Form
{
	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private MetroContextMenu ctmsAcc;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem liveToolStripMenuItem;

	private ToolStripMenuItem dieToolStripMenuItem;

	private ToolStripMenuItem checkpointToolStripMenuItem;

	private ToolStripMenuItem changePasswordToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem tokenToolStripMenuItem;

	private ToolStripMenuItem cookieToolStripMenuItem;

	private ToolStripMenuItem uidPassToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem checkCookieToolStripMenuItem;

	private ToolStripMenuItem backupToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem passToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem mnsCutAccount;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem cookieToolStripMenuItem1;

	private ToolStripMenuItem uidPassToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem cookieToolStripMenuItem2;

	private ToolStripMenuItem uidPassToolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripMenuItem toolStripMenuItem_17;

	private ToolStripMenuItem toolStripMenuItem_18;

	private ToolStripMenuItem tokenToolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_19;

	private ToolStripMenuItem tokenBussinessToolStripMenuItem;

	private ToolStripMenuItem tokenInstagramToolStripMenuItem1;

	private ToolStripMenuItem tokenIosToolStripMenuItem;

	private ToolStripMenuItem tokenAndroidToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_20;

	private ToolStripMenuItem cookieToolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem_21;

	private ToolStripMenuItem toolStripMenuItem_22;

	private ToolStripMenuItem toolStripMenuItem_23;

	private ToolStripMenuItem backupTokenToolStripMenuItem;

	private ToolStripMenuItem backupCookieToolStripMenuItem;

	private ToolStripMenuItem backupCookieTrungGianToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_24;

	private GroupBox groupBox3;

	private GroupBox groupBox5;

	private Label label10;

	private NumericUpDown nudThread;

	private Label label11;

	private Label label4;

	private Label label12;

	private ToolTip toolTip_0;

	private Panel panel2;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plDoiMatKhau;

	private Button btnNhapPass;

	private Panel plDoiAnhBia;

	private RadioButton rdAnhNguoiDungDat;

	private RadioButton rdAnhNgheThuat;

	private Button btnCapNhatThongTin;

	private CheckBox ckbThemMoTa;

	private Button btnThemMoTa;

	private CheckBox ckbDoiPass;

	private CheckBox ckbCapNhatThongTin;

	private CheckBox ckbDoiTen;

	private CheckBox ckbDoiAnhBia;

	private CheckBox ckbDoiAvatar;

	private Panel plDoiTen;

	private Panel plTenTuDat;

	private Button button8;

	private Button button7;

	private Button button6;

	private RadioButton rdTenTuDat;

	private RadioButton rdTenRandom;

	private Panel plTenNgauNhien;

	private RadioButton rdTenRandomNgoai;

	private RadioButton rdTenRandomViet;

	private CheckBox ckbDoiNgonNgu;

	private ComboBox cbbNgonNgu;

	private CheckBox ckbAddPhone;

	private TextBox txtPhone;

	private RadioButton rdPassRandom;

	private RadioButton rdPassTuNhap;

	private Panel pl2fa;

	private RadioButton rdTat2fa;

	private RadioButton rdBat2fa;

	private CheckBox ckb2fa;

	private MetroTextBox txtPathAvatar;

	private Panel panel1;

	private NumericUpDown nudNamFrom;

	private NumericUpDown nudNamTo;

	private NumericUpDown nudThangTo;

	private NumericUpDown nudNgayTo;

	private NumericUpDown nudThangFrom;

	private NumericUpDown nudNgayFrom;

	private Label label13;

	private Label label7;

	private Label label3;

	private Label label9;

	private Label label6;

	private Label label2;

	private Label label8;

	private Label label5;

	private Label label1;

	private CheckBox ckbDoiNgaySinh;

	private MetroTextBox txtPathCover;

	private Button button4;

	private Button button3;

	private Button button9;

	private Button button5;

	private Panel panel3;

	private Panel plDoiMail;

	private Button btnNhapHotmail;

	private CheckBox ckbAddMail;

	private CheckBox ckbLogOut;

	private Panel plXoaMail;

	private Panel plXoaMailLinkHacked;

	private Label lblNewPass1;

	private CheckBox ckbPassRandomXoaMail;

	private Button btnNhapPassXoaMail;

	private RadioButton rdXoaTrucTiep;

	private RadioButton rdXoaLinkHacked;

	private CheckBox ckbXoaMail;

	private MetroButton metroButton1;

	private Button btnCancel;

	private Button btnAdd;

	private CheckBox ckbAutoDeleteFile;

	private CheckBox ckbXoaSdt;

	private Label label14;

	private Panel panel4;

	private RadioButton rbLoginUidPass;

	private RadioButton rbLoginCookie;

	private CheckBox ckbCreateProfile;

	private Label label15;

	private CheckBox ckbCloseChrome;

	private Button button1;

	private CheckBox ckbVerify;

	private CheckBox ckbChangePassLinkHacked;

	private CheckBox ckbMailVip;

	private Panel plAvatar;

	private CheckBox ckbAvatarThuTu;

	private Label label16;

	private CheckBox ckbCoverThuTu;

	private Panel panel5;

	private RadioButton rbNu;

	private RadioButton rbNam;

	private CheckBox ckbGioiTinh;

	private Panel panel7;

	private RadioButton rbLoginWWW;

	private RadioButton rbLoginMFB;

	private Label label17;

	private CheckBox ckbXoaMailCu2;

	private CheckBox ckbAnMailAll;

	private CheckBox ckbXoaThietBiTinCay;

	private CheckBox ckbAddMailLinkHacked;

	private Panel plPassMailHacked;

	private Label label18;

	private CheckBox ckbRandomPassMailHacked;

	private MetroTextBox txtPassMailHacked;

	private Button button2;

	private Panel plVerify;

	private RadioButton rbMailTuNhap;

	private RadioButton rbVip;

	private CheckBox ckbLogOut2;

	private RadioButton rbLoginVia;

	private RadioButton rbLoginMbasic;

	private Panel plRemoveMail;

	private RadioButton rbMfbMail;

	private RadioButton rbWwwMail;

	private Panel plRemovePhone;

	private RadioButton rbMfbPhone;

	private RadioButton rbWwwPhone;

	public fChangeConfig()
	{
		InitializeComponent();
		method_0();
		gclass17_0 = new GClass17("configChange");
		method_2();
		method_4();
		method_1();
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		List<string> list = Class38.smethod_3();
		for (int i = 0; i < list.Count; i++)
		{
			string[] array = list[i].Split('|');
			dictionary.Add(array[0], array[1]);
		}
		cbbNgonNgu.DataSource = new BindingSource(dictionary, null);
		cbbNgonNgu.ValueMember = "Key";
		cbbNgonNgu.DisplayMember = "Value";
	}

	private void method_1()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox5);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label14);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(metroButton1);
		GClass29.smethod_1(ckbCreateProfile);
		GClass29.smethod_1(groupBox3);
		GClass29.smethod_1(ckbDoiNgonNgu);
		GClass29.smethod_1(ckbAddPhone);
		GClass29.smethod_1(ckbDoiAvatar);
		GClass29.smethod_1(ckbDoiAnhBia);
		GClass29.smethod_1(ckbAutoDeleteFile);
		GClass29.smethod_1(rdAnhNguoiDungDat);
		GClass29.smethod_1(rdAnhNgheThuat);
		GClass29.smethod_1(ckbThemMoTa);
		GClass29.smethod_1(btnThemMoTa);
		GClass29.smethod_1(ckbDoiNgaySinh);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(ckbCapNhatThongTin);
		GClass29.smethod_1(btnCapNhatThongTin);
		GClass29.smethod_1(button3);
		GClass29.smethod_1(button4);
		GClass29.smethod_1(button5);
		GClass29.smethod_1(button9);
		GClass29.smethod_1(ckbAddMail);
		GClass29.smethod_1(btnNhapHotmail);
		GClass29.smethod_1(ckbDoiTen);
		GClass29.smethod_1(rdTenTuDat);
		GClass29.smethod_1(button6);
		GClass29.smethod_1(button7);
		GClass29.smethod_1(button8);
		GClass29.smethod_1(rdTenRandom);
		GClass29.smethod_1(rdTenRandomViet);
		GClass29.smethod_1(rdTenRandomNgoai);
		GClass29.smethod_1(ckb2fa);
		GClass29.smethod_1(rdBat2fa);
		GClass29.smethod_1(rdTat2fa);
		GClass29.smethod_1(ckbDoiPass);
		GClass29.smethod_1(rdPassTuNhap);
		GClass29.smethod_1(btnNhapPass);
		GClass29.smethod_1(rdPassRandom);
		GClass29.smethod_1(ckbXoaSdt);
		GClass29.smethod_1(ckbLogOut);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void method_2()
	{
		nudThread.Value = gclass17_0.method_2("change_nudThread", 3);
		ckbVerify.Checked = gclass17_0.method_3("change_ckbVerify");
		ckbDoiNgonNgu.Checked = gclass17_0.method_3("change_ckbDoiNgonNgu");
		cbbNgonNgu.SelectedValue = gclass17_0.method_0("change_cbbNgonNgu", "vi_VN");
		ckbAddPhone.Checked = gclass17_0.method_3("change_ckbAddPhone");
		txtPhone.Text = gclass17_0.method_0("change_txtPhone", "09xxxxxxxx");
		txtPathAvatar.Text = gclass17_0.method_0("change_txtPathAvatar");
		txtPathCover.Text = gclass17_0.method_0("change_txtPathCover");
		ckbDoiAvatar.Checked = gclass17_0.method_3("change_ckbDoiAvatar");
		ckbAvatarThuTu.Checked = gclass17_0.method_3("change_ckbAvatarThuTu");
		ckbDoiAnhBia.Checked = gclass17_0.method_3("change_ckbDoiAnhBia");
		if (gclass17_0.method_2("change_typeUpCover") == 0)
		{
			rdAnhNguoiDungDat.Checked = true;
		}
		else
		{
			rdAnhNgheThuat.Checked = true;
		}
		ckbCoverThuTu.Checked = gclass17_0.method_3("change_ckbCoverThuTu");
		ckbThemMoTa.Checked = gclass17_0.method_3("change_ckbThemMoTa");
		ckbCapNhatThongTin.Checked = gclass17_0.method_3("change_ckbCapNhatThongTin");
		ckbDoiNgaySinh.Checked = gclass17_0.method_3("change_ckbDoiNgaySinh");
		nudNgayFrom.Value = gclass17_0.method_2("change_nudNgayFrom", 1);
		nudNgayTo.Value = gclass17_0.method_2("change_nudNgayTo", 30);
		nudThangFrom.Value = gclass17_0.method_2("change_nudThangFrom", 1);
		nudThangTo.Value = gclass17_0.method_2("change_nudThangTo", 12);
		nudNamFrom.Value = gclass17_0.method_2("change_nudNamFrom", 1980);
		nudNamTo.Value = gclass17_0.method_2("change_nudNamTo", 2000);
		ckbGioiTinh.Checked = gclass17_0.method_3("change_ckbGioiTinh");
		switch (gclass17_0.method_2("change_typeGioiTinh"))
		{
		case 0:
			rbNu.Checked = true;
			break;
		case 1:
			rbNam.Checked = true;
			break;
		}
		ckbDoiTen.Checked = gclass17_0.method_3("change_ckbDoiTen");
		if (gclass17_0.method_2("change_typeDatTen") == 0)
		{
			rdTenTuDat.Checked = true;
		}
		else
		{
			rdTenRandom.Checked = true;
		}
		if (gclass17_0.method_2("change_typeTenRandom") == 0)
		{
			rdTenRandomViet.Checked = true;
		}
		else
		{
			rdTenRandomNgoai.Checked = true;
		}
		ckbDoiPass.Checked = gclass17_0.method_3("change_ckbDoiPass");
		if (gclass17_0.method_2("change_typeDoiPass") == 0)
		{
			rdPassTuNhap.Checked = true;
		}
		else
		{
			rdPassRandom.Checked = true;
		}
		ckbChangePassLinkHacked.Checked = gclass17_0.method_3("change_ckbDoiPassUseLinkHacked");
		ckb2fa.Checked = gclass17_0.method_3("change_ckb2fa");
		switch (gclass17_0.method_2("change_type2fa"))
		{
		case 0:
			rdBat2fa.Checked = true;
			break;
		case 1:
			rdTat2fa.Checked = true;
			break;
		case 2:
			rbVip.Checked = true;
			break;
		}
		ckbAddMail.Checked = gclass17_0.method_3("ckbAddMail");
		ckbMailVip.Checked = gclass17_0.method_3("ckbMailVip");
		ckbCloseChrome.Checked = gclass17_0.method_3("ckbCloseChrome");
		ckbAddMailLinkHacked.Checked = gclass17_0.method_3("ckbAddMailLinkHacked");
		txtPassMailHacked.Text = gclass17_0.method_0("txtPassMailHacked");
		ckbRandomPassMailHacked.Checked = gclass17_0.method_3("ckbRandomPassMailHacked");
		ckbAnMailAll.Checked = gclass17_0.method_3("ckbAnMailAll");
		ckbXoaMailCu2.Checked = gclass17_0.method_3("ckbXoaMailCu2");
		if (gclass17_0.method_2("typeXoaMail") == 0)
		{
			rbMfbMail.Checked = true;
		}
		else
		{
			rbWwwMail.Checked = true;
		}
		ckbLogOut.Checked = gclass17_0.method_3("ckbLogOut");
		ckbXoaSdt.Checked = gclass17_0.method_3("ckbXoaSdt");
		if (gclass17_0.method_2("typeXoaSdt") == 0)
		{
			rbMfbPhone.Checked = true;
		}
		else
		{
			rbWwwPhone.Checked = true;
		}
		ckbXoaMail.Checked = gclass17_0.method_3("ckbXoaMail");
		int num = gclass17_0.method_2("xoaMail");
		if (num == 1)
		{
			rdXoaLinkHacked.Checked = true;
		}
		else
		{
			rdXoaTrucTiep.Checked = true;
		}
		ckbPassRandomXoaMail.Checked = gclass17_0.method_3("ckbPassRandomXoaMail");
		ckbAutoDeleteFile.Checked = gclass17_0.method_3("ckbAutoDeleteFile");
		if (gclass17_0.method_2("typeLogin") == 0)
		{
			rbLoginUidPass.Checked = true;
		}
		else if (gclass17_0.method_2("typeLogin") == 1)
		{
			rbLoginCookie.Checked = true;
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
			rbLoginVia.Checked = true;
			break;
		}
		ckbCreateProfile.Checked = gclass17_0.method_3("ckbCreateProfile");
		ckbXoaThietBiTinCay.Checked = gclass17_0.method_3("change_ckbXoaThietBiTinCay");
		ckbLogOut2.Checked = gclass17_0.method_3("ckbLogOut2");
	}

	private void method_3()
	{
		gclass17_0.method_5("change_nudThread", Convert.ToInt32(nudThread.Value));
		gclass17_0.method_5("change_ckbVerify", ckbVerify.Checked);
		gclass17_0.method_5("change_ckbDoiNgonNgu", ckbDoiNgonNgu.Checked);
		gclass17_0.method_5("change_cbbNgonNgu", cbbNgonNgu.SelectedValue);
		gclass17_0.method_5("change_ckbAddPhone", ckbAddPhone.Checked);
		gclass17_0.method_5("change_txtPhone", txtPhone.Text);
		gclass17_0.method_5("change_txtPathAvatar", txtPathAvatar.Text);
		gclass17_0.method_5("change_ckbAvatarThuTu", ckbAvatarThuTu.Checked);
		gclass17_0.method_5("change_txtPathCover", txtPathCover.Text);
		gclass17_0.method_5("change_ckbDoiAvatar", ckbDoiAvatar.Checked);
		gclass17_0.method_5("change_ckbDoiAnhBia", ckbDoiAnhBia.Checked);
		int num = 0;
		if (rdAnhNgheThuat.Checked)
		{
			num = 1;
		}
		gclass17_0.method_5("change_typeUpCover", num);
		gclass17_0.method_5("change_ckbThemMoTa", ckbThemMoTa.Checked);
		gclass17_0.method_5("change_ckbCapNhatThongTin", ckbCapNhatThongTin.Checked);
		gclass17_0.method_5("change_ckbCoverThuTu", ckbCoverThuTu.Checked);
		gclass17_0.method_5("change_ckbDoiNgaySinh", ckbDoiNgaySinh.Checked);
		gclass17_0.method_5("change_nudNgayFrom", Convert.ToInt32(nudNgayFrom.Value));
		gclass17_0.method_5("change_nudNgayTo", Convert.ToInt32(nudNgayTo.Value));
		gclass17_0.method_5("change_nudThangFrom", Convert.ToInt32(nudThangFrom.Value));
		gclass17_0.method_5("change_nudThangTo", Convert.ToInt32(nudThangTo.Value));
		gclass17_0.method_5("change_nudNamFrom", Convert.ToInt32(nudNamFrom.Value));
		gclass17_0.method_5("change_nudNamTo", Convert.ToInt32(nudNamTo.Value));
		gclass17_0.method_5("change_ckbGioiTinh", ckbGioiTinh.Checked);
		int num2 = 0;
		if (rbNam.Checked)
		{
			num2 = 1;
		}
		gclass17_0.method_5("change_typeGioiTinh", num2);
		gclass17_0.method_5("change_ckbDoiTen", ckbDoiTen.Checked);
		int num3 = 0;
		if (rdTenRandom.Checked)
		{
			num3 = 1;
		}
		gclass17_0.method_5("change_typeDatTen", num3);
		int num4 = 0;
		if (rdTenRandomNgoai.Checked)
		{
			num4 = 1;
		}
		gclass17_0.method_5("change_typeTenRandom", num4);
		gclass17_0.method_5("change_ckbDoiPass", ckbDoiPass.Checked);
		int num5 = 0;
		if (rdPassRandom.Checked)
		{
			num5 = 1;
		}
		gclass17_0.method_5("change_typeDoiPass", num5);
		gclass17_0.method_5("change_ckbDoiPassUseLinkHacked", ckbChangePassLinkHacked.Checked);
		gclass17_0.method_5("change_ckb2fa", ckb2fa.Checked);
		int num6 = 0;
		if (rdTat2fa.Checked)
		{
			num6 = 1;
		}
		else if (rbVip.Checked)
		{
			num6 = 2;
		}
		gclass17_0.method_5("change_type2fa", num6);
		gclass17_0.method_5("ckbAddMail", ckbAddMail.Checked.ToString());
		gclass17_0.method_5("themMail", 1);
		gclass17_0.method_5("ckbMailVip", ckbMailVip.Checked.ToString());
		gclass17_0.method_5("ckbCloseChrome", ckbCloseChrome.Checked.ToString());
		gclass17_0.method_5("ckbAddMailLinkHacked", ckbAddMailLinkHacked.Checked.ToString());
		gclass17_0.method_5("txtPassMailHacked", txtPassMailHacked.Text.Trim());
		gclass17_0.method_5("ckbRandomPassMailHacked", ckbRandomPassMailHacked.Checked);
		gclass17_0.method_5("ckbAnMailAll", ckbAnMailAll.Checked);
		gclass17_0.method_5("ckbXoaMailCu2", ckbXoaMailCu2.Checked);
		int num7 = 0;
		if (rbWwwMail.Checked)
		{
			num7 = 1;
		}
		gclass17_0.method_5("typeXoaMail", num7);
		gclass17_0.method_5("ckbLogOut", ckbLogOut.Checked.ToString());
		gclass17_0.method_5("ckbXoaSdt", ckbXoaSdt.Checked);
		int num8 = 0;
		if (rbWwwPhone.Checked)
		{
			num8 = 1;
		}
		gclass17_0.method_5("typeXoaSdt", num8);
		gclass17_0.method_5("ckbXoaMail", ckbXoaMail.Checked);
		int num9 = 0;
		if (rdXoaLinkHacked.Checked)
		{
			num9 = 1;
		}
		gclass17_0.method_5("xoaMail", num9.ToString());
		gclass17_0.method_5("ckbPassRandomXoaMail", ckbPassRandomXoaMail.Checked);
		gclass17_0.method_5("ckbAutoDeleteFile", ckbAutoDeleteFile.Checked);
		if (rbLoginUidPass.Checked)
		{
			gclass17_0.method_5("typeLogin", 0);
		}
		else
		{
			gclass17_0.method_5("typeLogin", 1);
		}
		int num10 = 0;
		num10 = ((!rbLoginMFB.Checked) ? (rbLoginWWW.Checked ? 1 : ((!rbLoginMbasic.Checked) ? 3 : 2)) : 0);
		gclass17_0.method_5("typeBrowserLogin", num10);
		gclass17_0.method_5("ckbCreateProfile", ckbCreateProfile.Checked);
		gclass17_0.method_5("change_ckbXoaThietBiTinCay", ckbXoaThietBiTinCay.Checked);
		gclass17_0.method_5("ckbLogOut2", ckbLogOut2.Checked);
		gclass17_0.method_8();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChangeConfig_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fCauHinhChung());
	}

	private void groupBox5_Enter(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_24_Click(object sender, EventArgs e)
	{
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			method_3();
			if (GClass38.smethod_1(GClass29.smethod_0("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng thử lại sau!"), 2);
		}
	}

	private void method_4()
	{
		ckbDoiNgonNgu_CheckedChanged(null, null);
		ckbAddPhone_CheckedChanged(null, null);
		ckbDoiAvatar_CheckedChanged(null, null);
		ckbDoiAnhBia_CheckedChanged(null, null);
		rdAnhNguoiDungDat_CheckedChanged(null, null);
		ckbThemMoTa_CheckedChanged(null, null);
		ckbCapNhatThongTin_CheckedChanged(null, null);
		ckbDoiTen_CheckedChanged(null, null);
		rdTenTuDat_CheckedChanged(null, null);
		rdTenRandom_CheckedChanged(null, null);
		ckbDoiPass_CheckedChanged(null, null);
		rdPassTuNhap_CheckedChanged(null, null);
		ckb2fa_CheckedChanged(null, null);
		ckbDoiNgaySinh_CheckedChanged(null, null);
		ckbAddMail_CheckedChanged(null, null);
		rdXoaLinkHacked_CheckedChanged(null, null);
		ckbXoaMail_CheckedChanged(null, null);
		ckbPassRandomXoaMail_CheckedChanged(null, null);
		ckbCloseChrome_CheckedChanged(null, null);
		ckbGioiTinh_CheckedChanged(null, null);
		method_8(null, null);
		method_10(null, null);
		method_11(null, null);
		ckbAnMailAll_CheckedChanged(null, null);
		ckbXoaMailCu2_CheckedChanged(null, null);
		ckbAddMailLinkHacked_CheckedChanged(null, null);
		ckbRandomPassMailHacked_CheckedChanged(null, null);
		rbMailTuNhap_CheckedChanged(null, null);
		method_12(null, null);
		ckbXoaSdt_CheckedChanged(null, null);
	}

	private void ckbDoiNgonNgu_CheckedChanged(object sender, EventArgs e)
	{
		cbbNgonNgu.Enabled = ckbDoiNgonNgu.Checked;
	}

	private void ckbAddPhone_CheckedChanged(object sender, EventArgs e)
	{
		txtPhone.Enabled = ckbAddPhone.Checked;
	}

	private void ckbDoiAvatar_CheckedChanged(object sender, EventArgs e)
	{
		plAvatar.Enabled = ckbDoiAvatar.Checked;
	}

	private void ckbDoiAnhBia_CheckedChanged(object sender, EventArgs e)
	{
		plDoiAnhBia.Enabled = ckbDoiAnhBia.Checked;
	}

	private void rdAnhNguoiDungDat_CheckedChanged(object sender, EventArgs e)
	{
		txtPathCover.Enabled = rdAnhNguoiDungDat.Checked;
	}

	private void ckbThemMoTa_CheckedChanged(object sender, EventArgs e)
	{
		btnThemMoTa.Enabled = ckbThemMoTa.Checked;
	}

	private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
	{
		panel3.Enabled = ckbCapNhatThongTin.Checked;
	}

	private void ckbDoiTen_CheckedChanged(object sender, EventArgs e)
	{
		plDoiTen.Enabled = ckbDoiTen.Checked;
	}

	private void rdTenTuDat_CheckedChanged(object sender, EventArgs e)
	{
		plTenTuDat.Enabled = rdTenTuDat.Checked;
	}

	private void rdTenRandom_CheckedChanged(object sender, EventArgs e)
	{
		plTenNgauNhien.Enabled = rdTenRandom.Checked;
	}

	private void ckbDoiPass_CheckedChanged(object sender, EventArgs e)
	{
		plDoiMatKhau.Enabled = ckbDoiPass.Checked;
	}

	private void rdPassTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapPass.Enabled = rdPassTuNhap.Checked;
	}

	private void method_5(object sender, EventArgs e)
	{
		txtPathAvatar.Text = GClass14.smethod_40();
	}

	private void method_6(object sender, EventArgs e)
	{
		Process.Start("configschange\\anhbia");
	}

	private void btnThemMoTa_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fNhapDuLieu2("configschange\\tieusu", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch tiê\u0309u sư\u0309")));
	}

	private void btnCapNhatThongTin_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\thongtincanhan\\NoiLamViec.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Nơi la\u0300m viê\u0323c"), GClass29.smethod_0("Danh sa\u0301ch tư\u0300 kho\u0301a"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button6_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\doiten\\ho.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Ho\u0323"), GClass29.smethod_0("Danh sa\u0301ch Ho\u0323"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button7_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\doiten\\tendem.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Tên đê\u0323m"), GClass29.smethod_0("Danh sa\u0301ch Tên đê\u0323m"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button8_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\doiten\\ten.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Tên"), GClass29.smethod_0("Danh sa\u0301ch Tên"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void btnNhapPass_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\doimk.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch mâ\u0323t khâ\u0309u câ\u0300n đô\u0309i"), GClass29.smethod_0("Danh sa\u0301ch mâ\u0323t khâ\u0309u"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void ckb2fa_CheckedChanged(object sender, EventArgs e)
	{
		pl2fa.Enabled = ckb2fa.Checked;
	}

	private void ckbDoiNgaySinh_CheckedChanged(object sender, EventArgs e)
	{
		panel1.Enabled = ckbDoiNgaySinh.Checked;
	}

	private void method_7(object sender, EventArgs e)
	{
		txtPathCover.Text = GClass14.smethod_40();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\thongtincanhan\\QueQuan.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Quê qua\u0301n"), GClass29.smethod_0("Danh sa\u0301ch tư\u0300 kho\u0301a"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button4_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\thongtincanhan\\ThanhPho.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Tha\u0300nh phô\u0301"), GClass29.smethod_0("Danh sa\u0301ch tư\u0300 kho\u0301a"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button5_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\thongtincanhan\\TruongDH.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Trươ\u0300ng ĐH"), GClass29.smethod_0("Danh sa\u0301ch tư\u0300 kho\u0301a"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button9_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\thongtincanhan\\TruongTHPT.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch Trươ\u0300ng THPT"), GClass29.smethod_0("Danh sa\u0301ch tư\u0300 kho\u0301a"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void btnNhapHotmail_Click(object sender, EventArgs e)
	{
		GClass14.smethod_32("configschange\\addmail");
		GClass14.smethod_33(new fNhapMailAdd());
	}

	private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
	{
		plDoiMail.Enabled = ckbAddMail.Checked;
	}

	private void btnNhapPassXoaMail_Click(object sender, EventArgs e)
	{
		GClass14.smethod_27("configschange\\doimk2.txt", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch mâ\u0323t khâ\u0309u mơ\u0301i"), GClass29.smethod_0("Danh sa\u0301ch mâ\u0323t khâ\u0309u"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void ckbXoaMail_CheckedChanged(object sender, EventArgs e)
	{
		plXoaMail.Enabled = ckbXoaMail.Checked;
	}

	private void rdXoaLinkHacked_CheckedChanged(object sender, EventArgs e)
	{
		plXoaMailLinkHacked.Enabled = rdXoaLinkHacked.Checked;
		if (rdXoaLinkHacked.Checked)
		{
			ckbDoiPass.Checked = false;
		}
	}

	private void ckbPassRandomXoaMail_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapPassXoaMail.Enabled = !ckbPassRandomXoaMail.Checked;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbAutoDeleteFile.Visible = true;
		}
	}

	private void ckbCloseChrome_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_32("configschange\\verify");
		GClass14.smethod_33(new fNhapDuLieu1("configschange\\verify\\hotmail.txt", "Nhâ\u0323p danh sa\u0301ch hotmail/outlook dùng để verify", "Danh sa\u0301ch email|pass mail", "(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void ckbVerify_CheckedChanged(object sender, EventArgs e)
	{
		plVerify.Enabled = ckbVerify.Checked;
	}

	private void ckbGioiTinh_CheckedChanged(object sender, EventArgs e)
	{
		panel5.Enabled = ckbGioiTinh.Checked;
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void method_9(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fCheckPoint());
	}

	private void groupBox3_Enter(object sender, EventArgs e)
	{
	}

	private void plDoiMail_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_10(object sender, EventArgs e)
	{
	}

	private void method_11(object sender, EventArgs e)
	{
	}

	private void ckbAnMailAll_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void ckbAddMailLinkHacked_CheckedChanged(object sender, EventArgs e)
	{
		plPassMailHacked.Enabled = ckbAddMailLinkHacked.Checked;
	}

	private void ckbRandomPassMailHacked_CheckedChanged(object sender, EventArgs e)
	{
		txtPassMailHacked.Enabled = !ckbRandomPassMailHacked.Checked;
	}

	private void plDoiMatKhau_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string object_ = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		GClass38.smethod_0(object_);
	}

	private void panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void rbMailTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		button1.Enabled = rbMailTuNhap.Checked;
	}

	private void method_12(object sender, EventArgs e)
	{
	}

	private void ckbXoaSdt_CheckedChanged(object sender, EventArgs e)
	{
		plRemovePhone.Enabled = ckbXoaSdt.Checked;
	}

	private void ckbXoaMailCu2_CheckedChanged(object sender, EventArgs e)
	{
		plRemoveMail.Enabled = ckbXoaMailCu2.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeConfig));
		this.ctmsAcc = new MetroFramework.Controls.MetroContextMenu(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_23 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_24 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.dieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.checkpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		this.mnsCutAccount = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		this.backupTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.backupCookieTrungGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenBussinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenInstagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenIosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenAndroidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_20 = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_21 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_22 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.plVerify = new System.Windows.Forms.Panel();
		this.rbMailTuNhap = new System.Windows.Forms.RadioButton();
		this.button1 = new System.Windows.Forms.Button();
		this.ckbLogOut2 = new System.Windows.Forms.CheckBox();
		this.ckbXoaThietBiTinCay = new System.Windows.Forms.CheckBox();
		this.ckbXoaMailCu2 = new System.Windows.Forms.CheckBox();
		this.ckbAnMailAll = new System.Windows.Forms.CheckBox();
		this.panel5 = new System.Windows.Forms.Panel();
		this.rbNu = new System.Windows.Forms.RadioButton();
		this.rbNam = new System.Windows.Forms.RadioButton();
		this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
		this.plAvatar = new System.Windows.Forms.Panel();
		this.ckbAvatarThuTu = new System.Windows.Forms.CheckBox();
		this.label16 = new System.Windows.Forms.Label();
		this.txtPathAvatar = new MetroFramework.Controls.MetroTextBox();
		this.ckbVerify = new System.Windows.Forms.CheckBox();
		this.plDoiMail = new System.Windows.Forms.Panel();
		this.plPassMailHacked = new System.Windows.Forms.Panel();
		this.txtPassMailHacked = new MetroFramework.Controls.MetroTextBox();
		this.label18 = new System.Windows.Forms.Label();
		this.ckbRandomPassMailHacked = new System.Windows.Forms.CheckBox();
		this.ckbAddMailLinkHacked = new System.Windows.Forms.CheckBox();
		this.ckbMailVip = new System.Windows.Forms.CheckBox();
		this.ckbCloseChrome = new System.Windows.Forms.CheckBox();
		this.label15 = new System.Windows.Forms.Label();
		this.btnNhapHotmail = new System.Windows.Forms.Button();
		this.ckbAddMail = new System.Windows.Forms.CheckBox();
		this.txtPhone = new System.Windows.Forms.TextBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudNamFrom = new System.Windows.Forms.NumericUpDown();
		this.nudNamTo = new System.Windows.Forms.NumericUpDown();
		this.nudThangTo = new System.Windows.Forms.NumericUpDown();
		this.nudNgayTo = new System.Windows.Forms.NumericUpDown();
		this.nudThangFrom = new System.Windows.Forms.NumericUpDown();
		this.nudNgayFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.panel3 = new System.Windows.Forms.Panel();
		this.button4 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.button9 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.btnCapNhatThongTin = new System.Windows.Forms.Button();
		this.pl2fa = new System.Windows.Forms.Panel();
		this.rbVip = new System.Windows.Forms.RadioButton();
		this.rdTat2fa = new System.Windows.Forms.RadioButton();
		this.rdBat2fa = new System.Windows.Forms.RadioButton();
		this.plDoiMatKhau = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.ckbChangePassLinkHacked = new System.Windows.Forms.CheckBox();
		this.btnNhapPass = new System.Windows.Forms.Button();
		this.rdPassRandom = new System.Windows.Forms.RadioButton();
		this.rdPassTuNhap = new System.Windows.Forms.RadioButton();
		this.plDoiAnhBia = new System.Windows.Forms.Panel();
		this.ckbCoverThuTu = new System.Windows.Forms.CheckBox();
		this.txtPathCover = new MetroFramework.Controls.MetroTextBox();
		this.rdAnhNguoiDungDat = new System.Windows.Forms.RadioButton();
		this.rdAnhNgheThuat = new System.Windows.Forms.RadioButton();
		this.ckbThemMoTa = new System.Windows.Forms.CheckBox();
		this.btnThemMoTa = new System.Windows.Forms.Button();
		this.ckbDoiNgaySinh = new System.Windows.Forms.CheckBox();
		this.ckb2fa = new System.Windows.Forms.CheckBox();
		this.ckbXoaSdt = new System.Windows.Forms.CheckBox();
		this.ckbLogOut = new System.Windows.Forms.CheckBox();
		this.ckbDoiPass = new System.Windows.Forms.CheckBox();
		this.ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
		this.ckbDoiTen = new System.Windows.Forms.CheckBox();
		this.ckbDoiAnhBia = new System.Windows.Forms.CheckBox();
		this.ckbAddPhone = new System.Windows.Forms.CheckBox();
		this.ckbAutoDeleteFile = new System.Windows.Forms.CheckBox();
		this.ckbDoiAvatar = new System.Windows.Forms.CheckBox();
		this.plDoiTen = new System.Windows.Forms.Panel();
		this.plTenTuDat = new System.Windows.Forms.Panel();
		this.button8 = new System.Windows.Forms.Button();
		this.button7 = new System.Windows.Forms.Button();
		this.button6 = new System.Windows.Forms.Button();
		this.rdTenTuDat = new System.Windows.Forms.RadioButton();
		this.rdTenRandom = new System.Windows.Forms.RadioButton();
		this.plTenNgauNhien = new System.Windows.Forms.Panel();
		this.rdTenRandomNgoai = new System.Windows.Forms.RadioButton();
		this.rdTenRandomViet = new System.Windows.Forms.RadioButton();
		this.ckbDoiNgonNgu = new System.Windows.Forms.CheckBox();
		this.cbbNgonNgu = new System.Windows.Forms.ComboBox();
		this.plXoaMail = new System.Windows.Forms.Panel();
		this.plXoaMailLinkHacked = new System.Windows.Forms.Panel();
		this.lblNewPass1 = new System.Windows.Forms.Label();
		this.ckbPassRandomXoaMail = new System.Windows.Forms.CheckBox();
		this.btnNhapPassXoaMail = new System.Windows.Forms.Button();
		this.rdXoaTrucTiep = new System.Windows.Forms.RadioButton();
		this.rdXoaLinkHacked = new System.Windows.Forms.RadioButton();
		this.ckbXoaMail = new System.Windows.Forms.CheckBox();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.rbLoginVia = new System.Windows.Forms.RadioButton();
		this.rbLoginMbasic = new System.Windows.Forms.RadioButton();
		this.rbLoginWWW = new System.Windows.Forms.RadioButton();
		this.rbLoginMFB = new System.Windows.Forms.RadioButton();
		this.label17 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.panel4 = new System.Windows.Forms.Panel();
		this.rbLoginUidPass = new System.Windows.Forms.RadioButton();
		this.rbLoginCookie = new System.Windows.Forms.RadioButton();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.label12 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nudThread = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.ckbCreateProfile = new System.Windows.Forms.CheckBox();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel2 = new System.Windows.Forms.Panel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.plRemovePhone = new System.Windows.Forms.Panel();
		this.rbMfbPhone = new System.Windows.Forms.RadioButton();
		this.rbWwwPhone = new System.Windows.Forms.RadioButton();
		this.plRemoveMail = new System.Windows.Forms.Panel();
		this.rbMfbMail = new System.Windows.Forms.RadioButton();
		this.rbWwwMail = new System.Windows.Forms.RadioButton();
		this.ctmsAcc.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox3.SuspendLayout();
		this.plVerify.SuspendLayout();
		this.panel5.SuspendLayout();
		this.plAvatar.SuspendLayout();
		this.plDoiMail.SuspendLayout();
		this.plPassMailHacked.SuspendLayout();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudNamFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudNamTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThangTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudNgayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThangFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudNgayFrom).BeginInit();
		this.panel3.SuspendLayout();
		this.pl2fa.SuspendLayout();
		this.plDoiMatKhau.SuspendLayout();
		this.plDoiAnhBia.SuspendLayout();
		this.plDoiTen.SuspendLayout();
		this.plTenTuDat.SuspendLayout();
		this.plTenNgauNhien.SuspendLayout();
		this.plXoaMail.SuspendLayout();
		this.plXoaMailLinkHacked.SuspendLayout();
		this.groupBox5.SuspendLayout();
		this.panel7.SuspendLayout();
		this.panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThread).BeginInit();
		this.panel2.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		this.plRemovePhone.SuspendLayout();
		this.plRemoveMail.SuspendLayout();
		base.SuspendLayout();
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[13]
		{
			this.toolStripMenuItem_0, this.toolStripMenuItem_7, this.toolStripMenuItem_1, this.copyToolStripMenuItem, this.toolStripMenuItem_2, this.toolStripMenuItem_5, this.checkCookieToolStripMenuItem, this.backupToolStripMenuItem, this.toolStripMenuItem_23, this.toolStripMenuItem_8,
			this.toolStripMenuItem_14, this.toolStripMenuItem_16, this.toolStripMenuItem_24
		});
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(133, 290);
		this.toolStripMenuItem_0.Name = "chọnLiveToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_7.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_1.Name = "mởTrìnhDuyệtToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(132, 22);
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_2.Name = "xóaTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_5.Name = "chuyểnThưMụcToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(132, 22);
		this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
		this.checkCookieToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
		this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
		this.backupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_23.Name = "mởCheckpointToolStripMenuItem";
		this.toolStripMenuItem_23.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_8.Name = "thêmVàoThưMụcToolStripMenuItem";
		this.toolStripMenuItem_8.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_14.Name = "tảiLạiDanhSáchToolStripMenuItem";
		this.toolStripMenuItem_14.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_16.Name = "cậpNhậtDữLiệuToolStripMenuItem";
		this.toolStripMenuItem_16.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_24.Name = "chứcNăngToolStripMenuItem1";
		this.toolStripMenuItem_24.Size = new System.Drawing.Size(132, 22);
		this.toolStripMenuItem_24.Text = "Chức năng";
		this.toolStripMenuItem_24.Click += new System.EventHandler(toolStripMenuItem_24_Click);
		this.toolStripMenuItem_6.Name = "tấtCảToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(32, 19);
		this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
		this.liveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.dieToolStripMenuItem.Name = "dieToolStripMenuItem";
		this.dieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.checkpointToolStripMenuItem.Name = "checkpointToolStripMenuItem";
		this.checkpointToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
		this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_10.Name = "đăngNhậpProfileToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem1.Name = "cookieToolStripMenuItem1";
		this.cookieToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem1.Name = "uidPassToolStripMenuItem1";
		this.uidPassToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_11.Name = "đăngNhậpTrìnhDuyệtMớiToolStripMenuItem";
		this.toolStripMenuItem_11.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem2.Name = "cookieToolStripMenuItem2";
		this.cookieToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem2.Name = "uidPassToolStripMenuItem2";
		this.uidPassToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		this.tokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		this.cookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		this.uidToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.passToolStripMenuItem.Name = "passToolStripMenuItem";
		this.passToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
		this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_3.Name = "danhSáchChọnToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_4.Name = "danhSáchKhôngChọnToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_9.Name = "giữNguyênỞThưMụcCũToolStripMenuItem";
		this.toolStripMenuItem_9.Size = new System.Drawing.Size(32, 19);
		this.mnsCutAccount.Name = "mnsCutAccount";
		this.mnsCutAccount.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_15.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_12.Name = "kiểmTraCookieToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_13.Name = "kiểmTraTokenToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new System.Drawing.Size(32, 19);
		this.backupTokenToolStripMenuItem.Name = "backupTokenToolStripMenuItem";
		this.backupTokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.backupCookieToolStripMenuItem.Name = "backupCookieToolStripMenuItem";
		this.backupCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.backupCookieTrungGianToolStripMenuItem.Name = "backupCookieTrungGianToolStripMenuItem";
		this.backupCookieTrungGianToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_17.Name = "mậtKhẩuToolStripMenuItem1";
		this.toolStripMenuItem_17.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_18.Name = "nhậpDữLiệuToolStripMenuItem";
		this.toolStripMenuItem_18.Size = new System.Drawing.Size(32, 19);
		this.tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
		this.tokenToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_19.Name = "tựĐộngLấyToolStripMenuItem1";
		this.toolStripMenuItem_19.Size = new System.Drawing.Size(32, 19);
		this.tokenBussinessToolStripMenuItem.Name = "tokenBussinessToolStripMenuItem";
		this.tokenBussinessToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.tokenInstagramToolStripMenuItem1.Name = "tokenInstagramToolStripMenuItem1";
		this.tokenInstagramToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.tokenIosToolStripMenuItem.Name = "tokenIosToolStripMenuItem";
		this.tokenIosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
		this.tokenAndroidToolStripMenuItem1.Name = "tokenAndroidToolStripMenuItem1";
		this.tokenAndroidToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_20.Name = "nhậpDữLiệuToolStripMenuItem2";
		this.toolStripMenuItem_20.Size = new System.Drawing.Size(32, 19);
		this.cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
		this.cookieToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_21.Name = "tựĐộngLấyToolStripMenuItem";
		this.toolStripMenuItem_21.Size = new System.Drawing.Size(32, 19);
		this.toolStripMenuItem_22.Name = "nhậpDữLiệuToolStripMenuItem1";
		this.toolStripMenuItem_22.Size = new System.Drawing.Size(32, 19);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 7);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(253, 16);
		this.bunifuCustomLabel1.TabIndex = 7;
		this.bunifuCustomLabel1.Text = "Cấu hình chức năng thay đô\u0309i thông tin";
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(662, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(6, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 16;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(630, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 13;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnCancel_Click);
		this.groupBox3.BackColor = System.Drawing.Color.White;
		this.groupBox3.Controls.Add(this.ckbLogOut2);
		this.groupBox3.Controls.Add(this.ckbXoaThietBiTinCay);
		this.groupBox3.Controls.Add(this.ckbXoaMailCu2);
		this.groupBox3.Controls.Add(this.ckbAnMailAll);
		this.groupBox3.Controls.Add(this.plRemoveMail);
		this.groupBox3.Controls.Add(this.plRemovePhone);
		this.groupBox3.Controls.Add(this.panel5);
		this.groupBox3.Controls.Add(this.ckbGioiTinh);
		this.groupBox3.Controls.Add(this.plAvatar);
		this.groupBox3.Controls.Add(this.plDoiMail);
		this.groupBox3.Controls.Add(this.ckbAddMail);
		this.groupBox3.Controls.Add(this.txtPhone);
		this.groupBox3.Controls.Add(this.panel1);
		this.groupBox3.Controls.Add(this.panel3);
		this.groupBox3.Controls.Add(this.pl2fa);
		this.groupBox3.Controls.Add(this.plDoiMatKhau);
		this.groupBox3.Controls.Add(this.plDoiAnhBia);
		this.groupBox3.Controls.Add(this.ckbThemMoTa);
		this.groupBox3.Controls.Add(this.btnThemMoTa);
		this.groupBox3.Controls.Add(this.ckbDoiNgaySinh);
		this.groupBox3.Controls.Add(this.ckb2fa);
		this.groupBox3.Controls.Add(this.ckbXoaSdt);
		this.groupBox3.Controls.Add(this.ckbLogOut);
		this.groupBox3.Controls.Add(this.ckbDoiPass);
		this.groupBox3.Controls.Add(this.ckbCapNhatThongTin);
		this.groupBox3.Controls.Add(this.ckbDoiTen);
		this.groupBox3.Controls.Add(this.ckbDoiAnhBia);
		this.groupBox3.Controls.Add(this.ckbAddPhone);
		this.groupBox3.Controls.Add(this.ckbAutoDeleteFile);
		this.groupBox3.Controls.Add(this.ckbDoiAvatar);
		this.groupBox3.Controls.Add(this.plDoiTen);
		this.groupBox3.Controls.Add(this.ckbDoiNgonNgu);
		this.groupBox3.Controls.Add(this.cbbNgonNgu);
		this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox3.Location = new System.Drawing.Point(6, 153);
		this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox3.Size = new System.Drawing.Size(647, 640);
		this.groupBox3.TabIndex = 18;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Tu\u0300y cho\u0323n";
		this.groupBox3.Enter += new System.EventHandler(groupBox3_Enter);
		this.plVerify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVerify.Controls.Add(this.rbMailTuNhap);
		this.plVerify.Controls.Add(this.button1);
		this.plVerify.Location = new System.Drawing.Point(614, 822);
		this.plVerify.Name = "plVerify";
		this.plVerify.Size = new System.Drawing.Size(273, 30);
		this.plVerify.TabIndex = 175;
		this.plVerify.Visible = false;
		this.rbMailTuNhap.AutoSize = true;
		this.rbMailTuNhap.Checked = true;
		this.rbMailTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbMailTuNhap.Location = new System.Drawing.Point(3, 4);
		this.rbMailTuNhap.Name = "rbMailTuNhap";
		this.rbMailTuNhap.Size = new System.Drawing.Size(101, 20);
		this.rbMailTuNhap.TabIndex = 163;
		this.rbMailTuNhap.TabStop = true;
		this.rbMailTuNhap.Text = "Mail tự nhập:";
		this.rbMailTuNhap.UseVisualStyleBackColor = true;
		this.rbMailTuNhap.CheckedChanged += new System.EventHandler(rbMailTuNhap_CheckedChanged);
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.Black;
		this.button1.Location = new System.Drawing.Point(105, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(106, 27);
		this.button1.TabIndex = 95;
		this.button1.Text = "Nhập mail|pass";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.ckbLogOut2.AutoSize = true;
		this.ckbLogOut2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOut2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLogOut2.Location = new System.Drawing.Point(335, 579);
		this.ckbLogOut2.Name = "ckbLogOut2";
		this.ckbLogOut2.Size = new System.Drawing.Size(64, 20);
		this.ckbLogOut2.TabIndex = 175;
		this.ckbLogOut2.Text = "Logout";
		this.ckbLogOut2.UseVisualStyleBackColor = true;
		this.ckbLogOut2.Visible = false;
		this.ckbXoaThietBiTinCay.AutoSize = true;
		this.ckbXoaThietBiTinCay.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaThietBiTinCay.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbXoaThietBiTinCay.Location = new System.Drawing.Point(16, 525);
		this.ckbXoaThietBiTinCay.Name = "ckbXoaThietBiTinCay";
		this.ckbXoaThietBiTinCay.Size = new System.Drawing.Size(132, 20);
		this.ckbXoaThietBiTinCay.TabIndex = 174;
		this.ckbXoaThietBiTinCay.Text = "Xóa thiết bị tin cậy";
		this.ckbXoaThietBiTinCay.UseVisualStyleBackColor = true;
		this.ckbXoaMailCu2.AutoSize = true;
		this.ckbXoaMailCu2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaMailCu2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbXoaMailCu2.Location = new System.Drawing.Point(335, 249);
		this.ckbXoaMailCu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbXoaMailCu2.Name = "ckbXoaMailCu2";
		this.ckbXoaMailCu2.Size = new System.Drawing.Size(116, 20);
		this.ckbXoaMailCu2.TabIndex = 173;
		this.ckbXoaMailCu2.Text = "Xóa các mail cũ";
		this.ckbXoaMailCu2.UseVisualStyleBackColor = true;
		this.ckbXoaMailCu2.CheckedChanged += new System.EventHandler(ckbXoaMailCu2_CheckedChanged);
		this.ckbAnMailAll.AutoSize = true;
		this.ckbAnMailAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAnMailAll.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAnMailAll.Location = new System.Drawing.Point(335, 221);
		this.ckbAnMailAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbAnMailAll.Name = "ckbAnMailAll";
		this.ckbAnMailAll.Size = new System.Drawing.Size(69, 20);
		this.ckbAnMailAll.TabIndex = 172;
		this.ckbAnMailAll.Text = "Â\u0309n mail";
		this.ckbAnMailAll.UseVisualStyleBackColor = true;
		this.ckbAnMailAll.CheckedChanged += new System.EventHandler(ckbAnMailAll_CheckedChanged);
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.rbNu);
		this.panel5.Controls.Add(this.rbNam);
		this.panel5.Location = new System.Drawing.Point(146, 499);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(121, 22);
		this.panel5.TabIndex = 167;
		this.rbNu.AutoSize = true;
		this.rbNu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNu.Location = new System.Drawing.Point(67, 0);
		this.rbNu.Name = "rbNu";
		this.rbNu.Size = new System.Drawing.Size(41, 20);
		this.rbNu.TabIndex = 1;
		this.rbNu.TabStop = true;
		this.rbNu.Text = "Nữ";
		this.rbNu.UseVisualStyleBackColor = true;
		this.rbNam.AutoSize = true;
		this.rbNam.Checked = true;
		this.rbNam.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNam.Location = new System.Drawing.Point(3, 0);
		this.rbNam.Name = "rbNam";
		this.rbNam.Size = new System.Drawing.Size(51, 20);
		this.rbNam.TabIndex = 0;
		this.rbNam.TabStop = true;
		this.rbNam.Text = "Nam";
		this.rbNam.UseVisualStyleBackColor = true;
		this.ckbGioiTinh.AutoSize = true;
		this.ckbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75f);
		this.ckbGioiTinh.Location = new System.Drawing.Point(16, 498);
		this.ckbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbGioiTinh.Name = "ckbGioiTinh";
		this.ckbGioiTinh.Size = new System.Drawing.Size(98, 21);
		this.ckbGioiTinh.TabIndex = 166;
		this.ckbGioiTinh.Text = "Đổi giới tính";
		this.ckbGioiTinh.UseVisualStyleBackColor = true;
		this.ckbGioiTinh.CheckedChanged += new System.EventHandler(ckbGioiTinh_CheckedChanged);
		this.plAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAvatar.Controls.Add(this.ckbAvatarThuTu);
		this.plAvatar.Controls.Add(this.label16);
		this.plAvatar.Controls.Add(this.txtPathAvatar);
		this.plAvatar.Location = new System.Drawing.Point(38, 107);
		this.plAvatar.Name = "plAvatar";
		this.plAvatar.Size = new System.Drawing.Size(270, 53);
		this.plAvatar.TabIndex = 165;
		this.ckbAvatarThuTu.AutoSize = true;
		this.ckbAvatarThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAvatarThuTu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAvatarThuTu.Location = new System.Drawing.Point(3, 31);
		this.ckbAvatarThuTu.Name = "ckbAvatarThuTu";
		this.ckbAvatarThuTu.Size = new System.Drawing.Size(138, 20);
		this.ckbAvatarThuTu.TabIndex = 161;
		this.ckbAvatarThuTu.Text = "Lấy ảnh theo thứ tự";
		this.ckbAvatarThuTu.UseVisualStyleBackColor = true;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(2, 7);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(100, 16);
		this.label16.TabIndex = 160;
		this.label16.Text = "Đường dẫn ảnh:";
		this.txtPathAvatar.CustomButton.Image = null;
		this.txtPathAvatar.CustomButton.Location = new System.Drawing.Point(139, 1);
		this.txtPathAvatar.CustomButton.Name = "";
		this.txtPathAvatar.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtPathAvatar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtPathAvatar.CustomButton.TabIndex = 1;
		this.txtPathAvatar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtPathAvatar.CustomButton.UseSelectable = true;
		this.txtPathAvatar.CustomButton.Visible = false;
		this.txtPathAvatar.Lines = new string[0];
		this.txtPathAvatar.Location = new System.Drawing.Point(104, 3);
		this.txtPathAvatar.MaxLength = 32767;
		this.txtPathAvatar.Name = "txtPathAvatar";
		this.txtPathAvatar.PasswordChar = '\0';
		this.txtPathAvatar.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtPathAvatar.SelectedText = "";
		this.txtPathAvatar.SelectionLength = 0;
		this.txtPathAvatar.SelectionStart = 0;
		this.txtPathAvatar.ShortcutsEnabled = true;
		this.txtPathAvatar.Size = new System.Drawing.Size(161, 23);
		this.txtPathAvatar.TabIndex = 159;
		this.txtPathAvatar.UseSelectable = true;
		this.txtPathAvatar.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtPathAvatar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
		this.ckbVerify.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.ckbVerify.AutoSize = true;
		this.ckbVerify.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVerify.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbVerify.Location = new System.Drawing.Point(591, 799);
		this.ckbVerify.Name = "ckbVerify";
		this.ckbVerify.Size = new System.Drawing.Size(108, 20);
		this.ckbVerify.TabIndex = 164;
		this.ckbVerify.Text = "Verify Account";
		this.ckbVerify.UseVisualStyleBackColor = true;
		this.ckbVerify.Visible = false;
		this.ckbVerify.CheckedChanged += new System.EventHandler(ckbVerify_CheckedChanged);
		this.plDoiMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDoiMail.Controls.Add(this.plPassMailHacked);
		this.plDoiMail.Controls.Add(this.ckbAddMailLinkHacked);
		this.plDoiMail.Controls.Add(this.ckbMailVip);
		this.plDoiMail.Controls.Add(this.ckbCloseChrome);
		this.plDoiMail.Controls.Add(this.label15);
		this.plDoiMail.Controls.Add(this.btnNhapHotmail);
		this.plDoiMail.Enabled = false;
		this.plDoiMail.Location = new System.Drawing.Point(365, 44);
		this.plDoiMail.Name = "plDoiMail";
		this.plDoiMail.Size = new System.Drawing.Size(273, 171);
		this.plDoiMail.TabIndex = 161;
		this.plDoiMail.Paint += new System.Windows.Forms.PaintEventHandler(plDoiMail_Paint);
		this.plPassMailHacked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plPassMailHacked.Controls.Add(this.txtPassMailHacked);
		this.plPassMailHacked.Controls.Add(this.label18);
		this.plPassMailHacked.Controls.Add(this.ckbRandomPassMailHacked);
		this.plPassMailHacked.Location = new System.Drawing.Point(24, 113);
		this.plPassMailHacked.Name = "plPassMailHacked";
		this.plPassMailHacked.Size = new System.Drawing.Size(242, 51);
		this.plPassMailHacked.TabIndex = 147;
		this.txtPassMailHacked.CustomButton.Image = null;
		this.txtPassMailHacked.CustomButton.Location = new System.Drawing.Point(117, 1);
		this.txtPassMailHacked.CustomButton.Name = "";
		this.txtPassMailHacked.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtPassMailHacked.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtPassMailHacked.CustomButton.TabIndex = 1;
		this.txtPassMailHacked.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtPassMailHacked.CustomButton.UseSelectable = true;
		this.txtPassMailHacked.CustomButton.Visible = false;
		this.txtPassMailHacked.Lines = new string[0];
		this.txtPassMailHacked.Location = new System.Drawing.Point(98, 3);
		this.txtPassMailHacked.MaxLength = 32767;
		this.txtPassMailHacked.Name = "txtPassMailHacked";
		this.txtPassMailHacked.PasswordChar = '\0';
		this.txtPassMailHacked.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtPassMailHacked.SelectedText = "";
		this.txtPassMailHacked.SelectionLength = 0;
		this.txtPassMailHacked.SelectionStart = 0;
		this.txtPassMailHacked.ShortcutsEnabled = true;
		this.txtPassMailHacked.Size = new System.Drawing.Size(139, 23);
		this.txtPassMailHacked.TabIndex = 160;
		this.txtPassMailHacked.UseSelectable = true;
		this.txtPassMailHacked.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtPassMailHacked.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(6, 5);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(89, 16);
		this.label18.TabIndex = 128;
		this.label18.Text = "Mật khẩu mới:";
		this.ckbRandomPassMailHacked.AutoSize = true;
		this.ckbRandomPassMailHacked.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRandomPassMailHacked.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbRandomPassMailHacked.Location = new System.Drawing.Point(9, 27);
		this.ckbRandomPassMailHacked.Name = "ckbRandomPassMailHacked";
		this.ckbRandomPassMailHacked.Size = new System.Drawing.Size(73, 20);
		this.ckbRandomPassMailHacked.TabIndex = 115;
		this.ckbRandomPassMailHacked.Text = "Random";
		this.ckbRandomPassMailHacked.UseVisualStyleBackColor = true;
		this.ckbRandomPassMailHacked.CheckedChanged += new System.EventHandler(ckbRandomPassMailHacked_CheckedChanged);
		this.ckbAddMailLinkHacked.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.ckbAddMailLinkHacked.AutoSize = true;
		this.ckbAddMailLinkHacked.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddMailLinkHacked.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddMailLinkHacked.Location = new System.Drawing.Point(7, 86);
		this.ckbAddMailLinkHacked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbAddMailLinkHacked.Name = "ckbAddMailLinkHacked";
		this.ckbAddMailLinkHacked.Size = new System.Drawing.Size(122, 20);
		this.ckbAddMailLinkHacked.TabIndex = 173;
		this.ckbAddMailLinkHacked.Text = "Dùng link hacked";
		this.ckbAddMailLinkHacked.UseVisualStyleBackColor = true;
		this.ckbAddMailLinkHacked.CheckedChanged += new System.EventHandler(ckbAddMailLinkHacked_CheckedChanged);
		this.ckbMailVip.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.ckbMailVip.AutoSize = true;
		this.ckbMailVip.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMailVip.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMailVip.Location = new System.Drawing.Point(7, 33);
		this.ckbMailVip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbMailVip.Name = "ckbMailVip";
		this.ckbMailVip.Size = new System.Drawing.Size(96, 20);
		this.ckbMailVip.TabIndex = 143;
		this.ckbMailVip.Text = "Mail Domain";
		this.ckbMailVip.UseVisualStyleBackColor = true;
		this.ckbCloseChrome.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.ckbCloseChrome.AutoSize = true;
		this.ckbCloseChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCloseChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCloseChrome.Location = new System.Drawing.Point(7, 60);
		this.ckbCloseChrome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbCloseChrome.Name = "ckbCloseChrome";
		this.ckbCloseChrome.Size = new System.Drawing.Size(223, 20);
		this.ckbCloseChrome.TabIndex = 142;
		this.ckbCloseChrome.Text = "Đóng chrome khi add mail thất bại";
		this.ckbCloseChrome.UseVisualStyleBackColor = true;
		this.ckbCloseChrome.CheckedChanged += new System.EventHandler(ckbCloseChrome_CheckedChanged);
		this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(4, 8);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(131, 16);
		this.label15.TabIndex = 141;
		this.label15.Text = "Nhập danh sách mail:";
		this.btnNhapHotmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.btnNhapHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapHotmail.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnNhapHotmail.ForeColor = System.Drawing.Color.Black;
		this.btnNhapHotmail.Location = new System.Drawing.Point(136, 2);
		this.btnNhapHotmail.Name = "btnNhapHotmail";
		this.btnNhapHotmail.Size = new System.Drawing.Size(82, 27);
		this.btnNhapHotmail.TabIndex = 95;
		this.btnNhapHotmail.Text = "Nhập";
		this.btnNhapHotmail.UseVisualStyleBackColor = true;
		this.btnNhapHotmail.Click += new System.EventHandler(btnNhapHotmail_Click);
		this.ckbAddMail.AutoSize = true;
		this.ckbAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddMail.Location = new System.Drawing.Point(336, 23);
		this.ckbAddMail.Name = "ckbAddMail";
		this.ckbAddMail.Size = new System.Drawing.Size(280, 20);
		this.ckbAddMail.TabIndex = 160;
		this.ckbAddMail.Text = "Change mail (Thêm mail mới + Xóa mail cũ)";
		this.ckbAddMail.UseVisualStyleBackColor = true;
		this.ckbAddMail.CheckedChanged += new System.EventHandler(ckbAddMail_CheckedChanged);
		this.txtPhone.Location = new System.Drawing.Point(194, 54);
		this.txtPhone.Name = "txtPhone";
		this.txtPhone.Size = new System.Drawing.Size(114, 23);
		this.txtPhone.TabIndex = 158;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.nudNamFrom);
		this.panel1.Controls.Add(this.nudNamTo);
		this.panel1.Controls.Add(this.nudThangTo);
		this.panel1.Controls.Add(this.nudNgayTo);
		this.panel1.Controls.Add(this.nudThangFrom);
		this.panel1.Controls.Add(this.nudNgayFrom);
		this.panel1.Controls.Add(this.label13);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Location = new System.Drawing.Point(47, 318);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(263, 87);
		this.panel1.TabIndex = 157;
		this.nudNamFrom.Location = new System.Drawing.Point(78, 58);
		this.nudNamFrom.Maximum = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.nudNamFrom.Minimum = new decimal(new int[4] { 1900, 0, 0, 0 });
		this.nudNamFrom.Name = "nudNamFrom";
		this.nudNamFrom.Size = new System.Drawing.Size(50, 23);
		this.nudNamFrom.TabIndex = 2;
		this.nudNamFrom.Value = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.nudNamTo.Location = new System.Drawing.Point(166, 58);
		this.nudNamTo.Maximum = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.nudNamTo.Minimum = new decimal(new int[4] { 1900, 0, 0, 0 });
		this.nudNamTo.Name = "nudNamTo";
		this.nudNamTo.Size = new System.Drawing.Size(53, 23);
		this.nudNamTo.TabIndex = 2;
		this.nudNamTo.Value = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.nudThangTo.Location = new System.Drawing.Point(166, 31);
		this.nudThangTo.Maximum = new decimal(new int[4] { 12, 0, 0, 0 });
		this.nudThangTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThangTo.Name = "nudThangTo";
		this.nudThangTo.Size = new System.Drawing.Size(53, 23);
		this.nudThangTo.TabIndex = 2;
		this.nudThangTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudNgayTo.Location = new System.Drawing.Point(166, 4);
		this.nudNgayTo.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.nudNgayTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudNgayTo.Name = "nudNgayTo";
		this.nudNgayTo.Size = new System.Drawing.Size(53, 23);
		this.nudNgayTo.TabIndex = 2;
		this.nudNgayTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThangFrom.Location = new System.Drawing.Point(78, 31);
		this.nudThangFrom.Maximum = new decimal(new int[4] { 12, 0, 0, 0 });
		this.nudThangFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThangFrom.Name = "nudThangFrom";
		this.nudThangFrom.Size = new System.Drawing.Size(50, 23);
		this.nudThangFrom.TabIndex = 2;
		this.nudThangFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudNgayFrom.Location = new System.Drawing.Point(78, 4);
		this.nudNgayFrom.Maximum = new decimal(new int[4] { 31, 0, 0, 0 });
		this.nudNgayFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudNgayFrom.Name = "nudNgayFrom";
		this.nudNgayFrom.Size = new System.Drawing.Size(50, 23);
		this.nudNgayFrom.TabIndex = 2;
		this.nudNgayFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label13.Location = new System.Drawing.Point(133, 60);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 1;
		this.label13.Text = "đến";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.Location = new System.Drawing.Point(133, 33);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 1;
		this.label7.Text = "đến";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(133, 6);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 1;
		this.label3.Text = "đến";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label9.Location = new System.Drawing.Point(49, 60);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(25, 16);
		this.label9.TabIndex = 1;
		this.label9.Text = "từ";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.Location = new System.Drawing.Point(49, 33);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(25, 16);
		this.label6.TabIndex = 1;
		this.label6.Text = "từ";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.Location = new System.Drawing.Point(49, 6);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(25, 16);
		this.label2.TabIndex = 1;
		this.label2.Text = "từ";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 60);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(38, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "Năm:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(4, 33);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(48, 16);
		this.label5.TabIndex = 0;
		this.label5.Text = "Tháng:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(4, 6);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(40, 16);
		this.label1.TabIndex = 0;
		this.label1.Text = "Ngày:";
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.button4);
		this.panel3.Controls.Add(this.button3);
		this.panel3.Controls.Add(this.button9);
		this.panel3.Controls.Add(this.button5);
		this.panel3.Controls.Add(this.btnCapNhatThongTin);
		this.panel3.Location = new System.Drawing.Point(47, 433);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(268, 60);
		this.panel3.TabIndex = 157;
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.ForeColor = System.Drawing.Color.Black;
		this.button4.Location = new System.Drawing.Point(185, 1);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(80, 27);
		this.button4.TabIndex = 146;
		this.button4.Text = "Tha\u0300nh phô\u0301";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.Color.Black;
		this.button3.Location = new System.Drawing.Point(98, 1);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(83, 27);
		this.button3.TabIndex = 146;
		this.button3.Text = "Quê qua\u0301n";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.ForeColor = System.Drawing.Color.Black;
		this.button9.Location = new System.Drawing.Point(98, 30);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(96, 27);
		this.button9.TabIndex = 146;
		this.button9.Text = "Trươ\u0300ng THPT";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click);
		this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.ForeColor = System.Drawing.Color.Black;
		this.button5.Location = new System.Drawing.Point(3, 30);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(90, 27);
		this.button5.TabIndex = 146;
		this.button5.Text = "Trươ\u0300ng ĐH";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.btnCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCapNhatThongTin.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCapNhatThongTin.ForeColor = System.Drawing.Color.Black;
		this.btnCapNhatThongTin.Location = new System.Drawing.Point(3, 1);
		this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
		this.btnCapNhatThongTin.Size = new System.Drawing.Size(90, 27);
		this.btnCapNhatThongTin.TabIndex = 146;
		this.btnCapNhatThongTin.Text = "Nơi la\u0300m viê\u0323c";
		this.btnCapNhatThongTin.UseVisualStyleBackColor = true;
		this.btnCapNhatThongTin.Click += new System.EventHandler(btnCapNhatThongTin_Click);
		this.pl2fa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.pl2fa.Controls.Add(this.rbVip);
		this.pl2fa.Controls.Add(this.rdTat2fa);
		this.pl2fa.Controls.Add(this.rdBat2fa);
		this.pl2fa.Location = new System.Drawing.Point(365, 442);
		this.pl2fa.Name = "pl2fa";
		this.pl2fa.Size = new System.Drawing.Size(266, 27);
		this.pl2fa.TabIndex = 157;
		this.rbVip.AutoSize = true;
		this.rbVip.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbVip.Location = new System.Drawing.Point(217, 3);
		this.rbVip.Name = "rbVip";
		this.rbVip.Size = new System.Drawing.Size(43, 20);
		this.rbVip.TabIndex = 132;
		this.rbVip.Text = "Vip";
		this.rbVip.UseVisualStyleBackColor = true;
		this.rdTat2fa.AutoSize = true;
		this.rdTat2fa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTat2fa.Location = new System.Drawing.Point(104, 3);
		this.rdTat2fa.Name = "rdTat2fa";
		this.rdTat2fa.Size = new System.Drawing.Size(95, 20);
		this.rdTat2fa.TabIndex = 131;
		this.rdTat2fa.Text = "Tă\u0301t ba\u0309o mâ\u0323t";
		this.rdTat2fa.UseVisualStyleBackColor = true;
		this.rdBat2fa.AutoSize = true;
		this.rdBat2fa.Checked = true;
		this.rdBat2fa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdBat2fa.Location = new System.Drawing.Point(3, 3);
		this.rdBat2fa.Name = "rdBat2fa";
		this.rdBat2fa.Size = new System.Drawing.Size(94, 20);
		this.rdBat2fa.TabIndex = 131;
		this.rdBat2fa.TabStop = true;
		this.rdBat2fa.Text = "Bâ\u0323t ba\u0309o mâ\u0323t";
		this.rdBat2fa.UseVisualStyleBackColor = true;
		this.rdBat2fa.CheckedChanged += new System.EventHandler(rdPassTuNhap_CheckedChanged);
		this.plDoiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDoiMatKhau.Controls.Add(this.button2);
		this.plDoiMatKhau.Controls.Add(this.ckbChangePassLinkHacked);
		this.plDoiMatKhau.Controls.Add(this.btnNhapPass);
		this.plDoiMatKhau.Controls.Add(this.rdPassRandom);
		this.plDoiMatKhau.Controls.Add(this.rdPassTuNhap);
		this.plDoiMatKhau.Location = new System.Drawing.Point(364, 493);
		this.plDoiMatKhau.Name = "plDoiMatKhau";
		this.plDoiMatKhau.Size = new System.Drawing.Size(274, 80);
		this.plDoiMatKhau.TabIndex = 157;
		this.plDoiMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(plDoiMatKhau_Paint);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(199, 4);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(24, 24);
		this.button2.TabIndex = 150;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.ckbChangePassLinkHacked.AutoSize = true;
		this.ckbChangePassLinkHacked.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChangePassLinkHacked.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbChangePassLinkHacked.Location = new System.Drawing.Point(4, 55);
		this.ckbChangePassLinkHacked.Name = "ckbChangePassLinkHacked";
		this.ckbChangePassLinkHacked.Size = new System.Drawing.Size(122, 20);
		this.ckbChangePassLinkHacked.TabIndex = 149;
		this.ckbChangePassLinkHacked.Text = "Dùng link hacked";
		this.ckbChangePassLinkHacked.UseVisualStyleBackColor = true;
		this.btnNhapPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapPass.Location = new System.Drawing.Point(88, 3);
		this.btnNhapPass.Name = "btnNhapPass";
		this.btnNhapPass.Size = new System.Drawing.Size(105, 27);
		this.btnNhapPass.TabIndex = 124;
		this.btnNhapPass.Text = "Nhập mật khẩu";
		this.btnNhapPass.UseVisualStyleBackColor = true;
		this.btnNhapPass.Click += new System.EventHandler(btnNhapPass_Click);
		this.rdPassRandom.AutoSize = true;
		this.rdPassRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdPassRandom.Location = new System.Drawing.Point(4, 30);
		this.rdPassRandom.Name = "rdPassRandom";
		this.rdPassRandom.Size = new System.Drawing.Size(72, 20);
		this.rdPassRandom.TabIndex = 131;
		this.rdPassRandom.Text = "Random";
		this.rdPassRandom.UseVisualStyleBackColor = true;
		this.rdPassTuNhap.AutoSize = true;
		this.rdPassTuNhap.Checked = true;
		this.rdPassTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdPassTuNhap.Location = new System.Drawing.Point(3, 5);
		this.rdPassTuNhap.Name = "rdPassTuNhap";
		this.rdPassTuNhap.Size = new System.Drawing.Size(73, 20);
		this.rdPassTuNhap.TabIndex = 131;
		this.rdPassTuNhap.TabStop = true;
		this.rdPassTuNhap.Text = "Tư\u0323 nhâ\u0323p";
		this.rdPassTuNhap.UseVisualStyleBackColor = true;
		this.rdPassTuNhap.CheckedChanged += new System.EventHandler(rdPassTuNhap_CheckedChanged);
		this.plDoiAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDoiAnhBia.Controls.Add(this.ckbCoverThuTu);
		this.plDoiAnhBia.Controls.Add(this.txtPathCover);
		this.plDoiAnhBia.Controls.Add(this.rdAnhNguoiDungDat);
		this.plDoiAnhBia.Controls.Add(this.rdAnhNgheThuat);
		this.plDoiAnhBia.Location = new System.Drawing.Point(46, 188);
		this.plDoiAnhBia.Name = "plDoiAnhBia";
		this.plDoiAnhBia.Size = new System.Drawing.Size(262, 74);
		this.plDoiAnhBia.TabIndex = 154;
		this.ckbCoverThuTu.AutoSize = true;
		this.ckbCoverThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCoverThuTu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCoverThuTu.Location = new System.Drawing.Point(3, 52);
		this.ckbCoverThuTu.Name = "ckbCoverThuTu";
		this.ckbCoverThuTu.Size = new System.Drawing.Size(138, 20);
		this.ckbCoverThuTu.TabIndex = 162;
		this.ckbCoverThuTu.Text = "Lấy ảnh theo thứ tự";
		this.ckbCoverThuTu.UseVisualStyleBackColor = true;
		this.txtPathCover.CustomButton.Image = null;
		this.txtPathCover.CustomButton.Location = new System.Drawing.Point(115, 1);
		this.txtPathCover.CustomButton.Name = "";
		this.txtPathCover.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtPathCover.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtPathCover.CustomButton.TabIndex = 1;
		this.txtPathCover.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtPathCover.CustomButton.UseSelectable = true;
		this.txtPathCover.CustomButton.Visible = false;
		this.txtPathCover.Lines = new string[0];
		this.txtPathCover.Location = new System.Drawing.Point(120, 3);
		this.txtPathCover.MaxLength = 32767;
		this.txtPathCover.Name = "txtPathCover";
		this.txtPathCover.PasswordChar = '\0';
		this.txtPathCover.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtPathCover.SelectedText = "";
		this.txtPathCover.SelectionLength = 0;
		this.txtPathCover.SelectionStart = 0;
		this.txtPathCover.ShortcutsEnabled = true;
		this.txtPathCover.Size = new System.Drawing.Size(137, 23);
		this.txtPathCover.TabIndex = 159;
		this.txtPathCover.UseSelectable = true;
		this.txtPathCover.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtPathCover.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
		this.rdAnhNguoiDungDat.AutoSize = true;
		this.rdAnhNguoiDungDat.Checked = true;
		this.rdAnhNguoiDungDat.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdAnhNguoiDungDat.Location = new System.Drawing.Point(3, 4);
		this.rdAnhNguoiDungDat.Name = "rdAnhNguoiDungDat";
		this.rdAnhNguoiDungDat.Size = new System.Drawing.Size(118, 20);
		this.rdAnhNguoiDungDat.TabIndex = 131;
		this.rdAnhNguoiDungDat.TabStop = true;
		this.rdAnhNguoiDungDat.Text = "Đường dẫn ảnh:";
		this.rdAnhNguoiDungDat.UseVisualStyleBackColor = true;
		this.rdAnhNguoiDungDat.CheckedChanged += new System.EventHandler(rdAnhNguoiDungDat_CheckedChanged);
		this.rdAnhNgheThuat.AutoSize = true;
		this.rdAnhNgheThuat.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdAnhNgheThuat.Location = new System.Drawing.Point(3, 28);
		this.rdAnhNgheThuat.Name = "rdAnhNgheThuat";
		this.rdAnhNgheThuat.Size = new System.Drawing.Size(215, 20);
		this.rdAnhNgheThuat.TabIndex = 130;
		this.rdAnhNgheThuat.Text = "Ảnh bìa nghệ thuật của Facebook";
		this.rdAnhNgheThuat.UseVisualStyleBackColor = true;
		this.ckbThemMoTa.AutoSize = true;
		this.ckbThemMoTa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThemMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75f);
		this.ckbThemMoTa.Location = new System.Drawing.Point(16, 268);
		this.ckbThemMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbThemMoTa.Name = "ckbThemMoTa";
		this.ckbThemMoTa.Size = new System.Drawing.Size(148, 21);
		this.ckbThemMoTa.TabIndex = 155;
		this.ckbThemMoTa.Text = "Thêm tiểu sử (mô tả)";
		this.ckbThemMoTa.UseVisualStyleBackColor = true;
		this.ckbThemMoTa.CheckedChanged += new System.EventHandler(ckbThemMoTa_CheckedChanged);
		this.btnThemMoTa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnThemMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnThemMoTa.ForeColor = System.Drawing.Color.Black;
		this.btnThemMoTa.Location = new System.Drawing.Point(169, 265);
		this.btnThemMoTa.Name = "btnThemMoTa";
		this.btnThemMoTa.Size = new System.Drawing.Size(96, 27);
		this.btnThemMoTa.TabIndex = 147;
		this.btnThemMoTa.Text = "Nhập tiểu sử";
		this.btnThemMoTa.UseVisualStyleBackColor = true;
		this.btnThemMoTa.Click += new System.EventHandler(btnThemMoTa_Click);
		this.ckbDoiNgaySinh.AutoSize = true;
		this.ckbDoiNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiNgaySinh.Location = new System.Drawing.Point(16, 296);
		this.ckbDoiNgaySinh.Name = "ckbDoiNgaySinh";
		this.ckbDoiNgaySinh.Size = new System.Drawing.Size(103, 20);
		this.ckbDoiNgaySinh.TabIndex = 148;
		this.ckbDoiNgaySinh.Text = "Đổi ngày sinh";
		this.ckbDoiNgaySinh.UseVisualStyleBackColor = true;
		this.ckbDoiNgaySinh.CheckedChanged += new System.EventHandler(ckbDoiNgaySinh_CheckedChanged);
		this.ckb2fa.AutoSize = true;
		this.ckb2fa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckb2fa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckb2fa.Location = new System.Drawing.Point(335, 416);
		this.ckb2fa.Name = "ckb2fa";
		this.ckb2fa.Size = new System.Drawing.Size(141, 20);
		this.ckb2fa.TabIndex = 148;
		this.ckb2fa.Text = "Ba\u0309o mâ\u0323t 2 lơ\u0301p (2FA)";
		this.ckb2fa.UseVisualStyleBackColor = true;
		this.ckb2fa.CheckedChanged += new System.EventHandler(ckb2fa_CheckedChanged);
		this.ckbXoaSdt.AutoSize = true;
		this.ckbXoaSdt.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaSdt.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbXoaSdt.Location = new System.Drawing.Point(16, 551);
		this.ckbXoaSdt.Name = "ckbXoaSdt";
		this.ckbXoaSdt.Size = new System.Drawing.Size(175, 20);
		this.ckbXoaSdt.TabIndex = 148;
		this.ckbXoaSdt.Text = "Tự động xóa số điện thoại";
		this.ckbXoaSdt.UseVisualStyleBackColor = true;
		this.ckbXoaSdt.CheckedChanged += new System.EventHandler(ckbXoaSdt_CheckedChanged);
		this.ckbLogOut.AutoSize = true;
		this.ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOut.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLogOut.Location = new System.Drawing.Point(16, 605);
		this.ckbLogOut.Name = "ckbLogOut";
		this.ckbLogOut.Size = new System.Drawing.Size(166, 20);
		this.ckbLogOut.TabIndex = 148;
		this.ckbLogOut.Text = "Đăng xuất hết thiết bị cũ";
		this.ckbLogOut.UseVisualStyleBackColor = true;
		this.ckbDoiPass.AutoSize = true;
		this.ckbDoiPass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiPass.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiPass.Location = new System.Drawing.Point(335, 471);
		this.ckbDoiPass.Name = "ckbDoiPass";
		this.ckbDoiPass.Size = new System.Drawing.Size(102, 20);
		this.ckbDoiPass.TabIndex = 148;
		this.ckbDoiPass.Text = "Đổi mật khẩu";
		this.ckbDoiPass.UseVisualStyleBackColor = true;
		this.ckbDoiPass.CheckedChanged += new System.EventHandler(ckbDoiPass_CheckedChanged);
		this.ckbCapNhatThongTin.AutoSize = true;
		this.ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCapNhatThongTin.Font = new System.Drawing.Font("Segoe UI", 9.75f);
		this.ckbCapNhatThongTin.Location = new System.Drawing.Point(16, 409);
		this.ckbCapNhatThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
		this.ckbCapNhatThongTin.Size = new System.Drawing.Size(184, 21);
		this.ckbCapNhatThongTin.TabIndex = 156;
		this.ckbCapNhatThongTin.Text = "Cập nhật thông tin cá nhân";
		this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.CheckedChanged += new System.EventHandler(ckbCapNhatThongTin_CheckedChanged);
		this.ckbDoiTen.AutoSize = true;
		this.ckbDoiTen.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiTen.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiTen.Location = new System.Drawing.Point(335, 283);
		this.ckbDoiTen.Name = "ckbDoiTen";
		this.ckbDoiTen.Size = new System.Drawing.Size(67, 20);
		this.ckbDoiTen.TabIndex = 149;
		this.ckbDoiTen.Text = "Đổi tên";
		this.ckbDoiTen.UseVisualStyleBackColor = true;
		this.ckbDoiTen.CheckedChanged += new System.EventHandler(ckbDoiTen_CheckedChanged);
		this.ckbDoiAnhBia.AutoSize = true;
		this.ckbDoiAnhBia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiAnhBia.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiAnhBia.Location = new System.Drawing.Point(16, 166);
		this.ckbDoiAnhBia.Name = "ckbDoiAnhBia";
		this.ckbDoiAnhBia.Size = new System.Drawing.Size(91, 20);
		this.ckbDoiAnhBia.TabIndex = 150;
		this.ckbDoiAnhBia.Text = "Đổi ảnh bìa";
		this.ckbDoiAnhBia.UseVisualStyleBackColor = true;
		this.ckbDoiAnhBia.CheckedChanged += new System.EventHandler(ckbDoiAnhBia_CheckedChanged);
		this.ckbAddPhone.AutoSize = true;
		this.ckbAddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddPhone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddPhone.Location = new System.Drawing.Point(16, 55);
		this.ckbAddPhone.Name = "ckbAddPhone";
		this.ckbAddPhone.Size = new System.Drawing.Size(183, 20);
		this.ckbAddPhone.TabIndex = 151;
		this.ckbAddPhone.Text = "Thêm sđt (không xa\u0301c minh)";
		this.ckbAddPhone.UseVisualStyleBackColor = true;
		this.ckbAddPhone.CheckedChanged += new System.EventHandler(ckbAddPhone_CheckedChanged);
		this.ckbAutoDeleteFile.AutoSize = true;
		this.ckbAutoDeleteFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteFile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAutoDeleteFile.Location = new System.Drawing.Point(135, 168);
		this.ckbAutoDeleteFile.Name = "ckbAutoDeleteFile";
		this.ckbAutoDeleteFile.Size = new System.Drawing.Size(172, 20);
		this.ckbAutoDeleteFile.TabIndex = 151;
		this.ckbAutoDeleteFile.Text = "Tự động xóa File đã dùng";
		this.ckbAutoDeleteFile.UseVisualStyleBackColor = true;
		this.ckbAutoDeleteFile.Visible = false;
		this.ckbDoiAvatar.AutoSize = true;
		this.ckbDoiAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiAvatar.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiAvatar.Location = new System.Drawing.Point(16, 81);
		this.ckbDoiAvatar.Name = "ckbDoiAvatar";
		this.ckbDoiAvatar.Size = new System.Drawing.Size(85, 20);
		this.ckbDoiAvatar.TabIndex = 151;
		this.ckbDoiAvatar.Text = "Đổi avatar";
		this.ckbDoiAvatar.UseVisualStyleBackColor = true;
		this.ckbDoiAvatar.CheckedChanged += new System.EventHandler(ckbDoiAvatar_CheckedChanged);
		this.plDoiTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDoiTen.Controls.Add(this.plTenTuDat);
		this.plDoiTen.Controls.Add(this.rdTenTuDat);
		this.plDoiTen.Controls.Add(this.rdTenRandom);
		this.plDoiTen.Controls.Add(this.plTenNgauNhien);
		this.plDoiTen.Location = new System.Drawing.Point(365, 305);
		this.plDoiTen.Name = "plDoiTen";
		this.plDoiTen.Size = new System.Drawing.Size(273, 109);
		this.plDoiTen.TabIndex = 153;
		this.plTenTuDat.Controls.Add(this.button8);
		this.plTenTuDat.Controls.Add(this.button7);
		this.plTenTuDat.Controls.Add(this.button6);
		this.plTenTuDat.Location = new System.Drawing.Point(23, 27);
		this.plTenTuDat.Name = "plTenTuDat";
		this.plTenTuDat.Size = new System.Drawing.Size(244, 27);
		this.plTenTuDat.TabIndex = 119;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Location = new System.Drawing.Point(175, 0);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(67, 27);
		this.button8.TabIndex = 124;
		this.button8.Text = "Nhập tên";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button7.Location = new System.Drawing.Point(73, 0);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(96, 27);
		this.button7.TabIndex = 124;
		this.button7.Text = "Nhập tên đệm";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(button7_Click);
		this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button6.Location = new System.Drawing.Point(4, 0);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(63, 27);
		this.button6.TabIndex = 124;
		this.button6.Text = "Nhập họ";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(button6_Click);
		this.rdTenTuDat.AutoSize = true;
		this.rdTenTuDat.Checked = true;
		this.rdTenTuDat.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenTuDat.Location = new System.Drawing.Point(3, 4);
		this.rdTenTuDat.Name = "rdTenTuDat";
		this.rdTenTuDat.Size = new System.Drawing.Size(155, 20);
		this.rdTenTuDat.TabIndex = 131;
		this.rdTenTuDat.TabStop = true;
		this.rdTenTuDat.Text = "Tên do người dùng đặt";
		this.rdTenTuDat.UseVisualStyleBackColor = true;
		this.rdTenTuDat.CheckedChanged += new System.EventHandler(rdTenTuDat_CheckedChanged);
		this.rdTenRandom.AutoSize = true;
		this.rdTenRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenRandom.Location = new System.Drawing.Point(3, 55);
		this.rdTenRandom.Name = "rdTenRandom";
		this.rdTenRandom.Size = new System.Drawing.Size(114, 20);
		this.rdTenRandom.TabIndex = 130;
		this.rdTenRandom.Text = "Tên ngẫu nhiên";
		this.rdTenRandom.UseVisualStyleBackColor = true;
		this.rdTenRandom.CheckedChanged += new System.EventHandler(rdTenRandom_CheckedChanged);
		this.plTenNgauNhien.Controls.Add(this.rdTenRandomNgoai);
		this.plTenNgauNhien.Controls.Add(this.rdTenRandomViet);
		this.plTenNgauNhien.Location = new System.Drawing.Point(23, 77);
		this.plTenNgauNhien.Name = "plTenNgauNhien";
		this.plTenNgauNhien.Size = new System.Drawing.Size(195, 27);
		this.plTenNgauNhien.TabIndex = 135;
		this.rdTenRandomNgoai.AutoSize = true;
		this.rdTenRandomNgoai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenRandomNgoai.Location = new System.Drawing.Point(83, 3);
		this.rdTenRandomNgoai.Name = "rdTenRandomNgoai";
		this.rdTenRandomNgoai.Size = new System.Drawing.Size(82, 20);
		this.rdTenRandomNgoai.TabIndex = 134;
		this.rdTenRandomNgoai.Text = "Tên ngoại";
		this.rdTenRandomNgoai.UseVisualStyleBackColor = true;
		this.rdTenRandomViet.AutoSize = true;
		this.rdTenRandomViet.Checked = true;
		this.rdTenRandomViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenRandomViet.Location = new System.Drawing.Point(5, 3);
		this.rdTenRandomViet.Name = "rdTenRandomViet";
		this.rdTenRandomViet.Size = new System.Drawing.Size(71, 20);
		this.rdTenRandomViet.TabIndex = 134;
		this.rdTenRandomViet.TabStop = true;
		this.rdTenRandomViet.Text = "Tên việt";
		this.rdTenRandomViet.UseVisualStyleBackColor = true;
		this.ckbDoiNgonNgu.AutoSize = true;
		this.ckbDoiNgonNgu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiNgonNgu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbDoiNgonNgu.Location = new System.Drawing.Point(16, 26);
		this.ckbDoiNgonNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ckbDoiNgonNgu.Name = "ckbDoiNgonNgu";
		this.ckbDoiNgonNgu.Size = new System.Drawing.Size(103, 20);
		this.ckbDoiNgonNgu.TabIndex = 142;
		this.ckbDoiNgonNgu.Text = "Đổi ngôn ngữ";
		this.ckbDoiNgonNgu.UseVisualStyleBackColor = true;
		this.ckbDoiNgonNgu.CheckedChanged += new System.EventHandler(ckbDoiNgonNgu_CheckedChanged);
		this.cbbNgonNgu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbNgonNgu.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.cbbNgonNgu.ForeColor = System.Drawing.Color.Black;
		this.cbbNgonNgu.FormattingEnabled = true;
		this.cbbNgonNgu.Location = new System.Drawing.Point(126, 24);
		this.cbbNgonNgu.Name = "cbbNgonNgu";
		this.cbbNgonNgu.Size = new System.Drawing.Size(182, 24);
		this.cbbNgonNgu.TabIndex = 143;
		this.plXoaMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plXoaMail.Controls.Add(this.plXoaMailLinkHacked);
		this.plXoaMail.Controls.Add(this.rdXoaTrucTiep);
		this.plXoaMail.Controls.Add(this.rdXoaLinkHacked);
		this.plXoaMail.Enabled = false;
		this.plXoaMail.Location = new System.Drawing.Point(707, 393);
		this.plXoaMail.Name = "plXoaMail";
		this.plXoaMail.Size = new System.Drawing.Size(274, 75);
		this.plXoaMail.TabIndex = 164;
		this.plXoaMail.Visible = false;
		this.plXoaMailLinkHacked.Controls.Add(this.lblNewPass1);
		this.plXoaMailLinkHacked.Controls.Add(this.ckbPassRandomXoaMail);
		this.plXoaMailLinkHacked.Controls.Add(this.btnNhapPassXoaMail);
		this.plXoaMailLinkHacked.Location = new System.Drawing.Point(15, 43);
		this.plXoaMailLinkHacked.Name = "plXoaMailLinkHacked";
		this.plXoaMailLinkHacked.Size = new System.Drawing.Size(252, 27);
		this.plXoaMailLinkHacked.TabIndex = 146;
		this.lblNewPass1.AutoSize = true;
		this.lblNewPass1.Location = new System.Drawing.Point(10, 5);
		this.lblNewPass1.Name = "lblNewPass1";
		this.lblNewPass1.Size = new System.Drawing.Size(89, 16);
		this.lblNewPass1.TabIndex = 128;
		this.lblNewPass1.Text = "Mật khẩu mới:";
		this.ckbPassRandomXoaMail.AutoSize = true;
		this.ckbPassRandomXoaMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbPassRandomXoaMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbPassRandomXoaMail.Location = new System.Drawing.Point(100, 4);
		this.ckbPassRandomXoaMail.Name = "ckbPassRandomXoaMail";
		this.ckbPassRandomXoaMail.Size = new System.Drawing.Size(73, 20);
		this.ckbPassRandomXoaMail.TabIndex = 115;
		this.ckbPassRandomXoaMail.Text = "Random";
		this.ckbPassRandomXoaMail.UseVisualStyleBackColor = true;
		this.ckbPassRandomXoaMail.CheckedChanged += new System.EventHandler(ckbPassRandomXoaMail_CheckedChanged);
		this.btnNhapPassXoaMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapPassXoaMail.Location = new System.Drawing.Point(174, 0);
		this.btnNhapPassXoaMail.Name = "btnNhapPassXoaMail";
		this.btnNhapPassXoaMail.Size = new System.Drawing.Size(62, 27);
		this.btnNhapPassXoaMail.TabIndex = 124;
		this.btnNhapPassXoaMail.Text = "Nhập";
		this.btnNhapPassXoaMail.UseVisualStyleBackColor = true;
		this.btnNhapPassXoaMail.Click += new System.EventHandler(btnNhapPassXoaMail_Click);
		this.rdXoaTrucTiep.AutoSize = true;
		this.rdXoaTrucTiep.Checked = true;
		this.rdXoaTrucTiep.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdXoaTrucTiep.Location = new System.Drawing.Point(3, 1);
		this.rdXoaTrucTiep.Name = "rdXoaTrucTiep";
		this.rdXoaTrucTiep.Size = new System.Drawing.Size(99, 20);
		this.rdXoaTrucTiep.TabIndex = 131;
		this.rdXoaTrucTiep.TabStop = true;
		this.rdXoaTrucTiep.Text = "Xóa trực tiếp";
		this.rdXoaTrucTiep.UseVisualStyleBackColor = true;
		this.rdXoaLinkHacked.AutoSize = true;
		this.rdXoaLinkHacked.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdXoaLinkHacked.Location = new System.Drawing.Point(3, 22);
		this.rdXoaLinkHacked.Name = "rdXoaLinkHacked";
		this.rdXoaLinkHacked.Size = new System.Drawing.Size(146, 20);
		this.rdXoaLinkHacked.TabIndex = 130;
		this.rdXoaLinkHacked.Text = "Xóa bằng link hacked";
		this.rdXoaLinkHacked.UseVisualStyleBackColor = true;
		this.rdXoaLinkHacked.CheckedChanged += new System.EventHandler(rdXoaLinkHacked_CheckedChanged);
		this.ckbXoaMail.AutoSize = true;
		this.ckbXoaMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaMail.Enabled = false;
		this.ckbXoaMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbXoaMail.Location = new System.Drawing.Point(676, 371);
		this.ckbXoaMail.Name = "ckbXoaMail";
		this.ckbXoaMail.Size = new System.Drawing.Size(147, 20);
		this.ckbXoaMail.TabIndex = 163;
		this.ckbXoaMail.Text = "Chỉ xóa mail (sắp có)";
		this.ckbXoaMail.UseVisualStyleBackColor = true;
		this.ckbXoaMail.Visible = false;
		this.ckbXoaMail.CheckedChanged += new System.EventHandler(ckbXoaMail_CheckedChanged);
		this.groupBox5.BackColor = System.Drawing.Color.White;
		this.groupBox5.Controls.Add(this.panel7);
		this.groupBox5.Controls.Add(this.label17);
		this.groupBox5.Controls.Add(this.label14);
		this.groupBox5.Controls.Add(this.panel4);
		this.groupBox5.Controls.Add(this.metroButton1);
		this.groupBox5.Controls.Add(this.label12);
		this.groupBox5.Controls.Add(this.label10);
		this.groupBox5.Controls.Add(this.nudThread);
		this.groupBox5.Controls.Add(this.label11);
		this.groupBox5.Controls.Add(this.label4);
		this.groupBox5.Controls.Add(this.ckbCreateProfile);
		this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox5.Location = new System.Drawing.Point(7, 42);
		this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox5.Size = new System.Drawing.Size(647, 104);
		this.groupBox5.TabIndex = 20;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Cấu hình chung";
		this.groupBox5.Enter += new System.EventHandler(groupBox5_Enter);
		this.panel7.Controls.Add(this.rbLoginVia);
		this.panel7.Controls.Add(this.rbLoginMbasic);
		this.panel7.Controls.Add(this.rbLoginWWW);
		this.panel7.Controls.Add(this.rbLoginMFB);
		this.panel7.Location = new System.Drawing.Point(147, 74);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(294, 26);
		this.panel7.TabIndex = 150;
		this.rbLoginVia.AutoSize = true;
		this.rbLoginVia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginVia.Location = new System.Drawing.Point(201, 3);
		this.rbLoginVia.Name = "rbLoginVia";
		this.rbLoginVia.Size = new System.Drawing.Size(80, 20);
		this.rbLoginVia.TabIndex = 4;
		this.rbLoginVia.Text = "www->m";
		this.rbLoginVia.UseVisualStyleBackColor = true;
		this.rbLoginMbasic.AutoSize = true;
		this.rbLoginMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginMbasic.Location = new System.Drawing.Point(130, 3);
		this.rbLoginMbasic.Name = "rbLoginMbasic";
		this.rbLoginMbasic.Size = new System.Drawing.Size(65, 20);
		this.rbLoginMbasic.TabIndex = 4;
		this.rbLoginMbasic.Text = "mbasic";
		this.rbLoginMbasic.UseVisualStyleBackColor = true;
		this.rbLoginWWW.AutoSize = true;
		this.rbLoginWWW.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLoginWWW.Location = new System.Drawing.Point(65, 3);
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
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(13, 77);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(110, 16);
		this.label17.TabIndex = 149;
		this.label17.Text = "Trang đăng nhâ\u0323p:";
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(13, 53);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(128, 16);
		this.label14.TabIndex = 65;
		this.label14.Text = "Tùy chọn đăng nhâ\u0323p:";
		this.panel4.Controls.Add(this.rbLoginUidPass);
		this.panel4.Controls.Add(this.rbLoginCookie);
		this.panel4.Location = new System.Drawing.Point(147, 49);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(163, 26);
		this.panel4.TabIndex = 66;
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
		this.rbLoginCookie.Location = new System.Drawing.Point(90, 3);
		this.rbLoginCookie.Name = "rbLoginCookie";
		this.rbLoginCookie.Size = new System.Drawing.Size(63, 20);
		this.rbLoginCookie.TabIndex = 4;
		this.rbLoginCookie.Text = "Cookie";
		this.rbLoginCookie.UseVisualStyleBackColor = true;
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(435, 20);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(72, 28);
		this.metroButton1.TabIndex = 64;
		this.metroButton1.Text = "Ca\u0300i đă\u0323t";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(333, 24);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(98, 16);
		this.label12.TabIndex = 30;
		this.label12.Text = "Cấu hình đổi IP:";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(13, 24);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(92, 16);
		this.label10.TabIndex = 30;
		this.label10.Text = "Số luồng chạy:";
		this.nudThread.Location = new System.Drawing.Point(112, 22);
		this.nudThread.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.nudThread.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThread.Name = "nudThread";
		this.nudThread.Size = new System.Drawing.Size(64, 23);
		this.nudThread.TabIndex = 31;
		this.nudThread.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(181, 24);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(38, 16);
		this.label11.TabIndex = 32;
		this.label11.Text = "luồng";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(23, 133);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(0, 16);
		this.label4.TabIndex = 19;
		this.ckbCreateProfile.AutoSize = true;
		this.ckbCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCreateProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCreateProfile.Location = new System.Drawing.Point(336, 52);
		this.ckbCreateProfile.Name = "ckbCreateProfile";
		this.ckbCreateProfile.Size = new System.Drawing.Size(136, 20);
		this.ckbCreateProfile.TabIndex = 148;
		this.ckbCreateProfile.Text = "Tự động tạo Profile";
		this.ckbCreateProfile.UseVisualStyleBackColor = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 500;
		this.toolTip_0.ReshowDelay = 100;
		this.toolTip_0.ToolTipTitle = "Chú thích";
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.plVerify);
		this.panel2.Controls.Add(this.btnCancel);
		this.panel2.Controls.Add(this.plXoaMail);
		this.panel2.Controls.Add(this.btnAdd);
		this.panel2.Controls.Add(this.ckbXoaMail);
		this.panel2.Controls.Add(this.bunifuCards1);
		this.panel2.Controls.Add(this.groupBox3);
		this.panel2.Controls.Add(this.ckbVerify);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(664, 858);
		this.panel2.TabIndex = 69;
		this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(panel2_Paint);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(337, 822);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 71;
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
		this.btnAdd.Location = new System.Drawing.Point(233, 822);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 70;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(662, 38);
		this.bunifuCards1.TabIndex = 69;
		this.plRemovePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plRemovePhone.Controls.Add(this.rbMfbPhone);
		this.plRemovePhone.Controls.Add(this.rbWwwPhone);
		this.plRemovePhone.Location = new System.Drawing.Point(40, 577);
		this.plRemovePhone.Name = "plRemovePhone";
		this.plRemovePhone.Size = new System.Drawing.Size(140, 22);
		this.plRemovePhone.TabIndex = 167;
		this.rbMfbPhone.AutoSize = true;
		this.rbMfbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbMfbPhone.Location = new System.Drawing.Point(74, 0);
		this.rbMfbPhone.Name = "rbMfbPhone";
		this.rbMfbPhone.Size = new System.Drawing.Size(53, 20);
		this.rbMfbPhone.TabIndex = 1;
		this.rbMfbPhone.TabStop = true;
		this.rbMfbPhone.Text = "M.Fb";
		this.rbMfbPhone.UseVisualStyleBackColor = true;
		this.rbWwwPhone.AutoSize = true;
		this.rbWwwPhone.Checked = true;
		this.rbWwwPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbWwwPhone.Location = new System.Drawing.Point(3, 0);
		this.rbWwwPhone.Name = "rbWwwPhone";
		this.rbWwwPhone.Size = new System.Drawing.Size(57, 20);
		this.rbWwwPhone.TabIndex = 0;
		this.rbWwwPhone.TabStop = true;
		this.rbWwwPhone.Text = "Www";
		this.rbWwwPhone.UseVisualStyleBackColor = true;
		this.plRemoveMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plRemoveMail.Controls.Add(this.rbMfbMail);
		this.plRemoveMail.Controls.Add(this.rbWwwMail);
		this.plRemoveMail.Location = new System.Drawing.Point(476, 247);
		this.plRemoveMail.Name = "plRemoveMail";
		this.plRemoveMail.Size = new System.Drawing.Size(140, 22);
		this.plRemoveMail.TabIndex = 167;
		this.rbMfbMail.AutoSize = true;
		this.rbMfbMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbMfbMail.Location = new System.Drawing.Point(74, 0);
		this.rbMfbMail.Name = "rbMfbMail";
		this.rbMfbMail.Size = new System.Drawing.Size(53, 20);
		this.rbMfbMail.TabIndex = 1;
		this.rbMfbMail.TabStop = true;
		this.rbMfbMail.Text = "M.Fb";
		this.rbMfbMail.UseVisualStyleBackColor = true;
		this.rbWwwMail.AutoSize = true;
		this.rbWwwMail.Checked = true;
		this.rbWwwMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbWwwMail.Location = new System.Drawing.Point(3, 0);
		this.rbWwwMail.Name = "rbWwwMail";
		this.rbWwwMail.Size = new System.Drawing.Size(57, 20);
		this.rbWwwMail.TabIndex = 0;
		this.rbWwwMail.TabStop = true;
		this.rbWwwMail.Text = "Www";
		this.rbWwwMail.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(664, 858);
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.panel2);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChangeConfig";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE - phần mềm quản lý tài khoản v1.2.1(ngày cập nhật 6/6/2019)";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fChangeConfig_FormClosing);
		this.ctmsAcc.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.plVerify.ResumeLayout(false);
		this.plVerify.PerformLayout();
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		this.plAvatar.ResumeLayout(false);
		this.plAvatar.PerformLayout();
		this.plDoiMail.ResumeLayout(false);
		this.plDoiMail.PerformLayout();
		this.plPassMailHacked.ResumeLayout(false);
		this.plPassMailHacked.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudNamFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudNamTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThangTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudNgayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThangFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudNgayFrom).EndInit();
		this.panel3.ResumeLayout(false);
		this.pl2fa.ResumeLayout(false);
		this.pl2fa.PerformLayout();
		this.plDoiMatKhau.ResumeLayout(false);
		this.plDoiMatKhau.PerformLayout();
		this.plDoiAnhBia.ResumeLayout(false);
		this.plDoiAnhBia.PerformLayout();
		this.plDoiTen.ResumeLayout(false);
		this.plDoiTen.PerformLayout();
		this.plTenTuDat.ResumeLayout(false);
		this.plTenNgauNhien.ResumeLayout(false);
		this.plTenNgauNhien.PerformLayout();
		this.plXoaMail.ResumeLayout(false);
		this.plXoaMail.PerformLayout();
		this.plXoaMailLinkHacked.ResumeLayout(false);
		this.plXoaMailLinkHacked.PerformLayout();
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThread).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		this.plRemovePhone.ResumeLayout(false);
		this.plRemovePhone.PerformLayout();
		this.plRemoveMail.ResumeLayout(false);
		this.plRemoveMail.PerformLayout();
		base.ResumeLayout(false);
	}
}
