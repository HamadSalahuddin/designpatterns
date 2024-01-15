namespace BridgeDesignPatternGuru
{
    // Implementor Interface
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
        void AdjustVolume(int volume);
    }
}
