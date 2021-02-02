using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayers : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public RuntimeAnimatorController samuraiAnim;
    public RuntimeAnimatorController femChefAnim;
    public RuntimeAnimatorController maleChefAnim;
    public RuntimeAnimatorController caveManAnim;
    public RuntimeAnimatorController femSciAnim;
    public RuntimeAnimatorController maleSciAnim;

    public Sprite samuraiSpr;
    public Sprite femChefSpr;
    public Sprite maleChefSpr;
    public Sprite caveManSpr;
    public Sprite femSciSpr;
    public Sprite maleSciSpr;

    public GameObject samuraiPro;
    public GameObject chefPro;
    public GameObject cavemanPro;
    public GameObject femSciPro;
    public GameObject maleSciPro;

    // Start is called before the first frame update
    void Start()
    {

        if(staticInfo.GetP1Active())
        {
            player1.SetActive(true);
            CharacterChoice(player1, staticInfo.GetP1Character());
        }
        else
        {
            player1.SetActive(false);
        }
        if (staticInfo.GetP2Active())
        {
            player2.SetActive(true);
            CharacterChoice(player2, staticInfo.GetP2Character());
        }
        else
        {
            player2.SetActive(false);
        }
        if (staticInfo.GetP3Active())
        {
            player3.SetActive(true);
            CharacterChoice(player3, staticInfo.GetP3Character());
        }
        else
        {
            player3.SetActive(false);
        }
        if (staticInfo.GetP4Active())
        {
            player4.SetActive(true);
            CharacterChoice(player4, staticInfo.GetP4Character());
        }
        else
        {
            player4.SetActive(false);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CharacterChoice(GameObject player, int selectedChar)
    {
        if (selectedChar == 0)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = caveManAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = caveManSpr;
            player.GetComponent<Player>().projectilePrefab = cavemanPro;
        }
        if (selectedChar == 1)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = maleSciAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = maleSciSpr;
            player.GetComponent<Player>().projectilePrefab = maleSciPro;
        }
        if (selectedChar == 2)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = femSciAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = femSciSpr;
            player.GetComponent<Player>().projectilePrefab = femSciPro;
        }
        if (selectedChar == 3)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = samuraiAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = samuraiSpr;
            player.GetComponent<Player>().projectilePrefab = samuraiPro;
        }
        if (selectedChar == 4)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = maleChefAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = maleChefSpr;
            player.GetComponent<Player>().projectilePrefab = chefPro;
        }
        if (selectedChar == 5)
        {
            player.GetComponent<Player>().GetComponent<Animator>().runtimeAnimatorController = femChefAnim;
            player.GetComponent<Player>().GetComponent<SpriteRenderer>().sprite = femChefSpr;
            player.GetComponent<Player>().projectilePrefab = chefPro;
        }
    }
}
