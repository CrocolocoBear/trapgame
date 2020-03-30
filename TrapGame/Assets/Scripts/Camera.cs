using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float step = 0.005f;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPosition = mainCamera.gameObject.transform.position;
        cameraPosition.y += step;
        if (cameraPosition.y < 20)
        {
            mainCamera.gameObject.transform.position = cameraPosition;
        }
    }
}
