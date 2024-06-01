using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Transform[] childs;
    void Start()
    {
        childs = new Transform[transform.childCount];
        //遍历子物体并存储下来
        for (int i = 0; i < transform.childCount; i++)
        {
            childs[i] = transform.GetChild(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0;i < childs.Length;i++)
        {
            // 获取当前的欧拉角度
            Vector3 childEulerAngles = childs[i].rotation.eulerAngles;
            if(childEulerAngles.y!=0)
            {
                childEulerAngles.x = 45;
            }
            else
            {
                childEulerAngles.x = -45;
            }
            // 应用新的旋转
            childs[i].rotation = Quaternion.Euler(childEulerAngles);
        }
    }
}
