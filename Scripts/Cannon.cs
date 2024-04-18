using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject projectilePrefab;
    public double fireRate = 0.5;
    public double nextFire = 0;
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
        
             Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}