using Sparkle.CSharp;
using unkwn.Scenes;
using unkwn;

GameSettings settings = new GameSettings();

using BaseGame game = new BaseGame(settings, "unwkn A open-source shooter");
game.Run(new MainScene());