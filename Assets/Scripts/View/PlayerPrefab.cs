using UnityEngine;

/// <summary>
/// プレイヤーの体・Viewにあたる
/// </summary>
public class PlayerPrefab : MonoBehaviour
{
    public PlayerCore PlayerCore { get; private set; }

    public void Initialize(PlayerCore playerCore)
    {
        PlayerCore = playerCore;
    }
}
