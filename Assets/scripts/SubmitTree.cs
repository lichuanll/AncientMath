using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SubmitTree : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ItemListSO itemListSo;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            foreach (var i in itemListSo.itemList)
            {
                print(i.Intro);
            }
        }
    }
}
