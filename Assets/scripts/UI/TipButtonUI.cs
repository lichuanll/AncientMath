using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipButtonUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI introText;
    [TextArea]
    [SerializeField] string intro;

    public void SetIntroText()
    {
        introText.text = intro; 
    }
}
