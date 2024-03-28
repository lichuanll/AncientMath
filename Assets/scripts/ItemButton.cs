using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    private Button button;
    public string Intro;
    public string Name;
    public Sprite Image;
    [SerializeField] private Image ItemImage;

    [SerializeField] private TextMeshProUGUI ItemName;

    [SerializeField] private TextMeshProUGUI ItemIntro;
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
    }
}
