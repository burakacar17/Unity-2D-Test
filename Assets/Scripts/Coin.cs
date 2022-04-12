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

    // bu fonk sayesinde karakterimiz tag�n� belirti�imiz objeye �arp�t���m�zda o obje silidi.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count++;
            //�arpt���m pozisyonda clibi �al.Clibi scribe untiyden ekledik
            AudioSource.PlayClipAtPoint(clickSound, collision.transform.position);
            Destroy(collision.gameObject);
        }
    }
}
