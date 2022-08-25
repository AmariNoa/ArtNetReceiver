using ArtNet.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Amari.LiveSystem
{
    public interface IArtNetDevice
    {
        public void OnReceiveArtNet(ArtNetData data);
    }
}
