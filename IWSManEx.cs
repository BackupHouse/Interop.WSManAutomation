using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000003 RID: 3
	[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("2D53BDAA-798E-49E6-A1AA-74D01256F411")]
	[ComImport]
	public interface IWSManEx : IWSMan
	{
		// Token: 0x06000005 RID: 5
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000006 RID: 6
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateConnectionOptions();

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7
		[DispId(3)]
		string CommandLine { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8
		[DispId(4)]
		string Error { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000009 RID: 9
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x0600000A RID: 10
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUTF8();

		// Token: 0x0600000B RID: 11
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagCredUsernamePassword();

		// Token: 0x0600000C RID: 12
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCACheck();

		// Token: 0x0600000D RID: 13
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagSkipCNCheck();

		// Token: 0x0600000E RID: 14
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseDigest();

		// Token: 0x0600000F RID: 15
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNegotiate();

		// Token: 0x06000010 RID: 16
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseBasic();

		// Token: 0x06000011 RID: 17
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseKerberos();

		// Token: 0x06000012 RID: 18
		[DispId(14)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagNoEncryption();

		// Token: 0x06000013 RID: 19
		[DispId(15)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagEnableSPNServerPort();

		// Token: 0x06000014 RID: 20
		[DispId(16)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SessionFlagUseNoAuthentication();

		// Token: 0x06000015 RID: 21
		[DispId(17)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagNonXmlText();

		// Token: 0x06000016 RID: 22
		[DispId(18)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnEPR();

		// Token: 0x06000017 RID: 23
		[DispId(19)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObjectAndEPR();

		// Token: 0x06000018 RID: 24
		[DispId(20)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetErrorMessage([In] uint errorNumber);

		// Token: 0x06000019 RID: 25
		[DispId(21)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeep();

		// Token: 0x0600001A RID: 26
		[DispId(22)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyShallow();

		// Token: 0x0600001B RID: 27
		[DispId(23)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x0600001C RID: 28
		[DispId(24)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int EnumerationFlagReturnObject();
	}
}
