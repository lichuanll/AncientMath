using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class BagPlaneUI : MonoBehaviour,INeedPopUpWindow
{
    //public string Name;
    //public Sprite Ico;

    [SerializeField] private ItemListSO itemListSO;
    private List<Item> CurItem;
    //public Sprite Plane;
    private int MaxCount = 30;
    private const string WINDOW_TEXT = "已纳入知识锦囊";

    public event EventHandler<INeedPopUpWindow.OnPopUpWindowEventArgs> OnPopUpWindow;

    private void Start()
    {
        Player.Instance.OnAddedBagObject += Player_OnAddedBagObject;
        Hide();
    }

    private void Player_OnAddedBagObject(object sender, EventArgs e)
    {
        AddItem(Player.Instance.GetbagObjectSO());
    }

    public void AddItem(Item item)
    {
        if (CurItem.Count < MaxCount)
        {
            CurItem.Add(item);

            string windowText = item.Name + WINDOW_TEXT;
            OnPopUpWindow?.Invoke(this, new INeedPopUpWindow.OnPopUpWindowEventArgs
            {
                windowContent = windowText
            });
        }
    }

    public void ShowBag()
    {
        gameObject.SetActive(true);
        GameObject ItemUI;
       
        for (int i = 0; i < CurItem.Count; i++)
        {
            ItemUI = this.transform.GetChild(i).gameObject;
            ItemUI.SetActive(true);
            AddItemData(ItemUI, CurItem[i]);
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
