using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    [SerializeField] Text time;

    private void Update()
    {
        time.text = DateTime.Now.ToString("HH:mm");
    }
}
