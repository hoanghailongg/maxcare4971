using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;

public class fCauHinhChung : Form
{
	private GClass17 gclass17_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Label label3;

	private NumericUpDown nudInteractThread;

	private Label label4;

	private Label label5;

	private NumericUpDown nudHideThread;

	private Label label6;

	private Label label9;

	private TextBox txbPathProfile;

	private Panel panel1;

	private GroupBox groupBox2;

	private CheckBox ckbShowImageInteract;

	private ComboBox cbbHostpot;

	private Panel plNordVPN;

	private Label label14;

	private TextBox txtNordVPN;

	private Button btnSSH;

	private RadioButton rbSSH;

	private RadioButton rbExpressVPN;

	private RadioButton rbNordVPN;

	private RadioButton rbHotspot;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private Button btnCancel;

	private Button btnSave;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button2;

	private ComboBox cbbRowChrome;

	private ComboBox cbbColumnChrome;

	private Label label10;

	private Label label11;

	private Panel panel2;

	private Label label12;

	private TextBox textBox1;

	private RadioButton radioButton5;

	private RadioButton radioButton4;

	private RadioButton radioButton3;

	private RadioButton radioButton2;

	private GroupBox grChrome;

	private RadioButton rbChromium;

	private RadioButton rbChrome;

	private Label label15;

	private TextBox txtLinkToOtherBrowser;

	private Label label19;

	private Panel plLinkToOtherBrowser;

	private NumericUpDown nudDelayOpenChromeTo;

	private Label label21;

	private Label label20;

	private Label label22;

	private Button button6;

	private GroupBox groupBox1;

	private RadioButton rbPhanBietMauChu;

	private RadioButton rbPhanBietMauNen;

	private Label label23;

	private NumericUpDown nudDelayOpenChromeFrom;

	private Label label29;

	private NumericUpDown nudDelayCloseChromeFrom;

	private NumericUpDown nudDelayCloseChromeTo;

	private Label label32;

	private Label label31;

	private Label label2;

	private ComboBox cbbSizeChrome;

	private Label label34;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private MetroButton AddFileAccount;

	private Panel plSizeChrome;

	private RadioButton rbTocDoGoNhanh;

	private RadioButton rbTocDoGoBinhThuong;

	private RadioButton rbTocDoGoCham;

	private Label label30;

	private Panel panel4;

	private NumericUpDown nudHeighChrome;

	private NumericUpDown nudWidthChrome;

	private CheckBox ckbAddChromeIntoForm;

	private Label label33;

	private Label label35;

	private Panel plAddChromeVaoFormView;

	private Button button9;

	private Panel plSapXepCuaSoChrome;

	private Panel plUsePortable;

	private Label lblFileZip;

	private CheckBox ckbUsePortable;

	private TextBox txtPathToPortableZip;

	private Panel panel3;

	private Button button1;

	private LinkLabel linkLabel2;

	private Panel plVitech;

	private RichTextBox txtListProxyVitech;

	private RadioButton radioButton9;

	private RadioButton radioButton10;

	private Label label40;

	private Label label41;

	private Label label42;

	private NumericUpDown nudLuongPerIPVitech;

	private Label label46;

	private TextBox txtApiVitech;

	private RadioButton rbVitech;

	private CheckBox ckbLuuTrangThai;

	private GroupBox groupBox3;

	private TabControl tabChangeIP;

	private TabPage tabDcom;

	private Panel plDcom;

	private Button button4;

	private TextBox txtUrlHilink;

	private TextBox txtProfileNameDcom;

	private RadioButton rbDcomHilink;

	private Label label36;

	private RadioButton rbDcomThuong;

	private TabPage tabTinsoft;

	private Panel plTinsoft;

	private CheckBox ckbWaitDoneAllTinsoft;

	private Panel plApiProxy;

	private Label lblCountApiProxy;

	private Label label28;

	private TextBox txtApiProxy;

	private Button button7;

	private Panel plApiUser;

	private Label label1;

	private TextBox txtApiUser;

	private Button button3;

	private ComboBox cbbLocationTinsoft;

	private RadioButton rbApiProxy;

	private RadioButton rbApiUser;

	private Label label7;

	private Label label8;

	private NumericUpDown nudLuongPerIPTinsoft;

	private TabPage tabXProxy;

	private Panel plXproxy;

	private TabPage tabObcProxy;

	private Panel plObcProxy;

	private Panel panel8;

	private Label label54;

	private RadioButton rbObcResetDaiIP;

	private RadioButton rbObcResetTungIP;

	private RadioButton rbObcSock5Proxy;

	private RadioButton rbObcHttpProxy;

	private Label label55;

	private RichTextBox txtListObcProxy;

	private Label label67;

	private Label label68;

	private Label label69;

	private NumericUpDown nudLuongPerIPObcProxy;

	private Label label70;

	private Label label71;

	private NumericUpDown nudDelayCheckIPObcProxy;

	private TextBox txtLinkWebObcProxy;

	private TabPage tabProxyV6;

	private Panel plProxyv6;

	private RichTextBox txtListProxyv6;

	private RadioButton radioButton1;

	private RadioButton radioButton6;

	private Label label39;

	private Label label43;

	private Label label44;

	private NumericUpDown nudLuongPerIPProxyv6;

	private Label label45;

	private TextBox txtApiProxyv6;

	private TabPage tabProxyShopLike;

	private Panel plShopLike;

	private RichTextBox txtApiShopLike;

	private Label label47;

	private Label label48;

	private NumericUpDown nudLuongPerIPShopLike;

	private TabPage tabTMProxy;

	private Panel panel15;

	private Panel plTMProxy;

	private CheckBox ckbWaitDoneAllTMProxy;

	private RichTextBox txtApiKeyTMProxy;

	private Label label24;

	private Button button8;

	private Label label25;

	private NumericUpDown nudLuongPerIPTMProxy;

	private TabPage tabNone;

	private Panel panel16;

	private TabPage tabMinProxy;

	private Panel panel5;

	private Panel plTypeProxy;

	private RadioButton rbSockv6;

	private RadioButton rbSockv4;

	private RadioButton rbHttpv6;

	private RadioButton rbHttpv4;

	private Label label56;

	private RadioButton rbProxyDanCu;

	private RadioButton rbProxyDong;

	private Button button10;

	private RichTextBox txtApiKeyMinProxy;

	private Label label49;

	private Label label50;

	private NumericUpDown nudLuongPerIPMinProxy;

	private RadioButton rbMinProxy;

	private RadioButton rbShopLike;

	private RadioButton rbProxyv6;

	private Label label37;

	private NumericUpDown nudDelayCheckIP;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel3;

	private Label label38;

	private Panel plCheckDoiIP;

	private Button button5;

	private Label label26;

	private NumericUpDown nudChangeIpCount;

	private Label label27;

	private RadioButton rbTMProxy;

	private RadioButton rbDcom;

	private RadioButton rbTinsoft;

	private RadioButton rbProxy;

	private RadioButton rbNone;

	private RadioButton rbObcProxy;

	private RadioButton rbXproxy;

	private RadioButton rbHma;

	private CheckBox ckbKhongCheckIP;

	private Panel panel6;

	private RadioButton rbServer;

	private RadioButton rbClient;

	private Label label57;

	private Panel panel7;

	private Label label53;

	private RadioButton rbXproxyResetAllProxy;

	private RadioButton rbXproxyResetEachProxy;

	private CheckBox ckbWaitDoneAllXproxy;

	private RichTextBox txtListProxy;

	private RadioButton rbSock5Proxy;

	private RadioButton rbHttpProxy;

	private Label label16;

	private Label label17;

	private Label label52;

	private Label label51;

	private Label label18;

	private NumericUpDown nudDelayResetXProxy;

	private NumericUpDown nudLuongPerIPXProxy;

	private Label label13;

	private TextBox txtServiceURLXProxy;

	public fCauHinhChung()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configGeneral");
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label6);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label5);
		GClass29.smethod_1(label9);
		GClass29.smethod_1(grChrome);
		GClass29.smethod_1(ckbShowImageInteract);
		GClass29.smethod_1(ckbAddChromeIntoForm);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label29);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label32);
		GClass29.smethod_1(label31);
		GClass29.smethod_1(label30);
		GClass29.smethod_1(rbTocDoGoCham);
		GClass29.smethod_1(rbTocDoGoBinhThuong);
		GClass29.smethod_1(rbTocDoGoNhanh);
		GClass29.smethod_1(linkLabel2);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(label23);
		GClass29.smethod_1(rbPhanBietMauNen);
		GClass29.smethod_1(rbPhanBietMauChu);
		GClass29.smethod_1(groupBox3);
		GClass29.smethod_1(ckbKhongCheckIP);
		GClass29.smethod_1(label26);
		GClass29.smethod_1(label27);
		GClass29.smethod_1(button5);
		GClass29.smethod_1(rbNone);
		GClass29.smethod_1(rbProxy);
		GClass29.smethod_1(rbHma);
		GClass29.smethod_1(rbDcom);
		GClass29.smethod_1(button4);
		GClass29.smethod_1(rbTinsoft);
		GClass29.smethod_1(linkLabel3);
		GClass29.smethod_1(rbApiUser);
		GClass29.smethod_1(ckbWaitDoneAllTinsoft);
		GClass29.smethod_1(rbApiProxy);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(label16);
		GClass29.smethod_1(label17);
		GClass29.smethod_1(ckbWaitDoneAllXproxy);
		GClass29.smethod_1(label18);
		GClass29.smethod_1(linkLabel1);
		GClass29.smethod_1(label24);
		GClass29.smethod_1(ckbWaitDoneAllTMProxy);
		GClass29.smethod_1(label25);
		GClass29.smethod_1(btnSave);
		GClass29.smethod_1(btnCancel);
	}

	private void method_1()
	{
		Dictionary<string, string> dataSource = method_2();
		cbbLocationTinsoft.DataSource = new BindingSource(dataSource, null);
		cbbLocationTinsoft.ValueMember = "Key";
		cbbLocationTinsoft.DisplayMember = "Value";
	}

	public Dictionary<string, string> method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		List<string> list = Class38.smethod_2();
		for (int i = 0; i < list.Count; i++)
		{
			string[] array = list[i].Split('|');
			dictionary.Add(array[0], array[1]);
		}
		return dictionary;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhChung_Load(object sender, EventArgs e)
	{
		method_1();
		method_12();
		nudInteractThread.Value = gclass17_0.method_2("nudInteractThread", 3);
		nudHideThread.Value = gclass17_0.method_2("nudHideThread", 5);
		txbPathProfile.Text = ((gclass17_0.method_0("txbPathProfile") == "") ? (Application.StartupPath + "\\profiles") : gclass17_0.method_0("txbPathProfile"));
		if (!Directory.Exists(txbPathProfile.Text) || txbPathProfile.Text.Trim() == "profiles")
		{
			txbPathProfile.Text = Application.StartupPath + "\\profiles";
		}
		gclass17_0.method_5("txbPathProfile", txbPathProfile.Text);
		ckbShowImageInteract.Checked = Convert.ToBoolean((gclass17_0.method_0("ckbShowImageInteract") == "") ? "false" : gclass17_0.method_0("ckbShowImageInteract"));
		ckbAddChromeIntoForm.Checked = gclass17_0.method_3("ckbAddChromeIntoForm");
		nudWidthChrome.Value = gclass17_0.method_2("nudWidthChrome", 320);
		nudHeighChrome.Value = gclass17_0.method_2("nudHeighChrome", 480);
		nudDelayOpenChromeFrom.Value = gclass17_0.method_2("nudDelayOpenChromeFrom", 1);
		nudDelayOpenChromeTo.Value = gclass17_0.method_2("nudDelayOpenChromeTo", 1);
		nudDelayCloseChromeFrom.Value = gclass17_0.method_2("nudDelayCloseChromeFrom");
		nudDelayCloseChromeTo.Value = gclass17_0.method_2("nudDelayCloseChromeTo");
		cbbColumnChrome.Text = ((gclass17_0.method_0("cbbColumnChrome") == "") ? "3" : gclass17_0.method_0("cbbColumnChrome"));
		cbbRowChrome.Text = ((gclass17_0.method_0("cbbRowChrome") == "") ? "2" : gclass17_0.method_0("cbbRowChrome"));
		switch (gclass17_0.method_2("typeBrowser"))
		{
		case 1:
			rbChromium.Checked = true;
			break;
		case 0:
			rbChrome.Checked = true;
			break;
		}
		txtLinkToOtherBrowser.Text = gclass17_0.method_0("txtLinkToOtherBrowser");
		ckbUsePortable.Checked = gclass17_0.method_3("ckbUsePortable");
		txtPathToPortableZip.Text = gclass17_0.method_0("txtPathToPortableZip");
		cbbSizeChrome.SelectedValue = gclass17_0.method_0("sizeChrome", "default").ToString();
		if (cbbSizeChrome.SelectedValue == null)
		{
			cbbSizeChrome.SelectedValue = "default";
		}
		switch (gclass17_0.method_2("tocDoGoVanBan"))
		{
		case 0:
			rbTocDoGoCham.Checked = true;
			break;
		case 1:
			rbTocDoGoBinhThuong.Checked = true;
			break;
		case 2:
			rbTocDoGoNhanh.Checked = true;
			break;
		}
		ckbKhongCheckIP.Checked = gclass17_0.method_3("ckbKhongCheckIP");
		nudChangeIpCount.Value = gclass17_0.method_2("ip_nudChangeIpCount", 1);
		nudDelayCheckIP.Value = gclass17_0.method_2("nudDelayCheckIP");
		switch (gclass17_0.method_2("ip_iTypeChangeIp"))
		{
		case 0:
			rbNone.Checked = true;
			break;
		case 1:
			rbHma.Checked = true;
			break;
		case 2:
			rbDcom.Checked = true;
			break;
		case 3:
			rbSSH.Checked = true;
			break;
		case 4:
			rbExpressVPN.Checked = true;
			break;
		case 5:
			rbHotspot.Checked = true;
			break;
		case 6:
			rbNordVPN.Checked = true;
			break;
		case 7:
			rbTinsoft.Checked = true;
			break;
		case 8:
			rbXproxy.Checked = true;
			break;
		case 9:
			rbProxy.Checked = true;
			break;
		case 10:
			rbTMProxy.Checked = true;
			break;
		case 11:
			rbProxyv6.Checked = true;
			break;
		case 12:
			rbShopLike.Checked = true;
			break;
		case 13:
			rbMinProxy.Checked = true;
			break;
		case 14:
			rbObcProxy.Checked = true;
			break;
		}
		if (gclass17_0.method_2("typeDcom") == 0)
		{
			rbDcomThuong.Checked = true;
		}
		else
		{
			rbDcomHilink.Checked = true;
		}
		txtProfileNameDcom.Text = gclass17_0.method_0("ip_txtProfileNameDcom");
		txtUrlHilink.Text = gclass17_0.method_0("txtUrlHilink", "http://192.168.1.1/html/home.html");
		txtNordVPN.Text = gclass17_0.method_0("ip_txtNordVPN");
		cbbHostpot.SelectedIndex = gclass17_0.method_2("ip_cbbHostpot");
		if (gclass17_0.method_2("typeApiTinsoft") == 0)
		{
			rbApiUser.Checked = true;
		}
		else
		{
			rbApiProxy.Checked = true;
		}
		txtApiUser.Text = gclass17_0.method_0("txtApiUser");
		txtApiProxy.Text = gclass17_0.method_0("txtApiProxy");
		cbbLocationTinsoft.SelectedValue = ((gclass17_0.method_0("cbbLocationTinsoft") == "") ? "0" : gclass17_0.method_0("cbbLocationTinsoft"));
		nudLuongPerIPTinsoft.Value = gclass17_0.method_2("nudLuongPerIPTinsoft");
		ckbWaitDoneAllTinsoft.Checked = gclass17_0.method_3("ckbWaitDoneAllTinsoft");
		txtServiceURLXProxy.Text = gclass17_0.method_0("txtServiceURLXProxy");
		if (gclass17_0.method_2("typeProxy") == 0)
		{
			rbHttpProxy.Checked = true;
		}
		else
		{
			rbSock5Proxy.Checked = true;
		}
		txtListProxy.Text = gclass17_0.method_0("txtListProxy");
		nudLuongPerIPXProxy.Value = gclass17_0.method_2("nudLuongPerIPXProxy");
		nudDelayResetXProxy.Value = gclass17_0.method_2("nudDelayResetXProxy", 5);
		ckbWaitDoneAllXproxy.Checked = gclass17_0.method_3("ckbWaitDoneAllXproxy");
		if (gclass17_0.method_2("typeRunXproxy") == 0)
		{
			rbXproxyResetEachProxy.Checked = true;
		}
		else
		{
			rbXproxyResetAllProxy.Checked = true;
		}
		txtApiKeyTMProxy.Text = gclass17_0.method_0("txtApiKeyTMProxy");
		nudLuongPerIPTMProxy.Value = gclass17_0.method_2("nudLuongPerIPTMProxy", 1);
		ckbWaitDoneAllTMProxy.Checked = gclass17_0.method_3("ckbWaitDoneAllTMProxy");
		txtApiProxyv6.Text = gclass17_0.method_0("txtApiProxyv6");
		txtListProxyv6.Text = gclass17_0.method_0("txtListProxyv6");
		nudLuongPerIPProxyv6.Value = gclass17_0.method_2("nudLuongPerIPProxyv6");
		txtApiShopLike.Text = gclass17_0.method_0("txtApiShopLike");
		nudLuongPerIPShopLike.Value = gclass17_0.method_2("nudLuongPerIPShopLike");
		if (gclass17_0.method_2("typeMin") == 0)
		{
			rbProxyDong.Checked = true;
		}
		else
		{
			rbProxyDanCu.Checked = true;
		}
		switch (gclass17_0.method_2("typeProxyMin"))
		{
		case 0:
			rbHttpv4.Checked = true;
			break;
		case 1:
			rbHttpv6.Checked = true;
			break;
		case 2:
			rbSockv4.Checked = true;
			break;
		default:
			rbSockv6.Checked = true;
			break;
		}
		txtApiKeyMinProxy.Text = gclass17_0.method_0("txtApiKeyMinProxy");
		nudLuongPerIPMinProxy.Value = gclass17_0.method_2("nudLuongPerIPMinProxy");
		txtLinkWebObcProxy.Text = gclass17_0.method_0("txtLinkWebObcProxy");
		txtListObcProxy.Text = gclass17_0.method_0("txtListObcProxy");
		nudLuongPerIPObcProxy.Value = gclass17_0.method_2("nudLuongPerIPObcProxy", 1);
		if (gclass17_0.method_2("typeRunObcProxy") == 0)
		{
			rbObcResetTungIP.Checked = true;
		}
		else
		{
			rbObcResetDaiIP.Checked = true;
		}
		nudDelayCheckIPObcProxy.Value = gclass17_0.method_2("nudDelayCheckIPObcProxy", 1);
		if (gclass17_0.method_2("typePhanBietMau") == 0)
		{
			rbPhanBietMauNen.Checked = true;
		}
		else
		{
			rbPhanBietMauChu.Checked = true;
		}
		ckbLuuTrangThai.Checked = gclass17_0.method_3("ckbLuuTrangThai");
		if (gclass17_0.method_2("type2Fa") == 0)
		{
			rbServer.Checked = true;
		}
		else
		{
			rbClient.Checked = true;
		}
		method_3();
		method_8();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			gclass17_0.method_5("nudInteractThread", nudInteractThread.Value);
			gclass17_0.method_5("nudHideThread", nudHideThread.Value);
			gclass17_0.method_5("txbPathProfile", txbPathProfile.Text);
			gclass17_0.method_5("ckbShowImageInteract", ckbShowImageInteract.Checked);
			gclass17_0.method_5("ckbAddChromeIntoForm", ckbAddChromeIntoForm.Checked);
			gclass17_0.method_5("nudWidthChrome", nudWidthChrome.Value);
			gclass17_0.method_5("nudHeighChrome", nudHeighChrome.Value);
			gclass17_0.method_5("nudDelayOpenChromeFrom", nudDelayOpenChromeFrom.Value);
			gclass17_0.method_5("nudDelayOpenChromeTo", nudDelayOpenChromeTo.Value);
			gclass17_0.method_5("nudDelayCloseChromeFrom", nudDelayCloseChromeFrom.Value);
			gclass17_0.method_5("nudDelayCloseChromeTo", nudDelayCloseChromeTo.Value);
			gclass17_0.method_5("cbbColumnChrome", cbbColumnChrome.Text);
			gclass17_0.method_5("cbbRowChrome", cbbRowChrome.Text);
			int num = 0;
			if (rbChromium.Checked)
			{
				num = 1;
			}
			gclass17_0.method_5("typeBrowser", num);
			gclass17_0.method_5("txtLinkToOtherBrowser", txtLinkToOtherBrowser.Text.Trim());
			gclass17_0.method_5("ckbUsePortable", ckbUsePortable.Checked);
			gclass17_0.method_5("txtPathToPortableZip", txtPathToPortableZip.Text.Trim());
			if (num != 0 && txtLinkToOtherBrowser.Text.Trim() == "")
			{
				string arg = "";
				switch (num)
				{
				case 1:
					arg = "Chromium";
					break;
				case 2:
					arg = "Cô\u0301c cô\u0301c";
					break;
				case 3:
					arg = "Slimjet";
					break;
				}
				GClass38.smethod_0(string.Format(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n file cha\u0323y cu\u0309a tri\u0300nh duyê\u0323t {0}!"), arg), 2);
				return;
			}
			if (cbbSizeChrome.Items.Count > 0 && cbbSizeChrome.SelectedValue.ToString() != "")
			{
				gclass17_0.method_5("sizeChrome", cbbSizeChrome.SelectedValue.ToString());
			}
			if (rbTocDoGoCham.Checked)
			{
				gclass17_0.method_5("tocDoGoVanBan", 0);
			}
			else if (rbTocDoGoBinhThuong.Checked)
			{
				gclass17_0.method_5("tocDoGoVanBan", 1);
			}
			else
			{
				gclass17_0.method_5("tocDoGoVanBan", 2);
			}
			gclass17_0.method_5("ckbKhongCheckIP", ckbKhongCheckIP.Checked);
			gclass17_0.method_5("ip_nudChangeIpCount", nudChangeIpCount.Value);
			gclass17_0.method_5("nudDelayCheckIP", nudDelayCheckIP.Value);
			int num2 = 0;
			if (rbNone.Checked)
			{
				num2 = 0;
			}
			else if (rbHma.Checked)
			{
				num2 = 1;
			}
			else if (rbDcom.Checked)
			{
				num2 = 2;
			}
			else if (rbSSH.Checked)
			{
				num2 = 3;
			}
			else if (rbExpressVPN.Checked)
			{
				num2 = 4;
			}
			else if (rbHotspot.Checked)
			{
				num2 = 5;
			}
			else if (rbNordVPN.Checked)
			{
				num2 = 6;
			}
			else if (rbTinsoft.Checked)
			{
				num2 = 7;
			}
			else if (rbXproxy.Checked)
			{
				num2 = 8;
			}
			else if (rbProxy.Checked)
			{
				num2 = 9;
			}
			else if (rbTMProxy.Checked)
			{
				num2 = 10;
			}
			else if (rbProxyv6.Checked)
			{
				num2 = 11;
			}
			else if (rbShopLike.Checked)
			{
				num2 = 12;
			}
			else if (rbMinProxy.Checked)
			{
				num2 = 13;
			}
			else if (rbObcProxy.Checked)
			{
				num2 = 14;
			}
			gclass17_0.method_5("ip_iTypeChangeIp", num2);
			if (rbDcomThuong.Checked)
			{
				gclass17_0.method_5("typeDcom", 0);
			}
			else
			{
				gclass17_0.method_5("typeDcom", 1);
			}
			gclass17_0.method_5("txtUrlHilink", txtUrlHilink.Text);
			gclass17_0.method_5("ip_txtProfileNameDcom", txtProfileNameDcom.Text);
			gclass17_0.method_5("ip_txtNordVPN", txtNordVPN.Text);
			gclass17_0.method_5("ip_cbbHostpot", cbbHostpot.SelectedIndex);
			if (rbApiUser.Checked)
			{
				gclass17_0.method_5("typeApiTinsoft", 0);
			}
			else
			{
				gclass17_0.method_5("typeApiTinsoft", 1);
			}
			gclass17_0.method_5("txtApiUser", txtApiUser.Text);
			gclass17_0.method_5("txtApiProxy", txtApiProxy.Text);
			gclass17_0.method_5("cbbLocationTinsoft", cbbLocationTinsoft.SelectedValue);
			gclass17_0.method_5("nudLuongPerIPTinsoft", nudLuongPerIPTinsoft.Value);
			gclass17_0.method_5("ckbWaitDoneAllTinsoft", ckbWaitDoneAllTinsoft.Checked);
			gclass17_0.method_5("txtServiceURLXProxy", txtServiceURLXProxy.Text);
			int num3 = 0;
			if (rbSock5Proxy.Checked)
			{
				num3 = 1;
			}
			gclass17_0.method_5("typeProxy", num3);
			gclass17_0.method_5("txtListProxy", txtListProxy.Text);
			gclass17_0.method_5("nudLuongPerIPXProxy", nudLuongPerIPXProxy.Value);
			gclass17_0.method_5("nudDelayResetXProxy", nudDelayResetXProxy.Value);
			gclass17_0.method_5("ckbWaitDoneAllXproxy", ckbWaitDoneAllXproxy.Checked);
			if (rbXproxyResetEachProxy.Checked)
			{
				gclass17_0.method_5("typeRunXproxy", 0);
			}
			else
			{
				gclass17_0.method_5("typeRunXproxy", 1);
			}
			gclass17_0.method_5("txtApiKeyTMProxy", txtApiKeyTMProxy.Text);
			gclass17_0.method_5("nudLuongPerIPTMProxy", nudLuongPerIPTMProxy.Value);
			gclass17_0.method_5("ckbWaitDoneAllTMProxy", ckbWaitDoneAllTMProxy.Checked);
			gclass17_0.method_5("txtApiProxyv6", txtApiProxyv6.Text);
			gclass17_0.method_5("txtListProxyv6", txtListProxyv6.Text);
			gclass17_0.method_5("nudLuongPerIPProxyv6", nudLuongPerIPProxyv6.Value);
			gclass17_0.method_5("txtApiShopLike", txtApiShopLike.Text);
			gclass17_0.method_5("nudLuongPerIPShopLike", nudLuongPerIPShopLike.Value);
			int num4 = 0;
			if (rbProxyDanCu.Checked)
			{
				num4 = 1;
			}
			gclass17_0.method_5("typeMin", num4);
			int num5 = 0;
			if (rbHttpv6.Checked)
			{
				num5 = 1;
			}
			else if (rbSockv4.Checked)
			{
				num5 = 2;
			}
			else if (rbSockv6.Checked)
			{
				num5 = 3;
			}
			gclass17_0.method_5("typeProxyMin", num5);
			gclass17_0.method_5("txtApiKeyMinProxy", txtApiKeyMinProxy.Text);
			gclass17_0.method_5("nudLuongPerIPMinProxy", nudLuongPerIPMinProxy.Value);
			gclass17_0.method_5("txtLinkWebObcProxy", txtLinkWebObcProxy.Text);
			gclass17_0.method_5("txtListObcProxy", txtListObcProxy.Text);
			gclass17_0.method_5("nudLuongPerIPObcProxy", nudLuongPerIPObcProxy.Value);
			if (rbObcResetTungIP.Checked)
			{
				gclass17_0.method_5("typeRunObcProxy", 0);
			}
			else
			{
				gclass17_0.method_5("typeRunObcProxy", 1);
			}
			gclass17_0.method_5("nudDelayCheckIPObcProxy", nudDelayCheckIPObcProxy.Value);
			if (rbPhanBietMauNen.Checked)
			{
				gclass17_0.method_5("typePhanBietMau", 0);
			}
			else
			{
				gclass17_0.method_5("typePhanBietMau", 1);
			}
			gclass17_0.method_5("ckbLuuTrangThai", ckbLuuTrangThai.Checked);
			Class187.bool_0 = ckbLuuTrangThai.Checked;
			int num6 = 0;
			if (rbClient.Checked)
			{
				num6 = 1;
			}
			gclass17_0.method_5("type2Fa", num6);
			gclass17_0.method_8();
			if (GClass38.smethod_1(GClass29.smethod_0("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Lỗi!"));
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (gclass17_0.method_2("ip_iTypeChangeIp") == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn loại đổi IP"), 3);
		}
		else if (GClass14.smethod_79(gclass17_0.method_2("ip_iTypeChangeIp"), gclass17_0.method_2("typeDcom"), gclass17_0.method_0("ip_txtProfileNameDcom"), gclass17_0.method_0("txtUrlHilink"), gclass17_0.method_2("ip_cbbHostpot"), gclass17_0.method_0("ip_txtNordVPN")))
		{
			GClass38.smethod_0(GClass29.smethod_0("Đổi IP thành công!"));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Đổi IP thất bại!"), 2);
		}
	}

	private void btnSSH_Click(object sender, EventArgs e)
	{
		Process.Start("changeip\\ssh.txt");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (GClass15.smethod_24() == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng cập nhật chromedriver!"), 3);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Phiên bản chromedriver khả dụng!"));
		}
	}

	private void rbTinsoft_CheckedChanged(object sender, EventArgs e)
	{
		plTinsoft.Enabled = rbTinsoft.Checked;
		method_13(rbTinsoft);
	}

	private void radioButton3_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = rbNordVPN.Checked;
	}

	private void method_3()
	{
		rbTinsoft_CheckedChanged(null, null);
		radioButton3_CheckedChanged(null, null);
		rbDcom_CheckedChanged(null, null);
		rbXproxy_CheckedChanged(null, null);
		rbHma_CheckedChanged(null, null);
		rbChrome_CheckedChanged(null, null);
		rbTMProxy_CheckedChanged(null, null);
		rbApiUser_CheckedChanged(null, null);
		method_9(null, null);
		ckbAddChromeIntoForm_CheckedChanged(null, null);
		ckbUsePortable_CheckedChanged(null, null);
		rbDcomHilink_CheckedChanged(null, null);
		rbDcomThuong_CheckedChanged(null, null);
		rbProxyv6_CheckedChanged(null, null);
		rbShopLike_CheckedChanged(null, null);
		rbMinProxy_CheckedChanged(null, null);
	}

	private void method_4(object sender, EventArgs e)
	{
		string string_ = txtApiUser.Text.Trim();
		List<string> list = Class40.smethod_2(string_);
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void rbDcom_CheckedChanged(object sender, EventArgs e)
	{
		plDcom.Enabled = rbDcom.Checked;
		method_5();
		method_13(rbDcom);
	}

	private void rbXproxy_CheckedChanged(object sender, EventArgs e)
	{
		plXproxy.Enabled = rbXproxy.Checked;
		method_13(rbXproxy);
	}

	private void method_5()
	{
		plCheckDoiIP.Enabled = rbDcom.Checked || rbHma.Checked;
	}

	private void rbHma_CheckedChanged(object sender, EventArgs e)
	{
		method_5();
		method_13(rbHma);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};
			Process process = Process.Start(startInfo);
			string text = process.StandardOutput.ReadToEnd();
			if (text.Split('\n').Length <= 3)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng kết nối Dcom trước!"), 2);
				return;
			}
			txtProfileNameDcom.Text = text.Split('\n').ToList()[1];
			GClass38.smethod_0(GClass29.smethod_0("Lấy tên cấu hình Dcom thành công!"));
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "change ip dcom");
			GClass38.smethod_0(GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void method_6()
	{
		if (rbChrome.Checked)
		{
			plLinkToOtherBrowser.Visible = false;
		}
		else
		{
			plLinkToOtherBrowser.Visible = true;
		}
	}

	private void rbChrome_CheckedChanged(object sender, EventArgs e)
	{
		method_6();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		try
		{
			GClass14.smethod_32("data\\extension");
			Process.Start("data\\extension");
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
		else if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			plSizeChrome.Visible = false;
		}
	}

	private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
	{
		plTMProxy.Enabled = rbTMProxy.Checked;
		method_13(rbTMProxy);
	}

	private void method_7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://youtu.be/eexEDCyPbR8");
		}
		catch
		{
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://www.youtube.com/watch?v=0t1IwKxkyKw");
		}
		catch
		{
		}
	}

	private void method_8()
	{
		txtApiProxy_TextChanged(null, null);
		txtListProxy_TextChanged(null, null);
		txtListObcProxy_TextChanged(null, null);
		txtApiKeyMinProxy_TextChanged(null, null);
		txtApiKeyTMProxy_TextChanged(null, null);
		txtApiShopLike_TextChanged(null, null);
		txtListProxyv6_TextChanged(null, null);
	}

	private void txtApiProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtApiProxy.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			lblCountApiProxy.Text = "(" + list_.Count + ")";
		}
		catch
		{
		}
	}

	private void rbApiUser_CheckedChanged(object sender, EventArgs e)
	{
		plApiUser.Enabled = rbApiUser.Checked;
	}

	private void method_9(object sender, EventArgs e)
	{
		plApiProxy.Enabled = rbApiProxy.Checked;
	}

	private void method_10(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list_ = txtApiProxy.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		foreach (string item in list_)
		{
			if (Class40.smethod_1(item))
			{
				list.Add(item);
			}
		}
		txtApiProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://www.youtube.com/watch?v=XZTveKk-utY");
		}
		catch
		{
		}
	}

	private void plXproxy_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbWaitDoneAllXproxy.Visible = true;
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbWaitDoneAllTinsoft.Visible = true;
		}
	}

	private void plTMProxy_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbWaitDoneAllTMProxy.Visible = true;
		}
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		grChrome.Height = 318;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		grChrome.Height = 233;
	}

	private void AddFileAccount_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fThemSizeChrome());
		method_12();
		GClass17 gClass = new GClass17("configGeneral");
		cbbSizeChrome.SelectedValue = gClass.method_0("sizeChrome", "default").ToString();
		if (cbbSizeChrome.SelectedValue == null)
		{
			cbbSizeChrome.SelectedValue = "default";
		}
	}

	private void method_12()
	{
		GClass17 gClass = new GClass17("configChrome");
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("default", "Mặc định");
		if (gClass.method_0("sizeChrome") != "")
		{
			Dictionary<string, object> dictionary2 = GClass17.smethod_0(JObject.Parse(gClass.method_0("sizeChrome")));
			foreach (KeyValuePair<string, object> item in dictionary2)
			{
				dictionary.Add(item.Value.ToString(), item.Key + $" ({item.Value})");
			}
		}
		cbbSizeChrome.DataSource = new BindingSource(dictionary, null);
		cbbSizeChrome.ValueMember = "Key";
		cbbSizeChrome.DisplayMember = "Value";
	}

	private void button8_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list_ = txtApiKeyTMProxy.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		foreach (string item in list_)
		{
			if (Class41.smethod_0(item))
			{
				list.Add(item);
			}
		}
		txtApiKeyTMProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtApiKeyTMProxy.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label24.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtListProxy.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			label17.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtPathToPortableZip_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			Process.Start(txbPathProfile.Text.Trim());
		}
	}

	private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
	{
		plAddChromeVaoFormView.Enabled = ckbAddChromeIntoForm.Checked;
		plSapXepCuaSoChrome.Enabled = !ckbAddChromeIntoForm.Checked;
	}

	private void button9_Click(object sender, EventArgs e)
	{
		txbPathProfile.Text = GClass14.smethod_40();
	}

	private void plUsePortable_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ckbUsePortable_CheckedChanged(object sender, EventArgs e)
	{
		lblFileZip.Enabled = ckbUsePortable.Checked;
		txtPathToPortableZip.Enabled = ckbUsePortable.Checked;
	}

	private void panel3_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			plUsePortable.BringToFront();
		}
	}

	private void rbDcomThuong_CheckedChanged(object sender, EventArgs e)
	{
		button4.Enabled = rbDcomThuong.Checked;
		txtProfileNameDcom.Enabled = rbDcomThuong.Checked;
	}

	private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
	{
		label36.Enabled = rbDcomHilink.Checked;
		txtUrlHilink.Enabled = rbDcomHilink.Checked;
	}

	private void rbNone_CheckedChanged(object sender, EventArgs e)
	{
		method_13(rbNone);
	}

	private void method_13(RadioButton radioButton_0)
	{
		if (radioButton_0 != null && radioButton_0.Checked)
		{
			if (radioButton_0.Name == rbDcom.Name)
			{
				tabChangeIP.SelectedTab = tabDcom;
			}
			else if (radioButton_0.Name == rbXproxy.Name)
			{
				tabChangeIP.SelectedTab = tabXProxy;
			}
			else if (radioButton_0.Name == rbTinsoft.Name)
			{
				tabChangeIP.SelectedTab = tabTinsoft;
			}
			else if (radioButton_0.Name == rbTMProxy.Name)
			{
				tabChangeIP.SelectedTab = tabTMProxy;
			}
			else if (radioButton_0.Name == rbObcProxy.Name)
			{
				tabChangeIP.SelectedTab = tabObcProxy;
			}
			else if (radioButton_0.Name == rbProxyv6.Name)
			{
				tabChangeIP.SelectedTab = tabProxyV6;
			}
			else if (radioButton_0.Name == rbShopLike.Name)
			{
				tabChangeIP.SelectedTab = tabProxyShopLike;
			}
			else if (radioButton_0.Name == rbMinProxy.Name)
			{
				tabChangeIP.SelectedTab = tabMinProxy;
			}
			else
			{
				tabChangeIP.SelectedTab = tabNone;
			}
		}
	}

	private void txtListProxyv6_TextChanged(object sender, EventArgs e)
	{
		List<string> list_ = txtListProxyv6.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		label43.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list_.Count.ToString());
	}

	private void txtListProxyVitech_TextChanged(object sender, EventArgs e)
	{
		List<string> list_ = txtListProxyVitech.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		label41.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list_.Count.ToString());
	}

	private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
	{
		plProxyv6.Enabled = rbProxyv6.Checked;
		method_13(rbProxyv6);
	}

	private void rbVitech_CheckedChanged(object sender, EventArgs e)
	{
		plVitech.Enabled = rbVitech.Checked;
	}

	private void rbShopLike_CheckedChanged(object sender, EventArgs e)
	{
		plShopLike.Enabled = rbShopLike.Checked;
		method_13(rbShopLike);
	}

	private void txtApiShopLike_TextChanged(object sender, EventArgs e)
	{
		List<string> list_ = txtApiShopLike.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		label47.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list_.Count.ToString());
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void txbPathProfile_TextChanged(object sender, EventArgs e)
	{
	}

	private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
	{
		panel5.Enabled = rbMinProxy.Checked;
		method_13(rbMinProxy);
	}

	private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
	{
		List<string> list_ = txtApiKeyMinProxy.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		label49.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list_.Count.ToString());
	}

	private void method_14(object sender, EventArgs e)
	{
		if (plXproxy.Height == 260)
		{
			plXproxy.Height = 170;
			(sender as Button).BackgroundImage = Class306.Bitmap_123;
		}
		else
		{
			plXproxy.Height = 260;
			(sender as Button).BackgroundImage = Class306.Bitmap_103;
		}
	}

	private void button10_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list_ = txtApiKeyMinProxy.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		int int_ = 0;
		if (rbProxyDanCu.Checked)
		{
			int_ = 1;
		}
		foreach (string item in list_)
		{
			if (Class11.smethod_0(int_, item))
			{
				list.Add(item);
			}
		}
		txtApiKeyMinProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		Point point = new Point(base.Size.Width, base.Size.Height);
		base.Size = new Size(point.X, point.Y + 386);
	}

	private void method_16(object sender, EventArgs e)
	{
		Point point = new Point(base.Size.Width, base.Size.Height);
		base.Size = new Size(point.X, point.Y - 386);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://www.youtube.com/watch?v=3dmKfPEzoDo&ab_channel=MINSOFTWARE");
		}
		catch
		{
		}
	}

	private void rbProxy_CheckedChanged(object sender, EventArgs e)
	{
		method_13(rbProxy);
	}

	private void rbObcProxy_CheckedChanged(object sender, EventArgs e)
	{
		plObcProxy.Enabled = rbObcProxy.Checked;
		method_13(rbObcProxy);
	}

	private void txtListObcProxy_TextChanged(object sender, EventArgs e)
	{
		GClass14.smethod_70(txtListObcProxy, label67);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		string string_ = txtApiUser.Text.Trim();
		List<string> list = Class40.smethod_2(string_);
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void rbApiProxy_CheckedChanged(object sender, EventArgs e)
	{
		plApiProxy.Enabled = rbApiProxy.Checked;
	}

	private void button7_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list_ = txtApiProxy.Lines.ToList();
		list_ = GClass14.smethod_36(list_);
		foreach (string item in list_)
		{
			if (Class40.smethod_1(item))
			{
				list.Add(item);
			}
		}
		txtApiProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	private void rbProxyDanCu_CheckedChanged(object sender, EventArgs e)
	{
		plTypeProxy.Enabled = rbProxyDanCu.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhChung));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.label3 = new System.Windows.Forms.Label();
		this.nudInteractThread = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudHideThread = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.txbPathProfile = new System.Windows.Forms.TextBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plVitech = new System.Windows.Forms.Panel();
		this.txtListProxyVitech = new System.Windows.Forms.RichTextBox();
		this.radioButton9 = new System.Windows.Forms.RadioButton();
		this.radioButton10 = new System.Windows.Forms.RadioButton();
		this.label40 = new System.Windows.Forms.Label();
		this.label41 = new System.Windows.Forms.Label();
		this.label42 = new System.Windows.Forms.Label();
		this.nudLuongPerIPVitech = new System.Windows.Forms.NumericUpDown();
		this.label46 = new System.Windows.Forms.Label();
		this.txtApiVitech = new System.Windows.Forms.TextBox();
		this.grChrome = new System.Windows.Forms.GroupBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.plSizeChrome = new System.Windows.Forms.Panel();
		this.rbTocDoGoNhanh = new System.Windows.Forms.RadioButton();
		this.rbTocDoGoBinhThuong = new System.Windows.Forms.RadioButton();
		this.rbTocDoGoCham = new System.Windows.Forms.RadioButton();
		this.label30 = new System.Windows.Forms.Label();
		this.plSapXepCuaSoChrome = new System.Windows.Forms.Panel();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.cbbColumnChrome = new System.Windows.Forms.ComboBox();
		this.cbbRowChrome = new System.Windows.Forms.ComboBox();
		this.plAddChromeVaoFormView = new System.Windows.Forms.Panel();
		this.nudWidthChrome = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.nudHeighChrome = new System.Windows.Forms.NumericUpDown();
		this.AddFileAccount = new MetroFramework.Controls.MetroButton();
		this.btnDown = new MetroFramework.Controls.MetroButton();
		this.btnUp = new MetroFramework.Controls.MetroButton();
		this.nudDelayCloseChromeFrom = new System.Windows.Forms.NumericUpDown();
		this.nudDelayCloseChromeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayOpenChromeFrom = new System.Windows.Forms.NumericUpDown();
		this.nudDelayOpenChromeTo = new System.Windows.Forms.NumericUpDown();
		this.plLinkToOtherBrowser = new System.Windows.Forms.Panel();
		this.label19 = new System.Windows.Forms.Label();
		this.txtLinkToOtherBrowser = new System.Windows.Forms.TextBox();
		this.rbChromium = new System.Windows.Forms.RadioButton();
		this.rbChrome = new System.Windows.Forms.RadioButton();
		this.label22 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.ckbShowImageInteract = new System.Windows.Forms.CheckBox();
		this.ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
		this.label32 = new System.Windows.Forms.Label();
		this.cbbSizeChrome = new System.Windows.Forms.ComboBox();
		this.label31 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.button6 = new System.Windows.Forms.Button();
		this.plUsePortable = new System.Windows.Forms.Panel();
		this.txtPathToPortableZip = new System.Windows.Forms.TextBox();
		this.lblFileZip = new System.Windows.Forms.Label();
		this.ckbUsePortable = new System.Windows.Forms.CheckBox();
		this.cbbHostpot = new System.Windows.Forms.ComboBox();
		this.rbVitech = new System.Windows.Forms.RadioButton();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.panel2 = new System.Windows.Forms.Panel();
		this.label12 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.plNordVPN = new System.Windows.Forms.Panel();
		this.label14 = new System.Windows.Forms.Label();
		this.txtNordVPN = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.ckbLuuTrangThai = new System.Windows.Forms.CheckBox();
		this.panel6 = new System.Windows.Forms.Panel();
		this.rbServer = new System.Windows.Forms.RadioButton();
		this.rbClient = new System.Windows.Forms.RadioButton();
		this.panel4 = new System.Windows.Forms.Panel();
		this.rbPhanBietMauNen = new System.Windows.Forms.RadioButton();
		this.rbPhanBietMauChu = new System.Windows.Forms.RadioButton();
		this.label57 = new System.Windows.Forms.Label();
		this.label23 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.button9 = new System.Windows.Forms.Button();
		this.btnSSH = new System.Windows.Forms.Button();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.rbHotspot = new System.Windows.Forms.RadioButton();
		this.radioButton5 = new System.Windows.Forms.RadioButton();
		this.rbNordVPN = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.rbSSH = new System.Windows.Forms.RadioButton();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.rbExpressVPN = new System.Windows.Forms.RadioButton();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.tabChangeIP = new System.Windows.Forms.TabControl();
		this.tabDcom = new System.Windows.Forms.TabPage();
		this.plDcom = new System.Windows.Forms.Panel();
		this.button4 = new System.Windows.Forms.Button();
		this.txtUrlHilink = new System.Windows.Forms.TextBox();
		this.txtProfileNameDcom = new System.Windows.Forms.TextBox();
		this.rbDcomHilink = new System.Windows.Forms.RadioButton();
		this.label36 = new System.Windows.Forms.Label();
		this.rbDcomThuong = new System.Windows.Forms.RadioButton();
		this.tabTinsoft = new System.Windows.Forms.TabPage();
		this.plTinsoft = new System.Windows.Forms.Panel();
		this.ckbWaitDoneAllTinsoft = new System.Windows.Forms.CheckBox();
		this.plApiProxy = new System.Windows.Forms.Panel();
		this.lblCountApiProxy = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.txtApiProxy = new System.Windows.Forms.TextBox();
		this.button7 = new System.Windows.Forms.Button();
		this.plApiUser = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.txtApiUser = new System.Windows.Forms.TextBox();
		this.button3 = new System.Windows.Forms.Button();
		this.cbbLocationTinsoft = new System.Windows.Forms.ComboBox();
		this.rbApiProxy = new System.Windows.Forms.RadioButton();
		this.rbApiUser = new System.Windows.Forms.RadioButton();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.nudLuongPerIPTinsoft = new System.Windows.Forms.NumericUpDown();
		this.tabXProxy = new System.Windows.Forms.TabPage();
		this.plXproxy = new System.Windows.Forms.Panel();
		this.tabObcProxy = new System.Windows.Forms.TabPage();
		this.plObcProxy = new System.Windows.Forms.Panel();
		this.panel8 = new System.Windows.Forms.Panel();
		this.label54 = new System.Windows.Forms.Label();
		this.rbObcResetDaiIP = new System.Windows.Forms.RadioButton();
		this.rbObcResetTungIP = new System.Windows.Forms.RadioButton();
		this.rbObcSock5Proxy = new System.Windows.Forms.RadioButton();
		this.rbObcHttpProxy = new System.Windows.Forms.RadioButton();
		this.label55 = new System.Windows.Forms.Label();
		this.txtListObcProxy = new System.Windows.Forms.RichTextBox();
		this.label67 = new System.Windows.Forms.Label();
		this.label68 = new System.Windows.Forms.Label();
		this.label69 = new System.Windows.Forms.Label();
		this.nudLuongPerIPObcProxy = new System.Windows.Forms.NumericUpDown();
		this.label70 = new System.Windows.Forms.Label();
		this.label71 = new System.Windows.Forms.Label();
		this.nudDelayCheckIPObcProxy = new System.Windows.Forms.NumericUpDown();
		this.txtLinkWebObcProxy = new System.Windows.Forms.TextBox();
		this.tabProxyV6 = new System.Windows.Forms.TabPage();
		this.plProxyv6 = new System.Windows.Forms.Panel();
		this.txtListProxyv6 = new System.Windows.Forms.RichTextBox();
		this.radioButton1 = new System.Windows.Forms.RadioButton();
		this.radioButton6 = new System.Windows.Forms.RadioButton();
		this.label39 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.label44 = new System.Windows.Forms.Label();
		this.nudLuongPerIPProxyv6 = new System.Windows.Forms.NumericUpDown();
		this.label45 = new System.Windows.Forms.Label();
		this.txtApiProxyv6 = new System.Windows.Forms.TextBox();
		this.tabProxyShopLike = new System.Windows.Forms.TabPage();
		this.plShopLike = new System.Windows.Forms.Panel();
		this.txtApiShopLike = new System.Windows.Forms.RichTextBox();
		this.label47 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.nudLuongPerIPShopLike = new System.Windows.Forms.NumericUpDown();
		this.tabTMProxy = new System.Windows.Forms.TabPage();
		this.panel15 = new System.Windows.Forms.Panel();
		this.plTMProxy = new System.Windows.Forms.Panel();
		this.ckbWaitDoneAllTMProxy = new System.Windows.Forms.CheckBox();
		this.txtApiKeyTMProxy = new System.Windows.Forms.RichTextBox();
		this.label24 = new System.Windows.Forms.Label();
		this.button8 = new System.Windows.Forms.Button();
		this.label25 = new System.Windows.Forms.Label();
		this.nudLuongPerIPTMProxy = new System.Windows.Forms.NumericUpDown();
		this.tabNone = new System.Windows.Forms.TabPage();
		this.panel16 = new System.Windows.Forms.Panel();
		this.tabMinProxy = new System.Windows.Forms.TabPage();
		this.panel5 = new System.Windows.Forms.Panel();
		this.plTypeProxy = new System.Windows.Forms.Panel();
		this.rbSockv6 = new System.Windows.Forms.RadioButton();
		this.rbSockv4 = new System.Windows.Forms.RadioButton();
		this.rbHttpv6 = new System.Windows.Forms.RadioButton();
		this.rbHttpv4 = new System.Windows.Forms.RadioButton();
		this.label56 = new System.Windows.Forms.Label();
		this.rbProxyDanCu = new System.Windows.Forms.RadioButton();
		this.rbProxyDong = new System.Windows.Forms.RadioButton();
		this.button10 = new System.Windows.Forms.Button();
		this.txtApiKeyMinProxy = new System.Windows.Forms.RichTextBox();
		this.label49 = new System.Windows.Forms.Label();
		this.label50 = new System.Windows.Forms.Label();
		this.nudLuongPerIPMinProxy = new System.Windows.Forms.NumericUpDown();
		this.rbMinProxy = new System.Windows.Forms.RadioButton();
		this.rbShopLike = new System.Windows.Forms.RadioButton();
		this.rbProxyv6 = new System.Windows.Forms.RadioButton();
		this.label37 = new System.Windows.Forms.Label();
		this.nudDelayCheckIP = new System.Windows.Forms.NumericUpDown();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.label38 = new System.Windows.Forms.Label();
		this.plCheckDoiIP = new System.Windows.Forms.Panel();
		this.button5 = new System.Windows.Forms.Button();
		this.label26 = new System.Windows.Forms.Label();
		this.nudChangeIpCount = new System.Windows.Forms.NumericUpDown();
		this.label27 = new System.Windows.Forms.Label();
		this.rbTMProxy = new System.Windows.Forms.RadioButton();
		this.rbDcom = new System.Windows.Forms.RadioButton();
		this.rbTinsoft = new System.Windows.Forms.RadioButton();
		this.rbProxy = new System.Windows.Forms.RadioButton();
		this.rbNone = new System.Windows.Forms.RadioButton();
		this.rbObcProxy = new System.Windows.Forms.RadioButton();
		this.rbXproxy = new System.Windows.Forms.RadioButton();
		this.rbHma = new System.Windows.Forms.RadioButton();
		this.ckbKhongCheckIP = new System.Windows.Forms.CheckBox();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.txtServiceURLXProxy = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.nudLuongPerIPXProxy = new System.Windows.Forms.NumericUpDown();
		this.nudDelayResetXProxy = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.label51 = new System.Windows.Forms.Label();
		this.label52 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.rbHttpProxy = new System.Windows.Forms.RadioButton();
		this.rbSock5Proxy = new System.Windows.Forms.RadioButton();
		this.txtListProxy = new System.Windows.Forms.RichTextBox();
		this.ckbWaitDoneAllXproxy = new System.Windows.Forms.CheckBox();
		this.rbXproxyResetEachProxy = new System.Windows.Forms.RadioButton();
		this.rbXproxyResetAllProxy = new System.Windows.Forms.RadioButton();
		this.label53 = new System.Windows.Forms.Label();
		this.panel7 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.nudInteractThread).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudHideThread).BeginInit();
		this.panel1.SuspendLayout();
		this.plVitech.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPVitech).BeginInit();
		this.grChrome.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plSizeChrome.SuspendLayout();
		this.plSapXepCuaSoChrome.SuspendLayout();
		this.plAddChromeVaoFormView.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCloseChromeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCloseChromeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayOpenChromeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayOpenChromeTo).BeginInit();
		this.plLinkToOtherBrowser.SuspendLayout();
		this.plUsePortable.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel2.SuspendLayout();
		this.plNordVPN.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.panel6.SuspendLayout();
		this.panel4.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.tabChangeIP.SuspendLayout();
		this.tabDcom.SuspendLayout();
		this.plDcom.SuspendLayout();
		this.tabTinsoft.SuspendLayout();
		this.plTinsoft.SuspendLayout();
		this.plApiProxy.SuspendLayout();
		this.plApiUser.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPTinsoft).BeginInit();
		this.tabXProxy.SuspendLayout();
		this.plXproxy.SuspendLayout();
		this.tabObcProxy.SuspendLayout();
		this.plObcProxy.SuspendLayout();
		this.panel8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPObcProxy).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCheckIPObcProxy).BeginInit();
		this.tabProxyV6.SuspendLayout();
		this.plProxyv6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPProxyv6).BeginInit();
		this.tabProxyShopLike.SuspendLayout();
		this.plShopLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPShopLike).BeginInit();
		this.tabTMProxy.SuspendLayout();
		this.panel15.SuspendLayout();
		this.plTMProxy.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPTMProxy).BeginInit();
		this.tabNone.SuspendLayout();
		this.tabMinProxy.SuspendLayout();
		this.panel5.SuspendLayout();
		this.plTypeProxy.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPMinProxy).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCheckIP).BeginInit();
		this.plCheckDoiIP.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudChangeIpCount).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPXProxy).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayResetXProxy).BeginInit();
		this.panel7.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(575, 38);
		this.bunifuCards1.TabIndex = 12;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(32, 27);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(157, 16);
		this.label3.TabIndex = 23;
		this.label3.Text = "Số luồng chạy tri\u0300nh duyê\u0323t:";
		this.nudInteractThread.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudInteractThread.Location = new System.Drawing.Point(207, 25);
		this.nudInteractThread.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		this.nudInteractThread.Name = "nudInteractThread";
		this.nudInteractThread.Size = new System.Drawing.Size(89, 23);
		this.nudInteractThread.TabIndex = 24;
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(299, 27);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(41, 16);
		this.label4.TabIndex = 25;
		this.label4.Text = "Luồng";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.Location = new System.Drawing.Point(299, 55);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(41, 16);
		this.label5.TabIndex = 28;
		this.label5.Text = "Luồng";
		this.nudHideThread.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudHideThread.Location = new System.Drawing.Point(207, 53);
		this.nudHideThread.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		this.nudHideThread.Name = "nudHideThread";
		this.nudHideThread.Size = new System.Drawing.Size(89, 23);
		this.nudHideThread.TabIndex = 27;
		this.label6.AutoSize = true;
		this.label6.Cursor = System.Windows.Forms.Cursors.Help;
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new System.Drawing.Point(32, 55);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(130, 16);
		this.label6.TabIndex = 26;
		this.label6.Text = "Số luồng chạy ẩn (?):";
		this.toolTip_0.SetToolTip(this.label6, "La\u0300 sô\u0301 luô\u0300ng khi cha\u0323y ca\u0301c chư\u0301c năng không liên quan gi\u0300 đê\u0301n tri\u0300nh duyê\u0323t.\r\nVi\u0301 du\u0323 như: Check wall, Check Avatar,...\r\n(Khuyê\u0301n ca\u0301o nên đê\u0309 10 luô\u0300ng)");
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(32, 84);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(152, 16);
		this.label9.TabIndex = 33;
		this.label9.Text = "Đường dẫn folder profile:";
		this.txbPathProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbPathProfile.Location = new System.Drawing.Point(207, 81);
		this.txbPathProfile.Name = "txbPathProfile";
		this.txbPathProfile.Size = new System.Drawing.Size(358, 23);
		this.txbPathProfile.TabIndex = 32;
		this.txbPathProfile.Click += new System.EventHandler(txtPathToPortableZip_Click);
		this.txbPathProfile.TextChanged += new System.EventHandler(txbPathProfile_TextChanged);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plVitech);
		this.panel1.Controls.Add(this.grChrome);
		this.panel1.Controls.Add(this.cbbHostpot);
		this.panel1.Controls.Add(this.rbVitech);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.plNordVPN);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.btnSSH);
		this.panel1.Controls.Add(this.radioButton4);
		this.panel1.Controls.Add(this.rbHotspot);
		this.panel1.Controls.Add(this.radioButton5);
		this.panel1.Controls.Add(this.rbNordVPN);
		this.panel1.Controls.Add(this.radioButton2);
		this.panel1.Controls.Add(this.rbSSH);
		this.panel1.Controls.Add(this.radioButton3);
		this.panel1.Controls.Add(this.rbExpressVPN);
		this.panel1.Controls.Add(this.groupBox3);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1158, 539);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVitech.Controls.Add(this.txtListProxyVitech);
		this.plVitech.Controls.Add(this.radioButton9);
		this.plVitech.Controls.Add(this.radioButton10);
		this.plVitech.Controls.Add(this.label40);
		this.plVitech.Controls.Add(this.label41);
		this.plVitech.Controls.Add(this.label42);
		this.plVitech.Controls.Add(this.nudLuongPerIPVitech);
		this.plVitech.Controls.Add(this.label46);
		this.plVitech.Controls.Add(this.txtApiVitech);
		this.plVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plVitech.Location = new System.Drawing.Point(11, 909);
		this.plVitech.Name = "plVitech";
		this.plVitech.Size = new System.Drawing.Size(266, 170);
		this.plVitech.TabIndex = 151;
		this.plVitech.Visible = false;
		this.txtListProxyVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtListProxyVitech.Location = new System.Drawing.Point(6, 71);
		this.txtListProxyVitech.Name = "txtListProxyVitech";
		this.txtListProxyVitech.Size = new System.Drawing.Size(255, 68);
		this.txtListProxyVitech.TabIndex = 144;
		this.txtListProxyVitech.Text = "";
		this.txtListProxyVitech.WordWrap = false;
		this.txtListProxyVitech.TextChanged += new System.EventHandler(txtListProxyVitech_TextChanged);
		this.radioButton9.AutoSize = true;
		this.radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton9.Enabled = false;
		this.radioButton9.Location = new System.Drawing.Point(137, 28);
		this.radioButton9.Name = "radioButton9";
		this.radioButton9.Size = new System.Drawing.Size(59, 20);
		this.radioButton9.TabIndex = 82;
		this.radioButton9.Text = "Sock5";
		this.radioButton9.UseVisualStyleBackColor = true;
		this.radioButton10.AutoSize = true;
		this.radioButton10.Checked = true;
		this.radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton10.Location = new System.Drawing.Point(74, 28);
		this.radioButton10.Name = "radioButton10";
		this.radioButton10.Size = new System.Drawing.Size(48, 20);
		this.radioButton10.TabIndex = 82;
		this.radioButton10.TabStop = true;
		this.radioButton10.Text = "Http";
		this.radioButton10.UseVisualStyleBackColor = true;
		this.label40.AutoSize = true;
		this.label40.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label40.Location = new System.Drawing.Point(3, 28);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(70, 16);
		this.label40.TabIndex = 79;
		this.label40.Text = "Loại Proxy:";
		this.label41.AutoSize = true;
		this.label41.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label41.Location = new System.Drawing.Point(3, 50);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(97, 16);
		this.label41.TabIndex = 79;
		this.label41.Text = "Nhập Proxy (0):";
		this.label42.AutoSize = true;
		this.label42.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label42.Location = new System.Drawing.Point(5, 143);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(78, 16);
		this.label42.TabIndex = 139;
		this.label42.Text = "Số luồng/IP:";
		this.nudLuongPerIPVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPVitech.Location = new System.Drawing.Point(90, 142);
		this.nudLuongPerIPVitech.Name = "nudLuongPerIPVitech";
		this.nudLuongPerIPVitech.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPVitech.TabIndex = 140;
		this.nudLuongPerIPVitech.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label46.AutoSize = true;
		this.label46.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label46.Location = new System.Drawing.Point(3, 5);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(55, 16);
		this.label46.TabIndex = 79;
		this.label46.Text = "API Key:";
		this.txtApiVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtApiVitech.ForeColor = System.Drawing.Color.Black;
		this.txtApiVitech.Location = new System.Drawing.Point(74, 2);
		this.txtApiVitech.Name = "txtApiVitech";
		this.txtApiVitech.Size = new System.Drawing.Size(187, 23);
		this.txtApiVitech.TabIndex = 81;
		this.grChrome.Controls.Add(this.panel3);
		this.grChrome.Controls.Add(this.plSizeChrome);
		this.grChrome.Controls.Add(this.plSapXepCuaSoChrome);
		this.grChrome.Controls.Add(this.plAddChromeVaoFormView);
		this.grChrome.Controls.Add(this.AddFileAccount);
		this.grChrome.Controls.Add(this.btnDown);
		this.grChrome.Controls.Add(this.btnUp);
		this.grChrome.Controls.Add(this.nudDelayCloseChromeFrom);
		this.grChrome.Controls.Add(this.nudDelayCloseChromeTo);
		this.grChrome.Controls.Add(this.nudDelayOpenChromeFrom);
		this.grChrome.Controls.Add(this.nudDelayOpenChromeTo);
		this.grChrome.Controls.Add(this.plLinkToOtherBrowser);
		this.grChrome.Controls.Add(this.rbChromium);
		this.grChrome.Controls.Add(this.rbChrome);
		this.grChrome.Controls.Add(this.label22);
		this.grChrome.Controls.Add(this.label15);
		this.grChrome.Controls.Add(this.ckbShowImageInteract);
		this.grChrome.Controls.Add(this.ckbAddChromeIntoForm);
		this.grChrome.Controls.Add(this.label32);
		this.grChrome.Controls.Add(this.cbbSizeChrome);
		this.grChrome.Controls.Add(this.label31);
		this.grChrome.Controls.Add(this.label29);
		this.grChrome.Controls.Add(this.label2);
		this.grChrome.Controls.Add(this.label21);
		this.grChrome.Controls.Add(this.label20);
		this.grChrome.Controls.Add(this.label34);
		this.grChrome.Controls.Add(this.button6);
		this.grChrome.Controls.Add(this.plUsePortable);
		this.grChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.grChrome.Location = new System.Drawing.Point(7, 156);
		this.grChrome.Name = "grChrome";
		this.grChrome.Size = new System.Drawing.Size(568, 233);
		this.grChrome.TabIndex = 38;
		this.grChrome.TabStop = false;
		this.grChrome.Text = "Cấu hình chrome";
		this.panel3.Controls.Add(this.button1);
		this.panel3.Controls.Add(this.linkLabel2);
		this.panel3.Location = new System.Drawing.Point(32, 200);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(530, 25);
		this.panel3.TabIndex = 156;
		this.panel3.Click += new System.EventHandler(panel3_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.Black;
		this.button1.Location = new System.Drawing.Point(0, -1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(134, 27);
		this.button1.TabIndex = 143;
		this.button1.Text = "Check Chromedriver";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel2.Location = new System.Drawing.Point(191, 4);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(221, 16);
		this.linkLabel2.TabIndex = 147;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Hươ\u0301ng dâ\u0303n câ\u0323p nhâ\u0323t ChromeDriver(?)";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.plSizeChrome.Controls.Add(this.rbTocDoGoNhanh);
		this.plSizeChrome.Controls.Add(this.rbTocDoGoBinhThuong);
		this.plSizeChrome.Controls.Add(this.rbTocDoGoCham);
		this.plSizeChrome.Controls.Add(this.label30);
		this.plSizeChrome.Location = new System.Drawing.Point(32, 169);
		this.plSizeChrome.Name = "plSizeChrome";
		this.plSizeChrome.Size = new System.Drawing.Size(463, 25);
		this.plSizeChrome.TabIndex = 155;
		this.rbTocDoGoNhanh.AutoSize = true;
		this.rbTocDoGoNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTocDoGoNhanh.Location = new System.Drawing.Point(378, 2);
		this.rbTocDoGoNhanh.Name = "rbTocDoGoNhanh";
		this.rbTocDoGoNhanh.Size = new System.Drawing.Size(61, 20);
		this.rbTocDoGoNhanh.TabIndex = 34;
		this.rbTocDoGoNhanh.Text = "Nhanh";
		this.rbTocDoGoNhanh.UseVisualStyleBackColor = true;
		this.rbTocDoGoBinhThuong.AutoSize = true;
		this.rbTocDoGoBinhThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTocDoGoBinhThuong.Location = new System.Drawing.Point(268, 2);
		this.rbTocDoGoBinhThuong.Name = "rbTocDoGoBinhThuong";
		this.rbTocDoGoBinhThuong.Size = new System.Drawing.Size(93, 20);
		this.rbTocDoGoBinhThuong.TabIndex = 34;
		this.rbTocDoGoBinhThuong.Text = "Bình thường";
		this.rbTocDoGoBinhThuong.UseVisualStyleBackColor = true;
		this.rbTocDoGoCham.AutoSize = true;
		this.rbTocDoGoCham.Checked = true;
		this.rbTocDoGoCham.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTocDoGoCham.Location = new System.Drawing.Point(193, 2);
		this.rbTocDoGoCham.Name = "rbTocDoGoCham";
		this.rbTocDoGoCham.Size = new System.Drawing.Size(58, 20);
		this.rbTocDoGoCham.TabIndex = 34;
		this.rbTocDoGoCham.TabStop = true;
		this.rbTocDoGoCham.Text = "Chậm";
		this.rbTocDoGoCham.UseVisualStyleBackColor = true;
		this.label30.AutoSize = true;
		this.label30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label30.Location = new System.Drawing.Point(-3, 4);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(173, 16);
		this.label30.TabIndex = 33;
		this.label30.Text = "Tùy chỉnh tốc độ gõ văn bản:";
		this.plSapXepCuaSoChrome.Controls.Add(this.label10);
		this.plSapXepCuaSoChrome.Controls.Add(this.label11);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
		this.plSapXepCuaSoChrome.Location = new System.Drawing.Point(26, 77);
		this.plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
		this.plSapXepCuaSoChrome.Size = new System.Drawing.Size(358, 29);
		this.plSapXepCuaSoChrome.TabIndex = 157;
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(3, 5);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(147, 16);
		this.label10.TabIndex = 33;
		this.label10.Text = "Sắp xếp cửa sổ chrome:";
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.Location = new System.Drawing.Point(245, 2);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(23, 23);
		this.label11.TabIndex = 33;
		this.label11.Text = "X";
		this.cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbColumnChrome.FormattingEnabled = true;
		this.cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		this.cbbColumnChrome.Location = new System.Drawing.Point(200, 2);
		this.cbbColumnChrome.Name = "cbbColumnChrome";
		this.cbbColumnChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbColumnChrome.TabIndex = 145;
		this.cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbRowChrome.FormattingEnabled = true;
		this.cbbRowChrome.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		this.cbbRowChrome.Location = new System.Drawing.Point(272, 2);
		this.cbbRowChrome.Name = "cbbRowChrome";
		this.cbbRowChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbRowChrome.TabIndex = 145;
		this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
		this.plAddChromeVaoFormView.Controls.Add(this.label35);
		this.plAddChromeVaoFormView.Controls.Add(this.label33);
		this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
		this.plAddChromeVaoFormView.Location = new System.Drawing.Point(219, 48);
		this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
		this.plAddChromeVaoFormView.Size = new System.Drawing.Size(175, 27);
		this.plAddChromeVaoFormView.TabIndex = 156;
		this.nudWidthChrome.Location = new System.Drawing.Point(41, 2);
		this.nudWidthChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudWidthChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudWidthChrome.Name = "nudWidthChrome";
		this.nudWidthChrome.Size = new System.Drawing.Size(53, 23);
		this.nudWidthChrome.TabIndex = 151;
		this.nudWidthChrome.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label35.AutoSize = true;
		this.label35.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.Location = new System.Drawing.Point(95, 2);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(23, 23);
		this.label35.TabIndex = 33;
		this.label35.Text = "X";
		this.label33.AutoSize = true;
		this.label33.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label33.Location = new System.Drawing.Point(3, 4);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(36, 16);
		this.label33.TabIndex = 33;
		this.label33.Text = "Size:";
		this.nudHeighChrome.Location = new System.Drawing.Point(118, 2);
		this.nudHeighChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudHeighChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudHeighChrome.Name = "nudHeighChrome";
		this.nudHeighChrome.Size = new System.Drawing.Size(53, 23);
		this.nudHeighChrome.TabIndex = 151;
		this.nudHeighChrome.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.AddFileAccount.BackgroundImage = Class306.Bitmap_172;
		this.AddFileAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.AddFileAccount.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AddFileAccount.Location = new System.Drawing.Point(415, 169);
		this.AddFileAccount.Name = "AddFileAccount";
		this.AddFileAccount.Size = new System.Drawing.Size(25, 25);
		this.AddFileAccount.TabIndex = 154;
		this.AddFileAccount.UseSelectable = true;
		this.AddFileAccount.Click += new System.EventHandler(AddFileAccount_Click);
		this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(512, 8);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 152;
		this.btnDown.UseSelectable = true;
		this.btnDown.Visible = false;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(543, 8);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 153;
		this.btnUp.UseSelectable = true;
		this.btnUp.Visible = false;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.nudDelayCloseChromeFrom.Location = new System.Drawing.Point(226, 140);
		this.nudDelayCloseChromeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayCloseChromeFrom.Name = "nudDelayCloseChromeFrom";
		this.nudDelayCloseChromeFrom.Size = new System.Drawing.Size(41, 23);
		this.nudDelayCloseChromeFrom.TabIndex = 151;
		this.nudDelayCloseChromeTo.Location = new System.Drawing.Point(298, 140);
		this.nudDelayCloseChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayCloseChromeTo.Name = "nudDelayCloseChromeTo";
		this.nudDelayCloseChromeTo.Size = new System.Drawing.Size(41, 23);
		this.nudDelayCloseChromeTo.TabIndex = 151;
		this.nudDelayOpenChromeFrom.Location = new System.Drawing.Point(226, 111);
		this.nudDelayOpenChromeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayOpenChromeFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudDelayOpenChromeFrom.Name = "nudDelayOpenChromeFrom";
		this.nudDelayOpenChromeFrom.Size = new System.Drawing.Size(41, 23);
		this.nudDelayOpenChromeFrom.TabIndex = 151;
		this.nudDelayOpenChromeFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudDelayOpenChromeTo.Location = new System.Drawing.Point(298, 111);
		this.nudDelayOpenChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayOpenChromeTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
		this.nudDelayOpenChromeTo.Size = new System.Drawing.Size(41, 23);
		this.nudDelayOpenChromeTo.TabIndex = 151;
		this.nudDelayOpenChromeTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.plLinkToOtherBrowser.Controls.Add(this.label19);
		this.plLinkToOtherBrowser.Controls.Add(this.txtLinkToOtherBrowser);
		this.plLinkToOtherBrowser.Location = new System.Drawing.Point(186, 287);
		this.plLinkToOtherBrowser.Name = "plLinkToOtherBrowser";
		this.plLinkToOtherBrowser.Size = new System.Drawing.Size(348, 26);
		this.plLinkToOtherBrowser.TabIndex = 150;
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(3, 4);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(75, 16);
		this.label19.TabIndex = 148;
		this.label19.Text = "Đươ\u0300ng dâ\u0303n:";
		this.txtLinkToOtherBrowser.Location = new System.Drawing.Point(83, 1);
		this.txtLinkToOtherBrowser.Name = "txtLinkToOtherBrowser";
		this.txtLinkToOtherBrowser.Size = new System.Drawing.Size(256, 23);
		this.txtLinkToOtherBrowser.TabIndex = 149;
		this.rbChromium.AutoSize = true;
		this.rbChromium.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbChromium.Location = new System.Drawing.Point(268, 265);
		this.rbChromium.Name = "rbChromium";
		this.rbChromium.Size = new System.Drawing.Size(265, 20);
		this.rbChromium.TabIndex = 147;
		this.rbChromium.Text = "Kha\u0301c (Chromium, Brave, Cốc cốc, Slimjet)";
		this.rbChromium.UseVisualStyleBackColor = true;
		this.rbChromium.CheckedChanged += new System.EventHandler(rbChrome_CheckedChanged);
		this.rbChrome.AutoSize = true;
		this.rbChrome.Checked = true;
		this.rbChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbChrome.Location = new System.Drawing.Point(191, 265);
		this.rbChrome.Name = "rbChrome";
		this.rbChrome.Size = new System.Drawing.Size(70, 20);
		this.rbChrome.TabIndex = 147;
		this.rbChrome.TabStop = true;
		this.rbChrome.Text = "Chrome";
		this.rbChrome.UseVisualStyleBackColor = true;
		this.rbChrome.CheckedChanged += new System.EventHandler(rbChrome_CheckedChanged);
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(29, 238);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(134, 16);
		this.label22.TabIndex = 146;
		this.label22.Text = "Nhập Extension (.crx):";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(29, 269);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(106, 16);
		this.label15.TabIndex = 146;
		this.label15.Text = "Cho\u0323n tri\u0300nh duyê\u0323t:";
		this.ckbShowImageInteract.AutoSize = true;
		this.ckbShowImageInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShowImageInteract.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbShowImageInteract.Location = new System.Drawing.Point(32, 22);
		this.ckbShowImageInteract.Name = "ckbShowImageInteract";
		this.ckbShowImageInteract.Size = new System.Drawing.Size(183, 20);
		this.ckbShowImageInteract.TabIndex = 112;
		this.ckbShowImageInteract.Text = "Hiê\u0323n a\u0309nh khi mơ\u0309 tri\u0300nh duyê\u0323t";
		this.ckbShowImageInteract.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.AutoSize = true;
		this.ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddChromeIntoForm.Location = new System.Drawing.Point(32, 50);
		this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		this.ckbAddChromeIntoForm.Size = new System.Drawing.Size(187, 20);
		this.ckbAddChromeIntoForm.TabIndex = 112;
		this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
		this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(ckbAddChromeIntoForm_CheckedChanged);
		this.label32.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label32.Location = new System.Drawing.Point(269, 142);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(29, 16);
		this.label32.TabIndex = 33;
		this.label32.Text = "đê\u0301n";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.cbbSizeChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbSizeChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbSizeChrome.DropDownWidth = 200;
		this.cbbSizeChrome.FormattingEnabled = true;
		this.cbbSizeChrome.Location = new System.Drawing.Point(226, 169);
		this.cbbSizeChrome.Name = "cbbSizeChrome";
		this.cbbSizeChrome.Size = new System.Drawing.Size(183, 24);
		this.cbbSizeChrome.TabIndex = 145;
		this.label31.AutoSize = true;
		this.label31.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label31.Location = new System.Drawing.Point(341, 142);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(30, 16);
		this.label31.TabIndex = 33;
		this.label31.Text = "giây";
		this.label29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label29.Location = new System.Drawing.Point(269, 113);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(29, 16);
		this.label29.TabIndex = 33;
		this.label29.Text = "đê\u0301n";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(29, 142);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(122, 16);
		this.label2.TabIndex = 33;
		this.label2.Text = "Delay đóng chrome:";
		this.label21.AutoSize = true;
		this.label21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label21.Location = new System.Drawing.Point(341, 113);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(30, 16);
		this.label21.TabIndex = 33;
		this.label21.Text = "giây";
		this.label20.AutoSize = true;
		this.label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.Location = new System.Drawing.Point(29, 113);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(112, 16);
		this.label20.TabIndex = 33;
		this.label20.Text = "Delay mơ\u0309 chrome:";
		this.label34.AutoSize = true;
		this.label34.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label34.Location = new System.Drawing.Point(31, 167);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(160, 16);
		this.label34.TabIndex = 33;
		this.label34.Text = "Kích thước cửa số chrome:";
		this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button6.ForeColor = System.Drawing.Color.Black;
		this.button6.Location = new System.Drawing.Point(190, 233);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(63, 27);
		this.button6.TabIndex = 143;
		this.button6.Text = "Nhập";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(button6_Click);
		this.plUsePortable.Controls.Add(this.txtPathToPortableZip);
		this.plUsePortable.Controls.Add(this.lblFileZip);
		this.plUsePortable.Controls.Add(this.ckbUsePortable);
		this.plUsePortable.Location = new System.Drawing.Point(32, 200);
		this.plUsePortable.Name = "plUsePortable";
		this.plUsePortable.Size = new System.Drawing.Size(530, 25);
		this.plUsePortable.TabIndex = 155;
		this.plUsePortable.Paint += new System.Windows.Forms.PaintEventHandler(plUsePortable_Paint);
		this.txtPathToPortableZip.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPathToPortableZip.Location = new System.Drawing.Point(194, 1);
		this.txtPathToPortableZip.Name = "txtPathToPortableZip";
		this.txtPathToPortableZip.Size = new System.Drawing.Size(333, 23);
		this.txtPathToPortableZip.TabIndex = 32;
		this.txtPathToPortableZip.Click += new System.EventHandler(txtPathToPortableZip_Click);
		this.lblFileZip.AutoSize = true;
		this.lblFileZip.Location = new System.Drawing.Point(139, 4);
		this.lblFileZip.Name = "lblFileZip";
		this.lblFileZip.Size = new System.Drawing.Size(52, 16);
		this.lblFileZip.TabIndex = 113;
		this.lblFileZip.Text = "File zip:";
		this.ckbUsePortable.AutoSize = true;
		this.ckbUsePortable.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUsePortable.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbUsePortable.Location = new System.Drawing.Point(0, 3);
		this.ckbUsePortable.Name = "ckbUsePortable";
		this.ckbUsePortable.Size = new System.Drawing.Size(125, 20);
		this.ckbUsePortable.TabIndex = 112;
		this.ckbUsePortable.Text = "Sử dụng Portable";
		this.ckbUsePortable.UseVisualStyleBackColor = true;
		this.ckbUsePortable.CheckedChanged += new System.EventHandler(ckbUsePortable_CheckedChanged);
		this.cbbHostpot.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbHostpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbHostpot.Enabled = false;
		this.cbbHostpot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.cbbHostpot.ForeColor = System.Drawing.Color.Black;
		this.cbbHostpot.FormattingEnabled = true;
		this.cbbHostpot.Items.AddRange(new object[2] { "Chi\u0309 trong quô\u0301c gia đang cho\u0323n", "Toa\u0300n bô\u0323 quô\u0301c gia" });
		this.cbbHostpot.Location = new System.Drawing.Point(1177, 563);
		this.cbbHostpot.Name = "cbbHostpot";
		this.cbbHostpot.Size = new System.Drawing.Size(229, 24);
		this.cbbHostpot.TabIndex = 144;
		this.rbVitech.AutoSize = true;
		this.rbVitech.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbVitech.Enabled = false;
		this.rbVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbVitech.Location = new System.Drawing.Point(11, 885);
		this.rbVitech.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbVitech.Name = "rbVitech";
		this.rbVitech.Size = new System.Drawing.Size(145, 20);
		this.rbVitech.TabIndex = 150;
		this.rbVitech.Text = "VitechCheap(Sắp có)";
		this.rbVitech.UseVisualStyleBackColor = true;
		this.rbVitech.Visible = false;
		this.rbVitech.CheckedChanged += new System.EventHandler(rbVitech_CheckedChanged);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.pnlHeader);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(1156, 37);
		this.bunifuCards2.TabIndex = 40;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1156, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		this.button2.Location = new System.Drawing.Point(1125, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(btnCancel_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1156, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh chung";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(580, 497);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 20;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.label12);
		this.panel2.Controls.Add(this.textBox1);
		this.panel2.Enabled = false;
		this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.panel2.Location = new System.Drawing.Point(1176, 475);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(232, 30);
		this.panel2.TabIndex = 142;
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label12.Location = new System.Drawing.Point(3, 5);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(75, 16);
		this.label12.TabIndex = 82;
		this.label12.Text = "Đường dẫn:";
		this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.textBox1.ForeColor = System.Drawing.Color.Black;
		this.textBox1.Location = new System.Drawing.Point(87, 2);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(142, 23);
		this.textBox1.TabIndex = 83;
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(480, 497);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 19;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.plNordVPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plNordVPN.Controls.Add(this.label14);
		this.plNordVPN.Controls.Add(this.txtNordVPN);
		this.plNordVPN.Enabled = false;
		this.plNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plNordVPN.Location = new System.Drawing.Point(1176, 475);
		this.plNordVPN.Name = "plNordVPN";
		this.plNordVPN.Size = new System.Drawing.Size(232, 30);
		this.plNordVPN.TabIndex = 142;
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label14.Location = new System.Drawing.Point(3, 5);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(75, 16);
		this.label14.TabIndex = 82;
		this.label14.Text = "Đường dẫn:";
		this.txtNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtNordVPN.ForeColor = System.Drawing.Color.Black;
		this.txtNordVPN.Location = new System.Drawing.Point(87, 2);
		this.txtNordVPN.Name = "txtNordVPN";
		this.txtNordVPN.Size = new System.Drawing.Size(142, 23);
		this.txtNordVPN.TabIndex = 83;
		this.groupBox1.Controls.Add(this.ckbLuuTrangThai);
		this.groupBox1.Controls.Add(this.panel6);
		this.groupBox1.Controls.Add(this.panel4);
		this.groupBox1.Controls.Add(this.label57);
		this.groupBox1.Controls.Add(this.label23);
		this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox1.Location = new System.Drawing.Point(7, 395);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(568, 96);
		this.groupBox1.TabIndex = 38;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình khác";
		this.ckbLuuTrangThai.AutoSize = true;
		this.ckbLuuTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLuuTrangThai.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLuuTrangThai.Location = new System.Drawing.Point(32, 46);
		this.ckbLuuTrangThai.Name = "ckbLuuTrangThai";
		this.ckbLuuTrangThai.Size = new System.Drawing.Size(184, 20);
		this.ckbLuuTrangThai.TabIndex = 157;
		this.ckbLuuTrangThai.Text = "Lưu dư\u0303 liê\u0323u cô\u0323t [Tra\u0323ng tha\u0301i]";
		this.ckbLuuTrangThai.UseVisualStyleBackColor = true;
		this.panel6.Controls.Add(this.rbServer);
		this.panel6.Controls.Add(this.rbClient);
		this.panel6.Location = new System.Drawing.Point(253, 66);
		this.panel6.Name = "panel6";
		this.panel6.Size = new System.Drawing.Size(156, 24);
		this.panel6.TabIndex = 156;
		this.panel6.Visible = false;
		this.rbServer.AutoSize = true;
		this.rbServer.Checked = true;
		this.rbServer.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbServer.Location = new System.Drawing.Point(3, 3);
		this.rbServer.Name = "rbServer";
		this.rbServer.Size = new System.Drawing.Size(63, 20);
		this.rbServer.TabIndex = 34;
		this.rbServer.TabStop = true;
		this.rbServer.Text = "Server";
		this.rbServer.UseVisualStyleBackColor = true;
		this.rbClient.AutoSize = true;
		this.rbClient.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbClient.Location = new System.Drawing.Point(84, 3);
		this.rbClient.Name = "rbClient";
		this.rbClient.Size = new System.Drawing.Size(57, 20);
		this.rbClient.TabIndex = 34;
		this.rbClient.Text = "Client";
		this.rbClient.UseVisualStyleBackColor = true;
		this.panel4.Controls.Add(this.rbPhanBietMauNen);
		this.panel4.Controls.Add(this.rbPhanBietMauChu);
		this.panel4.Location = new System.Drawing.Point(253, 18);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(309, 24);
		this.panel4.TabIndex = 156;
		this.rbPhanBietMauNen.AutoSize = true;
		this.rbPhanBietMauNen.Checked = true;
		this.rbPhanBietMauNen.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPhanBietMauNen.Location = new System.Drawing.Point(3, 3);
		this.rbPhanBietMauNen.Name = "rbPhanBietMauNen";
		this.rbPhanBietMauNen.Size = new System.Drawing.Size(130, 20);
		this.rbPhanBietMauNen.TabIndex = 34;
		this.rbPhanBietMauNen.TabStop = true;
		this.rbPhanBietMauNen.Text = "Đổi màu nền dòng";
		this.rbPhanBietMauNen.UseVisualStyleBackColor = true;
		this.rbPhanBietMauChu.AutoSize = true;
		this.rbPhanBietMauChu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPhanBietMauChu.Location = new System.Drawing.Point(176, 2);
		this.rbPhanBietMauChu.Name = "rbPhanBietMauChu";
		this.rbPhanBietMauChu.Size = new System.Drawing.Size(98, 20);
		this.rbPhanBietMauChu.TabIndex = 34;
		this.rbPhanBietMauChu.Text = "Đổi màu chữ";
		this.rbPhanBietMauChu.UseVisualStyleBackColor = true;
		this.label57.AutoSize = true;
		this.label57.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label57.Location = new System.Drawing.Point(32, 70);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(57, 16);
		this.label57.TabIndex = 33;
		this.label57.Text = "Lấy 2FA:";
		this.label57.Visible = false;
		this.label23.AutoSize = true;
		this.label23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.Location = new System.Drawing.Point(29, 22);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(223, 16);
		this.label23.TabIndex = 33;
		this.label23.Text = "Phân biệt màu [Tình trạng tài khoản]:";
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Controls.Add(this.nudHideThread);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.label9);
		this.groupBox2.Controls.Add(this.txbPathProfile);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.nudInteractThread);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.button9);
		this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox2.Location = new System.Drawing.Point(7, 39);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(568, 111);
		this.groupBox2.TabIndex = 38;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Cấu hình chung";
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button9.ForeColor = System.Drawing.Color.Black;
		this.button9.Location = new System.Drawing.Point(508, 80);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(54, 25);
		this.button9.TabIndex = 143;
		this.button9.Text = "Cho\u0323n";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click);
		this.btnSSH.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSSH.Enabled = false;
		this.btnSSH.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.btnSSH.ForeColor = System.Drawing.Color.Black;
		this.btnSSH.Location = new System.Drawing.Point(1263, 508);
		this.btnSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnSSH.Name = "btnSSH";
		this.btnSSH.Size = new System.Drawing.Size(106, 26);
		this.btnSSH.TabIndex = 130;
		this.btnSSH.Text = "Nhập IP SSH";
		this.btnSSH.UseVisualStyleBackColor = true;
		this.btnSSH.Click += new System.EventHandler(btnSSH_Click);
		this.radioButton4.AutoSize = true;
		this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton4.Enabled = false;
		this.radioButton4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.radioButton4.Location = new System.Drawing.Point(1162, 426);
		this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.radioButton4.Name = "radioButton4";
		this.radioButton4.Size = new System.Drawing.Size(130, 20);
		this.radioButton4.TabIndex = 133;
		this.radioButton4.Text = "Đổi IP ExpressVPN";
		this.radioButton4.UseVisualStyleBackColor = true;
		this.rbHotspot.AutoSize = true;
		this.rbHotspot.Enabled = false;
		this.rbHotspot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbHotspot.Location = new System.Drawing.Point(1162, 539);
		this.rbHotspot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbHotspot.Name = "rbHotspot";
		this.rbHotspot.Size = new System.Drawing.Size(145, 20);
		this.rbHotspot.TabIndex = 135;
		this.rbHotspot.Text = "Đổi IP Hotspot Shield";
		this.rbHotspot.UseVisualStyleBackColor = true;
		this.radioButton5.AutoSize = true;
		this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton5.Enabled = false;
		this.radioButton5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.radioButton5.Location = new System.Drawing.Point(1162, 511);
		this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.radioButton5.Name = "radioButton5";
		this.radioButton5.Size = new System.Drawing.Size(87, 20);
		this.radioButton5.TabIndex = 132;
		this.radioButton5.Text = "Đổi IP SSH";
		this.radioButton5.UseVisualStyleBackColor = true;
		this.rbNordVPN.AutoSize = true;
		this.rbNordVPN.Enabled = false;
		this.rbNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbNordVPN.Location = new System.Drawing.Point(1162, 451);
		this.rbNordVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbNordVPN.Name = "rbNordVPN";
		this.rbNordVPN.Size = new System.Drawing.Size(113, 20);
		this.rbNordVPN.TabIndex = 134;
		this.rbNordVPN.Text = "Đổi IP NordVPN";
		this.rbNordVPN.UseVisualStyleBackColor = true;
		this.rbNordVPN.CheckedChanged += new System.EventHandler(radioButton3_CheckedChanged);
		this.radioButton2.AutoSize = true;
		this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton2.Enabled = false;
		this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.radioButton2.Location = new System.Drawing.Point(1162, 539);
		this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new System.Drawing.Size(145, 20);
		this.radioButton2.TabIndex = 135;
		this.radioButton2.Text = "Đổi IP Hotspot Shield";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.rbSSH.AutoSize = true;
		this.rbSSH.Enabled = false;
		this.rbSSH.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbSSH.Location = new System.Drawing.Point(1162, 511);
		this.rbSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbSSH.Name = "rbSSH";
		this.rbSSH.Size = new System.Drawing.Size(87, 20);
		this.rbSSH.TabIndex = 132;
		this.rbSSH.Text = "Đổi IP SSH";
		this.rbSSH.UseVisualStyleBackColor = true;
		this.radioButton3.AutoSize = true;
		this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton3.Enabled = false;
		this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.radioButton3.Location = new System.Drawing.Point(1162, 451);
		this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.radioButton3.Name = "radioButton3";
		this.radioButton3.Size = new System.Drawing.Size(113, 20);
		this.radioButton3.TabIndex = 134;
		this.radioButton3.Text = "Đổi IP NordVPN";
		this.radioButton3.UseVisualStyleBackColor = true;
		this.radioButton3.CheckedChanged += new System.EventHandler(radioButton3_CheckedChanged);
		this.rbExpressVPN.AutoSize = true;
		this.rbExpressVPN.Enabled = false;
		this.rbExpressVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbExpressVPN.Location = new System.Drawing.Point(1162, 426);
		this.rbExpressVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbExpressVPN.Name = "rbExpressVPN";
		this.rbExpressVPN.Size = new System.Drawing.Size(130, 20);
		this.rbExpressVPN.TabIndex = 133;
		this.rbExpressVPN.Text = "Đổi IP ExpressVPN";
		this.rbExpressVPN.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.tabChangeIP);
		this.groupBox3.Controls.Add(this.rbMinProxy);
		this.groupBox3.Controls.Add(this.rbShopLike);
		this.groupBox3.Controls.Add(this.rbProxyv6);
		this.groupBox3.Controls.Add(this.label37);
		this.groupBox3.Controls.Add(this.nudDelayCheckIP);
		this.groupBox3.Controls.Add(this.linkLabel1);
		this.groupBox3.Controls.Add(this.linkLabel3);
		this.groupBox3.Controls.Add(this.label38);
		this.groupBox3.Controls.Add(this.plCheckDoiIP);
		this.groupBox3.Controls.Add(this.rbTMProxy);
		this.groupBox3.Controls.Add(this.rbDcom);
		this.groupBox3.Controls.Add(this.rbTinsoft);
		this.groupBox3.Controls.Add(this.rbProxy);
		this.groupBox3.Controls.Add(this.rbNone);
		this.groupBox3.Controls.Add(this.rbObcProxy);
		this.groupBox3.Controls.Add(this.rbXproxy);
		this.groupBox3.Controls.Add(this.rbHma);
		this.groupBox3.Controls.Add(this.ckbKhongCheckIP);
		this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.groupBox3.Location = new System.Drawing.Point(580, 38);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(565, 453);
		this.groupBox3.TabIndex = 39;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Cấu hình đổi IP";
		this.tabChangeIP.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		this.tabChangeIP.Controls.Add(this.tabDcom);
		this.tabChangeIP.Controls.Add(this.tabTinsoft);
		this.tabChangeIP.Controls.Add(this.tabXProxy);
		this.tabChangeIP.Controls.Add(this.tabObcProxy);
		this.tabChangeIP.Controls.Add(this.tabProxyV6);
		this.tabChangeIP.Controls.Add(this.tabProxyShopLike);
		this.tabChangeIP.Controls.Add(this.tabTMProxy);
		this.tabChangeIP.Controls.Add(this.tabNone);
		this.tabChangeIP.Controls.Add(this.tabMinProxy);
		this.tabChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.tabChangeIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tabChangeIP.Location = new System.Drawing.Point(24, 226);
		this.tabChangeIP.Name = "tabChangeIP";
		this.tabChangeIP.SelectedIndex = 0;
		this.tabChangeIP.Size = new System.Drawing.Size(510, 248);
		this.tabChangeIP.TabIndex = 146;
		this.tabDcom.Controls.Add(this.plDcom);
		this.tabDcom.Location = new System.Drawing.Point(4, 4);
		this.tabDcom.Name = "tabDcom";
		this.tabDcom.Padding = new System.Windows.Forms.Padding(3);
		this.tabDcom.Size = new System.Drawing.Size(502, 191);
		this.tabDcom.TabIndex = 0;
		this.tabDcom.Text = "Dcom";
		this.tabDcom.UseVisualStyleBackColor = true;
		this.plDcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDcom.Controls.Add(this.button4);
		this.plDcom.Controls.Add(this.txtUrlHilink);
		this.plDcom.Controls.Add(this.txtProfileNameDcom);
		this.plDcom.Controls.Add(this.rbDcomHilink);
		this.plDcom.Controls.Add(this.label36);
		this.plDcom.Controls.Add(this.rbDcomThuong);
		this.plDcom.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plDcom.Location = new System.Drawing.Point(3, 3);
		this.plDcom.Name = "plDcom";
		this.plDcom.Size = new System.Drawing.Size(496, 185);
		this.plDcom.TabIndex = 131;
		this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button4.ForeColor = System.Drawing.Color.Black;
		this.button4.Location = new System.Drawing.Point(313, 63);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(93, 25);
		this.button4.TabIndex = 143;
		this.button4.Text = "Lâ\u0301y tên Dcom";
		this.toolTip_0.SetToolTip(this.button4, "Lâ\u0301y tên dcom");
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.txtUrlHilink.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtUrlHilink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtUrlHilink.ForeColor = System.Drawing.Color.Black;
		this.txtUrlHilink.Location = new System.Drawing.Point(185, 112);
		this.txtUrlHilink.Name = "txtUrlHilink";
		this.txtUrlHilink.Size = new System.Drawing.Size(221, 23);
		this.txtUrlHilink.TabIndex = 81;
		this.txtProfileNameDcom.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtProfileNameDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtProfileNameDcom.ForeColor = System.Drawing.Color.Black;
		this.txtProfileNameDcom.Location = new System.Drawing.Point(121, 64);
		this.txtProfileNameDcom.Name = "txtProfileNameDcom";
		this.txtProfileNameDcom.Size = new System.Drawing.Size(186, 23);
		this.txtProfileNameDcom.TabIndex = 81;
		this.rbDcomHilink.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbDcomHilink.AutoSize = true;
		this.rbDcomHilink.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbDcomHilink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbDcomHilink.Location = new System.Drawing.Point(102, 91);
		this.rbDcomHilink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbDcomHilink.Name = "rbDcomHilink";
		this.rbDcomHilink.Size = new System.Drawing.Size(55, 20);
		this.rbDcomHilink.TabIndex = 136;
		this.rbDcomHilink.Text = "Hilink";
		this.rbDcomHilink.UseVisualStyleBackColor = true;
		this.rbDcomHilink.CheckedChanged += new System.EventHandler(rbDcomHilink_CheckedChanged);
		this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label36.AutoSize = true;
		this.label36.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label36.Location = new System.Drawing.Point(118, 115);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(64, 16);
		this.label36.TabIndex = 79;
		this.label36.Text = "Link Web:";
		this.rbDcomThuong.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbDcomThuong.AutoSize = true;
		this.rbDcomThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbDcomThuong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbDcomThuong.Location = new System.Drawing.Point(102, 40);
		this.rbDcomThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbDcomThuong.Name = "rbDcomThuong";
		this.rbDcomThuong.Size = new System.Drawing.Size(69, 20);
		this.rbDcomThuong.TabIndex = 136;
		this.rbDcomThuong.Text = "Thươ\u0300ng";
		this.rbDcomThuong.UseVisualStyleBackColor = true;
		this.rbDcomThuong.CheckedChanged += new System.EventHandler(rbDcomThuong_CheckedChanged);
		this.tabTinsoft.Controls.Add(this.plTinsoft);
		this.tabTinsoft.Location = new System.Drawing.Point(4, 4);
		this.tabTinsoft.Name = "tabTinsoft";
		this.tabTinsoft.Padding = new System.Windows.Forms.Padding(3);
		this.tabTinsoft.Size = new System.Drawing.Size(502, 221);
		this.tabTinsoft.TabIndex = 1;
		this.tabTinsoft.Text = "https://tinsoftproxy.com/";
		this.tabTinsoft.UseVisualStyleBackColor = true;
		this.plTinsoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTinsoft.Controls.Add(this.ckbWaitDoneAllTinsoft);
		this.plTinsoft.Controls.Add(this.plApiProxy);
		this.plTinsoft.Controls.Add(this.plApiUser);
		this.plTinsoft.Controls.Add(this.cbbLocationTinsoft);
		this.plTinsoft.Controls.Add(this.rbApiProxy);
		this.plTinsoft.Controls.Add(this.rbApiUser);
		this.plTinsoft.Controls.Add(this.label7);
		this.plTinsoft.Controls.Add(this.label8);
		this.plTinsoft.Controls.Add(this.nudLuongPerIPTinsoft);
		this.plTinsoft.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTinsoft.Location = new System.Drawing.Point(3, 3);
		this.plTinsoft.Name = "plTinsoft";
		this.plTinsoft.Size = new System.Drawing.Size(496, 215);
		this.plTinsoft.TabIndex = 143;
		this.ckbWaitDoneAllTinsoft.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ckbWaitDoneAllTinsoft.AutoSize = true;
		this.ckbWaitDoneAllTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWaitDoneAllTinsoft.Location = new System.Drawing.Point(233, 27);
		this.ckbWaitDoneAllTinsoft.Name = "ckbWaitDoneAllTinsoft";
		this.ckbWaitDoneAllTinsoft.Size = new System.Drawing.Size(128, 20);
		this.ckbWaitDoneAllTinsoft.TabIndex = 145;
		this.ckbWaitDoneAllTinsoft.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllTinsoft.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllTinsoft.Visible = false;
		this.plApiProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.plApiProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plApiProxy.Controls.Add(this.lblCountApiProxy);
		this.plApiProxy.Controls.Add(this.label28);
		this.plApiProxy.Controls.Add(this.txtApiProxy);
		this.plApiProxy.Controls.Add(this.button7);
		this.plApiProxy.Location = new System.Drawing.Point(107, 101);
		this.plApiProxy.Name = "plApiProxy";
		this.plApiProxy.Size = new System.Drawing.Size(301, 58);
		this.plApiProxy.TabIndex = 35;
		this.lblCountApiProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.lblCountApiProxy.Location = new System.Drawing.Point(1, 24);
		this.lblCountApiProxy.Name = "lblCountApiProxy";
		this.lblCountApiProxy.Size = new System.Drawing.Size(32, 16);
		this.lblCountApiProxy.TabIndex = 82;
		this.lblCountApiProxy.Text = "(0)";
		this.lblCountApiProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label28.AutoSize = true;
		this.label28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label28.Location = new System.Drawing.Point(1, 5);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(31, 16);
		this.label28.TabIndex = 82;
		this.label28.Text = "API:";
		this.txtApiProxy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtApiProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtApiProxy.ForeColor = System.Drawing.Color.Black;
		this.txtApiProxy.Location = new System.Drawing.Point(35, 2);
		this.txtApiProxy.Multiline = true;
		this.txtApiProxy.Name = "txtApiProxy";
		this.txtApiProxy.Size = new System.Drawing.Size(209, 51);
		this.txtApiProxy.TabIndex = 83;
		this.txtApiProxy.WordWrap = false;
		this.txtApiProxy.TextChanged += new System.EventHandler(txtApiProxy_TextChanged);
		this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button7.ForeColor = System.Drawing.Color.Black;
		this.button7.Location = new System.Drawing.Point(247, 1);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(52, 27);
		this.button7.TabIndex = 143;
		this.button7.Text = "Check";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(button7_Click);
		this.plApiUser.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.plApiUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plApiUser.Controls.Add(this.label1);
		this.plApiUser.Controls.Add(this.txtApiUser);
		this.plApiUser.Controls.Add(this.button3);
		this.plApiUser.Location = new System.Drawing.Point(107, 48);
		this.plApiUser.Name = "plApiUser";
		this.plApiUser.Size = new System.Drawing.Size(301, 29);
		this.plApiUser.TabIndex = 35;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(1, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(31, 16);
		this.label1.TabIndex = 82;
		this.label1.Text = "API:";
		this.txtApiUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtApiUser.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtApiUser.ForeColor = System.Drawing.Color.Black;
		this.txtApiUser.Location = new System.Drawing.Point(35, 2);
		this.txtApiUser.Name = "txtApiUser";
		this.txtApiUser.Size = new System.Drawing.Size(209, 23);
		this.txtApiUser.TabIndex = 83;
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button3.ForeColor = System.Drawing.Color.Black;
		this.button3.Location = new System.Drawing.Point(247, 0);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(52, 27);
		this.button3.TabIndex = 143;
		this.button3.Text = "Check";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.cbbLocationTinsoft.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.cbbLocationTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbLocationTinsoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbLocationTinsoft.DropDownWidth = 120;
		this.cbbLocationTinsoft.FormattingEnabled = true;
		this.cbbLocationTinsoft.Location = new System.Drawing.Point(162, 163);
		this.cbbLocationTinsoft.Name = "cbbLocationTinsoft";
		this.cbbLocationTinsoft.Size = new System.Drawing.Size(112, 24);
		this.cbbLocationTinsoft.TabIndex = 84;
		this.rbApiProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbApiProxy.AutoSize = true;
		this.rbApiProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbApiProxy.Location = new System.Drawing.Point(104, 80);
		this.rbApiProxy.Name = "rbApiProxy";
		this.rbApiProxy.Size = new System.Drawing.Size(135, 20);
		this.rbApiProxy.TabIndex = 34;
		this.rbApiProxy.Text = "Sử dụng Api Proxy:";
		this.rbApiProxy.UseVisualStyleBackColor = true;
		this.rbApiProxy.CheckedChanged += new System.EventHandler(rbApiProxy_CheckedChanged);
		this.rbApiUser.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbApiUser.AutoSize = true;
		this.rbApiUser.Checked = true;
		this.rbApiUser.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbApiUser.Location = new System.Drawing.Point(104, 27);
		this.rbApiUser.Name = "rbApiUser";
		this.rbApiUser.Size = new System.Drawing.Size(130, 20);
		this.rbApiUser.TabIndex = 34;
		this.rbApiUser.TabStop = true;
		this.rbApiUser.Text = "Sử dụng Api User:";
		this.rbApiUser.UseVisualStyleBackColor = true;
		this.rbApiUser.CheckedChanged += new System.EventHandler(rbApiUser_CheckedChanged);
		this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(104, 166);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(59, 16);
		this.label7.TabIndex = 82;
		this.label7.Text = "Location:";
		this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label8.Location = new System.Drawing.Point(280, 166);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(78, 16);
		this.label8.TabIndex = 139;
		this.label8.Text = "Số luồng/IP:";
		this.toolTip_0.SetToolTip(this.label8, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
		this.nudLuongPerIPTinsoft.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPTinsoft.Location = new System.Drawing.Point(362, 164);
		this.nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
		this.nudLuongPerIPTinsoft.Size = new System.Drawing.Size(46, 23);
		this.nudLuongPerIPTinsoft.TabIndex = 140;
		this.nudLuongPerIPTinsoft.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.tabXProxy.Controls.Add(this.plXproxy);
		this.tabXProxy.Location = new System.Drawing.Point(4, 4);
		this.tabXProxy.Name = "tabXProxy";
		this.tabXProxy.Padding = new System.Windows.Forms.Padding(3);
		this.tabXProxy.Size = new System.Drawing.Size(502, 219);
		this.tabXProxy.TabIndex = 2;
		this.tabXProxy.Text = "Xproxy, Mobi, Eager, S Proxy";
		this.tabXProxy.UseVisualStyleBackColor = true;
		this.plXproxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plXproxy.Controls.Add(this.panel7);
		this.plXproxy.Controls.Add(this.ckbWaitDoneAllXproxy);
		this.plXproxy.Controls.Add(this.txtListProxy);
		this.plXproxy.Controls.Add(this.rbSock5Proxy);
		this.plXproxy.Controls.Add(this.rbHttpProxy);
		this.plXproxy.Controls.Add(this.label16);
		this.plXproxy.Controls.Add(this.label17);
		this.plXproxy.Controls.Add(this.label52);
		this.plXproxy.Controls.Add(this.label51);
		this.plXproxy.Controls.Add(this.label18);
		this.plXproxy.Controls.Add(this.nudDelayResetXProxy);
		this.plXproxy.Controls.Add(this.nudLuongPerIPXProxy);
		this.plXproxy.Controls.Add(this.label13);
		this.plXproxy.Controls.Add(this.txtServiceURLXProxy);
		this.plXproxy.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plXproxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plXproxy.Location = new System.Drawing.Point(3, 3);
		this.plXproxy.Name = "plXproxy";
		this.plXproxy.Size = new System.Drawing.Size(496, 213);
		this.plXproxy.TabIndex = 142;
		this.plXproxy.Click += new System.EventHandler(plXproxy_Click);
		this.tabObcProxy.Controls.Add(this.plObcProxy);
		this.tabObcProxy.Location = new System.Drawing.Point(4, 4);
		this.tabObcProxy.Name = "tabObcProxy";
		this.tabObcProxy.Padding = new System.Windows.Forms.Padding(3);
		this.tabObcProxy.Size = new System.Drawing.Size(502, 221);
		this.tabObcProxy.TabIndex = 3;
		this.tabObcProxy.Text = "OBC Proxy";
		this.tabObcProxy.UseVisualStyleBackColor = true;
		this.plObcProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plObcProxy.Controls.Add(this.panel8);
		this.plObcProxy.Controls.Add(this.rbObcSock5Proxy);
		this.plObcProxy.Controls.Add(this.rbObcHttpProxy);
		this.plObcProxy.Controls.Add(this.label55);
		this.plObcProxy.Controls.Add(this.txtListObcProxy);
		this.plObcProxy.Controls.Add(this.label67);
		this.plObcProxy.Controls.Add(this.label68);
		this.plObcProxy.Controls.Add(this.label69);
		this.plObcProxy.Controls.Add(this.nudLuongPerIPObcProxy);
		this.plObcProxy.Controls.Add(this.label70);
		this.plObcProxy.Controls.Add(this.label71);
		this.plObcProxy.Controls.Add(this.nudDelayCheckIPObcProxy);
		this.plObcProxy.Controls.Add(this.txtLinkWebObcProxy);
		this.plObcProxy.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plObcProxy.Location = new System.Drawing.Point(3, 3);
		this.plObcProxy.Name = "plObcProxy";
		this.plObcProxy.Size = new System.Drawing.Size(496, 215);
		this.plObcProxy.TabIndex = 142;
		this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.panel8.Controls.Add(this.label54);
		this.panel8.Controls.Add(this.rbObcResetDaiIP);
		this.panel8.Controls.Add(this.rbObcResetTungIP);
		this.panel8.Location = new System.Drawing.Point(260, 98);
		this.panel8.Name = "panel8";
		this.panel8.Size = new System.Drawing.Size(223, 48);
		this.panel8.TabIndex = 156;
		this.label54.AutoSize = true;
		this.label54.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label54.Location = new System.Drawing.Point(1, 4);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(82, 16);
		this.label54.TabIndex = 155;
		this.label54.Text = "Chế độ chạy:";
		this.rbObcResetDaiIP.AutoSize = true;
		this.rbObcResetDaiIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbObcResetDaiIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbObcResetDaiIP.Location = new System.Drawing.Point(90, 25);
		this.rbObcResetDaiIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbObcResetDaiIP.Name = "rbObcResetDaiIP";
		this.rbObcResetDaiIP.Size = new System.Drawing.Size(110, 20);
		this.rbObcResetDaiIP.TabIndex = 153;
		this.rbObcResetDaiIP.Text = "Reset cả dải IP";
		this.rbObcResetDaiIP.UseVisualStyleBackColor = true;
		this.rbObcResetTungIP.AutoSize = true;
		this.rbObcResetTungIP.Checked = true;
		this.rbObcResetTungIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbObcResetTungIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbObcResetTungIP.Location = new System.Drawing.Point(90, 2);
		this.rbObcResetTungIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbObcResetTungIP.Name = "rbObcResetTungIP";
		this.rbObcResetTungIP.Size = new System.Drawing.Size(102, 20);
		this.rbObcResetTungIP.TabIndex = 154;
		this.rbObcResetTungIP.TabStop = true;
		this.rbObcResetTungIP.Text = "Reset từng IP";
		this.rbObcResetTungIP.UseVisualStyleBackColor = true;
		this.rbObcSock5Proxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbObcSock5Proxy.AutoSize = true;
		this.rbObcSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbObcSock5Proxy.Enabled = false;
		this.rbObcSock5Proxy.Location = new System.Drawing.Point(175, 35);
		this.rbObcSock5Proxy.Name = "rbObcSock5Proxy";
		this.rbObcSock5Proxy.Size = new System.Drawing.Size(59, 20);
		this.rbObcSock5Proxy.TabIndex = 154;
		this.rbObcSock5Proxy.Text = "Sock5";
		this.rbObcSock5Proxy.UseVisualStyleBackColor = true;
		this.rbObcHttpProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbObcHttpProxy.AutoSize = true;
		this.rbObcHttpProxy.Checked = true;
		this.rbObcHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbObcHttpProxy.Location = new System.Drawing.Point(112, 35);
		this.rbObcHttpProxy.Name = "rbObcHttpProxy";
		this.rbObcHttpProxy.Size = new System.Drawing.Size(48, 20);
		this.rbObcHttpProxy.TabIndex = 155;
		this.rbObcHttpProxy.TabStop = true;
		this.rbObcHttpProxy.Text = "Http";
		this.rbObcHttpProxy.UseVisualStyleBackColor = true;
		this.label55.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label55.AutoSize = true;
		this.label55.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label55.Location = new System.Drawing.Point(25, 35);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(70, 16);
		this.label55.TabIndex = 153;
		this.label55.Text = "Loại Proxy:";
		this.txtListObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtListObcProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtListObcProxy.Location = new System.Drawing.Point(28, 75);
		this.txtListObcProxy.Name = "txtListObcProxy";
		this.txtListObcProxy.Size = new System.Drawing.Size(229, 109);
		this.txtListObcProxy.TabIndex = 144;
		this.txtListObcProxy.Text = "";
		this.txtListObcProxy.WordWrap = false;
		this.txtListObcProxy.TextChanged += new System.EventHandler(txtListObcProxy_TextChanged);
		this.label67.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label67.AutoSize = true;
		this.label67.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label67.Location = new System.Drawing.Point(25, 56);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(97, 16);
		this.label67.TabIndex = 79;
		this.label67.Text = "Nhập Proxy (0):";
		this.label68.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(442, 149);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(32, 16);
		this.label68.TabIndex = 139;
		this.label68.Text = "phút";
		this.label69.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label69.AutoSize = true;
		this.label69.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label69.Location = new System.Drawing.Point(263, 75);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(78, 16);
		this.label69.TabIndex = 139;
		this.label69.Text = "Số luồng/IP:";
		this.nudLuongPerIPObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPObcProxy.Location = new System.Drawing.Point(348, 74);
		this.nudLuongPerIPObcProxy.Name = "nudLuongPerIPObcProxy";
		this.nudLuongPerIPObcProxy.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPObcProxy.TabIndex = 140;
		this.nudLuongPerIPObcProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label70.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label70.AutoSize = true;
		this.label70.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label70.Location = new System.Drawing.Point(263, 149);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(123, 16);
		this.label70.TabIndex = 139;
		this.label70.Text = "Chờ Check IP tối đa:";
		this.label71.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label71.AutoSize = true;
		this.label71.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label71.Location = new System.Drawing.Point(25, 13);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(64, 16);
		this.label71.TabIndex = 79;
		this.label71.Text = "Link Web:";
		this.nudDelayCheckIPObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudDelayCheckIPObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudDelayCheckIPObcProxy.Location = new System.Drawing.Point(389, 147);
		this.nudDelayCheckIPObcProxy.Name = "nudDelayCheckIPObcProxy";
		this.nudDelayCheckIPObcProxy.Size = new System.Drawing.Size(50, 23);
		this.nudDelayCheckIPObcProxy.TabIndex = 140;
		this.nudDelayCheckIPObcProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.txtLinkWebObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtLinkWebObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtLinkWebObcProxy.ForeColor = System.Drawing.Color.Black;
		this.txtLinkWebObcProxy.Location = new System.Drawing.Point(112, 10);
		this.txtLinkWebObcProxy.Name = "txtLinkWebObcProxy";
		this.txtLinkWebObcProxy.Size = new System.Drawing.Size(363, 23);
		this.txtLinkWebObcProxy.TabIndex = 81;
		this.tabProxyV6.Controls.Add(this.plProxyv6);
		this.tabProxyV6.Location = new System.Drawing.Point(4, 4);
		this.tabProxyV6.Name = "tabProxyV6";
		this.tabProxyV6.Padding = new System.Windows.Forms.Padding(3);
		this.tabProxyV6.Size = new System.Drawing.Size(502, 221);
		this.tabProxyV6.TabIndex = 4;
		this.tabProxyV6.Text = "https://proxyv6.net/vi";
		this.tabProxyV6.UseVisualStyleBackColor = true;
		this.plProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plProxyv6.Controls.Add(this.txtListProxyv6);
		this.plProxyv6.Controls.Add(this.radioButton1);
		this.plProxyv6.Controls.Add(this.radioButton6);
		this.plProxyv6.Controls.Add(this.label39);
		this.plProxyv6.Controls.Add(this.label43);
		this.plProxyv6.Controls.Add(this.label44);
		this.plProxyv6.Controls.Add(this.nudLuongPerIPProxyv6);
		this.plProxyv6.Controls.Add(this.label45);
		this.plProxyv6.Controls.Add(this.txtApiProxyv6);
		this.plProxyv6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plProxyv6.Location = new System.Drawing.Point(3, 3);
		this.plProxyv6.Name = "plProxyv6";
		this.plProxyv6.Size = new System.Drawing.Size(496, 215);
		this.plProxyv6.TabIndex = 151;
		this.txtListProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtListProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtListProxyv6.Location = new System.Drawing.Point(100, 85);
		this.txtListProxyv6.Name = "txtListProxyv6";
		this.txtListProxyv6.Size = new System.Drawing.Size(305, 96);
		this.txtListProxyv6.TabIndex = 144;
		this.txtListProxyv6.Text = "";
		this.txtListProxyv6.WordWrap = false;
		this.txtListProxyv6.TextChanged += new System.EventHandler(txtListProxyv6_TextChanged);
		this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.radioButton1.AutoSize = true;
		this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton1.Enabled = false;
		this.radioButton1.Location = new System.Drawing.Point(232, 44);
		this.radioButton1.Name = "radioButton1";
		this.radioButton1.Size = new System.Drawing.Size(59, 20);
		this.radioButton1.TabIndex = 82;
		this.radioButton1.Text = "Sock5";
		this.radioButton1.UseVisualStyleBackColor = true;
		this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.radioButton6.AutoSize = true;
		this.radioButton6.Checked = true;
		this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton6.Location = new System.Drawing.Point(169, 44);
		this.radioButton6.Name = "radioButton6";
		this.radioButton6.Size = new System.Drawing.Size(48, 20);
		this.radioButton6.TabIndex = 82;
		this.radioButton6.TabStop = true;
		this.radioButton6.Text = "Http";
		this.radioButton6.UseVisualStyleBackColor = true;
		this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label39.AutoSize = true;
		this.label39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label39.Location = new System.Drawing.Point(97, 44);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(70, 16);
		this.label39.TabIndex = 79;
		this.label39.Text = "Loại Proxy:";
		this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label43.AutoSize = true;
		this.label43.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label43.Location = new System.Drawing.Point(97, 66);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(97, 16);
		this.label43.TabIndex = 79;
		this.label43.Text = "Nhập Proxy (0):";
		this.label44.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label44.AutoSize = true;
		this.label44.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label44.Location = new System.Drawing.Point(99, 185);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(78, 16);
		this.label44.TabIndex = 139;
		this.label44.Text = "Số luồng/IP:";
		this.nudLuongPerIPProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPProxyv6.Location = new System.Drawing.Point(184, 184);
		this.nudLuongPerIPProxyv6.Name = "nudLuongPerIPProxyv6";
		this.nudLuongPerIPProxyv6.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPProxyv6.TabIndex = 140;
		this.nudLuongPerIPProxyv6.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label45.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label45.AutoSize = true;
		this.label45.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label45.Location = new System.Drawing.Point(97, 23);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(55, 16);
		this.label45.TabIndex = 79;
		this.label45.Text = "API Key:";
		this.txtApiProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtApiProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtApiProxyv6.ForeColor = System.Drawing.Color.Black;
		this.txtApiProxyv6.Location = new System.Drawing.Point(169, 20);
		this.txtApiProxyv6.Name = "txtApiProxyv6";
		this.txtApiProxyv6.Size = new System.Drawing.Size(236, 23);
		this.txtApiProxyv6.TabIndex = 81;
		this.tabProxyShopLike.Controls.Add(this.plShopLike);
		this.tabProxyShopLike.Location = new System.Drawing.Point(4, 4);
		this.tabProxyShopLike.Name = "tabProxyShopLike";
		this.tabProxyShopLike.Padding = new System.Windows.Forms.Padding(3);
		this.tabProxyShopLike.Size = new System.Drawing.Size(502, 221);
		this.tabProxyShopLike.TabIndex = 5;
		this.tabProxyShopLike.Text = "http://proxy.shoplike.vn/";
		this.tabProxyShopLike.UseVisualStyleBackColor = true;
		this.plShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plShopLike.Controls.Add(this.txtApiShopLike);
		this.plShopLike.Controls.Add(this.label47);
		this.plShopLike.Controls.Add(this.label48);
		this.plShopLike.Controls.Add(this.nudLuongPerIPShopLike);
		this.plShopLike.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plShopLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plShopLike.Location = new System.Drawing.Point(3, 3);
		this.plShopLike.Name = "plShopLike";
		this.plShopLike.Size = new System.Drawing.Size(496, 215);
		this.plShopLike.TabIndex = 153;
		this.txtApiShopLike.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtApiShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtApiShopLike.Location = new System.Drawing.Point(100, 43);
		this.txtApiShopLike.Name = "txtApiShopLike";
		this.txtApiShopLike.Size = new System.Drawing.Size(308, 124);
		this.txtApiShopLike.TabIndex = 144;
		this.txtApiShopLike.Text = "";
		this.txtApiShopLike.WordWrap = false;
		this.txtApiShopLike.TextChanged += new System.EventHandler(txtApiShopLike_TextChanged);
		this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label47.AutoSize = true;
		this.label47.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label47.Location = new System.Drawing.Point(97, 24);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(110, 16);
		this.label47.TabIndex = 79;
		this.label47.Text = "Nhập API KEY (0):";
		this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label48.AutoSize = true;
		this.label48.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label48.Location = new System.Drawing.Point(97, 173);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(78, 16);
		this.label48.TabIndex = 139;
		this.label48.Text = "Số luồng/IP:";
		this.nudLuongPerIPShopLike.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPShopLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPShopLike.Location = new System.Drawing.Point(182, 170);
		this.nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
		this.nudLuongPerIPShopLike.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPShopLike.TabIndex = 140;
		this.nudLuongPerIPShopLike.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.tabTMProxy.Controls.Add(this.panel15);
		this.tabTMProxy.Location = new System.Drawing.Point(4, 4);
		this.tabTMProxy.Name = "tabTMProxy";
		this.tabTMProxy.Padding = new System.Windows.Forms.Padding(3);
		this.tabTMProxy.Size = new System.Drawing.Size(502, 221);
		this.tabTMProxy.TabIndex = 6;
		this.tabTMProxy.Text = "https://tmproxy.com/";
		this.tabTMProxy.UseVisualStyleBackColor = true;
		this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel15.Controls.Add(this.plTMProxy);
		this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.panel15.Location = new System.Drawing.Point(3, 3);
		this.panel15.Name = "panel15";
		this.panel15.Size = new System.Drawing.Size(496, 215);
		this.panel15.TabIndex = 146;
		this.plTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTMProxy.Controls.Add(this.ckbWaitDoneAllTMProxy);
		this.plTMProxy.Controls.Add(this.txtApiKeyTMProxy);
		this.plTMProxy.Controls.Add(this.label24);
		this.plTMProxy.Controls.Add(this.button8);
		this.plTMProxy.Controls.Add(this.label25);
		this.plTMProxy.Controls.Add(this.nudLuongPerIPTMProxy);
		this.plTMProxy.Dock = System.Windows.Forms.DockStyle.Fill;
		this.plTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTMProxy.Location = new System.Drawing.Point(0, 0);
		this.plTMProxy.Name = "plTMProxy";
		this.plTMProxy.Size = new System.Drawing.Size(494, 213);
		this.plTMProxy.TabIndex = 146;
		this.plTMProxy.Click += new System.EventHandler(plTMProxy_Click);
		this.ckbWaitDoneAllTMProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ckbWaitDoneAllTMProxy.AutoSize = true;
		this.ckbWaitDoneAllTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWaitDoneAllTMProxy.Location = new System.Drawing.Point(258, 45);
		this.ckbWaitDoneAllTMProxy.Name = "ckbWaitDoneAllTMProxy";
		this.ckbWaitDoneAllTMProxy.Size = new System.Drawing.Size(128, 20);
		this.ckbWaitDoneAllTMProxy.TabIndex = 145;
		this.ckbWaitDoneAllTMProxy.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllTMProxy.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllTMProxy.Visible = false;
		this.txtApiKeyTMProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtApiKeyTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtApiKeyTMProxy.Location = new System.Drawing.Point(95, 67);
		this.txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
		this.txtApiKeyTMProxy.Size = new System.Drawing.Size(310, 101);
		this.txtApiKeyTMProxy.TabIndex = 144;
		this.txtApiKeyTMProxy.Text = "";
		this.txtApiKeyTMProxy.WordWrap = false;
		this.txtApiKeyTMProxy.TextChanged += new System.EventHandler(txtApiKeyTMProxy_TextChanged);
		this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label24.AutoSize = true;
		this.label24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label24.Location = new System.Drawing.Point(92, 46);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(110, 16);
		this.label24.TabIndex = 79;
		this.label24.Text = "Nhập API KEY (0):";
		this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button8.ForeColor = System.Drawing.Color.Black;
		this.button8.Location = new System.Drawing.Point(353, 171);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(52, 27);
		this.button8.TabIndex = 143;
		this.button8.Text = "Check";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label25.AutoSize = true;
		this.label25.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label25.Location = new System.Drawing.Point(92, 175);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(78, 16);
		this.label25.TabIndex = 139;
		this.label25.Text = "Số luồng/IP:";
		this.nudLuongPerIPTMProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPTMProxy.Location = new System.Drawing.Point(174, 173);
		this.nudLuongPerIPTMProxy.Name = "nudLuongPerIPTMProxy";
		this.nudLuongPerIPTMProxy.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPTMProxy.TabIndex = 140;
		this.nudLuongPerIPTMProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.tabNone.Controls.Add(this.panel16);
		this.tabNone.Location = new System.Drawing.Point(4, 4);
		this.tabNone.Name = "tabNone";
		this.tabNone.Padding = new System.Windows.Forms.Padding(3);
		this.tabNone.Size = new System.Drawing.Size(502, 221);
		this.tabNone.TabIndex = 7;
		this.tabNone.Text = "tabPage1";
		this.tabNone.UseVisualStyleBackColor = true;
		this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel16.Location = new System.Drawing.Point(3, 3);
		this.panel16.Name = "panel16";
		this.panel16.Size = new System.Drawing.Size(496, 215);
		this.panel16.TabIndex = 0;
		this.tabMinProxy.Controls.Add(this.panel5);
		this.tabMinProxy.Location = new System.Drawing.Point(4, 4);
		this.tabMinProxy.Name = "tabMinProxy";
		this.tabMinProxy.Padding = new System.Windows.Forms.Padding(3);
		this.tabMinProxy.Size = new System.Drawing.Size(502, 221);
		this.tabMinProxy.TabIndex = 8;
		this.tabMinProxy.Text = "https://minproxy.vn/";
		this.tabMinProxy.UseVisualStyleBackColor = true;
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.plTypeProxy);
		this.panel5.Controls.Add(this.rbProxyDanCu);
		this.panel5.Controls.Add(this.rbProxyDong);
		this.panel5.Controls.Add(this.button10);
		this.panel5.Controls.Add(this.txtApiKeyMinProxy);
		this.panel5.Controls.Add(this.label49);
		this.panel5.Controls.Add(this.label50);
		this.panel5.Controls.Add(this.nudLuongPerIPMinProxy);
		this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.panel5.Location = new System.Drawing.Point(3, 3);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(496, 215);
		this.panel5.TabIndex = 153;
		this.plTypeProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.plTypeProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTypeProxy.Controls.Add(this.rbSockv6);
		this.plTypeProxy.Controls.Add(this.rbSockv4);
		this.plTypeProxy.Controls.Add(this.rbHttpv6);
		this.plTypeProxy.Controls.Add(this.rbHttpv4);
		this.plTypeProxy.Controls.Add(this.label56);
		this.plTypeProxy.Enabled = false;
		this.plTypeProxy.Location = new System.Drawing.Point(33, 31);
		this.plTypeProxy.Name = "plTypeProxy";
		this.plTypeProxy.Size = new System.Drawing.Size(364, 34);
		this.plTypeProxy.TabIndex = 158;
		this.rbSockv6.AutoSize = true;
		this.rbSockv6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSockv6.Location = new System.Drawing.Point(292, 6);
		this.rbSockv6.Name = "rbSockv6";
		this.rbSockv6.Size = new System.Drawing.Size(67, 20);
		this.rbSockv6.TabIndex = 163;
		this.rbSockv6.Text = "SockV6";
		this.rbSockv6.UseVisualStyleBackColor = true;
		this.rbSockv4.AutoSize = true;
		this.rbSockv4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSockv4.Location = new System.Drawing.Point(220, 6);
		this.rbSockv4.Name = "rbSockv4";
		this.rbSockv4.Size = new System.Drawing.Size(67, 20);
		this.rbSockv4.TabIndex = 162;
		this.rbSockv4.Text = "SockV4";
		this.rbSockv4.UseVisualStyleBackColor = true;
		this.rbHttpv6.AutoSize = true;
		this.rbHttpv6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHttpv6.Location = new System.Drawing.Point(150, 6);
		this.rbHttpv6.Name = "rbHttpv6";
		this.rbHttpv6.Size = new System.Drawing.Size(63, 20);
		this.rbHttpv6.TabIndex = 161;
		this.rbHttpv6.Text = "HttpV6";
		this.rbHttpv6.UseVisualStyleBackColor = true;
		this.rbHttpv4.AutoSize = true;
		this.rbHttpv4.Checked = true;
		this.rbHttpv4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHttpv4.Location = new System.Drawing.Point(80, 6);
		this.rbHttpv4.Name = "rbHttpv4";
		this.rbHttpv4.Size = new System.Drawing.Size(63, 20);
		this.rbHttpv4.TabIndex = 160;
		this.rbHttpv4.TabStop = true;
		this.rbHttpv4.Text = "HttpV4";
		this.rbHttpv4.UseVisualStyleBackColor = true;
		this.label56.AutoSize = true;
		this.label56.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label56.Location = new System.Drawing.Point(4, 8);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(70, 16);
		this.label56.TabIndex = 155;
		this.label56.Text = "Loại Proxy:";
		this.rbProxyDanCu.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbProxyDanCu.AutoSize = true;
		this.rbProxyDanCu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbProxyDanCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbProxyDanCu.Location = new System.Drawing.Point(152, 10);
		this.rbProxyDanCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbProxyDanCu.Name = "rbProxyDanCu";
		this.rbProxyDanCu.Size = new System.Drawing.Size(99, 20);
		this.rbProxyDanCu.TabIndex = 154;
		this.rbProxyDanCu.Text = "Proxy dân cư";
		this.rbProxyDanCu.UseVisualStyleBackColor = true;
		this.rbProxyDanCu.CheckedChanged += new System.EventHandler(rbProxyDanCu_CheckedChanged);
		this.rbProxyDong.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbProxyDong.AutoSize = true;
		this.rbProxyDong.Checked = true;
		this.rbProxyDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbProxyDong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbProxyDong.Location = new System.Drawing.Point(33, 10);
		this.rbProxyDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbProxyDong.Name = "rbProxyDong";
		this.rbProxyDong.Size = new System.Drawing.Size(107, 20);
		this.rbProxyDong.TabIndex = 153;
		this.rbProxyDong.TabStop = true;
		this.rbProxyDong.Text = "Proxy V6 động";
		this.rbProxyDong.UseVisualStyleBackColor = true;
		this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button10.ForeColor = System.Drawing.Color.Black;
		this.button10.Location = new System.Drawing.Point(228, 179);
		this.button10.Name = "button10";
		this.button10.Size = new System.Drawing.Size(52, 27);
		this.button10.TabIndex = 145;
		this.button10.Text = "Check";
		this.button10.UseVisualStyleBackColor = true;
		this.button10.Click += new System.EventHandler(button10_Click);
		this.txtApiKeyMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtApiKeyMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtApiKeyMinProxy.Location = new System.Drawing.Point(33, 102);
		this.txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
		this.txtApiKeyMinProxy.Size = new System.Drawing.Size(253, 76);
		this.txtApiKeyMinProxy.TabIndex = 144;
		this.txtApiKeyMinProxy.Text = "";
		this.txtApiKeyMinProxy.WordWrap = false;
		this.txtApiKeyMinProxy.TextChanged += new System.EventHandler(txtApiKeyMinProxy_TextChanged);
		this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(30, 83);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(110, 16);
		this.label49.TabIndex = 79;
		this.label49.Text = "Nhập API KEY (0):";
		this.label50.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label50.AutoSize = true;
		this.label50.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label50.Location = new System.Drawing.Point(30, 184);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(78, 16);
		this.label50.TabIndex = 139;
		this.label50.Text = "Số luồng/IP:";
		this.nudLuongPerIPMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPMinProxy.Location = new System.Drawing.Point(115, 182);
		this.nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
		this.nudLuongPerIPMinProxy.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPMinProxy.TabIndex = 140;
		this.nudLuongPerIPMinProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.rbMinProxy.AutoSize = true;
		this.rbMinProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbMinProxy.Location = new System.Drawing.Point(30, 176);
		this.rbMinProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbMinProxy.Name = "rbMinProxy";
		this.rbMinProxy.Size = new System.Drawing.Size(142, 20);
		this.rbMinProxy.TabIndex = 152;
		this.rbMinProxy.Text = "https://minproxy.vn/";
		this.rbMinProxy.UseVisualStyleBackColor = true;
		this.rbMinProxy.CheckedChanged += new System.EventHandler(rbMinProxy_CheckedChanged);
		this.rbShopLike.AutoSize = true;
		this.rbShopLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbShopLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbShopLike.Location = new System.Drawing.Point(301, 177);
		this.rbShopLike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbShopLike.Name = "rbShopLike";
		this.rbShopLike.Size = new System.Drawing.Size(165, 20);
		this.rbShopLike.TabIndex = 152;
		this.rbShopLike.Text = "http://proxy.shoplike.vn/";
		this.rbShopLike.UseVisualStyleBackColor = true;
		this.rbShopLike.CheckedChanged += new System.EventHandler(rbShopLike_CheckedChanged);
		this.rbProxyv6.AutoSize = true;
		this.rbProxyv6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbProxyv6.Location = new System.Drawing.Point(301, 154);
		this.rbProxyv6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbProxyv6.Name = "rbProxyv6";
		this.rbProxyv6.Size = new System.Drawing.Size(139, 20);
		this.rbProxyv6.TabIndex = 150;
		this.rbProxyv6.Text = "https://proxyv6.net/";
		this.rbProxyv6.UseVisualStyleBackColor = true;
		this.rbProxyv6.CheckedChanged += new System.EventHandler(rbProxyv6_CheckedChanged);
		this.label37.AutoSize = true;
		this.label37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label37.Location = new System.Drawing.Point(27, 81);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(123, 16);
		this.label37.TabIndex = 139;
		this.label37.Text = "Delay sau khi đô\u0309i IP:";
		this.nudDelayCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudDelayCheckIP.Location = new System.Drawing.Point(157, 79);
		this.nudDelayCheckIP.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		this.nudDelayCheckIP.Name = "nudDelayCheckIP";
		this.nudDelayCheckIP.Size = new System.Drawing.Size(46, 23);
		this.nudDelayCheckIP.TabIndex = 140;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(208, 178);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(85, 16);
		this.linkLabel1.TabIndex = 147;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Hươ\u0301ng dâ\u0303n(?)";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel3.Location = new System.Drawing.Point(208, 201);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(85, 16);
		this.linkLabel3.TabIndex = 147;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "Hươ\u0301ng dâ\u0303n(?)";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked);
		this.label38.AutoSize = true;
		this.label38.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label38.Location = new System.Drawing.Point(205, 81);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(30, 16);
		this.label38.TabIndex = 141;
		this.label38.Text = "giây";
		this.plCheckDoiIP.Controls.Add(this.button5);
		this.plCheckDoiIP.Controls.Add(this.label26);
		this.plCheckDoiIP.Controls.Add(this.nudChangeIpCount);
		this.plCheckDoiIP.Controls.Add(this.label27);
		this.plCheckDoiIP.Location = new System.Drawing.Point(24, 48);
		this.plCheckDoiIP.Name = "plCheckDoiIP";
		this.plCheckDoiIP.Size = new System.Drawing.Size(304, 27);
		this.plCheckDoiIP.TabIndex = 146;
		this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.button5.ForeColor = System.Drawing.Color.Black;
		this.button5.Location = new System.Drawing.Point(220, 0);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(77, 27);
		this.button5.TabIndex = 143;
		this.button5.Text = "Test";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.label26.AutoSize = true;
		this.label26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label26.Location = new System.Drawing.Point(3, 5);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(100, 16);
		this.label26.TabIndex = 139;
		this.label26.Text = "Thay đổi IP sau:";
		this.nudChangeIpCount.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudChangeIpCount.Location = new System.Drawing.Point(133, 3);
		this.nudChangeIpCount.Name = "nudChangeIpCount";
		this.nudChangeIpCount.Size = new System.Drawing.Size(46, 23);
		this.nudChangeIpCount.TabIndex = 140;
		this.nudChangeIpCount.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label27.AutoSize = true;
		this.label27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label27.Location = new System.Drawing.Point(181, 5);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(29, 16);
		this.label27.TabIndex = 141;
		this.label27.Text = "lượt";
		this.rbTMProxy.AutoSize = true;
		this.rbTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbTMProxy.Location = new System.Drawing.Point(301, 200);
		this.rbTMProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbTMProxy.Name = "rbTMProxy";
		this.rbTMProxy.Size = new System.Drawing.Size(147, 20);
		this.rbTMProxy.TabIndex = 145;
		this.rbTMProxy.Text = "https://tmproxy.com/";
		this.rbTMProxy.UseVisualStyleBackColor = true;
		this.rbTMProxy.CheckedChanged += new System.EventHandler(rbTMProxy_CheckedChanged);
		this.rbDcom.AutoSize = true;
		this.rbDcom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbDcom.Location = new System.Drawing.Point(30, 130);
		this.rbDcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbDcom.Name = "rbDcom";
		this.rbDcom.Size = new System.Drawing.Size(95, 20);
		this.rbDcom.TabIndex = 137;
		this.rbDcom.Text = "Đổi IP Dcom";
		this.rbDcom.UseVisualStyleBackColor = true;
		this.rbDcom.CheckedChanged += new System.EventHandler(rbDcom_CheckedChanged);
		this.rbTinsoft.AutoSize = true;
		this.rbTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbTinsoft.Location = new System.Drawing.Point(30, 199);
		this.rbTinsoft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbTinsoft.Name = "rbTinsoft";
		this.rbTinsoft.Size = new System.Drawing.Size(167, 20);
		this.rbTinsoft.TabIndex = 134;
		this.rbTinsoft.Text = "https://tinsoftproxy.com/";
		this.rbTinsoft.UseVisualStyleBackColor = true;
		this.rbTinsoft.CheckedChanged += new System.EventHandler(rbTinsoft_CheckedChanged);
		this.rbProxy.AutoSize = true;
		this.rbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbProxy.Location = new System.Drawing.Point(30, 153);
		this.rbProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbProxy.Name = "rbProxy";
		this.rbProxy.Size = new System.Drawing.Size(266, 20);
		this.rbProxy.TabIndex = 136;
		this.rbProxy.Text = "Sử dụng Proxy (đã gán cho mỗi tài khoản)";
		this.rbProxy.UseVisualStyleBackColor = true;
		this.rbProxy.CheckedChanged += new System.EventHandler(rbProxy_CheckedChanged);
		this.rbNone.AutoSize = true;
		this.rbNone.Checked = true;
		this.rbNone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbNone.Location = new System.Drawing.Point(30, 107);
		this.rbNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbNone.Name = "rbNone";
		this.rbNone.Size = new System.Drawing.Size(96, 20);
		this.rbNone.TabIndex = 136;
		this.rbNone.TabStop = true;
		this.rbNone.Text = "Không đổi IP";
		this.rbNone.UseVisualStyleBackColor = true;
		this.rbNone.CheckedChanged += new System.EventHandler(rbNone_CheckedChanged);
		this.rbObcProxy.AutoSize = true;
		this.rbObcProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbObcProxy.Location = new System.Drawing.Point(301, 131);
		this.rbObcProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbObcProxy.Name = "rbObcProxy";
		this.rbObcProxy.Size = new System.Drawing.Size(84, 20);
		this.rbObcProxy.TabIndex = 138;
		this.rbObcProxy.Text = "OBC Proxy";
		this.rbObcProxy.UseVisualStyleBackColor = true;
		this.rbObcProxy.CheckedChanged += new System.EventHandler(rbObcProxy_CheckedChanged);
		this.rbXproxy.AutoSize = true;
		this.rbXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXproxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbXproxy.Location = new System.Drawing.Point(301, 108);
		this.rbXproxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbXproxy.Name = "rbXproxy";
		this.rbXproxy.Size = new System.Drawing.Size(258, 20);
		this.rbXproxy.TabIndex = 138;
		this.rbXproxy.Text = "Xproxy, Mobi, Eager, S Proxy, OBC proxy";
		this.rbXproxy.UseVisualStyleBackColor = true;
		this.rbXproxy.CheckedChanged += new System.EventHandler(rbXproxy_CheckedChanged);
		this.rbHma.AutoSize = true;
		this.rbHma.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHma.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbHma.Location = new System.Drawing.Point(205, 130);
		this.rbHma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbHma.Name = "rbHma";
		this.rbHma.Size = new System.Drawing.Size(89, 20);
		this.rbHma.TabIndex = 138;
		this.rbHma.Text = "Đổi IP HMA";
		this.rbHma.UseVisualStyleBackColor = true;
		this.rbHma.CheckedChanged += new System.EventHandler(rbHma_CheckedChanged);
		this.ckbKhongCheckIP.AutoSize = true;
		this.ckbKhongCheckIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbKhongCheckIP.Location = new System.Drawing.Point(30, 26);
		this.ckbKhongCheckIP.Name = "ckbKhongCheckIP";
		this.ckbKhongCheckIP.Size = new System.Drawing.Size(198, 20);
		this.ckbKhongCheckIP.TabIndex = 112;
		this.ckbKhongCheckIP.Text = "Không Check IP trước khi chạy";
		this.ckbKhongCheckIP.UseVisualStyleBackColor = true;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.txtServiceURLXProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtServiceURLXProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.txtServiceURLXProxy.ForeColor = System.Drawing.Color.Black;
		this.txtServiceURLXProxy.Location = new System.Drawing.Point(103, 13);
		this.txtServiceURLXProxy.Name = "txtServiceURLXProxy";
		this.txtServiceURLXProxy.Size = new System.Drawing.Size(378, 23);
		this.txtServiceURLXProxy.TabIndex = 81;
		this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label13.Location = new System.Drawing.Point(16, 16);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(80, 16);
		this.label13.TabIndex = 79;
		this.label13.Text = "Service URL:";
		this.nudLuongPerIPXProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudLuongPerIPXProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudLuongPerIPXProxy.Location = new System.Drawing.Point(343, 83);
		this.nudLuongPerIPXProxy.Name = "nudLuongPerIPXProxy";
		this.nudLuongPerIPXProxy.Size = new System.Drawing.Size(67, 23);
		this.nudLuongPerIPXProxy.TabIndex = 140;
		this.nudLuongPerIPXProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudDelayResetXProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudDelayResetXProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudDelayResetXProxy.Location = new System.Drawing.Point(382, 156);
		this.nudDelayResetXProxy.Name = "nudDelayResetXProxy";
		this.nudDelayResetXProxy.Size = new System.Drawing.Size(50, 23);
		this.nudDelayResetXProxy.TabIndex = 140;
		this.nudDelayResetXProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label18.Location = new System.Drawing.Point(258, 84);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(78, 16);
		this.label18.TabIndex = 139;
		this.label18.Text = "Số luồng/IP:";
		this.label51.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label51.AutoSize = true;
		this.label51.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label51.Location = new System.Drawing.Point(258, 160);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(123, 16);
		this.label51.TabIndex = 139;
		this.label51.Text = "Chờ Check IP tối đa:";
		this.label52.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label52.AutoSize = true;
		this.label52.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label52.Location = new System.Drawing.Point(434, 158);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(32, 16);
		this.label52.TabIndex = 139;
		this.label52.Text = "phút";
		this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label17.Location = new System.Drawing.Point(16, 65);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(97, 16);
		this.label17.TabIndex = 79;
		this.label17.Text = "Nhập Proxy (0):";
		this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label16.Location = new System.Drawing.Point(16, 40);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(70, 16);
		this.label16.TabIndex = 79;
		this.label16.Text = "Loại Proxy:";
		this.rbHttpProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbHttpProxy.AutoSize = true;
		this.rbHttpProxy.Checked = true;
		this.rbHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbHttpProxy.Location = new System.Drawing.Point(103, 40);
		this.rbHttpProxy.Name = "rbHttpProxy";
		this.rbHttpProxy.Size = new System.Drawing.Size(48, 20);
		this.rbHttpProxy.TabIndex = 82;
		this.rbHttpProxy.TabStop = true;
		this.rbHttpProxy.Text = "Http";
		this.rbHttpProxy.UseVisualStyleBackColor = true;
		this.rbSock5Proxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.rbSock5Proxy.AutoSize = true;
		this.rbSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSock5Proxy.Location = new System.Drawing.Point(166, 40);
		this.rbSock5Proxy.Name = "rbSock5Proxy";
		this.rbSock5Proxy.Size = new System.Drawing.Size(59, 20);
		this.rbSock5Proxy.TabIndex = 82;
		this.rbSock5Proxy.Text = "Sock5";
		this.rbSock5Proxy.UseVisualStyleBackColor = true;
		this.txtListProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtListProxy.Location = new System.Drawing.Point(19, 86);
		this.txtListProxy.Name = "txtListProxy";
		this.txtListProxy.Size = new System.Drawing.Size(229, 99);
		this.txtListProxy.TabIndex = 144;
		this.txtListProxy.Text = "";
		this.txtListProxy.WordWrap = false;
		this.txtListProxy.TextChanged += new System.EventHandler(txtListProxy_TextChanged);
		this.ckbWaitDoneAllXproxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ckbWaitDoneAllXproxy.AutoSize = true;
		this.ckbWaitDoneAllXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWaitDoneAllXproxy.Location = new System.Drawing.Point(125, 64);
		this.ckbWaitDoneAllXproxy.Name = "ckbWaitDoneAllXproxy";
		this.ckbWaitDoneAllXproxy.Size = new System.Drawing.Size(128, 20);
		this.ckbWaitDoneAllXproxy.TabIndex = 145;
		this.ckbWaitDoneAllXproxy.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllXproxy.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllXproxy.Visible = false;
		this.rbXproxyResetEachProxy.AutoSize = true;
		this.rbXproxyResetEachProxy.Checked = true;
		this.rbXproxyResetEachProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXproxyResetEachProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbXproxyResetEachProxy.Location = new System.Drawing.Point(90, 2);
		this.rbXproxyResetEachProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbXproxyResetEachProxy.Name = "rbXproxyResetEachProxy";
		this.rbXproxyResetEachProxy.Size = new System.Drawing.Size(122, 20);
		this.rbXproxyResetEachProxy.TabIndex = 154;
		this.rbXproxyResetEachProxy.TabStop = true;
		this.rbXproxyResetEachProxy.Text = "Reset từng proxy";
		this.rbXproxyResetEachProxy.UseVisualStyleBackColor = true;
		this.rbXproxyResetAllProxy.AutoSize = true;
		this.rbXproxyResetAllProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbXproxyResetAllProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.rbXproxyResetAllProxy.Location = new System.Drawing.Point(90, 26);
		this.rbXproxyResetAllProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.rbXproxyResetAllProxy.Name = "rbXproxyResetAllProxy";
		this.rbXproxyResetAllProxy.Size = new System.Drawing.Size(128, 20);
		this.rbXproxyResetAllProxy.TabIndex = 153;
		this.rbXproxyResetAllProxy.Text = "Reset tất cả proxy";
		this.rbXproxyResetAllProxy.UseVisualStyleBackColor = true;
		this.label53.AutoSize = true;
		this.label53.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label53.Location = new System.Drawing.Point(1, 4);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(82, 16);
		this.label53.TabIndex = 155;
		this.label53.Text = "Chế độ chạy:";
		this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.panel7.Controls.Add(this.label53);
		this.panel7.Controls.Add(this.rbXproxyResetAllProxy);
		this.panel7.Controls.Add(this.rbXproxyResetEachProxy);
		this.panel7.Location = new System.Drawing.Point(257, 107);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(223, 48);
		this.panel7.TabIndex = 152;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1158, 539);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhChung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fCauHinhChung_Load);
		((System.ComponentModel.ISupportInitialize)this.nudInteractThread).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudHideThread).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plVitech.ResumeLayout(false);
		this.plVitech.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPVitech).EndInit();
		this.grChrome.ResumeLayout(false);
		this.grChrome.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.plSizeChrome.ResumeLayout(false);
		this.plSizeChrome.PerformLayout();
		this.plSapXepCuaSoChrome.ResumeLayout(false);
		this.plSapXepCuaSoChrome.PerformLayout();
		this.plAddChromeVaoFormView.ResumeLayout(false);
		this.plAddChromeVaoFormView.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCloseChromeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCloseChromeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayOpenChromeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayOpenChromeTo).EndInit();
		this.plLinkToOtherBrowser.ResumeLayout(false);
		this.plLinkToOtherBrowser.PerformLayout();
		this.plUsePortable.ResumeLayout(false);
		this.plUsePortable.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.plNordVPN.ResumeLayout(false);
		this.plNordVPN.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.panel6.ResumeLayout(false);
		this.panel6.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.tabChangeIP.ResumeLayout(false);
		this.tabDcom.ResumeLayout(false);
		this.plDcom.ResumeLayout(false);
		this.plDcom.PerformLayout();
		this.tabTinsoft.ResumeLayout(false);
		this.plTinsoft.ResumeLayout(false);
		this.plTinsoft.PerformLayout();
		this.plApiProxy.ResumeLayout(false);
		this.plApiProxy.PerformLayout();
		this.plApiUser.ResumeLayout(false);
		this.plApiUser.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPTinsoft).EndInit();
		this.tabXProxy.ResumeLayout(false);
		this.plXproxy.ResumeLayout(false);
		this.plXproxy.PerformLayout();
		this.tabObcProxy.ResumeLayout(false);
		this.plObcProxy.ResumeLayout(false);
		this.plObcProxy.PerformLayout();
		this.panel8.ResumeLayout(false);
		this.panel8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPObcProxy).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCheckIPObcProxy).EndInit();
		this.tabProxyV6.ResumeLayout(false);
		this.plProxyv6.ResumeLayout(false);
		this.plProxyv6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPProxyv6).EndInit();
		this.tabProxyShopLike.ResumeLayout(false);
		this.plShopLike.ResumeLayout(false);
		this.plShopLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPShopLike).EndInit();
		this.tabTMProxy.ResumeLayout(false);
		this.panel15.ResumeLayout(false);
		this.plTMProxy.ResumeLayout(false);
		this.plTMProxy.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPTMProxy).EndInit();
		this.tabNone.ResumeLayout(false);
		this.tabMinProxy.ResumeLayout(false);
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		this.plTypeProxy.ResumeLayout(false);
		this.plTypeProxy.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPMinProxy).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayCheckIP).EndInit();
		this.plCheckDoiIP.ResumeLayout(false);
		this.plCheckDoiIP.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudChangeIpCount).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudLuongPerIPXProxy).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayResetXProxy).EndInit();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		base.ResumeLayout(false);
	}
}
