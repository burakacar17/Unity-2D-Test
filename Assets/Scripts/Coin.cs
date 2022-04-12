using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip clickSound;
    int count = 0;

    

    private void Update()
    {
        
    }

    // bu fonk sayesinde karakterimiz tagýný belirtiðimiz objeye çarpýtýðýmýzda o obje silidi.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count++;
            //çarptýðým pozisyonda clibi çal.Clibi scribe untiyden ekledik
            AudioSource.PlayClipAtPoint(clickSound, collision.transform.position);
            Destroy(collision.gameObject);
        }
    }
}
