using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textToModify;
    AudioSource AudioSource;
    AudioClip[] AudioClips;
    private SpriteRenderer sRenderer;
    private Transform mTransform;


    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        mTransform = GetComponent<Transform>();

        AudioSource = GameObject.FindGameObjectWithTag("Detector").GetComponent<AudioSource>();
        AudioClips = GameObject.FindGameObjectWithTag("Detector").GetComponent<MultipleAudio>().audioClips;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int earthWeight = StaticData.valueToKeep;
        if (collision.gameObject.tag == "Detector")
        {
            PlayAudio();

            sRenderer.color = Color.white;
            mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z) * 2;


            if (gameObject.tag == "Earth")
            {
                textToModify.text = $"On Earth you weight {earthWeight} kg. Unbelievable, right?";
            }
            if (gameObject.tag == "Mercury")
            {
                float mercuryWeight = earthWeight * 0.38f;
                textToModify.text = $"On Mercury you weigh {mercuryWeight} kg. Light as a feather!";
            }
            if (gameObject.tag == "Venera")
            {
                float veneraWeight = earthWeight * 0.91f;
                textToModify.text = $"On Venus you weigh {veneraWeight} kg. Heavy and hot!";
            }
            if (gameObject.tag == "Mars")
            {
                float marsWeight = earthWeight * 0.38f;
                textToModify.text = $"On Mars you weigh {marsWeight} kg. Time to bounce around!";
            }
            if (gameObject.tag == "Jupiter")
            {
                float jupiterWeight = earthWeight * 2.34f;
                textToModify.text = $"On Jupiter you weigh {jupiterWeight} kg. Feeling super heavy!";
            }
            if (gameObject.tag == "Saturn")
            {
                float saturnWeight = earthWeight * 0.93f;
                textToModify.text = $"On Saturn you weigh {saturnWeight} kg. Rings can't hold you down!";
            }
            if (gameObject.tag == "Uran")
            {
                float uranWeight = earthWeight * 0.92f;
                textToModify.text = $"On Uranus you weigh {uranWeight} kg. Ice cold and light!";
            }
            if (gameObject.tag == "Neptune")
            {
                float neptuneWeight = earthWeight * 1.12f;
                textToModify.text = $"On Neptune you weigh {neptuneWeight} kg. Deep blue and dense!";
            }

           

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        sRenderer.color = new Color(0.4f, 0.4f, 0.4f, 1f);
        mTransform.localScale = new Vector3(mTransform.localScale.x, mTransform.localScale.y, mTransform.localScale.z) / 2;
    }

    void PlayAudio()
    {
      
        int selected = Random.Range(0, AudioClips.Length);
        AudioSource.PlayOneShot(AudioClips[selected]);
    }

}
