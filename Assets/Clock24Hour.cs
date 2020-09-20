using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Clock24Hour : MonoBehaviour
{
    public TMP_Text ClockFaceDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime localDate = DateTime.Now;
        ClockFaceDisplay.text = localDate.Hour.ToString("D2") +":" + localDate.Minute.ToString("D2");
    }
}
