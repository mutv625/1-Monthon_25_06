using UnityEngine;

public class FightingEntryPoint : MonoBehaviour
{
    [SerializeField] private InputProvider inputProvider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputProvider.AcceptInput();
    }
}
