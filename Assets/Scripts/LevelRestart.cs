using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//sahneyi tekrar yüklemek için buna ihtiyac duyduk
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
