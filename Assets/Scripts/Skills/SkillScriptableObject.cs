using UnityEngine;

public abstract class SkillScriptableObject : ScriptableObject
{
    public abstract string SkillName { get; }

    public abstract Sprite SkillIcon { get; }

    public abstract void ExecuteSkill(FighterController user);
}
