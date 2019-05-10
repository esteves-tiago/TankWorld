﻿using System;
using System.Collections.Generic;
using static TankWorld.src.InputEnum;

namespace TankWorld.src.ressources.Panels
{
    public class MainMenuScene: Scene
    {
        private List<Panel> panels;

        //Constructors
        public MainMenuScene()
        {
            panels = new List<Panel>();
        }


        //Accessors
        public List<Panel> Panels
        {
            get { return panels; }
        }

        //Methods
        public override void Enter()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new StartGameMenuItem("Start", "Start Game"));
            menuItems.Add(new StartGameMenuItem("Quit", "Quit"));
            MenuPanel menuPanel = new MenuPanel(menuItems);
            menuPanel.SetPosition((GameConstants.WINDOWS_X * 1 / 3), 100);
            panels.Add(menuPanel);
            

        }

        public override void Exit()
        {
            Sprite.RemoveAll();
        }

        public override Scene HandleInput(InputEnum input)
        {
            Scene nextScene = null;
            MenuPanel mainMenu = panels[0] as MenuPanel;
            if(mainMenu != null)
            {

            
                switch (input){
                    case PRESS_S:
                        mainMenu.GoDown();
                        break;
                    case PRESS_W:
                        mainMenu.GoUp();
                        break;
                    case PRESS_SPACE:
                        nextScene = mainMenu.Act();
                        break;
                }
            }

            return nextScene;
        }

        public override void Render()
        {
            foreach (Panel entry in panels)
            {
                entry.Render();
            }
        }

        public override void Update()
        {
            foreach(Panel entry in panels)
            {
                entry.Update();
            }
        }

    }
}
