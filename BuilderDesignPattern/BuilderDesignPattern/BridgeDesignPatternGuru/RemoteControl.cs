namespace BridgeDesignPatternGuru
{
    // Abstraction
    public abstract class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public virtual void PowerOn()
        {
            device.TurnOn();
        }

        public virtual void PowerOff()
        {
            device.TurnOff();
        }

        public abstract void SetChannel(int channel);

        public abstract void AdjustVolume(int volume);
    }
}
