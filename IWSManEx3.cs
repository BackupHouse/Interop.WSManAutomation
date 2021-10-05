using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000005 RID: 5
	[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("6400E966-011D-4EAC-8474-049E0848AFAD")]
	[ComImport]
	public interface IWSManEx3 : IWSManEx2
	{
		// Token: 0x06000036 RID: 54
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000037 RID: 55
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateConnectionOptions();

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000038 RID: 56
		[DispId(3)]
		string CommandLine { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000039 RID: 57
		[DispId(4)]
		string Error { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600003A RID: 58
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x0600003B RID: 59
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUTF8();

		// Token: 0x0600003C RID: 60
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagCredUsernamePassword();

		// Token: 0x0600003D RID: 61
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCACheck();

		// Token: 0x0600003E RID: 62
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCNCheck();

		// Token: 0x0600003F RID: 63
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseDigest();

		// Token: 0x06000040 RID: 64
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNegotiate();

		// Token: 0x06000041 RID: 65
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseBasic();

		// Token: 0x06000042 RID: 66
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseKerberos();

		// Token: 0x06000043 RID: 67
		[DispId(14)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagNoEncryption();

		// Token: 0x06000044 RID: 68
		[DispId(15)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagEnableSPNServerPort();

		// Token: 0x06000045 RID: 69
		[DispId(16)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNoAuthentication();

		// Token: 0x06000046 RID: 70
		[DispId(17)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagNonXmlText();

		// Token: 0x06000047 RID: 71
		[DispId(18)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnEPR();

		// Token: 0x06000048 RID: 72
		[DispId(19)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObjectAndEPR();

		// Token: 0x06000049 RID: 73
		[DispId(20)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetErrorMessage([In] uint errorNumber);

		// Token: 0x0600004A RID: 74
		[DispId(21)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeep();

		// Token: 0x0600004B RID: 75
		[DispId(22)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyShallow();

		// Token: 0x0600004C RID: 76
		[DispId(23)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x0600004D RID: 77
		[DispId(24)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObject();

		// Token: 0x0600004E RID: 78
		[DispId(25)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseClientCertificate();

		// Token: 0x0600004F RID: 79
		[DispId(26)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUTF16();

		// Token: 0x06000050 RID: 80
		[DispId(27)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseCredSsp();

		// Token: 0x06000051 RID: 81
		[DispId(28)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagAssociationInstance();

		// Token: 0x06000052 RID: 82
		[DispId(29)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagAssociatedInstance();

		// Token: 0x06000053 RID: 83
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipRevocationCheck();

		// Token: 0x06000054 RID: 84
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagAllowNegotiateImplicitCredentials();

		// Token: 0x06000055 RID: 85
		[DispId(32)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseSsl();
	}
}
