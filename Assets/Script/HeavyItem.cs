using UnityEngine;

public class HeavyItem : PowerUpBase
{
    public override void ApplyEffect(Player target)
    {
        if (!IsEffectActive)
        {
            target.GetHeavyItem(20);
        }

        Destroy(this.gameObject);

    }
    
}
