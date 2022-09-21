using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;

public class fShowProgressBar : Form
{
	[CompilerGenerated]
	private sealed class Class185
	{
		public int int_0;

		public int int_1;

		public fShowProgressBar fShowProgressBar_0;

		internal void method_0()
		{
			fShowProgressBar_0.lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class186
	{
		public double double_0;

		public Class185 class185_0;

		internal void method_0()
		{
			class185_0.fShowProgressBar_0.lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), class185_0.int_0, class185_0.int_1);
			class185_0.fShowProgressBar_0.progressBar1.Value = int.Parse(Math.Truncate(double_0).ToString());
		}
	}

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private MetroProgressBar progressBar1;

	public fShowProgressBar(List<string> list_1)
	{
		InitializeComponent();
		method_0();
		list_0 = list_1;
	}

	private void method_0()
	{
		GClass29.smethod_1(lblproccess);
	}

	private void fShowProgressBar_Load(object sender, EventArgs e)
	{
		try
		{
			new Thread((ThreadStart)delegate
			{
				string text = "";
				string text2 = "";
				int int_0 = 0;
				int int_1 = list_0.Count;
				BeginInvoke((MethodInvoker)delegate
				{
					lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
				});
				for (int i = 0; i < list_0.Count; i++)
				{
					text = list_0[i].Split('|')[0];
					text2 = list_0[i].Split('|')[1];
					if (GClass37.smethod_3(text, text2, bool_0: true))
					{
						int num = int_0;
						int_0 = num + 1;
					}
					double double_0 = (double)int_0 * 1.0 / (double)int_1 * 100.0;
					BeginInvoke((MethodInvoker)delegate
					{
						lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
						progressBar1.Value = int.Parse(Math.Truncate(double_0).ToString());
					});
				}
				BeginInvoke((MethodInvoker)delegate
				{
					Close();
				});
			}).Start();
		}
		catch (Exception ex)
		{
			GClass38.smethod_0("Error: " + ex.Message, 2);
			Close();
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
		this.lblproccess.Size = new System.Drawing.Size(189, 16);
		this.lblproccess.TabIndex = 1;
		this.lblproccess.Text = "Đang copy, vui lo\u0300ng chơ\u0300 (0/0)...";
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
		base.Name = "fShowProgressBar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "frm_progress";
		base.Load += new System.EventHandler(fShowProgressBar_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		string text = "";
		string text2 = "";
		int int_0 = 0;
		int int_1 = list_0.Count;
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
		});
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Split('|')[0];
			text2 = list_0[i].Split('|')[1];
			if (GClass37.smethod_3(text, text2, bool_0: true))
			{
				int num = int_0;
				int_0 = num + 1;
			}
			double double_0 = (double)int_0 * 1.0 / (double)int_1 * 100.0;
			BeginInvoke((MethodInvoker)delegate
			{
				lblproccess.Text = string.Format(GClass29.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
				progressBar1.Value = int.Parse(Math.Truncate(double_0).ToString());
			});
		}
		BeginInvoke((MethodInvoker)delegate
		{
			Close();
		});
	}

	[CompilerGenerated]
	private void method_2()
	{
		Close();
	}
}
