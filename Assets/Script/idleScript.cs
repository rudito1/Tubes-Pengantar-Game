using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleScript : MonoBehaviour
{

    public float speed;
    public float jump;

    Vector3 jalan;
    // Start is called before the first frame update

    private int jumpcount;
    private int jumpvalue = 2;
    public bool isGrounded;

    public Animator anime;

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isGrounded)
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        jalan.x = Input.GetAxisRaw("Horizontal");
        transform.position += jalan * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.UpArrow)&& jumpcount > 0)
        {
            lompat();
            anime.SetBool("lompat", true);
            if (jumpcount == 1)
            {
                anime.SetBool("hlompat", true);
            }
        }

        if (isGrounded)
        {
            jumpcount = jumpvalue;
            anime.SetBool("lompat", false);
            anime.SetBool("hlompat", false);
        }

        if (jalan != Vector3.zero)
        {
            anime.SetBool("lari", true);
        }
        else
        {
            anime.SetBool("lari", false);
        }

        if (jalan == Vector3.left)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if(jalan == Vector3.right)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }
    private void lompat()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jump;
        isGrounded = false;
        jumpcount--;
    }
}
