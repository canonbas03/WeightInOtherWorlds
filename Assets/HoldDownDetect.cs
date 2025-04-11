using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HoldDownDetect : MonoBehaviour
{
    public PlanetDetection PlanetDetection;

    public static GameObject panel;

    string currentPlanet = "";
    public static bool show = false;
    public bool active = false;

    public float holdTime = 1f;
    float counter = 0f;
    static bool isHeld = false;

    private void OnMouseExit()
    {
        counter = 0f;
        isHeld = false;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("is touched");
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            Debug.Log(touchPos);

            Collider2D hit = Physics2D.OverlapPoint(touchPos);

            if (hit != null && hit.gameObject == gameObject)
            {
                Debug.Log("is gameobject");
                if (touch.phase == TouchPhase.Stationary)
                {
                    counter += Time.deltaTime;
                    if (counter > holdTime)
                    {
                        isHeld = true;
                        Debug.Log("is held");
                        // ShowInfo(PlanetDetection.tagGiver());
                        ShowInfo();
                    }
                }
            }
        }
        else
        {
            counter = 0f;
            isHeld = false;
        }
    }

    public void ShowInfo()
    {
        string text = PlanetDetection.tagGiver();
        Debug.Log(text);
    }
    //public void ShowInfo(string planet)
    //{
    //    //if (isHeld == true)
    //        Debug.Log(planet + " number");
    //    panel.SetActive(isHeld);
    //}
}
