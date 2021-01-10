using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] objectPrefabs;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("GenerateObjects", 1.5f, 1.5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GenerateObjects()
    {
        int len = objectPrefabs.Length;
        int index = Random.Range(0, len);
        float xLoc = Random.Range(-5f, 5f);
        float zLoc = Random.Range(5f, 15f);
        Vector3 newPos = new Vector3(xLoc, 0, zLoc);
        Instantiate(objectPrefabs[index], newPos, objectPrefabs[index].transform.rotation);
    }
}
