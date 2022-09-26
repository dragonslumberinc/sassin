using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Autohand;
using System;

public class WristDial : PhysicsGadgetHingeAngleReader
{
    public int numberOfOptions = 4;
    public TimeZoneManager manager;
    private int lastTimeZone = -1;

    void Update() {
        int currTimeZone = ConvertValueToPos();

        if (lastTimeZone == -1)
            lastTimeZone = currTimeZone;

        Debug.Log(string.Format("{0}, {1}", lastTimeZone, currTimeZone));

        if (currTimeZone != lastTimeZone) {
            manager.SetTimeZone(currTimeZone + 1);
            lastTimeZone = currTimeZone;
        }
    }

    int ConvertValueToPos() {
        float val = GetValue();
        float num = 2f / numberOfOptions;

        float res = (float)Math.Ceiling((val + 1) / num);
        res -= 1;
        if (res < 0)
            res = 0;

        return ((int)res);
    }
}
