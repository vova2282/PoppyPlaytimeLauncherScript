using System;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x02000004 RID: 4
public class PopupWindowScript : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x0000215C File Offset: 0x0000035C
	public void Chapter2ButtonPressed()
	{
		if (this.doOpenURL)
		{
			Application.OpenURL(this.openURL);
		}
        Object.Destroy(base.gameObject);
	}

	// Token: 0x04000005 RID: 5
	[SerializeField]
	private bool doOpenURL;

	// Token: 0x04000006 RID: 6
	[SerializeField]
	private string openURL;
}
