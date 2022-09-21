using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu2 : Form
{
	private string string_0 = "";

	private Random random_0 = new Random();

	private bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel lblTitle;

	private Button btnSave;

	private TextBox txtContent;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	public DataGridView dtgvDanhSach;

	private Button btnAdd;

	private DataGridViewTextBoxColumn cSTT;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewButtonColumn cChiTiet;

	private DataGridViewButtonColumn cSua;

	private DataGridViewButtonColumn cXoa;

	private Button btnHuy;

	public fNhapDuLieu2(string string_1, string string_2)
	{
		InitializeComponent();
		method_0();
		string_0 = string_1;
		lblTitle.Text = string_2;
	}

	private void method_0()
	{
		GClass29.smethod_1(lblTitle);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(groupBox2);
		foreach (DataGridViewColumn column in dtgvDanhSach.Columns)
		{
			GClass29.smethod_3(column);
		}
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnSave);
		GClass29.smethod_1(btnHuy);
	}

	private void fNhapDuLieu2_Load(object sender, EventArgs e)
	{
		GClass14.smethod_32(string_0);
		method_2(string_0);
	}

	private void method_1(int int_0)
	{
		txtContent.Lines = File.ReadAllLines(Class309.smethod_3(dtgvDanhSach, int_0, "cName"));
	}

	private void method_2(string string_1)
	{
		int num = -1;
		switch (dtgvDanhSach.RowCount)
		{
		default:
			num = dtgvDanhSach.SelectedRows[0].Index;
			break;
		case 1:
			num = 0;
			break;
		case 0:
			break;
		}
		dtgvDanhSach.Rows.Clear();
		List<string> list = Directory.GetFiles(string_1).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			dtgvDanhSach.Rows.Add(i + 1, list[i], GClass29.smethod_0("Chi tiê\u0301t"), GClass29.smethod_0("Sư\u0309a"), GClass29.smethod_0("Xo\u0301a"));
		}
		if (num == -1 && dtgvDanhSach.RowCount > 0)
		{
			num = 0;
		}
		else if (num + 1 > dtgvDanhSach.RowCount)
		{
			num = dtgvDanhSach.RowCount - 1;
		}
		if (num == -1)
		{
			txtContent.Text = "";
			return;
		}
		GClass14.smethod_31(dtgvDanhSach);
		dtgvDanhSach.Rows[num].Selected = true;
		method_1(num);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_3(int int_0)
	{
		if (int_0 == 1)
		{
			dtgvDanhSach.Enabled = false;
			btnAdd.Enabled = false;
			btnSave.Enabled = true;
			btnHuy.Enabled = true;
			txtContent.ReadOnly = false;
			txtContent.Focus();
		}
		else
		{
			dtgvDanhSach.Enabled = true;
			btnAdd.Enabled = true;
			btnSave.Enabled = false;
			btnHuy.Enabled = false;
			txtContent.ReadOnly = true;
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			string text2;
			do
			{
				text2 = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + GClass14.smethod_55(3, random_0) + ".txt";
			}
			while (File.Exists(text2));
			text = string_0 + "\\" + text2;
			GClass14.smethod_30(text);
			txtContent.Lines = File.ReadAllLines(text);
			dtgvDanhSach.Rows.Add(dtgvDanhSach.RowCount + 1, text, GClass29.smethod_0("Chi tiê\u0301t"), GClass29.smethod_0("Sư\u0309a"), GClass29.smethod_0("Xo\u0301a"));
			GClass14.smethod_31(dtgvDanhSach);
			dtgvDanhSach.Rows[dtgvDanhSach.RowCount - 1].Selected = true;
			method_3(1);
			bool_0 = true;
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void txtContent_TextChanged(object sender, EventArgs e)
	{
	}

	private void dtgvDanhSach_MouseHover(object sender, EventArgs e)
	{
	}

	private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		string name = dtgvDanhSach.Columns[e.ColumnIndex].Name;
		if (name != "cChiTiet" && name != "cSua" && name != "cXoa")
		{
			dtgvDanhSach.Cursor = Cursors.Default;
		}
		else if (e.RowIndex < dtgvDanhSach.RowCount)
		{
			dtgvDanhSach.Cursor = Cursors.Hand;
		}
	}

	private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (!(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
		{
			return;
		}
		switch (dataGridView.Columns[e.ColumnIndex].Name)
		{
		case "cXoa":
			if (GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn xóa?")) == DialogResult.Yes)
			{
				File.Delete(Class309.smethod_3(dtgvDanhSach, e.RowIndex, "cName"));
				method_2(string_0);
			}
			break;
		case "cSua":
			txtContent.Lines = File.ReadAllLines(Class309.smethod_3(dtgvDanhSach, e.RowIndex, "cName"));
			bool_0 = false;
			method_3(1);
			break;
		case "cChiTiet":
			method_1(e.RowIndex);
			break;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			string path = dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
			GClass14.smethod_30(path);
			if (txtContent.Text.Trim() == "")
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng nhập nội dung cần lưu!"), 3);
			}
			else if (GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn lưu lại?")) == DialogResult.Yes)
			{
				File.WriteAllLines(path, txtContent.Lines);
				GClass38.smethod_0(GClass29.smethod_0("Lưu thành công!"));
				method_3(2);
			}
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		try
		{
			string path = dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
			GClass14.smethod_30(path);
			if (GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn hủy?")) == DialogResult.Yes)
			{
				if (bool_0)
				{
					File.Delete(path);
				}
				method_3(2);
				method_2(string_0);
			}
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
		this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
		this.cSua = new System.Windows.Forms.DataGridViewButtonColumn();
		this.cXoa = new System.Windows.Forms.DataGridViewButtonColumn();
		this.btnAdd = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.txtContent = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.btnHuy = new System.Windows.Forms.Button();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).BeginInit();
		this.groupBox2.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(425, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(754, 388);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox1.Controls.Add(this.dtgvDanhSach);
		this.groupBox1.Controls.Add(this.btnAdd);
		this.groupBox1.Location = new System.Drawing.Point(3, 43);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(284, 339);
		this.groupBox1.TabIndex = 50;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = " Danh sa\u0301ch nô\u0323i dung";
		this.dtgvDanhSach.AllowUserToAddRows = false;
		this.dtgvDanhSach.AllowUserToDeleteRows = false;
		this.dtgvDanhSach.AllowUserToResizeRows = false;
		this.dtgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvDanhSach.Columns.AddRange(this.cSTT, this.cName, this.cChiTiet, this.cSua, this.cXoa);
		this.dtgvDanhSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvDanhSach.Location = new System.Drawing.Point(6, 22);
		this.dtgvDanhSach.Name = "dtgvDanhSach";
		this.dtgvDanhSach.RowHeadersVisible = false;
		this.dtgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvDanhSach.Size = new System.Drawing.Size(272, 277);
		this.dtgvDanhSach.TabIndex = 76;
		this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvDanhSach_CellContentClick);
		this.dtgvDanhSach.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvDanhSach_CellMouseEnter);
		this.dtgvDanhSach.MouseHover += new System.EventHandler(dtgvDanhSach_MouseHover);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cSTT.DefaultCellStyle = dataGridViewCellStyle2;
		this.cSTT.HeaderText = "STT";
		this.cSTT.Name = "cSTT";
		this.cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cSTT.Width = 40;
		this.cName.HeaderText = "Tên file";
		this.cName.Name = "cName";
		this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cName.Visible = false;
		this.cChiTiet.HeaderText = "Chi tiê\u0301t";
		this.cChiTiet.Name = "cChiTiet";
		this.cChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cChiTiet.Width = 80;
		this.cSua.HeaderText = "Sư\u0309a";
		this.cSua.Name = "cSua";
		this.cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cSua.Width = 71;
		this.cXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cXoa.HeaderText = "Xo\u0301a";
		this.cXoa.Name = "cXoa";
		this.cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.btnAdd.BackColor = System.Drawing.Color.Green;
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(186, 303);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.groupBox2.Controls.Add(this.txtContent);
		this.groupBox2.Controls.Add(this.btnHuy);
		this.groupBox2.Controls.Add(this.btnSave);
		this.groupBox2.Location = new System.Drawing.Point(293, 43);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(455, 339);
		this.groupBox2.TabIndex = 50;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Chi tiê\u0301t";
		this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtContent.Location = new System.Drawing.Point(5, 22);
		this.txtContent.Multiline = true;
		this.txtContent.Name = "txtContent";
		this.txtContent.ReadOnly = true;
		this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtContent.Size = new System.Drawing.Size(444, 277);
		this.txtContent.TabIndex = 48;
		this.txtContent.WordWrap = false;
		this.txtContent.TextChanged += new System.EventHandler(txtContent_TextChanged);
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.Enabled = false;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(256, 304);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 45;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
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
		this.bunifuCards2.Size = new System.Drawing.Size(752, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.lblTitle);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(752, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(721, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Location = new System.Drawing.Point(899, 1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.lblTitle.BackColor = System.Drawing.Color.Transparent;
		this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTitle.ForeColor = System.Drawing.Color.Black;
		this.lblTitle.Location = new System.Drawing.Point(0, 0);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(752, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Nhập nội dung comment";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.lblTitle;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
		this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHuy.Enabled = false;
		this.btnHuy.FlatAppearance.BorderSize = 0;
		this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnHuy.ForeColor = System.Drawing.Color.White;
		this.btnHuy.Location = new System.Drawing.Point(357, 304);
		this.btnHuy.Name = "btnHuy";
		this.btnHuy.Size = new System.Drawing.Size(92, 29);
		this.btnHuy.TabIndex = 45;
		this.btnHuy.Text = "Hủy";
		this.btnHuy.UseVisualStyleBackColor = false;
		this.btnHuy.Click += new System.EventHandler(btnHuy_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(754, 388);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapDuLieu2_Load);
		this.panel1.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
