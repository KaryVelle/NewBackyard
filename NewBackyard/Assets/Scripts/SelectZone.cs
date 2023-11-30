using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class SelectZone : MonoBehaviour
{
    [SerializeField] SpriteRenderer imageToModifi;
    [SerializeField] Sprite[] images;
    [SerializeField] bool canSend = true;
    private EnemyController enemy;
    private Clone clone;
    private void Start()
    {
        enemy = GetComponent<EnemyController>();
        canSend = true;
        clone = FindObjectOfType<Clone>();
        StartCoroutine(LifeTime(clone.lifetime));
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
                imageToModifi.sprite = images[4];
            }
            if (gamepad.dpad.right.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone1;
                canSend = false;
                imageToModifi.sprite = images[0];
            }
            if (gamepad.dpad.left.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone2;
                canSend = false;
                imageToModifi.sprite = images[2];
            }
            if (gamepad.dpad.up.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone3;
                canSend = false;
                imageToModifi.sprite = images[3];
            }
            if (gamepad.dpad.down.IsPressed())
            {
                enemy.enemyState = EnemyController.State.Zone4;
                canSend = false;
                imageToModifi.sprite = images[1];
            }
        }
    }

    IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
