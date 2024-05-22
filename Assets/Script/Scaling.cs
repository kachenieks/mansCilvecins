using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaling : MonoBehaviour
{
    public GameObject skin;

    public void Width(float n)
    {
        skin.transform.localScale = new Vector3(1F * n, skin.transform.localScale.y, skin.transform.localScale.z);
    }
    public void Height(float n)
    {
        skin.transform.localScale = new Vector3(skin.transform.localScale.x, 1F * n, skin.transform.localScale.z);
    }
}
