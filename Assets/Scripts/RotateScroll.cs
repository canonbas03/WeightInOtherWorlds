using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScroll : MonoBehaviour
{
    public float speed = 0.01f;
    public float friction = 0.95f;

    private float angularVelocity = 0f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);

            if (screenTouch.phase == TouchPhase.Moved)
            {
                angularVelocity = -screenTouch.deltaPosition.x * speed;
            }
        }
        transform.Rotate(0f, 0f, angularVelocity);
        angularVelocity *= friction;
    }
}
