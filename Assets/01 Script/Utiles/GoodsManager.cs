using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoodsManager : MonoBehaviour
{
    public int Gold { get; set; }
    [SerializeField] private TMP_Text _goldText;

    private void Awake()
    {
        _goldText.text = $"{Gold:N0}G";
    }

    private void Update()
    {
        
    }

    public void GetGold(int val)
    {
        Gold += val;
        _goldText.text = $"{Gold:N0}G";
    }
    
    public bool UseGold(int val)
    {
        if (val > Gold)
        {
            Debug.LogError("구매 실패");
            return false;
        }
        
        Debug.Log("구매 성공");
        Gold -= val;
        _goldText.text = $"{Gold:N0}G";
        return true;
    }
}