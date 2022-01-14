using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public FloatingJoystick joystick;
    public float playerSpeed = 1.0f;

    void FixedUpdate()
    {
        HandleJoystickInput();
    }

    private void HandleJoystickInput()
    {
        var direction = Vector2.right * joystick.Horizontal;
        transform.position += new Vector3((direction * playerSpeed * Time.fixedDeltaTime).x, 0.0f, 0.0f);
    }
}
