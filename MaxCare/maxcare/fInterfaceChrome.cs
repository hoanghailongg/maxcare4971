using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fInterfaceChrome : Form
{
	[CompilerGenerated]
	private sealed class Class182
	{
		public IntPtr intptr_0;

		public fInterfaceChrome fInterfaceChrome_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		internal void method_0()
		{
			GClass33.SetParent(intptr_0, (from Control control_0 in fInterfaceChrome_0.panelListDevice.Controls
				where control_0.Tag.Equals(int_0)
				select control_0).FirstOrDefault().Handle);
			GClass33.MoveWindow(intptr_0, int_1, int_2, int_3, int_4, bool_0: true);
		}

		internal bool method_1(Control control_0)
		{
			return control_0.Tag.Equals(int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class183
	{
		public fInterfaceChrome fInterfaceChrome_0;

		public Control control_0;

		internal void method_0()
		{
			fInterfaceChrome_0.panelListDevice.Controls.Remove(control_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class184
	{
		public fInterfaceChrome fInterfaceChrome_0;

		public Panel panel_0;

		internal void method_0()
		{
			fInterfaceChrome_0.panelListDevice.Controls.Add(panel_0);
		}
	}

	public static fInterfaceChrome fInterfaceChrome_0;

	private IContainer icontainer_0 = null;

	private FlowLayoutPanel panelListDevice;

	public fInterfaceChrome()
	{
		InitializeComponent();
		method_0();
		fInterfaceChrome_0 = this;
	}

	private void method_0()
	{
		GClass29.smethod_1(this);
	}

	public void method_1(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3 = -10, int int_4 = -30)
	{
		Invoke((MethodInvoker)delegate
		{
			GClass33.SetParent(intptr_0, (from Control control_0 in panelListDevice.Controls
				where control_0.Tag.Equals(int_0)
				select control_0).FirstOrDefault().Handle);
			GClass33.MoveWindow(intptr_0, int_3, int_4, int_1, int_2, bool_0: true);
		});
	}

	public void method_2(int int_0)
	{
		Control control_0 = panelListDevice.Controls["dv" + int_0];
		panelListDevice.Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Remove(control_0);
		});
	}

	public void method_3(int int_0, int int_1, int int_2)
	{
		Panel panel_0 = new Panel();
		panel_0.Name = "dv" + int_0;
		panel_0.Tag = int_0;
		panel_0.Size = new Size(int_1, int_2);
		panel_0.BackColor = Color.White;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Add(panel_0);
		});
		for (int i = 0; i < 10; i++)
		{
			if (panelListDevice.Controls["dv" + int_0] != null)
			{
				break;
			}
			Thread.Sleep(1000);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		method_2(Convert.ToInt32((sender as PictureBox).Name.Replace("pic", "")));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInterfaceChrome));
		this.panelListDevice = new System.Windows.Forms.FlowLayoutPanel();
		base.SuspendLayout();
		this.panelListDevice.AutoScroll = true;
		this.panelListDevice.BackColor = System.Drawing.Color.White;
		this.panelListDevice.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelListDevice.Location = new System.Drawing.Point(0, 0);
		this.panelListDevice.Name = "panelListDevice";
		this.panelListDevice.Padding = new System.Windows.Forms.Padding(10);
		this.panelListDevice.Size = new System.Drawing.Size(933, 554);
		this.panelListDevice.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(933, 554);
		base.Controls.Add(this.panelListDevice);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fInterfaceChrome";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Giao diện Chrome";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.ResumeLayout(false);
	}
}
