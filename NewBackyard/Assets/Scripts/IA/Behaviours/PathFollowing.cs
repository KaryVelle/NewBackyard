using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : Steering
{
    public EnemyController enemyController;
    public List<Vector3> nodes;
    public List<Vector3> nodes2;
    public List<Vector3> endList;
    public float pathRadius;
    public bool looping;
    private int _currentNode;
    private int _pathDirection = 1;

    public void Start()
    {
        enemyController = GetComponent<EnemyController>();
    }
    public override Vector3 GetForce()
    {
        if (Input.GetKeyDown("space")){
            enemyController.enemyState = EnemyController.State.Zone1;
        }
        Follow(endList);
        return Seek(endList);

    }

    public void Follow(List<Vector3> nodeList)
    {
        var actualPoint = nodeList[_currentNode];

        if (Vector3.Distance(actualPoint, transform.position) <= pathRadius)
        {
            _currentNode += _pathDirection;

            if (looping && (_currentNode >= nodeList.Count || _currentNode < 0))
            {
                _pathDirection *= -1;
                _currentNode += _pathDirection;
            }

            if (_currentNode >= nodeList.Count)
            {
                _currentNode = nodeList.Count - 1;
            }
        }
    }

    Vector3 Seek(List<Vector3> nodeList)
    {
        Target = nodeList[_currentNode];
        DesiredVelocity = (Target - Position).normalized * speed;
        Vector3 steering = DesiredVelocity - Velocity;
        return steering;
    }
}
