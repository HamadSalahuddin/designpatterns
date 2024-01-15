using System.Threading.Channels;

namespace BridgeDesignPatternGuru
{
    // Concrete Implementors
    public class TV : IDevice
    {
        void IDevice.AdjustVolume(int volume)
        {
            Console.WriteLine($"Adjust TV volume to {volume}");
        }

        void IDevice.SetChannel(int channel)
        {
            Console.WriteLine($"Set TV channel to {channel}");
        }

        void IDevice.TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }

        void IDevice.TurnOn()
        {
            Console.WriteLine("TV is ON");
        }
    }
}
