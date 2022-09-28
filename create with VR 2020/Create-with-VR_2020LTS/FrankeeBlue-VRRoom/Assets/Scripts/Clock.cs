using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Clock : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHands;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime nowTime = DateTime.Now;
        float secondDegree = (nowTime.Second / 60f) *  360f;
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(secondDegree, 0, 0));
    }
}
