using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000004 RID: 4
	[Guid("1D1B5AE0-42D9-4021-8261-3987619512E9")]
	[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWSManEx2 : IWSManEx
	{
		// Token: 0x0600001D RID: 29
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x0600001E RID: 30
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateConnectionOptions();

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31
		[DispId(3)]
		string CommandLine { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32
		[DispId(4)]
		string Error { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000021 RID: 33
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x06000022 RID: 34
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUTF8();

		// Token: 0x06000023 RID: 35
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagCredUsernamePassword();

		// Token: 0x06000024 RID: 36
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCACheck();

		// Token: 0x06000025 RID: 37
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCNCheck();

		// Token: 0x06000026 RID: 38
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseDigest();

		// Token: 0x06000027 RID: 39
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNegotiate();

		// Token: 0x06000028 RID: 40
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseBasic();

		// Token: 0x06000029 RID: 41
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseKerberos();

		// Token: 0x0600002A RID: 42
		[DispId(14)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagNoEncryption();

		// Token: 0x0600002B RID: 43
		[DispId(15)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagEnableSPNServerPort();

		// Token: 0x0600002C RID: 44
		[DispId(16)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNoAuthentication();

		// Token: 0x0600002D RID: 45
		[DispId(17)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagNonXmlText();

		// Token: 0x0600002E RID: 46
		[DispId(18)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnEPR();

		// Token: 0x0600002F RID: 47
		[DispId(19)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObjectAndEPR();

		// Token: 0x06000030 RID: 48
		[DispId(20)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetErrorMessage([In] uint errorNumber);

		// Token: 0x06000031 RID: 49
		[DispId(21)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeep();

		// Token: 0x06000032 RID: 50
		[DispId(22)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyShallow();

		// Token: 0x06000033 RID: 51
		[DispId(23)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x06000034 RID: 52
		[DispId(24)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObject();

		// Token: 0x06000035 RID: 53
		[DispId(25)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseClientCertificate();
	}
}
