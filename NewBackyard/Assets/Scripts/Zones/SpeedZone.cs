using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedZone : AbstracZone
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            AddEnemy( other.GetComponent<GameObject>());
            
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            AddAlly(other.GetComponent<GameObject>());
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            DeleteEnemy( other.GetComponent<GameObject>());
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            DeleteAlly( other.GetComponent<GameObject>());
        }
    }
    public void ActivateAbitity()
    {
        if (allyZoneConquered)
        {
            // los aliados ganaron, entonces su velocidad es x2
        }
        if (!allyZoneConquered)
        {
            // los enemigos ganaron, entonces su velocidad es x2
        }
    }
}
