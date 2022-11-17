using UnityEngine;
using Tudublin;
using _Scripts.LanguageExtensions;

public class DangerousObject : MonoBehaviour
{
    public int damageAmount = 10;
    
    private void OnTriggerEnter2D(Collider2D hit)
    {
        print("something hit bad star");

        IDamageable damageableComponent = hit.FindDamageableComponent();
        if (damageableComponent != null)
        {
            damageableComponent.Damage(damageAmount);
        }
    }
    
    

}
