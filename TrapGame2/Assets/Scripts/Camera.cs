using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float step = 0.005f;
    Camera mainCamera;
    bool movementCD = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        var cameraPosition = mainCamera.gameObject.transform.position;
        if (movementCD == false)
        {
            step = RandomMovement(0.003f, 0.02f);
            
        }
        cameraPosition.y += step;
        if (cameraPosition.y < 200)
        {
            mainCamera.gameObject.transform.position = cameraPosition;
        }
    }
    public float RandomMovement(float min, float max)
    {
        movementCD = true;
        Random randomFloat = new Random();
        StartCoroutine(Cooldown(10f));
        return Random.Range(min, max);
    }

    public IEnumerator Cooldown(float cd)
    {
        yield return new WaitForSeconds(cd);
        movementCD = false;
    }
}
