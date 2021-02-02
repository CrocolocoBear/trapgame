using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBook : StateMachineBehaviour
{
    public void OpenBook()
    {
        SceneManager.LoadScene("OpenBookMenu");
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
}
