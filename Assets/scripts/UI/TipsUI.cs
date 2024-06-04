using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TipsUI : MonoBehaviour,INeedPopUpWindow
{
    private const string WINDOW_TEXT = "已放入通关妙计";
    [SerializeField] GameObject ParentUI;
    [SerializeField] TextMeshProUGUI introText;
    [SerializeField] Button tipsButton;
    [SerializeField] List<Button> UnlockButtonList;
    [SerializeField] List<TextMeshProUGUI> UnlockTextList;
    [SerializeField] List<string> UnlockName;
    public event EventHandler<INeedPopUpWindow.OnPopUpWindowEventArgs> OnPopUpWindow;

    private void Start()
    {
        Player.Instance.OnUnlockTip += Player_OnUnlockTip;
        tipsButton.onClick.AddListener(() =>
        {
            introText.text = "";
            Show();
        });
        Hide();
    }

    private void Player_OnUnlockTip(object sender, Player.OnUnlockTipEventArgs e)
    {
        int UnlockIndex = e.tipIndex;
        UnlockButtonList[UnlockIndex].interactable = true;
        UnlockTextList[UnlockIndex].text = UnlockName[UnlockIndex];
        string windowText = UnlockName[UnlockIndex] + WINDOW_TEXT;

        OnPopUpWindow?.Invoke(this, new INeedPopUpWindow.OnPopUpWindowEventArgs
        {
            windowContent = windowText
        });
    }

    private void Hide()
    {
        ParentUI.SetActive(false);
    }
    private void Show()
    {
        ParentUI.SetActive(true);
    }
}
