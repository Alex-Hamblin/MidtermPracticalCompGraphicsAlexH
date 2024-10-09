using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool spawncloud;
    GameObject cloud;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Instantiate(cloud, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
        spawncloud=true;
    }
}
