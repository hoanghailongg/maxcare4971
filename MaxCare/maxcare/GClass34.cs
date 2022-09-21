using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

public class GClass34
{
	private class Class308
	{
		public struct Struct1
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;
		}

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr intptr_0, ref Struct1 struct1_0);
	}

	public static void smethod_0(Process process_0, string string_0)
	{
		Class308.Struct1 struct1_ = default(Class308.Struct1);
		Class308.GetWindowRect(process_0.MainWindowHandle, ref struct1_);
		int width = struct1_.int_2 - struct1_.int_0;
		int height = struct1_.int_3 - struct1_.int_1;
		Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.CopyFromScreen(struct1_.int_0, struct1_.int_1, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
		}
		bitmap.Save(string_0, ImageFormat.Png);
	}
}
