using ArtNet.Runtime;
using UnityEngine;

namespace Amari.ArtNet
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
