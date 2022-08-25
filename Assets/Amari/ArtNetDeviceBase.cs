using Amari.LiveSystem;
using ArtNet.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Amari.LiveSystem
{
    public class ArtNetDeviceBase : MonoBehaviour, IArtNetDevice
    {
        [SerializeField] protected int startAddress = 0;


        public virtual void OnReceiveDMX512(ArtNetData data)
        {
            // ‰½‚à‚µ‚È‚¢
        }
    }
}
