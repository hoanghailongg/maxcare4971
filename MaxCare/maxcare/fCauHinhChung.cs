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

// Token: 0x020001A9 RID: 425
public class fCauHinhChung : Form
{
	// Token: 0x06001167 RID: 4455 RVA: 0x0000723A File Offset: 0x0000543A
	public fCauHinhChung()
	{
		this.InitializeComponent();
		this.gclass17_0 = new GClass17("configGeneral", false);
		this.method_0();
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x001AA0BC File Offset: 0x001A82BC
	private void method_0()
	{
		GClass29.smethod_1(this.bunifuCustomLabel1);
		GClass29.smethod_1(this.groupBox2);
		GClass29.smethod_1(this.label3);
		GClass29.smethod_1(this.label6);
		GClass29.smethod_1(this.label4);
		GClass29.smethod_1(this.label5);
		GClass29.smethod_1(this.label9);
		GClass29.smethod_1(this.grChrome);
		GClass29.smethod_1(this.ckbShowImageInteract);
		GClass29.smethod_1(this.ckbAddChromeIntoForm);
		GClass29.smethod_1(this.label10);
		GClass29.smethod_1(this.label20);
		GClass29.smethod_1(this.label29);
		GClass29.smethod_1(this.label21);
		GClass29.smethod_1(this.label2);
		GClass29.smethod_1(this.label32);
		GClass29.smethod_1(this.label31);
		GClass29.smethod_1(this.label30);
		GClass29.smethod_1(this.rbTocDoGoCham);
		GClass29.smethod_1(this.rbTocDoGoBinhThuong);
		GClass29.smethod_1(this.rbTocDoGoNhanh);
		GClass29.smethod_1(this.linkLabel2);
		GClass29.smethod_1(this.groupBox1);
		GClass29.smethod_1(this.label23);
		GClass29.smethod_1(this.rbPhanBietMauNen);
		GClass29.smethod_1(this.rbPhanBietMauChu);
		GClass29.smethod_1(this.groupBox3);
		GClass29.smethod_1(this.ckbKhongCheckIP);
		GClass29.smethod_1(this.label26);
		GClass29.smethod_1(this.label27);
		GClass29.smethod_1(this.button5);
		GClass29.smethod_1(this.rbNone);
		GClass29.smethod_1(this.rbProxy);
		GClass29.smethod_1(this.rbHma);
		GClass29.smethod_1(this.rbDcom);
		GClass29.smethod_1(this.button4);
		GClass29.smethod_1(this.rbTinsoft);
		GClass29.smethod_1(this.linkLabel3);
		GClass29.smethod_1(this.rbApiUser);
		GClass29.smethod_1(this.ckbWaitDoneAllTinsoft);
		GClass29.smethod_1(this.rbApiProxy);
		GClass29.smethod_1(this.label7);
		GClass29.smethod_1(this.label8);
		GClass29.smethod_1(this.label16);
		GClass29.smethod_1(this.label17);
		GClass29.smethod_1(this.ckbWaitDoneAllXproxy);
		GClass29.smethod_1(this.label18);
		GClass29.smethod_1(this.linkLabel1);
		GClass29.smethod_1(this.label24);
		GClass29.smethod_1(this.ckbWaitDoneAllTMProxy);
		GClass29.smethod_1(this.label25);
		GClass29.smethod_1(this.btnSave);
		GClass29.smethod_1(this.btnCancel);
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x001AA310 File Offset: 0x001A8510
	private void method_1()
	{
		Dictionary<string, string> dataSource = this.method_2();
		this.cbbLocationTinsoft.DataSource = new BindingSource(dataSource, null);
		this.cbbLocationTinsoft.ValueMember = "Key";
		this.cbbLocationTinsoft.DisplayMember = "Value";
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x001AA358 File Offset: 0x001A8558
	public Dictionary<string, string> method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		List<string> list = Class38.smethod_2();
		for (int i = 0; i < list.Count; i++)
		{
			string[] array = list[i].Split(new char[]
			{
				'|'
			});
			dictionary.Add(array[0], array[1]);
		}
		return dictionary;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00002C53 File Offset: 0x00000E53
	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x001AA3B0 File Offset: 0x001A85B0
	// fCauHinhChung
	// Token: 0x0600116C RID: 4460 RVA: 0x001AA380 File Offset: 0x001A8580
	private void fCauHinhChung_Load(object sender, EventArgs e)
	{
		this.method_1();
		this.method_12();
		this.nudInteractThread.Value = this.gclass17_0.method_2("nudInteractThread", 3);
		this.nudHideThread.Value = this.gclass17_0.method_2("nudHideThread", 5);
		this.txbPathProfile.Text = ((this.gclass17_0.method_0("txbPathProfile", "") == "") ? (Application.StartupPath + "\\profiles") : this.gclass17_0.method_0("txbPathProfile", ""));
		if (!Directory.Exists(this.txbPathProfile.Text) || this.txbPathProfile.Text.Trim() == "profiles")
		{
			this.txbPathProfile.Text = Application.StartupPath + "\\profiles";
		}
		this.gclass17_0.method_5("txbPathProfile", this.txbPathProfile.Text);
		this.ckbShowImageInteract.Checked = Convert.ToBoolean((this.gclass17_0.method_0("ckbShowImageInteract", "") == "") ? "false" : this.gclass17_0.method_0("ckbShowImageInteract", ""));
		this.ckbAddChromeIntoForm.Checked = this.gclass17_0.method_3("ckbAddChromeIntoForm", false);
		this.nudWidthChrome.Value = this.gclass17_0.method_2("nudWidthChrome", 320);
		this.nudHeighChrome.Value = this.gclass17_0.method_2("nudHeighChrome", 480);
		this.nudDelayOpenChromeFrom.Value = this.gclass17_0.method_2("nudDelayOpenChromeFrom", 1);
		this.nudDelayOpenChromeTo.Value = this.gclass17_0.method_2("nudDelayOpenChromeTo", 1);
		this.nudDelayCloseChromeFrom.Value = this.gclass17_0.method_2("nudDelayCloseChromeFrom", 0);
		this.nudDelayCloseChromeTo.Value = this.gclass17_0.method_2("nudDelayCloseChromeTo", 0);
		this.cbbColumnChrome.Text = ((this.gclass17_0.method_0("cbbColumnChrome", "") == "") ? "3" : this.gclass17_0.method_0("cbbColumnChrome", ""));
		this.cbbRowChrome.Text = ((this.gclass17_0.method_0("cbbRowChrome", "") == "") ? "2" : this.gclass17_0.method_0("cbbRowChrome", ""));
		int num = this.gclass17_0.method_2("typeBrowser", 0);
		int num2 = num;
		int num3 = num2;
		if (num3 != 0)
		{
			if (num3 == 1)
			{
				this.rbChromium.Checked = true;
			}
		}
		else
		{
			this.rbChrome.Checked = true;
		}
		this.txtLinkToOtherBrowser.Text = this.gclass17_0.method_0("txtLinkToOtherBrowser", "");
		this.ckbUsePortable.Checked = this.gclass17_0.method_3("ckbUsePortable", false);
		this.txtPathToPortableZip.Text = this.gclass17_0.method_0("txtPathToPortableZip", "");
		this.cbbSizeChrome.SelectedValue = this.gclass17_0.method_0("sizeChrome", "default").ToString();
		if (this.cbbSizeChrome.SelectedValue == null)
		{
			this.cbbSizeChrome.SelectedValue = "default";
		}
		switch (this.gclass17_0.method_2("tocDoGoVanBan", 0))
		{
			case 0:
				this.rbTocDoGoCham.Checked = true;
				break;
			case 1:
				this.rbTocDoGoBinhThuong.Checked = true;
				break;
			case 2:
				this.rbTocDoGoNhanh.Checked = true;
				break;
		}
		this.ckbKhongCheckIP.Checked = this.gclass17_0.method_3("ckbKhongCheckIP", false);
		this.nudChangeIpCount.Value = this.gclass17_0.method_2("ip_nudChangeIpCount", 1);
		this.nudDelayCheckIP.Value = this.gclass17_0.method_2("nudDelayCheckIP", 0);
		int num4 = this.gclass17_0.method_2("ip_iTypeChangeIp", 0);
		if (num4 == 0)
		{
			this.rbNone.Checked = true;
		}
		else if (num4 == 1)
		{
			this.rbHma.Checked = true;
		}
		else if (num4 == 2)
		{
			this.rbDcom.Checked = true;
		}
		else if (num4 == 3)
		{
			this.rbSSH.Checked = true;
		}
		else if (num4 == 4)
		{
			this.rbExpressVPN.Checked = true;
		}
		else if (num4 == 5)
		{
			this.rbHotspot.Checked = true;
		}
		else if (num4 == 6)
		{
			this.rbNordVPN.Checked = true;
		}
		else if (num4 == 7)
		{
			this.rbTinsoft.Checked = true;
		}
		else if (num4 == 8)
		{
			this.rbXproxy.Checked = true;
		}
		else if (num4 == 9)
		{
			this.rbProxy.Checked = true;
		}
		else if (num4 == 10)
		{
			this.rbTMProxy.Checked = true;
		}
		else if (num4 == 11)
		{
			this.rbProxyv6.Checked = true;
		}
		else if (num4 == 12)
		{
			this.rbShopLike.Checked = true;
		}
		else if (num4 == 13)
		{
			this.rbMinProxy.Checked = true;
		}
		else if (num4 == 14)
		{
			this.rbObcProxy.Checked = true;
		}
		if (this.gclass17_0.method_2("typeDcom", 0) == 0)
		{
			this.rbDcomThuong.Checked = true;
		}
		else
		{
			this.rbDcomHilink.Checked = true;
		}
		this.txtProfileNameDcom.Text = this.gclass17_0.method_0("ip_txtProfileNameDcom", "");
		this.txtUrlHilink.Text = this.gclass17_0.method_0("txtUrlHilink", "http://192.168.1.1/html/home.html");
		this.txtNordVPN.Text = this.gclass17_0.method_0("ip_txtNordVPN", "");
		this.cbbHostpot.SelectedIndex = this.gclass17_0.method_2("ip_cbbHostpot", 0);
		if (this.gclass17_0.method_2("typeApiTinsoft", 0) == 0)
		{
			this.rbApiUser.Checked = true;
		}
		else
		{
			this.rbApiProxy.Checked = true;
		}
		this.txtApiUser.Text = this.gclass17_0.method_0("txtApiUser", "");
		this.txtApiProxy.Text = this.gclass17_0.method_0("txtApiProxy", "");
		this.cbbLocationTinsoft.SelectedValue = ((this.gclass17_0.method_0("cbbLocationTinsoft", "") == "") ? "0" : this.gclass17_0.method_0("cbbLocationTinsoft", ""));
		this.nudLuongPerIPTinsoft.Value = this.gclass17_0.method_2("nudLuongPerIPTinsoft", 0);
		this.ckbWaitDoneAllTinsoft.Checked = this.gclass17_0.method_3("ckbWaitDoneAllTinsoft", false);
		this.txtServiceURLXProxy.Text = this.gclass17_0.method_0("txtServiceURLXProxy", "");
		int num5 = this.gclass17_0.method_2("typeProxy", 0);
		if (num5 == 0)
		{
			this.rbHttpProxy.Checked = true;
		}
		else
		{
			this.rbSock5Proxy.Checked = true;
		}
		this.txtListProxy.Text = this.gclass17_0.method_0("txtListProxy", "");
		this.nudLuongPerIPXProxy.Value = this.gclass17_0.method_2("nudLuongPerIPXProxy", 0);
		this.nudDelayResetXProxy.Value = this.gclass17_0.method_2("nudDelayResetXProxy", 5);
		this.ckbWaitDoneAllXproxy.Checked = this.gclass17_0.method_3("ckbWaitDoneAllXproxy", false);
		if (this.gclass17_0.method_2("typeRunXproxy", 0) == 0)
		{
			this.rbXproxyResetEachProxy.Checked = true;
		}
		else
		{
			this.rbXproxyResetAllProxy.Checked = true;
		}
		this.txtApiKeyTMProxy.Text = this.gclass17_0.method_0("txtApiKeyTMProxy", "");
		this.nudLuongPerIPTMProxy.Value = this.gclass17_0.method_2("nudLuongPerIPTMProxy", 1);
		this.ckbWaitDoneAllTMProxy.Checked = this.gclass17_0.method_3("ckbWaitDoneAllTMProxy", false);
		this.txtApiProxyv6.Text = this.gclass17_0.method_0("txtApiProxyv6", "");
		this.txtListProxyv6.Text = this.gclass17_0.method_0("txtListProxyv6", "");
		this.nudLuongPerIPProxyv6.Value = this.gclass17_0.method_2("nudLuongPerIPProxyv6", 0);
		this.txtApiShopLike.Text = this.gclass17_0.method_0("txtApiShopLike", "");
		this.nudLuongPerIPShopLike.Value = this.gclass17_0.method_2("nudLuongPerIPShopLike", 0);
		int num6 = this.gclass17_0.method_2("typeMin", 0);
		if (num6 == 0)
		{
			this.rbProxyDong.Checked = true;
		}
		else
		{
			this.rbProxyDanCu.Checked = true;
		}
		int num7 = this.gclass17_0.method_2("typeProxyMin", 0);
		if (num7 == 0)
		{
			this.rbHttpv4.Checked = true;
		}
		else if (num7 == 1)
		{
			this.rbHttpv6.Checked = true;
		}
		else if (num7 == 2)
		{
			this.rbSockv4.Checked = true;
		}
		else
		{
			this.rbSockv6.Checked = true;
		}
		this.txtApiKeyMinProxy.Text = this.gclass17_0.method_0("txtApiKeyMinProxy", "");
		this.nudLuongPerIPMinProxy.Value = this.gclass17_0.method_2("nudLuongPerIPMinProxy", 0);
		this.txtLinkWebObcProxy.Text = this.gclass17_0.method_0("txtLinkWebObcProxy", "");
		this.txtListObcProxy.Text = this.gclass17_0.method_0("txtListObcProxy", "");
		this.nudLuongPerIPObcProxy.Value = this.gclass17_0.method_2("nudLuongPerIPObcProxy", 1);
		if (this.gclass17_0.method_2("typeRunObcProxy", 0) == 0)
		{
			this.rbObcResetTungIP.Checked = true;
		}
		else
		{
			this.rbObcResetDaiIP.Checked = true;
		}
		this.nudDelayCheckIPObcProxy.Value = this.gclass17_0.method_2("nudDelayCheckIPObcProxy", 1);
		if (this.gclass17_0.method_2("typePhanBietMau", 0) == 0)
		{
			this.rbPhanBietMauNen.Checked = true;
		}
		else
		{
			this.rbPhanBietMauChu.Checked = true;
		}
		this.ckbLuuTrangThai.Checked = this.gclass17_0.method_3("ckbLuuTrangThai", false);
		int num8 = this.gclass17_0.method_2("type2Fa", 0);
		if (num8 == 0)
		{
			this.rbServer.Checked = true;
		}
		else
		{
			this.rbClient.Checked = true;
		}
		this.method_3();
		this.method_8();
	}



	// Token: 0x0600116D RID: 4461 RVA: 0x001AAF24 File Offset: 0x001A9124
	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			this.gclass17_0.method_5("nudInteractThread", this.nudInteractThread.Value);
			this.gclass17_0.method_5("nudHideThread", this.nudHideThread.Value);
			this.gclass17_0.method_5("txbPathProfile", this.txbPathProfile.Text);
			this.gclass17_0.method_5("ckbShowImageInteract", this.ckbShowImageInteract.Checked);
			this.gclass17_0.method_5("ckbAddChromeIntoForm", this.ckbAddChromeIntoForm.Checked);
			this.gclass17_0.method_5("nudWidthChrome", this.nudWidthChrome.Value);
			this.gclass17_0.method_5("nudHeighChrome", this.nudHeighChrome.Value);
			this.gclass17_0.method_5("nudDelayOpenChromeFrom", this.nudDelayOpenChromeFrom.Value);
			this.gclass17_0.method_5("nudDelayOpenChromeTo", this.nudDelayOpenChromeTo.Value);
			this.gclass17_0.method_5("nudDelayCloseChromeFrom", this.nudDelayCloseChromeFrom.Value);
			this.gclass17_0.method_5("nudDelayCloseChromeTo", this.nudDelayCloseChromeTo.Value);
			this.gclass17_0.method_5("cbbColumnChrome", this.cbbColumnChrome.Text);
			this.gclass17_0.method_5("cbbRowChrome", this.cbbRowChrome.Text);
			int num = 0;
			if (this.rbChromium.Checked)
			{
				num = 1;
			}
			this.gclass17_0.method_5("typeBrowser", num);
			this.gclass17_0.method_5("txtLinkToOtherBrowser", this.txtLinkToOtherBrowser.Text.Trim());
			this.gclass17_0.method_5("ckbUsePortable", this.ckbUsePortable.Checked);
			this.gclass17_0.method_5("txtPathToPortableZip", this.txtPathToPortableZip.Text.Trim());
			if (num != 0 && this.txtLinkToOtherBrowser.Text.Trim() == "")
			{
				string arg = "";
				switch (num)
				{
					case 1:
						arg = "Chromium";
						break;
					case 2:
						arg = "Cốc cốc";
						break;
					case 3:
						arg = "Slimjet";
						break;
				}
				GClass38.smethod_0(string.Format(GClass29.smethod_0("Vui lòng nhập đường dẫn đến file chạy của trình duyệt {0}!"), arg), 2);
			}
			else
			{
				if (this.cbbSizeChrome.Items.Count > 0 && this.cbbSizeChrome.SelectedValue.ToString() != "")
				{
					this.gclass17_0.method_5("sizeChrome", this.cbbSizeChrome.SelectedValue.ToString());
				}
				if (this.rbTocDoGoCham.Checked)
				{
					this.gclass17_0.method_5("tocDoGoVanBan", 0);
				}
				else if (this.rbTocDoGoBinhThuong.Checked)
				{
					this.gclass17_0.method_5("tocDoGoVanBan", 1);
				}
				else
				{
					this.gclass17_0.method_5("tocDoGoVanBan", 2);
				}
				this.gclass17_0.method_5("ckbKhongCheckIP", this.ckbKhongCheckIP.Checked);
				this.gclass17_0.method_5("ip_nudChangeIpCount", this.nudChangeIpCount.Value);
				this.gclass17_0.method_5("nudDelayCheckIP", this.nudDelayCheckIP.Value);
				int num2 = 0;
				if (this.rbNone.Checked)
				{
					num2 = 0;
				}
				else if (this.rbHma.Checked)
				{
					num2 = 1;
				}
				else if (this.rbDcom.Checked)
				{
					num2 = 2;
				}
				else if (this.rbSSH.Checked)
				{
					num2 = 3;
				}
				else if (this.rbExpressVPN.Checked)
				{
					num2 = 4;
				}
				else if (this.rbHotspot.Checked)
				{
					num2 = 5;
				}
				else if (this.rbNordVPN.Checked)
				{
					num2 = 6;
				}
				else if (this.rbTinsoft.Checked)
				{
					num2 = 7;
				}
				else if (this.rbXproxy.Checked)
				{
					num2 = 8;
				}
				else if (this.rbProxy.Checked)
				{
					num2 = 9;
				}
				else if (this.rbTMProxy.Checked)
				{
					num2 = 10;
				}
				else if (this.rbProxyv6.Checked)
				{
					num2 = 11;
				}
				else if (this.rbShopLike.Checked)
				{
					num2 = 12;
				}
				else if (this.rbMinProxy.Checked)
				{
					num2 = 13;
				}
				else if (this.rbObcProxy.Checked)
				{
					num2 = 14;
				}
				this.gclass17_0.method_5("ip_iTypeChangeIp", num2);
				if (this.rbDcomThuong.Checked)
				{
					this.gclass17_0.method_5("typeDcom", 0);
				}
				else
				{
					this.gclass17_0.method_5("typeDcom", 1);
				}
				this.gclass17_0.method_5("txtUrlHilink", this.txtUrlHilink.Text);
				this.gclass17_0.method_5("ip_txtProfileNameDcom", this.txtProfileNameDcom.Text);
				this.gclass17_0.method_5("ip_txtNordVPN", this.txtNordVPN.Text);
				this.gclass17_0.method_5("ip_cbbHostpot", this.cbbHostpot.SelectedIndex);
				if (this.rbApiUser.Checked)
				{
					this.gclass17_0.method_5("typeApiTinsoft", 0);
				}
				else
				{
					this.gclass17_0.method_5("typeApiTinsoft", 1);
				}
				this.gclass17_0.method_5("txtApiUser", this.txtApiUser.Text);
				this.gclass17_0.method_5("txtApiProxy", this.txtApiProxy.Text);
				this.gclass17_0.method_5("cbbLocationTinsoft", this.cbbLocationTinsoft.SelectedValue);
				this.gclass17_0.method_5("nudLuongPerIPTinsoft", this.nudLuongPerIPTinsoft.Value);
				this.gclass17_0.method_5("ckbWaitDoneAllTinsoft", this.ckbWaitDoneAllTinsoft.Checked);
				this.gclass17_0.method_5("txtServiceURLXProxy", this.txtServiceURLXProxy.Text);
				int num3 = 0;
				if (this.rbSock5Proxy.Checked)
				{
					num3 = 1;
				}
				this.gclass17_0.method_5("typeProxy", num3);
				this.gclass17_0.method_5("txtListProxy", this.txtListProxy.Text);
				this.gclass17_0.method_5("nudLuongPerIPXProxy", this.nudLuongPerIPXProxy.Value);
				this.gclass17_0.method_5("nudDelayResetXProxy", this.nudDelayResetXProxy.Value);
				this.gclass17_0.method_5("ckbWaitDoneAllXproxy", this.ckbWaitDoneAllXproxy.Checked);
				if (this.rbXproxyResetEachProxy.Checked)
				{
					this.gclass17_0.method_5("typeRunXproxy", 0);
				}
				else
				{
					this.gclass17_0.method_5("typeRunXproxy", 1);
				}
				this.gclass17_0.method_5("txtApiKeyTMProxy", this.txtApiKeyTMProxy.Text);
				this.gclass17_0.method_5("nudLuongPerIPTMProxy", this.nudLuongPerIPTMProxy.Value);
				this.gclass17_0.method_5("ckbWaitDoneAllTMProxy", this.ckbWaitDoneAllTMProxy.Checked);
				this.gclass17_0.method_5("txtApiProxyv6", this.txtApiProxyv6.Text);
				this.gclass17_0.method_5("txtListProxyv6", this.txtListProxyv6.Text);
				this.gclass17_0.method_5("nudLuongPerIPProxyv6", this.nudLuongPerIPProxyv6.Value);
				this.gclass17_0.method_5("txtApiShopLike", this.txtApiShopLike.Text);
				this.gclass17_0.method_5("nudLuongPerIPShopLike", this.nudLuongPerIPShopLike.Value);
				int num4 = 0;
				if (this.rbProxyDanCu.Checked)
				{
					num4 = 1;
				}
				this.gclass17_0.method_5("typeMin", num4);
				int num5 = 0;
				if (this.rbHttpv6.Checked)
				{
					num5 = 1;
				}
				else if (this.rbSockv4.Checked)
				{
					num5 = 2;
				}
				else if (this.rbSockv6.Checked)
				{
					num5 = 3;
				}
				this.gclass17_0.method_5("typeProxyMin", num5);
				this.gclass17_0.method_5("txtApiKeyMinProxy", this.txtApiKeyMinProxy.Text);
				this.gclass17_0.method_5("nudLuongPerIPMinProxy", this.nudLuongPerIPMinProxy.Value);
				this.gclass17_0.method_5("txtLinkWebObcProxy", this.txtLinkWebObcProxy.Text);
				this.gclass17_0.method_5("txtListObcProxy", this.txtListObcProxy.Text);
				this.gclass17_0.method_5("nudLuongPerIPObcProxy", this.nudLuongPerIPObcProxy.Value);
				if (this.rbObcResetTungIP.Checked)
				{
					this.gclass17_0.method_5("typeRunObcProxy", 0);
				}
				else
				{
					this.gclass17_0.method_5("typeRunObcProxy", 1);
				}
				this.gclass17_0.method_5("nudDelayCheckIPObcProxy", this.nudDelayCheckIPObcProxy.Value);
				if (this.rbPhanBietMauNen.Checked)
				{
					this.gclass17_0.method_5("typePhanBietMau", 0);
				}
				else
				{
					this.gclass17_0.method_5("typePhanBietMau", 1);
				}
				this.gclass17_0.method_5("ckbLuuTrangThai", this.ckbLuuTrangThai.Checked);
				Class187.bool_0 = this.ckbLuuTrangThai.Checked;
				int num6 = 0;
				if (this.rbClient.Checked)
				{
					num6 = 1;
				}
				this.gclass17_0.method_5("type2Fa", num6);
				this.gclass17_0.method_8("");
				if (GClass38.smethod_1(GClass29.smethod_0("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes)
				{
					base.Close();
				}
			}
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Lỗi!"), 1);
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x001AB9B4 File Offset: 0x001A9BB4
	private void button5_Click(object sender, EventArgs e)
	{
		if (this.gclass17_0.method_2("ip_iTypeChangeIp", 0) == 0)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn loại đổi IP"), 3);
		}
		else if (GClass14.smethod_79(this.gclass17_0.method_2("ip_iTypeChangeIp", 0), this.gclass17_0.method_2("typeDcom", 0), this.gclass17_0.method_0("ip_txtProfileNameDcom", ""), this.gclass17_0.method_0("txtUrlHilink", ""), this.gclass17_0.method_2("ip_cbbHostpot", 0), this.gclass17_0.method_0("ip_txtNordVPN", "")))
		{
			GClass38.smethod_0(GClass29.smethod_0("Đổi IP thành công!"), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Đổi IP thất bại!"), 2);
		}
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00007266 File Offset: 0x00005466
	private void btnSSH_Click(object sender, EventArgs e)
	{
		Process.Start("changeip\\ssh.txt");
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x001ABA88 File Offset: 0x001A9C88
	private void button1_Click(object sender, EventArgs e)
	{
		if (GClass15.smethod_24() == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng cập nhật chromedriver!"), 3);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Phiên bản chromedriver khả dụng!"), 1);
		}
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00007273 File Offset: 0x00005473
	private void rbTinsoft_CheckedChanged(object sender, EventArgs e)
	{
		this.plTinsoft.Enabled = this.rbTinsoft.Checked;
		this.method_13(this.rbTinsoft);
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00007297 File Offset: 0x00005497
	private void radioButton3_CheckedChanged(object sender, EventArgs e)
	{
		this.panel2.Enabled = this.rbNordVPN.Checked;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x001ABAC8 File Offset: 0x001A9CC8
	private void method_3()
	{
		this.rbTinsoft_CheckedChanged(null, null);
		this.radioButton3_CheckedChanged(null, null);
		this.rbDcom_CheckedChanged(null, null);
		this.rbXproxy_CheckedChanged(null, null);
		this.rbHma_CheckedChanged(null, null);
		this.rbChrome_CheckedChanged(null, null);
		this.rbTMProxy_CheckedChanged(null, null);
		this.rbApiUser_CheckedChanged(null, null);
		this.method_9(null, null);
		this.ckbAddChromeIntoForm_CheckedChanged(null, null);
		this.ckbUsePortable_CheckedChanged(null, null);
		this.rbDcomHilink_CheckedChanged(null, null);
		this.rbDcomThuong_CheckedChanged(null, null);
		this.rbProxyv6_CheckedChanged(null, null);
		this.rbShopLike_CheckedChanged(null, null);
		this.rbMinProxy_CheckedChanged(null, null);
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x001ABB58 File Offset: 0x001A9D58
	private void method_4(object sender, EventArgs e)
	{
		string string_ = this.txtApiUser.Text.Trim();
		List<string> list = Class40.smethod_2(string_);
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x000072AF File Offset: 0x000054AF
	private void rbDcom_CheckedChanged(object sender, EventArgs e)
	{
		this.plDcom.Enabled = this.rbDcom.Checked;
		this.method_5();
		this.method_13(this.rbDcom);
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x000072D9 File Offset: 0x000054D9
	private void rbXproxy_CheckedChanged(object sender, EventArgs e)
	{
		this.plXproxy.Enabled = this.rbXproxy.Checked;
		this.method_13(this.rbXproxy);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000072FD File Offset: 0x000054FD
	private void method_5()
	{
		this.plCheckDoiIP.Enabled = (this.rbDcom.Checked || this.rbHma.Checked);
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00007325 File Offset: 0x00005525
	private void rbHma_CheckedChanged(object sender, EventArgs e)
	{
		this.method_5();
		this.method_13(this.rbHma);
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x001ABBBC File Offset: 0x001A9DBC
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
			if (text.Split(new char[]
			{
				'\n'
			}).Length <= 3)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng kết nối Dcom trước!"), 2);
			}
			else
			{
				this.txtProfileNameDcom.Text = text.Split(new char[]
				{
					'\n'
				}).ToList<string>()[1];
				GClass38.smethod_0(GClass29.smethod_0("Lấy tên cấu hình Dcom thành công!"), 1);
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "change ip dcom");
			GClass38.smethod_0(GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x001ABC94 File Offset: 0x001A9E94
	private void method_6()
	{
		if (this.rbChrome.Checked)
		{
			this.plLinkToOtherBrowser.Visible = false;
		}
		else
		{
			this.plLinkToOtherBrowser.Visible = true;
		}
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00007339 File Offset: 0x00005539
	private void rbChrome_CheckedChanged(object sender, EventArgs e)
	{
		this.method_6();
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x001ABCC8 File Offset: 0x001A9EC8
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

	// Token: 0x0600117D RID: 4477 RVA: 0x001ABD00 File Offset: 0x001A9F00
	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			this.btnUp.Visible = true;
			this.btnDown.Visible = true;
		}
		else if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			this.plSizeChrome.Visible = false;
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00007341 File Offset: 0x00005541
	private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
	{
		this.plTMProxy.Enabled = this.rbTMProxy.Checked;
		this.method_13(this.rbTMProxy);
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x001ABD7C File Offset: 0x001A9F7C
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

	// Token: 0x06001180 RID: 4480 RVA: 0x001ABDAC File Offset: 0x001A9FAC
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

	// Token: 0x06001181 RID: 4481 RVA: 0x00007365 File Offset: 0x00005565
	private void method_8()
	{
		this.txtApiProxy_TextChanged(null, null);
		this.txtListProxy_TextChanged(null, null);
		this.txtListObcProxy_TextChanged(null, null);
		this.txtApiKeyMinProxy_TextChanged(null, null);
		this.txtApiKeyTMProxy_TextChanged(null, null);
		this.txtApiShopLike_TextChanged(null, null);
		this.txtListProxyv6_TextChanged(null, null);
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x001ABDDC File Offset: 0x001A9FDC
	private void txtApiProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = this.txtApiProxy.Lines.ToList<string>();
			list = GClass14.smethod_36(list);
			this.lblCountApiProxy.Text = "(" + list.Count.ToString() + ")";
		}
		catch
		{
		}
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x0000739F File Offset: 0x0000559F
	private void rbApiUser_CheckedChanged(object sender, EventArgs e)
	{
		this.plApiUser.Enabled = this.rbApiUser.Checked;
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x000073B7 File Offset: 0x000055B7
	private void method_9(object sender, EventArgs e)
	{
		this.plApiProxy.Enabled = this.rbApiProxy.Checked;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x001ABE40 File Offset: 0x001AA040
	private void method_10(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = this.txtApiProxy.Lines.ToList<string>();
		list2 = GClass14.smethod_36(list2);
		foreach (string text in list2)
		{
			if (Class40.smethod_1(text))
			{
				list.Add(text);
			}
		}
		this.txtApiProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x001ABF04 File Offset: 0x001AA104
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

	// Token: 0x06001187 RID: 4487 RVA: 0x001ABF34 File Offset: 0x001AA134
	private void plXproxy_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			this.ckbWaitDoneAllXproxy.Visible = true;
		}
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x001ABF70 File Offset: 0x001AA170
	private void method_11(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			this.ckbWaitDoneAllTinsoft.Visible = true;
		}
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x001ABFAC File Offset: 0x001AA1AC
	private void plTMProxy_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			this.ckbWaitDoneAllTMProxy.Visible = true;
		}
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000073CF File Offset: 0x000055CF
	private void btnDown_Click(object sender, EventArgs e)
	{
		this.grChrome.Height = 318;
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x000073E1 File Offset: 0x000055E1
	private void btnUp_Click(object sender, EventArgs e)
	{
		this.grChrome.Height = 233;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x001ABFE8 File Offset: 0x001AA1E8
	private void AddFileAccount_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fThemSizeChrome());
		this.method_12();
		GClass17 gclass = new GClass17("configGeneral", false);
		this.cbbSizeChrome.SelectedValue = gclass.method_0("sizeChrome", "default").ToString();
		if (this.cbbSizeChrome.SelectedValue == null)
		{
			this.cbbSizeChrome.SelectedValue = "default";
		}
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x001AC054 File Offset: 0x001AA254
	private void method_12()
	{
		GClass17 gclass = new GClass17("configChrome", false);
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("default", "Mặc định");
		if (gclass.method_0("sizeChrome", "") != "")
		{
			Dictionary<string, object> dictionary2 = GClass17.smethod_0(JObject.Parse(gclass.method_0("sizeChrome", "")));
			foreach (KeyValuePair<string, object> keyValuePair in dictionary2)
			{
				dictionary.Add(keyValuePair.Value.ToString(), keyValuePair.Key + string.Format(" ({0})", keyValuePair.Value));
			}
		}
		this.cbbSizeChrome.DataSource = new BindingSource(dictionary, null);
		this.cbbSizeChrome.ValueMember = "Key";
		this.cbbSizeChrome.DisplayMember = "Value";
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x001AC158 File Offset: 0x001AA358
	private void button8_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = this.txtApiKeyTMProxy.Lines.ToList<string>();
		list2 = GClass14.smethod_36(list2);
		foreach (string text in list2)
		{
			if (Class41.smethod_0(text))
			{
				list.Add(text);
			}
		}
		this.txtApiKeyTMProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x001AC21C File Offset: 0x001AA41C
	private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = this.txtApiKeyTMProxy.Lines.ToList<string>();
			list = GClass14.smethod_36(list);
			this.label24.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x001AC280 File Offset: 0x001AA480
	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = this.txtListProxy.Lines.ToList<string>();
			list = GClass14.smethod_36(list);
			this.label17.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x001AC2E4 File Offset: 0x001AA4E4
	private void txtPathToPortableZip_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			Process.Start(this.txbPathProfile.Text.Trim());
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x000073F3 File Offset: 0x000055F3
	private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
	{
		this.plAddChromeVaoFormView.Enabled = this.ckbAddChromeIntoForm.Checked;
		this.plSapXepCuaSoChrome.Enabled = !this.ckbAddChromeIntoForm.Checked;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00007424 File Offset: 0x00005624
	private void button9_Click(object sender, EventArgs e)
	{
		this.txbPathProfile.Text = GClass14.smethod_40();
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x0000226B File Offset: 0x0000046B
	private void plUsePortable_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00007436 File Offset: 0x00005636
	private void ckbUsePortable_CheckedChanged(object sender, EventArgs e)
	{
		this.lblFileZip.Enabled = this.ckbUsePortable.Checked;
		this.txtPathToPortableZip.Enabled = this.ckbUsePortable.Checked;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x001AC32C File Offset: 0x001AA52C
	private void panel3_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			this.plUsePortable.BringToFront();
		}
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00007464 File Offset: 0x00005664
	private void rbDcomThuong_CheckedChanged(object sender, EventArgs e)
	{
		this.button4.Enabled = this.rbDcomThuong.Checked;
		this.txtProfileNameDcom.Enabled = this.rbDcomThuong.Checked;
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00007492 File Offset: 0x00005692
	private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
	{
		this.label36.Enabled = this.rbDcomHilink.Checked;
		this.txtUrlHilink.Enabled = this.rbDcomHilink.Checked;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x000074C0 File Offset: 0x000056C0
	private void rbNone_CheckedChanged(object sender, EventArgs e)
	{
		this.method_13(this.rbNone);
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x001AC368 File Offset: 0x001AA568
	private void method_13(RadioButton radioButton_0)
	{
		if (radioButton_0 != null && radioButton_0.Checked)
		{
			if (radioButton_0.Name == this.rbDcom.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabDcom;
			}
			else if (radioButton_0.Name == this.rbXproxy.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabXProxy;
			}
			else if (radioButton_0.Name == this.rbTinsoft.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabTinsoft;
			}
			else if (radioButton_0.Name == this.rbTMProxy.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabTMProxy;
			}
			else if (radioButton_0.Name == this.rbObcProxy.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabObcProxy;
			}
			else if (radioButton_0.Name == this.rbProxyv6.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabProxyV6;
			}
			else if (radioButton_0.Name == this.rbShopLike.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabProxyShopLike;
			}
			else if (radioButton_0.Name == this.rbMinProxy.Name)
			{
				this.tabChangeIP.SelectedTab = this.tabMinProxy;
			}
			else
			{
				this.tabChangeIP.SelectedTab = this.tabNone;
			}
		}
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x001AC504 File Offset: 0x001AA704
	private void txtListProxyv6_TextChanged(object sender, EventArgs e)
	{
		List<string> list = this.txtListProxyv6.Lines.ToList<string>();
		list = GClass14.smethod_36(list);
		this.label43.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list.Count.ToString());
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x001AC554 File Offset: 0x001AA754
	private void txtListProxyVitech_TextChanged(object sender, EventArgs e)
	{
		List<string> list = this.txtListProxyVitech.Lines.ToList<string>();
		list = GClass14.smethod_36(list);
		this.label41.Text = string.Format(GClass29.smethod_0("Nhập Proxy ({0}):"), list.Count.ToString());
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000074CE File Offset: 0x000056CE
	private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
	{
		this.plProxyv6.Enabled = this.rbProxyv6.Checked;
		this.method_13(this.rbProxyv6);
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x000074F2 File Offset: 0x000056F2
	private void rbVitech_CheckedChanged(object sender, EventArgs e)
	{
		this.plVitech.Enabled = this.rbVitech.Checked;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x0000750A File Offset: 0x0000570A
	private void rbShopLike_CheckedChanged(object sender, EventArgs e)
	{
		this.plShopLike.Enabled = this.rbShopLike.Checked;
		this.method_13(this.rbShopLike);
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x001AC5A4 File Offset: 0x001AA7A4
	private void txtApiShopLike_TextChanged(object sender, EventArgs e)
	{
		List<string> list = this.txtApiShopLike.Lines.ToList<string>();
		list = GClass14.smethod_36(list);
		this.label47.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list.Count.ToString());
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x0000226B File Offset: 0x0000046B
	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x0000226B File Offset: 0x0000046B
	private void txbPathProfile_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x0000752E File Offset: 0x0000572E
	private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
	{
		this.panel5.Enabled = this.rbMinProxy.Checked;
		this.method_13(this.rbMinProxy);
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x001AC5F4 File Offset: 0x001AA7F4
	private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
	{
		List<string> list = this.txtApiKeyMinProxy.Lines.ToList<string>();
		list = GClass14.smethod_36(list);
		this.label49.Text = string.Format(GClass29.smethod_0("Nhập API KEY ({0}):"), list.Count.ToString());
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x001AC644 File Offset: 0x001AA844
	private void method_14(object sender, EventArgs e)
	{
		if (this.plXproxy.Height == 260)
		{
			this.plXproxy.Height = 170;
			(sender as Button).BackgroundImage = Class306.Bitmap_123;
		}
		else
		{
			this.plXproxy.Height = 260;
			(sender as Button).BackgroundImage = Class306.Bitmap_103;
		}
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x001AC6A8 File Offset: 0x001AA8A8
	private void button10_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = this.txtApiKeyMinProxy.Lines.ToList<string>();
		list2 = GClass14.smethod_36(list2);
		int int_ = 0;
		if (this.rbProxyDanCu.Checked)
		{
			int_ = 1;
		}
		foreach (string text in list2)
		{
			if (Class11.smethod_0(int_, text))
			{
				list.Add(text);
			}
		}
		this.txtApiKeyMinProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x001AC784 File Offset: 0x001AA984
	private void method_15(object sender, EventArgs e)
	{
		Point point = new Point(base.Size.Width, base.Size.Height);
		base.Size = new Size(point.X, point.Y + 386);
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x001AC7D4 File Offset: 0x001AA9D4
	private void method_16(object sender, EventArgs e)
	{
		Point point = new Point(base.Size.Width, base.Size.Height);
		base.Size = new Size(point.X, point.Y - 386);
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x001AC824 File Offset: 0x001AAA24
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

	// Token: 0x060011AA RID: 4522 RVA: 0x00007552 File Offset: 0x00005752
	private void rbProxy_CheckedChanged(object sender, EventArgs e)
	{
		this.method_13(this.rbProxy);
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00007560 File Offset: 0x00005760
	private void rbObcProxy_CheckedChanged(object sender, EventArgs e)
	{
		this.plObcProxy.Enabled = this.rbObcProxy.Checked;
		this.method_13(this.rbObcProxy);
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00007584 File Offset: 0x00005784
	private void txtListObcProxy_TextChanged(object sender, EventArgs e)
	{
		GClass14.smethod_70(this.txtListObcProxy, this.label67);
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x001ABB58 File Offset: 0x001A9D58
	private void button3_Click(object sender, EventArgs e)
	{
		string string_ = this.txtApiUser.Text.Trim();
		List<string> list = Class40.smethod_2(string_);
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x000073B7 File Offset: 0x000055B7
	private void rbApiProxy_CheckedChanged(object sender, EventArgs e)
	{
		this.plApiProxy.Enabled = this.rbApiProxy.Checked;
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x001ABE40 File Offset: 0x001AA040
	private void button7_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = this.txtApiProxy.Lines.ToList<string>();
		list2 = GClass14.smethod_36(list2);
		foreach (string text in list2)
		{
			if (Class40.smethod_1(text))
			{
				list.Add(text);
			}
		}
		this.txtApiProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass38.smethod_0(string.Format(GClass29.smethod_0("Đang có {0} proxy khả dụng!"), list.Count), 1);
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Không có proxy khả dụng!"), 2);
		}
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00007597 File Offset: 0x00005797
	private void rbProxyDanCu_CheckedChanged(object sender, EventArgs e)
	{
		this.plTypeProxy.Enabled = this.rbProxyDanCu.Checked;
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x001AC854 File Offset: 0x001AAA54
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x001AC884 File Offset: 0x001AAA84
	private void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCauHinhChung));
		this.bunifuCards1 = new BunifuCards();
		this.label3 = new Label();
		this.nudInteractThread = new NumericUpDown();
		this.label4 = new Label();
		this.label5 = new Label();
		this.nudHideThread = new NumericUpDown();
		this.label6 = new Label();
		this.label9 = new Label();
		this.txbPathProfile = new TextBox();
		this.panel1 = new Panel();
		this.plVitech = new Panel();
		this.txtListProxyVitech = new RichTextBox();
		this.radioButton9 = new RadioButton();
		this.radioButton10 = new RadioButton();
		this.label40 = new Label();
		this.label41 = new Label();
		this.label42 = new Label();
		this.nudLuongPerIPVitech = new NumericUpDown();
		this.label46 = new Label();
		this.txtApiVitech = new TextBox();
		this.grChrome = new GroupBox();
		this.panel3 = new Panel();
		this.button1 = new Button();
		this.linkLabel2 = new LinkLabel();
		this.plSizeChrome = new Panel();
		this.rbTocDoGoNhanh = new RadioButton();
		this.rbTocDoGoBinhThuong = new RadioButton();
		this.rbTocDoGoCham = new RadioButton();
		this.label30 = new Label();
		this.plSapXepCuaSoChrome = new Panel();
		this.label10 = new Label();
		this.label11 = new Label();
		this.cbbColumnChrome = new ComboBox();
		this.cbbRowChrome = new ComboBox();
		this.plAddChromeVaoFormView = new Panel();
		this.nudWidthChrome = new NumericUpDown();
		this.label35 = new Label();
		this.label33 = new Label();
		this.nudHeighChrome = new NumericUpDown();
		this.AddFileAccount = new MetroButton();
		this.btnDown = new MetroButton();
		this.btnUp = new MetroButton();
		this.nudDelayCloseChromeFrom = new NumericUpDown();
		this.nudDelayCloseChromeTo = new NumericUpDown();
		this.nudDelayOpenChromeFrom = new NumericUpDown();
		this.nudDelayOpenChromeTo = new NumericUpDown();
		this.plLinkToOtherBrowser = new Panel();
		this.label19 = new Label();
		this.txtLinkToOtherBrowser = new TextBox();
		this.rbChromium = new RadioButton();
		this.rbChrome = new RadioButton();
		this.label22 = new Label();
		this.label15 = new Label();
		this.ckbShowImageInteract = new CheckBox();
		this.ckbAddChromeIntoForm = new CheckBox();
		this.label32 = new Label();
		this.cbbSizeChrome = new ComboBox();
		this.label31 = new Label();
		this.label29 = new Label();
		this.label2 = new Label();
		this.label21 = new Label();
		this.label20 = new Label();
		this.label34 = new Label();
		this.button6 = new Button();
		this.plUsePortable = new Panel();
		this.txtPathToPortableZip = new TextBox();
		this.lblFileZip = new Label();
		this.ckbUsePortable = new CheckBox();
		this.cbbHostpot = new ComboBox();
		this.rbVitech = new RadioButton();
		this.bunifuCards2 = new BunifuCards();
		this.pnlHeader = new Panel();
		this.button2 = new Button();
		this.pictureBox1 = new PictureBox();
		this.bunifuCustomLabel1 = new BunifuCustomLabel();
		this.btnCancel = new Button();
		this.panel2 = new Panel();
		this.label12 = new Label();
		this.textBox1 = new TextBox();
		this.btnSave = new Button();
		this.plNordVPN = new Panel();
		this.label14 = new Label();
		this.txtNordVPN = new TextBox();
		this.groupBox1 = new GroupBox();
		this.ckbLuuTrangThai = new CheckBox();
		this.panel6 = new Panel();
		this.rbServer = new RadioButton();
		this.rbClient = new RadioButton();
		this.panel4 = new Panel();
		this.rbPhanBietMauNen = new RadioButton();
		this.rbPhanBietMauChu = new RadioButton();
		this.label57 = new Label();
		this.label23 = new Label();
		this.groupBox2 = new GroupBox();
		this.button9 = new Button();
		this.btnSSH = new Button();
		this.radioButton4 = new RadioButton();
		this.rbHotspot = new RadioButton();
		this.radioButton5 = new RadioButton();
		this.rbNordVPN = new RadioButton();
		this.radioButton2 = new RadioButton();
		this.rbSSH = new RadioButton();
		this.radioButton3 = new RadioButton();
		this.rbExpressVPN = new RadioButton();
		this.groupBox3 = new GroupBox();
		this.tabChangeIP = new TabControl();
		this.tabDcom = new TabPage();
		this.plDcom = new Panel();
		this.button4 = new Button();
		this.txtUrlHilink = new TextBox();
		this.txtProfileNameDcom = new TextBox();
		this.rbDcomHilink = new RadioButton();
		this.label36 = new Label();
		this.rbDcomThuong = new RadioButton();
		this.tabTinsoft = new TabPage();
		this.plTinsoft = new Panel();
		this.ckbWaitDoneAllTinsoft = new CheckBox();
		this.plApiProxy = new Panel();
		this.lblCountApiProxy = new Label();
		this.label28 = new Label();
		this.txtApiProxy = new TextBox();
		this.button7 = new Button();
		this.plApiUser = new Panel();
		this.label1 = new Label();
		this.txtApiUser = new TextBox();
		this.button3 = new Button();
		this.cbbLocationTinsoft = new ComboBox();
		this.rbApiProxy = new RadioButton();
		this.rbApiUser = new RadioButton();
		this.label7 = new Label();
		this.label8 = new Label();
		this.nudLuongPerIPTinsoft = new NumericUpDown();
		this.tabXProxy = new TabPage();
		this.plXproxy = new Panel();
		this.tabObcProxy = new TabPage();
		this.plObcProxy = new Panel();
		this.panel8 = new Panel();
		this.label54 = new Label();
		this.rbObcResetDaiIP = new RadioButton();
		this.rbObcResetTungIP = new RadioButton();
		this.rbObcSock5Proxy = new RadioButton();
		this.rbObcHttpProxy = new RadioButton();
		this.label55 = new Label();
		this.txtListObcProxy = new RichTextBox();
		this.label67 = new Label();
		this.label68 = new Label();
		this.label69 = new Label();
		this.nudLuongPerIPObcProxy = new NumericUpDown();
		this.label70 = new Label();
		this.label71 = new Label();
		this.nudDelayCheckIPObcProxy = new NumericUpDown();
		this.txtLinkWebObcProxy = new TextBox();
		this.tabProxyV6 = new TabPage();
		this.plProxyv6 = new Panel();
		this.txtListProxyv6 = new RichTextBox();
		this.radioButton1 = new RadioButton();
		this.radioButton6 = new RadioButton();
		this.label39 = new Label();
		this.label43 = new Label();
		this.label44 = new Label();
		this.nudLuongPerIPProxyv6 = new NumericUpDown();
		this.label45 = new Label();
		this.txtApiProxyv6 = new TextBox();
		this.tabProxyShopLike = new TabPage();
		this.plShopLike = new Panel();
		this.txtApiShopLike = new RichTextBox();
		this.label47 = new Label();
		this.label48 = new Label();
		this.nudLuongPerIPShopLike = new NumericUpDown();
		this.tabTMProxy = new TabPage();
		this.panel15 = new Panel();
		this.plTMProxy = new Panel();
		this.ckbWaitDoneAllTMProxy = new CheckBox();
		this.txtApiKeyTMProxy = new RichTextBox();
		this.label24 = new Label();
		this.button8 = new Button();
		this.label25 = new Label();
		this.nudLuongPerIPTMProxy = new NumericUpDown();
		this.tabNone = new TabPage();
		this.panel16 = new Panel();
		this.tabMinProxy = new TabPage();
		this.panel5 = new Panel();
		this.plTypeProxy = new Panel();
		this.rbSockv6 = new RadioButton();
		this.rbSockv4 = new RadioButton();
		this.rbHttpv6 = new RadioButton();
		this.rbHttpv4 = new RadioButton();
		this.label56 = new Label();
		this.rbProxyDanCu = new RadioButton();
		this.rbProxyDong = new RadioButton();
		this.button10 = new Button();
		this.txtApiKeyMinProxy = new RichTextBox();
		this.label49 = new Label();
		this.label50 = new Label();
		this.nudLuongPerIPMinProxy = new NumericUpDown();
		this.rbMinProxy = new RadioButton();
		this.rbShopLike = new RadioButton();
		this.rbProxyv6 = new RadioButton();
		this.label37 = new Label();
		this.nudDelayCheckIP = new NumericUpDown();
		this.linkLabel1 = new LinkLabel();
		this.linkLabel3 = new LinkLabel();
		this.label38 = new Label();
		this.plCheckDoiIP = new Panel();
		this.button5 = new Button();
		this.label26 = new Label();
		this.nudChangeIpCount = new NumericUpDown();
		this.label27 = new Label();
		this.rbTMProxy = new RadioButton();
		this.rbDcom = new RadioButton();
		this.rbTinsoft = new RadioButton();
		this.rbProxy = new RadioButton();
		this.rbNone = new RadioButton();
		this.rbObcProxy = new RadioButton();
		this.rbXproxy = new RadioButton();
		this.rbHma = new RadioButton();
		this.ckbKhongCheckIP = new CheckBox();
		this.bunifuDragControl_0 = new BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new ToolTip(this.icontainer_0);
		this.txtServiceURLXProxy = new TextBox();
		this.label13 = new Label();
		this.nudLuongPerIPXProxy = new NumericUpDown();
		this.nudDelayResetXProxy = new NumericUpDown();
		this.label18 = new Label();
		this.label51 = new Label();
		this.label52 = new Label();
		this.label17 = new Label();
		this.label16 = new Label();
		this.rbHttpProxy = new RadioButton();
		this.rbSock5Proxy = new RadioButton();
		this.txtListProxy = new RichTextBox();
		this.ckbWaitDoneAllXproxy = new CheckBox();
		this.rbXproxyResetEachProxy = new RadioButton();
		this.rbXproxyResetAllProxy = new RadioButton();
		this.label53 = new Label();
		this.panel7 = new Panel();
		((ISupportInitialize)this.nudInteractThread).BeginInit();
		((ISupportInitialize)this.nudHideThread).BeginInit();
		this.panel1.SuspendLayout();
		this.plVitech.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPVitech).BeginInit();
		this.grChrome.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plSizeChrome.SuspendLayout();
		this.plSapXepCuaSoChrome.SuspendLayout();
		this.plAddChromeVaoFormView.SuspendLayout();
		((ISupportInitialize)this.nudWidthChrome).BeginInit();
		((ISupportInitialize)this.nudHeighChrome).BeginInit();
		((ISupportInitialize)this.nudDelayCloseChromeFrom).BeginInit();
		((ISupportInitialize)this.nudDelayCloseChromeTo).BeginInit();
		((ISupportInitialize)this.nudDelayOpenChromeFrom).BeginInit();
		((ISupportInitialize)this.nudDelayOpenChromeTo).BeginInit();
		this.plLinkToOtherBrowser.SuspendLayout();
		this.plUsePortable.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((ISupportInitialize)this.pictureBox1).BeginInit();
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
		((ISupportInitialize)this.nudLuongPerIPTinsoft).BeginInit();
		this.tabXProxy.SuspendLayout();
		this.plXproxy.SuspendLayout();
		this.tabObcProxy.SuspendLayout();
		this.plObcProxy.SuspendLayout();
		this.panel8.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPObcProxy).BeginInit();
		((ISupportInitialize)this.nudDelayCheckIPObcProxy).BeginInit();
		this.tabProxyV6.SuspendLayout();
		this.plProxyv6.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPProxyv6).BeginInit();
		this.tabProxyShopLike.SuspendLayout();
		this.plShopLike.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPShopLike).BeginInit();
		this.tabTMProxy.SuspendLayout();
		this.panel15.SuspendLayout();
		this.plTMProxy.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPTMProxy).BeginInit();
		this.tabNone.SuspendLayout();
		this.tabMinProxy.SuspendLayout();
		this.panel5.SuspendLayout();
		this.plTypeProxy.SuspendLayout();
		((ISupportInitialize)this.nudLuongPerIPMinProxy).BeginInit();
		((ISupportInitialize)this.nudDelayCheckIP).BeginInit();
		this.plCheckDoiIP.SuspendLayout();
		((ISupportInitialize)this.nudChangeIpCount).BeginInit();
		((ISupportInitialize)this.nudLuongPerIPXProxy).BeginInit();
		((ISupportInitialize)this.nudDelayResetXProxy).BeginInit();
		this.panel7.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.bunifuCards1.BackColor = Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new Size(575, 38);
		this.bunifuCards1.TabIndex = 12;
		this.label3.AutoSize = true;
		this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label3.Location = new Point(32, 27);
		this.label3.Name = "label3";
		this.label3.Size = new Size(157, 16);
		this.label3.TabIndex = 23;
		this.label3.Text = "Số luồng chạy trình duyệt:";
		this.nudInteractThread.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.nudInteractThread.Location = new Point(207, 25);
		NumericUpDown numericUpDown = this.nudInteractThread;
		int[] array = new int[4];
		array[0] = 1410065407;
		array[1] = 2;
		numericUpDown.Maximum = new decimal(array);
		this.nudInteractThread.Name = "nudInteractThread";
		this.nudInteractThread.Size = new Size(89, 23);
		this.nudInteractThread.TabIndex = 24;
		this.label4.AutoSize = true;
		this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label4.Location = new Point(299, 27);
		this.label4.Name = "label4";
		this.label4.Size = new Size(41, 16);
		this.label4.TabIndex = 25;
		this.label4.Text = "Luồng";
		this.label5.AutoSize = true;
		this.label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label5.Location = new Point(299, 55);
		this.label5.Name = "label5";
		this.label5.Size = new Size(41, 16);
		this.label5.TabIndex = 28;
		this.label5.Text = "Luồng";
		this.nudHideThread.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.nudHideThread.Location = new Point(207, 53);
		NumericUpDown numericUpDown2 = this.nudHideThread;
		int[] array2 = new int[4];
		array2[0] = 1410065407;
		array2[1] = 2;
		numericUpDown2.Maximum = new decimal(array2);
		this.nudHideThread.Name = "nudHideThread";
		this.nudHideThread.Size = new Size(89, 23);
		this.nudHideThread.TabIndex = 27;
		this.label6.AutoSize = true;
		this.label6.Cursor = Cursors.Help;
		this.label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label6.Location = new Point(32, 55);
		this.label6.Name = "label6";
		this.label6.Size = new Size(130, 16);
		this.label6.TabIndex = 26;
		this.label6.Text = "Số luồng chạy ẩn (?):";
		this.toolTip_0.SetToolTip(this.label6, "Là số luồng khi chạy các chức năng không liên quan gì đến trình duyệt.\r\nVí dụ như: Check wall, Check Avatar,...\r\n(Khuyến cáo nên để 10 luồng)");
		this.label9.AutoSize = true;
		this.label9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label9.Location = new Point(32, 84);
		this.label9.Name = "label9";
		this.label9.Size = new Size(152, 16);
		this.label9.TabIndex = 33;
		this.label9.Text = "Đường dẫn folder profile:";
		this.txbPathProfile.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.txbPathProfile.Location = new Point(207, 81);
		this.txbPathProfile.Name = "txbPathProfile";
		this.txbPathProfile.Size = new Size(358, 23);
		this.txbPathProfile.TabIndex = 32;
		this.txbPathProfile.Click += this.txtPathToPortableZip_Click;
		this.txbPathProfile.TextChanged += this.txbPathProfile_TextChanged;
		this.panel1.BorderStyle = BorderStyle.FixedSingle;
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
		this.panel1.Dock = DockStyle.Fill;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(1158, 539);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += this.panel1_Paint;
		this.plVitech.BorderStyle = BorderStyle.FixedSingle;
		this.plVitech.Controls.Add(this.txtListProxyVitech);
		this.plVitech.Controls.Add(this.radioButton9);
		this.plVitech.Controls.Add(this.radioButton10);
		this.plVitech.Controls.Add(this.label40);
		this.plVitech.Controls.Add(this.label41);
		this.plVitech.Controls.Add(this.label42);
		this.plVitech.Controls.Add(this.nudLuongPerIPVitech);
		this.plVitech.Controls.Add(this.label46);
		this.plVitech.Controls.Add(this.txtApiVitech);
		this.plVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plVitech.Location = new Point(11, 909);
		this.plVitech.Name = "plVitech";
		this.plVitech.Size = new Size(266, 170);
		this.plVitech.TabIndex = 151;
		this.plVitech.Visible = false;
		this.txtListProxyVitech.BorderStyle = BorderStyle.FixedSingle;
		this.txtListProxyVitech.Location = new Point(6, 71);
		this.txtListProxyVitech.Name = "txtListProxyVitech";
		this.txtListProxyVitech.Size = new Size(255, 68);
		this.txtListProxyVitech.TabIndex = 144;
		this.txtListProxyVitech.Text = "";
		this.txtListProxyVitech.WordWrap = false;
		this.txtListProxyVitech.TextChanged += this.txtListProxyVitech_TextChanged;
		this.radioButton9.AutoSize = true;
		this.radioButton9.Cursor = Cursors.Hand;
		this.radioButton9.Enabled = false;
		this.radioButton9.Location = new Point(137, 28);
		this.radioButton9.Name = "radioButton9";
		this.radioButton9.Size = new Size(59, 20);
		this.radioButton9.TabIndex = 82;
		this.radioButton9.Text = "Sock5";
		this.radioButton9.UseVisualStyleBackColor = true;
		this.radioButton10.AutoSize = true;
		this.radioButton10.Checked = true;
		this.radioButton10.Cursor = Cursors.Hand;
		this.radioButton10.Location = new Point(74, 28);
		this.radioButton10.Name = "radioButton10";
		this.radioButton10.Size = new Size(48, 20);
		this.radioButton10.TabIndex = 82;
		this.radioButton10.TabStop = true;
		this.radioButton10.Text = "Http";
		this.radioButton10.UseVisualStyleBackColor = true;
		this.label40.AutoSize = true;
		this.label40.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label40.Location = new Point(3, 28);
		this.label40.Name = "label40";
		this.label40.Size = new Size(70, 16);
		this.label40.TabIndex = 79;
		this.label40.Text = "Loại Proxy:";
		this.label41.AutoSize = true;
		this.label41.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label41.Location = new Point(3, 50);
		this.label41.Name = "label41";
		this.label41.Size = new Size(97, 16);
		this.label41.TabIndex = 79;
		this.label41.Text = "Nhập Proxy (0):";
		this.label42.AutoSize = true;
		this.label42.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label42.Location = new Point(5, 143);
		this.label42.Name = "label42";
		this.label42.Size = new Size(78, 16);
		this.label42.TabIndex = 139;
		this.label42.Text = "Số luồng/IP:";
		this.nudLuongPerIPVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPVitech.Location = new Point(90, 142);
		this.nudLuongPerIPVitech.Name = "nudLuongPerIPVitech";
		this.nudLuongPerIPVitech.Size = new Size(67, 23);
		this.nudLuongPerIPVitech.TabIndex = 140;
		NumericUpDown numericUpDown3 = this.nudLuongPerIPVitech;
		int[] array3 = new int[4];
		array3[0] = 1;
		numericUpDown3.Value = new decimal(array3);
		this.label46.AutoSize = true;
		this.label46.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label46.Location = new Point(3, 5);
		this.label46.Name = "label46";
		this.label46.Size = new Size(55, 16);
		this.label46.TabIndex = 79;
		this.label46.Text = "API Key:";
		this.txtApiVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtApiVitech.ForeColor = Color.Black;
		this.txtApiVitech.Location = new Point(74, 2);
		this.txtApiVitech.Name = "txtApiVitech";
		this.txtApiVitech.Size = new Size(187, 23);
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
		this.grChrome.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.grChrome.Location = new Point(7, 156);
		this.grChrome.Name = "grChrome";
		this.grChrome.Size = new Size(568, 233);
		this.grChrome.TabIndex = 38;
		this.grChrome.TabStop = false;
		this.grChrome.Text = "Cấu hình chrome";
		this.panel3.Controls.Add(this.button1);
		this.panel3.Controls.Add(this.linkLabel2);
		this.panel3.Location = new Point(32, 200);
		this.panel3.Name = "panel3";
		this.panel3.Size = new Size(530, 25);
		this.panel3.TabIndex = 156;
		this.panel3.Click += this.panel3_Click;
		this.button1.Cursor = Cursors.Hand;
		this.button1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.button1.ForeColor = Color.Black;
		this.button1.Location = new Point(0, -1);
		this.button1.Name = "button1";
		this.button1.Size = new Size(134, 27);
		this.button1.TabIndex = 143;
		this.button1.Text = "Check Chromedriver";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += this.button1_Click;
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Cursor = Cursors.Hand;
		this.linkLabel2.Location = new Point(191, 4);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new Size(221, 16);
		this.linkLabel2.TabIndex = 147;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Hướng dẫn cập nhật ChromeDriver(?)";
		this.linkLabel2.LinkClicked += this.linkLabel2_LinkClicked;
		this.plSizeChrome.Controls.Add(this.rbTocDoGoNhanh);
		this.plSizeChrome.Controls.Add(this.rbTocDoGoBinhThuong);
		this.plSizeChrome.Controls.Add(this.rbTocDoGoCham);
		this.plSizeChrome.Controls.Add(this.label30);
		this.plSizeChrome.Location = new Point(32, 169);
		this.plSizeChrome.Name = "plSizeChrome";
		this.plSizeChrome.Size = new Size(463, 25);
		this.plSizeChrome.TabIndex = 155;
		this.rbTocDoGoNhanh.AutoSize = true;
		this.rbTocDoGoNhanh.Cursor = Cursors.Hand;
		this.rbTocDoGoNhanh.Location = new Point(378, 2);
		this.rbTocDoGoNhanh.Name = "rbTocDoGoNhanh";
		this.rbTocDoGoNhanh.Size = new Size(61, 20);
		this.rbTocDoGoNhanh.TabIndex = 34;
		this.rbTocDoGoNhanh.Text = "Nhanh";
		this.rbTocDoGoNhanh.UseVisualStyleBackColor = true;
		this.rbTocDoGoBinhThuong.AutoSize = true;
		this.rbTocDoGoBinhThuong.Cursor = Cursors.Hand;
		this.rbTocDoGoBinhThuong.Location = new Point(268, 2);
		this.rbTocDoGoBinhThuong.Name = "rbTocDoGoBinhThuong";
		this.rbTocDoGoBinhThuong.Size = new Size(93, 20);
		this.rbTocDoGoBinhThuong.TabIndex = 34;
		this.rbTocDoGoBinhThuong.Text = "Bình thường";
		this.rbTocDoGoBinhThuong.UseVisualStyleBackColor = true;
		this.rbTocDoGoCham.AutoSize = true;
		this.rbTocDoGoCham.Checked = true;
		this.rbTocDoGoCham.Cursor = Cursors.Hand;
		this.rbTocDoGoCham.Location = new Point(193, 2);
		this.rbTocDoGoCham.Name = "rbTocDoGoCham";
		this.rbTocDoGoCham.Size = new Size(58, 20);
		this.rbTocDoGoCham.TabIndex = 34;
		this.rbTocDoGoCham.TabStop = true;
		this.rbTocDoGoCham.Text = "Chậm";
		this.rbTocDoGoCham.UseVisualStyleBackColor = true;
		this.label30.AutoSize = true;
		this.label30.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label30.Location = new Point(-3, 4);
		this.label30.Name = "label30";
		this.label30.Size = new Size(173, 16);
		this.label30.TabIndex = 33;
		this.label30.Text = "Tùy chỉnh tốc độ gõ văn bản:";
		this.plSapXepCuaSoChrome.Controls.Add(this.label10);
		this.plSapXepCuaSoChrome.Controls.Add(this.label11);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
		this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
		this.plSapXepCuaSoChrome.Location = new Point(26, 77);
		this.plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
		this.plSapXepCuaSoChrome.Size = new Size(358, 29);
		this.plSapXepCuaSoChrome.TabIndex = 157;
		this.label10.AutoSize = true;
		this.label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label10.Location = new Point(3, 5);
		this.label10.Name = "label10";
		this.label10.Size = new Size(147, 16);
		this.label10.TabIndex = 33;
		this.label10.Text = "Sắp xếp cửa sổ chrome:";
		this.label11.AutoSize = true;
		this.label11.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label11.Location = new Point(245, 2);
		this.label11.Name = "label11";
		this.label11.Size = new Size(23, 23);
		this.label11.TabIndex = 33;
		this.label11.Text = "X";
		this.cbbColumnChrome.Cursor = Cursors.Hand;
		this.cbbColumnChrome.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbbColumnChrome.FormattingEnabled = true;
		this.cbbColumnChrome.Items.AddRange(new object[]
		{
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10"
		});
		this.cbbColumnChrome.Location = new Point(200, 2);
		this.cbbColumnChrome.Name = "cbbColumnChrome";
		this.cbbColumnChrome.Size = new Size(41, 24);
		this.cbbColumnChrome.TabIndex = 145;
		this.cbbRowChrome.Cursor = Cursors.Hand;
		this.cbbRowChrome.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbbRowChrome.FormattingEnabled = true;
		this.cbbRowChrome.Items.AddRange(new object[]
		{
			"1",
			"2",
			"3",
			"4",
			"5"
		});
		this.cbbRowChrome.Location = new Point(272, 2);
		this.cbbRowChrome.Name = "cbbRowChrome";
		this.cbbRowChrome.Size = new Size(41, 24);
		this.cbbRowChrome.TabIndex = 145;
		this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
		this.plAddChromeVaoFormView.Controls.Add(this.label35);
		this.plAddChromeVaoFormView.Controls.Add(this.label33);
		this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
		this.plAddChromeVaoFormView.Location = new Point(219, 48);
		this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
		this.plAddChromeVaoFormView.Size = new Size(175, 27);
		this.plAddChromeVaoFormView.TabIndex = 156;
		this.nudWidthChrome.Location = new Point(41, 2);
		NumericUpDown numericUpDown4 = this.nudWidthChrome;
		int[] array4 = new int[4];
		array4[0] = 999999;
		numericUpDown4.Maximum = new decimal(array4);
		NumericUpDown numericUpDown5 = this.nudWidthChrome;
		int[] array5 = new int[4];
		array5[0] = 1;
		numericUpDown5.Minimum = new decimal(array5);
		this.nudWidthChrome.Name = "nudWidthChrome";
		this.nudWidthChrome.Size = new Size(53, 23);
		this.nudWidthChrome.TabIndex = 151;
		NumericUpDown numericUpDown6 = this.nudWidthChrome;
		int[] array6 = new int[4];
		array6[0] = 1;
		numericUpDown6.Value = new decimal(array6);
		this.label35.AutoSize = true;
		this.label35.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label35.Location = new Point(95, 2);
		this.label35.Name = "label35";
		this.label35.Size = new Size(23, 23);
		this.label35.TabIndex = 33;
		this.label35.Text = "X";
		this.label33.AutoSize = true;
		this.label33.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label33.Location = new Point(3, 4);
		this.label33.Name = "label33";
		this.label33.Size = new Size(36, 16);
		this.label33.TabIndex = 33;
		this.label33.Text = "Size:";
		this.nudHeighChrome.Location = new Point(118, 2);
		NumericUpDown numericUpDown7 = this.nudHeighChrome;
		int[] array7 = new int[4];
		array7[0] = 999999;
		numericUpDown7.Maximum = new decimal(array7);
		NumericUpDown numericUpDown8 = this.nudHeighChrome;
		int[] array8 = new int[4];
		array8[0] = 1;
		numericUpDown8.Minimum = new decimal(array8);
		this.nudHeighChrome.Name = "nudHeighChrome";
		this.nudHeighChrome.Size = new Size(53, 23);
		this.nudHeighChrome.TabIndex = 151;
		NumericUpDown numericUpDown9 = this.nudHeighChrome;
		int[] array9 = new int[4];
		array9[0] = 1;
		numericUpDown9.Value = new decimal(array9);
		this.AddFileAccount.BackgroundImage = Class306.Bitmap_172;
		this.AddFileAccount.BackgroundImageLayout = ImageLayout.None;
		this.AddFileAccount.Cursor = Cursors.Hand;
		this.AddFileAccount.Location = new Point(415, 169);
		this.AddFileAccount.Name = "AddFileAccount";
		this.AddFileAccount.Size = new Size(25, 25);
		this.AddFileAccount.TabIndex = 154;
		this.AddFileAccount.UseSelectable = true;
		this.AddFileAccount.Click += this.AddFileAccount_Click;
		this.btnDown.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = Cursors.Hand;
		this.btnDown.Location = new Point(512, 8);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new Size(25, 25);
		this.btnDown.TabIndex = 152;
		this.btnDown.UseSelectable = true;
		this.btnDown.Visible = false;
		this.btnDown.Click += this.btnDown_Click;
		this.btnUp.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = Cursors.Hand;
		this.btnUp.Location = new Point(543, 8);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new Size(25, 25);
		this.btnUp.TabIndex = 153;
		this.btnUp.UseSelectable = true;
		this.btnUp.Visible = false;
		this.btnUp.Click += this.btnUp_Click;
		this.nudDelayCloseChromeFrom.Location = new Point(226, 140);
		NumericUpDown numericUpDown10 = this.nudDelayCloseChromeFrom;
		int[] array10 = new int[4];
		array10[0] = 999999;
		numericUpDown10.Maximum = new decimal(array10);
		this.nudDelayCloseChromeFrom.Name = "nudDelayCloseChromeFrom";
		this.nudDelayCloseChromeFrom.Size = new Size(41, 23);
		this.nudDelayCloseChromeFrom.TabIndex = 151;
		this.nudDelayCloseChromeTo.Location = new Point(298, 140);
		NumericUpDown numericUpDown11 = this.nudDelayCloseChromeTo;
		int[] array11 = new int[4];
		array11[0] = 999999;
		numericUpDown11.Maximum = new decimal(array11);
		this.nudDelayCloseChromeTo.Name = "nudDelayCloseChromeTo";
		this.nudDelayCloseChromeTo.Size = new Size(41, 23);
		this.nudDelayCloseChromeTo.TabIndex = 151;
		this.nudDelayOpenChromeFrom.Location = new Point(226, 111);
		NumericUpDown numericUpDown12 = this.nudDelayOpenChromeFrom;
		int[] array12 = new int[4];
		array12[0] = 999999;
		numericUpDown12.Maximum = new decimal(array12);
		NumericUpDown numericUpDown13 = this.nudDelayOpenChromeFrom;
		int[] array13 = new int[4];
		array13[0] = 1;
		numericUpDown13.Minimum = new decimal(array13);
		this.nudDelayOpenChromeFrom.Name = "nudDelayOpenChromeFrom";
		this.nudDelayOpenChromeFrom.Size = new Size(41, 23);
		this.nudDelayOpenChromeFrom.TabIndex = 151;
		NumericUpDown numericUpDown14 = this.nudDelayOpenChromeFrom;
		int[] array14 = new int[4];
		array14[0] = 1;
		numericUpDown14.Value = new decimal(array14);
		this.nudDelayOpenChromeTo.Location = new Point(298, 111);
		NumericUpDown numericUpDown15 = this.nudDelayOpenChromeTo;
		int[] array15 = new int[4];
		array15[0] = 999999;
		numericUpDown15.Maximum = new decimal(array15);
		NumericUpDown numericUpDown16 = this.nudDelayOpenChromeTo;
		int[] array16 = new int[4];
		array16[0] = 1;
		numericUpDown16.Minimum = new decimal(array16);
		this.nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
		this.nudDelayOpenChromeTo.Size = new Size(41, 23);
		this.nudDelayOpenChromeTo.TabIndex = 151;
		NumericUpDown numericUpDown17 = this.nudDelayOpenChromeTo;
		int[] array17 = new int[4];
		array17[0] = 1;
		numericUpDown17.Value = new decimal(array17);
		this.plLinkToOtherBrowser.Controls.Add(this.label19);
		this.plLinkToOtherBrowser.Controls.Add(this.txtLinkToOtherBrowser);
		this.plLinkToOtherBrowser.Location = new Point(186, 287);
		this.plLinkToOtherBrowser.Name = "plLinkToOtherBrowser";
		this.plLinkToOtherBrowser.Size = new Size(348, 26);
		this.plLinkToOtherBrowser.TabIndex = 150;
		this.label19.AutoSize = true;
		this.label19.Location = new Point(3, 4);
		this.label19.Name = "label19";
		this.label19.Size = new Size(75, 16);
		this.label19.TabIndex = 148;
		this.label19.Text = "Đường dẫn:";
		this.txtLinkToOtherBrowser.Location = new Point(83, 1);
		this.txtLinkToOtherBrowser.Name = "txtLinkToOtherBrowser";
		this.txtLinkToOtherBrowser.Size = new Size(256, 23);
		this.txtLinkToOtherBrowser.TabIndex = 149;
		this.rbChromium.AutoSize = true;
		this.rbChromium.Cursor = Cursors.Hand;
		this.rbChromium.Location = new Point(268, 265);
		this.rbChromium.Name = "rbChromium";
		this.rbChromium.Size = new Size(265, 20);
		this.rbChromium.TabIndex = 147;
		this.rbChromium.Text = "Khác (Chromium, Brave, Cốc cốc, Slimjet)";
		this.rbChromium.UseVisualStyleBackColor = true;
		this.rbChromium.CheckedChanged += this.rbChrome_CheckedChanged;
		this.rbChrome.AutoSize = true;
		this.rbChrome.Checked = true;
		this.rbChrome.Cursor = Cursors.Hand;
		this.rbChrome.Location = new Point(191, 265);
		this.rbChrome.Name = "rbChrome";
		this.rbChrome.Size = new Size(70, 20);
		this.rbChrome.TabIndex = 147;
		this.rbChrome.TabStop = true;
		this.rbChrome.Text = "Chrome";
		this.rbChrome.UseVisualStyleBackColor = true;
		this.rbChrome.CheckedChanged += this.rbChrome_CheckedChanged;
		this.label22.AutoSize = true;
		this.label22.Location = new Point(29, 238);
		this.label22.Name = "label22";
		this.label22.Size = new Size(134, 16);
		this.label22.TabIndex = 146;
		this.label22.Text = "Nhập Extension (.crx):";
		this.label15.AutoSize = true;
		this.label15.Location = new Point(29, 269);
		this.label15.Name = "label15";
		this.label15.Size = new Size(106, 16);
		this.label15.TabIndex = 146;
		this.label15.Text = "Chọn trình duyệt:";
		this.ckbShowImageInteract.AutoSize = true;
		this.ckbShowImageInteract.Cursor = Cursors.Hand;
		this.ckbShowImageInteract.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ckbShowImageInteract.Location = new Point(32, 22);
		this.ckbShowImageInteract.Name = "ckbShowImageInteract";
		this.ckbShowImageInteract.Size = new Size(183, 20);
		this.ckbShowImageInteract.TabIndex = 112;
		this.ckbShowImageInteract.Text = "Hiện ảnh khi mở trình duyệt";
		this.ckbShowImageInteract.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.AutoSize = true;
		this.ckbAddChromeIntoForm.Cursor = Cursors.Hand;
		this.ckbAddChromeIntoForm.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ckbAddChromeIntoForm.Location = new Point(32, 50);
		this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		this.ckbAddChromeIntoForm.Size = new Size(187, 20);
		this.ckbAddChromeIntoForm.TabIndex = 112;
		this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
		this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.CheckedChanged += this.ckbAddChromeIntoForm_CheckedChanged;
		this.label32.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label32.Location = new Point(269, 142);
		this.label32.Name = "label32";
		this.label32.Size = new Size(29, 16);
		this.label32.TabIndex = 33;
		this.label32.Text = "đến";
		this.label32.TextAlign = ContentAlignment.MiddleCenter;
		this.cbbSizeChrome.Cursor = Cursors.Hand;
		this.cbbSizeChrome.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbbSizeChrome.DropDownWidth = 200;
		this.cbbSizeChrome.FormattingEnabled = true;
		this.cbbSizeChrome.Location = new Point(226, 169);
		this.cbbSizeChrome.Name = "cbbSizeChrome";
		this.cbbSizeChrome.Size = new Size(183, 24);
		this.cbbSizeChrome.TabIndex = 145;
		this.label31.AutoSize = true;
		this.label31.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label31.Location = new Point(341, 142);
		this.label31.Name = "label31";
		this.label31.Size = new Size(30, 16);
		this.label31.TabIndex = 33;
		this.label31.Text = "giây";
		this.label29.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label29.Location = new Point(269, 113);
		this.label29.Name = "label29";
		this.label29.Size = new Size(29, 16);
		this.label29.TabIndex = 33;
		this.label29.Text = "đến";
		this.label29.TextAlign = ContentAlignment.MiddleCenter;
		this.label2.AutoSize = true;
		this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label2.Location = new Point(29, 142);
		this.label2.Name = "label2";
		this.label2.Size = new Size(122, 16);
		this.label2.TabIndex = 33;
		this.label2.Text = "Delay đóng chrome:";
		this.label21.AutoSize = true;
		this.label21.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label21.Location = new Point(341, 113);
		this.label21.Name = "label21";
		this.label21.Size = new Size(30, 16);
		this.label21.TabIndex = 33;
		this.label21.Text = "giây";
		this.label20.AutoSize = true;
		this.label20.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label20.Location = new Point(29, 113);
		this.label20.Name = "label20";
		this.label20.Size = new Size(112, 16);
		this.label20.TabIndex = 33;
		this.label20.Text = "Delay mở chrome:";
		this.label34.AutoSize = true;
		this.label34.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label34.Location = new Point(31, 167);
		this.label34.Name = "label34";
		this.label34.Size = new Size(160, 16);
		this.label34.TabIndex = 33;
		this.label34.Text = "Kích thước cửa số chrome:";
		this.button6.Cursor = Cursors.Hand;
		this.button6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.button6.ForeColor = Color.Black;
		this.button6.Location = new Point(190, 233);
		this.button6.Name = "button6";
		this.button6.Size = new Size(63, 27);
		this.button6.TabIndex = 143;
		this.button6.Text = "Nhập";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += this.button6_Click;
		this.plUsePortable.Controls.Add(this.txtPathToPortableZip);
		this.plUsePortable.Controls.Add(this.lblFileZip);
		this.plUsePortable.Controls.Add(this.ckbUsePortable);
		this.plUsePortable.Location = new Point(32, 200);
		this.plUsePortable.Name = "plUsePortable";
		this.plUsePortable.Size = new Size(530, 25);
		this.plUsePortable.TabIndex = 155;
		this.plUsePortable.Paint += this.plUsePortable_Paint;
		this.txtPathToPortableZip.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.txtPathToPortableZip.Location = new Point(194, 1);
		this.txtPathToPortableZip.Name = "txtPathToPortableZip";
		this.txtPathToPortableZip.Size = new Size(333, 23);
		this.txtPathToPortableZip.TabIndex = 32;
		this.txtPathToPortableZip.Click += this.txtPathToPortableZip_Click;
		this.lblFileZip.AutoSize = true;
		this.lblFileZip.Location = new Point(139, 4);
		this.lblFileZip.Name = "lblFileZip";
		this.lblFileZip.Size = new Size(52, 16);
		this.lblFileZip.TabIndex = 113;
		this.lblFileZip.Text = "File zip:";
		this.ckbUsePortable.AutoSize = true;
		this.ckbUsePortable.Cursor = Cursors.Hand;
		this.ckbUsePortable.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ckbUsePortable.Location = new Point(0, 3);
		this.ckbUsePortable.Name = "ckbUsePortable";
		this.ckbUsePortable.Size = new Size(125, 20);
		this.ckbUsePortable.TabIndex = 112;
		this.ckbUsePortable.Text = "Sử dụng Portable";
		this.ckbUsePortable.UseVisualStyleBackColor = true;
		this.ckbUsePortable.CheckedChanged += this.ckbUsePortable_CheckedChanged;
		this.cbbHostpot.Cursor = Cursors.Hand;
		this.cbbHostpot.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbbHostpot.Enabled = false;
		this.cbbHostpot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.cbbHostpot.ForeColor = Color.Black;
		this.cbbHostpot.FormattingEnabled = true;
		this.cbbHostpot.Items.AddRange(new object[]
		{
			"Chỉ trong quốc gia đang chọn",
			"Toàn bộ quốc gia"
		});
		this.cbbHostpot.Location = new Point(1177, 563);
		this.cbbHostpot.Name = "cbbHostpot";
		this.cbbHostpot.Size = new Size(229, 24);
		this.cbbHostpot.TabIndex = 144;
		this.rbVitech.AutoSize = true;
		this.rbVitech.Cursor = Cursors.Hand;
		this.rbVitech.Enabled = false;
		this.rbVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbVitech.Location = new Point(11, 885);
		this.rbVitech.Margin = new Padding(3, 4, 3, 4);
		this.rbVitech.Name = "rbVitech";
		this.rbVitech.Size = new Size(145, 20);
		this.rbVitech.TabIndex = 150;
		this.rbVitech.Text = "VitechCheap(Sắp có)";
		this.rbVitech.UseVisualStyleBackColor = true;
		this.rbVitech.Visible = false;
		this.rbVitech.CheckedChanged += this.rbVitech_CheckedChanged;
		this.bunifuCards2.BackColor = Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.pnlHeader);
		this.bunifuCards2.Dock = DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new Size(1156, 37);
		this.bunifuCards2.TabIndex = 40;
		this.pnlHeader.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
		this.pnlHeader.BackColor = Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = Cursors.SizeAll;
		this.pnlHeader.Location = new Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new Size(1156, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.button2.Cursor = Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = FlatStyle.Flat;
		this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.button2.ForeColor = Color.White;
		this.button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
		this.button2.Location = new Point(1125, 1);
		this.button2.Name = "button2";
		this.button2.Size = new Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += this.btnCancel_Click;
		this.pictureBox1.Cursor = Cursors.Default;
		this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new Size(34, 27);
		this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += this.pictureBox1_Click;
		this.bunifuCustomLabel1.BackColor = Color.Transparent;
		this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = Color.Black;
		this.bunifuCustomLabel1.Location = new Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new Size(1156, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình chung";
		this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.btnCancel.BackColor = Color.Maroon;
		this.btnCancel.Cursor = Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = Color.White;
		this.btnCancel.Location = new Point(580, 497);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(92, 29);
		this.btnCancel.TabIndex = 20;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += this.btnCancel_Click;
		this.panel2.BorderStyle = BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.label12);
		this.panel2.Controls.Add(this.textBox1);
		this.panel2.Enabled = false;
		this.panel2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.panel2.Location = new Point(1176, 475);
		this.panel2.Name = "panel2";
		this.panel2.Size = new Size(232, 30);
		this.panel2.TabIndex = 142;
		this.label12.AutoSize = true;
		this.label12.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label12.Location = new Point(3, 5);
		this.label12.Name = "label12";
		this.label12.Size = new Size(75, 16);
		this.label12.TabIndex = 82;
		this.label12.Text = "Đường dẫn:";
		this.textBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.textBox1.ForeColor = Color.Black;
		this.textBox1.Location = new Point(87, 2);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new Size(142, 23);
		this.textBox1.TabIndex = 83;
		this.btnSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = FlatStyle.Flat;
		this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = Color.White;
		this.btnSave.Location = new Point(480, 497);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new Size(92, 29);
		this.btnSave.TabIndex = 19;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += this.btnSave_Click;
		this.plNordVPN.BorderStyle = BorderStyle.FixedSingle;
		this.plNordVPN.Controls.Add(this.label14);
		this.plNordVPN.Controls.Add(this.txtNordVPN);
		this.plNordVPN.Enabled = false;
		this.plNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plNordVPN.Location = new Point(1176, 475);
		this.plNordVPN.Name = "plNordVPN";
		this.plNordVPN.Size = new Size(232, 30);
		this.plNordVPN.TabIndex = 142;
		this.label14.AutoSize = true;
		this.label14.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label14.Location = new Point(3, 5);
		this.label14.Name = "label14";
		this.label14.Size = new Size(75, 16);
		this.label14.TabIndex = 82;
		this.label14.Text = "Đường dẫn:";
		this.txtNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtNordVPN.ForeColor = Color.Black;
		this.txtNordVPN.Location = new Point(87, 2);
		this.txtNordVPN.Name = "txtNordVPN";
		this.txtNordVPN.Size = new Size(142, 23);
		this.txtNordVPN.TabIndex = 83;
		this.groupBox1.Controls.Add(this.ckbLuuTrangThai);
		this.groupBox1.Controls.Add(this.panel6);
		this.groupBox1.Controls.Add(this.panel4);
		this.groupBox1.Controls.Add(this.label57);
		this.groupBox1.Controls.Add(this.label23);
		this.groupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.groupBox1.Location = new Point(7, 395);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new Size(568, 96);
		this.groupBox1.TabIndex = 38;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình khác";
		this.ckbLuuTrangThai.AutoSize = true;
		this.ckbLuuTrangThai.Cursor = Cursors.Hand;
		this.ckbLuuTrangThai.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ckbLuuTrangThai.Location = new Point(32, 46);
		this.ckbLuuTrangThai.Name = "ckbLuuTrangThai";
		this.ckbLuuTrangThai.Size = new Size(184, 20);
		this.ckbLuuTrangThai.TabIndex = 157;
		this.ckbLuuTrangThai.Text = "Lưu dữ liệu cột [Trạng thái]";
		this.ckbLuuTrangThai.UseVisualStyleBackColor = true;
		this.panel6.Controls.Add(this.rbServer);
		this.panel6.Controls.Add(this.rbClient);
		this.panel6.Location = new Point(253, 66);
		this.panel6.Name = "panel6";
		this.panel6.Size = new Size(156, 24);
		this.panel6.TabIndex = 156;
		this.panel6.Visible = false;
		this.rbServer.AutoSize = true;
		this.rbServer.Checked = true;
		this.rbServer.Cursor = Cursors.Hand;
		this.rbServer.Location = new Point(3, 3);
		this.rbServer.Name = "rbServer";
		this.rbServer.Size = new Size(63, 20);
		this.rbServer.TabIndex = 34;
		this.rbServer.TabStop = true;
		this.rbServer.Text = "Server";
		this.rbServer.UseVisualStyleBackColor = true;
		this.rbClient.AutoSize = true;
		this.rbClient.Cursor = Cursors.Hand;
		this.rbClient.Location = new Point(84, 3);
		this.rbClient.Name = "rbClient";
		this.rbClient.Size = new Size(57, 20);
		this.rbClient.TabIndex = 34;
		this.rbClient.Text = "Client";
		this.rbClient.UseVisualStyleBackColor = true;
		this.panel4.Controls.Add(this.rbPhanBietMauNen);
		this.panel4.Controls.Add(this.rbPhanBietMauChu);
		this.panel4.Location = new Point(253, 18);
		this.panel4.Name = "panel4";
		this.panel4.Size = new Size(309, 24);
		this.panel4.TabIndex = 156;
		this.rbPhanBietMauNen.AutoSize = true;
		this.rbPhanBietMauNen.Checked = true;
		this.rbPhanBietMauNen.Cursor = Cursors.Hand;
		this.rbPhanBietMauNen.Location = new Point(3, 3);
		this.rbPhanBietMauNen.Name = "rbPhanBietMauNen";
		this.rbPhanBietMauNen.Size = new Size(130, 20);
		this.rbPhanBietMauNen.TabIndex = 34;
		this.rbPhanBietMauNen.TabStop = true;
		this.rbPhanBietMauNen.Text = "Đổi màu nền dòng";
		this.rbPhanBietMauNen.UseVisualStyleBackColor = true;
		this.rbPhanBietMauChu.AutoSize = true;
		this.rbPhanBietMauChu.Cursor = Cursors.Hand;
		this.rbPhanBietMauChu.Location = new Point(176, 2);
		this.rbPhanBietMauChu.Name = "rbPhanBietMauChu";
		this.rbPhanBietMauChu.Size = new Size(98, 20);
		this.rbPhanBietMauChu.TabIndex = 34;
		this.rbPhanBietMauChu.Text = "Đổi màu chữ";
		this.rbPhanBietMauChu.UseVisualStyleBackColor = true;
		this.label57.AutoSize = true;
		this.label57.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label57.Location = new Point(32, 70);
		this.label57.Name = "label57";
		this.label57.Size = new Size(57, 16);
		this.label57.TabIndex = 33;
		this.label57.Text = "Lấy 2FA:";
		this.label57.Visible = false;
		this.label23.AutoSize = true;
		this.label23.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label23.Location = new Point(29, 22);
		this.label23.Name = "label23";
		this.label23.Size = new Size(223, 16);
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
		this.groupBox2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.groupBox2.Location = new Point(7, 39);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new Size(568, 111);
		this.groupBox2.TabIndex = 38;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Cấu hình chung";
		this.button9.Cursor = Cursors.Hand;
		this.button9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button9.ForeColor = Color.Black;
		this.button9.Location = new Point(508, 80);
		this.button9.Name = "button9";
		this.button9.Size = new Size(54, 25);
		this.button9.TabIndex = 143;
		this.button9.Text = "Chọn";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += this.button9_Click;
		this.btnSSH.Cursor = Cursors.Hand;
		this.btnSSH.Enabled = false;
		this.btnSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.btnSSH.ForeColor = Color.Black;
		this.btnSSH.Location = new Point(1263, 508);
		this.btnSSH.Margin = new Padding(3, 4, 3, 4);
		this.btnSSH.Name = "btnSSH";
		this.btnSSH.Size = new Size(106, 26);
		this.btnSSH.TabIndex = 130;
		this.btnSSH.Text = "Nhập IP SSH";
		this.btnSSH.UseVisualStyleBackColor = true;
		this.btnSSH.Click += this.btnSSH_Click;
		this.radioButton4.AutoSize = true;
		this.radioButton4.Cursor = Cursors.Hand;
		this.radioButton4.Enabled = false;
		this.radioButton4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.radioButton4.Location = new Point(1162, 426);
		this.radioButton4.Margin = new Padding(3, 4, 3, 4);
		this.radioButton4.Name = "radioButton4";
		this.radioButton4.Size = new Size(130, 20);
		this.radioButton4.TabIndex = 133;
		this.radioButton4.Text = "Đổi IP ExpressVPN";
		this.radioButton4.UseVisualStyleBackColor = true;
		this.rbHotspot.AutoSize = true;
		this.rbHotspot.Enabled = false;
		this.rbHotspot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbHotspot.Location = new Point(1162, 539);
		this.rbHotspot.Margin = new Padding(3, 4, 3, 4);
		this.rbHotspot.Name = "rbHotspot";
		this.rbHotspot.Size = new Size(145, 20);
		this.rbHotspot.TabIndex = 135;
		this.rbHotspot.Text = "Đổi IP Hotspot Shield";
		this.rbHotspot.UseVisualStyleBackColor = true;
		this.radioButton5.AutoSize = true;
		this.radioButton5.Cursor = Cursors.Hand;
		this.radioButton5.Enabled = false;
		this.radioButton5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.radioButton5.Location = new Point(1162, 511);
		this.radioButton5.Margin = new Padding(3, 4, 3, 4);
		this.radioButton5.Name = "radioButton5";
		this.radioButton5.Size = new Size(87, 20);
		this.radioButton5.TabIndex = 132;
		this.radioButton5.Text = "Đổi IP SSH";
		this.radioButton5.UseVisualStyleBackColor = true;
		this.rbNordVPN.AutoSize = true;
		this.rbNordVPN.Enabled = false;
		this.rbNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbNordVPN.Location = new Point(1162, 451);
		this.rbNordVPN.Margin = new Padding(3, 4, 3, 4);
		this.rbNordVPN.Name = "rbNordVPN";
		this.rbNordVPN.Size = new Size(113, 20);
		this.rbNordVPN.TabIndex = 134;
		this.rbNordVPN.Text = "Đổi IP NordVPN";
		this.rbNordVPN.UseVisualStyleBackColor = true;
		this.rbNordVPN.CheckedChanged += this.radioButton3_CheckedChanged;
		this.radioButton2.AutoSize = true;
		this.radioButton2.Cursor = Cursors.Hand;
		this.radioButton2.Enabled = false;
		this.radioButton2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.radioButton2.Location = new Point(1162, 539);
		this.radioButton2.Margin = new Padding(3, 4, 3, 4);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new Size(145, 20);
		this.radioButton2.TabIndex = 135;
		this.radioButton2.Text = "Đổi IP Hotspot Shield";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.rbSSH.AutoSize = true;
		this.rbSSH.Enabled = false;
		this.rbSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbSSH.Location = new Point(1162, 511);
		this.rbSSH.Margin = new Padding(3, 4, 3, 4);
		this.rbSSH.Name = "rbSSH";
		this.rbSSH.Size = new Size(87, 20);
		this.rbSSH.TabIndex = 132;
		this.rbSSH.Text = "Đổi IP SSH";
		this.rbSSH.UseVisualStyleBackColor = true;
		this.radioButton3.AutoSize = true;
		this.radioButton3.Cursor = Cursors.Hand;
		this.radioButton3.Enabled = false;
		this.radioButton3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.radioButton3.Location = new Point(1162, 451);
		this.radioButton3.Margin = new Padding(3, 4, 3, 4);
		this.radioButton3.Name = "radioButton3";
		this.radioButton3.Size = new Size(113, 20);
		this.radioButton3.TabIndex = 134;
		this.radioButton3.Text = "Đổi IP NordVPN";
		this.radioButton3.UseVisualStyleBackColor = true;
		this.radioButton3.CheckedChanged += this.radioButton3_CheckedChanged;
		this.rbExpressVPN.AutoSize = true;
		this.rbExpressVPN.Enabled = false;
		this.rbExpressVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbExpressVPN.Location = new Point(1162, 426);
		this.rbExpressVPN.Margin = new Padding(3, 4, 3, 4);
		this.rbExpressVPN.Name = "rbExpressVPN";
		this.rbExpressVPN.Size = new Size(130, 20);
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
		this.groupBox3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.groupBox3.Location = new Point(580, 38);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new Size(565, 453);
		this.groupBox3.TabIndex = 39;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Cấu hình đổi IP";
		this.tabChangeIP.Alignment = TabAlignment.Bottom;
		this.tabChangeIP.Controls.Add(this.tabDcom);
		this.tabChangeIP.Controls.Add(this.tabTinsoft);
		this.tabChangeIP.Controls.Add(this.tabXProxy);
		this.tabChangeIP.Controls.Add(this.tabObcProxy);
		this.tabChangeIP.Controls.Add(this.tabProxyV6);
		this.tabChangeIP.Controls.Add(this.tabProxyShopLike);
		this.tabChangeIP.Controls.Add(this.tabTMProxy);
		this.tabChangeIP.Controls.Add(this.tabNone);
		this.tabChangeIP.Controls.Add(this.tabMinProxy);
		this.tabChangeIP.Cursor = Cursors.Hand;
		this.tabChangeIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.tabChangeIP.Location = new Point(24, 226);
		this.tabChangeIP.Name = "tabChangeIP";
		this.tabChangeIP.SelectedIndex = 0;
		this.tabChangeIP.Size = new Size(510, 248);
		this.tabChangeIP.TabIndex = 146;
		this.tabDcom.Controls.Add(this.plDcom);
		this.tabDcom.Location = new Point(4, 4);
		this.tabDcom.Name = "tabDcom";
		this.tabDcom.Padding = new Padding(3);
		this.tabDcom.Size = new Size(502, 191);
		this.tabDcom.TabIndex = 0;
		this.tabDcom.Text = "Dcom";
		this.tabDcom.UseVisualStyleBackColor = true;
		this.plDcom.BorderStyle = BorderStyle.FixedSingle;
		this.plDcom.Controls.Add(this.button4);
		this.plDcom.Controls.Add(this.txtUrlHilink);
		this.plDcom.Controls.Add(this.txtProfileNameDcom);
		this.plDcom.Controls.Add(this.rbDcomHilink);
		this.plDcom.Controls.Add(this.label36);
		this.plDcom.Controls.Add(this.rbDcomThuong);
		this.plDcom.Dock = DockStyle.Fill;
		this.plDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plDcom.Location = new Point(3, 3);
		this.plDcom.Name = "plDcom";
		this.plDcom.Size = new Size(496, 185);
		this.plDcom.TabIndex = 131;
		this.button4.Anchor = AnchorStyles.None;
		this.button4.Cursor = Cursors.Hand;
		this.button4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button4.ForeColor = Color.Black;
		this.button4.Location = new Point(313, 63);
		this.button4.Name = "button4";
		this.button4.Size = new Size(93, 25);
		this.button4.TabIndex = 143;
		this.button4.Text = "Lấy tên Dcom";
		this.toolTip_0.SetToolTip(this.button4, "Lấy tên dcom");
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += this.button4_Click;
		this.txtUrlHilink.Anchor = AnchorStyles.None;
		this.txtUrlHilink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtUrlHilink.ForeColor = Color.Black;
		this.txtUrlHilink.Location = new Point(185, 112);
		this.txtUrlHilink.Name = "txtUrlHilink";
		this.txtUrlHilink.Size = new Size(221, 23);
		this.txtUrlHilink.TabIndex = 81;
		this.txtProfileNameDcom.Anchor = AnchorStyles.None;
		this.txtProfileNameDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtProfileNameDcom.ForeColor = Color.Black;
		this.txtProfileNameDcom.Location = new Point(121, 64);
		this.txtProfileNameDcom.Name = "txtProfileNameDcom";
		this.txtProfileNameDcom.Size = new Size(186, 23);
		this.txtProfileNameDcom.TabIndex = 81;
		this.rbDcomHilink.Anchor = AnchorStyles.None;
		this.rbDcomHilink.AutoSize = true;
		this.rbDcomHilink.Cursor = Cursors.Hand;
		this.rbDcomHilink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbDcomHilink.Location = new Point(102, 91);
		this.rbDcomHilink.Margin = new Padding(3, 4, 3, 4);
		this.rbDcomHilink.Name = "rbDcomHilink";
		this.rbDcomHilink.Size = new Size(55, 20);
		this.rbDcomHilink.TabIndex = 136;
		this.rbDcomHilink.Text = "Hilink";
		this.rbDcomHilink.UseVisualStyleBackColor = true;
		this.rbDcomHilink.CheckedChanged += this.rbDcomHilink_CheckedChanged;
		this.label36.Anchor = AnchorStyles.None;
		this.label36.AutoSize = true;
		this.label36.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label36.Location = new Point(118, 115);
		this.label36.Name = "label36";
		this.label36.Size = new Size(64, 16);
		this.label36.TabIndex = 79;
		this.label36.Text = "Link Web:";
		this.rbDcomThuong.Anchor = AnchorStyles.None;
		this.rbDcomThuong.AutoSize = true;
		this.rbDcomThuong.Cursor = Cursors.Hand;
		this.rbDcomThuong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbDcomThuong.Location = new Point(102, 40);
		this.rbDcomThuong.Margin = new Padding(3, 4, 3, 4);
		this.rbDcomThuong.Name = "rbDcomThuong";
		this.rbDcomThuong.Size = new Size(69, 20);
		this.rbDcomThuong.TabIndex = 136;
		this.rbDcomThuong.Text = "Thường";
		this.rbDcomThuong.UseVisualStyleBackColor = true;
		this.rbDcomThuong.CheckedChanged += this.rbDcomThuong_CheckedChanged;
		this.tabTinsoft.Controls.Add(this.plTinsoft);
		this.tabTinsoft.Location = new Point(4, 4);
		this.tabTinsoft.Name = "tabTinsoft";
		this.tabTinsoft.Padding = new Padding(3);
		this.tabTinsoft.Size = new Size(502, 221);
		this.tabTinsoft.TabIndex = 1;
		this.tabTinsoft.Text = "https://tinsoftproxy.com/";
		this.tabTinsoft.UseVisualStyleBackColor = true;
		this.plTinsoft.BorderStyle = BorderStyle.FixedSingle;
		this.plTinsoft.Controls.Add(this.ckbWaitDoneAllTinsoft);
		this.plTinsoft.Controls.Add(this.plApiProxy);
		this.plTinsoft.Controls.Add(this.plApiUser);
		this.plTinsoft.Controls.Add(this.cbbLocationTinsoft);
		this.plTinsoft.Controls.Add(this.rbApiProxy);
		this.plTinsoft.Controls.Add(this.rbApiUser);
		this.plTinsoft.Controls.Add(this.label7);
		this.plTinsoft.Controls.Add(this.label8);
		this.plTinsoft.Controls.Add(this.nudLuongPerIPTinsoft);
		this.plTinsoft.Dock = DockStyle.Fill;
		this.plTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plTinsoft.Location = new Point(3, 3);
		this.plTinsoft.Name = "plTinsoft";
		this.plTinsoft.Size = new Size(496, 215);
		this.plTinsoft.TabIndex = 143;
		this.ckbWaitDoneAllTinsoft.Anchor = AnchorStyles.None;
		this.ckbWaitDoneAllTinsoft.AutoSize = true;
		this.ckbWaitDoneAllTinsoft.Cursor = Cursors.Hand;
		this.ckbWaitDoneAllTinsoft.Location = new Point(233, 27);
		this.ckbWaitDoneAllTinsoft.Name = "ckbWaitDoneAllTinsoft";
		this.ckbWaitDoneAllTinsoft.Size = new Size(128, 20);
		this.ckbWaitDoneAllTinsoft.TabIndex = 145;
		this.ckbWaitDoneAllTinsoft.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllTinsoft.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllTinsoft.Visible = false;
		this.plApiProxy.Anchor = AnchorStyles.None;
		this.plApiProxy.BorderStyle = BorderStyle.FixedSingle;
		this.plApiProxy.Controls.Add(this.lblCountApiProxy);
		this.plApiProxy.Controls.Add(this.label28);
		this.plApiProxy.Controls.Add(this.txtApiProxy);
		this.plApiProxy.Controls.Add(this.button7);
		this.plApiProxy.Location = new Point(107, 101);
		this.plApiProxy.Name = "plApiProxy";
		this.plApiProxy.Size = new Size(301, 58);
		this.plApiProxy.TabIndex = 35;
		this.lblCountApiProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.lblCountApiProxy.Location = new Point(1, 24);
		this.lblCountApiProxy.Name = "lblCountApiProxy";
		this.lblCountApiProxy.Size = new Size(32, 16);
		this.lblCountApiProxy.TabIndex = 82;
		this.lblCountApiProxy.Text = "(0)";
		this.lblCountApiProxy.TextAlign = ContentAlignment.MiddleCenter;
		this.label28.AutoSize = true;
		this.label28.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label28.Location = new Point(1, 5);
		this.label28.Name = "label28";
		this.label28.Size = new Size(31, 16);
		this.label28.TabIndex = 82;
		this.label28.Text = "API:";
		this.txtApiProxy.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.txtApiProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtApiProxy.ForeColor = Color.Black;
		this.txtApiProxy.Location = new Point(35, 2);
		this.txtApiProxy.Multiline = true;
		this.txtApiProxy.Name = "txtApiProxy";
		this.txtApiProxy.Size = new Size(209, 51);
		this.txtApiProxy.TabIndex = 83;
		this.txtApiProxy.WordWrap = false;
		this.txtApiProxy.TextChanged += this.txtApiProxy_TextChanged;
		this.button7.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.button7.Cursor = Cursors.Hand;
		this.button7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button7.ForeColor = Color.Black;
		this.button7.Location = new Point(247, 1);
		this.button7.Name = "button7";
		this.button7.Size = new Size(52, 27);
		this.button7.TabIndex = 143;
		this.button7.Text = "Check";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += this.button7_Click;
		this.plApiUser.Anchor = AnchorStyles.None;
		this.plApiUser.BorderStyle = BorderStyle.FixedSingle;
		this.plApiUser.Controls.Add(this.label1);
		this.plApiUser.Controls.Add(this.txtApiUser);
		this.plApiUser.Controls.Add(this.button3);
		this.plApiUser.Location = new Point(107, 48);
		this.plApiUser.Name = "plApiUser";
		this.plApiUser.Size = new Size(301, 29);
		this.plApiUser.TabIndex = 35;
		this.label1.AutoSize = true;
		this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label1.Location = new Point(1, 5);
		this.label1.Name = "label1";
		this.label1.Size = new Size(31, 16);
		this.label1.TabIndex = 82;
		this.label1.Text = "API:";
		this.txtApiUser.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.txtApiUser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtApiUser.ForeColor = Color.Black;
		this.txtApiUser.Location = new Point(35, 2);
		this.txtApiUser.Name = "txtApiUser";
		this.txtApiUser.Size = new Size(209, 23);
		this.txtApiUser.TabIndex = 83;
		this.button3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.button3.Cursor = Cursors.Hand;
		this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button3.ForeColor = Color.Black;
		this.button3.Location = new Point(247, 0);
		this.button3.Name = "button3";
		this.button3.Size = new Size(52, 27);
		this.button3.TabIndex = 143;
		this.button3.Text = "Check";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += this.button3_Click;
		this.cbbLocationTinsoft.Anchor = AnchorStyles.None;
		this.cbbLocationTinsoft.Cursor = Cursors.Hand;
		this.cbbLocationTinsoft.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbbLocationTinsoft.DropDownWidth = 120;
		this.cbbLocationTinsoft.FormattingEnabled = true;
		this.cbbLocationTinsoft.Location = new Point(162, 163);
		this.cbbLocationTinsoft.Name = "cbbLocationTinsoft";
		this.cbbLocationTinsoft.Size = new Size(112, 24);
		this.cbbLocationTinsoft.TabIndex = 84;
		this.rbApiProxy.Anchor = AnchorStyles.None;
		this.rbApiProxy.AutoSize = true;
		this.rbApiProxy.Cursor = Cursors.Hand;
		this.rbApiProxy.Location = new Point(104, 80);
		this.rbApiProxy.Name = "rbApiProxy";
		this.rbApiProxy.Size = new Size(135, 20);
		this.rbApiProxy.TabIndex = 34;
		this.rbApiProxy.Text = "Sử dụng Api Proxy:";
		this.rbApiProxy.UseVisualStyleBackColor = true;
		this.rbApiProxy.CheckedChanged += this.rbApiProxy_CheckedChanged;
		this.rbApiUser.Anchor = AnchorStyles.None;
		this.rbApiUser.AutoSize = true;
		this.rbApiUser.Checked = true;
		this.rbApiUser.Cursor = Cursors.Hand;
		this.rbApiUser.Location = new Point(104, 27);
		this.rbApiUser.Name = "rbApiUser";
		this.rbApiUser.Size = new Size(130, 20);
		this.rbApiUser.TabIndex = 34;
		this.rbApiUser.TabStop = true;
		this.rbApiUser.Text = "Sử dụng Api User:";
		this.rbApiUser.UseVisualStyleBackColor = true;
		this.rbApiUser.CheckedChanged += this.rbApiUser_CheckedChanged;
		this.label7.Anchor = AnchorStyles.None;
		this.label7.AutoSize = true;
		this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label7.Location = new Point(104, 166);
		this.label7.Name = "label7";
		this.label7.Size = new Size(59, 16);
		this.label7.TabIndex = 82;
		this.label7.Text = "Location:";
		this.label8.Anchor = AnchorStyles.None;
		this.label8.AutoSize = true;
		this.label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label8.Location = new Point(280, 166);
		this.label8.Name = "label8";
		this.label8.Size = new Size(78, 16);
		this.label8.TabIndex = 139;
		this.label8.Text = "Số luồng/IP:";
		this.toolTip_0.SetToolTip(this.label8, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
		this.nudLuongPerIPTinsoft.Anchor = AnchorStyles.None;
		this.nudLuongPerIPTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPTinsoft.Location = new Point(362, 164);
		this.nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
		this.nudLuongPerIPTinsoft.Size = new Size(46, 23);
		this.nudLuongPerIPTinsoft.TabIndex = 140;
		NumericUpDown numericUpDown18 = this.nudLuongPerIPTinsoft;
		int[] array18 = new int[4];
		array18[0] = 1;
		numericUpDown18.Value = new decimal(array18);
		this.tabXProxy.Controls.Add(this.plXproxy);
		this.tabXProxy.Location = new Point(4, 4);
		this.tabXProxy.Name = "tabXProxy";
		this.tabXProxy.Padding = new Padding(3);
		this.tabXProxy.Size = new Size(502, 219);
		this.tabXProxy.TabIndex = 2;
		this.tabXProxy.Text = "Xproxy, Mobi, Eager, S Proxy";
		this.tabXProxy.UseVisualStyleBackColor = true;
		this.plXproxy.BorderStyle = BorderStyle.FixedSingle;
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
		this.plXproxy.Dock = DockStyle.Fill;
		this.plXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plXproxy.Location = new Point(3, 3);
		this.plXproxy.Name = "plXproxy";
		this.plXproxy.Size = new Size(496, 213);
		this.plXproxy.TabIndex = 142;
		this.plXproxy.Click += this.plXproxy_Click;
		this.tabObcProxy.Controls.Add(this.plObcProxy);
		this.tabObcProxy.Location = new Point(4, 4);
		this.tabObcProxy.Name = "tabObcProxy";
		this.tabObcProxy.Padding = new Padding(3);
		this.tabObcProxy.Size = new Size(502, 221);
		this.tabObcProxy.TabIndex = 3;
		this.tabObcProxy.Text = "OBC Proxy";
		this.tabObcProxy.UseVisualStyleBackColor = true;
		this.plObcProxy.BorderStyle = BorderStyle.FixedSingle;
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
		this.plObcProxy.Dock = DockStyle.Fill;
		this.plObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plObcProxy.Location = new Point(3, 3);
		this.plObcProxy.Name = "plObcProxy";
		this.plObcProxy.Size = new Size(496, 215);
		this.plObcProxy.TabIndex = 142;
		this.panel8.Anchor = AnchorStyles.None;
		this.panel8.Controls.Add(this.label54);
		this.panel8.Controls.Add(this.rbObcResetDaiIP);
		this.panel8.Controls.Add(this.rbObcResetTungIP);
		this.panel8.Location = new Point(260, 98);
		this.panel8.Name = "panel8";
		this.panel8.Size = new Size(223, 48);
		this.panel8.TabIndex = 156;
		this.label54.AutoSize = true;
		this.label54.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label54.Location = new Point(1, 4);
		this.label54.Name = "label54";
		this.label54.Size = new Size(82, 16);
		this.label54.TabIndex = 155;
		this.label54.Text = "Chế độ chạy:";
		this.rbObcResetDaiIP.AutoSize = true;
		this.rbObcResetDaiIP.Cursor = Cursors.Hand;
		this.rbObcResetDaiIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbObcResetDaiIP.Location = new Point(90, 25);
		this.rbObcResetDaiIP.Margin = new Padding(3, 4, 3, 4);
		this.rbObcResetDaiIP.Name = "rbObcResetDaiIP";
		this.rbObcResetDaiIP.Size = new Size(110, 20);
		this.rbObcResetDaiIP.TabIndex = 153;
		this.rbObcResetDaiIP.Text = "Reset cả dải IP";
		this.rbObcResetDaiIP.UseVisualStyleBackColor = true;
		this.rbObcResetTungIP.AutoSize = true;
		this.rbObcResetTungIP.Checked = true;
		this.rbObcResetTungIP.Cursor = Cursors.Hand;
		this.rbObcResetTungIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbObcResetTungIP.Location = new Point(90, 2);
		this.rbObcResetTungIP.Margin = new Padding(3, 4, 3, 4);
		this.rbObcResetTungIP.Name = "rbObcResetTungIP";
		this.rbObcResetTungIP.Size = new Size(102, 20);
		this.rbObcResetTungIP.TabIndex = 154;
		this.rbObcResetTungIP.TabStop = true;
		this.rbObcResetTungIP.Text = "Reset từng IP";
		this.rbObcResetTungIP.UseVisualStyleBackColor = true;
		this.rbObcSock5Proxy.Anchor = AnchorStyles.None;
		this.rbObcSock5Proxy.AutoSize = true;
		this.rbObcSock5Proxy.Cursor = Cursors.Hand;
		this.rbObcSock5Proxy.Enabled = false;
		this.rbObcSock5Proxy.Location = new Point(175, 35);
		this.rbObcSock5Proxy.Name = "rbObcSock5Proxy";
		this.rbObcSock5Proxy.Size = new Size(59, 20);
		this.rbObcSock5Proxy.TabIndex = 154;
		this.rbObcSock5Proxy.Text = "Sock5";
		this.rbObcSock5Proxy.UseVisualStyleBackColor = true;
		this.rbObcHttpProxy.Anchor = AnchorStyles.None;
		this.rbObcHttpProxy.AutoSize = true;
		this.rbObcHttpProxy.Checked = true;
		this.rbObcHttpProxy.Cursor = Cursors.Hand;
		this.rbObcHttpProxy.Location = new Point(112, 35);
		this.rbObcHttpProxy.Name = "rbObcHttpProxy";
		this.rbObcHttpProxy.Size = new Size(48, 20);
		this.rbObcHttpProxy.TabIndex = 155;
		this.rbObcHttpProxy.TabStop = true;
		this.rbObcHttpProxy.Text = "Http";
		this.rbObcHttpProxy.UseVisualStyleBackColor = true;
		this.label55.Anchor = AnchorStyles.None;
		this.label55.AutoSize = true;
		this.label55.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label55.Location = new Point(25, 35);
		this.label55.Name = "label55";
		this.label55.Size = new Size(70, 16);
		this.label55.TabIndex = 153;
		this.label55.Text = "Loại Proxy:";
		this.txtListObcProxy.Anchor = AnchorStyles.None;
		this.txtListObcProxy.BorderStyle = BorderStyle.FixedSingle;
		this.txtListObcProxy.Location = new Point(28, 75);
		this.txtListObcProxy.Name = "txtListObcProxy";
		this.txtListObcProxy.Size = new Size(229, 109);
		this.txtListObcProxy.TabIndex = 144;
		this.txtListObcProxy.Text = "";
		this.txtListObcProxy.WordWrap = false;
		this.txtListObcProxy.TextChanged += this.txtListObcProxy_TextChanged;
		this.label67.Anchor = AnchorStyles.None;
		this.label67.AutoSize = true;
		this.label67.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label67.Location = new Point(25, 56);
		this.label67.Name = "label67";
		this.label67.Size = new Size(97, 16);
		this.label67.TabIndex = 79;
		this.label67.Text = "Nhập Proxy (0):";
		this.label68.Anchor = AnchorStyles.None;
		this.label68.AutoSize = true;
		this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label68.Location = new Point(442, 149);
		this.label68.Name = "label68";
		this.label68.Size = new Size(32, 16);
		this.label68.TabIndex = 139;
		this.label68.Text = "phút";
		this.label69.Anchor = AnchorStyles.None;
		this.label69.AutoSize = true;
		this.label69.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label69.Location = new Point(263, 75);
		this.label69.Name = "label69";
		this.label69.Size = new Size(78, 16);
		this.label69.TabIndex = 139;
		this.label69.Text = "Số luồng/IP:";
		this.nudLuongPerIPObcProxy.Anchor = AnchorStyles.None;
		this.nudLuongPerIPObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPObcProxy.Location = new Point(348, 74);
		this.nudLuongPerIPObcProxy.Name = "nudLuongPerIPObcProxy";
		this.nudLuongPerIPObcProxy.Size = new Size(67, 23);
		this.nudLuongPerIPObcProxy.TabIndex = 140;
		NumericUpDown numericUpDown19 = this.nudLuongPerIPObcProxy;
		int[] array19 = new int[4];
		array19[0] = 1;
		numericUpDown19.Value = new decimal(array19);
		this.label70.Anchor = AnchorStyles.None;
		this.label70.AutoSize = true;
		this.label70.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label70.Location = new Point(263, 149);
		this.label70.Name = "label70";
		this.label70.Size = new Size(123, 16);
		this.label70.TabIndex = 139;
		this.label70.Text = "Chờ Check IP tối đa:";
		this.label71.Anchor = AnchorStyles.None;
		this.label71.AutoSize = true;
		this.label71.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label71.Location = new Point(25, 13);
		this.label71.Name = "label71";
		this.label71.Size = new Size(64, 16);
		this.label71.TabIndex = 79;
		this.label71.Text = "Link Web:";
		this.nudDelayCheckIPObcProxy.Anchor = AnchorStyles.None;
		this.nudDelayCheckIPObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudDelayCheckIPObcProxy.Location = new Point(389, 147);
		this.nudDelayCheckIPObcProxy.Name = "nudDelayCheckIPObcProxy";
		this.nudDelayCheckIPObcProxy.Size = new Size(50, 23);
		this.nudDelayCheckIPObcProxy.TabIndex = 140;
		NumericUpDown numericUpDown20 = this.nudDelayCheckIPObcProxy;
		int[] array20 = new int[4];
		array20[0] = 1;
		numericUpDown20.Value = new decimal(array20);
		this.txtLinkWebObcProxy.Anchor = AnchorStyles.None;
		this.txtLinkWebObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtLinkWebObcProxy.ForeColor = Color.Black;
		this.txtLinkWebObcProxy.Location = new Point(112, 10);
		this.txtLinkWebObcProxy.Name = "txtLinkWebObcProxy";
		this.txtLinkWebObcProxy.Size = new Size(363, 23);
		this.txtLinkWebObcProxy.TabIndex = 81;
		this.tabProxyV6.Controls.Add(this.plProxyv6);
		this.tabProxyV6.Location = new Point(4, 4);
		this.tabProxyV6.Name = "tabProxyV6";
		this.tabProxyV6.Padding = new Padding(3);
		this.tabProxyV6.Size = new Size(502, 221);
		this.tabProxyV6.TabIndex = 4;
		this.tabProxyV6.Text = "https://proxyv6.net/vi";
		this.tabProxyV6.UseVisualStyleBackColor = true;
		this.plProxyv6.BorderStyle = BorderStyle.FixedSingle;
		this.plProxyv6.Controls.Add(this.txtListProxyv6);
		this.plProxyv6.Controls.Add(this.radioButton1);
		this.plProxyv6.Controls.Add(this.radioButton6);
		this.plProxyv6.Controls.Add(this.label39);
		this.plProxyv6.Controls.Add(this.label43);
		this.plProxyv6.Controls.Add(this.label44);
		this.plProxyv6.Controls.Add(this.nudLuongPerIPProxyv6);
		this.plProxyv6.Controls.Add(this.label45);
		this.plProxyv6.Controls.Add(this.txtApiProxyv6);
		this.plProxyv6.Dock = DockStyle.Fill;
		this.plProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plProxyv6.Location = new Point(3, 3);
		this.plProxyv6.Name = "plProxyv6";
		this.plProxyv6.Size = new Size(496, 215);
		this.plProxyv6.TabIndex = 151;
		this.txtListProxyv6.Anchor = AnchorStyles.None;
		this.txtListProxyv6.BorderStyle = BorderStyle.FixedSingle;
		this.txtListProxyv6.Location = new Point(100, 85);
		this.txtListProxyv6.Name = "txtListProxyv6";
		this.txtListProxyv6.Size = new Size(305, 96);
		this.txtListProxyv6.TabIndex = 144;
		this.txtListProxyv6.Text = "";
		this.txtListProxyv6.WordWrap = false;
		this.txtListProxyv6.TextChanged += this.txtListProxyv6_TextChanged;
		this.radioButton1.Anchor = AnchorStyles.None;
		this.radioButton1.AutoSize = true;
		this.radioButton1.Cursor = Cursors.Hand;
		this.radioButton1.Enabled = false;
		this.radioButton1.Location = new Point(232, 44);
		this.radioButton1.Name = "radioButton1";
		this.radioButton1.Size = new Size(59, 20);
		this.radioButton1.TabIndex = 82;
		this.radioButton1.Text = "Sock5";
		this.radioButton1.UseVisualStyleBackColor = true;
		this.radioButton6.Anchor = AnchorStyles.None;
		this.radioButton6.AutoSize = true;
		this.radioButton6.Checked = true;
		this.radioButton6.Cursor = Cursors.Hand;
		this.radioButton6.Location = new Point(169, 44);
		this.radioButton6.Name = "radioButton6";
		this.radioButton6.Size = new Size(48, 20);
		this.radioButton6.TabIndex = 82;
		this.radioButton6.TabStop = true;
		this.radioButton6.Text = "Http";
		this.radioButton6.UseVisualStyleBackColor = true;
		this.label39.Anchor = AnchorStyles.None;
		this.label39.AutoSize = true;
		this.label39.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label39.Location = new Point(97, 44);
		this.label39.Name = "label39";
		this.label39.Size = new Size(70, 16);
		this.label39.TabIndex = 79;
		this.label39.Text = "Loại Proxy:";
		this.label43.Anchor = AnchorStyles.None;
		this.label43.AutoSize = true;
		this.label43.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label43.Location = new Point(97, 66);
		this.label43.Name = "label43";
		this.label43.Size = new Size(97, 16);
		this.label43.TabIndex = 79;
		this.label43.Text = "Nhập Proxy (0):";
		this.label44.Anchor = AnchorStyles.None;
		this.label44.AutoSize = true;
		this.label44.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label44.Location = new Point(99, 185);
		this.label44.Name = "label44";
		this.label44.Size = new Size(78, 16);
		this.label44.TabIndex = 139;
		this.label44.Text = "Số luồng/IP:";
		this.nudLuongPerIPProxyv6.Anchor = AnchorStyles.None;
		this.nudLuongPerIPProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPProxyv6.Location = new Point(184, 184);
		this.nudLuongPerIPProxyv6.Name = "nudLuongPerIPProxyv6";
		this.nudLuongPerIPProxyv6.Size = new Size(67, 23);
		this.nudLuongPerIPProxyv6.TabIndex = 140;
		NumericUpDown numericUpDown21 = this.nudLuongPerIPProxyv6;
		int[] array21 = new int[4];
		array21[0] = 1;
		numericUpDown21.Value = new decimal(array21);
		this.label45.Anchor = AnchorStyles.None;
		this.label45.AutoSize = true;
		this.label45.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label45.Location = new Point(97, 23);
		this.label45.Name = "label45";
		this.label45.Size = new Size(55, 16);
		this.label45.TabIndex = 79;
		this.label45.Text = "API Key:";
		this.txtApiProxyv6.Anchor = AnchorStyles.None;
		this.txtApiProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtApiProxyv6.ForeColor = Color.Black;
		this.txtApiProxyv6.Location = new Point(169, 20);
		this.txtApiProxyv6.Name = "txtApiProxyv6";
		this.txtApiProxyv6.Size = new Size(236, 23);
		this.txtApiProxyv6.TabIndex = 81;
		this.tabProxyShopLike.Controls.Add(this.plShopLike);
		this.tabProxyShopLike.Location = new Point(4, 4);
		this.tabProxyShopLike.Name = "tabProxyShopLike";
		this.tabProxyShopLike.Padding = new Padding(3);
		this.tabProxyShopLike.Size = new Size(502, 221);
		this.tabProxyShopLike.TabIndex = 5;
		this.tabProxyShopLike.Text = "http://proxy.shoplike.vn/";
		this.tabProxyShopLike.UseVisualStyleBackColor = true;
		this.plShopLike.BorderStyle = BorderStyle.FixedSingle;
		this.plShopLike.Controls.Add(this.txtApiShopLike);
		this.plShopLike.Controls.Add(this.label47);
		this.plShopLike.Controls.Add(this.label48);
		this.plShopLike.Controls.Add(this.nudLuongPerIPShopLike);
		this.plShopLike.Dock = DockStyle.Fill;
		this.plShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plShopLike.Location = new Point(3, 3);
		this.plShopLike.Name = "plShopLike";
		this.plShopLike.Size = new Size(496, 215);
		this.plShopLike.TabIndex = 153;
		this.txtApiShopLike.Anchor = AnchorStyles.None;
		this.txtApiShopLike.BorderStyle = BorderStyle.FixedSingle;
		this.txtApiShopLike.Location = new Point(100, 43);
		this.txtApiShopLike.Name = "txtApiShopLike";
		this.txtApiShopLike.Size = new Size(308, 124);
		this.txtApiShopLike.TabIndex = 144;
		this.txtApiShopLike.Text = "";
		this.txtApiShopLike.WordWrap = false;
		this.txtApiShopLike.TextChanged += this.txtApiShopLike_TextChanged;
		this.label47.Anchor = AnchorStyles.None;
		this.label47.AutoSize = true;
		this.label47.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label47.Location = new Point(97, 24);
		this.label47.Name = "label47";
		this.label47.Size = new Size(110, 16);
		this.label47.TabIndex = 79;
		this.label47.Text = "Nhập API KEY (0):";
		this.label48.Anchor = AnchorStyles.None;
		this.label48.AutoSize = true;
		this.label48.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label48.Location = new Point(97, 173);
		this.label48.Name = "label48";
		this.label48.Size = new Size(78, 16);
		this.label48.TabIndex = 139;
		this.label48.Text = "Số luồng/IP:";
		this.nudLuongPerIPShopLike.Anchor = AnchorStyles.None;
		this.nudLuongPerIPShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPShopLike.Location = new Point(182, 170);
		this.nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
		this.nudLuongPerIPShopLike.Size = new Size(67, 23);
		this.nudLuongPerIPShopLike.TabIndex = 140;
		NumericUpDown numericUpDown22 = this.nudLuongPerIPShopLike;
		int[] array22 = new int[4];
		array22[0] = 1;
		numericUpDown22.Value = new decimal(array22);
		this.tabTMProxy.Controls.Add(this.panel15);
		this.tabTMProxy.Location = new Point(4, 4);
		this.tabTMProxy.Name = "tabTMProxy";
		this.tabTMProxy.Padding = new Padding(3);
		this.tabTMProxy.Size = new Size(502, 221);
		this.tabTMProxy.TabIndex = 6;
		this.tabTMProxy.Text = "https://tmproxy.com/";
		this.tabTMProxy.UseVisualStyleBackColor = true;
		this.panel15.BorderStyle = BorderStyle.FixedSingle;
		this.panel15.Controls.Add(this.plTMProxy);
		this.panel15.Dock = DockStyle.Fill;
		this.panel15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.panel15.Location = new Point(3, 3);
		this.panel15.Name = "panel15";
		this.panel15.Size = new Size(496, 215);
		this.panel15.TabIndex = 146;
		this.plTMProxy.BorderStyle = BorderStyle.FixedSingle;
		this.plTMProxy.Controls.Add(this.ckbWaitDoneAllTMProxy);
		this.plTMProxy.Controls.Add(this.txtApiKeyTMProxy);
		this.plTMProxy.Controls.Add(this.label24);
		this.plTMProxy.Controls.Add(this.button8);
		this.plTMProxy.Controls.Add(this.label25);
		this.plTMProxy.Controls.Add(this.nudLuongPerIPTMProxy);
		this.plTMProxy.Dock = DockStyle.Fill;
		this.plTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.plTMProxy.Location = new Point(0, 0);
		this.plTMProxy.Name = "plTMProxy";
		this.plTMProxy.Size = new Size(494, 213);
		this.plTMProxy.TabIndex = 146;
		this.plTMProxy.Click += this.plTMProxy_Click;
		this.ckbWaitDoneAllTMProxy.Anchor = AnchorStyles.None;
		this.ckbWaitDoneAllTMProxy.AutoSize = true;
		this.ckbWaitDoneAllTMProxy.Cursor = Cursors.Hand;
		this.ckbWaitDoneAllTMProxy.Location = new Point(258, 45);
		this.ckbWaitDoneAllTMProxy.Name = "ckbWaitDoneAllTMProxy";
		this.ckbWaitDoneAllTMProxy.Size = new Size(128, 20);
		this.ckbWaitDoneAllTMProxy.TabIndex = 145;
		this.ckbWaitDoneAllTMProxy.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllTMProxy.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllTMProxy.Visible = false;
		this.txtApiKeyTMProxy.Anchor = AnchorStyles.None;
		this.txtApiKeyTMProxy.BorderStyle = BorderStyle.FixedSingle;
		this.txtApiKeyTMProxy.Location = new Point(95, 67);
		this.txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
		this.txtApiKeyTMProxy.Size = new Size(310, 101);
		this.txtApiKeyTMProxy.TabIndex = 144;
		this.txtApiKeyTMProxy.Text = "";
		this.txtApiKeyTMProxy.WordWrap = false;
		this.txtApiKeyTMProxy.TextChanged += this.txtApiKeyTMProxy_TextChanged;
		this.label24.Anchor = AnchorStyles.None;
		this.label24.AutoSize = true;
		this.label24.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label24.Location = new Point(92, 46);
		this.label24.Name = "label24";
		this.label24.Size = new Size(110, 16);
		this.label24.TabIndex = 79;
		this.label24.Text = "Nhập API KEY (0):";
		this.button8.Anchor = AnchorStyles.None;
		this.button8.Cursor = Cursors.Hand;
		this.button8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button8.ForeColor = Color.Black;
		this.button8.Location = new Point(353, 171);
		this.button8.Name = "button8";
		this.button8.Size = new Size(52, 27);
		this.button8.TabIndex = 143;
		this.button8.Text = "Check";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += this.button8_Click;
		this.label25.Anchor = AnchorStyles.None;
		this.label25.AutoSize = true;
		this.label25.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label25.Location = new Point(92, 175);
		this.label25.Name = "label25";
		this.label25.Size = new Size(78, 16);
		this.label25.TabIndex = 139;
		this.label25.Text = "Số luồng/IP:";
		this.nudLuongPerIPTMProxy.Anchor = AnchorStyles.None;
		this.nudLuongPerIPTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPTMProxy.Location = new Point(174, 173);
		this.nudLuongPerIPTMProxy.Name = "nudLuongPerIPTMProxy";
		this.nudLuongPerIPTMProxy.Size = new Size(67, 23);
		this.nudLuongPerIPTMProxy.TabIndex = 140;
		NumericUpDown numericUpDown23 = this.nudLuongPerIPTMProxy;
		int[] array23 = new int[4];
		array23[0] = 1;
		numericUpDown23.Value = new decimal(array23);
		this.tabNone.Controls.Add(this.panel16);
		this.tabNone.Location = new Point(4, 4);
		this.tabNone.Name = "tabNone";
		this.tabNone.Padding = new Padding(3);
		this.tabNone.Size = new Size(502, 221);
		this.tabNone.TabIndex = 7;
		this.tabNone.Text = "tabPage1";
		this.tabNone.UseVisualStyleBackColor = true;
		this.panel16.BorderStyle = BorderStyle.FixedSingle;
		this.panel16.Dock = DockStyle.Fill;
		this.panel16.Location = new Point(3, 3);
		this.panel16.Name = "panel16";
		this.panel16.Size = new Size(496, 215);
		this.panel16.TabIndex = 0;
		this.tabMinProxy.Controls.Add(this.panel5);
		this.tabMinProxy.Location = new Point(4, 4);
		this.tabMinProxy.Name = "tabMinProxy";
		this.tabMinProxy.Padding = new Padding(3);
		this.tabMinProxy.Size = new Size(502, 221);
		this.tabMinProxy.TabIndex = 8;
		this.tabMinProxy.Text = "https://minproxy.vn/";
		this.tabMinProxy.UseVisualStyleBackColor = true;
		this.panel5.BorderStyle = BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.plTypeProxy);
		this.panel5.Controls.Add(this.rbProxyDanCu);
		this.panel5.Controls.Add(this.rbProxyDong);
		this.panel5.Controls.Add(this.button10);
		this.panel5.Controls.Add(this.txtApiKeyMinProxy);
		this.panel5.Controls.Add(this.label49);
		this.panel5.Controls.Add(this.label50);
		this.panel5.Controls.Add(this.nudLuongPerIPMinProxy);
		this.panel5.Dock = DockStyle.Fill;
		this.panel5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.panel5.Location = new Point(3, 3);
		this.panel5.Name = "panel5";
		this.panel5.Size = new Size(496, 215);
		this.panel5.TabIndex = 153;
		this.plTypeProxy.Anchor = AnchorStyles.None;
		this.plTypeProxy.BorderStyle = BorderStyle.FixedSingle;
		this.plTypeProxy.Controls.Add(this.rbSockv6);
		this.plTypeProxy.Controls.Add(this.rbSockv4);
		this.plTypeProxy.Controls.Add(this.rbHttpv6);
		this.plTypeProxy.Controls.Add(this.rbHttpv4);
		this.plTypeProxy.Controls.Add(this.label56);
		this.plTypeProxy.Enabled = false;
		this.plTypeProxy.Location = new Point(33, 31);
		this.plTypeProxy.Name = "plTypeProxy";
		this.plTypeProxy.Size = new Size(364, 34);
		this.plTypeProxy.TabIndex = 158;
		this.rbSockv6.AutoSize = true;
		this.rbSockv6.Cursor = Cursors.Hand;
		this.rbSockv6.Location = new Point(292, 6);
		this.rbSockv6.Name = "rbSockv6";
		this.rbSockv6.Size = new Size(67, 20);
		this.rbSockv6.TabIndex = 163;
		this.rbSockv6.Text = "SockV6";
		this.rbSockv6.UseVisualStyleBackColor = true;
		this.rbSockv4.AutoSize = true;
		this.rbSockv4.Cursor = Cursors.Hand;
		this.rbSockv4.Location = new Point(220, 6);
		this.rbSockv4.Name = "rbSockv4";
		this.rbSockv4.Size = new Size(67, 20);
		this.rbSockv4.TabIndex = 162;
		this.rbSockv4.Text = "SockV4";
		this.rbSockv4.UseVisualStyleBackColor = true;
		this.rbHttpv6.AutoSize = true;
		this.rbHttpv6.Cursor = Cursors.Hand;
		this.rbHttpv6.Location = new Point(150, 6);
		this.rbHttpv6.Name = "rbHttpv6";
		this.rbHttpv6.Size = new Size(63, 20);
		this.rbHttpv6.TabIndex = 161;
		this.rbHttpv6.Text = "HttpV6";
		this.rbHttpv6.UseVisualStyleBackColor = true;
		this.rbHttpv4.AutoSize = true;
		this.rbHttpv4.Checked = true;
		this.rbHttpv4.Cursor = Cursors.Hand;
		this.rbHttpv4.Location = new Point(80, 6);
		this.rbHttpv4.Name = "rbHttpv4";
		this.rbHttpv4.Size = new Size(63, 20);
		this.rbHttpv4.TabIndex = 160;
		this.rbHttpv4.TabStop = true;
		this.rbHttpv4.Text = "HttpV4";
		this.rbHttpv4.UseVisualStyleBackColor = true;
		this.label56.AutoSize = true;
		this.label56.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label56.Location = new Point(4, 8);
		this.label56.Name = "label56";
		this.label56.Size = new Size(70, 16);
		this.label56.TabIndex = 155;
		this.label56.Text = "Loại Proxy:";
		this.rbProxyDanCu.Anchor = AnchorStyles.None;
		this.rbProxyDanCu.AutoSize = true;
		this.rbProxyDanCu.Cursor = Cursors.Hand;
		this.rbProxyDanCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbProxyDanCu.Location = new Point(152, 10);
		this.rbProxyDanCu.Margin = new Padding(3, 4, 3, 4);
		this.rbProxyDanCu.Name = "rbProxyDanCu";
		this.rbProxyDanCu.Size = new Size(99, 20);
		this.rbProxyDanCu.TabIndex = 154;
		this.rbProxyDanCu.Text = "Proxy dân cư";
		this.rbProxyDanCu.UseVisualStyleBackColor = true;
		this.rbProxyDanCu.CheckedChanged += this.rbProxyDanCu_CheckedChanged;
		this.rbProxyDong.Anchor = AnchorStyles.None;
		this.rbProxyDong.AutoSize = true;
		this.rbProxyDong.Checked = true;
		this.rbProxyDong.Cursor = Cursors.Hand;
		this.rbProxyDong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbProxyDong.Location = new Point(33, 10);
		this.rbProxyDong.Margin = new Padding(3, 4, 3, 4);
		this.rbProxyDong.Name = "rbProxyDong";
		this.rbProxyDong.Size = new Size(107, 20);
		this.rbProxyDong.TabIndex = 153;
		this.rbProxyDong.TabStop = true;
		this.rbProxyDong.Text = "Proxy V6 động";
		this.rbProxyDong.UseVisualStyleBackColor = true;
		this.button10.Anchor = AnchorStyles.None;
		this.button10.Cursor = Cursors.Hand;
		this.button10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button10.ForeColor = Color.Black;
		this.button10.Location = new Point(228, 179);
		this.button10.Name = "button10";
		this.button10.Size = new Size(52, 27);
		this.button10.TabIndex = 145;
		this.button10.Text = "Check";
		this.button10.UseVisualStyleBackColor = true;
		this.button10.Click += this.button10_Click;
		this.txtApiKeyMinProxy.Anchor = AnchorStyles.None;
		this.txtApiKeyMinProxy.BorderStyle = BorderStyle.FixedSingle;
		this.txtApiKeyMinProxy.Location = new Point(33, 102);
		this.txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
		this.txtApiKeyMinProxy.Size = new Size(253, 76);
		this.txtApiKeyMinProxy.TabIndex = 144;
		this.txtApiKeyMinProxy.Text = "";
		this.txtApiKeyMinProxy.WordWrap = false;
		this.txtApiKeyMinProxy.TextChanged += this.txtApiKeyMinProxy_TextChanged;
		this.label49.Anchor = AnchorStyles.None;
		this.label49.AutoSize = true;
		this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label49.Location = new Point(30, 83);
		this.label49.Name = "label49";
		this.label49.Size = new Size(110, 16);
		this.label49.TabIndex = 79;
		this.label49.Text = "Nhập API KEY (0):";
		this.label50.Anchor = AnchorStyles.None;
		this.label50.AutoSize = true;
		this.label50.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label50.Location = new Point(30, 184);
		this.label50.Name = "label50";
		this.label50.Size = new Size(78, 16);
		this.label50.TabIndex = 139;
		this.label50.Text = "Số luồng/IP:";
		this.nudLuongPerIPMinProxy.Anchor = AnchorStyles.None;
		this.nudLuongPerIPMinProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPMinProxy.Location = new Point(115, 182);
		this.nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
		this.nudLuongPerIPMinProxy.Size = new Size(67, 23);
		this.nudLuongPerIPMinProxy.TabIndex = 140;
		NumericUpDown numericUpDown24 = this.nudLuongPerIPMinProxy;
		int[] array24 = new int[4];
		array24[0] = 1;
		numericUpDown24.Value = new decimal(array24);
		this.rbMinProxy.AutoSize = true;
		this.rbMinProxy.Cursor = Cursors.Hand;
		this.rbMinProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbMinProxy.Location = new Point(30, 176);
		this.rbMinProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbMinProxy.Name = "rbMinProxy";
		this.rbMinProxy.Size = new Size(142, 20);
		this.rbMinProxy.TabIndex = 152;
		this.rbMinProxy.Text = "https://minproxy.vn/";
		this.rbMinProxy.UseVisualStyleBackColor = true;
		this.rbMinProxy.CheckedChanged += this.rbMinProxy_CheckedChanged;
		this.rbShopLike.AutoSize = true;
		this.rbShopLike.Cursor = Cursors.Hand;
		this.rbShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbShopLike.Location = new Point(301, 177);
		this.rbShopLike.Margin = new Padding(3, 4, 3, 4);
		this.rbShopLike.Name = "rbShopLike";
		this.rbShopLike.Size = new Size(165, 20);
		this.rbShopLike.TabIndex = 152;
		this.rbShopLike.Text = "http://proxy.shoplike.vn/";
		this.rbShopLike.UseVisualStyleBackColor = true;
		this.rbShopLike.CheckedChanged += this.rbShopLike_CheckedChanged;
		this.rbProxyv6.AutoSize = true;
		this.rbProxyv6.Cursor = Cursors.Hand;
		this.rbProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbProxyv6.Location = new Point(301, 154);
		this.rbProxyv6.Margin = new Padding(3, 4, 3, 4);
		this.rbProxyv6.Name = "rbProxyv6";
		this.rbProxyv6.Size = new Size(139, 20);
		this.rbProxyv6.TabIndex = 150;
		this.rbProxyv6.Text = "https://proxyv6.net/";
		this.rbProxyv6.UseVisualStyleBackColor = true;
		this.rbProxyv6.CheckedChanged += this.rbProxyv6_CheckedChanged;
		this.label37.AutoSize = true;
		this.label37.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label37.Location = new Point(27, 81);
		this.label37.Name = "label37";
		this.label37.Size = new Size(123, 16);
		this.label37.TabIndex = 139;
		this.label37.Text = "Delay sau khi đổi IP:";
		this.nudDelayCheckIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudDelayCheckIP.Location = new Point(157, 79);
		NumericUpDown numericUpDown25 = this.nudDelayCheckIP;
		int[] array25 = new int[4];
		array25[0] = 99999999;
		numericUpDown25.Maximum = new decimal(array25);
		this.nudDelayCheckIP.Name = "nudDelayCheckIP";
		this.nudDelayCheckIP.Size = new Size(46, 23);
		this.nudDelayCheckIP.TabIndex = 140;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = Cursors.Hand;
		this.linkLabel1.Location = new Point(208, 178);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new Size(85, 16);
		this.linkLabel1.TabIndex = 147;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Hướng dẫn(?)";
		this.linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Cursor = Cursors.Hand;
		this.linkLabel3.Location = new Point(208, 201);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new Size(85, 16);
		this.linkLabel3.TabIndex = 147;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "Hướng dẫn(?)";
		this.linkLabel3.LinkClicked += this.linkLabel3_LinkClicked;
		this.label38.AutoSize = true;
		this.label38.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label38.Location = new Point(205, 81);
		this.label38.Name = "label38";
		this.label38.Size = new Size(30, 16);
		this.label38.TabIndex = 141;
		this.label38.Text = "giây";
		this.plCheckDoiIP.Controls.Add(this.button5);
		this.plCheckDoiIP.Controls.Add(this.label26);
		this.plCheckDoiIP.Controls.Add(this.nudChangeIpCount);
		this.plCheckDoiIP.Controls.Add(this.label27);
		this.plCheckDoiIP.Location = new Point(24, 48);
		this.plCheckDoiIP.Name = "plCheckDoiIP";
		this.plCheckDoiIP.Size = new Size(304, 27);
		this.plCheckDoiIP.TabIndex = 146;
		this.button5.Cursor = Cursors.Hand;
		this.button5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.button5.ForeColor = Color.Black;
		this.button5.Location = new Point(220, 0);
		this.button5.Name = "button5";
		this.button5.Size = new Size(77, 27);
		this.button5.TabIndex = 143;
		this.button5.Text = "Test";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += this.button5_Click;
		this.label26.AutoSize = true;
		this.label26.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label26.Location = new Point(3, 5);
		this.label26.Name = "label26";
		this.label26.Size = new Size(100, 16);
		this.label26.TabIndex = 139;
		this.label26.Text = "Thay đổi IP sau:";
		this.nudChangeIpCount.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudChangeIpCount.Location = new Point(133, 3);
		this.nudChangeIpCount.Name = "nudChangeIpCount";
		this.nudChangeIpCount.Size = new Size(46, 23);
		this.nudChangeIpCount.TabIndex = 140;
		NumericUpDown numericUpDown26 = this.nudChangeIpCount;
		int[] array26 = new int[4];
		array26[0] = 1;
		numericUpDown26.Value = new decimal(array26);
		this.label27.AutoSize = true;
		this.label27.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label27.Location = new Point(181, 5);
		this.label27.Name = "label27";
		this.label27.Size = new Size(29, 16);
		this.label27.TabIndex = 141;
		this.label27.Text = "lượt";
		this.rbTMProxy.AutoSize = true;
		this.rbTMProxy.Cursor = Cursors.Hand;
		this.rbTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbTMProxy.Location = new Point(301, 200);
		this.rbTMProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbTMProxy.Name = "rbTMProxy";
		this.rbTMProxy.Size = new Size(147, 20);
		this.rbTMProxy.TabIndex = 145;
		this.rbTMProxy.Text = "https://tmproxy.com/";
		this.rbTMProxy.UseVisualStyleBackColor = true;
		this.rbTMProxy.CheckedChanged += this.rbTMProxy_CheckedChanged;
		this.rbDcom.AutoSize = true;
		this.rbDcom.Cursor = Cursors.Hand;
		this.rbDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbDcom.Location = new Point(30, 130);
		this.rbDcom.Margin = new Padding(3, 4, 3, 4);
		this.rbDcom.Name = "rbDcom";
		this.rbDcom.Size = new Size(95, 20);
		this.rbDcom.TabIndex = 137;
		this.rbDcom.Text = "Đổi IP Dcom";
		this.rbDcom.UseVisualStyleBackColor = true;
		this.rbDcom.CheckedChanged += this.rbDcom_CheckedChanged;
		this.rbTinsoft.AutoSize = true;
		this.rbTinsoft.Cursor = Cursors.Hand;
		this.rbTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbTinsoft.Location = new Point(30, 199);
		this.rbTinsoft.Margin = new Padding(3, 4, 3, 4);
		this.rbTinsoft.Name = "rbTinsoft";
		this.rbTinsoft.Size = new Size(167, 20);
		this.rbTinsoft.TabIndex = 134;
		this.rbTinsoft.Text = "https://tinsoftproxy.com/";
		this.rbTinsoft.UseVisualStyleBackColor = true;
		this.rbTinsoft.CheckedChanged += this.rbTinsoft_CheckedChanged;
		this.rbProxy.AutoSize = true;
		this.rbProxy.Cursor = Cursors.Hand;
		this.rbProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbProxy.Location = new Point(30, 153);
		this.rbProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbProxy.Name = "rbProxy";
		this.rbProxy.Size = new Size(266, 20);
		this.rbProxy.TabIndex = 136;
		this.rbProxy.Text = "Sử dụng Proxy (đã gán cho mỗi tài khoản)";
		this.rbProxy.UseVisualStyleBackColor = true;
		this.rbProxy.CheckedChanged += this.rbProxy_CheckedChanged;
		this.rbNone.AutoSize = true;
		this.rbNone.Checked = true;
		this.rbNone.Cursor = Cursors.Hand;
		this.rbNone.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbNone.Location = new Point(30, 107);
		this.rbNone.Margin = new Padding(3, 4, 3, 4);
		this.rbNone.Name = "rbNone";
		this.rbNone.Size = new Size(96, 20);
		this.rbNone.TabIndex = 136;
		this.rbNone.TabStop = true;
		this.rbNone.Text = "Không đổi IP";
		this.rbNone.UseVisualStyleBackColor = true;
		this.rbNone.CheckedChanged += this.rbNone_CheckedChanged;
		this.rbObcProxy.AutoSize = true;
		this.rbObcProxy.Cursor = Cursors.Hand;
		this.rbObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbObcProxy.Location = new Point(301, 131);
		this.rbObcProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbObcProxy.Name = "rbObcProxy";
		this.rbObcProxy.Size = new Size(84, 20);
		this.rbObcProxy.TabIndex = 138;
		this.rbObcProxy.Text = "OBC Proxy";
		this.rbObcProxy.UseVisualStyleBackColor = true;
		this.rbObcProxy.CheckedChanged += this.rbObcProxy_CheckedChanged;
		this.rbXproxy.AutoSize = true;
		this.rbXproxy.Cursor = Cursors.Hand;
		this.rbXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbXproxy.Location = new Point(301, 108);
		this.rbXproxy.Margin = new Padding(3, 4, 3, 4);
		this.rbXproxy.Name = "rbXproxy";
		this.rbXproxy.Size = new Size(258, 20);
		this.rbXproxy.TabIndex = 138;
		this.rbXproxy.Text = "Xproxy, Mobi, Eager, S Proxy, OBC proxy";
		this.rbXproxy.UseVisualStyleBackColor = true;
		this.rbXproxy.CheckedChanged += this.rbXproxy_CheckedChanged;
		this.rbHma.AutoSize = true;
		this.rbHma.Cursor = Cursors.Hand;
		this.rbHma.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbHma.Location = new Point(205, 130);
		this.rbHma.Margin = new Padding(3, 4, 3, 4);
		this.rbHma.Name = "rbHma";
		this.rbHma.Size = new Size(89, 20);
		this.rbHma.TabIndex = 138;
		this.rbHma.Text = "Đổi IP HMA";
		this.rbHma.UseVisualStyleBackColor = true;
		this.rbHma.CheckedChanged += this.rbHma_CheckedChanged;
		this.ckbKhongCheckIP.AutoSize = true;
		this.ckbKhongCheckIP.Cursor = Cursors.Hand;
		this.ckbKhongCheckIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ckbKhongCheckIP.Location = new Point(30, 26);
		this.ckbKhongCheckIP.Name = "ckbKhongCheckIP";
		this.ckbKhongCheckIP.Size = new Size(198, 20);
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
		this.txtServiceURLXProxy.Anchor = AnchorStyles.None;
		this.txtServiceURLXProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.txtServiceURLXProxy.ForeColor = Color.Black;
		this.txtServiceURLXProxy.Location = new Point(103, 13);
		this.txtServiceURLXProxy.Name = "txtServiceURLXProxy";
		this.txtServiceURLXProxy.Size = new Size(378, 23);
		this.txtServiceURLXProxy.TabIndex = 81;
		this.label13.Anchor = AnchorStyles.None;
		this.label13.AutoSize = true;
		this.label13.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label13.Location = new Point(16, 16);
		this.label13.Name = "label13";
		this.label13.Size = new Size(80, 16);
		this.label13.TabIndex = 79;
		this.label13.Text = "Service URL:";
		this.nudLuongPerIPXProxy.Anchor = AnchorStyles.None;
		this.nudLuongPerIPXProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudLuongPerIPXProxy.Location = new Point(343, 83);
		this.nudLuongPerIPXProxy.Name = "nudLuongPerIPXProxy";
		this.nudLuongPerIPXProxy.Size = new Size(67, 23);
		this.nudLuongPerIPXProxy.TabIndex = 140;
		NumericUpDown numericUpDown27 = this.nudLuongPerIPXProxy;
		int[] array27 = new int[4];
		array27[0] = 1;
		numericUpDown27.Value = new decimal(array27);
		this.nudDelayResetXProxy.Anchor = AnchorStyles.None;
		this.nudDelayResetXProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.nudDelayResetXProxy.Location = new Point(382, 156);
		this.nudDelayResetXProxy.Name = "nudDelayResetXProxy";
		this.nudDelayResetXProxy.Size = new Size(50, 23);
		this.nudDelayResetXProxy.TabIndex = 140;
		NumericUpDown numericUpDown28 = this.nudDelayResetXProxy;
		int[] array28 = new int[4];
		array28[0] = 1;
		numericUpDown28.Value = new decimal(array28);
		this.label18.Anchor = AnchorStyles.None;
		this.label18.AutoSize = true;
		this.label18.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label18.Location = new Point(258, 84);
		this.label18.Name = "label18";
		this.label18.Size = new Size(78, 16);
		this.label18.TabIndex = 139;
		this.label18.Text = "Số luồng/IP:";
		this.label51.Anchor = AnchorStyles.None;
		this.label51.AutoSize = true;
		this.label51.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label51.Location = new Point(258, 160);
		this.label51.Name = "label51";
		this.label51.Size = new Size(123, 16);
		this.label51.TabIndex = 139;
		this.label51.Text = "Chờ Check IP tối đa:";
		this.label52.Anchor = AnchorStyles.None;
		this.label52.AutoSize = true;
		this.label52.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label52.Location = new Point(434, 158);
		this.label52.Name = "label52";
		this.label52.Size = new Size(32, 16);
		this.label52.TabIndex = 139;
		this.label52.Text = "phút";
		this.label17.Anchor = AnchorStyles.None;
		this.label17.AutoSize = true;
		this.label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label17.Location = new Point(16, 65);
		this.label17.Name = "label17";
		this.label17.Size = new Size(97, 16);
		this.label17.TabIndex = 79;
		this.label17.Text = "Nhập Proxy (0):";
		this.label16.Anchor = AnchorStyles.None;
		this.label16.AutoSize = true;
		this.label16.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label16.Location = new Point(16, 40);
		this.label16.Name = "label16";
		this.label16.Size = new Size(70, 16);
		this.label16.TabIndex = 79;
		this.label16.Text = "Loại Proxy:";
		this.rbHttpProxy.Anchor = AnchorStyles.None;
		this.rbHttpProxy.AutoSize = true;
		this.rbHttpProxy.Checked = true;
		this.rbHttpProxy.Cursor = Cursors.Hand;
		this.rbHttpProxy.Location = new Point(103, 40);
		this.rbHttpProxy.Name = "rbHttpProxy";
		this.rbHttpProxy.Size = new Size(48, 20);
		this.rbHttpProxy.TabIndex = 82;
		this.rbHttpProxy.TabStop = true;
		this.rbHttpProxy.Text = "Http";
		this.rbHttpProxy.UseVisualStyleBackColor = true;
		this.rbSock5Proxy.Anchor = AnchorStyles.None;
		this.rbSock5Proxy.AutoSize = true;
		this.rbSock5Proxy.Cursor = Cursors.Hand;
		this.rbSock5Proxy.Location = new Point(166, 40);
		this.rbSock5Proxy.Name = "rbSock5Proxy";
		this.rbSock5Proxy.Size = new Size(59, 20);
		this.rbSock5Proxy.TabIndex = 82;
		this.rbSock5Proxy.Text = "Sock5";
		this.rbSock5Proxy.UseVisualStyleBackColor = true;
		this.txtListProxy.Anchor = AnchorStyles.None;
		this.txtListProxy.BorderStyle = BorderStyle.FixedSingle;
		this.txtListProxy.Location = new Point(19, 86);
		this.txtListProxy.Name = "txtListProxy";
		this.txtListProxy.Size = new Size(229, 99);
		this.txtListProxy.TabIndex = 144;
		this.txtListProxy.Text = "";
		this.txtListProxy.WordWrap = false;
		this.txtListProxy.TextChanged += this.txtListProxy_TextChanged;
		this.ckbWaitDoneAllXproxy.Anchor = AnchorStyles.None;
		this.ckbWaitDoneAllXproxy.AutoSize = true;
		this.ckbWaitDoneAllXproxy.Cursor = Cursors.Hand;
		this.ckbWaitDoneAllXproxy.Location = new Point(125, 64);
		this.ckbWaitDoneAllXproxy.Name = "ckbWaitDoneAllXproxy";
		this.ckbWaitDoneAllXproxy.Size = new Size(128, 20);
		this.ckbWaitDoneAllXproxy.TabIndex = 145;
		this.ckbWaitDoneAllXproxy.Text = "Đợi chạy xong hết";
		this.ckbWaitDoneAllXproxy.UseVisualStyleBackColor = true;
		this.ckbWaitDoneAllXproxy.Visible = false;
		this.rbXproxyResetEachProxy.AutoSize = true;
		this.rbXproxyResetEachProxy.Checked = true;
		this.rbXproxyResetEachProxy.Cursor = Cursors.Hand;
		this.rbXproxyResetEachProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbXproxyResetEachProxy.Location = new Point(90, 2);
		this.rbXproxyResetEachProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbXproxyResetEachProxy.Name = "rbXproxyResetEachProxy";
		this.rbXproxyResetEachProxy.Size = new Size(122, 20);
		this.rbXproxyResetEachProxy.TabIndex = 154;
		this.rbXproxyResetEachProxy.TabStop = true;
		this.rbXproxyResetEachProxy.Text = "Reset từng proxy";
		this.rbXproxyResetEachProxy.UseVisualStyleBackColor = true;
		this.rbXproxyResetAllProxy.AutoSize = true;
		this.rbXproxyResetAllProxy.Cursor = Cursors.Hand;
		this.rbXproxyResetAllProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.rbXproxyResetAllProxy.Location = new Point(90, 26);
		this.rbXproxyResetAllProxy.Margin = new Padding(3, 4, 3, 4);
		this.rbXproxyResetAllProxy.Name = "rbXproxyResetAllProxy";
		this.rbXproxyResetAllProxy.Size = new Size(128, 20);
		this.rbXproxyResetAllProxy.TabIndex = 153;
		this.rbXproxyResetAllProxy.Text = "Reset tất cả proxy";
		this.rbXproxyResetAllProxy.UseVisualStyleBackColor = true;
		this.label53.AutoSize = true;
		this.label53.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.label53.Location = new Point(1, 4);
		this.label53.Name = "label53";
		this.label53.Size = new Size(82, 16);
		this.label53.TabIndex = 155;
		this.label53.Text = "Chế độ chạy:";
		this.panel7.Anchor = AnchorStyles.None;
		this.panel7.Controls.Add(this.label53);
		this.panel7.Controls.Add(this.rbXproxyResetAllProxy);
		this.panel7.Controls.Add(this.rbXproxyResetEachProxy);
		this.panel7.Location = new Point(257, 107);
		this.panel7.Name = "panel7";
		this.panel7.Size = new Size(223, 48);
		this.panel7.TabIndex = 152;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(1158, 539);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhChung";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += this.fCauHinhChung_Load;
		((ISupportInitialize)this.nudInteractThread).EndInit();
		((ISupportInitialize)this.nudHideThread).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plVitech.ResumeLayout(false);
		this.plVitech.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPVitech).EndInit();
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
		((ISupportInitialize)this.nudWidthChrome).EndInit();
		((ISupportInitialize)this.nudHeighChrome).EndInit();
		((ISupportInitialize)this.nudDelayCloseChromeFrom).EndInit();
		((ISupportInitialize)this.nudDelayCloseChromeTo).EndInit();
		((ISupportInitialize)this.nudDelayOpenChromeFrom).EndInit();
		((ISupportInitialize)this.nudDelayOpenChromeTo).EndInit();
		this.plLinkToOtherBrowser.ResumeLayout(false);
		this.plLinkToOtherBrowser.PerformLayout();
		this.plUsePortable.ResumeLayout(false);
		this.plUsePortable.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((ISupportInitialize)this.pictureBox1).EndInit();
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
		((ISupportInitialize)this.nudLuongPerIPTinsoft).EndInit();
		this.tabXProxy.ResumeLayout(false);
		this.plXproxy.ResumeLayout(false);
		this.plXproxy.PerformLayout();
		this.tabObcProxy.ResumeLayout(false);
		this.plObcProxy.ResumeLayout(false);
		this.plObcProxy.PerformLayout();
		this.panel8.ResumeLayout(false);
		this.panel8.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPObcProxy).EndInit();
		((ISupportInitialize)this.nudDelayCheckIPObcProxy).EndInit();
		this.tabProxyV6.ResumeLayout(false);
		this.plProxyv6.ResumeLayout(false);
		this.plProxyv6.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPProxyv6).EndInit();
		this.tabProxyShopLike.ResumeLayout(false);
		this.plShopLike.ResumeLayout(false);
		this.plShopLike.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPShopLike).EndInit();
		this.tabTMProxy.ResumeLayout(false);
		this.panel15.ResumeLayout(false);
		this.plTMProxy.ResumeLayout(false);
		this.plTMProxy.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPTMProxy).EndInit();
		this.tabNone.ResumeLayout(false);
		this.tabMinProxy.ResumeLayout(false);
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		this.plTypeProxy.ResumeLayout(false);
		this.plTypeProxy.PerformLayout();
		((ISupportInitialize)this.nudLuongPerIPMinProxy).EndInit();
		((ISupportInitialize)this.nudDelayCheckIP).EndInit();
		this.plCheckDoiIP.ResumeLayout(false);
		this.plCheckDoiIP.PerformLayout();
		((ISupportInitialize)this.nudChangeIpCount).EndInit();
		((ISupportInitialize)this.nudLuongPerIPXProxy).EndInit();
		((ISupportInitialize)this.nudDelayResetXProxy).EndInit();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04001C67 RID: 7271
	private GClass17 gclass17_0;

	// Token: 0x04001C68 RID: 7272
	private IContainer icontainer_0 = null;

	// Token: 0x04001C69 RID: 7273
	private BunifuCards bunifuCards1;

	// Token: 0x04001C6A RID: 7274
	private Label label3;

	// Token: 0x04001C6B RID: 7275
	private NumericUpDown nudInteractThread;

	// Token: 0x04001C6C RID: 7276
	private Label label4;

	// Token: 0x04001C6D RID: 7277
	private Label label5;

	// Token: 0x04001C6E RID: 7278
	private NumericUpDown nudHideThread;

	// Token: 0x04001C6F RID: 7279
	private Label label6;

	// Token: 0x04001C70 RID: 7280
	private Label label9;

	// Token: 0x04001C71 RID: 7281
	private TextBox txbPathProfile;

	// Token: 0x04001C72 RID: 7282
	private Panel panel1;

	// Token: 0x04001C73 RID: 7283
	private GroupBox groupBox2;

	// Token: 0x04001C74 RID: 7284
	private CheckBox ckbShowImageInteract;

	// Token: 0x04001C75 RID: 7285
	private ComboBox cbbHostpot;

	// Token: 0x04001C76 RID: 7286
	private Panel plNordVPN;

	// Token: 0x04001C77 RID: 7287
	private Label label14;

	// Token: 0x04001C78 RID: 7288
	private TextBox txtNordVPN;

	// Token: 0x04001C79 RID: 7289
	private Button btnSSH;

	// Token: 0x04001C7A RID: 7290
	private RadioButton rbSSH;

	// Token: 0x04001C7B RID: 7291
	private RadioButton rbExpressVPN;

	// Token: 0x04001C7C RID: 7292
	private RadioButton rbNordVPN;

	// Token: 0x04001C7D RID: 7293
	private RadioButton rbHotspot;

	// Token: 0x04001C7E RID: 7294
	private BunifuDragControl bunifuDragControl_0;

	// Token: 0x04001C7F RID: 7295
	private ToolTip toolTip_0;

	// Token: 0x04001C80 RID: 7296
	private Button btnCancel;

	// Token: 0x04001C81 RID: 7297
	private Button btnSave;

	// Token: 0x04001C82 RID: 7298
	private BunifuCards bunifuCards2;

	// Token: 0x04001C83 RID: 7299
	private Panel pnlHeader;

	// Token: 0x04001C84 RID: 7300
	private PictureBox pictureBox1;

	// Token: 0x04001C85 RID: 7301
	private BunifuCustomLabel bunifuCustomLabel1;

	// Token: 0x04001C86 RID: 7302
	private Button button2;

	// Token: 0x04001C87 RID: 7303
	private ComboBox cbbRowChrome;

	// Token: 0x04001C88 RID: 7304
	private ComboBox cbbColumnChrome;

	// Token: 0x04001C89 RID: 7305
	private Label label10;

	// Token: 0x04001C8A RID: 7306
	private Label label11;

	// Token: 0x04001C8B RID: 7307
	private Panel panel2;

	// Token: 0x04001C8C RID: 7308
	private Label label12;

	// Token: 0x04001C8D RID: 7309
	private TextBox textBox1;

	// Token: 0x04001C8E RID: 7310
	private RadioButton radioButton5;

	// Token: 0x04001C8F RID: 7311
	private RadioButton radioButton4;

	// Token: 0x04001C90 RID: 7312
	private RadioButton radioButton3;

	// Token: 0x04001C91 RID: 7313
	private RadioButton radioButton2;

	// Token: 0x04001C92 RID: 7314
	private GroupBox grChrome;

	// Token: 0x04001C93 RID: 7315
	private RadioButton rbChromium;

	// Token: 0x04001C94 RID: 7316
	private RadioButton rbChrome;

	// Token: 0x04001C95 RID: 7317
	private Label label15;

	// Token: 0x04001C96 RID: 7318
	private TextBox txtLinkToOtherBrowser;

	// Token: 0x04001C97 RID: 7319
	private Label label19;

	// Token: 0x04001C98 RID: 7320
	private Panel plLinkToOtherBrowser;

	// Token: 0x04001C99 RID: 7321
	private NumericUpDown nudDelayOpenChromeTo;

	// Token: 0x04001C9A RID: 7322
	private Label label21;

	// Token: 0x04001C9B RID: 7323
	private Label label20;

	// Token: 0x04001C9C RID: 7324
	private Label label22;

	// Token: 0x04001C9D RID: 7325
	private Button button6;

	// Token: 0x04001C9E RID: 7326
	private GroupBox groupBox1;

	// Token: 0x04001C9F RID: 7327
	private RadioButton rbPhanBietMauChu;

	// Token: 0x04001CA0 RID: 7328
	private RadioButton rbPhanBietMauNen;

	// Token: 0x04001CA1 RID: 7329
	private Label label23;

	// Token: 0x04001CA2 RID: 7330
	private NumericUpDown nudDelayOpenChromeFrom;

	// Token: 0x04001CA3 RID: 7331
	private Label label29;

	// Token: 0x04001CA4 RID: 7332
	private NumericUpDown nudDelayCloseChromeFrom;

	// Token: 0x04001CA5 RID: 7333
	private NumericUpDown nudDelayCloseChromeTo;

	// Token: 0x04001CA6 RID: 7334
	private Label label32;

	// Token: 0x04001CA7 RID: 7335
	private Label label31;

	// Token: 0x04001CA8 RID: 7336
	private Label label2;

	// Token: 0x04001CA9 RID: 7337
	private ComboBox cbbSizeChrome;

	// Token: 0x04001CAA RID: 7338
	private Label label34;

	// Token: 0x04001CAB RID: 7339
	private MetroButton btnDown;

	// Token: 0x04001CAC RID: 7340
	private MetroButton btnUp;

	// Token: 0x04001CAD RID: 7341
	private MetroButton AddFileAccount;

	// Token: 0x04001CAE RID: 7342
	private Panel plSizeChrome;

	// Token: 0x04001CAF RID: 7343
	private RadioButton rbTocDoGoNhanh;

	// Token: 0x04001CB0 RID: 7344
	private RadioButton rbTocDoGoBinhThuong;

	// Token: 0x04001CB1 RID: 7345
	private RadioButton rbTocDoGoCham;

	// Token: 0x04001CB2 RID: 7346
	private Label label30;

	// Token: 0x04001CB3 RID: 7347
	private Panel panel4;

	// Token: 0x04001CB4 RID: 7348
	private NumericUpDown nudHeighChrome;

	// Token: 0x04001CB5 RID: 7349
	private NumericUpDown nudWidthChrome;

	// Token: 0x04001CB6 RID: 7350
	private CheckBox ckbAddChromeIntoForm;

	// Token: 0x04001CB7 RID: 7351
	private Label label33;

	// Token: 0x04001CB8 RID: 7352
	private Label label35;

	// Token: 0x04001CB9 RID: 7353
	private Panel plAddChromeVaoFormView;

	// Token: 0x04001CBA RID: 7354
	private Button button9;

	// Token: 0x04001CBB RID: 7355
	private Panel plSapXepCuaSoChrome;

	// Token: 0x04001CBC RID: 7356
	private Panel plUsePortable;

	// Token: 0x04001CBD RID: 7357
	private Label lblFileZip;

	// Token: 0x04001CBE RID: 7358
	private CheckBox ckbUsePortable;

	// Token: 0x04001CBF RID: 7359
	private TextBox txtPathToPortableZip;

	// Token: 0x04001CC0 RID: 7360
	private Panel panel3;

	// Token: 0x04001CC1 RID: 7361
	private Button button1;

	// Token: 0x04001CC2 RID: 7362
	private LinkLabel linkLabel2;

	// Token: 0x04001CC3 RID: 7363
	private Panel plVitech;

	// Token: 0x04001CC4 RID: 7364
	private RichTextBox txtListProxyVitech;

	// Token: 0x04001CC5 RID: 7365
	private RadioButton radioButton9;

	// Token: 0x04001CC6 RID: 7366
	private RadioButton radioButton10;

	// Token: 0x04001CC7 RID: 7367
	private Label label40;

	// Token: 0x04001CC8 RID: 7368
	private Label label41;

	// Token: 0x04001CC9 RID: 7369
	private Label label42;

	// Token: 0x04001CCA RID: 7370
	private NumericUpDown nudLuongPerIPVitech;

	// Token: 0x04001CCB RID: 7371
	private Label label46;

	// Token: 0x04001CCC RID: 7372
	private TextBox txtApiVitech;

	// Token: 0x04001CCD RID: 7373
	private RadioButton rbVitech;

	// Token: 0x04001CCE RID: 7374
	private CheckBox ckbLuuTrangThai;

	// Token: 0x04001CCF RID: 7375
	private GroupBox groupBox3;

	// Token: 0x04001CD0 RID: 7376
	private TabControl tabChangeIP;

	// Token: 0x04001CD1 RID: 7377
	private TabPage tabDcom;

	// Token: 0x04001CD2 RID: 7378
	private Panel plDcom;

	// Token: 0x04001CD3 RID: 7379
	private Button button4;

	// Token: 0x04001CD4 RID: 7380
	private TextBox txtUrlHilink;

	// Token: 0x04001CD5 RID: 7381
	private TextBox txtProfileNameDcom;

	// Token: 0x04001CD6 RID: 7382
	private RadioButton rbDcomHilink;

	// Token: 0x04001CD7 RID: 7383
	private Label label36;

	// Token: 0x04001CD8 RID: 7384
	private RadioButton rbDcomThuong;

	// Token: 0x04001CD9 RID: 7385
	private TabPage tabTinsoft;

	// Token: 0x04001CDA RID: 7386
	private Panel plTinsoft;

	// Token: 0x04001CDB RID: 7387
	private CheckBox ckbWaitDoneAllTinsoft;

	// Token: 0x04001CDC RID: 7388
	private Panel plApiProxy;

	// Token: 0x04001CDD RID: 7389
	private Label lblCountApiProxy;

	// Token: 0x04001CDE RID: 7390
	private Label label28;

	// Token: 0x04001CDF RID: 7391
	private TextBox txtApiProxy;

	// Token: 0x04001CE0 RID: 7392
	private Button button7;

	// Token: 0x04001CE1 RID: 7393
	private Panel plApiUser;

	// Token: 0x04001CE2 RID: 7394
	private Label label1;

	// Token: 0x04001CE3 RID: 7395
	private TextBox txtApiUser;

	// Token: 0x04001CE4 RID: 7396
	private Button button3;

	// Token: 0x04001CE5 RID: 7397
	private ComboBox cbbLocationTinsoft;

	// Token: 0x04001CE6 RID: 7398
	private RadioButton rbApiProxy;

	// Token: 0x04001CE7 RID: 7399
	private RadioButton rbApiUser;

	// Token: 0x04001CE8 RID: 7400
	private Label label7;

	// Token: 0x04001CE9 RID: 7401
	private Label label8;

	// Token: 0x04001CEA RID: 7402
	private NumericUpDown nudLuongPerIPTinsoft;

	// Token: 0x04001CEB RID: 7403
	private TabPage tabXProxy;

	// Token: 0x04001CEC RID: 7404
	private Panel plXproxy;

	// Token: 0x04001CED RID: 7405
	private TabPage tabObcProxy;

	// Token: 0x04001CEE RID: 7406
	private Panel plObcProxy;

	// Token: 0x04001CEF RID: 7407
	private Panel panel8;

	// Token: 0x04001CF0 RID: 7408
	private Label label54;

	// Token: 0x04001CF1 RID: 7409
	private RadioButton rbObcResetDaiIP;

	// Token: 0x04001CF2 RID: 7410
	private RadioButton rbObcResetTungIP;

	// Token: 0x04001CF3 RID: 7411
	private RadioButton rbObcSock5Proxy;

	// Token: 0x04001CF4 RID: 7412
	private RadioButton rbObcHttpProxy;

	// Token: 0x04001CF5 RID: 7413
	private Label label55;

	// Token: 0x04001CF6 RID: 7414
	private RichTextBox txtListObcProxy;

	// Token: 0x04001CF7 RID: 7415
	private Label label67;

	// Token: 0x04001CF8 RID: 7416
	private Label label68;

	// Token: 0x04001CF9 RID: 7417
	private Label label69;

	// Token: 0x04001CFA RID: 7418
	private NumericUpDown nudLuongPerIPObcProxy;

	// Token: 0x04001CFB RID: 7419
	private Label label70;

	// Token: 0x04001CFC RID: 7420
	private Label label71;

	// Token: 0x04001CFD RID: 7421
	private NumericUpDown nudDelayCheckIPObcProxy;

	// Token: 0x04001CFE RID: 7422
	private TextBox txtLinkWebObcProxy;

	// Token: 0x04001CFF RID: 7423
	private TabPage tabProxyV6;

	// Token: 0x04001D00 RID: 7424
	private Panel plProxyv6;

	// Token: 0x04001D01 RID: 7425
	private RichTextBox txtListProxyv6;

	// Token: 0x04001D02 RID: 7426
	private RadioButton radioButton1;

	// Token: 0x04001D03 RID: 7427
	private RadioButton radioButton6;

	// Token: 0x04001D04 RID: 7428
	private Label label39;

	// Token: 0x04001D05 RID: 7429
	private Label label43;

	// Token: 0x04001D06 RID: 7430
	private Label label44;

	// Token: 0x04001D07 RID: 7431
	private NumericUpDown nudLuongPerIPProxyv6;

	// Token: 0x04001D08 RID: 7432
	private Label label45;

	// Token: 0x04001D09 RID: 7433
	private TextBox txtApiProxyv6;

	// Token: 0x04001D0A RID: 7434
	private TabPage tabProxyShopLike;

	// Token: 0x04001D0B RID: 7435
	private Panel plShopLike;

	// Token: 0x04001D0C RID: 7436
	private RichTextBox txtApiShopLike;

	// Token: 0x04001D0D RID: 7437
	private Label label47;

	// Token: 0x04001D0E RID: 7438
	private Label label48;

	// Token: 0x04001D0F RID: 7439
	private NumericUpDown nudLuongPerIPShopLike;

	// Token: 0x04001D10 RID: 7440
	private TabPage tabTMProxy;

	// Token: 0x04001D11 RID: 7441
	private Panel panel15;

	// Token: 0x04001D12 RID: 7442
	private Panel plTMProxy;

	// Token: 0x04001D13 RID: 7443
	private CheckBox ckbWaitDoneAllTMProxy;

	// Token: 0x04001D14 RID: 7444
	private RichTextBox txtApiKeyTMProxy;

	// Token: 0x04001D15 RID: 7445
	private Label label24;

	// Token: 0x04001D16 RID: 7446
	private Button button8;

	// Token: 0x04001D17 RID: 7447
	private Label label25;

	// Token: 0x04001D18 RID: 7448
	private NumericUpDown nudLuongPerIPTMProxy;

	// Token: 0x04001D19 RID: 7449
	private TabPage tabNone;

	// Token: 0x04001D1A RID: 7450
	private Panel panel16;

	// Token: 0x04001D1B RID: 7451
	private TabPage tabMinProxy;

	// Token: 0x04001D1C RID: 7452
	private Panel panel5;

	// Token: 0x04001D1D RID: 7453
	private Panel plTypeProxy;

	// Token: 0x04001D1E RID: 7454
	private RadioButton rbSockv6;

	// Token: 0x04001D1F RID: 7455
	private RadioButton rbSockv4;

	// Token: 0x04001D20 RID: 7456
	private RadioButton rbHttpv6;

	// Token: 0x04001D21 RID: 7457
	private RadioButton rbHttpv4;

	// Token: 0x04001D22 RID: 7458
	private Label label56;

	// Token: 0x04001D23 RID: 7459
	private RadioButton rbProxyDanCu;

	// Token: 0x04001D24 RID: 7460
	private RadioButton rbProxyDong;

	// Token: 0x04001D25 RID: 7461
	private Button button10;

	// Token: 0x04001D26 RID: 7462
	private RichTextBox txtApiKeyMinProxy;

	// Token: 0x04001D27 RID: 7463
	private Label label49;

	// Token: 0x04001D28 RID: 7464
	private Label label50;

	// Token: 0x04001D29 RID: 7465
	private NumericUpDown nudLuongPerIPMinProxy;

	// Token: 0x04001D2A RID: 7466
	private RadioButton rbMinProxy;

	// Token: 0x04001D2B RID: 7467
	private RadioButton rbShopLike;

	// Token: 0x04001D2C RID: 7468
	private RadioButton rbProxyv6;

	// Token: 0x04001D2D RID: 7469
	private Label label37;

	// Token: 0x04001D2E RID: 7470
	private NumericUpDown nudDelayCheckIP;

	// Token: 0x04001D2F RID: 7471
	private LinkLabel linkLabel1;

	// Token: 0x04001D30 RID: 7472
	private LinkLabel linkLabel3;

	// Token: 0x04001D31 RID: 7473
	private Label label38;

	// Token: 0x04001D32 RID: 7474
	private Panel plCheckDoiIP;

	// Token: 0x04001D33 RID: 7475
	private Button button5;

	// Token: 0x04001D34 RID: 7476
	private Label label26;

	// Token: 0x04001D35 RID: 7477
	private NumericUpDown nudChangeIpCount;

	// Token: 0x04001D36 RID: 7478
	private Label label27;

	// Token: 0x04001D37 RID: 7479
	private RadioButton rbTMProxy;

	// Token: 0x04001D38 RID: 7480
	private RadioButton rbDcom;

	// Token: 0x04001D39 RID: 7481
	private RadioButton rbTinsoft;

	// Token: 0x04001D3A RID: 7482
	private RadioButton rbProxy;

	// Token: 0x04001D3B RID: 7483
	private RadioButton rbNone;

	// Token: 0x04001D3C RID: 7484
	private RadioButton rbObcProxy;

	// Token: 0x04001D3D RID: 7485
	private RadioButton rbXproxy;

	// Token: 0x04001D3E RID: 7486
	private RadioButton rbHma;

	// Token: 0x04001D3F RID: 7487
	private CheckBox ckbKhongCheckIP;

	// Token: 0x04001D40 RID: 7488
	private Panel panel6;

	// Token: 0x04001D41 RID: 7489
	private RadioButton rbServer;

	// Token: 0x04001D42 RID: 7490
	private RadioButton rbClient;

	// Token: 0x04001D43 RID: 7491
	private Label label57;

	// Token: 0x04001D44 RID: 7492
	private Panel panel7;

	// Token: 0x04001D45 RID: 7493
	private Label label53;

	// Token: 0x04001D46 RID: 7494
	private RadioButton rbXproxyResetAllProxy;

	// Token: 0x04001D47 RID: 7495
	private RadioButton rbXproxyResetEachProxy;

	// Token: 0x04001D48 RID: 7496
	private CheckBox ckbWaitDoneAllXproxy;

	// Token: 0x04001D49 RID: 7497
	private RichTextBox txtListProxy;

	// Token: 0x04001D4A RID: 7498
	private RadioButton rbSock5Proxy;

	// Token: 0x04001D4B RID: 7499
	private RadioButton rbHttpProxy;

	// Token: 0x04001D4C RID: 7500
	private Label label16;

	// Token: 0x04001D4D RID: 7501
	private Label label17;

	// Token: 0x04001D4E RID: 7502
	private Label label52;

	// Token: 0x04001D4F RID: 7503
	private Label label51;

	// Token: 0x04001D50 RID: 7504
	private Label label18;

	// Token: 0x04001D51 RID: 7505
	private NumericUpDown nudDelayResetXProxy;

	// Token: 0x04001D52 RID: 7506
	private NumericUpDown nudLuongPerIPXProxy;

	// Token: 0x04001D53 RID: 7507
	private Label label13;

	// Token: 0x04001D54 RID: 7508
	private TextBox txtServiceURLXProxy;
}
