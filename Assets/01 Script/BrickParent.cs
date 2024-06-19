using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickParent : MonoBehaviour
{
    private Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    public void UpForce(float power)
    {
        _rigid.AddForce(Vector3.up * power, ForceMode2D.Impulse);
    }
}
