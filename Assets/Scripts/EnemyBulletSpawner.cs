using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyMissle;
    [SerializeField] private float Yseperation = 0.5f;

    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).x;
        maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;


        InvokeRepeating("CreateMissle", 0f, 1f);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void CreateMissle()
    {
        float randomX = Random.Range(minX, maxX);
        float yValue = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Instantiate(enemyMissle, new Vector3(randomX, yValue + Yseperation, 0), Quaternion.identity);
    }
}
