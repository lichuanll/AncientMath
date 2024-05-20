using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class BagPlaneUI : MonoBehaviour
{
    public string Name;
    public Sprite Ico;
    [SerializeField] private ItemListSO itemListSO;
    public Sprite Plane;
    private int MaxCount=30;

    private void Start()
    {
        Hide();
    }
    public void AddItem(Item item)
    {
        if (itemListSO.itemList.Count < MaxCount)
        {
            itemListSO.itemList.Add(item);
        }
    }

    public void ShowBag()
    {
        gameObject.SetActive(true);
        GameObject ItemUI;
       
        for (int i = 0; i < itemListSO.itemList.Count; i++)
        {
            ItemUI = this.transform.GetChild(i).gameObject;
            ItemUI.SetActive(true);
            AddItemData(ItemUI, itemListSO.itemList[i]);
            //Image ico = ItemUI.GetComponent<Image>();
            //ico.sprite = Items[i].Ico;
            //ItemButton itemButton = ItemUI.GetComponent<ItemButton>();
            //itemButton.Intro = Items[i].Intro;
            //itemButton.Name = Items[i].Name;
            //itemButton.Image = Items[i].Image;
        }
       // print(Items.Count);
    }

    private void AddItemData(GameObject ItemUI,Item item)
    {
        Image ico = ItemUI.GetComponent<Image>();
        ico.sprite = item.Ico;
        ItemButtonUI itemButton = ItemUI.GetComponent<ItemButtonUI>();
        itemButton.Intro = item.Intro;
        itemButton.Name = item.Name;
        itemButton.Image = item.Image;
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
