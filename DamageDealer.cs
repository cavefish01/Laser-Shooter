using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [Header("Damage")]
    [SerializeField] int damage = 100;

 //   [Header("Visual Effects")]
 //   [SerializeField] GameObject deathVFX;
 //   [SerializeField] float durationOfExplosion = 1f;

    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
  //      GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
  //      Destroy(explosion, durationOfExplosion);
    }
}
