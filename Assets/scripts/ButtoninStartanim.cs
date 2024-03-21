using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtoninStartanim : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
  
    void Start()
    {
        //禁用按钮UI，确保开始看不见
        button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowButton()
    {
        button.gameObject.SetActive(true);
    }
}
