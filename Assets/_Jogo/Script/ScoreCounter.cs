using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int scoreValue;

    private bool doublePickedUp;

    void Start()
    {
        doublePickedUp = false;
    }


    private void Update()
    {
        scoreText.text = "score: " + scoreValue;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Double"))
        {
            doublePickedUp = true;
            collision.gameObject.SetActive(false);
            StartCoroutine(TempDouble());
        }
        if (collision.name.Equals("Point") && !doublePickedUp)
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
        }
        if (collision.name.Equals("Point") && doublePickedUp)
        {
            collision.gameObject.SetActive(false);
            scoreValue += 2;
        }
    }
    IEnumerator TempDouble()
    {
        yield return new WaitForSeconds(5);
        Start();
    }
}
