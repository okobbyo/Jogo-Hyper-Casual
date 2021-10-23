using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    public GameObject GameOver;
    public GameObject Move;
    public GameObject Pause;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameOver.SetActive(true);
            Move.SetActive(false);
            Pause.SetActive(false);
            Time.timeScale = 0f;

        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
