using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlanetDetection : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textToModify;
    AudioSource AudioSource;
    AudioClip[] AudioClips;
    private SpriteRenderer sRenderer;
    private Transform mTransform;
    private GameObject currentPrefab;

    static string tagName = "Earth";  // First Planet on UI

    [SerializeField] GameObject[] widgetPrefabs;  // Array of GameObjects storing prefabs

    public Dictionary<string, int> planetIndex = new Dictionary<string, int>
        {
            {"Earth",    0},
            {"Mercury",  1},
            {"Venera",   2},
            {"Mars",     3},
            {"Jupiter",  4},
            {"Saturn",   5},
            {"Uran",     6},
            {"Neptune",  7}
        };
    void Start()
    {
        AudioSource = GameObject.FindGameObjectWithTag("Detector").GetComponent<AudioSource>();
        AudioClips = GameObject.FindGameObjectWithTag("Detector").GetComponent<MultipleAudio>().audioClips;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        tagName = collision.gameObject.tag;

        //HoldDownDetect.ShowInfo(collision.gameObject.tag);

        sRenderer = collision.GetComponent<SpriteRenderer>();
        mTransform = collision.GetComponent<Transform>();



        int earthWeight = StaticData.valueToKeep;
        PlayAudio();

        Dictionary<string, (float multiplier, string message)> planetData = new Dictionary<string, (float, string)>
        {
            { "Mercury",(0.38f,"On Mercury you weigh {0} kg. Light as a feather!")},
            { "Venera", (0.91f,"On Venus you weigh {0} kg. Heavy and hot!")},
            { "Earth",  (1f,   "On Earth you weigh {0} kg. Unbelievable, right?")},
            { "Mars",   (0.38f,"On Mars you weigh {0} kg. Time to bounce around!")},
            { "Jupiter",(2.34f,"On Jupiter you weigh {0} kg. Feeling super heavy!")},
            { "Saturn", (0.93f,"On Saturn you weigh {0} kg. Rings can't hold you down!")},
            { "Uran",   (0.92f,"On Uranus you weigh {0} kg. Ice cold and light!")},
            { "Neptune",(1.12f,"On Neptune you weigh {0} kg. Deep blue and dense!")}
        };

        if (planetData.TryGetValue(collision.gameObject.tag, out var data))
        {
            float planetWeight = earthWeight * data.multiplier;
            textToModify.text = string.Format(data.message, planetWeight);

            sRenderer.color = Color.white;
            mTransform.localScale *= 2;
        }

        if (planetIndex.TryGetValue(collision.gameObject.tag, out int index))
        {
            if (currentPrefab != null) // A check to prevent duplicates
            {
                Destroy(currentPrefab);
            }

            currentPrefab = Instantiate(widgetPrefabs[index]);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sRenderer = collision.GetComponent<SpriteRenderer>();
        mTransform = collision.GetComponent<Transform>();
        sRenderer.color = new Color(0.4f, 0.4f, 0.4f, 1f);
        mTransform.localScale /= 2;
    }

    void PlayAudio()
    {

        int selected = Random.Range(0, AudioClips.Length);
        AudioSource.PlayOneShot(AudioClips[selected]);
    }

    public string tagGiver()
    {
        return tagName;
    }
}
