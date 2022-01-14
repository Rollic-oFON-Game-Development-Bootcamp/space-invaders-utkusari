using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapPlayerMovement : MonoBehaviour
{
    public float leftConstraint;
    public float rightConstraint;
    private float bufferSize;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        bufferSize = player.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        WrapMovement();
    }

    public void WrapMovement()
    {
        if (player.transform.position.x < leftConstraint - bufferSize)
        {
            player.transform.position = new Vector3(rightConstraint - bufferSize, player.transform.position.y, 0.0f);
        }
        if (player.transform.position.x > rightConstraint + bufferSize)
        {
            player.transform.position = new Vector3(leftConstraint + bufferSize, player.transform.position.y, 0.0f);
        }
    }

}
