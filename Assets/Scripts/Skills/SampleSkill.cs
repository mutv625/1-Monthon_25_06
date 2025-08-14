using UnityEngine;

[CreateAssetMenu(fileName = "NewSampleSkill", menuName = "Skills/New Sample Skill")]
public class SampleSkill : SkillScriptableObject
{
    [SerializeField] private string skillName;

    [SerializeField] private Sprite skillIcon;

    public override void ExecuteSkill(FighterController user)
    {
        Debug.Log($"{user.name} executed skill: {skillName}");
    }

}
