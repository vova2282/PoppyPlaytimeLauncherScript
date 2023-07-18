using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Object = UnityEngine.Object;

// Token: 0x02000003 RID: 3
public class LauncherButtonScript : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002093 File Offset: 0x00000293
	private void Awake()
	{
		this.button = base.GetComponent<Button>();
		this.button.onClick.AddListener(new UnityAction(this.OnButtonClick));
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000020C0 File Offset: 0x000002C0
	private void OnButtonClick()
	{
        UnityEngine.Debug.Log("Clicked");
		string fileName = Application.dataPath + "/../../WindowsNoEditor/" + this.executableName + ".exe";
		try
		{
			Process.Start(fileName);
			Application.Quit();
		}
		catch
		{
            UnityEngine.Debug.Log("Didn't work");
			GameObject gameObject = Object.Instantiate<GameObject>(this.OnErrorPopupWindow);
			gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("PopupWindowContainer").transform);
			gameObject.transform.localPosition = Vector3.zero;
		}
	}

	// Token: 0x04000002 RID: 2
	[SerializeField]
	private string executableName;

	// Token: 0x04000003 RID: 3
	[SerializeField]
	private GameObject OnErrorPopupWindow;

	// Token: 0x04000004 RID: 4
	private Button button;
}
