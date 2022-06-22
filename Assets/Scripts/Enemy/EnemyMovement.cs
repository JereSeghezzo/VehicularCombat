using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
 public UnityEngine.AI.NavMeshAgent navMesh;
 public GameObject player;
 public int damage;
 public float chaseCD;
 float chase;
 public int health;
 public GameManager Manager;

private void Start() 
{
  player = GameObject.FindGameObjectWithTag("Player"); 
  Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>(); 
}

 void Update() 
 {
    navMesh.destination = player.transform.position;
    if(chase < chaseCD)
    {
        chase += Time.deltaTime;
        if(chase >= chaseCD)
        {
          navMesh.speed = 10f;  
        }
    }

    if(health <= 0)
    {
     Manager.KillCount();
     Destroy(gameObject);
    }
 }

 private void OnCollisionEnter(Collision other) 
 {
    if(other.gameObject.CompareTag("Player"))
    {
     player.GetComponent<Health>().TakeDamage(damage);
     navMesh.speed = 0f;
     chase = 0f;
    }
 }

 public void TakeDamage(int damage)
 {
    health -= damage;
 }
}
