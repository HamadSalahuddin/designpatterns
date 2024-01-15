namespace BridgeDesignPatternGuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            IDevice audioSystem = new AudioSystem();

            RemoteControl basicRemote = new BasicRemote(tv);
            RemoteControl advancedRemote = new AdvancedRemote(audioSystem);

            basicRemote.PowerOn();
            basicRemote.SetChannel(5);
            basicRemote.AdjustVolume(20);
            basicRemote.PowerOff();

            Console.WriteLine();

            advancedRemote.PowerOn();
            advancedRemote.SetChannel(10);
            advancedRemote.AdjustVolume(30);
            advancedRemote.PowerOff();
        }
    }
}
