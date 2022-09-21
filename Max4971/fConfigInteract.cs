using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fConfigInteract : Form
{
	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private GroupBox groupBox5;

	private Panel plTuongTacCMSN;

	private RadioButton rbTuongTacCMSNDangBai;

	private RadioButton rbTuongTacCMSNNhanTin;

	private Label label11;

	private NumericUpDown nudTuongTacCMSNSoLuongFrom;

	private Button button2;

	private Label label28;

	private Label label35;

	private NumericUpDown nudTuongTacCMSNDelayFrom;

	private Label label10;

	private Label label37;

	private NumericUpDown nudTuongTacCMSNDelayTo;

	private Label label45;

	private Panel plTuongTacNhanTin;

	private Button btnInbox;

	private Label label41;

	private NumericUpDown nudTuongTacNhanTinSoLuongFrom;

	private Label label42;

	private NumericUpDown nudTuongTacNhanTinDelayFrom;

	private Label label43;

	private NumericUpDown nudTuongTacNhanTinDelayTo;

	private Label label44;

	private Panel plTuongTacChoc;

	private Label label36;

	private NumericUpDown nudTuongTacChocSoLuongFrom;

	private Label label38;

	private NumericUpDown nudTuongTacChocSoLuongDelayFrom;

	private Label label39;

	private NumericUpDown nudTuongTacChocSoLuongDelayTo;

	private Label label40;

	private CheckBox ckbTuongTacNhanTin;

	private CheckBox ckbTuongTacChoc;

	private CheckBox ckbTuongTacCMSN;

	private GroupBox groupBox4;

	private Panel plTuongTacFanpage;

	private Label label56;

	private NumericUpDown nudTuongTacFanpageSoLuongPageFrom;

	private Label label58;

	private NumericUpDown nudTuongTacFanpageSoLuongBaiVietFrom;

	private CheckBox ckbTuongTacFanpageComment;

	private Button button7;

	private Button btnTuongTacFanpageComment;

	private CheckBox ckbTuongTacFanpageLike;

	private Label label59;

	private Label label60;

	private NumericUpDown nudTuongTacFanpageDelayFrom;

	private Label label61;

	private NumericUpDown nudTuongTacFanpageDelayTo;

	private Label label62;

	private Panel plTuongTacGroup;

	private Label label7;

	private NumericUpDown nudTuongTacGroupSoLuongNhomFrom;

	private Label label18;

	private NumericUpDown nudTuongTacGroupSoLuongBaiVietFrom;

	private CheckBox ckbTuongTacGroupComment;

	private Button btnTuongTacGroupComment;

	private CheckBox ckbTuongTacGroupLike;

	private Label label50;

	private Label label51;

	private NumericUpDown nudTuongTacGroupDelayFrom;

	private Label label52;

	private NumericUpDown nudTuongTacGroupDelayTo;

	private Label label53;

	private Panel plTuongTacFriend;

	private Label label49;

	private NumericUpDown nudTuongTacFriendSoLuongBanBeFrom;

	private Label label54;

	private Label label19;

	private NumericUpDown nudTuongTacFriendSoLuongBaiVietFrom;

	private CheckBox ckbTuongTacFriendComment;

	private Button btnTuongTacFriendComment;

	private CheckBox ckbTuongTacFriendLike;

	private Label label33;

	private Label label46;

	private NumericUpDown nudTuongTacFriendDelayFrom;

	private Label label47;

	private NumericUpDown nudTuongTacFriendDelayTo;

	private Label label48;

	private Panel plTuongTacNewsfeed;

	private Label label1;

	private NumericUpDown nudTuongTacNewsfeedSoLuongFrom;

	private CheckBox ckbTuongTacNewsfeedComment;

	private Button btnTuongTacNewsfeedComment;

	private CheckBox ckbTuongTacNewsfeedLike;

	private Label label8;

	private Label label24;

	private NumericUpDown nudTuongTacNewsfeedDelayFrom;

	private Label label29;

	private NumericUpDown nudTuongTacNewsfeedDelayTo;

	private Label label25;

	private CheckBox ckbTuongTacFanpage;

	private CheckBox ckbTuongTacGroup;

	private CheckBox ckbTuongTacNewsfeed;

	private CheckBox ckbTuongTacFriend;

	private GroupBox groupBox8;

	private CheckBox ckbKetBanGoiY;

	private CheckBox ckbXacNhanKetBan;

	private CheckBox ckbKetBanTepUid;

	private Button button8;

	private GroupBox groupBox7;

	private CheckBox ckbThamGiaNhom;

	private ToolTip toolTip_0;

	private CheckBox ckbKetBanTuKhoa;

	private Panel plKetBanTepUid;

	private Label label17;

	private Label label20;

	private NumericUpDown nudKetBanTepUidSoLuongFrom;

	private Label label21;

	private NumericUpDown nudKetBanTepUidDelayFrom;

	private Label label22;

	private NumericUpDown nudKetBanTepUidDelayTo;

	private Label label23;

	private Panel plKetBanTuKhoa;

	private TextBox txtKetBanTuKhoaTuKhoa;

	private Label label16;

	private Label label3;

	private NumericUpDown nudKetBanTuKhoaSoLuongFrom;

	private Label label9;

	private NumericUpDown nudKetBanTuKhoaDelayFrom;

	private Label label14;

	private NumericUpDown nudKetBanTuKhoaDelayTo;

	private Label label15;

	private Panel plXacNhanKetBan;

	private Label label26;

	private NumericUpDown nudXacNhanKetBanSoLuongFrom;

	private Label label27;

	private NumericUpDown nudXacNhanKetBanDelayFrom;

	private Label label30;

	private NumericUpDown nudXacNhanKetBanDelayTo;

	private Label label31;

	private Panel plKetBanGoiY;

	private Label label2;

	private NumericUpDown nudKetBanGoiYSoLuongFrom;

	private Label label4;

	private NumericUpDown nudKetBanGoiYDelayFrom;

	private Label label5;

	private NumericUpDown nudKetBanGoiYDelayTo;

	private Label label6;

	private Panel plThamGiaNhom;

	private CheckBox ckbThamGiaNhomTraLoiCauHoi;

	private Label label12;

	private Label label13;

	private NumericUpDown nudThamGiaNhomSoLuongFrom;

	private Label label32;

	private NumericUpDown nudThamGiaNhomDelayFrom;

	private Label label34;

	private NumericUpDown nudThamGiaNhomDelayTo;

	private Button btnThamGiaNhomTraLoiCauHoi;

	private Button button1;

	private Label label63;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private CheckBox ckbKetBanTepUidTrungNhau;

	private CheckBox ckbThamGiaNhomTrungNhau;

	private Label label80;

	private NumericUpDown nudTuongTacCMSNSoLuongTo;

	private Label label79;

	private Label label84;

	private NumericUpDown nudTuongTacNhanTinSoLuongTo;

	private Label label83;

	private Label label82;

	private NumericUpDown nudTuongTacChocSoLuongTo;

	private Label label81;

	private Label label87;

	private Label label85;

	private NumericUpDown nudTuongTacFanpageSoLuongPageTo;

	private NumericUpDown nudTuongTacFanpageSoLuongBaiVietTo;

	private Label label86;

	private Label label57;

	private Label label89;

	private Label label90;

	private NumericUpDown nudTuongTacGroupSoLuongBaiVietTo;

	private Label label55;

	private NumericUpDown nudTuongTacGroupSoLuongNhomTo;

	private Label label88;

	private Label label68;

	private NumericUpDown nudTuongTacFriendSoLuongBaiVietTo;

	private NumericUpDown nudTuongTacFriendSoLuongBanBeTo;

	private Label label67;

	private Label label66;

	private Label label65;

	private NumericUpDown nudTuongTacNewsfeedSoLuongTo;

	private Label label64;

	private Label label74;

	private NumericUpDown nudKetBanTepUidSoLuongTo;

	private Label label73;

	private Label label70;

	private NumericUpDown nudKetBanTuKhoaSoLuongTo;

	private Label label69;

	private Label label76;

	private NumericUpDown nudXacNhanKetBanSoLuongTo;

	private Label label75;

	private Label label72;

	private NumericUpDown nudKetBanGoiYSoLuongTo;

	private Label label71;

	private Label label78;

	private NumericUpDown nudThamGiaNhomSoLuongTo;

	private Label label77;

	private Label label92;

	private Label label91;

	public fConfigInteract()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configInteract");
		method_0();
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox4);
		GClass29.smethod_1(ckbTuongTacNewsfeed);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label64);
		GClass29.smethod_1(label65);
		GClass29.smethod_1(label24);
		GClass29.smethod_1(label25);
		GClass29.smethod_1(label29);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(btnTuongTacNewsfeedComment);
		GClass29.smethod_1(ckbTuongTacFriend);
		GClass29.smethod_1(label49);
		GClass29.smethod_1(label66);
		GClass29.smethod_1(label68);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(label67);
		GClass29.smethod_1(label54);
		GClass29.smethod_1(label46);
		GClass29.smethod_1(label48);
		GClass29.smethod_1(label47);
		GClass29.smethod_1(label33);
		GClass29.smethod_1(btnTuongTacFriendComment);
		GClass29.smethod_1(ckbTuongTacFanpage);
		GClass29.smethod_1(label91);
		GClass29.smethod_1(button7);
		GClass29.smethod_1(label56);
		GClass29.smethod_1(label86);
		GClass29.smethod_1(label87);
		GClass29.smethod_1(label58);
		GClass29.smethod_1(label57);
		GClass29.smethod_1(label85);
		GClass29.smethod_1(label60);
		GClass29.smethod_1(label62);
		GClass29.smethod_1(label61);
		GClass29.smethod_1(label59);
		GClass29.smethod_1(btnTuongTacFanpageComment);
		GClass29.smethod_1(ckbTuongTacGroup);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label88);
		GClass29.smethod_1(label89);
		GClass29.smethod_1(label18);
		GClass29.smethod_1(label55);
		GClass29.smethod_1(label90);
		GClass29.smethod_1(label51);
		GClass29.smethod_1(label53);
		GClass29.smethod_1(label52);
		GClass29.smethod_1(label50);
		GClass29.smethod_1(btnTuongTacGroupComment);
		GClass29.smethod_1(groupBox5);
		GClass29.smethod_1(ckbTuongTacNhanTin);
		GClass29.smethod_1(label92);
		GClass29.smethod_1(btnInbox);
		GClass29.smethod_1(label41);
		GClass29.smethod_1(label83);
		GClass29.smethod_1(label84);
		GClass29.smethod_1(label42);
		GClass29.smethod_1(label44);
		GClass29.smethod_1(label43);
		GClass29.smethod_1(ckbTuongTacChoc);
		GClass29.smethod_1(label36);
		GClass29.smethod_1(label81);
		GClass29.smethod_1(label82);
		GClass29.smethod_1(label38);
		GClass29.smethod_1(label40);
		GClass29.smethod_1(label39);
		GClass29.smethod_1(ckbTuongTacCMSN);
		GClass29.smethod_1(label11);
		GClass29.smethod_1(label79);
		GClass29.smethod_1(label80);
		GClass29.smethod_1(label35);
		GClass29.smethod_1(label45);
		GClass29.smethod_1(label37);
		GClass29.smethod_1(label28);
		GClass29.smethod_1(rbTuongTacCMSNNhanTin);
		GClass29.smethod_1(rbTuongTacCMSNDangBai);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(groupBox8);
		GClass29.smethod_1(ckbKetBanTuKhoa);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(pictureBox2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label69);
		GClass29.smethod_1(label70);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label14);
		GClass29.smethod_1(ckbKetBanGoiY);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label71);
		GClass29.smethod_1(label72);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(ckbKetBanTepUid);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(button8);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label73);
		GClass29.smethod_1(label74);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label23);
		GClass29.smethod_1(label22);
		GClass29.smethod_1(ckbKetBanTepUidTrungNhau);
		GClass29.smethod_1(ckbXacNhanKetBan);
		GClass29.smethod_1(label26);
		GClass29.smethod_1(label75);
		GClass29.smethod_1(label76);
		GClass29.smethod_1(label31);
		GClass29.smethod_1(label30);
		GClass29.smethod_1(groupBox7);
		GClass29.smethod_1(label12);
		GClass29.smethod_1(button1);
		GClass29.smethod_1(label13);
		GClass29.smethod_1(label77);
		GClass29.smethod_1(label78);
		GClass29.smethod_1(label32);
		GClass29.smethod_1(label63);
		GClass29.smethod_1(label34);
		GClass29.smethod_1(ckbThamGiaNhom);
		GClass29.smethod_1(ckbThamGiaNhomTrungNhau);
		GClass29.smethod_1(ckbThamGiaNhomTraLoiCauHoi);
		GClass29.smethod_1(btnThamGiaNhomTraLoiCauHoi);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fConfigInteract_Load(object sender, EventArgs e)
	{
		method_1();
		method_6();
	}

	private void method_1()
	{
		ckbTuongTacNewsfeed.Checked = gclass17_0.method_3("ckbTuongTacNewsfeed");
		nudTuongTacNewsfeedSoLuongFrom.Value = gclass17_0.method_2("nudTuongTacNewsfeedSoLuongFrom", 1);
		nudTuongTacNewsfeedSoLuongTo.Value = gclass17_0.method_2("nudTuongTacNewsfeedSoLuongTo", 3);
		nudTuongTacNewsfeedDelayFrom.Value = gclass17_0.method_2("nudTuongTacNewsfeedDelayFrom", 2);
		nudTuongTacNewsfeedDelayTo.Value = gclass17_0.method_2("nudTuongTacNewsfeedDelayTo", 5);
		ckbTuongTacNewsfeedLike.Checked = gclass17_0.method_3("ckbTuongTacNewsfeedLike", bool_0: true);
		ckbTuongTacNewsfeedComment.Checked = gclass17_0.method_3("ckbTuongTacNewsfeedComment");
		ckbTuongTacFriend.Checked = gclass17_0.method_3("ckbTuongTacFriend");
		nudTuongTacFriendSoLuongBanBeFrom.Value = gclass17_0.method_2("nudTuongTacFriendSoLuongBanBe", 1);
		nudTuongTacFriendSoLuongBaiVietFrom.Value = gclass17_0.method_2("nudTuongTacFriendSoLuongBaiVietFrom", 1);
		nudTuongTacFriendSoLuongBaiVietTo.Value = gclass17_0.method_2("nudTuongTacFriendSoLuongBaiVietTo", 3);
		nudTuongTacFriendDelayFrom.Value = gclass17_0.method_2("nudTuongTacFriendDelayFrom", 2);
		nudTuongTacFriendDelayTo.Value = gclass17_0.method_2("nudTuongTacFriendDelayTo", 5);
		ckbTuongTacFriendLike.Checked = gclass17_0.method_3("ckbTuongTacFriendLike", bool_0: true);
		ckbTuongTacFriendComment.Checked = gclass17_0.method_3("ckbTuongTacFriendComment", bool_0: true);
		ckbTuongTacGroup.Checked = gclass17_0.method_3("ckbTuongTacGroup");
		nudTuongTacGroupSoLuongNhomFrom.Value = gclass17_0.method_2("nudTuongTacGroupSoLuongNhomFrom", 1);
		nudTuongTacGroupSoLuongNhomTo.Value = gclass17_0.method_2("nudTuongTacGroupSoLuongNhomTo", 3);
		nudTuongTacGroupSoLuongBaiVietFrom.Value = gclass17_0.method_2("nudTuongTacGroupSoLuongBaiVietFrom", 1);
		nudTuongTacGroupSoLuongBaiVietTo.Value = gclass17_0.method_2("nudTuongTacGroupSoLuongBaiVietTo", 1);
		nudTuongTacGroupDelayFrom.Value = gclass17_0.method_2("nudTuongTacGroupDelayFrom", 2);
		nudTuongTacGroupDelayTo.Value = gclass17_0.method_2("nudTuongTacGroupDelayTo", 5);
		ckbTuongTacGroupLike.Checked = gclass17_0.method_3("ckbTuongTacGroupLike", bool_0: true);
		ckbTuongTacGroupComment.Checked = gclass17_0.method_3("ckbTuongTacGroupComment");
		ckbTuongTacFanpage.Checked = gclass17_0.method_3("ckbTuongTacFanpage");
		nudTuongTacFanpageSoLuongPageFrom.Value = gclass17_0.method_2("nudTuongTacFanpageSoLuongPageFrom", 1);
		nudTuongTacFanpageSoLuongPageTo.Value = gclass17_0.method_2("nudTuongTacFanpageSoLuongPageTo", 1);
		nudTuongTacFanpageSoLuongBaiVietFrom.Value = gclass17_0.method_2("nudTuongTacFanpageSoLuongBaiVietFrom", 2);
		nudTuongTacFanpageSoLuongBaiVietTo.Value = gclass17_0.method_2("nudTuongTacFanpageSoLuongBaiVietTo", 2);
		nudTuongTacFanpageDelayFrom.Value = gclass17_0.method_2("nudTuongTacFanpageDelayFrom", 2);
		nudTuongTacFanpageDelayTo.Value = gclass17_0.method_2("nudTuongTacFanpageDelayTo", 5);
		ckbTuongTacFanpageLike.Checked = gclass17_0.method_3("ckbTuongTacFanpageLike", bool_0: true);
		ckbTuongTacFanpageComment.Checked = gclass17_0.method_3("ckbTuongTacFanpageComment");
		ckbKetBanTuKhoa.Checked = gclass17_0.method_3("ckbKetBanTuKhoa");
		txtKetBanTuKhoaTuKhoa.Text = gclass17_0.method_0("txtKetBanTuKhoaTuKhoa");
		nudKetBanTuKhoaSoLuongFrom.Value = gclass17_0.method_2("nudKetBanTuKhoaSoLuongFrom", 1);
		nudKetBanTuKhoaSoLuongTo.Value = gclass17_0.method_2("nudKetBanTuKhoaSoLuongTo", 3);
		nudKetBanTuKhoaDelayFrom.Value = gclass17_0.method_2("nudKetBanTuKhoaDelayFrom", 2);
		nudKetBanTuKhoaDelayTo.Value = gclass17_0.method_2("nudKetBanTuKhoaDelayTo", 5);
		ckbKetBanGoiY.Checked = gclass17_0.method_3("ckbKetBanGoiY");
		nudKetBanGoiYSoLuongFrom.Value = gclass17_0.method_2("nudKetBanGoiYSoLuongFrom", 1);
		nudKetBanGoiYSoLuongTo.Value = gclass17_0.method_2("nudKetBanGoiYSoLuongTo", 3);
		nudKetBanGoiYDelayFrom.Value = gclass17_0.method_2("nudKetBanGoiYDelayFrom", 2);
		nudKetBanGoiYDelayTo.Value = gclass17_0.method_2("nudKetBanGoiYDelayTo", 5);
		ckbKetBanTepUid.Checked = gclass17_0.method_3("ckbKetBanTepUid");
		nudKetBanTepUidSoLuongFrom.Value = gclass17_0.method_2("nudKetBanTepUidSoLuongFrom", 1);
		nudKetBanTepUidSoLuongTo.Value = gclass17_0.method_2("nudKetBanTepUidSoLuongTo", 3);
		nudKetBanTepUidDelayFrom.Value = gclass17_0.method_2("nudKetBanTepUidDelayFrom", 2);
		nudKetBanTepUidDelayTo.Value = gclass17_0.method_2("nudKetBanTepUidDelayTo", 5);
		ckbKetBanTepUidTrungNhau.Checked = gclass17_0.method_3("ckbKetBanTepUidTrungNhau");
		ckbXacNhanKetBan.Checked = gclass17_0.method_3("ckbXacNhanKetBan");
		nudXacNhanKetBanSoLuongFrom.Value = gclass17_0.method_2("nudXacNhanKetBanSoLuongFrom", 1);
		nudXacNhanKetBanSoLuongTo.Value = gclass17_0.method_2("nudXacNhanKetBanSoLuongTo", 3);
		nudXacNhanKetBanDelayFrom.Value = gclass17_0.method_2("nudXacNhanKetBanDelayFrom", 2);
		nudXacNhanKetBanDelayTo.Value = gclass17_0.method_2("nudXacNhanKetBanDelayTo", 5);
		ckbTuongTacNhanTin.Checked = gclass17_0.method_3("ckbTuongTacNhanTin");
		nudTuongTacNhanTinSoLuongFrom.Value = gclass17_0.method_2("nudTuongTacNhanTinSoLuongFrom", 1);
		nudTuongTacNhanTinSoLuongTo.Value = gclass17_0.method_2("nudTuongTacNhanTinSoLuongTo", 3);
		nudTuongTacNhanTinDelayFrom.Value = gclass17_0.method_2("nudTuongTacNhanTinDelayFrom", 2);
		nudTuongTacNhanTinDelayTo.Value = gclass17_0.method_2("nudTuongTacNhanTinDelayTo", 5);
		ckbTuongTacChoc.Checked = gclass17_0.method_3("ckbTuongTacChoc");
		nudTuongTacChocSoLuongFrom.Value = gclass17_0.method_2("nudTuongTacChocSoLuongFrom", 1);
		nudTuongTacChocSoLuongTo.Value = gclass17_0.method_2("nudTuongTacChocSoLuongTo", 3);
		nudTuongTacChocSoLuongDelayFrom.Value = gclass17_0.method_2("nudTuongTacChocSoLuongDelayFrom", 2);
		nudTuongTacChocSoLuongDelayTo.Value = gclass17_0.method_2("nudTuongTacChocSoLuongDelayTo", 5);
		ckbTuongTacCMSN.Checked = gclass17_0.method_3("ckbTuongTacCMSN");
		nudTuongTacCMSNSoLuongFrom.Value = gclass17_0.method_2("nudTuongTacCMSNSoLuongFrom", 1);
		nudTuongTacCMSNSoLuongTo.Value = gclass17_0.method_2("nudTuongTacCMSNSoLuongTo", 3);
		nudTuongTacCMSNDelayFrom.Value = gclass17_0.method_2("nudTuongTacCMSNDelayFrom", 2);
		nudTuongTacCMSNDelayTo.Value = gclass17_0.method_2("nudTuongTacCMSNDelayTo", 5);
		if (gclass17_0.method_2("TuongTacCMSNTypeAction") == 0)
		{
			rbTuongTacCMSNNhanTin.Checked = true;
		}
		else
		{
			rbTuongTacCMSNDangBai.Checked = true;
		}
		ckbThamGiaNhom.Checked = gclass17_0.method_3("ckbThamGiaNhom");
		nudThamGiaNhomSoLuongFrom.Value = gclass17_0.method_2("nudThamGiaNhomSoLuongFrom", 1);
		nudThamGiaNhomSoLuongTo.Value = gclass17_0.method_2("nudThamGiaNhomSoLuongTo", 3);
		nudThamGiaNhomDelayFrom.Value = gclass17_0.method_2("nudThamGiaNhomDelayFrom", 2);
		nudThamGiaNhomDelayTo.Value = gclass17_0.method_2("nudThamGiaNhomDelayTo", 5);
		ckbThamGiaNhomTraLoiCauHoi.Checked = gclass17_0.method_3("ckbThamGiaNhomTraLoiCauHoi");
		ckbThamGiaNhomTrungNhau.Checked = gclass17_0.method_3("ckbThamGiaNhomTrungNhau");
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		gclass17_0.method_5("ckbTuongTacNewsfeed", ckbTuongTacNewsfeed.Checked);
		gclass17_0.method_5("nudTuongTacNewsfeedSoLuongFrom", Convert.ToInt32(nudTuongTacNewsfeedSoLuongFrom.Value));
		gclass17_0.method_5("nudTuongTacNewsfeedSoLuongTo", Convert.ToInt32(nudTuongTacNewsfeedSoLuongTo.Value));
		gclass17_0.method_5("nudTuongTacNewsfeedDelayFrom", Convert.ToInt32(nudTuongTacNewsfeedDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacNewsfeedDelayTo", Convert.ToInt32(nudTuongTacNewsfeedDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacNewsfeedLike", ckbTuongTacNewsfeedLike.Checked);
		gclass17_0.method_5("ckbTuongTacNewsfeedComment", ckbTuongTacNewsfeedComment.Checked);
		gclass17_0.method_5("ckbTuongTacFriend", ckbTuongTacFriend.Checked);
		gclass17_0.method_5("nudTuongTacFriendSoLuongBanBeFrom", Convert.ToInt32(nudTuongTacFriendSoLuongBanBeFrom.Value));
		gclass17_0.method_5("nudTuongTacFriendSoLuongBanBeTo", Convert.ToInt32(nudTuongTacFriendSoLuongBanBeTo.Value));
		gclass17_0.method_5("nudTuongTacFriendSoLuongBaiVietFrom", Convert.ToInt32(nudTuongTacFriendSoLuongBaiVietFrom.Value));
		gclass17_0.method_5("nudTuongTacFriendSoLuongBaiVietTo", Convert.ToInt32(nudTuongTacFriendSoLuongBaiVietTo.Value));
		gclass17_0.method_5("nudTuongTacFriendDelayFrom", Convert.ToInt32(nudTuongTacFriendDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacFriendDelayTo", Convert.ToInt32(nudTuongTacFriendDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacFriendLike", ckbTuongTacFriendLike.Checked);
		gclass17_0.method_5("ckbTuongTacFriendComment", ckbTuongTacFriendComment.Checked);
		gclass17_0.method_5("ckbTuongTacGroup", ckbTuongTacGroup.Checked);
		gclass17_0.method_5("nudTuongTacGroupSoLuongNhomFrom", Convert.ToInt32(nudTuongTacGroupSoLuongNhomFrom.Value));
		gclass17_0.method_5("nudTuongTacGroupSoLuongNhomTo", Convert.ToInt32(nudTuongTacGroupSoLuongNhomTo.Value));
		gclass17_0.method_5("nudTuongTacGroupSoLuongBaiVietFrom", Convert.ToInt32(nudTuongTacGroupSoLuongBaiVietFrom.Value));
		gclass17_0.method_5("nudTuongTacGroupSoLuongBaiVietTo", Convert.ToInt32(nudTuongTacGroupSoLuongBaiVietTo.Value));
		gclass17_0.method_5("nudTuongTacGroupDelayFrom", Convert.ToInt32(nudTuongTacGroupDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacGroupDelayTo", Convert.ToInt32(nudTuongTacGroupDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacGroupLike", ckbTuongTacGroupLike.Checked);
		gclass17_0.method_5("ckbTuongTacGroupComment", ckbTuongTacGroupComment.Checked);
		gclass17_0.method_5("ckbTuongTacFanpage", ckbTuongTacFanpage.Checked);
		gclass17_0.method_5("nudTuongTacFanpageSoLuongPageFrom", Convert.ToInt32(nudTuongTacFanpageSoLuongPageFrom.Value));
		gclass17_0.method_5("nudTuongTacFanpageSoLuongPageTo", Convert.ToInt32(nudTuongTacFanpageSoLuongPageTo.Value));
		gclass17_0.method_5("nudTuongTacFanpageSoLuongBaiVietFrom", Convert.ToInt32(nudTuongTacFanpageSoLuongBaiVietFrom.Value));
		gclass17_0.method_5("nudTuongTacFanpageSoLuongBaiVietTo", Convert.ToInt32(nudTuongTacFanpageSoLuongBaiVietTo.Value));
		gclass17_0.method_5("nudTuongTacFanpageDelayFrom", Convert.ToInt32(nudTuongTacFanpageDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacFanpageDelayTo", Convert.ToInt32(nudTuongTacFanpageDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacFanpageLike", ckbTuongTacFanpageLike.Checked);
		gclass17_0.method_5("ckbTuongTacFanpageComment", ckbTuongTacFanpageComment.Checked);
		gclass17_0.method_5("ckbKetBanTuKhoa", ckbKetBanTuKhoa.Checked);
		gclass17_0.method_5("txtKetBanTuKhoaTuKhoa", txtKetBanTuKhoaTuKhoa.Text);
		gclass17_0.method_5("nudKetBanTuKhoaSoLuongFrom", Convert.ToInt32(nudKetBanTuKhoaSoLuongFrom.Value));
		gclass17_0.method_5("nudKetBanTuKhoaSoLuongTo", Convert.ToInt32(nudKetBanTuKhoaSoLuongTo.Value));
		gclass17_0.method_5("nudKetBanTuKhoaDelayFrom", Convert.ToInt32(nudKetBanTuKhoaDelayFrom.Value));
		gclass17_0.method_5("nudKetBanTuKhoaDelayTo", Convert.ToInt32(nudKetBanTuKhoaDelayTo.Value));
		gclass17_0.method_5("ckbKetBanGoiY", ckbKetBanGoiY.Checked);
		gclass17_0.method_5("nudKetBanGoiYSoLuongFrom", Convert.ToInt32(nudKetBanGoiYSoLuongFrom.Value));
		gclass17_0.method_5("nudKetBanGoiYSoLuongTo", Convert.ToInt32(nudKetBanGoiYSoLuongTo.Value));
		gclass17_0.method_5("nudKetBanGoiYDelayFrom", Convert.ToInt32(nudKetBanGoiYDelayFrom.Value));
		gclass17_0.method_5("nudKetBanGoiYDelayTo", Convert.ToInt32(nudKetBanGoiYDelayTo.Value));
		gclass17_0.method_5("ckbKetBanTepUid", ckbKetBanTepUid.Checked);
		gclass17_0.method_5("nudKetBanTepUidSoLuongFrom", Convert.ToInt32(nudKetBanTepUidSoLuongFrom.Value));
		gclass17_0.method_5("nudKetBanTepUidSoLuongTo", Convert.ToInt32(nudKetBanTepUidSoLuongTo.Value));
		gclass17_0.method_5("nudKetBanTepUidDelayFrom", Convert.ToInt32(nudKetBanTepUidDelayFrom.Value));
		gclass17_0.method_5("nudKetBanTepUidDelayTo", Convert.ToInt32(nudKetBanTepUidDelayTo.Value));
		gclass17_0.method_5("ckbKetBanTepUidTrungNhau", ckbKetBanTepUidTrungNhau.Checked);
		gclass17_0.method_5("ckbXacNhanKetBan", ckbXacNhanKetBan.Checked);
		gclass17_0.method_5("nudXacNhanKetBanSoLuongFrom", Convert.ToInt32(nudXacNhanKetBanSoLuongFrom.Value));
		gclass17_0.method_5("nudXacNhanKetBanSoLuongTo", Convert.ToInt32(nudXacNhanKetBanSoLuongTo.Value));
		gclass17_0.method_5("nudXacNhanKetBanDelayFrom", Convert.ToInt32(nudXacNhanKetBanDelayFrom.Value));
		gclass17_0.method_5("nudXacNhanKetBanDelayTo", Convert.ToInt32(nudXacNhanKetBanDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacNhanTin", ckbTuongTacNhanTin.Checked);
		gclass17_0.method_5("nudTuongTacNhanTinSoLuongFrom", Convert.ToInt32(nudTuongTacNhanTinSoLuongFrom.Value));
		gclass17_0.method_5("nudTuongTacNhanTinSoLuongTo", Convert.ToInt32(nudTuongTacNhanTinSoLuongTo.Value));
		gclass17_0.method_5("nudTuongTacNhanTinDelayFrom", Convert.ToInt32(nudTuongTacNhanTinDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacNhanTinDelayTo", Convert.ToInt32(nudTuongTacNhanTinDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacChoc", ckbTuongTacChoc.Checked);
		gclass17_0.method_5("nudTuongTacChocSoLuongFrom", Convert.ToInt32(nudTuongTacChocSoLuongFrom.Value));
		gclass17_0.method_5("nudTuongTacChocSoLuongTo", Convert.ToInt32(nudTuongTacChocSoLuongTo.Value));
		gclass17_0.method_5("nudTuongTacChocSoLuongDelayFrom", Convert.ToInt32(nudTuongTacChocSoLuongDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacChocSoLuongDelayTo", Convert.ToInt32(nudTuongTacChocSoLuongDelayTo.Value));
		gclass17_0.method_5("ckbTuongTacCMSN", ckbTuongTacCMSN.Checked);
		gclass17_0.method_5("nudTuongTacCMSNSoLuongFrom", Convert.ToInt32(nudTuongTacCMSNSoLuongFrom.Value));
		gclass17_0.method_5("nudTuongTacCMSNSoLuongTo", Convert.ToInt32(nudTuongTacCMSNSoLuongTo.Value));
		gclass17_0.method_5("nudTuongTacCMSNDelayFrom", Convert.ToInt32(nudTuongTacCMSNDelayFrom.Value));
		gclass17_0.method_5("nudTuongTacCMSNDelayTo", Convert.ToInt32(nudTuongTacCMSNDelayTo.Value));
		if (rbTuongTacCMSNNhanTin.Checked)
		{
			gclass17_0.method_5("TuongTacCMSNTypeAction", 0);
		}
		else
		{
			gclass17_0.method_5("TuongTacCMSNTypeAction", 1);
		}
		gclass17_0.method_5("ckbThamGiaNhom", ckbThamGiaNhom.Checked);
		gclass17_0.method_5("nudThamGiaNhomSoLuongFrom", Convert.ToInt32(nudThamGiaNhomSoLuongFrom.Value));
		gclass17_0.method_5("nudThamGiaNhomSoLuongTo", Convert.ToInt32(nudThamGiaNhomSoLuongTo.Value));
		gclass17_0.method_5("nudThamGiaNhomDelayFrom", Convert.ToInt32(nudThamGiaNhomDelayFrom.Value));
		gclass17_0.method_5("nudThamGiaNhomDelayTo", Convert.ToInt32(nudThamGiaNhomDelayTo.Value));
		gclass17_0.method_5("ckbThamGiaNhomTraLoiCauHoi", ckbThamGiaNhomTraLoiCauHoi.Checked);
		gclass17_0.method_5("ckbThamGiaNhomTrungNhau", ckbThamGiaNhomTrungNhau.Checked);
		gclass17_0.method_8();
		if (GClass38.smethod_1(GClass29.smethod_0("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
		{
			Close();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		Process.Start("comments.txt");
	}

	private void method_3(object sender, EventArgs e)
	{
		Process.Start("uidadddfriend.txt");
	}

	private void method_4(object sender, EventArgs e)
	{
		Process.Start("groups.txt");
	}

	private void method_5(object sender, EventArgs e)
	{
		Process.Start("inboxs.txt");
	}

	private void method_6()
	{
		ckbTuongTacNewsfeed_CheckedChanged(null, null);
		ckbTuongTacFriend_CheckedChanged(null, null);
		ckbTuongTacGroup_CheckedChanged(null, null);
		ckbTuongTacFanpage_CheckedChanged(null, null);
		ckbKetBanTuKhoa_CheckedChanged(null, null);
		ckbKetBanTepUid_CheckedChanged(null, null);
		ckbKetBanGoiY_CheckedChanged(null, null);
		ckbTuongTacNhanTin_CheckedChanged(null, null);
		ckbTuongTacChoc_CheckedChanged(null, null);
		ckbTuongTacCMSN_CheckedChanged(null, null);
		ckbThamGiaNhom_CheckedChanged(null, null);
		ckbXacNhanKetBan_CheckedChanged(null, null);
		ckbTuongTacNewsfeedComment_CheckedChanged(null, null);
		ckbTuongTacFriendComment_CheckedChanged(null, null);
		ckbTuongTacGroupComment_CheckedChanged(null, null);
		ckbTuongTacFanpageComment_CheckedChanged(null, null);
		ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(null, null);
	}

	private void ckbTuongTacNewsfeed_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacNewsfeed.Enabled = ckbTuongTacNewsfeed.Checked;
	}

	private void ckbTuongTacFriend_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacFriend.Enabled = ckbTuongTacFriend.Checked;
	}

	private void ckbTuongTacGroup_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacGroup.Enabled = ckbTuongTacGroup.Checked;
	}

	private void ckbTuongTacFanpage_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacFanpage.Enabled = ckbTuongTacFanpage.Checked;
	}

	private void ckbKetBanTuKhoa_CheckedChanged(object sender, EventArgs e)
	{
		plKetBanTuKhoa.Enabled = ckbKetBanTuKhoa.Checked;
	}

	private void ckbKetBanTepUid_CheckedChanged(object sender, EventArgs e)
	{
		plKetBanTepUid.Enabled = ckbKetBanTepUid.Checked;
	}

	private void ckbKetBanGoiY_CheckedChanged(object sender, EventArgs e)
	{
		plKetBanGoiY.Enabled = ckbKetBanGoiY.Checked;
	}

	private void ckbTuongTacNhanTin_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacNhanTin.Enabled = ckbTuongTacNhanTin.Checked;
	}

	private void ckbTuongTacChoc_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacChoc.Enabled = ckbTuongTacChoc.Checked;
	}

	private void ckbTuongTacCMSN_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacCMSN.Enabled = ckbTuongTacCMSN.Checked;
	}

	private void ckbThamGiaNhom_CheckedChanged(object sender, EventArgs e)
	{
		plThamGiaNhom.Enabled = ckbThamGiaNhom.Checked;
	}

	private void ckbXacNhanKetBan_CheckedChanged(object sender, EventArgs e)
	{
		plXacNhanKetBan.Enabled = ckbXacNhanKetBan.Checked;
	}

	private void btnTuongTacNewsfeedComment_Click(object sender, EventArgs e)
	{
		method_7("newsfeedcomments", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("Danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void method_7(string string_0, string string_1, string string_2, string string_3)
	{
		try
		{
			string text = "reactions\\" + string_0 + ".txt";
			if (!File.Exists(text))
			{
				GClass14.smethod_30(text);
			}
			GClass14.smethod_33(new fNhapDuLieu1(text, string_1, string_2, string_3));
		}
		catch
		{
		}
	}

	private void btnTuongTacFriendComment_Click(object sender, EventArgs e)
	{
		method_7("friendcomments", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("Danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void btnTuongTacGroupComment_Click(object sender, EventArgs e)
	{
		method_7("groupcomments", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("Danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void button7_Click(object sender, EventArgs e)
	{
		method_7("pages", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch ID page"), GClass29.smethod_0("Danh sa\u0301ch ID page"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void btnTuongTacFanpageComment_Click(object sender, EventArgs e)
	{
		method_7("pagecomments", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("Danh sa\u0301ch bi\u0300nh luâ\u0323n"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void btnInbox_Click(object sender, EventArgs e)
	{
		method_7("message", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch tin nhă\u0301n"), GClass29.smethod_0("Danh sa\u0301ch tin nhă\u0301n"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void button2_Click(object sender, EventArgs e)
	{
		method_7("birthdaycontent", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch lơ\u0300i chu\u0301c"), GClass29.smethod_0("Danh sa\u0301ch lơ\u0300i chu\u0301c"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void button8_Click(object sender, EventArgs e)
	{
		method_7("idFriend", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch UID câ\u0300n kê\u0301t ba\u0323n"), GClass29.smethod_0("Danh sa\u0301ch UID"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_7("idGroup", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch ID nho\u0301m câ\u0300n tham gia"), GClass29.smethod_0("Danh sa\u0301ch ID nho\u0301m"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng)"));
	}

	private void btnThamGiaNhomTraLoiCauHoi_Click(object sender, EventArgs e)
	{
		method_7("answer", GClass29.smethod_0("Nhâ\u0323p danh sa\u0301ch câu tra\u0309 lơ\u0300i"), GClass29.smethod_0("Danh sa\u0301ch câu tra\u0309 lơ\u0300i"), GClass29.smethod_0("(Mô\u0303i nô\u0323i dung 1 do\u0300ng, spin nô\u0323i dung {a|b|c})"));
	}

	private void ckbTuongTacNewsfeedComment_CheckedChanged(object sender, EventArgs e)
	{
		btnTuongTacNewsfeedComment.Enabled = ckbTuongTacNewsfeedComment.Checked;
	}

	private void ckbTuongTacFriendComment_CheckedChanged(object sender, EventArgs e)
	{
		btnTuongTacFriendComment.Enabled = ckbTuongTacFriendComment.Checked;
	}

	private void ckbTuongTacGroupComment_CheckedChanged(object sender, EventArgs e)
	{
		btnTuongTacGroupComment.Enabled = ckbTuongTacGroupComment.Checked;
	}

	private void ckbTuongTacFanpageComment_CheckedChanged(object sender, EventArgs e)
	{
		btnTuongTacFanpageComment.Enabled = ckbTuongTacFanpageComment.Checked;
	}

	private void ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(object sender, EventArgs e)
	{
		btnThamGiaNhomTraLoiCauHoi.Enabled = ckbThamGiaNhomTraLoiCauHoi.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfigInteract));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.plTuongTacCMSN = new System.Windows.Forms.Panel();
		this.rbTuongTacCMSNDangBai = new System.Windows.Forms.RadioButton();
		this.rbTuongTacCMSNNhanTin = new System.Windows.Forms.RadioButton();
		this.label11 = new System.Windows.Forms.Label();
		this.nudTuongTacCMSNSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.button2 = new System.Windows.Forms.Button();
		this.label28 = new System.Windows.Forms.Label();
		this.label35 = new System.Windows.Forms.Label();
		this.nudTuongTacCMSNDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.label80 = new System.Windows.Forms.Label();
		this.label37 = new System.Windows.Forms.Label();
		this.nudTuongTacCMSNSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label79 = new System.Windows.Forms.Label();
		this.nudTuongTacCMSNDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label45 = new System.Windows.Forms.Label();
		this.plTuongTacNhanTin = new System.Windows.Forms.Panel();
		this.btnInbox = new System.Windows.Forms.Button();
		this.label92 = new System.Windows.Forms.Label();
		this.label41 = new System.Windows.Forms.Label();
		this.nudTuongTacNhanTinSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label42 = new System.Windows.Forms.Label();
		this.nudTuongTacNhanTinDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label84 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.nudTuongTacNhanTinDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacNhanTinSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label83 = new System.Windows.Forms.Label();
		this.label44 = new System.Windows.Forms.Label();
		this.plTuongTacChoc = new System.Windows.Forms.Panel();
		this.label36 = new System.Windows.Forms.Label();
		this.nudTuongTacChocSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label38 = new System.Windows.Forms.Label();
		this.nudTuongTacChocSoLuongDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label82 = new System.Windows.Forms.Label();
		this.label39 = new System.Windows.Forms.Label();
		this.nudTuongTacChocSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label81 = new System.Windows.Forms.Label();
		this.nudTuongTacChocSoLuongDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label40 = new System.Windows.Forms.Label();
		this.ckbTuongTacNhanTin = new System.Windows.Forms.CheckBox();
		this.ckbTuongTacChoc = new System.Windows.Forms.CheckBox();
		this.ckbTuongTacCMSN = new System.Windows.Forms.CheckBox();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.plTuongTacFanpage = new System.Windows.Forms.Panel();
		this.label91 = new System.Windows.Forms.Label();
		this.label56 = new System.Windows.Forms.Label();
		this.nudTuongTacFanpageSoLuongPageFrom = new System.Windows.Forms.NumericUpDown();
		this.label58 = new System.Windows.Forms.Label();
		this.label87 = new System.Windows.Forms.Label();
		this.label85 = new System.Windows.Forms.Label();
		this.button7 = new System.Windows.Forms.Button();
		this.nudTuongTacFanpageSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacFanpageComment = new System.Windows.Forms.CheckBox();
		this.btnTuongTacFanpageComment = new System.Windows.Forms.Button();
		this.ckbTuongTacFanpageLike = new System.Windows.Forms.CheckBox();
		this.label59 = new System.Windows.Forms.Label();
		this.label60 = new System.Windows.Forms.Label();
		this.nudTuongTacFanpageDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label61 = new System.Windows.Forms.Label();
		this.nudTuongTacFanpageDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacFanpageSoLuongPageTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacFanpageSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.label86 = new System.Windows.Forms.Label();
		this.label62 = new System.Windows.Forms.Label();
		this.label57 = new System.Windows.Forms.Label();
		this.plTuongTacGroup = new System.Windows.Forms.Panel();
		this.label7 = new System.Windows.Forms.Label();
		this.nudTuongTacGroupSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
		this.label89 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.nudTuongTacGroupSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacGroupComment = new System.Windows.Forms.CheckBox();
		this.btnTuongTacGroupComment = new System.Windows.Forms.Button();
		this.ckbTuongTacGroupLike = new System.Windows.Forms.CheckBox();
		this.label90 = new System.Windows.Forms.Label();
		this.label50 = new System.Windows.Forms.Label();
		this.label51 = new System.Windows.Forms.Label();
		this.nudTuongTacGroupSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacGroupDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label55 = new System.Windows.Forms.Label();
		this.label52 = new System.Windows.Forms.Label();
		this.nudTuongTacGroupDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label53 = new System.Windows.Forms.Label();
		this.nudTuongTacGroupSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
		this.label88 = new System.Windows.Forms.Label();
		this.plTuongTacFriend = new System.Windows.Forms.Panel();
		this.label49 = new System.Windows.Forms.Label();
		this.nudTuongTacFriendSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.label54 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.nudTuongTacFriendSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacFriendComment = new System.Windows.Forms.CheckBox();
		this.btnTuongTacFriendComment = new System.Windows.Forms.Button();
		this.ckbTuongTacFriendLike = new System.Windows.Forms.CheckBox();
		this.label33 = new System.Windows.Forms.Label();
		this.label46 = new System.Windows.Forms.Label();
		this.nudTuongTacFriendDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label47 = new System.Windows.Forms.Label();
		this.nudTuongTacFriendSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacFriendSoLuongBanBeTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacFriendDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label67 = new System.Windows.Forms.Label();
		this.label66 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.plTuongTacNewsfeed = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.nudTuongTacNewsfeedSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacNewsfeedComment = new System.Windows.Forms.CheckBox();
		this.btnTuongTacNewsfeedComment = new System.Windows.Forms.Button();
		this.ckbTuongTacNewsfeedLike = new System.Windows.Forms.CheckBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.nudTuongTacNewsfeedDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label65 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.nudTuongTacNewsfeedSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacNewsfeedDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label64 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.ckbTuongTacFanpage = new System.Windows.Forms.CheckBox();
		this.ckbTuongTacGroup = new System.Windows.Forms.CheckBox();
		this.ckbTuongTacNewsfeed = new System.Windows.Forms.CheckBox();
		this.ckbTuongTacFriend = new System.Windows.Forms.CheckBox();
		this.groupBox8 = new System.Windows.Forms.GroupBox();
		this.ckbKetBanTuKhoa = new System.Windows.Forms.CheckBox();
		this.plKetBanTepUid = new System.Windows.Forms.Panel();
		this.ckbKetBanTepUidTrungNhau = new System.Windows.Forms.CheckBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.nudKetBanTepUidSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label21 = new System.Windows.Forms.Label();
		this.nudKetBanTepUidDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label22 = new System.Windows.Forms.Label();
		this.label74 = new System.Windows.Forms.Label();
		this.nudKetBanTepUidDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudKetBanTepUidSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label73 = new System.Windows.Forms.Label();
		this.button8 = new System.Windows.Forms.Button();
		this.label23 = new System.Windows.Forms.Label();
		this.plKetBanTuKhoa = new System.Windows.Forms.Panel();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.txtKetBanTuKhoaTuKhoa = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.nudKetBanTuKhoaSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.nudKetBanTuKhoaDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label70 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudKetBanTuKhoaSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label69 = new System.Windows.Forms.Label();
		this.nudKetBanTuKhoaDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.ckbKetBanGoiY = new System.Windows.Forms.CheckBox();
		this.plXacNhanKetBan = new System.Windows.Forms.Panel();
		this.label26 = new System.Windows.Forms.Label();
		this.nudXacNhanKetBanSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label27 = new System.Windows.Forms.Label();
		this.nudXacNhanKetBanDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label30 = new System.Windows.Forms.Label();
		this.nudXacNhanKetBanDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label31 = new System.Windows.Forms.Label();
		this.label76 = new System.Windows.Forms.Label();
		this.nudXacNhanKetBanSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label75 = new System.Windows.Forms.Label();
		this.plKetBanGoiY = new System.Windows.Forms.Panel();
		this.label2 = new System.Windows.Forms.Label();
		this.nudKetBanGoiYSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.nudKetBanGoiYDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.nudKetBanGoiYDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.label72 = new System.Windows.Forms.Label();
		this.nudKetBanGoiYSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.label71 = new System.Windows.Forms.Label();
		this.ckbKetBanTepUid = new System.Windows.Forms.CheckBox();
		this.ckbXacNhanKetBan = new System.Windows.Forms.CheckBox();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.ckbThamGiaNhom = new System.Windows.Forms.CheckBox();
		this.plThamGiaNhom = new System.Windows.Forms.Panel();
		this.ckbThamGiaNhomTrungNhau = new System.Windows.Forms.CheckBox();
		this.ckbThamGiaNhomTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.nudThamGiaNhomSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label32 = new System.Windows.Forms.Label();
		this.nudThamGiaNhomDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label78 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.nudThamGiaNhomSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudThamGiaNhomDelayTo = new System.Windows.Forms.NumericUpDown();
		this.btnThamGiaNhomTraLoiCauHoi = new System.Windows.Forms.Button();
		this.label77 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.label63 = new System.Windows.Forms.Label();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox5.SuspendLayout();
		this.plTuongTacCMSN.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayTo).BeginInit();
		this.plTuongTacNhanTin.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongTo).BeginInit();
		this.plTuongTacChoc.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayTo).BeginInit();
		this.groupBox4.SuspendLayout();
		this.plTuongTacFanpage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietTo).BeginInit();
		this.plTuongTacGroup.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomTo).BeginInit();
		this.plTuongTacFriend.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayTo).BeginInit();
		this.plTuongTacNewsfeed.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayTo).BeginInit();
		this.groupBox8.SuspendLayout();
		this.plKetBanTepUid.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongTo).BeginInit();
		this.plKetBanTuKhoa.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayTo).BeginInit();
		this.plXacNhanKetBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongTo).BeginInit();
		this.plKetBanGoiY.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongTo).BeginInit();
		this.groupBox7.SuspendLayout();
		this.plThamGiaNhom.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayTo).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1012, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1012, 30);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(5, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(980, 30);
		this.bunifuCustomLabel1.TabIndex = 0;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác nhanh";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(980, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 30);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(513, 675);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 6;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(409, 675);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 5;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.groupBox5.Controls.Add(this.plTuongTacCMSN);
		this.groupBox5.Controls.Add(this.plTuongTacNhanTin);
		this.groupBox5.Controls.Add(this.plTuongTacChoc);
		this.groupBox5.Controls.Add(this.ckbTuongTacNhanTin);
		this.groupBox5.Controls.Add(this.ckbTuongTacChoc);
		this.groupBox5.Controls.Add(this.ckbTuongTacCMSN);
		this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox5.Location = new System.Drawing.Point(662, 37);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(344, 381);
		this.groupBox5.TabIndex = 2;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Tương ta\u0301c ba\u0323n be\u0300";
		this.plTuongTacCMSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNDangBai);
		this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNNhanTin);
		this.plTuongTacCMSN.Controls.Add(this.label11);
		this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongFrom);
		this.plTuongTacCMSN.Controls.Add(this.button2);
		this.plTuongTacCMSN.Controls.Add(this.label28);
		this.plTuongTacCMSN.Controls.Add(this.label35);
		this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayFrom);
		this.plTuongTacCMSN.Controls.Add(this.label10);
		this.plTuongTacCMSN.Controls.Add(this.label80);
		this.plTuongTacCMSN.Controls.Add(this.label37);
		this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongTo);
		this.plTuongTacCMSN.Controls.Add(this.label79);
		this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayTo);
		this.plTuongTacCMSN.Controls.Add(this.label45);
		this.plTuongTacCMSN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacCMSN.Location = new System.Drawing.Point(42, 256);
		this.plTuongTacCMSN.Name = "plTuongTacCMSN";
		this.plTuongTacCMSN.Size = new System.Drawing.Size(288, 118);
		this.plTuongTacCMSN.TabIndex = 5;
		this.rbTuongTacCMSNDangBai.AutoSize = true;
		this.rbTuongTacCMSNDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacCMSNDangBai.Location = new System.Drawing.Point(199, 59);
		this.rbTuongTacCMSNDangBai.Name = "rbTuongTacCMSNDangBai";
		this.rbTuongTacCMSNDangBai.Size = new System.Drawing.Size(77, 20);
		this.rbTuongTacCMSNDangBai.TabIndex = 4;
		this.rbTuongTacCMSNDangBai.Text = "Đăng ba\u0300i";
		this.rbTuongTacCMSNDangBai.UseVisualStyleBackColor = true;
		this.rbTuongTacCMSNNhanTin.AutoSize = true;
		this.rbTuongTacCMSNNhanTin.Checked = true;
		this.rbTuongTacCMSNNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuongTacCMSNNhanTin.Location = new System.Drawing.Point(122, 61);
		this.rbTuongTacCMSNNhanTin.Name = "rbTuongTacCMSNNhanTin";
		this.rbTuongTacCMSNNhanTin.Size = new System.Drawing.Size(73, 20);
		this.rbTuongTacCMSNNhanTin.TabIndex = 3;
		this.rbTuongTacCMSNNhanTin.TabStop = true;
		this.rbTuongTacCMSNNhanTin.Text = "Nhă\u0301n tin";
		this.rbTuongTacCMSNNhanTin.UseVisualStyleBackColor = true;
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label11.Location = new System.Drawing.Point(7, 7);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(102, 16);
		this.label11.TabIndex = 89;
		this.label11.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300";
		this.nudTuongTacCMSNSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacCMSNSoLuongFrom.Location = new System.Drawing.Point(122, 4);
		this.nudTuongTacCMSNSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacCMSNSoLuongFrom.Name = "nudTuongTacCMSNSoLuongFrom";
		this.nudTuongTacCMSNSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacCMSNSoLuongFrom.TabIndex = 0;
		this.nudTuongTacCMSNSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button2.Location = new System.Drawing.Point(122, 84);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(58, 27);
		this.button2.TabIndex = 5;
		this.button2.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.button2, "Nhâ\u0323p danh sa\u0301ch nô\u0323i dung chu\u0301c mư\u0300ng sinh nhâ\u0323t");
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.label28.AutoSize = true;
		this.label28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label28.Location = new System.Drawing.Point(7, 61);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(67, 16);
		this.label28.TabIndex = 89;
		this.label28.Text = "Hi\u0300nh thư\u0301c:";
		this.label35.AutoSize = true;
		this.label35.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label35.Location = new System.Drawing.Point(7, 36);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(100, 16);
		this.label35.TabIndex = 89;
		this.label35.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacCMSNDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacCMSNDelayFrom.Location = new System.Drawing.Point(122, 33);
		this.nudTuongTacCMSNDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacCMSNDelayFrom.Name = "nudTuongTacCMSNDelayFrom";
		this.nudTuongTacCMSNDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacCMSNDelayFrom.TabIndex = 1;
		this.nudTuongTacCMSNDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label10.Location = new System.Drawing.Point(7, 89);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(63, 16);
		this.label10.TabIndex = 89;
		this.label10.Text = "Nô\u0323i dung:";
		this.label80.AutoSize = true;
		this.label80.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label80.Location = new System.Drawing.Point(246, 8);
		this.label80.Name = "label80";
		this.label80.Size = new System.Drawing.Size(29, 16);
		this.label80.TabIndex = 91;
		this.label80.Text = "ba\u0323n";
		this.label37.AutoSize = true;
		this.label37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label37.Location = new System.Drawing.Point(246, 38);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(31, 16);
		this.label37.TabIndex = 91;
		this.label37.Text = "giây";
		this.nudTuongTacCMSNSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacCMSNSoLuongTo.Location = new System.Drawing.Point(199, 4);
		this.nudTuongTacCMSNSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacCMSNSoLuongTo.Name = "nudTuongTacCMSNSoLuongTo";
		this.nudTuongTacCMSNSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacCMSNSoLuongTo.TabIndex = 2;
		this.nudTuongTacCMSNSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label79.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label79.Location = new System.Drawing.Point(167, 8);
		this.label79.Name = "label79";
		this.label79.Size = new System.Drawing.Size(29, 16);
		this.label79.TabIndex = 91;
		this.label79.Text = "đê\u0301n";
		this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudTuongTacCMSNDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacCMSNDelayTo.Location = new System.Drawing.Point(199, 33);
		this.nudTuongTacCMSNDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacCMSNDelayTo.Name = "nudTuongTacCMSNDelayTo";
		this.nudTuongTacCMSNDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacCMSNDelayTo.TabIndex = 2;
		this.nudTuongTacCMSNDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label45.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label45.Location = new System.Drawing.Point(167, 38);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(29, 16);
		this.label45.TabIndex = 91;
		this.label45.Text = "đê\u0301n";
		this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plTuongTacNhanTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacNhanTin.Controls.Add(this.btnInbox);
		this.plTuongTacNhanTin.Controls.Add(this.label92);
		this.plTuongTacNhanTin.Controls.Add(this.label41);
		this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongFrom);
		this.plTuongTacNhanTin.Controls.Add(this.label42);
		this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayFrom);
		this.plTuongTacNhanTin.Controls.Add(this.label84);
		this.plTuongTacNhanTin.Controls.Add(this.label43);
		this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayTo);
		this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongTo);
		this.plTuongTacNhanTin.Controls.Add(this.label83);
		this.plTuongTacNhanTin.Controls.Add(this.label44);
		this.plTuongTacNhanTin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacNhanTin.Location = new System.Drawing.Point(42, 45);
		this.plTuongTacNhanTin.Name = "plTuongTacNhanTin";
		this.plTuongTacNhanTin.Size = new System.Drawing.Size(288, 90);
		this.plTuongTacNhanTin.TabIndex = 1;
		this.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnInbox.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnInbox.Location = new System.Drawing.Point(122, 2);
		this.btnInbox.Name = "btnInbox";
		this.btnInbox.Size = new System.Drawing.Size(78, 27);
		this.btnInbox.TabIndex = 1;
		this.btnInbox.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.btnInbox, "Nhâ\u0323p danh sa\u0301ch tin nhă\u0301n");
		this.btnInbox.UseVisualStyleBackColor = true;
		this.btnInbox.Click += new System.EventHandler(btnInbox_Click);
		this.label92.AutoSize = true;
		this.label92.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label92.Location = new System.Drawing.Point(3, 6);
		this.label92.Name = "label92";
		this.label92.Size = new System.Drawing.Size(122, 16);
		this.label92.TabIndex = 0;
		this.label92.Text = "Danh sách tin nhắn:";
		this.label41.AutoSize = true;
		this.label41.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label41.Location = new System.Drawing.Point(3, 36);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(107, 16);
		this.label41.TabIndex = 89;
		this.label41.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		this.nudTuongTacNhanTinSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNhanTinSoLuongFrom.Location = new System.Drawing.Point(123, 33);
		this.nudTuongTacNhanTinSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNhanTinSoLuongFrom.Name = "nudTuongTacNhanTinSoLuongFrom";
		this.nudTuongTacNhanTinSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacNhanTinSoLuongFrom.TabIndex = 0;
		this.nudTuongTacNhanTinSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label42.AutoSize = true;
		this.label42.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label42.Location = new System.Drawing.Point(3, 63);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(100, 16);
		this.label42.TabIndex = 89;
		this.label42.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacNhanTinDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNhanTinDelayFrom.Location = new System.Drawing.Point(123, 60);
		this.nudTuongTacNhanTinDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNhanTinDelayFrom.Name = "nudTuongTacNhanTinDelayFrom";
		this.nudTuongTacNhanTinDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacNhanTinDelayFrom.TabIndex = 2;
		this.nudTuongTacNhanTinDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label84.AutoSize = true;
		this.label84.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label84.Location = new System.Drawing.Point(247, 37);
		this.label84.Name = "label84";
		this.label84.Size = new System.Drawing.Size(29, 16);
		this.label84.TabIndex = 91;
		this.label84.Text = "ba\u0323n";
		this.label43.AutoSize = true;
		this.label43.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label43.Location = new System.Drawing.Point(247, 65);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(31, 16);
		this.label43.TabIndex = 91;
		this.label43.Text = "giây";
		this.nudTuongTacNhanTinDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNhanTinDelayTo.Location = new System.Drawing.Point(200, 61);
		this.nudTuongTacNhanTinDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNhanTinDelayTo.Name = "nudTuongTacNhanTinDelayTo";
		this.nudTuongTacNhanTinDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacNhanTinDelayTo.TabIndex = 3;
		this.nudTuongTacNhanTinDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacNhanTinSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNhanTinSoLuongTo.Location = new System.Drawing.Point(200, 33);
		this.nudTuongTacNhanTinSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNhanTinSoLuongTo.Name = "nudTuongTacNhanTinSoLuongTo";
		this.nudTuongTacNhanTinSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacNhanTinSoLuongTo.TabIndex = 2;
		this.nudTuongTacNhanTinSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label83.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label83.Location = new System.Drawing.Point(168, 37);
		this.label83.Name = "label83";
		this.label83.Size = new System.Drawing.Size(29, 16);
		this.label83.TabIndex = 91;
		this.label83.Text = "đê\u0301n";
		this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label44.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label44.Location = new System.Drawing.Point(168, 65);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(29, 16);
		this.label44.TabIndex = 91;
		this.label44.Text = "đê\u0301n";
		this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plTuongTacChoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacChoc.Controls.Add(this.label36);
		this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongFrom);
		this.plTuongTacChoc.Controls.Add(this.label38);
		this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayFrom);
		this.plTuongTacChoc.Controls.Add(this.label82);
		this.plTuongTacChoc.Controls.Add(this.label39);
		this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongTo);
		this.plTuongTacChoc.Controls.Add(this.label81);
		this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayTo);
		this.plTuongTacChoc.Controls.Add(this.label40);
		this.plTuongTacChoc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacChoc.Location = new System.Drawing.Point(42, 163);
		this.plTuongTacChoc.Name = "plTuongTacChoc";
		this.plTuongTacChoc.Size = new System.Drawing.Size(288, 65);
		this.plTuongTacChoc.TabIndex = 3;
		this.label36.AutoSize = true;
		this.label36.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label36.Location = new System.Drawing.Point(3, 8);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(107, 16);
		this.label36.TabIndex = 89;
		this.label36.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		this.nudTuongTacChocSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacChocSoLuongFrom.Location = new System.Drawing.Point(122, 5);
		this.nudTuongTacChocSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacChocSoLuongFrom.Name = "nudTuongTacChocSoLuongFrom";
		this.nudTuongTacChocSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacChocSoLuongFrom.TabIndex = 0;
		this.nudTuongTacChocSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label38.AutoSize = true;
		this.label38.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label38.Location = new System.Drawing.Point(3, 37);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(100, 16);
		this.label38.TabIndex = 89;
		this.label38.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacChocSoLuongDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacChocSoLuongDelayFrom.Location = new System.Drawing.Point(122, 34);
		this.nudTuongTacChocSoLuongDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacChocSoLuongDelayFrom.Name = "nudTuongTacChocSoLuongDelayFrom";
		this.nudTuongTacChocSoLuongDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacChocSoLuongDelayFrom.TabIndex = 1;
		this.nudTuongTacChocSoLuongDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label82.AutoSize = true;
		this.label82.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label82.Location = new System.Drawing.Point(246, 10);
		this.label82.Name = "label82";
		this.label82.Size = new System.Drawing.Size(29, 16);
		this.label82.TabIndex = 91;
		this.label82.Text = "ba\u0323n";
		this.label39.AutoSize = true;
		this.label39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label39.Location = new System.Drawing.Point(246, 39);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(31, 16);
		this.label39.TabIndex = 91;
		this.label39.Text = "giây";
		this.nudTuongTacChocSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacChocSoLuongTo.Location = new System.Drawing.Point(199, 5);
		this.nudTuongTacChocSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacChocSoLuongTo.Name = "nudTuongTacChocSoLuongTo";
		this.nudTuongTacChocSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacChocSoLuongTo.TabIndex = 2;
		this.nudTuongTacChocSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label81.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label81.Location = new System.Drawing.Point(167, 10);
		this.label81.Name = "label81";
		this.label81.Size = new System.Drawing.Size(29, 16);
		this.label81.TabIndex = 91;
		this.label81.Text = "đê\u0301n";
		this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudTuongTacChocSoLuongDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacChocSoLuongDelayTo.Location = new System.Drawing.Point(199, 34);
		this.nudTuongTacChocSoLuongDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacChocSoLuongDelayTo.Name = "nudTuongTacChocSoLuongDelayTo";
		this.nudTuongTacChocSoLuongDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacChocSoLuongDelayTo.TabIndex = 2;
		this.nudTuongTacChocSoLuongDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label40.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label40.Location = new System.Drawing.Point(167, 39);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(29, 16);
		this.label40.TabIndex = 91;
		this.label40.Text = "đê\u0301n";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbTuongTacNhanTin.AutoSize = true;
		this.ckbTuongTacNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacNhanTin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacNhanTin.Location = new System.Drawing.Point(23, 22);
		this.ckbTuongTacNhanTin.Name = "ckbTuongTacNhanTin";
		this.ckbTuongTacNhanTin.Size = new System.Drawing.Size(74, 20);
		this.ckbTuongTacNhanTin.TabIndex = 0;
		this.ckbTuongTacNhanTin.Text = "Nhă\u0301n tin";
		this.ckbTuongTacNhanTin.UseVisualStyleBackColor = true;
		this.ckbTuongTacNhanTin.CheckedChanged += new System.EventHandler(ckbTuongTacNhanTin_CheckedChanged);
		this.ckbTuongTacChoc.AutoSize = true;
		this.ckbTuongTacChoc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacChoc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacChoc.Location = new System.Drawing.Point(23, 140);
		this.ckbTuongTacChoc.Name = "ckbTuongTacChoc";
		this.ckbTuongTacChoc.Size = new System.Drawing.Size(98, 20);
		this.ckbTuongTacChoc.TabIndex = 2;
		this.ckbTuongTacChoc.Text = "Cho\u0323c ba\u0323n be\u0300";
		this.ckbTuongTacChoc.UseVisualStyleBackColor = true;
		this.ckbTuongTacChoc.CheckedChanged += new System.EventHandler(ckbTuongTacChoc_CheckedChanged);
		this.ckbTuongTacCMSN.AutoSize = true;
		this.ckbTuongTacCMSN.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacCMSN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacCMSN.Location = new System.Drawing.Point(23, 233);
		this.ckbTuongTacCMSN.Name = "ckbTuongTacCMSN";
		this.ckbTuongTacCMSN.Size = new System.Drawing.Size(148, 20);
		this.ckbTuongTacCMSN.TabIndex = 4;
		this.ckbTuongTacCMSN.Text = "Chu\u0301c mư\u0300ng sinh nhâ\u0323t";
		this.ckbTuongTacCMSN.UseVisualStyleBackColor = true;
		this.ckbTuongTacCMSN.CheckedChanged += new System.EventHandler(ckbTuongTacCMSN_CheckedChanged);
		this.groupBox4.Controls.Add(this.plTuongTacFanpage);
		this.groupBox4.Controls.Add(this.plTuongTacGroup);
		this.groupBox4.Controls.Add(this.plTuongTacFriend);
		this.groupBox4.Controls.Add(this.plTuongTacNewsfeed);
		this.groupBox4.Controls.Add(this.ckbTuongTacFanpage);
		this.groupBox4.Controls.Add(this.ckbTuongTacGroup);
		this.groupBox4.Controls.Add(this.ckbTuongTacNewsfeed);
		this.groupBox4.Controls.Add(this.ckbTuongTacFriend);
		this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox4.Location = new System.Drawing.Point(7, 37);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(649, 381);
		this.groupBox4.TabIndex = 1;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Tương ta\u0301c ba\u0300i viê\u0301t";
		this.plTuongTacFanpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacFanpage.Controls.Add(this.label91);
		this.plTuongTacFanpage.Controls.Add(this.label56);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageFrom);
		this.plTuongTacFanpage.Controls.Add(this.label58);
		this.plTuongTacFanpage.Controls.Add(this.button7);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietFrom);
		this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageComment);
		this.plTuongTacFanpage.Controls.Add(this.btnTuongTacFanpageComment);
		this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageLike);
		this.plTuongTacFanpage.Controls.Add(this.label59);
		this.plTuongTacFanpage.Controls.Add(this.label60);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayFrom);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayTo);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageTo);
		this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietTo);
		this.plTuongTacFanpage.Controls.Add(this.label86);
		this.plTuongTacFanpage.Controls.Add(this.label62);
		this.plTuongTacFanpage.Controls.Add(this.label57);
		this.plTuongTacFanpage.Controls.Add(this.label87);
		this.plTuongTacFanpage.Controls.Add(this.label85);
		this.plTuongTacFanpage.Controls.Add(this.label61);
		this.plTuongTacFanpage.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacFanpage.Location = new System.Drawing.Point(41, 198);
		this.plTuongTacFanpage.Name = "plTuongTacFanpage";
		this.plTuongTacFanpage.Size = new System.Drawing.Size(278, 176);
		this.plTuongTacFanpage.TabIndex = 97;
		this.label91.AutoSize = true;
		this.label91.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label91.Location = new System.Drawing.Point(7, 8);
		this.label91.Name = "label91";
		this.label91.Size = new System.Drawing.Size(90, 16);
		this.label91.TabIndex = 0;
		this.label91.Text = "Nhập ID Page:";
		this.label56.AutoSize = true;
		this.label56.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label56.Location = new System.Drawing.Point(7, 38);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(96, 16);
		this.label56.TabIndex = 0;
		this.label56.Text = "Sô\u0301 lươ\u0323ng page:";
		this.nudTuongTacFanpageSoLuongPageFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageSoLuongPageFrom.Location = new System.Drawing.Point(117, 35);
		this.nudTuongTacFanpageSoLuongPageFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongPageFrom.Name = "nudTuongTacFanpageSoLuongPageFrom";
		this.nudTuongTacFanpageSoLuongPageFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFanpageSoLuongPageFrom.TabIndex = 1;
		this.nudTuongTacFanpageSoLuongPageFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label58.AutoSize = true;
		this.label58.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label58.Location = new System.Drawing.Point(7, 67);
		this.label58.Name = "label58";
		this.label58.Size = new System.Drawing.Size(106, 16);
		this.label58.TabIndex = 89;
		this.label58.Text = "Sô\u0301 ba\u0300i viê\u0301t/page:";
		this.label87.AutoSize = true;
		this.label87.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label87.Location = new System.Drawing.Point(239, 38);
		this.label87.Name = "label87";
		this.label87.Size = new System.Drawing.Size(36, 16);
		this.label87.TabIndex = 89;
		this.label87.Text = "page";
		this.label85.AutoSize = true;
		this.label85.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label85.Location = new System.Drawing.Point(239, 67);
		this.label85.Name = "label85";
		this.label85.Size = new System.Drawing.Size(25, 16);
		this.label85.TabIndex = 89;
		this.label85.Text = "ba\u0300i";
		this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button7.Location = new System.Drawing.Point(116, 3);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(75, 27);
		this.button7.TabIndex = 2;
		this.button7.Text = "Nhập";
		this.toolTip_0.SetToolTip(this.button7, "Nhâ\u0323p danh sa\u0301ch ID Page");
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(button7_Click);
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 64);
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Name = "nudTuongTacFanpageSoLuongBaiVietFrom";
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFanpageSoLuongBaiVietFrom.TabIndex = 3;
		this.nudTuongTacFanpageSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacFanpageComment.AutoSize = true;
		this.ckbTuongTacFanpageComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFanpageComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFanpageComment.Location = new System.Drawing.Point(117, 144);
		this.ckbTuongTacFanpageComment.Name = "ckbTuongTacFanpageComment";
		this.ckbTuongTacFanpageComment.Size = new System.Drawing.Size(82, 20);
		this.ckbTuongTacFanpageComment.TabIndex = 7;
		this.ckbTuongTacFanpageComment.Text = "Comment";
		this.ckbTuongTacFanpageComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacFanpageComment.CheckedChanged += new System.EventHandler(ckbTuongTacFanpageComment_CheckedChanged);
		this.btnTuongTacFanpageComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnTuongTacFanpageComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnTuongTacFanpageComment.Location = new System.Drawing.Point(208, 140);
		this.btnTuongTacFanpageComment.Name = "btnTuongTacFanpageComment";
		this.btnTuongTacFanpageComment.Size = new System.Drawing.Size(58, 27);
		this.btnTuongTacFanpageComment.TabIndex = 8;
		this.btnTuongTacFanpageComment.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.btnTuongTacFanpageComment, "Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n");
		this.btnTuongTacFanpageComment.UseVisualStyleBackColor = true;
		this.btnTuongTacFanpageComment.Click += new System.EventHandler(btnTuongTacFanpageComment_Click);
		this.ckbTuongTacFanpageLike.AutoSize = true;
		this.ckbTuongTacFanpageLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFanpageLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFanpageLike.Location = new System.Drawing.Point(117, 121);
		this.ckbTuongTacFanpageLike.Name = "ckbTuongTacFanpageLike";
		this.ckbTuongTacFanpageLike.Size = new System.Drawing.Size(49, 20);
		this.ckbTuongTacFanpageLike.TabIndex = 6;
		this.ckbTuongTacFanpageLike.Text = "Like";
		this.ckbTuongTacFanpageLike.UseVisualStyleBackColor = true;
		this.label59.AutoSize = true;
		this.label59.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label59.Location = new System.Drawing.Point(7, 122);
		this.label59.Name = "label59";
		this.label59.Size = new System.Drawing.Size(94, 16);
		this.label59.TabIndex = 89;
		this.label59.Text = "Loa\u0323i tương ta\u0301c:";
		this.label60.AutoSize = true;
		this.label60.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label60.Location = new System.Drawing.Point(7, 96);
		this.label60.Name = "label60";
		this.label60.Size = new System.Drawing.Size(100, 16);
		this.label60.TabIndex = 89;
		this.label60.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacFanpageDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageDelayFrom.Location = new System.Drawing.Point(117, 93);
		this.nudTuongTacFanpageDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageDelayFrom.Name = "nudTuongTacFanpageDelayFrom";
		this.nudTuongTacFanpageDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFanpageDelayFrom.TabIndex = 4;
		this.nudTuongTacFanpageDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label61.AutoSize = true;
		this.label61.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label61.Location = new System.Drawing.Point(239, 98);
		this.label61.Name = "label61";
		this.label61.Size = new System.Drawing.Size(31, 16);
		this.label61.TabIndex = 91;
		this.label61.Text = "giây";
		this.nudTuongTacFanpageDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageDelayTo.Location = new System.Drawing.Point(194, 94);
		this.nudTuongTacFanpageDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageDelayTo.Name = "nudTuongTacFanpageDelayTo";
		this.nudTuongTacFanpageDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFanpageDelayTo.TabIndex = 5;
		this.nudTuongTacFanpageDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongPageTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageSoLuongPageTo.Location = new System.Drawing.Point(194, 36);
		this.nudTuongTacFanpageSoLuongPageTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongPageTo.Name = "nudTuongTacFanpageSoLuongPageTo";
		this.nudTuongTacFanpageSoLuongPageTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFanpageSoLuongPageTo.TabIndex = 4;
		this.nudTuongTacFanpageSoLuongPageTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFanpageSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 65);
		this.nudTuongTacFanpageSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFanpageSoLuongBaiVietTo.Name = "nudTuongTacFanpageSoLuongBaiVietTo";
		this.nudTuongTacFanpageSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFanpageSoLuongBaiVietTo.TabIndex = 4;
		this.nudTuongTacFanpageSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label86.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label86.Location = new System.Drawing.Point(162, 38);
		this.label86.Name = "label86";
		this.label86.Size = new System.Drawing.Size(29, 16);
		this.label86.TabIndex = 91;
		this.label86.Text = "đê\u0301n";
		this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label62.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label62.Location = new System.Drawing.Point(162, 98);
		this.label62.Name = "label62";
		this.label62.Size = new System.Drawing.Size(29, 16);
		this.label62.TabIndex = 91;
		this.label62.Text = "đê\u0301n";
		this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label57.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label57.Location = new System.Drawing.Point(162, 67);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(29, 16);
		this.label57.TabIndex = 91;
		this.label57.Text = "đê\u0301n";
		this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plTuongTacGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacGroup.Controls.Add(this.label7);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomFrom);
		this.plTuongTacGroup.Controls.Add(this.label18);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietFrom);
		this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupComment);
		this.plTuongTacGroup.Controls.Add(this.btnTuongTacGroupComment);
		this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupLike);
		this.plTuongTacGroup.Controls.Add(this.label50);
		this.plTuongTacGroup.Controls.Add(this.label51);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietTo);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayFrom);
		this.plTuongTacGroup.Controls.Add(this.label55);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayTo);
		this.plTuongTacGroup.Controls.Add(this.label53);
		this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomTo);
		this.plTuongTacGroup.Controls.Add(this.label88);
		this.plTuongTacGroup.Controls.Add(this.label89);
		this.plTuongTacGroup.Controls.Add(this.label90);
		this.plTuongTacGroup.Controls.Add(this.label52);
		this.plTuongTacGroup.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacGroup.Location = new System.Drawing.Point(358, 225);
		this.plTuongTacGroup.Name = "plTuongTacGroup";
		this.plTuongTacGroup.Size = new System.Drawing.Size(278, 149);
		this.plTuongTacGroup.TabIndex = 6;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(7, 8);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(100, 16);
		this.label7.TabIndex = 89;
		this.label7.Text = "Sô\u0301 lươ\u0323ng nho\u0301m:";
		this.nudTuongTacGroupSoLuongNhomFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupSoLuongNhomFrom.Location = new System.Drawing.Point(117, 5);
		this.nudTuongTacGroupSoLuongNhomFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupSoLuongNhomFrom.Name = "nudTuongTacGroupSoLuongNhomFrom";
		this.nudTuongTacGroupSoLuongNhomFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacGroupSoLuongNhomFrom.TabIndex = 0;
		this.nudTuongTacGroupSoLuongNhomFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label89.AutoSize = true;
		this.label89.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label89.Location = new System.Drawing.Point(239, 8);
		this.label89.Name = "label89";
		this.label89.Size = new System.Drawing.Size(40, 16);
		this.label89.TabIndex = 89;
		this.label89.Text = "nho\u0301m";
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label18.Location = new System.Drawing.Point(7, 37);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(110, 16);
		this.label18.TabIndex = 89;
		this.label18.Text = "Sô\u0301 ba\u0300i viê\u0301t/nho\u0301m:";
		this.nudTuongTacGroupSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 34);
		this.nudTuongTacGroupSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupSoLuongBaiVietFrom.Name = "nudTuongTacGroupSoLuongBaiVietFrom";
		this.nudTuongTacGroupSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacGroupSoLuongBaiVietFrom.TabIndex = 1;
		this.nudTuongTacGroupSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacGroupComment.AutoSize = true;
		this.ckbTuongTacGroupComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacGroupComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacGroupComment.Location = new System.Drawing.Point(117, 117);
		this.ckbTuongTacGroupComment.Name = "ckbTuongTacGroupComment";
		this.ckbTuongTacGroupComment.Size = new System.Drawing.Size(82, 20);
		this.ckbTuongTacGroupComment.TabIndex = 5;
		this.ckbTuongTacGroupComment.Text = "Comment";
		this.ckbTuongTacGroupComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacGroupComment.CheckedChanged += new System.EventHandler(ckbTuongTacGroupComment_CheckedChanged);
		this.btnTuongTacGroupComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnTuongTacGroupComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnTuongTacGroupComment.Location = new System.Drawing.Point(208, 113);
		this.btnTuongTacGroupComment.Name = "btnTuongTacGroupComment";
		this.btnTuongTacGroupComment.Size = new System.Drawing.Size(58, 27);
		this.btnTuongTacGroupComment.TabIndex = 6;
		this.btnTuongTacGroupComment.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.btnTuongTacGroupComment, "Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n");
		this.btnTuongTacGroupComment.UseVisualStyleBackColor = true;
		this.btnTuongTacGroupComment.Click += new System.EventHandler(btnTuongTacGroupComment_Click);
		this.ckbTuongTacGroupLike.AutoSize = true;
		this.ckbTuongTacGroupLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacGroupLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacGroupLike.Location = new System.Drawing.Point(117, 92);
		this.ckbTuongTacGroupLike.Name = "ckbTuongTacGroupLike";
		this.ckbTuongTacGroupLike.Size = new System.Drawing.Size(49, 20);
		this.ckbTuongTacGroupLike.TabIndex = 4;
		this.ckbTuongTacGroupLike.Text = "Like";
		this.ckbTuongTacGroupLike.UseVisualStyleBackColor = true;
		this.label90.AutoSize = true;
		this.label90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label90.Location = new System.Drawing.Point(240, 38);
		this.label90.Name = "label90";
		this.label90.Size = new System.Drawing.Size(25, 16);
		this.label90.TabIndex = 91;
		this.label90.Text = "ba\u0300i";
		this.label50.AutoSize = true;
		this.label50.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label50.Location = new System.Drawing.Point(7, 93);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(94, 16);
		this.label50.TabIndex = 89;
		this.label50.Text = "Loa\u0323i tương ta\u0301c:";
		this.label51.AutoSize = true;
		this.label51.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label51.Location = new System.Drawing.Point(7, 66);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(100, 16);
		this.label51.TabIndex = 89;
		this.label51.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacGroupSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 35);
		this.nudTuongTacGroupSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupSoLuongBaiVietTo.Name = "nudTuongTacGroupSoLuongBaiVietTo";
		this.nudTuongTacGroupSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacGroupSoLuongBaiVietTo.TabIndex = 2;
		this.nudTuongTacGroupSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacGroupDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupDelayFrom.Location = new System.Drawing.Point(117, 63);
		this.nudTuongTacGroupDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupDelayFrom.Name = "nudTuongTacGroupDelayFrom";
		this.nudTuongTacGroupDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacGroupDelayFrom.TabIndex = 2;
		this.nudTuongTacGroupDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label55.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label55.Location = new System.Drawing.Point(162, 38);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(29, 16);
		this.label55.TabIndex = 91;
		this.label55.Text = "đê\u0301n";
		this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label52.AutoSize = true;
		this.label52.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label52.Location = new System.Drawing.Point(240, 68);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(31, 16);
		this.label52.TabIndex = 91;
		this.label52.Text = "giây";
		this.nudTuongTacGroupDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupDelayTo.Location = new System.Drawing.Point(194, 64);
		this.nudTuongTacGroupDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupDelayTo.Name = "nudTuongTacGroupDelayTo";
		this.nudTuongTacGroupDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacGroupDelayTo.TabIndex = 3;
		this.nudTuongTacGroupDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label53.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label53.Location = new System.Drawing.Point(162, 68);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(29, 16);
		this.label53.TabIndex = 91;
		this.label53.Text = "đê\u0301n";
		this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudTuongTacGroupSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacGroupSoLuongNhomTo.Location = new System.Drawing.Point(194, 5);
		this.nudTuongTacGroupSoLuongNhomTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacGroupSoLuongNhomTo.Name = "nudTuongTacGroupSoLuongNhomTo";
		this.nudTuongTacGroupSoLuongNhomTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacGroupSoLuongNhomTo.TabIndex = 4;
		this.nudTuongTacGroupSoLuongNhomTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label88.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label88.Location = new System.Drawing.Point(162, 8);
		this.label88.Name = "label88";
		this.label88.Size = new System.Drawing.Size(29, 16);
		this.label88.TabIndex = 91;
		this.label88.Text = "đê\u0301n";
		this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plTuongTacFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacFriend.Controls.Add(this.label49);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeFrom);
		this.plTuongTacFriend.Controls.Add(this.label19);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietFrom);
		this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendComment);
		this.plTuongTacFriend.Controls.Add(this.btnTuongTacFriendComment);
		this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendLike);
		this.plTuongTacFriend.Controls.Add(this.label33);
		this.plTuongTacFriend.Controls.Add(this.label46);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayFrom);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietTo);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeTo);
		this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayTo);
		this.plTuongTacFriend.Controls.Add(this.label67);
		this.plTuongTacFriend.Controls.Add(this.label66);
		this.plTuongTacFriend.Controls.Add(this.label48);
		this.plTuongTacFriend.Controls.Add(this.label68);
		this.plTuongTacFriend.Controls.Add(this.label54);
		this.plTuongTacFriend.Controls.Add(this.label47);
		this.plTuongTacFriend.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacFriend.Location = new System.Drawing.Point(356, 46);
		this.plTuongTacFriend.Name = "plTuongTacFriend";
		this.plTuongTacFriend.Size = new System.Drawing.Size(278, 151);
		this.plTuongTacFriend.TabIndex = 4;
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(7, 8);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(107, 16);
		this.label49.TabIndex = 0;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		this.nudTuongTacFriendSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendSoLuongBanBeFrom.Location = new System.Drawing.Point(117, 5);
		this.nudTuongTacFriendSoLuongBanBeFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendSoLuongBanBeFrom.Name = "nudTuongTacFriendSoLuongBanBeFrom";
		this.nudTuongTacFriendSoLuongBanBeFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFriendSoLuongBanBeFrom.TabIndex = 1;
		this.nudTuongTacFriendSoLuongBanBeFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(240, 8);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(29, 16);
		this.label68.TabIndex = 89;
		this.label68.Text = "ba\u0323n";
		this.label54.AutoSize = true;
		this.label54.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label54.Location = new System.Drawing.Point(240, 37);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(25, 16);
		this.label54.TabIndex = 89;
		this.label54.Text = "ba\u0300i";
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(7, 37);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(99, 16);
		this.label19.TabIndex = 89;
		this.label19.Text = "Sô\u0301 ba\u0300i viê\u0301t/ba\u0323n:";
		this.nudTuongTacFriendSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 34);
		this.nudTuongTacFriendSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendSoLuongBaiVietFrom.Name = "nudTuongTacFriendSoLuongBaiVietFrom";
		this.nudTuongTacFriendSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFriendSoLuongBaiVietFrom.TabIndex = 2;
		this.nudTuongTacFriendSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacFriendComment.AutoSize = true;
		this.ckbTuongTacFriendComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFriendComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFriendComment.Location = new System.Drawing.Point(117, 118);
		this.ckbTuongTacFriendComment.Name = "ckbTuongTacFriendComment";
		this.ckbTuongTacFriendComment.Size = new System.Drawing.Size(82, 20);
		this.ckbTuongTacFriendComment.TabIndex = 6;
		this.ckbTuongTacFriendComment.Text = "Comment";
		this.ckbTuongTacFriendComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacFriendComment.CheckedChanged += new System.EventHandler(ckbTuongTacFriendComment_CheckedChanged);
		this.btnTuongTacFriendComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnTuongTacFriendComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnTuongTacFriendComment.Location = new System.Drawing.Point(208, 114);
		this.btnTuongTacFriendComment.Name = "btnTuongTacFriendComment";
		this.btnTuongTacFriendComment.Size = new System.Drawing.Size(58, 27);
		this.btnTuongTacFriendComment.TabIndex = 7;
		this.btnTuongTacFriendComment.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.btnTuongTacFriendComment, "Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n");
		this.btnTuongTacFriendComment.UseVisualStyleBackColor = true;
		this.btnTuongTacFriendComment.Click += new System.EventHandler(btnTuongTacFriendComment_Click);
		this.ckbTuongTacFriendLike.AutoSize = true;
		this.ckbTuongTacFriendLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFriendLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFriendLike.Location = new System.Drawing.Point(117, 93);
		this.ckbTuongTacFriendLike.Name = "ckbTuongTacFriendLike";
		this.ckbTuongTacFriendLike.Size = new System.Drawing.Size(49, 20);
		this.ckbTuongTacFriendLike.TabIndex = 5;
		this.ckbTuongTacFriendLike.Text = "Like";
		this.ckbTuongTacFriendLike.UseVisualStyleBackColor = true;
		this.label33.AutoSize = true;
		this.label33.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label33.Location = new System.Drawing.Point(7, 94);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(94, 16);
		this.label33.TabIndex = 89;
		this.label33.Text = "Loa\u0323i tương ta\u0301c:";
		this.label46.AutoSize = true;
		this.label46.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label46.Location = new System.Drawing.Point(7, 66);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(100, 16);
		this.label46.TabIndex = 89;
		this.label46.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacFriendDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendDelayFrom.Location = new System.Drawing.Point(117, 63);
		this.nudTuongTacFriendDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendDelayFrom.Name = "nudTuongTacFriendDelayFrom";
		this.nudTuongTacFriendDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacFriendDelayFrom.TabIndex = 3;
		this.nudTuongTacFriendDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label47.AutoSize = true;
		this.label47.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label47.Location = new System.Drawing.Point(240, 68);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(31, 16);
		this.label47.TabIndex = 91;
		this.label47.Text = "giây";
		this.nudTuongTacFriendSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 35);
		this.nudTuongTacFriendSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendSoLuongBaiVietTo.Name = "nudTuongTacFriendSoLuongBaiVietTo";
		this.nudTuongTacFriendSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFriendSoLuongBaiVietTo.TabIndex = 4;
		this.nudTuongTacFriendSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacFriendSoLuongBanBeTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendSoLuongBanBeTo.Location = new System.Drawing.Point(194, 6);
		this.nudTuongTacFriendSoLuongBanBeTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendSoLuongBanBeTo.Name = "nudTuongTacFriendSoLuongBanBeTo";
		this.nudTuongTacFriendSoLuongBanBeTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFriendSoLuongBanBeTo.TabIndex = 4;
		this.nudTuongTacFriendSoLuongBanBeTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacFriendDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacFriendDelayTo.Location = new System.Drawing.Point(194, 64);
		this.nudTuongTacFriendDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacFriendDelayTo.Name = "nudTuongTacFriendDelayTo";
		this.nudTuongTacFriendDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacFriendDelayTo.TabIndex = 4;
		this.nudTuongTacFriendDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label67.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label67.Location = new System.Drawing.Point(162, 37);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(29, 16);
		this.label67.TabIndex = 91;
		this.label67.Text = "đê\u0301n";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(162, 8);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 91;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label48.Location = new System.Drawing.Point(162, 68);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(29, 16);
		this.label48.TabIndex = 91;
		this.label48.Text = "đê\u0301n";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plTuongTacNewsfeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacNewsfeed.Controls.Add(this.label1);
		this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongFrom);
		this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedComment);
		this.plTuongTacNewsfeed.Controls.Add(this.btnTuongTacNewsfeedComment);
		this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedLike);
		this.plTuongTacNewsfeed.Controls.Add(this.label8);
		this.plTuongTacNewsfeed.Controls.Add(this.label24);
		this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayFrom);
		this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongTo);
		this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayTo);
		this.plTuongTacNewsfeed.Controls.Add(this.label64);
		this.plTuongTacNewsfeed.Controls.Add(this.label25);
		this.plTuongTacNewsfeed.Controls.Add(this.label65);
		this.plTuongTacNewsfeed.Controls.Add(this.label29);
		this.plTuongTacNewsfeed.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTacNewsfeed.Location = new System.Drawing.Point(41, 46);
		this.plTuongTacNewsfeed.Name = "plTuongTacNewsfeed";
		this.plTuongTacNewsfeed.Size = new System.Drawing.Size(278, 123);
		this.plTuongTacNewsfeed.TabIndex = 2;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(7, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(109, 16);
		this.label1.TabIndex = 89;
		this.label1.Text = "Sô\u0301 lươ\u0323ng ba\u0300i viê\u0301t:";
		this.nudTuongTacNewsfeedSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNewsfeedSoLuongFrom.Location = new System.Drawing.Point(117, 6);
		this.nudTuongTacNewsfeedSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNewsfeedSoLuongFrom.Name = "nudTuongTacNewsfeedSoLuongFrom";
		this.nudTuongTacNewsfeedSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacNewsfeedSoLuongFrom.TabIndex = 0;
		this.nudTuongTacNewsfeedSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacNewsfeedComment.AutoSize = true;
		this.ckbTuongTacNewsfeedComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacNewsfeedComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacNewsfeedComment.Location = new System.Drawing.Point(117, 90);
		this.ckbTuongTacNewsfeedComment.Name = "ckbTuongTacNewsfeedComment";
		this.ckbTuongTacNewsfeedComment.Size = new System.Drawing.Size(82, 20);
		this.ckbTuongTacNewsfeedComment.TabIndex = 4;
		this.ckbTuongTacNewsfeedComment.Text = "Comment";
		this.ckbTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacNewsfeedComment.CheckedChanged += new System.EventHandler(ckbTuongTacNewsfeedComment_CheckedChanged);
		this.btnTuongTacNewsfeedComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnTuongTacNewsfeedComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnTuongTacNewsfeedComment.Location = new System.Drawing.Point(208, 86);
		this.btnTuongTacNewsfeedComment.Name = "btnTuongTacNewsfeedComment";
		this.btnTuongTacNewsfeedComment.Size = new System.Drawing.Size(58, 27);
		this.btnTuongTacNewsfeedComment.TabIndex = 5;
		this.btnTuongTacNewsfeedComment.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.btnTuongTacNewsfeedComment, "Nhâ\u0323p danh sa\u0301ch bi\u0300nh luâ\u0323n");
		this.btnTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
		this.btnTuongTacNewsfeedComment.Click += new System.EventHandler(btnTuongTacNewsfeedComment_Click);
		this.ckbTuongTacNewsfeedLike.AutoSize = true;
		this.ckbTuongTacNewsfeedLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacNewsfeedLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacNewsfeedLike.Location = new System.Drawing.Point(117, 65);
		this.ckbTuongTacNewsfeedLike.Name = "ckbTuongTacNewsfeedLike";
		this.ckbTuongTacNewsfeedLike.Size = new System.Drawing.Size(49, 20);
		this.ckbTuongTacNewsfeedLike.TabIndex = 3;
		this.ckbTuongTacNewsfeedLike.Text = "Like";
		this.ckbTuongTacNewsfeedLike.UseVisualStyleBackColor = true;
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label8.Location = new System.Drawing.Point(7, 66);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(94, 16);
		this.label8.TabIndex = 89;
		this.label8.Text = "Loa\u0323i tương ta\u0301c:";
		this.label24.AutoSize = true;
		this.label24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label24.Location = new System.Drawing.Point(7, 39);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(100, 16);
		this.label24.TabIndex = 89;
		this.label24.Text = "Thơ\u0300i gian delay:";
		this.nudTuongTacNewsfeedDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNewsfeedDelayFrom.Location = new System.Drawing.Point(117, 36);
		this.nudTuongTacNewsfeedDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNewsfeedDelayFrom.Name = "nudTuongTacNewsfeedDelayFrom";
		this.nudTuongTacNewsfeedDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacNewsfeedDelayFrom.TabIndex = 1;
		this.nudTuongTacNewsfeedDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label65.AutoSize = true;
		this.label65.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label65.Location = new System.Drawing.Point(240, 11);
		this.label65.Name = "label65";
		this.label65.Size = new System.Drawing.Size(25, 16);
		this.label65.TabIndex = 91;
		this.label65.Text = "ba\u0300i";
		this.label29.AutoSize = true;
		this.label29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label29.Location = new System.Drawing.Point(240, 40);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(31, 16);
		this.label29.TabIndex = 91;
		this.label29.Text = "giây";
		this.nudTuongTacNewsfeedSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNewsfeedSoLuongTo.Location = new System.Drawing.Point(194, 7);
		this.nudTuongTacNewsfeedSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNewsfeedSoLuongTo.Name = "nudTuongTacNewsfeedSoLuongTo";
		this.nudTuongTacNewsfeedSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacNewsfeedSoLuongTo.TabIndex = 2;
		this.nudTuongTacNewsfeedSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacNewsfeedDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacNewsfeedDelayTo.Location = new System.Drawing.Point(194, 37);
		this.nudTuongTacNewsfeedDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacNewsfeedDelayTo.Name = "nudTuongTacNewsfeedDelayTo";
		this.nudTuongTacNewsfeedDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacNewsfeedDelayTo.TabIndex = 2;
		this.nudTuongTacNewsfeedDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label64.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label64.Location = new System.Drawing.Point(162, 11);
		this.label64.Name = "label64";
		this.label64.Size = new System.Drawing.Size(29, 16);
		this.label64.TabIndex = 91;
		this.label64.Text = "đê\u0301n";
		this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label25.Location = new System.Drawing.Point(162, 41);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(29, 16);
		this.label25.TabIndex = 91;
		this.label25.Text = "đê\u0301n";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbTuongTacFanpage.AutoSize = true;
		this.ckbTuongTacFanpage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFanpage.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFanpage.Location = new System.Drawing.Point(21, 175);
		this.ckbTuongTacFanpage.Name = "ckbTuongTacFanpage";
		this.ckbTuongTacFanpage.Size = new System.Drawing.Size(76, 20);
		this.ckbTuongTacFanpage.TabIndex = 7;
		this.ckbTuongTacFanpage.Text = "Fanpage";
		this.ckbTuongTacFanpage.UseVisualStyleBackColor = true;
		this.ckbTuongTacFanpage.CheckedChanged += new System.EventHandler(ckbTuongTacFanpage_CheckedChanged);
		this.ckbTuongTacGroup.AutoSize = true;
		this.ckbTuongTacGroup.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacGroup.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacGroup.Location = new System.Drawing.Point(338, 204);
		this.ckbTuongTacGroup.Name = "ckbTuongTacGroup";
		this.ckbTuongTacGroup.Size = new System.Drawing.Size(61, 20);
		this.ckbTuongTacGroup.TabIndex = 5;
		this.ckbTuongTacGroup.Text = "Group";
		this.ckbTuongTacGroup.UseVisualStyleBackColor = true;
		this.ckbTuongTacGroup.CheckedChanged += new System.EventHandler(ckbTuongTacGroup_CheckedChanged);
		this.ckbTuongTacNewsfeed.AutoSize = true;
		this.ckbTuongTacNewsfeed.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacNewsfeed.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacNewsfeed.Location = new System.Drawing.Point(23, 22);
		this.ckbTuongTacNewsfeed.Name = "ckbTuongTacNewsfeed";
		this.ckbTuongTacNewsfeed.Size = new System.Drawing.Size(83, 20);
		this.ckbTuongTacNewsfeed.TabIndex = 0;
		this.ckbTuongTacNewsfeed.Text = "Newsfeed";
		this.ckbTuongTacNewsfeed.UseVisualStyleBackColor = true;
		this.ckbTuongTacNewsfeed.CheckedChanged += new System.EventHandler(ckbTuongTacNewsfeed_CheckedChanged);
		this.ckbTuongTacFriend.AutoSize = true;
		this.ckbTuongTacFriend.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacFriend.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacFriend.Location = new System.Drawing.Point(338, 22);
		this.ckbTuongTacFriend.Name = "ckbTuongTacFriend";
		this.ckbTuongTacFriend.Size = new System.Drawing.Size(63, 20);
		this.ckbTuongTacFriend.TabIndex = 3;
		this.ckbTuongTacFriend.Text = "Friend";
		this.ckbTuongTacFriend.UseVisualStyleBackColor = true;
		this.ckbTuongTacFriend.CheckedChanged += new System.EventHandler(ckbTuongTacFriend_CheckedChanged);
		this.groupBox8.Controls.Add(this.ckbKetBanTuKhoa);
		this.groupBox8.Controls.Add(this.plKetBanTepUid);
		this.groupBox8.Controls.Add(this.plKetBanTuKhoa);
		this.groupBox8.Controls.Add(this.ckbKetBanGoiY);
		this.groupBox8.Controls.Add(this.plXacNhanKetBan);
		this.groupBox8.Controls.Add(this.plKetBanGoiY);
		this.groupBox8.Controls.Add(this.ckbKetBanTepUid);
		this.groupBox8.Controls.Add(this.ckbXacNhanKetBan);
		this.groupBox8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox8.Location = new System.Drawing.Point(7, 424);
		this.groupBox8.Name = "groupBox8";
		this.groupBox8.Size = new System.Drawing.Size(649, 243);
		this.groupBox8.TabIndex = 3;
		this.groupBox8.TabStop = false;
		this.groupBox8.Text = "Kê\u0301t ba\u0323n";
		this.ckbKetBanTuKhoa.AutoSize = true;
		this.ckbKetBanTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKetBanTuKhoa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbKetBanTuKhoa.Location = new System.Drawing.Point(23, 20);
		this.ckbKetBanTuKhoa.Name = "ckbKetBanTuKhoa";
		this.ckbKetBanTuKhoa.Size = new System.Drawing.Size(146, 20);
		this.ckbKetBanTuKhoa.TabIndex = 0;
		this.ckbKetBanTuKhoa.Text = "Kết bạn theo tư\u0300 kho\u0301a";
		this.ckbKetBanTuKhoa.UseVisualStyleBackColor = true;
		this.ckbKetBanTuKhoa.CheckedChanged += new System.EventHandler(ckbKetBanTuKhoa_CheckedChanged);
		this.plKetBanTepUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plKetBanTepUid.Controls.Add(this.ckbKetBanTepUidTrungNhau);
		this.plKetBanTepUid.Controls.Add(this.label17);
		this.plKetBanTepUid.Controls.Add(this.label20);
		this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongFrom);
		this.plKetBanTepUid.Controls.Add(this.label21);
		this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayFrom);
		this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayTo);
		this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongTo);
		this.plKetBanTepUid.Controls.Add(this.label73);
		this.plKetBanTepUid.Controls.Add(this.button8);
		this.plKetBanTepUid.Controls.Add(this.label23);
		this.plKetBanTepUid.Controls.Add(this.label22);
		this.plKetBanTepUid.Controls.Add(this.label74);
		this.plKetBanTepUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plKetBanTepUid.Location = new System.Drawing.Point(358, 43);
		this.plKetBanTepUid.Name = "plKetBanTepUid";
		this.plKetBanTepUid.Size = new System.Drawing.Size(278, 105);
		this.plKetBanTepUid.TabIndex = 5;
		this.ckbKetBanTepUidTrungNhau.AutoSize = true;
		this.ckbKetBanTepUidTrungNhau.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKetBanTepUidTrungNhau.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbKetBanTepUidTrungNhau.Location = new System.Drawing.Point(10, 82);
		this.ckbKetBanTepUidTrungNhau.Name = "ckbKetBanTepUidTrungNhau";
		this.ckbKetBanTepUidTrungNhau.Size = new System.Drawing.Size(193, 20);
		this.ckbKetBanTepUidTrungNhau.TabIndex = 112;
		this.ckbKetBanTepUidTrungNhau.Text = "Cho phép kết bạn trùng nhau";
		this.ckbKetBanTepUidTrungNhau.UseVisualStyleBackColor = true;
		this.ckbKetBanTepUidTrungNhau.CheckedChanged += new System.EventHandler(ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label17.Location = new System.Drawing.Point(7, 7);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(88, 16);
		this.label17.TabIndex = 89;
		this.label17.Text = "Nhâ\u0323p tê\u0323p UID:";
		this.label20.AutoSize = true;
		this.label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label20.Location = new System.Drawing.Point(7, 34);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(64, 16);
		this.label20.TabIndex = 89;
		this.label20.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudKetBanTepUidSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTepUidSoLuongFrom.Location = new System.Drawing.Point(117, 31);
		this.nudKetBanTepUidSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTepUidSoLuongFrom.Name = "nudKetBanTepUidSoLuongFrom";
		this.nudKetBanTepUidSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanTepUidSoLuongFrom.TabIndex = 1;
		this.nudKetBanTepUidSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label21.AutoSize = true;
		this.label21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label21.Location = new System.Drawing.Point(7, 61);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(100, 16);
		this.label21.TabIndex = 89;
		this.label21.Text = "Thơ\u0300i gian delay:";
		this.nudKetBanTepUidDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTepUidDelayFrom.Location = new System.Drawing.Point(117, 57);
		this.nudKetBanTepUidDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTepUidDelayFrom.Name = "nudKetBanTepUidDelayFrom";
		this.nudKetBanTepUidDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanTepUidDelayFrom.TabIndex = 2;
		this.nudKetBanTepUidDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label22.AutoSize = true;
		this.label22.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label22.Location = new System.Drawing.Point(239, 61);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(31, 16);
		this.label22.TabIndex = 91;
		this.label22.Text = "giây";
		this.label74.AutoSize = true;
		this.label74.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label74.Location = new System.Drawing.Point(239, 36);
		this.label74.Name = "label74";
		this.label74.Size = new System.Drawing.Size(29, 16);
		this.label74.TabIndex = 91;
		this.label74.Text = "ba\u0323n";
		this.nudKetBanTepUidDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTepUidDelayTo.Location = new System.Drawing.Point(194, 58);
		this.nudKetBanTepUidDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTepUidDelayTo.Name = "nudKetBanTepUidDelayTo";
		this.nudKetBanTepUidDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanTepUidDelayTo.TabIndex = 3;
		this.nudKetBanTepUidDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudKetBanTepUidSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTepUidSoLuongTo.Location = new System.Drawing.Point(194, 32);
		this.nudKetBanTepUidSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTepUidSoLuongTo.Name = "nudKetBanTepUidSoLuongTo";
		this.nudKetBanTepUidSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanTepUidSoLuongTo.TabIndex = 3;
		this.nudKetBanTepUidSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label73.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label73.Location = new System.Drawing.Point(162, 36);
		this.label73.Name = "label73";
		this.label73.Size = new System.Drawing.Size(29, 16);
		this.label73.TabIndex = 91;
		this.label73.Text = "đê\u0301n";
		this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button8.Location = new System.Drawing.Point(116, 2);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(80, 27);
		this.button8.TabIndex = 0;
		this.button8.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.button8, "Nhâ\u0323p danh sa\u0301ch UID câ\u0300n kê\u0301t ba\u0323n");
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.label23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label23.Location = new System.Drawing.Point(162, 61);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(29, 16);
		this.label23.TabIndex = 91;
		this.label23.Text = "đê\u0301n";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plKetBanTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plKetBanTuKhoa.Controls.Add(this.pictureBox2);
		this.plKetBanTuKhoa.Controls.Add(this.txtKetBanTuKhoaTuKhoa);
		this.plKetBanTuKhoa.Controls.Add(this.label16);
		this.plKetBanTuKhoa.Controls.Add(this.label3);
		this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongFrom);
		this.plKetBanTuKhoa.Controls.Add(this.label9);
		this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayFrom);
		this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongTo);
		this.plKetBanTuKhoa.Controls.Add(this.label69);
		this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayTo);
		this.plKetBanTuKhoa.Controls.Add(this.label15);
		this.plKetBanTuKhoa.Controls.Add(this.label70);
		this.plKetBanTuKhoa.Controls.Add(this.label14);
		this.plKetBanTuKhoa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plKetBanTuKhoa.Location = new System.Drawing.Point(41, 43);
		this.plKetBanTuKhoa.Name = "plKetBanTuKhoa";
		this.plKetBanTuKhoa.Size = new System.Drawing.Size(278, 91);
		this.plKetBanTuKhoa.TabIndex = 1;
		this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		this.pictureBox2.Location = new System.Drawing.Point(249, 3);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(25, 25);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 92;
		this.pictureBox2.TabStop = false;
		this.toolTip_0.SetToolTip(this.pictureBox2, "Có thể nhập nhiều từ khóa, ngăn cách nhau bởi dấu |");
		this.txtKetBanTuKhoaTuKhoa.Location = new System.Drawing.Point(117, 4);
		this.txtKetBanTuKhoaTuKhoa.Name = "txtKetBanTuKhoaTuKhoa";
		this.txtKetBanTuKhoaTuKhoa.Size = new System.Drawing.Size(129, 23);
		this.txtKetBanTuKhoaTuKhoa.TabIndex = 0;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label16.Location = new System.Drawing.Point(7, 7);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(60, 16);
		this.label16.TabIndex = 89;
		this.label16.Text = "Tư\u0300 kho\u0301a:";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label3.Location = new System.Drawing.Point(7, 35);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(64, 16);
		this.label3.TabIndex = 89;
		this.label3.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudKetBanTuKhoaSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTuKhoaSoLuongFrom.Location = new System.Drawing.Point(117, 32);
		this.nudKetBanTuKhoaSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTuKhoaSoLuongFrom.Name = "nudKetBanTuKhoaSoLuongFrom";
		this.nudKetBanTuKhoaSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanTuKhoaSoLuongFrom.TabIndex = 1;
		this.nudKetBanTuKhoaSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label9.Location = new System.Drawing.Point(7, 64);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(100, 16);
		this.label9.TabIndex = 89;
		this.label9.Text = "Thơ\u0300i gian delay:";
		this.nudKetBanTuKhoaDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTuKhoaDelayFrom.Location = new System.Drawing.Point(117, 62);
		this.nudKetBanTuKhoaDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTuKhoaDelayFrom.Name = "nudKetBanTuKhoaDelayFrom";
		this.nudKetBanTuKhoaDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanTuKhoaDelayFrom.TabIndex = 2;
		this.nudKetBanTuKhoaDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label70.AutoSize = true;
		this.label70.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label70.Location = new System.Drawing.Point(239, 36);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(29, 16);
		this.label70.TabIndex = 91;
		this.label70.Text = "ba\u0323n";
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label14.Location = new System.Drawing.Point(239, 66);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(31, 16);
		this.label14.TabIndex = 91;
		this.label14.Text = "giây";
		this.nudKetBanTuKhoaSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTuKhoaSoLuongTo.Location = new System.Drawing.Point(194, 32);
		this.nudKetBanTuKhoaSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTuKhoaSoLuongTo.Name = "nudKetBanTuKhoaSoLuongTo";
		this.nudKetBanTuKhoaSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanTuKhoaSoLuongTo.TabIndex = 3;
		this.nudKetBanTuKhoaSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label69.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label69.Location = new System.Drawing.Point(162, 36);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(29, 16);
		this.label69.TabIndex = 91;
		this.label69.Text = "đê\u0301n";
		this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudKetBanTuKhoaDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanTuKhoaDelayTo.Location = new System.Drawing.Point(194, 62);
		this.nudKetBanTuKhoaDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanTuKhoaDelayTo.Name = "nudKetBanTuKhoaDelayTo";
		this.nudKetBanTuKhoaDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanTuKhoaDelayTo.TabIndex = 3;
		this.nudKetBanTuKhoaDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label15.Location = new System.Drawing.Point(162, 66);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(29, 16);
		this.label15.TabIndex = 91;
		this.label15.Text = "đê\u0301n";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbKetBanGoiY.AutoSize = true;
		this.ckbKetBanGoiY.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKetBanGoiY.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbKetBanGoiY.Location = new System.Drawing.Point(23, 140);
		this.ckbKetBanGoiY.Name = "ckbKetBanGoiY";
		this.ckbKetBanGoiY.Size = new System.Drawing.Size(130, 20);
		this.ckbKetBanGoiY.TabIndex = 2;
		this.ckbKetBanGoiY.Text = "Kết bạn theo gợi ý";
		this.ckbKetBanGoiY.UseVisualStyleBackColor = true;
		this.ckbKetBanGoiY.CheckedChanged += new System.EventHandler(ckbKetBanGoiY_CheckedChanged);
		this.plXacNhanKetBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plXacNhanKetBan.Controls.Add(this.label26);
		this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongFrom);
		this.plXacNhanKetBan.Controls.Add(this.label27);
		this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayFrom);
		this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayTo);
		this.plXacNhanKetBan.Controls.Add(this.label31);
		this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongTo);
		this.plXacNhanKetBan.Controls.Add(this.label75);
		this.plXacNhanKetBan.Controls.Add(this.label30);
		this.plXacNhanKetBan.Controls.Add(this.label76);
		this.plXacNhanKetBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plXacNhanKetBan.Location = new System.Drawing.Point(358, 176);
		this.plXacNhanKetBan.Name = "plXacNhanKetBan";
		this.plXacNhanKetBan.Size = new System.Drawing.Size(278, 61);
		this.plXacNhanKetBan.TabIndex = 97;
		this.label26.AutoSize = true;
		this.label26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label26.Location = new System.Drawing.Point(7, 7);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(64, 16);
		this.label26.TabIndex = 89;
		this.label26.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudXacNhanKetBanSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudXacNhanKetBanSoLuongFrom.Location = new System.Drawing.Point(117, 4);
		this.nudXacNhanKetBanSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudXacNhanKetBanSoLuongFrom.Name = "nudXacNhanKetBanSoLuongFrom";
		this.nudXacNhanKetBanSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudXacNhanKetBanSoLuongFrom.TabIndex = 0;
		this.nudXacNhanKetBanSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label27.AutoSize = true;
		this.label27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label27.Location = new System.Drawing.Point(7, 34);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(100, 16);
		this.label27.TabIndex = 89;
		this.label27.Text = "Thơ\u0300i gian delay:";
		this.nudXacNhanKetBanDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudXacNhanKetBanDelayFrom.Location = new System.Drawing.Point(117, 31);
		this.nudXacNhanKetBanDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudXacNhanKetBanDelayFrom.Name = "nudXacNhanKetBanDelayFrom";
		this.nudXacNhanKetBanDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudXacNhanKetBanDelayFrom.TabIndex = 1;
		this.nudXacNhanKetBanDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label30.AutoSize = true;
		this.label30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label30.Location = new System.Drawing.Point(239, 36);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(31, 16);
		this.label30.TabIndex = 91;
		this.label30.Text = "giây";
		this.nudXacNhanKetBanDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudXacNhanKetBanDelayTo.Location = new System.Drawing.Point(194, 32);
		this.nudXacNhanKetBanDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudXacNhanKetBanDelayTo.Name = "nudXacNhanKetBanDelayTo";
		this.nudXacNhanKetBanDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudXacNhanKetBanDelayTo.TabIndex = 2;
		this.nudXacNhanKetBanDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label31.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label31.Location = new System.Drawing.Point(162, 36);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(29, 16);
		this.label31.TabIndex = 91;
		this.label31.Text = "đê\u0301n";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label76.AutoSize = true;
		this.label76.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label76.Location = new System.Drawing.Point(239, 9);
		this.label76.Name = "label76";
		this.label76.Size = new System.Drawing.Size(29, 16);
		this.label76.TabIndex = 91;
		this.label76.Text = "ba\u0323n";
		this.nudXacNhanKetBanSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudXacNhanKetBanSoLuongTo.Location = new System.Drawing.Point(194, 5);
		this.nudXacNhanKetBanSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudXacNhanKetBanSoLuongTo.Name = "nudXacNhanKetBanSoLuongTo";
		this.nudXacNhanKetBanSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudXacNhanKetBanSoLuongTo.TabIndex = 3;
		this.nudXacNhanKetBanSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label75.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label75.Location = new System.Drawing.Point(162, 9);
		this.label75.Name = "label75";
		this.label75.Size = new System.Drawing.Size(29, 16);
		this.label75.TabIndex = 91;
		this.label75.Text = "đê\u0301n";
		this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plKetBanGoiY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plKetBanGoiY.Controls.Add(this.label2);
		this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongFrom);
		this.plKetBanGoiY.Controls.Add(this.label4);
		this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayFrom);
		this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayTo);
		this.plKetBanGoiY.Controls.Add(this.label6);
		this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongTo);
		this.plKetBanGoiY.Controls.Add(this.label71);
		this.plKetBanGoiY.Controls.Add(this.label5);
		this.plKetBanGoiY.Controls.Add(this.label72);
		this.plKetBanGoiY.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plKetBanGoiY.Location = new System.Drawing.Point(41, 162);
		this.plKetBanGoiY.Name = "plKetBanGoiY";
		this.plKetBanGoiY.Size = new System.Drawing.Size(278, 64);
		this.plKetBanGoiY.TabIndex = 3;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(7, 7);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(64, 16);
		this.label2.TabIndex = 89;
		this.label2.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudKetBanGoiYSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanGoiYSoLuongFrom.Location = new System.Drawing.Point(117, 4);
		this.nudKetBanGoiYSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanGoiYSoLuongFrom.Name = "nudKetBanGoiYSoLuongFrom";
		this.nudKetBanGoiYSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanGoiYSoLuongFrom.TabIndex = 0;
		this.nudKetBanGoiYSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label4.Location = new System.Drawing.Point(7, 36);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(100, 16);
		this.label4.TabIndex = 89;
		this.label4.Text = "Thơ\u0300i gian delay:";
		this.nudKetBanGoiYDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanGoiYDelayFrom.Location = new System.Drawing.Point(117, 33);
		this.nudKetBanGoiYDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanGoiYDelayFrom.Name = "nudKetBanGoiYDelayFrom";
		this.nudKetBanGoiYDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudKetBanGoiYDelayFrom.TabIndex = 1;
		this.nudKetBanGoiYDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label5.Location = new System.Drawing.Point(239, 38);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(31, 16);
		this.label5.TabIndex = 91;
		this.label5.Text = "giây";
		this.nudKetBanGoiYDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanGoiYDelayTo.Location = new System.Drawing.Point(194, 34);
		this.nudKetBanGoiYDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanGoiYDelayTo.Name = "nudKetBanGoiYDelayTo";
		this.nudKetBanGoiYDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanGoiYDelayTo.TabIndex = 2;
		this.nudKetBanGoiYDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label6.Location = new System.Drawing.Point(162, 38);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(29, 16);
		this.label6.TabIndex = 91;
		this.label6.Text = "đê\u0301n";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label72.AutoSize = true;
		this.label72.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label72.Location = new System.Drawing.Point(239, 9);
		this.label72.Name = "label72";
		this.label72.Size = new System.Drawing.Size(29, 16);
		this.label72.TabIndex = 91;
		this.label72.Text = "ba\u0323n";
		this.nudKetBanGoiYSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudKetBanGoiYSoLuongTo.Location = new System.Drawing.Point(194, 5);
		this.nudKetBanGoiYSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudKetBanGoiYSoLuongTo.Name = "nudKetBanGoiYSoLuongTo";
		this.nudKetBanGoiYSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudKetBanGoiYSoLuongTo.TabIndex = 3;
		this.nudKetBanGoiYSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label71.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label71.Location = new System.Drawing.Point(162, 9);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(29, 16);
		this.label71.TabIndex = 91;
		this.label71.Text = "đê\u0301n";
		this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbKetBanTepUid.AutoSize = true;
		this.ckbKetBanTepUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKetBanTepUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbKetBanTepUid.Location = new System.Drawing.Point(338, 20);
		this.ckbKetBanTepUid.Name = "ckbKetBanTepUid";
		this.ckbKetBanTepUid.Size = new System.Drawing.Size(145, 20);
		this.ckbKetBanTepUid.TabIndex = 4;
		this.ckbKetBanTepUid.Text = "Kết bạn theo tệp UID";
		this.ckbKetBanTepUid.UseVisualStyleBackColor = true;
		this.ckbKetBanTepUid.CheckedChanged += new System.EventHandler(ckbKetBanTepUid_CheckedChanged);
		this.ckbXacNhanKetBan.AutoSize = true;
		this.ckbXacNhanKetBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXacNhanKetBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbXacNhanKetBan.Location = new System.Drawing.Point(338, 154);
		this.ckbXacNhanKetBan.Name = "ckbXacNhanKetBan";
		this.ckbXacNhanKetBan.Size = new System.Drawing.Size(126, 20);
		this.ckbXacNhanKetBan.TabIndex = 6;
		this.ckbXacNhanKetBan.Text = "Xác nhận kết bạn";
		this.ckbXacNhanKetBan.UseVisualStyleBackColor = true;
		this.ckbXacNhanKetBan.CheckedChanged += new System.EventHandler(ckbXacNhanKetBan_CheckedChanged);
		this.groupBox7.Controls.Add(this.ckbThamGiaNhom);
		this.groupBox7.Controls.Add(this.plThamGiaNhom);
		this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox7.Location = new System.Drawing.Point(662, 424);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(344, 243);
		this.groupBox7.TabIndex = 4;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "Tham gia nho\u0301m";
		this.ckbThamGiaNhom.AutoSize = true;
		this.ckbThamGiaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThamGiaNhom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbThamGiaNhom.Location = new System.Drawing.Point(23, 22);
		this.ckbThamGiaNhom.Name = "ckbThamGiaNhom";
		this.ckbThamGiaNhom.Size = new System.Drawing.Size(184, 20);
		this.ckbThamGiaNhom.TabIndex = 0;
		this.ckbThamGiaNhom.Text = "Tham gia nhóm theo tê\u0323p ID";
		this.ckbThamGiaNhom.UseVisualStyleBackColor = true;
		this.ckbThamGiaNhom.CheckedChanged += new System.EventHandler(ckbThamGiaNhom_CheckedChanged);
		this.plThamGiaNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTrungNhau);
		this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTraLoiCauHoi);
		this.plThamGiaNhom.Controls.Add(this.label12);
		this.plThamGiaNhom.Controls.Add(this.label13);
		this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongFrom);
		this.plThamGiaNhom.Controls.Add(this.label32);
		this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayFrom);
		this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongTo);
		this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayTo);
		this.plThamGiaNhom.Controls.Add(this.btnThamGiaNhomTraLoiCauHoi);
		this.plThamGiaNhom.Controls.Add(this.label77);
		this.plThamGiaNhom.Controls.Add(this.button1);
		this.plThamGiaNhom.Controls.Add(this.label63);
		this.plThamGiaNhom.Controls.Add(this.label78);
		this.plThamGiaNhom.Controls.Add(this.label34);
		this.plThamGiaNhom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plThamGiaNhom.Location = new System.Drawing.Point(39, 43);
		this.plThamGiaNhom.Name = "plThamGiaNhom";
		this.plThamGiaNhom.Size = new System.Drawing.Size(291, 148);
		this.plThamGiaNhom.TabIndex = 1;
		this.ckbThamGiaNhomTrungNhau.AutoSize = true;
		this.ckbThamGiaNhomTrungNhau.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThamGiaNhomTrungNhau.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbThamGiaNhomTrungNhau.Location = new System.Drawing.Point(10, 92);
		this.ckbThamGiaNhomTrungNhau.Name = "ckbThamGiaNhomTrungNhau";
		this.ckbThamGiaNhomTrungNhau.Size = new System.Drawing.Size(237, 20);
		this.ckbThamGiaNhomTrungNhau.TabIndex = 112;
		this.ckbThamGiaNhomTrungNhau.Text = "Cho phép tham gia nhóm trùng nhau";
		this.ckbThamGiaNhomTrungNhau.UseVisualStyleBackColor = true;
		this.ckbThamGiaNhomTrungNhau.CheckedChanged += new System.EventHandler(ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
		this.ckbThamGiaNhomTraLoiCauHoi.AutoSize = true;
		this.ckbThamGiaNhomTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThamGiaNhomTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbThamGiaNhomTraLoiCauHoi.Location = new System.Drawing.Point(10, 118);
		this.ckbThamGiaNhomTraLoiCauHoi.Name = "ckbThamGiaNhomTraLoiCauHoi";
		this.ckbThamGiaNhomTraLoiCauHoi.Size = new System.Drawing.Size(157, 20);
		this.ckbThamGiaNhomTraLoiCauHoi.TabIndex = 112;
		this.ckbThamGiaNhomTraLoiCauHoi.Text = "Tư\u0323 đô\u0323ng tra\u0309 lơ\u0300i câu ho\u0309i";
		this.ckbThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
		this.ckbThamGiaNhomTraLoiCauHoi.CheckedChanged += new System.EventHandler(ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label12.Location = new System.Drawing.Point(10, 7);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(80, 16);
		this.label12.TabIndex = 89;
		this.label12.Text = "Nhâ\u0323p tê\u0323p ID:";
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label13.Location = new System.Drawing.Point(10, 35);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 89;
		this.label13.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudThamGiaNhomSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudThamGiaNhomSoLuongFrom.Location = new System.Drawing.Point(127, 33);
		this.nudThamGiaNhomSoLuongFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudThamGiaNhomSoLuongFrom.Name = "nudThamGiaNhomSoLuongFrom";
		this.nudThamGiaNhomSoLuongFrom.Size = new System.Drawing.Size(42, 23);
		this.nudThamGiaNhomSoLuongFrom.TabIndex = 1;
		this.nudThamGiaNhomSoLuongFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label32.AutoSize = true;
		this.label32.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label32.Location = new System.Drawing.Point(10, 64);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(100, 16);
		this.label32.TabIndex = 89;
		this.label32.Text = "Thơ\u0300i gian delay:";
		this.nudThamGiaNhomDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudThamGiaNhomDelayFrom.Location = new System.Drawing.Point(127, 62);
		this.nudThamGiaNhomDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudThamGiaNhomDelayFrom.Name = "nudThamGiaNhomDelayFrom";
		this.nudThamGiaNhomDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudThamGiaNhomDelayFrom.TabIndex = 2;
		this.nudThamGiaNhomDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label78.AutoSize = true;
		this.label78.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label78.Location = new System.Drawing.Point(250, 37);
		this.label78.Name = "label78";
		this.label78.Size = new System.Drawing.Size(40, 16);
		this.label78.TabIndex = 91;
		this.label78.Text = "nho\u0301m";
		this.label34.AutoSize = true;
		this.label34.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label34.Location = new System.Drawing.Point(250, 65);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(31, 16);
		this.label34.TabIndex = 91;
		this.label34.Text = "giây";
		this.nudThamGiaNhomSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudThamGiaNhomSoLuongTo.Location = new System.Drawing.Point(204, 32);
		this.nudThamGiaNhomSoLuongTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudThamGiaNhomSoLuongTo.Name = "nudThamGiaNhomSoLuongTo";
		this.nudThamGiaNhomSoLuongTo.Size = new System.Drawing.Size(47, 23);
		this.nudThamGiaNhomSoLuongTo.TabIndex = 3;
		this.nudThamGiaNhomSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudThamGiaNhomDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudThamGiaNhomDelayTo.Location = new System.Drawing.Point(204, 62);
		this.nudThamGiaNhomDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudThamGiaNhomDelayTo.Name = "nudThamGiaNhomDelayTo";
		this.nudThamGiaNhomDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudThamGiaNhomDelayTo.TabIndex = 3;
		this.nudThamGiaNhomDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.btnThamGiaNhomTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnThamGiaNhomTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnThamGiaNhomTraLoiCauHoi.Location = new System.Drawing.Point(170, 114);
		this.btnThamGiaNhomTraLoiCauHoi.Name = "btnThamGiaNhomTraLoiCauHoi";
		this.btnThamGiaNhomTraLoiCauHoi.Size = new System.Drawing.Size(103, 27);
		this.btnThamGiaNhomTraLoiCauHoi.TabIndex = 4;
		this.btnThamGiaNhomTraLoiCauHoi.Text = "Nhâ\u0323p nô\u0323i dung";
		this.toolTip_0.SetToolTip(this.btnThamGiaNhomTraLoiCauHoi, "Nhâ\u0323p danh sa\u0301ch nô\u0323i dung câu tra\u0309 lơ\u0300i");
		this.btnThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
		this.btnThamGiaNhomTraLoiCauHoi.Click += new System.EventHandler(btnThamGiaNhomTraLoiCauHoi_Click);
		this.label77.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label77.Location = new System.Drawing.Point(172, 37);
		this.label77.Name = "label77";
		this.label77.Size = new System.Drawing.Size(29, 16);
		this.label77.TabIndex = 91;
		this.label77.Text = "đê\u0301n";
		this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button1.Location = new System.Drawing.Point(126, 2);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(80, 27);
		this.button1.TabIndex = 0;
		this.button1.Text = "Nhâ\u0323p";
		this.toolTip_0.SetToolTip(this.button1, "Nhâ\u0323p danh sa\u0301ch ID nho\u0301m câ\u0300n tham gia");
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.label63.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label63.Location = new System.Drawing.Point(172, 65);
		this.label63.Name = "label63";
		this.label63.Size = new System.Drawing.Size(29, 16);
		this.label63.TabIndex = 91;
		this.label63.Text = "đê\u0301n";
		this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.toolTip_0.ToolTipTitle = "Chú thích";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1012, 716);
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.groupBox4);
		base.Controls.Add(this.groupBox8);
		base.Controls.Add(this.groupBox7);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fConfigInteract";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fConfigInteract_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		this.plTuongTacCMSN.ResumeLayout(false);
		this.plTuongTacCMSN.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayTo).EndInit();
		this.plTuongTacNhanTin.ResumeLayout(false);
		this.plTuongTacNhanTin.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongTo).EndInit();
		this.plTuongTacChoc.ResumeLayout(false);
		this.plTuongTacChoc.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayTo).EndInit();
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		this.plTuongTacFanpage.ResumeLayout(false);
		this.plTuongTacFanpage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietTo).EndInit();
		this.plTuongTacGroup.ResumeLayout(false);
		this.plTuongTacGroup.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomTo).EndInit();
		this.plTuongTacFriend.ResumeLayout(false);
		this.plTuongTacFriend.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayTo).EndInit();
		this.plTuongTacNewsfeed.ResumeLayout(false);
		this.plTuongTacNewsfeed.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayTo).EndInit();
		this.groupBox8.ResumeLayout(false);
		this.groupBox8.PerformLayout();
		this.plKetBanTepUid.ResumeLayout(false);
		this.plKetBanTepUid.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongTo).EndInit();
		this.plKetBanTuKhoa.ResumeLayout(false);
		this.plKetBanTuKhoa.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayTo).EndInit();
		this.plXacNhanKetBan.ResumeLayout(false);
		this.plXacNhanKetBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongTo).EndInit();
		this.plKetBanGoiY.ResumeLayout(false);
		this.plKetBanGoiY.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongTo).EndInit();
		this.groupBox7.ResumeLayout(false);
		this.groupBox7.PerformLayout();
		this.plThamGiaNhom.ResumeLayout(false);
		this.plThamGiaNhom.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayTo).EndInit();
		base.ResumeLayout(false);
	}
}
