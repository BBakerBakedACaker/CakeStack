using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeSpawner : MonoBehaviour
{
    public GameObject cake;
    private Vector3 newSpawnPoint;

    public int cakeCount;

    public int offset = 10;

    // Start is called before the first frame update
    void Start()
    {
        newSpawnPoint = transform.position;
        Instantiate(cake, transform.position, transform.rotation);
        newSpawnPoint += (Vector3.up / offset);
        Debug.Log(newSpawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began) 
            {
                Instantiate(cake, newSpawnPoint, transform.rotation);
                cakeCount = GameObject.FindGameObjectsWithTag("Cake").Length;
                newSpawnPoint += (Vector3.up / offset);
                Debug.Log(newSpawnPoint);
            }
        }
    }
}
