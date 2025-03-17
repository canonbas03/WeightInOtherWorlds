using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetValue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;

    public void Start()
    {
        int newText = StaticData.valueToKeep;
        myText.text = $"On Earth you weight {newText} kg. Unbelievable, right?";
    }
}
