using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI text;
    //text field

    public float time = 30;
    //remaining time

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        //initailization
    }

    void Update()
    {
        time -= Time.deltaTime;
        text.text = string.Format("{0:0}", time);
        //counting the timer
    }
}
