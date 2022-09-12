using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    GameObject[] homes;

    Transform lives;
    // Start is called before the first frame update
    void Start()
    {
        homes = GameObject.FindGameObjectsWithTag("Homes");
        lives = homes[Random.Range(0, homes.Length)].transform;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);
    }

 //   public void OnCollisionEnter2D(Collision2D collision)
 //   {
    //    {

        //    if (collision.gameObject.tag == "Homes")
         //   {
        //        Destroy(gameObject);
      //      }
      //  }
  //  }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, lives.position, speed * Time.deltaTime);
    }
}
