using UnityEngine;

public abstract class SkillScriptableObject : ScriptableObject
{
    private string skillName;

    private Sprite skillIcon;

    public abstract void ExecuteSkill(FighterController user);
}
