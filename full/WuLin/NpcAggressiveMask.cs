using System;

namespace WuLin;

[Flags]
public enum NpcAggressiveMask
{
	None = 0,
	PlayerBeSaw = 1,
	PlayerStealth = 0x20,
	PlayerStealItem = 0x400,
	PlayerEnterForbiddenArea = 0x8000,
	Auction = ~PlayerBeSaw,
	All = Auction | PlayerBeSaw
}
