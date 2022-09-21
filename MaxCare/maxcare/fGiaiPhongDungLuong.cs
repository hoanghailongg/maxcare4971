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

public class fGiaiPhongDungLuong : Form
{
	[CompilerGenerated]
	private sealed class Class80
	{
		public List<string> list_0;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class Class81
	{
		public int int_0;

		public int int_1;

		public Class80 class80_0;
	}

	[CompilerGenerated]
	private sealed class Class82
	{
		public int int_0;

		public Class81 class81_0;

		internal void method_0()
		{
			try
			{
				string string_ = class81_0.class80_0.fGiaiPhongDungLuong_0.gclass17_0.method_0("txbPathProfile") + "\\" + class81_0.class80_0.list_0[int_0];
				GClass14.smethod_95(string_);
			}
			catch
			{
			}
			Interlocked.Increment(ref class81_0.int_0);
			class81_0.class80_0.fGiaiPhongDungLuong_0.method_1(class81_0.class80_0.fGiaiPhongDungLuong_0.lblStatusDonDepProfileRac, $"Đang chạy {class81_0.int_0}/{class81_0.class80_0.list_0.Count}...");
			Interlocked.Decrement(ref class81_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class83
	{
		public int int_0;

		public List<string> list_0;

		public int int_1;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class Class84
	{
		public string string_0;

		public Class83 class83_0;

		internal void method_0()
		{
			try
			{
				string text = class83_0.fGiaiPhongDungLuong_0.gclass17_0.method_0("txbPathProfile") + "\\" + string_0;
				if (Directory.Exists(text))
				{
					GClass14.smethod_95(text + "\\Default\\Cache");
					GClass14.smethod_95(text + "\\Default\\Code Cache");
					GClass14.smethod_95(text + "\\OptimizationGuidePredictionModels");
				}
			}
			catch
			{
			}
			Interlocked.Increment(ref class83_0.int_0);
			class83_0.fGiaiPhongDungLuong_0.method_1(class83_0.fGiaiPhongDungLuong_0.lblStatusXoaCacheProfile, $"Đang chạy {class83_0.int_0}/{class83_0.list_0.Count}...");
			Interlocked.Decrement(ref class83_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class85
	{
		public List<string> list_0;

		public int int_0;

		public int int_1;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class Class86
	{
		public int int_0;

		public Class85 class85_0;

		internal void method_0()
		{
			try
			{
				GClass14.smethod_95(class85_0.list_0[int_0]);
			}
			catch
			{
			}
			Interlocked.Increment(ref class85_0.int_0);
			class85_0.fGiaiPhongDungLuong_0.method_1(class85_0.fGiaiPhongDungLuong_0.lblStatusXoaTemp, $"Đang chạy {class85_0.int_0}/{class85_0.list_0.Count}...");
			Interlocked.Decrement(ref class85_0.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class87
	{
		public Label label_0;

		public string string_0;

		internal void method_0()
		{
			label_0.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class88
	{
		public Label label_0;

		internal void method_0()
		{
			label_0.Visible = true;
		}
	}

	[CompilerGenerated]
	private sealed class Class89
	{
		public bool bool_0;

		public Label label_0;

		internal void method_0()
		{
			if (bool_0)
			{
				label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			}
			else
			{
				label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}
	}

	private bool bool_0 = false;

	private GClass17 gclass17_0;

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label lblXoaFileRac;

	private Label lblDonDepProfileRac;

	private Label lblXoaCacheProfile;

	private Label lblStatusXoaFileRac;

	private Label lblStatusDonDepProfileRac;

	private Label lblStatusXoaCacheProfile;

	private Label lblStatusXoaTemp;

	private Label lblXoaTemp;

	public fGiaiPhongDungLuong(bool bool_2 = false)
	{
		InitializeComponent();
		gclass17_0 = new GClass17("configGeneral");
		bool_0 = bool_2;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		btnCancel.Invoke((Action)delegate
		{
			btnCancel.Enabled = false;
		});
		bool_1 = true;
	}

	private List<string> method_0()
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

	private void method_1(Label label_0, string string_0)
	{
		try
		{
			Invoke((Action)delegate
			{
				label_0.Text = string_0;
			});
		}
		catch
		{
		}
	}

	private void method_2(Label label_0)
	{
		try
		{
			Invoke((Action)delegate
			{
				label_0.Visible = true;
			});
		}
		catch
		{
		}
	}

	private void method_3(Label label_0, bool bool_2 = true)
	{
		try
		{
			Invoke((Action)delegate
			{
				if (bool_2)
				{
					label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
				}
				else
				{
					label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
			});
		}
		catch
		{
		}
	}

	private void fGiaiPhongDungLuong_Load(object sender, EventArgs e)
	{
		GClass14.smethod_42("chromedriver");
		new Thread((ThreadStart)delegate
		{
			method_3(lblXoaFileRac);
			method_1(lblStatusXoaFileRac, "Đang chạy...");
			method_2(lblStatusXoaFileRac);
			GClass14.smethod_95("log");
			GClass14.smethod_95("log_capture");
			if (!bool_1)
			{
				method_1(lblStatusXoaFileRac, "Hoàn thành!");
				method_3(lblXoaFileRac, bool_2: false);
				method_3(lblDonDepProfileRac);
				method_1(lblStatusDonDepProfileRac, "");
				method_2(lblStatusDonDepProfileRac);
				List<string> list = Directory.GetDirectories(gclass17_0.method_0("txbPathProfile")).ToList();
				List<string> list2 = method_0();
				List<string> list_2 = new List<string>();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						list_2.Add(text);
					}
				}
				try
				{
					int int_7 = 0;
					int num = 100;
					int int_4 = 0;
					int num2 = 0;
					while (num2 < list_2.Count && !bool_1)
					{
						if (int_7 < num)
						{
							Interlocked.Increment(ref int_7);
							int int_3 = num2++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string string_ = gclass17_0.method_0("txbPathProfile") + "\\" + list_2[int_3];
									GClass14.smethod_95(string_);
								}
								catch
								{
								}
								Interlocked.Increment(ref int_4);
								method_1(lblStatusDonDepProfileRac, $"Đang chạy {int_4}/{list_2.Count}...");
								Interlocked.Decrement(ref int_7);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					while (int_7 > 0)
					{
						GClass14.smethod_58(1.0);
					}
				}
				catch
				{
				}
				if (!bool_1)
				{
					method_1(lblStatusDonDepProfileRac, "Hoàn thành!");
					method_3(lblDonDepProfileRac, bool_2: false);
					method_3(lblXoaCacheProfile);
					method_1(lblStatusXoaCacheProfile, "");
					method_2(lblStatusXoaCacheProfile);
					int int_6 = 0;
					int num3 = 100;
					int int_2 = 0;
					List<string> list_ = method_0();
					int num4 = 0;
					while (num4 < list_.Count && !bool_1)
					{
						if (int_6 < num3)
						{
							Interlocked.Increment(ref int_6);
							string string_0 = list_[num4++];
							new Thread((ThreadStart)delegate
							{
								try
								{
									string text2 = gclass17_0.method_0("txbPathProfile") + "\\" + string_0;
									if (Directory.Exists(text2))
									{
										GClass14.smethod_95(text2 + "\\Default\\Cache");
										GClass14.smethod_95(text2 + "\\Default\\Code Cache");
										GClass14.smethod_95(text2 + "\\OptimizationGuidePredictionModels");
									}
								}
								catch
								{
								}
								Interlocked.Increment(ref int_2);
								method_1(lblStatusXoaCacheProfile, $"Đang chạy {int_2}/{list_.Count}...");
								Interlocked.Decrement(ref int_6);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					while (int_6 > 0)
					{
						GClass14.smethod_58(1.0);
					}
					if (!bool_1)
					{
						method_1(lblStatusXoaCacheProfile, "Hoàn thành!");
						method_3(lblXoaCacheProfile, bool_2: false);
						method_3(lblXoaTemp);
						method_1(lblStatusXoaTemp, "");
						method_2(lblStatusXoaTemp);
						try
						{
							int int_5 = 0;
							int num5 = 100;
							int int_ = 0;
							List<string> list_0 = Directory.GetDirectories(Path.GetTempPath()).ToList();
							int num6 = 0;
							while (num6 < list_0.Count && !bool_1)
							{
								if (int_5 < num5)
								{
									Interlocked.Increment(ref int_5);
									int int_0 = num6++;
									new Thread((ThreadStart)delegate
									{
										try
										{
											GClass14.smethod_95(list_0[int_0]);
										}
										catch
										{
										}
										Interlocked.Increment(ref int_);
										method_1(lblStatusXoaTemp, $"Đang chạy {int_}/{list_0.Count}...");
										Interlocked.Decrement(ref int_5);
									}).Start();
								}
								else
								{
									Application.DoEvents();
									Thread.Sleep(200);
								}
							}
							while (int_5 > 0)
							{
								GClass14.smethod_58(1.0);
							}
						}
						catch
						{
						}
					}
				}
			}
			if (bool_0)
			{
				GClass14.smethod_15();
			}
			Invoke((Action)delegate
			{
				Close();
			});
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
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.lblXoaFileRac = new System.Windows.Forms.Label();
		this.lblDonDepProfileRac = new System.Windows.Forms.Label();
		this.lblXoaCacheProfile = new System.Windows.Forms.Label();
		this.lblStatusXoaFileRac = new System.Windows.Forms.Label();
		this.lblStatusDonDepProfileRac = new System.Windows.Forms.Label();
		this.lblStatusXoaCacheProfile = new System.Windows.Forms.Label();
		this.lblStatusXoaTemp = new System.Windows.Forms.Label();
		this.lblXoaTemp = new System.Windows.Forms.Label();
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
		this.bunifuCards1.Size = new System.Drawing.Size(373, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(373, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Class306.Bitmap_59;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.Enabled = false;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = Class306.Bitmap_12;
		this.btnMinimize.Location = new System.Drawing.Point(341, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(373, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Giải phóng dung lượng";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(142, 191);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Dừng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.lblXoaFileRac.AutoSize = true;
		this.lblXoaFileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblXoaFileRac.Location = new System.Drawing.Point(35, 71);
		this.lblXoaFileRac.Name = "lblXoaFileRac";
		this.lblXoaFileRac.Size = new System.Drawing.Size(90, 16);
		this.lblXoaFileRac.TabIndex = 5;
		this.lblXoaFileRac.Text = "1. Xóa File rác";
		this.lblDonDepProfileRac.AutoSize = true;
		this.lblDonDepProfileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblDonDepProfileRac.Location = new System.Drawing.Point(35, 95);
		this.lblDonDepProfileRac.Name = "lblDonDepProfileRac";
		this.lblDonDepProfileRac.Size = new System.Drawing.Size(131, 16);
		this.lblDonDepProfileRac.TabIndex = 5;
		this.lblDonDepProfileRac.Text = "2. Dọn dẹp profile rác";
		this.lblXoaCacheProfile.AutoSize = true;
		this.lblXoaCacheProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblXoaCacheProfile.Location = new System.Drawing.Point(35, 119);
		this.lblXoaCacheProfile.Name = "lblXoaCacheProfile";
		this.lblXoaCacheProfile.Size = new System.Drawing.Size(123, 16);
		this.lblXoaCacheProfile.TabIndex = 5;
		this.lblXoaCacheProfile.Text = "3. Xóa Cache profile";
		this.lblStatusXoaFileRac.AutoSize = true;
		this.lblStatusXoaFileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusXoaFileRac.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusXoaFileRac.Location = new System.Drawing.Point(200, 71);
		this.lblStatusXoaFileRac.Name = "lblStatusXoaFileRac";
		this.lblStatusXoaFileRac.Size = new System.Drawing.Size(79, 16);
		this.lblStatusXoaFileRac.TabIndex = 5;
		this.lblStatusXoaFileRac.Text = "Đang chạy...";
		this.lblStatusXoaFileRac.Visible = false;
		this.lblStatusDonDepProfileRac.AutoSize = true;
		this.lblStatusDonDepProfileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusDonDepProfileRac.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusDonDepProfileRac.Location = new System.Drawing.Point(200, 95);
		this.lblStatusDonDepProfileRac.Name = "lblStatusDonDepProfileRac";
		this.lblStatusDonDepProfileRac.Size = new System.Drawing.Size(102, 16);
		this.lblStatusDonDepProfileRac.TabIndex = 5;
		this.lblStatusDonDepProfileRac.Text = "Đang chạy 0/0...";
		this.lblStatusDonDepProfileRac.Visible = false;
		this.lblStatusXoaCacheProfile.AutoSize = true;
		this.lblStatusXoaCacheProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusXoaCacheProfile.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusXoaCacheProfile.Location = new System.Drawing.Point(200, 119);
		this.lblStatusXoaCacheProfile.Name = "lblStatusXoaCacheProfile";
		this.lblStatusXoaCacheProfile.Size = new System.Drawing.Size(102, 16);
		this.lblStatusXoaCacheProfile.TabIndex = 5;
		this.lblStatusXoaCacheProfile.Text = "Đang chạy 0/0...";
		this.lblStatusXoaCacheProfile.Visible = false;
		this.lblStatusXoaTemp.AutoSize = true;
		this.lblStatusXoaTemp.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusXoaTemp.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusXoaTemp.Location = new System.Drawing.Point(200, 144);
		this.lblStatusXoaTemp.Name = "lblStatusXoaTemp";
		this.lblStatusXoaTemp.Size = new System.Drawing.Size(102, 16);
		this.lblStatusXoaTemp.TabIndex = 5;
		this.lblStatusXoaTemp.Text = "Đang chạy 0/0...";
		this.lblStatusXoaTemp.Visible = false;
		this.lblXoaTemp.AutoSize = true;
		this.lblXoaTemp.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblXoaTemp.Location = new System.Drawing.Point(35, 144);
		this.lblXoaTemp.Name = "lblXoaTemp";
		this.lblXoaTemp.Size = new System.Drawing.Size(81, 16);
		this.lblXoaTemp.TabIndex = 5;
		this.lblXoaTemp.Text = "4. Xóa Temp";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(373, 232);
		base.Controls.Add(this.lblXoaTemp);
		base.Controls.Add(this.lblXoaCacheProfile);
		base.Controls.Add(this.lblStatusXoaTemp);
		base.Controls.Add(this.lblDonDepProfileRac);
		base.Controls.Add(this.lblStatusXoaCacheProfile);
		base.Controls.Add(this.lblStatusDonDepProfileRac);
		base.Controls.Add(this.lblStatusXoaFileRac);
		base.Controls.Add(this.lblXoaFileRac);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fGiaiPhongDungLuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fGiaiPhongDungLuong_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_4()
	{
		btnCancel.Enabled = false;
	}

	[CompilerGenerated]
	private void method_5()
	{
		method_3(lblXoaFileRac);
		method_1(lblStatusXoaFileRac, "Đang chạy...");
		method_2(lblStatusXoaFileRac);
		GClass14.smethod_95("log");
		GClass14.smethod_95("log_capture");
		if (!bool_1)
		{
			method_1(lblStatusXoaFileRac, "Hoàn thành!");
			method_3(lblXoaFileRac, bool_2: false);
			method_3(lblDonDepProfileRac);
			method_1(lblStatusDonDepProfileRac, "");
			method_2(lblStatusDonDepProfileRac);
			List<string> list = Directory.GetDirectories(gclass17_0.method_0("txbPathProfile")).ToList();
			List<string> list2 = method_0();
			List<string> list_2 = new List<string>();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					list_2.Add(text);
				}
			}
			try
			{
				int int_7 = 0;
				int num = 100;
				int int_4 = 0;
				int num2 = 0;
				while (num2 < list_2.Count && !bool_1)
				{
					if (int_7 < num)
					{
						Interlocked.Increment(ref int_7);
						int int_3 = num2++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string string_ = gclass17_0.method_0("txbPathProfile") + "\\" + list_2[int_3];
								GClass14.smethod_95(string_);
							}
							catch
							{
							}
							Interlocked.Increment(ref int_4);
							method_1(lblStatusDonDepProfileRac, $"Đang chạy {int_4}/{list_2.Count}...");
							Interlocked.Decrement(ref int_7);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_7 > 0)
				{
					GClass14.smethod_58(1.0);
				}
			}
			catch
			{
			}
			if (!bool_1)
			{
				method_1(lblStatusDonDepProfileRac, "Hoàn thành!");
				method_3(lblDonDepProfileRac, bool_2: false);
				method_3(lblXoaCacheProfile);
				method_1(lblStatusXoaCacheProfile, "");
				method_2(lblStatusXoaCacheProfile);
				int int_6 = 0;
				int num3 = 100;
				int int_2 = 0;
				List<string> list_ = method_0();
				int num4 = 0;
				while (num4 < list_.Count && !bool_1)
				{
					if (int_6 < num3)
					{
						Interlocked.Increment(ref int_6);
						string string_0 = list_[num4++];
						new Thread((ThreadStart)delegate
						{
							try
							{
								string text2 = gclass17_0.method_0("txbPathProfile") + "\\" + string_0;
								if (Directory.Exists(text2))
								{
									GClass14.smethod_95(text2 + "\\Default\\Cache");
									GClass14.smethod_95(text2 + "\\Default\\Code Cache");
									GClass14.smethod_95(text2 + "\\OptimizationGuidePredictionModels");
								}
							}
							catch
							{
							}
							Interlocked.Increment(ref int_2);
							method_1(lblStatusXoaCacheProfile, $"Đang chạy {int_2}/{list_.Count}...");
							Interlocked.Decrement(ref int_6);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_6 > 0)
				{
					GClass14.smethod_58(1.0);
				}
				if (!bool_1)
				{
					method_1(lblStatusXoaCacheProfile, "Hoàn thành!");
					method_3(lblXoaCacheProfile, bool_2: false);
					method_3(lblXoaTemp);
					method_1(lblStatusXoaTemp, "");
					method_2(lblStatusXoaTemp);
					try
					{
						int int_5 = 0;
						int num5 = 100;
						int int_ = 0;
						List<string> list_0 = Directory.GetDirectories(Path.GetTempPath()).ToList();
						int num6 = 0;
						while (num6 < list_0.Count && !bool_1)
						{
							if (int_5 < num5)
							{
								Interlocked.Increment(ref int_5);
								int int_0 = num6++;
								new Thread((ThreadStart)delegate
								{
									try
									{
										GClass14.smethod_95(list_0[int_0]);
									}
									catch
									{
									}
									Interlocked.Increment(ref int_);
									method_1(lblStatusXoaTemp, $"Đang chạy {int_}/{list_0.Count}...");
									Interlocked.Decrement(ref int_5);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						while (int_5 > 0)
						{
							GClass14.smethod_58(1.0);
						}
					}
					catch
					{
					}
				}
			}
		}
		if (bool_0)
		{
			GClass14.smethod_15();
		}
		Invoke((Action)delegate
		{
			Close();
		});
	}

	[CompilerGenerated]
	private void method_6()
	{
		Close();
	}
}
