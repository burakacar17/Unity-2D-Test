using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumpForce = 500f;
    private bool grounded;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private bool started;
    private bool jumping;



    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); //caching
        animator = GetComponent<Animator>();
        grounded = true;

    }

    //Update methodunda oyunun ba�lay�p ba�lamad���n� kontrol edicez
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (started && grounded)
            {
                animator.SetTrigger("jump");
                grounded = false;
                jumping = true;
            }
            else
            {
                animator.SetBool("GameStarted", true);
                started = true;
            }
        }

        
        
          animator.SetBool("grounded", grounded);
        
    }
    //bu methodta rigidbodyy kullanarak h�z veriyoruz karaktere
    private void FixedUpdate()
    {
        if (started)
        {
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
        }

        if (jumping)
        {
            rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            jumping = false;
        }
    }

    //bu fonksiyon sayesinde e�er bir yere �arp�yosak
    //z�plamadan sonra runa d�n�p tekrar z�playabiliriz
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
}
