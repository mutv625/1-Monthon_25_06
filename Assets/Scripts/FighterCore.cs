using UnityEngine;

public class FighterCore : MonoBehaviour
{
    [SerializeField] private float initialHealth;
    public float InitialHealth { get; }

    [SerializeField] private float currentHealth;
    public float CurrentHealth { get; set; }

    void Start()
    {
        CurrentHealth = initialHealth;
    }
}
