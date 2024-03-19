using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    private Button button;
    public string Intro;

    private GameObject ItemIntro;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowIntro);
        ItemIntro = this.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void ShowIntro()
    {
        ItemIntro.SetActive(true);
        print("Show");
        print(Intro);
    }
}
