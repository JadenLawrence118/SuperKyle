﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cans = 0;
    [SerializeField] private Text canCount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Can"))
        {
            Destroy(collision.gameObject);
            cans++;
            canCount.text = "Cans: " + cans;
        }

    }
}
