using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using Newtonsoft.Json.Linq;

internal class Class318
{
	[Serializable]
	[CompilerGenerated]
	private sealed class E02C2402
	{
		public static readonly E02C2402 _003C_003E9 = new E02C2402();

		public static RemoteCertificateValidationCallback _003C_003E9__4_0;

		internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}
	}

	public static void smethod_0(string string_0, string string_1, string string_2 = "")
	{
		int num = 0;
		while (true)
		{
			try
			{
				if (string_2 == "")
				{
					string_2 = "outlook.office365.com";
					if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail.") || string_0.Contains("muarefbmail.com"))
					{
						string_2 = "outlook.office365.com";
					}
					else if (string_0.EndsWith("@yandex.com"))
					{
						string_2 = "imap.yandex.com";
					}
					else if (string_0.EndsWith("@gmail.com"))
					{
						string_2 = "imap.gmail.com";
					}
				}
				ImapClient imapClient = new ImapClient();
				imapClient.SslProtocols = SslProtocols.Tls12;
				imapClient.Connect(string_2, 993);
				imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
				imapClient.Authenticate(string_0, string_1);
				imapClient.Inbox.Open(FolderAccess.ReadWrite);
				IList<UniqueId> list = imapClient.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.FromContains("security@facebookmail.com")));
				foreach (UniqueId item in list)
				{
					imapClient.Inbox.AddFlags(item, MessageFlags.Seen, silent: true);
				}
				if (imapClient.IsConnected)
				{
					imapClient.Disconnect(quit: true);
				}
				break;
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
				{
					num++;
					if (num < 10)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	public static string smethod_1(int int_0, string string_0, string string_1, int int_1 = 10, string string_2 = "")
	{
		int num = 0;
		int num2 = 10;
		if (string_2 == "")
		{
			string_2 = "outlook.office365.com";
			if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail.") || string_0.Contains("muarefbmail.com"))
			{
				string_2 = "outlook.office365.com";
			}
			else if (string_0.EndsWith("@yandex.com"))
			{
				string_2 = "imap.yandex.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
		}
		while (true)
		{
			try
			{
				for (int i = 0; i < int_1; i++)
				{
					try
					{
						ImapClient imapClient = new ImapClient();
						imapClient.SslProtocols = SslProtocols.Tls12;
						if (!imapClient.IsConnected)
						{
							imapClient.Connect(string_2, 993);
						}
						if (!imapClient.IsAuthenticated)
						{
							imapClient.Authenticate(string_0, string_1);
						}
						imapClient.Inbox.Open(FolderAccess.ReadWrite);
						IList<UniqueId> list = imapClient.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.FromContains("security@facebookmail.com")));
						int num3 = list.Count - 1;
						while (num3 >= 0)
						{
							UniqueId uid = list[num3];
							imapClient.Inbox.AddFlags(uid, MessageFlags.Seen, silent: true);
							string text = imapClient.Inbox.GetMessage(uid).BodyParts.OfType<TextPart>().FirstOrDefault().Text;
							string text2 = "";
							switch (int_0)
							{
							case 0:
								text2 = Regex.Match(text, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
								break;
							case 1:
								text2 = Regex.Match(text, "\\d{8}").Value.Trim();
								break;
							case 2:
								text2 = Regex.Match(text, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\n").Value.Trim();
								if (text2 == "")
								{
									text2 = Regex.Match(text, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
								}
								break;
							case 3:
								text2 = Regex.Match(text, "confirmcontact.php\\?c=(.*?)&").Groups[1].Value;
								break;
							case 4:
								text2 = Regex.Match(text, "c=(.*?)&").Groups[1].Value;
								break;
							}
							if (!(text2 != ""))
							{
								num3--;
								continue;
							}
							if (imapClient.IsConnected)
							{
								imapClient.Disconnect(quit: true);
							}
							return text2;
						}
					}
					catch (Exception ex)
					{
						if (ex.ToString().ToString().Contains("failed"))
						{
							return "block";
						}
					}
					GClass14.smethod_58(1.0);
				}
			}
			catch (Exception ex2)
			{
				if (ex2.ToString().ToLower().Contains("blocked"))
				{
					return "block";
				}
				num++;
				if (num < num2)
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public static string smethod_2(string string_0, string string_1, int int_0 = 10, string string_2 = "")
	{
		int num = 0;
		int num2 = 10;
		if (string_2 == "")
		{
			string_2 = "outlook.office365.com";
			if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail.") || string_0.Contains("muarefbmail.com") || string_0.Contains("@gzipmail."))
			{
				string_2 = "outlook.office365.com";
			}
			else if (string_0.EndsWith("@yandex.com"))
			{
				string_2 = "imap.yandex.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
		}
		while (true)
		{
			try
			{
				for (int i = 0; i < int_0; i++)
				{
					try
					{
						ImapClient imapClient = new ImapClient();
						imapClient.SslProtocols = SslProtocols.Tls12;
						if (!imapClient.IsConnected)
						{
							imapClient.Connect(string_2, 993);
						}
						if (!imapClient.IsAuthenticated)
						{
							imapClient.Authenticate(string_0, string_1);
						}
						imapClient.Inbox.Open(FolderAccess.ReadWrite);
						IList<UniqueId> list = imapClient.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.FromContains("security@facebookmail.com")));
						int num3 = list.Count - 1;
						while (num3 >= 0)
						{
							UniqueId uid = list[num3];
							imapClient.Inbox.AddFlags(uid, MessageFlags.Seen, silent: true);
							string text = imapClient.Inbox.GetMessage(uid).BodyParts.OfType<TextPart>().FirstOrDefault().Text;
							string value = Regex.Match(text, "\\d{8}").Value;
							if (!(value != ""))
							{
								num3--;
								continue;
							}
							if (imapClient.IsConnected)
							{
								imapClient.Disconnect(quit: true);
							}
							return value;
						}
					}
					catch (Exception ex)
					{
						if (ex.ToString().ToString().Contains("failed"))
						{
							return "block";
						}
					}
					GClass14.smethod_58(1.0);
				}
			}
			catch (Exception ex2)
			{
				if (ex2.ToString().ToLower().Contains("blocked"))
				{
					return "block";
				}
				num++;
				if (num < num2)
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public static string smethod_3(string string_0, string string_1, int int_0 = 10, int int_1 = 0, string string_2 = "")
	{
		int num = 0;
		int num2 = 10;
		if (string_2 == "")
		{
			string_2 = "outlook.office365.com";
			if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail.") || string_0.Contains("muarefbmail.com"))
			{
				string_2 = "outlook.office365.com";
			}
			else if (string_0.EndsWith("@yandex.com"))
			{
				string_2 = "imap.yandex.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_2 = "imap.gmail.com";
			}
		}
		while (true)
		{
			try
			{
				for (int i = 0; i < int_0; i++)
				{
					try
					{
						ImapClient imapClient = new ImapClient();
						imapClient.SslProtocols = SslProtocols.Tls12;
						if (!imapClient.IsConnected)
						{
							imapClient.Connect(string_2, 993);
						}
						if (!imapClient.IsAuthenticated)
						{
							imapClient.Authenticate(string_0, string_1);
						}
						imapClient.Inbox.Open(FolderAccess.ReadWrite);
						IList<UniqueId> list = imapClient.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.FromContains("registration@facebookmail.com")));
						int num3 = list.Count - 1;
						while (num3 >= 0)
						{
							UniqueId uid = list[num3];
							imapClient.Inbox.AddFlags(uid, MessageFlags.Seen, silent: true);
							string text = imapClient.Inbox.GetMessage(uid).BodyParts.OfType<TextPart>().FirstOrDefault().Text;
							string text2 = "";
							text2 = ((int_1 != 0) ? Regex.Match(text, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\\n").Value : Regex.Match(text, "checkpoint/(.*?)\\n").Value);
							if (!(text2 != ""))
							{
								num3--;
								continue;
							}
							if (imapClient.IsConnected)
							{
								imapClient.Disconnect(quit: true);
							}
							return text2;
						}
					}
					catch (Exception ex)
					{
						if (ex.ToString().ToString().Contains("failed"))
						{
							return "block";
						}
					}
					GClass14.smethod_58(1.0);
				}
			}
			catch (Exception ex2)
			{
				if (ex2.ToString().ToLower().Contains("blocked"))
				{
					return "block";
				}
				num++;
				if (num < num2)
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public static string smethod_4(int int_0, string string_0, string string_1, string string_2, int int_1 = 15, string string_3 = "")
	{
		int num = 0;
		int num2 = 10;
		if (string_3 == "")
		{
			string_3 = "outlook.office365.com";
			if (string_0.Contains("@hotmail.") || string_0.Contains("@outlook.") || string_0.Contains("@rickystar.") || string_0.Contains("@nickpromail."))
			{
				string_3 = "outlook.office365.com";
			}
			else if (string_0.EndsWith("@yandex.com"))
			{
				string_3 = "imap.yandex.com";
			}
			else if (string_0.EndsWith("@gmail.com"))
			{
				string_3 = "imap.gmail.com";
			}
		}
		while (true)
		{
			try
			{
				for (int i = 0; i < int_1; i++)
				{
					ImapClient imapClient = new ImapClient();
					imapClient.CheckCertificateRevocation = false;
					imapClient.ServerCertificateValidationCallback = (object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true;
					imapClient.SslProtocols = SslProtocols.Ssl2 | SslProtocols.Ssl3 | SslProtocols.Tls11;
					if (!imapClient.IsConnected)
					{
						imapClient.Connect(string_3, 993, SecureSocketOptions.SslOnConnect);
					}
					if (!imapClient.IsAuthenticated)
					{
						imapClient.Authenticate(string_0, string_1);
					}
					try
					{
						IList<UniqueId> list = imapClient.Inbox.Search(SearchQuery.NotSeen.And(SearchQuery.FromContains("security@facebookmail.com")));
						foreach (UniqueId item in list)
						{
							try
							{
								string text = imapClient.Inbox.GetMessage(item).BodyParts.OfType<TextPart>().FirstOrDefault().Text;
								if (!text.Contains(string_2))
								{
									continue;
								}
								string text2 = "";
								switch (int_0)
								{
								case 1:
									text2 = Regex.Match(text, "\\d{8}").Value.Trim();
									break;
								case 0:
									text2 = Regex.Match(text, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
									break;
								}
								if (text2 != "")
								{
									imapClient.Inbox.AddFlags(item, MessageFlags.Deleted, silent: true);
									if (imapClient.IsConnected)
									{
										imapClient.Disconnect(quit: true);
									}
									return text2;
								}
							}
							catch (Exception)
							{
								break;
							}
						}
					}
					catch (Exception)
					{
					}
					GClass14.smethod_58(1.0);
				}
			}
			catch (Exception ex3)
			{
				if (ex3.ToString().ToLower().Contains("blocked") || ex3.ToString().ToString().Contains("failed"))
				{
					return "block";
				}
				num++;
				if (num < num2)
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public static string smethod_5(string string_0)
	{
		string text = "";
		try
		{
			int num = 0;
			while (num < 10)
			{
				GClass19 gClass = new GClass19("", "", "", 0);
				gClass.httpRequest_0.AddHeader("Authorization", string_0);
				string json = gClass.method_0("https://web2.temp-mail.org/messages");
				JObject jObject = JObject.Parse(json);
				int num2 = 0;
				while (true)
				{
					if (num2 < jObject["messages"].Count())
					{
						gClass.httpRequest_0.AddHeader("Authorization", string_0);
						json = gClass.method_0("https://web2.temp-mail.org/messages/" + jObject["messages"]![num2]!["_id"]!.ToString());
						text = Regex.Match(json, "https://www.facebook.com/checkpoint/(.*?)\"").Value.Replace("amp;", "").Replace("\"", "").Replace("\\", "")
							.Replace("www", "m");
						if (!(text != ""))
						{
							num2++;
							continue;
						}
						goto end_IL_0123;
					}
					Thread.Sleep(3000);
					num++;
					break;
				}
				continue;
				end_IL_0123:
				break;
			}
		}
		catch (Exception)
		{
		}
		return text;
	}
}
