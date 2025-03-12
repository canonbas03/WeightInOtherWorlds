using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    private SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Detector")
        {
            sRenderer.color = Color.white;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
            sRenderer.color = new Color(0.4f, 0.4f, 0.4f, 1f);
        
    }
}
