using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    private Button button;
    private Text Intro;
    private Bag bagIntro;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowIntro);
    }

    // Update is called once per frame
    void ShowIntro()
    {
        print("Show");
        bagIntro = GetComponentInParent<Bag>();
        Intro.text = "父物体上的物品介绍";
    }
}
