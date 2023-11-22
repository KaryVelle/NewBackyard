using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private BehaviourController _behaviourController;
    private Wander _wander;
    private Seek _seek;
    public GameObject target;

    public enum State
    {
        Idle,
        Follow
    }
    public State enemyState;

    private void Start()
    {
        _behaviourController = GetComponent<BehaviourController>();
        _wander = GetComponent<Wander>();
        _seek = GetComponent<Seek>();
    }

    private void Update()
    {
        switch (enemyState)
        {
            case State.Idle:
                _behaviourController.behaviours[0] = _wander;
                _wander.enabled = true;
                break;
            case State.Follow:
                _behaviourController.behaviours[0] = _seek;
                _wander.enabled = false;
                _seek.Target = target.transform.position;
                break;
        }

    }

}
