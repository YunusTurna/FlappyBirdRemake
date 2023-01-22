using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    private float leftEdge = 0f;
    
    

    
  
    
    
    void Start()
    {
        leftEdge = -13f;
        
        
    }

    
    void Update()
    {
        
        
            transform.position += Vector3.left * Time.deltaTime * speed;

            if(transform.position.x < leftEdge)
            {
             Destroy(gameObject);
        
            }
        
        
        
        
        
    }
}
