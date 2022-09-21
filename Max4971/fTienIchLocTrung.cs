using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fTienIchLocTrung : Form
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

	private BunifuCustomLabel lblTitle;

	private Button btnAdd;

	private RichTextBox txtInput;

	private GroupBox groupBox2;

	private RichTextBox txtOutput;

	private GroupBox groupBox1;

	private MetroButton btnNhapTuFile;

	private TextBox txtNhapTuFile;

	private RadioButton rbTuNhap;

	private RadioButton rbNhapTuFile;

	public fTienIchLocTrung()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(lblTitle);
		GClass29.smethod_1(rbNhapTuFile);
		GClass29.smethod_1(btnNhapTuFile);
		GClass29.smethod_1(rbTuNhap);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> source = new List<string>();
			string text = txtNhapTuFile.Text.Trim();
			if (rbNhapTuFile.Checked)
			{
				if (text.EndsWith(".txt"))
				{
					if (!File.Exists(text))
					{
						GClass38.smethod_0(GClass29.smethod_0("File dữ liệu nhập không tồn tại!"), 2);
					}
				}
				else
				{
					GClass38.smethod_0(GClass29.smethod_0("File nhập vào chỉ hỗ trợ đối với File (.txt)!"), 2);
				}
			}
			if (rbNhapTuFile.Checked)
			{
				source = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				source = txtInput.Lines.ToList();
			}
			List<string> list = source.Distinct().ToList();
			txtOutput.Lines = list.ToArray();
			GClass38.smethod_0(GClass29.smethod_0("Đã lọc xong!"));
		}
		catch (Exception)
		{
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtInput.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			rbTuNhap.Text = string.Format(GClass29.smethod_0("Tự nhập ({0})"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void rbNhapTuFile_CheckedChanged(object sender, EventArgs e)
	{
		txtNhapTuFile.Enabled = rbNhapTuFile.Checked;
		btnNhapTuFile.Enabled = rbNhapTuFile.Checked;
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		txtInput.Enabled = rbTuNhap.Checked;
	}

	private void btnNhapTuFile_Click(object sender, EventArgs e)
	{
		txtNhapTuFile.Text = GClass14.smethod_41();
	}

	private void txtOutput_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtOutput.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			groupBox2.Text = $"Output ({list_.Count.ToString()})";
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchLocTrung_Load(object sender, EventArgs e)
	{
		rbNhapTuFile_CheckedChanged(null, null);
		rbTuNhap_CheckedChanged(null, null);
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
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.txtOutput = new System.Windows.Forms.RichTextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.btnNhapTuFile = new MetroFramework.Controls.MetroButton();
		this.txtInput = new System.Windows.Forms.RichTextBox();
		this.txtNhapTuFile = new System.Windows.Forms.TextBox();
		this.rbTuNhap = new System.Windows.Forms.RadioButton();
		this.rbNhapTuFile = new System.Windows.Forms.RadioButton();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox1.SuspendLayout();
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
		this.bunifuCards1.Size = new System.Drawing.Size(509, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(838, 270);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox2.Controls.Add(this.txtOutput);
		this.groupBox2.Location = new System.Drawing.Point(469, 40);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(361, 223);
		this.groupBox2.TabIndex = 51;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Output (0)";
		this.txtOutput.Location = new System.Drawing.Point(6, 22);
		this.txtOutput.Name = "txtOutput";
		this.txtOutput.Size = new System.Drawing.Size(349, 194);
		this.txtOutput.TabIndex = 50;
		this.txtOutput.Text = "";
		this.txtOutput.WordWrap = false;
		this.txtOutput.TextChanged += new System.EventHandler(txtOutput_TextChanged);
		this.groupBox1.Controls.Add(this.btnNhapTuFile);
		this.groupBox1.Controls.Add(this.txtInput);
		this.groupBox1.Controls.Add(this.txtNhapTuFile);
		this.groupBox1.Controls.Add(this.rbTuNhap);
		this.groupBox1.Controls.Add(this.rbNhapTuFile);
		this.groupBox1.Location = new System.Drawing.Point(6, 40);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(361, 223);
		this.groupBox1.TabIndex = 51;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Input";
		this.btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapTuFile.Location = new System.Drawing.Point(287, 22);
		this.btnNhapTuFile.Name = "btnNhapTuFile";
		this.btnNhapTuFile.Size = new System.Drawing.Size(65, 24);
		this.btnNhapTuFile.TabIndex = 2;
		this.btnNhapTuFile.Text = "Chọn";
		this.btnNhapTuFile.UseSelectable = true;
		this.btnNhapTuFile.Click += new System.EventHandler(btnNhapTuFile_Click);
		this.txtInput.Location = new System.Drawing.Point(30, 75);
		this.txtInput.Name = "txtInput";
		this.txtInput.Size = new System.Drawing.Size(322, 141);
		this.txtInput.TabIndex = 50;
		this.txtInput.Text = "";
		this.txtInput.WordWrap = false;
		this.txtInput.TextChanged += new System.EventHandler(txtInput_TextChanged);
		this.txtNhapTuFile.Location = new System.Drawing.Point(110, 22);
		this.txtNhapTuFile.Name = "txtNhapTuFile";
		this.txtNhapTuFile.Size = new System.Drawing.Size(171, 23);
		this.txtNhapTuFile.TabIndex = 1;
		this.rbTuNhap.AutoSize = true;
		this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuNhap.Location = new System.Drawing.Point(9, 49);
		this.rbTuNhap.Name = "rbTuNhap";
		this.rbTuNhap.Size = new System.Drawing.Size(95, 20);
		this.rbTuNhap.TabIndex = 0;
		this.rbTuNhap.Text = "Tự nhập (0)";
		this.rbTuNhap.UseVisualStyleBackColor = true;
		this.rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		this.rbNhapTuFile.AutoSize = true;
		this.rbNhapTuFile.Checked = true;
		this.rbNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNhapTuFile.Location = new System.Drawing.Point(9, 23);
		this.rbNhapTuFile.Name = "rbNhapTuFile";
		this.rbNhapTuFile.Size = new System.Drawing.Size(95, 20);
		this.rbNhapTuFile.TabIndex = 0;
		this.rbNhapTuFile.TabStop = true;
		this.rbNhapTuFile.Text = "Nhập từ File";
		this.rbNhapTuFile.UseVisualStyleBackColor = true;
		this.rbNhapTuFile.CheckedChanged += new System.EventHandler(rbNhapTuFile_CheckedChanged);
		this.btnAdd.BackColor = System.Drawing.Color.Green;
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(379, 138);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(78, 29);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Start";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		this.bunifuCards2.Size = new System.Drawing.Size(836, 37);
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
		this.pnlHeader.Size = new System.Drawing.Size(836, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(805, 1);
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
		this.lblTitle.Size = new System.Drawing.Size(836, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Lọc trùng dữ liệu";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.lblTitle;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(838, 270);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchLocTrung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchLocTrung_Load);
		this.panel1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
