using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x0200000F RID: 15
	[Guid("F704E861-9E52-464F-B786-DA5EB2320FDD")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWSManConnectionOptions
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AF RID: 175
		// (set) Token: 0x060000B0 RID: 176
		[DispId(1)]
		string UserName { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x060000B1 RID: 177
		[DispId(2)]
		string Password { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
