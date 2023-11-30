using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    
    private BehaviourController _behaviourController;
    private WanderEnemy _wanderEnemy;
    private Seek _seek;
    private AvoidCollision _avoidCollision;
    private PathFollowingEnemy _pathFollowing;
    public GameObject target;

    public bool canSend;

    public enum State
    {
        Idle,
        Follow,
        Zone1,
        Zone2,
        Zone3,
        Zone4,
        ZoneCenter,
    }
    public State enemyState;

    private void Start()
    {
        target = GameObject.Find("Capsule");
        _behaviourController = GetComponent<BehaviourController>();
        _wanderEnemy = GetComponent<WanderEnemy>();
        _seek = GetComponent<Seek>();
        _avoidCollision = GetComponent<AvoidCollision>();
        _pathFollowing = GetComponent<PathFollowingEnemy>();
        canSend = false;
    }

    private void Update()
    {
        switch (enemyState)
        {
            case State.Idle:
                _behaviourController.behaviours[0] = _wanderEnemy;
                _wanderEnemy.enabled = true;
                _pathFollowing.enabled = false;
                break;
            case State.Follow:
                _behaviourController.behaviours[0] = _seek;
                _pathFollowing.enabled = false;
                _wanderEnemy.enabled = false;
                _seek.Target = target.transform.position;
                canSend = true;
                break;
            case State.Zone1:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes;
                _pathFollowing.enabled = true;
                _wanderEnemy.enabled = false;
                break;
            case State.Zone2:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes2;
                _pathFollowing.enabled = true;
                _wanderEnemy.enabled = false;
                break;
            case State.Zone3:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes3;
                _pathFollowing.enabled = true;
                _wanderEnemy.enabled = false;
                break;
            case State.Zone4:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes4;
                _pathFollowing.enabled = true;
                _wanderEnemy.enabled = false;
                break;
            case State.ZoneCenter:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodescenter;
                _pathFollowing.enabled = true;
                _wanderEnemy.enabled = false;
                break;
                
        }

    }
}
