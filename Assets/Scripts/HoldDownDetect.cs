using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class HoldDownDetect : MonoBehaviour
{
    [SerializeField] GameObject[] panelPrefabs;
    [SerializeField] GameObject parentCanvas;
    public PlanetDetection PlanetDetection;

    public GameObject currentPrefab;

    public float holdTime = 1f;
    float counter = 0f;
    bool isHeld = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            Collider2D hit = Physics2D.OverlapPoint(touchPos);

            if (hit != null && hit.gameObject == gameObject)
            {
                if (touch.phase == TouchPhase.Stationary)
                {
                    counter += Time.deltaTime;
                    if (counter > holdTime)
                    {
                        isHeld = true;

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
        if (PlanetDetection.planetIndex.TryGetValue(PlanetDetection.tagGiver(), out int index))
        {
            if (currentPrefab != null) // A check to prevent duplicates
            {
                Destroy(currentPrefab);
            }

            currentPrefab = Instantiate(panelPrefabs[index], parentCanvas.transform);
            Debug.Log($"Current Index: {index}, {PlanetDetection.tagGiver()}");
        }

        currentPrefab.SetActive(isHeld);
        Time.timeScale = 0f;
    }
}
