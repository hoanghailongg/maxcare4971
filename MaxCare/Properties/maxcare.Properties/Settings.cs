using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using maxcare.Properties;


[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => settings_0;

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string UserName
	{
		get
		{
			return (string)this["UserName"];
		}
		set
		{
			this["UserName"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string PassWord
	{
		get
		{
			return (string)this["PassWord"];
		}
		set
		{
			this["PassWord"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string PathChrome
	{
		get
		{
			return (string)this["PathChrome"];
		}
		set
		{
			this["PathChrome"] = value;
		}
	}
}
