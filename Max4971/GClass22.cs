using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class GClass22
{
	public static List<string> smethod_0(List<string> list_0)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Trim();
			if (text != "")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static void smethod_1(string string_0)
	{
		Process process = new Process();
		process.StartInfo.FileName = "rasdial.exe";
		process.StartInfo.Arguments = "\"" + string_0 + "\" /disconnect";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
		Thread.Sleep(3000);
		process = new Process();
		process.StartInfo.FileName = "rasdial.exe";
		process.StartInfo.Arguments = "\"" + string_0 + "\"";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
		Thread.Sleep(1500);
	}

	public static string smethod_2(string string_0, string string_1)
	{
		if (!string_0.EndsWith(string_1))
		{
			return string_0;
		}
		return string_0.Remove(string_0.LastIndexOf(string_1));
	}

	public static void smethod_3(DataGridView dataGridView_0, string string_0)
	{
		List<string> list = new List<string>();
		string text = "";
		object obj = null;
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			text = "";
			for (int j = 0; j < dataGridView_0.ColumnCount; j++)
			{
				obj = dataGridView_0.Rows[i].Cells[j].Value;
				text += ((obj == null) ? "" : (obj?.ToString() + "|"));
			}
			text = text.TrimEnd('|');
			list.Add(text);
		}
		File.WriteAllLines(string_0, list);
	}

	public static void smethod_4(DataGridView dataGridView_0, string string_0)
	{
		List<string> list = File.ReadAllLines(string_0).ToList();
		string text = "";
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i];
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = text.Split('|');
				rows.Add(values);
			}
		}
	}

	public static string smethod_5()
	{
		string result = "";
		try
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				result = folderBrowserDialog.SelectedPath;
			}
		}
		catch
		{
		}
		return result;
	}

	public static void smethod_6(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	public static bool smethod_7(string string_0)
	{
		bool result = true;
		foreach (char c in string_0)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.' && c != '[' && c != ']')
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string smethod_8(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				text += c;
			}
		}
		return text;
	}

	public static string smethod_9(string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		string_0 = Encoding.UTF8.GetString(bytes);
		return string_0;
	}

	public static bool smethod_10(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char c = string_0[num];
				if (char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_11(string string_0)
	{
		string text = "zzz999.html";
		File.WriteAllText(text, string_0);
		Process.Start(text);
	}

	public static string smethod_12(string string_0)
	{
		try
		{
			return new GClass18().method_0(string_0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
			return "";
		}
	}

	public static bool smethod_13(string string_0)
	{
		try
		{
			new MailAddress(string_0);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string smethod_14(string string_0)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string smethod_15(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_16(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_17(int int_0, Random random_0 = null)
	{
		string text = "";
		if (random_0 == null)
		{
			random_0 = new Random();
		}
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 0; i < int_0; i++)
		{
			text += text2[random_0.Next(0, text2.Length)];
		}
		return text;
	}

	public static string smethod_18(int int_0, Random random_0 = null)
	{
		string text = "";
		if (random_0 == null)
		{
			random_0 = new Random();
		}
		string text2 = "0123456789";
		for (int i = 0; i < int_0; i++)
		{
			text += text2[random_0.Next(0, text2.Length)];
		}
		return text;
	}

	public static string smethod_19(string string_0)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string input = string_0.Normalize(NormalizationForm.FormD);
		return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
	}

	public static string smethod_20(string string_0)
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c " + string_0;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		if (string.IsNullOrEmpty(text))
		{
			return "";
		}
		return text;
	}

	public static void smethod_21(double double_0)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
	}

	public static void smethod_22(ChromeDriver chromeDriver_0, string string_0)
	{
		try
		{
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			string text2 = "";
			if (chromeDriver_0 != null)
			{
				text2 = chromeDriver_0.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
				Screenshot screenshot = ((ITakesScreenshot)chromeDriver_0).GetScreenshot();
				screenshot.SaveAsFile("log\\images\\" + text + ".png");
				File.WriteAllText("log\\html\\" + text + ".html", text2);
			}
			File.AppendAllText("log\\log.txt", DateTime.Now.ToString() + "|<" + text + ">|" + string_0 + Environment.NewLine);
		}
		catch
		{
		}
	}
}
