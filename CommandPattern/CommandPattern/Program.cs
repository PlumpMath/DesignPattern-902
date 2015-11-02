using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Light light = new Light();
            //GarageDoor garageDoor = new GarageDoor();

            //LightOnCommand lightOn = new LightOnCommand(light);
            //GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            //remote.setCommand(lightOn);
            //remote.buttonWasPressed();

            //remote.setCommand(garageOpen);
            //remote.buttonWasPressed();
            RemoteControl remoteControl = new RemoteControl();


            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageClose = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffWithCDCommand stereoOffWithCD = new StereoOffWithCDCommand(stereo);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.setCommand(2, garageOpen, garageClose);
            remoteControl.setCommand(3, stereoOnWithCD, stereoOffWithCD);

            remoteControl.setCommand(4, ceilingFanHigh, ceilingFanOff);
            remoteControl.setCommand(5, ceilingFanMedium, ceilingFanOff);
            remoteControl.setCommand(6, ceilingFanLow, ceilingFanOff);

            Console.WriteLine(remoteControl.toString());

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(5);
            remoteControl.offButtonWasPushed(5);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(4);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();


            #region marco command
            Command[] partyOn = { kitchenLightOn, livingRoomLightOn, garageOpen, stereoOnWithCD };
            Command[] partyOff = { kitchenLightOff, livingRoomLightOff, garageClose, stereoOffWithCD };

            MacroCommand partyOnCommand = new MacroCommand(partyOn);
            MacroCommand partyOffCommand = new MacroCommand(partyOff);

            remoteControl.setCommand(6, partyOnCommand, partyOffCommand);

            remoteControl.onButtonWasPushed(6);
            remoteControl.offButtonWasPushed(6);
            remoteControl.undoButtonWasPushed();
            #endregion
            Console.ReadLine();
        }
    }
}
