using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000002 RID: 2
public class ExitButtonScript : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void Awake()
	{
		this.button = base.GetComponent<Button>();
		this.button.onClick.AddListener(new UnityAction(this.OnButtonClick));
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000207A File Offset: 0x0000027A
	private void OnButtonClick()
	{
		Debug.Log("Clicked");
		Application.Quit();
	}

	// Token: 0x04000001 RID: 1
	private Button button;
}
