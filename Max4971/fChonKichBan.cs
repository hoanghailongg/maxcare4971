using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonKichBan : Form
{
	private GClass17 gclass17_0;

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

	public DataGridView dtgvKichBan;

	private Panel panel1;

	private Button button2;

	private Button button3;

	private GroupBox groupBox2;

	private Label label2;

	private Button btnCancel;

	private Button btnSave;

	private Label lblCountAcc;

	private Label label7;

	private Label label1;

	public DataGridView dtgvKichBanChoose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cIdKichBan;

	private DataGridViewTextBoxColumn cTenKichBan;

	private DataGridViewTextBoxColumn cSTTChoose;

	private DataGridViewTextBoxColumn cIdKichBanChoose;

	private DataGridViewTextBoxColumn cTenKichBanChoose;

	public fChonKichBan()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configInteractGeneral");
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(groupBox1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(groupBox2);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label7);
		GClass29.smethod_1(btnSave);
		GClass29.smethod_1(btnCancel);
		foreach (DataGridViewColumn column in dtgvKichBan.Columns)
		{
			GClass29.smethod_3(column);
		}
		foreach (DataGridViewColumn column2 in dtgvKichBanChoose.Columns)
		{
			GClass29.smethod_3(column2);
		}
	}

	private void fChonKichBan_Load(object sender, EventArgs e)
	{
		method_1();
		method_1(gclass17_0.method_1("lstIdKichBan"));
	}

	private void method_1(List<string> list_0 = null)
	{
		try
		{
			if (list_0 != null && list_0.Count > 0)
			{
				dtgvKichBanChoose.Rows.Clear();
				for (int i = 0; i < list_0.Count; i++)
				{
					DataTable dataTable = Class307.smethod_2(list_0[i]);
					if (dataTable.Rows.Count > 0)
					{
						DataRow dataRow = dataTable.Rows[0];
						dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
					}
				}
				return;
			}
			dtgvKichBan.Rows.Clear();
			DataTable dataTable2 = Class307.smethod_4();
			if (dataTable2.Rows.Count > 0)
			{
				for (int j = 0; j < dataTable2.Rows.Count; j++)
				{
					DataRow dataRow2 = dataTable2.Rows[j];
					dtgvKichBan.Rows.Add(j + 1, dataRow2["Id_KichBan"], dataRow2["TenKichBan"]);
				}
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	public void method_2(ref DataGridView dataGridView_0, int int_0, int int_1)
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
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != 0)
		{
			string text = Class309.smethod_3(dtgvKichBanChoose, index - 1, "cIdKichBanChoose");
			string text2 = Class309.smethod_3(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_2(ref dtgvKichBanChoose, index, index - 1);
				dtgvKichBanChoose.Rows[index - 1].Selected = true;
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != dtgvKichBanChoose.RowCount - 1)
		{
			string text = Class309.smethod_3(dtgvKichBanChoose, index + 1, "cIdKichBanChoose");
			string text2 = Class309.smethod_3(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_2(ref dtgvKichBanChoose, index, index + 1);
				dtgvKichBanChoose.Rows[index + 1].Selected = true;
			}
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool method_3(string string_0)
	{
		bool result = false;
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			if (string_0 == dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dtgvKichBan.SelectedRows[0].Cells[1].Value);
		string text = dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
		if (!method_3(num.ToString()))
		{
			dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, num, text);
		}
	}

	private void dtgvKichBanChoose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		dtgvKichBanChoose.Rows.RemoveAt(dtgvKichBanChoose.SelectedRows[0].Index);
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			Class309.smethod_5(dtgvKichBanChoose, i, "cSTTChoose", i + 1);
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
			{
				list.Add(Class309.smethod_3(dtgvKichBanChoose, i, "cIdKichBanChoose"));
			}
			gclass17_0.method_6("lstIdKichBan", list);
			gclass17_0.method_8();
			Close();
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_);
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 3);
		}
	}

	private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonKichBan));
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
		this.label2 = new System.Windows.Forms.Label();
		this.dtgvKichBan = new System.Windows.Forms.DataGridView();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cIdKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.lblCountAcc = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.dtgvKichBanChoose = new System.Windows.Forms.DataGridView();
		this.cSTTChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cIdKichBanChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTenKichBanChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.button2 = new System.Windows.Forms.Button();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.panel1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBanChoose).BeginInit();
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
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(696, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
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
		this.pnlHeader.Size = new System.Drawing.Size(696, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(667, 2);
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
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.dtgvKichBan);
		this.groupBox1.Location = new System.Drawing.Point(12, 41);
		this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox1.Size = new System.Drawing.Size(308, 302);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Danh sách kịch bản";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(3, 281);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(193, 16);
		this.label2.TabIndex = 81;
		this.label2.Text = "(Click đúp vào kịch bản để chọn)";
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
		this.dtgvKichBan.Columns.AddRange(this.cStt, this.cIdKichBan, this.cTenKichBan);
		this.dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvKichBan.Location = new System.Drawing.Point(6, 20);
		this.dtgvKichBan.MultiSelect = false;
		this.dtgvKichBan.Name = "dtgvKichBan";
		this.dtgvKichBan.RowHeadersVisible = false;
		this.dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvKichBan.Size = new System.Drawing.Size(296, 258);
		this.dtgvKichBan.TabIndex = 76;
		this.dtgvKichBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvKichBan_CellDoubleClick);
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.Width = 35;
		this.cIdKichBan.HeaderText = "Id kịch bản";
		this.cIdKichBan.Name = "cIdKichBan";
		this.cIdKichBan.Visible = false;
		this.cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cTenKichBan.HeaderText = "Tên kịch bản";
		this.cTenKichBan.Name = "cTenKichBan";
		this.cTenKichBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
		this.bunifuCards1.Size = new System.Drawing.Size(699, 37);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(702, 391);
		this.panel1.TabIndex = 13;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(359, 350);
		this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 22;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(252, 350);
		this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.groupBox2.BackColor = System.Drawing.Color.White;
		this.groupBox2.Controls.Add(this.lblCountAcc);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.label1);
		this.groupBox2.Controls.Add(this.button3);
		this.groupBox2.Controls.Add(this.dtgvKichBanChoose);
		this.groupBox2.Controls.Add(this.button2);
		this.groupBox2.Location = new System.Drawing.Point(325, 40);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Size = new System.Drawing.Size(363, 302);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Kịch bản cần chạy";
		this.lblCountAcc.AutoSize = true;
		this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		this.lblCountAcc.Location = new System.Drawing.Point(297, 281);
		this.lblCountAcc.Name = "lblCountAcc";
		this.lblCountAcc.Size = new System.Drawing.Size(16, 16);
		this.lblCountAcc.TabIndex = 82;
		this.lblCountAcc.Text = "0";
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(255, 281);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(44, 16);
		this.label7.TabIndex = 83;
		this.label7.Text = "Tổng:";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(4, 282);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(186, 16);
		this.label1.TabIndex = 81;
		this.label1.Text = "(Click đúp vào kịch bản để xóa)";
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Image = Class306.Bitmap_118;
		this.button3.Location = new System.Drawing.Point(314, 64);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(41, 38);
		this.button3.TabIndex = 78;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.dtgvKichBanChoose.AllowUserToAddRows = false;
		this.dtgvKichBanChoose.AllowUserToDeleteRows = false;
		this.dtgvKichBanChoose.AllowUserToResizeRows = false;
		this.dtgvKichBanChoose.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvKichBanChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvKichBanChoose.Columns.AddRange(this.cSTTChoose, this.cIdKichBanChoose, this.cTenKichBanChoose);
		this.dtgvKichBanChoose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvKichBanChoose.Location = new System.Drawing.Point(6, 20);
		this.dtgvKichBanChoose.MultiSelect = false;
		this.dtgvKichBanChoose.Name = "dtgvKichBanChoose";
		this.dtgvKichBanChoose.RowHeadersVisible = false;
		this.dtgvKichBanChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvKichBanChoose.Size = new System.Drawing.Size(302, 258);
		this.dtgvKichBanChoose.TabIndex = 76;
		this.dtgvKichBanChoose.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvKichBanChoose_CellDoubleClick);
		this.dtgvKichBanChoose.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(dtgvKichBanChoose_RowsAdded);
		this.dtgvKichBanChoose.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(dtgvKichBanChoose_RowsRemoved);
		this.cSTTChoose.HeaderText = "STT";
		this.cSTTChoose.Name = "cSTTChoose";
		this.cSTTChoose.Width = 35;
		this.cIdKichBanChoose.HeaderText = "Id kịch bản";
		this.cIdKichBanChoose.Name = "cIdKichBanChoose";
		this.cIdKichBanChoose.Visible = false;
		this.cTenKichBanChoose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cTenKichBanChoose.HeaderText = "Tên kịch bản";
		this.cTenKichBanChoose.Name = "cTenKichBanChoose";
		this.cTenKichBanChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Image = Class306.Bitmap_222;
		this.button2.Location = new System.Drawing.Point(314, 19);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(41, 38);
		this.button2.TabIndex = 78;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(702, 391);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChonKichBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fChonKichBan_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBanChoose).EndInit();
		base.ResumeLayout(false);
	}
}
