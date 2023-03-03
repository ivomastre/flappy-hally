using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinExitOnClick : MonoBehaviour
{
    public void OnClick()
    {
        // Set parent visibility to false
        transform.parent.gameObject.SetActive(false);
    }
}
