using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;

public class fSuaChuDe : Form
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

	private Label label2;

	private Button btnCancel;

	private Button btnAdd;

	private MetroTextBox txtNewChuDe;

	private Label label1;

	private MetroTextBox txtChude;

	public fSuaChuDe(string string_0)
	{
		InitializeComponent();
		txtChude.Text = string_0;
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void fSuaChuDe_Load(object sender, EventArgs e)
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

	private void btnAdd_Click(object sender, EventArgs e)
	{
		List<string> list = Class36.smethod_34();
		string string_ = txtChude.Text;
		string text = txtNewChuDe.Text;
		if (text == "")
		{
			GClass14.smethod_20("Vui lòng nhập tên chủ đề mới!", 2);
		}
		else if (!list.Contains(text))
		{
			Class36.smethod_42(string_, text);
			if (MessageBox.Show("Cập nhật thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass14.smethod_20("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fSuaChuDe_FormClosing(object sender, FormClosingEventArgs e)
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
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.txtChude = new MetroFramework.Controls.MetroTextBox();
		this.btnAdd = new System.Windows.Forms.Button();
		this.txtNewChuDe = new MetroFramework.Controls.MetroTextBox();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
		this.bunifuCards1.Size = new System.Drawing.Size(0, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.txtChude);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.txtNewChuDe);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(329, 164);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(28, 49);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(94, 16);
		this.label1.TabIndex = 47;
		this.label1.Text = "Tên chủ đề cũ:";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(28, 78);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(102, 16);
		this.label2.TabIndex = 47;
		this.label2.Text = "Tên chủ đề mới:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(173, 116);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 46;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.txtChude.CustomButton.Image = null;
		this.txtChude.CustomButton.Location = new System.Drawing.Point(131, 1);
		this.txtChude.CustomButton.Name = "";
		this.txtChude.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtChude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtChude.CustomButton.TabIndex = 1;
		this.txtChude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtChude.CustomButton.UseSelectable = true;
		this.txtChude.CustomButton.Visible = false;
		this.txtChude.Lines = new string[0];
		this.txtChude.Location = new System.Drawing.Point(138, 46);
		this.txtChude.MaxLength = 32767;
		this.txtChude.Name = "txtChude";
		this.txtChude.PasswordChar = '\0';
		this.txtChude.ReadOnly = true;
		this.txtChude.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtChude.SelectedText = "";
		this.txtChude.SelectionLength = 0;
		this.txtChude.SelectionStart = 0;
		this.txtChude.ShortcutsEnabled = true;
		this.txtChude.Size = new System.Drawing.Size(153, 23);
		this.txtChude.TabIndex = 44;
		this.txtChude.UseSelectable = true;
		this.txtChude.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtChude.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(69, 116);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Cập nhật";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.txtNewChuDe.CustomButton.Image = null;
		this.txtNewChuDe.CustomButton.Location = new System.Drawing.Point(131, 1);
		this.txtNewChuDe.CustomButton.Name = "";
		this.txtNewChuDe.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtNewChuDe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtNewChuDe.CustomButton.TabIndex = 1;
		this.txtNewChuDe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtNewChuDe.CustomButton.UseSelectable = true;
		this.txtNewChuDe.CustomButton.Visible = false;
		this.txtNewChuDe.Lines = new string[0];
		this.txtNewChuDe.Location = new System.Drawing.Point(138, 75);
		this.txtNewChuDe.MaxLength = 32767;
		this.txtNewChuDe.Name = "txtNewChuDe";
		this.txtNewChuDe.PasswordChar = '\0';
		this.txtNewChuDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtNewChuDe.SelectedText = "";
		this.txtNewChuDe.SelectionLength = 0;
		this.txtNewChuDe.SelectionStart = 0;
		this.txtNewChuDe.ShortcutsEnabled = true;
		this.txtNewChuDe.Size = new System.Drawing.Size(153, 23);
		this.txtNewChuDe.TabIndex = 44;
		this.txtNewChuDe.UseSelectable = true;
		this.txtNewChuDe.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtNewChuDe.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
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
		this.bunifuCards2.Size = new System.Drawing.Size(327, 37);
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
		this.pnlHeader.Size = new System.Drawing.Size(327, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(296, 1);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(327, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cập nhật chủ đề";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		base.ClientSize = new System.Drawing.Size(329, 164);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSuaChuDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fSuaChuDe_FormClosing);
		base.Load += new System.EventHandler(fSuaChuDe_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
