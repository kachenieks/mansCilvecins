using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    [SerializeField] private GameObject skin;
    public void buttonPress()
    {
        foreach (Transform child in skin.transform)
        {
            if (child.gameObject.activeSelf)
            {
                Global.setSkin(child.GetComponent<Image>().sprite);
            }
        }
    }
}
