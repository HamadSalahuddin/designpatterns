using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeDesignPatternGuru
{
    public class AdvancedRemote : RemoteControl
    {

        public AdvancedRemote(IDevice device): base(device)
        {

        }
        public override void AdjustVolume(int volume)
        {
            // Advanced remote can have additional audio settings
            Console.WriteLine($"Adjusting advanced volume to {volume}");
            device.AdjustVolume(volume);
        }

        public override void SetChannel(int channel)
        {
            // Advanced remote can remember favorite channels or provide additional features
            Console.WriteLine($"Setting favorite channel {channel}");
            device.SetChannel(channel);
        }
    }
}
