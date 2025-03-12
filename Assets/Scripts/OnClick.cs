using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class OnClick : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 startPos;
    private Vector2 EndPos;
    bool movingRight = true;
    Vector2 target;
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
       // EndPos = startPos;
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            EndPos = new Vector2(0.28f, startPos.y);
            //movingRight = !movingRight;
            //target = movingRight ? EndPos : startPos;
        }
       
        transform.position = Vector2.MoveTowards(transform.position, EndPos, speed * Time.deltaTime);


    }
}
