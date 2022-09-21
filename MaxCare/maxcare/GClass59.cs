using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x02000A13 RID: 2579
public class GClass59
{
	// Token: 0x060016E7 RID: 5863 RVA: 0x002315A0 File Offset: 0x0022F7A0
	private void method_0()
	{
		this.class368_0.method_5(new GClass59.Class351(this.class368_0.method_3()));
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x002315C8 File Offset: 0x0022F7C8
	private void method_1()
	{
		Type type = this.method_50(this.class369_0.method_0());
		Dictionary<object, DynamicMethod> obj = GClass59.dictionary_1;
		DynamicMethod dynamicMethod;
		lock (obj)
		{
			if (!GClass59.dictionary_1.TryGetValue(type, out dynamicMethod))
			{
				dynamicMethod = new DynamicMethod("", typeof(int), null, typeof(GClass59).Module, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Sizeof, type);
				ilgenerator.Emit(OpCodes.Ret);
				GClass59.dictionary_1.Add(type, dynamicMethod);
			}
		}
		this.class368_0.method_5(new GClass59.Class335((int)dynamicMethod.Invoke(null, null)));
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x00231694 File Offset: 0x0022F894
	private void method_2()
	{
		this.class368_0.method_5(new GClass59.Class340(null));
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x002316B4 File Offset: 0x0022F8B4
	private void method_3()
	{
		this.class368_0.method_5(new GClass59.Class336(this.class369_0.method_1()));
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x002316DC File Offset: 0x0022F8DC
	private void method_4()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(this.method_24(this.class368_0.method_3().vmethod_5(type_, false), type_));
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x00231720 File Offset: 0x0022F920
	private void method_5()
	{
		string string_ = this.method_11(this.class369_0.method_0());
		this.class368_0.method_5(new GClass59.Class339(string_));
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x00231750 File Offset: 0x0022F950
	private void method_6()
	{
		short int_ = this.class369_0.method_2();
		Type type_ = this.method_50(this.class368_0.method_3().vmethod_22());
		GClass59.Class333 @class = this.class368_0.method_3();
		GClass59.Class333 class2 = this.class368_0.method_3();
		if (@class.vmethod_21())
		{
			class2 = new GClass59.Class346(this.method_24(class2.vmethod_12(), type_), @class);
		}
		else
		{
			class2 = this.method_24(class2.vmethod_12(), type_);
		}
		this.class368_0.method_0((int)int_, class2);
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x002317D4 File Offset: 0x0022F9D4
	private void method_7()
	{
		this.class368_0.method_3();
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x002317F0 File Offset: 0x0022F9F0
	public object method_8(object[] object_0, int int_0)
	{
		this.class369_0.vmethod_0(int_0);
		this.class368_0.method_5(new GClass59.Class343(object_0));
		object result;
		try
		{
			for (; ; )
			{
				try
				{
					this.dictionary_2[(uint)this.class369_0.method_8()]();
					if (this.class369_0.vmethod_1() != 0)
					{
						continue;
					}
				}
				catch (Exception ex)
				{
					if (this.class364_0 == null)
					{
						this.exception_0 = ex;
					}
					this.method_23();
					continue;
				}
				break;
			}
			result = this.class368_0.method_3().vmethod_12();
		}
		finally
		{
			foreach (IntPtr hglobal in this.list_0)
			{
				Marshal.FreeHGlobal(hglobal);
			}
			this.list_0.Clear();
		}
		return result;
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x002318DC File Offset: 0x0022FADC
	private void method_9()
	{
		this.class368_0.method_5(new GClass59.Class338(this.class369_0.method_4()));
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x00231904 File Offset: 0x0022FB04
	private void method_10()
	{
		GClass59.Class333 @class;
		GClass59.Class333 class2;
		bool bool_;
		for (; ; )
		{
			@class = this.class368_0.method_3();
			class2 = this.class368_0.method_3();
			bool_ = ((this.class369_0.method_8() & 2) > 0);
			TypeCode typeCode = this.method_67(class2, @class);
			if (typeCode != TypeCode.Object)
			{
				switch (typeCode)
				{
					case TypeCode.Int32:
						goto IL_5F;
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_89;
					case TypeCode.Int64:
						goto IL_74;
					case TypeCode.Single:
						goto IL_9E;
					case TypeCode.Double:
						continue;
				}
				break;
			}
			goto IL_B3;
		}
		throw new InvalidOperationException();
	IL_5F:
		this.class368_0.method_5(GClass59.Class335.smethod_3(class2, @class, bool_));
		return;
	IL_74:
		//this.class368_0.method_5(GClass59.Class336.smethod_11(class2, @class, bool_));
		return;
	IL_89:
		this.class368_0.method_5(GClass59.Class341.smethod_3(class2, @class, bool_));
		return;
	IL_9E:
		this.class368_0.method_5(GClass59.Class337.smethod_2(class2, @class, bool_));
		return;
	IL_B3:
		this.class368_0.method_5(GClass59.Class340.smethod_0(class2, @class));
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x002319D8 File Offset: 0x0022FBD8
	private string method_11(int int_0)
	{
		Dictionary<int, object> obj = GClass59.dictionary_0;
		string result;
		lock (obj)
		{
			object obj2;
			if (GClass59.dictionary_0.TryGetValue(int_0, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				string text = GClass59.module_0.ResolveString(int_0);
				GClass59.dictionary_0.Add(int_0, text);
				result = text;
			}
		}
		return result;
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x00231A4C File Offset: 0x0022FC4C
	private void method_12()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		Array array = this.class368_0.method_3().vmethod_12() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.class368_0.method_5(this.method_24(array.GetValue(@class.vmethod_22()), type_));
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x00231AB4 File Offset: 0x0022FCB4
	private bool method_13(object object_0, Type type_0)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		return type == type_0 || type_0.IsAssignableFrom(type) || 605167617 != 0;
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x00231AE8 File Offset: 0x0022FCE8
	private void method_14()
	{
		GClass59.Class333 class333_ = this.class368_0.method_3();
		GClass59.Class333 @class = this.class368_0.method_3();
		TypeCode typeCode = @class.vmethod_2();
		if (typeCode == TypeCode.Int32)
		{
			this.class368_0.method_5(GClass59.Class335.smethod_5(@class, class333_));
			return;
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		this.class368_0.method_5(GClass59.Class336.smethod_9(@class, class333_));
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x00231B4C File Offset: 0x0022FD4C
	private void method_15()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		if (!this.method_13(@class.vmethod_12(), type_))
		{
			@class = new GClass59.Class340(null);
		}
		this.class368_0.method_5(@class);
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x00231B9C File Offset: 0x0022FD9C
	private void method_16()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(this.method_24(this.class368_0.method_3(), type_));
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x00231BD8 File Offset: 0x0022FDD8
	private void method_17()
	{
		GClass59.Class333 class333_;
		GClass59.Class333 @class;
		bool bool_;
		TypeCode typeCode;
		for (; ; )
		{
			class333_ = this.class368_0.method_3();
			@class = this.class368_0.method_3();
			bool_ = ((this.class369_0.method_8() & 2) > 0);
			typeCode = @class.vmethod_2();
			if (typeCode != TypeCode.Int32)
			{
				break;
			}
			this.class368_0.method_5(GClass59.Class335.smethod_10(@class, class333_, bool_));
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		this.class368_0.method_5(GClass59.Class336.smethod_3(@class, class333_, bool_));
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x00231C54 File Offset: 0x0022FE54
	private void method_18()
	{
		FieldInfo fieldInfo_ = this.method_42(this.class369_0.method_0());
		GClass59.Class333 class333_ = this.class368_0.method_3();
		this.class368_0.method_5(new GClass59.Class347(fieldInfo_, class333_));
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x00231C94 File Offset: 0x0022FE94
	private void method_19()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(this.method_24(this.class368_0.method_3().vmethod_5(type_, true), type_));
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x00231CD8 File Offset: 0x0022FED8
	private void method_20()
	{
		Exception ex = this.class368_0.method_3().vmethod_12() as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x00231D04 File Offset: 0x0022FF04
	private void method_21()
	{
		int num;
		int num2;
		for (; ; )
		{
			num = this.class369_0.method_0();
			num2 = num >> 24;
			if (num2 > 10)
			{
				goto IL_A0;
			}
			switch (num2)
			{
				case 1:
				case 2:
					goto IL_DF;
				case 3:
				case 5:
					goto IL_B0;
				case 4:
					goto IL_77;
				case 6:
					goto IL_B6;
				default:
					if (num2 != 10)
					{
						goto Block_2;
					}
					if (!this.method_45(num).Boolean_0)
					{
						goto Block_3;
					}
					break;
			}
		}
	Block_2:
		goto IL_B0;
	Block_3:
		this.class368_0.method_5(new GClass59.Class342(GClass59.module_0.ModuleHandle.ResolveFieldHandle(num)));
		return;
	IL_77:
		this.class368_0.method_5(new GClass59.Class342(GClass59.module_0.ModuleHandle.ResolveFieldHandle(num)));
		return;
	IL_A0:
		if (num2 == 411895375)
		{
			goto IL_DF;
		}
		if (num2 == 663029279)
		{
			goto IL_B6;
		}
	IL_B0:
		throw new InvalidOperationException();
	IL_B6:
		this.class368_0.method_5(new GClass59.Class342(GClass59.module_0.ModuleHandle.ResolveMethodHandle(num)));
		return;
	IL_DF:
		this.class368_0.method_5(new GClass59.Class342(GClass59.module_0.ModuleHandle.ResolveTypeHandle(num)));
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x00231E18 File Offset: 0x00230018
	private void method_22()
	{
		short int_ = this.class369_0.method_2();
		GClass59.Class333 @class = this.class368_0.method_4((int)int_);
		if (@class.vmethod_21())
		{
			throw new ArgumentException();
		}
		this.class368_0.method_5(new GClass59.Class345(@class));
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x00231E60 File Offset: 0x00230060
	private void method_23()
	{
		GClass59.Class364 @class;
		for (; ; )
		{
		IL_00:
			this.class368_0.method_1();
			this.class369_0.method_5();
			while (this.class367_0.method_0() != 0)
			{
				List<GClass59.Class364> list = this.class367_0.method_2().method_3();
				int num = (this.class364_0 == null) ? 1258966896 : (list.IndexOf(this.class364_0) + 1);
				this.class364_0 = null;
				for (int i = num; i < list.Count; i++)
				{
					@class = list[i];
					byte b = @class.method_1();
					if (b != 0)
					{
						if (b == 1)
						{
							this.class364_0 = @class;
							goto IL_00;
						}
					}
					else
					{
						Type type = this.exception_0.GetType();
						Type type2 = this.method_50(@class.method_0());
						if (type == type2 || type.IsSubclassOf(type2))
						{
							goto IL_143;
						}
					}
				}
				this.class367_0.method_1();
				for (int j = list.Count; j > 0; j--)
				{
					GClass59.Class364 class2 = list[j - 1];
					if (class2.method_1() == 2 || class2.method_1() == 4)
					{
						this.class369_0.method_9(class2.method_2());
					}
				}
				if (this.class369_0.method_3() != 0)
				{
					goto IL_137;
				}
			}
			break;
		}
		throw this.exception_0;
	IL_137:
		this.class369_0.method_6();
		return;
	IL_143:
		this.class367_0.method_1();
		this.class368_0.method_5(new GClass59.Class340(this.exception_0));
		this.class369_0.vmethod_0(@class.method_2());
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x00231FE4 File Offset: 0x002301E4
	private GClass59.Class333 method_24(object object_0, Type type_0)
	{
		GClass59.Class333 @class = object_0 as GClass59.Class333;
		while (!type_0.IsEnum)
		{
			Type.GetTypeCode(type_0);
		}
		if (@class != null)
		{
			object_0 = @class.vmethod_12();
		}
		if (object_0 != null && !(object_0 is Enum))
		{
			object_0 = Enum.ToObject(type_0, object_0);
		}
		return new GClass59.Class355((object_0 == null) ? ((Enum)Activator.CreateInstance(type_0)) : ((Enum)object_0));
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x00232044 File Offset: 0x00230244
	private bool method_25(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		for (; ; )
		{
			Type declaringType = methodBase_0.DeclaringType;
			if (declaringType == null)
			{
				break;
			}
			if (!(Nullable.GetUnderlyingType(declaringType) != null))
			{
				return -439211208 != 0;
			}
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				goto IL_49;
			}
			if (!string.Equals(methodBase_0.Name, "get_Value", StringComparison.OrdinalIgnoreCase))
			{
				goto IL_56;
			}
		}
		return false;
	IL_49:
		object_1 = (object_0 != null);
		return true;
	IL_56:
		if (methodBase_0.Name.Equals("GetValueOrDefault", (StringComparison)71489028))
		{
			if (object_0 == null)
			{
				object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
			}
			object_1 = object_0;
			return true;
		}
		return -439211208 != 0;
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x002320E0 File Offset: 0x002302E0
	private void method_26()
	{
		if (this.exception_0 == null)
		{
			this.class369_0.method_6();
			return;
		}
		this.method_23();
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x00232108 File Offset: 0x00230308
	private void method_27()
	{
		int num = this.class369_0.method_0();
		this.class369_0.method_9(this.class368_0.method_3().vmethod_22());
		List<int> list = new List<int>();
		while (this.class367_0.method_0() != 0 && num > this.class367_0.method_2().method_0())
		{
			List<GClass59.Class364> list2 = this.class367_0.method_1().method_3();
			for (int i = 0; i < list2.Count; i++)
			{
				GClass59.Class364 @class = list2[i];
				if (@class.method_1() == 2)
				{
					list.Add(@class.method_2());
				}
			}
		}
		for (int j = list.Count; j > 0; j--)
		{
			this.class369_0.method_9(list[j - 1]);
		}
		this.exception_0 = null;
		this.class368_0.method_1();
		this.class369_0.method_6();
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x002321EC File Offset: 0x002303EC
	private void method_28()
	{
		FieldInfo fieldInfo_ = this.method_42(this.class369_0.method_0());
		this.class368_0.method_5(new GClass59.Class350(fieldInfo_, this));
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x00232220 File Offset: 0x00230420
	private void method_29()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		GClass59.Class333 class2 = this.class368_0.method_3();
		byte b = this.class369_0.method_8();
		bool bool_ = (b & 2) > 0;
		bool bool_2 = (b & 16) > 0;
		switch (this.method_67(@class, class2))
		{
			case TypeCode.Int32:
				this.class368_0.method_5(GClass59.Class335.smethod_1(@class, class2, bool_2, bool_));
				return;
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				//this.class368_0.method_5(GClass59.Class341.smethod_0(@class, class2, bool_2, bool_));
				return;
			case TypeCode.Int64:
				this.class368_0.method_5(GClass59.Class336.smethod_2(@class, class2, bool_2, bool_));
				return;
			case TypeCode.Single:
				this.class368_0.method_5(GClass59.Class337.smethod_4(@class, class2, bool_2, bool_));
				return;
			case TypeCode.Double:
				this.class368_0.method_5(GClass59.Class338.smethod_0(@class, class2, bool_2, bool_));
				return;
			default:
				throw new InvalidOperationException();
		}
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x00232304 File Offset: 0x00230504
	private void method_30()
	{
		GClass59.Class333 class333_ = this.class368_0.method_3();
		GClass59.Class333 class333_2 = this.class368_0.method_3();
		TypeCode typeCode = this.method_67(class333_2, class333_);
		if (typeCode == TypeCode.Int32)
		{
			this.class368_0.method_5(GClass59.Class335.smethod_6(class333_2, class333_));
			return;
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		this.class368_0.method_5(GClass59.Class336.smethod_12(class333_2, class333_));
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x00232368 File Offset: 0x00230568
	// Note: this type is marked as 'beforefieldinit'.
	static GClass59()
	{
		GClass59.dictionary_0 = new Dictionary<int, object>();
		GClass59.dictionary_1 = new Dictionary<object, DynamicMethod>();
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x002323A0 File Offset: 0x002305A0
	private void method_31()
	{
		GClass59.Class369 @class = new GClass59.Class369();
		@class.vmethod_0(this.class368_0.method_3().vmethod_22());
		uint num = (uint)this.class369_0.method_8();
		ushort num2 = (ushort)@class.method_2();
		Dictionary<int, GClass59.Class333> dictionary = new Dictionary<int, GClass59.Class333>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[(int)num2];
			for (int i = (int)(num2 - 1); i >= 0; i--)
			{
				GClass59.Class333 class2 = this.class368_0.method_3();
				if (class2.vmethod_21())
				{
					dictionary[i] = class2;
				}
				array[i] = this.method_24(class2, this.method_50(@class.method_0())).vmethod_12();
			}
		}
		int num3 = @class.method_0();
		if ((num & 4U) > 0U && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new GClass59().method_8(array, @class.vmethod_1());
		foreach (KeyValuePair<int, GClass59.Class333> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_10(array[keyValuePair.Key]);
		}
		if (num3 != 0)
		{
			Type type = this.method_50(num3);
			if (type != typeof(void))
			{
				this.class368_0.method_5(this.method_24(object_, type));
			}
		}
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x00232504 File Offset: 0x00230704
	private void method_32()
	{
		for (; ; )
		{
			GClass59.Class333 class333_ = this.class368_0.method_3();
			GClass59.Class333 class333_2 = this.class368_0.method_3();
			TypeCode typeCode = this.method_67(class333_2, class333_);
			if (typeCode != TypeCode.Int32)
			{
				if (typeCode != TypeCode.Int64)
				{
					break;
				}
			}
			else
			{
				this.class368_0.method_5(GClass59.Class335.smethod_8(class333_2, class333_));
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x0023255C File Offset: 0x0023075C
	private void method_33()
	{
		GClass59.Class333 class333_ = this.class368_0.method_3();
		GClass59.Class333 class333_2;
		bool bool_;
		bool bool_2;
		for (; ; )
		{
			class333_2 = this.class368_0.method_3();
			byte b = this.class369_0.method_8();
			bool_ = ((b & 2) > 0);
			bool_2 = ((b & 16) > 0);
			switch (this.method_67(class333_2, class333_))
			{
				case TypeCode.Int32:
					goto IL_6F;
				case TypeCode.Int64:
					
						continue;
					
					goto IL_86;
				case TypeCode.Single:
					goto IL_A3;
				case TypeCode.Double:
					goto IL_BA;
			}
			break;
		}
		goto IL_9D;
	IL_6F:
		//this.class368_0.method_5(GClass59.Class335.smethod_12(class333_2, class333_, bool_2, bool_));
		return;
	IL_86:
		this.class368_0.method_5(GClass59.Class336.smethod_6(class333_2, class333_, bool_2, bool_));
		return;
	IL_9D:
		throw new InvalidOperationException();
	IL_A3:
		this.class368_0.method_5(GClass59.Class337.smethod_0(class333_2, class333_, bool_2, bool_));
		return;
	IL_BA:
		this.class368_0.method_5(GClass59.Class338.smethod_2(class333_2, class333_, bool_2, bool_));
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x0023263C File Offset: 0x0023083C
	private void method_34()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(this.class368_0.method_3().vmethod_19());
		this.list_0.Add(intPtr);
		this.class368_0.method_5(new GClass59.Class353(intPtr));
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x0023267C File Offset: 0x0023087C
	private void method_35()
	{
		GClass59.Class331 @class = this.method_45(this.class369_0.method_0());
		if (!@class.Boolean_0)
		{
			throw new ArgumentException();
		}
		BindingFlags invokeAttr = (BindingFlags)(-641755495);
		Type[] array = @class.method_1();
		Type[] array2 = new Type[array.Length + 1879048193];
		array.CopyTo(array2, 0);
		array2[array.Length] = typeof(IntPtr);
		object[] array3 = new object[array2.Length];
		Dictionary<int, GClass59.Class333> dictionary = new Dictionary<int, GClass59.Class333>();
		GClass59.Class332 class2 = new GClass59.Class332();
		try
		{
			int i = array3.Length - 1;
			while (i >= 0)
			{
				Type type = array2[i];
				GClass59.Class333 class3 = this.class368_0.method_3();
				if (!class3.vmethod_21())
				{
					goto IL_C7;
				}
				if (type.IsByRef)
				{
					dictionary[i] = class3;
					goto IL_C7;
				}
				array3[i] = class2.method_0(class3.vmethod_12());
			IL_DB:
				i--;
				continue;
			IL_C7:
				array3[i] = this.method_24(class3, type).vmethod_12();
				goto IL_DB;
			}
			Dictionary<object, DynamicMethod> obj = GClass59.dictionary_1;
			DynamicMethod dynamicMethod;
			lock (obj)
			{
				if (!GClass59.dictionary_1.TryGetValue(@class, out dynamicMethod))
				{
					dynamicMethod = new DynamicMethod("", (@class.Type_0 != typeof(void)) ? @class.Type_0 : null, array2, typeof(GClass59).Module, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int j = 0; j < array2.Length; j++)
					{
						ilgenerator.Emit(dictionary.ContainsKey(j) ? OpCodes.Ldarga : OpCodes.Ldarg, j);
					}
					ilgenerator.EmitCalli(OpCodes.Calli, @class.CallingConvention_0, @class.Type_0, array);
					ilgenerator.Emit(OpCodes.Ret);
					GClass59.dictionary_1.Add(@class, dynamicMethod);
				}
			}
			object object_ = dynamicMethod.Invoke(null, invokeAttr, null, array3, null);
			foreach (KeyValuePair<int, GClass59.Class333> keyValuePair in dictionary)
			{
				keyValuePair.Value.vmethod_10(array3[keyValuePair.Key]);
			}
			if (@class.Type_0 != typeof(void))
			{
				this.class368_0.method_5(this.method_24(object_, @class.Type_0));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00232928 File Offset: 0x00230B28
	private void method_36()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(new GClass59.Class340(this.method_24(this.class368_0.method_3(), type_).vmethod_12()));
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x00232970 File Offset: 0x00230B70
	private void method_37()
	{
		MethodBase methodBase_ = this.method_65(this.class369_0.method_0());
		this.class368_0.method_5(new GClass59.Class352(methodBase_));
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x002329A0 File Offset: 0x00230BA0
	private void method_38()
	{
		Type type = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		object object_ = null;
		if (type.IsValueType && Nullable.GetUnderlyingType(type) == null)
		{
			object_ = FormatterServices.GetUninitializedObject(type);
		}
		@class.vmethod_10(object_);
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x002329F0 File Offset: 0x00230BF0
	private void method_39()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		Array array = this.class368_0.method_3().vmethod_12() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.class368_0.method_5(new GClass59.Class348(array, @class.vmethod_22()));
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00232A40 File Offset: 0x00230C40
	private void method_40()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		if (@class.vmethod_12() is IConvertible)
		{
			double d = @class.vmethod_6();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new OverflowException();
			}
		}
		else
		{
			@class = new GClass59.Class338(double.NaN);
		}
		this.class368_0.method_5(@class);
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00232AA0 File Offset: 0x00230CA0
	private void method_41()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		GClass59.Class333 class2 = this.class368_0.method_3();
		byte b = this.class369_0.method_8();
		bool bool_ = (b & 2) > 0;
		bool bool_2 = (b & 16) > 0;
		switch (this.method_67(class2, @class))
		{
			case TypeCode.Int32:
				this.class368_0.method_5(GClass59.Class335.smethod_11(class2, @class, bool_2, bool_));
				return;
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				//this.class368_0.method_5(GClass59.Class341.smethod_1(class2, @class, bool_2, bool_));
				return;
			case TypeCode.Int64:
				this.class368_0.method_5(GClass59.Class336.smethod_1(class2, @class, bool_2, bool_));
				return;
			case TypeCode.Single:
				this.class368_0.method_5(GClass59.Class337.smethod_1(class2, @class, bool_2, bool_));
				return;
			case TypeCode.Double:
				this.class368_0.method_5(GClass59.Class338.smethod_5(class2, @class, bool_2, bool_));
				return;
			default:
				throw new InvalidOperationException();
		}
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00232B80 File Offset: 0x00230D80
	private FieldInfo method_42(int int_0)
	{
		Dictionary<int, object> obj = GClass59.dictionary_0;
		FieldInfo result;
		lock (obj)
		{
			object obj2;
			if (GClass59.dictionary_0.TryGetValue(int_0, out obj2))
			{
				result = (FieldInfo)obj2;
			}
			else
			{
				FieldInfo fieldInfo = GClass59.module_0.ResolveField(int_0);
				GClass59.dictionary_0.Add(int_0, fieldInfo);
				result = fieldInfo;
			}
		}
		return result;
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00232BF4 File Offset: 0x00230DF4
	private void method_43()
	{
		short int_ = this.class369_0.method_2();
		GClass59.Class333 @class = this.class368_0.method_4((int)int_);
		GClass59.Class333 class2 = this.class368_0.method_3();
		if (@class != null)
		{
			@class.vmethod_10(this.method_24(class2, @class.vmethod_8()).vmethod_12());
			return;
		}
		if (!class2.vmethod_21())
		{
			throw new ArgumentException();
		}
		this.class368_0.method_0((int)int_, class2);
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00232C60 File Offset: 0x00230E60
	private void method_44()
	{
		this.class368_0.method_5(this.class368_0.method_2().vmethod_24());
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00232C88 File Offset: 0x00230E88
	private GClass59.Class331 method_45(int int_0)
	{
		Dictionary<int, object> obj = GClass59.dictionary_0;
		GClass59.Class331 result;
		lock (obj)
		{
			int key = int_0 | 1073741824;
			object obj2;
			if (GClass59.dictionary_0.TryGetValue(key, out obj2))
			{
				result = (GClass59.Class331)obj2;
			}
			else
			{
				byte[] byte_ = GClass59.module_0.ResolveSignature(int_0);
				GClass59.Class331 @class = new GClass59.Class331();
				@class.method_0(byte_, GClass59.module_0);
				GClass59.dictionary_0.Add(key, @class);
				result = @class;
			}
		}
		return result;
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00232D14 File Offset: 0x00230F14
	private void method_46()
	{
		this.class368_0.method_5(new GClass59.Class335(this.class369_0.method_0()));
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00232D3C File Offset: 0x00230F3C
	private void method_47()
	{
		GClass59.Class333 class333_ = this.class368_0.method_3();
		GClass59.Class333 class333_2 = this.class368_0.method_3();
		bool bool_ = (this.class369_0.method_8() & 2) > 0;
		switch (this.method_67(class333_2, class333_))
		{
			case TypeCode.Int32:
				this.class368_0.method_5(GClass59.Class335.smethod_4(class333_2, class333_, bool_));
				return;
			case TypeCode.Int64:
				this.class368_0.method_5(GClass59.Class336.smethod_10(class333_2, class333_, bool_));
				return;
			case TypeCode.Single:
				this.class368_0.method_5(GClass59.Class337.smethod_5(class333_2, class333_, bool_));
				return;
			case TypeCode.Double:
				this.class368_0.method_5(GClass59.Class338.smethod_1(class333_2, class333_, bool_));
				return;
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x00232DF8 File Offset: 0x00230FF8
	private void method_48()
	{
		Type type = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		GClass59.Class333 class2 = this.class368_0.method_3();
		@class = this.method_24(@class, type);
		if (class2.vmethod_21())
		{
			@class = this.method_24(@class, class2.vmethod_8());
		}
		else
		{
			//class2 = new GClass59.Class349((class2.vmethod_12() is Pointer) ? new IntPtr(Pointer.Unbox(class2.vmethod_12())) : class2.vmethod_19(), type);
		}
		class2.vmethod_10(@class.vmethod_12());
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x00232E88 File Offset: 0x00231088
	private void method_49()
	{
		MethodBase methodBase;
		uint num;
		Type[] array;
		for (; ; )
		{
			int int_ = this.class368_0.method_3().vmethod_22();
			methodBase = this.method_65(int_);
			num = (uint)this.class369_0.method_8();
			if (methodBase.CallingConvention != CallingConventions.VarArgs)
			{
				goto IL_55;
			}
			GClass59.Class331 @class = this.method_45(int_);
			if (!@class.Boolean_0)
			{
				break;
			}
			array = @class.method_1();
		}
		throw new ArgumentException();
	IL_55:
		ParameterInfo[] parameters = methodBase.GetParameters();
		array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		bool flag = (num & 3289971090U) > 3429579702U;
		if ((num & 3089631455U) > 1210583266U)
		{
			MethodInfo method = this.method_50(this.class368_0.method_3().vmethod_22()).GetMethod(methodBase.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
		}
		BindingFlags bindingFlags = BindingFlags.Default;
		MethodInfo methodInfo = methodBase as MethodInfo;
		Dictionary<int, GClass59.Class333> dictionary = new Dictionary<int, GClass59.Class333>();
		object[] array2 = new object[array.Length];
		GClass59.Class332 class2 = new GClass59.Class332();
		try
		{
			object obj2;
			object object_;
			for (; ; )
			{
				int j = array2.Length - 1;
				GClass59.Class333 class3;
				while (j >= 0)
				{
					Type type = array[j];
					class3 = this.class368_0.method_3();
					if (!class3.vmethod_21())
					{
						goto IL_151;
					}
					if (type.IsByRef)
					{
						dictionary[j] = class3;
						goto IL_151;
					}
					array2[j] = class2.method_0(class3.vmethod_12());
				IL_164:
					j--;
					continue;
				IL_151:
					array2[j] = this.method_24(class3, type).vmethod_12();
					goto IL_164;
				}
				class3 = (methodBase.IsStatic ? null : this.class368_0.method_3());
				if (class3 == null)
				{
					goto IL_196;
				}
				object obj;
				if ((obj = class3.vmethod_12()) == null)
				{
					goto IL_196;
				}
			IL_198:
				obj2 = obj;
				if (flag && obj2 == null)
				{
					break;
				}
				object_ = null;
				if (methodBase.CallingConvention == (CallingConventions)1852629114)
				{
					continue;
				}
				goto IL_1C2;
			IL_196:
				obj = null;
				goto IL_198;
			}
			throw new NullReferenceException();
		IL_1C2:
			if (methodBase.IsConstructor && methodBase.DeclaringType.IsValueType)
			{
				obj2 = Activator.CreateInstance(methodBase.DeclaringType, bindingFlags, null, array2, null);
				GClass59.Class333 class3;
				//if (class3 != null)
				//{
				//	DynamicMethod dynamicMethod;
				//	object_ = dynamicMethod.Invoke(null, bindingFlags, null, array2, null);
				//}
			}
			else if (!this.method_25(methodBase, obj2, ref object_, array2))
			{
				if (!flag && methodBase.IsVirtual && !methodBase.IsFinal)
				{
					object[] array3 = new object[array.Length + 1];
					array3[0] = obj2;
					for (int k = 0; k < array.Length; k++)
					{
						array3[k + 1] = array2[k];
					}
					Dictionary<object, DynamicMethod> obj3 = GClass59.dictionary_1;
					DynamicMethod dynamicMethod2;
					lock (obj3)
					{
						if (!GClass59.dictionary_1.TryGetValue(methodBase, out dynamicMethod2))
						{
							Type[] array4 = new Type[array3.Length];
							array4[0] = methodBase.DeclaringType;
							for (int l = 0; l < array.Length; l++)
							{
								array4[l + 1] = array[l];
							}
							dynamicMethod2 = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array4, typeof(GClass59).Module, true);
							ILGenerator ilgenerator = dynamicMethod2.GetILGenerator();
							//GClass59.Class333 class3;
							//ilgenerator.Emit(class3.vmethod_21() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
							for (int m = 1; m < array4.Length; m++)
							{
								ilgenerator.Emit(dictionary.ContainsKey(m - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, m);
							}
							ilgenerator.Emit(OpCodes.Call, methodInfo);
							ilgenerator.Emit(OpCodes.Ret);
							GClass59.dictionary_1.Add(methodBase, dynamicMethod2);
						}
					}
					object_ = dynamicMethod2.Invoke(null, bindingFlags, null, array3, null);
					foreach (KeyValuePair<int, GClass59.Class333> keyValuePair in dictionary)
					{
						keyValuePair.Value.vmethod_10(array3[keyValuePair.Key + 1]);
					}
					dictionary.Clear();
				}
				else
				{
					object_ = methodBase.Invoke(obj2, bindingFlags, null, array2, null);
				}
			}
			foreach (KeyValuePair<int, GClass59.Class333> keyValuePair2 in dictionary)
			{
				keyValuePair2.Value.vmethod_10(array2[keyValuePair2.Key]);
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class368_0.method_5(this.method_24(object_, methodInfo.ReturnType));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x00233398 File Offset: 0x00231598
	private Type method_50(int int_0)
	{
		Dictionary<int, object> obj = GClass59.dictionary_0;
		Type result;
		lock (obj)
		{
			object obj2;
			if (GClass59.dictionary_0.TryGetValue(int_0, out obj2))
			{
				result = (Type)obj2;
			}
			else
			{
				Type type = GClass59.module_0.ResolveType(int_0);
				GClass59.dictionary_0.Add(int_0, type);
				result = type;
			}
		}
		return result;
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x0023340C File Offset: 0x0023160C
	private void method_51()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		GClass59.Class333 object_ = this.class368_0.method_3();
		@class.vmethod_10(this.method_24(object_, @class.vmethod_8()).vmethod_12());
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x0023344C File Offset: 0x0023164C
	private void method_52()
	{
		short int_ = this.class369_0.method_2();
		GClass59.Class333 @class = this.class368_0.method_4((int)int_);
		this.class368_0.method_5(@class.vmethod_24());
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x00233484 File Offset: 0x00231684
	private void method_53()
	{
		GClass59.Class333 class333_ = this.class368_0.method_3();
		GClass59.Class333 @class = this.class368_0.method_3();
		bool bool_ = (this.class369_0.method_8() & 2) > 0;
		TypeCode typeCode = @class.vmethod_2();
		if (typeCode == TypeCode.Int32)
		{
			this.class368_0.method_5(GClass59.Class335.smethod_7(@class, class333_, bool_));
			return;
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		this.class368_0.method_5(GClass59.Class336.smethod_7(@class, class333_, bool_));
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x002334F8 File Offset: 0x002316F8
	private void method_54()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		this.class368_0.method_5(this.method_24(@class, @class.vmethod_8()));
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x0023352C File Offset: 0x0023172C
	private void method_55()
	{
		this.class368_0.method_5(new GClass59.Class337(this.class369_0.method_7()));
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x00233554 File Offset: 0x00231754
	private void method_56()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		GClass59.Class333 object_ = this.class368_0.method_3();
		GClass59.Class333 @class = this.class368_0.method_3();
		Array array = this.class368_0.method_3().vmethod_12() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		array.SetValue(this.method_24(this.method_24(object_, type_), array.GetType().GetElementType()).vmethod_12(), @class.vmethod_22());
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x002335D8 File Offset: 0x002317D8
	private void method_57()
	{
		Array array = this.class368_0.method_3().vmethod_12() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.class368_0.method_5(new GClass59.Class335(array.Length));
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x0023361C File Offset: 0x0023181C
	private void method_58()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(this.method_24(this.class368_0.method_3().vmethod_12(), type_));
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00233660 File Offset: 0x00231860
	private void method_59()
	{
		GClass59.Class333 class333_;
		GClass59.Class333 class333_2;
		TypeCode typeCode;
		do
		{
			class333_ = this.class368_0.method_3();
			class333_2 = this.class368_0.method_3();
			typeCode = this.method_67(class333_2, class333_);
			if (typeCode == TypeCode.Int32)
			{
				goto IL_31;
			}
		}
		while (typeCode == TypeCode.Int64);
		throw new InvalidOperationException();
	IL_31:
		this.class368_0.method_5(GClass59.Class335.smethod_2(class333_2, class333_));
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x002336B0 File Offset: 0x002318B0
	private void method_60()
	{
		MethodBase methodBase = this.method_65(this.class369_0.method_0());
		Type type = this.class368_0.method_3().vmethod_12().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while (type != null && type != declaringType)
		{
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase = method;
				break;
			}
			type = type.BaseType;
		}
		this.class368_0.method_5(new GClass59.Class352(methodBase));
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x0023378C File Offset: 0x0023198C
	private void method_61()
	{
		Type type;
		object obj;
		for (; ; )
		{
			type = this.method_50(this.class369_0.method_0());
			obj = this.class368_0.method_3().vmethod_12();
			if (obj == null)
			{
				goto Block_3;
			}
			if (!type.IsValueType)
			{
				switch (Type.GetTypeCode(type))
				{
					case TypeCode.Boolean:
						goto IL_A6;
					case TypeCode.Char:
						goto IL_BD;
					case TypeCode.SByte:
						goto IL_D4;
					case TypeCode.Byte:
						goto IL_EB;
					case TypeCode.Int16:
						goto IL_102;
					case TypeCode.UInt16:
						goto IL_119;
					case TypeCode.Int32:
						goto IL_130;
					case TypeCode.UInt32:
						goto IL_147;
					case TypeCode.Int64:
						goto IL_15E;
					case TypeCode.UInt64:
						goto IL_175;
					case TypeCode.Single:
						goto IL_18C;
					case TypeCode.Double:
						continue;
				}
				break;
			}
			goto IL_78;
		}
		throw new InvalidCastException();
	Block_3:
		throw new NullReferenceException();
	IL_78:
		if (type != obj.GetType())
		{
			throw new InvalidCastException();
		}
		this.class368_0.method_5(this.method_24(obj, type));
		return;
	IL_A6:
		this.class368_0.method_5(new GClass59.Class358((bool)obj));
		return;
	IL_BD:
		this.class368_0.method_5(new GClass59.Class359((char)obj));
		return;
	IL_D4:
		this.class368_0.method_5(new GClass59.Class361((sbyte)obj));
		return;
	IL_EB:
		this.class368_0.method_5(new GClass59.Class360((byte)obj));
		return;
	IL_102:
		this.class368_0.method_5(new GClass59.Class356((short)obj));
		return;
	IL_119:
		this.class368_0.method_5(new GClass59.Class357((ushort)obj));
		return;
	IL_130:
		this.class368_0.method_5(new GClass59.Class335((int)obj));
		return;
	IL_147:
		this.class368_0.method_5(new GClass59.Class362((uint)obj));
		return;
	IL_15E:
		this.class368_0.method_5(new GClass59.Class336((long)obj));
		return;
	IL_175:
		this.class368_0.method_5(new GClass59.Class363((ulong)obj));
		return;
	IL_18C:
		this.class368_0.method_5(new GClass59.Class337((float)obj));
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x0023393C File Offset: 0x00231B3C
	private void method_62()
	{
		byte byte_ = this.class369_0.method_8();
		int int_ = this.class369_0.method_0();
		int int_2 = this.class369_0.method_0();
		int int_3 = this.class369_0.method_0();
		int int_4 = this.class369_0.method_0();
		this.class367_0.method_3(int_, int_2, byte_, int_3, int_4);
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x0023399C File Offset: 0x00231B9C
	private void method_63()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		TypeCode typeCode = @class.vmethod_2();
		if (typeCode == TypeCode.Int32)
		{
			this.class368_0.method_5(GClass59.Class335.smethod_0(@class));
			return;
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		this.class368_0.method_5(GClass59.Class336.smethod_8(@class));
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x002339F0 File Offset: 0x00231BF0
	private void method_64()
	{
		Type type = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		if (!@class.vmethod_21())
		{
			//@class = new GClass59.Class349((@class.vmethod_12() is Pointer) ? new IntPtr(Pointer.Unbox(@class.vmethod_12())) : @class.vmethod_19(), type);
		}
		this.class368_0.method_5(this.method_24(@class, type));
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x00233A64 File Offset: 0x00231C64
	private MethodBase method_65(int int_0)
	{
		Dictionary<int, object> obj = GClass59.dictionary_0;
		MethodBase result;
		lock (obj)
		{
			object obj2;
			if (GClass59.dictionary_0.TryGetValue(int_0, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else
			{
				MethodBase methodBase = GClass59.module_0.ResolveMethod(int_0);
				GClass59.dictionary_0.Add(int_0, methodBase);
				result = methodBase;
			}
		}
		return result;
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x00233AD4 File Offset: 0x00231CD4
	private void method_66()
	{
		Type type_ = this.method_50(this.class369_0.method_0());
		GClass59.Class333 @class = this.class368_0.method_3();
		if (!this.method_13(@class.vmethod_12(), type_))
		{
			throw new InvalidCastException();
		}
		this.class368_0.method_5(@class);
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x00233B20 File Offset: 0x00231D20
	private TypeCode method_67(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
	{
		TypeCode typeCode;
		TypeCode typeCode2;
		for (; ; )
		{
			typeCode = class333_0.vmethod_2();
			typeCode2 = class333_1.vmethod_2();
			if (typeCode == TypeCode.Empty || typeCode2 == TypeCode.Empty)
			{
				return TypeCode.Empty;
			}
			if (typeCode == (TypeCode)10517909)
			{
				break;
			}
			if (typeCode2 == (TypeCode)(-26639))
			{
				break;
			}
			if (typeCode == (TypeCode)3119642)
			{
				goto Block_4;
			}
			if (typeCode2 == (TypeCode)(-1870659574))
			{
				goto Block_5;
			}
		}
		return TypeCode.Object;
	Block_4:
		if (typeCode2 != (TypeCode)3119641 && typeCode2 != TypeCode.UInt32)
		{
			return TypeCode.Empty;
		}
		return typeCode;
	Block_5:
		if (typeCode != (TypeCode)(-276824055) && typeCode != (TypeCode)1904214026)
		{
			return (TypeCode)(-243269632);
		}
		return typeCode2;
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x00233B94 File Offset: 0x00231D94
	private void method_68()
	{
		if (this.exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw this.exception_0;
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00233BB8 File Offset: 0x00231DB8
	private void method_69()
	{
		if (this.class368_0.method_3().vmethod_22() != 0)
		{
			this.class367_0.method_1();
			this.class368_0.method_5(new GClass59.Class340(this.exception_0));
			this.class369_0.vmethod_0(this.class364_0.method_2());
			this.class364_0 = null;
			return;
		}
		this.method_23();
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00233C20 File Offset: 0x00231E20
	private void method_70()
	{
		Type elementType = this.method_50(this.class369_0.method_0());
		this.class368_0.method_5(new GClass59.Class343(Array.CreateInstance(elementType, this.class368_0.method_3().vmethod_22())));
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00233C68 File Offset: 0x00231E68
	private void method_71()
	{
		GClass59.Class333 @class = this.class368_0.method_3();
		switch (@class.vmethod_2())
		{
			case TypeCode.Int32:
				this.class368_0.method_5(GClass59.Class335.smethod_9(@class));
				return;
			case TypeCode.Int64:
				this.class368_0.method_5(GClass59.Class336.smethod_5(@class));
				return;
			case TypeCode.Single:
				return;
			case TypeCode.Double:
				this.class368_0.method_5(GClass59.Class338.smethod_4(@class));
				return;
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00233CE8 File Offset: 0x00231EE8
	private void method_72()
	{
		MethodBase methodBase = this.method_65(this.class369_0.method_0());
		ParameterInfo[] parameters = methodBase.GetParameters();
		Dictionary<int, GClass59.Class333> dictionary = new Dictionary<int, GClass59.Class333>();
		object[] array = new object[parameters.Length];
		GClass59.Class332 @class = new GClass59.Class332();
		try
		{
			for (; ; )
			{
			IL_32:
				for (int i = parameters.Length - 1; i >= 0; i--)
				{
					Type parameterType = parameters[i].ParameterType;
					GClass59.Class333 class2 = this.class368_0.method_3();
					if (class2.vmethod_21())
					{
						if (parameterType.IsByRef)
						{
							goto IL_32;
						}
						array[i] = @class.method_0(class2.vmethod_12());
					}
					else
					{
						array[i] = this.method_24(class2, parameterType).vmethod_12();
					}
				}
				break;
			}
			object object_ = ((ConstructorInfo)methodBase).Invoke(array);
			foreach (KeyValuePair<int, GClass59.Class333> keyValuePair in dictionary)
			{
				keyValuePair.Value.vmethod_10(array[keyValuePair.Key]);
			}
			this.class368_0.method_5(this.method_24(object_, methodBase.DeclaringType));
		}
		finally
		{
			@class.Dispose();
		}
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x00233E1C File Offset: 0x0023201C
	public GClass59()
	{
		this.class369_0 = new GClass59.Class369();
		this.class368_0 = new GClass59.Class368();
		this.class367_0 = new GClass59.Class367();
		this.list_0 = new List<IntPtr>();
		this.dictionary_2[0U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[1U] = new GClass59.Delegate3(this.method_0);
		this.dictionary_2[2U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[3U] = new GClass59.Delegate3(this.method_9);
		this.dictionary_2[4U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[5U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[6U] = new GClass59.Delegate3(this.method_12);
		this.dictionary_2[7U] = new GClass59.Delegate3(this.method_15);
		this.dictionary_2[8U] = new GClass59.Delegate3(this.method_70);
		this.dictionary_2[9U] = new GClass59.Delegate3(this.method_35);
		this.dictionary_2[10U] = new GClass59.Delegate3(this.method_28);
		this.dictionary_2[11U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[12U] = new GClass59.Delegate3(this.method_14);
		this.dictionary_2[13U] = new GClass59.Delegate3(this.method_60);
		this.dictionary_2[14U] = new GClass59.Delegate3(this.method_1);
		this.dictionary_2[15U] = new GClass59.Delegate3(this.method_5);
		this.dictionary_2[16U] = new GClass59.Delegate3(this.method_33);
		this.dictionary_2[17U] = new GClass59.Delegate3(this.method_29);
		this.dictionary_2[18U] = new GClass59.Delegate3(this.method_46);
		this.dictionary_2[19U] = new GClass59.Delegate3(this.method_17);
		this.dictionary_2[20U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[21U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[22U] = new GClass59.Delegate3(this.method_58);
		this.dictionary_2[23U] = new GClass59.Delegate3(this.method_64);
		this.dictionary_2[24U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[25U] = new GClass59.Delegate3(this.method_19);
		this.dictionary_2[26U] = new GClass59.Delegate3(this.method_40);
		this.dictionary_2[27U] = new GClass59.Delegate3(this.method_37);
		this.dictionary_2[28U] = new GClass59.Delegate3(this.method_54);
		this.dictionary_2[29U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[30U] = new GClass59.Delegate3(this.method_52);
		this.dictionary_2[31U] = new GClass59.Delegate3(this.method_22);
		this.dictionary_2[32U] = new GClass59.Delegate3(this.method_6);
		this.dictionary_2[33U] = new GClass59.Delegate3(this.method_48);
		this.dictionary_2[34U] = new GClass59.Delegate3(this.method_30);
		this.dictionary_2[35U] = new GClass59.Delegate3(this.method_69);
		this.dictionary_2[36U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[37U] = new GClass59.Delegate3(this.method_39);
		this.dictionary_2[38U] = new GClass59.Delegate3(this.method_71);
		this.dictionary_2[39U] = new GClass59.Delegate3(this.method_51);
		this.dictionary_2[40U] = new GClass59.Delegate3(this.method_34);
		this.dictionary_2[41U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[42U] = new GClass59.Delegate3(this.method_49);
		this.dictionary_2[43U] = new GClass59.Delegate3(this.method_68);
		this.dictionary_2[44U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[45U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[46U] = new GClass59.Delegate3(this.method_32);
		this.dictionary_2[47U] = new GClass59.Delegate3(this.method_27);
		this.dictionary_2[48U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[49U] = new GClass59.Delegate3(this.method_36);
		this.dictionary_2[50U] = new GClass59.Delegate3(this.method_38);
		this.dictionary_2[51U] = new GClass59.Delegate3(this.method_57);
		this.dictionary_2[52U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[53U] = new GClass59.Delegate3(this.method_63);
		this.dictionary_2[54U] = new GClass59.Delegate3(this.method_44);
		this.dictionary_2[55U] = new GClass59.Delegate3(this.method_20);
		this.dictionary_2[56U] = new GClass59.Delegate3(this.method_21);
		this.dictionary_2[57U] = new GClass59.Delegate3(this.method_66);
		this.dictionary_2[58U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[59U] = new GClass59.Delegate3(this.method_4);
		this.dictionary_2[60U] = new GClass59.Delegate3(this.method_72);
		this.dictionary_2[61U] = new GClass59.Delegate3(this.method_7);
		this.dictionary_2[62U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[63U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[64U] = new GClass59.Delegate3(this.method_27);
		this.dictionary_2[65U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[66U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[67U] = new GClass59.Delegate3(this.method_0);
		this.dictionary_2[68U] = new GClass59.Delegate3(this.method_66);
		this.dictionary_2[69U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[70U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[71U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[72U] = new GClass59.Delegate3(this.method_60);
		this.dictionary_2[73U] = new GClass59.Delegate3(this.method_15);
		this.dictionary_2[74U] = new GClass59.Delegate3(this.method_69);
		this.dictionary_2[75U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[76U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[77U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[78U] = new GClass59.Delegate3(this.method_1);
		this.dictionary_2[79U] = new GClass59.Delegate3(this.method_37);
		this.dictionary_2[80U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[81U] = new GClass59.Delegate3(this.method_46);
		this.dictionary_2[82U] = new GClass59.Delegate3(this.method_0);
		this.dictionary_2[83U] = new GClass59.Delegate3(this.method_40);
		this.dictionary_2[84U] = new GClass59.Delegate3(this.method_36);
		this.dictionary_2[85U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[86U] = new GClass59.Delegate3(this.method_29);
		this.dictionary_2[87U] = new GClass59.Delegate3(this.method_19);
		this.dictionary_2[88U] = new GClass59.Delegate3(this.method_14);
		this.dictionary_2[89U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[90U] = new GClass59.Delegate3(this.method_64);
		this.dictionary_2[91U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[92U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[93U] = new GClass59.Delegate3(this.method_32);
		this.dictionary_2[94U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[95U] = new GClass59.Delegate3(this.method_32);
		this.dictionary_2[96U] = new GClass59.Delegate3(this.method_48);
		this.dictionary_2[97U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[98U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[99U] = new GClass59.Delegate3(this.method_52);
		this.dictionary_2[100U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[101U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[102U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[103U] = new GClass59.Delegate3(this.method_51);
		this.dictionary_2[104U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[105U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[106U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[107U] = new GClass59.Delegate3(this.method_60);
		this.dictionary_2[108U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[109U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[110U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[111U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[112U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[113U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[114U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[115U] = new GClass59.Delegate3(this.method_66);
		this.dictionary_2[116U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[117U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[118U] = new GClass59.Delegate3(this.method_64);
		this.dictionary_2[119U] = new GClass59.Delegate3(this.method_46);
		this.dictionary_2[120U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[121U] = new GClass59.Delegate3(this.method_6);
		this.dictionary_2[122U] = new GClass59.Delegate3(this.method_38);
		this.dictionary_2[123U] = new GClass59.Delegate3(this.method_64);
		this.dictionary_2[124U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[125U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[126U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[127U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[128U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[129U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[130U] = new GClass59.Delegate3(this.method_48);
		this.dictionary_2[131U] = new GClass59.Delegate3(this.method_30);
		this.dictionary_2[132U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[133U] = new GClass59.Delegate3(this.method_36);
		this.dictionary_2[134U] = new GClass59.Delegate3(this.method_70);
		this.dictionary_2[135U] = new GClass59.Delegate3(this.method_72);
		this.dictionary_2[136U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[137U] = new GClass59.Delegate3(this.method_58);
		this.dictionary_2[138U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[139U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[140U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[141U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[142U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[143U] = new GClass59.Delegate3(this.method_52);
		this.dictionary_2[144U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[145U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[146U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[147U] = new GClass59.Delegate3(this.method_51);
		this.dictionary_2[148U] = new GClass59.Delegate3(this.method_46);
		this.dictionary_2[149U] = new GClass59.Delegate3(this.method_48);
		this.dictionary_2[150U] = new GClass59.Delegate3(this.method_22);
		this.dictionary_2[151U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[152U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[153U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[154U] = new GClass59.Delegate3(this.method_30);
		this.dictionary_2[155U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[156U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[157U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[158U] = new GClass59.Delegate3(this.method_5);
		this.dictionary_2[159U] = new GClass59.Delegate3(this.method_30);
		this.dictionary_2[160U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[161U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[162U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[163U] = new GClass59.Delegate3(this.method_52);
		this.dictionary_2[164U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[165U] = new GClass59.Delegate3(this.method_22);
		this.dictionary_2[166U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[167U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[168U] = new GClass59.Delegate3(this.method_40);
		this.dictionary_2[169U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[170U] = new GClass59.Delegate3(this.method_27);
		this.dictionary_2[171U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[172U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[173U] = new GClass59.Delegate3(this.method_54);
		this.dictionary_2[174U] = new GClass59.Delegate3(this.method_64);
		this.dictionary_2[175U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[176U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[177U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[178U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[179U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[180U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[181U] = new GClass59.Delegate3(this.method_14);
		this.dictionary_2[182U] = new GClass59.Delegate3(this.method_69);
		this.dictionary_2[183U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[184U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[185U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[186U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[187U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[188U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[189U] = new GClass59.Delegate3(this.method_35);
		this.dictionary_2[190U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[191U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[192U] = new GClass59.Delegate3(this.method_71);
		this.dictionary_2[193U] = new GClass59.Delegate3(this.method_30);
		this.dictionary_2[194U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[195U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[196U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[197U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[198U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[199U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[200U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[201U] = new GClass59.Delegate3(this.method_54);
		this.dictionary_2[202U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[203U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[204U] = new GClass59.Delegate3(this.method_56);
		this.dictionary_2[205U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[206U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[207U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[208U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[209U] = new GClass59.Delegate3(this.method_55);
		this.dictionary_2[210U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[211U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[212U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[213U] = new GClass59.Delegate3(this.method_41);
		this.dictionary_2[214U] = new GClass59.Delegate3(this.method_53);
		this.dictionary_2[215U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[216U] = new GClass59.Delegate3(this.method_3);
		this.dictionary_2[217U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[218U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[219U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[220U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[221U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[222U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[223U] = new GClass59.Delegate3(this.method_43);
		this.dictionary_2[224U] = new GClass59.Delegate3(this.method_70);
		this.dictionary_2[225U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[226U] = new GClass59.Delegate3(this.method_40);
		this.dictionary_2[227U] = new GClass59.Delegate3(this.method_26);
		this.dictionary_2[228U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[229U] = new GClass59.Delegate3(this.method_10);
		this.dictionary_2[230U] = new GClass59.Delegate3(this.method_70);
		this.dictionary_2[231U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[232U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[233U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[234U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[235U] = new GClass59.Delegate3(this.method_29);
		this.dictionary_2[236U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[237U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[238U] = new GClass59.Delegate3(this.method_36);
		this.dictionary_2[239U] = new GClass59.Delegate3(this.method_2);
		this.dictionary_2[240U] = new GClass59.Delegate3(this.method_61);
		this.dictionary_2[241U] = new GClass59.Delegate3(this.method_31);
		this.dictionary_2[242U] = new GClass59.Delegate3(this.method_16);
		this.dictionary_2[243U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[244U] = new GClass59.Delegate3(this.method_6);
		this.dictionary_2[245U] = new GClass59.Delegate3(this.method_28);
		this.dictionary_2[246U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[247U] = new GClass59.Delegate3(this.method_54);
		this.dictionary_2[248U] = new GClass59.Delegate3(this.method_71);
		this.dictionary_2[249U] = new GClass59.Delegate3(this.method_29);
		this.dictionary_2[250U] = new GClass59.Delegate3(this.method_62);
		this.dictionary_2[251U] = new GClass59.Delegate3(this.method_60);
		this.dictionary_2[252U] = new GClass59.Delegate3(this.method_18);
		this.dictionary_2[253U] = new GClass59.Delegate3(this.method_47);
		this.dictionary_2[254U] = new GClass59.Delegate3(this.method_59);
		this.dictionary_2[255U] = new GClass59.Delegate3(this.method_48);
	}

	// Token: 0x0400217C RID: 8572
	private static readonly Dictionary<int, object> dictionary_0;

	// Token: 0x0400217D RID: 8573
	private Exception exception_0;

	// Token: 0x0400217E RID: 8574
	private static readonly Dictionary<object, DynamicMethod> dictionary_1;

	// Token: 0x0400217F RID: 8575
	private GClass59.Class367 class367_0;

	// Token: 0x04002180 RID: 8576
	private static readonly Module module_0 = typeof(GClass59).Module;

	// Token: 0x04002181 RID: 8577
	private List<IntPtr> list_0;

	// Token: 0x04002182 RID: 8578
	private GClass59.Class368 class368_0;

	// Token: 0x04002183 RID: 8579
	private GClass59.Class364 class364_0;

	// Token: 0x04002184 RID: 8580
	private GClass59.Class369 class369_0;

	// Token: 0x04002185 RID: 8581
	private readonly Dictionary<uint, GClass59.Delegate3> dictionary_2 = new Dictionary<uint, GClass59.Delegate3>();

	// Token: 0x02000A14 RID: 2580
	private static class Class329
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x002358E0 File Offset: 0x00233AE0
		public unsafe static void* smethod_0(object object_0)
		{
			return Pointer.Unbox(object_0);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x002358F4 File Offset: 0x00233AF4
		public unsafe static object smethod_1(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}
	}

	// Token: 0x02000A15 RID: 2581
	private sealed class Class330
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x00235914 File Offset: 0x00233B14
		public uint method_0()
		{
			byte b = this.byte_0[this.int_0];
			if ((b & 128) == 0)
			{
				this.int_0++;
			}
			else if (((int)b & -1174405056) == 0)
			{
				this.int_0 += -1405798230;
			}
			else
			{
				this.int_0 += 4;
			}
			return 0U;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00235978 File Offset: 0x00233B78
		public byte method_1()
		{
			byte[] array = this.byte_0;
			int num = this.int_0;
			this.int_0 = num + 1;
			return array[num];
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x002359A0 File Offset: 0x00233BA0
		public Type method_2(Module module_0)
		{
			bool flag;
			Type type;
			for (; ; )
			{
			IL_00:
				flag = false;
				for (; ; )
				{
					bool flag2 = true;
					for (; ; )
					{
						if (!flag2)
						{
							switch (this.method_0())
							{
								case 0U:
									goto IL_15D;
								case 1U:
									goto IL_07;
								case 2U:
									goto IL_165;
								case 3U:
									goto IL_176;
								case 4U:
									goto IL_187;
								case 5U:
									goto IL_11F;
								case 6U:
									goto IL_130;
								case 7U:
									goto IL_198;
								case 8U:
									goto IL_1A6;
								case 9U:
									goto IL_141;
								case 10U:
								case 13U:
									goto IL_00;
								case 11U:
									goto IL_1B4;
								case 12U:
									goto IL_1C2;
								case 14U:
									goto IL_1D0;
								case 15U:
									goto IL_1DE;
								case 17U:
								case 18U:
									goto IL_F6;
								case 24U:
									goto IL_1EE;
								case 25U:
									goto IL_FF;
								case 28U:
									goto IL_208;
								case 29U:
									goto IL_216;
							}
							goto Block_4;
						}
					IL_07:
						GClass59.Class330.Enum1 @enum = (GClass59.Class330.Enum1)this.method_1();
						if (@enum <= GClass59.Class330.Enum1.const_7)
						{
							if (@enum == GClass59.Class330.Enum1.const_27)
							{
								goto IL_152;
							}
							if (@enum - GClass59.Class330.Enum1.const_4 <= 1)
							{
								this.method_0();
								continue;
							}
						}
						else if (@enum == (GClass59.Class330.Enum1)189298457 || @enum == (GClass59.Class330.Enum1)358127293)
						{
							continue;
						}
						flag2 = false;
						this.int_0--;
					}
				IL_F6:
					this.method_0();
					continue;
				IL_FF:
					type = typeof(UIntPtr);
					
						
					
				}
			IL_11F:
				type = typeof(byte);
				continue;
			IL_130:
				type = typeof(short);
				continue;
			IL_141:
				type = typeof(uint);
			IL_152:;
			}
		Block_4:
			goto IL_1FC;
		IL_15D:
			type = null;
			goto IL_224;
		IL_165:
			type = typeof(bool);
			goto IL_224;
		IL_176:
			type = typeof(char);
			goto IL_224;
		IL_187:
			type = typeof(sbyte);
			goto IL_224;
		IL_198:
			type = typeof(ushort);
			goto IL_224;
		IL_1A6:
			type = typeof(int);
			goto IL_224;
		IL_1B4:
			type = typeof(ulong);
			goto IL_224;
		IL_1C2:
			type = typeof(float);
			goto IL_224;
		IL_1D0:
			type = typeof(string);
			goto IL_224;
		IL_1DE:
			type = this.method_2(module_0).MakePointerType();
			goto IL_224;
		IL_1EE:
			type = typeof(IntPtr);
			goto IL_224;
		IL_1FC:
			throw new COMException(null, -2146233785);
		IL_208:
			type = typeof(object);
			goto IL_224;
		IL_216:
			type = this.method_2(module_0).MakeArrayType();
		IL_224:
			if (flag)
			{
				type = type.MakeByRefType();
			}
			return type;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00235BE0 File Offset: 0x00233DE0
		public Class330(byte[] byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x04002186 RID: 8582
		private int int_0;

		// Token: 0x04002187 RID: 8583
		private byte[] byte_0;

		// Token: 0x02000A16 RID: 2582
		private enum Enum1
		{
			// Token: 0x04002188 RID: 8584
			const_0 = 27,
			// Token: 0x04002189 RID: 8585
			const_1 = 5,
			// Token: 0x0400218A RID: 8586
			const_2 = 2,
			// Token: 0x0400218B RID: 8587
			const_3 = 24,
			// Token: 0x0400218C RID: 8588
			const_4 = 31,
			// Token: 0x0400218D RID: 8589
			const_5 = 20,
			// Token: 0x0400218E RID: 8590
			const_6 = 1,
			// Token: 0x0400218F RID: 8591
			const_7 = 32,
			// Token: 0x04002190 RID: 8592
			const_8 = 11,
			// Token: 0x04002191 RID: 8593
			const_9,
			// Token: 0x04002192 RID: 8594
			const_10 = 26,
			// Token: 0x04002193 RID: 8595
			const_11 = 0,
			// Token: 0x04002194 RID: 8596
			const_12 = 69,
			// Token: 0x04002195 RID: 8597
			const_13 = 19,
			// Token: 0x04002196 RID: 8598
			const_14 = 14,
			// Token: 0x04002197 RID: 8599
			const_15 = 29,
			// Token: 0x04002198 RID: 8600
			const_16 = 8,
			// Token: 0x04002199 RID: 8601
			const_17 = 10,
			// Token: 0x0400219A RID: 8602
			const_18 = 9,
			// Token: 0x0400219B RID: 8603
			const_19 = 6,
			// Token: 0x0400219C RID: 8604
			const_20 = 21,
			// Token: 0x0400219D RID: 8605
			const_21 = 28,
			// Token: 0x0400219E RID: 8606
			const_22 = 22,
			// Token: 0x0400219F RID: 8607
			const_23 = 3,
			// Token: 0x040021A0 RID: 8608
			const_24,
			// Token: 0x040021A1 RID: 8609
			const_25 = 65,
			// Token: 0x040021A2 RID: 8610
			const_26 = 30,
			// Token: 0x040021A3 RID: 8611
			const_27 = 16,
			// Token: 0x040021A4 RID: 8612
			const_28,
			// Token: 0x040021A5 RID: 8613
			const_29 = 15,
			// Token: 0x040021A6 RID: 8614
			const_30 = 23,
			// Token: 0x040021A7 RID: 8615
			const_31 = 18,
			// Token: 0x040021A8 RID: 8616
			const_32 = 13,
			// Token: 0x040021A9 RID: 8617
			const_33 = 7,
			// Token: 0x040021AA RID: 8618
			const_34 = 25
		}
	}

	// Token: 0x02000A17 RID: 2583
	private enum Enum2
	{
		// Token: 0x040021AC RID: 8620
		const_0 = 64,
		// Token: 0x040021AD RID: 8621
		const_1 = 8,
		// Token: 0x040021AE RID: 8622
		const_2,
		// Token: 0x040021AF RID: 8623
		const_3 = 3,
		// Token: 0x040021B0 RID: 8624
		const_4 = 15,
		// Token: 0x040021B1 RID: 8625
		const_5 = 11,
		// Token: 0x040021B2 RID: 8626
		const_6 = 4,
		// Token: 0x040021B3 RID: 8627
		const_7,
		// Token: 0x040021B4 RID: 8628
		const_8,
		// Token: 0x040021B5 RID: 8629
		const_9 = 2,
		// Token: 0x040021B6 RID: 8630
		const_10 = 0,
		// Token: 0x040021B7 RID: 8631
		const_11 = 16,
		// Token: 0x040021B8 RID: 8632
		const_12 = 10,
		// Token: 0x040021B9 RID: 8633
		const_13 = 7,
		// Token: 0x040021BA RID: 8634
		const_14 = 1,
		// Token: 0x040021BB RID: 8635
		const_15 = 32
	}

	// Token: 0x02000A18 RID: 2584
	private sealed class Class331
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00235C10 File Offset: 0x00233E10
		public void method_0(byte[] byte_0, Module module_0)
		{
			GClass59.Class330 @class = new GClass59.Class330(byte_0);
			this.enum2_0 = (GClass59.Enum2)@class.method_1();
			if ((this.enum2_0 & GClass59.Enum2.const_11) != GClass59.Enum2.const_10)
			{
				this.uint_0 = @class.method_0();
			}
			switch (this.enum2_0 & GClass59.Enum2.const_4)
			{
				case GClass59.Enum2.const_10:
				case GClass59.Enum2.const_14:
				case GClass59.Enum2.const_9:
				case GClass59.Enum2.const_3:
				case GClass59.Enum2.const_6:
				case GClass59.Enum2.const_7:
				case GClass59.Enum2.const_1:
				case GClass59.Enum2.const_2:
				case GClass59.Enum2.const_5:
					{
						uint num = @class.method_0();
						this.type_1 = @class.method_2(module_0);
						this.type_0 = new Type[num];
						int num2 = 0;
						while ((long)num2 < (long)((ulong)num))
						{
							this.type_0[num2] = @class.method_2(module_0);
							num2++;
						}
						return;
					}
				case GClass59.Enum2.const_8:
					this.type_1 = @class.method_2(module_0);
					return;
				case GClass59.Enum2.const_13:
				case GClass59.Enum2.const_12:
					{
						uint num3 = @class.method_0();
						this.type_0 = new Type[num3];
						int num4 = 0;
						while ((long)num4 < (long)((ulong)num3))
						{
							this.type_0[num4] = @class.method_2(module_0);
							num4++;
						}
						return;
					}
				default:
					throw new COMException(null, -2146233799);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00235D20 File Offset: 0x00233F20
		public Type Type_0
		{
			get
			{
				return this.type_1;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00235D34 File Offset: 0x00233F34
		public bool Boolean_0
		{
			get
			{
				switch (this.enum2_0 & GClass59.Enum2.const_4)
				{
					case GClass59.Enum2.const_10:
					case GClass59.Enum2.const_14:
					case GClass59.Enum2.const_9:
					case GClass59.Enum2.const_3:
					case GClass59.Enum2.const_6:
					case GClass59.Enum2.const_7:
					case GClass59.Enum2.const_2:
					case GClass59.Enum2.const_5:
						return true;
					default:
						return false;
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00235D84 File Offset: 0x00233F84
		public CallingConvention CallingConvention_0
		{
			get
			{
				switch (this.enum2_0 & GClass59.Enum2.const_4)
				{
					case GClass59.Enum2.const_14:
						return (CallingConvention)1732859227;
					case GClass59.Enum2.const_9:
						return (CallingConvention)573858877;
					case GClass59.Enum2.const_3:
						return (CallingConvention)1476395012;
					case GClass59.Enum2.const_6:
						return (CallingConvention)1476395012;
					default:
						return CallingConvention.Winapi;
				}
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00235DCC File Offset: 0x00233FCC
		public Type[] method_1()
		{
			return this.type_0;
		}

		// Token: 0x040021BD RID: 8637
		private Type[] type_0;

		// Token: 0x040021BE RID: 8638
		private Type type_1;

		// Token: 0x040021BF RID: 8639
		private uint uint_0;

		// Token: 0x040021C0 RID: 8640
		private GClass59.Enum2 enum2_0;
	}

	// Token: 0x02000A19 RID: 2585
	private sealed class Class332 : IDisposable
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x00235DE0 File Offset: 0x00233FE0
		public void Dispose()
		{
			foreach (GCHandle gchandle in this.list_0)
			{
				gchandle.Free();
			}
			this.list_0.Clear();
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00235E60 File Offset: 0x00234060
		public IntPtr method_0(object object_0)
		{
			GCHandle item = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			this.list_0.Add(item);
			return item.AddrOfPinnedObject();
		}

		// Token: 0x040021C1 RID: 8641
		private List<GCHandle> list_0 = new List<GCHandle>();
	}

	// Token: 0x02000A1A RID: 2586
	private abstract class Class333
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x00235E88 File Offset: 0x00234088
		public unsafe virtual void* vmethod_0()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00235E9C File Offset: 0x0023409C
		public virtual byte vmethod_1()
		{
			return Convert.ToByte(this.vmethod_12());
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00235E88 File Offset: 0x00234088
		public virtual TypeCode vmethod_2()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00235EB4 File Offset: 0x002340B4
		public virtual char vmethod_3()
		{
			return Convert.ToChar(this.vmethod_12());
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00235ECC File Offset: 0x002340CC
		public virtual ulong vmethod_4()
		{
			return Convert.ToUInt64(this.vmethod_12());
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00235EE4 File Offset: 0x002340E4
		public override string ToString()
		{
			object obj = this.vmethod_12();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00235E88 File Offset: 0x00234088
		public virtual object vmethod_5(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00235F04 File Offset: 0x00234104
		public virtual double vmethod_6()
		{
			return Convert.ToDouble(this.vmethod_12());
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00235F1C File Offset: 0x0023411C
		public virtual ushort vmethod_7()
		{
			return Convert.ToUInt16(this.vmethod_12());
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00235E88 File Offset: 0x00234088
		public virtual Type vmethod_8()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00235F34 File Offset: 0x00234134
		public virtual GClass59.Class333 vmethod_9()
		{
			return this;
		}

		// Token: 0x0600174C RID: 5964
		public abstract void vmethod_10(object object_0);

		// Token: 0x0600174D RID: 5965 RVA: 0x00235F44 File Offset: 0x00234144
		public virtual long vmethod_11()
		{
			return Convert.ToInt64(this.vmethod_12());
		}

		// Token: 0x0600174E RID: 5966
		public abstract object vmethod_12();

		// Token: 0x0600174F RID: 5967 RVA: 0x00235F5C File Offset: 0x0023415C
		public virtual float vmethod_13()
		{
			return Convert.ToSingle(this.vmethod_12());
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00235F74 File Offset: 0x00234174
		public virtual short vmethod_14()
		{
			return Convert.ToInt16(this.vmethod_12());
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00235F8C File Offset: 0x0023418C
		public virtual bool vmethod_15()
		{
			return Convert.ToBoolean(this.vmethod_12());
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00235E88 File Offset: 0x00234088
		public virtual GClass59.Class334 vmethod_16()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00235FA4 File Offset: 0x002341A4
		public virtual sbyte vmethod_17()
		{
			return Convert.ToSByte(this.vmethod_12());
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00235FBC File Offset: 0x002341BC
		public virtual uint vmethod_18()
		{
			return Convert.ToUInt32(this.vmethod_12());
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00235FD4 File Offset: 0x002341D4
		public virtual IntPtr vmethod_19()
		{
			object obj;
			do
			{
				obj = this.vmethod_12();
			}
			while (obj != null);
			if (!(null == typeof(IntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (IntPtr)obj;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0023600C File Offset: 0x0023420C
		public virtual void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = this.vmethod_12();
			fieldInfo_0.SetValue(obj, object_0);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00236028 File Offset: 0x00234228
		public virtual bool vmethod_21()
		{
			return false;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00236038 File Offset: 0x00234238
		public virtual int vmethod_22()
		{
			return Convert.ToInt32(this.vmethod_12());
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00236050 File Offset: 0x00234250
		public virtual UIntPtr vmethod_23()
		{
			object obj = this.vmethod_12();
			if (!(((obj != null) ? obj.GetType() : null) == typeof(UIntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		// Token: 0x0600175B RID: 5979
		public abstract GClass59.Class333 vmethod_24();
	}

	// Token: 0x02000A1B RID: 2587
	private abstract class Class334 : GClass59.Class333
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x00236028 File Offset: 0x00234228
		public override TypeCode vmethod_2()
		{
			return TypeCode.Empty;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00235F34 File Offset: 0x00234134
		public override GClass59.Class334 vmethod_16()
		{
			return this;
		}
	}

	// Token: 0x02000A1C RID: 2588
	private sealed class Class335 : GClass59.Class334
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x002360A4 File Offset: 0x002342A4
		public override void vmethod_10(object object_0)
		{
			this.int_0 = Convert.ToInt32(object_0);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x002360C0 File Offset: 0x002342C0
		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x002360D8 File Offset: 0x002342D8
		public override GClass59.Class333 vmethod_9()
		{
			return new GClass59.Class362((uint)this.int_0);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x002360F0 File Offset: 0x002342F0
		public static GClass59.Class333 smethod_0(GClass59.Class333 class333_0)
		{
			return new GClass59.Class335(~class333_0.vmethod_22());
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0023610C File Offset: 0x0023430C
		public static GClass59.Class333 smethod_1(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{

			int int_;
			if (bool_1)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				int_ = (int)(bool_0 ? checked(num + num2) : (num + num2));
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				int_ = (bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			return new Class335(int_);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00236160 File Offset: 0x00234360
		public static GClass59.Class333 smethod_2(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new GClass59.Class335(num ^ num2);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00236184 File Offset: 0x00234384
		public static GClass59.Class333 smethod_3(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			int int_;
			if (bool_0)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				if (num == num2)
				{
					int_ = 1;
				}
				else
				{
					int_ = ((num > num2) ? -1080244384 : -275476340);
				}
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				if (num3 == num4)
				{
					int_ = 1;
				}
				else
				{
					int_ = ((num3 > num4) ? -1989763008 : 545260544);
				}
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x002361F0 File Offset: 0x002343F0
		public override ushort vmethod_7()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00236204 File Offset: 0x00234404
		public override float vmethod_13()
		{
			return (float)this.int_0;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00236218 File Offset: 0x00234418
		public static GClass59.Class333 smethod_4(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			int int_;
			if (bool_0)
			{
				int num = (int)class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				int_ = num / (int)num2;
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				int_ = num3 / num4;
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00236250 File Offset: 0x00234450
		public override double vmethod_6()
		{
			return (double)this.int_0;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00236264 File Offset: 0x00234464
		public override byte vmethod_1()
		{
			return (byte)this.int_0;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00236278 File Offset: 0x00234478
		public override short vmethod_14()
		{
			return (short)this.int_0;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0023628C File Offset: 0x0023448C
		public override long vmethod_11()
		{
			return (long)this.int_0;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x002362A0 File Offset: 0x002344A0
		public override bool vmethod_15()
		{
			return this.int_0 != 0;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x002362B8 File Offset: 0x002344B8
		public override int vmethod_22()
		{
			return this.int_0;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x002362CC File Offset: 0x002344CC
		public static GClass59.Class333 smethod_5(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new GClass59.Class335(num << num2);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x002362F0 File Offset: 0x002344F0
		public static GClass59.Class333 smethod_6(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new GClass59.Class335(num & num2);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00236314 File Offset: 0x00234514
		public static GClass59.Class333 smethod_7(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				int num = (int)class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				return new GClass59.Class335(num % (int)num2);
			}
			int num3 = class333_0.vmethod_22();
			int num4 = class333_1.vmethod_22();
			return new GClass59.Class335(num3 % num4);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00236350 File Offset: 0x00234550
		public static GClass59.Class333 smethod_8(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new GClass59.Class335(num | num2);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00236374 File Offset: 0x00234574
		public override IntPtr vmethod_19()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0023638C File Offset: 0x0023458C
		public static GClass59.Class333 smethod_9(GClass59.Class333 class333_0)
		{
			return new GClass59.Class335(-class333_0.vmethod_22());
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x002363A8 File Offset: 0x002345A8
		public static GClass59.Class333 smethod_10(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				uint num = class333_0.vmethod_18();
				int num2 = class333_1.vmethod_22();
				return new Class335((int)(num >> num2));
			}
			int num3 = class333_0.vmethod_22();
			int num4 = class333_1.vmethod_22();
			return new Class335(num3 >> (num4 & 0x5394C89D));
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x002363EC File Offset: 0x002345EC
		public static GClass59.Class333 smethod_11(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			int int_;
			if (bool_1)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				int_ = (int)(bool_0 ? checked(num - num2) : (num - num2));
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				int_ = (bool_0 ? checked(num3 - num4) : (num3 - num4));
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0023643C File Offset: 0x0023463C
		public override sbyte vmethod_17()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00236450 File Offset: 0x00234650
		//public static GClass59.Class333 smethod_12(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		//{
		//	uint num;
		//	if (bool_1)
		//	{
		//		num = class333_0.vmethod_18();
		//	}
		//	else
		//	{
		//		class333_0.vmethod_22();
		//		class333_1.vmethod_22();
		//	}
		//	uint num2 = class333_1.vmethod_18();
		//	//int int_ = (int)(bool_0 ? checked(num * num2) : (num * num2));
		//	//return new GClass59.Class335(int_);
		//}

		// Token: 0x06001779 RID: 6009 RVA: 0x00236494 File Offset: 0x00234694
		public override Type vmethod_8()
		{
			return typeof(int);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x002364AC File Offset: 0x002346AC
		public override TypeCode vmethod_2()
		{
			return TypeCode.Int32;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x002364BC File Offset: 0x002346BC
		public override ulong vmethod_4()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x002361F0 File Offset: 0x002343F0
		public override char vmethod_3()
		{
			return (char)this.int_0;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x002362B8 File Offset: 0x002344B8
		public override uint vmethod_18()
		{
			return (uint)this.int_0;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x002364D0 File Offset: 0x002346D0
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					if (IntPtr.Size != 4)
					{
						return new IntPtr((long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0)))));
					}
				}
				else if (!(type_0 == typeof(UIntPtr)))
				{
					switch (Type.GetTypeCode(type_0))
					{
						case TypeCode.SByte:
							return bool_0 ? ((sbyte)((uint)this.int_0)) : ((sbyte)this.int_0);
						case TypeCode.Byte:
							return bool_0 ? ((byte)((uint)this.int_0)) : ((byte)this.int_0);
						case TypeCode.Int16:
							return bool_0 ? ((short)((uint)this.int_0)) : ((short)this.int_0);
						case TypeCode.UInt16:
							return bool_0 ? ((ushort)((uint)this.int_0)) : ((ushort)this.int_0);
						case TypeCode.Int32:
							return bool_0 ? ((int)((uint)this.int_0)) : this.int_0;
						case TypeCode.UInt32:
							return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
						case TypeCode.Int64:
							return (long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0))));
						case TypeCode.UInt64:
							return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
						case TypeCode.Double:
							return bool_0 ? this.int_0 : ((double)this.int_0);
					}
					throw new ArgumentException();
				}
				return new IntPtr(bool_0 ? ((int)((uint)this.int_0)) : this.int_0);
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0023666C File Offset: 0x0023486C
		public override object vmethod_12()
		{
			return this.int_0;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00236684 File Offset: 0x00234884
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class335(this.int_0);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0023669C File Offset: 0x0023489C
		public Class335(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x040021C2 RID: 8642
		private int int_0;
	}

	// Token: 0x02000A1D RID: 2589
	private sealed class Class336 : GClass59.Class334
	{
		// Token: 0x06001782 RID: 6018 RVA: 0x002366B8 File Offset: 0x002348B8
		public override ulong vmethod_4()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x002366CC File Offset: 0x002348CC
		public override void vmethod_10(object object_0)
		{
			this.long_0 = Convert.ToInt64(object_0);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x002366E8 File Offset: 0x002348E8
		public static GClass59.Class333 smethod_0(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new GClass59.Class336(num ^ num2);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0023670C File Offset: 0x0023490C
		public static GClass59.Class333 smethod_1(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			while (!bool_1)
			{
				class333_0.vmethod_11();
				class333_1.vmethod_11();
			}
			ulong num = class333_0.vmethod_4();
			ulong num2 = class333_1.vmethod_4();
			long long_ = (long)(bool_0 ? checked(num - num2) : (num - num2));
			return new GClass59.Class336(long_);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00236750 File Offset: 0x00234950
		public unsafe override void* vmethod_0()
		{
			return this.vmethod_19().ToPointer();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0023676C File Offset: 0x0023496C
		public override int vmethod_22()
		{
			return (int)this.long_0;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00236780 File Offset: 0x00234980
		public override float vmethod_13()
		{
			return (float)this.long_0;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00236794 File Offset: 0x00234994
		public override object vmethod_12()
		{
			return this.long_0;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x002367AC File Offset: 0x002349AC
		public static GClass59.Class333 smethod_2(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			long long_;
			if (bool_1)
			{
				ulong num;
				ulong num2;
				do
				{
					num = class333_0.vmethod_4();
					num2 = class333_1.vmethod_4();
				}
				while (bool_0);
				long_ = (long)(num + num2);
			}
			else
			{
				long num3 = class333_0.vmethod_11();
				long num4 = class333_1.vmethod_11();
				long_ = (bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			return new GClass59.Class336(long_);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x002367FC File Offset: 0x002349FC
		public static GClass59.Class333 smethod_3(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			int int_;
			if (bool_0)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				int_ = ((num == num2) ? 1 : ((num > num2) ? (-1080244384) : (-275476340)));
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				int_ = ((num3 == num4) ? 1 : ((num3 > num4) ? (-1989763008) : 545260544));
			}
			return new Class335(int_);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0023683C File Offset: 0x00234A3C
		public static GClass59.Class333 smethod_4(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new GClass59.Class336(num | num2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00236860 File Offset: 0x00234A60
		public static GClass59.Class333 smethod_5(GClass59.Class333 class333_0)
		{
			return new GClass59.Class336(-class333_0.vmethod_11());
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0023687C File Offset: 0x00234A7C
		public static GClass59.Class333 smethod_6(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			long long_;
			if (bool_1)
			{
				ulong num = class333_0.vmethod_4();
				ulong num2 = class333_1.vmethod_4();
				long_ = (long)(bool_0 ? checked(num * num2) : (num * num2));
			}
			else
			{
				long num3 = class333_0.vmethod_11();
				long num4 = class333_1.vmethod_11();
				long_ = (bool_0 ? checked(num3 * num4) : (num3 * num4));
			}
			return new GClass59.Class336(long_);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x002368D0 File Offset: 0x00234AD0
		public override double vmethod_6()
		{
			return (double)this.long_0;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x002368E4 File Offset: 0x00234AE4
		public static GClass59.Class333 smethod_7(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				long num = (long)class333_0.vmethod_4();
				ulong num2 = class333_1.vmethod_4();
				return new GClass59.Class336(num % (long)num2);
			}
			long num3 = class333_0.vmethod_11();
			long num4 = class333_1.vmethod_11();
			return new GClass59.Class336(num3 % num4);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00236920 File Offset: 0x00234B20
		public override short vmethod_14()
		{
			return (short)this.long_0;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00236934 File Offset: 0x00234B34
		public override byte vmethod_1()
		{
			return (byte)this.long_0;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00236948 File Offset: 0x00234B48
		public static GClass59.Class333 smethod_8(GClass59.Class333 class333_0)
		{
			return new GClass59.Class336(~class333_0.vmethod_11());
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00236964 File Offset: 0x00234B64
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				if (!(type_0 == typeof(IntPtr)))
				{
					if (!(type_0 == typeof(UIntPtr)))
					{
						switch (Type.GetTypeCode(type_0))
						{
							case TypeCode.SByte:
								return bool_0 ? ((sbyte)((ulong)this.long_0)) : ((sbyte)this.long_0);
							case TypeCode.Byte:
								return bool_0 ? ((byte)((ulong)this.long_0)) : ((byte)this.long_0);
							case TypeCode.Int16:
								return bool_0 ? ((short)((ulong)this.long_0)) : ((short)this.long_0);
							case TypeCode.UInt16:
								goto IL_C6;
							case TypeCode.Int32:
								if (!bool_0)
								{
									goto IL_C6;
								}
								return (int)((ulong)this.long_0);
							case TypeCode.UInt32:
								return bool_0 ? ((uint)((ulong)this.long_0)) : ((uint)this.long_0);
							case TypeCode.Int64:
								return bool_0 ? ((long)((ulong)this.long_0)) : this.long_0;
							case TypeCode.UInt64:
								if (!bool_0)
								{
									return (ulong)this.long_0;
								}
								goto IL_135;
							case TypeCode.Double:
								return bool_0 ? this.long_0 : ((double)this.long_0);
						}
						throw new ArgumentException();
					}
					ulong value;
					if (!bool_0)
					{
						value = (ulong)this.long_0;
						goto IL_13B;
					}
				IL_135:
					value = (ulong)this.long_0;
				IL_13B:
					return new UIntPtr(value);
				}
			IL_C6:
				return new IntPtr(bool_0 ? ((long)((ulong)this.long_0)) : this.long_0);
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00236AD8 File Offset: 0x00234CD8
		public static GClass59.Class333 smethod_9(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			int num2 = class333_1.vmethod_22();
			return new GClass59.Class336(num << num2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00236AFC File Offset: 0x00234CFC
		public override GClass59.Class333 vmethod_9()
		{
			return new GClass59.Class363((ulong)this.long_0);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00236B14 File Offset: 0x00234D14
		public override char vmethod_3()
		{
			return (char)this.long_0;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00236B28 File Offset: 0x00234D28
		public override bool vmethod_15()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00236B48 File Offset: 0x00234D48
		public override TypeCode vmethod_2()
		{
			return TypeCode.Int64;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00236B58 File Offset: 0x00234D58
		public override sbyte vmethod_17()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00236B6C File Offset: 0x00234D6C
		public static GClass59.Class333 smethod_10(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			long long_;
			if (bool_0)
			{
				long num = (long)class333_0.vmethod_4();
				ulong num2 = class333_1.vmethod_4();
				long_ = num / (long)num2;
			}
			else
			{
				long num3 = class333_0.vmethod_11();
				long num4 = class333_1.vmethod_11();
				long_ = num3 / num4;
			}
			return new GClass59.Class336(long_);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00236BA4 File Offset: 0x00234DA4
		public override uint vmethod_18()
		{
			return (uint)this.long_0;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00236B14 File Offset: 0x00234D14
		public override ushort vmethod_7()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00236BB8 File Offset: 0x00234DB8
		public override Type vmethod_8()
		{
			return typeof(long);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00236BD0 File Offset: 0x00234DD0
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class336(this.long_0);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00236BE8 File Offset: 0x00234DE8
		//public static GClass59.Class333 smethod_11(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		//{
		//	ulong num;
		//	ulong num2;
		//	if (bool_0)
		//	{
		//		num = class333_0.vmethod_4();
		//		num2 = class333_1.vmethod_4();
		//	}
		//	else
		//	{
		//		class333_0.vmethod_11();
		//	}
		//	int int_;
		//	if (num == num2)
		//	{
		//		int_ = 1;
		//	}
		//	else
		//	{
		//		int_ = ((num > num2) ? 922966503 : 8);
		//	}
		//	return new GClass59.Class335(int_);
		//}

		// Token: 0x060017A1 RID: 6049 RVA: 0x002366B8 File Offset: 0x002348B8
		public override long vmethod_11()
		{
			return this.long_0;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00236C30 File Offset: 0x00234E30
		public static GClass59.Class333 smethod_12(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new GClass59.Class336(num & num2);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00236C54 File Offset: 0x00234E54
		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.long_0)) : this.long_0);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00236C80 File Offset: 0x00234E80
		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((UIntPtr.Size == 4) ? ((ulong)((uint)this.long_0)) : ((ulong)this.long_0));
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00236CAC File Offset: 0x00234EAC
		public Class336(long long_1)
		{
			this.long_0 = long_1;
		}

		// Token: 0x040021C3 RID: 8643
		private long long_0;
	}

	// Token: 0x02000A1E RID: 2590
	private sealed class Class337 : GClass59.Class334
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x00236CC8 File Offset: 0x00234EC8
		public static GClass59.Class333 smethod_0(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new GClass59.Class337(bool_0 ? (num * num2) : (num * num2));
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00236D0C File Offset: 0x00234F0C
		public static GClass59.Class333 smethod_1(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new GClass59.Class337(bool_0 ? (num - num2) : (num - num2));
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00236D50 File Offset: 0x00234F50
		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.float_0)) : ((long)this.float_0));
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00236D7C File Offset: 0x00234F7C
		public override sbyte vmethod_17()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00236D90 File Offset: 0x00234F90
		public override uint vmethod_18()
		{
			return (uint)this.float_0;
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00236DA4 File Offset: 0x00234FA4
		public override ushort vmethod_7()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00236DB8 File Offset: 0x00234FB8
		public override byte vmethod_1()
		{
			return (byte)this.float_0;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00236DCC File Offset: 0x00234FCC
		public static GClass59.Class333 smethod_2(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			float num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			int int_;
			if (num == num2)
			{
				int_ = 1;
			}
			else
			{
				int_ = ((num > num2) ? -2050529080 : -294044691);
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00236E1C File Offset: 0x0023501C
		public override void vmethod_10(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00236E38 File Offset: 0x00235038
		public override short vmethod_14()
		{
			return (short)this.float_0;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00236E4C File Offset: 0x0023504C
		public override TypeCode vmethod_2()
		{
			return TypeCode.Single;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00236E5C File Offset: 0x0023505C
		public static GClass59.Class333 smethod_3(GClass59.Class333 class333_0)
		{
			return new GClass59.Class337(-class333_0.vmethod_13());
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00236E78 File Offset: 0x00235078
		public override int vmethod_22()
		{
			return (int)this.float_0;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00236E8C File Offset: 0x0023508C
		public override object vmethod_12()
		{
			return this.float_0;
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00236EA4 File Offset: 0x002350A4
		public override ulong vmethod_4()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00236DA4 File Offset: 0x00234FA4
		public override char vmethod_3()
		{
			return (char)this.float_0;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00236EB8 File Offset: 0x002350B8
		public static GClass59.Class333 smethod_4(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new GClass59.Class337(bool_0 ? (num + num2) : (num + num2));
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00236EFC File Offset: 0x002350FC
		public override bool vmethod_15()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00236F14 File Offset: 0x00235114
		public static GClass59.Class333 smethod_5(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			float num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new GClass59.Class337(num / num2);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00236F4C File Offset: 0x0023514C
		public override long vmethod_11()
		{
			return (long)this.float_0;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00236F60 File Offset: 0x00235160
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class337(this.float_0);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00236F78 File Offset: 0x00235178
		public override Type vmethod_8()
		{
			return typeof(float);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00236F90 File Offset: 0x00235190
		public override float vmethod_13()
		{
			return this.float_0;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00236FA4 File Offset: 0x002351A4
		public override double vmethod_6()
		{
			return (double)this.float_0;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00236FB8 File Offset: 0x002351B8
		public override UIntPtr vmethod_23()
		{
			if (IntPtr.Size != 4)
			{
			}
			return new UIntPtr((ulong)this.float_0);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00236FDC File Offset: 0x002351DC
		public override object vmethod_5(Type type_0, bool bool_0)
		{
		IL_00:
			checked
			{
				while (!(type_0 == typeof(IntPtr)))
				{
					if (type_0 == typeof(UIntPtr))
					{
						return new UIntPtr((ulong)this.float_0);
					}
					for (; ; )
					{
						switch (Type.GetTypeCode(type_0))
						{
							case TypeCode.SByte:
								goto IL_6C;
							case TypeCode.Byte:
								goto IL_86;
							case TypeCode.Int16:
								if (!bool_0)
								{
									continue;
								}
								goto IL_98;
							case TypeCode.UInt16:
								goto IL_A6;
							case TypeCode.Int32:
								goto IL_00;
							case TypeCode.UInt32:
								goto IL_B3;
							case TypeCode.UInt64:
								goto IL_C6;
						}
						break;
					}
					goto IL_C0;
				IL_6C:
					return bool_0 ? ((sbyte)((uint)this.float_0)) : ((sbyte)this.float_0);
				IL_98:
					return (short)((uint)this.float_0);
				IL_A6:
					return (ushort)this.float_0;
				IL_B3:
					return (uint)this.float_0;
				IL_C0:
					throw new ArgumentException();
				IL_C6:
					return (ulong)this.float_0;
				}
			IL_86:
				return new IntPtr((long)this.float_0);
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x002370BC File Offset: 0x002352BC
		public Class337(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x040021C4 RID: 8644
		private float float_0;
	}

	// Token: 0x02000A1F RID: 2591
	private sealed class Class338 : GClass59.Class334
	{
		// Token: 0x060017C1 RID: 6081 RVA: 0x002370D8 File Offset: 0x002352D8
		public static GClass59.Class333 smethod_0(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			double num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new GClass59.Class338(bool_0 ? (num + num2) : (num + num2));
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0023711C File Offset: 0x0023531C
		public static GClass59.Class333 smethod_1(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			double num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new GClass59.Class338(num / num2);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00237154 File Offset: 0x00235354
		public override char vmethod_3()
		{
			return (char)this.double_0;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00237168 File Offset: 0x00235368
		public override void vmethod_10(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00237184 File Offset: 0x00235384
		public override short vmethod_14()
		{
			return (short)this.double_0;
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00237198 File Offset: 0x00235398
		public override byte vmethod_1()
		{
			return (byte)this.double_0;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x002371AC File Offset: 0x002353AC
		public override object vmethod_12()
		{
			return this.double_0;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x002371C4 File Offset: 0x002353C4
		public override Type vmethod_8()
		{
			return typeof(double);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x002371DC File Offset: 0x002353DC
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.double_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.double_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
					case TypeCode.SByte:
						return bool_0 ? ((sbyte)((uint)this.double_0)) : ((sbyte)this.double_0);
					case TypeCode.Byte:
						return (byte)this.double_0;
					case TypeCode.Int16:
						return bool_0 ? ((short)((uint)this.double_0)) : ((short)this.double_0);
					case TypeCode.UInt16:
						return (ushort)this.double_0;
					case TypeCode.Int32:
						return (int)this.double_0;
					case TypeCode.UInt32:
						return (uint)this.double_0;
					case TypeCode.Int64:
						return (long)this.double_0;
					case TypeCode.UInt64:
						return (ulong)this.double_0;
					case TypeCode.Double:
						return this.double_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00237300 File Offset: 0x00235500
		public static GClass59.Class333 smethod_2(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			double num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new GClass59.Class338(bool_0 ? (num * num2) : (num * num2));
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00237344 File Offset: 0x00235544
		public override long vmethod_11()
		{
			return (long)this.double_0;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00237358 File Offset: 0x00235558
		public static GClass59.Class333 smethod_3(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0)
		{
			double num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			int int_;
			if (num == num2)
			{
				int_ = 1;
			}
			else
			{
				int_ = ((num > num2) ? -2068882236 : -1442115366);
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x002373A8 File Offset: 0x002355A8
		public static GClass59.Class333 smethod_4(GClass59.Class333 class333_0)
		{
			return new GClass59.Class338(-class333_0.vmethod_6());
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x002373C4 File Offset: 0x002355C4
		public override int vmethod_22()
		{
			return (int)this.double_0;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x002373D8 File Offset: 0x002355D8
		public override bool vmethod_15()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x002373F0 File Offset: 0x002355F0
		public override IntPtr vmethod_19()
		{
			while (IntPtr.Size == 4)
			{
			}
			return new IntPtr((long)this.double_0);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00237418 File Offset: 0x00235618
		public override double vmethod_6()
		{
			return this.double_0;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0023742C File Offset: 0x0023562C
		public static GClass59.Class333 smethod_5(GClass59.Class333 class333_0, GClass59.Class333 class333_1, bool bool_0, bool bool_1)
		{
			while (bool_1)
			{
			}
			double num = class333_0.vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new GClass59.Class338(bool_0 ? (num - num2) : (num - num2));
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00237468 File Offset: 0x00235668
		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.double_0)) : ((ulong)this.double_0));
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00237154 File Offset: 0x00235354
		public override ushort vmethod_7()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00237494 File Offset: 0x00235694
		public override sbyte vmethod_17()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x002374A8 File Offset: 0x002356A8
		public override uint vmethod_18()
		{
			return (uint)this.double_0;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x002374BC File Offset: 0x002356BC
		public override float vmethod_13()
		{
			return (float)this.double_0;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x002374D0 File Offset: 0x002356D0
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class338(this.double_0);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x002374E8 File Offset: 0x002356E8
		public override TypeCode vmethod_2()
		{
			return TypeCode.Double;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x002374F8 File Offset: 0x002356F8
		public override ulong vmethod_4()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0023750C File Offset: 0x0023570C
		public Class338(double double_1)
		{
			this.double_0 = double_1;
		}

		// Token: 0x040021C5 RID: 8645
		private double double_0;
	}

	// Token: 0x02000A20 RID: 2592
	private sealed class Class339 : GClass59.Class334
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x00237528 File Offset: 0x00235728
		public override TypeCode vmethod_2()
		{
			return TypeCode.Object;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00237538 File Offset: 0x00235738
		public override object vmethod_12()
		{
			return this.string_0;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0023754C File Offset: 0x0023574C
		public override Type vmethod_8()
		{
			return typeof(string);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00237538 File Offset: 0x00235738
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00237564 File Offset: 0x00235764
		public override void vmethod_10(object object_0)
		{
			this.string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00237584 File Offset: 0x00235784
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class339(this.string_0);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0023759C File Offset: 0x0023579C
		public override bool vmethod_15()
		{
			return this.string_0 != null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x002375B4 File Offset: 0x002357B4
		public Class339(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x040021C6 RID: 8646
		private string string_0;
	}

	// Token: 0x02000A21 RID: 2593
	private sealed class Class356 : GClass59.Class333
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x002375D0 File Offset: 0x002357D0
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class356(this.short_0);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x002375E8 File Offset: 0x002357E8
		public override ushort vmethod_7()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x002375FC File Offset: 0x002357FC
		public override object vmethod_12()
		{
			return this.short_0;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0023762C File Offset: 0x0023582C
		public override uint vmethod_18()
		{
			return (uint)this.short_0;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00237640 File Offset: 0x00235840
		public override sbyte vmethod_17()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00237654 File Offset: 0x00235854
		public override Type vmethod_8()
		{
			return typeof(short);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0023766C File Offset: 0x0023586C
		public override void vmethod_10(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0023762C File Offset: 0x0023582C
		public override int vmethod_22()
		{
			return (int)this.short_0;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0023762C File Offset: 0x0023582C
		public override short vmethod_14()
		{
			return this.short_0;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00237688 File Offset: 0x00235888
		public override byte vmethod_1()
		{
			return (byte)this.short_0;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0023769C File Offset: 0x0023589C
		public Class356(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x040021C7 RID: 8647
		private short short_0;
	}

	// Token: 0x02000A22 RID: 2594
	private sealed class Class357 : GClass59.Class333
	{
		// Token: 0x060017F0 RID: 6128 RVA: 0x002376B8 File Offset: 0x002358B8
		public override uint vmethod_18()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x002376CC File Offset: 0x002358CC
		public override sbyte vmethod_17()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x002376E0 File Offset: 0x002358E0
		public override short vmethod_14()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x002376B8 File Offset: 0x002358B8
		public override ushort vmethod_7()
		{
			return this.ushort_0;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x002376F4 File Offset: 0x002358F4
		public override void vmethod_10(object object_0)
		{
			this.ushort_0 = Convert.ToUInt16(object_0);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00237710 File Offset: 0x00235910
		public override object vmethod_12()
		{
			return this.ushort_0;
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x002376B8 File Offset: 0x002358B8
		public override int vmethod_22()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00237728 File Offset: 0x00235928
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class357(this.ushort_0);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00237740 File Offset: 0x00235940
		public override Type vmethod_8()
		{
			return typeof(ushort);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00237758 File Offset: 0x00235958
		public override byte vmethod_1()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0023776C File Offset: 0x0023596C
		public Class357(ushort ushort_1)
		{
			this.ushort_0 = ushort_1;
		}

		// Token: 0x040021C8 RID: 8648
		private ushort ushort_0;
	}

	// Token: 0x02000A23 RID: 2595
	private sealed class Class358 : GClass59.Class333
	{
		// Token: 0x060017FC RID: 6140 RVA: 0x00237788 File Offset: 0x00235988
		public override int vmethod_22()
		{
			if (!this.bool_0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x002377A0 File Offset: 0x002359A0
		public override Type vmethod_8()
		{
			return typeof(bool);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x002377B8 File Offset: 0x002359B8
		public override void vmethod_10(object object_0)
		{
			this.bool_0 = Convert.ToBoolean(object_0);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x002377D4 File Offset: 0x002359D4
		public override object vmethod_12()
		{
			return this.bool_0;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x002377EC File Offset: 0x002359EC
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class358(this.bool_0);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00237804 File Offset: 0x00235A04
		public Class358(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x040021C9 RID: 8649
		private bool bool_0;
	}

	// Token: 0x02000A24 RID: 2596
	private sealed class Class359 : GClass59.Class333
	{
		// Token: 0x06001803 RID: 6147 RVA: 0x00237820 File Offset: 0x00235A20
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class359(this.char_0);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00237838 File Offset: 0x00235A38
		public override short vmethod_14()
		{
			return (short)this.char_0;
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0023784C File Offset: 0x00235A4C
		public override sbyte vmethod_17()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00237860 File Offset: 0x00235A60
		public override uint vmethod_18()
		{
			return (uint)this.char_0;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00237860 File Offset: 0x00235A60
		public override int vmethod_22()
		{
			return (int)this.char_0;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00237874 File Offset: 0x00235A74
		public override Type vmethod_8()
		{
			return typeof(char);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0023788C File Offset: 0x00235A8C
		public override void vmethod_10(object object_0)
		{
			this.char_0 = Convert.ToChar(object_0);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x002378A8 File Offset: 0x00235AA8
		public override object vmethod_12()
		{
			return this.char_0;
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00237860 File Offset: 0x00235A60
		public override ushort vmethod_7()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x002378C0 File Offset: 0x00235AC0
		public override byte vmethod_1()
		{
			return (byte)this.char_0;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x002378D4 File Offset: 0x00235AD4
		public Class359(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x040021CA RID: 8650
		private char char_0;
	}

	// Token: 0x02000A25 RID: 2597
	private sealed class Class360 : GClass59.Class333
	{
		// Token: 0x0600180F RID: 6159 RVA: 0x002378F0 File Offset: 0x00235AF0
		public override byte vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x002378F0 File Offset: 0x00235AF0
		public override short vmethod_14()
		{
			return (short)this.byte_0;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00237904 File Offset: 0x00235B04
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class360(this.byte_0);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0023791C File Offset: 0x00235B1C
		public override object vmethod_12()
		{
			return this.byte_0;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00237934 File Offset: 0x00235B34
		public override sbyte vmethod_17()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x002378F0 File Offset: 0x00235AF0
		public override uint vmethod_18()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x002378F0 File Offset: 0x00235AF0
		public override int vmethod_22()
		{
			return (int)this.byte_0;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x002378F0 File Offset: 0x00235AF0
		public override ushort vmethod_7()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00237948 File Offset: 0x00235B48
		public override Type vmethod_8()
		{
			return typeof(byte);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00237960 File Offset: 0x00235B60
		public override void vmethod_10(object object_0)
		{
			this.byte_0 = Convert.ToByte(object_0);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0023797C File Offset: 0x00235B7C
		public Class360(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x040021CB RID: 8651
		private byte byte_0;
	}

	// Token: 0x02000A26 RID: 2598
	private sealed class Class361 : GClass59.Class333
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x00237998 File Offset: 0x00235B98
		public override int vmethod_22()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x002379AC File Offset: 0x00235BAC
		public override object vmethod_12()
		{
			return this.sbyte_0;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x002379C4 File Offset: 0x00235BC4
		public override Type vmethod_8()
		{
			return typeof(sbyte);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x002379DC File Offset: 0x00235BDC
		public override byte vmethod_1()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x002379F0 File Offset: 0x00235BF0
		public override ushort vmethod_7()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00237998 File Offset: 0x00235B98
		public override uint vmethod_18()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00237A04 File Offset: 0x00235C04
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class361(this.sbyte_0);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00237998 File Offset: 0x00235B98
		public override short vmethod_14()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00237A1C File Offset: 0x00235C1C
		public override void vmethod_10(object object_0)
		{
			this.sbyte_0 = Convert.ToSByte(object_0);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00237998 File Offset: 0x00235B98
		public override sbyte vmethod_17()
		{
			return this.sbyte_0;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00237A38 File Offset: 0x00235C38
		public Class361(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x040021CC RID: 8652
		private sbyte sbyte_0;
	}

	// Token: 0x02000A27 RID: 2599
	private sealed class Class362 : GClass59.Class333
	{
		// Token: 0x06001827 RID: 6183 RVA: 0x00237A54 File Offset: 0x00235C54
		public override Type vmethod_8()
		{
			return typeof(uint);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00237A6C File Offset: 0x00235C6C
		public override short vmethod_14()
		{
			return (short)this.uint_0;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00237A80 File Offset: 0x00235C80
		public override ushort vmethod_7()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00237A94 File Offset: 0x00235C94
		public override void vmethod_10(object object_0)
		{
			this.uint_0 = Convert.ToUInt32(object_0);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00237AB0 File Offset: 0x00235CB0
		public override byte vmethod_1()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00237AC4 File Offset: 0x00235CC4
		public override object vmethod_12()
		{
			return this.uint_0;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00237ADC File Offset: 0x00235CDC
		public override sbyte vmethod_17()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00237AF0 File Offset: 0x00235CF0
		public override uint vmethod_18()
		{
			return this.uint_0;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00237B04 File Offset: 0x00235D04
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class362(this.uint_0);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00237614 File Offset: 0x00235814
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class335(this.vmethod_22());
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00237AF0 File Offset: 0x00235CF0
		public override int vmethod_22()
		{
			return (int)this.uint_0;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00237B1C File Offset: 0x00235D1C
		public Class362(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x040021CD RID: 8653
		private uint uint_0;
	}

	// Token: 0x02000A28 RID: 2600
	private sealed class Class363 : GClass59.Class333
	{
		// Token: 0x06001833 RID: 6195 RVA: 0x00237B38 File Offset: 0x00235D38
		public override sbyte vmethod_17()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00237B4C File Offset: 0x00235D4C
		public override object vmethod_12()
		{
			return this.ulong_0;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00237B64 File Offset: 0x00235D64
		public override uint vmethod_18()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00237B78 File Offset: 0x00235D78
		public override byte vmethod_1()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00237B8C File Offset: 0x00235D8C
		public override long vmethod_11()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00237BA0 File Offset: 0x00235DA0
		public override int vmethod_22()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00237BB4 File Offset: 0x00235DB4
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class363(this.ulong_0);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00237BCC File Offset: 0x00235DCC
		public override short vmethod_14()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00237B8C File Offset: 0x00235D8C
		public override ulong vmethod_4()
		{
			return this.ulong_0;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00237BE0 File Offset: 0x00235DE0
		public override void vmethod_10(object object_0)
		{
			this.ulong_0 = Convert.ToUInt64(object_0);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00237BFC File Offset: 0x00235DFC
		public override GClass59.Class334 vmethod_16()
		{
			return new GClass59.Class336(this.vmethod_11());
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00237C14 File Offset: 0x00235E14
		public override ushort vmethod_7()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00237C28 File Offset: 0x00235E28
		public override Type vmethod_8()
		{
			return typeof(ulong);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00237C40 File Offset: 0x00235E40
		public Class363(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x040021CE RID: 8654
		private ulong ulong_0;
	}

	// Token: 0x02000A29 RID: 2601
	private sealed class Class340 : GClass59.Class334
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00237C5C File Offset: 0x00235E5C
		public override bool vmethod_15()
		{
			return this.object_0 != null;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00237C74 File Offset: 0x00235E74
		public static GClass59.Class333 smethod_0(GClass59.Class333 class333_0, GClass59.Class333 class333_1)
		{
			object obj = class333_0.vmethod_12();
			object obj2 = class333_1.vmethod_12();
			int int_;
			if (obj == obj2)
			{
				int_ = 1;
			}
			else
			{
				int_ = ((obj2 == null) ? 421481213 : 30542);
			}
			return new GClass59.Class335(int_);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00237528 File Offset: 0x00235728
		public override TypeCode vmethod_2()
		{
			return TypeCode.Object;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00237CAC File Offset: 0x00235EAC
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class340(this.object_0);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00237CC4 File Offset: 0x00235EC4
		public override Type vmethod_8()
		{
			return typeof(object);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00237CDC File Offset: 0x00235EDC
		public override void vmethod_10(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00237CF0 File Offset: 0x00235EF0
		public override object vmethod_12()
		{
			return this.object_0;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00237D04 File Offset: 0x00235F04
		public Class340(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x040021CF RID: 8655
		private object object_0;
	}

	// Token: 0x02000A2A RID: 2602
	private sealed class Class341 : GClass59.Class334
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00237D20 File Offset: 0x00235F20
		//public static GClass59.Class333 smethod_0(GClass59.Class333 class333_1, GClass59.Class333 class333_2, bool bool_0, bool bool_1)
		//{
		//	while (class333_1 is GClass59.Class341)
		//	{
		//	}
		//	GClass59.Class341 @class = (GClass59.Class341)class333_2;
		//	if (@class.vmethod_2() == TypeCode.UInt32)
		//	{
		//		int value;
		//		if (bool_1)
		//		{
		//			uint num = class333_1.vmethod_18();
		//			uint num2 = class333_2.vmethod_18();
		//			value = (int)(bool_0 ? checked(num + num2) : (num + num2));
		//		}
		//		else
		//		{
		//			int num3 = class333_1.vmethod_22();
		//			int num4 = class333_2.vmethod_22();
		//			value = (bool_0 ? checked(num3 + num4) : (num3 + num4));
		//		}
		//		//return new GClass59.Class341(Pointer.Box(new IntPtr(value).ToPointer(), @class.vmethod_8()), @class.vmethod_8());
		//	}
		//	long value2;
		//	if (bool_1)
		//	{
		//		ulong num5 = class333_1.vmethod_4();
		//		ulong num6 = class333_2.vmethod_4();
		//		value2 = (long)(bool_0 ? checked(num5 + num6) : (num5 + num6));
		//	}
		//	else
		//	{
		//		long num7 = class333_1.vmethod_11();
		//		long num8 = class333_2.vmethod_11();
		//		value2 = (bool_0 ? checked(num7 + num8) : (num7 + num8));
		//	}
		//	//return new GClass59.Class341(Pointer.Box(new IntPtr(value2).ToPointer(), @class.vmethod_8()), @class.vmethod_8());
		//}

		// Token: 0x0600184A RID: 6218 RVA: 0x00237E20 File Offset: 0x00236020
		//public static GClass59.Class333 smethod_1(GClass59.Class333 class333_1, GClass59.Class333 class333_2, bool bool_0, bool bool_1)
		//{
		//	GClass59.Class341 class2;
		//	for (; ; )
		//	{
		//		if (class333_1 is GClass59.Class341)
		//		{
		//			goto IL_2C;
		//		}
		//		GClass59.Class341 @class = (GClass59.Class341)class333_2;
		//	IL_09:
		//		class2 = @class;
		//		if (class2.vmethod_2() == TypeCode.UInt32)
		//		{
		//			if (!bool_1)
		//			{
		//				class333_1.vmethod_22();
		//				class333_2.vmethod_22();
		//				continue;
		//			}
		//			break;
		//		}
		//		else
		//		{
		//			if (!bool_1)
		//			{
		//				long num = class333_1.vmethod_11();
		//				long num2 = class333_2.vmethod_11();
		//				long num3 = bool_0 ? checked(num - num2) : (num - num2);
		//				continue;
		//			}
		//			class333_1.vmethod_4();
		//			class333_2.vmethod_4();
		//			if (!bool_0)
		//			{
		//				continue;
		//			}
		//		}
		//	IL_2C:
		//		@class = (GClass59.Class341)class333_1;
		//		goto IL_09;
		//	}
		//	uint num4 = class333_1.vmethod_18();
		//	uint num5 = class333_2.vmethod_18();
		//	int value = (int)(bool_0 ? checked(num4 - num5) : (num4 - num5));
		//	//return new Class341(Pointer.Box(new IntPtr(value).ToPointer(), class2.vmethod_8()), class2.vmethod_8());
		//}

		// Token: 0x0600184B RID: 6219 RVA: 0x00237EE4 File Offset: 0x002360E4
		public override IntPtr vmethod_19()
		{
			return this.class333_0.vmethod_19();
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00237EFC File Offset: 0x002360FC
		public override byte vmethod_1()
		{
			return this.class333_0.vmethod_1();
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00237F14 File Offset: 0x00236114
		public override UIntPtr vmethod_23()
		{
			return this.class333_0.vmethod_23();
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00237F2C File Offset: 0x0023612C
		public override float vmethod_13()
		{
			return this.class333_0.vmethod_13();
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00237F44 File Offset: 0x00236144
		public override TypeCode vmethod_2()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00237F60 File Offset: 0x00236160
		public unsafe override void* vmethod_0()
		{
			return Pointer.Unbox(this.object_0);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00237F78 File Offset: 0x00236178
		public override int vmethod_22()
		{
			return this.class333_0.vmethod_22();
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00237F90 File Offset: 0x00236190
		public override short vmethod_14()
		{
			return this.class333_0.vmethod_14();
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00237FA8 File Offset: 0x002361A8
		public override uint vmethod_18()
		{
			return this.class333_0.vmethod_18();
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00237FC0 File Offset: 0x002361C0
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class341(this.object_0, this.type_0);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00237FE0 File Offset: 0x002361E0
		public override long vmethod_11()
		{
			return this.class333_0.vmethod_11();
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00237FF8 File Offset: 0x002361F8
		public override ulong vmethod_4()
		{
			return this.class333_0.vmethod_4();
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00238010 File Offset: 0x00236210
		public override ushort vmethod_7()
		{
			return this.class333_0.vmethod_7();
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00238028 File Offset: 0x00236228
		public override object vmethod_5(Type type_1, bool bool_0)
		{
			return this.class333_0.vmethod_5(type_1, bool_0);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00238044 File Offset: 0x00236244
		public override void vmethod_10(object object_1)
		{
			this.object_0 = object_1;
			//this.class333_0 = GClass59.Class341.smethod_2(object_1);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00238064 File Offset: 0x00236264
		public override bool vmethod_15()
		{
			return this.object_0 != null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0023807C File Offset: 0x0023627C
		public override sbyte vmethod_17()
		{
			return this.class333_0.vmethod_17();
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00238094 File Offset: 0x00236294
		public override Type vmethod_8()
		{
			return this.type_0;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x002380A8 File Offset: 0x002362A8
		public override double vmethod_6()
		{
			return this.class333_0.vmethod_6();
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x002380C0 File Offset: 0x002362C0
		public override object vmethod_12()
		{
			return this.object_0;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x002380D4 File Offset: 0x002362D4
		//private static GClass59.Class333 smethod_2(object object_1)
		//{
		//	IntPtr intPtr = (object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1));
		//	if (IntPtr.Size == 4)
		//	{
		//		return new GClass59.Class335(intPtr.ToInt32());
		//	}
		//	return new GClass59.Class336(intPtr.ToInt64());
		//}

		// Token: 0x06001860 RID: 6240 RVA: 0x00238118 File Offset: 0x00236318
		public static GClass59.Class333 smethod_3(GClass59.Class333 class333_1, GClass59.Class333 class333_2, bool bool_0)
		{
			int int_;
			if (((class333_1 is GClass59.Class341) ? ((GClass59.Class341)class333_1) : ((GClass59.Class341)class333_2)).vmethod_2() == TypeCode.UInt32)
			{
				while (bool_0)
				{
					uint num = class333_1.vmethod_18();
					uint num2 = class333_2.vmethod_18();
					if (num == num2)
					{
						int_ = 1;
						goto IL_DA;
					}
				}
				int num3 = class333_1.vmethod_22();
				int num4 = class333_2.vmethod_22();
				if (num3 == num4)
				{
					int_ = 1;
				}
				else
				{
					int_ = ((num3 > num4) ? -193 : -400822264);
				}
			}
			else if (bool_0)
			{
				ulong num5 = class333_1.vmethod_4();
				ulong num6 = class333_2.vmethod_4();
				if (num5 == num6)
				{
					int_ = 655242457;
				}
				else
				{
					int_ = ((num5 > num6) ? -1127848869 : 1796502);
				}
			}
			else
			{
				long num7 = class333_1.vmethod_11();
				long num8 = class333_2.vmethod_11();
				if (num7 == num8)
				{
					int_ = 1289303481;
				}
				else
				{
					int_ = ((num7 > num8) ? 1021599840 : -16448);
				}
			}
		IL_DA:
			return new GClass59.Class335(int_);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00238208 File Offset: 0x00236408
		public Class341(object object_1, Type type_1)
		{
			this.object_0 = object_1;
			this.type_0 = type_1;
			//this.class333_0 = GClass59.Class341.smethod_2(object_1);
		}

		// Token: 0x040021D0 RID: 8656
		private Type type_0;

		// Token: 0x040021D1 RID: 8657
		private GClass59.Class333 class333_0;

		// Token: 0x040021D2 RID: 8658
		private object object_0;
	}

	// Token: 0x02000A2B RID: 2603
	private sealed class Class342 : GClass59.Class334
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x00238238 File Offset: 0x00236438
		public override void vmethod_10(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00238260 File Offset: 0x00236460
		public override object vmethod_12()
		{
			return this.object_0;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00238274 File Offset: 0x00236474
		public override Type vmethod_8()
		{
			return typeof(ValueType);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0023828C File Offset: 0x0023648C
		public override GClass59.Class333 vmethod_24()
		{
			object obj;
			if (this.object_0 == null)
			{
				obj = null;
			}
			else
			{
				Type type = this.object_0.GetType();
				FieldInfo[] fields = type.GetFields((BindingFlags)1782787206);
				obj = Activator.CreateInstance(type);
				FieldInfo[] array = fields;
				for (int i = 39; i < array.Length; i++)
				{
					FieldInfo fieldInfo = array[i];
					fieldInfo.SetValue(obj, fieldInfo.GetValue(this.object_0));
				}
			}
			return new GClass59.Class342(obj);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x002382F8 File Offset: 0x002364F8
		public Class342(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x040021D3 RID: 8659
		private object object_0;
	}

	// Token: 0x02000A2C RID: 2604
	private sealed class Class343 : GClass59.Class334
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x00238324 File Offset: 0x00236524
		public override void vmethod_10(object object_0)
		{
			this.array_0 = (Array)object_0;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00238340 File Offset: 0x00236540
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class343(this.array_0);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00238358 File Offset: 0x00236558
		public override object vmethod_12()
		{
			return this.array_0;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0023836C File Offset: 0x0023656C
		public override Type vmethod_8()
		{
			return typeof(Array);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00238384 File Offset: 0x00236584
		public override bool vmethod_15()
		{
			return this.array_0 != null;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0023839C File Offset: 0x0023659C
		public Class343(Array array_1)
		{
			this.array_0 = array_1;
		}

		// Token: 0x040021D4 RID: 8660
		private Array array_0;
	}

	// Token: 0x02000A2D RID: 2605
	private abstract class Class344 : GClass59.Class334
	{
		// Token: 0x0600186E RID: 6254 RVA: 0x00237528 File Offset: 0x00235728
		public override bool vmethod_21()
		{
			return true;
		}
	}

	// Token: 0x02000A2E RID: 2606
	private sealed class Class345 : GClass59.Class344
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x002383CC File Offset: 0x002365CC
		public override object vmethod_12()
		{
			return this.class333_0.vmethod_12();
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x002383E4 File Offset: 0x002365E4
		public override bool vmethod_15()
		{
			return this.class333_0 != null;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x002383FC File Offset: 0x002365FC
		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			this.class333_0.vmethod_20(fieldInfo_0, object_0);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00238418 File Offset: 0x00236618
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class345(this.class333_0);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00238430 File Offset: 0x00236630
		public override Type vmethod_8()
		{
			return this.class333_0.vmethod_8();
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00238448 File Offset: 0x00236648
		public override void vmethod_10(object object_0)
		{
			this.class333_0.vmethod_10(object_0);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00238464 File Offset: 0x00236664
		public Class345(GClass59.Class333 class333_1)
		{
			this.class333_0 = class333_1;
		}

		// Token: 0x040021D5 RID: 8661
		private GClass59.Class333 class333_0;
	}

	// Token: 0x02000A2F RID: 2607
	private sealed class Class351 : GClass59.Class334
	{
		// Token: 0x06001876 RID: 6262 RVA: 0x00235F34 File Offset: 0x00234134
		public override GClass59.Class334 vmethod_16()
		{
			return this;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00238480 File Offset: 0x00236680
		public override object vmethod_12()
		{
			object result = this.class333_0.vmethod_12();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x002384A0 File Offset: 0x002366A0
		public override bool vmethod_21()
		{
			return this.class333_0.vmethod_21();
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x002384B8 File Offset: 0x002366B8
		public override byte vmethod_1()
		{
			byte result = this.class333_0.vmethod_1();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x002384D8 File Offset: 0x002366D8
		public override long vmethod_11()
		{
			long result = this.class333_0.vmethod_11();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x002384F8 File Offset: 0x002366F8
		public override sbyte vmethod_17()
		{
			sbyte result = this.class333_0.vmethod_17();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00238518 File Offset: 0x00236718
		public override short vmethod_14()
		{
			short result = this.class333_0.vmethod_14();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00238538 File Offset: 0x00236738
		public override TypeCode vmethod_2()
		{
			return this.class333_0.vmethod_2();
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00238550 File Offset: 0x00236750
		public override bool vmethod_15()
		{
			bool result = this.class333_0.vmethod_15();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00238570 File Offset: 0x00236770
		public override int vmethod_22()
		{
			int result = this.class333_0.vmethod_22();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00238590 File Offset: 0x00236790
		public override ushort vmethod_7()
		{
			ushort result = this.class333_0.vmethod_7();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x002385B0 File Offset: 0x002367B0
		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			this.class333_0.vmethod_20(fieldInfo_0, object_0);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x002385D0 File Offset: 0x002367D0
		public override double vmethod_6()
		{
			double result = this.class333_0.vmethod_6();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x002385F0 File Offset: 0x002367F0
		public override Type vmethod_8()
		{
			return this.class333_0.vmethod_8();
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00238608 File Offset: 0x00236808
		public override uint vmethod_18()
		{
			uint result = this.class333_0.vmethod_18();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00238628 File Offset: 0x00236828
		public override float vmethod_13()
		{
			float result = this.class333_0.vmethod_13();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00238648 File Offset: 0x00236848
		public override ulong vmethod_4()
		{
			ulong result = this.class333_0.vmethod_4();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00238668 File Offset: 0x00236868
		public override void vmethod_10(object object_0)
		{
			Thread.MemoryBarrier();
			this.class333_0.vmethod_10(object_0);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00235E88 File Offset: 0x00234088
		public override GClass59.Class333 vmethod_24()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00238688 File Offset: 0x00236888
		public Class351(GClass59.Class333 class333_1)
		{
			this.class333_0 = class333_1;
		}

		// Token: 0x040021D6 RID: 8662
		private GClass59.Class333 class333_0;
	}

	// Token: 0x02000A30 RID: 2608
	private sealed class Class346 : GClass59.Class344
	{
		// Token: 0x0600188A RID: 6282 RVA: 0x002386A4 File Offset: 0x002368A4
		public override bool vmethod_15()
		{
			return this.class333_1 != null;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x002386BC File Offset: 0x002368BC
		public override Type vmethod_8()
		{
			return this.class333_1.vmethod_8();
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x002386D4 File Offset: 0x002368D4
		public override void vmethod_10(object object_0)
		{
			this.class333_1.vmethod_10(object_0);
			this.class333_0.vmethod_10(this.class333_1.vmethod_12());
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00238704 File Offset: 0x00236904
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class346(this.class333_1, this.class333_0);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00238724 File Offset: 0x00236924
		public override object vmethod_12()
		{
			return this.class333_1.vmethod_12();
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0023873C File Offset: 0x0023693C
		public Class346(GClass59.Class333 class333_2, GClass59.Class333 class333_3)
		{
			this.class333_1 = class333_2;
			this.class333_0 = class333_3;
		}

		// Token: 0x040021D7 RID: 8663
		private GClass59.Class333 class333_0;

		// Token: 0x040021D8 RID: 8664
		private GClass59.Class333 class333_1;
	}

	// Token: 0x02000A31 RID: 2609
	private sealed class Class347 : GClass59.Class344
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x00238760 File Offset: 0x00236960
		public override void vmethod_10(object object_0)
		{
			this.class333_0.vmethod_20(this.fieldInfo_0, object_0);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00238780 File Offset: 0x00236980
		public override object vmethod_12()
		{
			object obj = (!this.class333_0.vmethod_8().IsPointer || !this.fieldInfo_0.DeclaringType.IsValueType) ? this.class333_0.vmethod_12() : Marshal.PtrToStructure(this.class333_0.vmethod_19(), this.fieldInfo_0.DeclaringType);
			return this.fieldInfo_0.GetValue(obj);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x002387E8 File Offset: 0x002369E8
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class347(this.fieldInfo_0, this.class333_0);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00238808 File Offset: 0x00236A08
		public override Type vmethod_8()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00238820 File Offset: 0x00236A20
		public Class347(FieldInfo fieldInfo_1, GClass59.Class333 class333_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.class333_0 = class333_1;
		}

		// Token: 0x040021D9 RID: 8665
		private GClass59.Class333 class333_0;

		// Token: 0x040021DA RID: 8666
		private FieldInfo fieldInfo_0;
	}

	// Token: 0x02000A32 RID: 2610
	private sealed class Class348 : GClass59.Class344
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x00238844 File Offset: 0x00236A44
		public override object vmethod_12()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00238864 File Offset: 0x00236A64
		public override Type vmethod_8()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00238884 File Offset: 0x00236A84
		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = this.vmethod_12();
			fieldInfo_0.SetValue(obj, object_0);
			if (obj is ValueType)
			{
				this.vmethod_10(obj);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x002388B0 File Offset: 0x00236AB0
		public override void vmethod_10(object object_0)
		{
			switch (Type.GetTypeCode(this.array_0.GetType().GetElementType()))
			{
				case TypeCode.Char:
					object_0 = Convert.ToChar(object_0);
					break;
				case TypeCode.SByte:
					object_0 = Convert.ToSByte(object_0);
					break;
				case TypeCode.Byte:
					object_0 = Convert.ToByte(object_0);
					break;
				case TypeCode.Int16:
					object_0 = Convert.ToInt16(object_0);
					break;
				case TypeCode.UInt16:
					object_0 = Convert.ToUInt16(object_0);
					break;
				case TypeCode.Int32:
					object_0 = Convert.ToInt32(object_0);
					break;
				case TypeCode.UInt32:
					object_0 = Convert.ToUInt32(object_0);
					break;
				case TypeCode.Int64:
					object_0 = Convert.ToInt64(object_0);
					break;
				case TypeCode.UInt64:
					object_0 = Convert.ToUInt64(object_0);
					break;
			}
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0023899C File Offset: 0x00236B9C
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class348(this.array_0, this.int_0);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x002389BC File Offset: 0x00236BBC
		public Class348(Array array_1, int int_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
		}

		// Token: 0x040021DB RID: 8667
		private int int_0;

		// Token: 0x040021DC RID: 8668
		private Array array_0;
	}

	// Token: 0x02000A33 RID: 2611
	private sealed class Class352 : GClass59.Class334
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x002389E0 File Offset: 0x00236BE0
		public override void vmethod_10(object object_0)
		{
			this.methodBase_0 = (MethodBase)object_0;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x002389FC File Offset: 0x00236BFC
		public override Type vmethod_8()
		{
			return typeof(MethodBase);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00238A14 File Offset: 0x00236C14
		public override object vmethod_12()
		{
			return this.methodBase_0;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00238A28 File Offset: 0x00236C28
		public override IntPtr vmethod_19()
		{
			return this.methodBase_0.MethodHandle.GetFunctionPointer();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00238A48 File Offset: 0x00236C48
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class352(this.methodBase_0);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00238A60 File Offset: 0x00236C60
		public override bool vmethod_15()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00238A7C File Offset: 0x00236C7C
		public Class352(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x040021DD RID: 8669
		private MethodBase methodBase_0;
	}

	// Token: 0x02000A34 RID: 2612
	private sealed class Class353 : GClass59.Class334
	{
		// Token: 0x060018A2 RID: 6306 RVA: 0x00238A98 File Offset: 0x00236C98
		public override void vmethod_10(object object_0)
		{
			this.intptr_0 = (IntPtr)object_0;
			this.class333_0 = GClass59.Class353.smethod_0(this.intptr_0);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00238AC4 File Offset: 0x00236CC4
		public override int vmethod_22()
		{
			return this.class333_0.vmethod_22();
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00238ADC File Offset: 0x00236CDC
		public override Type vmethod_8()
		{
			return typeof(IntPtr);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00238AF4 File Offset: 0x00236CF4
		public unsafe override void* vmethod_0()
		{
			return this.intptr_0.ToPointer();
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00238B0C File Offset: 0x00236D0C
		public override bool vmethod_15()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00238B2C File Offset: 0x00236D2C
		public override short vmethod_14()
		{
			return this.class333_0.vmethod_14();
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00238B44 File Offset: 0x00236D44
		public override uint vmethod_18()
		{
			return this.class333_0.vmethod_18();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00238B5C File Offset: 0x00236D5C
		public override ulong vmethod_4()
		{
			return this.class333_0.vmethod_4();
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00238B74 File Offset: 0x00236D74
		public override UIntPtr vmethod_23()
		{
			return this.class333_0.vmethod_23();
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00238B8C File Offset: 0x00236D8C
		private static GClass59.Class333 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass59.Class335(intptr_1.ToInt32());
			}
			return new GClass59.Class336(intptr_1.ToInt64());
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00238BBC File Offset: 0x00236DBC
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class353(this.intptr_0);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00238BD4 File Offset: 0x00236DD4
		public override float vmethod_13()
		{
			return this.class333_0.vmethod_13();
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00238BEC File Offset: 0x00236DEC
		public override object vmethod_12()
		{
			return this.intptr_0;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00238C04 File Offset: 0x00236E04
		public override long vmethod_11()
		{
			return this.class333_0.vmethod_11();
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00238C1C File Offset: 0x00236E1C
		public override TypeCode vmethod_2()
		{
			return this.class333_0.vmethod_2();
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00238C34 File Offset: 0x00236E34
		public override double vmethod_6()
		{
			return this.class333_0.vmethod_6();
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00238C4C File Offset: 0x00236E4C
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return this.class333_0.vmethod_5(type_0, bool_0);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00238C68 File Offset: 0x00236E68
		public override ushort vmethod_7()
		{
			return this.class333_0.vmethod_7();
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00238C80 File Offset: 0x00236E80
		public override sbyte vmethod_17()
		{
			return this.class333_0.vmethod_17();
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00238C98 File Offset: 0x00236E98
		public override byte vmethod_1()
		{
			return this.class333_0.vmethod_1();
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00238CB0 File Offset: 0x00236EB0
		public override IntPtr vmethod_19()
		{
			return this.intptr_0;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00238CC4 File Offset: 0x00236EC4
		public Class353(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
			this.class333_0 = GClass59.Class353.smethod_0(this.intptr_0);
		}

		// Token: 0x040021DE RID: 8670
		private GClass59.Class333 class333_0;

		// Token: 0x040021DF RID: 8671
		private IntPtr intptr_0;
	}

	// Token: 0x02000A35 RID: 2613
	private sealed class Class354 : GClass59.Class334
	{
		// Token: 0x060018B8 RID: 6328 RVA: 0x00238CF0 File Offset: 0x00236EF0
		private static GClass59.Class333 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass59.Class335((int)uintptr_1.ToUInt32());
			}
			return new GClass59.Class336((long)uintptr_1.ToUInt64());
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00238D20 File Offset: 0x00236F20
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return this.class333_0.vmethod_5(type_0, bool_0);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00238D3C File Offset: 0x00236F3C
		public override float vmethod_13()
		{
			return this.class333_0.vmethod_13();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00238D54 File Offset: 0x00236F54
		public override Type vmethod_8()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00238D6C File Offset: 0x00236F6C
		public override byte vmethod_1()
		{
			return this.class333_0.vmethod_1();
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00238D84 File Offset: 0x00236F84
		public override ushort vmethod_7()
		{
			return this.class333_0.vmethod_7();
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00238D9C File Offset: 0x00236F9C
		public override bool vmethod_15()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00238DBC File Offset: 0x00236FBC
		public override ulong vmethod_4()
		{
			return this.class333_0.vmethod_4();
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00238DD4 File Offset: 0x00236FD4
		public override UIntPtr vmethod_23()
		{
			return this.uintptr_0;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00238DE8 File Offset: 0x00236FE8
		public override IntPtr vmethod_19()
		{
			return this.class333_0.vmethod_19();
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00238E00 File Offset: 0x00237000
		public override double vmethod_6()
		{
			return this.class333_0.vmethod_6();
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00238E18 File Offset: 0x00237018
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class354(this.uintptr_0);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00238E30 File Offset: 0x00237030
		public override sbyte vmethod_17()
		{
			return this.class333_0.vmethod_17();
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00238E48 File Offset: 0x00237048
		public override void vmethod_10(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			this.class333_0 = GClass59.Class354.smethod_0(this.uintptr_0);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00238E74 File Offset: 0x00237074
		public override uint vmethod_18()
		{
			return this.class333_0.vmethod_18();
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00238E8C File Offset: 0x0023708C
		public override int vmethod_22()
		{
			return this.class333_0.vmethod_22();
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00238EA4 File Offset: 0x002370A4
		public override short vmethod_14()
		{
			return this.class333_0.vmethod_14();
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00238EBC File Offset: 0x002370BC
		public override TypeCode vmethod_2()
		{
			return this.class333_0.vmethod_2();
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00238ED4 File Offset: 0x002370D4
		public override long vmethod_11()
		{
			return this.class333_0.vmethod_11();
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00238EEC File Offset: 0x002370EC
		public unsafe override void* vmethod_0()
		{
			return this.uintptr_0.ToPointer();
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00238F04 File Offset: 0x00237104
		public override object vmethod_12()
		{
			return this.uintptr_0;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00238F1C File Offset: 0x0023711C
		public Class354(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class333_0 = GClass59.Class354.smethod_0(this.uintptr_0);
		}

		// Token: 0x040021E0 RID: 8672
		private GClass59.Class333 class333_0;

		// Token: 0x040021E1 RID: 8673
		private UIntPtr uintptr_0;
	}

	// Token: 0x02000A36 RID: 2614
	private sealed class Class355 : GClass59.Class334
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x00238F48 File Offset: 0x00237148
		public override double vmethod_6()
		{
			return this.class333_0.vmethod_6();
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00238F60 File Offset: 0x00237160
		public override Type vmethod_8()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00238F78 File Offset: 0x00237178
		public override ushort vmethod_7()
		{
			return this.class333_0.vmethod_7();
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00238F90 File Offset: 0x00237190
		public override float vmethod_13()
		{
			return this.class333_0.vmethod_13();
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00238FA8 File Offset: 0x002371A8
		public override short vmethod_14()
		{
			return this.class333_0.vmethod_14();
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00238FC0 File Offset: 0x002371C0
		public override IntPtr vmethod_19()
		{
			while (IntPtr.Size == 4)
			{
			}
			return new IntPtr(this.vmethod_11());
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00238FE4 File Offset: 0x002371E4
		public override void vmethod_10(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = (Enum)object_0;
			this.class333_0 = GClass59.Class355.smethod_0(this.enum_0);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00239018 File Offset: 0x00237218
		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return this.class333_0.vmethod_5(type_0, bool_0);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00239034 File Offset: 0x00237234
		public override uint vmethod_18()
		{
			return this.class333_0.vmethod_18();
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0023904C File Offset: 0x0023724C
		public override sbyte vmethod_17()
		{
			return this.class333_0.vmethod_17();
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00239064 File Offset: 0x00237264
		public override ulong vmethod_4()
		{
			return this.class333_0.vmethod_4();
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0023907C File Offset: 0x0023727C
		public override TypeCode vmethod_2()
		{
			return this.class333_0.vmethod_2();
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00239094 File Offset: 0x00237294
		public override object vmethod_12()
		{
			return this.enum_0;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x002390A8 File Offset: 0x002372A8
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class355(this.enum_0);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x002390C0 File Offset: 0x002372C0
		public override byte vmethod_1()
		{
			return this.class333_0.vmethod_1();
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x002390D8 File Offset: 0x002372D8
		private static GClass59.Class333 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
					return new GClass59.Class335(Convert.ToInt32(enum_1));
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
					return new GClass59.Class335((int)Convert.ToUInt32(enum_1));
				case TypeCode.Int64:
					return new GClass59.Class336(Convert.ToInt64(enum_1));
				case TypeCode.UInt64:
					return new GClass59.Class336((long)Convert.ToUInt64(enum_1));
				default:
					throw new InvalidOperationException();
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0023914C File Offset: 0x0023734C
		public override long vmethod_11()
		{
			return this.class333_0.vmethod_11();
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00239164 File Offset: 0x00237364
		public override int vmethod_22()
		{
			return this.class333_0.vmethod_22();
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0023917C File Offset: 0x0023737C
		public override GClass59.Class333 vmethod_9()
		{
			return this.class333_0.vmethod_9();
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00239194 File Offset: 0x00237394
		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)this.vmethod_18()) : this.vmethod_4());
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x002391C0 File Offset: 0x002373C0
		public Class355(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = enum_1;
			this.class333_0 = GClass59.Class355.smethod_0(this.enum_0);
		}

		// Token: 0x040021E2 RID: 8674
		private GClass59.Class333 class333_0;

		// Token: 0x040021E3 RID: 8675
		private Enum enum_0;
	}

	// Token: 0x02000A37 RID: 2615
	private sealed class Class349 : GClass59.Class344
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x002391F4 File Offset: 0x002373F4
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class349(this.intptr_0, this.type_0);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00239214 File Offset: 0x00237414
		public override int vmethod_22()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0023922C File Offset: 0x0023742C
		public override Type vmethod_8()
		{
			return typeof(Pointer);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00239244 File Offset: 0x00237444
		public override byte vmethod_1()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0023925C File Offset: 0x0023745C
		public override double vmethod_6()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00239280 File Offset: 0x00237480
		public override short vmethod_14()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00239298 File Offset: 0x00237498
		public override float vmethod_13()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x002392BC File Offset: 0x002374BC
		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)Marshal.ReadInt32(this.intptr_0)) : ((ulong)Marshal.ReadInt64(this.intptr_0)));
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x002392F0 File Offset: 0x002374F0
		public override sbyte vmethod_17()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00239214 File Offset: 0x00237414
		public override uint vmethod_18()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0023930C File Offset: 0x0023750C
		public override ulong vmethod_4()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00236028 File Offset: 0x00234228
		public override TypeCode vmethod_2()
		{
			return TypeCode.Empty;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00239324 File Offset: 0x00237524
		public override char vmethod_3()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00239324 File Offset: 0x00237524
		public override ushort vmethod_7()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00239340 File Offset: 0x00237540
		public override object vmethod_12()
		{
			if (!this.type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(this.intptr_0, this.type_0);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0023930C File Offset: 0x0023750C
		public override long vmethod_11()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00239374 File Offset: 0x00237574
		public override void vmethod_10(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			Marshal.StructureToPtr(object_0, this.intptr_0, -796141539 != 0);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0023939C File Offset: 0x0023759C
		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)Marshal.ReadInt32(this.intptr_0)) : Marshal.ReadInt64(this.intptr_0));
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x002393D0 File Offset: 0x002375D0
		public Class349(IntPtr intptr_1, Type type_1)
		{
			this.intptr_0 = intptr_1;
			this.type_0 = type_1;
		}

		// Token: 0x040021E4 RID: 8676
		private Type type_0;

		// Token: 0x040021E5 RID: 8677
		private IntPtr intptr_0;
	}

	// Token: 0x02000A38 RID: 2616
	private sealed class Class364
	{
		// Token: 0x060018F6 RID: 6390 RVA: 0x002393F4 File Offset: 0x002375F4
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00239408 File Offset: 0x00237608
		public byte method_1()
		{
			return this.byte_0;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0023941C File Offset: 0x0023761C
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00239430 File Offset: 0x00237630
		public Class364(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_1 = int_2;
			this.int_0 = int_3;
		}

		// Token: 0x040021E6 RID: 8678
		private int int_0;

		// Token: 0x040021E7 RID: 8679
		private int int_1;

		// Token: 0x040021E8 RID: 8680
		private byte byte_0;
	}

	// Token: 0x02000A39 RID: 2617
	private sealed class Class365
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00239458 File Offset: 0x00237658
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0023946C File Offset: 0x0023766C
		public void method_1(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass59.Class364(byte_0, int_2, int_3));
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0023948C File Offset: 0x0023768C
		public int method_2(GClass59.Class365 class365_0)
		{
			if (class365_0 == null)
			{
				return 1;
			}
			int num = this.int_1.CompareTo(class365_0.method_4());
			if (num == 0)
			{
				num = class365_0.method_0().CompareTo(this.int_0);
			}
			return num;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x002394CC File Offset: 0x002376CC
		public List<GClass59.Class364> method_3()
		{
			return this.list_0;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x002394E0 File Offset: 0x002376E0
		public int method_4()
		{
			return this.int_1;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x002394F4 File Offset: 0x002376F4
		public Class365(int int_2, int int_3)
		{
			this.int_1 = int_2;
			this.int_0 = int_3;
		}

		// Token: 0x040021E9 RID: 8681
		private int int_0;

		// Token: 0x040021EA RID: 8682
		private List<GClass59.Class364> list_0 = new List<GClass59.Class364>();

		// Token: 0x040021EB RID: 8683
		private int int_1;
	}

	// Token: 0x02000A3A RID: 2618
	private sealed class Class350 : GClass59.Class344
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x00239520 File Offset: 0x00237720
		public override void vmethod_10(object object_1)
		{
			((GClass59.Class366)this.fieldInfo_0.GetValue(this.object_0)).vmethod_0((int)object_1);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00239550 File Offset: 0x00237750
		public override object vmethod_12()
		{
			return ((GClass59.Class366)this.fieldInfo_0.GetValue(this.object_0)).vmethod_1();
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00236494 File Offset: 0x00234694
		public override Type vmethod_8()
		{
			return typeof(int);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00239580 File Offset: 0x00237780
		public override GClass59.Class333 vmethod_24()
		{
			return new GClass59.Class350(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x002395A0 File Offset: 0x002377A0
		public Class350(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
		}

		// Token: 0x040021EC RID: 8684
		private object object_0;

		// Token: 0x040021ED RID: 8685
		private FieldInfo fieldInfo_0;
	}

	// Token: 0x02000A3B RID: 2619
	private abstract class Class366
	{
		// Token: 0x06001905 RID: 6405
		public abstract void vmethod_0(int int_0);

		// Token: 0x06001907 RID: 6407
		public abstract int vmethod_1();
	}

	// Token: 0x02000A3C RID: 2620
	private sealed class Class367 : GClass59.Class366
	{
		// Token: 0x06001908 RID: 6408 RVA: 0x002395C4 File Offset: 0x002377C4
		public int method_0()
		{
			return this.stack_0.Count;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x002395DC File Offset: 0x002377DC
		public override void vmethod_0(int int_0)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].method_4() == int_0)
				{
					this.stack_0.Push(i);
				}
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00239620 File Offset: 0x00237820
		public GClass59.Class365 method_1()
		{
			return this.list_0[this.stack_0.Pop()];
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00239644 File Offset: 0x00237844
		public GClass59.Class365 method_2()
		{
			return this.list_0[this.stack_0.Peek()];
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00236028 File Offset: 0x00234228
		public override int vmethod_1()
		{
			return 0;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00239668 File Offset: 0x00237868
		public Class367()
		{
			this.stack_0 = new Stack<int>();
			
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00239694 File Offset: 0x00237894
		public void method_3(int int_0, int int_1, byte byte_0, int int_2, int int_3)
		{
			GClass59.Class365 @class = null;
			for (int i = 0; i < this.list_0.Count; i += 605892737)
			{
				GClass59.Class365 class2 = this.list_0[i];
				if (class2.method_4() == int_0 && class2.method_0() == int_1)
				{
					@class = class2;
				IL_43:
					if (@class == null)
					{
						bool flag = false;
						@class = new GClass59.Class365(int_0, int_1);
						int j = 0;
						while (j < this.list_0.Count)
						{
							GClass59.Class365 class365_ = this.list_0[j];
							if (@class.method_2(class365_) >= 0)
							{
								j += 37244422;
							}
							else
							{
								this.list_0.Insert(j, @class);
								flag = true;
							IL_98:
								if (!flag)
								{
									this.list_0.Add(@class);
									goto IL_A8;
								}
								goto IL_A8;
							}
						}
						
					}
				IL_A8:
					@class.method_1(byte_0, int_2, int_3);
					return;
				}
			}
			
		}

		// Token: 0x040021EE RID: 8686
		private Stack<int> stack_0;

		// Token: 0x040021EF RID: 8687
		private List<GClass59.Class365> list_0 = new List<GClass59.Class365>();
	}

	// Token: 0x02000A3D RID: 2621
	private sealed class Class368 : GClass59.Class366
	{
		// Token: 0x0600190F RID: 6415 RVA: 0x00239758 File Offset: 0x00237958
		public GClass59.Class333 method_0(int int_1, GClass59.Class333 class333_0)
		{
			if (int_1 < 0)
			{
				int_1 += this.list_0.Count - 1;
			}
			this.list_0[int_1] = class333_0;
			return class333_0;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0023978C File Offset: 0x0023798C
		public void method_1()
		{
			while (this.list_0.Count > this.int_0)
			{
				this.list_0.RemoveAt(this.int_0);
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x002397C0 File Offset: 0x002379C0
		public override void vmethod_0(int int_1)
		{
			this.int_0 = int_1;
			for (int i = 0; i < this.int_0; i++)
			{
				this.list_0.Insert(0, null);
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x002397F4 File Offset: 0x002379F4
		public GClass59.Class333 method_2()
		{
			int index = this.list_0.Count - 1;
			return this.list_0[index];
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0023981C File Offset: 0x00237A1C
		public GClass59.Class333 method_3()
		{
			int index = this.list_0.Count - 1;
			GClass59.Class333 result = this.list_0[index];
			this.list_0.RemoveAt(index);
			return result;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00239870 File Offset: 0x00237A70
		public GClass59.Class333 method_4(int int_1)
		{
			if (int_1 < 0)
			{
				int_1 += this.list_0.Count - 1;
			}
			return this.list_0[int_1];
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x002398A0 File Offset: 0x00237AA0
		public void method_5(GClass59.Class333 class333_0)
		{
			this.list_0.Add(class333_0.vmethod_16());
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x002398C0 File Offset: 0x00237AC0
		public override int vmethod_1()
		{
			return this.list_0.Count;
		}

		// Token: 0x040021F0 RID: 8688
		private int int_0;

		// Token: 0x040021F1 RID: 8689
		private List<GClass59.Class333> list_0 = new List<GClass59.Class333>();
	}

	// Token: 0x02000A3E RID: 2622
	private sealed class Class369 : GClass59.Class366
	{
		// Token: 0x06001918 RID: 6424 RVA: 0x002398D8 File Offset: 0x00237AD8
		public unsafe int method_0()
		{
			int result = *(int*)(long_0 + int_0);
			int_0 += 4;
			return result;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00239904 File Offset: 0x00237B04
		public unsafe long method_1()
		{
			long result = *(long*)(long_0 + int_0);
			int_0 += 8;
			return result;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00239930 File Offset: 0x00237B30
		public unsafe short method_2()
		{
			short result = *(short*)(long_0 + int_0);
			int_0 += 2;
			return result;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0023995C File Offset: 0x00237B5C
		public int method_3()
		{
			return this.stack_0.Count;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00239974 File Offset: 0x00237B74
		public double method_4()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(this.method_1()), 0);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00239994 File Offset: 0x00237B94
		public void method_5()
		{
			this.stack_0.Clear();
			this.int_0 = 0;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x002399B4 File Offset: 0x00237BB4
		public override void vmethod_0(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x002399E8 File Offset: 0x00237BE8
		public void method_6()
		{
			this.int_0 = this.stack_0.Pop();
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00239A08 File Offset: 0x00237C08
		public float method_7()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(this.method_0()), 0);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00239A28 File Offset: 0x00237C28
		public unsafe byte method_8()
		{
			byte result = *(byte*)(long_0 + int_0);
			int_0++;
			return result;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00239A54 File Offset: 0x00237C54
		public void method_9(int int_1)
		{
			this.stack_0.Push(int_1);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00239AA0 File Offset: 0x00237CA0
		public override int vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x040021F2 RID: 8690
		private Stack<int> stack_0 = new Stack<int>();

		// Token: 0x040021F3 RID: 8691
		private int int_0;

		// Token: 0x040021F4 RID: 8692
		private static long long_0 = Marshal.GetHINSTANCE(typeof(GClass59).Module).ToInt64();
	}

	// Token: 0x02000A3F RID: 2623
	// (Invoke) Token: 0x06001928 RID: 6440
	internal delegate void Delegate3();
}
