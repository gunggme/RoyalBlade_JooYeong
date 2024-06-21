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

    public float MaxDeffenceTime
    {
        get => maxDeffenceTime * DefCoolDown;
        set => maxDeffenceTime = value;
    }

    [field: SerializeField]
    public float DefCoolDown
    {
        get;
        set;
    }
    [field: SerializeField]public float AttPower
    {
        get;
        set;
    }

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
            defenceIcon.fillAmount = tempDeffenceTime / MaxDeffenceTime;
            tempDeffenceTime -= Time.deltaTime;
        }
    }

    public void Jump()
    {
        if (!CheckGround())
        {
            return;
        }
        _rigid.AddForce(Vector3.up * _jumpPower, ForceMode2D.Impulse);
    }

    public void Attack()
    {
        _animator.SetTrigger("Attack");
    }
    
    bool CheckGround()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Ground"));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Brick"))
        {
            if (tempDeffenceTime <= 0)
            {
                Debug.Log("방어함");
                tempDeffenceTime = MaxDeffenceTime;
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
