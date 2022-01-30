using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    public GameObject player1, player2;
    SpriteRenderer spriteRenderer1, spriteRenderer2;
    BoxCollider2D boxCollider1, boxCollider2;
    bool isSmall;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer1 = player1.GetComponent<SpriteRenderer>();
        spriteRenderer2 = player2.GetComponent<SpriteRenderer>();
        boxCollider1 = player1.GetComponent<BoxCollider2D>();
        boxCollider2 = player2.GetComponent<BoxCollider2D>();
        BigPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangePlayer();
        }
    }
    void ChangePlayer()
    {
        if (!isSmall)
        {
            SmallPlayer();
            isSmall = true;
        }
        else
        {
            BigPlayer();
            isSmall = false;
        }
      
    }
    void BigPlayer()
    {
        player2.transform.position = player1.transform.position;
        spriteRenderer1.enabled=false;
        boxCollider1.enabled = false;
        spriteRenderer2.enabled = true;
        boxCollider2.enabled = true;


    }
    void SmallPlayer()
    {
        player1.transform.position = player2.transform.position;
        spriteRenderer1.enabled = true;
        boxCollider1.enabled = true;
        spriteRenderer2.enabled = false;
        boxCollider2.enabled = false;
    }
}
