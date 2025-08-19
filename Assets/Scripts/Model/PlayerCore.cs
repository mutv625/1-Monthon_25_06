using UnityEngine;

/// <summary>
/// プレイヤーの脳・Modelにあたる
/// </summary>
public class PlayerCore
{
    public int PlayerId { get; private set; }
    public FighterID FighterId { get; private set; }

    public PlayerCore(int playerId, FighterID fighterId)
    {
        PlayerId = playerId;
        FighterId = fighterId;
    }
}
