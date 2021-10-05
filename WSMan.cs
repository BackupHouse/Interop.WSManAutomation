using System;
using System.Runtime.InteropServices;

namespace WSManAutomation
{
	// Token: 0x02000006 RID: 6
	[Guid("6400E966-011D-4EAC-8474-049E0848AFAD")]
	[CoClass(typeof(WSManClass))]
	[ComImport]
	public interface WSMan : IWSManEx3
	{
	}
}
