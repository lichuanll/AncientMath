using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Bag/Item")]
public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public Sprite Ico;
    public string name;
    [TextArea] public string Intro;
}
