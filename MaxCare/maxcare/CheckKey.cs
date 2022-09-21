using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace maxcare
{
	// Token: 0x020002CC RID: 716
	public class CheckKey : Form
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x0024BD24 File Offset: 0x00249F24
		private string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + cmd;
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

		// Token: 0x060017D4 RID: 6100 RVA: 0x00003744 File Offset: 0x00001944
		public CheckKey()
		{
			this.InitializeComponent();
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00003752 File Offset: 0x00001952
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0024BDA8 File Offset: 0x00249FA8
		private void button1_Click(object sender, EventArgs e)
		{
			string value = this.RunCMD("wmic diskdrive get serialNumber");
			using (StreamWriter streamWriter = new StreamWriter("HDD.txt", true))
			{
				streamWriter.WriteLine(value);
				streamWriter.Close();
			}
			string[] array = File.ReadAllLines("HDD.txt");
			File.Delete("HDD.txt");
			string str = Regex.Replace(array[2], "\\s", "");
			string value2 = this.RunCMD("wmic bios get serialnumber");
			using (StreamWriter streamWriter2 = new StreamWriter("bios.txt", true))
			{
				streamWriter2.WriteLine(value2);
				streamWriter2.Close();
			}
			string[] array2 = File.ReadAllLines("bios.txt");
			File.Delete("bios.txt");
			string text = Regex.Replace(array2[2], "\\s", "") + str;
			HttpClient httpClient = new HttpClient();
			string str2 = text;
			string requestUri = "https://docs.google.com/spreadsheets/d/164dQ1xsawv4Ffn7XwIbX7ohOpVBOb-SQx9tDas3PinI/edit?usp=sharing";
			Match match = Regex.Match(httpClient.GetAsync(requestUri).Result.Content.ReadAsStringAsync().Result.ToString().ToString(), str2 + ".*?(?=ok)");
			if (match == Match.Empty)
			{
				MessageBox.Show(string.Format("Bạn chưa mua bản quyền tool, vui lòng bấm Ctrl + C và gửi mã \"{0}\" để kích hoạt tool!", text), "Thông báo active bản quyền!", MessageBoxButtons.OK);
				this.textBox1.Text = text;
				return;
			}
			string[] array3 = match.ToString().Split(new char[]
			{
				'|'
			});
			DateTime now = DateTime.Now;
			int day = now.Day;
			int month = now.Month;
			int year = now.Year;
			string[] array4 = array3[1].ToString().Split(new char[]
			{
				'/'
			});
			int day2 = int.Parse(array4[0]);
			int month2 = int.Parse(array4[1]);
			int year2 = int.Parse(array4[2]);
			DateTime value3 = new DateTime(year, month, day);
			DateTime dateTime = new DateTime(year2, month2, day2);
			int num = (int)Math.Ceiling(dateTime.Subtract(value3).TotalDays);
			if (num <= 0)
			{
				MessageBox.Show("Vui lòng liên hệ admin để gia hạn.", "Phần mềm hết hạn" + num, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.label3.Text = array3[1].ToString();
				this.ngayconlai.Text = num.ToString() + " ngày";
				return;
			}
			MessageBox.Show("Đăng Nhập Thành Công .", "Còn lại: " + num + " ngày!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.label3.Text = array3[1].ToString();
			this.ngayconlai.Text = num.ToString() + " ngày";
			base.Hide();
			//new fMainz("LTD|LTD|2050/03/01 00:00:00 AM|MIN223B399297F9AD197CD2CBE0DBD92108").ShowDialog();
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0024C068 File Offset: 0x0024A268
		private void InitializeComponent()
		{
			string value = this.RunCMD("wmic diskdrive get serialNumber");
			using (StreamWriter streamWriter = new StreamWriter("HDD.txt", true))
			{
				streamWriter.WriteLine(value);
				streamWriter.Close();
			}
			string[] array = File.ReadAllLines("HDD.txt");
			File.Delete("HDD.txt");
			string str = Regex.Replace(array[2], "\\s", "");
			string value2 = this.RunCMD("wmic bios get serialnumber");
			using (StreamWriter streamWriter2 = new StreamWriter("bios.txt", true))
			{
				streamWriter2.WriteLine(value2);
				streamWriter2.Close();
			}
			string[] array2 = File.ReadAllLines("bios.txt");
			File.Delete("bios.txt");
			string text = Regex.Replace(array2[2], "\\s", "") + str;
			new HttpClient();
			this.label1 = new Label();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.ngayconlai = new Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(26, 27);
			this.label1.Margin = new Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(33, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Key";
			this.textBox1.Location = new Point(80, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(350, 25);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = text;
			this.button1.Location = new Point(80, 88);
			this.button1.Name = "button1";
			this.button1.Size = new Size(156, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "Kích Hoạt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(26, 170);
			this.label2.Margin = new Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(97, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ngày hết hạn:";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(138, 170);
			this.label3.Name = "label3";
			this.label3.Size = new Size(20, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "...";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(209, 170);
			this.label4.Margin = new Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new Size(57, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Còn lại:";
			this.ngayconlai.AutoSize = true;
			this.ngayconlai.Location = new Point(273, 170);
			this.ngayconlai.Name = "ngayconlai";
			this.ngayconlai.Size = new Size(20, 17);
			this.ngayconlai.TabIndex = 6;
			this.ngayconlai.Text = "...";
			base.AutoScaleDimensions = new SizeF(8f, 17f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(527, 205);
			base.Controls.Add(this.ngayconlai);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			this.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4);
			base.Name = "Form1";
			this.Text = "Active Bản Quyền MinSoftWare";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001F16 RID: 7958
		private IContainer components;

		// Token: 0x04001F17 RID: 7959
		private Label label1;

		// Token: 0x04001F18 RID: 7960
		private TextBox textBox1;

		// Token: 0x04001F19 RID: 7961
		private Button button1;

		// Token: 0x04001F1A RID: 7962
		private Label label2;

		// Token: 0x04001F1B RID: 7963
		private Label label3;

		// Token: 0x04001F1C RID: 7964
		private Label label4;

		// Token: 0x04001F1D RID: 7965
		private Label ngayconlai;
	}
}
