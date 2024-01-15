namespace BridgeDesignPatternGuru
{
    // Another Concrete Implementor.
    internal class AudioSystem : IDevice
    {
        void IDevice.AdjustVolume(int volume)
        {
            Console.WriteLine($"Adjust Audio System volume to {volume}");
        }

        void IDevice.SetChannel(int channel)
        {
            // Audio System doesn't have channels
            Console.WriteLine("Audio System does not support channels");
        }

        void IDevice.TurnOff()
        {
            Console.WriteLine("Audio System is OFF");
        }

        void IDevice.TurnOn()
        {
            Console.WriteLine("Audio System is ON");
        }
    }
}
