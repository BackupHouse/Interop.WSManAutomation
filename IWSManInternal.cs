using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000008 RID: 8
	[Guid("04AE2B1D-9954-4D99-94A9-A961E72C3A13")]
	[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWSManInternal
	{
		// Token: 0x060000AC RID: 172
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string ConfigSDDL([MarshalAs(UnmanagedType.IDispatch)][In] object session, [MarshalAs(UnmanagedType.Struct)][In] object resourceUri, [In] int flags = 0);
	}
}
