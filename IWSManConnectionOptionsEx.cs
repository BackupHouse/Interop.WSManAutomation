using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000010 RID: 16
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("EF43EDF7-2A48-4D93-9526-8BD6AB6D4A6B")]
	[ComImport]
	public interface IWSManConnectionOptionsEx : IWSManConnectionOptions
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B2 RID: 178
		// (set) Token: 0x060000B3 RID: 179
		[DispId(1)]
		string UserName { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x060000B4 RID: 180
		[DispId(2)]
		string Password { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B5 RID: 181
		// (set) Token: 0x060000B6 RID: 182
		[DispId(3)]
		string CertificateThumbprint { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
