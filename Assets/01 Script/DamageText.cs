using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    public TMP_Text _text;
    private RectTransform _rect;
    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    public void SetText(string txt)
    {
        _text.text = txt;
    }

    private void Update()
    {
        _rect.anchoredPosition += Vector2.up *_movementSpeed * Time.deltaTime;
    }

    void DisableObj()
    {
        gameObject.SetActive(false);
    }
}
