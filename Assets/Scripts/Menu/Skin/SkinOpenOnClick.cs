using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinOpenOnClick : MonoBehaviour
{
    public GameObject SkinsDialogContainer;
    public void OnClick()
    {
        SkinsDialogContainer.SetActive(true);
    }
}
