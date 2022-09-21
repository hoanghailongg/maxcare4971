using System;
using System.IO;
using System.IO.Compression;
using OpenQA.Selenium.Chrome;

public static class GClass13
{
	public static void smethod_0(this ChromeOptions chromeOptions_0)
	{
		string contents = "var id_tab;\nfunction send_cookie() {\n  chrome.cookies.getAll({ domain: \".facebook.com\" }, function (cookies) {\n    var cookie = \"\";\n    for (var i = 0; i < cookies.length; i++) {\n      if (!cookie.includes(cookies[i][\"name\"]))\n        cookie += cookies[i][\"name\"] + \"=\" + cookies[i][\"value\"] + \";\";\n    }\n    if (!cookie.includes(\"useragent\"))\n      cookie += \"useragent=\" + btoa(navigator.userAgent) + \";\";\n    if (!cookie.includes(\"_uafec\"))\n      cookie += \"_uafec=\" + encodeURIComponent(navigator.userAgent) + \";\";\n    // console.log(cookie);\n    chrome.tabs.sendMessage(id_tab, {\n      url: \"send_cookie\",\n      data: cookie,\n    });\n  });\n}\n\nchrome.runtime.onMessage.addListener(function (ms, sd, rp) {\n  if (ms.url == \"set_tab_id\") {\n    id_tab = sd.tab.id;\n    send_cookie();\n  }\n});";
		string contents2 = "chrome.runtime.sendMessage({\n  url: \"set_tab_id\",\n});\n\nchrome.runtime.onMessage.addListener(function (ms, sd, rp) {\n  if (ms.url == \"send_cookie\") {\n    localStorage[\"cookie_minsofware\"] = ms.data;\n    localStorage[\"getcookie\"] = \"false\";\n    trigger = true;\n  }\n});\n\nvar trigger = true;\nsetInterval(function () {\n  if ((localStorage[\"getcookie\"] = \"true\")) {\n    if (trigger) {\n      trigger = false;\n      chrome.runtime.sendMessage({\n        url: \"set_tab_id\",\n      });\n    }\n  }\n}, 1000);\n\nvar x = document.createElement(\"script\");\nx.textContent = `\n(async () => {\n  let x = await get_cookie()\n  console.log(x);\n})()\n\nfunction get_cookie() {\nreturn new Promise(function (resolve, reject) {\n  var x = \"\";\n  // console.log(localStorage.getItem('cc'));\n  localStorage[\"getcookie\"] = \"true\";\n\n  var clock_get_cookie = setInterval(function () {\n    if (localStorage[\"getcookie\"] == \"false\") {\n      clearInterval(clock_get_cookie);\n      x = localStorage[\"cookie_minsofware\"];\n      return resolve(x);\n    }\n  }, 100);\n});\n}\n`;\nx.onload = function () {\n  setTimeout(function () {\n    x.remove();\n  }, 100);\n};\ndocument.documentElement.appendChild(x);\n";
		if (!Directory.Exists("Plugins"))
		{
			Directory.CreateDirectory("Plugins");
		}
		string text = Guid.NewGuid().ToString();
		string text2 = "Plugins/manifest_" + text + ".json";
		string text3 = "Plugins/bg_" + text + ".js";
		string text4 = "Plugins/ct_" + text + ".js";
		string text5 = "Plugins/mincookie_" + text + ".zip";
		File.WriteAllText(text2, "{\n  \"manifest_version\": 2,\n  \"name\": \"Cookie\",\n  \"version\": \"1.0.0\",\n  \"permissions\": [\n    \"<all_urls>\",\n    \"tabs\",\n    \"cookies\",\n    \"https://*.facebook.com/\"\n  ],\n  \"background\": {\n    \"scripts\": [\"background.js\"]\n  },\n  \"content_scripts\": [\n    {\n      \"js\": [\"contents.js\"],\n      \"matches\": [\"<all_urls>\"],\n      \"run_at\": \"document_end\",\n      \"all_frames\": true\n    }\n  ]\n}");
		File.WriteAllText(text3, contents);
		File.WriteAllText(text4, contents2);
		using (ZipArchive destination = ZipFile.Open(text5, ZipArchiveMode.Create))
		{
			destination.CreateEntryFromFile(text2, "manifest.json");
			destination.CreateEntryFromFile(text3, "background.js");
			destination.CreateEntryFromFile(text4, "contents.js");
		}
		File.Delete(text2);
		File.Delete(text3);
		File.Delete(text4);
		chromeOptions_0.AddExtension(text5);
	}
}
