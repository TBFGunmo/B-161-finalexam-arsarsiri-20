using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player target)
    {
        if (!IsEffectActive) 
        {
            target.SetInvulnerability(true);
        }

        Destroy(this.gameObject);
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
