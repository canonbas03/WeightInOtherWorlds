using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // When a planet enters the cube, check the tag and according to it show a corresponding widget

    [SerializeField]GameObject Detector;
    [SerializeField]GameObject CowPrefab;
    [SerializeField] GameObject SSignPrefab;
    bool isPut = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void detectorPlanet(GameObject planet)
    {
        string planetTag = planet.tag;

        if (planetTag == "Earth")
        {
            Debug.Log("The planet is EARTH");
        }
        else if (planetTag == "Mars")
        {
            Debug.Log("The planet is MARS");
        }
    }
}

