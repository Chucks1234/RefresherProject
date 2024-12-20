using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HStat : ScriptableObject
{
    /* Remember to match UI health bar max value */
    [SerializeField] private int maxHealth;
    private int currentHealth;

    public int health
    {
        get => currentHealth;
        set => currentHealth = value;
    }
    public void PublicResetHealth()
    {
        currentHealth = maxHealth;
    }
    public int GetMaxHealthValue()
    { return maxHealth; }
}
