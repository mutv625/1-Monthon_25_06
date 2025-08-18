using UnityEngine;

[CreateAssetMenu(fileName = "NewSampleSkill", menuName = "Skills/New Sample Skill")]
public class SampleSkill : SkillScriptableObject
{
    [SerializeField] private string _skillName;
    public override string SkillName => _skillName;

    [SerializeField] private Sprite _skillIcon;
    public override Sprite SkillIcon => _skillIcon;

    [SerializeField] private GameObject _hitboxPrefab;

    public override void ExecuteSkill(FighterController user)
    {
        Debug.Log($"{user.name} executed skill: {_skillName}");

        // プレイヤーのアニメーションを再生
        // アニメーション内でヒットボックスを生成する



    }

    

}
