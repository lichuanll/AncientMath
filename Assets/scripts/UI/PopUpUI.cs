using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpUI : MonoBehaviour
{
    private INeedPopUpWindow needPopUpWindow;
    [SerializeField] Animation _animation;
    [SerializeField] TextMeshProUGUI popUpText;
    [SerializeField] GameObject needWindowPopUp;
    private const float SHOW_UI_TIME = 2f;
    private void Start()
    {
        needPopUpWindow = needWindowPopUp.GetComponent<INeedPopUpWindow>();
        if(needPopUpWindow != null)
        {
            needPopUpWindow.OnPopUpWindow += NeedPopUpWindow_OnPopUpWindow;
        }
        else
        {
            Debug.LogError("该游戏物体没有实现INeedPopUpWindow接口");
        }
        Hide();
    }

    private void NeedPopUpWindow_OnPopUpWindow(object sender, INeedPopUpWindow.OnPopUpWindowEventArgs e)
    {
        popUpText.text = e.windowContent;
        Show();
        Invoke("Hide", SHOW_UI_TIME);
    }

    private void Show()
    {
        gameObject.SetActive(true);
        _animation.Play();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
