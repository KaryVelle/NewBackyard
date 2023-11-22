using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstracZone : MonoBehaviour
{
  public List<GameObject> enemyList;
  public List<GameObject> allyList;
  public float timeRemaining;
  public int numberToWin;
  public Material enemyMat;
  public Material allyMat;
  public Material normalMat;
  public GameObject soil;
  public GameObject tower;
  public GameObject flag;
  public bool allyZoneConquered;
  public bool zoneEmpty;

  public void GetMajorPopulation()
  {
    if (allyList.Count >= numberToWin)
    {
      SpreadLooser();
      allyZoneConquered = true;
      ChangeColor();
    }
    if (enemyList.Count >= numberToWin)
    {
      SpreadLooser();
      allyZoneConquered = false;
      ChangeColor();
      
    }
  }

  public void AddEnemy(GameObject enemy)
  {
    enemyList.Add(enemy);
    GetMajorPopulation();
  }

  public void AddAlly(GameObject ally)
  {
    allyList.Add(ally);
    GetMajorPopulation();
  }

  public void DeleteEnemy(GameObject enemy)
  {
    enemyList.Remove(enemy);
    GetMajorPopulation();
  }
  public void DeleteAlly(GameObject ally)
  {
    allyList.Remove(ally);
    GetMajorPopulation();
  }

  public void ChangeColor()
  {
   
    if ((allyZoneConquered)&&(!zoneEmpty))
    {
      soil.GetComponent<Renderer>().material = allyMat;
      flag.GetComponent<Renderer>().material = allyMat;
      tower.GetComponent<Renderer>().material = allyMat;
    }
    if ((!allyZoneConquered)&&(!zoneEmpty) )
    {
      soil.GetComponent<Renderer>().material = enemyMat;
      flag.GetComponent<Renderer>().material = enemyMat;
      tower.GetComponent<Renderer>().material = enemyMat;
    }

    if (zoneEmpty)
    {
      soil.GetComponent<Renderer>().material = normalMat;
      flag.GetComponent<Renderer>().material = normalMat;
      tower.GetComponent<Renderer>().material = normalMat;
      
    }
  }

  public void SpreadLooser()
  {
    if (allyZoneConquered)
    {
      // enemigos huyen 
    }
    else
    {
      //aliados huyen
    }
  }
}
