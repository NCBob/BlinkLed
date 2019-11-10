using System;
using System.Threading;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Leds;

namespace BasicBlinkLed
{
    public class BlinkyLed : App<F7Micro, BlinkyLed>
    { 
        public BlinkyLed()
        {
            blinkLed();
            
        }

        public void blinkLed()
        {
            Console.WriteLine("Creating Outputs...");
            var pwmRedLed = new PwmLed(Device, Device.Pins.D13, TypicalForwardVoltage.Red);
            var pwmBlueLed = new PwmLed(Device, Device.Pins.D12, TypicalForwardVoltage.Blue);

            pwmRedLed.StartBlink(10,10);
            pwmBlueLed.StartBlink(10, 10);

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
