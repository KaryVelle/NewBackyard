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
        canSend = true;
    }
    // Update is called once per frame
    void Update()
    {
        var gamepad = Gamepad.current;
        if (canSend && enemy.canSend)
        {
            if(gamepad.rightShoulder.IsPressed())
            {
                enemy.enemyState = EnemyController.State.ZoneCenter;
                canSend = false;
            }
            if (gamepad.dpad.right.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone1;
                canSend = false;
            }
            if (gamepad.dpad.left.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone2;
                canSend = false;
            }
            if (gamepad.dpad.up.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone3;
                canSend = false;
            }
            if (gamepad.dpad.down.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone4;
                canSend = false;
            }
        }
    }
}
