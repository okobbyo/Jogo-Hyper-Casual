using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMove : MonoBehaviour
{
    private Rigidbody2D PlataformRG;
    public bool PlataformDirection = true;
    private PlataformMove PParede;

    [SerializeField]
    float PlataformSpeed;

    void Start()
    {
        PlataformRG = gameObject.GetComponent<Rigidbody2D>();
        PParede = GameObject.FindGameObjectWithTag("Plataform").GetComponent<PlataformMove>();
        PlataformMoveHorizontal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlataformMoveHorizontal()
    {
        if (PlataformDirection == true)
        {
            PlataformRG.velocity = new Vector2(PlataformSpeed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Parede")
        {
            PParede.PlataformDirection = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Parede")
        {
            PParede.PlataformDirection = false;
        }
    }
}