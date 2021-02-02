using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneratorForest : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformHeight;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    //public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformHeights;



    public ObjectPooler[] theObjectPools;

    private float minWidth;
    public Transform maxWidthPoint;
    public Transform minWidthPoint;
    private float maxWidth;
    public float maxWidthChange;
    private float widthChange;

    // Start is called before the first frame update
    void Start()
    {
        //platformHeight = thePlatform.GetComponent<CapsuleCollider2D>().size.y;

        platformHeights = new float[theObjectPools.Length];

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformHeights[i] = theObjectPools[i].pooledObject.GetComponent<CapsuleCollider2D>().size.y;

        }

        minWidth = minWidthPoint.position.x;
        maxWidth = maxWidthPoint.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < generationPoint.position.y)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);

            widthChange = transform.position.x + Random.Range(maxWidthChange, -maxWidthChange);

            if (widthChange > maxWidth)
            {
                widthChange = maxWidth;
            }else if (widthChange < minWidth)
            {
                widthChange = minWidth;
            }

            transform.position = new Vector3(widthChange , transform.position.y + (platformHeights[platformSelector] / 2) + distanceBetween, transform.position.z);

            

            //Instantiate(/*thePlatform*/thePlatforms[platformSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            transform.position = new Vector3(transform.position.x, transform.position.y + (platformHeights[platformSelector] / 2), transform.position.z);
        }
    }
}
