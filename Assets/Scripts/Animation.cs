using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator jump , firstT;
    
    private bool isJump;
    private bool isFirstT;
    
    
    

    private void Awake() {
        jump = GetComponent<Animator>();
        firstT = GetComponent<Animator>();
        jump.SetBool("jump" , isJump);
        firstT.SetBool("firstT" , isFirstT);
        
        
    }
    
    IEnumerator Bekle(){
        yield return new WaitForSeconds(5);
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            isJump = true;
            isFirstT = true;
            Bekle();
            
        }
        else{
            isJump = false;
            isFirstT = false;
        }
        


    
    }
    
}
