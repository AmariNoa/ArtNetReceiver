using ArtNet.Runtime;

namespace Amari.LiveSystem
{
    public interface IArtNetDevice
    {
        public void OnReceiveDMX512(ArtNetData data);
    }
}
