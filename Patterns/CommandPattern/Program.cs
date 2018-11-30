using CommandPattern.Devices;
using CommandPattern.Commands;
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
            /*var remote = new SimpleRemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOnCommand = new LigthOnCommand(light);
            var garageOpenCommand = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpenCommand);
            remote.ButtonWasPressed();*/

            var remoteControl = new RemoteControl();

            var livigRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("");
            var stereo = new Stereo("Living Room");

            var livingRoomLightOn = new LightOnCommand(livigRoomLight);
            var livingRoomLightOff = new LightOffCommand(livigRoomLight);

            var kitchenRoomLightOn = new LightOnCommand(kitchenLight);
            var kitchenRoomLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            Console.WriteLine("-----------------------------------------------------");

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("-----------------------------------------------------");

            var tv = new TV("Living room");
            var hottub = new Hottub();

            var stereoOn = new StereoOnCommand(stereo);
            var tvOn = new TVOnCommand(tv);
            var hottubOn = new HottubOnCommand(hottub);

            var tvOff = new TVOffCommand(tv);
            var hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { livingRoomLightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff, tvOff, hottubOff };

            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("---Pushing Macro On---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("---Pushing Macro Off---");
            remoteControl.OffButtonWasPushed(0);

            remoteControl.UndoButtonWasPushed();
        }
    }
}
