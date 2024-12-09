using PatternBridge.ConcreteImplementor;
using PatternBridge.Control;
using PatternBridge.Implementor;

class Program
{
    static void Main(string[] args)
    {
        RemoteControl remoteControl = new TelevisionRemoteControl(new Television());
        remoteControl.PowerOn();
        remoteControl.SetChannel();
        remoteControl.PowerOff();
    }
}