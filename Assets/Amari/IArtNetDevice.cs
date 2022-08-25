using ArtNet.Runtime;

namespace Amari.LiveSystem
{
    public interface IArtNetDevice
    {
        public void OnReceiveArtNet(ArtNetData data);
    }
}
