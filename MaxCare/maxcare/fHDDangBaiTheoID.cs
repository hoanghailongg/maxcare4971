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

public class fHDDangBaiTheoID : Form
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

	private Panel plDangBaiLenNhom;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label label25;

	private Label label26;

	private CheckBox ckbDangBaiLenNhom;

	private CheckBox ckbDangBaiLenTuong;

	private CheckBox ckbOnlyDangNhomKhongKiemDuyet;

	private CheckBox ckbDelete;

	private Label label2;

	private CheckBox ckbDangBaiLenPage;

	private Panel panel4;

	private MetroButton btnNhapNhom;

	private RadioButton rbNhomTuNhap;

	private RadioButton rbNgauNhienNhomThamGia;

	private Label label27;

	private RichTextBox txtIdPost;

	public fHDDangBaiTheoID(string string_3, int int_1 = 0, string string_4 = "")
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
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', 'Đăng bài clone ID');");
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
		GClass29.smethod_1(ckbOnlyDangNhomKhongKiemDuyet);
		GClass29.smethod_1(ckbDangBaiLenPage);
		GClass29.smethod_1(label21);
		GClass29.smethod_1(label23);
		GClass29.smethod_1(label22);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDDangBaiTheoID_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass17_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass17_0.method_2("nudDelayTo", 5);
			ckbDangBaiLenTuong.Checked = gclass17_0.method_3("ckbDangBaiLenTuong");
			ckbDangBaiLenNhom.Checked = gclass17_0.method_3("ckbDangBaiLenNhom");
			if (gclass17_0.method_2("typePost") == 0)
			{
				rbNgauNhienNhomThamGia.Checked = true;
			}
			else
			{
				rbNhomTuNhap.Checked = true;
			}
			list_0 = gclass17_0.method_1("lstNhomTuNhap");
			ckbOnlyDangNhomKhongKiemDuyet.Checked = gclass17_0.method_3("ckbOnlyDangNhomKhongKiemDuyet");
			nudCountGroupFrom.Value = gclass17_0.method_2("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = gclass17_0.method_2("nudCountGroupTo", 1);
			ckbDangBaiLenPage.Checked = gclass17_0.method_3("ckbDangBaiLenPage");
			nudCountPageFrom.Value = gclass17_0.method_2("nudCountPageFrom", 1);
			nudCountPageTo.Value = gclass17_0.method_2("nudCountPageTo", 1);
			txtIdPost.Text = gclass17_0.method_0("txtIdPost");
			ckbDelete.Checked = gclass17_0.method_3("ckbDelete");
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
		if (txtIdPost.Text == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p id post cần clone!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_5("nudDelayTo", nudDelayTo.Value);
		gClass.method_5("ckbDangBaiLenTuong", ckbDangBaiLenTuong.Checked);
		gClass.method_5("ckbDangBaiLenNhom", ckbDangBaiLenNhom.Checked);
		int num = 0;
		if (rbNhomTuNhap.Checked)
		{
			num = 1;
		}
		gClass.method_5("typePost", num);
		gClass.method_6("lstNhomTuNhap", list_0);
		gClass.method_5("ckbOnlyDangNhomKhongKiemDuyet", ckbOnlyDangNhomKhongKiemDuyet.Checked);
		gClass.method_5("nudCountGroupFrom", nudCountGroupFrom.Value);
		gClass.method_5("nudCountGroupTo", nudCountGroupTo.Value);
		gClass.method_5("ckbDangBaiLenPage", ckbDangBaiLenPage.Checked);
		gClass.method_5("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.method_5("nudCountPageTo", nudCountPageTo.Value);
		gClass.method_5("txtIdPost", txtIdPost.Text.Trim());
		gClass.method_5("ckbDelete", ckbDelete.Checked);
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
		rbNhomTuNhap_CheckedChanged(null, null);
	}

	private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = ckbDangBaiLenNhom.Checked;
	}

	private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbDangBaiLenPage.Checked;
	}

	private void btnNhapNhom_Click(object sender, EventArgs e)
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

	private void rbNhomTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapNhom.Enabled = rbNhomTuNhap.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBaiTheoID));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.button1 = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbDelete = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plDangBaiLenPage = new System.Windows.Forms.Panel();
		this.label21 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.btnNhapNhom = new MetroFramework.Controls.MetroButton();
		this.rbNhomTuNhap = new System.Windows.Forms.RadioButton();
		this.rbNgauNhienNhomThamGia = new System.Windows.Forms.RadioButton();
		this.label27 = new System.Windows.Forms.Label();
		this.ckbOnlyDangNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
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
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.plDangBaiLenPage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
		this.plDangBaiLenNhom.SuspendLayout();
		this.panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(372, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Đăng bài theo ID";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(372, 31);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(342, 5);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 0;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.txtIdPost);
		this.panel1.Controls.Add(this.ckbDelete);
		this.panel1.Controls.Add(this.label2);
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
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(377, 642);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.ckbDelete.AutoSize = true;
		this.ckbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDelete.Location = new System.Drawing.Point(13, 567);
		this.ckbDelete.Name = "ckbDelete";
		this.ckbDelete.Size = new System.Drawing.Size(140, 20);
		this.ckbDelete.TabIndex = 65;
		this.ckbDelete.Text = "Tự động xóa id post";
		this.ckbDelete.UseVisualStyleBackColor = true;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(11, 387);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(115, 16);
		this.label2.TabIndex = 64;
		this.label2.Text = "Danh sách ID post:";
		this.groupBox2.Controls.Add(this.plDangBaiLenPage);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenPage);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbDangBaiLenTuong);
		this.groupBox2.Location = new System.Drawing.Point(14, 107);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(347, 277);
		this.groupBox2.TabIndex = 62;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn đăng";
		this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenPage.Controls.Add(this.label21);
		this.plDangBaiLenPage.Controls.Add(this.label22);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
		this.plDangBaiLenPage.Controls.Add(this.label23);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
		this.plDangBaiLenPage.Location = new System.Drawing.Point(25, 243);
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
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.panel4);
		this.plDangBaiLenNhom.Controls.Add(this.label27);
		this.plDangBaiLenNhom.Controls.Add(this.ckbOnlyDangNhomKhongKiemDuyet);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.label25);
		this.plDangBaiLenNhom.Controls.Add(this.label26);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(25, 80);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(310, 131);
		this.plDangBaiLenNhom.TabIndex = 1;
		this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel4.Controls.Add(this.btnNhapNhom);
		this.panel4.Controls.Add(this.rbNhomTuNhap);
		this.panel4.Controls.Add(this.rbNgauNhienNhomThamGia);
		this.panel4.Location = new System.Drawing.Point(20, 54);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(285, 50);
		this.panel4.TabIndex = 57;
		this.btnNhapNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapNhom.Location = new System.Drawing.Point(205, 23);
		this.btnNhapNhom.Name = "btnNhapNhom";
		this.btnNhapNhom.Size = new System.Drawing.Size(75, 23);
		this.btnNhapNhom.TabIndex = 1;
		this.btnNhapNhom.Text = "Nhâ\u0323p";
		this.btnNhapNhom.UseSelectable = true;
		this.btnNhapNhom.Click += new System.EventHandler(btnNhapNhom_Click);
		this.rbNhomTuNhap.AutoSize = true;
		this.rbNhomTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNhomTuNhap.Location = new System.Drawing.Point(4, 25);
		this.rbNhomTuNhap.Name = "rbNhomTuNhap";
		this.rbNhomTuNhap.Size = new System.Drawing.Size(176, 20);
		this.rbNhomTuNhap.TabIndex = 0;
		this.rbNhomTuNhap.Text = "Nho\u0301m do ngươ\u0300i du\u0300ng nhâ\u0323p";
		this.rbNhomTuNhap.UseVisualStyleBackColor = true;
		this.rbNhomTuNhap.CheckedChanged += new System.EventHandler(rbNhomTuNhap_CheckedChanged);
		this.rbNgauNhienNhomThamGia.AutoSize = true;
		this.rbNgauNhienNhomThamGia.Checked = true;
		this.rbNgauNhienNhomThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNgauNhienNhomThamGia.Location = new System.Drawing.Point(4, 3);
		this.rbNgauNhienNhomThamGia.Name = "rbNgauNhienNhomThamGia";
		this.rbNgauNhienNhomThamGia.Size = new System.Drawing.Size(197, 20);
		this.rbNgauNhienNhomThamGia.TabIndex = 0;
		this.rbNgauNhienNhomThamGia.TabStop = true;
		this.rbNgauNhienNhomThamGia.Text = "Ngâ\u0303u nhiên nho\u0301m đa\u0303 tham gia";
		this.rbNgauNhienNhomThamGia.UseVisualStyleBackColor = true;
		this.label27.AutoSize = true;
		this.label27.Location = new System.Drawing.Point(4, 35);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(154, 16);
		this.label27.TabIndex = 58;
		this.label27.Text = "Tu\u0300y cho\u0323n nho\u0301m đê\u0309 share:";
		this.ckbOnlyDangNhomKhongKiemDuyet.AutoSize = true;
		this.ckbOnlyDangNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyDangNhomKhongKiemDuyet.Location = new System.Drawing.Point(7, 110);
		this.ckbOnlyDangNhomKhongKiemDuyet.Name = "ckbOnlyDangNhomKhongKiemDuyet";
		this.ckbOnlyDangNhomKhongKiemDuyet.Size = new System.Drawing.Size(216, 20);
		this.ckbOnlyDangNhomKhongKiemDuyet.TabIndex = 2;
		this.ckbOnlyDangNhomKhongKiemDuyet.Text = "Chỉ đăng nhóm không kiểm duyệt";
		this.ckbOnlyDangNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.nudCountGroupTo.Location = new System.Drawing.Point(205, 5);
		this.nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupTo.Name = "nudCountGroupTo";
		this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupTo.TabIndex = 53;
		this.nudCountGroupFrom.Location = new System.Drawing.Point(108, 5);
		this.nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupFrom.Name = "nudCountGroupFrom";
		this.nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupFrom.TabIndex = 52;
		this.label24.Location = new System.Drawing.Point(170, 7);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(29, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = "đê\u0301n";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(261, 7);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(39, 16);
		this.label25.TabIndex = 55;
		this.label25.Text = "nhóm";
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(3, 7);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(99, 16);
		this.label26.TabIndex = 54;
		this.label26.Text = "Số lượng nhóm:";
		this.ckbDangBaiLenPage.AutoSize = true;
		this.ckbDangBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDangBaiLenPage.Location = new System.Drawing.Point(11, 217);
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
		this.nudDelayTo.Location = new System.Drawing.Point(222, 79);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(58, 23);
		this.nudDelayTo.TabIndex = 58;
		this.nudDelayFrom.Location = new System.Drawing.Point(125, 79);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(58, 23);
		this.nudDelayFrom.TabIndex = 57;
		this.label20.Location = new System.Drawing.Point(187, 81);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(31, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = "đê\u0301n";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(286, 81);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(30, 16);
		this.label19.TabIndex = 60;
		this.label19.Text = "giây";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(11, 81);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(116, 16);
		this.label15.TabIndex = 59;
		this.label15.Text = "Khoảng cách đăng:";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(92, 600);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(11, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(191, 600);
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
		this.bunifuCards1.Controls.Add(this.button1);
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(375, 37);
		this.bunifuCards1.TabIndex = 28;
		this.txtIdPost.Location = new System.Drawing.Point(13, 406);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(348, 155);
		this.txtIdPost.TabIndex = 66;
		this.txtIdPost.Text = "";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(377, 642);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBaiTheoID";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangBaiTheoID_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plDangBaiLenPage.ResumeLayout(false);
		this.plDangBaiLenPage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
