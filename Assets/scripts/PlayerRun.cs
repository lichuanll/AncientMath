using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    private Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //水平轴
        float horizontal = Input.GetAxis("Horizontal");
        //向量
        Vector2 dir = new Vector2(horizontal,0);
        //面向向量
        //transform.rotation = Quaternion.LookRotation(dir);
        if(dir != Vector2.zero)
        {
            transform.rotation=Quaternion.LookRotation(dir);
            //播放跑步动画
            //animation.SetBool("isWalking",true);
        }
    }
}
