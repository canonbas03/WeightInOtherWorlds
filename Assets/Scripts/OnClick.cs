using UnityEngine;

public class OnClick : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 startPos;
    private Vector2 endPos;
    private Vector2 target;
    bool isMoving = false;

    void Start()
    {
        startPos = transform.position;
        endPos = new Vector2(0.28f, startPos.y);
        target = startPos;

    }

    private void OnMouseDown()
    {
        target = (target == startPos) ? endPos : startPos;
        isMoving = true;
        Debug.Log("Clicked!");
    }
    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }

    }
}
