﻿
using TankWorld.Engine;
using TankWorld.Game.Events;

namespace TankWorld.Game.Commands
{
    class FlipMenuCommand : MenuCommand
    {
        //Constructors
        public FlipMenuCommand()
        {

        }

        //Accessors


        //Methods
        public override void Execute()
        {
            MainEventBus.PostEvent(new SceneStateEvent(SceneStateEvent.Type.FLIP_MENU));
        }

    }
}
