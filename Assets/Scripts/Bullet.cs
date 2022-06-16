using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
 void Awake() 
 {
  Destroy(gameObject, 3f);
 }

 void OnCollisionEnter(Collision other) 
 {
   Destroy(gameObject); 
 }
}
