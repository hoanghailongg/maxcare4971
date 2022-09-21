using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBackupData : Form
{
	private GClass17 gclass17_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

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

	private Panel plAnh;

	private CheckBox ckbAnhBanBe;

	private CheckBox ckbNgaySinh;

	private CheckBox ckbNhanTin;

	private NumericUpDown nudSoLuongAnh;

	private Label label10;

	private Label label7;

	private Label label3;

	private CheckBox ckbBinhLuan;

	private GroupBox groupBox1;

	private CheckBox ckbCreateHTML;

	private Panel plComment;

	private NumericUpDown nudSoThang;

	private Label label2;

	private Label label4;

	private Label label5;

	private CheckBox ckbBackupImageNangCao;

	private Button button2;

	public fHDBackupData(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		method_0();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class307.smethod_13("", "HDBackupData").Rows.Count == 0)
		{
			GClass32.GClass32_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBackupData', '{  \"ckbNgaySinh\": \"True\",  \"ckbAnhBanBe\": \"True\",  \"nudSoLuongAnh\": \"20\",  \"ckbNhanTin\": \"True\",  \"ckbBinhLuan\": \"True\",  \"ckbCreateHTML\": \"True\"}', 'Backup dữ liệu');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class307.smethod_13("", "HDBackupData");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = GClass29.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class307.smethod_15(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = GClass29.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass17_0 = new GClass17(text, bool_0: true);
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(ckbNgaySinh);
		GClass29.smethod_1(ckbAnhBanBe);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(ckbBackupImageNangCao);
		GClass29.smethod_1(button2);
		GClass29.smethod_1(ckbNhanTin);
		GClass29.smethod_1(ckbBinhLuan);
		GClass29.smethod_1(label4);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(ckbCreateHTML);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void fHDBackupData_Load(object sender, EventArgs e)
	{
		try
		{
			ckbNgaySinh.Checked = gclass17_0.method_3("ckbNgaySinh", bool_0: true);
			ckbAnhBanBe.Checked = gclass17_0.method_3("ckbAnhBanBe", bool_0: true);
			ckbBackupImageNangCao.Checked = gclass17_0.method_3("ckbBackupImageNangCao");
			nudSoLuongAnh.Value = gclass17_0.method_2("nudSoLuongAnh", 20);
			nudSoThang.Value = gclass17_0.method_2("nudSoThang", 5);
			ckbNhanTin.Checked = gclass17_0.method_3("ckbNhanTin", bool_0: true);
			ckbBinhLuan.Checked = gclass17_0.method_3("ckbBinhLuan", bool_0: true);
			ckbCreateHTML.Checked = gclass17_0.method_3("ckbCreateHTML", bool_0: true);
		}
		catch
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
		if (!ckbNgaySinh.Checked && !ckbAnhBanBe.Checked && !ckbNhanTin.Checked && !ckbBinhLuan.Checked)
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng chọn cấu hình backup!"), 3);
			return;
		}
		GClass17 gClass = new GClass17();
		gClass.method_5("ckbNgaySinh", ckbNgaySinh.Checked);
		gClass.method_5("ckbAnhBanBe", ckbAnhBanBe.Checked);
		gClass.method_5("ckbBackupImageNangCao", ckbBackupImageNangCao.Checked);
		gClass.method_5("nudSoLuongAnh", nudSoLuongAnh.Value);
		gClass.method_5("ckbNhanTin", ckbNhanTin.Checked);
		gClass.method_5("ckbBinhLuan", ckbBinhLuan.Checked);
		gClass.method_5("nudSoThang", nudSoThang.Value);
		gClass.method_5("ckbCreateHTML", ckbCreateHTML.Checked);
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
		method_2(null, null);
		ckbAnhBanBe_CheckedChanged(null, null);
		ckbBinhLuan_CheckedChanged(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbAnhBanBe_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnhBanBe.Checked;
	}

	private void ckbBinhLuan_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbBinhLuan.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass38.smethod_0(GClass29.smethod_0("Nếu tích tùy chọn này thì sẽ backup được nhiều ảnh bạn bè hơn.") + "\r\n" + GClass29.smethod_0("Đồng nghĩa với việc tốc độ backup sẽ chậm hơn!"));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBackupData));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
		this.ckbNhanTin = new System.Windows.Forms.CheckBox();
		this.plComment = new System.Windows.Forms.Panel();
		this.nudSoThang = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.ckbBackupImageNangCao = new System.Windows.Forms.CheckBox();
		this.nudSoLuongAnh = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbBinhLuan = new System.Windows.Forms.CheckBox();
		this.ckbAnhBanBe = new System.Windows.Forms.CheckBox();
		this.ckbCreateHTML = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoThang).BeginInit();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnh).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Backup dữ liệu";
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
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
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
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.ckbCreateHTML);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 373);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox1.Controls.Add(this.ckbNgaySinh);
		this.groupBox1.Controls.Add(this.ckbNhanTin);
		this.groupBox1.Controls.Add(this.plComment);
		this.groupBox1.Controls.Add(this.plAnh);
		this.groupBox1.Controls.Add(this.ckbBinhLuan);
		this.groupBox1.Controls.Add(this.ckbAnhBanBe);
		this.groupBox1.Location = new System.Drawing.Point(30, 82);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(295, 205);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình backup";
		this.ckbNgaySinh.AutoSize = true;
		this.ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNgaySinh.Location = new System.Drawing.Point(12, 20);
		this.ckbNgaySinh.Name = "ckbNgaySinh";
		this.ckbNgaySinh.Size = new System.Drawing.Size(82, 20);
		this.ckbNgaySinh.TabIndex = 0;
		this.ckbNgaySinh.Text = "Ngày sinh";
		this.ckbNgaySinh.UseVisualStyleBackColor = true;
		this.ckbNhanTin.AutoSize = true;
		this.ckbNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNhanTin.Location = new System.Drawing.Point(12, 122);
		this.ckbNhanTin.Name = "ckbNhanTin";
		this.ckbNhanTin.Size = new System.Drawing.Size(185, 20);
		this.ckbNhanTin.TabIndex = 2;
		this.ckbNhanTin.Text = "Danh sách nhắn tin gần đây";
		this.ckbNhanTin.UseVisualStyleBackColor = true;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.nudSoThang);
		this.plComment.Controls.Add(this.label2);
		this.plComment.Controls.Add(this.label4);
		this.plComment.Controls.Add(this.label5);
		this.plComment.Location = new System.Drawing.Point(30, 169);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(221, 27);
		this.plComment.TabIndex = 8;
		this.nudSoThang.Location = new System.Drawing.Point(119, 1);
		this.nudSoThang.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudSoThang.Name = "nudSoThang";
		this.nudSoThang.Size = new System.Drawing.Size(52, 23);
		this.nudSoThang.TabIndex = 0;
		this.nudSoThang.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(172, 3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(40, 16);
		this.label2.TabIndex = 151;
		this.label2.Text = "tháng";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label4.Location = new System.Drawing.Point(2, 3);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(100, 16);
		this.label4.TabIndex = 152;
		this.label4.Text = "Số lượng tháng:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(3, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(0, 16);
		this.label5.TabIndex = 31;
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.button2);
		this.plAnh.Controls.Add(this.ckbBackupImageNangCao);
		this.plAnh.Controls.Add(this.nudSoLuongAnh);
		this.plAnh.Controls.Add(this.label10);
		this.plAnh.Controls.Add(this.label7);
		this.plAnh.Controls.Add(this.label3);
		this.plAnh.Location = new System.Drawing.Point(30, 69);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(221, 50);
		this.plAnh.TabIndex = 8;
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(154, 25);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 153;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.ckbBackupImageNangCao.AutoSize = true;
		this.ckbBackupImageNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBackupImageNangCao.Location = new System.Drawing.Point(5, 26);
		this.ckbBackupImageNangCao.Name = "ckbBackupImageNangCao";
		this.ckbBackupImageNangCao.Size = new System.Drawing.Size(148, 20);
		this.ckbBackupImageNangCao.TabIndex = 0;
		this.ckbBackupImageNangCao.Text = "Backup ảnh nâng cao";
		this.ckbBackupImageNangCao.UseVisualStyleBackColor = true;
		this.nudSoLuongAnh.Location = new System.Drawing.Point(119, 1);
		this.nudSoLuongAnh.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudSoLuongAnh.Name = "nudSoLuongAnh";
		this.nudSoLuongAnh.Size = new System.Drawing.Size(52, 23);
		this.nudSoLuongAnh.TabIndex = 0;
		this.nudSoLuongAnh.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label10.Location = new System.Drawing.Point(173, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 151;
		this.label10.Text = "a\u0309nh";
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(2, 3);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(115, 16);
		this.label7.TabIndex = 152;
		this.label7.Text = "Số lươ\u0323ng a\u0309nh/ba\u0323n:";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(0, 16);
		this.label3.TabIndex = 31;
		this.ckbBinhLuan.AutoSize = true;
		this.ckbBinhLuan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBinhLuan.Location = new System.Drawing.Point(12, 148);
		this.ckbBinhLuan.Name = "ckbBinhLuan";
		this.ckbBinhLuan.Size = new System.Drawing.Size(142, 20);
		this.ckbBinhLuan.TabIndex = 3;
		this.ckbBinhLuan.Text = "Danh sách bình luận";
		this.ckbBinhLuan.UseVisualStyleBackColor = true;
		this.ckbBinhLuan.CheckedChanged += new System.EventHandler(ckbBinhLuan_CheckedChanged);
		this.ckbAnhBanBe.AutoSize = true;
		this.ckbAnhBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAnhBanBe.Location = new System.Drawing.Point(12, 46);
		this.ckbAnhBanBe.Name = "ckbAnhBanBe";
		this.ckbAnhBanBe.Size = new System.Drawing.Size(92, 20);
		this.ckbAnhBanBe.TabIndex = 1;
		this.ckbAnhBanBe.Text = "Ảnh bạn bè";
		this.ckbAnhBanBe.UseVisualStyleBackColor = true;
		this.ckbAnhBanBe.CheckedChanged += new System.EventHandler(ckbAnhBanBe_CheckedChanged);
		this.ckbCreateHTML.AutoSize = true;
		this.ckbCreateHTML.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCreateHTML.Location = new System.Drawing.Point(30, 293);
		this.ckbCreateHTML.Name = "ckbCreateHTML";
		this.ckbCreateHTML.Size = new System.Drawing.Size(267, 20);
		this.ckbCreateHTML.TabIndex = 2;
		this.ckbCreateHTML.Text = "Tự động tạo luôn File Html sau khi backup";
		this.ckbCreateHTML.UseVisualStyleBackColor = true;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
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
		this.btnCancel.Location = new System.Drawing.Point(189, 327);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
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
		this.btnAdd.Location = new System.Drawing.Point(82, 327);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
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
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(362, 373);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBackupData";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBackupData_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoThang).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnh).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
