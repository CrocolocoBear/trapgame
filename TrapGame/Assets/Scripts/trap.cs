using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{

    Rigidbody2D myRigidBody;
    BoxCollider2D myBoxCollider2D;
    CapsuleCollider2D myCapsuleCollider2D;
    Animator myAnimator;
    private Player player1;
    private Player player2;
    bool hasTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCapsuleCollider2D = GetComponent<CapsuleCollider2D>();
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        myAnimator = GetComponent<Animator>();
        
        player1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Player>();
        player2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Player>();
        StartCoroutine(TrapDelay(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TrapDelay(float duration)
    {
        myCapsuleCollider2D.isTrigger = false;
        yield return new WaitForSeconds(duration);
        myCapsuleCollider2D.isTrigger = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasTriggered == false)
        {
            hasTriggered = true;
            if (collision.CompareTag("Player1"))
            {
                StartCoroutine(player1.Stun(2));
            }
            if (collision.CompareTag("Player2"))
            {
                StartCoroutine(player2.Stun(2));
            }

            myAnimator.SetBool("trap_activated", true);

            Destroy(gameObject, 2.5f);
        }
    }
}
