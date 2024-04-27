using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Button interactButton;     //������ť
    public GameObject dialogueUI;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);        //���ضԻ���
        interactButton.onClick.AddListener(onInteractButtonClicked);
    }

    void onInteractButtonClicked()
    {
        interactButton.gameObject.SetActive(false);
        dialogueUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
