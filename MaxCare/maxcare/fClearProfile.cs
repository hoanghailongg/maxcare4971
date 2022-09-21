using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fClearProfile : Form
{
	[CompilerGenerated]
	private sealed class Class202
	{
		public int int_0;

		public int int_1;

		public fClearProfile fClearProfile_0;

		public int int_2;

		public Action action_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fClearProfile_0.list_0.Count)
				{
					if (int_0 < int_1)
					{
						Class203 CS_0024_003C_003E8__locals0 = new Class203
						{
							class202_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = CS_0024_003C_003E8__locals0.class202_0.fClearProfile_0.gclass17_0.method_0("txbPathProfile") + "\\" + CS_0024_003C_003E8__locals0.class202_0.fClearProfile_0.list_0[CS_0024_003C_003E8__locals0.int_0];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.class202_0.int_2);
								CS_0024_003C_003E8__locals0.class202_0.fClearProfile_0.method_2(string.Format(GClass29.smethod_0("Đang dọn dẹp profile {0}/{1}..."), CS_0024_003C_003E8__locals0.class202_0.int_2, CS_0024_003C_003E8__locals0.class202_0.fClearProfile_0.list_0.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class202_0.int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					GClass14.smethod_58(1.0);
				}
				fClearProfile_0.Invoke((Action)delegate
				{
					fClearProfile_0.Close();
					GClass38.smethod_0(GClass29.smethod_0("Đã dọn dẹp profile xong!"));
				});
			}
			catch
			{
			}
		}

		internal void method_1()
		{
			fClearProfile_0.Close();
			GClass38.smethod_0(GClass29.smethod_0("Đã dọn dẹp profile xong!"));
		}
	}

	[CompilerGenerated]
	private sealed class Class203
	{
		public int int_0;

		public Class202 class202_0;

		internal void method_0()
		{
			try
			{
				string path = class202_0.fClearProfile_0.gclass17_0.method_0("txbPathProfile") + "\\" + class202_0.fClearProfile_0.list_0[int_0];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref class202_0.int_2);
				class202_0.fClearProfile_0.method_2(string.Format(GClass29.smethod_0("Đang dọn dẹp profile {0}/{1}..."), class202_0.int_2, class202_0.fClearProfile_0.list_0.Count));
				Interlocked.Decrement(ref class202_0.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class204
	{
		public fClearProfile fClearProfile_0;

		public string string_0;

		internal void method_0()
		{
			fClearProfile_0.lblStatus.Text = string_0;
		}
	}

	private GClass17 gclass17_0;

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel lblStatus;

	private PictureBox pictureBox1;

	public fClearProfile()
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configGeneral");
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(lblStatus);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		btnAdd.Enabled = false;
		btnCancel.Enabled = false;
		int int_2 = 0;
		method_2(string.Format(GClass29.smethod_0("Đang dọn dẹp profile {0}/{1}..."), int_2, list_0.Count));
		int int_0 = 0;
		int int_1 = 20;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < list_0.Count)
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_3 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = gclass17_0.method_0("txbPathProfile") + "\\" + list_0[int_3];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref int_2);
								method_2(string.Format(GClass29.smethod_0("Đang dọn dẹp profile {0}/{1}..."), int_2, list_0.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					GClass14.smethod_58(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					GClass38.smethod_0(GClass29.smethod_0("Đã dọn dẹp profile xong!"));
				});
			}
			catch
			{
			}
		}).Start();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	private List<string> method_1()
	{
		List<string> list = new List<string>();
		try
		{
			DataTable dataTable = Class36.smethod_22();
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["uid"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	private void method_2(string string_0)
	{
		Invoke((Action)delegate
		{
			lblStatus.Text = string_0;
		});
	}

	private void fClearProfile_Load(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = Directory.GetDirectories(gclass17_0.method_0("txbPathProfile")).ToList();
				List<string> list2 = method_1();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						list_0.Add(text);
					}
				}
				if (list_0.Count > 0)
				{
					Invoke((Action)delegate
					{
						lblStatus.Text = string.Format(GClass29.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + GClass29.smethod_0("Bạn có muốn dọn dẹp?");
						btnAdd.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						GClass38.smethod_0(GClass29.smethod_0("Không có profile rác!"));
					});
				}
			}
			catch (Exception)
			{
			}
		}).Start();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClearProfile));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(364, 0);
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
		this.bunifuCustomLabel1.Text = "Dọn dẹp profile";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(204, 105);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Hủy";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Visible = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(100, 105);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Đồng ý";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Visible = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.lblStatus.BackColor = System.Drawing.Color.Transparent;
		this.lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ForeColor = System.Drawing.Color.Black;
		this.lblStatus.Location = new System.Drawing.Point(-1, 57);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(396, 32);
		this.lblStatus.TabIndex = 21;
		this.lblStatus.Text = "Đang quét profile...";
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblStatus.Click += new System.EventHandler(lblStatus_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fClearProfile_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_3()
	{
		try
		{
			List<string> list = Directory.GetDirectories(gclass17_0.method_0("txbPathProfile")).ToList();
			List<string> list2 = method_1();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					list_0.Add(text);
				}
			}
			if (list_0.Count > 0)
			{
				Invoke((Action)delegate
				{
					lblStatus.Text = string.Format(GClass29.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + GClass29.smethod_0("Bạn có muốn dọn dẹp?");
					btnAdd.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					GClass38.smethod_0(GClass29.smethod_0("Không có profile rác!"));
				});
			}
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void method_4()
	{
		lblStatus.Text = string.Format(GClass29.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + GClass29.smethod_0("Bạn có muốn dọn dẹp?");
		btnAdd.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void method_5()
	{
		Close();
		GClass38.smethod_0(GClass29.smethod_0("Không có profile rác!"));
	}
}
