using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

internal class Class32
{
	[CompilerGenerated]
	private sealed class Class33
	{
		public List<string> list_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public int int_0;
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		public int int_0;

		public Class33 class33_0;
	}

	[CompilerGenerated]
	private sealed class Class35
	{
		public int int_0;

		public Class34 class34_0;

		internal void method_0()
		{
			string text = class34_0.class33_0.list_0[int_0];
			bool flag = true;
			try
			{
				string text2 = text.Split('|')[0];
				GClass19 gClass = new GClass19(class34_0.class33_0.string_0, class34_0.class33_0.string_1, class34_0.class33_0.string_2, class34_0.class33_0.int_0);
				string text3 = gClass.method_0("https://mobile.facebook.com/groups/" + text2 + "/madminpanel");
				flag = text3.Contains("madminpanel/pending/");
			}
			catch
			{
			}
			class34_0.class33_0.list_0[int_0] = $"{text}|{flag}";
			Interlocked.Decrement(ref class34_0.int_0);
		}
	}

	public static List<string> smethod_0(string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			GClass19 gClass = new GClass19(string_0, "", "", 0);
			string value = Regex.Match(string_0, "c_user=(.*?);").Groups[1].Value;
			string input = gClass.method_0("https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed");
			string value2 = Regex.Match(input, "fb_dtsg\\\\\" value=\\\\\"(.*?)\\\\\" ").Groups[1].Value;
			string string_2 = "batch_name=MessengerGraphQLThreadlistFetcher&__user=" + value + "&fb_dtsg=" + value2 + "&av=" + string_1 + "&queries={\"o0\":{\"doc_id\":\"3566388080113165\",\"query_params\":{\"limit\":200,\"before\":null,\"tags\":[\"INBOX\"],\"isWorkUser\":false,\"includeDeliveryReceipts\":true,\"includeSeqID\":false,\"is_work_teamwork_not_putting_muted_in_unreads\":false}}}";
			input = gClass.method_2("https://www.facebook.com/api/graphqlbatch/", string_2);
			if (input.Contains("{\"successful_results\":1,\"error_results\":0,\"skipped_results\":0}"))
			{
				input = input.Replace("{\"successful_results\":1,\"error_results\":0,\"skipped_results\":0}", "");
				JObject jObject = JObject.Parse(input);
				int num = jObject["o0"]!["data"]!["viewer"]!["message_threads"]!["nodes"].Count();
				if (num > 0)
				{
					for (int i = 0; i < num; i++)
					{
						list.Add(jObject["o0"]!["data"]!["viewer"]!["message_threads"]!["nodes"]![i]!["all_participants"]!["edges"]![0]!["node"]!["messaging_actor"]!["id"]!.ToString() + "|" + jObject["o0"]!["data"]!["viewer"]!["message_threads"]!["nodes"]![i]!["all_participants"]!["edges"]![0]!["node"]!["messaging_actor"]!["name"]!.ToString());
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_1(int int_0 = 16)
	{
		Random random = new Random();
		string text = "abcdef1234567890";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			text2 += Convert.ToString(text[random.Next(0, text.Length)]);
		}
		return text2;
	}

	public static string smethod_2(string string_0, string string_1, string string_2, int int_0)
	{
		string result = "0|0";
		string value = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
		try
		{
			GClass19 gClass = new GClass19(string_0, "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/102.0.5005.63 Mobile/15E148 Safari/604.1", string_2, int_0);
			if (value != "")
			{
				string string_3 = gClass.method_0("https://m.facebook.com/home.php").ToString();
				List<string> list_ = new List<string> { "/friends/", "/logout.php?button_location=settings&amp;button_name=logout" };
				if (GClass15.smethod_50(string_3, list_))
				{
					return "1|1";
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_3(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
			GClass19 gClass = new GClass19(string_0, string_2, string_3, int_0);
			gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_1);
			string json = gClass.method_0("https://graph.facebook.com/?ids=" + value + "&fields=friends{id,name}");
			JObject jObject = JObject.Parse(json);
			JToken jToken = jObject[value]!["friends"];
			if (jToken["data"].Count() > 0)
			{
				for (int i = 0; i < jToken["data"].Count(); i++)
				{
					string item = jToken["data"]![i]!["id"]!.ToString();
					list.Add(item);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static List<string> smethod_4(string string_0, string string_1, string string_2, string string_3, string string_4, int int_0, int int_1 = 20, bool bool_0 = false)
	{
		List<string> list = new List<string>();
		try
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			string[] array = string_0.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				dictionary.Add(array[i], new List<string>());
			}
			try
			{
				GClass19 gClass = new GClass19(string_1, string_3, string_4, int_0);
				gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_2);
				string string_5 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=id,name,photos.limit(" + int_1 + "){images}";
				string text = gClass.method_0(string_5);
				JObject jObject = JObject.Parse(text);
				if (jObject != null && text.Contains("images"))
				{
					string[] array2 = string_0.Split(',');
					foreach (string text2 in array2)
					{
						string text3 = jObject[text2]!["name"]!.ToString();
						try
						{
							foreach (JToken item in (IEnumerable<JToken>)(jObject[text2]!["photos"]!["data"]!))
							{
								try
								{
									int num = item["images"].ToList().Count - 1;
									dictionary[text2].Add(text2 + "*" + text3 + "*" + item["images"]![num]!["source"]?.ToString() + "|" + item["images"]![num]!["width"]?.ToString() + "|" + item["images"]![num]!["height"]);
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
			if (bool_0)
			{
				try
				{
					GClass19 gClass2 = new GClass19(string_1, string_3, string_4, int_0);
					gClass2.httpRequest_0.AddHeader("Authorization", "OAuth " + string_2);
					string string_6 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=name,albums.limit(3){photos.limit(10){width,height,images}}";
					string text4 = gClass2.method_0(string_6);
					JObject jObject2 = JObject.Parse(text4);
					if (jObject2 != null && text4.Contains("images"))
					{
						string[] array3 = string_0.Split(',');
						foreach (string text5 in array3)
						{
							string text6 = jObject2[text5]!["name"]!.ToString();
							foreach (JToken item2 in (IEnumerable<JToken>)(jObject2[text5]!["albums"]!["data"]!))
							{
								try
								{
									foreach (JToken item3 in (IEnumerable<JToken>)(item2["photos"]!["data"]!))
									{
										try
										{
											int num2 = item3["images"].ToList().Count - 1;
											if (dictionary[text5].Count >= int_1)
											{
												goto end_IL_04a3;
											}
											dictionary[text5].Add(text5 + "*" + text6 + "*" + item3["images"]![num2]!["source"]?.ToString() + "|" + item3["images"]![num2]!["width"]?.ToString() + "|" + item3["images"]![num2]!["height"]);
											continue;
										}
										catch (Exception)
										{
											continue;
										}
									}
								}
								catch (Exception)
								{
								}
								continue;
								end_IL_04a3:
								break;
							}
						}
					}
				}
				catch
				{
				}
			}
			foreach (KeyValuePair<string, List<string>> item4 in dictionary)
			{
				if (item4.Value.Count > 0)
				{
					list.AddRange(item4.Value);
					list.Add("");
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_5(string string_0, string string_1, string string_2, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
			string value = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
			string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			MatchCollection matchCollection = null;
			List<string> list2 = new List<string>();
			for (int i = 0; i < 5; i++)
			{
				DateTime dateTime = DateTime.Now.AddMonths(2 - i);
				DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
				text = GClass14.smethod_4(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
				text2 = GClass14.smethod_4(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
				text3 = string.Format(format, value, text, text2);
				list2.Add(text3);
			}
			for (int j = 0; j < list2.Count; j++)
			{
				text3 = list2[j];
				bool flag = false;
				do
				{
					flag = false;
					text4 = gClass.method_0(text3);
					text4 = WebUtility.HtmlDecode(text4);
					matchCollection = Regex.Matches(text4, "<span>(.*?)</h4>");
					for (int k = 0; k < matchCollection.Count; k++)
					{
						string value2 = matchCollection[k].Groups[1].Value;
						value2 = value2.Substring(0, value2.LastIndexOf('<'));
						MatchCollection matchCollection2 = Regex.Matches(value2, "<(.*?)>");
						for (int l = 0; l < matchCollection2.Count; l++)
						{
							value2 = value2.Replace(matchCollection2[l].Value, "");
						}
						if (value2 != "" && !list.Contains(value2))
						{
							list.Add(value2);
						}
					}
					if (Regex.IsMatch(text4, "/" + value + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
					{
						text3 = "https://mbasic.facebook.com" + Regex.Match(text4, "/" + value + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
						flag = true;
					}
				}
				while (flag);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_6(string string_0, string string_1, string string_2, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
			int num = 1;
			string input = gClass.method_0("https://mbasic.facebook.com/messages/");
			string text = "";
			string text2 = "";
			do
			{
				MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					try
					{
						text2 = matchCollection[i].Groups[1].Value.Replace("\"", "");
						text2 = GClass14.smethod_59(text2);
						if (!list.Contains(text2))
						{
							list.Add(text2);
						}
					}
					catch
					{
					}
				}
				text = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
				input = gClass.method_0("https://mbasic.facebook.com" + text);
				num++;
			}
			while (num < 5 && text != "");
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_7(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		string result = "";
		try
		{
			GClass19 gClass = new GClass19(string_0, string_2, string_3, int_0);
			string json = gClass.method_0("https://graph.facebook.com/me?fields=id,name,birthday&access_token=" + string_1);
			JObject jObject = JObject.Parse(json);
			return jObject["id"]!.ToString() + "|" + jObject["birthday"]!.ToString() + "|" + jObject["name"]!.ToString();
		}
		catch
		{
			if (!smethod_17(string_0, string_1, string_2, string_3, int_0))
			{
				result = "-1";
			}
		}
		return result;
	}

	public static string smethod_8(string string_0, string string_1, string string_2, int int_0)
	{
		try
		{
			string input = new GClass19(string_0, string_1, string_2, int_0).method_0("https://m.facebook.com/help/");
			return Regex.Match(input, GClass14.smethod_53("ZHRzZyI6eyJ0b2tlbiI6IiguKj8pIg==")).Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}

	public static int smethod_9(string string_0, string string_1)
	{
		int num = 0;
		try
		{
			GClass19 gClass = new GClass19("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36", "", 0);
			string text = gClass.method_0("https://graph.facebook.com/" + string_0 + "/picture?width=73&redirect=false&access_token=" + string_1);
			if (text.Contains(".gif") || text.Contains("143086968_2856368904622192_1959732218791162458") || text.Contains("84628273_176159830277856_972693363922829312_n"))
			{
				return 0;
			}
			return 1;
		}
		catch
		{
			return 2;
		}
	}

	private static Bitmap smethod_10(string string_0)
	{
		GClass19 gClass = new GClass19("", "", "", 0);
		string string_ = "https://graph.facebook.com/" + string_0 + "/picture?height=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662";
		byte[] array = gClass.method_1(string_);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, Convert.ToInt32(array.Length));
		Bitmap result = new Bitmap(memoryStream, useIcm: false);
		memoryStream.Dispose();
		return result;
	}

	public static bool smethod_11(string string_0, string string_1)
	{
		try
		{
			string address = "https://graph.facebook.com/" + string_0 + "/picture?width=9999&access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662";
			using (WebClient webClient = new WebClient())
			{
				byte[] buffer = webClient.DownloadData(address);
				using MemoryStream stream = new MemoryStream(buffer);
				using Image image = Image.FromStream(stream);
				string text = string_1 + "\\" + string_0;
				try
				{
					image.Save(text + ".png", ImageFormat.Png);
				}
				catch
				{
					image.Save(text + ".jpg", ImageFormat.Jpeg);
				}
			}
			return true;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(null, exception_, "Error DownLoadImageByUid");
			return false;
		}
	}

	public static string smethod_12()
	{
		string text = "";
		try
		{
			string address = "https://thispersondoesnotexist.com/image";
			using WebClient webClient = new WebClient();
			byte[] buffer = webClient.DownloadData(address);
			using MemoryStream stream = new MemoryStream(buffer);
			using Image image = Image.FromStream(stream);
			text = Application.StartupPath + "\\photos\\" + Guid.NewGuid().ToString();
			try
			{
				image.Save(text + ".png", ImageFormat.Png);
			}
			catch
			{
				image.Save(text + ".jpg", ImageFormat.Jpeg);
			}
		}
		catch (Exception)
		{
		}
		return text + ".png";
	}

	private static List<bool> smethod_13(Bitmap bitmap_0)
	{
		List<bool> list = new List<bool>();
		Bitmap bitmap = new Bitmap(bitmap_0, new Size(16, 16));
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
			}
		}
		return list;
	}

	public static string smethod_14(string string_0)
	{
		GClass19 gClass = new GClass19("datr=WZJvYiyKfkXCQUnre2uko636; fr=0oqi8uvi6J1Ke1hP4.AWWnEdQcAIbqvuADKlxidQffUOA.BiXNNR._x.AAA.0.0.Bi14Bb.AWWzPrNJL6o; sb=UNNcYqIKRmV0qebQb9n77CHo", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36", "", 0);
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = gClass.method_0("https://graph.facebook.com/" + string_0 + "/picture?type=normal&redirect=false");
					if (string.IsNullOrEmpty(text))
					{
						continue;
					}
					if (text.Contains("height") && text.Contains("width"))
					{
						return "1|";
					}
					try
					{
						text = gClass.method_0("https://graph.facebook.com/" + string_0 + "/picture?width=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662&redirect=false");
						if (text.Contains(".gif") || text.Contains("error"))
						{
							return "0|";
						}
						return "1|";
					}
					catch
					{
						text = gClass.method_2("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){name}");
						JObject jObject = JObject.Parse(text);
						if (string.IsNullOrEmpty(jObject[string_0]!.ToString()))
						{
							return "0|";
						}
						return "1|";
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch
		{
		}
		return "2|";
	}

	public static string smethod_15(string string_0)
	{
		GClass18 gClass = new GClass18("", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89");
		string text = "";
		try
		{
			string text2 = "";
			string text3 = "";
			string text4 = "";
			text = gClass.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){name}");
			JObject jObject = JObject.Parse(text);
			if (string.IsNullOrEmpty(jObject[string_0]!.ToString()))
			{
				return "0|";
			}
			text3 = jObject[string_0]!["name"]!.ToString();
			text = gClass.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){friends{count}}");
			jObject = JObject.Parse(text);
			if (string.IsNullOrEmpty(jObject[string_0]!.ToString()))
			{
				return "0|";
			}
			text2 = jObject[string_0]!["friends"]!["count"]!.ToString();
			text = gClass.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){created_time}");
			jObject = JObject.Parse(text);
			if (string.IsNullOrEmpty(jObject[string_0]!.ToString()))
			{
				return "0|";
			}
			text4 = smethod_16(Convert.ToDouble(jObject[string_0]!["created_time"]!.ToString())).ToString();
			return "1|" + text3 + "|" + text2 + "|" + text4;
		}
		catch (Exception)
		{
		}
		return "2|";
	}

	public static DateTime smethod_16(double double_0)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
	}

	public static bool smethod_17(string string_0, string string_1, string string_2, string string_3, int int_0 = 0)
	{
		bool result = false;
		try
		{
			GClass19 gClass = new GClass19(string_0, string_2, string_3, int_0);
			gClass.method_0("https://graph.facebook.com/me?access_token=" + string_1);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string smethod_18(string string_0, string string_1, string string_2, int int_0 = 0)
	{
		string text = "";
		try
		{
			GClass19 gClass = new GClass19(string_0, "", string_2, int_0);
			gClass.httpRequest_0.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			gClass.httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9");
			gClass.httpRequest_0.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			gClass.httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			gClass.httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			gClass.httpRequest_0.AddHeader("sec-fetch-dest", "document");
			gClass.httpRequest_0.AddHeader("sec-fetch-mode", "navigate");
			gClass.httpRequest_0.AddHeader("sec-fetch-site", "none");
			gClass.httpRequest_0.AddHeader("sec-fetch-user", "?1");
			gClass.httpRequest_0.AddHeader("upgrade-insecure-requests", "1");
			gClass.httpRequest_0.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			string input = gClass.method_0("https://www.facebook.com/adsmanager/manage/campaigns?act=");
			text = Regex.Match(input, "EAAB(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
		}
		catch
		{
			if (!smethod_2(string_0, string_1, string_2, int_0).StartsWith("1|"))
			{
				return "-1";
			}
		}
		if (text == "" && !smethod_2(string_0, string_1, string_2, int_0).StartsWith("1|"))
		{
			return "-1";
		}
		return text;
	}

	public static string smethod_19(string string_0, string string_1, string string_2, int int_0)
	{
		string text = "";
		try
		{
			GClass19 gClass = new GClass19(string_0, "", string_2, int_0);
			gClass.httpRequest_0.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			gClass.httpRequest_0.AddHeader("accept-encoding", "gzip, deflate, br");
			gClass.httpRequest_0.AddHeader("accept-language", "vi,en-US;q=0.9,en;q=0.8,ko;q=0.7,ru;q=0.6");
			gClass.httpRequest_0.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			gClass.httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			gClass.httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			gClass.httpRequest_0.AddHeader("sec-fetch-dest", "document");
			gClass.httpRequest_0.AddHeader("sec-fetch-mode", "navigate");
			gClass.httpRequest_0.AddHeader("sec-fetch-site", "none");
			gClass.httpRequest_0.AddHeader("sec-fetch-user", "?1");
			gClass.httpRequest_0.AddHeader("upgrade-insecure-requests", "1");
			gClass.httpRequest_0.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			string input = gClass.method_0("https://business.facebook.com/content_management");
			text = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
		}
		catch
		{
			if (!smethod_2(string_0, string_1, string_2, int_0).StartsWith("1|"))
			{
				return "-1";
			}
		}
		if (text == "" && !smethod_2(string_0, string_1, string_2, int_0).StartsWith("1|"))
		{
			return "-1";
		}
		return text;
	}

	public static string smethod_20(string string_0)
	{
		string result = "";
		int num = 0;
		uint num2 = Class321.smethod_0(string_0);
		if (num2 <= 1315429348)
		{
			if (num2 <= 822911587)
			{
				if (num2 != 334175660)
				{
					if (num2 != 401286136)
					{
						if (num2 == 822911587 && string_0 == "4")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "14")
					{
						result = ((num != 0) ? "device" : "Thiết bị");
						goto IL_02c6;
					}
				}
				else if (string_0 == "18")
				{
					result = ((num != 0) ? "comment" : "Bình luận");
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 923577301)
			{
				if (num2 != 906799682)
				{
					if (num2 != 923577301 || !(string_0 == "2"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Birthday" : "Ngày sinh");
				}
				else
				{
					if (!(string_0 == "3"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Image" : "Ảnh");
				}
			}
			else if (num2 != 1153637868)
			{
				if (num2 != 1315429348 || !(string_0 == "id_upload"))
				{
					goto IL_02a5;
				}
				result = "Up a\u0309nh";
			}
			else
			{
				if (!(string_0 == "72h"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "72 hours" : "72h");
			}
		}
		else
		{
			if (num2 <= 2347784130u)
			{
				if (num2 != 1718322808)
				{
					if (num2 != 2331006511u)
					{
						if (num2 == 2347784130u && string_0 == "34")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "37")
					{
						result = "Gư\u0309i OTP vê\u0300 mail";
						goto IL_02c6;
					}
				}
				else if (string_0 == "2fa")
				{
					result = "Co\u0301 2fa";
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 2364561749u)
			{
				if (num2 != 2347931225u)
				{
					if (num2 != 2364561749u || !(string_0 == "35"))
					{
						goto IL_02a5;
					}
					result = "Login Google";
				}
				else
				{
					if (!(string_0 == "26"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Friend" : "Nhơ\u0300 bạn bè");
				}
			}
			else if (num2 != 2381486463u)
			{
				if (num2 != 2517938561u || !(string_0 == "vhh"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "disable" : "Vô hiệu hóa");
			}
			else
			{
				if (!(string_0 == "20"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "Message" : "Tin nhắn");
			}
		}
		goto IL_02c6;
		IL_01c8:
		result = "Otp";
		goto IL_02c6;
		IL_02a5:
		File.AppendAllText("data\\dangcp.txt", string_0);
		goto IL_02c6;
		IL_02c6:
		return result;
	}

	public static string smethod_21(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		string text = "";
		try
		{
			string string_4 = "email=" + WebUtility.UrlEncode(string_0) + "&pass=" + WebUtility.UrlEncode(string_1);
			GClass19 gClass = new GClass19("", string_2, string_3, int_0);
			string text2 = gClass.method_2("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", string_4).ToString();
			if (text2.Contains("id=\"checkpointSubmitButton\""))
			{
				if (text2.Contains("id=\"approvals_code\""))
				{
					text = "5|";
				}
				else
				{
					text = "2|";
					gClass = new GClass19("", string_2, string_3, int_0);
					gClass.method_0("https://www.facebook.com").ToString();
					text2 = gClass.method_2("https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=100", string_4).ToString();
					string value = Regex.Match(text2, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
					string value3 = Regex.Match(text2, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
					string value4 = Regex.Match(text2, "\"__spin_r\":(.*?),").Groups[1].Value;
					string value5 = Regex.Match(text2, "\"__spin_t\":(.*?),").Groups[1].Value;
					string string_5 = "jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value3 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=7xe6Fo4OQ1PyUhxOnFwn84a2i5U4e1Fx-ewSwMxW0DUeUhw5cx60Vo1upE4W0OE2WxO0SobEa87i0n2US1vw4Ugao881FU3rw&__csr=&__req=5&__beoa=0&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value4 + "&__s=op5tkm%3A2d4a9m%3A37z92b&__hsi=6789153697588537525-0&__spin_r=" + value4 + "&__spin_b=trunk&__spin_t=" + value5;
					text2 = gClass.method_2("https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", string_5);
					text2 = gClass.method_0("https://www.facebook.com/checkpoint/?next");
					MatchCollection matchCollection = Regex.Matches(text2, "verification_method\" value=\"(.*?)\"");
					if (matchCollection.Count > 0)
					{
						for (int i = 0; i < matchCollection.Count; i++)
						{
							text = text + smethod_20(matchCollection[i].Groups[1].Value) + "-";
						}
						text = text.TrimEnd('-');
					}
					else if (text2.Contains("/checkpoint/dyi/?referrer=disabled_checkpoint"))
					{
						text += smethod_20("vhh");
					}
					else if (text2.Contains("captcha-recaptcha"))
					{
						text += smethod_20("72h");
					}
					else if (text2.Contains("name=\"submit[Log Out]\"") || text2.Contains("name=\"submit[__placeholder__]\""))
					{
						text += "không thê\u0309 xmdt";
					}
					else if (text2.Contains("name=\"submit[Continue]\""))
					{
						text += "Thiê\u0301t bi\u0323";
					}
				}
			}
			else if (text2.Contains("login_error"))
			{
				text = ((!text2.Contains("m_login_email")) ? "0|" : "3|");
			}
			else if (text2.Contains("action_set_contact_point"))
			{
				text = "2|" + smethod_20("34");
			}
			else
			{
				string text3 = gClass.method_4();
				text = ((!smethod_2(text3, string_2, string_3, int_0).StartsWith("1|")) ? "2|" : (text + "1|" + text3));
			}
		}
		catch
		{
			text = "0|";
		}
		return text;
	}

	public static string smethod_22(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		try
		{
			GClass19 gClass = new GClass19("", string_2, string_3, int_0);
			if (string_1 == "")
			{
				string_1 = "me";
			}
			string json = gClass.method_0("https://graph.facebook.com/v2.11/" + string_1 + "?fields=name,email,gender,birthday,friends.limit(0)&access_token=" + string_0);
			JObject jObject = JObject.Parse(json);
			flag = true;
			text2 = jObject["name"]!.ToString();
			try
			{
				text3 = jObject["gender"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text4 = jObject["birthday"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text6 = jObject["email"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text7 = jObject["friends"]!["summary"]!["total_count"]!.ToString();
			}
			catch
			{
			}
			if (text7 == "")
			{
				text7 = "0";
			}
			json = gClass.method_0("https://graph.facebook.com/v2.11/" + string_1 + "/groups?fields=id&limit=5000&access_token=" + string_0);
			jObject = JObject.Parse(json);
			try
			{
				text8 = jObject["data"].Count().ToString() ?? "";
			}
			catch
			{
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!smethod_17("", string_0, "", ""))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static string smethod_23(string string_0, string string_1, string string_2, int int_0)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		try
		{
			string value = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
			GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
			string string_3 = "https://business.facebook.com/business_locations/";
			string input = gClass.method_0(string_3);
			string value2 = Regex.Match(input, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
			text9 = Regex.Match(input, "EAAA(.*?)\"").Value.TrimEnd('"', '\\');
			text2 = JObject.Parse("{" + Regex.Match(input, "\"NAME\":\"(.*?)\"").Value + "}")["NAME"]!.ToString();
			text2 = WebUtility.HtmlDecode(text2);
			string text11 = GClass14.smethod_53("LS0tLS0tV2ViS2l0Rm9ybUJvdW5kYXJ5MnlnMEV6RHBTWk9DWGdCUgpDb250ZW50LURpc3Bvc2l0aW9uOiBmb3JtLWRhdGE7IG5hbWU9ImZiX2R0c2ciCgp7e2ZiX2R0c2d9fQotLS0tLS1XZWJLaXRGb3JtQm91bmRhcnkyeWcwRXpEcFNaT0NYZ0JSCkNvbnRlbnQtRGlzcG9zaXRpb246IGZvcm0tZGF0YTsgbmFtZT0icSIKCm5vZGUoe3t1aWR9fSl7ZnJpZW5kc3tjb3VudH0sc3Vic2NyaWJlcnN7Y291bnR9LGdyb3VwcyxjcmVhdGVkX3RpbWV9Ci0tLS0tLVdlYktpdEZvcm1Cb3VuZGFyeTJ5ZzBFekRwU1pPQ1hnQlItLQ==");
			text11 = text11.Replace("{{fb_dtsg}}", value2);
			text11 = text11.Replace("{{uid}}", value);
			input = gClass.method_2("https://www.facebook.com/api/graphql/", text11, "multipart/form-data; boundary=----WebKitFormBoundary2yg0EzDpSZOCXgBR");
			JObject jObject = JObject.Parse(input);
			text7 = jObject[value]!["friends"]!["count"]!.ToString();
			text8 = jObject[value]!["groups"]!["count"]!.ToString();
			text10 = jObject[value]!["created_time"]!.ToString();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!smethod_2(string_0, string_1, string_2, int_0).Contains("1|"))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	public static string smethod_24(string string_0, string string_1)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		try
		{
			string text11 = "c_user=" + Regex.Match(string_1 + ";", "c_user=(.*?);").Groups[1].Value + "; xs=xs=" + Regex.Match(string_1 + ";", "xs=(.*?);").Groups[1].Value + ";";
			GClass19 gClass = new GClass19(text11 + " useragent=TW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzc0LjAuMjMwMi42MSBTYWZhcmkvNTM3LjM2", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0", "", 0);
			string string_2 = "https://www.facebook.com/api/graphql";
			string string_3 = "q=user(" + string_0 + ")%7Bfriends%7Bcount%7D%2Cgroups%7Bcount%7D%2Cid%2Cname%2Cgender%2Cbirthday%2Cemail_addresses%2Cusername%7D";
			string json = gClass.method_2(string_2, string_3);
			JObject jObject = JObject.Parse(json);
			text7 = jObject[string_0]!["friends"]!["count"]!.ToString();
			text8 = jObject[string_0]!["groups"]!["count"]!.ToString();
			text2 = jObject[string_0]!["name"]!.ToString();
			text4 = ((jObject[string_0]!["birthday"] != null) ? jObject[string_0]!["birthday"]!.ToString() : "");
			text3 = jObject[string_0]!["gender"]!.ToString().ToLower();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
			flag = true;
		}
		catch
		{
			if (!smethod_2(string_1, "", "", 0).StartsWith("1|"))
			{
				return "-1";
			}
			flag = false;
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	public static List<string> smethod_25(string string_0, string string_1, string string_2, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
			string input = gClass.method_0("https://m.facebook.com/help/");
			string value = Regex.Match(input, GClass14.smethod_53("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
			string value2 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
			string string_3 = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + value + "&filter%5B0%5D=group&viewer=" + value2 + "&__user=" + value2 + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
			input = gClass.method_0(string_3).Replace("for (;;);", "");
			JObject jObject = JObject.Parse(input);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["payload"]!["entries"]!))
			{
				try
				{
					string text = item["uid"]!.ToString();
					string text2 = item["text"]!.ToString();
					string text3 = item["size"]!.ToString();
					list.Add(text + "|" + text2 + "|" + text3);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_26(List<string> list_0, string string_0, string string_1, string string_2, int int_0)
	{
		try
		{
			int int_2 = 0;
			int num = ((list_0.Count < 100) ? list_0.Count : 100);
			int num2 = 0;
			while (num2 < list_0.Count)
			{
				if (int_2 < num)
				{
					Interlocked.Increment(ref int_2);
					int int_ = num2++;
					new Thread((ThreadStart)delegate
					{
						string text = list_0[int_];
						bool flag = true;
						try
						{
							string text2 = text.Split('|')[0];
							GClass19 gClass = new GClass19(string_0, string_1, string_2, int_0);
							string text3 = gClass.method_0("https://mobile.facebook.com/groups/" + text2 + "/madminpanel");
							flag = text3.Contains("madminpanel/pending/");
						}
						catch
						{
						}
						list_0[int_] = $"{text}|{flag}";
						Interlocked.Decrement(ref int_2);
					}).Start();
				}
				else
				{
					Application.DoEvents();
					Thread.Sleep(200);
				}
			}
			while (int_2 > 0)
			{
				Application.DoEvents();
				Thread.Sleep(100);
			}
		}
		catch
		{
		}
		return list_0;
	}
}
