using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{
    [SerializeField] private Transform[] parts;
    [SerializeField] private Vector2 speed;
    [SerializeField] private float hight;
    [SerializeField] private Vector2 randomWidth;

    private int _partsLenght;

    protected System.Action<Transform> onScrollPartRecycled;


    void Start()
    {
        onScrollPartRecycled += DoRandomWidth;

        _partsLenght = parts.Length;

        RandomScroll();
    }


    void Update()
    {
        foreach (Transform p in parts)
        {
            p.Translate(speed * Time.deltaTime);

            if (p.position.y < hight * _partsLenght / 2 * -1)
            {
                p.Translate(new Vector2(0, _partsLenght * 4));
                OnPartRecycled(p);
            }
        }
    }

    void RandomScroll()
    {
        foreach (Transform part in parts)
        {
            DoRandomWidth(part);
        }
    }

    void DoRandomWidth(Transform part)
    {
        float randomValue = Random.Range(randomWidth.x, randomWidth.y);
        part.position = new Vector2(randomValue, part.position.y);
    }
    void OnPartRecycled(Transform part)
    {
        DoRandomWidth(part);
    }
}