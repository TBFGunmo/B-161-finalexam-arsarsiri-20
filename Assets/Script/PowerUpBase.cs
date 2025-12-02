using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive = false;

    public abstract void ApplyEffect(Player target);
    
}
