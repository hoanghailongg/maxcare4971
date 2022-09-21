using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonThuMuc : Form
{
	private bool bool_0 = false;

	public static List<string> list_0;

	public static List<string> list_1;

	public static bool bool_1;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label1;

	private Label lblCountTotal;

	private Label label3;

	private Label lblCountChoose;

	private Label label2;

	public DataGridView dtgvAcc;

	private CheckBox checkBox1;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cThuMuc;

	public fChonThuMuc(bool bool_2 = false)
	{
		InitializeComponent();
		bool_1 = false;
		bool_0 = bool_2;
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			GClass29.smethod_3(column);
		}
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			list_1 = new List<string>();
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list_1.Add(Class309.smethod_3(dtgvAcc, i, "cId"));
				}
			}
			if (list_1.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < dtgvAcc.Rows.Count; j++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(Class309.smethod_3(dtgvAcc, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				GClass38.smethod_0(GClass29.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonThuMuc_Load(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (list_1 == null)
			{
				list_1 = new List<string>();
			}
			method_1(list_1);
		}
		else
		{
			if (list_0 == null)
			{
				list_0 = new List<string>();
			}
			method_1(list_0);
		}
	}

	private void method_1(List<string> list_2 = null)
	{
		try
		{
			DataTable dataTable = ((!bool_0) ? Class36.smethod_1() : Class36.smethod_2());
			if (list_2 != null && list_2.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					if (list_2.Contains(dataTable.Rows[i]["id"].ToString()))
					{
						dtgvAcc.Rows.Add(true, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
					else
					{
						dtgvAcc.Rows.Add(false, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
				}
			}
			else
			{
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					dtgvAcc.Rows.Add(false, j + 1, dataTable.Rows[j]["id"], dataTable.Rows[j]["name"]);
				}
			}
			method_2();
			method_3();
			if (method_4() == dtgvAcc.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_76(exception_, "LoadListFiles");
			GClass38.smethod_0(GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void method_2()
	{
		try
		{
			lblCountChoose.Text = method_4().ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			method_2();
			if (method_4() == dtgvAcc.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}

	private void method_3()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int method_4()
	{
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void checkBox1_Click(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				Class309.smethod_5(dtgvAcc, i, "cChose", true);
			}
		}
		else
		{
			for (int j = 0; j < dtgvAcc.Rows.Count; j++)
			{
				Class309.smethod_5(dtgvAcc, j, "cChose", false);
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonThuMuc));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.lblCountTotal = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.lblCountChoose = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.dtgvAcc = new System.Windows.Forms.DataGridView();
		this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(317, 34);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(317, 28);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(285, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(317, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Chọn Danh sách thư mục";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(156, 280);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(52, 280);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(145, 252);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(59, 16);
		this.label1.TabIndex = 6;
		this.label1.Text = "Tổng số:";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblCountTotal.AutoSize = true;
		this.lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountTotal.ForeColor = System.Drawing.Color.DarkRed;
		this.lblCountTotal.Location = new System.Drawing.Point(203, 253);
		this.lblCountTotal.Name = "lblCountTotal";
		this.lblCountTotal.Size = new System.Drawing.Size(15, 16);
		this.lblCountTotal.TabIndex = 6;
		this.lblCountTotal.Text = "0";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(49, 252);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 16);
		this.label3.TabIndex = 6;
		this.label3.Text = "Đã chọn:";
		this.lblCountChoose.AutoSize = true;
		this.lblCountChoose.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountChoose.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblCountChoose.Location = new System.Drawing.Point(107, 253);
		this.lblCountChoose.Name = "lblCountChoose";
		this.lblCountChoose.Size = new System.Drawing.Size(15, 16);
		this.lblCountChoose.TabIndex = 6;
		this.lblCountChoose.Text = "0";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.DarkRed;
		this.label2.Location = new System.Drawing.Point(12, 227);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(178, 16);
		this.label2.TabIndex = 6;
		this.label2.Text = "(Click đúp vào dòng để chọn!)";
		this.dtgvAcc.AllowUserToAddRows = false;
		this.dtgvAcc.AllowUserToDeleteRows = false;
		this.dtgvAcc.AllowUserToResizeRows = false;
		this.dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvAcc.Columns.AddRange(this.cChose, this.cStt, this.cId, this.cThuMuc);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvAcc.Location = new System.Drawing.Point(15, 40);
		this.dtgvAcc.Name = "dtgvAcc";
		this.dtgvAcc.ReadOnly = true;
		this.dtgvAcc.RowHeadersVisible = false;
		this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvAcc.Size = new System.Drawing.Size(287, 184);
		this.dtgvAcc.TabIndex = 7;
		this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		this.dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		this.dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		this.cChose.HeaderText = "";
		this.cChose.Name = "cChose";
		this.cChose.ReadOnly = true;
		this.cChose.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cChose.Width = 30;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cStt.Width = 35;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.cThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cThuMuc.HeaderText = "Thư mục";
		this.cThuMuc.Name = "cThuMuc";
		this.cThuMuc.ReadOnly = true;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBox1.Location = new System.Drawing.Point(25, 45);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(15, 14);
		this.checkBox1.TabIndex = 8;
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.Click += new System.EventHandler(checkBox1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(317, 322);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.dtgvAcc);
		base.Controls.Add(this.lblCountChoose);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.lblCountTotal);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fChonThuMuc_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
