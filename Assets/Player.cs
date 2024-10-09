using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool spawncloud;
    public GameObject cloud;
    // Start is called before the first frame update
    void Start()
    {
        spawncloud = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawncloud) 
        {
            spawncloud = false;
            StartCoroutine(Clouds());
        }

        
    }
    IEnumerator Clouds()
    {
        Instantiate(cloud,new Vector3(-44.3f,-9.91f,-4.46f), Quaternion.identity);
        yield return new WaitForSeconds(5);
        spawncloud=true;
    }
}
