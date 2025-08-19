using System.Collections.Generic;
using UnityEngine;
using UniRx;

// 入力は View だと信じて
public class InputProvider : MonoBehaviour
{
    [SerializeField] private List<PlayerKeyConfig> playerKeyConfigs;

    public Subject<Unit> On

    public void InitializeForEach(List<PlayerCore> playerCores)
    {
        foreach (var playerCore in playerCores)
        {

        }
    }



}
