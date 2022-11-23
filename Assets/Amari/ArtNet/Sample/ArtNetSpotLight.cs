using Amari.ArtNet;
using ArtNet.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtNetSpotLight : ArtNetDeviceBase
{
    [Header("Light")]
    [SerializeField] private float maxLightPower = 12.0f;
    private Light lightComp;

    // TODO Check steps (255 or 256?)
    private const int DMX_MAX_STEP = 256; 
    private const float STEP_TO_DEGREE = 365.0f / DMX_MAX_STEP;

    private float StepToDegree(int step)
    {
        return step * STEP_TO_DEGREE - 180.0f;  // 256(Step) to -180~180(Degree)
    }

    public override void OnReceiveDMX512(ArtNetData data)
    {
        Vector3 localRot = gameObject.transform.localEulerAngles;
        Color col = lightComp.color;
        localRot.z = StepToDegree(data.Channels[startAddress]);                                 // Pan              (ch1)
        localRot.x = StepToDegree(data.Channels[startAddress + 1]);                             // Tilt             (ch2)
        lightComp.intensity = maxLightPower * (data.Channels[startAddress + 2] / DMX_MAX_STEP); // Master Dimmer    (ch3)
        col.r = data.Channels[startAddress + 3];                                                // Red Dimmer       (ch4)
        col.g = data.Channels[startAddress + 4];                                                // Green Dimmer     (ch5)
        col.b = data.Channels[startAddress + 5];                                                // Blue Dimmer      (ch6)
        // TODO Impl                                                                               Iris             (ch7)
        // TODO Impl                                                                               Zoom             (ch8)
        // TODO Impl                                                                               Reset            (ch9)
    }

    private void Awake()
    {
        lightComp = GetComponent<Light>();
        
        if(lightComp == null)
        {
            gameObject.SetActive(false);
            return;
        }
    }
}
