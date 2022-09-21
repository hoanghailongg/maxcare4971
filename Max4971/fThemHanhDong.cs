using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fThemHanhDong : Form
{
	private string string_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	private GroupBox groupBox2;

	private MetroButton metroButton3;

	private MetroButton metroButton2;

	private MetroButton btnDocThongBao;

	private MetroButton metroButton4;

	private GroupBox groupBox1;

	private MetroButton metroButton5;

	private MetroButton metroButton6;

	private MetroButton metroButton7;

	private MetroButton metroButton8;

	private MetroButton metroButton10;

	private MetroButton metroButton11;

	private MetroButton metroButton12;

	private GroupBox groupBox4;

	private MetroButton metroButton18;

	private MetroButton metroButton9;

	private MetroButton metroButton17;

	private MetroButton metroButton13;

	private MetroButton metroButton14;

	private MetroButton metroButton15;

	private MetroButton metroButton16;

	private GroupBox groupBox5;

	private MetroButton metroButton20;

	private MetroButton metroButton22;

	private MetroButton metroButton23;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private MetroButton metroButton21;

	private Panel panel1;

	private GroupBox groupBox3;

	private PictureBox pictureBox6;

	private MetroButton metroButton25;

	private MetroButton metroButton26;

	private GroupBox groupBox6;

	private PictureBox pictureBox7;

	private MetroButton metroButton28;

	private MetroButton metroButton31;

	private ToolTip toolTip_0;

	private MetroButton metroButton19;

	private MetroButton metroButton24;

	private MetroButton metroButton27;

	private MetroButton metroButton29;

	private MetroButton metroButton1;

	private MetroButton metroButton32;

	private MetroButton metroButton33;

	private MetroButton metroButton34;

	private MetroButton metroButton35;

	private MetroButton metroButton36;

	private MetroButton metroButton37;

	private MetroButton metroButton38;

	private MetroButton metroButton41;

	private MetroButton metroButton39;

	private MetroButton metroButton44;

	private MetroButton metroButton43;

	private MetroButton metroButton42;

	private MetroButton metroButton40;

	private MetroButton metroButton45;

	private MetroButton metroButton46;

	private MetroButton metroButton47;

	private GroupBox groupBox7;

	private PictureBox pictureBox8;

	private MetroButton metroButton48;

	private MetroButton metroButton49;

	private MetroButton metroButton53;

	private MetroButton metroButton50;

	private MetroButton metroButton51;

	private MetroButton metroButton52;

	private MetroButton metroButton55;

	private MetroButton metroButton54;

	private MetroButton metroButton30;

	private MetroButton metroButton56;

	private MetroButton metroButton57;

	private MetroButton metroButton59;

	private MetroButton metroButton60;

	private MetroButton metroButton63;

	private MetroButton metroButton64;

	private MetroButton metroButton58;

	private MetroButton metroButton65;

	private MetroButton metroButton66;

	private MetroButton metroButton67;

	private MetroButton metroButton68;

	private MetroButton metroButton69;

	private MetroButton metroButton70;

	private MetroButton metroButton71;

	private MetroButton metroButton72;

	private MetroButton metroButton73;

	private MetroButton metroButton61;

	private MetroButton metroButton62;

	private MetroButton metroButton74;

	private MetroButton metroButton75;

	public fThemHanhDong(string string_1)
	{
		InitializeComponent();
		method_0();
		string_0 = string_1;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(btnDocThongBao);
		GClass29.smethod_1(metroButton2);
		GClass29.smethod_1(metroButton3);
		GClass29.smethod_1(metroButton12);
		GClass29.smethod_1(metroButton11);
		GClass29.smethod_1(metroButton10);
		GClass29.smethod_1(metroButton4);
		GClass29.smethod_1(metroButton19);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(metroButton29);
		GClass29.smethod_1(metroButton34);
		GClass29.smethod_1(metroButton8);
		GClass29.smethod_1(metroButton7);
		GClass29.smethod_1(metroButton6);
		GClass29.smethod_1(metroButton5);
		GClass29.smethod_1(groupBox4);
		GClass29.smethod_1(metroButton14);
		GClass29.smethod_1(metroButton13);
		GClass29.smethod_1(metroButton18);
		GClass29.smethod_1(metroButton16);
		GClass29.smethod_1(metroButton9);
		GClass29.smethod_1(metroButton15);
		GClass29.smethod_1(metroButton17);
		GClass29.smethod_1(groupBox5);
		GClass29.smethod_1(metroButton38);
		GClass29.smethod_1(metroButton23);
		GClass29.smethod_1(metroButton21);
		GClass29.smethod_1(metroButton22);
		GClass29.smethod_1(metroButton20);
		GClass29.smethod_1(groupBox3);
		GClass29.smethod_1(metroButton26);
		GClass29.smethod_1(metroButton25);
		GClass29.smethod_1(metroButton31);
		GClass29.smethod_1(metroButton27);
		GClass29.smethod_1(metroButton1);
		GClass29.smethod_1(metroButton24);
		GClass29.smethod_1(metroButton36);
		GClass29.smethod_1(metroButton37);
		GClass29.smethod_1(groupBox6);
		GClass29.smethod_1(metroButton28);
		GClass29.smethod_1(metroButton32);
		GClass29.smethod_1(metroButton33);
		GClass29.smethod_1(metroButton35);
	}

	private void fThemHanhDong_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnDocThongBao_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDocThongBao(string_0));
		if (fHDDocThongBao.bool_0)
		{
			Close();
		}
	}

	private void metroButton2_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemStory(string_0));
		if (fHDXemStory.bool_0)
		{
			Close();
		}
	}

	private void metroButton3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemWatch(string_0));
		if (fHDXemWatch.bool_0)
		{
			Close();
		}
	}

	private void metroButton12_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDNhanTinBanBe(string_0));
		if (fHDNhanTinBanBe.bool_0)
		{
			Close();
		}
	}

	private void metroButton11_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDChocBanBe(string_0));
		if (fHDChocBanBe.bool_0)
		{
			Close();
		}
	}

	private void metroButton10_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDChucMungSinhNhat(string_0));
		if (fHDChucMungSinhNhat.bool_0)
		{
			Close();
		}
	}

	private void metroButton4_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDPhanHoiTinNhan(string_0));
		if (fHDPhanHoiTinNhan.bool_0)
		{
			Close();
		}
	}

	private void metroButton8_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBaiVietNewsfeed(string_0));
		if (fHDBaiVietNewsfeed.bool_0)
		{
			Close();
		}
	}

	private void metroButton7_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBaiVietBanBe(string_0));
		if (fHDBaiVietBanBe.bool_0)
		{
			Close();
		}
	}

	private void metroButton6_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBaiVietNhom(string_0));
		if (fHDBaiVietNhom.bool_0)
		{
			Close();
		}
	}

	private void metroButton5_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBaiVietFanpage(string_0));
		if (fHDBaiVietFanpage.bool_0)
		{
			Close();
		}
	}

	private void metroButton14_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTheoTuKhoa(string_0));
		if (fHDKetBanTheoTuKhoa.bool_0)
		{
			Close();
		}
	}

	private void metroButton13_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanGoiY(string_0));
		if (fHDKetBanGoiY.bool_0)
		{
			Close();
		}
	}

	private void groupBox6_Enter(object sender, EventArgs e)
	{
	}

	private void metroButton18_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXacNhanKetBan(string_0));
		if (fHDXacNhanKetBan.bool_0)
		{
			Close();
		}
	}

	private void metroButton9_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTepUid(string_0));
		if (fHDKetBanTepUid.bool_0)
		{
			Close();
		}
	}

	private void metroButton16_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanThanhVienNhom(string_0));
		if (fHDKetBanThanhVienNhom.bool_0)
		{
			Close();
		}
	}

	private void metroButton15_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDHuyLoiMoiKetBan(string_0));
		if (fHDHuyLoiMoiKetBan.bool_0)
		{
			Close();
		}
	}

	private void metroButton17_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDHuyKetBan(string_0));
		if (fHDHuyKetBan.bool_0)
		{
			Close();
		}
	}

	private void metroButton21_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomUid(string_0));
		if (fHDThamGiaNhomUid.bool_0)
		{
			Close();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanVoiBanBeCuaUid(string_0));
		if (fHDKetBanVoiBanBeCuaUid.bool_0)
		{
			Close();
		}
	}

	private void metroButton23_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomTuKhoa(string_0));
		if (fHDThamGiaNhomTuKhoa.bool_0)
		{
			Close();
		}
	}

	private void metroButton22_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDRoiNhom(string_0));
		if (fHDRoiNhom.bool_0)
		{
			Close();
		}
	}

	private void metroButton20_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDMoiBanBeVaoNhom(string_0));
		if (fHDMoiBanBeVaoNhom.bool_0)
		{
			Close();
		}
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

	private void metroButton29_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTuongTacNewsfeed(string_0));
		if (fHDTuongTacNewsfeed.bool_0)
		{
			Close();
		}
	}

	private void metroButton26_Click(object sender, EventArgs e)
	{
		try
		{
			GClass14.smethod_33(new fHDBuffLikeComment(string_0));
			if (fHDBuffLikeComment.bool_0)
			{
				Close();
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "metroButton26_Click");
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng liên hệ Admin!"), 2);
		}
	}

	private void metroButton31_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBuffFollowLikePage(string_0));
		if (fHDBuffFollowLikePage.bool_0)
		{
			Close();
		}
	}

	private void metroButton25_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBuffFollowCaNhan(string_0));
		if (fHDBuffFollowCaNhan.bool_0)
		{
			Close();
		}
	}

	private void metroButton28_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBackupData(string_0));
		if (fHDBackupData.bool_0)
		{
			Close();
		}
	}

	private void metroButton19_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStatus(string_0));
		if (fHDDangStatus.bool_0)
		{
			Close();
		}
	}

	private void metroButton24_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDSpamBaiViet(string_0));
		if (fHDSpamBaiViet.bool_0)
		{
			Close();
		}
	}

	private void metroButton27_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBuffTinNhanProfile(string_0));
		if (fHDBuffTinNhanProfile.bool_0)
		{
			Close();
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDSeedingByVideo(string_0));
		if (fHDSeedingByVideo.bool_0)
		{
			Close();
		}
	}

	private void metroButton33_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTruyCapWebsite(string_0));
		if (fHDTruyCapWebsite.bool_0)
		{
			Close();
		}
	}

	private void metroButton32_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTimKiemGoogle(string_0));
		if (fHDTimKiemGoogle.bool_0)
		{
			Close();
		}
	}

	private void metroButton34_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTuongTacBanBe(string_0));
		if (fHDTuongTacBanBe.bool_0)
		{
			Close();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTepUidNew(string_0));
		if (fHDKetBanTepUidNew.bool_0)
		{
			Close();
		}
	}

	private void metroButton35_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDNghiGiaiLao(string_0));
		if (fHDNghiGiaiLao.bool_0)
		{
			Close();
		}
	}

	private void metroButton36_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangBai(string_0));
		if (fHDDangBai.bool_0)
		{
			Close();
		}
	}

	private void metroButton37_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDShareBai(string_0));
		if (fHDShareBai.bool_0)
		{
			Close();
		}
	}

	private void metroButton38_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomGoiY(string_0));
		if (fHDThamGiaNhomGoiY.bool_0)
		{
			Close();
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			base.Height = 508;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanNewfeed(string_0));
		if (fHDKetBanNewfeed.bool_0)
		{
			Close();
		}
	}

	private void metroButton41_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanVoiBanCuaBanBe(string_0));
		if (fHDKetBanVoiBanCuaBanBe.bool_0)
		{
			Close();
		}
	}

	private void metroButton39_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanVoiBanBeCuaUid(string_0));
		if (fHDKetBanVoiBanBeCuaUid.bool_0)
		{
			Close();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemStoryChiDinh(string_0));
		if (fHDXemStoryChiDinh.bool_0)
		{
			Close();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStory(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void metroButton40_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDocThongBaov2(string_0));
		if (fHDDocThongBaov2.bool_0)
		{
			Close();
		}
	}

	private void metroButton43_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTepUidv2(string_0));
		if (fHDKetBanTepUidv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton42_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTuongTacNewsfeedv2(string_0));
		if (fHDTuongTacNewsfeedv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton44_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomUidv2(string_0));
		if (fHDThamGiaNhomUidv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton45_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStatusV2(string_0));
		if (fHDDangStatusV2.bool_0)
		{
			Close();
		}
	}

	private void metroButton46_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTuongTacBaiVietNhomv2(string_0));
		if (fHDTuongTacBaiVietNhomv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton47_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXacNhanKetBanv2(string_0));
		if (fHDXacNhanKetBanv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton49_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBuffViewVideo(string_0));
		if (fHDBuffViewVideo.bool_0)
		{
			Close();
		}
	}

	private void metroButton48_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTuongTacBaiVietTheoID(string_0));
		if (fHDTuongTacBaiVietTheoID.bool_0)
		{
			Close();
		}
	}

	private void method_7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		base.Width = 1462;
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void metroButton54_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTheoTuKhoav2(string_0));
		if (fHDKetBanTheoTuKhoav2.bool_0)
		{
			Close();
		}
	}

	private void metroButton55_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanGoiYv2(string_0));
		if (fHDKetBanGoiYv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton56_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDMoiLikePage(string_0));
		if (fHDMoiLikePage.bool_0)
		{
			Close();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStory(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomTuKhoav2(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void metroButton64_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXoaBaiPage(string_0));
		if (fHDXoaBaiPage.bool_0)
		{
			Close();
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomGoiYv2(string_0));
		if (fHDThamGiaNhomGoiYv2.bool_0)
		{
			Close();
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanGoiYv2(string_0));
		if (fHDKetBanGoiYv2.bool_0)
		{
			Close();
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKetBanTheoTuKhoav2(string_0));
		if (fHDKetBanTheoTuKhoav2.bool_0)
		{
			Close();
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemStoryChiDinh(string_0));
		if (fHDXemStoryChiDinh.bool_0)
		{
			Close();
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStory(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void metroButton50_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemStoryv2(string_0));
		if (fHDXemStoryv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton51_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXemWatchv2(string_0));
		if (fHDXemWatchv2.bool_0)
		{
			Close();
		}
	}

	private void method_16(object sender, EventArgs e)
	{
	}

	private void method_17(object sender, EventArgs e)
	{
	}

	private void metroButton30_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXoaBaiTuong(string_0));
		if (fHDXoaBaiTuong.bool_0)
		{
			Close();
		}
	}

	private void metroButton52_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomTuKhoav2(string_0));
		if (fHDThamGiaNhomTuKhoav2.bool_0)
		{
			Close();
		}
	}

	private void metroButton53_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDThamGiaNhomGoiYv2(string_0));
		if (fHDThamGiaNhomGoiYv2.bool_0)
		{
			Close();
		}
	}

	private void method_18(object sender, EventArgs e)
	{
	}

	private void metroButton57_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDHuyLikePage(string_0));
		if (fHDHuyLikePage.bool_0)
		{
			Close();
		}
	}

	private void metroButton59_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDBaiVietTrenTuong(string_0));
		if (fHDBaiVietTrenTuong.bool_0)
		{
			Close();
		}
	}

	private void metroButton60_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangBaiTheoID(string_0));
		if (fHDDangBaiTheoID.bool_0)
		{
			Close();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDChangeSoThich(string_0));
		if (fHDChangeSoThich.bool_0)
		{
			Close();
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDChangeTenPhu(string_0));
		if (fHDChangeTenPhu.bool_0)
		{
			Close();
		}
	}

	private void metroButton63_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDLinkToInstagram(string_0));
		if (fHDLinkToInstagram.bool_0)
		{
			Close();
		}
	}

	private void metroButton58_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDShareBaiTut(string_0));
		if (fHDShareBaiTut.bool_0)
		{
			Close();
		}
	}

	private void metroButton65_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDAnMail(string_0));
		if (fHDAnMail.bool_0)
		{
			Close();
		}
	}

	private void metroButton66_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDCongKhaiBaiVietGanThe(string_0));
		if (fHDCongKhaiBaiVietGanThe.bool_0)
		{
			Close();
		}
	}

	private void metroButton67_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDLoginMail(string_0));
		if (fHDLoginMail.bool_0)
		{
			Close();
		}
	}

	private void metroButton68_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDSpamBaiVietv2(string_0));
		if (fHDSpamBaiVietv2.bool_0)
		{
			Close();
		}
	}

	private void metroButton69_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXoaTinNhan(string_0));
		if (fHDXoaTinNhan.bool_0)
		{
			Close();
		}
	}

	private void metroButton70_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDPhanHoiBinhLuan(string_0));
		if (fHDPhanHoiBinhLuan.bool_0)
		{
			Close();
		}
	}

	private void metroButton71_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDReport(string_0));
		if (fHDReport.bool_0)
		{
			Close();
		}
	}

	private void metroButton72_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDTaoPage(string_0));
		if (fHDTaoPage.bool_0)
		{
			Close();
		}
	}

	private void metroButton73_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDDangStory(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void metroButton61_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDVerify(string_0));
		if (fHDVerify.bool_0)
		{
			Close();
		}
	}

	private void metroButton74_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDXoaNhatKyHoatDong(string_0));
		if (fHDXoaNhatKyHoatDong.bool_0)
		{
			Close();
		}
	}

	private void metroButton75_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHDKhangSpam(string_0));
		if (fHDKhangSpam.bool_0)
		{
			Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHanhDong));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.metroButton10 = new MetroFramework.Controls.MetroButton();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.metroButton73 = new MetroFramework.Controls.MetroButton();
		this.metroButton19 = new MetroFramework.Controls.MetroButton();
		this.metroButton11 = new MetroFramework.Controls.MetroButton();
		this.metroButton4 = new MetroFramework.Controls.MetroButton();
		this.metroButton12 = new MetroFramework.Controls.MetroButton();
		this.metroButton3 = new MetroFramework.Controls.MetroButton();
		this.metroButton2 = new MetroFramework.Controls.MetroButton();
		this.btnDocThongBao = new MetroFramework.Controls.MetroButton();
		this.metroButton72 = new MetroFramework.Controls.MetroButton();
		this.metroButton49 = new MetroFramework.Controls.MetroButton();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.metroButton66 = new MetroFramework.Controls.MetroButton();
		this.metroButton59 = new MetroFramework.Controls.MetroButton();
		this.metroButton5 = new MetroFramework.Controls.MetroButton();
		this.pictureBox3 = new System.Windows.Forms.PictureBox();
		this.metroButton6 = new MetroFramework.Controls.MetroButton();
		this.metroButton7 = new MetroFramework.Controls.MetroButton();
		this.metroButton8 = new MetroFramework.Controls.MetroButton();
		this.metroButton48 = new MetroFramework.Controls.MetroButton();
		this.metroButton29 = new MetroFramework.Controls.MetroButton();
		this.metroButton34 = new MetroFramework.Controls.MetroButton();
		this.metroButton24 = new MetroFramework.Controls.MetroButton();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.pictureBox4 = new System.Windows.Forms.PictureBox();
		this.metroButton15 = new MetroFramework.Controls.MetroButton();
		this.metroButton18 = new MetroFramework.Controls.MetroButton();
		this.metroButton16 = new MetroFramework.Controls.MetroButton();
		this.metroButton9 = new MetroFramework.Controls.MetroButton();
		this.metroButton41 = new MetroFramework.Controls.MetroButton();
		this.metroButton39 = new MetroFramework.Controls.MetroButton();
		this.metroButton17 = new MetroFramework.Controls.MetroButton();
		this.metroButton13 = new MetroFramework.Controls.MetroButton();
		this.metroButton14 = new MetroFramework.Controls.MetroButton();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.pictureBox5 = new System.Windows.Forms.PictureBox();
		this.metroButton38 = new MetroFramework.Controls.MetroButton();
		this.metroButton20 = new MetroFramework.Controls.MetroButton();
		this.metroButton22 = new MetroFramework.Controls.MetroButton();
		this.metroButton21 = new MetroFramework.Controls.MetroButton();
		this.metroButton23 = new MetroFramework.Controls.MetroButton();
		this.metroButton47 = new MetroFramework.Controls.MetroButton();
		this.metroButton46 = new MetroFramework.Controls.MetroButton();
		this.metroButton45 = new MetroFramework.Controls.MetroButton();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.metroButton74 = new MetroFramework.Controls.MetroButton();
		this.metroButton62 = new MetroFramework.Controls.MetroButton();
		this.metroButton58 = new MetroFramework.Controls.MetroButton();
		this.pictureBox8 = new System.Windows.Forms.PictureBox();
		this.metroButton53 = new MetroFramework.Controls.MetroButton();
		this.metroButton44 = new MetroFramework.Controls.MetroButton();
		this.metroButton52 = new MetroFramework.Controls.MetroButton();
		this.metroButton55 = new MetroFramework.Controls.MetroButton();
		this.metroButton40 = new MetroFramework.Controls.MetroButton();
		this.metroButton54 = new MetroFramework.Controls.MetroButton();
		this.metroButton43 = new MetroFramework.Controls.MetroButton();
		this.metroButton50 = new MetroFramework.Controls.MetroButton();
		this.metroButton51 = new MetroFramework.Controls.MetroButton();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.metroButton42 = new MetroFramework.Controls.MetroButton();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.metroButton75 = new MetroFramework.Controls.MetroButton();
		this.metroButton61 = new MetroFramework.Controls.MetroButton();
		this.metroButton67 = new MetroFramework.Controls.MetroButton();
		this.metroButton65 = new MetroFramework.Controls.MetroButton();
		this.metroButton64 = new MetroFramework.Controls.MetroButton();
		this.metroButton63 = new MetroFramework.Controls.MetroButton();
		this.metroButton60 = new MetroFramework.Controls.MetroButton();
		this.metroButton57 = new MetroFramework.Controls.MetroButton();
		this.metroButton30 = new MetroFramework.Controls.MetroButton();
		this.pictureBox7 = new System.Windows.Forms.PictureBox();
		this.metroButton28 = new MetroFramework.Controls.MetroButton();
		this.metroButton35 = new MetroFramework.Controls.MetroButton();
		this.metroButton33 = new MetroFramework.Controls.MetroButton();
		this.metroButton32 = new MetroFramework.Controls.MetroButton();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.metroButton71 = new MetroFramework.Controls.MetroButton();
		this.metroButton70 = new MetroFramework.Controls.MetroButton();
		this.metroButton69 = new MetroFramework.Controls.MetroButton();
		this.pictureBox6 = new System.Windows.Forms.PictureBox();
		this.metroButton68 = new MetroFramework.Controls.MetroButton();
		this.metroButton56 = new MetroFramework.Controls.MetroButton();
		this.metroButton27 = new MetroFramework.Controls.MetroButton();
		this.metroButton37 = new MetroFramework.Controls.MetroButton();
		this.metroButton36 = new MetroFramework.Controls.MetroButton();
		this.metroButton31 = new MetroFramework.Controls.MetroButton();
		this.metroButton25 = new MetroFramework.Controls.MetroButton();
		this.metroButton26 = new MetroFramework.Controls.MetroButton();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
		this.groupBox4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox8).BeginInit();
		this.groupBox6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1468, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Danh sách hành động";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1468, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(1436, 1);
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
		this.bunifuCards1.Size = new System.Drawing.Size(1468, 37);
		this.bunifuCards1.TabIndex = 12;
		this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox2.Controls.Add(this.metroButton10);
		this.groupBox2.Controls.Add(this.pictureBox2);
		this.groupBox2.Controls.Add(this.metroButton73);
		this.groupBox2.Controls.Add(this.metroButton19);
		this.groupBox2.Controls.Add(this.metroButton11);
		this.groupBox2.Controls.Add(this.metroButton4);
		this.groupBox2.Controls.Add(this.metroButton12);
		this.groupBox2.Controls.Add(this.metroButton3);
		this.groupBox2.Controls.Add(this.metroButton2);
		this.groupBox2.Controls.Add(this.btnDocThongBao);
		this.groupBox2.Controls.Add(this.metroButton72);
		this.groupBox2.Location = new System.Drawing.Point(9, 43);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(178, 505);
		this.groupBox2.TabIndex = 0;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tương tác cá nhân";
		this.metroButton10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton10.Location = new System.Drawing.Point(13, 269);
		this.metroButton10.Name = "metroButton10";
		this.metroButton10.Size = new System.Drawing.Size(151, 23);
		this.metroButton10.TabIndex = 5;
		this.metroButton10.Text = "Chúc mừng sinh nhật";
		this.metroButton10.UseSelectable = true;
		this.metroButton10.Click += new System.EventHandler(metroButton10_Click);
		this.pictureBox2.Image = Class306.Bitmap_4;
		this.pictureBox2.Location = new System.Drawing.Point(14, 22);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(151, 83);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 1;
		this.pictureBox2.TabStop = false;
		this.metroButton73.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton73.Location = new System.Drawing.Point(13, 356);
		this.metroButton73.Name = "metroButton73";
		this.metroButton73.Size = new System.Drawing.Size(151, 23);
		this.metroButton73.TabIndex = 2;
		this.metroButton73.Text = "Đăng story";
		this.metroButton73.UseSelectable = true;
		this.metroButton73.Click += new System.EventHandler(metroButton73_Click);
		this.metroButton19.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton19.Location = new System.Drawing.Point(13, 327);
		this.metroButton19.Name = "metroButton19";
		this.metroButton19.Size = new System.Drawing.Size(151, 23);
		this.metroButton19.TabIndex = 2;
		this.metroButton19.Text = "Đăng status";
		this.metroButton19.UseSelectable = true;
		this.metroButton19.Click += new System.EventHandler(metroButton19_Click);
		this.metroButton11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton11.Location = new System.Drawing.Point(13, 240);
		this.metroButton11.Name = "metroButton11";
		this.metroButton11.Size = new System.Drawing.Size(151, 23);
		this.metroButton11.TabIndex = 4;
		this.metroButton11.Text = "Chọc bạn bè";
		this.metroButton11.UseSelectable = true;
		this.metroButton11.Click += new System.EventHandler(metroButton11_Click);
		this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton4.Location = new System.Drawing.Point(13, 298);
		this.metroButton4.Name = "metroButton4";
		this.metroButton4.Size = new System.Drawing.Size(151, 23);
		this.metroButton4.TabIndex = 6;
		this.metroButton4.Text = "Phản hồi tin nhắn";
		this.metroButton4.UseSelectable = true;
		this.metroButton4.Click += new System.EventHandler(metroButton4_Click);
		this.metroButton12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton12.Location = new System.Drawing.Point(13, 211);
		this.metroButton12.Name = "metroButton12";
		this.metroButton12.Size = new System.Drawing.Size(151, 23);
		this.metroButton12.TabIndex = 3;
		this.metroButton12.Text = "Nhắn tin ba\u0323n be\u0300";
		this.metroButton12.UseSelectable = true;
		this.metroButton12.Click += new System.EventHandler(metroButton12_Click);
		this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton3.Location = new System.Drawing.Point(13, 182);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new System.Drawing.Size(151, 23);
		this.metroButton3.TabIndex = 2;
		this.metroButton3.Text = "Xem Watch";
		this.metroButton3.UseSelectable = true;
		this.metroButton3.Click += new System.EventHandler(metroButton3_Click);
		this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton2.Location = new System.Drawing.Point(13, 153);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new System.Drawing.Size(151, 23);
		this.metroButton2.TabIndex = 1;
		this.metroButton2.Text = "Xem Story";
		this.metroButton2.UseSelectable = true;
		this.metroButton2.Click += new System.EventHandler(metroButton2_Click);
		this.btnDocThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDocThongBao.Location = new System.Drawing.Point(13, 124);
		this.btnDocThongBao.Name = "btnDocThongBao";
		this.btnDocThongBao.Size = new System.Drawing.Size(151, 23);
		this.btnDocThongBao.TabIndex = 0;
		this.btnDocThongBao.Text = "Đọc thông báo";
		this.btnDocThongBao.UseSelectable = true;
		this.btnDocThongBao.Click += new System.EventHandler(btnDocThongBao_Click);
		this.metroButton72.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton72.Location = new System.Drawing.Point(14, 327);
		this.metroButton72.Name = "metroButton72";
		this.metroButton72.Size = new System.Drawing.Size(151, 23);
		this.metroButton72.TabIndex = 7;
		this.metroButton72.Text = "Tạo Page";
		this.metroButton72.UseSelectable = true;
		this.metroButton72.Click += new System.EventHandler(metroButton72_Click);
		this.metroButton49.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton49.Location = new System.Drawing.Point(14, 269);
		this.metroButton49.Name = "metroButton49";
		this.metroButton49.Size = new System.Drawing.Size(151, 23);
		this.metroButton49.TabIndex = 2;
		this.metroButton49.Text = "Buff View Video";
		this.metroButton49.UseSelectable = true;
		this.metroButton49.Click += new System.EventHandler(metroButton49_Click);
		this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox1.Controls.Add(this.metroButton66);
		this.groupBox1.Controls.Add(this.metroButton59);
		this.groupBox1.Controls.Add(this.metroButton5);
		this.groupBox1.Controls.Add(this.pictureBox3);
		this.groupBox1.Controls.Add(this.metroButton6);
		this.groupBox1.Controls.Add(this.metroButton7);
		this.groupBox1.Controls.Add(this.metroButton8);
		this.groupBox1.Controls.Add(this.metroButton48);
		this.groupBox1.Controls.Add(this.metroButton29);
		this.groupBox1.Controls.Add(this.metroButton34);
		this.groupBox1.Location = new System.Drawing.Point(192, 42);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(178, 505);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Tương tác bài viết";
		this.metroButton66.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton66.Location = new System.Drawing.Point(14, 356);
		this.metroButton66.Name = "metroButton66";
		this.metroButton66.Size = new System.Drawing.Size(151, 23);
		this.metroButton66.TabIndex = 13;
		this.metroButton66.Text = "Công khai bài viết gắn thẻ";
		this.metroButton66.UseSelectable = true;
		this.metroButton66.Visible = false;
		this.metroButton66.Click += new System.EventHandler(metroButton66_Click);
		this.metroButton59.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton59.Location = new System.Drawing.Point(14, 327);
		this.metroButton59.Name = "metroButton59";
		this.metroButton59.Size = new System.Drawing.Size(151, 23);
		this.metroButton59.TabIndex = 4;
		this.metroButton59.Text = "Bài viết trên tường";
		this.metroButton59.UseSelectable = true;
		this.metroButton59.Click += new System.EventHandler(metroButton59_Click);
		this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton5.Location = new System.Drawing.Point(14, 269);
		this.metroButton5.Name = "metroButton5";
		this.metroButton5.Size = new System.Drawing.Size(151, 23);
		this.metroButton5.TabIndex = 3;
		this.metroButton5.Text = "Bài viết Fanpage";
		this.metroButton5.UseSelectable = true;
		this.metroButton5.Click += new System.EventHandler(metroButton5_Click);
		this.pictureBox3.Image = Class306.Bitmap_1;
		this.pictureBox3.Location = new System.Drawing.Point(14, 22);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new System.Drawing.Size(151, 83);
		this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox3.TabIndex = 1;
		this.pictureBox3.TabStop = false;
		this.metroButton6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton6.Location = new System.Drawing.Point(14, 240);
		this.metroButton6.Name = "metroButton6";
		this.metroButton6.Size = new System.Drawing.Size(151, 23);
		this.metroButton6.TabIndex = 2;
		this.metroButton6.Text = "Bài viết Nhóm";
		this.metroButton6.UseSelectable = true;
		this.metroButton6.Click += new System.EventHandler(metroButton6_Click);
		this.metroButton7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton7.Location = new System.Drawing.Point(14, 211);
		this.metroButton7.Name = "metroButton7";
		this.metroButton7.Size = new System.Drawing.Size(151, 23);
		this.metroButton7.TabIndex = 1;
		this.metroButton7.Text = "Bài viết Bạn bè";
		this.metroButton7.UseSelectable = true;
		this.metroButton7.Click += new System.EventHandler(metroButton7_Click);
		this.metroButton8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton8.Location = new System.Drawing.Point(14, 182);
		this.metroButton8.Name = "metroButton8";
		this.metroButton8.Size = new System.Drawing.Size(151, 23);
		this.metroButton8.TabIndex = 0;
		this.metroButton8.Text = "Bài viết Newsfeed";
		this.metroButton8.UseSelectable = true;
		this.metroButton8.Click += new System.EventHandler(metroButton8_Click);
		this.metroButton48.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton48.Location = new System.Drawing.Point(14, 298);
		this.metroButton48.Name = "metroButton48";
		this.metroButton48.Size = new System.Drawing.Size(151, 23);
		this.metroButton48.TabIndex = 0;
		this.metroButton48.Text = "Tương tác bài viết theo ID";
		this.metroButton48.UseSelectable = true;
		this.metroButton48.Click += new System.EventHandler(metroButton48_Click);
		this.metroButton29.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton29.Location = new System.Drawing.Point(14, 124);
		this.metroButton29.Name = "metroButton29";
		this.metroButton29.Size = new System.Drawing.Size(151, 23);
		this.metroButton29.TabIndex = 0;
		this.metroButton29.Text = "Tương tác Newsfeed";
		this.metroButton29.UseSelectable = true;
		this.metroButton29.Click += new System.EventHandler(metroButton29_Click);
		this.metroButton34.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton34.Location = new System.Drawing.Point(14, 153);
		this.metroButton34.Name = "metroButton34";
		this.metroButton34.Size = new System.Drawing.Size(151, 23);
		this.metroButton34.TabIndex = 1;
		this.metroButton34.Text = "Tương ta\u0301c Bạn bè";
		this.metroButton34.UseSelectable = true;
		this.metroButton34.Click += new System.EventHandler(metroButton34_Click);
		this.metroButton24.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton24.Location = new System.Drawing.Point(14, 240);
		this.metroButton24.Name = "metroButton24";
		this.metroButton24.Size = new System.Drawing.Size(151, 23);
		this.metroButton24.TabIndex = 3;
		this.metroButton24.Text = "Spam bài viết theo ID";
		this.metroButton24.UseSelectable = true;
		this.metroButton24.Click += new System.EventHandler(metroButton24_Click);
		this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox4.Controls.Add(this.pictureBox4);
		this.groupBox4.Controls.Add(this.metroButton15);
		this.groupBox4.Controls.Add(this.metroButton18);
		this.groupBox4.Controls.Add(this.metroButton16);
		this.groupBox4.Controls.Add(this.metroButton9);
		this.groupBox4.Controls.Add(this.metroButton41);
		this.groupBox4.Controls.Add(this.metroButton39);
		this.groupBox4.Controls.Add(this.metroButton17);
		this.groupBox4.Controls.Add(this.metroButton13);
		this.groupBox4.Controls.Add(this.metroButton14);
		this.groupBox4.Location = new System.Drawing.Point(376, 42);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(178, 505);
		this.groupBox4.TabIndex = 3;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Chức năng Bạn bè";
		this.pictureBox4.Image = Class306.Bitmap_50;
		this.pictureBox4.Location = new System.Drawing.Point(14, 22);
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.Size = new System.Drawing.Size(151, 83);
		this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox4.TabIndex = 1;
		this.pictureBox4.TabStop = false;
		this.metroButton15.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton15.Location = new System.Drawing.Point(14, 240);
		this.metroButton15.Name = "metroButton15";
		this.metroButton15.Size = new System.Drawing.Size(151, 23);
		this.metroButton15.TabIndex = 5;
		this.metroButton15.Text = "Hủy lời mời đã gửi";
		this.metroButton15.UseSelectable = true;
		this.metroButton15.Click += new System.EventHandler(metroButton15_Click);
		this.metroButton18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton18.Location = new System.Drawing.Point(14, 182);
		this.metroButton18.Name = "metroButton18";
		this.metroButton18.Size = new System.Drawing.Size(151, 23);
		this.metroButton18.TabIndex = 2;
		this.metroButton18.Text = "Xác nhận kết bạn";
		this.metroButton18.UseSelectable = true;
		this.metroButton18.Click += new System.EventHandler(metroButton18_Click);
		this.metroButton16.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton16.Location = new System.Drawing.Point(14, 298);
		this.metroButton16.Name = "metroButton16";
		this.metroButton16.Size = new System.Drawing.Size(151, 23);
		this.metroButton16.TabIndex = 3;
		this.metroButton16.Text = "Kết bạn thành viên nhóm";
		this.metroButton16.UseSelectable = true;
		this.metroButton16.Click += new System.EventHandler(metroButton16_Click);
		this.metroButton9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton9.Location = new System.Drawing.Point(14, 211);
		this.metroButton9.Name = "metroButton9";
		this.metroButton9.Size = new System.Drawing.Size(151, 23);
		this.metroButton9.TabIndex = 4;
		this.metroButton9.Text = "Kết bạn theo tệp UID";
		this.metroButton9.UseSelectable = true;
		this.metroButton9.Click += new System.EventHandler(metroButton9_Click);
		this.metroButton41.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton41.Location = new System.Drawing.Point(14, 327);
		this.metroButton41.Name = "metroButton41";
		this.metroButton41.Size = new System.Drawing.Size(151, 23);
		this.metroButton41.TabIndex = 6;
		this.metroButton41.Text = "Kết bạn với bạn của bạn bè";
		this.metroButton41.UseSelectable = true;
		this.metroButton41.Click += new System.EventHandler(metroButton41_Click);
		this.metroButton39.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton39.Location = new System.Drawing.Point(14, 356);
		this.metroButton39.Name = "metroButton39";
		this.metroButton39.Size = new System.Drawing.Size(151, 23);
		this.metroButton39.TabIndex = 6;
		this.metroButton39.Text = "Kết bạn với bạn bè của UID";
		this.metroButton39.UseSelectable = true;
		this.metroButton39.Click += new System.EventHandler(metroButton39_Click);
		this.metroButton17.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton17.Location = new System.Drawing.Point(14, 269);
		this.metroButton17.Name = "metroButton17";
		this.metroButton17.Size = new System.Drawing.Size(151, 23);
		this.metroButton17.TabIndex = 6;
		this.metroButton17.Text = "Hủy kết bạn";
		this.metroButton17.UseSelectable = true;
		this.metroButton17.Click += new System.EventHandler(metroButton17_Click);
		this.metroButton13.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton13.Location = new System.Drawing.Point(14, 153);
		this.metroButton13.Name = "metroButton13";
		this.metroButton13.Size = new System.Drawing.Size(151, 23);
		this.metroButton13.TabIndex = 1;
		this.metroButton13.Text = "Kết bạn theo gợi ý";
		this.metroButton13.UseSelectable = true;
		this.metroButton13.Click += new System.EventHandler(metroButton13_Click);
		this.metroButton14.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton14.Location = new System.Drawing.Point(14, 124);
		this.metroButton14.Name = "metroButton14";
		this.metroButton14.Size = new System.Drawing.Size(151, 23);
		this.metroButton14.TabIndex = 0;
		this.metroButton14.Text = "Kết bạn theo từ khóa";
		this.metroButton14.UseSelectable = true;
		this.metroButton14.Click += new System.EventHandler(metroButton14_Click);
		this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox5.Controls.Add(this.pictureBox5);
		this.groupBox5.Controls.Add(this.metroButton38);
		this.groupBox5.Controls.Add(this.metroButton20);
		this.groupBox5.Controls.Add(this.metroButton22);
		this.groupBox5.Controls.Add(this.metroButton21);
		this.groupBox5.Controls.Add(this.metroButton23);
		this.groupBox5.Location = new System.Drawing.Point(560, 42);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(178, 505);
		this.groupBox5.TabIndex = 4;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Chức năng Nhóm";
		this.groupBox5.Enter += new System.EventHandler(groupBox6_Enter);
		this.pictureBox5.Image = Class306.Bitmap_16;
		this.pictureBox5.Location = new System.Drawing.Point(14, 22);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new System.Drawing.Size(151, 83);
		this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox5.TabIndex = 1;
		this.pictureBox5.TabStop = false;
		this.metroButton38.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton38.Location = new System.Drawing.Point(14, 124);
		this.metroButton38.Name = "metroButton38";
		this.metroButton38.Size = new System.Drawing.Size(151, 23);
		this.metroButton38.TabIndex = 3;
		this.metroButton38.Text = "Tham gia nhóm theo gợi ý";
		this.metroButton38.UseSelectable = true;
		this.metroButton38.Click += new System.EventHandler(metroButton38_Click);
		this.metroButton20.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton20.Location = new System.Drawing.Point(14, 240);
		this.metroButton20.Name = "metroButton20";
		this.metroButton20.Size = new System.Drawing.Size(151, 23);
		this.metroButton20.TabIndex = 3;
		this.metroButton20.Text = "Mời bạn bè vào nhóm";
		this.metroButton20.UseSelectable = true;
		this.metroButton20.Click += new System.EventHandler(metroButton20_Click);
		this.metroButton22.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton22.Location = new System.Drawing.Point(14, 211);
		this.metroButton22.Name = "metroButton22";
		this.metroButton22.Size = new System.Drawing.Size(151, 23);
		this.metroButton22.TabIndex = 2;
		this.metroButton22.Text = "Rời nhóm";
		this.metroButton22.UseSelectable = true;
		this.metroButton22.Click += new System.EventHandler(metroButton22_Click);
		this.metroButton21.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton21.Location = new System.Drawing.Point(14, 182);
		this.metroButton21.Name = "metroButton21";
		this.metroButton21.Size = new System.Drawing.Size(151, 23);
		this.metroButton21.TabIndex = 1;
		this.metroButton21.Text = "Tham gia nhóm theo ID";
		this.metroButton21.UseSelectable = true;
		this.metroButton21.Click += new System.EventHandler(metroButton21_Click);
		this.metroButton23.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton23.Location = new System.Drawing.Point(14, 153);
		this.metroButton23.Name = "metroButton23";
		this.metroButton23.Size = new System.Drawing.Size(151, 23);
		this.metroButton23.TabIndex = 0;
		this.metroButton23.Text = "Tham gia nhóm từ khóa";
		this.metroButton23.UseSelectable = true;
		this.metroButton23.Click += new System.EventHandler(metroButton23_Click);
		this.metroButton47.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton47.Location = new System.Drawing.Point(14, 240);
		this.metroButton47.Name = "metroButton47";
		this.metroButton47.Size = new System.Drawing.Size(151, 23);
		this.metroButton47.TabIndex = 10;
		this.metroButton47.Text = "Xác nhận kết bạn";
		this.metroButton47.UseSelectable = true;
		this.metroButton47.Click += new System.EventHandler(metroButton47_Click);
		this.metroButton46.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton46.Location = new System.Drawing.Point(14, 182);
		this.metroButton46.Name = "metroButton46";
		this.metroButton46.Size = new System.Drawing.Size(151, 23);
		this.metroButton46.TabIndex = 9;
		this.metroButton46.Text = "Tương tác bài viết nhóm";
		this.metroButton46.UseSelectable = true;
		this.metroButton46.Click += new System.EventHandler(metroButton46_Click);
		this.metroButton45.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton45.Location = new System.Drawing.Point(14, 269);
		this.metroButton45.Name = "metroButton45";
		this.metroButton45.Size = new System.Drawing.Size(151, 23);
		this.metroButton45.TabIndex = 8;
		this.metroButton45.Text = "Đăng Status";
		this.metroButton45.UseSelectable = true;
		this.metroButton45.Click += new System.EventHandler(metroButton45_Click);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox5);
		this.panel1.Controls.Add(this.groupBox7);
		this.panel1.Controls.Add(this.groupBox6);
		this.panel1.Controls.Add(this.groupBox4);
		this.panel1.Controls.Add(this.groupBox3);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1471, 559);
		this.panel1.TabIndex = 25;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox7.Controls.Add(this.metroButton74);
		this.groupBox7.Controls.Add(this.metroButton62);
		this.groupBox7.Controls.Add(this.metroButton67);
		this.groupBox7.Controls.Add(this.metroButton58);
		this.groupBox7.Controls.Add(this.pictureBox8);
		this.groupBox7.Controls.Add(this.metroButton53);
		this.groupBox7.Controls.Add(this.metroButton47);
		this.groupBox7.Controls.Add(this.metroButton44);
		this.groupBox7.Controls.Add(this.metroButton46);
		this.groupBox7.Controls.Add(this.metroButton52);
		this.groupBox7.Controls.Add(this.metroButton55);
		this.groupBox7.Controls.Add(this.metroButton40);
		this.groupBox7.Controls.Add(this.metroButton54);
		this.groupBox7.Controls.Add(this.metroButton45);
		this.groupBox7.Controls.Add(this.metroButton43);
		this.groupBox7.Controls.Add(this.metroButton50);
		this.groupBox7.Controls.Add(this.metroButton51);
		this.groupBox7.Controls.Add(this.metroButton1);
		this.groupBox7.Controls.Add(this.metroButton42);
		this.groupBox7.Location = new System.Drawing.Point(1113, 42);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(345, 505);
		this.groupBox7.TabIndex = 4;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "Tính năng chạy trên WWW";
		this.groupBox7.Enter += new System.EventHandler(groupBox6_Enter);
		this.metroButton74.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton74.Location = new System.Drawing.Point(180, 298);
		this.metroButton74.Name = "metroButton74";
		this.metroButton74.Size = new System.Drawing.Size(151, 23);
		this.metroButton74.TabIndex = 11;
		this.metroButton74.Text = "Xóa nhật ký hoạt động";
		this.metroButton74.UseSelectable = true;
		this.metroButton74.Click += new System.EventHandler(metroButton74_Click);
		this.metroButton62.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton62.Location = new System.Drawing.Point(14, 414);
		this.metroButton62.Name = "metroButton62";
		this.metroButton62.Size = new System.Drawing.Size(151, 23);
		this.metroButton62.TabIndex = 11;
		this.metroButton62.Text = "Share bài VIP";
		this.metroButton62.UseSelectable = true;
		this.metroButton62.Visible = false;
		this.metroButton62.Click += new System.EventHandler(metroButton58_Click);
		this.metroButton58.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton58.Location = new System.Drawing.Point(14, 443);
		this.metroButton58.Name = "metroButton58";
		this.metroButton58.Size = new System.Drawing.Size(151, 23);
		this.metroButton58.TabIndex = 11;
		this.metroButton58.Text = "Share bài";
		this.metroButton58.UseSelectable = true;
		this.metroButton58.Visible = false;
		this.metroButton58.Click += new System.EventHandler(metroButton58_Click);
		this.pictureBox8.Image = Class306.Bitmap_269;
		this.pictureBox8.Location = new System.Drawing.Point(14, 22);
		this.pictureBox8.Name = "pictureBox8";
		this.pictureBox8.Size = new System.Drawing.Size(151, 83);
		this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox8.TabIndex = 1;
		this.pictureBox8.TabStop = false;
		this.metroButton53.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton53.Location = new System.Drawing.Point(180, 269);
		this.metroButton53.Name = "metroButton53";
		this.metroButton53.Size = new System.Drawing.Size(151, 23);
		this.metroButton53.TabIndex = 3;
		this.metroButton53.Text = "Tham gia nhóm gợi ý";
		this.metroButton53.UseSelectable = true;
		this.metroButton53.Click += new System.EventHandler(metroButton53_Click);
		this.metroButton44.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton44.Location = new System.Drawing.Point(14, 298);
		this.metroButton44.Name = "metroButton44";
		this.metroButton44.Size = new System.Drawing.Size(151, 23);
		this.metroButton44.TabIndex = 7;
		this.metroButton44.Text = "Tham gia nhóm theo ID";
		this.metroButton44.UseSelectable = true;
		this.metroButton44.Click += new System.EventHandler(metroButton44_Click);
		this.metroButton52.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton52.Location = new System.Drawing.Point(180, 124);
		this.metroButton52.Name = "metroButton52";
		this.metroButton52.Size = new System.Drawing.Size(151, 23);
		this.metroButton52.TabIndex = 0;
		this.metroButton52.Text = "Tham gia nhóm từ khóa";
		this.metroButton52.UseSelectable = true;
		this.metroButton52.Click += new System.EventHandler(metroButton52_Click);
		this.metroButton55.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton55.Location = new System.Drawing.Point(180, 182);
		this.metroButton55.Name = "metroButton55";
		this.metroButton55.Size = new System.Drawing.Size(151, 23);
		this.metroButton55.TabIndex = 1;
		this.metroButton55.Text = "Kết bạn theo gợi ý";
		this.metroButton55.UseSelectable = true;
		this.metroButton55.Click += new System.EventHandler(metroButton55_Click);
		this.metroButton40.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton40.Location = new System.Drawing.Point(14, 124);
		this.metroButton40.Name = "metroButton40";
		this.metroButton40.Size = new System.Drawing.Size(151, 23);
		this.metroButton40.TabIndex = 7;
		this.metroButton40.Text = "Đọc thông báo";
		this.metroButton40.UseSelectable = true;
		this.metroButton40.Click += new System.EventHandler(metroButton40_Click);
		this.metroButton54.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton54.Location = new System.Drawing.Point(180, 153);
		this.metroButton54.Name = "metroButton54";
		this.metroButton54.Size = new System.Drawing.Size(151, 23);
		this.metroButton54.TabIndex = 0;
		this.metroButton54.Text = "Kết bạn theo từ khóa";
		this.metroButton54.UseSelectable = true;
		this.metroButton54.Click += new System.EventHandler(metroButton54_Click);
		this.metroButton43.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton43.Location = new System.Drawing.Point(14, 211);
		this.metroButton43.Name = "metroButton43";
		this.metroButton43.Size = new System.Drawing.Size(151, 23);
		this.metroButton43.TabIndex = 7;
		this.metroButton43.Text = "Kết bạn theo UID";
		this.metroButton43.UseSelectable = true;
		this.metroButton43.Click += new System.EventHandler(metroButton43_Click);
		this.metroButton50.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton50.Location = new System.Drawing.Point(180, 211);
		this.metroButton50.Name = "metroButton50";
		this.metroButton50.Size = new System.Drawing.Size(151, 23);
		this.metroButton50.TabIndex = 1;
		this.metroButton50.Text = "Xem Story";
		this.metroButton50.UseSelectable = true;
		this.metroButton50.Click += new System.EventHandler(metroButton50_Click);
		this.metroButton51.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton51.Location = new System.Drawing.Point(180, 240);
		this.metroButton51.Name = "metroButton51";
		this.metroButton51.Size = new System.Drawing.Size(151, 23);
		this.metroButton51.TabIndex = 2;
		this.metroButton51.Text = "Xem Watch";
		this.metroButton51.UseSelectable = true;
		this.metroButton51.Click += new System.EventHandler(metroButton51_Click);
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(14, 269);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(151, 23);
		this.metroButton1.TabIndex = 0;
		this.metroButton1.Text = "Seeding bằng Video";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Visible = false;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.metroButton42.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton42.Location = new System.Drawing.Point(14, 153);
		this.metroButton42.Name = "metroButton42";
		this.metroButton42.Size = new System.Drawing.Size(151, 23);
		this.metroButton42.TabIndex = 7;
		this.metroButton42.Text = "Tương tác Newsfeed";
		this.metroButton42.UseSelectable = true;
		this.metroButton42.Click += new System.EventHandler(metroButton42_Click);
		this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox6.Controls.Add(this.metroButton75);
		this.groupBox6.Controls.Add(this.metroButton61);
		this.groupBox6.Controls.Add(this.metroButton65);
		this.groupBox6.Controls.Add(this.metroButton64);
		this.groupBox6.Controls.Add(this.metroButton63);
		this.groupBox6.Controls.Add(this.metroButton60);
		this.groupBox6.Controls.Add(this.metroButton57);
		this.groupBox6.Controls.Add(this.metroButton30);
		this.groupBox6.Controls.Add(this.pictureBox7);
		this.groupBox6.Controls.Add(this.metroButton28);
		this.groupBox6.Controls.Add(this.metroButton35);
		this.groupBox6.Controls.Add(this.metroButton33);
		this.groupBox6.Controls.Add(this.metroButton32);
		this.groupBox6.Location = new System.Drawing.Point(928, 42);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(179, 505);
		this.groupBox6.TabIndex = 4;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Chư\u0301c năng kha\u0301c";
		this.groupBox6.Enter += new System.EventHandler(groupBox6_Enter);
		this.metroButton75.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton75.Location = new System.Drawing.Point(14, 414);
		this.metroButton75.Name = "metroButton75";
		this.metroButton75.Size = new System.Drawing.Size(151, 23);
		this.metroButton75.TabIndex = 13;
		this.metroButton75.Text = "Kháng spam";
		this.metroButton75.UseSelectable = true;
		this.metroButton75.Click += new System.EventHandler(metroButton75_Click);
		this.metroButton61.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton61.Location = new System.Drawing.Point(14, 472);
		this.metroButton61.Name = "metroButton61";
		this.metroButton61.Size = new System.Drawing.Size(151, 23);
		this.metroButton61.TabIndex = 13;
		this.metroButton61.Text = "Verify + Up Avatar";
		this.metroButton61.UseSelectable = true;
		this.metroButton61.Visible = false;
		this.metroButton61.Click += new System.EventHandler(metroButton61_Click);
		this.metroButton67.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton67.Location = new System.Drawing.Point(14, 472);
		this.metroButton67.Name = "metroButton67";
		this.metroButton67.Size = new System.Drawing.Size(151, 23);
		this.metroButton67.TabIndex = 13;
		this.metroButton67.Text = "Login Hotmail";
		this.metroButton67.UseSelectable = true;
		this.metroButton67.Visible = false;
		this.metroButton67.Click += new System.EventHandler(metroButton67_Click);
		this.metroButton65.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton65.Location = new System.Drawing.Point(14, 385);
		this.metroButton65.Name = "metroButton65";
		this.metroButton65.Size = new System.Drawing.Size(151, 23);
		this.metroButton65.TabIndex = 12;
		this.metroButton65.Text = "Ẩn mail";
		this.metroButton65.UseSelectable = true;
		this.metroButton65.Click += new System.EventHandler(metroButton65_Click);
		this.metroButton64.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton64.Location = new System.Drawing.Point(14, 356);
		this.metroButton64.Name = "metroButton64";
		this.metroButton64.Size = new System.Drawing.Size(151, 23);
		this.metroButton64.TabIndex = 11;
		this.metroButton64.Text = "Xóa bài trên page";
		this.metroButton64.UseSelectable = true;
		this.metroButton64.Click += new System.EventHandler(metroButton64_Click);
		this.metroButton63.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton63.Location = new System.Drawing.Point(14, 269);
		this.metroButton63.Name = "metroButton63";
		this.metroButton63.Size = new System.Drawing.Size(151, 23);
		this.metroButton63.TabIndex = 10;
		this.metroButton63.Text = "Liên kết Instagram";
		this.metroButton63.UseSelectable = true;
		this.metroButton63.Click += new System.EventHandler(metroButton63_Click);
		this.metroButton60.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton60.Location = new System.Drawing.Point(14, 298);
		this.metroButton60.Name = "metroButton60";
		this.metroButton60.Size = new System.Drawing.Size(151, 23);
		this.metroButton60.TabIndex = 7;
		this.metroButton60.Text = "Đăng bài clone ID";
		this.metroButton60.UseSelectable = true;
		this.metroButton60.Click += new System.EventHandler(metroButton60_Click);
		this.metroButton57.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton57.Location = new System.Drawing.Point(14, 240);
		this.metroButton57.Name = "metroButton57";
		this.metroButton57.Size = new System.Drawing.Size(151, 23);
		this.metroButton57.TabIndex = 6;
		this.metroButton57.Text = "Hủy like page";
		this.metroButton57.UseSelectable = true;
		this.metroButton57.Click += new System.EventHandler(metroButton57_Click);
		this.metroButton30.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton30.Location = new System.Drawing.Point(14, 327);
		this.metroButton30.Name = "metroButton30";
		this.metroButton30.Size = new System.Drawing.Size(151, 23);
		this.metroButton30.TabIndex = 3;
		this.metroButton30.Text = "Xóa bài trên tường";
		this.metroButton30.UseSelectable = true;
		this.metroButton30.Click += new System.EventHandler(metroButton30_Click);
		this.pictureBox7.Image = Class306.Bitmap_3;
		this.pictureBox7.Location = new System.Drawing.Point(14, 22);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new System.Drawing.Size(151, 83);
		this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox7.TabIndex = 1;
		this.pictureBox7.TabStop = false;
		this.metroButton28.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton28.Location = new System.Drawing.Point(14, 124);
		this.metroButton28.Name = "metroButton28";
		this.metroButton28.Size = new System.Drawing.Size(151, 23);
		this.metroButton28.TabIndex = 2;
		this.metroButton28.Text = "Backup dư\u0303 liê\u0323u";
		this.metroButton28.UseSelectable = true;
		this.metroButton28.Click += new System.EventHandler(metroButton28_Click);
		this.metroButton35.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton35.Location = new System.Drawing.Point(14, 211);
		this.metroButton35.Name = "metroButton35";
		this.metroButton35.Size = new System.Drawing.Size(151, 23);
		this.metroButton35.TabIndex = 0;
		this.metroButton35.Text = "Nghỉ giải lao";
		this.metroButton35.UseSelectable = true;
		this.metroButton35.Click += new System.EventHandler(metroButton35_Click);
		this.metroButton33.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton33.Location = new System.Drawing.Point(14, 182);
		this.metroButton33.Name = "metroButton33";
		this.metroButton33.Size = new System.Drawing.Size(151, 23);
		this.metroButton33.TabIndex = 0;
		this.metroButton33.Text = "Truy cập Website";
		this.metroButton33.UseSelectable = true;
		this.metroButton33.Click += new System.EventHandler(metroButton33_Click);
		this.metroButton32.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton32.Location = new System.Drawing.Point(14, 153);
		this.metroButton32.Name = "metroButton32";
		this.metroButton32.Size = new System.Drawing.Size(151, 23);
		this.metroButton32.TabIndex = 0;
		this.metroButton32.Text = "Ti\u0300m kiê\u0301m Google";
		this.metroButton32.UseSelectable = true;
		this.metroButton32.Click += new System.EventHandler(metroButton32_Click);
		this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.groupBox3.Controls.Add(this.metroButton71);
		this.groupBox3.Controls.Add(this.metroButton70);
		this.groupBox3.Controls.Add(this.metroButton69);
		this.groupBox3.Controls.Add(this.pictureBox6);
		this.groupBox3.Controls.Add(this.metroButton24);
		this.groupBox3.Controls.Add(this.metroButton68);
		this.groupBox3.Controls.Add(this.metroButton56);
		this.groupBox3.Controls.Add(this.metroButton27);
		this.groupBox3.Controls.Add(this.metroButton49);
		this.groupBox3.Controls.Add(this.metroButton37);
		this.groupBox3.Controls.Add(this.metroButton36);
		this.groupBox3.Controls.Add(this.metroButton31);
		this.groupBox3.Controls.Add(this.metroButton25);
		this.groupBox3.Controls.Add(this.metroButton26);
		this.groupBox3.Location = new System.Drawing.Point(744, 42);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(178, 505);
		this.groupBox3.TabIndex = 4;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Chư\u0301c năng Seeding";
		this.metroButton71.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton71.Location = new System.Drawing.Point(14, 414);
		this.metroButton71.Name = "metroButton71";
		this.metroButton71.Size = new System.Drawing.Size(151, 23);
		this.metroButton71.TabIndex = 7;
		this.metroButton71.Text = "Report";
		this.metroButton71.UseSelectable = true;
		this.metroButton71.Visible = false;
		this.metroButton71.Click += new System.EventHandler(metroButton71_Click);
		this.metroButton70.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton70.Location = new System.Drawing.Point(14, 385);
		this.metroButton70.Name = "metroButton70";
		this.metroButton70.Size = new System.Drawing.Size(151, 23);
		this.metroButton70.TabIndex = 6;
		this.metroButton70.Text = "Phản hồi bình luận";
		this.metroButton70.UseSelectable = true;
		this.metroButton70.Click += new System.EventHandler(metroButton70_Click);
		this.metroButton69.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton69.Location = new System.Drawing.Point(14, 472);
		this.metroButton69.Name = "metroButton69";
		this.metroButton69.Size = new System.Drawing.Size(151, 23);
		this.metroButton69.TabIndex = 5;
		this.metroButton69.Text = "Xóa tin nhắn";
		this.metroButton69.UseSelectable = true;
		this.metroButton69.Visible = false;
		this.metroButton69.Click += new System.EventHandler(metroButton69_Click);
		this.pictureBox6.Image = Class306.Bitmap_253;
		this.pictureBox6.Location = new System.Drawing.Point(14, 22);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new System.Drawing.Size(151, 83);
		this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox6.TabIndex = 1;
		this.pictureBox6.TabStop = false;
		this.metroButton68.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton68.Location = new System.Drawing.Point(14, 443);
		this.metroButton68.Name = "metroButton68";
		this.metroButton68.Size = new System.Drawing.Size(151, 23);
		this.metroButton68.TabIndex = 4;
		this.metroButton68.Text = "Spam bài viết theo ID v2";
		this.metroButton68.UseSelectable = true;
		this.metroButton68.Visible = false;
		this.metroButton68.Click += new System.EventHandler(metroButton68_Click);
		this.metroButton56.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton56.Location = new System.Drawing.Point(14, 356);
		this.metroButton56.Name = "metroButton56";
		this.metroButton56.Size = new System.Drawing.Size(151, 23);
		this.metroButton56.TabIndex = 3;
		this.metroButton56.Text = "Mời bạn bè like page";
		this.metroButton56.UseSelectable = true;
		this.metroButton56.Click += new System.EventHandler(metroButton56_Click);
		this.metroButton27.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton27.Location = new System.Drawing.Point(14, 211);
		this.metroButton27.Name = "metroButton27";
		this.metroButton27.Size = new System.Drawing.Size(151, 23);
		this.metroButton27.TabIndex = 3;
		this.metroButton27.Text = "Buff Tin nhắn theo UID";
		this.metroButton27.UseSelectable = true;
		this.metroButton27.Click += new System.EventHandler(metroButton27_Click);
		this.metroButton37.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton37.Location = new System.Drawing.Point(14, 327);
		this.metroButton37.Name = "metroButton37";
		this.metroButton37.Size = new System.Drawing.Size(151, 23);
		this.metroButton37.TabIndex = 2;
		this.metroButton37.Text = "Share bài";
		this.metroButton37.UseSelectable = true;
		this.metroButton37.Click += new System.EventHandler(metroButton37_Click);
		this.metroButton36.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton36.Location = new System.Drawing.Point(14, 298);
		this.metroButton36.Name = "metroButton36";
		this.metroButton36.Size = new System.Drawing.Size(151, 23);
		this.metroButton36.TabIndex = 2;
		this.metroButton36.Text = "Đăng bài";
		this.metroButton36.UseSelectable = true;
		this.metroButton36.Click += new System.EventHandler(metroButton36_Click);
		this.metroButton31.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton31.Location = new System.Drawing.Point(14, 182);
		this.metroButton31.Name = "metroButton31";
		this.metroButton31.Size = new System.Drawing.Size(151, 23);
		this.metroButton31.TabIndex = 1;
		this.metroButton31.Text = "Buff Like, Follow page";
		this.metroButton31.UseSelectable = true;
		this.metroButton31.Click += new System.EventHandler(metroButton31_Click);
		this.metroButton25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton25.Location = new System.Drawing.Point(14, 153);
		this.metroButton25.Name = "metroButton25";
		this.metroButton25.Size = new System.Drawing.Size(151, 23);
		this.metroButton25.TabIndex = 1;
		this.metroButton25.Text = "Buff Follow ca\u0301 nhân";
		this.metroButton25.UseSelectable = true;
		this.metroButton25.Click += new System.EventHandler(metroButton25_Click);
		this.metroButton26.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton26.Location = new System.Drawing.Point(14, 124);
		this.metroButton26.Name = "metroButton26";
		this.metroButton26.Size = new System.Drawing.Size(151, 23);
		this.metroButton26.TabIndex = 0;
		this.metroButton26.Text = "Buff Like, Comment";
		this.metroButton26.UseSelectable = true;
		this.metroButton26.Click += new System.EventHandler(metroButton26_Click);
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 500;
		this.toolTip_0.ReshowDelay = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1471, 559);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemHanhDong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fThemHanhDong_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
		this.groupBox4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
		this.groupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
		this.panel1.ResumeLayout(false);
		this.groupBox7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox8).EndInit();
		this.groupBox6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
		this.groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
		base.ResumeLayout(false);
	}
}
