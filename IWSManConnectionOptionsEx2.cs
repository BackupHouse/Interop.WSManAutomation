using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000011 RID: 17
	[Guid("F500C9EC-24EE-48AB-B38D-FC9A164C658E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWSManConnectionOptionsEx2 : IWSManConnectionOptionsEx
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B7 RID: 183
		// (set) Token: 0x060000B8 RID: 184
		[DispId(1)]
		string UserName { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x060000B9 RID: 185
		[DispId(2)]
		string Password { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BA RID: 186
		// (set) Token: 0x060000BB RID: 187
		[DispId(3)]
		string CertificateThumbprint { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060000BC RID: 188
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetProxy([In] int accessType = 0, [In] int authenticationMechanism = 0, [MarshalAs(UnmanagedType.BStr)][In] string UserName = "", [MarshalAs(UnmanagedType.BStr)][In] string Password = "");

		// Token: 0x060000BD RID: 189
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyIEConfig();

		// Token: 0x060000BE RID: 190
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyWinHttpConfig();

		// Token: 0x060000BF RID: 191
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyAutoDetect();

		// Token: 0x060000C0 RID: 192
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyNoProxyServer();

		// Token: 0x060000C1 RID: 193
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyAuthenticationUseNegotiate();

		// Token: 0x060000C2 RID: 194
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyAuthenticationUseBasic();

		// Token: 0x060000C3 RID: 195
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int ProxyAuthenticationUseDigest();
	}
}
