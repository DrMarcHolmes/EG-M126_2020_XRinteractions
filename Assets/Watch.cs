using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Watch : MonoBehaviour
{
    public TMP_Text ClockFaceDisplay;
    public enum ClockType {_24hour,_12Hour};
    public ClockType FaceChoice;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (FaceChoice == ClockType._24hour)
        {
            DateTime localDate = DateTime.Now;
            ClockFaceDisplay.text = localDate.Hour.ToString("D2") + ":" + localDate.Minute.ToString("D2");
        }
        if (FaceChoice == ClockType._12Hour)
        {
            DateTime localDate = DateTime.Now;

            string AMorPM = "AM";
            if (localDate.Hour > 12) AMorPM = "PM";
            if (localDate.Hour < 1 & localDate.Minute <= 1) AMorPM = "PM";

            ClockFaceDisplay.text = 
                  localDate.Hour.ToString("D2") 
                + ":" 
                + localDate.Minute.ToString("D2") 
                + " " 
                + AMorPM;
        }

    }
}
