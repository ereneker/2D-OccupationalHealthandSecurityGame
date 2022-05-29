using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private SpriteRenderer flipSprite;
    public Animator characterMove;
    public float speed = 3f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    bool spriteFlipped = false;

    private void Awake()
    {
        flipSprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        PlayerMovement();
        Vector3 characterRotation = new Vector3(0, 0, 0);
        transform.eulerAngles = characterRotation;
    }

    public void PlayerMovement()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        verticalMove = Input.GetAxisRaw("Vertical") * speed;


        if (verticalMove > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
            characterMove.SetFloat("isWalking", Mathf.Abs(verticalMove));
        }
        else if (verticalMove < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            transform.position = temp;
            characterMove.SetFloat("isWalking", Mathf.Abs(verticalMove));
        }
        if (horizontalMove > 0f)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
            if (spriteFlipped == false)
            {
                return;
            }
            else
            {
                flipSprite.flipX = false;
                spriteFlipped = false;
            }
            characterMove.SetFloat("isWalking", Mathf.Abs(horizontalMove));
        }
        else if (horizontalMove < 0f)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
            if (spriteFlipped == true)
            {
                return;
            }
            else
            {
                flipSprite.flipX = true;
                spriteFlipped = true;
            }
            characterMove.SetFloat("isWalking", Mathf.Abs(horizontalMove));
        }
        if (horizontalMove == 0f && verticalMove == 0f)
        {
            characterMove.SetFloat("isWalking", Mathf.Abs(horizontalMove));
        }
    }

}
