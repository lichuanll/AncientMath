using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Bag : MonoBehaviour
{
    public string Name;
    public Sprite Ico;
    public List<Item> Items;
    public Sprite Plane;
    public int RowCount;
    public int ColCount;
    private int MaxCount=30;
    public void AddItem(Item item)
    {
        if (Items.Count < MaxCount)
        {
            Items.Add(item);
        }
    }

    public void ShowBag()
    {
        gameObject.SetActive(true);
        GameObject ItemUI;
       
        for (int i = 0; i < Items.Count; i++)
        {
            ItemUI = this.transform.GetChild(i).gameObject;
            ItemUI.SetActive(true);
            Image ico = ItemUI.GetComponent<Image>();
            ico.sprite = Items[i].Ico;
            ItemButton itemButton = ItemUI.GetComponent<ItemButton>();
            itemButton.Intro = Items[i].Intro;
            itemButton.Name = Items[i].Name;
            itemButton.Image = Items[i].Image;
        }
       // print(Items.Count);
    }
}
