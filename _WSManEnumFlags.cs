using System;

namespace WSManAutomation
{
	// Token: 0x0200000C RID: 12
	public enum _WSManEnumFlags
	{
		// Token: 0x04000014 RID: 20
		WSManFlagNonXmlText = 1,
		// Token: 0x04000015 RID: 21
		WSManFlagReturnObject = 0,
		// Token: 0x04000016 RID: 22
		WSManFlagReturnEPR = 2,
		// Token: 0x04000017 RID: 23
		WSManFlagReturnObjectAndEPR = 4,
		// Token: 0x04000018 RID: 24
		WSManFlagHierarchyDeep = 0,
		// Token: 0x04000019 RID: 25
		WSManFlagHierarchyShallow = 32,
		// Token: 0x0400001A RID: 26
		WSManFlagHierarchyDeepBasePropsOnly = 64,
		// Token: 0x0400001B RID: 27
		WSManFlagAssociatedInstance = 0,
		// Token: 0x0400001C RID: 28
		WSManFlagAssociationInstance = 128
	}

	// Token: 0x0200000D RID: 13
	public enum _WSManProxyAccessTypeFlags
	{
		// Token: 0x0400001E RID: 30
		WSManProxyIEConfig = 1,
		// Token: 0x0400001F RID: 31
		WSManProxyWinHttpConfig,
		// Token: 0x04000020 RID: 32
		WSManProxyAutoDetect = 4,
		// Token: 0x04000021 RID: 33
		WSManProxyNoProxyServer = 8
	}
	public enum _WSManProxyAuthenticationFlags
	{
		// Token: 0x04000023 RID: 35
		WSManFlagProxyAuthenticationUseNegotiate = 1,
		// Token: 0x04000024 RID: 36
		WSManFlagProxyAuthenticationUseBasic,
		// Token: 0x04000025 RID: 37
		WSManFlagProxyAuthenticationUseDigest = 4
	}

	public enum _WSManSessionFlags
	{
		// Token: 0x04000002 RID: 2
		WSManFlagUTF8 = 1,
		// Token: 0x04000003 RID: 3
		WSManFlagCredUsernamePassword = 4096,
		// Token: 0x04000004 RID: 4
		WSManFlagSkipCACheck = 8192,
		// Token: 0x04000005 RID: 5
		WSManFlagSkipCNCheck = 16384,
		// Token: 0x04000006 RID: 6
		WSManFlagUseNoAuthentication = 32768,
		// Token: 0x04000007 RID: 7
		WSManFlagUseDigest = 65536,
		// Token: 0x04000008 RID: 8
		WSManFlagUseNegotiate = 131072,
		// Token: 0x04000009 RID: 9
		WSManFlagUseBasic = 262144,
		// Token: 0x0400000A RID: 10
		WSManFlagUseKerberos = 524288,
		// Token: 0x0400000B RID: 11
		WSManFlagNoEncryption = 1048576,
		// Token: 0x0400000C RID: 12
		WSManFlagUseClientCertificate = 2097152,
		// Token: 0x0400000D RID: 13
		WSManFlagEnableSPNServerPort = 4194304,
		// Token: 0x0400000E RID: 14
		WSManFlagUTF16 = 8388608,
		// Token: 0x0400000F RID: 15
		WSManFlagUseCredSsp = 16777216,
		// Token: 0x04000010 RID: 16
		WSManFlagSkipRevocationCheck = 33554432,
		// Token: 0x04000011 RID: 17
		WSManFlagAllowNegotiateImplicitCredentials = 67108864,
		// Token: 0x04000012 RID: 18
		WSManFlagUseSsl = 134217728
	}
}
