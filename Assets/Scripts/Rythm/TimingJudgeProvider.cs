using UnityEngine;

public enum Judgement
{
    Perfect,
    Great,
    Good,
    Miss
}

public class TimingJudgeProvider : MonoBehaviour
{
    // 譜面ファイルのパス
    [SerializeField] private string sheetMusicFilePath;

    // 譜面データ

    public Judgement JudgeByTiming(float inputTiming)
    {
        // Implement your timing judgment logic here
        return Judgement.Perfect;
    }

}
