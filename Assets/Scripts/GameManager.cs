using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 public Health Player;
 public GameObject win;
 public int Kills;

 private void Start() 
 {
   win.SetActive(false); 
 }

 void Update() 
 {
   if(Player.health <= 0 || Input.GetKeyDown("r")) 
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
 }

 public void KillCount()
 {
  Kills += 1;
  if(Kills == 5)
  {
    win.SetActive(true);
  }
 }
}
