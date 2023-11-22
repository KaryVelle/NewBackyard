using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : AbstracZone
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aa");
        if (other.gameObject.CompareTag("Enemy"))
        {
            addEnemy( other.GetComponent<GameObject>());
            Debug.Log("enemy");
            soil.GetComponent<Renderer>().material = enemyMat;
            flag.GetComponent<Renderer>().material = enemyMat;
            tower.GetComponent<Renderer>().material = enemyMat;
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            addAlly(other.GetComponent<GameObject>());
            Debug.Log("ally");
            soil.GetComponent<Renderer>().material = allyMat;
            flag.GetComponent<Renderer>().material = allyMat;
            tower.GetComponent<Renderer>().material = allyMat;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
       
    }


    public override Vector3 ActivateAbitity()
    {
        throw new System.NotImplementedException();
        
    }
}