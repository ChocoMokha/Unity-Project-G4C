using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody enemyRb;
    public Transform player;
    public int health = 5;
    public bool Win = false;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if(health <= 0)
        {
            Win = true;
        }
        if(Win == true)
        {
           SceneManager.LoadScene(3);
        }

        Vector3 lookDirection = (player.position - transform.position).normalized;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(player.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            health -= 1;
        }
        
    }
}
