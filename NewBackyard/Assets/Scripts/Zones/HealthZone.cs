
using System;
using UnityEngine;

public class HealthZone : AbstracZone
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            AddEnemy( other.GetComponent<GameObject>());
            ChangeColor();
            Debug.Log("Enemy");
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            AddAlly(other.GetComponent<GameObject>());
            ChangeColor();
            Debug.Log("Ally");
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
            
            // los aliados ganaron, entonces su vida es x2
        }
        if (!allyZoneConquered)
        {
            // los enemigos ganaron, entonces su vida es x2
        }
    }
    
}