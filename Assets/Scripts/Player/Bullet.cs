using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
 void Awake() 
 {
  Destroy(gameObject, 3f);
 }

 void OnCollisionEnter(Collision col)
    {
    if(col.gameObject.CompareTag("enemy"))
     {
     col.gameObject.GetComponent<EnemyMovement>().TakeDamage(25);
     Destroy(gameObject);
     }
    }
}
