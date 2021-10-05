using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000013 RID: 19
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("F3457CA9-ABB9-4FA5-B850-90E8CA300E7F")]
	[ComImport]
	public interface IWSManEnumerator
	{
		// Token: 0x060000D0 RID: 208
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string ReadItem();

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D1 RID: 209
		[DispId(2)]
		bool AtEndOfStream { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D2 RID: 210
		[DispId(8)]
		string Error { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
