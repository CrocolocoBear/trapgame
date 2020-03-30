using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{

    BoxCollider2D myBoxCollider2D;
    private Player player1;
    private Player player2;
    
    // Start is called before the first frame update
    void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        player1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Player>();
        player2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") || collision.CompareTag("Player2"))
        {
            StartCoroutine(RestartGame(3));
        }
    }

    public IEnumerator RestartGame(float duration)
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        yield return new WaitForSeconds(duration);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadSceneAsync(0);
    }
}
