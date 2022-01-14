using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    public FloatingJoystick joystick;
    private Rigidbody2D rb;
    public float playerSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
