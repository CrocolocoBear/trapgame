using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    [SerializeField] public float projectileSpeed = 50f;
    [SerializeField] private float destroyTime = 0.75f; // Time in Seconds

    Rigidbody2D myRigidBody;
    Collider2D myCollider2D;
    public GameObject spriteChild;
    int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider2D = GetComponent<Collider2D>();
        myRigidBody.velocity = transform.forward * projectileSpeed*10;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        myRigidBody.velocity = transform.forward * projectileSpeed*5;
        spriteChild.transform.rotation = Quaternion.Euler(0, 0, -15 * timer);
        WaitToDestroy();
    }

    private void WaitToDestroy()
    {
        Destroy(gameObject, destroyTime);
    }
}



