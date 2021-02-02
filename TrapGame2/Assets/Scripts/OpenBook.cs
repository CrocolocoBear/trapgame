using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BookClosed;
    public GameObject BookOpen;
    public GameObject CharacterSelect;

    public void ChangeBook()
    {
        StartCoroutine(Delay(0.5f));
    }

    public IEnumerator Delay(float cd)
    {
        yield return new WaitForSeconds(cd);
        BookClosed.SetActive(false);
        BookOpen.SetActive(true);
        CharacterSelect.SetActive(true);
    }

}
