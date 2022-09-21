using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;

public class frm_progress : Form
{
	[CompilerGenerated]
	private sealed class Class205
	{
		public frm_progress frm_progress_0;

		public Uri uri_0;

		public string string_0;

		internal void method_0()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += frm_progress_0.method_4;
			webClient.DownloadFileCompleted += frm_progress_0.method_5;
			webClient.DownloadFileAsync(uri_0, string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class206
	{
		public DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;

		public frm_progress frm_progress_0;

		internal void method_0()
		{
			double num = double.Parse(downloadProgressChangedEventArgs_0.BytesReceived.ToString());
			double num2 = double.Parse(downloadProgressChangedEventArgs_0.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			frm_progress_0.lblproccess.Text = string.Format(GClass29.smethod_0("Đang tải xuô\u0301ng, vui lo\u0300ng chơ\u0300 ({0}%)..."), int.Parse(Math.Truncate(d).ToString()));
			frm_progress_0.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		}
	}

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private MetroProgressBar progressBar1;

	public frm_progress()
	{
		InitializeComponent();
		method_0();
	}

	private void method_0()
	{
		GClass29.smethod_1(lblproccess);
	}

	private void frm_progress_Load(object sender, EventArgs e)
	{
		try
		{
			if (File.Exists("./" + Class49.string_3 + "/" + Class49.string_3 + ".zip"))
			{
				File.Delete("./" + Class49.string_3 + "/" + Class49.string_3 + ".zip");
			}
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string text = Class49.string_4 + Class49.string_3;
			if (Class207.smethod_0())
			{
				Uri uri_ = new Uri(text + "/" + Class49.string_3 + ".zip");
				method_3(uri_, "./" + Class49.string_3 + "/" + Class49.string_3 + ".zip");
			}
			else
			{
				GClass38.smethod_0(GClass29.smethod_0("Không co\u0301 kê\u0301t nô\u0301i Internet, vui lo\u0300ng kiê\u0309m tra la\u0323i!"));
				Close();
			}
		}
		catch (Exception ex)
		{
			GClass38.smethod_0("Error: " + ex.Message, 2);
			Close();
		}
	}

	public void method_1(string string_0, string string_1)
	{
		DirectoryInfo directoryInfo_ = new DirectoryInfo(string_0);
		DirectoryInfo directoryInfo_2 = new DirectoryInfo(string_1);
		method_2(directoryInfo_, directoryInfo_2);
	}

	public void method_2(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
	{
		Directory.CreateDirectory(directoryInfo_1.FullName);
		int num = 1;
		FileInfo[] files = directoryInfo_0.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			Application.DoEvents();
			fileInfo.CopyTo(Path.Combine(directoryInfo_1.FullName, fileInfo.Name), overwrite: true);
			num++;
		}
		DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
			method_2(directoryInfo, directoryInfo_2);
		}
	}

	private void method_3(Uri uri_0, string string_0)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += method_4;
			webClient.DownloadFileCompleted += method_5;
			webClient.DownloadFileAsync(uri_0, string_0);
		});
		thread.Start();
	}

	private void method_4(object sender, DownloadProgressChangedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double num2 = double.Parse(e.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			lblproccess.Text = string.Format(GClass29.smethod_0("Đang tải xuô\u0301ng, vui lo\u0300ng chơ\u0300 ({0}%)..."), int.Parse(Math.Truncate(d).ToString()));
			progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		});
	}

	private void method_5(object sender, AsyncCompletedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = GClass29.smethod_0("Đang gia\u0309i ne\u0301n file...");
		});
		try
		{
			ZipFile.ExtractToDirectory("./" + Class49.string_3 + "/" + Class49.string_3 + ".zip", "./" + Class49.string_3 + "/");
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			GClass38.smethod_0("Error: " + ex.Message, 2);
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
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
		this.lblproccess = new System.Windows.Forms.Label();
		this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
		base.SuspendLayout();
		this.lblproccess.AutoSize = true;
		this.lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblproccess.Location = new System.Drawing.Point(34, 22);
		this.lblproccess.Name = "lblproccess";
		this.lblproccess.Size = new System.Drawing.Size(215, 16);
		this.lblproccess.TabIndex = 1;
		this.lblproccess.Text = "Đang tải xuô\u0301ng, vui lo\u0300ng chơ\u0300 (0%)...";
		this.progressBar1.Location = new System.Drawing.Point(37, 52);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new System.Drawing.Size(219, 23);
		this.progressBar1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(this.progressBar1);
		base.Controls.Add(this.lblproccess);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "frm_progress";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "frm_progress";
		base.Load += new System.EventHandler(frm_progress_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_6()
	{
		lblproccess.Text = GClass29.smethod_0("Đang gia\u0309i ne\u0301n file...");
	}

	[CompilerGenerated]
	private void method_7()
	{
		Close();
	}

	[CompilerGenerated]
	private void method_8()
	{
		Close();
	}
}
