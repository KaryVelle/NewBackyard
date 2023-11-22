
using System;
using UnityEngine;

public class HealthZone : AbstracZone
{
    public Clone clone;
    public CloneEnemy cloneEnemy;

    private void Start()
    {
        clone = FindObjectOfType<Clone>();
    }
    public void Update()
    {
        if ((allyList.Count == 0)||(enemyList.Count == 0))
        {
            zoneEmpty = true;
        }
        if ((allyList.Count != 0)||(enemyList.Count != 0))
        {
            zoneEmpty = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            AddEnemy( other.GetComponent<GameObject>());
            ChangeColor();
            Debug.Log("Enemy");
            ActivateAbitity();
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            AddAlly(other.GetComponent<GameObject>());
            ChangeColor();
            Debug.Log("Ally");
            ActivateAbitity();
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
            clone.lifetime = 120;
        }
        if (!allyZoneConquered)
        {
            cloneEnemy.lifetime = 120;
           
        }
    }
    
}