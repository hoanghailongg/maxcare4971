using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

public class GClass59
{
	private static class Class329
	{
		public unsafe static void* smethod_0(object object_0)
		{
			return Pointer.Unbox(object_0);
		}

		public unsafe static object smethod_1(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}
	}

	private sealed class Class330
	{
		private enum Enum1
		{
			const_0 = 27,
			const_1 = 5,
			const_2 = 2,
			const_3 = 24,
			const_4 = 31,
			const_5 = 20,
			const_6 = 1,
			const_7 = 32,
			const_8 = 11,
			const_9 = 12,
			const_10 = 26,
			const_11 = 0,
			const_12 = 69,
			const_13 = 19,
			const_14 = 14,
			const_15 = 29,
			const_16 = 8,
			const_17 = 10,
			const_18 = 9,
			const_19 = 6,
			const_20 = 21,
			const_21 = 28,
			const_22 = 22,
			const_23 = 3,
			const_24 = 4,
			const_25 = 65,
			const_26 = 30,
			const_27 = 16,
			const_28 = 17,
			const_29 = 15,
			const_30 = 23,
			const_31 = 18,
			const_32 = 13,
			const_33 = 7,
			const_34 = 25
		}

		private int int_0;

		private byte[] byte_0;

		public uint method_0()
		{
			byte b = byte_0[int_0];
			if ((b & 0x80) == 0)
			{
				int_0++;
			}
			else if ((b & -1174405056) == 0)
			{
				int_0 += -1405798230;
			}
			else
			{
				int_0 += 4;
			}
			return 0u;
		}

		public byte method_1()
		{
			return byte_0[int_0++];
		}

		public Type method_2(Module module_0)
		{
			while (true)
			{
				bool flag = false;
				while (true)
				{
					IL_011b:
					bool flag2 = true;
					while (true)
					{
						if (!flag2)
						{
							Type type;
							switch (method_0())
							{
							case 10u:
							case 13u:
								break;
							case 1u:
								goto IL_0007;
							case 17u:
							case 18u:
								goto IL_00f6;
							case 25u:
								type = typeof(UIntPtr);
								if (1283207947u % 0u == 0)
								{
									goto IL_011b;
								}
								goto IL_0224;
							case 5u:
								type = typeof(byte);
								break;
							case 6u:
								type = typeof(short);
								break;
							case 9u:
								type = typeof(uint);
								break;
							case 0u:
								type = null;
								goto IL_0224;
							case 2u:
								type = typeof(bool);
								goto IL_0224;
							case 3u:
								type = typeof(char);
								goto IL_0224;
							case 4u:
								type = typeof(sbyte);
								goto IL_0224;
							case 7u:
								type = typeof(ushort);
								goto IL_0224;
							case 8u:
								type = typeof(int);
								goto IL_0224;
							case 11u:
								type = typeof(ulong);
								goto IL_0224;
							case 12u:
								type = typeof(float);
								goto IL_0224;
							case 14u:
								type = typeof(string);
								goto IL_0224;
							case 15u:
								type = method_2(module_0).MakePointerType();
								goto IL_0224;
							case 24u:
								type = typeof(IntPtr);
								goto IL_0224;
							default:
								throw new COMException(null, -2146233785);
							case 28u:
								type = typeof(object);
								goto IL_0224;
							case 29u:
								{
									type = method_2(module_0).MakeArrayType();
									goto IL_0224;
								}
								IL_0224:
								if (flag)
								{
									type = type.MakeByRefType();
								}
								return type;
							}
							break;
						}
						goto IL_0007;
						IL_0007:
						Enum1 @enum = (Enum1)method_1();
						if (@enum <= Enum1.const_7)
						{
							if (@enum == Enum1.const_27)
							{
								flag = true;
								break;
							}
							if ((uint)(@enum - 31) <= 1u)
							{
								method_0();
								continue;
							}
						}
						else if (@enum == (Enum1)189298457 || @enum == (Enum1)358127293)
						{
							continue;
						}
						flag2 = false;
						int_0--;
						continue;
						IL_00f6:
						method_0();
						goto IL_011b;
					}
					break;
				}
			}
		}

		public Class330(byte[] byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private enum Enum2
	{
		const_0 = 64,
		const_1 = 8,
		const_2 = 9,
		const_3 = 3,
		const_4 = 15,
		const_5 = 11,
		const_6 = 4,
		const_7 = 5,
		const_8 = 6,
		const_9 = 2,
		const_10 = 0,
		const_11 = 16,
		const_12 = 10,
		const_13 = 7,
		const_14 = 1,
		const_15 = 32
	}

	private sealed class Class331
	{
		private Type[] type_0;

		private Type type_1;

		private uint uint_0;

		private Enum2 enum2_0;

		public Type Type_0 => type_1;

		public CallingConvention CallingConvention_0 => (enum2_0 & Enum2.const_4) switch
		{
			Enum2.const_14 => (CallingConvention)1732859227, 
			Enum2.const_9 => (CallingConvention)573858877, 
			Enum2.const_3 => (CallingConvention)1476395012, 
			Enum2.const_6 => (CallingConvention)1476395012, 
			_ => CallingConvention.Winapi, 
		};

		public bool Boolean_0
		{
			get
			{
				switch (enum2_0 & Enum2.const_4)
				{
				default:
					return false;
				case Enum2.const_10:
				case Enum2.const_14:
				case Enum2.const_9:
				case Enum2.const_3:
				case Enum2.const_6:
				case Enum2.const_7:
				case Enum2.const_2:
				case Enum2.const_5:
					return true;
				}
			}
		}

		public void method_0(byte[] byte_0, Module module_0)
		{
			Class330 @class = new Class330(byte_0);
			enum2_0 = (Enum2)@class.method_1();
			if ((enum2_0 & Enum2.const_11) != 0)
			{
				uint_0 = @class.method_0();
			}
			switch (enum2_0 & Enum2.const_4)
			{
			default:
				throw new COMException(null, -2146233799);
			case Enum2.const_8:
				type_1 = @class.method_2(module_0);
				break;
			case Enum2.const_13:
			case Enum2.const_12:
			{
				uint num2 = @class.method_0();
				type_0 = new Type[num2];
				for (int j = 0; j < num2; j++)
				{
					type_0[j] = @class.method_2(module_0);
				}
				break;
			}
			case Enum2.const_10:
			case Enum2.const_14:
			case Enum2.const_9:
			case Enum2.const_3:
			case Enum2.const_6:
			case Enum2.const_7:
			case Enum2.const_1:
			case Enum2.const_2:
			case Enum2.const_5:
			{
				uint num = @class.method_0();
				type_1 = @class.method_2(module_0);
				type_0 = new Type[num];
				for (int i = 0; i < num; i++)
				{
					type_0[i] = @class.method_2(module_0);
				}
				break;
			}
			}
		}

		public Type[] method_1()
		{
			return type_0;
		}
	}

	private sealed class Class332 : IDisposable
	{
		private List<GCHandle> list_0 = new List<GCHandle>();

		public void Dispose()
		{
			foreach (GCHandle item in list_0)
			{
				item.Free();
			}
			list_0.Clear();
		}

		public IntPtr method_0(object object_0)
		{
			GCHandle item = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			list_0.Add(item);
			return item.AddrOfPinnedObject();
		}
	}

	private abstract class Class333
	{
		public unsafe virtual void* vmethod_0()
		{
			throw new InvalidOperationException();
		}

		public virtual byte vmethod_1()
		{
			return Convert.ToByte(vmethod_12());
		}

		public virtual TypeCode vmethod_2()
		{
			throw new InvalidOperationException();
		}

		public virtual char vmethod_3()
		{
			return Convert.ToChar(vmethod_12());
		}

		public virtual ulong vmethod_4()
		{
			return Convert.ToUInt64(vmethod_12());
		}

		public override string ToString()
		{
			object obj = vmethod_12();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		public virtual object vmethod_5(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		public virtual double vmethod_6()
		{
			return Convert.ToDouble(vmethod_12());
		}

		public virtual ushort vmethod_7()
		{
			return Convert.ToUInt16(vmethod_12());
		}

		public virtual Type vmethod_8()
		{
			throw new InvalidOperationException();
		}

		public virtual Class333 vmethod_9()
		{
			return this;
		}

		public abstract void vmethod_10(object object_0);

		public virtual long vmethod_11()
		{
			return Convert.ToInt64(vmethod_12());
		}

		public abstract object vmethod_12();

		public virtual float vmethod_13()
		{
			return Convert.ToSingle(vmethod_12());
		}

		public virtual short vmethod_14()
		{
			return Convert.ToInt16(vmethod_12());
		}

		public virtual bool vmethod_15()
		{
			return Convert.ToBoolean(vmethod_12());
		}

		public virtual Class334 vmethod_16()
		{
			throw new InvalidOperationException();
		}

		public virtual sbyte vmethod_17()
		{
			return Convert.ToSByte(vmethod_12());
		}

		public virtual uint vmethod_18()
		{
			return Convert.ToUInt32(vmethod_12());
		}

		public virtual IntPtr vmethod_19()
		{
			object obj;
			do
			{
				obj = vmethod_12();
			}
			while (obj != null);
			if (!(null == typeof(IntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (IntPtr)obj;
		}

		public virtual void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_12();
			fieldInfo_0.SetValue(obj, object_0);
		}

		public virtual bool vmethod_21()
		{
			return false;
		}

		public virtual int vmethod_22()
		{
			return Convert.ToInt32(vmethod_12());
		}

		public virtual UIntPtr vmethod_23()
		{
			object obj = vmethod_12();
			if (!(obj?.GetType() == typeof(UIntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		public abstract Class333 vmethod_24();
	}

	private abstract class Class334 : Class333
	{
		public override TypeCode vmethod_2()
		{
			return TypeCode.Empty;
		}

		public override Class334 vmethod_16()
		{
			return this;
		}
	}

	private sealed class Class335 : Class334
	{
		private int int_0;

		public override void vmethod_10(object object_0)
		{
			int_0 = Convert.ToInt32(object_0);
		}

		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class333 vmethod_9()
		{
			return new Class362((uint)int_0);
		}

		public static Class333 smethod_0(Class333 class333_0)
		{
			return new Class335(~class333_0.vmethod_22());
		}

		public static Class333 smethod_1(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
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

		public static Class333 smethod_2(Class333 class333_0, Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new Class335(num ^ num2);
		}

		public static Class333 smethod_3(Class333 class333_0, Class333 class333_1, bool bool_0)
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

		public override ushort vmethod_7()
		{
			return (ushort)int_0;
		}

		public override float vmethod_13()
		{
			return int_0;
		}

		public static Class333 smethod_4(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			int int_;
			if (bool_0)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				int_ = (int)(num / num2);
			}
			else
			{
				int num3 = class333_0.vmethod_22();
				int num4 = class333_1.vmethod_22();
				int_ = num3 / num4;
			}
			return new Class335(int_);
		}

		public override double vmethod_6()
		{
			return int_0;
		}

		public override byte vmethod_1()
		{
			return (byte)int_0;
		}

		public override short vmethod_14()
		{
			return (short)int_0;
		}

		public override long vmethod_11()
		{
			return int_0;
		}

		public override bool vmethod_15()
		{
			return int_0 != 0;
		}

		public override int vmethod_22()
		{
			return int_0;
		}

		public static Class333 smethod_5(Class333 class333_0, Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new Class335(num << num2);
		}

		public static Class333 smethod_6(Class333 class333_0, Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new Class335(num & num2);
		}

		public static Class333 smethod_7(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				uint num = class333_0.vmethod_18();
				uint num2 = class333_1.vmethod_18();
				return new Class335((int)(num % num2));
			}
			int num3 = class333_0.vmethod_22();
			int num4 = class333_1.vmethod_22();
			return new Class335(num3 % num4);
		}

		public static Class333 smethod_8(Class333 class333_0, Class333 class333_1)
		{
			int num = class333_0.vmethod_22();
			int num2 = class333_1.vmethod_22();
			return new Class335(num | num2);
		}

		public override IntPtr vmethod_19()
		{
			return new IntPtr(int_0);
		}

		public static Class333 smethod_9(Class333 class333_0)
		{
			return new Class335(-class333_0.vmethod_22());
		}

		public static Class333 smethod_10(Class333 class333_0, Class333 class333_1, bool bool_0)
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

		public static Class333 smethod_11(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
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
			return new Class335(int_);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)int_0;
		}

		public static Class333 smethod_12(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			uint num = default(uint);
			if (bool_1)
			{
				num = class333_0.vmethod_18();
			}
			else
			{
				class333_0.vmethod_22();
				class333_1.vmethod_22();
			}
			uint num2 = class333_1.vmethod_18();
			int int_ = (int)(bool_0 ? checked(num * num2) : (num * num2));
			return new Class335(int_);
		}

		public override Type vmethod_8()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Int32;
		}

		public override ulong vmethod_4()
		{
			return (uint)int_0;
		}

		public override char vmethod_3()
		{
			return (char)int_0;
		}

		public override uint vmethod_18()
		{
			return (uint)int_0;
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					if (IntPtr.Size != 4)
					{
						return new IntPtr(unchecked(bool_0 ? ((long)(uint)int_0) : ((long)int_0)));
					}
				}
				else if (!(type_0 == typeof(UIntPtr)))
				{
					return Type.GetTypeCode(type_0) switch
					{
						TypeCode.SByte => bool_0 ? ((sbyte)(uint)int_0) : ((sbyte)int_0), 
						TypeCode.Byte => bool_0 ? ((byte)(uint)int_0) : ((byte)int_0), 
						TypeCode.Int16 => bool_0 ? ((short)(uint)int_0) : ((short)int_0), 
						TypeCode.UInt16 => bool_0 ? ((ushort)(uint)int_0) : ((ushort)int_0), 
						TypeCode.Int32 => bool_0 ? ((int)(uint)int_0) : int_0, 
						TypeCode.UInt32 => bool_0 ? unchecked((uint)int_0) : ((uint)int_0), 
						TypeCode.Int64 => unchecked(bool_0 ? ((long)(uint)int_0) : ((long)int_0)), 
						TypeCode.UInt64 => bool_0 ? unchecked((uint)int_0) : ((uint)int_0), 
						TypeCode.Double => bool_0 ? ((double)unchecked((uint)int_0)) : ((double)int_0), 
						_ => throw new ArgumentException(), 
					};
				}
				return new IntPtr(bool_0 ? ((int)(uint)int_0) : int_0);
			}
		}

		public override object vmethod_12()
		{
			return int_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class335(int_0);
		}

		public Class335(int int_1)
		{
			int_0 = int_1;
		}
	}

	private sealed class Class336 : Class334
	{
		private long long_0;

		public override ulong vmethod_4()
		{
			return (ulong)long_0;
		}

		public override void vmethod_10(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public static Class333 smethod_0(Class333 class333_0, Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new Class336(num ^ num2);
		}

		public static Class333 smethod_1(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			while (!bool_1)
			{
				class333_0.vmethod_11();
				class333_1.vmethod_11();
			}
			ulong num = class333_0.vmethod_4();
			ulong num2 = class333_1.vmethod_4();
			long long_ = (long)(bool_0 ? checked(num - num2) : (num - num2));
			return new Class336(long_);
		}

		public unsafe override void* vmethod_0()
		{
			return vmethod_19().ToPointer();
		}

		public override int vmethod_22()
		{
			return (int)long_0;
		}

		public override float vmethod_13()
		{
			return long_0;
		}

		public override object vmethod_12()
		{
			return long_0;
		}

		public static Class333 smethod_2(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
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
			return new Class336(long_);
		}

		public static Class333 smethod_3(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				ulong num = class333_0.vmethod_4();
				int num2 = class333_1.vmethod_22();
				return new Class336((long)(num >> num2));
			}
			long num3 = class333_0.vmethod_11();
			int num4 = class333_1.vmethod_22();
			return new Class336(num3 >> (num4 & 0x3C));
		}

		public static Class333 smethod_4(Class333 class333_0, Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new Class336(num | num2);
		}

		public static Class333 smethod_5(Class333 class333_0)
		{
			return new Class336(-class333_0.vmethod_11());
		}

		public static Class333 smethod_6(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
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
			return new Class336(long_);
		}

		public override double vmethod_6()
		{
			return long_0;
		}

		public static Class333 smethod_7(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			if (bool_0)
			{
				ulong num = class333_0.vmethod_4();
				ulong num2 = class333_1.vmethod_4();
				return new Class336((long)(num % num2));
			}
			long num3 = class333_0.vmethod_11();
			long num4 = class333_1.vmethod_11();
			return new Class336(num3 % num4);
		}

		public override short vmethod_14()
		{
			return (short)long_0;
		}

		public override byte vmethod_1()
		{
			return (byte)long_0;
		}

		public static Class333 smethod_8(Class333 class333_0)
		{
			return new Class336(~class333_0.vmethod_11());
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			long value;
			if (!(type_0 == typeof(IntPtr)))
			{
				if (type_0 == typeof(UIntPtr))
				{
					if (bool_0)
					{
						goto IL_0135;
					}
					value = (long)checked((ulong)long_0);
					goto IL_013b;
				}
				checked
				{
					switch (Type.GetTypeCode(type_0))
					{
					case TypeCode.SByte:
						return bool_0 ? ((sbyte)(ulong)long_0) : ((sbyte)long_0);
					case TypeCode.Byte:
						return bool_0 ? ((byte)(ulong)long_0) : ((byte)long_0);
					case TypeCode.Int16:
						return bool_0 ? ((short)(ulong)long_0) : ((short)long_0);
					case TypeCode.Int32:
						if (bool_0)
						{
							return (int)(ulong)long_0;
						}
						break;
					case TypeCode.UInt16:
						break;
					case TypeCode.UInt32:
						return bool_0 ? ((uint)(ulong)long_0) : ((uint)long_0);
					case TypeCode.Int64:
						return bool_0 ? ((long)(ulong)long_0) : long_0;
					case TypeCode.UInt64:
						goto IL_0125;
					default:
						throw new ArgumentException();
					case TypeCode.Double:
						return bool_0 ? ((double)unchecked((ulong)long_0)) : ((double)long_0);
					}
				}
			}
			return new IntPtr(bool_0 ? checked((long)(ulong)long_0) : long_0);
			IL_0125:
			if (!bool_0)
			{
				return checked((ulong)long_0);
			}
			goto IL_0135;
			IL_0135:
			value = long_0;
			goto IL_013b;
			IL_013b:
			return new UIntPtr((ulong)value);
		}

		public static Class333 smethod_9(Class333 class333_0, Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			int num2 = class333_1.vmethod_22();
			return new Class336(num << num2);
		}

		public override Class333 vmethod_9()
		{
			return new Class363((ulong)long_0);
		}

		public override char vmethod_3()
		{
			return (char)long_0;
		}

		public override bool vmethod_15()
		{
			return (ulong)long_0 > 0uL;
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Int64;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)long_0;
		}

		public static Class333 smethod_10(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			long long_;
			if (bool_0)
			{
				ulong num = class333_0.vmethod_4();
				ulong num2 = class333_1.vmethod_4();
				long_ = (long)(num / num2);
			}
			else
			{
				long num3 = class333_0.vmethod_11();
				long num4 = class333_1.vmethod_11();
				long_ = num3 / num4;
			}
			return new Class336(long_);
		}

		public override uint vmethod_18()
		{
			return (uint)long_0;
		}

		public override ushort vmethod_7()
		{
			return (ushort)long_0;
		}

		public override Type vmethod_8()
		{
			return typeof(long);
		}

		public override Class333 vmethod_24()
		{
			return new Class336(long_0);
		}

		public static Class333 smethod_11(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			ulong num = default(ulong);
			ulong num2 = default(ulong);
			if (bool_0)
			{
				num = class333_0.vmethod_4();
				num2 = class333_1.vmethod_4();
			}
			else
			{
				class333_0.vmethod_11();
			}
			int int_ = ((num == num2) ? 1 : ((num > num2) ? 922966503 : 8));
			return new Class335(int_);
		}

		public override long vmethod_11()
		{
			return long_0;
		}

		public static Class333 smethod_12(Class333 class333_0, Class333 class333_1)
		{
			long num = class333_0.vmethod_11();
			long num2 = class333_1.vmethod_11();
			return new Class336(num & num2);
		}

		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)long_0) : long_0);
		}

		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)long_0) : long_0));
		}

		public Class336(long long_1)
		{
			long_0 = long_1;
		}
	}

	private sealed class Class337 : Class334
	{
		private float float_0;

		public static Class333 smethod_0(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new Class337(bool_0 ? (num * num2) : (num * num2));
		}

		public static Class333 smethod_1(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new Class337(bool_0 ? (num - num2) : (num - num2));
		}

		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)float_0) : ((long)float_0));
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)float_0;
		}

		public override uint vmethod_18()
		{
			return (uint)float_0;
		}

		public override ushort vmethod_7()
		{
			return (ushort)float_0;
		}

		public override byte vmethod_1()
		{
			return (byte)float_0;
		}

		public static Class333 smethod_2(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			float num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			int int_ = ((num == num2) ? 1 : ((num > num2) ? (-2050529080) : (-294044691)));
			return new Class335(int_);
		}

		public override void vmethod_10(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override short vmethod_14()
		{
			return (short)float_0;
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Single;
		}

		public static Class333 smethod_3(Class333 class333_0)
		{
			return new Class337(0f - class333_0.vmethod_13());
		}

		public override int vmethod_22()
		{
			return (int)float_0;
		}

		public override object vmethod_12()
		{
			return float_0;
		}

		public override ulong vmethod_4()
		{
			return (ulong)float_0;
		}

		public override char vmethod_3()
		{
			return (char)float_0;
		}

		public static Class333 smethod_4(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			float num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new Class337(bool_0 ? (num + num2) : (num + num2));
		}

		public override bool vmethod_15()
		{
			return Convert.ToBoolean(float_0);
		}

		public static Class333 smethod_5(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			float num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_13();
			float num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_13();
			return new Class337(num / num2);
		}

		public override long vmethod_11()
		{
			return (long)float_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class337(float_0);
		}

		public override Type vmethod_8()
		{
			return typeof(float);
		}

		public override float vmethod_13()
		{
			return float_0;
		}

		public override double vmethod_6()
		{
			return float_0;
		}

		public override UIntPtr vmethod_23()
		{
			if (IntPtr.Size != 4)
			{
			}
			return new UIntPtr((ulong)float_0);
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				while (!(type_0 == typeof(IntPtr)))
				{
					if (!(type_0 == typeof(UIntPtr)))
					{
						while (true)
						{
							switch (Type.GetTypeCode(type_0))
							{
							case TypeCode.Int32:
								break;
							case TypeCode.Int16:
								if (!bool_0)
								{
									continue;
								}
								return (short)(uint)float_0;
							case TypeCode.SByte:
								return bool_0 ? ((sbyte)(uint)float_0) : ((sbyte)float_0);
							case TypeCode.Byte:
								goto end_IL_0000;
							case TypeCode.UInt16:
								return (ushort)float_0;
							case TypeCode.UInt32:
								return (uint)float_0;
							default:
								throw new ArgumentException();
							case TypeCode.UInt64:
								return (ulong)float_0;
							}
							break;
						}
						continue;
					}
					return new UIntPtr((ulong)float_0);
					continue;
					end_IL_0000:
					break;
				}
				return new IntPtr((long)float_0);
			}
		}

		public Class337(float float_1)
		{
			float_0 = float_1;
		}
	}

	private sealed class Class338 : Class334
	{
		private double double_0;

		public static Class333 smethod_0(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			double num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new Class338(bool_0 ? (num + num2) : (num + num2));
		}

		public static Class333 smethod_1(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			double num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new Class338(num / num2);
		}

		public override char vmethod_3()
		{
			return (char)double_0;
		}

		public override void vmethod_10(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override short vmethod_14()
		{
			return (short)double_0;
		}

		public override byte vmethod_1()
		{
			return (byte)double_0;
		}

		public override object vmethod_12()
		{
			return double_0;
		}

		public override Type vmethod_8()
		{
			return typeof(double);
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)double_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)double_0);
				}
				return Type.GetTypeCode(type_0) switch
				{
					TypeCode.SByte => bool_0 ? ((sbyte)(uint)double_0) : ((sbyte)double_0), 
					TypeCode.Byte => (byte)double_0, 
					TypeCode.Int16 => bool_0 ? ((short)(uint)double_0) : ((short)double_0), 
					TypeCode.UInt16 => (ushort)double_0, 
					TypeCode.Int32 => (int)double_0, 
					TypeCode.UInt32 => (uint)double_0, 
					TypeCode.Int64 => (long)double_0, 
					TypeCode.UInt64 => (ulong)double_0, 
					TypeCode.Double => double_0, 
					_ => throw new ArgumentException(), 
				};
			}
		}

		public static Class333 smethod_2(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			double num = (bool_1 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new Class338(bool_0 ? (num * num2) : (num * num2));
		}

		public override long vmethod_11()
		{
			return (long)double_0;
		}

		public static Class333 smethod_3(Class333 class333_0, Class333 class333_1, bool bool_0)
		{
			double num = (bool_0 ? class333_0.vmethod_9() : class333_0).vmethod_6();
			double num2 = (bool_0 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			int int_ = ((num == num2) ? 1 : ((num > num2) ? (-2068882236) : (-1442115366)));
			return new Class335(int_);
		}

		public static Class333 smethod_4(Class333 class333_0)
		{
			return new Class338(0.0 - class333_0.vmethod_6());
		}

		public override int vmethod_22()
		{
			return (int)double_0;
		}

		public override bool vmethod_15()
		{
			return Convert.ToBoolean(double_0);
		}

		public override IntPtr vmethod_19()
		{
			while (IntPtr.Size == 4)
			{
			}
			return new IntPtr((long)double_0);
		}

		public override double vmethod_6()
		{
			return double_0;
		}

		public static Class333 smethod_5(Class333 class333_0, Class333 class333_1, bool bool_0, bool bool_1)
		{
			while (bool_1)
			{
			}
			double num = class333_0.vmethod_6();
			double num2 = (bool_1 ? class333_1.vmethod_9() : class333_1).vmethod_6();
			return new Class338(bool_0 ? (num - num2) : (num - num2));
		}

		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)double_0) : ((ulong)double_0));
		}

		public override ushort vmethod_7()
		{
			return (ushort)double_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)double_0;
		}

		public override uint vmethod_18()
		{
			return (uint)double_0;
		}

		public override float vmethod_13()
		{
			return (float)double_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class338(double_0);
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Double;
		}

		public override ulong vmethod_4()
		{
			return (ulong)double_0;
		}

		public Class338(double double_1)
		{
			double_0 = double_1;
		}
	}

	private sealed class Class339 : Class334
	{
		private string string_0;

		public override TypeCode vmethod_2()
		{
			return TypeCode.Object;
		}

		public override object vmethod_12()
		{
			return string_0;
		}

		public override Type vmethod_8()
		{
			return typeof(string);
		}

		public override string ToString()
		{
			return string_0;
		}

		public override void vmethod_10(object object_0)
		{
			string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		public override Class333 vmethod_24()
		{
			return new Class339(string_0);
		}

		public override bool vmethod_15()
		{
			return string_0 != null;
		}

		public Class339(string string_1)
		{
			string_0 = string_1;
		}
	}

	private sealed class Class356 : Class333
	{
		private short short_0;

		public override Class333 vmethod_24()
		{
			return new Class356(short_0);
		}

		public override ushort vmethod_7()
		{
			return (ushort)short_0;
		}

		public override object vmethod_12()
		{
			return short_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public override uint vmethod_18()
		{
			return (uint)short_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)short_0;
		}

		public override Type vmethod_8()
		{
			return typeof(short);
		}

		public override void vmethod_10(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override int vmethod_22()
		{
			return short_0;
		}

		public override short vmethod_14()
		{
			return short_0;
		}

		public override byte vmethod_1()
		{
			return (byte)short_0;
		}

		public Class356(short short_1)
		{
			short_0 = short_1;
		}
	}

	private sealed class Class357 : Class333
	{
		private ushort ushort_0;

		public override uint vmethod_18()
		{
			return ushort_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)ushort_0;
		}

		public override short vmethod_14()
		{
			return (short)ushort_0;
		}

		public override ushort vmethod_7()
		{
			return ushort_0;
		}

		public override void vmethod_10(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override object vmethod_12()
		{
			return ushort_0;
		}

		public override int vmethod_22()
		{
			return ushort_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class357(ushort_0);
		}

		public override Type vmethod_8()
		{
			return typeof(ushort);
		}

		public override byte vmethod_1()
		{
			return (byte)ushort_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public Class357(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}
	}

	private sealed class Class358 : Class333
	{
		private bool bool_0;

		public override int vmethod_22()
		{
			if (!bool_0)
			{
				return 0;
			}
			return 1;
		}

		public override Type vmethod_8()
		{
			return typeof(bool);
		}

		public override void vmethod_10(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override object vmethod_12()
		{
			return bool_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public override Class333 vmethod_24()
		{
			return new Class358(bool_0);
		}

		public Class358(bool bool_1)
		{
			bool_0 = bool_1;
		}
	}

	private sealed class Class359 : Class333
	{
		private char char_0;

		public override Class333 vmethod_24()
		{
			return new Class359(char_0);
		}

		public override short vmethod_14()
		{
			return (short)char_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)char_0;
		}

		public override uint vmethod_18()
		{
			return char_0;
		}

		public override int vmethod_22()
		{
			return char_0;
		}

		public override Type vmethod_8()
		{
			return typeof(char);
		}

		public override void vmethod_10(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override object vmethod_12()
		{
			return char_0;
		}

		public override ushort vmethod_7()
		{
			return char_0;
		}

		public override byte vmethod_1()
		{
			return (byte)char_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public Class359(char char_1)
		{
			char_0 = char_1;
		}
	}

	private sealed class Class360 : Class333
	{
		private byte byte_0;

		public override byte vmethod_1()
		{
			return byte_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public override short vmethod_14()
		{
			return byte_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class360(byte_0);
		}

		public override object vmethod_12()
		{
			return byte_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)byte_0;
		}

		public override uint vmethod_18()
		{
			return byte_0;
		}

		public override int vmethod_22()
		{
			return byte_0;
		}

		public override ushort vmethod_7()
		{
			return byte_0;
		}

		public override Type vmethod_8()
		{
			return typeof(byte);
		}

		public override void vmethod_10(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public Class360(byte byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private sealed class Class361 : Class333
	{
		private sbyte sbyte_0;

		public override int vmethod_22()
		{
			return sbyte_0;
		}

		public override object vmethod_12()
		{
			return sbyte_0;
		}

		public override Type vmethod_8()
		{
			return typeof(sbyte);
		}

		public override byte vmethod_1()
		{
			return (byte)sbyte_0;
		}

		public override ushort vmethod_7()
		{
			return (ushort)sbyte_0;
		}

		public override uint vmethod_18()
		{
			return (uint)sbyte_0;
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public override Class333 vmethod_24()
		{
			return new Class361(sbyte_0);
		}

		public override short vmethod_14()
		{
			return sbyte_0;
		}

		public override void vmethod_10(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override sbyte vmethod_17()
		{
			return sbyte_0;
		}

		public Class361(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}
	}

	private sealed class Class362 : Class333
	{
		private uint uint_0;

		public override Type vmethod_8()
		{
			return typeof(uint);
		}

		public override short vmethod_14()
		{
			return (short)uint_0;
		}

		public override ushort vmethod_7()
		{
			return (ushort)uint_0;
		}

		public override void vmethod_10(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override byte vmethod_1()
		{
			return (byte)uint_0;
		}

		public override object vmethod_12()
		{
			return uint_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)uint_0;
		}

		public override uint vmethod_18()
		{
			return uint_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class362(uint_0);
		}

		public override Class334 vmethod_16()
		{
			return new Class335(vmethod_22());
		}

		public override int vmethod_22()
		{
			return (int)uint_0;
		}

		public Class362(uint uint_1)
		{
			uint_0 = uint_1;
		}
	}

	private sealed class Class363 : Class333
	{
		private ulong ulong_0;

		public override sbyte vmethod_17()
		{
			return (sbyte)ulong_0;
		}

		public override object vmethod_12()
		{
			return ulong_0;
		}

		public override uint vmethod_18()
		{
			return (uint)ulong_0;
		}

		public override byte vmethod_1()
		{
			return (byte)ulong_0;
		}

		public override long vmethod_11()
		{
			return (long)ulong_0;
		}

		public override int vmethod_22()
		{
			return (int)ulong_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class363(ulong_0);
		}

		public override short vmethod_14()
		{
			return (short)ulong_0;
		}

		public override ulong vmethod_4()
		{
			return ulong_0;
		}

		public override void vmethod_10(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class334 vmethod_16()
		{
			return new Class336(vmethod_11());
		}

		public override ushort vmethod_7()
		{
			return (ushort)ulong_0;
		}

		public override Type vmethod_8()
		{
			return typeof(ulong);
		}

		public Class363(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}
	}

	private sealed class Class340 : Class334
	{
		private object object_0;

		public override bool vmethod_15()
		{
			return object_0 != null;
		}

		public static Class333 smethod_0(Class333 class333_0, Class333 class333_1)
		{
			object obj = class333_0.vmethod_12();
			object obj2 = class333_1.vmethod_12();
			int int_ = ((obj == obj2) ? 1 : ((obj2 == null) ? 421481213 : 30542));
			return new Class335(int_);
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Object;
		}

		public override Class333 vmethod_24()
		{
			return new Class340(object_0);
		}

		public override Type vmethod_8()
		{
			return typeof(object);
		}

		public override void vmethod_10(object object_1)
		{
			object_0 = object_1;
		}

		public override object vmethod_12()
		{
			return object_0;
		}

		public Class340(object object_1)
		{
			object_0 = object_1;
		}
	}

	private sealed class Class341 : Class334
	{
		private Type type_0;

		private Class333 class333_0;

		private object object_0;

		public unsafe static Class333 smethod_0(Class333 class333_1, Class333 class333_2, bool bool_0, bool bool_1)
		{
			while (class333_1 is Class341)
			{
			}
			Class341 @class = (Class341)class333_2;
			if (@class.vmethod_2() == TypeCode.UInt32)
			{
				int value;
				if (bool_1)
				{
					uint num = class333_1.vmethod_18();
					uint num2 = class333_2.vmethod_18();
					value = (int)(bool_0 ? checked(num + num2) : (num + num2));
				}
				else
				{
					int num3 = class333_1.vmethod_22();
					int num4 = class333_2.vmethod_22();
					value = (bool_0 ? checked(num3 + num4) : (num3 + num4));
				}
				return new Class341(Pointer.Box(new IntPtr(value).ToPointer(), @class.vmethod_8()), @class.vmethod_8());
			}
			long value2;
			if (bool_1)
			{
				ulong num5 = class333_1.vmethod_4();
				ulong num6 = class333_2.vmethod_4();
				value2 = (long)(bool_0 ? checked(num5 + num6) : (num5 + num6));
			}
			else
			{
				long num7 = class333_1.vmethod_11();
				long num8 = class333_2.vmethod_11();
				value2 = (bool_0 ? checked(num7 + num8) : (num7 + num8));
			}
			return new Class341(Pointer.Box(new IntPtr(value2).ToPointer(), @class.vmethod_8()), @class.vmethod_8());
		}

		public unsafe static Class333 smethod_1(Class333 class333_1, Class333 class333_2, bool bool_0, bool bool_1)
		{
			Class341 @class;
			while (true)
			{
				object obj;
				if (!(class333_1 is Class341))
				{
					obj = (Class341)class333_2;
					goto IL_0009;
				}
				goto IL_002c;
				IL_0009:
				@class = (Class341)obj;
				if (@class.vmethod_2() != TypeCode.UInt32)
				{
					if (bool_1)
					{
						class333_1.vmethod_4();
						class333_2.vmethod_4();
						if (!bool_0)
						{
							continue;
						}
						goto IL_002c;
					}
					long num = class333_1.vmethod_11();
					long num2 = class333_2.vmethod_11();
					if (bool_0)
					{
						_ = num - num2;
					}
					else
						_ = num - num2;
					continue;
				}
				if (bool_1)
				{
					break;
				}
				class333_1.vmethod_22();
				class333_2.vmethod_22();
				continue;
				IL_002c:
				obj = (Class341)class333_1;
				goto IL_0009;
			}
			uint num3 = class333_1.vmethod_18();
			uint num4 = class333_2.vmethod_18();
			int value = (int)(bool_0 ? checked(num3 - num4) : (num3 - num4));
			return new Class341(Pointer.Box(new IntPtr(value).ToPointer(), @class.vmethod_8()), @class.vmethod_8());
		}

		public override IntPtr vmethod_19()
		{
			return class333_0.vmethod_19();
		}

		public override byte vmethod_1()
		{
			return class333_0.vmethod_1();
		}

		public override UIntPtr vmethod_23()
		{
			return class333_0.vmethod_23();
		}

		public override float vmethod_13()
		{
			return class333_0.vmethod_13();
		}

		public override TypeCode vmethod_2()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		public unsafe override void* vmethod_0()
		{
			return Pointer.Unbox(object_0);
		}

		public override int vmethod_22()
		{
			return class333_0.vmethod_22();
		}

		public override short vmethod_14()
		{
			return class333_0.vmethod_14();
		}

		public override uint vmethod_18()
		{
			return class333_0.vmethod_18();
		}

		public override Class333 vmethod_24()
		{
			return new Class341(object_0, type_0);
		}

		public override long vmethod_11()
		{
			return class333_0.vmethod_11();
		}

		public override ulong vmethod_4()
		{
			return class333_0.vmethod_4();
		}

		public override ushort vmethod_7()
		{
			return class333_0.vmethod_7();
		}

		public override object vmethod_5(Type type_1, bool bool_0)
		{
			return class333_0.vmethod_5(type_1, bool_0);
		}

		public override void vmethod_10(object object_1)
		{
			object_0 = object_1;
			class333_0 = smethod_2(object_1);
		}

		public override bool vmethod_15()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_17()
		{
			return class333_0.vmethod_17();
		}

		public override Type vmethod_8()
		{
			return type_0;
		}

		public override double vmethod_6()
		{
			return class333_0.vmethod_6();
		}

		public override object vmethod_12()
		{
			return object_0;
		}

		private unsafe static Class333 smethod_2(object object_1)
		{
			IntPtr intPtr = ((object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1)));
			if (IntPtr.Size == 4)
			{
				return new Class335(intPtr.ToInt32());
			}
			return new Class336(intPtr.ToInt64());
		}

		public static Class333 smethod_3(Class333 class333_1, Class333 class333_2, bool bool_0)
		{
			int int_;
			if (((class333_1 is Class341) ? ((Class341)class333_1) : ((Class341)class333_2)).vmethod_2() == TypeCode.UInt32)
			{
				while (true)
				{
					if (bool_0)
					{
						uint num = class333_1.vmethod_18();
						uint num2 = class333_2.vmethod_18();
						if (num == num2)
						{
							int_ = 1;
							break;
						}
						continue;
					}
					int num3 = class333_1.vmethod_22();
					int num4 = class333_2.vmethod_22();
					int_ = ((num3 == num4) ? 1 : ((num3 > num4) ? (-193) : (-400822264)));
					break;
				}
			}
			else if (bool_0)
			{
				ulong num5 = class333_1.vmethod_4();
				ulong num6 = class333_2.vmethod_4();
				int_ = ((num5 != num6) ? ((num5 > num6) ? (-1127848869) : 1796502) : 655242457);
			}
			else
			{
				long num7 = class333_1.vmethod_11();
				long num8 = class333_2.vmethod_11();
				int_ = ((num7 != num8) ? ((num7 > num8) ? 1021599840 : (-16448)) : 1289303481);
			}
			return new Class335(int_);
		}

		public Class341(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class333_0 = smethod_2(object_1);
		}
	}

	private sealed class Class342 : Class334
	{
		private object object_0;

		public override void vmethod_10(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}

		public override object vmethod_12()
		{
			return object_0;
		}

		public override Type vmethod_8()
		{
			return typeof(ValueType);
		}

		public override Class333 vmethod_24()
		{
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				Type type = object_0.GetType();
				FieldInfo[] fields = type.GetFields((BindingFlags)1782787206);
				obj = Activator.CreateInstance(type);
				FieldInfo[] array = fields;
				for (int i = 39; i < array.Length; i++)
				{
					FieldInfo fieldInfo = array[i];
					fieldInfo.SetValue(obj, fieldInfo.GetValue(object_0));
				}
			}
			return new Class342(obj);
		}

		public Class342(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}
	}

	private sealed class Class343 : Class334
	{
		private Array array_0;

		public override void vmethod_10(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class343(array_0);
		}

		public override object vmethod_12()
		{
			return array_0;
		}

		public override Type vmethod_8()
		{
			return typeof(Array);
		}

		public override bool vmethod_15()
		{
			return array_0 != null;
		}

		public Class343(Array array_1)
		{
			array_0 = array_1;
		}
	}

	private abstract class Class344 : Class334
	{
		public override bool vmethod_21()
		{
			return true;
		}
	}

	private sealed class Class345 : Class344
	{
		private Class333 class333_0;

		public override object vmethod_12()
		{
			return class333_0.vmethod_12();
		}

		public override bool vmethod_15()
		{
			return class333_0 != null;
		}

		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			class333_0.vmethod_20(fieldInfo_0, object_0);
		}

		public override Class333 vmethod_24()
		{
			return new Class345(class333_0);
		}

		public override Type vmethod_8()
		{
			return class333_0.vmethod_8();
		}

		public override void vmethod_10(object object_0)
		{
			class333_0.vmethod_10(object_0);
		}

		public Class345(Class333 class333_1)
		{
			class333_0 = class333_1;
		}
	}

	private sealed class Class351 : Class334
	{
		private Class333 class333_0;

		public override Class334 vmethod_16()
		{
			return this;
		}

		public override object vmethod_12()
		{
			object result = class333_0.vmethod_12();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_21()
		{
			return class333_0.vmethod_21();
		}

		public override byte vmethod_1()
		{
			byte result = class333_0.vmethod_1();
			Thread.MemoryBarrier();
			return result;
		}

		public override long vmethod_11()
		{
			long result = class333_0.vmethod_11();
			Thread.MemoryBarrier();
			return result;
		}

		public override sbyte vmethod_17()
		{
			sbyte result = class333_0.vmethod_17();
			Thread.MemoryBarrier();
			return result;
		}

		public override short vmethod_14()
		{
			short result = class333_0.vmethod_14();
			Thread.MemoryBarrier();
			return result;
		}

		public override TypeCode vmethod_2()
		{
			return class333_0.vmethod_2();
		}

		public override bool vmethod_15()
		{
			bool result = class333_0.vmethod_15();
			Thread.MemoryBarrier();
			return result;
		}

		public override int vmethod_22()
		{
			int result = class333_0.vmethod_22();
			Thread.MemoryBarrier();
			return result;
		}

		public override ushort vmethod_7()
		{
			ushort result = class333_0.vmethod_7();
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			class333_0.vmethod_20(fieldInfo_0, object_0);
		}

		public override double vmethod_6()
		{
			double result = class333_0.vmethod_6();
			Thread.MemoryBarrier();
			return result;
		}

		public override Type vmethod_8()
		{
			return class333_0.vmethod_8();
		}

		public override uint vmethod_18()
		{
			uint result = class333_0.vmethod_18();
			Thread.MemoryBarrier();
			return result;
		}

		public override float vmethod_13()
		{
			float result = class333_0.vmethod_13();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong vmethod_4()
		{
			ulong result = class333_0.vmethod_4();
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_10(object object_0)
		{
			Thread.MemoryBarrier();
			class333_0.vmethod_10(object_0);
		}

		public override Class333 vmethod_24()
		{
			throw new InvalidOperationException();
		}

		public Class351(Class333 class333_1)
		{
			class333_0 = class333_1;
		}
	}

	private sealed class Class346 : Class344
	{
		private Class333 class333_0;

		private Class333 class333_1;

		public override bool vmethod_15()
		{
			return class333_1 != null;
		}

		public override Type vmethod_8()
		{
			return class333_1.vmethod_8();
		}

		public override void vmethod_10(object object_0)
		{
			class333_1.vmethod_10(object_0);
			class333_0.vmethod_10(class333_1.vmethod_12());
		}

		public override Class333 vmethod_24()
		{
			return new Class346(class333_1, class333_0);
		}

		public override object vmethod_12()
		{
			return class333_1.vmethod_12();
		}

		public Class346(Class333 class333_2, Class333 class333_3)
		{
			class333_1 = class333_2;
			class333_0 = class333_3;
		}
	}

	private sealed class Class347 : Class344
	{
		private Class333 class333_0;

		private FieldInfo fieldInfo_0;

		public override void vmethod_10(object object_0)
		{
			class333_0.vmethod_20(fieldInfo_0, object_0);
		}

		public override object vmethod_12()
		{
			object obj = ((!class333_0.vmethod_8().IsPointer || !fieldInfo_0.DeclaringType.IsValueType) ? class333_0.vmethod_12() : Marshal.PtrToStructure(class333_0.vmethod_19(), fieldInfo_0.DeclaringType));
			return fieldInfo_0.GetValue(obj);
		}

		public override Class333 vmethod_24()
		{
			return new Class347(fieldInfo_0, class333_0);
		}

		public override Type vmethod_8()
		{
			return fieldInfo_0.FieldType;
		}

		public Class347(FieldInfo fieldInfo_1, Class333 class333_1)
		{
			fieldInfo_0 = fieldInfo_1;
			class333_0 = class333_1;
		}
	}

	private sealed class Class348 : Class344
	{
		private int int_0;

		private Array array_0;

		public override object vmethod_12()
		{
			return array_0.GetValue(int_0);
		}

		public override Type vmethod_8()
		{
			return array_0.GetType().GetElementType();
		}

		public override void vmethod_20(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_12();
			fieldInfo_0.SetValue(obj, object_0);
			if (obj is ValueType)
			{
				vmethod_10(obj);
			}
		}

		public override void vmethod_10(object object_0)
		{
			switch (Type.GetTypeCode(array_0.GetType().GetElementType()))
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
			array_0.SetValue(object_0, int_0);
		}

		public override Class333 vmethod_24()
		{
			return new Class348(array_0, int_0);
		}

		public Class348(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}
	}

	private sealed class Class352 : Class334
	{
		private MethodBase methodBase_0;

		public override void vmethod_10(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override Type vmethod_8()
		{
			return typeof(MethodBase);
		}

		public override object vmethod_12()
		{
			return methodBase_0;
		}

		public override IntPtr vmethod_19()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}

		public override Class333 vmethod_24()
		{
			return new Class352(methodBase_0);
		}

		public override bool vmethod_15()
		{
			return methodBase_0 != null;
		}

		public Class352(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}
	}

	private sealed class Class353 : Class334
	{
		private Class333 class333_0;

		private IntPtr intptr_0;

		public override void vmethod_10(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class333_0 = smethod_0(intptr_0);
		}

		public override int vmethod_22()
		{
			return class333_0.vmethod_22();
		}

		public override Type vmethod_8()
		{
			return typeof(IntPtr);
		}

		public unsafe override void* vmethod_0()
		{
			return intptr_0.ToPointer();
		}

		public override bool vmethod_15()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override short vmethod_14()
		{
			return class333_0.vmethod_14();
		}

		public override uint vmethod_18()
		{
			return class333_0.vmethod_18();
		}

		public override ulong vmethod_4()
		{
			return class333_0.vmethod_4();
		}

		public override UIntPtr vmethod_23()
		{
			return class333_0.vmethod_23();
		}

		private static Class333 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class335(intptr_1.ToInt32());
			}
			return new Class336(intptr_1.ToInt64());
		}

		public override Class333 vmethod_24()
		{
			return new Class353(intptr_0);
		}

		public override float vmethod_13()
		{
			return class333_0.vmethod_13();
		}

		public override object vmethod_12()
		{
			return intptr_0;
		}

		public override long vmethod_11()
		{
			return class333_0.vmethod_11();
		}

		public override TypeCode vmethod_2()
		{
			return class333_0.vmethod_2();
		}

		public override double vmethod_6()
		{
			return class333_0.vmethod_6();
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return class333_0.vmethod_5(type_0, bool_0);
		}

		public override ushort vmethod_7()
		{
			return class333_0.vmethod_7();
		}

		public override sbyte vmethod_17()
		{
			return class333_0.vmethod_17();
		}

		public override byte vmethod_1()
		{
			return class333_0.vmethod_1();
		}

		public override IntPtr vmethod_19()
		{
			return intptr_0;
		}

		public Class353(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class333_0 = smethod_0(intptr_0);
		}
	}

	private sealed class Class354 : Class334
	{
		private Class333 class333_0;

		private UIntPtr uintptr_0;

		private static Class333 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class335((int)uintptr_1.ToUInt32());
			}
			return new Class336((long)uintptr_1.ToUInt64());
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return class333_0.vmethod_5(type_0, bool_0);
		}

		public override float vmethod_13()
		{
			return class333_0.vmethod_13();
		}

		public override Type vmethod_8()
		{
			return typeof(UIntPtr);
		}

		public override byte vmethod_1()
		{
			return class333_0.vmethod_1();
		}

		public override ushort vmethod_7()
		{
			return class333_0.vmethod_7();
		}

		public override bool vmethod_15()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override ulong vmethod_4()
		{
			return class333_0.vmethod_4();
		}

		public override UIntPtr vmethod_23()
		{
			return uintptr_0;
		}

		public override IntPtr vmethod_19()
		{
			return class333_0.vmethod_19();
		}

		public override double vmethod_6()
		{
			return class333_0.vmethod_6();
		}

		public override Class333 vmethod_24()
		{
			return new Class354(uintptr_0);
		}

		public override sbyte vmethod_17()
		{
			return class333_0.vmethod_17();
		}

		public override void vmethod_10(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class333_0 = smethod_0(uintptr_0);
		}

		public override uint vmethod_18()
		{
			return class333_0.vmethod_18();
		}

		public override int vmethod_22()
		{
			return class333_0.vmethod_22();
		}

		public override short vmethod_14()
		{
			return class333_0.vmethod_14();
		}

		public override TypeCode vmethod_2()
		{
			return class333_0.vmethod_2();
		}

		public override long vmethod_11()
		{
			return class333_0.vmethod_11();
		}

		public unsafe override void* vmethod_0()
		{
			return uintptr_0.ToPointer();
		}

		public override object vmethod_12()
		{
			return uintptr_0;
		}

		public Class354(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class333_0 = smethod_0(uintptr_0);
		}
	}

	private sealed class Class355 : Class334
	{
		private Class333 class333_0;

		private Enum enum_0;

		public override double vmethod_6()
		{
			return class333_0.vmethod_6();
		}

		public override Type vmethod_8()
		{
			return enum_0.GetType();
		}

		public override ushort vmethod_7()
		{
			return class333_0.vmethod_7();
		}

		public override float vmethod_13()
		{
			return class333_0.vmethod_13();
		}

		public override short vmethod_14()
		{
			return class333_0.vmethod_14();
		}

		public override IntPtr vmethod_19()
		{
			while (IntPtr.Size == 4)
			{
			}
			return new IntPtr(vmethod_11());
		}

		public override void vmethod_10(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = (Enum)object_0;
			class333_0 = smethod_0(enum_0);
		}

		public override object vmethod_5(Type type_0, bool bool_0)
		{
			return class333_0.vmethod_5(type_0, bool_0);
		}

		public override uint vmethod_18()
		{
			return class333_0.vmethod_18();
		}

		public override sbyte vmethod_17()
		{
			return class333_0.vmethod_17();
		}

		public override ulong vmethod_4()
		{
			return class333_0.vmethod_4();
		}

		public override TypeCode vmethod_2()
		{
			return class333_0.vmethod_2();
		}

		public override object vmethod_12()
		{
			return enum_0;
		}

		public override Class333 vmethod_24()
		{
			return new Class355(enum_0);
		}

		public override byte vmethod_1()
		{
			return class333_0.vmethod_1();
		}

		private static Class333 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			default:
				throw new InvalidOperationException();
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new Class335(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new Class335((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new Class336(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new Class336((long)Convert.ToUInt64(enum_1));
			}
		}

		public override long vmethod_11()
		{
			return class333_0.vmethod_11();
		}

		public override int vmethod_22()
		{
			return class333_0.vmethod_22();
		}

		public override Class333 vmethod_9()
		{
			return class333_0.vmethod_9();
		}

		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((IntPtr.Size == 4) ? vmethod_18() : vmethod_4());
		}

		public Class355(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = enum_1;
			class333_0 = smethod_0(enum_0);
		}
	}

	private sealed class Class349 : Class344
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override Class333 vmethod_24()
		{
			return new Class349(intptr_0, type_0);
		}

		public override int vmethod_22()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override Type vmethod_8()
		{
			return typeof(Pointer);
		}

		public override byte vmethod_1()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override double vmethod_6()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override short vmethod_14()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override float vmethod_13()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override UIntPtr vmethod_23()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override uint vmethod_18()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_4()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override TypeCode vmethod_2()
		{
			return TypeCode.Empty;
		}

		public override char vmethod_3()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override ushort vmethod_7()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override object vmethod_12()
		{
			if (!type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(intptr_0, type_0);
		}

		public override long vmethod_11()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override void vmethod_10(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			Marshal.StructureToPtr(object_0, intptr_0, fDeleteOld: true);
		}

		public override IntPtr vmethod_19()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public Class349(IntPtr intptr_1, Type type_1)
		{
			intptr_0 = intptr_1;
			type_0 = type_1;
		}
	}

	private sealed class Class364
	{
		private int int_0;

		private int int_1;

		private byte byte_0;

		public int method_0()
		{
			return int_0;
		}

		public byte method_1()
		{
			return byte_0;
		}

		public int method_2()
		{
			return int_1;
		}

		public Class364(byte byte_1, int int_2, int int_3)
		{
			byte_0 = byte_1;
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	private sealed class Class365
	{
		private int int_0;

		private List<Class364> list_0 = new List<Class364>();

		private int int_1;

		public int method_0()
		{
			return int_0;
		}

		public void method_1(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class364(byte_0, int_2, int_3));
		}

		public int method_2(Class365 class365_0)
		{
			if (class365_0 == null)
			{
				return 1;
			}
			int num = int_1.CompareTo(class365_0.method_4());
			if (num == 0)
			{
				num = class365_0.method_0().CompareTo(int_0);
			}
			return num;
		}

		public List<Class364> method_3()
		{
			return list_0;
		}

		public int method_4()
		{
			return int_1;
		}

		public Class365(int int_2, int int_3)
		{
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	private sealed class Class350 : Class344
	{
		private object object_0;

		private FieldInfo fieldInfo_0;

		public override void vmethod_10(object object_1)
		{
			((Class366)fieldInfo_0.GetValue(object_0)).vmethod_0((int)object_1);
		}

		public override object vmethod_12()
		{
			return ((Class366)fieldInfo_0.GetValue(object_0)).vmethod_1();
		}

		public override Type vmethod_8()
		{
			return typeof(int);
		}

		public override Class333 vmethod_24()
		{
			return new Class350(fieldInfo_0, object_0);
		}

		public Class350(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}
	}

	private abstract class Class366
	{
		public abstract void vmethod_0(int int_0);

		public abstract int vmethod_1();
	}

	private sealed class Class367 : Class366
	{
		private Stack<int> stack_0 = new Stack<int>();

		private List<Class365> list_0 = new List<Class365>();

		public int method_0()
		{
			return stack_0.Count;
		}

		public override void vmethod_0(int int_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].method_4() == int_0)
				{
					stack_0.Push(i);
				}
			}
		}

		public Class365 method_1()
		{
			return list_0[stack_0.Pop()];
		}

		public Class365 method_2()
		{
			return list_0[stack_0.Peek()];
		}

		public override int vmethod_1()
		{
			return 0;
		}

		public void method_3(int int_0, int int_1, byte byte_0, int int_2, int int_3)
		{
			Class365 @class = null;
			for (int i = 0; i < list_0.Count; i += 605892737)
			{
				Class365 class2 = list_0[i];
				if (class2.method_4() == int_0 && class2.method_0() == int_1)
				{
					@class = class2;
					break;
				}
			}
			if (@class == null)
			{
				bool flag = false;
				@class = new Class365(int_0, int_1);
				for (int j = 0; j < list_0.Count; j += 37244422)
				{
					Class365 class365_ = list_0[j];
					if (@class.method_2(class365_) < 0)
					{
						list_0.Insert(j, @class);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list_0.Add(@class);
				}
			}
			@class.method_1(byte_0, int_2, int_3);
		}
	}

	private sealed class Class368 : Class366
	{
		private int int_0;

		private List<Class333> list_0 = new List<Class333>();

		public Class333 method_0(int int_1, Class333 class333_0)
		{
			if (int_1 < 0)
			{
				int_1 += list_0.Count - 1;
			}
			return list_0[int_1] = class333_0;
		}

		public void method_1()
		{
			while (list_0.Count > int_0)
			{
				list_0.RemoveAt(int_0);
			}
		}

		public override void vmethod_0(int int_1)
		{
			int_0 = int_1;
			for (int i = 0; i < int_0; i++)
			{
				list_0.Insert(0, null);
			}
		}

		public Class333 method_2()
		{
			int index = list_0.Count - 1;
			return list_0[index];
		}

		public Class333 method_3()
		{
			int index = list_0.Count - 1;
			Class333 result = list_0[index];
			list_0.RemoveAt(index);
			return result;
		}

		public Class333 method_4(int int_1)
		{
			if (int_1 < 0)
			{
				int_1 += list_0.Count - 1;
			}
			return list_0[int_1];
		}

		public void method_5(Class333 class333_0)
		{
			list_0.Add(class333_0.vmethod_16());
		}

		public override int vmethod_1()
		{
			return list_0.Count;
		}
	}

	private sealed class Class369 : Class366
	{
		private Stack<int> stack_0 = new Stack<int>();

		private int int_0;

		private static long long_0 = Marshal.GetHINSTANCE(typeof(GClass59).Module).ToInt64();

		public unsafe int method_0()
		{
			int result = *(int*)(long_0 + int_0);
			int_0 += 4;
			return result;
		}

		public unsafe long method_1()
		{
			long result = *(long*)(long_0 + int_0);
			int_0 += 8;
			return result;
		}

		public unsafe short method_2()
		{
			short result = *(short*)(long_0 + int_0);
			int_0 += 2;
			return result;
		}

		public int method_3()
		{
			return stack_0.Count;
		}

		public double method_4()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_1()), 0);
		}

		public void method_5()
		{
			stack_0.Clear();
			int_0 = 0;
		}

		public override void vmethod_0(int int_1)
		{
			int_0 = int_1;
		}

		public void method_6()
		{
			int_0 = stack_0.Pop();
		}

		public float method_7()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(method_0()), 0);
		}

		public unsafe byte method_8()
		{
			byte result = *(byte*)(long_0 + int_0);
			int_0++;
			return result;
		}

		public void method_9(int int_1)
		{
			stack_0.Push(int_1);
		}

		public override int vmethod_1()
		{
			return int_0;
		}
	}

	internal delegate void Delegate3();

	private static readonly Dictionary<int, object> dictionary_0 = new Dictionary<int, object>();

	private Exception exception_0;

	private static readonly Dictionary<object, DynamicMethod> dictionary_1 = new Dictionary<object, DynamicMethod>();

	private Class367 class367_0 = new Class367();

	private static readonly Module module_0 = typeof(GClass59).Module;

	private List<IntPtr> list_0 = new List<IntPtr>();

	private Class368 class368_0 = new Class368();

	private Class364 class364_0;

	private Class369 class369_0 = new Class369();

	private readonly Dictionary<uint, Delegate3> dictionary_2 = new Dictionary<uint, Delegate3>();

	private void method_0()
	{
		class368_0.method_5(new Class351(class368_0.method_3()));
	}

	private void method_1()
	{
		Type type = method_50(class369_0.method_0());
		DynamicMethod value;
		lock (dictionary_1)
		{
			if (!dictionary_1.TryGetValue(type, out value))
			{
				value = new DynamicMethod("", typeof(int), null, typeof(GClass59).Module, skipVisibility: true);
				ILGenerator iLGenerator = value.GetILGenerator();
				iLGenerator.Emit(OpCodes.Sizeof, type);
				iLGenerator.Emit(OpCodes.Ret);
				dictionary_1.Add(type, value);
			}
		}
		class368_0.method_5(new Class335((int)value.Invoke(null, null)));
	}

	private void method_2()
	{
		class368_0.method_5(new Class340(null));
	}

	private void method_3()
	{
		class368_0.method_5(new Class336(class369_0.method_1()));
	}

	private void method_4()
	{
		Type type_ = method_50(class369_0.method_0());
		class368_0.method_5(method_24(class368_0.method_3().vmethod_5(type_, bool_0: false), type_));
	}

	private void method_5()
	{
		string string_ = method_11(class369_0.method_0());
		class368_0.method_5(new Class339(string_));
	}

	private void method_6()
	{
		short int_ = class369_0.method_2();
		Type type_ = method_50(class368_0.method_3().vmethod_22());
		Class333 @class = class368_0.method_3();
		Class333 class2 = class368_0.method_3();
		class2 = ((!@class.vmethod_21()) ? method_24(class2.vmethod_12(), type_) : new Class346(method_24(class2.vmethod_12(), type_), @class));
		class368_0.method_0(int_, class2);
	}

	private void method_7()
	{
		class368_0.method_3();
	}

	public object method_8(object[] object_0, int int_0)
	{
		class369_0.vmethod_0(int_0);
		class368_0.method_5(new Class343(object_0));
		try
		{
			while (true)
			{
				try
				{
					dictionary_2[class369_0.method_8()]();
					if (class369_0.vmethod_1() == 0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					if (class364_0 == null)
					{
						exception_0 = ex;
					}
					method_23();
				}
			}
			return class368_0.method_3().vmethod_12();
		}
		finally
		{
			foreach (IntPtr item in list_0)
			{
				Marshal.FreeHGlobal(item);
			}
			list_0.Clear();
		}
	}

	private void method_9()
	{
		class368_0.method_5(new Class338(class369_0.method_4()));
	}

	private void method_10()
	{
		while (true)
		{
			Class333 @class = class368_0.method_3();
			Class333 class2 = class368_0.method_3();
			bool bool_ = (class369_0.method_8() & 2) != 0;
			switch (method_67(class2, @class))
			{
			case TypeCode.Double:
				break;
			default:
				throw new InvalidOperationException();
			case TypeCode.Int32:
				class368_0.method_5(Class335.smethod_3(class2, @class, bool_));
				return;
			case TypeCode.Int64:
				class368_0.method_5(Class336.smethod_11(class2, @class, bool_));
				return;
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				class368_0.method_5(Class341.smethod_3(class2, @class, bool_));
				return;
			case TypeCode.Single:
				class368_0.method_5(Class337.smethod_2(class2, @class, bool_));
				return;
			case TypeCode.Object:
				class368_0.method_5(Class340.smethod_0(class2, @class));
				return;
			}
		}
	}

	private string method_11(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_0, out var value))
			{
				return (string)value;
			}
			string text = module_0.ResolveString(int_0);
			dictionary_0.Add(int_0, text);
			return text;
		}
	}

	private void method_12()
	{
		Type type_ = method_50(class369_0.method_0());
		Class333 @class = class368_0.method_3();
		if (!(class368_0.method_3().vmethod_12() is Array array))
		{
			throw new ArgumentException();
		}
		class368_0.method_5(method_24(array.GetValue(@class.vmethod_22()), type_));
	}

	private bool method_13(object object_0, Type type_0)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		if (!(type == type_0) && !type_0.IsAssignableFrom(type))
		{
			return true;
		}
		return true;
	}

	private void method_14()
	{
		Class333 class333_ = class368_0.method_3();
		Class333 @class = class368_0.method_3();
		switch (@class.vmethod_2())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_9(@class, class333_));
			break;
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_5(@class, class333_));
			break;
		}
	}

	private void method_15()
	{
		Type type_ = method_50(class369_0.method_0());
		Class333 @class = class368_0.method_3();
		if (!method_13(@class.vmethod_12(), type_))
		{
			@class = new Class340(null);
		}
		class368_0.method_5(@class);
	}

	private void method_16()
	{
		Type type_ = method_50(class369_0.method_0());
		class368_0.method_5(method_24(class368_0.method_3(), type_));
	}

	private void method_17()
	{
		while (true)
		{
			Class333 class333_ = class368_0.method_3();
			Class333 @class = class368_0.method_3();
			bool bool_ = (class369_0.method_8() & 2) != 0;
			switch (@class.vmethod_2())
			{
			case TypeCode.Int32:
				break;
			default:
				throw new InvalidOperationException();
			case TypeCode.Int64:
				class368_0.method_5(Class336.smethod_3(@class, class333_, bool_));
				return;
			}
			class368_0.method_5(Class335.smethod_10(@class, class333_, bool_));
		}
	}

	private void method_18()
	{
		FieldInfo fieldInfo_ = method_42(class369_0.method_0());
		Class333 class333_ = class368_0.method_3();
		class368_0.method_5(new Class347(fieldInfo_, class333_));
	}

	private void method_19()
	{
		Type type_ = method_50(class369_0.method_0());
		class368_0.method_5(method_24(class368_0.method_3().vmethod_5(type_, bool_0: true), type_));
	}

	private void method_20()
	{
		throw (class368_0.method_3().vmethod_12() as Exception) ?? throw new ArgumentException();
	}

	private void method_21()
	{
		int num;
		do
		{
			num = class369_0.method_0();
			switch (num >> 24)
			{
			case 10:
				break;
			case 4:
				class368_0.method_5(new Class342(module_0.ModuleHandle.ResolveFieldHandle(num)));
				return;
			default:
				throw new InvalidOperationException();
			case 6:
			case 663029279:
				class368_0.method_5(new Class342(module_0.ModuleHandle.ResolveMethodHandle(num)));
				return;
			case 1:
			case 2:
			case 411895375:
				class368_0.method_5(new Class342(module_0.ModuleHandle.ResolveTypeHandle(num)));
				return;
			}
		}
		while (method_45(num).Boolean_0);
		class368_0.method_5(new Class342(module_0.ModuleHandle.ResolveFieldHandle(num)));
	}

	private void method_22()
	{
		short int_ = class369_0.method_2();
		Class333 @class = class368_0.method_4(int_);
		if (@class.vmethod_21())
		{
			throw new ArgumentException();
		}
		class368_0.method_5(new Class345(@class));
	}

	private void method_23()
	{
		while (true)
		{
			class368_0.method_1();
			class369_0.method_5();
			Class364 @class;
			while (true)
			{
				if (class367_0.method_0() != 0)
				{
					List<Class364> list = class367_0.method_2().method_3();
					int num = ((class364_0 == null) ? 1258966896 : (list.IndexOf(class364_0) + 1));
					class364_0 = null;
					for (int i = num; i < list.Count; i++)
					{
						@class = list[i];
						switch (@class.method_1())
						{
						case 0:
						{
							Type type = exception_0.GetType();
							Type type2 = method_50(@class.method_0());
							if (type == type2 || type.IsSubclassOf(type2))
							{
								class367_0.method_1();
								class368_0.method_5(new Class340(exception_0));
								class369_0.vmethod_0(@class.method_2());
								return;
							}
							break;
						}
						case 1:
							goto end_IL_0112;
						}
					}
					class367_0.method_1();
					for (int num2 = list.Count; num2 > 0; num2--)
					{
						Class364 class2 = list[num2 - 1];
						if (class2.method_1() == 2 || class2.method_1() == 4)
						{
							class369_0.method_9(class2.method_2());
						}
					}
					if (class369_0.method_3() != 0)
					{
						class369_0.method_6();
						return;
					}
					continue;
				}
				throw exception_0;
				continue;
				end_IL_0112:
				break;
			}
			class364_0 = @class;
		}
	}

	private Class333 method_24(object object_0, Type type_0)
	{
		Class333 @class = object_0 as Class333;
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
		return new Class355((object_0 == null) ? ((Enum)Activator.CreateInstance(type_0)) : ((Enum)object_0));
	}

	private bool method_25(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			Type declaringType = methodBase_0.DeclaringType;
			if (!(declaringType == null))
			{
				if (!(Nullable.GetUnderlyingType(declaringType) != null))
				{
					break;
				}
				if (!string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
				{
					if (!string.Equals(methodBase_0.Name, "get_Value", StringComparison.OrdinalIgnoreCase))
					{
						if (!methodBase_0.Name.Equals("GetValueOrDefault", (StringComparison)71489028))
						{
							break;
						}
						if (object_0 == null)
						{
							object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
						}
						object_1 = object_0;
						return true;
					}
					continue;
				}
				object_1 = object_0 != null;
				return true;
			}
			return false;
		}
		return true;
	}

	private void method_26()
	{
		if (exception_0 == null)
		{
			class369_0.method_6();
		}
		else
		{
			method_23();
		}
	}

	private void method_27()
	{
		int num = class369_0.method_0();
		class369_0.method_9(class368_0.method_3().vmethod_22());
		List<int> list = new List<int>();
		while (class367_0.method_0() != 0 && num > class367_0.method_2().method_0())
		{
			List<Class364> list2 = class367_0.method_1().method_3();
			for (int i = 0; i < list2.Count; i++)
			{
				Class364 @class = list2[i];
				if (@class.method_1() == 2)
				{
					list.Add(@class.method_2());
				}
			}
		}
		for (int num2 = list.Count; num2 > 0; num2--)
		{
			class369_0.method_9(list[num2 - 1]);
		}
		exception_0 = null;
		class368_0.method_1();
		class369_0.method_6();
	}

	private void method_28()
	{
		FieldInfo fieldInfo_ = method_42(class369_0.method_0());
		class368_0.method_5(new Class350(fieldInfo_, this));
	}

	private void method_29()
	{
		Class333 @class = class368_0.method_3();
		Class333 class2 = class368_0.method_3();
		byte num = class369_0.method_8();
		bool bool_ = (num & 2) != 0;
		bool bool_2 = (num & 0x10) != 0;
		switch (method_67(@class, class2))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_1(@class, class2, bool_2, bool_));
			break;
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_2(@class, class2, bool_2, bool_));
			break;
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			class368_0.method_5(Class341.smethod_0(@class, class2, bool_2, bool_));
			break;
		case TypeCode.Single:
			class368_0.method_5(Class337.smethod_4(@class, class2, bool_2, bool_));
			break;
		case TypeCode.Double:
			class368_0.method_5(Class338.smethod_0(@class, class2, bool_2, bool_));
			break;
		}
	}

	private void method_30()
	{
		Class333 class333_ = class368_0.method_3();
		Class333 class333_2 = class368_0.method_3();
		switch (method_67(class333_2, class333_))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_12(class333_2, class333_));
			break;
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_6(class333_2, class333_));
			break;
		}
	}

	private void method_31()
	{
		Class369 @class = new Class369();
		@class.vmethod_0(class368_0.method_3().vmethod_22());
		uint num = class369_0.method_8();
		ushort num2 = (ushort)@class.method_2();
		Dictionary<int, Class333> dictionary = new Dictionary<int, Class333>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[num2];
			for (int num3 = num2 - 1; num3 >= 0; num3--)
			{
				Class333 class2 = class368_0.method_3();
				if (class2.vmethod_21())
				{
					dictionary[num3] = class2;
				}
				array[num3] = method_24(class2, method_50(@class.method_0())).vmethod_12();
			}
		}
		int num4 = @class.method_0();
		if ((num & 4u) != 0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new GClass59().method_8(array, @class.vmethod_1());
		foreach (KeyValuePair<int, Class333> item in dictionary)
		{
			item.Value.vmethod_10(array[item.Key]);
		}
		if (num4 != 0)
		{
			Type type = method_50(num4);
			if (type != typeof(void))
			{
				class368_0.method_5(method_24(object_, type));
			}
		}
	}

	private void method_32()
	{
		while (true)
		{
			Class333 class333_ = class368_0.method_3();
			Class333 class333_2 = class368_0.method_3();
			switch (method_67(class333_2, class333_))
			{
			case TypeCode.Int32:
				break;
			case TypeCode.Int64:
				continue;
			default:
				throw new InvalidOperationException();
			}
			class368_0.method_5(Class335.smethod_8(class333_2, class333_));
		}
	}

	private void method_33()
	{
		Class333 class333_ = class368_0.method_3();
		Class333 class333_2;
		bool bool_;
		bool bool_2;
		do
		{
			class333_2 = class368_0.method_3();
			byte num = class369_0.method_8();
			bool_ = (num & 2) != 0;
			bool_2 = (num & 0x10) != 0;
			switch (method_67(class333_2, class333_))
			{
			case TypeCode.Int64:
				break;
			case TypeCode.Int32:
				class368_0.method_5(Class335.smethod_12(class333_2, class333_, bool_2, bool_));
				return;
			default:
				throw new InvalidOperationException();
			case TypeCode.Single:
				class368_0.method_5(Class337.smethod_0(class333_2, class333_, bool_2, bool_));
				return;
			case TypeCode.Double:
				class368_0.method_5(Class338.smethod_2(class333_2, class333_, bool_2, bool_));
				return;
			}
		}
		while (1791047102u % 0u != 0);
		class368_0.method_5(Class336.smethod_6(class333_2, class333_, bool_2, bool_));
	}

	private void method_34()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(class368_0.method_3().vmethod_19());
		list_0.Add(intPtr);
		class368_0.method_5(new Class353(intPtr));
	}

	private void method_35()
	{
		Class331 @class = method_45(class369_0.method_0());
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
		Dictionary<int, Class333> dictionary = new Dictionary<int, Class333>();
		Class332 class2 = new Class332();
		try
		{
			for (int num = array3.Length - 1; num >= 0; num--)
			{
				Type type = array2[num];
				Class333 class3 = class368_0.method_3();
				if (class3.vmethod_21())
				{
					if (!type.IsByRef)
					{
						array3[num] = class2.method_0(class3.vmethod_12());
						continue;
					}
					dictionary[num] = class3;
				}
				array3[num] = method_24(class3, type).vmethod_12();
			}
			DynamicMethod value;
			lock (dictionary_1)
			{
				if (!dictionary_1.TryGetValue(@class, out value))
				{
					value = new DynamicMethod("", (@class.Type_0 != typeof(void)) ? @class.Type_0 : null, array2, typeof(GClass59).Module, skipVisibility: true);
					ILGenerator iLGenerator = value.GetILGenerator();
					for (int i = 0; i < array2.Length; i++)
					{
						iLGenerator.Emit(dictionary.ContainsKey(i) ? OpCodes.Ldarga : OpCodes.Ldarg, i);
					}
					iLGenerator.EmitCalli(OpCodes.Calli, @class.CallingConvention_0, @class.Type_0, array);
					iLGenerator.Emit(OpCodes.Ret);
					dictionary_1.Add(@class, value);
				}
			}
			object object_ = value.Invoke(null, invokeAttr, null, array3, null);
			foreach (KeyValuePair<int, Class333> item in dictionary)
			{
				item.Value.vmethod_10(array3[item.Key]);
			}
			if (@class.Type_0 != typeof(void))
			{
				class368_0.method_5(method_24(object_, @class.Type_0));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	private void method_36()
	{
		Type type_ = method_50(class369_0.method_0());
		class368_0.method_5(new Class340(method_24(class368_0.method_3(), type_).vmethod_12()));
	}

	private void method_37()
	{
		MethodBase methodBase_ = method_65(class369_0.method_0());
		class368_0.method_5(new Class352(methodBase_));
	}

	private void method_38()
	{
		Type type = method_50(class369_0.method_0());
		Class333 @class = class368_0.method_3();
		object object_ = null;
		if (type.IsValueType && Nullable.GetUnderlyingType(type) == null)
		{
			object_ = FormatterServices.GetUninitializedObject(type);
		}
		@class.vmethod_10(object_);
	}

	private void method_39()
	{
		Class333 @class = class368_0.method_3();
		if (!(class368_0.method_3().vmethod_12() is Array array_))
		{
			throw new ArgumentException();
		}
		class368_0.method_5(new Class348(array_, @class.vmethod_22()));
	}

	private void method_40()
	{
		Class333 @class = class368_0.method_3();
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
			@class = new Class338(double.NaN);
		}
		class368_0.method_5(@class);
	}

	private void method_41()
	{
		Class333 @class = class368_0.method_3();
		Class333 class2 = class368_0.method_3();
		byte num = class369_0.method_8();
		bool bool_ = (num & 2) != 0;
		bool bool_2 = (num & 0x10) != 0;
		switch (method_67(class2, @class))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_11(class2, @class, bool_2, bool_));
			break;
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_1(class2, @class, bool_2, bool_));
			break;
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			class368_0.method_5(Class341.smethod_1(class2, @class, bool_2, bool_));
			break;
		case TypeCode.Single:
			class368_0.method_5(Class337.smethod_1(class2, @class, bool_2, bool_));
			break;
		case TypeCode.Double:
			class368_0.method_5(Class338.smethod_5(class2, @class, bool_2, bool_));
			break;
		}
	}

	private FieldInfo method_42(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_0, out var value))
			{
				return (FieldInfo)value;
			}
			FieldInfo fieldInfo = module_0.ResolveField(int_0);
			dictionary_0.Add(int_0, fieldInfo);
			return fieldInfo;
		}
	}

	private void method_43()
	{
		short int_ = class369_0.method_2();
		Class333 @class = class368_0.method_4(int_);
		Class333 class2 = class368_0.method_3();
		if (@class == null)
		{
			if (!class2.vmethod_21())
			{
				throw new ArgumentException();
			}
			class368_0.method_0(int_, class2);
		}
		else
		{
			@class.vmethod_10(method_24(class2, @class.vmethod_8()).vmethod_12());
		}
	}

	private void method_44()
	{
		class368_0.method_5(class368_0.method_2().vmethod_24());
	}

	private Class331 method_45(int int_0)
	{
		lock (dictionary_0)
		{
			int key = int_0 | 0x40000000;
			if (dictionary_0.TryGetValue(key, out var value))
			{
				return (Class331)value;
			}
			byte[] byte_ = module_0.ResolveSignature(int_0);
			Class331 @class = new Class331();
			@class.method_0(byte_, module_0);
			dictionary_0.Add(key, @class);
			return @class;
		}
	}

	private void method_46()
	{
		class368_0.method_5(new Class335(class369_0.method_0()));
	}

	private void method_47()
	{
		Class333 class333_ = class368_0.method_3();
		Class333 class333_2 = class368_0.method_3();
		bool bool_ = (class369_0.method_8() & 2) != 0;
		switch (method_67(class333_2, class333_))
		{
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_4(class333_2, class333_, bool_));
			break;
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_10(class333_2, class333_, bool_));
			break;
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			class368_0.method_5(Class337.smethod_5(class333_2, class333_, bool_));
			break;
		case TypeCode.Double:
			class368_0.method_5(Class338.smethod_1(class333_2, class333_, bool_));
			break;
		}
	}

	private unsafe void method_48()
	{
		Type type = method_50(class369_0.method_0());
		Class333 object_ = class368_0.method_3();
		Class333 @class = class368_0.method_3();
		object_ = method_24(object_, type);
		if (@class.vmethod_21())
		{
			object_ = method_24(object_, @class.vmethod_8());
		}
		else
		{
			@class = new Class349((@class.vmethod_12() is Pointer) ? new IntPtr(Pointer.Unbox(@class.vmethod_12())) : @class.vmethod_19(), type);
		}
		@class.vmethod_10(object_.vmethod_12());
	}

	private void method_49()
	{
		MethodBase methodBase;
		uint num;
		Type[] array;
		while (true)
		{
			int int_ = class368_0.method_3().vmethod_22();
			methodBase = method_65(int_);
			num = class369_0.method_8();
			if (methodBase.CallingConvention != CallingConventions.VarArgs)
			{
				break;
			}
			Class331 @class = method_45(int_);
			if (@class.Boolean_0)
			{
				array = @class.method_1();
				continue;
			}
			throw new ArgumentException();
		}
		ParameterInfo[] parameters = methodBase.GetParameters();
		array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		bool flag = (num & 0xC418F992u) > 3429579702u;
		if ((num & 0xB82808DFu) > 1210583266)
		{
			MethodInfo method = method_50(class368_0.method_3().vmethod_22()).GetMethod(methodBase.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
		}
		BindingFlags bindingFlags = BindingFlags.Default;
		MethodInfo methodInfo = methodBase as MethodInfo;
		Dictionary<int, Class333> dictionary = new Dictionary<int, Class333>();
		object[] array2 = new object[array.Length];
		Class332 class2 = new Class332();
		try
		{
			Class333 class3;
			object object_;
			object obj2;
			do
			{
				for (int num2 = array2.Length - 1; num2 >= 0; num2--)
				{
					Type type = array[num2];
					class3 = class368_0.method_3();
					if (class3.vmethod_21())
					{
						if (!type.IsByRef)
						{
							array2[num2] = class2.method_0(class3.vmethod_12());
							continue;
						}
						dictionary[num2] = class3;
					}
					array2[num2] = method_24(class3, type).vmethod_12();
				}
				class3 = (methodBase.IsStatic ? null : class368_0.method_3());
				object obj;
				if (class3 == null)
				{
					obj = null;
				}
				else
				{
					obj = class3.vmethod_12();
					if (obj != null)
					{
						goto IL_0198;
					}
				}
				obj = null;
				goto IL_0198;
				IL_0198:
				obj2 = obj;
				if (!flag || obj2 != null)
				{
					object_ = null;
					continue;
				}
				throw new NullReferenceException();
			}
			while (methodBase.CallingConvention == (CallingConventions)1852629114);
			if (methodBase.IsConstructor && methodBase.DeclaringType.IsValueType)
			{
				obj2 = Activator.CreateInstance(methodBase.DeclaringType, bindingFlags, null, array2, null);
				if (class3 != null)
				{
					DynamicMethod dynamicMethod = default(DynamicMethod);
					object_ = dynamicMethod.Invoke(null, bindingFlags, null, array2, null);
				}
			}
			else if (!method_25(methodBase, obj2, ref object_, array2))
			{
				if (!flag && methodBase.IsVirtual && !methodBase.IsFinal)
				{
					object[] array3 = new object[array.Length + 1];
					array3[0] = obj2;
					for (int j = 0; j < array.Length; j++)
					{
						array3[j + 1] = array2[j];
					}
					DynamicMethod value;
					lock (dictionary_1)
					{
						if (!dictionary_1.TryGetValue(methodBase, out value))
						{
							Type[] array4 = new Type[array3.Length];
							array4[0] = methodBase.DeclaringType;
							for (int k = 0; k < array.Length; k++)
							{
								array4[k + 1] = array[k];
							}
							value = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array4, typeof(GClass59).Module, skipVisibility: true);
							ILGenerator iLGenerator = value.GetILGenerator();
							iLGenerator.Emit(class3.vmethod_21() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
							for (int l = 1; l < array4.Length; l++)
							{
								iLGenerator.Emit(dictionary.ContainsKey(l - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, l);
							}
							iLGenerator.Emit(OpCodes.Call, methodInfo);
							iLGenerator.Emit(OpCodes.Ret);
							dictionary_1.Add(methodBase, value);
						}
					}
					object_ = value.Invoke(null, bindingFlags, null, array3, null);
					foreach (KeyValuePair<int, Class333> item in dictionary)
					{
						item.Value.vmethod_10(array3[item.Key + 1]);
					}
					dictionary.Clear();
				}
				else
				{
					object_ = methodBase.Invoke(obj2, bindingFlags, null, array2, null);
				}
			}
			foreach (KeyValuePair<int, Class333> item2 in dictionary)
			{
				item2.Value.vmethod_10(array2[item2.Key]);
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				class368_0.method_5(method_24(object_, methodInfo.ReturnType));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	private Type method_50(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_0, out var value))
			{
				return (Type)value;
			}
			Type type = module_0.ResolveType(int_0);
			dictionary_0.Add(int_0, type);
			return type;
		}
	}

	private void method_51()
	{
		Class333 @class = class368_0.method_3();
		Class333 object_ = class368_0.method_3();
		@class.vmethod_10(method_24(object_, @class.vmethod_8()).vmethod_12());
	}

	private void method_52()
	{
		short int_ = class369_0.method_2();
		Class333 @class = class368_0.method_4(int_);
		class368_0.method_5(@class.vmethod_24());
	}

	private void method_53()
	{
		Class333 class333_ = class368_0.method_3();
		Class333 @class = class368_0.method_3();
		bool bool_ = (class369_0.method_8() & 2) != 0;
		switch (@class.vmethod_2())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_7(@class, class333_, bool_));
			break;
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_7(@class, class333_, bool_));
			break;
		}
	}

	private void method_54()
	{
		Class333 @class = class368_0.method_3();
		class368_0.method_5(method_24(@class, @class.vmethod_8()));
	}

	private void method_55()
	{
		class368_0.method_5(new Class337(class369_0.method_7()));
	}

	private void method_56()
	{
		Type type_ = method_50(class369_0.method_0());
		Class333 object_ = class368_0.method_3();
		Class333 @class = class368_0.method_3();
		if (!(class368_0.method_3().vmethod_12() is Array array))
		{
			throw new ArgumentException();
		}
		array.SetValue(method_24(method_24(object_, type_), array.GetType().GetElementType()).vmethod_12(), @class.vmethod_22());
	}

	private void method_57()
	{
		if (!(class368_0.method_3().vmethod_12() is Array array))
		{
			throw new ArgumentException();
		}
		class368_0.method_5(new Class335(array.Length));
	}

	private void method_58()
	{
		Type type_ = method_50(class369_0.method_0());
		class368_0.method_5(method_24(class368_0.method_3().vmethod_12(), type_));
	}

	private void method_59()
	{
		while (true)
		{
			Class333 class333_ = class368_0.method_3();
			Class333 class333_2 = class368_0.method_3();
			switch (method_67(class333_2, class333_))
			{
			case TypeCode.Int64:
				break;
			default:
				throw new InvalidOperationException();
			case TypeCode.Int32:
				class368_0.method_5(Class335.smethod_2(class333_2, class333_));
				return;
			}
		}
	}

	private void method_60()
	{
		MethodBase methodBase = method_65(class369_0.method_0());
		Type type = class368_0.method_3().vmethod_12().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		ParameterInfo[] array2 = parameters;
		foreach (ParameterInfo parameterInfo in array2)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while (type != null && type != declaringType)
		{
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (!(method != null) || !(method.GetBaseDefinition() == methodBase))
			{
				type = type.BaseType;
				continue;
			}
			methodBase = method;
			break;
		}
		class368_0.method_5(new Class352(methodBase));
	}

	private void method_61()
	{
		Type type;
		object obj;
		while (true)
		{
			type = method_50(class369_0.method_0());
			obj = class368_0.method_3().vmethod_12();
			if (obj != null)
			{
				if (type.IsValueType)
				{
					break;
				}
				switch (Type.GetTypeCode(type))
				{
				case TypeCode.Double:
					break;
				default:
					throw new InvalidCastException();
				case TypeCode.Boolean:
					class368_0.method_5(new Class358((bool)obj));
					return;
				case TypeCode.Char:
					class368_0.method_5(new Class359((char)obj));
					return;
				case TypeCode.SByte:
					class368_0.method_5(new Class361((sbyte)obj));
					return;
				case TypeCode.Byte:
					class368_0.method_5(new Class360((byte)obj));
					return;
				case TypeCode.Int16:
					class368_0.method_5(new Class356((short)obj));
					return;
				case TypeCode.UInt16:
					class368_0.method_5(new Class357((ushort)obj));
					return;
				case TypeCode.Int32:
					class368_0.method_5(new Class335((int)obj));
					return;
				case TypeCode.UInt32:
					class368_0.method_5(new Class362((uint)obj));
					return;
				case TypeCode.Int64:
					class368_0.method_5(new Class336((long)obj));
					return;
				case TypeCode.UInt64:
					class368_0.method_5(new Class363((ulong)obj));
					return;
				case TypeCode.Single:
					class368_0.method_5(new Class337((float)obj));
					return;
				}
				continue;
			}
			throw new NullReferenceException();
		}
		if (type != obj.GetType())
		{
			throw new InvalidCastException();
		}
		class368_0.method_5(method_24(obj, type));
	}

	private void method_62()
	{
		byte byte_ = class369_0.method_8();
		int int_ = class369_0.method_0();
		int int_2 = class369_0.method_0();
		int int_3 = class369_0.method_0();
		int int_4 = class369_0.method_0();
		class367_0.method_3(int_, int_2, byte_, int_3, int_4);
	}

	private void method_63()
	{
		Class333 @class = class368_0.method_3();
		switch (@class.vmethod_2())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_8(@class));
			break;
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_0(@class));
			break;
		}
	}

	private unsafe void method_64()
	{
		Type type = method_50(class369_0.method_0());
		Class333 @class = class368_0.method_3();
		if (!@class.vmethod_21())
		{
			@class = new Class349((@class.vmethod_12() is Pointer) ? new IntPtr(Pointer.Unbox(@class.vmethod_12())) : @class.vmethod_19(), type);
		}
		class368_0.method_5(method_24(@class, type));
	}

	private MethodBase method_65(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_0, out var value))
			{
				return (MethodBase)value;
			}
			MethodBase methodBase = module_0.ResolveMethod(int_0);
			dictionary_0.Add(int_0, methodBase);
			return methodBase;
		}
	}

	private void method_66()
	{
		Type type_ = method_50(class369_0.method_0());
		Class333 @class = class368_0.method_3();
		if (!method_13(@class.vmethod_12(), type_))
		{
			throw new InvalidCastException();
		}
		class368_0.method_5(@class);
	}

	private TypeCode method_67(Class333 class333_0, Class333 class333_1)
	{
		while (true)
		{
			TypeCode typeCode = class333_0.vmethod_2();
			TypeCode typeCode2 = class333_1.vmethod_2();
			if (typeCode == TypeCode.Empty || typeCode2 == TypeCode.Empty)
			{
				break;
			}
			if (typeCode != (TypeCode)10517909 && typeCode2 != (TypeCode)(-26639))
			{
				if (typeCode != (TypeCode)3119642)
				{
					if (typeCode2 == (TypeCode)(-1870659574))
					{
						if (typeCode != (TypeCode)(-276824055) && typeCode != (TypeCode)1904214026)
						{
							return (TypeCode)(-243269632);
						}
						return typeCode2;
					}
					continue;
				}
				if (typeCode2 != (TypeCode)3119641 && typeCode2 != TypeCode.UInt32)
				{
					return TypeCode.Empty;
				}
				return typeCode;
			}
			return TypeCode.Object;
		}
		return TypeCode.Empty;
	}

	private void method_68()
	{
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void method_69()
	{
		if (class368_0.method_3().vmethod_22() != 0)
		{
			class367_0.method_1();
			class368_0.method_5(new Class340(exception_0));
			class369_0.vmethod_0(class364_0.method_2());
			class364_0 = null;
		}
		else
		{
			method_23();
		}
	}

	private void method_70()
	{
		Type elementType = method_50(class369_0.method_0());
		class368_0.method_5(new Class343(Array.CreateInstance(elementType, class368_0.method_3().vmethod_22())));
	}

	private void method_71()
	{
		Class333 @class = class368_0.method_3();
		switch (@class.vmethod_2())
		{
		case TypeCode.Int32:
			class368_0.method_5(Class335.smethod_9(@class));
			break;
		case TypeCode.Int64:
			class368_0.method_5(Class336.smethod_5(@class));
			break;
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			break;
		case TypeCode.Double:
			class368_0.method_5(Class338.smethod_4(@class));
			break;
		}
	}

	private void method_72()
	{
		MethodBase methodBase = method_65(class369_0.method_0());
		ParameterInfo[] parameters = methodBase.GetParameters();
		Dictionary<int, Class333> dictionary = new Dictionary<int, Class333>();
		object[] array = new object[parameters.Length];
		Class332 @class = new Class332();
		try
		{
			while (true)
			{
				int num = parameters.Length - 1;
				while (true)
				{
					if (num >= 0)
					{
						Type parameterType = parameters[num].ParameterType;
						Class333 class2 = class368_0.method_3();
						if (class2.vmethod_21())
						{
							if (parameterType.IsByRef)
							{
								break;
							}
							array[num] = @class.method_0(class2.vmethod_12());
						}
						else
						{
							array[num] = method_24(class2, parameterType).vmethod_12();
						}
						num--;
						continue;
					}
					object object_ = ((ConstructorInfo)methodBase).Invoke(array);
					foreach (KeyValuePair<int, Class333> item in dictionary)
					{
						item.Value.vmethod_10(array[item.Key]);
					}
					class368_0.method_5(method_24(object_, methodBase.DeclaringType));
					return;
				}
			}
		}
		finally
		{
			@class.Dispose();
		}
	}

	public GClass59()
	{
		dictionary_2[0u] = method_59;
		dictionary_2[1u] = method_0;
		dictionary_2[2u] = method_43;
		dictionary_2[3u] = method_9;
		dictionary_2[4u] = method_47;
		dictionary_2[5u] = method_16;
		dictionary_2[6u] = method_12;
		dictionary_2[7u] = method_15;
		dictionary_2[8u] = method_70;
		dictionary_2[9u] = method_35;
		dictionary_2[10u] = method_28;
		dictionary_2[11u] = method_41;
		dictionary_2[12u] = method_14;
		dictionary_2[13u] = method_60;
		dictionary_2[14u] = method_1;
		dictionary_2[15u] = method_5;
		dictionary_2[16u] = method_33;
		dictionary_2[17u] = method_29;
		dictionary_2[18u] = method_46;
		dictionary_2[19u] = method_17;
		dictionary_2[20u] = method_61;
		dictionary_2[21u] = method_31;
		dictionary_2[22u] = method_58;
		dictionary_2[23u] = method_64;
		dictionary_2[24u] = method_62;
		dictionary_2[25u] = method_19;
		dictionary_2[26u] = method_40;
		dictionary_2[27u] = method_37;
		dictionary_2[28u] = method_54;
		dictionary_2[29u] = method_2;
		dictionary_2[30u] = method_52;
		dictionary_2[31u] = method_22;
		dictionary_2[32u] = method_6;
		dictionary_2[33u] = method_48;
		dictionary_2[34u] = method_30;
		dictionary_2[35u] = method_69;
		dictionary_2[36u] = method_55;
		dictionary_2[37u] = method_39;
		dictionary_2[38u] = method_71;
		dictionary_2[39u] = method_51;
		dictionary_2[40u] = method_34;
		dictionary_2[41u] = method_56;
		dictionary_2[42u] = method_49;
		dictionary_2[43u] = method_68;
		dictionary_2[44u] = method_3;
		dictionary_2[45u] = method_53;
		dictionary_2[46u] = method_32;
		dictionary_2[47u] = method_27;
		dictionary_2[48u] = method_10;
		dictionary_2[49u] = method_36;
		dictionary_2[50u] = method_38;
		dictionary_2[51u] = method_57;
		dictionary_2[52u] = method_26;
		dictionary_2[53u] = method_63;
		dictionary_2[54u] = method_44;
		dictionary_2[55u] = method_20;
		dictionary_2[56u] = method_21;
		dictionary_2[57u] = method_66;
		dictionary_2[58u] = method_18;
		dictionary_2[59u] = method_4;
		dictionary_2[60u] = method_72;
		dictionary_2[61u] = method_7;
		dictionary_2[62u] = method_26;
		dictionary_2[63u] = method_61;
		dictionary_2[64u] = method_27;
		dictionary_2[65u] = method_10;
		dictionary_2[66u] = method_18;
		dictionary_2[67u] = method_0;
		dictionary_2[68u] = method_66;
		dictionary_2[69u] = method_59;
		dictionary_2[70u] = method_55;
		dictionary_2[71u] = method_53;
		dictionary_2[72u] = method_60;
		dictionary_2[73u] = method_15;
		dictionary_2[74u] = method_69;
		dictionary_2[75u] = method_56;
		dictionary_2[76u] = method_2;
		dictionary_2[77u] = method_56;
		dictionary_2[78u] = method_1;
		dictionary_2[79u] = method_37;
		dictionary_2[80u] = method_61;
		dictionary_2[81u] = method_46;
		dictionary_2[82u] = method_0;
		dictionary_2[83u] = method_40;
		dictionary_2[84u] = method_36;
		dictionary_2[85u] = method_16;
		dictionary_2[86u] = method_29;
		dictionary_2[87u] = method_19;
		dictionary_2[88u] = method_14;
		dictionary_2[89u] = method_31;
		dictionary_2[90u] = method_64;
		dictionary_2[91u] = method_43;
		dictionary_2[92u] = method_10;
		dictionary_2[93u] = method_32;
		dictionary_2[94u] = method_3;
		dictionary_2[95u] = method_32;
		dictionary_2[96u] = method_48;
		dictionary_2[97u] = method_3;
		dictionary_2[98u] = method_47;
		dictionary_2[99u] = method_52;
		dictionary_2[100u] = method_59;
		dictionary_2[101u] = method_61;
		dictionary_2[102u] = method_43;
		dictionary_2[103u] = method_51;
		dictionary_2[104u] = method_16;
		dictionary_2[105u] = method_59;
		dictionary_2[106u] = method_47;
		dictionary_2[107u] = method_60;
		dictionary_2[108u] = method_10;
		dictionary_2[109u] = method_61;
		dictionary_2[110u] = method_2;
		dictionary_2[111u] = method_53;
		dictionary_2[112u] = method_2;
		dictionary_2[113u] = method_55;
		dictionary_2[114u] = method_2;
		dictionary_2[115u] = method_66;
		dictionary_2[116u] = method_56;
		dictionary_2[117u] = method_18;
		dictionary_2[118u] = method_64;
		dictionary_2[119u] = method_46;
		dictionary_2[120u] = method_62;
		dictionary_2[121u] = method_6;
		dictionary_2[122u] = method_38;
		dictionary_2[123u] = method_64;
		dictionary_2[124u] = method_41;
		dictionary_2[125u] = method_61;
		dictionary_2[126u] = method_47;
		dictionary_2[127u] = method_43;
		dictionary_2[128u] = method_56;
		dictionary_2[129u] = method_26;
		dictionary_2[130u] = method_48;
		dictionary_2[131u] = method_30;
		dictionary_2[132u] = method_62;
		dictionary_2[133u] = method_36;
		dictionary_2[134u] = method_70;
		dictionary_2[135u] = method_72;
		dictionary_2[136u] = method_2;
		dictionary_2[137u] = method_58;
		dictionary_2[138u] = method_43;
		dictionary_2[139u] = method_10;
		dictionary_2[140u] = method_26;
		dictionary_2[141u] = method_18;
		dictionary_2[142u] = method_31;
		dictionary_2[143u] = method_52;
		dictionary_2[144u] = method_55;
		dictionary_2[145u] = method_53;
		dictionary_2[146u] = method_2;
		dictionary_2[147u] = method_51;
		dictionary_2[148u] = method_46;
		dictionary_2[149u] = method_48;
		dictionary_2[150u] = method_22;
		dictionary_2[151u] = method_26;
		dictionary_2[152u] = method_47;
		dictionary_2[153u] = method_61;
		dictionary_2[154u] = method_30;
		dictionary_2[155u] = method_53;
		dictionary_2[156u] = method_47;
		dictionary_2[157u] = method_26;
		dictionary_2[158u] = method_5;
		dictionary_2[159u] = method_30;
		dictionary_2[160u] = method_18;
		dictionary_2[161u] = method_55;
		dictionary_2[162u] = method_53;
		dictionary_2[163u] = method_52;
		dictionary_2[164u] = method_62;
		dictionary_2[165u] = method_22;
		dictionary_2[166u] = method_61;
		dictionary_2[167u] = method_18;
		dictionary_2[168u] = method_40;
		dictionary_2[169u] = method_31;
		dictionary_2[170u] = method_27;
		dictionary_2[171u] = method_61;
		dictionary_2[172u] = method_18;
		dictionary_2[173u] = method_54;
		dictionary_2[174u] = method_64;
		dictionary_2[175u] = method_41;
		dictionary_2[176u] = method_18;
		dictionary_2[177u] = method_31;
		dictionary_2[178u] = method_41;
		dictionary_2[179u] = method_43;
		dictionary_2[180u] = method_59;
		dictionary_2[181u] = method_14;
		dictionary_2[182u] = method_69;
		dictionary_2[183u] = method_16;
		dictionary_2[184u] = method_56;
		dictionary_2[185u] = method_2;
		dictionary_2[186u] = method_56;
		dictionary_2[187u] = method_61;
		dictionary_2[188u] = method_61;
		dictionary_2[189u] = method_35;
		dictionary_2[190u] = method_56;
		dictionary_2[191u] = method_43;
		dictionary_2[192u] = method_71;
		dictionary_2[193u] = method_30;
		dictionary_2[194u] = method_41;
		dictionary_2[195u] = method_43;
		dictionary_2[196u] = method_56;
		dictionary_2[197u] = method_3;
		dictionary_2[198u] = method_56;
		dictionary_2[199u] = method_56;
		dictionary_2[200u] = method_2;
		dictionary_2[201u] = method_54;
		dictionary_2[202u] = method_56;
		dictionary_2[203u] = method_47;
		dictionary_2[204u] = method_56;
		dictionary_2[205u] = method_53;
		dictionary_2[206u] = method_3;
		dictionary_2[207u] = method_43;
		dictionary_2[208u] = method_2;
		dictionary_2[209u] = method_55;
		dictionary_2[210u] = method_59;
		dictionary_2[211u] = method_41;
		dictionary_2[212u] = method_43;
		dictionary_2[213u] = method_41;
		dictionary_2[214u] = method_53;
		dictionary_2[215u] = method_18;
		dictionary_2[216u] = method_3;
		dictionary_2[217u] = method_61;
		dictionary_2[218u] = method_10;
		dictionary_2[219u] = method_26;
		dictionary_2[220u] = method_61;
		dictionary_2[221u] = method_62;
		dictionary_2[222u] = method_26;
		dictionary_2[223u] = method_43;
		dictionary_2[224u] = method_70;
		dictionary_2[225u] = method_47;
		dictionary_2[226u] = method_40;
		dictionary_2[227u] = method_26;
		dictionary_2[228u] = method_2;
		dictionary_2[229u] = method_10;
		dictionary_2[230u] = method_70;
		dictionary_2[231u] = method_61;
		dictionary_2[232u] = method_16;
		dictionary_2[233u] = method_18;
		dictionary_2[234u] = method_2;
		dictionary_2[235u] = method_29;
		dictionary_2[236u] = method_31;
		dictionary_2[237u] = method_2;
		dictionary_2[238u] = method_36;
		dictionary_2[239u] = method_2;
		dictionary_2[240u] = method_61;
		dictionary_2[241u] = method_31;
		dictionary_2[242u] = method_16;
		dictionary_2[243u] = method_47;
		dictionary_2[244u] = method_6;
		dictionary_2[245u] = method_28;
		dictionary_2[246u] = method_47;
		dictionary_2[247u] = method_54;
		dictionary_2[248u] = method_71;
		dictionary_2[249u] = method_29;
		dictionary_2[250u] = method_62;
		dictionary_2[251u] = method_60;
		dictionary_2[252u] = method_18;
		dictionary_2[253u] = method_47;
		dictionary_2[254u] = method_59;
		dictionary_2[255u] = method_48;
	}
}
