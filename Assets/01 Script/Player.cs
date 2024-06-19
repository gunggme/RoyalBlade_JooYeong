using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpPower;

    [Header("Deffence")] [SerializeField] private Image defenceIcon;
    [SerializeField] private float maxDeffenceTime;
    [SerializeField] private float tempDeffenceTime;
    [SerializeField] private float defencePower;
    
    private Animator _animator;
    private Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (tempDeffenceTime > 0)
        {
            defenceIcon.fillAmount = tempDeffenceTime / maxDeffenceTime;
            tempDeffenceTime -= Time.deltaTime;
        }
    }

    public void Jump()
    {
        _rigid.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
    }

    public void Attack()
    {
        _animator.SetTrigger("Attack");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Brick"))
        {
            if (tempDeffenceTime <= 0)
            {
                Debug.Log("방어함");
                tempDeffenceTime = maxDeffenceTime;
                if (other.transform.TryGetComponent(out BrickParent bp))
                {
                    Debug.Log("올라감");
                    bp.UpForce(defencePower);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
