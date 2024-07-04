using Sparkle.CSharp.Scenes;
using Sparkle.CSharp;
using unkwn.Scenes;
using unkwn;
using Raylib_cs;

GameSettings settings = new GameSettings() { WindowFlags = (ConfigFlags)0 };

using BaseGame game = new BaseGame(settings, "unwkn A open-source shooter");
game.Run(new MainScene());