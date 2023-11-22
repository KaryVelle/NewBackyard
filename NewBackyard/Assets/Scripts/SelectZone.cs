using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class SelectZone : MonoBehaviour
{
    [SerializeField] bool canSend = true;
    private EnemyController enemy;
    private void Start()
    {
        enemy = GetComponent<EnemyController>();
    }
    // Update is called once per frame
    void Update()
    {
        var gamepad = Gamepad.current;
        if (canSend)
        {
            if(gamepad.rightShoulder.IsPressed())
            {
                Debug.Log("center");
                enemy.enemyState = EnemyController.State.ZoneCenter;
            }
            canSend = false;
        }
    }
}
