using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedZone : AbstracZone
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
            DeleteEnemy(other.GetComponent<GameObject>());
            ChangeColor();
            
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            DeleteAlly(other.GetComponent<GameObject>());
            ChangeColor();
           
        }
    }
    public void ActivateAbitity()
    {
        if (allyZoneConquered)
        {
            clone.speed = 10;
        }
        if (!allyZoneConquered)
        {
            cloneEnemy.speed = 10;

        }
    }
}
