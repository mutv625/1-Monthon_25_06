using UnityEngine;
using UniRx;

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


    public void Move(float x)
    {
        // プレイヤーの行動を実行する処理
    }
    public void Jump()
    {
        // ジャンプの処理
    }

}
