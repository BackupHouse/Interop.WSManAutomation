using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x0200000A RID: 10
	[Guid("7DE087A5-5DCB-4DF7-BB12-0924AD8FBD9A")]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport]
	public class WSManInternalClass : IWSManInternal, WSManInternal
	{
		// ComImport 特性标记的类 不能拥有用户定义的构造函数   MethodImpl(MethodImplOptions.InternalCall) 内部调用
		// https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0669
		// Token: 0x060000AD RID: 173
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public extern WSManInternalClass();

		// Token: 0x060000AE RID: 174
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string ConfigSDDL([MarshalAs(UnmanagedType.IDispatch)][In] object session, [MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [In] int flags = 0);
	}
}
