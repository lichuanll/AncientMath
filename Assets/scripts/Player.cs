using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    public event EventHandler OnAddedBagObject;
    public event EventHandler<OnUnlockTipEventArgs> OnUnlockTip;
    public class OnUnlockTipEventArgs
    {
        public int tipIndex;
    }
    [SerializeField] private Item bagObjectSO;

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
    }
    int textInt = 0;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnUnlockTip.Invoke(this, new OnUnlockTipEventArgs
            {
                tipIndex = textInt
            });
            textInt++;
            print("Add");
        }
    }

    public void AcquireBagObject(Item item)
    {
        bagObjectSO = item;
        OnAddedBagObject?.Invoke(this, EventArgs.Empty);
        bagObjectSO = null;
    }

    public Item GetbagObjectSO()
    {
        return bagObjectSO;
    }
}
