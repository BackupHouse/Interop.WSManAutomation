using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000007 RID: 7
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("BCED617B-EC03-420B-8508-977DC7A686BD")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport]
	public class WSManClass : IWSManEx3, WSMan, IWSMan, IWSManEx, IWSManEx2
	{
		// ComImport 特性不能拥有用户定义的构造函数
		// Token: 0x06000056 RID: 86
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public extern WSManClass();

		// Token: 0x06000057 RID: 87
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000058 RID: 88
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object CreateConnectionOptions();

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000059 RID: 89
		[DispId(3)]
		public virtual extern string CommandLine { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600005A RID: 90
		[DispId(4)]
		public virtual extern string Error { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600005B RID: 91
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x0600005C RID: 92
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUTF8();

		// Token: 0x0600005D RID: 93
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagCredUsernamePassword();

		// Token: 0x0600005E RID: 94
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagSkipCACheck();

		// Token: 0x0600005F RID: 95
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagSkipCNCheck();

		// Token: 0x06000060 RID: 96
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseDigest();

		// Token: 0x06000061 RID: 97
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseNegotiate();

		// Token: 0x06000062 RID: 98
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseBasic();

		// Token: 0x06000063 RID: 99
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseKerberos();

		// Token: 0x06000064 RID: 100
		[DispId(14)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagNoEncryption();

		// Token: 0x06000065 RID: 101
		[DispId(15)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagEnableSPNServerPort();

		// Token: 0x06000066 RID: 102
		[DispId(16)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseNoAuthentication();

		// Token: 0x06000067 RID: 103
		[DispId(17)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagNonXmlText();

		// Token: 0x06000068 RID: 104
		[DispId(18)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagReturnEPR();

		// Token: 0x06000069 RID: 105
		[DispId(19)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagReturnObjectAndEPR();

		// Token: 0x0600006A RID: 106
		[DispId(20)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string GetErrorMessage([In] uint errorNumber);

		// Token: 0x0600006B RID: 107
		[DispId(21)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagHierarchyDeep();

		// Token: 0x0600006C RID: 108
		[DispId(22)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagHierarchyShallow();

		// Token: 0x0600006D RID: 109
		[DispId(23)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x0600006E RID: 110
		[DispId(24)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagReturnObject();

		// Token: 0x0600006F RID: 111
		[DispId(25)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseClientCertificate();

		// Token: 0x06000070 RID: 112
		[DispId(26)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUTF16();

		// Token: 0x06000071 RID: 113
		[DispId(27)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseCredSsp();

		// Token: 0x06000072 RID: 114
		[DispId(28)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagAssociationInstance();

		// Token: 0x06000073 RID: 115
		[DispId(29)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int EnumerationFlagAssociatedInstance();

		// Token: 0x06000074 RID: 116
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagSkipRevocationCheck();

		// Token: 0x06000075 RID: 117
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagAllowNegotiateImplicitCredentials();

		// Token: 0x06000076 RID: 118
		[DispId(32)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SessionFlagUseSsl();

		// Token: 0x06000077 RID: 119
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSMan_CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000078 RID: 120
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSMan_CreateConnectionOptions();

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000079 RID: 121
		public virtual extern string IWSMan_CommandLine { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007A RID: 122
		public virtual extern string IWSMan_Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600007B RID: 123
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx_CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x0600007C RID: 124
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx_CreateConnectionOptions();

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007D RID: 125
		public virtual extern string IWSManEx_CommandLine { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007E RID: 126
		public virtual extern string IWSManEx_Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600007F RID: 127
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx_CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x06000080 RID: 128
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUTF8();

		// Token: 0x06000081 RID: 129
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagCredUsernamePassword();

		// Token: 0x06000082 RID: 130
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagSkipCACheck();

		// Token: 0x06000083 RID: 131
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagSkipCNCheck();

		// Token: 0x06000084 RID: 132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUseDigest();

		// Token: 0x06000085 RID: 133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUseNegotiate();

		// Token: 0x06000086 RID: 134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUseBasic();

		// Token: 0x06000087 RID: 135
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUseKerberos();

		// Token: 0x06000088 RID: 136
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagNoEncryption();

		// Token: 0x06000089 RID: 137
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagEnableSPNServerPort();

		// Token: 0x0600008A RID: 138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_SessionFlagUseNoAuthentication();

		// Token: 0x0600008B RID: 139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagNonXmlText();

		// Token: 0x0600008C RID: 140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagReturnEPR();

		// Token: 0x0600008D RID: 141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagReturnObjectAndEPR();

		// Token: 0x0600008E RID: 142
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IWSManEx_GetErrorMessage([In] uint errorNumber);

		// Token: 0x0600008F RID: 143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagHierarchyDeep();

		// Token: 0x06000090 RID: 144
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagHierarchyShallow();

		// Token: 0x06000091 RID: 145
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x06000092 RID: 146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx_EnumerationFlagReturnObject();

		// Token: 0x06000093 RID: 147
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx2_CreateSession([MarshalAs(UnmanagedType.BStr)][In] string connection, [In] int flags, [IDispatchConstant][MarshalAs(UnmanagedType.IDispatch)][In][Optional] object connectionOptions);

		// Token: 0x06000094 RID: 148
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx2_CreateConnectionOptions();

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000095 RID: 149
		public virtual extern string IWSManEx2_CommandLine { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000096 RID: 150
		public virtual extern string IWSManEx2_Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000097 RID: 151
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object IWSManEx2_CreateResourceLocator([MarshalAs(UnmanagedType.BStr)][In] string strResourceLocator = "");

		// Token: 0x06000098 RID: 152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUTF8();

		// Token: 0x06000099 RID: 153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagCredUsernamePassword();

		// Token: 0x0600009A RID: 154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagSkipCACheck();

		// Token: 0x0600009B RID: 155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagSkipCNCheck();

		// Token: 0x0600009C RID: 156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseDigest();

		// Token: 0x0600009D RID: 157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseNegotiate();

		// Token: 0x0600009E RID: 158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseBasic();

		// Token: 0x0600009F RID: 159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseKerberos();

		// Token: 0x060000A0 RID: 160
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagNoEncryption();

		// Token: 0x060000A1 RID: 161
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagEnableSPNServerPort();

		// Token: 0x060000A2 RID: 162
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseNoAuthentication();

		// Token: 0x060000A3 RID: 163
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagNonXmlText();

		// Token: 0x060000A4 RID: 164
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagReturnEPR();

		// Token: 0x060000A5 RID: 165
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagReturnObjectAndEPR();

		// Token: 0x060000A6 RID: 166
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public virtual extern string IWSManEx2_GetErrorMessage([In] uint errorNumber);

		// Token: 0x060000A7 RID: 167
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagHierarchyDeep();

		// Token: 0x060000A8 RID: 168
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagHierarchyShallow();

		// Token: 0x060000A9 RID: 169
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagHierarchyDeepBasePropsOnly();

		// Token: 0x060000AA RID: 170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_EnumerationFlagReturnObject();

		// Token: 0x060000AB RID: 171
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int IWSManEx2_SessionFlagUseClientCertificate();
	}
}
