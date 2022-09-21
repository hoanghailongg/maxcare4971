using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;

public class fTienIchCheckImapHotmail : Form
{
	[CompilerGenerated]
	private sealed class Class194
	{
		public int int_0;

		public fTienIchCheckImapHotmail fTienIchCheckImapHotmail_0;
	}

	[CompilerGenerated]
	private sealed class Class195
	{
		public string string_0;

		public Class194 class194_0;

		internal void method_0()
		{
			if (class194_0.fTienIchCheckImapHotmail_0.method_2(string_0))
			{
				class194_0.fTienIchCheckImapHotmail_0.method_1(class194_0.fTienIchCheckImapHotmail_0.txtDaTao, string_0);
			}
			else
			{
				class194_0.fTienIchCheckImapHotmail_0.method_1(class194_0.fTienIchCheckImapHotmail_0.txtChuaTao, string_0);
			}
			Interlocked.Decrement(ref class194_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class196
	{
		public RichTextBox richTextBox_0;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		}
	}

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

	private GroupBox grDaTao;

	private RichTextBox txtDaTao;

	private GroupBox groupBox1;

	private MetroButton btnNhapTuFile;

	private TextBox txtNhapTuFile;

	private RadioButton rbTuNhap;

	private RadioButton rbNhapTuFile;

	private GroupBox grChuaTao;

	private RichTextBox txtChuaTao;

	private Label lblStatus;

	public fTienIchCheckImapHotmail()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
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
			List<string> list = new List<string>();
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
				list = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				list = txtInput.Lines.ToList();
			}
			int int_0 = 0;
			int num = 50;
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string string_0 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						if (method_2(string_0))
						{
							method_1(txtDaTao, string_0);
						}
						else
						{
							method_1(txtChuaTao, string_0);
						}
						Interlocked.Decrement(ref int_0);
					}).Start();
				}
				else
				{
					Application.DoEvents();
					GClass14.smethod_58(1.0);
				}
			}
			while (int_0 > 0)
			{
				GClass14.smethod_58(1.0);
			}
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = false;
			});
			GClass38.smethod_0(GClass29.smethod_0("Đã check xong!"));
		}
		catch (Exception)
		{
			GClass38.smethod_0(GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void method_1(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private bool method_2(string string_0)
	{
		try
		{
			string[] array = string_0.Split('|');
			string string_ = "";
			string text = array[0];
			string text2 = array[1];
			if (text == "" || text2 == "")
			{
				return false;
			}
			if (array.Length > 2)
			{
				string_ = array[2];
			}
			return GClass14.smethod_14(text, text2, string_) == "1";
		}
		catch
		{
			return false;
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

	private void txtDaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtDaTao.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			grDaTao.Text = string.Format(GClass29.smethod_0("Live ({0})"), list_.Count.ToString());
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckImapHotmail_Load(object sender, EventArgs e)
	{
		rbNhapTuFile_CheckedChanged(null, null);
		rbTuNhap_CheckedChanged(null, null);
	}

	private void txtChuaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = txtChuaTao.Lines.ToList();
			list_ = GClass14.smethod_36(list_);
			grChuaTao.Text = string.Format(GClass29.smethod_0("Die ({0})"), list_.Count.ToString());
		}
		catch
		{
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
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.lblStatus = new System.Windows.Forms.Label();
		this.grChuaTao = new System.Windows.Forms.GroupBox();
		this.txtChuaTao = new System.Windows.Forms.RichTextBox();
		this.grDaTao = new System.Windows.Forms.GroupBox();
		this.txtDaTao = new System.Windows.Forms.RichTextBox();
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
		this.grChuaTao.SuspendLayout();
		this.grDaTao.SuspendLayout();
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
		this.bunifuCards1.Size = new System.Drawing.Size(466, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.grChuaTao);
		this.panel1.Controls.Add(this.grDaTao);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(795, 404);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.lblStatus.AutoSize = true;
		this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatus.Location = new System.Drawing.Point(480, 59);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(71, 16);
		this.lblStatus.TabIndex = 52;
		this.lblStatus.Text = "Checking...";
		this.lblStatus.Visible = false;
		this.grChuaTao.Controls.Add(this.txtChuaTao);
		this.grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
		this.grChuaTao.Location = new System.Drawing.Point(566, 91);
		this.grChuaTao.Name = "grChuaTao";
		this.grChuaTao.Size = new System.Drawing.Size(221, 307);
		this.grChuaTao.TabIndex = 51;
		this.grChuaTao.TabStop = false;
		this.grChuaTao.Text = "Die (0)";
		this.txtChuaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtChuaTao.Location = new System.Drawing.Point(3, 19);
		this.txtChuaTao.Name = "txtChuaTao";
		this.txtChuaTao.Size = new System.Drawing.Size(215, 285);
		this.txtChuaTao.TabIndex = 50;
		this.txtChuaTao.Text = "";
		this.txtChuaTao.WordWrap = false;
		this.txtChuaTao.TextChanged += new System.EventHandler(txtChuaTao_TextChanged);
		this.grDaTao.Controls.Add(this.txtDaTao);
		this.grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		this.grDaTao.Location = new System.Drawing.Point(339, 91);
		this.grDaTao.Name = "grDaTao";
		this.grDaTao.Size = new System.Drawing.Size(221, 307);
		this.grDaTao.TabIndex = 51;
		this.grDaTao.TabStop = false;
		this.grDaTao.Text = "Live (0)";
		this.txtDaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtDaTao.Location = new System.Drawing.Point(3, 19);
		this.txtDaTao.Name = "txtDaTao";
		this.txtDaTao.Size = new System.Drawing.Size(215, 285);
		this.txtDaTao.TabIndex = 50;
		this.txtDaTao.Text = "";
		this.txtDaTao.WordWrap = false;
		this.txtDaTao.TextChanged += new System.EventHandler(txtDaTao_TextChanged);
		this.groupBox1.Controls.Add(this.btnNhapTuFile);
		this.groupBox1.Controls.Add(this.txtInput);
		this.groupBox1.Controls.Add(this.txtNhapTuFile);
		this.groupBox1.Controls.Add(this.rbTuNhap);
		this.groupBox1.Controls.Add(this.rbNhapTuFile);
		this.groupBox1.Location = new System.Drawing.Point(6, 40);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(316, 358);
		this.groupBox1.TabIndex = 51;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Input: Email|Pass mail hoặc Email|Pass mail|Imap";
		this.btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapTuFile.Location = new System.Drawing.Point(243, 22);
		this.btnNhapTuFile.Name = "btnNhapTuFile";
		this.btnNhapTuFile.Size = new System.Drawing.Size(64, 24);
		this.btnNhapTuFile.TabIndex = 2;
		this.btnNhapTuFile.Text = "Chọn";
		this.btnNhapTuFile.UseSelectable = true;
		this.btnNhapTuFile.Click += new System.EventHandler(btnNhapTuFile_Click);
		this.txtInput.Location = new System.Drawing.Point(30, 75);
		this.txtInput.Name = "txtInput";
		this.txtInput.Size = new System.Drawing.Size(277, 277);
		this.txtInput.TabIndex = 50;
		this.txtInput.Text = "";
		this.txtInput.WordWrap = false;
		this.txtInput.TextChanged += new System.EventHandler(txtInput_TextChanged);
		this.txtNhapTuFile.Location = new System.Drawing.Point(110, 22);
		this.txtNhapTuFile.Name = "txtNhapTuFile";
		this.txtNhapTuFile.Size = new System.Drawing.Size(127, 23);
		this.txtNhapTuFile.TabIndex = 1;
		this.rbTuNhap.AutoSize = true;
		this.rbTuNhap.Checked = true;
		this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuNhap.Location = new System.Drawing.Point(9, 49);
		this.rbTuNhap.Name = "rbTuNhap";
		this.rbTuNhap.Size = new System.Drawing.Size(95, 20);
		this.rbTuNhap.TabIndex = 0;
		this.rbTuNhap.TabStop = true;
		this.rbTuNhap.Text = "Tự nhập (0)";
		this.rbTuNhap.UseVisualStyleBackColor = true;
		this.rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		this.rbNhapTuFile.AutoSize = true;
		this.rbNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNhapTuFile.Location = new System.Drawing.Point(9, 23);
		this.rbNhapTuFile.Name = "rbNhapTuFile";
		this.rbNhapTuFile.Size = new System.Drawing.Size(95, 20);
		this.rbNhapTuFile.TabIndex = 0;
		this.rbNhapTuFile.Text = "Nhập từ File";
		this.rbNhapTuFile.UseVisualStyleBackColor = true;
		this.rbNhapTuFile.CheckedChanged += new System.EventHandler(rbNhapTuFile_CheckedChanged);
		this.btnAdd.BackColor = System.Drawing.Color.Green;
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(339, 49);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(135, 36);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Check";
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
		this.bunifuCards2.Size = new System.Drawing.Size(793, 37);
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
		this.pnlHeader.Size = new System.Drawing.Size(793, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Class306.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(762, 1);
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
		this.lblTitle.Size = new System.Drawing.Size(793, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Check có thể kết nối Email bằng Imap không?";
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
		base.ClientSize = new System.Drawing.Size(795, 404);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckImapHotmail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckImapHotmail_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.grChuaTao.ResumeLayout(false);
		this.grDaTao.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_3()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void method_4()
	{
		lblStatus.Visible = false;
	}
}
