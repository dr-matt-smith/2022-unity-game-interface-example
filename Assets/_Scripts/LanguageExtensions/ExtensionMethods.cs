using UnityEngine;
using Tudublin;
using System;

namespace _Scripts.LanguageExtensions
{
    public static class ExtensionMethods
    {
        // add new method to Collider2D components
        // if found, return a component that implements the interface IDamageable
        // otherwise return NULL
        public static IDamageable FindDamageableComponent(this Collider2D collider)
        {
            MonoBehaviour[] list = collider.gameObject.GetComponents<MonoBehaviour>();
            foreach (Component component in list)
            {
                if (component is IDamageable)
                {
                    return (IDamageable) component;
                }
            }

            // if get here, not found in any component 
            return null;
        }
//        
//        // add new method to Collider2D components
//        // if found, return a component that implements the interface IDamageable
//        // otherwise return NULL
//        public static T FindComponent<T>(this Collider2D collider)
//        {
//            MonoBehaviour[] list = collider.gameObject.GetComponents<MonoBehaviour>();
//            foreach (Component component in list)
//            {
//                if (component is T)
//                {
//                    return component as <T>;
//                }
//            }
//
//            // if get here, not found in any component 
//            return null;
//        }

    }

}