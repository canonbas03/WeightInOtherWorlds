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
        int dataToKeep;
        int.TryParse(myText.text, out dataToKeep);
        Debug.Log(dataToKeep);
        StaticData.valueToKeep = dataToKeep;

    }
}
