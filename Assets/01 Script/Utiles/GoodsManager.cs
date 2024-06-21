using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodsManager : MonoBehaviour
{
    public int Gold { get; set; }

    bool UseGold(int val)
    {
        if (val > Gold)
        {
            Debug.LogError("구매 실패");
            return false;
        }
        
        Debug.Log("구매 성공");
        Gold -= val;
        return true;
    }
}