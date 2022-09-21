using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DeviceId;
using MetroFramework.Controls;

public class fIntro : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private PictureBox pictureBox1;

	private MetroProgressBar progressBar;

	private Timer timer_0;

	private Timer timer_1;

	private Label label7;

	private Label label10;

	private Panel panel3;

	private LinkLabel linkLabel4;

	private Label label2;

	private Label label8;

	private Label label9;

	private Label label3;

	private Panel panel2;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label11;

	private PictureBox pictureBox2;

	private Label label12;

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	public fIntro()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(label10);
		GClass29.smethod_1(label7);
	}

	private void fIntro_Load(object sender, EventArgs e)
	{
		Class305.int_0++;
		timer_0.Tick += timer_0_Tick;
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			timer_0.Stop();
			try
			{
				try
				{
					GClass17 gClass = new GClass17("settingLogin");
					gClass.method_0("UserName");
					gClass.method_0("PassWord");
					gClass.method_0("Domain");
				}
				catch
				{
				}
				string string_ = (Class49.string_0 = "Đã kích hoạt");
				new GClass18();
				new GClass4();
				new Random().Next(0, 999999);
				Class49.string_1 = "Đã kích hoạt";
				Class49.string_10 += "_";
				string text = "LTD|LTD|2050/03/01 00:00:00 AM|MIN223B399297F9AD197CD2CBE0DBD92108";
				Class49.string_2 = text.Replace(text.Split('|')[3], GClass22.smethod_14(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
					.AddSystemDriveSerialNumber()
					.ToString())) + "code";
				Hide();
				try
				{
					_ = text.Split('|')[0];
					_ = text.Split('|')[1];
					_ = text.Split('|')[2];
					new fMain(text).ShowDialog();
				}
				catch
				{
					new fActive(1, string_).ShowDialog();
				}
				timer_0.Tick += timer_0_Tick_1;
				timer_0.Start();
				return;
			}
			catch (Exception exception_)
			{
				GClass38.smethod_0(GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!"), 2);
				GClass14.smethod_75(null, exception_, "Run Program");
				Close();
				return;
			}
		}
		base.Opacity += 0.05;
	}

	private void timer_0_Tick_1(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			timer_0.Stop();
			Close();
		}
		else
		{
			base.Opacity -= 0.05;
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (progressBar.Value < 90)
		{
			progressBar.Value += 10;
		}
		else
		{
			timer_1.Stop();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIntro));
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.progressBar = new MetroFramework.Controls.MetroProgressBar();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.label7 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.panel3 = new System.Windows.Forms.Panel();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		this.label2 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.panel2 = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.label12 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel3.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.label1.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(61, 152);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(653, 21);
		this.label1.TabIndex = 1;
		this.label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(77, 12);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(620, 130);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox1.TabIndex = 5;
		this.pictureBox1.TabStop = false;
		this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.progressBar.Location = new System.Drawing.Point(38, 506);
		this.progressBar.Name = "progressBar";
		this.progressBar.Size = new System.Drawing.Size(723, 23);
		this.progressBar.Step = 50;
		this.progressBar.TabIndex = 7;
		this.timer_0.Interval = 30;
		this.timer_1.Enabled = true;
		this.timer_1.Tick += new System.EventHandler(timer_1_Tick);
		this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.DarkViolet;
		this.label7.Location = new System.Drawing.Point(611, 486);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(154, 16);
		this.label7.TabIndex = 9;
		this.label7.Text = "Đang kiểm tra thông tin...";
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.label10.Location = new System.Drawing.Point(235, 305);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(274, 25);
		this.label10.TabIndex = 18;
		this.label10.Text = "Liên hệ code tool theo yêu cầu:";
		this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.linkLabel4);
		this.panel3.Controls.Add(this.label2);
		this.panel3.Controls.Add(this.label8);
		this.panel3.Controls.Add(this.label9);
		this.panel3.Location = new System.Drawing.Point(266, 331);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(495, 65);
		this.panel3.TabIndex = 16;
		this.linkLabel4.AutoSize = true;
		this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel4.Location = new System.Drawing.Point(94, 32);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Size = new System.Drawing.Size(180, 25);
		this.linkLabel4.TabIndex = 9;
		this.linkLabel4.TabStop = true;
		this.linkLabel4.Text = "http://bit.ly/MINSoft";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(3, 5);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(77, 25);
		this.label2.TabIndex = 2;
		this.label2.Text = "Hotline:";
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(3, 32);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(87, 25);
		this.label8.TabIndex = 2;
		this.label8.Text = "Fanpage:";
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.Color.Black;
		this.label9.Location = new System.Drawing.Point(94, 5);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(120, 25);
		this.label9.TabIndex = 2;
		this.label9.Text = "035.839.4040";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.label3.Location = new System.Drawing.Point(235, 181);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(228, 25);
		this.label3.TabIndex = 19;
		this.label3.Text = "Liên hệ hỗ trợ phần mềm:";
		this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.linkLabel1);
		this.panel2.Controls.Add(this.linkLabel2);
		this.panel2.Controls.Add(this.label4);
		this.panel2.Controls.Add(this.label5);
		this.panel2.Controls.Add(this.label6);
		this.panel2.Controls.Add(this.label11);
		this.panel2.Location = new System.Drawing.Point(266, 207);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(495, 95);
		this.panel2.TabIndex = 17;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel1.Location = new System.Drawing.Point(94, 6);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(207, 25);
		this.linkLabel1.TabIndex = 9;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "https://minsoftware.vn/";
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel2.Location = new System.Drawing.Point(94, 63);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(180, 25);
		this.linkLabel2.TabIndex = 9;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "http://bit.ly/MINSoft";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(3, 6);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(83, 25);
		this.label4.TabIndex = 2;
		this.label4.Text = "Website:";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(3, 36);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(77, 25);
		this.label5.TabIndex = 2;
		this.label5.Text = "Hotline:";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(3, 63);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(87, 25);
		this.label6.TabIndex = 2;
		this.label6.Text = "Fanpage:";
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.ForeColor = System.Drawing.Color.Black;
		this.label11.Location = new System.Drawing.Point(94, 36);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(372, 25);
		this.label11.TabIndex = 2;
		this.label11.Text = "0969.078.803 - 0966.260.829 - 0973.363.129";
		this.pictureBox2.Image = Class306.Bitmap_2;
		this.pictureBox2.Location = new System.Drawing.Point(9, 184);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(220, 238);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 15;
		this.pictureBox2.TabStop = false;
		this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.ForeColor = System.Drawing.Color.Red;
		this.label12.Location = new System.Drawing.Point(235, 399);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(526, 77);
		this.label12.TabIndex = 20;
		this.label12.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.WhiteSmoke;
		base.ClientSize = new System.Drawing.Size(801, 541);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.progressBar);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fIntro";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Kiểm tra thông tin";
		base.TopMost = true;
		base.Load += new System.EventHandler(fIntro_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
