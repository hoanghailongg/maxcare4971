using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fChonBaiViet : Form
{
	private bool bool_0 = false;

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private Button btnCancel;

	private Button btnSave;

	private GroupBox groupBox2;

	private GroupBox groupBox1;

	public DataGridView dgvDSBaiViet;

	private MetroButton metroButton1;

	private Label label1;

	private ComboBox cbbChuDe;

	private Label lblCountAcc;

	private Label label7;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label2;

	public DataGridView dgvBaiVietDaChon;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private Label label3;

	private DataGridViewTextBoxColumn cStt1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cChuDe;

	private DataGridViewTextBoxColumn cIdBaiViet;

	private DataGridViewTextBoxColumn cTieuDe;

	private DataGridViewTextBoxColumn cAnh;

	private DataGridViewTextBoxColumn cVideo;

	public fChonBaiViet(ref List<string> list_1)
	{
		InitializeComponent();
		method_2();
		list_0 = list_1;
		method_0();
	}

	private void method_0()
	{
		if (list_0.Count <= 0)
		{
			return;
		}
		dgvBaiVietDaChon.Rows.Clear();
		for (int i = 0; i < list_0.Count; i++)
		{
			try
			{
				Class48 @class = method_1(list_0[i]);
				dgvBaiVietDaChon.Rows.Add(i + 1, @class.String_0, @class.Int32_0, @class.String_1, @class.String_2.Split('|').Length - 1, @class.String_3.Split('|').Length - 1);
			}
			catch
			{
				list_0.RemoveAt(i--);
			}
		}
	}

	private Class48 method_1(string string_0)
	{
		Class48 result = new Class48();
		try
		{
			result = Class36.smethod_33(string_0)[0];
		}
		catch
		{
		}
		return result;
	}

	private void method_2(bool bool_1 = false)
	{
		int selectedIndex = cbbChuDe.SelectedIndex;
		cbbChuDe.Items.Clear();
		List<string> list = Class36.smethod_34();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		if (cbbChuDe.Items.Count == 0)
		{
			cbbChuDe.SelectedIndex = -1;
		}
		else if (cbbChuDe.Items.Count == 1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (selectedIndex == -1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (cbbChuDe.Items.Count - 1 < selectedIndex)
		{
			cbbChuDe.SelectedIndex = cbbChuDe.Items.Count - 1;
		}
		else
		{
			cbbChuDe.SelectedIndex = selectedIndex;
		}
		method_3(bool_1);
		method_0();
	}

	private void method_3(bool bool_1 = true)
	{
		try
		{
			dgvDSBaiViet.Rows.Clear();
			List<Class48> list = new List<Class48>();
			list = (bool_1 ? Class36.smethod_35() : Class36.smethod_35(cbbChuDe.SelectedItem.ToString()));
			Class48 @class = new Class48();
			for (int i = 0; i < list.Count; i++)
			{
				@class = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, @class.String_0, @class.Int32_0, @class.String_1, @class.String_2.Split('|').Length - 1, @class.String_3.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		list_0.Clear();
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			list_0.Add(dgvBaiVietDaChon.Rows[i].Cells["cId"].Value.ToString());
		}
		if (MessageBox.Show("Lưu thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Close();
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
		Close();
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fDanhSachChuDe());
		method_2(bool_0);
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		try
		{
			int count = Class36.smethod_35().Count;
			GClass14.smethod_33(new fThemBaiViet(cbbChuDe.SelectedIndex));
			int count2 = Class36.smethod_35().Count;
			if (count2 > count)
			{
				Class48 @class = Class36.smethod_40()[0];
				dgvDSBaiViet.Rows.Add(dgvDSBaiViet.RowCount + 1, @class.String_0, @class.Int32_0, @class.String_1, @class.String_2.Split('|').Length - 1, @class.String_3.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			int int_ = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
			GClass14.smethod_33(new fSuaBaiViet(int_));
			Class48 @class = Class36.smethod_33(int_.ToString())[0];
			GClass14.smethod_21(dgvDSBaiViet, dataGridViewRow.Index, "cTieuDe", @class.String_1);
			GClass14.smethod_21(dgvDSBaiViet, dataGridViewRow.Index, "cAnh", @class.String_2.Split('|').Length - 1);
			GClass14.smethod_21(dgvDSBaiViet, dataGridViewRow.Index, "cVideo", @class.String_3.Split('|').Length - 1);
			method_0();
		}
		catch
		{
		}
	}

	private bool method_5(string string_0)
	{
		bool result = false;
		for (int i = 0; i < dgvBaiVietDaChon.Rows.Count; i++)
		{
			if (string_0 == dgvBaiVietDaChon.Rows[i].Cells[2].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void dgvDSBaiViet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
		List<Class48> list = Class36.smethod_33(num.ToString());
		Class48 @class = new Class48();
		for (int i = 0; i < list.Count; i++)
		{
			if (method_5(num.ToString()))
			{
				break;
			}
			@class = list[i];
			dgvBaiVietDaChon.Rows.Add(dgvBaiVietDaChon.Rows.Count + 1, @class.String_0, @class.Int32_0, @class.String_1, @class.String_2.Split('|').Length - 1, @class.String_3.Split('|').Length - 1);
			list_0.Add(@class.Int32_0.ToString());
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		try
		{
			int int_ = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
			fChiTietBaiViet fChiTietBaiViet2 = new fChiTietBaiViet(int_);
			fChiTietBaiViet2.Show();
		}
		catch
		{
		}
	}

	private void method_6()
	{
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			GClass14.smethod_21(dgvBaiVietDaChon, i, "cStt1", i + 1);
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		dgvDSBaiViet.Rows.Clear();
		List<Class48> list = Class36.smethod_35(cbbChuDe.SelectedItem.ToString());
		Class48 @class = new Class48();
		for (int i = 0; i < list.Count; i++)
		{
			try
			{
				@class = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, @class.String_0, @class.Int32_0, @class.String_1, @class.String_2.Split('|').Length - 1, @class.String_3.Split('|').Length - 1);
			}
			catch
			{
			}
		}
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_3(bool_0);
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		dgvDSBaiViet.Rows.Clear();
		method_3(bool_0);
	}

	private void method_9(object sender, EventArgs e)
	{
	}

	private void dgvBaiVietDaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvBaiVietDaChon.SelectedRows)
		{
			dgvBaiVietDaChon.Rows.RemoveAt(selectedRow.Index);
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			if (dataGridViewRow != null && MessageBox.Show("Bạn có muốn xóa bài viết này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				int int_ = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
				Class36.smethod_36(int_);
				dgvDSBaiViet.Rows.Remove(dataGridViewRow);
				method_0();
			}
		}
		catch
		{
		}
	}

	private void dgvDSBaiViet_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
	{
	}

	private void dgvBaiVietDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		method_6();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void dgvBaiVietDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		method_6();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool_0 = false;
		method_3(bool_0);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonBaiViet));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.lblCountAcc = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.dgvBaiVietDaChon = new System.Windows.Forms.DataGridView();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label2 = new System.Windows.Forms.Label();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbChuDe = new System.Windows.Forms.ComboBox();
		this.dgvDSBaiViet = new System.Windows.Forms.DataGridView();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cIdBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.panel1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
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
		this.bunifuCards1.Size = new System.Drawing.Size(270, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(927, 517);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
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
		this.bunifuCards2.Size = new System.Drawing.Size(925, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(925, 31);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(0, 4);
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
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(896, 3);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(925, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Chọn bình luận";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.groupBox2.BackColor = System.Drawing.Color.White;
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.lblCountAcc);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.dgvBaiVietDaChon);
		this.groupBox2.Location = new System.Drawing.Point(465, 40);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox2.Size = new System.Drawing.Size(454, 423);
		this.groupBox2.TabIndex = 41;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Bình luận cần sử dụng";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.Location = new System.Drawing.Point(6, 401);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(167, 16);
		this.label3.TabIndex = 80;
		this.label3.Text = "(Click đúp vào dòng để xóa)";
		this.lblCountAcc.AutoSize = true;
		this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		this.lblCountAcc.Location = new System.Drawing.Point(349, 401);
		this.lblCountAcc.Name = "lblCountAcc";
		this.lblCountAcc.Size = new System.Drawing.Size(16, 16);
		this.lblCountAcc.TabIndex = 78;
		this.lblCountAcc.Text = "0";
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(307, 401);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(44, 16);
		this.label7.TabIndex = 79;
		this.label7.Text = "Tổng:";
		this.dgvBaiVietDaChon.AllowUserToAddRows = false;
		this.dgvBaiVietDaChon.AllowUserToDeleteRows = false;
		this.dgvBaiVietDaChon.AllowUserToResizeRows = false;
		this.dgvBaiVietDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvBaiVietDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvBaiVietDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvBaiVietDaChon.Columns.AddRange(this.cStt1, this.dataGridViewTextBoxColumn2, this.cId, this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5, this.Column1);
		this.dgvBaiVietDaChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dgvBaiVietDaChon.Location = new System.Drawing.Point(6, 52);
		this.dgvBaiVietDaChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvBaiVietDaChon.MultiSelect = false;
		this.dgvBaiVietDaChon.Name = "dgvBaiVietDaChon";
		this.dgvBaiVietDaChon.RowHeadersVisible = false;
		this.dgvBaiVietDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvBaiVietDaChon.Size = new System.Drawing.Size(444, 345);
		this.dgvBaiVietDaChon.TabIndex = 76;
		this.dgvBaiVietDaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvBaiVietDaChon_CellDoubleClick);
		this.dgvBaiVietDaChon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(dgvBaiVietDaChon_RowsAdded);
		this.dgvBaiVietDaChon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(dgvBaiVietDaChon_RowsRemoved);
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.metroButton1);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.cbbChuDe);
		this.groupBox1.Controls.Add(this.dgvDSBaiViet);
		this.groupBox1.Location = new System.Drawing.Point(3, 39);
		this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox1.Size = new System.Drawing.Size(456, 423);
		this.groupBox1.TabIndex = 42;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Danh sách bình luận";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(7, 401);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(174, 16);
		this.label2.TabIndex = 80;
		this.label2.Text = "(Click đúp vào dòng để chọn)";
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(282, 23);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(109, 25);
		this.metroButton1.TabIndex = 79;
		this.metroButton1.Text = "Quản lý chủ đề";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(8, 27);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(53, 16);
		this.label1.TabIndex = 78;
		this.label1.Text = "Chủ đề:";
		this.cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChuDe.FormattingEnabled = true;
		this.cbbChuDe.Location = new System.Drawing.Point(64, 23);
		this.cbbChuDe.Name = "cbbChuDe";
		this.cbbChuDe.Size = new System.Drawing.Size(212, 24);
		this.cbbChuDe.TabIndex = 77;
		this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(cbbChuDe_SelectedIndexChanged);
		this.dgvDSBaiViet.AllowUserToAddRows = false;
		this.dgvDSBaiViet.AllowUserToDeleteRows = false;
		this.dgvDSBaiViet.AllowUserToResizeRows = false;
		this.dgvDSBaiViet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvDSBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dgvDSBaiViet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvDSBaiViet.Columns.AddRange(this.cStt, this.cChuDe, this.cIdBaiViet, this.cTieuDe, this.cAnh, this.cVideo);
		this.dgvDSBaiViet.ContextMenuStrip = this.contextMenuStrip1;
		this.dgvDSBaiViet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dgvDSBaiViet.Location = new System.Drawing.Point(10, 54);
		this.dgvDSBaiViet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvDSBaiViet.MultiSelect = false;
		this.dgvDSBaiViet.Name = "dgvDSBaiViet";
		this.dgvDSBaiViet.RowHeadersVisible = false;
		this.dgvDSBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvDSBaiViet.Size = new System.Drawing.Size(440, 343);
		this.dgvDSBaiViet.TabIndex = 76;
		this.dgvDSBaiViet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvDSBaiViet_CellContentClick);
		this.dgvDSBaiViet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvDSBaiViet_CellDoubleClick);
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_4, this.toolStripMenuItem_3, this.toolStripMenuItem_5 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(202, 158);
		this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(contextMenuStrip1_Opening);
		this.toolStripMenuItem_0.Name = "thêmBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_0.Text = "Thêm bình luận";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.toolStripMenuItem_1.Name = "sửaBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_1.Text = "Sửa bình luận";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.toolStripMenuItem_2.Name = "xóaBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_2.Text = "Xóa bình luận";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.toolStripMenuItem_4.Name = "chiTiếtBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_4.Text = "Chi tiết bình luận";
		this.toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		this.toolStripMenuItem_3.Name = "làmMớiDanhSáchToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_3.Text = "Làm mới danh sách";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		this.toolStripMenuItem_5.Name = "hiểnThịTấtCảBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_5.Text = "Hiển thị tất cả bình luận";
		this.toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(468, 473);
		this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 20;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(361, 473);
		this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 19;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.Width = 35;
		this.cChuDe.HeaderText = "Chủ đề";
		this.cChuDe.Name = "cChuDe";
		this.cIdBaiViet.HeaderText = "ID Bài viết";
		this.cIdBaiViet.Name = "cIdBaiViet";
		this.cIdBaiViet.Visible = false;
		this.cIdBaiViet.Width = 90;
		this.cTieuDe.HeaderText = "Tiêu đề";
		this.cTieuDe.Name = "cTieuDe";
		this.cTieuDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cTieuDe.Width = 230;
		this.cAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cAnh.HeaderText = "Ảnh";
		this.cAnh.Name = "cAnh";
		this.cVideo.HeaderText = "Video";
		this.cVideo.Name = "cVideo";
		this.cVideo.Visible = false;
		this.cVideo.Width = 50;
		this.cStt1.HeaderText = "STT";
		this.cStt1.Name = "cStt1";
		this.cStt1.Width = 35;
		this.dataGridViewTextBoxColumn2.HeaderText = "Chủ đề";
		this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
		this.cId.HeaderText = "ID Bài viết";
		this.cId.Name = "cId";
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.dataGridViewTextBoxColumn4.HeaderText = "Tiêu đề";
		this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn4.Width = 230;
		this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn5.HeaderText = "Ảnh";
		this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
		this.Column1.HeaderText = "Video";
		this.Column1.Name = "Column1";
		this.Column1.Visible = false;
		this.Column1.Width = 50;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(927, 517);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChonBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fChonBaiViet_Load);
		this.panel1.ResumeLayout(false);
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
