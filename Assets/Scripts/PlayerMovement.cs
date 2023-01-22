using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using willbeusingthat;
namespace PlayerMovement{
public class PlayerMovement : MonoBehaviour
{
    private Vector3 direction;
    
    
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    [SerializeField] private float jumpPower = 5f;
    [SerializeField] private float gravity = -9.8f; /*I set gravity as -9.8 becasue as we know real g is approximately -9,8 the minus 
    refers to direction not a value. Because gravity is a vectorel quantity.*/
    private bool stableBool = false;
    
    
    private void Awake() {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();        
        
    }

    
    private void Update() {
        
        if(stableBool == true){


        if(Input.GetKeyDown(KeyCode.Space)){
            direction = Vector3.up * jumpPower;

        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        if(transform.position.y <= -2.90 || transform.position.y >= 4.75){
            FindObjectOfType<GameManager>().GameOver();
        }
        }

        else{
            if(Input.GetKeyDown(KeyCode.Space)){
            direction = Vector3.up * jumpPower;

        }
        direction.y += 0 * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        if(transform.position.y <= -2.90 || transform.position.y >= 4.75){
            FindObjectOfType<GameManager>().GameOver();
          }
        if(Input.GetKeyDown(KeyCode.Space)){
            stableBool = true;

        }
        }



        }
        
    
    
    }

    
    
        

        

}

