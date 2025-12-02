using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player target)
    {
        if (!IsEffectActive)
        {
            target.SetMoveSpeed(2);
        }

        Destroy(this.gameObject);
    }
}
