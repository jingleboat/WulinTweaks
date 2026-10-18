namespace WuLin.StateMachine;

public enum StateMachineDataTypes
{
	None = 0,
	Battle_BattleStart = 100,
	Battle_BattleFinished = 101,
	Battle_ActorReady = 110,
	Battle_PerformComplete = 111,
	Battle_OnControlMoving = 150,
	Battle_OnControlAction = 151,
	Battle_ActorHasMoved = 180,
	Battle_ActorHasActiveSecondStrike = 181,
	Battle_ActorHasMadeSecondStrike = 182,
	Interactive_OnCharacterSet = 200,
	Interactive_OnOptionChoose = 201,
	Interactive_OnObjectSet = 202,
	Interactive_OnStoryAction = 203,
	Interactive_OnLastOptionData = 204,
	Interactive_OnFactionLeaderAction = 205
}
