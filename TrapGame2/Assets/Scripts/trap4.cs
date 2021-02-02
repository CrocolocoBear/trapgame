using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap4 : MonoBehaviour
{
    //mummy trap

    Rigidbody2D myRigidBody;
    BoxCollider2D myBoxCollider2D;
    CapsuleCollider2D myCapsuleCollider2D;
    Animator myAnimator;
    GameObject player1;
    GameObject player2;
    GameObject player3;
    GameObject player4;
    private AudioSource source;
    bool hasTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCapsuleCollider2D = GetComponent<CapsuleCollider2D>();
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        myAnimator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        StartCoroutine(TrapDelay(2f));
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");


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
            source.Play();
            hasTriggered = true;
            if (collision.CompareTag("Player1"))
            {
                StartCoroutine(GameObject.FindGameObjectWithTag("Player1").GetComponent<Player>().Stun(2));
            }
            if (collision.CompareTag("Player2"))
            {
                StartCoroutine((GameObject.FindGameObjectWithTag("Player2").GetComponent<Player>().Stun(2)));
            }
            if (collision.CompareTag("Player3"))
            {
                StartCoroutine((GameObject.FindGameObjectWithTag("Player3").GetComponent<Player>().Stun(2)));
            }
            if (collision.CompareTag("Player4"))
            {
                StartCoroutine((GameObject.FindGameObjectWithTag("Player4").GetComponent<Player>().Stun(2)));
            }

            myAnimator.SetBool("trap_activated", true);

            Destroy(gameObject, 2.5f);
        }
    }
}
