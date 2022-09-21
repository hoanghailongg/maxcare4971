using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChiTietBaiViet : Form
{
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

	private BunifuCustomLabel bunifuCustomLabel1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label lblNanh;

	private DataGridView dgvPic;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox txtChuDe;

	private Label label5;

	private TextBox txtConten;

	private Label label4;

	private Label label2;

	private TextBox txtName;

	public fChiTietBaiViet(int int_0)
	{
		InitializeComponent();
		List<Class48> list = Class36.smethod_33(int_0.ToString());
		foreach (Class48 item in list)
		{
			txtChuDe.Text = item.String_0;
			txtName.Text = item.String_1;
			txtConten.Text = item.String_4;
			string[] array = item.String_2.Split('|');
			lblNanh.Text = "Ảnh (" + (array.Length - 1) + "):";
			item.String_3.Split('|');
			for (int i = 0; i < array.Length - 1; i++)
			{
				dgvPic.Rows.Add(array[i]);
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void fChiTietBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			Process.Start(dgvPic.SelectedRows[0].Cells[0].Value.ToString());
		}
		catch (Exception)
		{
			MessageBox.Show("Link ảnh không tồn tại", "Lỗi");
		}
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dgvPic_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
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
		this.lblNanh = new System.Windows.Forms.Label();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.dgvPic = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.txtChuDe = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.txtConten = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dgvPic).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(36, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.lblNanh);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Controls.Add(this.dgvPic);
		this.panel1.Controls.Add(this.txtChuDe);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.txtConten);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.txtName);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(365, 342);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.lblNanh.AutoSize = true;
		this.lblNanh.Location = new System.Drawing.Point(6, 100);
		this.lblNanh.Name = "lblNanh";
		this.lblNanh.Size = new System.Drawing.Size(56, 16);
		this.lblNanh.TabIndex = 50;
		this.lblNanh.Text = "Ảnh (0):";
		this.lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		this.bunifuCards2.Size = new System.Drawing.Size(363, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(363, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(332, 1);
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
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(363, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Chi tiết bài viết";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		this.dgvPic.Location = new System.Drawing.Point(85, 97);
		this.dgvPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvPic.Name = "dgvPic";
		this.dgvPic.RowHeadersVisible = false;
		this.dgvPic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvPic.Size = new System.Drawing.Size(270, 76);
		this.dgvPic.TabIndex = 42;
		this.dgvPic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPic_CellContentClick);
		this.dgvPic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPic_CellDoubleClick);
		this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		this.dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		this.dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		this.txtChuDe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtChuDe.Location = new System.Drawing.Point(85, 41);
		this.txtChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtChuDe.Name = "txtChuDe";
		this.txtChuDe.ReadOnly = true;
		this.txtChuDe.Size = new System.Drawing.Size(270, 23);
		this.txtChuDe.TabIndex = 46;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label5.Location = new System.Drawing.Point(6, 72);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(56, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Tiêu đề:";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.txtConten.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtConten.Location = new System.Drawing.Point(85, 181);
		this.txtConten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtConten.Multiline = true;
		this.txtConten.Name = "txtConten";
		this.txtConten.ReadOnly = true;
		this.txtConten.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtConten.Size = new System.Drawing.Size(270, 149);
		this.txtConten.TabIndex = 48;
		this.txtConten.WordWrap = false;
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label4.Location = new System.Drawing.Point(6, 44);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(53, 16);
		this.label4.TabIndex = 43;
		this.label4.Text = "Chủ đề:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label2.Location = new System.Drawing.Point(6, 184);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 45;
		this.label2.Text = "Nội dung:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtName.Location = new System.Drawing.Point(85, 69);
		this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtName.Name = "txtName";
		this.txtName.ReadOnly = true;
		this.txtName.Size = new System.Drawing.Size(270, 23);
		this.txtName.TabIndex = 47;
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(365, 342);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChiTietBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fChiTietBaiViet_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dgvPic).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
