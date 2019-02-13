﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextMeshPro

public class Timer : MonoBehaviour
{
    TextMeshProUGUI text;

    public float time = 60;

    void Start()
    {
        text = Getcomponent<TextMeshProUGUI>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        text.text = string.Format("{0:0}", time);
    }
}
