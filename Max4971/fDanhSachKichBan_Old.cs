using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDanhSachKichBan_Old : Form
{
	private string string_0 = "";

	private IContainer icontainer_0 = null;

	private ToolTip toolTip_0;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private GroupBox groupBox1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	private GroupBox groupBox2;

	public DataGridView dtgvKichBan;

	public DataGridView dtgvHanhDong;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Button button3;

	private Button button2;

	private ContextMenuStrip contextMenuStrip1_1;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn cId_HanhDong;

	private DataGridViewTextBoxColumn cTenHanhDong;

	private DataGridViewTextBoxColumn cTheLoai;

	private Panel panel1;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId_KichBan;

	private DataGridViewTextBoxColumn cTenKichBan;

	private SplitContainer splitContainer1;

	public fDanhSachKichBan_Old(string string_1)
	{
		InitializeComponent();
		method_0();
		string_0 = string_1;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox1);
		foreach (DataGridViewColumn column in dtgvKichBan.Columns)
		{
			GClass29.smethod_3(column);
		}
		GClass29.smethod_1(groupBox2);
		foreach (DataGridViewColumn column2 in dtgvHanhDong.Columns)
		{
			GClass29.smethod_3(column2);
		}
		GClass29.smethod_2(toolStripMenuItem_0);
		GClass29.smethod_2(toolStripMenuItem_1);
		GClass29.smethod_2(toolStripMenuItem_2);
		GClass29.smethod_2(toolStripMenuItem_3);
		GClass29.smethod_2(toolStripMenuItem1);
		GClass29.smethod_2(toolStripMenuItem3);
		GClass29.smethod_2(toolStripMenuItem4);
		GClass29.smethod_2(toolStripMenuItem2);
	}

	private void fDanhSachKichBan_Old_Load(object sender, EventArgs e)
	{
		method_7(string_0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_9();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		method_4();
	}

	public void method_1(ref DataGridView dataGridView_0, int int_0, int int_1)
	{
		string text = "";
		for (int i = 1; i < dataGridView_0.Columns.Count; i++)
		{
			text = Class309.smethod_2(dataGridView_0, int_0, i);
			Class309.smethod_4(dataGridView_0, int_0, i, Class309.smethod_2(dataGridView_0, int_1, i));
			Class309.smethod_4(dataGridView_0, int_1, i, text);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = Class309.smethod_3(dtgvHanhDong, index - 1, "cId_HanhDong");
		string text2 = Class309.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class307.smethod_21(text, text2))
			{
				method_1(ref dtgvHanhDong, index, index - 1);
				dtgvHanhDong.Rows[index - 1].Selected = true;
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == dtgvHanhDong.RowCount - 1)
		{
			return;
		}
		string text = Class309.smethod_3(dtgvHanhDong, index + 1, "cId_HanhDong");
		string text2 = Class309.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class307.smethod_21(text, text2))
			{
				method_1(ref dtgvHanhDong, index, index + 1);
				dtgvHanhDong.Rows[index + 1].Selected = true;
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_10();
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_11();
	}

	private void dtgvKichBan_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			method_3();
		}
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void dtgvHanhDong_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			method_4();
			break;
		case Keys.Insert:
		case Keys.F1:
			method_5();
			break;
		case Keys.F2:
			method_6();
			break;
		case Keys.F5:
			method_3();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				method_2();
			}
			break;
		}
	}

	private void method_2()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass38.smethod_0("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenHanhDong"].Value.ToString();
			string string_ = text2 + " - Copy";
			int num = 2;
			while (Class307.smethod_17(string_))
			{
				string_ = text2 + $" - Copy ({num++})";
			}
			if (Class307.smethod_19(text, string_))
			{
				DataTable dataTable = Class307.smethod_16();
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[0]["Id_HanhDong"], dataTable.Rows[0]["TenHanhDong"], dataTable.Rows[0]["MoTa"]);
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			dtgvHanhDong.Rows.Clear();
			if (dtgvKichBan.RowCount != 0)
			{
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
				DataTable dataTable = Class307.smethod_14(text);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[i]["Id_HanhDong"], dataTable.Rows[i]["TenHanhDong"], dataTable.Rows[i]["MoTa"]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm hành động trước!"), 3);
			}
			else
			{
				if (GClass38.smethod_1(GClass29.smethod_0("Bạn có chắc muốn xóa hoạt động này?")) != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
				if (Class307.smethod_22(dataGridViewRow.Cells["cId_HanhDong"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvHanhDong.Rows.Count - 1; i++)
					{
						method_1(ref dtgvHanhDong, i, i + 1);
					}
					dtgvHanhDong.Rows.RemoveAt(dtgvHanhDong.Rows.Count - 1);
				}
				else
				{
					GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_5()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string string_ = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			int count = Class307.smethod_14(string_).Rows.Count;
			GClass14.smethod_33(new fThemHanhDong(string_));
			DataTable dataTable = Class307.smethod_14(string_);
			int count2 = dataTable.Rows.Count;
			if (count2 > count)
			{
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[count2 - 1]["Id_HanhDong"], dataTable.Rows[count2 - 1]["TenHanhDong"], dataTable.Rows[count2 - 1]["MoTa"]);
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_6()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm hành động trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string string_ = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			DataTable dataTable = Class307.smethod_15(string_);
			Form form = null;
			string text = dataTable.Rows[0]["TenTuongTac"].ToString();
			string text2 = text;
			string text3 = text2;
			switch (Class321.smethod_0(text3))
			{
			case 60724616u:
				if (text3 == "HDThamGiaNhomTuKhoav2")
				{
					form = new fHDThamGiaNhomTuKhoav2("", 1, string_);
				}
				break;
			case 18769620u:
				if (text3 == "HDNhanTinPage")
				{
					form = new fHDNhanTinPage("", 1, string_);
				}
				break;
			case 228496669u:
				if (text3 == "HDDocThongBaov2")
				{
					form = new fHDDocThongBaov2("", 1, string_);
				}
				break;
			case 170588456u:
				if (text3 == "HDShareBai")
				{
					form = new fHDShareBai("", 1, string_);
				}
				break;
			case 159321262u:
				if (text3 == "HDThamGiaNhomUidv2")
				{
					form = new fHDThamGiaNhomUidv2("", 1, string_);
				}
				break;
			case 311671696u:
				if (text3 == "HDKetBanGoiY")
				{
					form = new fHDKetBanGoiY("", 1, string_);
				}
				break;
			case 271171672u:
				if (text3 == "HDTruyCapWebsite")
				{
					form = new fHDTruyCapWebsite("", 1, string_);
				}
				break;
			case 390215220u:
				if (text3 == "HDKetBanTheoTuKhoav2")
				{
					form = new fHDKetBanTheoTuKhoav2("", 1, string_);
				}
				break;
			case 378364318u:
				if (text3 == "HDDangBaiTheoID")
				{
					form = new fHDDangBaiTheoID("", 1, string_);
				}
				break;
			case 327820411u:
				if (text3 == "HDBuffTinNhanProfile")
				{
					form = new fHDBuffTinNhanProfile("", 1, string_);
				}
				break;
			case 532292684u:
				if (text3 == "HDBuffLikeComment")
				{
					form = new fHDBuffLikeComment("", 1, string_);
				}
				break;
			case 444757497u:
				if (text3 == "HDKetBanTepUidNew")
				{
					form = new fHDKetBanTepUidNew("", 1, string_);
				}
				break;
			case 786238800u:
				if (text3 == "HDXemWatch")
				{
					form = new fHDXemWatch("", 1, string_);
				}
				break;
			case 614517095u:
				if (text3 == "HDReport")
				{
					form = new fHDReport("", 1, string_);
				}
				break;
			case 582938346u:
				if (text3 == "HDXemStory")
				{
					form = new fHDXemStory("", 1, string_);
				}
				break;
			case 1005065709u:
				if (text3 == "HDLoginMail")
				{
					form = new fHDLoginMail("", 1, string_);
				}
				break;
			case 935513960u:
				if (text3 == "HDMoiLikePage")
				{
					form = new fHDMoiLikePage("", 1, string_);
				}
				break;
			case 852508141u:
				if (text3 == "HDKetBanTepUid")
				{
					form = new fHDKetBanTepUid("", 1, string_);
				}
				break;
			case 1411668073u:
				if (text3 == "HDChangeSoThich")
				{
					form = new fHDChangeSoThich("", 1, string_);
				}
				break;
			case 1197870971u:
				if (text3 == "HDTuongTacNewsfeedv2")
				{
					form = new fHDTuongTacNewsfeedv2("", 1, string_);
				}
				break;
			case 1085363537u:
				if (text3 == "HDAnMail")
				{
					form = new fHDAnMail("", 1, string_);
				}
				break;
			case 1430147666u:
				if (text3 == "HDXemStoryv2")
				{
					form = new fHDXemStoryv2("", 1, string_);
				}
				break;
			case 1426897924u:
				if (text3 == "HDBaiVietProfile")
				{
					form = new fHDBaiVietProfile("", 1, string_);
				}
				break;
			case 1526944464u:
				if (text3 == "HDTuongTacBanBe")
				{
					form = new fHDTuongTacBanBe("", 1, string_);
				}
				break;
			case 1470935067u:
				if (text3 == "HDDangStatus")
				{
					form = new fHDDangStatus("", 1, string_);
				}
				break;
			case 1467610808u:
				if (text3 == "HDLinkToInstagram")
				{
					form = new fHDLinkToInstagram("", 1, string_);
				}
				break;
			case 1640113110u:
				if (text3 == "HDKetBanVoiBanCuaBanBe")
				{
					form = new fHDKetBanVoiBanCuaBanBe("", 1, string_);
				}
				break;
			case 1564120736u:
				if (text3 == "HDXemWatchv2")
				{
					form = new fHDXemWatchv2("", 1, string_);
				}
				break;
			case 1530053848u:
				if (text3 == "HDShareBaiv2")
				{
					form = new fHDShareBaiv2("", 1, string_);
				}
				break;
			case 1723758688u:
				if (text3 == "HDXoaBaiTuong")
				{
					form = new fHDXoaBaiTuong("", 1, string_);
				}
				break;
			case 1697418988u:
				if (text3 == "HDTimKiemGoogle")
				{
					form = new fHDTimKiemGoogle("", 1, string_);
				}
				break;
			case 1653385921u:
				if (text3 == "HDNghiGiaiLao")
				{
					form = new fHDNghiGiaiLao("", 1, string_);
				}
				break;
			case 1807592900u:
				if (text3 == "HDSeedingByVideo")
				{
					form = new fHDSeedingByVideo("", 1, string_);
				}
				break;
			case 1742384383u:
				if (text3 == "HDChangeTenPhu")
				{
					form = new fHDChangeTenPhu("", 1, string_);
				}
				break;
			case 1891134530u:
				if (text3 == "HDXoaBaiPage")
				{
					form = new fHDXoaBaiPage("", 1, string_);
				}
				break;
			case 1884305945u:
				if (text3 == "HDDocThongBao")
				{
					form = new fHDDocThongBao("", 1, string_);
				}
				break;
			case 1810740917u:
				if (text3 == "HDNhanTinBanBe")
				{
					form = new fHDNhanTinBanBe("", 1, string_);
				}
				break;
			case 1984335833u:
				if (text3 == "HDBaiVietBanBe")
				{
					form = new fHDBaiVietBanBe("", 1, string_);
				}
				break;
			case 1952866892u:
				if (text3 == "HDKetBanTheoTuKhoa")
				{
					form = new fHDKetBanTheoTuKhoa("", 1, string_);
				}
				break;
			case 1906272025u:
				if (text3 == "HDKetBanVoiBanBeCuaUid")
				{
					form = new fHDKetBanVoiBanBeCuaUid("", 1, string_);
				}
				break;
			case 2065195933u:
				if (text3 == "HDBuffFollowLikePage")
				{
					form = new fHDBuffFollowLikePage("", 1, string_);
				}
				break;
			case 2018428872u:
				if (text3 == "HDThamGiaNhomGoiYv2")
				{
					form = new fHDThamGiaNhomGoiYv2("", 1, string_);
				}
				break;
			case 1999692336u:
				if (text3 == "HDVerify")
				{
					form = new fHDVerify("", 1, string_);
				}
				break;
			case 2081285240u:
				if (text3 == "HDChocBanBe")
				{
					form = new fHDChocBanBe("", 1, string_);
				}
				break;
			case 2079252553u:
				if (text3 == "HDPhanHoiBinhLuan")
				{
					form = new fHDPhanHoiBinhLuan("", 1, string_);
				}
				break;
			case 2253849399u:
				if (text3 == "HDTraLoiComment")
				{
					form = new fHDTraLoiComment("", 1, string_);
				}
				break;
			case 2230339588u:
				if (text3 == "HDBuffFollowCaNhan")
				{
					form = new fHDBuffFollowCaNhan("", 1, string_);
				}
				break;
			case 2117563667u:
				if (text3 == "HDKhangSpam")
				{
					form = new fHDKhangSpam("", 1, string_);
				}
				break;
			case 2277183375u:
				if (text3 == "HDRoiNhom")
				{
					form = new fHDRoiNhom("", 1, string_);
				}
				break;
			case 2255824322u:
				if (text3 == "HDXoaNhatKyHoatDong")
				{
					form = new fHDXoaNhatKyHoatDong("", 1, string_);
				}
				break;
			case 2483578584u:
				if (text3 == "HDBuffViewVideo")
				{
					form = new fHDBuffViewVideo("", 1, string_);
				}
				break;
			case 2421286761u:
				if (text3 == "HDBaiVietNhom")
				{
					form = new fHDBaiVietNhom("", 1, string_);
				}
				break;
			case 2416405417u:
				if (text3 == "HDHuyLikePage")
				{
					form = new fHDHuyLikePage("", 1, string_);
				}
				break;
			case 2586028642u:
				if (text3 == "HDTuongTacBaiVietNhomv2")
				{
					form = new fHDTuongTacBaiVietNhomv2("", 1, string_);
				}
				break;
			case 2540878680u:
				if (text3 == "HDThamGiaNhomTuKhoa")
				{
					form = new fHDThamGiaNhomTuKhoa("", 1, string_);
				}
				break;
			case 2739439145u:
				if (text3 == "HDTuongTacBaiVietTheoID")
				{
					form = new fHDTuongTacBaiVietTheoID("", 1, string_);
				}
				break;
			case 2735851020u:
				if (text3 == "HDBaiVietNewsfeedv2")
				{
					form = new fHDBaiVietNewsfeedv2("", 1, string_);
				}
				break;
			case 2703861858u:
				if (text3 == "HDChucMungSinhNhat")
				{
					form = new fHDChucMungSinhNhat("", 1, string_);
				}
				break;
			case 2924758840u:
				if (text3 == "HDMoiBanBeVaoNhom")
				{
					form = new fHDMoiBanBeVaoNhom("", 1, string_);
				}
				break;
			case 2837141903u:
				if (text3 == "HDBaiVietFanpage")
				{
					form = new fHDBaiVietFanpage("", 1, string_);
				}
				break;
			case 2821037716u:
				if (text3 == "HDHuyKetBan")
				{
					form = new fHDHuyKetBan("", 1, string_);
				}
				break;
			case 3035546143u:
				if (text3 == "HDTuongTacNewsfeed")
				{
					form = new fHDTuongTacNewsfeed("", 1, string_);
				}
				break;
			case 2951725920u:
				if (text3 == "HDKetBanGoiYv2")
				{
					form = new fHDKetBanGoiYv2("", 1, string_);
				}
				break;
			case 2944435598u:
				if (text3 == "HDThamGiaNhomUid")
				{
					form = new fHDThamGiaNhomUid("", 1, string_);
				}
				break;
			case 3155799767u:
				if (text3 == "HDHuyKetBanNhanh")
				{
					form = new fHDHuyKetBan2("", 1, string_);
				}
				break;
			case 3128485203u:
				if (text3 == "HDXacNhanKetBanv2")
				{
					form = new fHDXacNhanKetBanv2("", 1, string_);
				}
				break;
			case 3372854657u:
				if (text3 == "HDGiaiCheckpoint")
				{
					form = new fHDGiaiCheckpoint("", 1, string_);
				}
				break;
			case 3288035657u:
				if (text3 == "HDKetBanTepUidv2")
				{
					form = new fHDKetBanTepUidv2("", 1, string_);
				}
				break;
			case 3169819074u:
				if (text3 == "HDCongKhaiBaiVietGanThe")
				{
					form = new fHDCongKhaiBaiVietGanThe("", 1, string_);
				}
				break;
			case 3598280146u:
				if (text3 == "HDKetBanNewfeed")
				{
					form = new fHDKetBanNewfeed("", 1, string_);
				}
				break;
			case 3550581772u:
				if (text3 == "HDPhanHoiTinNhan")
				{
					form = new fHDPhanHoiTinNhan("", 1, string_);
				}
				break;
			case 3427768725u:
				if (text3 == "HDBaiVietTrenTuong")
				{
					form = new fHDBaiVietTrenTuong("", 1, string_);
				}
				break;
			case 3732058847u:
				if (text3 == "HDDangStatusV2")
				{
					form = new fHDDangStatusV2("", 1, string_);
				}
				break;
			case 3677432718u:
				if (text3 == "HDDangStory")
				{
					form = new fHDDangStory("", 1, string_);
				}
				break;
			case 3671364376u:
				if (text3 == "HDThamGiaNhomGoiY")
				{
					form = new fHDThamGiaNhomGoiY("", 1, string_);
				}
				break;
			case 3779638787u:
				if (text3 == "HDBackupData")
				{
					form = new fHDBackupData("", 1, string_);
				}
				break;
			case 3742679556u:
				if (text3 == "HDBaiVietNewsfeed")
				{
					form = new fHDBaiVietNewsfeed("", 1, string_);
				}
				break;
			case 3921961843u:
				if (text3 == "HDXoaTinNhan")
				{
					form = new fHDXoaTinNhan("", 1, string_);
				}
				break;
			case 3917587807u:
				if (text3 == "HDHuyLoiMoiKetBan")
				{
					form = new fHDHuyLoiMoiKetBan("", 1, string_);
				}
				break;
			case 3850864715u:
				if (text3 == "HDDangBai")
				{
					form = new fHDDangBai("", 1, string_);
				}
				break;
			case 4136680805u:
				if (text3 == "HDShareBaiTut")
				{
					form = new fHDShareBaiTut("", 1, string_);
				}
				break;
			case 4095834327u:
				if (text3 == "HDXacNhanKetBan")
				{
					form = new fHDXacNhanKetBan("", 1, string_);
				}
				break;
			case 4054725761u:
				if (text3 == "HDXemStoryChiDinh")
				{
					form = new fHDXemStoryChiDinh("", 1, string_);
				}
				break;
			case 4272788648u:
				if (text3 == "HDSpamBaiVietv2")
				{
					form = new fHDSpamBaiVietv2("", 1, string_);
				}
				break;
			case 4226158249u:
				if (text3 == "HDKetBanThanhVienNhom")
				{
					form = new fHDKetBanThanhVienNhom("", 1, string_);
				}
				break;
			case 4189681400u:
				if (text3 == "HDSpamBaiViet")
				{
					form = new fHDSpamBaiViet("", 1, string_);
				}
				break;
			}
			if (form != null)
			{
				GClass14.smethod_33(form);
			}
			dataTable = Class307.smethod_15(string_);
			Class309.smethod_5(dtgvHanhDong, dataGridViewRow.Index, "cTenHanhDong", dataTable.Rows[0]["TenHanhDong"].ToString());
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void dtgvKichBan_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			method_8();
			break;
		case Keys.Insert:
		case Keys.F1:
			method_10();
			break;
		case Keys.F2:
			method_9();
			break;
		case Keys.F5:
			method_7();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				method_11();
			}
			break;
		}
	}

	private void method_7(string string_1 = "")
	{
		try
		{
			dtgvKichBan.Rows.Clear();
			DataTable dataTable = Class307.smethod_4();
			if (dataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					dtgvKichBan.Rows.Add(i + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
				}
			}
			if (string_1 != "")
			{
				for (int j = 0; j < dtgvKichBan.RowCount; j++)
				{
					if (Class309.smethod_3(dtgvKichBan, j, "cId_KichBan") == string_1)
					{
						dtgvKichBan.Rows[j].Selected = true;
						break;
					}
				}
			}
			method_3();
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
		}
	}

	private void method_8()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
			}
			else
			{
				if (GClass38.smethod_1(GClass29.smethod_0("Bạn có chắc muốn xóa kịch bản này?")) != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				if (Class307.smethod_11(dataGridViewRow.Cells["cId_KichBan"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvKichBan.Rows.Count - 1; i++)
					{
						method_1(ref dtgvKichBan, i, i + 1);
					}
					dtgvKichBan.Rows.RemoveAt(dtgvKichBan.Rows.Count - 1);
					method_3();
				}
				else
				{
					GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_9()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string string_ = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			GClass14.smethod_33(new fThemKichBan(1, string_));
			string object_ = Class307.smethod_2(string_).Rows[0]["TenKichBan"].ToString();
			Class309.smethod_5(dtgvKichBan, dataGridViewRow.Index, "cTenKichBan", object_);
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_10()
	{
		try
		{
			string text = "";
			try
			{
				text = Class307.smethod_5().Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			GClass14.smethod_33(new fThemKichBan(0));
			DataTable dataTable = Class307.smethod_5();
			string text2 = "";
			try
			{
				text2 = dataTable.Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			if (text != text2)
			{
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_11()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenKichBan"].Value.ToString();
			string string_ = text2 + " - Copy";
			int num = 2;
			while (Class307.smethod_8(string_))
			{
				string_ = text2 + $" - Copy ({num++})";
			}
			if (Class307.smethod_12(text, string_))
			{
				DataTable dataTable = Class307.smethod_5();
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		catch
		{
		}
	}

	private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		Keys keys = keyCode;
		if (keys == Keys.Up || keys == Keys.Down)
		{
			method_3();
		}
	}

	private void fDanhSachKichBan_Old_Paint(object sender, PaintEventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachKichBan_Old));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.dtgvKichBan = new System.Windows.Forms.DataGridView();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId_KichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.dtgvHanhDong = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId_HanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTenHanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.contextMenuStrip1_1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.panel1 = new System.Windows.Forms.Panel();
		this.splitContainer1 = new System.Windows.Forms.SplitContainer();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvHanhDong).BeginInit();
		this.contextMenuStrip1_1.SuspendLayout();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.toolTip_0.ToolTipTitle = "Chú thích";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(771, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Qua\u0309n ly\u0301 ki\u0323ch ba\u0309n";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(986, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(957, 2);
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
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.dtgvKichBan);
		this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox1.Location = new System.Drawing.Point(0, 0);
		this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox1.Size = new System.Drawing.Size(330, 517);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Danh sách kịch bản";
		this.dtgvKichBan.AllowUserToAddRows = false;
		this.dtgvKichBan.AllowUserToDeleteRows = false;
		this.dtgvKichBan.AllowUserToResizeRows = false;
		this.dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvKichBan.Columns.AddRange(this.cStt, this.cId_KichBan, this.cTenKichBan);
		this.dtgvKichBan.ContextMenuStrip = this.contextMenuStrip1;
		this.dtgvKichBan.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvKichBan.Location = new System.Drawing.Point(3, 20);
		this.dtgvKichBan.MultiSelect = false;
		this.dtgvKichBan.Name = "dtgvKichBan";
		this.dtgvKichBan.RowHeadersVisible = false;
		this.dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvKichBan.Size = new System.Drawing.Size(324, 493);
		this.dtgvKichBan.TabIndex = 76;
		this.dtgvKichBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvKichBan_CellClick);
		this.dtgvKichBan.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvKichBan_KeyDown);
		this.dtgvKichBan.KeyUp += new System.Windows.Forms.KeyEventHandler(dtgvKichBan_KeyUp);
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.Width = 35;
		this.cId_KichBan.HeaderText = "Column1";
		this.cId_KichBan.Name = "cId_KichBan";
		this.cId_KichBan.Visible = false;
		this.cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cTenKichBan.HeaderText = "Tên kịch bản";
		this.cTenKichBan.Name = "cTenKichBan";
		this.cTenKichBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
		this.toolStripMenuItem_0.Image = Class306.Bitmap_77;
		this.toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_0.Text = "Thêm ki\u0323ch ba\u0309n";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.toolStripMenuItem_1.Image = Class306.Bitmap_120;
		this.toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_1.Text = "Sửa tên ki\u0323ch ba\u0309n";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.toolStripMenuItem_2.Image = Class306.Bitmap_116;
		this.toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_2.Text = "Xóa ki\u0323ch ba\u0309n";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.toolStripMenuItem_3.Image = Class306.Bitmap_107;
		this.toolStripMenuItem_3.Name = "nhânBảnToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_3.Text = "Nhân bản";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
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
		this.bunifuCards1.Size = new System.Drawing.Size(989, 37);
		this.bunifuCards1.TabIndex = 12;
		this.groupBox2.BackColor = System.Drawing.Color.White;
		this.groupBox2.Controls.Add(this.button3);
		this.groupBox2.Controls.Add(this.button2);
		this.groupBox2.Controls.Add(this.dtgvHanhDong);
		this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox2.Location = new System.Drawing.Point(0, 0);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Size = new System.Drawing.Size(639, 517);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Danh sách hành động";
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Image = Class306.Bitmap_118;
		this.button3.Location = new System.Drawing.Point(594, 64);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(41, 38);
		this.button3.TabIndex = 78;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Image = Class306.Bitmap_222;
		this.button2.Location = new System.Drawing.Point(594, 19);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(41, 38);
		this.button2.TabIndex = 78;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.dtgvHanhDong.AllowUserToAddRows = false;
		this.dtgvHanhDong.AllowUserToDeleteRows = false;
		this.dtgvHanhDong.AllowUserToResizeRows = false;
		this.dtgvHanhDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dtgvHanhDong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvHanhDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvHanhDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvHanhDong.Columns.AddRange(this.dataGridViewTextBoxColumn1, this.cId_HanhDong, this.cTenHanhDong, this.cTheLoai);
		this.dtgvHanhDong.ContextMenuStrip = this.contextMenuStrip1_1;
		this.dtgvHanhDong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvHanhDong.Location = new System.Drawing.Point(6, 20);
		this.dtgvHanhDong.MultiSelect = false;
		this.dtgvHanhDong.Name = "dtgvHanhDong";
		this.dtgvHanhDong.RowHeadersVisible = false;
		this.dtgvHanhDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvHanhDong.Size = new System.Drawing.Size(585, 493);
		this.dtgvHanhDong.TabIndex = 77;
		this.dtgvHanhDong.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvHanhDong_KeyDown);
		this.dataGridViewTextBoxColumn1.HeaderText = "STT";
		this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn1.Width = 35;
		this.cId_HanhDong.HeaderText = "Column1";
		this.cId_HanhDong.Name = "cId_HanhDong";
		this.cId_HanhDong.Visible = false;
		this.cTenHanhDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cTenHanhDong.HeaderText = "Tên hành động";
		this.cTenHanhDong.Name = "cTenHanhDong";
		this.cTenHanhDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cTheLoai.HeaderText = "Loại tương tác";
		this.cTheLoai.Name = "cTheLoai";
		this.cTheLoai.Width = 175;
		this.contextMenuStrip1_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripMenuItem1, this.toolStripMenuItem3, this.toolStripMenuItem4, this.toolStripMenuItem2 });
		this.contextMenuStrip1_1.Name = "contextMenuStrip1";
		this.contextMenuStrip1_1.Size = new System.Drawing.Size(166, 92);
		this.toolStripMenuItem1.Image = Class306.Bitmap_76;
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem1.Text = "Thêm ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		this.toolStripMenuItem3.Image = Class306.Bitmap_119;
		this.toolStripMenuItem3.Name = "toolStripMenuItem3";
		this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem3.Text = "Sửa ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem3.Click += new System.EventHandler(toolStripMenuItem3_Click);
		this.toolStripMenuItem4.Image = Class306.Bitmap_115;
		this.toolStripMenuItem4.Name = "toolStripMenuItem4";
		this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem4.Text = "Xóa ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
		this.toolStripMenuItem2.Image = Class306.Bitmap_106;
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem2.Text = "Nhân bản";
		this.toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.splitContainer1);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(992, 565);
		this.panel1.TabIndex = 13;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.splitContainer1.Location = new System.Drawing.Point(4, 40);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
		this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
		this.splitContainer1.Size = new System.Drawing.Size(984, 517);
		this.splitContainer1.SplitterDistance = 330;
		this.splitContainer1.SplitterWidth = 15;
		this.splitContainer1.TabIndex = 13;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(992, 565);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDanhSachKichBan_Old";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fDanhSachKichBan_Old_Load);
		base.Paint += new System.Windows.Forms.PaintEventHandler(fDanhSachKichBan_Old_Paint);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		this.bunifuCards1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvHanhDong).EndInit();
		this.contextMenuStrip1_1.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
