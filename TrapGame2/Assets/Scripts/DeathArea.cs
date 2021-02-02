using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{

    BoxCollider2D myBoxCollider2D;
    bool p1Dead = false;
    bool p2Dead = false;
    bool p3Dead = false;
    bool p4Dead = false;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    // Start is called before the first frame update
    void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        StartCoroutine(Delay(1));

    }

    // Update is called once per frame
    void Update()
    {
        if(p1Dead && p2Dead && p3Dead && p4Dead)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            p1Dead = true;
        }
        if (collision.CompareTag("Player2"))
        {
            p2Dead = true;
        }
        if (collision.CompareTag("Player3"))
        {
            p3Dead = true;
        }
        if (collision.CompareTag("Player4"))
        {
            p4Dead = true;
        }
    }

    public IEnumerator Delay(float duration)
    {
        yield return new WaitForSeconds(duration);
        if (player1.activeInHierarchy != true)
        {
            p1Dead = true;
        }
        if (player2.activeInHierarchy != true)
        {
            p2Dead = true;
        }
        if (player3.activeInHierarchy != true)
        {
            p3Dead = true;
        }
        if (player4.activeInHierarchy != true)
        {
            p4Dead = true;
        }
    }

}
