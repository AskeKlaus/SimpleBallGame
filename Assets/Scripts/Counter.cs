﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlusPoint"))
        {
            count += 1;
            counterText.text = "Count : " + count + "/10";
        }

    }
}
