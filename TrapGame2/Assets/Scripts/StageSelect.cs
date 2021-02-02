using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public GameObject Stage0Image;
    public GameObject Stage1Image;
    public int stageNumber;

    // Start is called before the first frame update
    void Start()
    {
        stageNumber = 0;
        Stage0Image.SetActive(true);
        Stage1Image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        selectStage();
        if (CrossPlatformInputManager.GetButtonDown("Start"))
        {
            if(stageNumber == 0)
            {
                //Scene activeScene = SceneManager.GetActiveScene();
                SceneManager.LoadSceneAsync(1);
            }
            if(stageNumber == 1)
            {
                //Scene activeScene = SceneManager.GetActiveScene();
                SceneManager.LoadSceneAsync(2);
            }
            
        }
    }

    void selectStage()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire2_1"))
        {
            if(stageNumber == 0)
            {
                stageNumber = 1;
                Stage0Image.SetActive(false);
                Stage1Image.SetActive(true);
            }
            else
            {
                stageNumber = 0;
                Stage0Image.SetActive(true);
                Stage1Image.SetActive(false);
            }
        }
        if (CrossPlatformInputManager.GetButtonDown("Fire3_1"))
        {
            if (stageNumber == 0)
            {
                stageNumber = 1;
                Stage0Image.SetActive(false);
                Stage1Image.SetActive(true);
            }
            else
            {
                stageNumber = 0;
                Stage0Image.SetActive(true);
                Stage1Image.SetActive(false);
            }
        }
    }
}
