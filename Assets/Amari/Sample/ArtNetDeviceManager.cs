using Amari.LiveSystem;
using ArtNet.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtNetDeviceManager : MonoBehaviour
{
    [SerializeField] private ArtNetClient client;
    [SerializeReference] private List<ArtNetDeviceBase> artNetDevices = new List<ArtNetDeviceBase>();

    void Start()
    {
        this.client.onDataReceived += data =>
        {
            if (data.OpCode == ArtNetOpCode.OpDmx)
            {
                foreach (var device in artNetDevices)
                {
                    device?.OnReceiveDMX512(data);
                }

                /*
                GetComponent<Light>().color = new Color(
                    data.Channels[0],
                    data.Channels[1],
                    data.Channels[2]);
                */
            }
        };
    }
}
