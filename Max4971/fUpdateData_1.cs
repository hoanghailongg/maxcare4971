using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;

public class fUpdateData_1 : Form
{
	private fMain fMain_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private MetroComboBox cbbTypeUpdate;

	private Label label1;

	private TextBox txbData;

	private Label label2;

	private Button btnCancel;

	private Button btnAdd;

	private PictureBox pictureBox1;

	private Label label3;

	private ComboBox cbbTypeProxy;

	public fUpdateData_1(fMain fMain_1, string string_0)
	{
		InitializeComponent();
		method_0();
		fMain_0 = fMain_1;
		cbbTypeUpdate.Text = string_0;
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void method_0()
	{
		GClass29.smethod_1(bunifuCustomLabel1);
		GClass29.smethod_1(label1);
		GClass29.smethod_1(label2);
		GClass29.smethod_1(label3);
		GClass29.smethod_1(btnAdd);
		GClass29.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (txbData.Text.Equals("") || txbData.Text.Equals("|"))
			{
				if (GClass38.smethod_1(string.Format(GClass29.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), fMain_0.method_199())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (GClass38.smethod_1(string.Format(GClass29.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), fMain_0.method_199())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < fMain_0.dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(fMain_0.method_212(i, "cId"));
				}
			}
			string text2 = cbbTypeUpdate.Text;
			string text3 = text2;
			switch (Class321.smethod_0(text3))
			{
			case 750979128u:
			{
				if (!(text3 == "Password") || !Class36.smethod_17(list, "pass", text))
				{
					break;
				}
				for (int num5 = 0; num5 < fMain_0.dtgvAcc.Rows.Count; num5++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						fMain_0.method_208(num5, "cPassword", text);
					}
				}
				break;
			}
			case 267393898u:
			{
				if (!(text3 == "Notes") || !Class36.smethod_17(list, "ghiChu", text))
				{
					break;
				}
				for (int k = 0; k < fMain_0.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[k].Cells["cChose"].Value))
					{
						fMain_0.method_208(k, "cGhiChu", text);
					}
				}
				break;
			}
			case 96026087u:
			{
				if (!(text3 == "Mail|pass"))
				{
					break;
				}
				if (text.Split('|').Length != 2)
				{
					GClass38.smethod_0(GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p la\u0323i đi\u0323nh da\u0323ng Mail|Pass Mail!"), 3);
					return;
				}
				if (!Class36.smethod_15(list, "email|passmail", text))
				{
					break;
				}
				for (int l = 0; l < fMain_0.dtgvAcc.Rows.Count; l++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[l].Cells["cChose"].Value))
					{
						fMain_0.method_208(l, "cEmail", text.Split('|')[0]);
						fMain_0.method_208(l, "cPassMail", text.Split('|')[1]);
					}
				}
				break;
			}
			case 1335761915u:
			{
				if (!(text3 == "Proxy"))
				{
					break;
				}
				int selectedIndex = cbbTypeProxy.SelectedIndex;
				string text4 = ((text == "") ? "" : (text + "*" + selectedIndex));
				if (!Class36.smethod_17(list, "proxy", text4))
				{
					break;
				}
				for (int num2 = 0; num2 < fMain_0.dtgvAcc.Rows.Count; num2++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						fMain_0.method_208(num2, "cProxy", text4);
					}
				}
				break;
			}
			case 1227920463u:
			{
				if (!(text3 == "Phone") || !Class36.smethod_15(list, "phone", text))
				{
					break;
				}
				for (int num3 = 0; num3 < fMain_0.dtgvAcc.Rows.Count; num3++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						fMain_0.method_208(num3, "cPhone", text.Split('|')[0]);
					}
				}
				break;
			}
			case 976575442u:
			{
				if (!(text3 == "Token") || !Class36.smethod_17(list, "token", text))
				{
					break;
				}
				for (int num7 = 0; num7 < fMain_0.dtgvAcc.Rows.Count; num7++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num7].Cells["cChose"].Value))
					{
						fMain_0.method_208(num7, "cToken", text);
					}
				}
				break;
			}
			case 2249983736u:
			{
				if (!(text3 == "2FA") || !Class36.smethod_17(list, "fa2", text))
				{
					break;
				}
				for (int m = 0; m < fMain_0.dtgvAcc.Rows.Count; m++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[m].Cells["cChose"].Value))
					{
						fMain_0.method_208(m, "cFa2", text);
					}
				}
				break;
			}
			case 1802569846u:
			{
				if (!(text3 == "Mail khôi phục") || !Class36.smethod_15(list, "mailrecovery", text))
				{
					break;
				}
				for (int num6 = 0; num6 < fMain_0.dtgvAcc.Rows.Count; num6++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						fMain_0.method_208(num6, "cMailRecovery", text.Split('|')[0]);
					}
				}
				break;
			}
			case 1669390511u:
			{
				if (!(text3 == "PassMail") || !Class36.smethod_15(list, "PassMail", text))
				{
					break;
				}
				for (int num = 0; num < fMain_0.dtgvAcc.Rows.Count; num++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						fMain_0.method_208(num, "cPassMail", text);
					}
				}
				break;
			}
			case 3243292492u:
			{
				if (!(text3 == "Birthday") || !Class36.smethod_17(list, "birthday", text))
				{
					break;
				}
				for (int num8 = 0; num8 < fMain_0.dtgvAcc.Rows.Count; num8++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num8].Cells["cChose"].Value))
					{
						fMain_0.method_208(num8, "cBirthday", text);
					}
				}
				break;
			}
			case 3183131359u:
			{
				if (!(text3 == "Cookie") || !Class36.smethod_17(list, "cookie1", text))
				{
					break;
				}
				for (int num4 = 0; num4 < fMain_0.dtgvAcc.Rows.Count; num4++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						fMain_0.method_208(num4, "cCookies", text);
					}
				}
				break;
			}
			case 4192210162u:
			{
				if (!(text3 == "Email|Mail khôi phục") || !Class36.smethod_15(list, "email|mailrecovery", text))
				{
					break;
				}
				for (int n = 0; n < fMain_0.dtgvAcc.Rows.Count; n++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[n].Cells["cChose"].Value))
					{
						fMain_0.method_208(n, "cEmail", text.Split('|')[0]);
						fMain_0.method_208(n, "cMailRecovery", text.Split('|')[1]);
					}
				}
				break;
			}
			case 3646757383u:
			{
				if (!(text3 == "Useragent") || !Class36.smethod_17(list, "useragent", text))
				{
					break;
				}
				for (int j = 0; j < fMain_0.dtgvAcc.Rows.Count; j++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						fMain_0.method_208(j, "cUseragent", text);
					}
				}
				break;
			}
			}
			Close();
		}
		catch
		{
			GClass38.smethod_0(GClass29.smethod_0("Vui lòng thử lại sau!"), 2);
		}
	}

	private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool visible = cbbTypeUpdate.Text == "Proxy";
		label3.Visible = visible;
		cbbTypeProxy.Visible = visible;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateData_1));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.cbbTypeUpdate = new MetroFramework.Controls.MetroComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.txbData = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(416, 38);
		this.bunifuCards1.TabIndex = 12;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(416, 32);
		this.pnlHeader.TabIndex = 9;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(382, -1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 79;
		this.pictureBox1.TabStop = false;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeUpdate.FontSize = MetroFramework.MetroComboBoxSize.Small;
		this.cbbTypeUpdate.FormattingEnabled = true;
		this.cbbTypeUpdate.ItemHeight = 19;
		this.cbbTypeUpdate.Items.AddRange(new object[13]
		{
			"Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes",
			"Email|Mail khôi phục", "Mail khôi phục", "Phone"
		});
		this.cbbTypeUpdate.Location = new System.Drawing.Point(146, 43);
		this.cbbTypeUpdate.Name = "cbbTypeUpdate";
		this.cbbTypeUpdate.Size = new System.Drawing.Size(238, 25);
		this.cbbTypeUpdate.TabIndex = 13;
		this.cbbTypeUpdate.UseSelectable = true;
		this.cbbTypeUpdate.SelectedIndexChanged += new System.EventHandler(cbbTypeUpdate_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(34, 51);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(105, 16);
		this.label1.TabIndex = 14;
		this.label1.Text = "Dữ liệu cập nhật:";
		this.txbData.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbData.Location = new System.Drawing.Point(146, 79);
		this.txbData.Name = "txbData";
		this.txbData.Size = new System.Drawing.Size(238, 23);
		this.txbData.TabIndex = 15;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(34, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(84, 16);
		this.label2.TabIndex = 16;
		this.label2.Text = "Nhập dữ liệu:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(209, 145);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 18;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(111, 145);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 17;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(34, 111);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(70, 16);
		this.label3.TabIndex = 16;
		this.label3.Text = "Loại proxy:";
		this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbTypeProxy.FormattingEnabled = true;
		this.cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		this.cbbTypeProxy.Location = new System.Drawing.Point(146, 108);
		this.cbbTypeProxy.Name = "cbbTypeProxy";
		this.cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
		this.cbbTypeProxy.TabIndex = 124;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(416, 188);
		base.Controls.Add(this.cbbTypeProxy);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.txbData);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.cbbTypeUpdate);
		base.Controls.Add(this.bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fUpdateData";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fUpdateData";
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
