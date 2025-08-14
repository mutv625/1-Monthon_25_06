using UnityEngine;

public interface ISkill
{
    public string SkillName { get; }
    public Sprite SkillIcon { get; }

    public void ExecuteSkill(FighterController fighterController);
}
