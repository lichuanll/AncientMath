using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRuninLevel : MonoBehaviour
{
    private float scaleValue;
    public float playerMoveSpeed;
    public Rigidbody2D rigidbody2;
    public Animator animator;

    private const string IS_WALKING = "isWalking";
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
        float vertical = Input.GetAxis("Vertical");
        float faceNum = Input.GetAxisRaw("Horizontal");
        rigidbody2.velocity = new Vector2( horizontal, vertical).normalized*playerMoveSpeed;
        if (horizontal != 0 || vertical != 0)
        {
            animator.SetBool(IS_WALKING, true);
        }
        else
        {
            animator.SetBool(IS_WALKING, false);
        }

        if (faceNum < 0)
        {
            transform.localScale = new Vector3(-scaleValue, transform.localScale.y, transform.localScale.z);
        }
        else if (faceNum > 0)
        {
            transform.localScale = new Vector3(scaleValue, transform.localScale.y, transform.localScale.z);
        }
    }
}
