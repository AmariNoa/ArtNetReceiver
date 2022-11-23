using ArtNet.Runtime;

namespace Amari.ArtNet
{
    public interface IArtNetDevice
    {
        public void OnReceiveDMX512(ArtNetData data);
    }
}
