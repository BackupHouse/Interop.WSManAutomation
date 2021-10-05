using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000012 RID: 18
	[Guid("FC84FC58-1286-40C4-9DA0-C8EF6EC241E0")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWSManSession
	{
		// Token: 0x060000C4 RID: 196
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Get([MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [In] int flags = 0);

		// Token: 0x060000C5 RID: 197
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Put([MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [MarshalAs(UnmanagedType.BStr)][In] string resource, [In] int flags = 0);

		// Token: 0x060000C6 RID: 198
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Create([MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [MarshalAs(UnmanagedType.BStr)][In] string resource, [In] int flags = 0);

		// Token: 0x060000C7 RID: 199
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Delete([MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [In] int flags = 0);

		// Token: 0x060000C8 RID: 200
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Invoke([MarshalAs(UnmanagedType.BStr)][In] string actionUri, [MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [MarshalAs(UnmanagedType.BStr)][In] string parameters, [In] int flags = 0);

		// Token: 0x060000C9 RID: 201
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Enumerate([MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [MarshalAs(UnmanagedType.BStr)][In] string filter = "", [MarshalAs(UnmanagedType.BStr)][In] string dialect = "", [In] int flags = 0);

		// Token: 0x060000CA RID: 202
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string Identify([In] int flags = 0);

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CB RID: 203
		[DispId(8)]
		string Error { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CC RID: 204
		// (set) Token: 0x060000CD RID: 205
		[DispId(9)]
		int BatchItems { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000CE RID: 206
		// (set) Token: 0x060000CF RID: 207
		[DispId(10)]
		int Timeout { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
