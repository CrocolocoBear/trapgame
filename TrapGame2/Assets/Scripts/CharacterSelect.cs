using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    bool hasJoinedP1 = false;
    bool hasJoinedP2 = false;
    bool hasJoinedP3 = false;
    bool hasJoinedP4 = false;

    int P1Character = 1;
    int P2Character = 2;
    int P3Character = 3;
    int P4Character = 4;

    public GameObject P1CharImage;
    public GameObject P2CharImage;
    public GameObject P3CharImage;
    public GameObject P4CharImage;

    public Sprite CaveMan;
    public Sprite ScienceMan;
    public Sprite ScienceWoman;
    public Sprite Samurai;
    public Sprite ChefMan;
    public Sprite ChefWoman;

    public GameObject CharSelect;
    public GameObject StageSelect;

    // Start is called before the first frame update
    void Start()
    {
        P1CharImage = GameObject.Find("P1CharImage");
        P2CharImage = GameObject.Find("P2CharImage");
        P3CharImage = GameObject.Find("P3CharImage");
        P4CharImage = GameObject.Find("P4CharImage");
    }

    // Update is called once per frame
    void Update()
    {
        joiningGame();
        chooseCharacter();
        if (CrossPlatformInputManager.GetButtonDown("Start"))
        {
            
            staticInfo.SetP1Character(P1Character);
            staticInfo.SetP2Character(P2Character);
            staticInfo.SetP3Character(P3Character);
            staticInfo.SetP4Character(P4Character);
            staticInfo.SetP1Active(hasJoinedP1);
            staticInfo.SetP2Active(hasJoinedP2);
            staticInfo.SetP3Active(hasJoinedP3);
            staticInfo.SetP4Active(hasJoinedP4);

            StageSelect.SetActive(true);
            CharSelect.SetActive(false);
        }
    }

    void joiningGame()
    {
            if (CrossPlatformInputManager.GetButtonDown("JumpPlayer1"))
            {
            hasJoinedP1 = true;
            CharacterImage(P1CharImage, 0);
        }


            if (CrossPlatformInputManager.GetButtonDown("JumpPlayer2"))
            {
                hasJoinedP2 = true;
            CharacterImage(P2CharImage, 1);
        }


            if (CrossPlatformInputManager.GetButtonDown("JumpPlayer3"))
            {
                hasJoinedP3 = true;
            CharacterImage(P3CharImage, 2);
        }

            if (CrossPlatformInputManager.GetButtonDown("JumpPlayer4"))
            {
                hasJoinedP4 = true;
            CharacterImage(P4CharImage, 3);
        }
    }

    void chooseCharacter()
    {
        if (hasJoinedP1)
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_1"))
            {
                if (P1Character > 0)
                {
                    P1Character--;
                }
                else
                {
                    P1Character = 5;
                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Fire3_1"))
            {
                if (P1Character < 5)
                {
                    P1Character++;
                }
                else
                {
                    P1Character = 0;
                }
            }
            CharacterImage(P1CharImage, P1Character);
        }

        if (hasJoinedP2)
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_2"))
            {
                if (P2Character > 0)
                {
                    P2Character--;
                }
                else
                {
                    P2Character = 5;
                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Fire3_2"))
            {
                if (P2Character < 5)
                {
                    P2Character++;
                }
                else
                {
                    P2Character = 0;
                }
            }
            CharacterImage(P2CharImage, P2Character);
        }

        if (hasJoinedP3)
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_3"))
            {
                if (P3Character > 0)
                {
                    P3Character--;
                }
                else
                {
                    P3Character = 5;
                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Fire3_3"))
            {
                if (P3Character < 5)
                {
                    P3Character++;
                }
                else
                {
                    P3Character = 0;
                }
            }
            CharacterImage(P3CharImage, P3Character);
        }

        if (hasJoinedP4)
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_4"))
            {
                if (P4Character > 0)
                {
                    P4Character--;
                }
                else
                {
                    P4Character = 5;
                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Fire3_4"))
            {
                if (P4Character < 5)
                {
                    P4Character++;
                }
                else
                {
                    P4Character = 0;
                }
            }
            CharacterImage(P4CharImage, P4Character);
        }
    }

    void CharacterImage(GameObject pImage, int pChoice)
    {
        if(pChoice == 0)
        {
            pImage.GetComponent<Image>().sprite = ScienceMan;
        }
        if (pChoice == 1)
        {
            pImage.GetComponent<Image>().sprite = ScienceWoman;
        }
        if (pChoice == 2)
        {
            pImage.GetComponent<Image>().sprite = CaveMan;
        }
        if (pChoice == 3)
        {
            pImage.GetComponent<Image>().sprite = Samurai;
        }
        if (pChoice == 4)
        {
            pImage.GetComponent<Image>().sprite = ChefMan;
        }
        if (pChoice == 5)
        {
            pImage.GetComponent<Image>().sprite = ChefWoman;
        }
    }
}
