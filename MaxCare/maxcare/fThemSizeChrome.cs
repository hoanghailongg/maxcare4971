using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fThemSizeChrome : Form
{
	private Random random_0 = new Random();

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

	private GroupBox grDanhSach;

	private GroupBox grChiTiet;

	public DataGridView dtgvDanhSach;

	private Button btnAdd;

	private Button btnHuy;

	private TextBox txtTen;

	private Label label2;

	private Label label1;

	private NumericUpDown nudHeight;

	private NumericUpDown nudWidth;

	private Label label11;

	private Label label3;

	private DataGridViewTextBoxColumn cSTT;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cSize;

	private DataGridViewTextBoxColumn cPixelRatio;

	private DataGridViewButtonColumn cSua;

	private DataGridViewButtonColumn cXoa;

	private TextBox txtPixelRatio;

	public fThemSizeChrome()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(lblTitle);
		GClass29.smethod_1(grDanhSach);
		GClass29.smethod_1(label1);
		foreach (DataGridViewColumn column in dtgvDanhSach.Columns)
		{
			GClass29.smethod_3(column);
		}
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(btnSave);
		GClass29.smethod_1(btnHuy);
	}

	private void fThemSizeChrome_Load(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_1(int int_0)
	{
		try
		{
			txtTen.Text = Class309.smethod_3(dtgvDanhSach, int_0, "cName");
			string text = Class309.smethod_3(dtgvDanhSach, int_0, "cSize");
			txtPixelRatio.Text = ((Class309.smethod_3(dtgvDanhSach, int_0, "cPixelRatio") == "") ? "0" : Class309.smethod_3(dtgvDanhSach, int_0, "cPixelRatio"));
			nudWidth.Value = Convert.ToInt32(text.Split('x')[0]);
			nudHeight.Value = Convert.ToInt32(text.Split('x')[1]);
		}
		catch
		{
		}
	}

	private void method_2()
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
		GClass17 gClass = new GClass17("configChrome");
		if (!(gClass.method_0("sizeChrome") != ""))
		{
			return;
		}
		Dictionary<string, object> dictionary = GClass17.smethod_0(JObject.Parse(gClass.method_0("sizeChrome")));
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			if (item.Value.ToString().Split('x').Length == 3)
			{
				dtgvDanhSach.Rows.Add(dtgvDanhSach.RowCount + 1, item.Key, item.Value.ToString().Substring(0, item.Value.ToString().LastIndexOf('x')), item.Value.ToString().Split('x')[2], "Sư\u0309a", "Xo\u0301a");
			}
			else
			{
				dtgvDanhSach.Rows.Add(dtgvDanhSach.RowCount + 1, item.Key, item.Value.ToString().Substring(0, item.Value.ToString().LastIndexOf('x')), "", "Sư\u0309a", "Xo\u0301a");
			}
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
			txtTen.Text = "";
			nudWidth.Value = 0m;
			nudHeight.Value = 0m;
		}
		else
		{
			GClass14.smethod_31(dtgvDanhSach);
			dtgvDanhSach.Rows[num].Selected = true;
			method_1(num);
		}
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
		switch (int_0)
		{
		case 1:
			grDanhSach.Enabled = false;
			grChiTiet.Enabled = true;
			txtTen.Clear();
			txtTen.Focus();
			nudWidth.Value = 0m;
			nudHeight.Value = 0m;
			break;
		case 2:
			grDanhSach.Enabled = true;
			grChiTiet.Enabled = false;
			break;
		case 3:
			grDanhSach.Enabled = false;
			grChiTiet.Enabled = true;
			break;
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		method_3(1);
	}

	private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		string name = dtgvDanhSach.Columns[e.ColumnIndex].Name;
		if (name != "cSua" && name != "cXoa")
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
		string name = dataGridView.Columns[e.ColumnIndex].Name;
		string text = name;
		if (!(text == "cSua"))
		{
			if (text == "cXoa" && GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn xóa?")) == DialogResult.Yes)
			{
				GClass17 gClass = new GClass17(new GClass17("configChrome").method_0("sizeChrome"), bool_0: true);
				gClass.method_7(Class309.smethod_3(dtgvDanhSach, dtgvDanhSach.CurrentRow.Index, "cName"));
				GClass17 gClass2 = new GClass17("configChrome");
				gClass2.method_5("sizeChrome", gClass.method_9());
				gClass2.method_8();
				method_2();
			}
		}
		else
		{
			method_3(3);
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			if (txtTen.Text.Trim() == "")
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng điền tên thiết bị!"), 3);
			}
			else if (GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn lưu lại?")) == DialogResult.Yes)
			{
				GClass17 gClass = new GClass17(new GClass17("configChrome").method_0("sizeChrome"), bool_0: true);
				gClass.method_5(txtTen.Text.Trim(), nudWidth.Value + "x" + nudHeight.Value + "x" + txtPixelRatio.Text.Trim());
				GClass17 gClass2 = new GClass17("configChrome");
				gClass2.method_5("sizeChrome", gClass.method_9());
				gClass2.method_8();
				method_2();
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
			if (GClass38.smethod_1(GClass29.smethod_0("Bạn có muốn hủy?")) == DialogResult.Yes)
			{
				method_3(2);
			}
		}
		catch
		{
		}
	}

	private void dtgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		method_1(dtgvDanhSach.CurrentRow.Index);
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
		this.grDanhSach = new System.Windows.Forms.GroupBox();
		this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
		this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPixelRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cSua = new System.Windows.Forms.DataGridViewButtonColumn();
		this.cXoa = new System.Windows.Forms.DataGridViewButtonColumn();
		this.btnAdd = new System.Windows.Forms.Button();
		this.grChiTiet = new System.Windows.Forms.GroupBox();
		this.nudHeight = new System.Windows.Forms.NumericUpDown();
		this.nudWidth = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.txtTen = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnHuy = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.txtPixelRatio = new System.Windows.Forms.TextBox();
		this.panel1.SuspendLayout();
		this.grDanhSach.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).BeginInit();
		this.grChiTiet.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudHeight).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudWidth).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(415, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.grDanhSach);
		this.panel1.Controls.Add(this.grChiTiet);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(744, 388);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.grDanhSach.Controls.Add(this.dtgvDanhSach);
		this.grDanhSach.Controls.Add(this.btnAdd);
		this.grDanhSach.Location = new System.Drawing.Point(3, 43);
		this.grDanhSach.Name = "grDanhSach";
		this.grDanhSach.Size = new System.Drawing.Size(473, 339);
		this.grDanhSach.TabIndex = 50;
		this.grDanhSach.TabStop = false;
		this.grDanhSach.Text = "Danh sách Kích thước Chrome";
		this.dtgvDanhSach.AllowUserToAddRows = false;
		this.dtgvDanhSach.AllowUserToDeleteRows = false;
		this.dtgvDanhSach.AllowUserToResizeRows = false;
		this.dtgvDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
		this.dtgvDanhSach.Columns.AddRange(this.cSTT, this.cName, this.cSize, this.cPixelRatio, this.cSua, this.cXoa);
		this.dtgvDanhSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvDanhSach.Location = new System.Drawing.Point(6, 22);
		this.dtgvDanhSach.Name = "dtgvDanhSach";
		this.dtgvDanhSach.RowHeadersVisible = false;
		this.dtgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvDanhSach.Size = new System.Drawing.Size(461, 277);
		this.dtgvDanhSach.TabIndex = 76;
		this.dtgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvDanhSach_CellClick);
		this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvDanhSach_CellContentClick);
		this.dtgvDanhSach.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvDanhSach_CellMouseEnter);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cSTT.DefaultCellStyle = dataGridViewCellStyle2;
		this.cSTT.HeaderText = "STT";
		this.cSTT.Name = "cSTT";
		this.cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cSTT.Width = 40;
		this.cName.HeaderText = "Tên";
		this.cName.Name = "cName";
		this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cSize.HeaderText = "Kích thước";
		this.cSize.Name = "cSize";
		this.cSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cSize.Width = 80;
		this.cPixelRatio.HeaderText = "Pixel Ratio";
		this.cPixelRatio.Name = "cPixelRatio";
		this.cPixelRatio.Width = 90;
		this.cSua.HeaderText = "Sư\u0309a";
		this.cSua.Name = "cSua";
		this.cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cSua.Width = 71;
		this.cXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cXoa.HeaderText = "Xo\u0301a";
		this.cXoa.Name = "cXoa";
		this.cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnAdd.BackColor = System.Drawing.Color.Green;
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(375, 303);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.grChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.grChiTiet.Controls.Add(this.nudHeight);
		this.grChiTiet.Controls.Add(this.nudWidth);
		this.grChiTiet.Controls.Add(this.label11);
		this.grChiTiet.Controls.Add(this.txtPixelRatio);
		this.grChiTiet.Controls.Add(this.txtTen);
		this.grChiTiet.Controls.Add(this.label3);
		this.grChiTiet.Controls.Add(this.label2);
		this.grChiTiet.Controls.Add(this.label1);
		this.grChiTiet.Controls.Add(this.btnHuy);
		this.grChiTiet.Controls.Add(this.btnSave);
		this.grChiTiet.Enabled = false;
		this.grChiTiet.Location = new System.Drawing.Point(482, 44);
		this.grChiTiet.Name = "grChiTiet";
		this.grChiTiet.Size = new System.Drawing.Size(256, 177);
		this.grChiTiet.TabIndex = 50;
		this.grChiTiet.TabStop = false;
		this.grChiTiet.Text = "Chi tiê\u0301t";
		this.nudHeight.Location = new System.Drawing.Point(181, 64);
		this.nudHeight.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudHeight.Name = "nudHeight";
		this.nudHeight.Size = new System.Drawing.Size(59, 23);
		this.nudHeight.TabIndex = 49;
		this.nudWidth.Location = new System.Drawing.Point(95, 64);
		this.nudWidth.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudWidth.Name = "nudWidth";
		this.nudWidth.Size = new System.Drawing.Size(59, 23);
		this.nudWidth.TabIndex = 49;
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.Location = new System.Drawing.Point(156, 64);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(23, 23);
		this.label11.TabIndex = 48;
		this.label11.Text = "X";
		this.txtTen.Location = new System.Drawing.Point(95, 29);
		this.txtTen.Name = "txtTen";
		this.txtTen.Size = new System.Drawing.Size(145, 23);
		this.txtTen.TabIndex = 47;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(17, 99);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(72, 16);
		this.label3.TabIndex = 46;
		this.label3.Text = "Pixel Ratio:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(17, 66);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(72, 16);
		this.label2.TabIndex = 46;
		this.label2.Text = "Kích thước:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(17, 32);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(35, 16);
		this.label1.TabIndex = 46;
		this.label1.Text = "Tên:";
		this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
		this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHuy.FlatAppearance.BorderSize = 0;
		this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnHuy.ForeColor = System.Drawing.Color.White;
		this.btnHuy.Location = new System.Drawing.Point(148, 136);
		this.btnHuy.Name = "btnHuy";
		this.btnHuy.Size = new System.Drawing.Size(92, 29);
		this.btnHuy.TabIndex = 45;
		this.btnHuy.Text = "Hủy";
		this.btnHuy.UseVisualStyleBackColor = false;
		this.btnHuy.Click += new System.EventHandler(btnHuy_Click);
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(47, 136);
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
		this.bunifuCards2.Size = new System.Drawing.Size(742, 37);
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
		this.pnlHeader.Size = new System.Drawing.Size(742, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(711, 1);
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
		this.lblTitle.Size = new System.Drawing.Size(742, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Danh sách Kích thước Chrome";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.lblTitle;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.txtPixelRatio.Location = new System.Drawing.Point(95, 96);
		this.txtPixelRatio.Name = "txtPixelRatio";
		this.txtPixelRatio.Size = new System.Drawing.Size(59, 23);
		this.txtPixelRatio.TabIndex = 47;
		this.txtPixelRatio.Text = "3";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(744, 388);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemSizeChrome";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fThemSizeChrome_Load);
		this.panel1.ResumeLayout(false);
		this.grDanhSach.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).EndInit();
		this.grChiTiet.ResumeLayout(false);
		this.grChiTiet.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudHeight).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudWidth).EndInit();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
