using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcquireSkin : MonoBehaviour
{
    [SerializeField] private Image img;
    void Start()
    {
        if (img != null && Global.skin != null)
            img.sprite = Global.skin;
    }
}
