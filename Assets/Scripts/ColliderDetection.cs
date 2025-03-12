using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    private Transform mTransform;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        mTransform = GetComponent<Transform>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Detector")
        {
            sRenderer.color = Color.white;
            mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z)*2;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        sRenderer.color = new Color(0.4f, 0.4f, 0.4f, 1f);
        mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z) / 2;
    }
}
