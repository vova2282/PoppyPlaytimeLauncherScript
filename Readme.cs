using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class Readme : ScriptableObject
{
	// Token: 0x04000007 RID: 7
	public Texture2D icon;

	// Token: 0x04000008 RID: 8
	public string title;

	// Token: 0x04000009 RID: 9
	public Readme.Section[] sections;

	// Token: 0x0400000A RID: 10
	public bool loadedLayout;

	// Token: 0x02000006 RID: 6
	[Serializable]
	public class Section
	{
		// Token: 0x0400000B RID: 11
		public string heading;

		// Token: 0x0400000C RID: 12
		public string text;

		// Token: 0x0400000D RID: 13
		public string linkText;

		// Token: 0x0400000E RID: 14
		public string url;
	}
}
