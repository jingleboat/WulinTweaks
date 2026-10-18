using System;

namespace WuLin;

[Flags]
public enum GameFunctionMask
{
	None = 0,
	PlayerControl = 1,
	PlayerTriggerNpcSight = 4,
	PlayerPet = 8,
	InGameTimeElapse = 0x20,
	SaveGame = 0x400,
	All = -1
}
