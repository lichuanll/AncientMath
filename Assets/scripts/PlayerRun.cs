using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    public float scaleValue ;
    public float playerMoveSpeed;
    public Rigidbody2D rigidbody2;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        scaleValue = this.transform.localScale.x;
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMove();
    }

    void PlayerMove()
    {
        //Ë®Æ½Öá
        float horizontal = Input.GetAxis("Horizontal");
        float faceNum = Input.GetAxisRaw("Horizontal");
        rigidbody2.velocity=new Vector2(playerMoveSpeed*horizontal,rigidbody2.velocity.y);
        if(horizontal !=0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if(faceNum < 0 )
        {
            transform.localScale = new Vector3(-scaleValue, transform.localScale.y, transform.localScale.z);
        }
        else if (faceNum > 0)
        {
            transform.localScale = new Vector3(scaleValue, transform.localScale.y, transform.localScale.z);
        }
    }
}
