using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject vfx;

    public void SetDeactiveVfx()
    {
        vfx.SetActive(false);
    }
}
