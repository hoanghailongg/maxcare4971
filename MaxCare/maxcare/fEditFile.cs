using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;

public class fEditFile : Form
{
	private string string_0;

	private string string_1;

	public bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private Label label1;

	private BunifuDragControl bunifuDragControl_0;

	private MetroTextBox txtNameFileOld;

	private PictureBox pictureBox1;

	private MetroTextBox txtNameFileNew;

	private Label label2;

	public fEditFile(string string_2, string string_3)
	{
		InitializeComponent();
		method_0();
		string_0 = string_2;
		string_1 = string_3;
		bool_0 = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtNameFileNew.Text.Trim();
		if (text == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng điền tên thư mục mới!"), 3);
			txtNameFileNew.Focus();
		}
		else if (Class36.smethod_0(text))
		{
			GClass38.smethod_0(GClass29.smethod_0("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"), 3);
			txtNameFileNew.Focus();
		}
		else if (text.Equals(txtNameFileOld.Text.Trim()))
		{
			GClass38.smethod_0(GClass29.smethod_0("Tên thư mục mới phải khác thư mục cũ!"), 3);
			txtNameFileNew.Focus();
		}
		else if (Class36.smethod_4(string_0, text))
		{
			bool_0 = true;
			if (GClass38.smethod_1(GClass29.smethod_0("Cập nhật thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass38.smethod_0(GClass29.smethod_0("Cập nhật tên thư mục lỗi!"));
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtNameFileNew_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnAdd_Click(null, null);
		}
	}

	private void fEditFile_Load(object sender, EventArgs e)
	{
		txtNameFileOld.Text = string_1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditFile));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.txtNameFileOld = new MetroFramework.Controls.MetroTextBox();
		this.txtNameFileNew = new MetroFramework.Controls.MetroTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
		this.bunifuCards1.Size = new System.Drawing.Size(396, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(396, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(4, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(362, -2);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(204, 138);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Hủy";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(100, 138);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Cập nhật";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(33, 69);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(103, 16);
		this.label1.TabIndex = 20;
		this.label1.Text = "Tên thư mu\u0323c cũ:";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.txtNameFileOld.CustomButton.Image = null;
		this.txtNameFileOld.CustomButton.Location = new System.Drawing.Point(187, 1);
		this.txtNameFileOld.CustomButton.Name = "";
		this.txtNameFileOld.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtNameFileOld.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtNameFileOld.CustomButton.TabIndex = 1;
		this.txtNameFileOld.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtNameFileOld.CustomButton.UseSelectable = true;
		this.txtNameFileOld.CustomButton.Visible = false;
		this.txtNameFileOld.Enabled = false;
		this.txtNameFileOld.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.txtNameFileOld.Lines = new string[0];
		this.txtNameFileOld.Location = new System.Drawing.Point(150, 66);
		this.txtNameFileOld.MaxLength = 32767;
		this.txtNameFileOld.Name = "txtNameFileOld";
		this.txtNameFileOld.PasswordChar = '\0';
		this.txtNameFileOld.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtNameFileOld.SelectedText = "";
		this.txtNameFileOld.SelectionLength = 0;
		this.txtNameFileOld.SelectionStart = 0;
		this.txtNameFileOld.ShortcutsEnabled = true;
		this.txtNameFileOld.Size = new System.Drawing.Size(209, 23);
		this.txtNameFileOld.TabIndex = 2;
		this.txtNameFileOld.UseSelectable = true;
		this.txtNameFileOld.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtNameFileOld.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtNameFileOld.KeyDown += new System.Windows.Forms.KeyEventHandler(txtNameFileNew_KeyDown);
		this.txtNameFileNew.CustomButton.Image = null;
		this.txtNameFileNew.CustomButton.Location = new System.Drawing.Point(187, 1);
		this.txtNameFileNew.CustomButton.Name = "";
		this.txtNameFileNew.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtNameFileNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtNameFileNew.CustomButton.TabIndex = 1;
		this.txtNameFileNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtNameFileNew.CustomButton.UseSelectable = true;
		this.txtNameFileNew.CustomButton.Visible = false;
		this.txtNameFileNew.Lines = new string[0];
		this.txtNameFileNew.Location = new System.Drawing.Point(150, 95);
		this.txtNameFileNew.MaxLength = 32767;
		this.txtNameFileNew.Name = "txtNameFileNew";
		this.txtNameFileNew.PasswordChar = '\0';
		this.txtNameFileNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtNameFileNew.SelectedText = "";
		this.txtNameFileNew.SelectionLength = 0;
		this.txtNameFileNew.SelectionStart = 0;
		this.txtNameFileNew.ShortcutsEnabled = true;
		this.txtNameFileNew.Size = new System.Drawing.Size(209, 23);
		this.txtNameFileNew.TabIndex = 2;
		this.txtNameFileNew.UseSelectable = true;
		this.txtNameFileNew.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtNameFileNew.WaterMarkFont = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtNameFileNew.KeyDown += new System.Windows.Forms.KeyEventHandler(txtNameFileNew_KeyDown);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(33, 98);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(111, 16);
		this.label2.TabIndex = 20;
		this.label2.Text = "Tên thư mu\u0323c mới:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(396, 182);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.txtNameFileNew);
		base.Controls.Add(this.txtNameFileOld);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fEditFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fEditFile_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
