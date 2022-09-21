using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

[CompilerGenerated]
internal static class Class322
{
	private static object object_0 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static string string_0;

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	private static List<string> list_0 = new List<string>();

	private static List<string> list_1 = new List<string>();

	private static Dictionary<string, string> dictionary_3 = new Dictionary<string, string>();

	private static int int_0;

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return cultureInfo_0.Name;
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static Assembly smethod_2(string string_1, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		string path = ((IntPtr.Size == 8) ? "64" : "32");
		string path2 = Path.Combine(string_1, text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.Combine(Path.Combine(string_1, path), text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		return null;
	}

	private static void smethod_3(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static Stream smethod_4(string string_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_1.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(string_1))
			{
				using DeflateStream stream_ = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_3(stream_, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(string_1);
	}

	private static Stream smethod_5(Dictionary<string, string> dictionary_4, string string_1)
	{
		if (dictionary_4.TryGetValue(string_1, out var value))
		{
			return smethod_4(value);
		}
		return null;
	}

	private static byte[] smethod_6(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_7(Dictionary<string, string> dictionary_4, Dictionary<string, string> dictionary_5, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = smethod_5(dictionary_4, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_6(stream);
		}
		using (Stream stream2 = smethod_5(dictionary_5, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_6(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_8(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = smethod_1(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_2(string_0, assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_7(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			lock (object_0)
			{
				dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static Class322()
	{
		dictionary_3.Add("costura32.main.dll", "E1B1C61B8DF3231B35E211B7423FAE0930684439");
		dictionary_3.Add("costura64.main.dll", "E1B1C61B8DF3231B35E211B7423FAE0930684439");
		dictionary_1.Add("ae.net.mail", "costura.ae.net.mail.dll.compressed");
		dictionary_2.Add("ae.net.mail", "costura.ae.net.mail.pdb.compressed");
		dictionary_1.Add("bouncycastle.crypto", "costura.bouncycastle.crypto.dll.compressed");
		dictionary_1.Add("bunifu_ui_v1.52", "costura.bunifu_ui_v1.52.dll.compressed");
		dictionary_1.Add("costura", "costura.costura.dll.compressed");
		dictionary_2.Add("costura", "costura.costura.pdb.compressed");
		dictionary_1.Add("deviceid", "costura.deviceid.dll.compressed");
		dictionary_1.Add("emgu.cv.world", "costura.emgu.cv.world.dll.compressed");
		dictionary_1.Add("entityframework", "costura.entityframework.dll.compressed");
		dictionary_1.Add("entityframework.sqlserver", "costura.entityframework.sqlserver.dll.compressed");
		dictionary_1.Add("http", "costura.http.dll.compressed");
		dictionary_1.Add("mailkit", "costura.mailkit.dll.compressed");
		dictionary_2.Add("mailkit", "costura.mailkit.pdb.compressed");
		dictionary_1.Add("managedwinapi", "costura.managedwinapi.dll.compressed");
		dictionary_1.Add("materialskin", "costura.materialskin.dll.compressed");
		dictionary_1.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
		dictionary_1.Add("metroframework", "costura.metroframework.dll.compressed");
		dictionary_1.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
		dictionary_1.Add("microsoft.win32.primitives", "costura.microsoft.win32.primitives.dll.compressed");
		dictionary_1.Add("mimekit", "costura.mimekit.dll.compressed");
		dictionary_2.Add("mimekit", "costura.mimekit.pdb.compressed");
		dictionary_1.Add("netstandard", "costura.netstandard.dll.compressed");
		dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		dictionary_1.Add("openqa.selenium.chrome.chromedriverextensions", "costura.openqa.selenium.chrome.chromedriverextensions.dll.compressed");
		dictionary_1.Add("otp.net", "costura.otp.net.dll.compressed");
		dictionary_1.Add("system.appcontext", "costura.system.appcontext.dll.compressed");
		dictionary_1.Add("system.buffers", "costura.system.buffers.dll.compressed");
		dictionary_1.Add("system.collections.concurrent", "costura.system.collections.concurrent.dll.compressed");
		dictionary_1.Add("system.collections", "costura.system.collections.dll.compressed");
		dictionary_1.Add("system.collections.nongeneric", "costura.system.collections.nongeneric.dll.compressed");
		dictionary_1.Add("system.collections.specialized", "costura.system.collections.specialized.dll.compressed");
		dictionary_1.Add("system.componentmodel", "costura.system.componentmodel.dll.compressed");
		dictionary_1.Add("system.componentmodel.eventbasedasync", "costura.system.componentmodel.eventbasedasync.dll.compressed");
		dictionary_1.Add("system.componentmodel.primitives", "costura.system.componentmodel.primitives.dll.compressed");
		dictionary_1.Add("system.componentmodel.typeconverter", "costura.system.componentmodel.typeconverter.dll.compressed");
		dictionary_1.Add("system.console", "costura.system.console.dll.compressed");
		dictionary_1.Add("system.data.common", "costura.system.data.common.dll.compressed");
		dictionary_1.Add("system.data.sqlite", "costura.system.data.sqlite.dll.compressed");
		dictionary_1.Add("system.data.sqlite.ef6", "costura.system.data.sqlite.ef6.dll.compressed");
		dictionary_1.Add("system.data.sqlite.linq", "costura.system.data.sqlite.linq.dll.compressed");
		dictionary_1.Add("system.diagnostics.contracts", "costura.system.diagnostics.contracts.dll.compressed");
		dictionary_1.Add("system.diagnostics.debug", "costura.system.diagnostics.debug.dll.compressed");
		dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		dictionary_1.Add("system.diagnostics.fileversioninfo", "costura.system.diagnostics.fileversioninfo.dll.compressed");
		dictionary_1.Add("system.diagnostics.process", "costura.system.diagnostics.process.dll.compressed");
		dictionary_1.Add("system.diagnostics.stacktrace", "costura.system.diagnostics.stacktrace.dll.compressed");
		dictionary_1.Add("system.diagnostics.textwritertracelistener", "costura.system.diagnostics.textwritertracelistener.dll.compressed");
		dictionary_1.Add("system.diagnostics.tools", "costura.system.diagnostics.tools.dll.compressed");
		dictionary_1.Add("system.diagnostics.tracesource", "costura.system.diagnostics.tracesource.dll.compressed");
		dictionary_1.Add("system.diagnostics.tracing", "costura.system.diagnostics.tracing.dll.compressed");
		dictionary_1.Add("system.drawing.primitives", "costura.system.drawing.primitives.dll.compressed");
		dictionary_1.Add("system.dynamic.runtime", "costura.system.dynamic.runtime.dll.compressed");
		dictionary_1.Add("system.globalization.calendars", "costura.system.globalization.calendars.dll.compressed");
		dictionary_1.Add("system.globalization", "costura.system.globalization.dll.compressed");
		dictionary_1.Add("system.globalization.extensions", "costura.system.globalization.extensions.dll.compressed");
		dictionary_1.Add("system.io.compression", "costura.system.io.compression.dll.compressed");
		dictionary_1.Add("system.io.compression.zipfile", "costura.system.io.compression.zipfile.dll.compressed");
		dictionary_1.Add("system.io", "costura.system.io.dll.compressed");
		dictionary_1.Add("system.io.filesystem", "costura.system.io.filesystem.dll.compressed");
		dictionary_1.Add("system.io.filesystem.driveinfo", "costura.system.io.filesystem.driveinfo.dll.compressed");
		dictionary_1.Add("system.io.filesystem.primitives", "costura.system.io.filesystem.primitives.dll.compressed");
		dictionary_1.Add("system.io.filesystem.watcher", "costura.system.io.filesystem.watcher.dll.compressed");
		dictionary_1.Add("system.io.isolatedstorage", "costura.system.io.isolatedstorage.dll.compressed");
		dictionary_1.Add("system.io.memorymappedfiles", "costura.system.io.memorymappedfiles.dll.compressed");
		dictionary_1.Add("system.io.pipes", "costura.system.io.pipes.dll.compressed");
		dictionary_1.Add("system.io.unmanagedmemorystream", "costura.system.io.unmanagedmemorystream.dll.compressed");
		dictionary_1.Add("system.linq", "costura.system.linq.dll.compressed");
		dictionary_1.Add("system.linq.expressions", "costura.system.linq.expressions.dll.compressed");
		dictionary_1.Add("system.linq.parallel", "costura.system.linq.parallel.dll.compressed");
		dictionary_1.Add("system.linq.queryable", "costura.system.linq.queryable.dll.compressed");
		dictionary_1.Add("system.net.http", "costura.system.net.http.dll.compressed");
		dictionary_1.Add("system.net.nameresolution", "costura.system.net.nameresolution.dll.compressed");
		dictionary_1.Add("system.net.networkinformation", "costura.system.net.networkinformation.dll.compressed");
		dictionary_1.Add("system.net.ping", "costura.system.net.ping.dll.compressed");
		dictionary_1.Add("system.net.primitives", "costura.system.net.primitives.dll.compressed");
		dictionary_1.Add("system.net.requests", "costura.system.net.requests.dll.compressed");
		dictionary_1.Add("system.net.security", "costura.system.net.security.dll.compressed");
		dictionary_1.Add("system.net.sockets", "costura.system.net.sockets.dll.compressed");
		dictionary_1.Add("system.net.webheadercollection", "costura.system.net.webheadercollection.dll.compressed");
		dictionary_1.Add("system.net.websockets.client", "costura.system.net.websockets.client.dll.compressed");
		dictionary_1.Add("system.net.websockets", "costura.system.net.websockets.dll.compressed");
		dictionary_1.Add("system.objectmodel", "costura.system.objectmodel.dll.compressed");
		dictionary_1.Add("system.reflection", "costura.system.reflection.dll.compressed");
		dictionary_1.Add("system.reflection.extensions", "costura.system.reflection.extensions.dll.compressed");
		dictionary_1.Add("system.reflection.primitives", "costura.system.reflection.primitives.dll.compressed");
		dictionary_1.Add("system.resources.reader", "costura.system.resources.reader.dll.compressed");
		dictionary_1.Add("system.resources.resourcemanager", "costura.system.resources.resourcemanager.dll.compressed");
		dictionary_1.Add("system.resources.writer", "costura.system.resources.writer.dll.compressed");
		dictionary_1.Add("system.runtime.compilerservices.visualc", "costura.system.runtime.compilerservices.visualc.dll.compressed");
		dictionary_1.Add("system.runtime", "costura.system.runtime.dll.compressed");
		dictionary_1.Add("system.runtime.extensions", "costura.system.runtime.extensions.dll.compressed");
		dictionary_1.Add("system.runtime.handles", "costura.system.runtime.handles.dll.compressed");
		dictionary_1.Add("system.runtime.interopservices", "costura.system.runtime.interopservices.dll.compressed");
		dictionary_1.Add("system.runtime.interopservices.runtimeinformation", "costura.system.runtime.interopservices.runtimeinformation.dll.compressed");
		dictionary_1.Add("system.runtime.numerics", "costura.system.runtime.numerics.dll.compressed");
		dictionary_1.Add("system.runtime.serialization.formatters", "costura.system.runtime.serialization.formatters.dll.compressed");
		dictionary_1.Add("system.runtime.serialization.json", "costura.system.runtime.serialization.json.dll.compressed");
		dictionary_1.Add("system.runtime.serialization.primitives", "costura.system.runtime.serialization.primitives.dll.compressed");
		dictionary_1.Add("system.runtime.serialization.xml", "costura.system.runtime.serialization.xml.dll.compressed");
		dictionary_1.Add("system.security.claims", "costura.system.security.claims.dll.compressed");
		dictionary_1.Add("system.security.cryptography.algorithms", "costura.system.security.cryptography.algorithms.dll.compressed");
		dictionary_1.Add("system.security.cryptography.csp", "costura.system.security.cryptography.csp.dll.compressed");
		dictionary_1.Add("system.security.cryptography.encoding", "costura.system.security.cryptography.encoding.dll.compressed");
		dictionary_1.Add("system.security.cryptography.primitives", "costura.system.security.cryptography.primitives.dll.compressed");
		dictionary_1.Add("system.security.cryptography.x509certificates", "costura.system.security.cryptography.x509certificates.dll.compressed");
		dictionary_1.Add("system.security.principal", "costura.system.security.principal.dll.compressed");
		dictionary_1.Add("system.security.securestring", "costura.system.security.securestring.dll.compressed");
		dictionary_1.Add("system.text.encoding", "costura.system.text.encoding.dll.compressed");
		dictionary_1.Add("system.text.encoding.extensions", "costura.system.text.encoding.extensions.dll.compressed");
		dictionary_1.Add("system.text.regularexpressions", "costura.system.text.regularexpressions.dll.compressed");
		dictionary_1.Add("system.threading", "costura.system.threading.dll.compressed");
		dictionary_1.Add("system.threading.overlapped", "costura.system.threading.overlapped.dll.compressed");
		dictionary_1.Add("system.threading.tasks", "costura.system.threading.tasks.dll.compressed");
		dictionary_1.Add("system.threading.tasks.parallel", "costura.system.threading.tasks.parallel.dll.compressed");
		dictionary_1.Add("system.threading.thread", "costura.system.threading.thread.dll.compressed");
		dictionary_1.Add("system.threading.threadpool", "costura.system.threading.threadpool.dll.compressed");
		dictionary_1.Add("system.threading.timer", "costura.system.threading.timer.dll.compressed");
		dictionary_1.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
		dictionary_1.Add("system.xml.readerwriter", "costura.system.xml.readerwriter.dll.compressed");
		dictionary_1.Add("system.xml.xdocument", "costura.system.xml.xdocument.dll.compressed");
		dictionary_1.Add("system.xml.xmldocument", "costura.system.xml.xmldocument.dll.compressed");
		dictionary_1.Add("system.xml.xmlserializer", "costura.system.xml.xmlserializer.dll.compressed");
		dictionary_1.Add("system.xml.xpath", "costura.system.xml.xpath.dll.compressed");
		dictionary_1.Add("system.xml.xpath.xdocument", "costura.system.xml.xpath.xdocument.dll.compressed");
		dictionary_1.Add("webdriver", "costura.webdriver.dll.compressed");
		dictionary_1.Add("webdriver.support", "costura.webdriver.support.dll.compressed");
		dictionary_1.Add("webdrivermanager", "costura.webdrivermanager.dll.compressed");
		dictionary_1.Add("xnet", "costura.xnet.dll.compressed");
		list_0.Add("costura32.main.dll");
		list_1.Add("costura64.main.dll");
	}

	private static void smethod_9(string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
	}

	private static string smethod_10(string string_1)
	{
		string text = ((IntPtr.Size == 8) ? "64" : "32");
		string text2 = string_1;
		if (string_1.StartsWith("costura" + text + "."))
		{
			text2 = Path.Combine(text, string_1.Substring(10));
		}
		else if (string_1.StartsWith("costura."))
		{
			text2 = string_1.Substring(8);
		}
		if (text2.EndsWith(".compressed"))
		{
			text2 = text2.Substring(0, text2.Length - 11);
		}
		return text2;
	}

	private static string smethod_11(string string_1)
	{
		using FileStream stream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		using BufferedStream inputStream = new BufferedStream(stream);
		using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(inputStream);
		StringBuilder stringBuilder = new StringBuilder(2 * array.Length);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll")]
	private static extern uint SetErrorMode(uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_1, IntPtr intptr_0, uint uint_0);

	private static void smethod_12(string string_1, IList<string> ilist_0, Dictionary<string, string> dictionary_4)
	{
		foreach (string item in ilist_0)
		{
			string path = smethod_10(item);
			string text = Path.Combine(string_1, path);
			if (File.Exists(text))
			{
				string text2 = smethod_11(text);
				if (text2 != dictionary_4[item])
				{
					File.Delete(text);
				}
			}
			if (File.Exists(text))
			{
				continue;
			}
			using Stream stream_ = smethod_4(item);
			using FileStream stream_2 = File.OpenWrite(text);
			smethod_3(stream_, stream_2);
		}
		uint errorMode = SetErrorMode(32771u);
		foreach (string item2 in ilist_0)
		{
			string path = smethod_10(item2);
			if (path.EndsWith(".dll"))
			{
				string string_2 = Path.Combine(string_1, path);
				LoadLibraryEx(string_2, IntPtr.Zero, 8u);
			}
		}
		SetErrorMode(errorMode);
	}

	private static void smethod_13(string string_1, string string_2, List<string> list_2, Dictionary<string, string> dictionary_4)
	{
		string name = "Costura" + string_1;
		using Mutex mutex = new Mutex(initiallyOwned: false, name);
		bool flag = false;
		try
		{
			try
			{
				if (!(flag = mutex.WaitOne(60000, exitContext: false)))
				{
					throw new TimeoutException("Timeout waiting for exclusive access");
				}
			}
			catch (AbandonedMutexException)
			{
				flag = true;
			}
			string path = ((IntPtr.Size == 8) ? "64" : "32");
			smethod_9(Path.Combine(string_2, path));
			smethod_12(string_2, list_2, dictionary_4);
		}
		finally
		{
			if (flag)
			{
				mutex.ReleaseMutex();
			}
		}
	}

	public static void smethod_14()
	{
		if (Interlocked.Exchange(ref int_0, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object obj = currentDomain.GetType()?.GetProperty("SetupInformation")?.GetValue(currentDomain);
		PropertyInfo propertyInfo = obj?.GetType()?.GetProperty("TargetFrameworkName");
		if ((object)propertyInfo != null && propertyInfo.GetValue(obj) == null)
		{
			string text = ((TargetFrameworkAttribute)(Assembly.GetCallingAssembly()?.GetCustomAttribute(typeof(TargetFrameworkAttribute))))?.FrameworkName;
			if (text != null)
			{
				currentDomain.SetData("TargetFrameworkName", text);
			}
		}
		string text2 = "D17F17B44027F70892EAED828137C94E";
		string path = Path.Combine(Path.GetTempPath(), "Costura");
		string_0 = Path.Combine(path, text2);
		List<string> list_ = ((IntPtr.Size == 8) ? list_1 : list_0);
		smethod_13(text2, string_0, list_, dictionary_3);
		currentDomain.AssemblyResolve += delegate(object object_1, ResolveEventArgs resolveEventArgs_0)
		{
			lock (object_0)
			{
				if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
			Assembly assembly = smethod_1(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_2(string_0, assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_7(dictionary_1, dictionary_2, assemblyName);
			if ((object)assembly == null)
			{
				lock (object_0)
				{
					dictionary_0[resolveEventArgs_0.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}
