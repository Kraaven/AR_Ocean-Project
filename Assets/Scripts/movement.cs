using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 pos;
    private float TheSin;
    private float oldSin;
    private float oci = 0;
    // Update is called once per frame
    public void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        oci+= 0.05f;
        TheSin = (float)Math.Sin(oci) * 0.07f;
        if (TheSin < 0 && oldSin < TheSin)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (TheSin > 0 && TheSin< oldSin)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }

        transform.position = new Vector3(pos.x + TheSin, pos.y, pos.z);
        oldSin = TheSin;

    }
}
