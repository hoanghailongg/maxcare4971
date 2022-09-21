using System.Windows.Forms;

public class GClass38
{
	public static void smethod_0(object object_0, int int_0 = 1)
	{
		switch (int_0)
		{
		case 1:
			MessageBox.Show(object_0.ToString(), GClass29.smethod_0("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			break;
		case 2:
			MessageBox.Show(object_0.ToString(), GClass29.smethod_0("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			break;
		case 3:
			MessageBox.Show(object_0.ToString(), GClass29.smethod_0("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			break;
		case 4:
			MessageBox.Show(object_0.ToString(), GClass29.smethod_0("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			break;
		}
	}

	public static DialogResult smethod_1(string string_0)
	{
		return MessageBox.Show(string_0, GClass29.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	}
}
