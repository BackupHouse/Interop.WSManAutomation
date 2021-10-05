using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000014 RID: 20
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("A7A1BA28-DE41-466A-AD0A-C4059EAD7428")]
	[ComImport]
	public interface IWSManResourceLocator
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D4 RID: 212
		// (set) Token: 0x060000D3 RID: 211
		[DispId(1)]
		string resourceUri { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060000D5 RID: 213
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddSelector([MarshalAs(UnmanagedType.BStr)][In] string resourceSelName, [MarshalAs(UnmanagedType.Struct)][In] object selValue);

		// Token: 0x060000D6 RID: 214
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClearSelectors();

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000D7 RID: 215
		// (set) Token: 0x060000D8 RID: 216
		[DispId(4)]
		string FragmentPath { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D9 RID: 217
		// (set) Token: 0x060000DA RID: 218
		[DispId(5)]
		string FragmentDialect { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060000DB RID: 219
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddOption([MarshalAs(UnmanagedType.BStr)][In] string OptionName, [MarshalAs(UnmanagedType.Struct)][In] object OptionValue, [In] int mustComply = 0);

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DC RID: 220
		[DispId(7)]
		int MustUnderstandOptions { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060000DE RID: 222
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClearOptions();

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000DF RID: 223
		[DispId(9)]
		string Error { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
