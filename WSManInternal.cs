using System;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000009 RID: 9
	[Guid("04AE2B1D-9954-4D99-94A9-A961E72C3A13")]
	[CoClass(typeof(WSManInternalClass))]
	[ComImport]
	public interface WSManInternal : IWSManInternal
	{
	}
}
