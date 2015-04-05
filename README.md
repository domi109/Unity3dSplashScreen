# UnitySplash
Unity3D version 5 Personal Edition game launcher with your own professional splash screen

The purpose of this git repositary is, to force Unity Technologies rebranding the ridiculous splash screen from Personal Edition to something else; like, Powered by Unity. Personal Edition sounds like the games are developed with a non-commercial (personal) evaluation version.

This game launcher will not remove the mandatory Unity3D splash screen, however, the way Unity3D coded the splash screen gives us an advantage not having to show it without actually removing it.

The basics are like this:

The game launcher will execute the Unity3D game minimized. The startup scene (usually your Unity3D game menu) will have a script attached which is included here, to maximize the game window. The Unity splash screen does not allow any coding, so we use this trick. The result will be that when the Unity splash screen is finished the game menu will show up giving the impression that there was no Unity3D Personal Edition splash screen.

The structure is: Game folder, game launcher, sub folder for Unity game. Everything is customizable.

Please share this with your friends and promote it everywhere. It’s free software and you never will have to pay for it. If you got this game launcher from somewhere else having to pay money for it then I take no responsibility for it that you get your money back.
