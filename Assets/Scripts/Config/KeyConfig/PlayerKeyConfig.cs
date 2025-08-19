using UnityEngine;

[CreateAssetMenu(fileName = "PlayerKeyConfig", menuName = "ScriptableObjects/PlayerKeyConfig")]
public class PlayerKeyConfig : ScriptableObject
{
    public int playerId;

    public KeyCode jumpKey;
    public KeyCode guardKey;
    public KeyCode moveLeftKey;
    public KeyCode moveRightKey;
    public KeyCode attackAKey;
    public KeyCode attackBKey;
}
