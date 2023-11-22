using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEditor.UI;

public class MoveInputs : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotSpeed;
    [SerializeField] Canvas selector;

    void Update()
    {
        var gamepad = Gamepad.current;
        Vector2 moveInput = gamepad.leftStick.ReadValue();
        Vector2 cameraRot = gamepad.rightStick.ReadValue();
        
        transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * cameraRot.x * rotSpeed * Time.deltaTime);

    }
}
