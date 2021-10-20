using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGenerator : MonoBehaviour
{
    [SerializeField]
    float spawnHeight;

    [SerializeField]
    float respawnHeight;

    int platNumber;

    public GameObject[] Plataformas;

    public GameObject Zonas;

    public GameObject Player;

    [SerializeField]
    float zoneHeight;

    int zoneNumber;

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
            ZonasMoveUp();
        }
        //if(Player.transform.position.y > zoneHeight)
        //{

        //}
    }

    public void PlataformGen()
    {
        Plataformas[platNumber].transform.position = new Vector3(0,spawnHeight,0);
        Plataformas[platNumber].SetActive(true);
        float random = Random.Range(0f,10f);
        spawnHeight = spawnHeight + 2.5f;
        respawnHeight = respawnHeight + 2.5f;
        platNumber++;

        if (platNumber == 10)
        {
            platNumber = 0;
        }
    }

    public void ZonasMoveUp()
    {
        Zonas.transform.position = new Vector3(0, zoneHeight, 0);
        zoneHeight = zoneHeight + 2.5f;
        zoneNumber++;
    }
}
