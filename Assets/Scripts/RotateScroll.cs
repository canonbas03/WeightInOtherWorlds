using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScroll : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
            Debug.Log("Touched!");

            Touch screenTouch = Input.GetTouch(0);

            if(screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, 0f, -screenTouch.deltaPosition.x*speed);
            }
        }
    }
}
