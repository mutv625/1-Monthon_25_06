using UnityEngine;

/// <summary>
/// プレイヤーのAnimationClipを格納するクラス
/// (PlayerAnimatorの方に渡される)
/// </summary>
public class PlayerAnimationStorage : MonoBehaviour
{
    [SerializeField] private SerDictionary<FighterID, AnimatorOverrideController> animatorOverrides;
}
