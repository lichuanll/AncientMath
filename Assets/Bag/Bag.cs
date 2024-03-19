using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Bag",menuName = "Bag/Bag")]
public class Bag : MonoBehaviour
{
    public string Name;
    public Sprite Ico;
    public List<Item> Items;
    public List<string> ItemsIntro;
    public Sprite Plane;
    public int RowCount;
    
    public int ColCount;
    public void AddItem()
    {
    }

    public void ShowBag()
    {
        GameObject ItemUI;
        for (int i = 0; i < Items.Count; i++)
        {
            ItemUI = this.transform.GetChild(i).gameObject;
            Image ico = ItemUI.GetComponent<Image>();
            ico.sprite = Items[i].Ico;
            ItemsIntro[i] = Items[i].Intro;
        }
    }
}
