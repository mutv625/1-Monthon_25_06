using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 戦闘シーンのフローを制御するエントリーポイント
/// </summary>
public class FightingEntryPoint : MonoBehaviour
{
    [SerializeField] private PlayerPrefab playerPrefab;
    private List<PlayerKeyConfig> playerKeyConfigs;

    [Header("View Only")]
    [SerializeField] private PlayerPrefab playerP1;
    private PlayerCore playerCoreP1;

    void Start()
    {
        // * Test
        InitializePlayer();
    }

    void InitializePlayer()
    {
        // * 1P の初期化
        playerCoreP1 = new PlayerCore(1, FighterID.Default);
        playerP1 = Instantiate(playerPrefab);
        playerP1.Initialize(playerCoreP1);

        // TODO: 2P の初期化
    }

    
    void Update()
    {

    }
}
