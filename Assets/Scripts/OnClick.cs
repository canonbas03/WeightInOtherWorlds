using UnityEngine;

public class OnClick : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 startPos;
    private Vector2 endPos;
    private Vector2 target;
    bool isMoving = false;
    AudioSource AudioSource;
    bool isMOO = true;
    void Start()
    {
        startPos = transform.position;
        endPos = new Vector2(0.28f, startPos.y);
        target = startPos;
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (Time.timeScale == 0) return;
        target = (target == startPos) ? endPos : startPos;
        isMoving = true;
        Debug.Log("Clicked!");

        if (isMOO)
        {
            AudioSource.Play();
           
        }
        isMOO = !isMOO;
    }
    void Update()
    {
        if (Time.timeScale == 0) return;
        if (isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }

    }
}
