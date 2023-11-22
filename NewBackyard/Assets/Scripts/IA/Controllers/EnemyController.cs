using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private BehaviourController _behaviourController;
    private Wander _wander;
    private Seek _seek;
    private AvoidCollision _avoidCollision;
    private PathFollowing _pathFollowing;
    public GameObject target;

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
        _behaviourController = GetComponent<BehaviourController>();
        _wander = GetComponent<Wander>();
        _seek = GetComponent<Seek>();
        _avoidCollision = GetComponent<AvoidCollision>();
        _pathFollowing = GetComponent<PathFollowing>();

    }

    private void Update()
    {
        switch (enemyState)
        {
            case State.Idle:
                _behaviourController.behaviours[0] = _wander;
                _wander.enabled = true;
                _pathFollowing.enabled = false;
                break;
            case State.Follow:
                _behaviourController.behaviours[0] = _seek;
                _pathFollowing.enabled = false;
                _wander.enabled = false;
                _seek.Target = target.transform.position;
                break;
            case State.Zone1:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes;
                _pathFollowing.enabled = true;
                _wander.enabled = false;
                break;
            case State.Zone2:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes2;
                _pathFollowing.enabled = true;
                _wander.enabled = false;
                break;
            case State.Zone4:
                _behaviourController.behaviours[0] = _pathFollowing;
                _pathFollowing.endList = _pathFollowing.nodes4;
                _pathFollowing.enabled = true;
                _wander.enabled = false;
                break;
                
        }

    }

}
