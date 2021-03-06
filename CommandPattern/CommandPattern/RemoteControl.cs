﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];

        }
        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }


        public string toString()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.Append("\n-----Remote Control-----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuild.Append("[slot " + i.ToString() + "]" + onCommands[i].GetType().ToString() + "        " + offCommands[i].GetType().ToString() + "\n");

            }
            return stringBuild.ToString();
        }
    }
}
