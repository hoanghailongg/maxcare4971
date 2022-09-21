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

public class fHDShareBaiv2 : Form
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

	private CheckBox ckbVanBan;

	private Panel plVanBan;

	private Label lblStatus;

	private RichTextBox txtNoiDung;

	private MetroButton btnDown;

	private MetroButton btnUp;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label20;

	private Label label19;

	private Label label15;

	private GroupBox groupBox2;

	private Panel plDangBaiLenNhom;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label label25;

	private Label label26;

	private CheckBox ckbShareBaiLenNhom;

	private Button button3;

	private Button button2;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Label label8;

	private Label label2;

	private TextBox txtLinkChiaSe;

	private CheckBox ckbOnlyShareNhomKhongKiemDuyet;

	private Label label4;

	private CheckBox ckbNhomTuNhap;

	private Button button8;

	private CheckBox ckbKhongShareTrung;

	public fHDShareBaiv2(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Share bài v2";
		if (Class307.smethod_13("", text).Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text3, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label15);
		GClass29.smethod_1(label20);
		GClass29.smethod_1(label19);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(ckbShareBaiLenNhom);
		GClass29.smethod_1(label26);
		GClass29.smethod_1(label24);
		GClass29.smethod_1(label25);
		GClass29.smethod_1(ckbOnlyShareNhomKhongKiemDuyet);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(ckbVanBan);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(label8);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
		GClass29.smethod_1(rbNganCachMoiDong);
		GClass29.smethod_1(rbNganCachKyTu);
	}

	private void fHDShareBaiv2_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			ckbShareBaiLenNhom.Checked = gclass17_0.method_3("ckbShareBaiLenNhom");
			ckbOnlyShareNhomKhongKiemDuyet.Checked = gclass17_0.method_3("ckbOnlyShareNhomKhongKiemDuyet");
			ckbNhomTuNhap.Checked = gclass17_0.method_3("ckbNhomTuNhap");
			list_0 = gclass17_0.method_1("lstNhomTuNhap");
			ckbKhongShareTrung.Checked = gclass17_0.method_3("ckbKhongShareTrung");
			nudCountGroupFrom.Value = gclass17_0.method_2("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = gclass17_0.method_2("nudCountGroupTo", 1);
			txtLinkChiaSe.Text = gclass17_0.method_0("txtLinkChiaSe");
			ckbVanBan.Checked = gclass17_0.method_3("ckbVanBan");
			txtNoiDung.Text = gclass17_0.method_0("txtNoiDung");
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
		gClass.method_5("ckbShareBaiLenNhom", ckbShareBaiLenNhom.Checked);
		gClass.method_5("ckbOnlyShareNhomKhongKiemDuyet", ckbOnlyShareNhomKhongKiemDuyet.Checked);
		gClass.method_5("ckbNhomTuNhap", ckbNhomTuNhap.Checked);
		gClass.method_6("lstNhomTuNhap", list_0);
		gClass.method_5("ckbKhongShareTrung", ckbKhongShareTrung.Checked);
		gClass.method_5("nudCountGroupFrom", nudCountGroupFrom.Value);
		gClass.method_5("nudCountGroupTo", nudCountGroupTo.Value);
		gClass.method_5("txtLinkChiaSe", txtLinkChiaSe.Text.Trim());
		gClass.method_5("ckbVanBan", ckbVanBan.Checked);
		gClass.method_5("txtNoiDung", txtNoiDung.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.method_5("typeNganCach", num);
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
		method_5(null, null);
		method_6(null, null);
		method_4(null, null);
		ckbShareBaiLenNhom_CheckedChanged(null, null);
		method_3(null, null);
		ckbVanBan_CheckedChanged(null, null);
		ckbNhomTuNhap_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
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
		plVanBan.Height = 216;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 169;
	}

	private void ckbShareBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = ckbShareBaiLenNhom.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtNoiDung.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fHelpNhapComment());
		txtNoiDung.Focus();
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
	{
		List<string> list = txtLinkChiaSe.Lines.ToList();
		list = GClass14.smethod_36(list);
		label2.Text = $"Link bài cần share ({list.Count}):";
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

	private void ckbNhomTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		button8.Enabled = ckbNhomTuNhap.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDShareBaiv2));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.txtLinkChiaSe = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.ckbKhongShareTrung = new System.Windows.Forms.CheckBox();
		this.button8 = new System.Windows.Forms.Button();
		this.ckbNhomTuNhap = new System.Windows.Forms.CheckBox();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.ckbOnlyShareNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
		this.label26 = new System.Windows.Forms.Label();
		this.ckbShareBaiLenNhom = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
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
		this.btnAdd = new System.Windows.Forms.Button();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.plDangBaiLenNhom.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.plVanBan.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(537, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Share bài v2";
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
		this.pnlHeader.Size = new System.Drawing.Size(537, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(506, 1);
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
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.txtLinkChiaSe);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.plVanBan);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.ckbVanBan);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(540, 646);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.label4.Location = new System.Drawing.Point(209, 249);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(302, 16);
		this.label4.TabIndex = 64;
		this.label4.Text = "(Tool sẽ lấy random 1 trong các link dưới để share)";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 249);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(137, 16);
		this.label2.TabIndex = 64;
		this.label2.Text = "Link bài cần share (0):";
		this.txtLinkChiaSe.Location = new System.Drawing.Point(30, 269);
		this.txtLinkChiaSe.Multiline = true;
		this.txtLinkChiaSe.Name = "txtLinkChiaSe";
		this.txtLinkChiaSe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtLinkChiaSe.Size = new System.Drawing.Size(476, 122);
		this.txtLinkChiaSe.TabIndex = 63;
		this.txtLinkChiaSe.WordWrap = false;
		this.txtLinkChiaSe.TextChanged += new System.EventHandler(txtLinkChiaSe_TextChanged);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenNhom);
		this.groupBox2.Location = new System.Drawing.Point(30, 107);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(476, 137);
		this.groupBox2.TabIndex = 62;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn share";
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.ckbKhongShareTrung);
		this.plDangBaiLenNhom.Controls.Add(this.button8);
		this.plDangBaiLenNhom.Controls.Add(this.ckbNhomTuNhap);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.label25);
		this.plDangBaiLenNhom.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
		this.plDangBaiLenNhom.Controls.Add(this.label26);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(149, 20);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(310, 111);
		this.plDangBaiLenNhom.TabIndex = 1;
		this.ckbKhongShareTrung.AutoSize = true;
		this.ckbKhongShareTrung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongShareTrung.Location = new System.Drawing.Point(6, 80);
		this.ckbKhongShareTrung.Name = "ckbKhongShareTrung";
		this.ckbKhongShareTrung.Size = new System.Drawing.Size(168, 20);
		this.ckbKhongShareTrung.TabIndex = 59;
		this.ckbKhongShareTrung.Text = "Không share trùng nhóm";
		this.ckbKhongShareTrung.UseVisualStyleBackColor = true;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Location = new System.Drawing.Point(153, 52);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(75, 23);
		this.button8.TabIndex = 58;
		this.button8.Text = "Nhập";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.ckbNhomTuNhap.AutoSize = true;
		this.ckbNhomTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNhomTuNhap.Location = new System.Drawing.Point(6, 54);
		this.ckbNhomTuNhap.Name = "ckbNhomTuNhap";
		this.ckbNhomTuNhap.Size = new System.Drawing.Size(145, 20);
		this.ckbNhomTuNhap.TabIndex = 57;
		this.ckbNhomTuNhap.Text = "Share nhóm tự nhập";
		this.ckbNhomTuNhap.UseVisualStyleBackColor = true;
		this.ckbNhomTuNhap.CheckedChanged += new System.EventHandler(ckbNhomTuNhap_CheckedChanged);
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
		this.label24.Size = new System.Drawing.Size(29, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = "đê\u0301n";
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(264, 5);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(40, 16);
		this.label25.TabIndex = 55;
		this.label25.Text = "nhóm";
		this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
		this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyShareNhomKhongKiemDuyet.Location = new System.Drawing.Point(6, 28);
		this.ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
		this.ckbOnlyShareNhomKhongKiemDuyet.Size = new System.Drawing.Size(221, 20);
		this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
		this.ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
		this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(3, 5);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(100, 16);
		this.label26.TabIndex = 54;
		this.label26.Text = "Số lượng nhóm:";
		this.ckbShareBaiLenNhom.AutoSize = true;
		this.ckbShareBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenNhom.Location = new System.Drawing.Point(6, 22);
		this.ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
		this.ckbShareBaiLenNhom.Size = new System.Drawing.Size(139, 20);
		this.ckbShareBaiLenNhom.TabIndex = 0;
		this.ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
		this.ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
		this.ckbShareBaiLenNhom.CheckedChanged += new System.EventHandler(ckbShareBaiLenNhom_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(251, 79);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 58;
		this.nudDelayFrom.Location = new System.Drawing.Point(154, 79);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 57;
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(216, 81);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(29, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = "đê\u0301n";
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(310, 81);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(31, 16);
		this.label19.TabIndex = 60;
		this.label19.Text = "giây";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(27, 81);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(121, 16);
		this.label15.TabIndex = 59;
		this.label15.Text = "Khoảng cách share:";
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
		this.plVanBan.Location = new System.Drawing.Point(49, 421);
		this.plVanBan.Name = "plVanBan";
		this.plVanBan.Size = new System.Drawing.Size(457, 169);
		this.plVanBan.TabIndex = 33;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(230, 189);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 44;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(230, 166);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 23);
		this.button2.TabIndex = 45;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(71, 189);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		this.rbNganCachKyTu.TabIndex = 42;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(71, 168);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		this.rbNganCachMoiDong.TabIndex = 43;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(6, 168);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(65, 16);
		this.label9.TabIndex = 41;
		this.label9.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(5, 147);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(144, 16);
		this.label8.TabIndex = 40;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnDown.BackgroundImage = Class306.Bitmap_123;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(400, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 38;
		this.btnDown.UseSelectable = true;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnUp.BackgroundImage = Class306.Bitmap_103;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(431, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 39;
		this.btnUp.UseSelectable = true;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtNoiDung.Location = new System.Drawing.Point(7, 26);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(442, 119);
		this.txtNoiDung.TabIndex = 34;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(146, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(174, 604);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(30, 397);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(113, 20);
		this.ckbVanBan.TabIndex = 32;
		this.ckbVanBan.Text = "Nội dung share";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		this.txtTenHanhDong.Location = new System.Drawing.Point(154, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(99, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(273, 604);
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
		this.bunifuCards1.Size = new System.Drawing.Size(537, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(540, 646);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDShareBaiv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDShareBaiv2_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.plVanBan.ResumeLayout(false);
		this.plVanBan.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
