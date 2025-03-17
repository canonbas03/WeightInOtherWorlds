using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textToModify;
    private SpriteRenderer sRenderer;
    private Transform mTransform;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        mTransform = GetComponent<Transform>();
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string newText = StaticData.valueToKeep;
        if (collision.gameObject.tag == "Detector")
        {
            sRenderer.color = Color.white;
            mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z)*2;
           

            if(gameObject.tag == "Earth")
            {
                textToModify.text = $"On Earth you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Mercury")
            {
                textToModify.text = $"On Mercury you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Venera")
            {
                textToModify.text = $"On Venera you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Mars")
            {
                textToModify.text = $"On Mars you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Jupiter")
            {
                textToModify.text = $"On Jupiter you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Saturn")
            {
                textToModify.text = $"On Saturn you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Uran")
            {
                textToModify.text = $"On Uranus you weight {newText} kg. Unbelievable, right? 000";
            }
            if (gameObject.tag == "Neptune")
            {
                textToModify.text = $"On Neptune you weight {newText} kg. Unbelievable, right? 000";
            }
           
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        sRenderer.color = new Color(0.4f, 0.4f, 0.4f, 1f);
        mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z) / 2;
    }
}
