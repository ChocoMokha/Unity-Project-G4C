using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
public float horizontalInput;
public float speed = 10.0f;
public float turnSpeed = 20.0f;
public int health = 10;
public bool gameOver = false;
public bool Win = false;

    void Update()
    {
        if(gameOver == true)
        {
           SceneManager.LoadScene(0);
        }
        if(Win == true)
        {
           SceneManager.LoadScene(3);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if(health <= 0)
        {
            gameOver = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")){
            health -= 1;
        }
         if (collision.gameObject.CompareTag("Island")){
            Win = true;
        }
    }
    
       
  
    
    
}
