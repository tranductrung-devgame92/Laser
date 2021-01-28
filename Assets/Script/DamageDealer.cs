using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    //
    [SerializeField] int damage = 100;
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int GetDamage()
    {
        return damage;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Hit()
    {
        Destroy(gameObject);
    }
}
   

