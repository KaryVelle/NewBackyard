using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstracZone : MonoBehaviour
{
  public Collider validationCollider;
  public List<GameObject> enemyList;
  public List<GameObject> allyList;
  public float timeRemaining;
  public Vector3 position;
  public Material enemyMat;
  public Material allyMat;
  public GameObject soil;
  public GameObject tower;
  public GameObject flag;

  public void getMajorPopulation()
  {
  }

  public void addEnemy(GameObject enemy)
  {
    enemyList.Add(enemy);
  }

  public void addAlly(GameObject ally)
  {
    allyList.Add(ally);
  }

  public void deleteEnemy(GameObject enemy)
  {
  }

  public void spreadLooser()
  {
  }

  public abstract Vector3 ActivateAbitity();
  
  
}
