using UnityEngine;
using Tudublin;
using _Scripts.LanguageExtensions;

public class KillingObject : MonoBehaviour
{
    public int damageAmount = 100;
    
    private void OnTriggerEnter2D(Collider2D hit)
    {
        print("something hit Poison Bottle!");
        
        IDamageable damageableComponent = hit.FindDamageableComponent();
        if (damageableComponent != null)
        {
            damageableComponent.Damage(damageAmount);
        }
    }
    
}
