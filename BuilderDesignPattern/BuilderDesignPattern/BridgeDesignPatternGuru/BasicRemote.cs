namespace BridgeDesignPatternGuru
{
    // Redefined Abstractions.
    internal class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device): base(device)
        {
        }

        public override void AdjustVolume(int volume)
        {
            device.AdjustVolume(volume);
        }

        public override void SetChannel(int channel)
        {
            device.SetChannel(channel);
        }
    }
}
