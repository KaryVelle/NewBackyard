using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : AbstracZone
{
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
      if (allyZoneConquered)
      {
         // los aliados ganaron, entonces ganas
      }
      if (!allyZoneConquered)
      {
         // los enemigos ganaron, entonces pierdes
      }
   }
   
}
