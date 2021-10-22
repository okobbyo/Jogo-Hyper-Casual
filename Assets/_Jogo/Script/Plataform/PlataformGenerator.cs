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

    public GameObject[] PointObj;


    [SerializeField]
    float zoneHeight;

    [SerializeField]
    float poinSpawntheight;

    [SerializeField]
    float poinReSpawntheight;

    int pointNumber;


    void Update()
    {
        if (Player.transform.position.y > respawnHeight)
        {
            PlataformGen();
            ZonasMoveUp();
            points();
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
    }

    public void points()
    {
        PointObj[pointNumber].transform.position = new Vector3(0, poinSpawntheight, 0);
        PointObj[pointNumber].SetActive(true);
        float PRandom = Random.Range(0f, 10f);
        poinSpawntheight = poinSpawntheight + 2.5f;
        poinReSpawntheight = poinReSpawntheight + 2.5f;
        pointNumber++;

        if(pointNumber == 10)
        {
            pointNumber = 0;
        }
    }
}
