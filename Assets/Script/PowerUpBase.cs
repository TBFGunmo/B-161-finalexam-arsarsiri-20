using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour //abstract class
{
    protected bool IsEffectActive = false;

    public abstract void ApplyEffect(Player target); //abstract method for chile override

}
