﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TROFF
{
    public static class Textures
    {
        public static Texture2D GameBackground,
                                MenuBackground,
                                GameOverBackground,
                                HelpBackground,
                                LobbyBackground;

        public static Texture2D Color1, Color2;
        public static Texture2D Light1, Light2;

        public static ButtonTextures Create, Join, Quit, Help, Ready, ComeBack, TextBox;

        public static Texture2D Cursor;

        public static void Initialize(ContentManager content)
        {
            GameBackground = content.Load<Texture2D>("GameBackground");
            MenuBackground = content.Load<Texture2D>("MenuBackground");
            GameOverBackground = content.Load<Texture2D>("GameOverBackground");
            HelpBackground = content.Load<Texture2D>("HelpBackground");
            LobbyBackground = content.Load<Texture2D>("LobbyBackground");

            Create = new ButtonTextures("Create", content);
            Join = new ButtonTextures("Join", content);
            Quit = new ButtonTextures("Quit", content);
            Help = new ButtonTextures("Help", content);
            Ready = new ButtonTextures("Ready", content);
            ComeBack = new ButtonTextures("ComeBack", content);
            TextBox = new ButtonTextures("TextBox", content);

            Color1 = content.Load<Texture2D>("Color1");
            Color2 = content.Load<Texture2D>("Color2");
            Light1 = content.Load<Texture2D>("Light1");
            Light2 = content.Load<Texture2D>("Light2");

            Cursor = content.Load<Texture2D>("Cursor");
        }
    }

    public struct ButtonTextures
    {
        public Texture2D Base, Focus;

        public ButtonTextures(string p, ContentManager content)
        {
            Base = content.Load<Texture2D>(p);
            Focus = content.Load<Texture2D>(p + "Hover");
        }
    }
}
