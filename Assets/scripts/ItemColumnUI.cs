using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColumnUI : MonoBehaviour
{
    [SerializeField]  GameObject ItemUI;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    public void ShowItemUI()
    {
        print("asdj");
        ItemUI.SetActive(true);
    }
}
