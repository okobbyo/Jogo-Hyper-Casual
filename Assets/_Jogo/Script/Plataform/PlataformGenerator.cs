using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGenerator : MonoBehaviour
{
    private PlataformMove pm;
    private PlataformSome ps;

    [SerializeField]
    float spawnHeight;

    [SerializeField]
    float respawnHeight;

    int platNumber;

    public GameObject[] Plataformas;

    public GameObject Player;

    private void Awake()
    {

    }

    void Start()
    {
        
    }


    void Update()
    {
        if (Player.transform.position.y > respawnHeight)
        {
            PlataformGen();
        }
    }

    public void PlataformGen()
    {
        Plataformas[platNumber].transform.position = new Vector3(0,spawnHeight,0);
        Plataformas[platNumber].SetActive(true);
        float random = Random.Range(0f,10f);
        //if (random > 4)
        //{
        //    Plataformas[platNumber].GetComponent<PlataformSome>().enabled = true;
        //    Plataformas[platNumber].GetComponent<PlataformMove>().enabled = false;
        //}
        //else
        //{
        //    Plataformas[platNumber].GetComponent<PlataformSome>().enabled = false;
        //    Plataformas[platNumber].GetComponent<PlataformMove>().enabled = true;
        //}
        spawnHeight = spawnHeight + 2.5f;
        respawnHeight = respawnHeight + 2.5f;
        platNumber++;

        if (platNumber == 10)
        {
            platNumber = 0;
        }
    }
}
