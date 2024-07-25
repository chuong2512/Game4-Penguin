using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddBullet : MonoBehaviour
{
    public int number = 10;
    public string id = "add50star";

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        IAPManager.OnPurchaseSuccess = () => { GlobalValue.Checkpointbullet += number; };

        IAPManager.Instance.BuyProductID(id);
    }
}