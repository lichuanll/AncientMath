using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonUI : MonoBehaviour
{
    private Button button;
    [HideInInspector] public string Intro;
    [HideInInspector] public string Name;
    [HideInInspector] public Sprite Image;
    [SerializeField] private Image ItemImage;

    [SerializeField] private TextMeshProUGUI ItemName;

    [SerializeField] private TextMeshProUGUI ItemIntro;

    [SerializeField] private Scrollbar scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowIntro);
    }

    // Update is called once per frame
    void ShowIntro()
    {
        ItemImage.sprite = Image;
        ItemName.text = Name;
        ItemIntro.text = Intro;
        scrollbar.value = 1.0f;
    }
}
