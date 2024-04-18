using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject projectilePrefab;
    public double fireRate = 0.5;
    public double nextFire = 0;
    public int speed = 10;

    void Update()
    {
        if(Time.time > nextFire){
        nextFire = Time.time + fireRate;
 
        Instantiate(projectilePrefab, transform.position, transform.rotation);
 

            
        }
    }
}