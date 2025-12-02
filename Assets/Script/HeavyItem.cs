using UnityEngine;

public class HeavyItem : PowerUpBase //inhheritance from PowerUpBase
{
    public override void ApplyEffect(Player target) //override abstract method
    {
        if (!IsEffectActive)
        {
            target.GetHeavyItem(5);
        }

        Destroy(this.gameObject);

    }
    
}
