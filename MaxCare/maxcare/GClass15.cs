using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class GClass15
{
	private GClass17 gclass17_0 = new GClass17("configGeneral");

	public static bool smethod_0(GClass12 gclass12_0)
	{
		if (gclass12_0.method_12().StartsWith("https://m.facebook.com/feature_limit_notice/") || gclass12_0.method_49(0.0, "[href*=\"facebook.com/help/177066345680802\"]", "[href*=\"facebook.com/help/contact/\"]", "#captcha_response") != 0 || gclass12_0.method_12().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
		{
			return true;
		}
		return false;
	}

	public static void smethod_1(GClass12 gclass12_0, List<string> list_0)
	{
		List<string> list = new List<string>();
		int num = gclass12_0.method_45("textarea");
		string text = "";
		for (int i = 0; i < num; i++)
		{
			if (list.Count == 0)
			{
				list = GClass14.smethod_25(list_0);
			}
			text = list[Class49.random_0.Next(0, list.Count)];
			text = GClass14.smethod_26(text, Class49.random_0);
			list.Remove(text);
			gclass12_0.method_54($"document.querySelectorAll('textarea')[{num}]");
			gclass12_0.method_39(1, 2);
			gclass12_0.method_32(4, "textarea", i, text, 0.1);
			gclass12_0.method_39(1, 2);
		}
	}

	public static void smethod_2(GClass12 gclass12_0, List<string> list_0)
	{
		List<string> list = new List<string>();
		string text = "[aria-label=\"Answer Questions\"][role=\"dialog\"] [data-visualcompletion=\"ignore-dynamic\"]";
		string text2 = "";
		int num = 0;
		int num2 = Convert.ToInt32(gclass12_0.method_20("return document.querySelectorAll('" + text + "').length").ToString());
		for (int i = 0; i < num2; i++)
		{
			if (gclass12_0.method_20("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"radio\"]')+''").ToString() != "null")
			{
				num = 1;
			}
			else if (gclass12_0.method_20("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('textarea')+''").ToString() != "null")
			{
				num = 2;
			}
			else if (gclass12_0.method_20("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"checkbox\"]')+''").ToString() != "null")
			{
				num = 3;
			}
			gclass12_0.method_55("document.querySelectorAll('" + text + "')[" + i + "]");
			gclass12_0.method_67(1.0);
			switch (num)
			{
			case 1:
				gclass12_0.method_20("document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"radio\"]').click()");
				gclass12_0.method_67(1.0);
				break;
			case 2:
				if (list.Count == 0)
				{
					list = GClass14.smethod_25(list_0);
				}
				text2 = list[Class49.random_0.Next(0, list.Count)];
				list.Remove(text2);
				gclass12_0.method_34(4, text ?? "", i, 4, "textarea", 0, text2);
				gclass12_0.method_67(1.0);
				break;
			case 3:
				gclass12_0.method_20("document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"checkbox\"]').click()");
				gclass12_0.method_67(1.0);
				break;
			}
		}
		if (gclass12_0.method_46("[name=\"agree-to-group-rules\"]") == 1)
		{
			if (gclass12_0.method_26(2, "agree-to-group-rules") == 0)
			{
				gclass12_0.method_20("document.querySelector('[name=\"agree-to-group-rules\"]').click()");
			}
			gclass12_0.method_67(1.0);
		}
	}

	public static bool smethod_3(GClass12 gclass12_0)
	{
		try
		{
			List<string> list = new List<string> { "#captcha_response", "[name=\"captcha_response\"]", "[name=\"verification_method\"]", "[name=\"password_new\"]", "[href=\"https://www.facebook.com/communitystandards/\"]" };
			return gclass12_0.method_49(0.0, list.ToArray()) > 0;
		}
		catch
		{
			return false;
		}
	}

	public static int smethod_4(GClass12 gclass12_0, string string_0, string string_1, string string_2 = "", string string_3 = "https://www.facebook.com")
	{
		new Random();
		int result = 0;
		try
		{
			int num = 0;
			num = smethod_26(gclass12_0.method_12());
			if (num != 0)
			{
				goto IL_003e;
			}
			if (gclass12_0.method_13(string_3) != -2)
			{
				num = smethod_26(gclass12_0.method_12());
				goto IL_003e;
			}
			result = -2;
			goto end_IL_0008;
			IL_003e:
			if (gclass12_0.method_46("[data-cookiebanner=\"accept_button\"]") == 1)
			{
				gclass12_0.method_26(4, "[data-cookiebanner=\"accept_button\"]");
				gclass12_0.method_67(1.0);
			}
			if (num == 1)
			{
				gclass12_0.method_14("https://www.facebook.com/login");
				if (gclass12_0.method_46("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass12_0.method_26(4, "[data-cookiebanner=\"accept_button\"]");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_31(1, "email", string_0, 0.1) == -2)
				{
					result = -2;
				}
				else
				{
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_31(1, "pass", string_1, 0.1) == -2)
					{
						result = -2;
					}
					else
					{
						gclass12_0.method_67(1.0);
						if (gclass12_0.method_26(1, "loginbutton") != -2)
						{
							gclass12_0.method_67(1.0);
							if (gclass12_0.method_46("#approvals_code", 5.0) == 1 && string_2 != "")
							{
								string text = GClass14.smethod_83(string_2.Replace(" ", "").Replace("\n", ""));
								if (text != "")
								{
									gclass12_0.method_31(1, "approvals_code", text, 0.1);
									gclass12_0.method_67(1.0);
									gclass12_0.method_26(1, "checkpointSubmitButton");
									gclass12_0.method_67(1.0);
								}
							}
							int num2 = 0;
							while (gclass12_0.method_46("#checkpointSubmitButton", 3.0) == 1)
							{
								if (gclass12_0.method_2())
								{
									if (!gclass12_0.method_12().Contains("m.facebook"))
									{
										gclass12_0.method_13(gclass12_0.method_12().Replace("www", "m").Replace("mbasic", "m"));
									}
									if (smethod_3(gclass12_0) || num2 == 7)
									{
										break;
									}
									gclass12_0.method_26(1, "checkpointSubmitButton");
									gclass12_0.method_67(1.0);
									num2++;
									continue;
								}
								result = -2;
								goto end_IL_0008;
							}
							goto IL_063c;
						}
						result = -2;
					}
				}
			}
			else
			{
				int num3 = gclass12_0.method_14("https://m.facebook.com/login");
				if (gclass12_0.method_46("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass12_0.method_26(4, "[data-cookiebanner=\"accept_button\"]");
					gclass12_0.method_67(1.0);
				}
				num3 = gclass12_0.method_46("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0);
				int num4 = num3;
				int num5 = num4;
				if (num5 != -2)
				{
					if (num5 != 1)
					{
						if (gclass12_0.method_31(1, "m_login_email", string_0, 0.1) == 1)
						{
							gclass12_0.method_38();
							string string_4 = ((gclass12_0.method_49(3.0, "#m_login_password", "[name=\"pass\"]") == 1) ? "#m_login_password" : "[name=\"pass\"]");
							gclass12_0.method_31(4, string_4, string_1, 0.1);
							gclass12_0.method_38();
							gclass12_0.method_26(2, "login");
							gclass12_0.method_38();
						}
						goto IL_04ef;
					}
					gclass12_0.method_38();
					if (gclass12_0.method_26(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
					{
						gclass12_0.method_38(2);
						switch (gclass12_0.method_49(10.0, "[name=\"pass\"]", "#approvals_code"))
						{
						case -2:
							result = -2;
							goto end_IL_0008;
						case 1:
							if (gclass12_0.method_31(2, "pass", string_1, 0.1) == 1)
							{
								gclass12_0.method_38();
								if (gclass12_0.method_26(4, gclass12_0.method_5("button", "data-sigil", "password_login_button")) == 1)
								{
									gclass12_0.method_67(1.0);
								}
							}
							break;
						}
						goto IL_04ef;
					}
					result = -2;
				}
				else
				{
					result = -2;
				}
			}
			goto end_IL_0008;
			IL_063c:
			gclass12_0.method_67(1.0);
			return smethod_34(gclass12_0);
			IL_04ef:
			switch (gclass12_0.method_49(5.0, "#approvals_code", "#identify_search_text_input"))
			{
			case -2:
				result = -2;
				goto end_IL_0008;
			case 1:
				if (string_2.Trim() != "")
				{
					string text2 = GClass14.smethod_83(string_2.Replace(" ", "").Replace("\n", ""));
					if (text2 != "")
					{
						gclass12_0.method_31(1, "approvals_code", text2, 0.1);
						gclass12_0.method_38(-1);
						gclass12_0.method_26(1, "checkpointSubmitButton-actual-button");
						gclass12_0.method_38();
					}
				}
				goto default;
			default:
			{
				int num6 = 0;
				while (gclass12_0.method_46("#checkpointSubmitButton-actual-button", 3.0) == 1 && gclass12_0.method_46("[name=\"password_new\"]") != 1)
				{
					if (gclass12_0.method_2())
					{
						if (smethod_37(gclass12_0) || num6 == 7)
						{
							break;
						}
						gclass12_0.method_26(1, "checkpointSubmitButton-actual-button");
						gclass12_0.method_38();
						num6++;
						continue;
					}
					result = -2;
					goto end_IL_0008;
				}
				break;
			}
			}
			goto IL_063c;
			end_IL_0008:;
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(gclass12_0, exception_, "Login Uid Pass Fail");
		}
		return result;
	}

	public static string smethod_5(GClass12 gclass12_0)
	{
		string text = gclass12_0.method_20("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();
		if (text == "")
		{
			text = gclass12_0.method_20("return document.title").ToString().Split('-', '|')[0].Trim();
		}
		return text;
	}

	public static string smethod_6(GClass12 gclass12_0)
	{
		return gclass12_0.method_20("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();
	}

	public static int smethod_7(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (!(gclass12_0.method_12() == "https://m.facebook.com/home.php") && !(gclass12_0.method_12() == "https://m.facebook.com"))
				{
					if (gclass12_0.method_46("#feed_jewel a") == 1)
					{
						gclass12_0.method_55("document.querySelector('#feed_jewel a')");
						gclass12_0.method_38();
					}
					if (gclass12_0.method_26(4, "#feed_jewel a") != 1)
					{
						gclass12_0.method_13("https://m.facebook.com/home.php");
					}
					gclass12_0.method_67(1.0);
					if (gclass12_0.method_46("#nux-nav-button", 2.0) == 1)
					{
						gclass12_0.method_28(1, "nux-nav-button");
						gclass12_0.method_67(2.0);
					}
				}
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_12() == "https://m.facebook.com/home.php" || gclass12_0.method_12() == "https://m.facebook.com/home.php?ref=wizard&_rdr" || gclass12_0.method_12() == "https://m.facebook.com")
				{
					return 1;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_8(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("#requests_jewel a") == 1)
				{
					gclass12_0.method_55("document.querySelector('#requests_jewel a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "#requests_jewel a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "#requests_jewel a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					if (gclass12_0.method_26(4, "[href=\"/friends/center/friends/?mff_nav=1\"]") == 1)
					{
						gclass12_0.method_38();
						return 1;
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/friends/center/friends/?mff_nav=1");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_9(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("#requests_jewel a") == 1)
				{
					gclass12_0.method_55("document.querySelector('#requests_jewel a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "#requests_jewel a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "#requests_jewel a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					if (gclass12_0.method_26(4, "[href=\"/friends/center/suggestions/?mff_nav=1&ref=bookmarks\"]") == 1)
					{
						gclass12_0.method_38();
						return 1;
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_10(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass12_0.method_55("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					string text = gclass12_0.method_5("a", "href", "/groups/");
					if (text != "")
					{
						gclass12_0.method_55("document.querySelector('" + text + "')");
						gclass12_0.method_38();
						if (gclass12_0.method_26(4, text) == 1)
						{
							gclass12_0.method_38(2);
							if (gclass12_0.method_26(4, "[href=\"/groups_browse/your_groups/\"]") == 1)
							{
								gclass12_0.method_38();
								return 1;
							}
						}
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/groups_browse/your_groups/");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_11(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass12_0.method_55("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					string text = gclass12_0.method_5("a", "href", "/watch/");
					if (text != "")
					{
						gclass12_0.method_55("document.querySelector('" + text + "')");
						gclass12_0.method_38();
						if (gclass12_0.method_26(4, text) == 1)
						{
							gclass12_0.method_38();
							return 1;
						}
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/watch/?ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_12(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass12_0.method_55("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					string text = gclass12_0.method_5("a", "href", "/settings/");
					if (text != "")
					{
						gclass12_0.method_55("document.querySelector('" + text + "')");
						gclass12_0.method_38();
						if (gclass12_0.method_26(4, text) == 1)
						{
							gclass12_0.method_38();
							return 1;
						}
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/settings/?entry_point=bookmark");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_13(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				smethod_12(gclass12_0);
				string text = gclass12_0.method_5("a", "href", "/privacy/touch/timeline_and_tagging/");
				if (text != "")
				{
					gclass12_0.method_55("document.querySelector('" + text + "')");
					gclass12_0.method_38();
					if (gclass12_0.method_26(4, text) == 1)
					{
						gclass12_0.method_38();
						return 1;
					}
				}
				return gclass12_0.method_13("https://m.facebook.com/privacy/touch/timeline_and_tagging/");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_14(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("#notifications_jewel a") == 1)
				{
					gclass12_0.method_55("document.querySelector('#notifications_jewel a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "#notifications_jewel a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					num = gclass12_0.method_26(4, "#notifications_jewel a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					return 1;
				}
				return gclass12_0.method_13("https://m.facebook.com/notifications.php?ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_15(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("#messages_jewel a") == 1)
				{
					gclass12_0.method_55("document.querySelector('#messages_jewel a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "#messages_jewel a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38(2);
					num = gclass12_0.method_26(4, "#messages_jewel a");
				}
				if (num == 1)
				{
					gclass12_0.method_38(1);
					return 1;
				}
				return gclass12_0.method_13("https://m.facebook.com/messages/?entrypoint=jewel&no_hist=1&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_16(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (smethod_15(gclass12_0) == 1 && gclass12_0.method_26(4, "[href=\"/messages/?folder=unread&refid=11&ref=bookmarks\"]") == 1)
				{
					gclass12_0.method_39(3, 5);
					return 1;
				}
				return gclass12_0.method_13("https://m.facebook.com/messages/?folder=unread&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_17(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (gclass12_0.method_46("#notifications_jewel a") == 1)
				{
					gclass12_0.method_55("document.querySelector('#search_jewel a')");
					gclass12_0.method_38();
				}
				int num = gclass12_0.method_26(4, "#search_jewel a");
				if (num != 1)
				{
					smethod_7(gclass12_0);
					gclass12_0.method_38();
					num = gclass12_0.method_26(4, "#search_jewel a");
					if (num != 1)
					{
						num = gclass12_0.method_26(1, "search_jewel_container_sigil");
					}
				}
				if (num == 1 && gclass12_0.method_46("#main-search-input") == 1)
				{
					gclass12_0.method_38(1);
					return 1;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_18(GClass12 gclass12_0, string string_0, int int_0 = 0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (smethod_17(gclass12_0) == 1)
				{
					bool flag = false;
					if (gclass12_0.method_46("#main-search-input") == 1)
					{
						string_0 = GClass14.smethod_26(string_0, Class49.random_0);
						switch (int_0)
						{
						case 0:
							gclass12_0.method_33(Class49.random_0, 1, "main-search-input", string_0, 0.1);
							break;
						case 1:
							gclass12_0.method_31(1, "main-search-input", string_0, 0.1);
							break;
						case 2:
							gclass12_0.method_29(1, "main-search-input", string_0);
							break;
						}
						gclass12_0.method_38();
						gclass12_0.method_52(1, "main-search-input");
						gclass12_0.method_38(2);
						string text = gclass12_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
						if (text != "")
						{
							if (gclass12_0.method_26(4, text) == 0)
							{
								if (gclass12_0.method_26(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									gclass12_0.method_38();
									text = gclass12_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
									if (text != "")
									{
										flag = true;
										gclass12_0.method_26(4, text);
										gclass12_0.method_38(2);
									}
								}
							}
							else
							{
								flag = true;
								gclass12_0.method_38(2);
							}
						}
					}
					if (!flag)
					{
						gclass12_0.method_13("https://m.facebook.com/search/groups/?q=" + string_0);
						gclass12_0.method_38(2);
						flag = true;
					}
					if (flag)
					{
						gclass12_0.method_38(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_19(GClass12 gclass12_0, string string_0, int int_0 = 0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				if (smethod_17(gclass12_0) == 1)
				{
					bool flag = false;
					if (gclass12_0.method_46("#main-search-input") == 1)
					{
						string_0 = GClass14.smethod_26(string_0, Class49.random_0);
						switch (int_0)
						{
						case 0:
							gclass12_0.method_33(Class49.random_0, 1, "main-search-input", string_0, 0.1);
							break;
						case 1:
							gclass12_0.method_31(1, "main-search-input", string_0, 0.1);
							break;
						case 2:
							gclass12_0.method_29(1, "main-search-input", string_0);
							break;
						}
						gclass12_0.method_38();
						gclass12_0.method_52(1, "main-search-input");
						gclass12_0.method_38(2);
						string text = gclass12_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
						if (text != "")
						{
							if (gclass12_0.method_26(4, text) == 0)
							{
								if (gclass12_0.method_26(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									gclass12_0.method_38();
									text = gclass12_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
									if (text != "")
									{
										flag = true;
										gclass12_0.method_26(4, text);
										gclass12_0.method_38(2);
									}
								}
							}
							else
							{
								flag = true;
								gclass12_0.method_38(2);
							}
						}
					}
					if (!flag)
					{
						gclass12_0.method_13("https://m.facebook.com/search/people/?q=" + string_0 + "&source=filter&isTrending=0");
						gclass12_0.method_38(2);
						flag = true;
					}
					if (flag)
					{
						gclass12_0.method_38(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_20(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_13("https://m.facebook.com/browse/birthdays/") != -2)
				{
					gclass12_0.method_39(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_21(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_13("https://m.facebook.com/pokes/") != -2)
				{
					gclass12_0.method_39(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_22(GClass12 gclass12_0, int int_0 = 3, int int_1 = 5)
	{
		try
		{
			if (gclass12_0.method_3())
			{
				return -2;
			}
			int num = Class49.random_0.Next(int_0, int_1 + 1);
			int num2 = Convert.ToInt32(gclass12_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
			if (gclass12_0.method_8(Class49.random_0.Next(gclass12_0.method_57().Y / 2, gclass12_0.method_57().Y)) == 1)
			{
				gclass12_0.method_39(1, 3);
				int num3 = Convert.ToInt32(gclass12_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				if (num2 != num3)
				{
					for (int i = 0; i < num - 1; i++)
					{
						num2 = Convert.ToInt32(gclass12_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
						if (gclass12_0.method_8(((Class49.random_0.Next(1, 1000) % 5 != 0) ? 1 : (-1)) * Class49.random_0.Next(gclass12_0.method_57().Y / 2, gclass12_0.method_57().Y)) != -2)
						{
							gclass12_0.method_39(1, 3);
							num3 = Convert.ToInt32(gclass12_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
							if (num2 == num3)
							{
								break;
							}
							gclass12_0.method_39(1, 2);
							continue;
						}
						return -2;
					}
				}
				return 1;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_23(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0 != null)
			{
				if (gclass12_0.method_3())
				{
					return -2;
				}
				switch (gclass12_0.method_46("[jsselect=\"suggestionsSummaryList\"]"))
				{
				default:
					if (smethod_36(gclass12_0))
					{
						return -1;
					}
					break;
				case 1:
					return -3;
				case -2:
					return -2;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static string smethod_24()
	{
		string text = "";
		try
		{
			GClass17 gClass = new GClass17("configGeneral");
			GClass12 gClass2 = new GClass12
			{
				Boolean_0 = true,
				String_5 = ""
			};
			if (gClass.method_2("typeBrowser") != 0)
			{
				gClass2.String_4 = gClass.method_0("txtLinkToOtherBrowser");
			}
			if (gClass2.method_0(bool_7: true))
			{
				text = gClass2.method_9();
				text = text.Replace("Headless", "");
				gClass2.method_58();
			}
			if (text == "")
			{
				text = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.102 Safari/537.36";
			}
		}
		catch
		{
			if (text == "")
			{
				text = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.102 Safari/537.36";
			}
		}
		return text;
	}

	public static string smethod_25(GClass12 gclass12_0, string string_0, string string_1 = "https://www.facebook.com")
	{
		try
		{
			if (gclass12_0.method_14(string_1) == -2)
			{
				return "-2";
			}
			if (gclass12_0.method_61(string_0) == -2)
			{
				return "-2";
			}
			if (gclass12_0.method_15() == -2)
			{
				return "-2";
			}
			return smethod_34(gclass12_0).ToString() ?? "";
		}
		catch
		{
		}
		return "0";
	}

	public static int smethod_26(string string_0)
	{
		int result = 0;
		if (string_0.StartsWith("https://www.facebook") || string_0.StartsWith("https://facebook") || string_0.StartsWith("https://web.facebook"))
		{
			result = 1;
		}
		else if (string_0.StartsWith("https://m.facebook") || string_0.StartsWith("https://d.facebook") || string_0.StartsWith("https://mobile.facebook"))
		{
			result = 2;
		}
		else if (string_0.StartsWith("https://mbasic.facebook"))
		{
			result = 3;
		}
		return result;
	}

	public static int smethod_27(GClass12 gclass12_0, string string_0)
	{
		if (!gclass12_0.method_2())
		{
			return -2;
		}
		int num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = smethod_26(gclass12_0.method_12());
			if (num != 0)
			{
				break;
			}
			gclass12_0.method_13(string_0);
			gclass12_0.method_67(1.0);
		}
		return num;
	}

	public static List<string> smethod_28(GClass12 gclass12_0)
	{
		List<string> result = new List<string>();
		try
		{
			result = gclass12_0.method_20("var arr=[]; document.querySelectorAll('a').forEach(e=>{arr.push(e.href)});var s=arr.join('|'); return s").ToString().Split('|')
				.ToList();
		}
		catch
		{
		}
		return result;
	}

	public static int smethod_29(GClass12 gclass12_0, int int_0)
	{
		bool flag = false;
		try
		{
			switch (int_0)
			{
			case 1:
				gclass12_0.method_13("https://www.facebook.com/login");
				break;
			case 2:
				gclass12_0.method_13("https://m.facebook.com/login");
				break;
			case 3:
				gclass12_0.method_13("https://mbasic.facebook.com/login");
				break;
			}
			flag = true;
			gclass12_0.method_67(1.0);
		}
		catch (Exception)
		{
		}
		return flag ? 1 : 0;
	}

	public static string smethod_30(GClass12 gclass12_0, string string_0, string string_1, string string_2 = "", string string_3 = "https://m.facebook.com", int int_0 = 0, bool bool_0 = false, int int_1 = 0, int int_2 = 120, bool bool_1 = false)
	{
		int num = 0;
		int num2 = 0;
		int tickCount = Environment.TickCount;
		try
		{
			int int_3 = smethod_27(gclass12_0, string_3);
			while (true)
			{
				IL_0d6d:
				if (gclass12_0.method_46("[name='email']") != 1 || gclass12_0.method_46("[name='pass']") != 1 || gclass12_0.method_46("[name='login']") != 1 || gclass12_0.method_46("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					if (gclass12_0.method_12().Contains("facebook.com/user_cookie_prompt"))
					{
						gclass12_0.method_13("https://m.facebook.com/");
					}
					gclass12_0.method_20("document.querySelector('[name=\"primary_consent_button\"]').click()");
					gclass12_0.method_20("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
					gclass12_0.method_20("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
					if (gclass12_0.method_46("[name=\"pass\"]") != 1)
					{
						gclass12_0.method_41(int_3);
						gclass12_0.method_20("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
						gclass12_0.method_20("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
					}
					if (gclass12_0.method_27(0.0, 4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") == 1 || gclass12_0.method_27(0.0, 4, "[action*=\"/login/device-based/\"] [type=\"submit\"]") == 1)
					{
						gclass12_0.method_67(1.0);
						num2 = gclass12_0.method_49(5.0, "[name=\"pass\"]", "#approvals_code");
						if (num2 == 1 && gclass12_0.method_35(int_0, 2, "pass", string_1, 0.1) == 1)
						{
							gclass12_0.method_67(1.0);
							gclass12_0.method_52(2, "pass");
						}
					}
					else if (smethod_26(gclass12_0.method_12()) == 2)
					{
						gclass12_0.method_27(0.0, 4, "[id=\"nux-nav-button\"]");
						if (!gclass12_0.method_12().StartsWith("https://m.facebook.com/home.php"))
						{
							gclass12_0.method_27(0.0, 4, "[data-sigil=\"touchable\"]");
						}
					}
				}
				if (gclass12_0.method_46("[name='email']") == 1 && gclass12_0.method_46("[name='pass']") == 1 && gclass12_0.method_46("[name='login']") == 1)
				{
					int num3 = 1;
					bool flag = false;
					int num4 = 1;
					int num5 = 1;
					while (true)
					{
						IL_02c6:
						num2 = gclass12_0.method_35(int_0, 2, "email", string_0, 0.1);
						while (true)
						{
							if (num2 != -2)
							{
								gclass12_0.method_67(1.0);
								num3++;
								if (!flag)
								{
									switch (num3)
									{
									default:
										flag = true;
										continue;
									case 2:
										num2 = gclass12_0.method_35(int_0, 2, "pass", string_1, 0.1);
										continue;
									case 3:
										num2 = gclass12_0.method_26(2, "login");
										gclass12_0.method_67(3.0);
										flag = true;
										continue;
									case 1:
										break;
									}
									goto IL_02c6;
								}
								goto IL_02eb;
							}
							num = -2;
							break;
						}
						break;
					}
					break;
				}
				goto IL_02eb;
				IL_02eb:
				int num6 = 0;
				int num7 = 0;
				while (Environment.TickCount - tickCount < int_2 * 1000)
				{
					switch (gclass12_0.method_49(0.0, "[name=\"login\"]", "[name=\"approvals_code\"]", "[name=\"verification_method\"]", "#checkpointSubmitButton", "#qf_skip_dialog_skip_link", "#nux-nav-button", "[name=\"n\"]", "[name=\"reset_action\"]", "#checkpointBottomBar", "[name=\"primary_consent_button\"]", "#identify_search_text_input"))
					{
					default:
					{
						string text3 = (string)gclass12_0.method_20("async function checkCookie(){try{let a=await fetch(\"https://www.facebook.com/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c");
						if (text3.StartsWith("0|"))
						{
							num = 2;
						}
						else if (smethod_47(gclass12_0))
						{
							num = 8;
						}
						else if (gclass12_0.method_12().Contains("facebook.com/checkpoint/1501092823525282/") || gclass12_0.method_12().Contains("checkpoint/828281030927956"))
						{
							num = 2;
						}
						else if (gclass12_0.method_12().Contains("facebook.com/user_cookie_prompt"))
						{
							gclass12_0.method_13("https://m.facebook.com/");
						}
						else
						{
							if (gclass12_0.method_12().Contains("facebook.com/nt/screen/?params=%7B%22token") || gclass12_0.method_49(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]") != 0 || smethod_50(gclass12_0.method_1(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
							{
								num = 2;
							}
							else if (smethod_49(gclass12_0))
							{
								num = 1;
							}
							if (smethod_26(gclass12_0.method_12()) == 2)
							{
								if (gclass12_0.method_12().StartsWith("https://m.facebook.com/zero/policy/optin"))
								{
									gclass12_0.method_67(1.0);
									gclass12_0.method_20("document.querySelector('a[data-sigil=\"touchable\"]').click()");
									gclass12_0.method_67(3.0);
									if (gclass12_0.method_46("button[data-sigil=\"touchable\"]", 10.0) == 1)
									{
										gclass12_0.method_67(1.0);
										gclass12_0.method_20("document.querySelector('button[data-sigil=\"touchable\"]').click()");
										gclass12_0.method_67(3.0);
									}
								}
								if (Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
								{
									for (int j = 0; j < 5; j++)
									{
										GClass14.smethod_58(2.0);
										if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
										{
											break;
										}
									}
									for (int k = 0; k < 5; k++)
									{
										GClass14.smethod_58(2.0);
										if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
										{
											break;
										}
									}
									if (gclass12_0.method_46("[href=\"/home.php\"]") == 1)
									{
										gclass12_0.method_26(4, "[href=\"/home.php\"]");
									}
								}
								if (gclass12_0.method_12().StartsWith("https://m.facebook.com/legal_consent"))
								{
									gclass12_0.method_20("document.querySelector('button').click()");
									gclass12_0.method_67(1.0);
									gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
									gclass12_0.method_67(1.0);
									gclass12_0.method_20("document.querySelector('button').click()");
									gclass12_0.method_67(1.0);
									gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
									gclass12_0.method_67(1.0);
								}
								if (gclass12_0.method_12().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
								{
									gclass12_0.method_26(4, "[data-sigil=\"touchable\"]");
									gclass12_0.method_67(1.0);
								}
								if (gclass12_0.method_46("button[value=\"OK\"]") == 1)
								{
									gclass12_0.method_26(4, "button[value=\"OK\"]");
									gclass12_0.method_67(1.0);
								}
								if (gclass12_0.method_46("[data-store-id=\"2\"]>span") == 1)
								{
									gclass12_0.method_26(4, "[data-store-id=\"2\"]>span");
									gclass12_0.method_67(1.0);
								}
								if (gclass12_0.method_46("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
								{
									gclass12_0.method_26(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
									gclass12_0.method_67(3.0);
								}
							}
							else if (gclass12_0.method_12().StartsWith("https://www.facebook.com/legal_consent"))
							{
								for (int l = 0; l < 5; l++)
								{
									if (gclass12_0.method_46("button") != 1)
									{
										break;
									}
									gclass12_0.method_20("document.querySelector('button').click()");
									gclass12_0.method_67(1.0);
								}
							}
						}
						goto IL_0cd4;
					}
					case 2:
						if (string_2 == "")
						{
							num = 3;
						}
						else if (num6 == 3)
						{
							num = 6;
						}
						else
						{
							if (bool_1)
							{
								gclass12_0.method_13(gclass12_0.method_12().Replace("www.face", "m.face"));
								for (int i = 0; i < 10; i++)
								{
									if (gclass12_0.method_46("[name=\"approvals_code\"]") == 1)
									{
										break;
									}
									gclass12_0.method_67(1.0);
								}
							}
							string text2 = GClass14.smethod_83(string_2.Replace(" ", "").Replace("\n", "").Trim(), int_1);
							if (text2 != "")
							{
								num6++;
								gclass12_0.method_29(2, "approvals_code", text2);
								gclass12_0.method_67(1.0);
								num2 = gclass12_0.method_49(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
								if (num2 == 1)
								{
									gclass12_0.method_26(4, "button#checkpointSubmitButton");
								}
								else
								{
									gclass12_0.method_26(4, "#checkpointSubmitButton [type=\"submit\"]");
								}
								gclass12_0.method_67(1.0);
							}
							else
							{
								num = 6;
							}
						}
						goto IL_0cd4;
					case 3:
						num = 2;
						goto IL_0cd4;
					case 4:
						gclass12_0.method_26(1, "checkpointSubmitButton");
						gclass12_0.method_67(1.0);
						goto IL_0cd4;
					case 5:
						if (gclass12_0.method_28(1, "qf_skip_dialog_skip_link") == 0)
						{
							gclass12_0.method_20("document.getElementById('qf_skip_dialog_skip_link').click()");
						}
						gclass12_0.method_67(2.0);
						goto IL_0cd4;
					case 6:
						gclass12_0.method_26(1, "nux-nav-button");
						gclass12_0.method_67(2.0);
						goto IL_0cd4;
					case 7:
						num = 5;
						goto IL_0cd4;
					case 1:
					case 8:
						if (num6 == 0 && num7 == 0)
						{
							string text = "";
							switch (smethod_26(gclass12_0.method_12()))
							{
							case 2:
								text = gclass12_0.method_20("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
								break;
							case 1:
								text = gclass12_0.method_20("var out='';var x=document.querySelector('#error_box');if(x!=null) out=x.innerText;return out;").ToString();
								text = ((text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Count() > 1) ? text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)[1] : text);
								break;
							}
							if (text != "")
							{
								return text;
							}
							if (gclass12_0.method_46("[href=\"/login/identify/\"]") == 1)
							{
								num = 4;
							}
							else if (gclass12_0.method_46("#account_recovery_initiate_view_label") == 1)
							{
								num = 5;
							}
							else if (!Convert.ToBoolean(gclass12_0.method_20("return (document.querySelector('[name=\"email\"]').value!='' && document.querySelector('[name=\"pass\"]').value!='')+''").ToString()))
							{
								if (gclass12_0.method_20("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
								{
									num = 4;
								}
								else if (gclass12_0.method_20("return document.querySelector('[name=\"pass\"]').value").ToString().Trim() == "")
								{
									num = 5;
								}
							}
						}
						else if (gclass12_0.method_20("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
						{
							num = 0;
							goto end_IL_0cdd;
						}
						goto IL_0cd4;
					case 9:
						if (num6 > 1)
						{
							num = 6;
						}
						else if (gclass12_0.method_49(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]") != 0 || smethod_50(gclass12_0.method_1(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395", "checkpoint/828281030927956" }))
						{
							num = 2;
						}
						else
						{
							num2 = gclass12_0.method_49(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
							if (num7 < 10)
							{
								if (gclass12_0.method_46("[value=\"dont_save\"]") == 1 && bool_0)
								{
									gclass12_0.method_26(4, "[value=\"dont_save\"]");
								}
								num7++;
								if (num2 == 1)
								{
									gclass12_0.method_26(4, "button#checkpointSubmitButton");
								}
								else
								{
									gclass12_0.method_26(4, "#checkpointSubmitButton [type=\"submit\"]");
								}
								gclass12_0.method_67(1.0);
							}
							else
							{
								num = 0;
							}
						}
						goto IL_0cd4;
					case 10:
					{
						int num8 = gclass12_0.method_45("[name=\"primary_consent_button\"]");
						gclass12_0.method_26(4, "[name=\"primary_consent_button\"]", num8 - 1);
						goto IL_0cd4;
					}
					case 11:
						break;
						IL_0cd4:
						if (num == 0)
						{
							continue;
						}
						goto end_IL_0cdd;
					}
					gclass12_0.method_13("https://www.facebook.com/login");
					gclass12_0.method_67(1.0);
					int_3 = 0;
					goto IL_0d6d;
					continue;
					end_IL_0cdd:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			GClass14.smethod_75(gclass12_0, exception_, "Error Login Uid Pass");
		}
		return num.ToString() ?? "";
	}

	public static string smethod_31(GClass12 gclass12_0)
	{
		string result = "";
		try
		{
			string input = smethod_39(gclass12_0, "https://m.facebook.com/help", "https://m.facebook.com");
			result = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_32(GClass12 gclass12_0, string string_0)
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
			string json = smethod_39(gclass12_0, "https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + string_0, "https://graph.facebook.com/");
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
		}
		catch
		{
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static string smethod_33(GClass12 gclass12_0, string string_0)
	{
		string result = "";
		try
		{
			result = smethod_61(gclass12_0, string_0);
		}
		catch
		{
		}
		return result;
	}

	public static int smethod_34(GClass12 gclass12_0, string string_0 = "https://m.facebook.com")
	{
		try
		{
			if (gclass12_0.method_3())
			{
				return -2;
			}
			if (smethod_26(gclass12_0.method_12()) != smethod_26(string_0))
			{
				gclass12_0.method_13(string_0);
			}
			string text = (string)gclass12_0.method_20("async function checkCookie(){try{let a=await fetch(\"/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c");
			if (text.Equals("0|1"))
			{
				return 2;
			}
			if (text.Equals("1|1"))
			{
				return 1;
			}
			string text2 = gclass12_0.method_12();
			if (text2.Contains("facebook.com/checkpoint/") || text2.Contains("facebook.com/nt/screen/?params=%7B%22token") || text2.Contains("facebook.com/x/checkpoint/"))
			{
				return 2;
			}
			if (gclass12_0.method_12().Contains("facebook.com/user_cookie_prompt"))
			{
				gclass12_0.method_13("https://m.facebook.com/");
			}
			switch (smethod_27(gclass12_0, string_0))
			{
			case 2:
			{
				for (int j = 0; j < 30; j++)
				{
					smethod_46(gclass12_0, bool_0: true);
					switch (gclass12_0.GEnum10_0)
					{
					case GEnum10.const_1:
						return -2;
					case GEnum10.const_2:
					case GEnum10.const_3:
						return 0;
					case GEnum10.const_4:
						return 2;
					case GEnum10.const_5:
						return 1;
					case GEnum10.const_6:
						return -3;
					case GEnum10.const_8:
						return 3;
					}
					if (gclass12_0.method_46("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
					{
						gclass12_0.method_20("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
						gclass12_0.method_67(3.0);
						if (gclass12_0.method_46("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
						{
							gclass12_0.method_20("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
							gclass12_0.method_67(3.0);
						}
					}
					if (!gclass12_0.method_12().StartsWith("https://m.facebook.com/privacy/consent_framework/prompt/"))
					{
						break;
					}
					gclass12_0.method_20("document.querySelector('button[name=\"primary_consent_button\"]').click()");
					gclass12_0.method_67(2.0);
					if (gclass12_0.method_12().StartsWith("https://m.facebook.com/zero/optin/write/"))
					{
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						gclass12_0.method_67(3.0);
					}
					if (gclass12_0.method_12().StartsWith("https://m.facebook.com/zero/policy/optin"))
					{
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelector('a[data-sigil=\"touchable\"]').click()");
						gclass12_0.method_67(3.0);
						if (gclass12_0.method_46("button[data-sigil=\"touchable\"]", 10.0) == 1)
						{
							gclass12_0.method_67(1.0);
							gclass12_0.method_20("document.querySelector('button[data-sigil=\"touchable\"]').click()");
							gclass12_0.method_67(3.0);
						}
					}
					if (Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
					{
						for (int k = 0; k < 5; k++)
						{
							GClass14.smethod_58(2.0);
							if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						for (int l = 0; l < 5; l++)
						{
							GClass14.smethod_58(2.0);
							if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						if (gclass12_0.method_46("[href=\"/home.php\"]") == 1)
						{
							gclass12_0.method_26(4, "[href=\"/home.php\"]");
						}
					}
					if (gclass12_0.method_12().StartsWith("https://m.facebook.com/legal_consent"))
					{
						gclass12_0.method_20("document.querySelector('button').click()");
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelector('button').click()");
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
						gclass12_0.method_67(1.0);
					}
					if (gclass12_0.method_12().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
					{
						gclass12_0.method_26(4, "[data-sigil=\"touchable\"]");
						gclass12_0.method_67(1.0);
					}
					if (gclass12_0.method_46("button[value=\"OK\"]") == 1)
					{
						gclass12_0.method_26(4, "button[value=\"OK\"]");
						gclass12_0.method_67(1.0);
					}
					if (gclass12_0.method_46("[data-store-id=\"2\"]>span") == 1)
					{
						gclass12_0.method_26(4, "[data-store-id=\"2\"]>span");
						gclass12_0.method_67(1.0);
					}
					if (gclass12_0.method_46("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
					{
						gclass12_0.method_26(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
						gclass12_0.method_67(3.0);
					}
					if (gclass12_0.method_46("#nux-nav-button") == 1)
					{
						bool flag = false;
						for (int m = 0; m < 5; m++)
						{
							if (flag)
							{
								break;
							}
							switch (gclass12_0.method_49(3.0, "#qf_skip_dialog_skip_link", "#nux-nav-button"))
							{
							default:
								flag = true;
								break;
							case 2:
								gclass12_0.method_26(1, "nux-nav-button");
								gclass12_0.method_67(2.0);
								break;
							case 1:
								gclass12_0.method_20("document.querySelector('#qf_skip_dialog_skip_link').click()");
								gclass12_0.method_67(1.0);
								break;
							}
						}
					}
					gclass12_0.method_27(0.0, 4, "[name=\"primary_consent_button\"]");
					gclass12_0.method_67(2.0);
					if (gclass12_0.method_46("#nux-nav-button") == 1)
					{
						gclass12_0.method_26(1, "nux-nav-button");
						if (gclass12_0.method_46("#qf_skip_dialog_skip_link", 10.0) == 1 && gclass12_0.method_28(1, "qf_skip_dialog_skip_link") == 0)
						{
							gclass12_0.method_20("document.getElementById('qf_skip_dialog_skip_link').click()");
						}
					}
				}
				break;
			}
			case 1:
			{
				if (!gclass12_0.method_12().StartsWith("https://www.facebook.com/legal_consent"))
				{
					break;
				}
				for (int i = 0; i < 5; i++)
				{
					if (gclass12_0.method_46("button") != 1)
					{
						break;
					}
					gclass12_0.method_20("document.querySelector('button').click()");
					gclass12_0.method_67(1.0);
				}
				break;
			}
			}
			smethod_46(gclass12_0, bool_0: true);
			switch (gclass12_0.GEnum10_0)
			{
			case GEnum10.const_1:
				return -2;
			case GEnum10.const_2:
			case GEnum10.const_3:
				return 0;
			case GEnum10.const_4:
				return 2;
			case GEnum10.const_5:
				return 1;
			case GEnum10.const_6:
				return -3;
			case GEnum10.const_7:
				break;
			case GEnum10.const_8:
				return 3;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_35(GClass12 gclass12_0, string string_0 = "https://m.facebook.com")
	{
		try
		{
			if (gclass12_0.method_3())
			{
				return -2;
			}
			if (gclass12_0.method_12().Contains("https://m.facebook.com/x/checkpoint/hacked_cleanup") || gclass12_0.method_46("#checkpointButtonGetStarted") == 1)
			{
				return 1;
			}
			if (smethod_26(gclass12_0.method_12()) == 0)
			{
				gclass12_0.method_13(string_0);
			}
			switch (smethod_27(gclass12_0, string_0))
			{
			case 2:
				if (gclass12_0.method_46("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
				{
					gclass12_0.method_20("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
					gclass12_0.method_67(3.0);
					if (gclass12_0.method_46("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
					{
						gclass12_0.method_20("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						gclass12_0.method_67(3.0);
					}
				}
				if (gclass12_0.method_12().StartsWith("https://m.facebook.com/zero/optin/write/"))
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_20("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
					gclass12_0.method_67(3.0);
				}
				if (gclass12_0.method_12().StartsWith("https://m.facebook.com/zero/policy/optin"))
				{
					gclass12_0.method_67(1.0);
					gclass12_0.method_20("document.querySelector('a[data-sigil=\"touchable\"]').click()");
					gclass12_0.method_67(3.0);
					if (gclass12_0.method_46("button[data-sigil=\"touchable\"]", 10.0) == 1)
					{
						gclass12_0.method_67(1.0);
						gclass12_0.method_20("document.querySelector('button[data-sigil=\"touchable\"]').click()");
						gclass12_0.method_67(3.0);
					}
				}
				if (Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
				{
					for (int j = 0; j < 5; j++)
					{
						GClass14.smethod_58(2.0);
						if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					for (int k = 0; k < 5; k++)
					{
						GClass14.smethod_58(2.0);
						if (!Convert.ToBoolean(gclass12_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					if (gclass12_0.method_46("[href=\"/home.php\"]") == 1)
					{
						gclass12_0.method_26(4, "[href=\"/home.php\"]");
					}
				}
				if (gclass12_0.method_12().StartsWith("https://m.facebook.com/legal_consent"))
				{
					gclass12_0.method_20("document.querySelector('button').click()");
					gclass12_0.method_67(1.0);
					gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
					gclass12_0.method_67(1.0);
					gclass12_0.method_20("document.querySelector('button').click()");
					gclass12_0.method_67(1.0);
					gclass12_0.method_20("document.querySelectorAll('button')[1].click()");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_12().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
				{
					gclass12_0.method_26(4, "[data-sigil=\"touchable\"]");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_46("button[value=\"OK\"]") == 1)
				{
					gclass12_0.method_26(4, "button[value=\"OK\"]");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_46("[data-store-id=\"2\"]>span") == 1)
				{
					gclass12_0.method_26(4, "[data-store-id=\"2\"]>span");
					gclass12_0.method_67(1.0);
				}
				if (gclass12_0.method_46("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
				{
					gclass12_0.method_26(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
					gclass12_0.method_67(3.0);
				}
				break;
			case 1:
			{
				if (!gclass12_0.method_12().StartsWith("https://www.facebook.com/legal_consent"))
				{
					break;
				}
				for (int i = 0; i < 5; i++)
				{
					if (gclass12_0.method_46("button") != 1)
					{
						break;
					}
					gclass12_0.method_20("document.querySelector('button').click()");
					gclass12_0.method_67(1.0);
				}
				break;
			}
			}
			smethod_46(gclass12_0, bool_0: true);
			switch (gclass12_0.GEnum10_0)
			{
			case GEnum10.const_1:
				return -2;
			case GEnum10.const_2:
			case GEnum10.const_3:
				return 0;
			case GEnum10.const_4:
				return 2;
			case GEnum10.const_5:
				return 1;
			case GEnum10.const_6:
				return -3;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static bool smethod_36(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0.method_49(0.0, "#checkpointSubmitButton", "#captcha_response", "[name=\"verification_method\"]", "#checkpointBottomBar", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
			if (gclass12_0.method_12().Contains("nt/screen/?params="))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_37(GClass12 gclass12_0)
	{
		try
		{
			if (gclass12_0.method_49(0.0, "[name=\"captcha_response\"]", "#captcha_response", "[name=\"password_new\"]", "[name=\"verification_method\"]", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_38(GClass12 gclass12_0, string string_0 = "")
	{
		string result = "";
		try
		{
			if (!gclass12_0.method_12().Contains("https://business.facebook.com/business_locations"))
			{
				gclass12_0.method_13("https://business.facebook.com/business_locations");
				gclass12_0.method_67(1.0);
			}
			for (int i = 0; i < 5; i++)
			{
				if (gclass12_0.method_46("#globalContainer [type=\"text\"]") == 1)
				{
					gclass12_0.method_44(4, "#globalContainer [type=\"text\"]");
					gclass12_0.method_67(1.0);
					gclass12_0.method_29(4, "#globalContainer [type=\"text\"]", GClass14.smethod_83(string_0));
					gclass12_0.method_67(1.0);
					gclass12_0.method_52(4, "#globalContainer [type=\"text\"]");
					gclass12_0.method_67(5.0);
				}
			}
			string input = gclass12_0.method_1();
			result = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("'", "").Replace("\"", "");
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_39(GClass12 gclass12_0, string string_0, string string_1)
	{
		try
		{
			if (string_1.Split('/').Length > 2)
			{
				string_1 = string_1.Replace("//", "__");
				string_1 = string_1.Split('/')[0];
				string_1 = string_1.Replace("__", "//");
			}
			if (!gclass12_0.method_12().StartsWith(string_1))
			{
				gclass12_0.method_13(string_1);
				gclass12_0.method_67(1.0);
				gclass12_0.method_20("document.querySelector('body').innerHTML='MIN SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			return (string)gclass12_0.method_20("async function RequestGet() { var output = ''; try { var response = await fetch('" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_40(GClass12 gclass12_0, string string_0, string string_1, string string_2, string string_3 = "application/x-www-form-urlencoded")
	{
		try
		{
			if (!gclass12_0.method_12().StartsWith(string_2))
			{
				gclass12_0.method_13(string_2);
				gclass12_0.method_67(1.0);
				gclass12_0.method_20("document.querySelector('body').innerHTML='MIN SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			gclass12_0.method_67(1.0);
			string_1 = string_1.Replace("\n", "\\n").Replace("\"", "\\\"");
			return (string)gclass12_0.method_20("async function RequestPost() { var output = ''; try { var response = await fetch('" + string_0 + "', { method: 'POST', body: '" + string_1 + "', headers: { 'Content-Type': '" + string_3 + "' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static List<string> smethod_41(GClass12 gclass12_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_31(gclass12_0);
			string json = smethod_40(gclass12_0, "https://m.facebook.com/buddylist.php", "data_fetch=true&send_full_data=true&fb_dtsg=" + text + "&jazoest=&lsd=r&__dyn=&__csr=&__req=a&__a=&__user=" + string_0, "https://m.facebook.com/").Replace("for (;;);", "");
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["payload"]!["buddylist"]!))
			{
				list.Add(item["id"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string smethod_42(GClass12 gclass12_0, string string_0)
	{
		string result = "";
		try
		{
			if (!gclass12_0.method_12().Contains("https://graph.facebook.com/"))
			{
				gclass12_0.method_13("https://graph.facebook.com/");
			}
			string json = (string)gclass12_0.method_20("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
			JObject jObject = JObject.Parse(json);
			return jObject["id"]!.ToString() + "|" + jObject["birthday"]!.ToString() + "|" + jObject["name"]!.ToString();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_43(GClass12 gclass12_0)
	{
		List<string> list = new List<string>();
		try
		{
			if (!gclass12_0.method_12().Contains("https://mbasic.facebook.com/"))
			{
				gclass12_0.method_13("https://mbasic.facebook.com/");
			}
			string input = (string)gclass12_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			int num = 1;
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
						text2 = WebUtility.HtmlDecode(text2);
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
				input = (string)gclass12_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				num++;
			}
			while (num < 5 && text != "");
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_44(GClass12 gclass12_0, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			if (!gclass12_0.method_12().Contains("https://mbasic.facebook.com/"))
			{
				gclass12_0.method_13("https://mbasic.facebook.com/");
			}
			string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
			string text = gclass12_0.method_20("return (document.cookie + ';').match(new RegExp('c_user=(.*?);'))[1]").ToString();
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			MatchCollection matchCollection = null;
			List<string> list2 = new List<string>();
			for (int i = 0; i < int_0; i++)
			{
				DateTime dateTime = DateTime.Now.AddMonths(2 - i);
				DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
				text2 = GClass14.smethod_4(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
				text3 = GClass14.smethod_4(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
				text4 = string.Format(format, text, text2, text3);
				list2.Add(text4);
			}
			for (int j = 0; j < list2.Count; j++)
			{
				text4 = list2[j];
				bool flag = false;
				do
				{
					flag = false;
					text5 = smethod_39(gclass12_0, text4, "https://mbasic.facebook.com/");
					text5 = WebUtility.HtmlDecode(text5);
					matchCollection = Regex.Matches(text5, "<span>(.*?)</h4>");
					for (int k = 0; k < matchCollection.Count; k++)
					{
						string value = matchCollection[k].Groups[1].Value;
						value = value.Substring(0, value.LastIndexOf('<'));
						MatchCollection matchCollection2 = Regex.Matches(value, "<(.*?)>");
						for (int l = 0; l < matchCollection2.Count; l++)
						{
							value = value.Replace(matchCollection2[l].Value, "");
						}
						if (value != "" && !list.Contains(value))
						{
							list.Add(value);
						}
					}
					if (Regex.IsMatch(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
					{
						text4 = "https://mbasic.facebook.com" + Regex.Match(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
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

	public static List<string> smethod_45(GClass12 gclass12_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_33(gclass12_0, string_0);
			if (!gclass12_0.method_12().Contains("https://graph.facebook.com/"))
			{
				gclass12_0.method_13("https://graph.facebook.com/");
			}
			string json = (string)gclass12_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=id,name&access_token=" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(json);
			if (jObject["data"].Count() > 0)
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					string text2 = jObject["data"]![i]!["id"]!.ToString();
					string text3 = jObject["data"]![i]!["name"]!.ToString();
					list.Add(text2 + "|" + text3);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal static void smethod_46(GClass12 gclass12_0, bool bool_0)
	{
		try
		{
			if (gclass12_0.method_3())
			{
				gclass12_0.GEnum10_0 = GEnum10.const_1;
				return;
			}
			if (smethod_49(gclass12_0))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_5;
				return;
			}
			string text = "";
			if (bool_0)
			{
				string input = gclass12_0.method_12();
				input = Regex.Match(input, "https://(.*?)facebook.com").Value + "/login";
				text = smethod_39(gclass12_0, input, input);
			}
			else
			{
				text = gclass12_0.method_1();
			}
			if (text == "-2")
			{
				gclass12_0.GEnum10_0 = GEnum10.const_1;
			}
			else if (Regex.IsMatch(text, "login_form") || text.Contains("/login/?next"))
			{
				if (gclass12_0.method_46("[href*=\"/login/?next\"]") == 1)
				{
					gclass12_0.method_26(4, "[href*=\"/login/?next\"]");
				}
				gclass12_0.GEnum10_0 = GEnum10.const_2;
			}
			else if (Regex.IsMatch(text, "login_profile_form") || Regex.IsMatch(text, "/login/device-based/validate-p"))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_3;
			}
			else if (Convert.ToBoolean(gclass12_0.method_20("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) || Regex.IsMatch(text, "href=\"https://m.facebook.com/login.php"))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_3;
			}
			else if (smethod_47(gclass12_0))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_8;
			}
			else if (smethod_48(gclass12_0))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_4;
			}
			else if (text.Contains("error-information-popup-content") || text.Contains("suggestionsSummaryList"))
			{
				gclass12_0.GEnum10_0 = GEnum10.const_6;
			}
		}
		catch
		{
		}
	}

	public static bool smethod_47(GClass12 gclass12_0, string string_0 = "", string string_1 = "")
	{
		if (string_0 == "")
		{
			string_0 = gclass12_0.method_12();
		}
		List<string> list_ = new List<string> { "facebook.com/confirmemail.php" };
		if (smethod_50(string_0, list_))
		{
			return true;
		}
		List<string> list = new List<string> { "[name=\"c\"]" };
		if (gclass12_0.method_49(0.0, list.ToArray()) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_48(GClass12 gclass12_0, string string_0 = "", string string_1 = "")
	{
		if (string_0 == "")
		{
			string_0 = gclass12_0.method_12();
		}
		List<string> list_ = new List<string> { "facebook.com/checkpoint/828281030927956", "facebook.com/checkpoint/1501092823525282", "facebook.com/nt/screen/?params=%7B%22token", "facebook.com/x/checkpoint/", "facebook.com/checkpoint/block" };
		if (smethod_50(string_0, list_))
		{
			return true;
		}
		if (string_1 == "")
		{
			string_1 = gclass12_0.method_1();
		}
		List<string> list_2 = new List<string>
		{
			"verification_method", "submit[Yes]", "send_code", "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395", "help/166863010078512", "help/117450615006715", "checkpoint/1501092823525282", "checkpoint/828281030927956",
			"name=\"code_1\""
		};
		if (smethod_50(string_1, list_2))
		{
			return true;
		}
		List<string> list = new List<string> { "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "[href=\"https://www.facebook.com/communitystandards/\"]", "[name=\"code_1\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]" };
		if (gclass12_0.method_49(0.0, list.ToArray()) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_49(GClass12 gclass12_0, string string_0 = "", string string_1 = "")
	{
		if (string_0 == "")
		{
			string_0 = gclass12_0.method_12();
		}
		List<string> list_ = new List<string> { "https://m.facebook.com/home.php" };
		if (smethod_50(string_0, list_))
		{
			return true;
		}
		if (string_1 == "")
		{
			string_1 = gclass12_0.method_1();
		}
		List<string> list_2 = new List<string> { "/friends/", "/logout.php?button_location=settings&amp;button_name=logout" };
		if (smethod_50(string_1, list_2))
		{
			return true;
		}
		List<string> list = new List<string> { "a[href*=\"/friends/\"]", "[action=\"/logout.php?button_location=settings&button_name=logout\"]" };
		if (gclass12_0.method_49(0.0, list.ToArray()) > 0)
		{
			return true;
		}
		string text = (string)gclass12_0.method_20("async function checkCookie(){try{let a=await fetch(\"https://www.facebook.com/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c");
		if (text.Equals("1|1"))
		{
			return true;
		}
		return false;
	}

	public static bool smethod_50(string string_0, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Regex.IsMatch(string_0, list_0[num]) || string_0.Contains(list_0[num]))
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

	public static List<string> smethod_51(GClass12 gclass12_0, string string_0, string string_1, string string_2, int int_0 = 20)
	{
		List<string> list = new List<string>();
		try
		{
			if (!gclass12_0.method_12().Contains("https://graph.facebook.com/"))
			{
				gclass12_0.method_13("https://graph.facebook.com/");
			}
			string text = (string)gclass12_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/" + string_0 + "/photos?fields=images&limit=" + int_0 + "&access_token=" + string_2 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(text);
			int num = 0;
			if (jObject != null && text.Contains("images"))
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					num = jObject["data"]![i]!["images"].ToList().Count - 1;
					list.Add(string_0 + "*" + string_1 + "*" + jObject["data"]![i]!["images"]![num]!["source"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["width"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["height"]);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_52(GClass12 gclass12_0, string string_0, bool bool_0 = false)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_31(gclass12_0);
			if (!gclass12_0.method_12().Contains("https://www.facebook.com/api/graphql"))
			{
				gclass12_0.method_13("https://www.facebook.com/api/graphql");
			}
			string json = (string)gclass12_0.method_20("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[string_0]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				if (bool_0)
				{
					try
					{
						string string_ = jObject[string_0]!["friends"]!["nodes"]![i]!["name"]!.ToString();
						if (GClass14.smethod_96(string_))
						{
							list.Add(jObject[string_0]!["friends"]!["nodes"]![i]!["id"]!.ToString());
						}
					}
					catch
					{
					}
				}
				else
				{
					list.Add(jObject[string_0]!["friends"]!["nodes"]![i]!["id"]!.ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool smethod_53(GClass12 gclass12_0)
	{
		bool result = true;
		string text = "";
		switch (gclass12_0.method_49(2.0, "[action*=\"https://m.facebook.com/a/friends/profile/add\"] [type=\"submit\"]", "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]", "[data-sigil=\"touchable m-error-overlay-done\"]", "[data-sigil=\"touchable m-overlay-layer\"]", "[data-sigil=\"touchable m-error-overlay-cancel\"]"))
		{
		case 1:
			text = "[action*=\"https://m.facebook.com/a/friends/profile/add\"] [type=\"submit\"]";
			break;
		case 2:
			text = "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]";
			break;
		case 3:
			text = "[data-sigil=\"touchable m-error-overlay-done\"]";
			break;
		case 4:
			text = "[data-sigil=\"touchable m-overlay-layer\"]";
			break;
		case 5:
			text = "[data-sigil=\"touchable m-error-overlay-cancel\"]";
			break;
		}
		if (text != "")
		{
			gclass12_0.method_20("document.querySelector('" + text + "').click();");
		}
		return result;
	}

	public static string smethod_54(GClass12 gclass12_0)
	{
		string text = "";
		try
		{
			for (int i = 0; i < 5; i++)
			{
				string string_ = gclass12_0.method_12();
				if (smethod_26(string_) != 2)
				{
					gclass12_0.method_13("https://m.facebook.com");
				}
				string_ = Regex.Match(gclass12_0.method_12(), "https://(.*?)facebook.com").Value;
				string input = smethod_39(gclass12_0, string_ + "/help/", string_);
				text = Regex.Match(input, GClass14.smethod_53("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
				if (text != "")
				{
					break;
				}
			}
		}
		catch
		{
			return "";
		}
		return text;
	}

	public static string smethod_55(GClass12 gclass12_0, int int_0 = 2)
	{
		try
		{
			string string_ = gclass12_0.method_12();
			if (smethod_26(string_) != int_0)
			{
				switch (int_0)
				{
				case 1:
					gclass12_0.method_13("https://www.facebook.com");
					break;
				case 2:
					gclass12_0.method_13("https://m.facebook.com");
					break;
				case 3:
					gclass12_0.method_13("https://mbasic.facebook.com");
					break;
				}
			}
			return Regex.Match(gclass12_0.method_12(), "https://(.*?)facebook.com").Value;
		}
		catch
		{
		}
		return "";
	}

	public static List<string> smethod_56(GClass12 gclass12_0, string string_0, int int_0 = 1)
	{
		List<string> list = new List<string>();
		string text = "";
		switch (int_0)
		{
		case 0:
			list = smethod_57(gclass12_0);
			break;
		case 1:
		{
			for (int j = 0; j < 3; j++)
			{
				text = smethod_61(gclass12_0, string_0);
				string value = Regex.Match(gclass12_0.method_62(), "c_user=(.*?);").Groups[1].Value;
				string json2 = smethod_40(gclass12_0, "https://graph.facebook.com/graphql", "q=nodes(" + value + "){groups{nodes{id,name,viewer_post_status,visibility,group_member_profiles{count}}}}&access_token=" + text, "https://graph.facebook.com");
				JObject jObject2 = JObject.Parse(json2);
				foreach (JToken item in (IEnumerable<JToken>)(jObject2[value]!["groups"]!["nodes"]!))
				{
					list.Add(item["id"]!.ToString() + "|" + item["name"]!.ToString().Replace("|", "") + "|" + item["group_member_profiles"]!["count"]!.ToString() + "|" + ((item["viewer_post_status"]!.ToString() == "CAN_POST_AFTER_APPROVAL") ? "True" : "False"));
				}
				if (list.Count > 0)
				{
					break;
				}
			}
			break;
		}
		case 2:
		{
			for (int i = 0; i < 3; i++)
			{
				text = smethod_33(gclass12_0, string_0);
				if (text != "")
				{
					break;
				}
			}
			string json = smethod_39(gclass12_0, "https://graph.facebook.com/me/groups?fields=id,name,administrator,member_count&limit=1000&access_token=" + text, "https://graph.facebook.com/");
			try
			{
				JObject jObject = JObject.Parse(json);
				foreach (JToken item2 in (IEnumerable<JToken>)(jObject["data"]!))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}", item2["id"], item2["name"]!.ToString().Replace("|", ""), item2["member_count"]));
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			break;
		}
		}
		return list;
	}

	public static List<string> smethod_57(GClass12 gclass12_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_54(gclass12_0);
			string value = Regex.Match(gclass12_0.method_62(), "c_user=(.*?);").Groups[1].Value;
			string string_ = gclass12_0.method_12();
			if (smethod_26(string_) != 1)
			{
				gclass12_0.method_13("https://www.facebook.com");
			}
			string_ = Regex.Match(gclass12_0.method_12(), "https://(.*?)facebook.com").Value;
			string string_2 = string_ + "/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + text + "&filter%5B0%5D=group&viewer=" + value + "&__user=" + value + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
			string json = smethod_39(gclass12_0, string_2, string_).Replace("for (;;);", "");
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["payload"]!["entries"]!))
			{
				try
				{
					list.Add(string.Format("{0}|{1}|{2}", item["uid"], item["text"], item["size"]));
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static List<string> smethod_58(GClass12 gclass12_0, string string_0)
	{
		List<string> result = new List<string>();
		try
		{
			string input = smethod_39(gclass12_0, "https://mbasic.facebook.com/pages/?viewallpywo=1", "https://mbasic.facebook.com/");
			List<string> list = new List<string>();
			MatchCollection matchCollection = Regex.Matches(input, "page_suggestion_(\\d+)\"");
			foreach (Match item in matchCollection)
			{
				list.Add(item.Groups[1].Value);
			}
			List<string> list2 = new List<string>();
			matchCollection = Regex.Matches(input, "id=(\\d+)&");
			foreach (Match item2 in matchCollection)
			{
				list2.Add(item2.Groups[1].Value);
			}
			result = list.Except(list2).ToList();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string smethod_59(GClass12 gclass12_0, int int_0)
	{
		string string_ = "";
		switch (int_0)
		{
		case 1:
			string_ = "https://www.facebook.com";
			break;
		case 2:
			string_ = "https://m.facebook.com";
			break;
		case 3:
			string_ = "https://mbasic.facebook.com";
			break;
		}
		string string_2 = gclass12_0.method_12();
		if (smethod_26(string_2) != int_0)
		{
			gclass12_0.method_13(string_);
		}
		return Regex.Match(gclass12_0.method_12(), "https://(.*?)facebook.com").Value;
	}

	public static Bitmap smethod_60(GClass12 gclass12_0, string string_0)
	{
		gclass12_0.method_55("document.querySelector('" + string_0 + "')");
		gclass12_0.method_67(1.0);
		string text = gclass12_0.method_20("var img=document.querySelector('" + string_0 + "').getBoundingClientRect(); return Math.floor(img.x)+'|'+Math.floor(img.y)+'|'+Math.ceil(img.width)+'|'+Math.ceil(img.height);").ToString();
		int num = Convert.ToInt32(text.Split('|')[0]) + 10;
		int num2 = Convert.ToInt32(text.Split('|')[1]) + 30;
		int width = Convert.ToInt32(text.Split('|')[2]);
		int height = Convert.ToInt32(text.Split('|')[3]);
		Bitmap image = gclass12_0.method_22();
		Bitmap bitmap = new Bitmap(width, height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(image, -num, -num2);
		return bitmap;
	}

	public static string smethod_61(GClass12 gclass12_0, string string_0)
	{
		string result = "";
		try
		{
			string text = smethod_31(gclass12_0);
			if (!gclass12_0.method_12().StartsWith("https://www.face"))
			{
				gclass12_0.method_13("https://www.facebook.com/");
			}
			gclass12_0.method_67(1.0);
			string value = Regex.Match(gclass12_0.method_20("return document.cookie").ToString(), "c_user=(.*?);").Groups[1].Value;
			string string_ = "fb_dtsg=" + text + "&app_id=124024574287414&redirect_uri=fbconnect%3A%2F%2Fsuccess&display=page&access_token=&from_post=1&return_format=access_token&domain=&sso_device=ios&_CONFIRM=1&_user=" + value;
			string input = smethod_40(gclass12_0, "https://www.facebook.com/v1.0/dialog/oauth/confirm", string_, gclass12_0.method_12());
			result = Regex.Match(input, "access_token=(.*?)&").Groups[1].Value;
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_62(GClass12 gclass12_0, string string_0, bool bool_0 = false)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_31(gclass12_0);
			if (!gclass12_0.method_12().Contains("https://www.facebook.com/api/graphql"))
			{
				gclass12_0.method_13("https://www.facebook.com/api/graphql");
			}
			string json = (string)gclass12_0.method_20("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[string_0]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				try
				{
					string text2 = jObject[string_0]!["friends"]!["nodes"]![i]!["name"]!.ToString();
					if (bool_0)
					{
						if (GClass14.smethod_96(text2))
						{
							list.Add(text2);
						}
					}
					else
					{
						list.Add(text2);
					}
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

	public static string smethod_63(GClass12 gclass12_0)
	{
		string result = "";
		try
		{
			GClass19 gClass = new GClass19("", "", "", 0);
			string text = gClass.method_2("https://graph.facebook.com/v2.6/device/login", "scope=email,read_custom_friendlists&access_token=437340816620806|04a36c2558cde98e185d7f4f701e4d94");
			if (text != null)
			{
				JObject jObject = JObject.Parse(text);
				string text2 = jObject["code"]!.ToString();
				string text3 = jObject["user_code"]!.ToString();
				string text4 = smethod_31(gclass12_0);
				text = smethod_40(gclass12_0, "https://m.facebook.com/device/redirect/", "fb_dtsg=" + text4 + "&jazoest=25333&qr=0&user_code=" + text3, "https://m.facebook.com");
				string value = Regex.Match(text, "encrypted_post_body\" value=\"(.*?)\"").Groups[1].Value;
				string value2 = Regex.Match(text, "logger_id\" value=\"(.*?)\"").Groups[1].Value;
				string string_ = "fb_dtsg=" + text4 + "&jazoest=25359&from_post=1&push_read=&push_link=&deduplicate=&link_customer_account=&read=&link_news_subscription=&write=&extended=&confirm=&reauthorize=&user_messenger_contact=&user_pay_preference=&seen_scopes=&response_type=code&auth_type=rerequest&auth_nonce=&calling_package_key=&default_audience=&dialog_type=gdp_v4&fbapp_pres=&ret=&return_format=code&domain=&scope=email%2Cread_custom_friendlists&sso_device=&logger_id=" + value2 + "&sheet_name=initial&fallback_redirect_uri=&sdk=&facebook_sdk_version=&sdk_version=&user_code=" + text3 + "&logged_out_behavior=&install_nonce=&l_nonce=&original_redirect_uri=&loyalty_program_id=&messenger_page_id=&page_id_account_linking=&reset_messenger_state=&aid=&deferred_redirect_uri=&code_redirect_uri=&extras=&tp=unspecified&fx_app=&is_promote_auth=&code_challenge=&code_challenge_method=&encrypted_post_body=" + value + "&cbt=&__CONFIRM__=Ti%E1%BA%BFp+t%E1%BB%A5c";
				text = smethod_40(gclass12_0, "https://m.facebook.com/v2.0/dialog/oauth/confirm/", string_, "https://m.facebook.com/");
				text = gClass.method_2("https://graph.facebook.com/v2.6/device/login_status?access_token=437340816620806|04a36c2558cde98e185d7f4f701e4d94&code=" + text2);
				result = JObject.Parse(text)["access_token"]!.ToString();
			}
		}
		catch
		{
		}
		return result;
	}
}
