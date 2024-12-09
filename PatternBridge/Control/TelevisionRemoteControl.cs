using PatternBridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Control
{
    public class TelevisionRemoteControl : RemoteControl
    {
        public TelevisionRemoteControl(IDevice device)
        {
            this._device = device;
        }

        public override void PowerOn()
        { 
            _device.PowerOn();
        }

        public override void PowerOff()
        {
            _device.PowerOff();
        }

        public new int SetChannel()
        {
            int channel = base.SetChannel();
            _device.SetChannel(channel);
            return channel;
        }
    }
}
