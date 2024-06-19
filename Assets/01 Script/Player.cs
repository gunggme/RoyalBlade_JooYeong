using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpPower;

    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
    }
}
