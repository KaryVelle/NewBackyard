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

      void Start()
      {
         StartCoroutine(WinZoneUnlocked());
      }

      IEnumerator WinZoneUnlocked()
      {
         yield return new WaitForSeconds(Random.Range(time1, time2));

         Vector3 targetPosition = new Vector3(-36.1f, -7.1f, -80.3f);
         float duration = 2.0f; 

         float elapsedTime = 0f;
         Vector3 initialPosition = winPlatform.transform.position;

         while (elapsedTime < duration)
         {
            winPlatform.transform.position = Vector3.Lerp(initialPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
         }
         
         winPlatform.transform.position = targetPosition;

      }
      
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
