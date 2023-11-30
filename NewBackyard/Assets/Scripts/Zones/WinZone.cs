using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class WinZone : AbstracZone
{
   public float time1;
   public float time2;
   public GameObject winPlatform;
   public ZoneController zoneController;
   public GameObject CanvaWin;


   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Enemy"))
      {
         AddEnemy(other.GetComponent<GameObject>());
         ChangeColor();
        
      }
      if (other.gameObject.CompareTag("Ally"))
      {
         AddAlly(other.GetComponent<GameObject>());
         ChangeColor();
      }
      ActivateAbitity();
   }
    
   private void OnTriggerExit(Collider other)
   {
      if (other.gameObject.CompareTag("Enemy"))
      {
         DeleteEnemy( other.GetComponent<GameObject>());
         ChangeColor();
         
      }
      if (other.gameObject.CompareTag("Ally"))
      {
         DeleteAlly( other.GetComponent<GameObject>());
         ChangeColor();
        
      }
   }
   public void ActivateAbitity()
   {
      if ((zoneController.zoneList.Count > 3) && (allyZoneConquered))
      {
         CanvaWin.SetActive(true);
         Time.timeScale = 0;
      }
      if ((zoneController.zoneListEnem.Count > 3) && (!allyZoneConquered))
      {

         Debug.Log("lose");
      }
     
   }

 
   
}
