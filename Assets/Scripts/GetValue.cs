using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GetValue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;
    public void KeepValue()
    {
        string dataToKeep = myText.text;
        Debug.Log(dataToKeep);
        StaticData.valueToKeep = dataToKeep;

    }
}
