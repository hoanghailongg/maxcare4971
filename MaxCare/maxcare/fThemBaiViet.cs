using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fThemBaiViet : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private MetroButton metroButton1;

	private Label label1;

	private ComboBox cbbChuDe;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private DataGridView dgvPic;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox txtName;

	private Label label2;

	private Label label5;

	private Button btnCancel;

	private Button button1;

	private Label lblNanh;

	private MetroButton metroButton3;

	private MetroButton metroButton2;

	private RichTextBox txtConten;

	private Label label8;

	public fThemBaiViet(int int_0)
	{
		InitializeComponent();
		method_0();
		cbbChuDe.SelectedIndex = int_0;
	}

	private void method_0()
	{
		List<string> list = Class36.smethod_34();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		try
		{
			cbbChuDe.SelectedIndex = 0;
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass14.smethod_33(new fDanhSachChuDe());
		cbbChuDe.Items.Clear();
		method_0();
	}

	private void metroButton2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
		openFileDialog.FilterIndex = 0;
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string[] fileNames = openFileDialog.FileNames;
			for (int i = 0; i < fileNames.Length; i++)
			{
				dgvPic.Rows.Add(fileNames[i]);
			}
			lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
		}
	}

	private void metroButton3_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvPic.SelectedRows)
		{
			dgvPic.Rows.RemoveAt(selectedRow.Index);
		}
		lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (txtName.Text != "")
		{
			string text = "";
			if (dgvPic.Rows.Count != 0)
			{
				for (int i = 0; i < dgvPic.Rows.Count; i++)
				{
					text = text + dgvPic.Rows[i].Cells[0].Value.ToString() + "|";
				}
			}
			string string_ = "";
			string string_2 = cbbChuDe.SelectedItem.ToString();
			Class48 class48_ = new Class48
			{
				String_1 = txtName.Text,
				String_2 = text,
				String_3 = string_,
				String_5 = DateTime.Now.ToString("dd/MM/yyyy"),
				String_4 = txtConten.Text
			};
			Class36.smethod_43(string_2, class48_);
			DialogResult dialogResult = MessageBox.Show("Thêm thành công. Bạn muốn có muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass14.smethod_20("Chưa nhập tiêu đề!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		Process.Start(dgvPic.SelectedRows[0].Cells[0].Value.ToString());
	}

	private void cbbChuDe_Click(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_2(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void bunifuCustomLabel1_Click(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass14.smethod_33(new fHuongDanRandom());
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
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtConten = new System.Windows.Forms.RichTextBox();
		this.metroButton3 = new MetroFramework.Controls.MetroButton();
		this.metroButton2 = new MetroFramework.Controls.MetroButton();
		this.lblNanh = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.dgvPic = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.txtName = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbChuDe = new System.Windows.Forms.ComboBox();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.label8 = new System.Windows.Forms.Label();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPic).BeginInit();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(43, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.txtConten);
		this.panel1.Controls.Add(this.metroButton3);
		this.panel1.Controls.Add(this.metroButton2);
		this.panel1.Controls.Add(this.lblNanh);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.dgvPic);
		this.panel1.Controls.Add(this.txtName);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.metroButton1);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.cbbChuDe);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(372, 411);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtConten.Location = new System.Drawing.Point(76, 187);
		this.txtConten.Name = "txtConten";
		this.txtConten.Size = new System.Drawing.Size(271, 149);
		this.txtConten.TabIndex = 120;
		this.txtConten.Text = "";
		this.txtConten.WordWrap = false;
		this.metroButton3.BackgroundImage = Class306.Bitmap_154;
		this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton3.Location = new System.Drawing.Point(317, 149);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new System.Drawing.Size(30, 30);
		this.metroButton3.TabIndex = 114;
		this.metroButton3.UseSelectable = true;
		this.metroButton3.Click += new System.EventHandler(metroButton3_Click);
		this.metroButton2.BackgroundImage = Class306.Bitmap_80;
		this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton2.Location = new System.Drawing.Point(317, 110);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new System.Drawing.Size(30, 30);
		this.metroButton2.TabIndex = 115;
		this.metroButton2.UseSelectable = true;
		this.metroButton2.Click += new System.EventHandler(metroButton2_Click);
		this.lblNanh.AutoSize = true;
		this.lblNanh.Location = new System.Drawing.Point(6, 110);
		this.lblNanh.Name = "lblNanh";
		this.lblNanh.Size = new System.Drawing.Size(56, 16);
		this.lblNanh.TabIndex = 109;
		this.lblNanh.Text = "Ảnh (0):";
		this.lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(184, 369);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 108;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.button1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Location = new System.Drawing.Point(77, 369);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(92, 29);
		this.button1.TabIndex = 107;
		this.button1.Text = "Lưu";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.dgvPic.AllowUserToAddRows = false;
		this.dgvPic.AllowUserToDeleteRows = false;
		this.dgvPic.AllowUserToResizeColumns = false;
		this.dgvPic.AllowUserToResizeRows = false;
		this.dgvPic.BackgroundColor = System.Drawing.Color.White;
		this.dgvPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPic.ColumnHeadersVisible = false;
		this.dgvPic.Columns.AddRange(this.dataGridViewTextBoxColumn4);
		this.dgvPic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.dgvPic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dgvPic.Location = new System.Drawing.Point(77, 109);
		this.dgvPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvPic.Name = "dgvPic";
		this.dgvPic.RowHeadersVisible = false;
		this.dgvPic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvPic.Size = new System.Drawing.Size(234, 70);
		this.dgvPic.TabIndex = 83;
		this.dgvPic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPic_CellDoubleClick);
		this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		this.dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		this.dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtName.Location = new System.Drawing.Point(77, 78);
		this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(270, 23);
		this.txtName.TabIndex = 87;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label2.Location = new System.Drawing.Point(6, 187);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 86;
		this.label2.Text = "Nội dung:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label5.Location = new System.Drawing.Point(6, 81);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(56, 16);
		this.label5.TabIndex = 85;
		this.label5.Text = "Tiêu đề:";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(254, 46);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(93, 25);
		this.metroButton1.TabIndex = 82;
		this.metroButton1.Text = "Quản lý chủ đề";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(6, 50);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(53, 16);
		this.label1.TabIndex = 81;
		this.label1.Text = "Chủ đề:";
		this.cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChuDe.FormattingEnabled = true;
		this.cbbChuDe.Location = new System.Drawing.Point(77, 47);
		this.cbbChuDe.Name = "cbbChuDe";
		this.cbbChuDe.Size = new System.Drawing.Size(171, 24);
		this.cbbChuDe.TabIndex = 80;
		this.cbbChuDe.Click += new System.EventHandler(cbbChuDe_Click);
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
		this.bunifuCards2.Size = new System.Drawing.Size(370, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(370, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(339, 1);
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
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(370, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Thêm bình luận";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuCustomLabel1.Click += new System.EventHandler(bunifuCustomLabel1_Click);
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
		this.toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_0.Text = "Thêm chủ đề";
		this.toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		this.toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_2.Text = "Xóa chủ đề";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(74, 339);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(134, 16);
		this.label8.TabIndex = 121;
		this.label8.Text = "Spin nội dung {a|b|c}";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(372, 411);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPic).EndInit();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
