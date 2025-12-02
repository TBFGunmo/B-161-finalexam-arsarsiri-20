using UnityEngine;

public class SpeedBoost : PowerUpBase //inhheritance from PowerUpBase
{
    public override void ApplyEffect(Player target) //override abstract method
    {
        if (!IsEffectActive)
        {
            target.SetMoveSpeed(2);
        }

        Destroy(this.gameObject);
    }
}
