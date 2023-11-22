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
  public GameObject soil;
  public GameObject tower;
  public GameObject flag;
  public bool allyZoneConquered;

  public void GetMajorPopulation()
  {
    if (allyList.Count > numberToWin)
    {
      SpreadLooser();
      allyZoneConquered = true;
      ChangeColor();
    }
    if (enemyList.Count > numberToWin)
    {
      SpreadLooser();
      allyZoneConquered = false;
      ChangeColor();
      
    }
  }

  public void AddEnemy(GameObject enemy)
  {
    enemyList.Add(enemy);
  }

  public void AddAlly(GameObject ally)
  {
    allyList.Add(ally);
  }

  public void DeleteEnemy(GameObject enemy)
  {
    enemyList.Remove(enemy);
  }
  public void DeleteAlly(GameObject ally)
  {
    allyList.Remove(ally);
  }

  public void ChangeColor()
  {
    if (allyZoneConquered)
    {
      soil.GetComponent<Renderer>().material = allyMat;
      flag.GetComponent<Renderer>().material = allyMat;
      tower.GetComponent<Renderer>().material = allyMat;
    }
    else
    {
      soil.GetComponent<Renderer>().material = enemyMat;
      flag.GetComponent<Renderer>().material = enemyMat;
      tower.GetComponent<Renderer>().material = enemyMat;
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
