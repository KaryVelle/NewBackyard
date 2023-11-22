using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidCollision : Steering
{
    public float maxSeeAhead;
    public float obstacleRadius;
    public float maxAvoidanceForce;
    public bool showVectors;
    private GameObject[] positionList;
    private List<Vector3> _obstacleList = new List<Vector3>();
    private Vector3 _ahead, _ahead2;
    

    private void Start()
    {
        positionList = GameObject.FindGameObjectsWithTag("Obs");
        
        foreach (var obstacle in positionList)
        {
            Vector3 position = obstacle.transform.position;
            _obstacleList.Add(position);
        }
    }

    public override Vector3 GetForce()
    {
        _ahead = Position + (Velocity.normalized * maxSeeAhead); 
        _ahead2 = Position + (Velocity.normalized * maxSeeAhead * 0.5f);
        
        if (showVectors)
        {
            Debug.DrawLine(Position, _ahead ,Color.red);
        }
        
        Vector3? Biggest = FindBiggestThreat();

        if (Biggest == null)
        {
            return Vector3.zero;
        }
        Vector3 avoidance = _ahead - Biggest.Value;
        avoidance = avoidance.normalized;
        avoidance *= maxAvoidanceForce;
        return avoidance;
    }

    Vector3? FindBiggestThreat ()
    {
        Vector3? mostThreat = null;
        foreach (var obs in _obstacleList)
        {
            var distance = Vector3.Distance(obs, Position);
            bool collision = Collision(_ahead, _ahead2, obs);
           
            if (collision &&  (mostThreat == null || distance <= Vector3.Distance(Position,mostThreat.Value)))
            {
                mostThreat = obs;
            }
        }
        return mostThreat;
    }

    bool Collision(Vector3 ahead, Vector3 ahead2, Vector3 obstacle)
    {
        
        if (Vector3.Distance(ahead, obstacle) < obstacleRadius || Vector3.Distance(ahead2, obstacle) < obstacleRadius)
        {
            return true;
        }
        return false;
        
    }
}
