using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000002 RID: 2
	[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("190D8637-5CD3-496D-AD24-69636BB5A3B5")]
	[ComImport]
	public interface IWSMan
	{
		// Token: 0x06000001 RID: 1
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000002 RID: 2
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateConnectionOptions();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[DispId(3)]
		string CommandLine { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		[DispId(4)]
		string Error { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
