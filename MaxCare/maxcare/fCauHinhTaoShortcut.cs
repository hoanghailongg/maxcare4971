using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;

public class fCauHinhTaoShortcut : Form
{
	public static bool bool_0;

	private string string_0 = "";

	private GClass17 gclass17_0;

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

	private MetroTextBox txtPathShortcut;

	private MetroButton metroButton1;

	private Label label2;

	private MetroTextBox txtPathChromeOrigin;

	private MetroButton metroButton2;

	public fCauHinhTaoShortcut()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configInteractGeneral");
		method_0();
		bool_0 = false;
		string path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		string path2 = "C:\\Program Files (x64)\\Google\\Chrome\\Application\\chrome.exe";
		string path3 = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
		if (!File.Exists(path))
		{
			if (!File.Exists(path2))
			{
				if (File.Exists(path3))
				{
					string_0 = path3;
				}
			}
			else
			{
				string_0 = path2;
			}
		}
		else
		{
			string_0 = path;
		}
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(metroButton1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(metroButton2);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (txtPathShortcut.Text.Trim() == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n Thư mu\u0323c lưu Shortcut!"), 3);
			return;
		}
		if (txtPathChromeOrigin.Text.Trim() == "")
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe!"), 3);
			return;
		}
		if (!txtPathChromeOrigin.Text.Trim().EndsWith("chrome.exe"))
		{
			GClass38.smethod_0(GClass29.smethod_0("Đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe không hơ\u0323p lê\u0323!"), 3);
			return;
		}
		gclass17_0.method_5("txtPathShortcut", txtPathShortcut.Text.Trim());
		gclass17_0.method_5("txtPathChromeOrigin", txtPathChromeOrigin.Text.Trim());
		gclass17_0.method_8();
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void fCauHinhTaoShortcut_Load(object sender, EventArgs e)
	{
		txtPathShortcut.Text = gclass17_0.method_0("txtPathShortcut");
		if (txtPathShortcut.Text.Trim() == "" || !Directory.Exists(txtPathShortcut.Text.Trim()))
		{
			txtPathShortcut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		if (File.Exists(gclass17_0.method_0("txtPathChromeOrigin")))
		{
			txtPathChromeOrigin.Text = gclass17_0.method_0("txtPathChromeOrigin");
		}
		else
		{
			txtPathChromeOrigin.Text = string_0;
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		txtPathShortcut.Text = GClass14.smethod_40();
	}

	private void metroButton2_Click(object sender, EventArgs e)
	{
		txtPathChromeOrigin.Text = GClass14.smethod_41(GClass29.smethod_0("Cho\u0323n File"), "");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTaoShortcut));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.txtPathShortcut = new MetroFramework.Controls.MetroTextBox();
		this.metroButton1 = new MetroFramework.Controls.MetroButton();
		this.label2 = new System.Windows.Forms.Label();
		this.txtPathChromeOrigin = new MetroFramework.Controls.MetroTextBox();
		this.metroButton2 = new MetroFramework.Controls.MetroButton();
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
		this.bunifuCards1.Size = new System.Drawing.Size(594, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(594, 32);
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
		this.btnMinimize.Location = new System.Drawing.Point(562, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(594, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh ta\u0323o Shortcut Chrome";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(303, 139);
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
		this.btnAdd.Location = new System.Drawing.Point(199, 139);
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
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(33, 60);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(105, 16);
		this.label1.TabIndex = 5;
		this.label1.Text = "Nơi lưu Shortcut:";
		this.txtPathShortcut.CustomButton.Image = null;
		this.txtPathShortcut.CustomButton.Location = new System.Drawing.Point(330, 1);
		this.txtPathShortcut.CustomButton.Name = "";
		this.txtPathShortcut.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtPathShortcut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtPathShortcut.CustomButton.TabIndex = 1;
		this.txtPathShortcut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtPathShortcut.CustomButton.UseSelectable = true;
		this.txtPathShortcut.CustomButton.Visible = false;
		this.txtPathShortcut.Lines = new string[0];
		this.txtPathShortcut.Location = new System.Drawing.Point(157, 58);
		this.txtPathShortcut.MaxLength = 32767;
		this.txtPathShortcut.Name = "txtPathShortcut";
		this.txtPathShortcut.PasswordChar = '\0';
		this.txtPathShortcut.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtPathShortcut.SelectedText = "";
		this.txtPathShortcut.SelectionLength = 0;
		this.txtPathShortcut.SelectionStart = 0;
		this.txtPathShortcut.ShortcutsEnabled = true;
		this.txtPathShortcut.Size = new System.Drawing.Size(352, 23);
		this.txtPathShortcut.TabIndex = 6;
		this.txtPathShortcut.UseSelectable = true;
		this.txtPathShortcut.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtPathShortcut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(515, 58);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(47, 24);
		this.metroButton1.TabIndex = 7;
		this.metroButton1.Text = "Cho\u0323n";
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(33, 91);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(125, 16);
		this.label2.TabIndex = 5;
		this.label2.Text = "Đươ\u0300ng dâ\u0303n Chrome:";
		this.txtPathChromeOrigin.CustomButton.Image = null;
		this.txtPathChromeOrigin.CustomButton.Location = new System.Drawing.Point(330, 1);
		this.txtPathChromeOrigin.CustomButton.Name = "";
		this.txtPathChromeOrigin.CustomButton.Size = new System.Drawing.Size(21, 21);
		this.txtPathChromeOrigin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
		this.txtPathChromeOrigin.CustomButton.TabIndex = 1;
		this.txtPathChromeOrigin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
		this.txtPathChromeOrigin.CustomButton.UseSelectable = true;
		this.txtPathChromeOrigin.CustomButton.Visible = false;
		this.txtPathChromeOrigin.Lines = new string[1] { "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe" };
		this.txtPathChromeOrigin.Location = new System.Drawing.Point(157, 89);
		this.txtPathChromeOrigin.MaxLength = 32767;
		this.txtPathChromeOrigin.Name = "txtPathChromeOrigin";
		this.txtPathChromeOrigin.PasswordChar = '\0';
		this.txtPathChromeOrigin.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtPathChromeOrigin.SelectedText = "";
		this.txtPathChromeOrigin.SelectionLength = 0;
		this.txtPathChromeOrigin.SelectionStart = 0;
		this.txtPathChromeOrigin.ShortcutsEnabled = true;
		this.txtPathChromeOrigin.Size = new System.Drawing.Size(352, 23);
		this.txtPathChromeOrigin.TabIndex = 6;
		this.txtPathChromeOrigin.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		this.txtPathChromeOrigin.UseSelectable = true;
		this.txtPathChromeOrigin.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
		this.txtPathChromeOrigin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
		this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton2.Location = new System.Drawing.Point(515, 89);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new System.Drawing.Size(47, 24);
		this.metroButton2.TabIndex = 7;
		this.metroButton2.Text = "Cho\u0323n";
		this.metroButton2.UseSelectable = true;
		this.metroButton2.Click += new System.EventHandler(metroButton2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(594, 187);
		base.Controls.Add(this.metroButton2);
		base.Controls.Add(this.metroButton1);
		base.Controls.Add(this.txtPathChromeOrigin);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.txtPathShortcut);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTaoShortcut";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTaoShortcut_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
