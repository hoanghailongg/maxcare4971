using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCheckPoint : Form
{
	private GClass17 gclass17_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbCaptcha;

	private TextBox txtImage;

	private CheckBox ckbImage;

	private TextBox txtAhaSim;

	private CheckBox ckbPhone;

	private Panel panel2;

	private Label label3;

	private NumericUpDown nudTime;

	private Label label2;

	private RadioButton rbSimCode;

	private TextBox txtSimCode;

	private RadioButton rbOtpSim;

	private TextBox txtOtpSim;

	private RadioButton rbAhaSim;

	private RadioButton rbOtpmmo;

	private TextBox txtOtpmmo;

	private RadioButton rbPrimeOtp;

	private TextBox txtPrimeOtp;

	private RadioButton rbMfb;

	private RadioButton rbMbasic;

	private BackgroundWorker backgroundWorker_0;

	private GroupBox groupBox1;

	private RadioButton rbOtpfb;

	private TextBox txtOtpfb;

	private RadioButton rbServer;

	private TextBox txtServer;

	private RadioButton rbCustom;

	private TextBox txtCustom;

	private RadioButton rbOtpTextnow;

	private RadioButton rbViotp;

	private TextBox txtOtpTextnow;

	private TextBox txtViotp;

	private RadioButton rbTempCode;

	private TextBox txtTempCode;

	private RadioButton rbThueCode;

	private TextBox txtThueCode;

	private Panel panel3;

	private RadioButton rbAnyCaptcha;

	private TextBox txtAnyCaptcha;

	private RadioButton rbCaptchafb;

	private TextBox txtCaptchafb;

	private RadioButton rb2Captcha;

	private TextBox txt2Captcha;

	private Panel panel4;

	private RadioButton rbWeb;

	private RadioButton rbFolder;

	private Panel panel5;

	private TextBox txtServiceId;

	private Label label1;

	public fCheckPoint()
	{
		InitializeComponent();
		bool_0 = false;
		gclass17_0 = new GClass17("configCheckpoint");
	}

	private void fCheckPoint_Load(object sender, EventArgs e)
	{
		try
		{
			if (gclass17_0.method_2("typeWeb") == 0)
			{
				rbMfb.Checked = true;
			}
			else
			{
				rbMbasic.Checked = true;
			}
			ckbCaptcha.Checked = gclass17_0.method_3("ckbCaptcha");
			switch (gclass17_0.method_2("typeCaptcha"))
			{
			case 0:
				rb2Captcha.Checked = true;
				break;
			case 2:
				rbAnyCaptcha.Checked = true;
				break;
			default:
				rbCaptchafb.Checked = true;
				break;
			}
			txt2Captcha.Text = gclass17_0.method_0("txt2Captcha");
			txtAnyCaptcha.Text = gclass17_0.method_0("txtAnyCaptcha");
			txtCaptchafb.Text = gclass17_0.method_0("txtCaptchafb");
			ckbPhone.Checked = gclass17_0.method_3("ckbPhone");
			switch (gclass17_0.method_2("typeSim"))
			{
			case 0:
				rbAhaSim.Checked = true;
				break;
			case 1:
				rbOtpSim.Checked = true;
				break;
			case 2:
				rbSimCode.Checked = true;
				break;
			case 3:
				rbOtpmmo.Checked = true;
				break;
			case 4:
				rbPrimeOtp.Checked = true;
				break;
			case 5:
				rbServer.Checked = true;
				break;
			case 6:
				rbOtpfb.Checked = true;
				break;
			case 7:
				rbCustom.Checked = true;
				break;
			case 8:
				rbViotp.Checked = true;
				break;
			case 9:
				rbOtpTextnow.Checked = true;
				break;
			case 10:
				rbTempCode.Checked = true;
				break;
			case 11:
				rbThueCode.Checked = true;
				break;
			}
			txtAhaSim.Text = gclass17_0.method_0("txtAhaSim");
			txtOtpSim.Text = gclass17_0.method_0("txtOtpSim");
			txtSimCode.Text = gclass17_0.method_0("txtSimCode");
			txtOtpmmo.Text = gclass17_0.method_0("txtOtpmmo");
			txtPrimeOtp.Text = gclass17_0.method_0("txtPrimeOtp");
			txtServer.Text = gclass17_0.method_0("txtServer");
			txtOtpfb.Text = gclass17_0.method_0("txtOtpfb");
			txtCustom.Text = gclass17_0.method_0("txtCustom");
			txtViotp.Text = gclass17_0.method_0("txtViotp");
			txtOtpTextnow.Text = gclass17_0.method_0("txtOtpTextnow");
			txtTempCode.Text = gclass17_0.method_0("txtTempCode");
			txtServiceId.Text = gclass17_0.method_0("txtServiceId", "fb_tn");
			txtThueCode.Text = gclass17_0.method_0("txtThueCode");
			nudTime.Value = gclass17_0.method_2("nudTime", 120);
			ckbImage.Checked = gclass17_0.method_3("ckbImage");
			if (gclass17_0.method_2("typeImage") == 0)
			{
				rbFolder.Checked = true;
			}
			else
			{
				rbWeb.Checked = true;
			}
			txtImage.Text = gclass17_0.method_0("txtImage");
		}
		catch
		{
		}
		method_0();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			int num = 0;
			if (rbMbasic.Checked)
			{
				num = 1;
			}
			gclass17_0.method_5("typeWeb", num);
			gclass17_0.method_5("ckbCaptcha", ckbCaptcha.Checked);
			int num2 = 0;
			if (rb2Captcha.Checked)
			{
				num2 = 0;
			}
			else if (rbAnyCaptcha.Checked)
			{
				num2 = 2;
			}
			else if (rbCaptchafb.Checked)
			{
				num2 = 3;
			}
			gclass17_0.method_5("typeCaptcha", num2);
			gclass17_0.method_5("txt2Captcha", txt2Captcha.Text);
			gclass17_0.method_5("txtAnyCaptcha", txtAnyCaptcha.Text);
			gclass17_0.method_5("txtCaptchafb", txtCaptchafb.Text);
			gclass17_0.method_5("ckbPhone", ckbPhone.Checked);
			int num3 = 0;
			if (rbAhaSim.Checked)
			{
				num3 = 0;
			}
			if (rbOtpSim.Checked)
			{
				num3 = 1;
			}
			else if (rbSimCode.Checked)
			{
				num3 = 2;
			}
			else if (rbOtpmmo.Checked)
			{
				num3 = 3;
			}
			else if (rbPrimeOtp.Checked)
			{
				num3 = 4;
			}
			else if (rbServer.Checked)
			{
				num3 = 5;
			}
			else if (rbOtpfb.Checked)
			{
				num3 = 6;
			}
			else if (rbCustom.Checked)
			{
				num3 = 7;
			}
			else if (rbViotp.Checked)
			{
				num3 = 8;
			}
			else if (rbOtpTextnow.Checked)
			{
				num3 = 9;
			}
			else if (rbTempCode.Checked)
			{
				num3 = 10;
			}
			else if (rbThueCode.Checked)
			{
				num3 = 11;
			}
			gclass17_0.method_5("typeSim", num3);
			gclass17_0.method_5("txtAhaSim", txtAhaSim.Text);
			gclass17_0.method_5("txtOtpSim", txtOtpSim.Text);
			gclass17_0.method_5("txtSimCode", txtSimCode.Text);
			gclass17_0.method_5("txtOtpmmo", txtOtpmmo.Text);
			gclass17_0.method_5("txtPrimeOtp", txtPrimeOtp.Text);
			gclass17_0.method_5("txtServer", txtServer.Text);
			gclass17_0.method_5("txtOtpfb", txtOtpfb.Text);
			gclass17_0.method_5("txtCustom", txtCustom.Text);
			gclass17_0.method_5("txtViotp", txtViotp.Text);
			gclass17_0.method_5("txtOtpTextnow", txtOtpTextnow.Text);
			gclass17_0.method_5("txtTempCode", txtTempCode.Text);
			gclass17_0.method_5("txtServiceId", txtServiceId.Text);
			gclass17_0.method_5("txtThueCode", txtThueCode.Text);
			gclass17_0.method_5("nudTime", nudTime.Value);
			gclass17_0.method_5("ckbImage", ckbImage.Checked);
			int num4 = 0;
			if (rbWeb.Checked)
			{
				num4 = 1;
			}
			gclass17_0.method_5("typeImage", num4);
			gclass17_0.method_5("txtImage", txtImage.Text);
			gclass17_0.method_8();
			bool_0 = true;
			Close();
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng thử lại sau!"), 2);
		}
	}

	private void method_0()
	{
		ckbCaptcha_CheckedChanged(null, null);
		ckbPhone_CheckedChanged(null, null);
		ckbImage_CheckedChanged(null, null);
		rbAhaSim_CheckedChanged(null, null);
		rbOtpSim_CheckedChanged(null, null);
		rbSimCode_CheckedChanged(null, null);
		rb2Captcha_CheckedChanged(null, null);
		rbAnyCaptcha_CheckedChanged(null, null);
		rbOtpmmo_CheckedChanged(null, null);
		rbPrimeOtp_CheckedChanged(null, null);
		rbServer_CheckedChanged(null, null);
		rbOtpfb_CheckedChanged(null, null);
		rbCustom_CheckedChanged(null, null);
		rbViotp_CheckedChanged(null, null);
		rbOtpTextnow_CheckedChanged(null, null);
		rbThueCode_CheckedChanged(null, null);
		rbCaptchafb_CheckedChanged(null, null);
		rbFolder_CheckedChanged(null, null);
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

	private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		panel3.Enabled = ckbCaptcha.Checked;
	}

	private void ckbPhone_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbPhone.Checked;
	}

	private void ckbImage_CheckedChanged(object sender, EventArgs e)
	{
		txtImage.Enabled = ckbImage.Checked;
	}

	private void rbAhaSim_CheckedChanged(object sender, EventArgs e)
	{
		if (rbAhaSim.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = true;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbOtpSim_CheckedChanged(object sender, EventArgs e)
	{
		if (rbOtpSim.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = true;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
		}
	}

	private void rbSimCode_CheckedChanged(object sender, EventArgs e)
	{
		if (rbSimCode.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = true;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rb2Captcha_CheckedChanged(object sender, EventArgs e)
	{
		if (rb2Captcha.Checked)
		{
			txt2Captcha.Enabled = true;
			txtAnyCaptcha.Enabled = false;
			txtCaptchafb.Enabled = false;
		}
	}

	private void rbOtpmmo_CheckedChanged(object sender, EventArgs e)
	{
		if (rbOtpmmo.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = true;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbAnyCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		if (rbAnyCaptcha.Checked)
		{
			txt2Captcha.Enabled = false;
			txtAnyCaptcha.Enabled = true;
			txtCaptchafb.Enabled = false;
		}
	}

	private void rbPrimeOtp_CheckedChanged(object sender, EventArgs e)
	{
		if (rbPrimeOtp.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = true;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbServer_CheckedChanged(object sender, EventArgs e)
	{
		if (rbServer.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = true;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbOtpfb_CheckedChanged(object sender, EventArgs e)
	{
		if (rbOtpfb.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = true;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbCustom_CheckedChanged(object sender, EventArgs e)
	{
		if (rbCustom.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = true;
			txtViotp.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbViotp_CheckedChanged(object sender, EventArgs e)
	{
		if (rbViotp.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = true;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = false;
		}
	}

	private void rbOtpTextnow_CheckedChanged(object sender, EventArgs e)
	{
		if (rbOtpTextnow.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = true;
			panel5.Enabled = false;
		}
	}

	private void rbTempCode_CheckedChanged(object sender, EventArgs e)
	{
		if (rbTempCode.Checked)
		{
			txtThueCode.Enabled = false;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			panel5.Enabled = true;
		}
	}

	private void rbThueCode_CheckedChanged(object sender, EventArgs e)
	{
		if (rbThueCode.Checked)
		{
			txtThueCode.Enabled = true;
			txtAhaSim.Enabled = false;
			txtOtpSim.Enabled = false;
			txtSimCode.Enabled = false;
			txtOtpmmo.Enabled = false;
			txtPrimeOtp.Enabled = false;
			txtServer.Enabled = false;
			txtOtpfb.Enabled = false;
			txtCustom.Enabled = false;
			txtViotp.Enabled = false;
			txtOtpTextnow.Enabled = false;
			txtTempCode.Enabled = false;
		}
	}

	private void rbCaptchafb_CheckedChanged(object sender, EventArgs e)
	{
		if (rbCaptchafb.Checked)
		{
			txt2Captcha.Enabled = false;
			txtAnyCaptcha.Enabled = false;
			txtCaptchafb.Enabled = true;
		}
	}

	private void rbFolder_CheckedChanged(object sender, EventArgs e)
	{
		txtImage.Enabled = rbFolder.Checked;
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
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.rbWeb = new System.Windows.Forms.RadioButton();
		this.rbFolder = new System.Windows.Forms.RadioButton();
		this.txtImage = new System.Windows.Forms.TextBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbAnyCaptcha = new System.Windows.Forms.RadioButton();
		this.txtAnyCaptcha = new System.Windows.Forms.TextBox();
		this.rbCaptchafb = new System.Windows.Forms.RadioButton();
		this.txtCaptchafb = new System.Windows.Forms.TextBox();
		this.rb2Captcha = new System.Windows.Forms.RadioButton();
		this.txt2Captcha = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.rbMfb = new System.Windows.Forms.RadioButton();
		this.rbMbasic = new System.Windows.Forms.RadioButton();
		this.rbCustom = new System.Windows.Forms.RadioButton();
		this.rbThueCode = new System.Windows.Forms.RadioButton();
		this.txtThueCode = new System.Windows.Forms.TextBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.rbPrimeOtp = new System.Windows.Forms.RadioButton();
		this.txtPrimeOtp = new System.Windows.Forms.TextBox();
		this.rbTempCode = new System.Windows.Forms.RadioButton();
		this.rbOtpTextnow = new System.Windows.Forms.RadioButton();
		this.rbViotp = new System.Windows.Forms.RadioButton();
		this.txtTempCode = new System.Windows.Forms.TextBox();
		this.rbOtpfb = new System.Windows.Forms.RadioButton();
		this.txtOtpTextnow = new System.Windows.Forms.TextBox();
		this.txtViotp = new System.Windows.Forms.TextBox();
		this.rbSimCode = new System.Windows.Forms.RadioButton();
		this.txtOtpfb = new System.Windows.Forms.TextBox();
		this.txtSimCode = new System.Windows.Forms.TextBox();
		this.rbAhaSim = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.nudTime = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.txtAhaSim = new System.Windows.Forms.TextBox();
		this.rbOtpmmo = new System.Windows.Forms.RadioButton();
		this.txtOtpmmo = new System.Windows.Forms.TextBox();
		this.txtCustom = new System.Windows.Forms.TextBox();
		this.ckbImage = new System.Windows.Forms.CheckBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.rbServer = new System.Windows.Forms.RadioButton();
		this.txtServer = new System.Windows.Forms.TextBox();
		this.ckbCaptcha = new System.Windows.Forms.CheckBox();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.rbOtpSim = new System.Windows.Forms.RadioButton();
		this.txtOtpSim = new System.Windows.Forms.TextBox();
		this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
		this.panel5 = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.txtServiceId = new System.Windows.Forms.TextBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.panel4.SuspendLayout();
		this.panel3.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTime).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.panel5.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(413, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
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
		this.pnlHeader.Size = new System.Drawing.Size(413, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Class306.Bitmap_15;
		this.button1.Location = new System.Drawing.Point(382, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.panel4);
		this.panel1.Controls.Add(this.panel3);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.rbCustom);
		this.panel1.Controls.Add(this.rbThueCode);
		this.panel1.Controls.Add(this.txtThueCode);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.rbOtpmmo);
		this.panel1.Controls.Add(this.txtOtpmmo);
		this.panel1.Controls.Add(this.txtCustom);
		this.panel1.Controls.Add(this.ckbImage);
		this.panel1.Controls.Add(this.ckbPhone);
		this.panel1.Controls.Add(this.rbServer);
		this.panel1.Controls.Add(this.txtServer);
		this.panel1.Controls.Add(this.ckbCaptcha);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Controls.Add(this.rbOtpSim);
		this.panel1.Controls.Add(this.txtOtpSim);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(416, 676);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel4.Controls.Add(this.rbWeb);
		this.panel4.Controls.Add(this.rbFolder);
		this.panel4.Controls.Add(this.txtImage);
		this.panel4.Location = new System.Drawing.Point(28, 562);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(370, 63);
		this.panel4.TabIndex = 49;
		this.rbWeb.AutoSize = true;
		this.rbWeb.Location = new System.Drawing.Point(7, 33);
		this.rbWeb.Name = "rbWeb";
		this.rbWeb.Size = new System.Drawing.Size(88, 20);
		this.rbWeb.TabIndex = 38;
		this.rbWeb.Text = "Lấy từ web";
		this.rbWeb.UseVisualStyleBackColor = true;
		this.rbFolder.AutoSize = true;
		this.rbFolder.Checked = true;
		this.rbFolder.Location = new System.Drawing.Point(7, 4);
		this.rbFolder.Name = "rbFolder";
		this.rbFolder.Size = new System.Drawing.Size(144, 20);
		this.rbFolder.TabIndex = 38;
		this.rbFolder.TabStop = true;
		this.rbFolder.Text = "Đường dẫn thư mục:";
		this.rbFolder.UseVisualStyleBackColor = true;
		this.rbFolder.CheckedChanged += new System.EventHandler(rbFolder_CheckedChanged);
		this.txtImage.Location = new System.Drawing.Point(157, 3);
		this.txtImage.Name = "txtImage";
		this.txtImage.Size = new System.Drawing.Size(208, 23);
		this.txtImage.TabIndex = 37;
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.rbAnyCaptcha);
		this.panel3.Controls.Add(this.txtAnyCaptcha);
		this.panel3.Controls.Add(this.rbCaptchafb);
		this.panel3.Controls.Add(this.txtCaptchafb);
		this.panel3.Controls.Add(this.rb2Captcha);
		this.panel3.Controls.Add(this.txt2Captcha);
		this.panel3.Location = new System.Drawing.Point(32, 147);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(368, 83);
		this.panel3.TabIndex = 48;
		this.rbAnyCaptcha.AutoSize = true;
		this.rbAnyCaptcha.Location = new System.Drawing.Point(3, 29);
		this.rbAnyCaptcha.Name = "rbAnyCaptcha";
		this.rbAnyCaptcha.Size = new System.Drawing.Size(117, 20);
		this.rbAnyCaptcha.TabIndex = 44;
		this.rbAnyCaptcha.Text = "anycaptcha.com";
		this.rbAnyCaptcha.UseVisualStyleBackColor = true;
		this.rbAnyCaptcha.CheckedChanged += new System.EventHandler(rbAnyCaptcha_CheckedChanged);
		this.txtAnyCaptcha.Location = new System.Drawing.Point(123, 28);
		this.txtAnyCaptcha.Name = "txtAnyCaptcha";
		this.txtAnyCaptcha.Size = new System.Drawing.Size(240, 23);
		this.txtAnyCaptcha.TabIndex = 43;
		this.rbCaptchafb.AutoSize = true;
		this.rbCaptchafb.Location = new System.Drawing.Point(3, 3);
		this.rbCaptchafb.Name = "rbCaptchafb";
		this.rbCaptchafb.Size = new System.Drawing.Size(113, 20);
		this.rbCaptchafb.TabIndex = 42;
		this.rbCaptchafb.Text = "captchafb.com:";
		this.rbCaptchafb.UseVisualStyleBackColor = true;
		this.rbCaptchafb.CheckedChanged += new System.EventHandler(rbCaptchafb_CheckedChanged);
		this.txtCaptchafb.Location = new System.Drawing.Point(123, 2);
		this.txtCaptchafb.Name = "txtCaptchafb";
		this.txtCaptchafb.Size = new System.Drawing.Size(240, 23);
		this.txtCaptchafb.TabIndex = 34;
		this.rb2Captcha.AutoSize = true;
		this.rb2Captcha.Checked = true;
		this.rb2Captcha.Location = new System.Drawing.Point(3, 55);
		this.rb2Captcha.Name = "rb2Captcha";
		this.rb2Captcha.Size = new System.Drawing.Size(109, 20);
		this.rb2Captcha.TabIndex = 41;
		this.rb2Captcha.TabStop = true;
		this.rb2Captcha.Text = "2captcha.com:";
		this.rb2Captcha.UseVisualStyleBackColor = true;
		this.rb2Captcha.CheckedChanged += new System.EventHandler(rb2Captcha_CheckedChanged);
		this.txt2Captcha.Location = new System.Drawing.Point(123, 54);
		this.txt2Captcha.Name = "txt2Captcha";
		this.txt2Captcha.Size = new System.Drawing.Size(240, 23);
		this.txt2Captcha.TabIndex = 33;
		this.groupBox1.Controls.Add(this.rbMfb);
		this.groupBox1.Controls.Add(this.rbMbasic);
		this.groupBox1.Location = new System.Drawing.Point(32, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(368, 71);
		this.groupBox1.TabIndex = 47;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Giao diện";
		this.rbMfb.AutoSize = true;
		this.rbMfb.Location = new System.Drawing.Point(12, 17);
		this.rbMfb.Name = "rbMfb";
		this.rbMfb.Size = new System.Drawing.Size(119, 20);
		this.rbMfb.TabIndex = 46;
		this.rbMfb.Text = "m.facebook.com";
		this.rbMfb.UseVisualStyleBackColor = true;
		this.rbMbasic.AutoSize = true;
		this.rbMbasic.Checked = true;
		this.rbMbasic.Location = new System.Drawing.Point(12, 45);
		this.rbMbasic.Name = "rbMbasic";
		this.rbMbasic.Size = new System.Drawing.Size(148, 20);
		this.rbMbasic.TabIndex = 45;
		this.rbMbasic.TabStop = true;
		this.rbMbasic.Text = "mbasic.facebook.com";
		this.rbMbasic.UseVisualStyleBackColor = true;
		this.rbCustom.AutoSize = true;
		this.rbCustom.Location = new System.Drawing.Point(509, 471);
		this.rbCustom.Name = "rbCustom";
		this.rbCustom.Size = new System.Drawing.Size(73, 20);
		this.rbCustom.TabIndex = 44;
		this.rbCustom.Text = "Custom:";
		this.rbCustom.UseVisualStyleBackColor = true;
		this.rbCustom.CheckedChanged += new System.EventHandler(rbCustom_CheckedChanged);
		this.rbThueCode.AutoSize = true;
		this.rbThueCode.Location = new System.Drawing.Point(451, 357);
		this.rbThueCode.Name = "rbThueCode";
		this.rbThueCode.Size = new System.Drawing.Size(159, 20);
		this.rbThueCode.TabIndex = 46;
		this.rbThueCode.Text = "Thuecodetextnow.com:";
		this.rbThueCode.UseVisualStyleBackColor = true;
		this.rbThueCode.CheckedChanged += new System.EventHandler(rbThueCode_CheckedChanged);
		this.txtThueCode.Location = new System.Drawing.Point(610, 353);
		this.txtThueCode.Name = "txtThueCode";
		this.txtThueCode.Size = new System.Drawing.Size(201, 23);
		this.txtThueCode.TabIndex = 45;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.panel5);
		this.panel2.Controls.Add(this.rbPrimeOtp);
		this.panel2.Controls.Add(this.txtPrimeOtp);
		this.panel2.Controls.Add(this.rbTempCode);
		this.panel2.Controls.Add(this.rbOtpTextnow);
		this.panel2.Controls.Add(this.rbViotp);
		this.panel2.Controls.Add(this.rbOtpfb);
		this.panel2.Controls.Add(this.txtOtpTextnow);
		this.panel2.Controls.Add(this.txtViotp);
		this.panel2.Controls.Add(this.rbSimCode);
		this.panel2.Controls.Add(this.txtOtpfb);
		this.panel2.Controls.Add(this.txtSimCode);
		this.panel2.Controls.Add(this.rbAhaSim);
		this.panel2.Controls.Add(this.label3);
		this.panel2.Controls.Add(this.nudTime);
		this.panel2.Controls.Add(this.label2);
		this.panel2.Controls.Add(this.txtAhaSim);
		this.panel2.Location = new System.Drawing.Point(28, 264);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(371, 265);
		this.panel2.TabIndex = 38;
		this.rbPrimeOtp.AutoSize = true;
		this.rbPrimeOtp.Location = new System.Drawing.Point(6, 33);
		this.rbPrimeOtp.Name = "rbPrimeOtp";
		this.rbPrimeOtp.Size = new System.Drawing.Size(103, 20);
		this.rbPrimeOtp.TabIndex = 48;
		this.rbPrimeOtp.Text = "Primeotp.me:";
		this.rbPrimeOtp.UseVisualStyleBackColor = true;
		this.rbPrimeOtp.CheckedChanged += new System.EventHandler(rbPrimeOtp_CheckedChanged);
		this.txtPrimeOtp.Location = new System.Drawing.Point(165, 32);
		this.txtPrimeOtp.Name = "txtPrimeOtp";
		this.txtPrimeOtp.Size = new System.Drawing.Size(201, 23);
		this.txtPrimeOtp.TabIndex = 47;
		this.rbTempCode.AutoSize = true;
		this.rbTempCode.Checked = true;
		this.rbTempCode.Location = new System.Drawing.Point(6, 163);
		this.rbTempCode.Name = "rbTempCode";
		this.rbTempCode.Size = new System.Drawing.Size(107, 20);
		this.rbTempCode.TabIndex = 44;
		this.rbTempCode.TabStop = true;
		this.rbTempCode.Text = "Tempcode.co:";
		this.rbTempCode.UseVisualStyleBackColor = true;
		this.rbTempCode.CheckedChanged += new System.EventHandler(rbTempCode_CheckedChanged);
		this.rbOtpTextnow.AutoSize = true;
		this.rbOtpTextnow.Location = new System.Drawing.Point(6, 137);
		this.rbOtpTextnow.Name = "rbOtpTextnow";
		this.rbOtpTextnow.Size = new System.Drawing.Size(123, 20);
		this.rbOtpTextnow.TabIndex = 44;
		this.rbOtpTextnow.Text = "Otptextnow.com:";
		this.rbOtpTextnow.UseVisualStyleBackColor = true;
		this.rbOtpTextnow.CheckedChanged += new System.EventHandler(rbOtpTextnow_CheckedChanged);
		this.rbViotp.AutoSize = true;
		this.rbViotp.Location = new System.Drawing.Point(6, 111);
		this.rbViotp.Name = "rbViotp";
		this.rbViotp.Size = new System.Drawing.Size(87, 20);
		this.rbViotp.TabIndex = 44;
		this.rbViotp.Text = "Viotp.com:";
		this.rbViotp.UseVisualStyleBackColor = true;
		this.rbViotp.CheckedChanged += new System.EventHandler(rbViotp_CheckedChanged);
		this.txtTempCode.Location = new System.Drawing.Point(3, 3);
		this.txtTempCode.Name = "txtTempCode";
		this.txtTempCode.Size = new System.Drawing.Size(201, 23);
		this.txtTempCode.TabIndex = 43;
		this.rbOtpfb.AutoSize = true;
		this.rbOtpfb.Location = new System.Drawing.Point(6, 85);
		this.rbOtpfb.Name = "rbOtpfb";
		this.rbOtpfb.Size = new System.Drawing.Size(89, 20);
		this.rbOtpfb.TabIndex = 44;
		this.rbOtpfb.Text = "Otpfb.com:";
		this.rbOtpfb.UseVisualStyleBackColor = true;
		this.rbOtpfb.CheckedChanged += new System.EventHandler(rbOtpfb_CheckedChanged);
		this.txtOtpTextnow.Location = new System.Drawing.Point(165, 136);
		this.txtOtpTextnow.Name = "txtOtpTextnow";
		this.txtOtpTextnow.Size = new System.Drawing.Size(201, 23);
		this.txtOtpTextnow.TabIndex = 43;
		this.txtViotp.Location = new System.Drawing.Point(165, 110);
		this.txtViotp.Name = "txtViotp";
		this.txtViotp.Size = new System.Drawing.Size(201, 23);
		this.txtViotp.TabIndex = 43;
		this.rbSimCode.AutoSize = true;
		this.rbSimCode.Location = new System.Drawing.Point(6, 59);
		this.rbSimCode.Name = "rbSimCode";
		this.rbSimCode.Size = new System.Drawing.Size(152, 20);
		this.rbSimCode.TabIndex = 44;
		this.rbSimCode.Text = "Chothuesimcode.com:";
		this.rbSimCode.UseVisualStyleBackColor = true;
		this.rbSimCode.CheckedChanged += new System.EventHandler(rbSimCode_CheckedChanged);
		this.txtOtpfb.Location = new System.Drawing.Point(165, 84);
		this.txtOtpfb.Name = "txtOtpfb";
		this.txtOtpfb.Size = new System.Drawing.Size(201, 23);
		this.txtOtpfb.TabIndex = 43;
		this.txtSimCode.Location = new System.Drawing.Point(165, 58);
		this.txtSimCode.Name = "txtSimCode";
		this.txtSimCode.Size = new System.Drawing.Size(201, 23);
		this.txtSimCode.TabIndex = 43;
		this.rbAhaSim.AutoSize = true;
		this.rbAhaSim.Location = new System.Drawing.Point(6, 7);
		this.rbAhaSim.Name = "rbAhaSim";
		this.rbAhaSim.Size = new System.Drawing.Size(133, 20);
		this.rbAhaSim.TabIndex = 40;
		this.rbAhaSim.Text = "Supersim247.com:";
		this.rbAhaSim.UseVisualStyleBackColor = true;
		this.rbAhaSim.CheckedChanged += new System.EventHandler(rbAhaSim_CheckedChanged);
		this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(104, 234);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(30, 16);
		this.label3.TabIndex = 39;
		this.label3.Text = "giây";
		this.nudTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.nudTime.Location = new System.Drawing.Point(42, 231);
		this.nudTime.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTime.Name = "nudTime";
		this.nudTime.Size = new System.Drawing.Size(56, 23);
		this.nudTime.TabIndex = 38;
		this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(4, 234);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(34, 16);
		this.label2.TabIndex = 37;
		this.label2.Text = "Chờ:";
		this.txtAhaSim.Location = new System.Drawing.Point(165, 6);
		this.txtAhaSim.Name = "txtAhaSim";
		this.txtAhaSim.Size = new System.Drawing.Size(201, 23);
		this.txtAhaSim.TabIndex = 35;
		this.rbOtpmmo.AutoSize = true;
		this.rbOtpmmo.Location = new System.Drawing.Point(451, 330);
		this.rbOtpmmo.Name = "rbOtpmmo";
		this.rbOtpmmo.Size = new System.Drawing.Size(107, 20);
		this.rbOtpmmo.TabIndex = 46;
		this.rbOtpmmo.Text = "Otpmmo.com:";
		this.rbOtpmmo.UseVisualStyleBackColor = true;
		this.rbOtpmmo.Visible = false;
		this.rbOtpmmo.CheckedChanged += new System.EventHandler(rbOtpmmo_CheckedChanged);
		this.txtOtpmmo.Location = new System.Drawing.Point(564, 328);
		this.txtOtpmmo.Name = "txtOtpmmo";
		this.txtOtpmmo.Size = new System.Drawing.Size(201, 23);
		this.txtOtpmmo.TabIndex = 45;
		this.txtOtpmmo.Visible = false;
		this.txtCustom.Location = new System.Drawing.Point(668, 470);
		this.txtCustom.Name = "txtCustom";
		this.txtCustom.Size = new System.Drawing.Size(201, 23);
		this.txtCustom.TabIndex = 43;
		this.ckbImage.AutoSize = true;
		this.ckbImage.Location = new System.Drawing.Point(10, 535);
		this.ckbImage.Name = "ckbImage";
		this.ckbImage.Size = new System.Drawing.Size(71, 20);
		this.ckbImage.TabIndex = 36;
		this.ckbImage.Text = "Up ảnh:";
		this.ckbImage.UseVisualStyleBackColor = true;
		this.ckbImage.CheckedChanged += new System.EventHandler(ckbImage_CheckedChanged);
		this.ckbPhone.AutoSize = true;
		this.ckbPhone.Location = new System.Drawing.Point(10, 238);
		this.ckbPhone.Name = "ckbPhone";
		this.ckbPhone.Size = new System.Drawing.Size(93, 20);
		this.ckbPhone.TabIndex = 34;
		this.ckbPhone.Text = "Thêm SĐT:";
		this.ckbPhone.UseVisualStyleBackColor = true;
		this.ckbPhone.CheckedChanged += new System.EventHandler(ckbPhone_CheckedChanged);
		this.rbServer.AutoSize = true;
		this.rbServer.Location = new System.Drawing.Point(451, 383);
		this.rbServer.Name = "rbServer";
		this.rbServer.Size = new System.Drawing.Size(135, 20);
		this.rbServer.TabIndex = 42;
		this.rbServer.Text = "Servertextnow.xyz:";
		this.rbServer.UseVisualStyleBackColor = true;
		this.rbServer.CheckedChanged += new System.EventHandler(rbServer_CheckedChanged);
		this.txtServer.Location = new System.Drawing.Point(610, 382);
		this.txtServer.Name = "txtServer";
		this.txtServer.Size = new System.Drawing.Size(201, 23);
		this.txtServer.TabIndex = 41;
		this.ckbCaptcha.AutoSize = true;
		this.ckbCaptcha.Location = new System.Drawing.Point(11, 121);
		this.ckbCaptcha.Name = "ckbCaptcha";
		this.ckbCaptcha.Size = new System.Drawing.Size(100, 20);
		this.ckbCaptcha.TabIndex = 32;
		this.ckbCaptcha.Text = "Giải captcha:";
		this.ckbCaptcha.UseVisualStyleBackColor = true;
		this.ckbCaptcha.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(215, 636);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
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
		this.btnAdd.Location = new System.Drawing.Point(108, 636);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Lưu";
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
		this.bunifuCards1.Size = new System.Drawing.Size(413, 37);
		this.bunifuCards1.TabIndex = 28;
		this.rbOtpSim.AutoSize = true;
		this.rbOtpSim.Location = new System.Drawing.Point(451, 584);
		this.rbOtpSim.Name = "rbOtpSim";
		this.rbOtpSim.Size = new System.Drawing.Size(100, 20);
		this.rbOtpSim.TabIndex = 42;
		this.rbOtpSim.Text = "OtpSim.com:";
		this.rbOtpSim.UseVisualStyleBackColor = true;
		this.rbOtpSim.Visible = false;
		this.rbOtpSim.CheckedChanged += new System.EventHandler(rbOtpSim_CheckedChanged);
		this.txtOtpSim.Location = new System.Drawing.Point(540, 528);
		this.txtOtpSim.Name = "txtOtpSim";
		this.txtOtpSim.Size = new System.Drawing.Size(201, 23);
		this.txtOtpSim.TabIndex = 41;
		this.txtOtpSim.Visible = false;
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.txtServiceId);
		this.panel5.Controls.Add(this.label1);
		this.panel5.Controls.Add(this.txtTempCode);
		this.panel5.Location = new System.Drawing.Point(161, 165);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(208, 61);
		this.panel5.TabIndex = 49;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 36);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(69, 16);
		this.label1.TabIndex = 44;
		this.label1.Text = "service_id:";
		this.txtServiceId.Location = new System.Drawing.Point(78, 33);
		this.txtServiceId.Name = "txtServiceId";
		this.txtServiceId.Size = new System.Drawing.Size(127, 23);
		this.txtServiceId.TabIndex = 45;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(416, 676);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fCheckPoint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fCheckPoint_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTime).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		base.ResumeLayout(false);
	}
}
