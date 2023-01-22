using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using willbeusingthat;
using PlayerMovement;

public class PlayerCollision : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Over")
        {
            FindObjectOfType<GameManager>().GameOver();
            

        }
        else if(other.gameObject.tag == "Score"){
            FindObjectOfType<GameManager>().Score();
        }
    }
}
