using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 target;
    [SerializeField] private GameObject explosion;
    // Start is called before the first frame update


    private void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == (Vector3)target)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
