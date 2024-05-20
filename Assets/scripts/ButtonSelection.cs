using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int judge;
    public int Correct;
    [SerializeField] private GameObject Wrong;
    public void ClickEvent()
    {
        if (judge == Correct)
        {
            TextMeshProUGUI TextIntro = this.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        }
        else
        {
            Wrong.SetActive(true);
        }

    }
}
