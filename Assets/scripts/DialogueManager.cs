using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Button interactButton;     //交互按钮
    public GameObject dialogueUI;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);        //隐藏对话框
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
